
Imports System.Drawing
Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ImagesInterface.MultiMedia


Public Class MultimediaInterface

    Private m_sImageSubject As String
    Private m_sImageLocation As String
    Private m_lImageGroup As Integer = 0
    Private m_ImagePath As String = String.Empty
    Private DANO As String = String.Empty

    Private mydocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Printimages\"





    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANO = value
        End Set
    End Property


    Public Property ImageGroupID() As Integer
        Get
            Return m_lImageGroup
        End Get
        Set(ByVal value As Integer)
            m_lImageGroup = value
        End Set
    End Property



    Public Function ImageFolderHash(ByVal sImageNumber As String) As Integer
        Dim lFilenumber As Integer
        'lFilenumber = Left(sImageNumber, InStr(sImageNumber, ".") - 1)
        lFilenumber = CInt(sImageNumber.Substring(0, sImageNumber.IndexOf(".")))
        'lFilenumber = CInt(sImageNumber.Substring(InStr(sImageNumber, ".") - 1))
        ImageFolderHash = lFilenumber \ 5000
    End Function

    Private Sub InitializeOpenFileDialog()
        Me.cd = New System.Windows.Forms.OpenFileDialog

        ' Set the file dialog to filter for graphics files.
        Me.cd.Filter = _
        "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"

        ' Allow the user to select multiple images.
        Me.cd.Multiselect = True
        Me.cd.Title = "Image Browser"
    End Sub
    Private Sub fileButton_Click(ByVal sender As System.Object, _
         ByVal e As System.EventArgs) Handles btnAddPhoto.Click

        cd.ShowDialog()
    End Sub


    ' This method handles the FileOK event.  It opens each file 
    ' selected and loads the image from a stream into PictureBox1.
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) _
     Handles cd.FileOk
        Dim m_sOfficersName As String = String.Empty

        Me.Activate()
        Dim files() As String
        files = cd.FileNames
        Dim climage As New ImagesInterface.MultiMedia

        With climage
            .ImageGroupID = m_lImageGroup
            .ImageFiles = files
            '.ImagePath = sImagePath
            .CatalogeName = "Multimedia;"
            .ServerName = My.Settings.ServerName
            .ImageLocation = m_sImageLocation
            .ImageSubject = m_sImageSubject
            .Application = 7
            .LoadInterface()
            m_lImageGroup = .ImageGroupID
            UpdateGroupID(m_lImageGroup)
            m_sImageSubject = .ImageSubject
            m_sImageLocation = .ImageLocation
            m_sOfficersName = .OfficerName

            Me.FilmStripControl.RemoveAllPictures()

            RetrieveImagesForDisplay(.ImageGroupID)

        End With

    End Sub

    Private Sub UpdateGroupID(ByVal groupImageID As Integer)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateGroupID routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateGroupImageId"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANO
                        .Parameters.Add("@GROUPID", SqlDbType.Int).Value = groupImageID
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateGroupID routine - form " & Me.Name)

            End Try
        End Using

    End Sub
    Private Sub GetImageSubject(ByVal sImageName As String)
        Dim Returnvalue As String = String.Empty

        Using cn As New SqlConnection(My.Settings.MMConnection)
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
                        .CommandText = "usp_SELECT_ImageSubjectDescription"

                        .Parameters.Add("@IMAGEID", SqlDbType.VarChar).Value = sImageName
                    End With

                    Dim objDT As New CZONES.ImageDataDataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim objRow As DataRow = objDT.Rows(0)
                    txtSubject.Text = objRow.Item("Subject").ToString
                    txtDescription.Text = objRow.Item("DescriptionofImage").ToString

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

    Private Sub GetImageGroupData(ByVal lImageGroup As Long)


        Using cn As New SqlConnection(My.Settings.MMConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetImageGroupData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetSubjectandLocation"

                        .Parameters.Add("@IMAGEGRP", SqlDbType.Int).Value = lImageGroup
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count

                    If RowCount > 0 Then
                        m_sImageSubject = objDT.Rows(0).Item("Subject").ToString
                        m_sImageLocation = objDT.Rows(0).Item("SubLocationTakeject").ToString
                    End If


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetImageGroupData routine - form " & Me.Name)

            End Try
        End Using









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
        Dim sFileName As String
        Dim sImageNumber As String
        Dim objDT As New DataTable

        Me.FilmStripControl.RemoveAllPictures()

        Using cn As New SqlConnection(My.Settings.MMConnection)
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
                        .CommandText = "usp_IMageData"

                        .Parameters.Add("@GROUPID", SqlDbType.Int).Value = groupimageID
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
                        sFileName = objDataRow.Item("ImageFileName").ToString
                        sImageNumber = objDataRow.Item("ImageId").ToString
                        '   Uncomment the following when moving to the new rec server to allow for archiving
                        If CInt(BuildYear(sImageNumber).Substring(0, 4)) <> Year(DateTime.Today) Then
                            sImageLocation = My.Settings.ImageArchiveStorage & BuildYear(sImageNumber) & ImageFolderHash(sImageNumber) & "\" & sFileName
                        Else
                            sImageLocation = My.Settings.ImageStorageLocation & BuildYear(sImageNumber) & ImageFolderHash(sImageNumber) & "\" & sFileName
                        End If
                        Me.FilmStripControl.AddPicture(sImageLocation)
                        'addMe(sImageLocation)

                    Next

                End If



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveImagesForDisplay routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Public Function BuildYear(ByVal sDocumentNumber As String) As String
        Dim sResult As String = String.Empty

        sResult = "20" & sDocumentNumber.Substring(sDocumentNumber.Length - 2) & "\"
        Return sResult

    End Function
    Public Function ImageFileName(ByVal sDocumentNumber As String) As String
        ImageFileName = "\" & sDocumentNumber & ".pdf"
    End Function
    Public Function FolderHash(ByVal sDocumentNumber As String) As Long
        Dim lFilenumber As Long
        'lFilenumber = Left(sDocumentNumber, InStr(sDocumentNumber, "_") - 1)
        lFilenumber = CLng(sDocumentNumber.Substring(InStr(sDocumentNumber, "_") - 1))
        FolderHash = lFilenumber \ 5000
    End Function

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

        btnPrint.Enabled = True


    End Sub



    Private Sub FilmStripControl_OnImageClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilmStripControl.OnImageClicked
        displayImage(CType(sender, String))
        GetImageSubject(FileIO.FileSystem.GetName(CType(sender, String)))

        m_ImagePath = CType(sender, String)
    End Sub

    Private Sub MultimediaInterface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitializeOpenFileDialog()
        Me.FilmStripControl.RemoveAllPictures()

        RetrieveImagesForDisplay(m_lImageGroup)
    End Sub

 
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        My.Computer.FileSystem.CopyFile(m_ImagePath, mydocuments & "PrintThis.jpg", True)
        Dim x As Integer
        If m_ImagePath <> String.Empty Then
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & mydocuments & "PrintThis.jpg")
        End If

    End Sub
End Class