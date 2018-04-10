Imports system.data.SqlClient
Imports DevExpress.XtraEditors
Imports SB = System.Text.StringBuilder

Public Class SystemUsersMaintenance

    Private mdllOfficerID As Integer
    Private ErrorProvider As System.Windows.Forms.ErrorProvider


    Private Sub LoadListOfOfficers(ByVal whichList As Boolean)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfOfficers routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ListOfOfficesAndEntities"
                        .Parameters.Add("@STAFF", SqlDbType.Bit).Value = whichList
                        .Parameters.Add("@ACTIVEONLY", SqlDbType.Bit).Value = Not chkActiveOnly.Checked

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdOfficers.DataSource = objDT


                End Using


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfOfficers routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private WithEvents WhichButton As RadioButton

    Private Sub SystemUsersMaintenance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadListOfOfficers(0)
    End Sub

    Private Sub rbStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStaff.CheckedChanged, rbExternal.CheckedChanged
        If rbStaff.Checked = True Then
            LoadListOfOfficers(0)
        Else
            LoadListOfOfficers(1)
        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, btnEdit.Click, btnSave.Click

        Select Case CType(sender, SimpleButton).Name.ToString.ToUpper
            Case "BTNADD"
                btnSave.Enabled = True
                btnAdd.Enabled = False
                btnEdit.Enabled = False

                UnLockForm(GroupBox2, False)
                ClearTheForm(Me)
                Me.picSignature.Image = Nothing
                Me.txtOfficer.Focus()

            Case "BTNEDIT"
                btnSave.Enabled = True
                btnEdit.Enabled = False

                UnLockForm(GroupBox2, False)
                Me.txtOfficer.Focus()

            Case Else
                If Not ChecksOut() Then
                    Return
                End If

                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnAdd.Enabled = True

                UnLockForm(GroupBox2, True)
                SaveTheData()
                If rbStaff.Checked = True Then
                    LoadListOfOfficers(0)
                Else
                    LoadListOfOfficers(1)
                End If




        End Select

    End Sub



    Private Sub SaveTheData()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveTheData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateDAUserTable"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblID.Text)
                        .Parameters.Add("@OFFICER", SqlDbType.NVarChar).Value = Me.txtOfficer.Text
                        .Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Me.txtPhone.Text
                        .Parameters.Add("@QUIT", SqlDbType.Bit).Value = Me.chkActive.CheckState
                        .Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Me.txtEmail.Text
                        .Parameters.Add("@MOBILE", SqlDbType.NVarChar).Value = Me.txtMobilePhone.Text
                        .Parameters.Add("@TITLE", SqlDbType.NVarChar).Value = Me.txtTitle.Text
                        .Parameters.Add("@IMAGE", SqlDbType.NVarChar).Value = Me.txtSignature.Text
                        .Parameters.Add("@EXTERNAL", SqlDbType.Bit).Value = Me.chkExternal.CheckState
                        .Parameters.Add("@ASSESSMENT", SqlDbType.Bit).Value = Me.chkAssessmentOfficer.CheckState
                        .Parameters.Add("@LAN", SqlDbType.NVarChar).Value = Me.txtLAN.Text
                        .Parameters.Add("@BPBNUMBER", SqlDbType.NChar, 10).Value = Me.txtBPBNumber.Text
                        .ExecuteNonQuery()
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveTheData routine - form " & Me.Name)

            End Try
        End Using


    End Sub
    Private Sub Loadform(ByVal OfficerID As Integer)
        Dim lHeight As Integer
        Dim lWidth As Integer
        Dim dRatio As Double
        UnLockForm(GroupBox2, True)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in Loadform routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadOfficersDetails"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = OfficerID
                    End With

                    Dim objDT As New DataTable

                    ClearTheForm(Me)

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        While objDataReader.Read
                            Me.txtOfficer.Text = objDataReader.Item(0).ToString
                            Me.txtPhone.Text = objDataReader.Item(1).ToString
                            Me.txtTitle.Text = objDataReader.Item(6).ToString
                            Me.txtMobilePhone.Text = objDataReader.Item(5).ToString
                            Me.txtLAN.Text = objDataReader.Item(9).ToString
                            Me.txtEmail.Text = objDataReader.Item(4).ToString
                            Me.txtSignature.Text = objDataReader.Item(7).ToString
                            Me.chkActive.Checked = CBool(objDataReader.Item(3))
                            Me.chkExternal.Checked = CBool(objDataReader.Item(8))
                            Me.chkAssessmentOfficer.Checked = CBool(objDataReader.Item(12))
                            lblID.Text = objDataReader.Item(10).ToString
                            txtBPBNumber.Text = objDataReader.Item("BuildersProfBoard").ToString
                            If txtSignature.Text <> String.Empty Then
                                With picSignature
                                    .Visible = False
                                    .SizeMode = PictureBoxSizeMode.AutoSize
                                    .Image = Image.FromFile(txtSignature.Text)
                                    lHeight = .Height
                                    lWidth = .Width

                                    If lHeight > lWidth Then
                                        dRatio = lHeight / lWidth
                                        .Width = CInt(245 / dRatio)
                                        .Height = 245
                                        .SizeMode = PictureBoxSizeMode.StretchImage
                                        '.Location = New Point(229, 3)
                                    Else
                                        dRatio = lWidth / lHeight
                                        .Height = CInt((245 / dRatio))
                                        .Width = (245)
                                        .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                                        '.Location = New Point(135, 88)
                                    End If



                                    .Visible = True
                                End With
                            Else
                                Me.picSignature.Image = Nothing
                            End If

                        End While


                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in Loadform routine - form " & Me.Name)

            End Try
        End Using
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnAdd.Enabled = True




    End Sub

    Private Sub btnSignature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignature.Click
        Dim lHeight As Integer
        Dim lWidth As Integer
        Dim dRatio As Double

        cd.Title = "Select Images"
        cd.InitialDirectory = "H:\temp\"
        cd.Filter = "Supported Files (*.bmp;*.jpg;*.wmf)" _
                  & "|*.bmp;*.jpg;*.wmf" _
                  & "|Bitmaps (*.bmp)|*.bmp" _
                  & "|JPEG Images (*.jpg)|*.jpg" _
                  & "|Metafiles (*.wmf)|*.wmf;"
        cd.FilterIndex = 1
        cd.FileName = ""
        cd.ShowDialog()
        'add the selected image/s as thumbnail/s
        Dim sImagePath As String = cd.FileName
        Dim filename As String = My.Computer.FileSystem.GetName(sImagePath).ToString

        If sImagePath <> String.Empty Then
            My.Computer.FileSystem.MoveFile(sImagePath, My.Settings.SignatureLocation & filename, True)


            Me.txtSignature.Text = My.Settings.SignatureLocation & filename

            With picSignature
                .Visible = False
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Image = Image.FromFile(txtSignature.Text)
                lHeight = .Height
                lWidth = .Width

                If lHeight > lWidth Then
                    dRatio = lHeight / lWidth
                    .Width = CInt(245 / dRatio)
                    .Height = 245
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    '.Location = New Point(229, 3)
                Else
                    dRatio = lWidth / lHeight
                    .Height = CInt((245 / dRatio))
                    .Width = (245)
                    .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                    '.Location = New Point(135, 88)
                End If



                .Visible = True
            End With




            Me.picSignature.Image = Image.FromFile(txtSignature.Text)

        End If


    End Sub



    Private Sub UnLockForm(ByVal Pnl As Control, ByVal Lock As Boolean)
        For Each ctrl As Control In Pnl.Controls
            If TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                If cb.Name = "txtSignature" Then

                Else
                    cb.ReadOnly = Lock

                End If
            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                If cb.Name = "chkActiveOnly" Then
                    cb.ReadOnly = False
                Else
                    cb.ReadOnly = Lock

                End If
            End If



            If ctrl.HasChildren Then
                UnLockForm(ctrl, Lock)
            End If
        Next
        Me.btnSignature.Enabled = Not Lock
    End Sub


    Private Sub ClearTheForm(ByVal Pnl As Control)
        For Each ctrl As Control In Pnl.Controls
            If TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is Checkedit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)

                If cb.Name <> "chkActiveOnly" Then cb.CheckState = CheckState.Unchecked
            End If


            If ctrl.HasChildren Then
                ClearTheForm(ctrl)
            End If
        Next
        Me.lblID.Text = "0"
    End Sub


    Private Function ChecksOut() As Boolean
        Dim result As Boolean = True

        Dim sbMsg As New SB





        If txtOfficer.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(txtOfficer, ErrorIconAlignment.MiddleRight)
                .SetError(txtOfficer, "This is a required field")
                sbMsg.Append("Officer Name is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(txtOfficer, "")

        End If

        If txtTitle.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(txtTitle, ErrorIconAlignment.MiddleRight)
                .SetError(txtTitle, "This is a required field")
                sbMsg.Append("Title is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(txtTitle, "")

        End If

        If txtEmail.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight)
                .SetError(txtEmail, "This is a required field")
                sbMsg.Append("Email is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(txtEmail, "")

        End If

        If txtLAN.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(txtLAN, ErrorIconAlignment.MiddleRight)
                .SetError(txtLAN, "This is a required field")
                sbMsg.Append("LAN logon ID is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(txtLAN, "")

        End If


        If sbMsg.ToString <> String.Empty Then

            MessageBox.Show(sbMsg.ToString, "Following Fields need to be completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return result


    End Function



    Private Sub chkActiveOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkActiveOnly.CheckedChanged
        LoadListOfOfficers(0)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub gvwOfficers_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwOfficers.RowClick
        Try


            Dim myobj As DataRowView = CType(gvwOfficers.GetFocusedRow, DataRowView)



            Loadform(CInt(myobj.Row.Item("OfficerID")))
        Catch ex As Exception

        End Try
    End Sub
End Class