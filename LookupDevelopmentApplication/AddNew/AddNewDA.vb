Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class AddNewDA

    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private bisloading As Boolean
    Private TheNewNumber As String = String.Empty


    Friend Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
    End Sub

    Private Sub AddNewDA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ApplicationStatus As New ArrayList

        With ApplicationStatus
            .Add(New ApplicationStatus("WITH OFFICER", 7))
            .Add(New ApplicationStatus("REGISTERED", 6))
        End With

        With Me.cboDecision.Properties
            .DataSource = ApplicationStatus
            .DisplayMember = "ApplicationStatus"
            .ValueMember = "AppStatCode"
        End With

        Dim col2 As LookUpColumnInfoCollection = cboDecision.Properties.Columns
        col2.Add(New LookUpColumnInfo("ApplicationStatus", 0))
        col2.Add(New LookUpColumnInfo("AppStatCode", 0))

        col2.Item(1).Visible = False

        LoadDAApplicationTypes()
        LoadOfficersList()


    End Sub

    Private Sub LoadDAApplicationTypes()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDAApplicationTypes routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_DAApplicationTypes"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboAppType.Properties
                        .DataSource = objDT
                        .DisplayMember = "DAAppType"
                        .ValueMember = "DAAppTypeId"

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboAppType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DAAppType", 0))
                    col2.Add(New LookUpColumnInfo("DAAppTypeId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDAApplicationTypes routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadOfficersList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_ListOfOfficersForNewApplication"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboDAOfficer.Properties
                        .DataSource = objDT
                        .DisplayMember = "Officer"
                        .ValueMember = "OfficerID"

                    End With
                    Dim col2 As LookUpColumnInfoCollection = cboDAOfficer.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Officer", 0))
                    col2.Add(New LookUpColumnInfo("OfficerID", 0))

                    col2.Item(1).Visible = False
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub GetOriginalData(ByVal dano As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOriginalData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "ups_RetrievePreviousDAApplicantDetails"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = dano
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            Me.txtAppName.Text = objDataReader.Item(0).ToString
                            Me.txtAppAddress.Text = objDataReader.Item(1).ToString
                            Me.txtAppTown.Text = objDataReader.Item(2).ToString
                            Me.txtappPcode.Text = objDataReader.Item(3).ToString
                            Me.txtAppPhone.Text = objDataReader.Item(4).ToString
                            Me.txtEmail.Text = objDataReader.Item(5).ToString
                            Me.txtFileNo.Text = objDataReader.Item(6).ToString
                        Loop
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOriginalData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink


        Me.dtRego.EditValue = Today.Date

    End Sub


    Private Function CheckDataEntry() As Boolean
        Dim result As Boolean = True

        If cboAppType.EditValue Is Nothing Then

            With ErrorProvider
                .SetIconAlignment(Me.cboAppType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboAppType, "Applicant type is required")
            End With

            result = False


        Else

            Select Case CInt(cboAppType.EditValue)
                Case 3

                    If txtModeNumber.Text = String.Empty Then
                        With ErrorProvider
                            .SetIconAlignment(txtModeNumber, ErrorIconAlignment.MiddleRight)
                            .SetError(txtModeNumber, "Requires a number")
                        End With
                        result = False
                    Else
                        ErrorProvider.SetError(txtModeNumber, "")

                    End If

                Case Else
                    'do nothing
            End Select

        End If



        If Me.txtAppName.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppName, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppName, "Applicants name is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppName, "")

        End If

        If Me.txtAppAddress.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppAddress, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppAddress, "Applicants address is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppAddress, "")

        End If

        If Me.txtAppTown.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.Label11, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.Label11, "Applicants town is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.Label11, "")

        End If

        If Me.txtappPcode.Text = "0" Then
            With ErrorProvider
                .SetIconAlignment(Me.txtappPcode, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtappPcode, "Applicants postcode is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtappPcode, "")

        End If

        'If Me.cboAppType.Text = String.Empty Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.cboAppType, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.cboAppType, "Application Type is required")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.cboAppType, "")

        'End If

        If Me.txtAppPhone.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppPhone, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppPhone, "Phone number is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppPhone, "")

        End If

        If Me.txtFileNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtFileNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtFileNo, "File number is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtFileNo, "")

        End If

        If Me.dtRego.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.dtRego, ErrorIconAlignment.MiddleRight)
                .SetError(Me.dtRego, "Registration date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.dtRego, "")

        End If

        If Me.cboDAOfficer.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDAOfficer, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDAOfficer, "Officer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDAOfficer, "")

        End If



        If Me.cboDecision.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDecision, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDecision, "Application status is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDecision, "")

        End If


        Return result
    End Function



    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        If Not CheckDataEntry() Then Exit Sub
        Select Case CInt(cboAppType.EditValue)
            Case 3

                NewDANo = Me.txtAAno.Text & "-M" & txtModeNumber.Text.Trim
                ReplicateDAforModification(NewDANo)
                'CreateANewDA()

            Case 4

                NewDANo = Me.txtAAno.Text & "-82A"
                ReplicateDAforModification(NewDANo)


            Case Else

                NewDANo = Me.txtAAno.Text
                CreateANewDA(NewDANo)

        End Select

        Me.DialogResult = DialogResult.OK


    End Sub


    Private Sub CreateANewDA(NewDANumber As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateNewDa"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = NewDANumber
                        .Parameters.Add("@USERID", SqlDbType.NVarChar).Value = sUserID
                        .Parameters.Add("@DATypeId", SqlDbType.Int).Value = CInt(cboAppType.EditValue)
                        .Parameters.Add("@DARegoDt", SqlDbType.SmallDateTime)
                        If Not dtRego.EditValue Is Nothing Then .Parameters("@DARegoDt").Value = Format(CDate(dtRego.EditValue), "dd/MM/yyyy")

                        .Parameters.Add("@DADecisionId", SqlDbType.Int)
                        If Not cboDecision.EditValue Is Nothing Then .Parameters("@dADecisionId").Value = CInt(cboDecision.EditValue)
                        .Parameters.Add("@DAOfficerId", SqlDbType.Int)
                        If Not cboDAOfficer.EditValue Is Nothing Then .Parameters("@DAOfficerId").Value = CInt(cboDAOfficer.EditValue)
                        .Parameters.Add("@DAFileNo", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@DAAppName", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@DAAppAddr", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@DAAppTown", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@DAAppEmail", SqlDbType.NVarChar).Value = Me.txtEmail.Text
                        .Parameters.Add("@DAAppPC", SqlDbType.VarChar)
                        If txtappPcode.Text <> String.Empty Then .Parameters("@DAAppPC").Value = CInt(txtappPcode.Text)
                        .Parameters.Add("@DAAppPhone", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text

                        .ExecuteNonQuery()

                    End With



                End Using

                bisloading = True


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub ReplicateDAforModification(NewDANumber As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ReplicateDAforModification routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateModifiedDA"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = NewDANumber
                        .Parameters.Add("@USERID", SqlDbType.NVarChar).Value = sUserID
                        .Parameters.Add("@ORGDANO", SqlDbType.NVarChar).Value = Me.lblOriginalDANumber.Text
                        .Parameters.Add("@OFFCERID", SqlDbType.Int).Value = CInt(cboDAOfficer.EditValue)
                        .Parameters.Add("@DATypeid", SqlDbType.Int).Value = CInt(cboAppType.EditValue)
                        .Parameters.Add("@DADecisionID", SqlDbType.Int).Value = CInt(Me.cboDecision.EditValue)
                        .Parameters.Add("@RegoDte", SqlDbType.SmallDateTime).Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")

                        .Parameters.Add("@APPNAME", SqlDbType.NVarChar).Value = txtAppName.Text
                        .Parameters.Add("@APPADDR", SqlDbType.NVarChar).Value = txtAppAddress.Text
                        .Parameters.Add("@APPTOWN", SqlDbType.NVarChar).Value = txtAppTown.Text
                        If txtappPcode.Text <> String.Empty Then .Parameters.Add("@DAAppPC", SqlDbType.SmallInt).Value = CInt(txtappPcode.Text)
                        .Parameters.Add("@APPPHONE", SqlDbType.NVarChar).Value = txtAppPhone.Text
                        .Parameters.Add("@APPEMAIL", SqlDbType.NVarChar).Value = txtEmail.Text


                        .ExecuteNonQuery()

                    End With

                    Dim objDT As New DataTable


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ReplicateDAforModification routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private NewDANo As String = String.Empty
    Public ReadOnly Property NewDANumber() As String
        Get
            Return NewDANo
        End Get
    End Property



    'Private Sub txtAAno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAAno.Validating
    '    If txtAAno.Text = String.Empty Then Exit Sub
    '    Select Case CInt(cboAppType.SelectedValue)
    '        Case 3, 4
    '            If (Me.txtAAno.Text.Substring(0, 1).ToUpper <> "M") And (Me.txtAAno.Text.Substring(0, 3).ToUpper <> "82A") Then
    '                MessageBox.Show("This is a modified Application, the number must have a 'M' or '82A' preceding it", "Unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                e.Cancel = True
    '            End If

    '        Case Else
    '            'do nothing
    '    End Select

    'End Sub

    Private Sub btnKeep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeep1.Click

        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(Me.txtAppName.Text)
        objStreamWriter.WriteLine(Me.txtAppAddress.Text)
        objStreamWriter.WriteLine(Me.txtAppTown.Text)
        objStreamWriter.WriteLine(Me.txtappPcode.Text)
        objStreamWriter.WriteLine(Me.txtAppPhone.Text)


        'Close the file.
        objStreamWriter.Close()
    End Sub

    Private Sub cboAppType_EditValueChanged(sender As Object, e As EventArgs) Handles cboAppType.EditValueChanged

        If cboAppType.IsLoading Then Return

        Dim result As String = String.Empty

        Me.lblMod.Visible = False
        txtModeNumber.Visible = False
        lblModSuffix.Visible = False

        Select Case CInt(cboAppType.EditValue)
            Case 3

                Dim fLookFor As New LocateOriginalDA
                With fLookFor
                    .ShowDialog()
                    result = .OriginalDANumber
                    .Dispose()
                End With

                If result <> String.Empty Then

                    Me.lblMod.Visible = True
                    txtModeNumber.Visible = True
                    lblModSuffix.Visible = True
                    Me.lblOriginalDANumber.Text = result

                    GetOriginalData(result)

                Else
                    MessageBox.Show("You are required to select the previous DA before you can proceed with this application", "Unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblOriginalDANumber.Text = String.Empty
                End If

                Me.txtAAno.Text = result

                txtAAno.ReadOnly = True
                txtModeNumber.Focus()

            Case 4

                Dim fLookFor As New LocateOriginalDA
                With fLookFor
                    .ShowDialog()
                    result = .OriginalDANumber
                    .Dispose()
                End With

                If result <> String.Empty Then

                    Me.lblMod.Visible = True

                    Me.lblOriginalDANumber.Text = result

                    GetOriginalData(result)

                Else

                    MessageBox.Show("You are required to select the previous DA before you can proceed with this application", "Unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblOriginalDANumber.Text = String.Empty

                End If

                Me.txtAAno.Text = result

                txtAAno.ReadOnly = True
                txtModeNumber.Focus()

            Case Else
                Me.lblMod.Visible = False
                txtModeNumber.Visible = False
                lblModSuffix.Visible = False

                Me.lblOriginalDANumber.Text = String.Empty

                If TheNewNumber <> String.Empty Then Exit Sub

                If MessageBox.Show("Create this " + Me.cboAppType.Text & " record?", "Create new Development application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

                Dim newNumber As String = String.Empty



                Using cn As New SqlConnection(My.Settings.connectionString)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in cboAppType_SelectedValueChanged routine - form " & Me.Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_GetNextDANumber"

                                .Parameters.Add("@DANO", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output

                                .ExecuteNonQuery()
                                Dim number As String = .Parameters("@DANO").Value.ToString

                                Me.txtAAno.Text = number
                                txtAAno.ReadOnly = True
                                TheNewNumber = number
                            End With


                        End Using




                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in cboAppType_SelectedValueChanged routine - form " & Me.Name)

                    End Try
                End Using


        End Select

    End Sub


    Private Function thisNumberIsAlreadyInUse() As Boolean

        Dim result As Boolean


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in thisNumberIsAlreadyInUse routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_CheckIfModNumberExist"

                        .Parameters.Add("@NEWNUMBER", SqlDbType.VarChar).Value = txtAAno.Text & "-M" & txtModeNumber.Text.Trim
                        .Parameters.Add("@RESULT", SqlDbType.Bit).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()

                        result = CBool(.Parameters("@RESULT").Value)


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in thisNumberIsAlreadyInUse routine - form " & Me.Name)

            End Try
        End Using



        Return result


    End Function
    Private Sub txtModeNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtModeNumber.Validating

        If thisNumberIsAlreadyInUse() Then

            MessageBox.Show("This suffix has already been used, please re-key", "Number exists", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

    End Sub

    Private Sub cboAppType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAppType.KeyPress
        KeyPressSendTab(e)
    End Sub

    Private Sub txtAAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAAno.KeyPress
        KeyPressSendTab(e)

    End Sub

    Private Sub txtFileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFileNo.KeyPress
        KeyPressSendTab(e)

    End Sub

End Class