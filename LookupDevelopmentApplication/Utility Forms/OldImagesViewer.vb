Imports System.Drawing
Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ImagesInterface.MultiMedia

Public Class OldImagesViewer


    Private m_sImageSubject As String
    Private m_sImageLocation As String
    Private m_lImageGroup As Integer = 0
    Private m_ImagePath As String = String.Empty
    Private DANO As String = String.Empty

    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANO = value
        End Set
    End Property


    Private Sub GetImageSubject(ByVal sImageName As String)
        Dim Returnvalue As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetImageSubject routine - form " & Me.Name)
            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Images_OldSystemImageMetaData"

                        .Parameters.Add("@LOCATE", SqlDbType.VarChar).Value = sImageName
                    End With

                    Dim objDT As New CZONES.ImageDataDataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim objRow As DataRow = objDT.Rows(0)

                    txtDate.Text = Format(CDate(objRow.Item("DateTaken")), "dd/MM/yyyy")
                    txtSubject.Text = objRow.Item("Officer").ToString
                    txtDescription.Text = objRow.Item("COMMENT").ToString

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetImageSubject routine - form " & Me.Name)

            End Try
        End Using




    End Sub


    Private Sub imgCurrent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgCurrent.DoubleClick
        Dim x As Integer
        If m_ImagePath <> String.Empty Then
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & m_ImagePath)
        End If

    End Sub

    Public Sub RetrieveImagesForDisplay(ByVal groupimageID As Integer)
        '---------------------------------------------------------------------------------------
        ' Procedure : RetrieveImagesForDisplay
        ' DateTime  : 14/12/2005 16:33
        ' Author    : rocallag
        ' Purpose   :
        '---------------------------------------------------------------------------------------
        '

        Dim sImageLocation As String
        'Dim sFileName As String
        'Dim sImageNumber As String
        Dim objDT As New DataTable

        Me.FilmStripControl.RemoveAllPictures()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveImagesForDisplay routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ImagesRetrieveOldSystem"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANO
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using
                 
                Dim RowCount As Integer = objDT.Rows.Count
                If RowCount > 0 Then
                    Dim objDataRow As DataRow
                    Me.txtSubject.Text = ""
                    'iMageList.Images.Clear()
                    'lv.Items.Clear()
                    'im.Visible = False
                    For Each objDataRow In objDT.Rows
                        'sFileName = objDataRow.Item("ImageFileName").ToString
                        'sImageNumber = objDataRow.Item("Id").ToString
                        '   Uncomment the following when moving to the new rec server to allow for archiving
                        sImageLocation = objDataRow.Item("PathToDocument").ToString
                        Me.FilmStripControl.AddPicture(sImageLocation)
                        'addMe(sImageLocation)

                    Next

                End If



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveImagesForDisplay routine - form " & Me.Name)

            End Try
        End Using


    End Sub


    Private Sub displayImage(ByVal ImagePath As String)
        Dim lHeight As Integer
        Dim lWidth As Integer
        Dim dRatio As Double

        With imgCurrent
            .Visible = False
            .SizeMode = PictureBoxSizeMode.AutoSize
            .Image = Image.FromFile(ImagePath)
            .Refresh()
            lHeight = .Height
            lWidth = .Width

            If lHeight > lWidth Then
                dRatio = lHeight / lWidth
                .Width = CInt(471 / dRatio)
                .Height = 471
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Location = New Point(229, 3)
            Else
                dRatio = lWidth / lHeight
                .Height = CInt((503 / dRatio))
                .Width = (503)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                .Location = New Point(135, 88)
            End If



            .Visible = True

        End With

    End Sub



    Private Sub FilmStripControl_OnImageClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilmStripControl.OnImageClicked
        displayImage(CType(sender, String))
        GetImageSubject(CType(sender, String))

        m_ImagePath = CType(sender, String)
    End Sub

    Private Sub MultimediaInterface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FilmStripControl.RemoveAllPictures()

        RetrieveImagesForDisplay(m_lImageGroup)
    End Sub

End Class