Imports System.Data.SqlClient
Imports WORD = Microsoft.Office.Interop.Word
Imports QSS.Components.Windows.Forms
Imports MAIL = MailHelper.MailHelper


Public Class ConstructionCerticate
#Region "Declarations"
    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private isloading As Boolean

#End Region

#Region "Functions and Sub routines"

    Private DAno As String
    Public WriteOnly Property DANumber() As String
        Set(ByVal value As String)
            DAno = value
        End Set
    End Property

    Private Function CalculateElapsedDays(ByVal DAno As String) As Integer

        Dim dateVar As Date = CDate("1/1/1900")
        Dim objDT As New DataTable
        Dim dayscount As Integer

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_NetReferalDays"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DAno
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

            End Try
        End Using




        If objDT.Rows.Count > 0 Then
            For count2 As Integer = 0 To objDT.Rows.Count - 1
                Dim objdatarow2 As DataRow = objDT.Rows.Item(count2)

                If Not IsDBNull(objdatarow2.Item("RefRetDt")) And Not IsDBNull(objdatarow2.Item("Refdt")) Then

                    'If (objdatarow2.Item("RefRetDt") <> null) And (objdatarow2.Item("RefDt") <> null) Then
                    If DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar) > 0 Then

                    ElseIf DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("Refdt"))) <= 0 Then
                        dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar))
                        dateVar = CDate(objdatarow2.Item("RefRetDt"))

                    Else
                        dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("Refdt")), CDate(objdatarow2.Item("RefRetDt"))))
                        dateVar = CDate(objdatarow2.Item("RefRetDt"))

                    End If
                End If
            Next
        End If
        Return dayscount
    End Function

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        If TheNewDate <> String.Empty Then datefield.Text = TheNewDate

    End Sub

    Private Sub LoadForm(ByVal CCno As String)

        Try
            Me.CCApplicationTableAdapter.Fill(Me.CCdata.CCApplication, CCno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.DASummaryDataTableAdapter.Fill(Me.DAdatasets.DASummaryData, Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Try
            Me.Property_NumbersTableAdapter.Fill(Me.DAdatasets.Property_Numbers, CCno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, CCno, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, CCno, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        CalculateRefundsandPayments(CCno)

        Try
            Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, CCno, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "CC", Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.RetrieveFileNotesTableAdapter.Fill(Me.DAdatasets.RetrieveFileNotes, CCno, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.CC_DocType_WordTemplateTableAdapter.Fill(Me.CCdata.CC_DocType_WordTemplate)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If Me.cboConsentDocType.SelectedIndex <> -1 Then
            Try
                Me.ListofConditionsByLetterTypeTableAdapter.Fill(Me.DAdatasets.ListofConditionsByLetterType, New System.Nullable(Of Integer)(CType(cboConsentDocType.SelectedValue, Integer)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If

        Try
            Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, CCno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, CCno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, CCno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtDANo.Text, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "CC", txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        LoadBuildersNames()

        btnEditDA.Enabled = True
        Me.btnEditAddinfoTab.Enabled = True
        Me.btnEditReferralsTab.Enabled = True
        btnEditAddinfoTab.Enabled = True
        Me.btnSaveDA.Enabled = False
        Me.btnAddCC.Enabled = True





    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Function FileExists(ByVal sFileNumber As String, ByRef errorMessage As String) As Boolean
        ' Confirm there is text in the control.
        If sFileNumber.Length = 0 Then
            errorMessage = "File number is required"
            Return False
        End If


        Using Connection As New SqlConnection(My.Settings.cnDAsystem)
            Dim Returnvalue As Boolean = False

            Try

                Using cmd As New SqlCommand


                    With cmd
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckEASEFileExists"
                        .Parameters.Add("@FILENO", SqlDbType.VarChar, 20, Nothing)

                        .Parameters.Add("@OK", SqlDbType.Bit, 0, Nothing)
                        .Parameters("@OK").Direction = ParameterDirection.Output
                        .Parameters("@FILENO").Value = sFileNumber
                    End With


                    Connection.Open()
                    cmd.ExecuteNonQuery()


                    Returnvalue = DirectCast(cmd.Parameters("@OK").Value, Boolean)
                    Connection.Close()
                    If Not Returnvalue Then errorMessage = "This is not a valid file number"
                    Return Returnvalue
                End Using

            Catch ex As Exception
                MessageBox.Show("The following error has occured in routine FileExists " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorMessage = "This is not a valid file number"
                Return Returnvalue
            End Try
        End Using

    End Function

    Private Sub CalculateRefundsandPayments(ByVal dano As String)

        Dim Receipt As String = String.Empty
        Dim Refund As String = String.Empty
        Dim difference As String = String.Empty

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_TotalPaymentandRefunds"
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = dano
                        .Parameters.Add("@SYSID", SqlDbType.VarChar).Value = "CC"

                        .Parameters.Add("@TOTALREFUNDS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .Parameters.Add("@TOTALPAYMENTS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        Receipt = .Parameters("@TOTALPAYMENTS").Value.ToString
                        Refund = .Parameters("@TOTALREFUNDS").Value.ToString
                        difference = CStr(NZ(Receipt) - NZ(Refund))
                    End With


                End Using
                cn.Close()
                Me.txtReceipts.Text = Format(Receipt, "currency")
                Me.txtRefunds.Text = Format(Refund, "currency")
                Me.txtDifference.Text = Format(difference, "currency")


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
    End Sub

    Private Function CheckConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckIfCodeDoseNoteExitInList"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = condID
                        .Parameters.Add("@EXIST", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@EXIST").Value)

                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub FindUserInfor()
        'TODO: Finnish this function to set user Permissions

        Try
            sUserID = My.User.Name.Substring(4)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub InsertIntoDADocumentsTable(ByVal DocType As String, ByVal FileName As String)
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertDocumentData"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "DA"
                        .Parameters.Add("@AUTHOR", SqlDbType.Int).Value = MyUserId
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = FileName
                        .ExecuteNonQuery()
                    End With

                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function GetEmailAddress() As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
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
                        .CommandText = "usp_GetOfficerEmailAddress"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(cboDAOfficer.SelectedValue)
                        .Parameters.Add("@EMAIL", SqlDbType.NVarChar, 200).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@EMAIL").Value.ToString
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub ClearReferralData(ByVal Pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ExtendedComboBox Then
                Dim cb As ExtendedComboBox = DirectCast(ctrl, ExtendedComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked

            End If
        Next
        Me.lblReferralID.Text = String.Empty

    End Sub

    Private Function CheckAdditionalInfo() As Boolean
        Dim result As Boolean = True

        If Not IsDate(AIRequestDt.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.AIRequestDt, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.AIRequestDt, "A request date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.AIRequestDt, "")

        End If
        If AICommentTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.AICommentTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.AICommentTextBox, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.AICommentTextBox, "")

        End If
        Return result
    End Function

    Private Function CheckReferralData() As Boolean
        Dim result As Boolean = True

        If Not IsDate(Refdt.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.Refdt, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.Refdt, "A referral date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.Refdt, "")

        End If
        If cboRefCodeId.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboRefCodeId, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboRefCodeId, "A referral source is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboRefCodeId, "")

        End If
        If txtRefComm.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtRefComm, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtRefComm, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtRefComm, "")

        End If
        If cboRFSSubDivisionType.Visible Then
            If cboRFSSubDivisionType.SelectedIndex = -1 Then
                With ErrorProvider
                    .SetIconAlignment(Me.cboRFSSubDivisionType, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.cboRFSSubDivisionType, "A comment is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "")

            End If

            If Me.txtRFSSubLots.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.txtRFSSubLots, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.txtRFSSubLots, "A comment is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.txtRFSSubLots, "")

            End If
        End If
        Return result
    End Function

    Private Sub ClearAddInfoData(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ExtendedComboBox Then
                Dim cb As ExtendedComboBox = DirectCast(ctrl, ExtendedComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            End If
        Next

        Me.lblAdditionalInfoId.Text = String.Empty
    End Sub

    Private Sub LoadBuildersNames()


        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CC_BuildersListing"

                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboBuildersNames.Items.Add(New BuilderNames(objDataReader(0).ToString, objDataReader(1).ToString, objDataReader(2).ToString, CInt(objDataReader(3))))
                        Loop
                        objDataReader.Close()
                        cboBuildersNames.SelectedIndex = -1
                    End Using



                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadSearchList()

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CC_Listing"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    isloading = True


                    Me.lstSearchResults.DataSource = objDT
                    Me.lstSearchResults.DisplayMember = "CCAppNo"
                    Me.lstSearchResults.ValueMember = "CCAppNo"
                    isloading = False
                    Me.lstSearchResults.SelectedItem = 0
                    LoadForm(lstSearchResults.Text)




                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is ExtendedComboBox Then
                Dim cb As ExtendedComboBox = DirectCast(ctrl, ExtendedComboBox)
                cb.ReadOnly = Not bLock
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = Not bLock
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock

            End If
        Next
    End Sub

    Private Sub ClearData(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ExtendedComboBox Then
                Dim cb As ExtendedComboBox = DirectCast(ctrl, ExtendedComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            End If
        Next

    End Sub


#End Region

#Region "EASE Functions"

    Private Function GetNextDocumentNumber() As String
        Dim Returnvalue As String = String.Empty

        Try

            Dim cmd As New SqlCommand
            Dim cn As New SqlConnection(My.Settings.cnEASE)


            With cmd
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_Common_GetNextDocumentNo"
                .Parameters.Add("@NEWDOCID", SqlDbType.VarChar, 15, Nothing)

                .Parameters("@NEWDOCID").Direction = ParameterDirection.Output
            End With


            cn.Open()
            cmd.ExecuteNonQuery()


            Returnvalue = cmd.Parameters("@NEWDOCID").Value.ToString
            cn.Close()

            Return Returnvalue
        Catch ex As Exception
            MessageBox.Show("The following error has occured in routine GetNextDocumentNumber " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Returnvalue
        End Try





        Return Returnvalue

    End Function

    'Private Sub CreateEASErecordExtracted(ByVal strDocumentNo As String, ByVal strEASEdocumentName As String)


    '    Dim strDocumentSummary As String = "OSMS Initial Inspection advice letter to " & objDataRow.Item(MAILNAME).ToString


    '    Try
    '        Using cn As New SqlConnection(My.Settings.cnLIMES)
    '            Using cmd As New SqlCommand


    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_EASE_InsertNewDocument"
    '                    .Parameters.Add("@DOCID", SqlDbType.VarChar, 10, Nothing).Value = strDocumentNo
    '                    .Parameters.Add("@FILENO", SqlDbType.VarChar, 10, Nothing).Value = objDataRow.Item(EASEFILENO).ToString
    '                    .Parameters.Add("@SUMMARY", SqlDbType.VarChar, 255, Nothing).Value = strDocumentSummary
    '                    .Parameters.Add("@ACTIONOFFICER", SqlDbType.VarChar, 100, Nothing).Value = lUserID.ToString & "|"
    '                    .Parameters.Add("@FILENAME", SqlDbType.VarChar, 25, Nothing).Value = strEASEdocumentName
    '                    .Parameters.Add("@CUSTNAME", SqlDbType.VarChar, 120, Nothing).Value = objDataRow.Item(MAILNAME).ToString
    '                    .Parameters.Add("@CUSTADDRS", SqlDbType.VarChar, 100, Nothing).Value = objDataRow.Item(MAILADDRESS).ToString
    '                    .Parameters.Add("@PUBLICID", SqlDbType.Int, 0, Nothing).Value = objDataRow.Item(PUBLICID).ToString
    '                    .Parameters.Add("@LANID", SqlDbType.VarChar, 10, Nothing).Value = sUserID
    '                    .Parameters.Add("@LETTERTYPE", SqlDbType.Int, 0, Nothing).Value = 5 'Initial inspection letter


    '                End With
    '                cn.Open()
    '                cmd.ExecuteNonQuery()
    '                cn.Close()
    '            End Using

    '        End Using

    '    Catch ex As Exception
    '        MessageBox.Show("The following error occurred in CreateEASErecordExtracted" & ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End Try
    'End Sub

    'Private Sub CreateEASErecord()


    '    Try


    '        Me.Cursor = Cursors.WaitCursor

    '        Dim strDocumentNo As String = GetNextDocumentNumber()
    '        Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"


    '        Dim iLetterType As Integer = 5



    '        CreateEASErecordExtracted(strDocumentNo, Replace(strDocumentNo, ".", "_"))






    '    Catch ex As Exception
    '        MessageBox.Show("The following error occurred in CreateEASErecord" & ex.Message, "Error producing EASE document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '        'Me.Close()
    '    End Try

    'End Sub


#End Region

#Region "Add Property"

    Private Sub btnAddPIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPIN.Click
        Dim NewPIN As Integer = 0
        With LIMESsearch
            .ShowDialog()
            NewPIN = .PIN
            .Dispose()
        End With

        If NewPIN = 0 Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddPIN_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertNewPropertyNo"
                        .Parameters.Add("@DANUM", SqlDbType.VarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@PIN", SqlDbType.Int).Value = NewPIN
                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddPIN_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnRemovePIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePIN.Click
        If MessageBox.Show("Remove Property number " & lstPINs.Text & " ?", "Remove PIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.cnDAsystem)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemovePIN_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_RemoveDAPin"
                            .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                            .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(lstPINs.SelectedValue)
                            .ExecuteNonQuery()
                        End With

                    End Using
                    cn.Close()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemovePIN_Click routine - form " & Me.Name)

                End Try
            End Using

            'reload file numbers
            Try
                Me.Property_NumbersTableAdapter.Fill(Me.DAdatasets.Property_Numbers, txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

#End Region

#Region "Integrated Development Tab"

    Private Sub cboReferralsIntProvision_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.SelectedValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If cboReferralsIntProvision.SelectedIndex <> -1 Then
            If MessageBox.Show("Add  " & cboReferralsIntProvision.Text & " ?", "Add ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.cnDAsystem)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_InsertNewReferralIntProvision"
                                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                                .Parameters.Add("@PROVISIONID", SqlDbType.Int).Value = CInt(cboReferralsIntProvision.SelectedValue)
                                .ExecuteNonQuery()
                            End With

                        End Using
                        cn.Close()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDANo.Text, "CC")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & Me.lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.cnDAsystem)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_DeleteReferralsIntProvision"
                            .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lstIntegrated.SelectedValue)
                            .ExecuteNonQuery()
                        End With

                    End Using
                    cn.Close()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Me.Name)

                End Try
            End Using
            'reload file numbers
            Try
                Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDANo.Text, "CC")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

#End Region


#Region "Documents Tab"
    Private Sub dgvDocumentsList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentsList.CellClick
        If IsANonHeaderButtonCell(e) Then
            DisplayPDFdocument()
        ElseIf IsANonHeaderTextCell(e) Then
            txtDocNote.Text = dgvDocumentsList.CurrentRow.Cells(6).Value.ToString

        End If

    End Sub

    Private Function IsANonHeaderTextCell(ByVal cellEvent As _
          DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewTextBoxColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

    Private Function IsANonHeaderButtonCell(ByVal cellEvent As _
        DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

    Private Sub DisplayPDFdocument()

        If dgvDocumentsList.CurrentRow.Cells(2).Value.ToString = String.Empty Then Exit Sub
        Dim sDocname As String = dgvDocumentsList.CurrentRow.Cells(2).Value.ToString
        Dim sMTH As String = dgvDocumentsList.CurrentRow.Cells(7).Value.ToString
        Dim sYr As String = dgvDocumentsList.CurrentRow.Cells(8).Value.ToString
        Dim sPDFDoc As String = String.Empty


        If sDocname.Length <= 8 Then
            Dim YeartoCheck As String = "20" & sDocname.Substring(InStr(sDocname, "_"), 2)
            If CLng(YeartoCheck) <> Today.Year Then
                sPDFDoc = My.Settings.ARCHIVE & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            Else
                sPDFDoc = My.Settings.HASHBIN & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            End If


        ElseIf sDocname.Length <> 0 Then
            If CLng(sYr) <> Today.Year Then
                sPDFDoc = My.Settings.HASHBIN & sYr & "\" & sMTH & "\" & sDocname

            Else
                sPDFDoc = My.Settings.ARCHIVE & sYr & "\" & sMTH & "\" & sDocname

            End If

        End If

        If sPDFDoc <> String.Empty Then
            Dim PDFviewer As New PDFviewer
            With PDFviewer
                .DocumentToDisplay = sPDFDoc
                .ShowDialog()
                .Dispose()
            End With
        End If


    End Sub
#End Region

#Region "File Notes Tab"
    Private Sub btnDocNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocNote.Click
        If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateDocumentNote"
                        .Parameters.Add("@ID", SqlDbType.NText).Value = Me.txtDocNote.Text
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(dgvDocumentsList.CurrentRow.Cells(10).Value)
                        .ExecuteNonQuery()
                    End With

                End Using
                cn.Close()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        txtDocNote.Text = String.Empty
        Try
            RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "DA", txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearNoteFields()
        Me.NoteDate.Text = String.Empty
        Me.txtNotesSubject.Text = String.Empty
        Me.txtNoteDetails.Text = String.Empty
        Me.txtNotesContactNo.Text = String.Empty
        Me.cboNoteType.SelectedValue = -1
        Me.txtNotesSpokeTo.Text = String.Empty
        Me.txtNotesCC.Text = String.Empty
        Me.txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        Me.cboNotesOfficer.SelectedValue = -1
        Me.btnNotesEdit.Enabled = False
        Me.btnNotesSave.Enabled = False
        btnNotesAdd.Enabled = True
        Me.btnNotePrint.Enabled = False
    End Sub

    Private Sub LockNotes(ByVal lock As Boolean)
        Me.NoteDate.ReadOnly = lock
        Me.txtNotesSubject.ReadOnly = lock
        Me.txtNoteDetails.ReadOnly = lock
        Me.txtNotesContactNo.ReadOnly = lock
        Me.cboNoteType.ReadOnly = lock
        Me.txtNotesSpokeTo.ReadOnly = lock
        Me.txtNotesCC.ReadOnly = lock
        Me.txtNotesFollowUp.ReadOnly = lock
        Me.cboNotesOfficer.ReadOnly = lock
        Me.btnNotesEdit.Enabled = lock
        Me.btnNotesSave.Enabled = Not lock
        btnNotesAdd.Enabled = lock
        Me.btnNotePrint.Enabled = Not lock

    End Sub

    Private Sub dgvFileNotes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFileNotes.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadNoteDetailsForEdit"

                        .Parameters.Add("@NOTEID", SqlDbType.Int).Value = CInt(dgvFileNotes.CurrentRow.Cells(6).Value)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.NoteDate.Text = Format(CDate(objDataRow.Item(0).ToString), "dd/MM/yyyy")
                        Me.txtNotesSubject.Text = objDataRow.Item(1).ToString
                        Me.txtNoteDetails.Text = objDataRow.Item(2).ToString
                        Me.txtNotesContactNo.Text = objDataRow.Item(3).ToString
                        Me.cboNoteType.SelectedValue = objDataRow.Item(4).ToString
                        Me.txtNotesSpokeTo.Text = objDataRow.Item(5).ToString
                        Me.txtNotesCC.Text = objDataRow.Item(6).ToString
                        Me.txtNotesFollowUp.Text = objDataRow.Item(7).ToString
                        Me.cboNotesOfficer.SelectedValue = CInt(objDataRow.Item(8).ToString)
                        Me.lblNotesID.Text = objDataRow.Item(9).ToString
                        Me.btnNotesEdit.Enabled = True
                        Me.btnNotesSave.Enabled = False
                        btnNotesAdd.Enabled = True
                        Me.btnNotePrint.Enabled = True
                        LockNotes(True)

                    Else
                        ClearNoteFields()
                    End If

                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnNotesAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesAdd.Click
        ClearNoteFields()
        LockNotes(False)
        Me.btnNotesSave.Enabled = True
        btnNotesAdd.Enabled = False
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub btnNotesEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesEdit.Click
        LockNotes(False)
        Me.btnNotesSave.Enabled = True
        btnNotesAdd.Enabled = True
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = True

    End Sub

    Private Sub btnNotesSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesSave.Click
        SaveNotesData()
        ClearNoteFields()
        LockNotes(True)
        Me.btnNotesSave.Enabled = False
        btnNotesAdd.Enabled = True
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub SaveNotesData()
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateFileNotes"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblNotesID.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@NOTEDATE", SqlDbType.SmallDateTime).Value = Format(CDate(NoteDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SUBJECT", SqlDbType.NVarChar).Value = Me.txtNotesSubject.Text
                        .Parameters.Add("@DETAIL", SqlDbType.NText).Value = Me.txtNoteDetails.Text
                        .Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = Me.txtNotesContactNo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "DA"
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = Me.cboNoteType.SelectedValue.ToString
                        .Parameters.Add("@SPOKEN", SqlDbType.NVarChar).Value = Me.txtNotesSpokeTo.Text
                        .Parameters.Add("@CC", SqlDbType.NVarChar).Value = Me.txtNotesCC.Text
                        .Parameters.Add("@FOLLOWUP", SqlDbType.NVarChar).Value = Me.txtNotesFollowUp.Text
                        .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = Me.cboNotesOfficer.SelectedValue.ToString
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = Me.txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

#End Region


#Region "From Events"


    Private Sub DALookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadSearchList()


        Me.InsuranceTableAdapter.Fill(Me.CCdata.Insurance)
        Me.CC_DocType_WordTemplateTableAdapter.Fill(Me.CCdata.CC_DocType_WordTemplate)
        Me.CCDescWorkTableAdapter.Fill(Me.CCdata.CCDescWork)
        Me.CCClassTableAdapter.Fill(Me.CCdata.CCClass)
        Me.CCBuildSolTableAdapter.Fill(Me.CCdata.CCBuildSol)
        Me.CCAppTypeTableAdapter.Fill(Me.AssessmentData.CCAppType)
        Me.AssessmentSheetTypeTableAdapter.Fill(Me.DAdatasets.AssessmentSheetType)
        Me.FileNoteTypeTableAdapter.Fill(Me.DAdatasets.FileNoteType)
        Me.LoadReferralsIntProvisionListTableAdapter.Fill(Me.DAdatasets.LoadReferralsIntProvisionList)
        Me.ReferralCodeTableAdapter.Fill(Me.DAdatasets.ReferralCode)
        Me.DAAuthorityTableAdapter.Fill(Me.DAdatasets.DAAuthority)
        Me.OfficerTableAdapter.Fill(Me.DAdatasets.Officer)
        Me.LocalityCodeTableAdapter.Fill(Me.DAdatasets.LocalityCode)
        Me.DADecisionTableAdapter.Fill(Me.DAdatasets.DADecision)
        Me.cboReferralsIntProvision.SelectedIndex = -1
        cboAppType.SelectedIndex = -1
        cboDecision.SelectedIndex = -1
        cboDAOfficer.SelectedIndex = -1
        cboDAAuthorityId.SelectedIndex = -1
        cboDADecisionId.SelectedIndex = -1
        cboDAlocalityCode.SelectedIndex = -1
        Me.cboConsentDocType.SelectedIndex = -1
        Me.cboSTDconditions.SelectedIndex = -1
        cboRefCodeId.SelectedIndex = -1
        Me.cboInsuranceName.SelectedIndex = -1
        Me.cboBuildersNames.SelectedIndex = -1





        Dim RFS As New ArrayList

        ' Add division structure entries to the arraylist
        With RFS
            .Add(New RFSSubvisionType("Residential", "2"))
            .Add(New RFSSubvisionType("Rural", "1"))
        End With

        With cboRFSSubDivisionType
            .DataSource = RFS
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With




    End Sub

    Private Sub lstSearchResults_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSearchResults.SelectedValueChanged
        If isloading Then Exit Sub
        LoadForm(lstSearchResults.SelectedValue.ToString)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub cboConsentDocType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboConsentDocType.SelectedValueChanged
        If cboConsentDocType.SelectedIndex = -1 Then Exit Sub
        Try
            Me.ListofConditionsByLetterTypeTableAdapter.Fill(Me.DAdatasets.ListofConditionsByLetterType, New System.Nullable(Of Integer)(CType(cboConsentDocType.SelectedValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCondition.Click
        If MessageBox.Show("Insert """ & Me.cboSTDconditions.Text & """ into the list?", "Insert condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        If CheckConditionAlreadyExists(CInt(cboSTDconditions.SelectedValue)) Then
            MessageBox.Show("Condition """ & Me.cboSTDconditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertIndividualSTDCondition"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboSTDconditions.SelectedValue)
                        .ExecuteNonQuery()

                    End With

                    Try
                        Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, Me.txtDANo.Text)
                    Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnAddOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOneOffCond.Click
        Dim fOneUpCond As New InsertOneUpCondition
        With fOneUpCond
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgvSTDConditions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSTDConditions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If TypeOf Me.dgvSTDConditions.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then
            If CBool(dgvSTDConditions.CurrentRow.Cells(2).Value) Then
                Dim fFreeForm As New DAConditionsFreeForm
                With fFreeForm
                    .ConditionCode = CInt(dgvSTDConditions.CurrentRow.Cells(0).Value)
                    .DANumber = Me.txtDANo.Text

                    .ShowDialog()
                    .Dispose()

                End With
            End If

        End If

    End Sub

    Private Sub btnRemoveOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOneOffCond.Click

        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOneUpCondition"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvOneUpConditions.CurrentRow.Cells(2).Value)
                        .ExecuteNonQuery()
                    End With



                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click


        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveConditionCode"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvSTDConditions.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()
                    End With



                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click
        If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub
        Try
            Dim objWordApp As New Microsoft.Office.Interop.Word.Application
            Dim objWordDoc As Microsoft.Office.Interop.Word.Document = objWordApp.Application.Documents.Open(Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString)
            objWordDoc.Activate()
            objWordApp.Visible = True

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click
        If Me.dgvDraftDocs.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString

        If MessageBox.Show("You are about to delete this word document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells(4).Value)
                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()

                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        InsertIntoDADocumentsTable(dgvDraftDocs.CurrentRow.Cells(1).Value.ToString, sDocumentNo.Replace(".", "_"))

        Dim summary As String = "Application No. " & txtDANo.Text & " Application Type: DA Document Type: " & dgvDraftDocs.CurrentRow.Cells(1).Value.ToString




        Dim fEASE As New InsertEASEdocument
        With fEASE
            .WordDocLocation = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString
            .CustName = Me.txtDAOwnersName.Text
            .CustAddress = Me.txtDAOwnersAddress.Text & " " & Me.txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With


        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString
        My.Computer.FileSystem.DeleteFile(FileToDelete)

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells(4).Value)
                        .ExecuteNonQuery()
                    End With
                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        Try
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnPrintAddinfoLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAddinfoLetter.Click
        'TODO: Write  code for btnPrintAddinfoLetter button

    End Sub

    Private Sub btnPrint100DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint100DayLetter.Click
        'TODO: Write  code for btnPrint100DayLetter button

    End Sub

    Private Sub btnPrint200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint200DayLetter.Click
        'TODO: Write  code for btnPrint200DayLetter button

    End Sub

    Private Sub btnPrintOver200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOver200DayLetter.Click
        'TODO: Write  code for btnPrintOver200DayLetter button

    End Sub

    Private Sub btnEditAddinfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAddinfoTab.Click
        LockTheForm(grpAddinfo, True)
        btnSaveAddInfoTab.Enabled = True
        btnEditAddinfoTab.Enabled = False

    End Sub

    Private Sub btnSaveAddInfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAddInfoTab.Click
        If Not CheckAdditionalInfo() Then Exit Sub

        LockTheForm(grpAddinfo, False)
        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = True

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveAddInfoTab_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_AdditionalInfo"

                        .Parameters.Add("@IDNO", SqlDbType.Int).Value = NZ(lblAdditionalInfoId.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@REQDATE", SqlDbType.SmallDateTime)
                        If IsDate(AIRequestDt.Text) Then .Parameters("@REQDATE").Value = Format(CDate(AIRequestDt.Text), "dd/MM/yyyy")


                        .Parameters.Add("@RECDDTE", SqlDbType.SmallDateTime)
                        If IsDate(AIReceivedDt.Text) Then .Parameters("@RECDDTE").Value = Format(CDate(AIReceivedDt.Text), "dd/MM/yyyy")

                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = AICommentTextBox.Text
                        .Parameters.Add("@LETRA200DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over200LetterADate.Text) Then .Parameters("@REQDATE").Value = Format(CDate(Over200LetterADate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@LETRB200DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over200LetterBDate.Text) Then .Parameters("@REQDATE").Value = Format(CDate(Over200LetterBDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@LETR100DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over100LetterDate.Text) Then .Parameters("@REQDATE").Value = Format(CDate(Over100LetterDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveAddInfoTab_Click routine - form " & Me.Name)

            End Try
        End Using



        Try
            Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "DA", txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try






    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        'TODO: Write  code for btnDraftconditions button - this is to be looked at in conjunction with SB towards end

    End Sub

    Private Sub btnMailResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailResponse.Click
        If Me.txtRefResponse.Text = String.Empty Then
            MessageBox.Show("There is nothing typed in the response area - please complete and try again", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Subject As String = "Referral Response for Appl No: " & Me.txtDANo.Text
        Dim Body As String = "Please find attached my response to your referral regarding application number " & vbCrLf & txtRefResponse.Text

        Dim emailaddress As String = GetEmailAddress()
        If emailaddress = String.Empty Then
            MessageBox.Show("Responsible Officer Not selected - Can't send e-mail !", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            MAIL.SendMailMessage("DA System@eurocoast.nsw.gov.au", emailaddress, "", "", Subject, Body, "")

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim fpopup As New ReferralsResponsePopUp
        With fpopup
            .ResponseText = Me.txtRefResponse.Text
            .ShowDialog()
            txtRefResponse.Text = .ResponseText
            .Dispose()
        End With

    End Sub

    Private Sub btnEditDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditDA.Click

        LockTheForm(Me.grpPropertyLotAddress, True)
        LockTheForm(Me.grpPropertyOwner, True)
        LockTheForm(Me.grpPropertyDescription, True)
        LockTheForm(Me.grpOwnerBuilder, True)
        LockTheForm(Me.grpInsurance, True)
        LockTheForm(Me.grpLicenceBuilder, True)
        LockTheForm(Me.grpMatWalls, True)
        LockTheForm(Me.grpMatRoof, True)
        LockTheForm(Me.grpFloor, True)
        LockTheForm(Me.grpFrame, True)
        LockTheForm(Me.grpAssessment, True)
        LockTheForm(Me.pnlPrimaryDetail, True)

        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True



        Me.btnAddPIN.Enabled = True
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = True



    End Sub

    Private Sub btnSaveDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveDA.Click
        LockTheForm(Me.grpPropertyLotAddress, False)
        LockTheForm(Me.grpPropertyOwner, False)
        LockTheForm(Me.grpPropertyDescription, False)
        LockTheForm(Me.grpOwnerBuilder, False)
        LockTheForm(Me.grpInsurance, False)
        LockTheForm(Me.grpLicenceBuilder, False)
        LockTheForm(Me.grpMatWalls, False)
        LockTheForm(Me.grpMatRoof, False)
        LockTheForm(Me.grpFloor, False)
        LockTheForm(Me.grpFrame, False)
        LockTheForm(Me.grpAssessment, False)
        LockTheForm(Me.pnlPrimaryDetail, False)

        btnEditDA.Enabled = True
        Me.btnSaveDA.Enabled = False
        btnAddCC.Enabled = True

        Me.btnAddPIN.Enabled = False
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = False

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CCUPDATE_Property"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@DALOT", SqlDbType.NVarChar).Value = Me.txtLot.Text
                        .Parameters.Add("@DADP", SqlDbType.NVarChar).Value = Me.txtDP.Text
                        .Parameters.Add("@DASECT", SqlDbType.NVarChar).Value = Me.txtSection.Text
                        .Parameters.Add("@DASTREETNO", SqlDbType.NVarChar).Value = Me.txtStreetNo.Text
                        .Parameters.Add("@DASTREETNAME", SqlDbType.NVarChar).Value = Me.txtStreetName.Text
                        .Parameters.Add("@LOCALITY", SqlDbType.Int).Value = CInt(cboDAlocalityCode.SelectedValue)
                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = Me.txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = Me.txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = Me.txtDAOwnersTown.Text
                        If txtDAOwnersPcode.Text <> String.Empty Then .Parameters.Add("@OWNERPCODE", SqlDbType.SmallInt).Value = CInt(txtDAOwnersPcode.Text)
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = Me.txtDAOwnersPhone.Text
                        .Parameters.Add("@CCDESC", SqlDbType.NVarChar).Value = Me.txtCCDesc.Text
                        If txtCCValue.Text <> String.Empty Then .Parameters.Add("@VALUE", SqlDbType.Money).Value = CDbl(txtCCValue.Text)
                        .Parameters.Add("@OWNERBLDER", SqlDbType.Bit).Value = Me.chkOwnerBuilder.CheckState
                        .Parameters.Add("@OWNERBLDRNO", SqlDbType.NVarChar).Value = txtCCOwnerBuilderNo.Text
                        .Parameters.Add("@LICBLDR", SqlDbType.Bit).Value = chkCCLicBuilder.CheckState
                        .Parameters.Add("@LICBLDRNAME", SqlDbType.NVarChar).Value = cboBuildersNames.Text
                        .Parameters.Add("@LICBLDRNO", SqlDbType.NVarChar).Value = txtLicBuilderNo.Text
                        .Parameters.Add("@LICBLDRPHONE", SqlDbType.NVarChar).Value = txtLicBuilderPhone.Text
                        .Parameters.Add("@INSURNO", SqlDbType.NVarChar).Value = txtCCInsuranceNo.Text
                        .Parameters.Add("@INSURNAME", SqlDbType.NVarChar).Value = cboInsuranceName.SelectedValue
                        .Parameters.Add("@LSL", SqlDbType.NVarChar).Value = txtLongServiceLevy.Text

                        If cboAppType.SelectedIndex <> -1 Then .Parameters.Add("@APPTYPE", SqlDbType.Int).Value = CInt(cboAppType.SelectedValue)
                        .Parameters.Add("@REGDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGDATE").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@ACKDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.txtAckDate.Text) Then .Parameters("@ACKDTE").Value = Format(CDate(txtAckDate.Text), "dd/MM/yyyy")


                        If cboDecision.SelectedIndex <> -1 Then .Parameters.Add("@DESCID", SqlDbType.Int).Value = CInt(cboDecision.SelectedValue)
                        If cboBldgCodeAust.SelectedIndex <> -1 Then .Parameters.Add("@CLASSID", SqlDbType.Int).Value = CInt(Me.cboBldgCodeAust.SelectedValue)
                        If cboBldgSolution.SelectedIndex <> -1 Then .Parameters.Add("@BLDGSOLID", SqlDbType.Int).Value = CInt(Me.cboBldgSolution.SelectedValue)
                        If cboDAOfficer.SelectedIndex <> -1 Then .Parameters.Add("@OFFICERID", SqlDbType.Int).Value = CInt(Me.cboDAOfficer.SelectedValue)
                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@STREET", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@POSTCODE", SqlDbType.NVarChar).Value = Me.txtAppPcode.Text
                        .Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .Parameters.Add("@MATW1", SqlDbType.Bit).Value = Me.CCMatW1CheckBox.CheckState
                        .Parameters.Add("@MATW2", SqlDbType.Bit).Value = CCMatW2CheckBox.CheckState
                        .Parameters.Add("@MATW3", SqlDbType.Bit).Value = CCMatW3CheckBox.CheckState
                        .Parameters.Add("@MATW4", SqlDbType.Bit).Value = CCMatW4CheckBox.CheckState
                        .Parameters.Add("@MATW5", SqlDbType.Bit).Value = CCMatW5CheckBox.CheckState
                        .Parameters.Add("@MATW6", SqlDbType.Bit).Value = CCMatW6CheckBox.CheckState
                        .Parameters.Add("@MATW7", SqlDbType.Bit).Value = CCMatW7CheckBox.CheckState
                        .Parameters.Add("@MATW8", SqlDbType.Bit).Value = CCMatW8CheckBox.CheckState
                        .Parameters.Add("@MATW9", SqlDbType.Bit).Value = CCMatW9CheckBox.CheckState
                        .Parameters.Add("@MATW10", SqlDbType.Bit).Value = CCMatW10CheckBox.CheckState
                        .Parameters.Add("@MATW11", SqlDbType.Bit).Value = CCMatW10CheckBox.CheckState
                        .Parameters.Add("@MATW12", SqlDbType.Bit).Value = CCMatW12CheckBox.CheckState
                        .Parameters.Add("@MATW13", SqlDbType.Bit).Value = CCMatW13CheckBox.CheckState
                        .Parameters.Add("@MATW14", SqlDbType.Bit).Value = CCMatW14CheckBox.CheckState
                        .Parameters.Add("@MATF1", SqlDbType.Bit).Value = chkConcretefloor.CheckState
                        .Parameters.Add("@MATF2", SqlDbType.Bit).Value = Me.chkTimberfloor.CheckState
                        .Parameters.Add("@MATF3", SqlDbType.Bit).Value = Me.chkOtherFloor.CheckState
                        .Parameters.Add("@MATF4", SqlDbType.Bit).Value = Me.chkunknownfloor.CheckState
                        .Parameters.Add("@MATR1", SqlDbType.Bit).Value = CCMatR1CheckBox.CheckState
                        .Parameters.Add("@MATR2", SqlDbType.Bit).Value = CCMatR2CheckBox.CheckState
                        .Parameters.Add("@MATR3", SqlDbType.Bit).Value = CCMatR3CheckBox.CheckState
                        .Parameters.Add("@MATR4", SqlDbType.Bit).Value = CCMatR4CheckBox.CheckState
                        .Parameters.Add("@MATR5", SqlDbType.Bit).Value = CCMatR5CheckBox.CheckState
                        .Parameters.Add("@MATR6", SqlDbType.Bit).Value = CCMatR6CheckBox.CheckState
                        .Parameters.Add("@MATR7", SqlDbType.Bit).Value = CCMatR7CheckBox.CheckState
                        .Parameters.Add("@MATR8", SqlDbType.Bit).Value = CCMatR8CheckBox.CheckState
                        .Parameters.Add("@MATR9", SqlDbType.Bit).Value = CCMatR9CheckBox.CheckState
                        .Parameters.Add("@MATR10", SqlDbType.Bit).Value = CCMatR10CheckBox.CheckState
                        .Parameters.Add("@MATR11", SqlDbType.Bit).Value = CCMatR11CheckBox.CheckState
                        .Parameters.Add("@MATC1", SqlDbType.Bit).Value = Me.chkFrameTimber.CheckState
                        .Parameters.Add("@MATC2", SqlDbType.Bit).Value = CCMatC2CheckBox.CheckState
                        .Parameters.Add("@MATC3", SqlDbType.Bit).Value = chkFrameOther.CheckState
                        .Parameters.Add("@MATC4", SqlDbType.Bit).Value = chkFrameUnknown.CheckState

                        .Parameters.Add("@TOOFFICER", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToPlannerDt.Text) Then .Parameters("@TOOFFICER").Value = Format(CDate(DAToPlannerDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DETERMINED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DecisionDt.Text) Then .Parameters("@DETERMINED").Value = Format(CDate(DecisionDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@INFORMDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.informedDte.Text) Then .Parameters("@INFORMDTE").Value = Format(CDate(informedDte.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SITEINSPECTDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.SiteInspectDte.Text) Then .Parameters("@SITEINSPECTDTE").Value = Format(CDate(SiteInspectDte.Text), "dd/MM/yyyy")

                        .Parameters.Add("@DECISIONID", SqlDbType.NVarChar).Value = CInt(cboDADecisionId.SelectedValue)
                        .Parameters.Add("@AUTHORITYID", SqlDbType.SmallInt).Value = CInt(Me.cboDAAuthorityId.SelectedValue)
                        .Parameters.Add("@FIRESAFETY", SqlDbType.Bit).Value = Me.chkFireSafety.CheckState
                        .Parameters.Add("@PLANNO", SqlDbType.NVarChar).Value = Me.txtCouncilPlanNo.Text




                        '.Parameters.Add("", SqlDbType.Money).Value = CDbl(txtCCValue.Text)
                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnAssembleLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssembleLetter.Click
        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboConsentDocType.SelectedValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboConsentDocType.SelectedValue)
                            docname = objDataReader.Item(0).ToString
                            docfilename = objDataReader.Item(1).ToString
                            MacroName = objDataReader.Item(2).ToString
                        Loop
                        objDataReader.Close()
                    End Using



                End Using
                cn.Close()

                CreateWordDocs(docType, Me.txtDANo.Text, docname, docfilename, MacroName, sysType)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub cboRefCodeId_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRefCodeId.SelectedValueChanged
        Select Case CInt(cboRefCodeId.SelectedValue)
            Case 2, 3, 59
                Me.grpRFS.Visible = True
            Case Else
                Me.grpRFS.Visible = False

        End Select



    End Sub

    Private Sub chksepp71_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksepp71.CheckStateChanged
        If chksepp71.CheckState = CheckState.Checked Then
            Me.grpSepp71.Visible = True
        Else
            Me.grpSepp71.Visible = False

        End If
    End Sub

    Private Sub dgvLoadListReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoadListReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then
            Try
                Me.ReferalInfoTableAdapter.Fill(Me.DAdatasets.ReferalInfo, CInt(dgvLoadListReferrals.CurrentRow.Cells(0).Value))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            LockTheForm(pnlButtons, False)
            LockTheForm(grpMain, False)
            LockTheForm(grpRFS, False)
            LockTheForm(grpIntDesig, False)
            LockTheForm(grpEngineers, False)
            LockTheForm(grpSepp71, False)
            btnView.Enabled = True
            Me.btnEditReferralsTab.Enabled = True
            btnSaveReferralsTab.Enabled = False

        End If

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If


    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click
        btnAddReferral.Enabled = False
        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty
        lstIntegrated.Items.Clear()
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)

    End Sub

    Private Sub dgvRetrieveListOfReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRetrieveListOfReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then

            Try
                Me.RequestForAdditionalInfoDataTableAdapter.Fill(Me.DAdatasets.RequestForAdditionalInfoData, CInt(dgvRetrieveListOfReferrals.CurrentRow.Cells(0).Value))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        LockTheForm(grpAddinfo, False)

        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = True

        btnPrintAddinfoLetter.Enabled = True
        btnPrint200DayLetter.Enabled = True
        btnPrint100DayLetter.Enabled = True
        btnPrintOver200DayLetter.Enabled = True

    End Sub

    Private Sub btnADDAddinfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADDAddinfoTab.Click
        LockTheForm(grpAddinfo, True)
        btnEditAddinfoTab.Enabled = False
        btnSaveAddInfoTab.Enabled = True
        btnPrintAddinfoLetter.Enabled = True
        btnPrint200DayLetter.Enabled = True
        btnPrint100DayLetter.Enabled = True
        btnPrintOver200DayLetter.Enabled = True
        ClearAddInfoData(grpAddinfo)
    End Sub

    Private Sub cboBuildersNames_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBuildersNames.SelectedValueChanged
        If cboBuildersNames.SelectedIndex = -1 Then Exit Sub

        Dim mlist As BuilderNames = CType(cboBuildersNames.SelectedItem, BuilderNames)
        Me.txtLicBuilderNo.Text = mlist.Licence.ToString
        Me.txtLicBuilderPhone.Text = mlist.Phone.ToString


    End Sub


    Private Sub btnEditReferralsTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditReferralsTab.Click
        btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)

    End Sub

    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        btnEditReferralsTab.Enabled = True
        btnSaveReferralsTab.Enabled = False
        LockTheForm(grpMain, False)
        LockTheForm(pnlButtons, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Referrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                        .Parameters.Add("@REFDATE", SqlDbType.SmallDateTime)
                        If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
                        If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.SelectedValue)
                        .Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
                        .Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
                        .Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
                        .Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
                        .Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If cboRFSSubDivisionType.SelectedIndex <> -1 Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.SelectedValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.Text), "dd/MM/yyyy")
                        .ExecuteNonQuery()
                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnRetrieveProperty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRetrieveProperty.Click
        If Me.lstPINs.Text = String.Empty Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnLIMES)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveProperty_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RatesData"

                        .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(lstPINs.Text)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtLot.Text = objDataRow.Item("Lot").ToString
                        Me.txtDP.Text = objDataRow.Item("DP").ToString
                        Me.txtSection.Text = objDataRow.Item("Sec").ToString
                        Me.txtStreetNo.Text = objDataRow.Item("HOFR").ToString
                        Me.txtStreetName.Text = objDataRow.Item("Street Name").ToString
                        Me.cboDAlocalityCode.SelectedValue = CInt(objDataRow.Item("LOC"))
                        Me.txtDAOwnersName.Text = objDataRow.Item("Name").ToString
                        Me.txtDAOwnersAddress.Text = objDataRow.Item("Add1").ToString
                        Me.txtDAOwnersTown.Text = objDataRow.Item("Addrs").ToString
                        Me.txtDAOwnersPcode.Text = objDataRow.Item("POST").ToString

                    End If


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveProperty_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnAddCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCC.Click
        LockTheForm(Me.grpPropertyLotAddress, False)
        LockTheForm(Me.grpPropertyOwner, False)
        LockTheForm(Me.grpPropertyDescription, False)
        LockTheForm(Me.grpOwnerBuilder, False)
        LockTheForm(Me.grpInsurance, False)
        LockTheForm(Me.grpLicenceBuilder, False)
        LockTheForm(Me.grpMatWalls, False)
        LockTheForm(Me.grpMatRoof, False)
        LockTheForm(Me.grpFloor, False)
        LockTheForm(Me.grpFrame, False)
        LockTheForm(Me.grpAssessment, False)
        LockTheForm(Me.pnlPrimaryDetail, False)

        ClearData(Me.grpPropertyLotAddress)
        ClearData(Me.grpPropertyOwner)
        ClearData(Me.grpPropertyDescription)
        ClearData(Me.grpOwnerBuilder)
        ClearData(Me.grpInsurance)
        ClearData(Me.grpLicenceBuilder)
        ClearData(Me.grpMatWalls)
        ClearData(Me.grpMatRoof)
        ClearData(Me.grpFloor)
        ClearData(Me.grpFrame)
        ClearData(Me.grpAssessment)
        ClearData(Me.pnlPrimaryDetail)


        'lstPINs.DataSource = Nothing

        Try
            Me.Property_NumbersTableAdapter.Fill(Me.DAdatasets.Property_Numbers, "")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Try
            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, "", "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, "", "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.txtReceipts.Text = String.Empty
        Me.txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty


        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True
        btnAddCC.Enabled = False



        Me.btnAddPIN.Enabled = True
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = True

        Dim fAddNew As New AddNewCC
        With fAddNew
            .DAnumber = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()

            .Dispose()

        End With

    End Sub

#End Region

#Region "Date Buttons"
    Private Sub btnRefToPlanCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefToPlanCom.Click
        RetrieveDate(SiteInspectDte)

    End Sub

    Private Sub btnDARegoDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDARegoDt.Click
        RetrieveDate(DARegoDt)
    End Sub

    Private Sub btnDAToPlannerDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAToPlannerDt.Click
        RetrieveDate(DAToPlannerDt)
    End Sub

    Private Sub btnDASiteInspectedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDASiteInspectedDt.Click
        RetrieveDate(DecisionDt)
    End Sub

    Private Sub btndtRego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndtRego.Click
        RetrieveDate(dtRego)

    End Sub


    Private Sub btnAIReceivedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAIReceivedDt.Click
        RetrieveDate(AIReceivedDt)
    End Sub

    Private Sub btnRefdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefdt.Click
        RetrieveDate(Refdt)
    End Sub

    Private Sub btnRefRetDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefRetDt.Click
        RetrieveDate(RefRetDt)
    End Sub

    Private Sub btnEngDueReturnDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEngDueReturnDate.Click
        RetrieveDate(EngDueReturnDate)
    End Sub

    Private Sub btnNoteDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteDate.Click
        RetrieveDate(NoteDate)
    End Sub

    Private Sub btnAIRequestDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAIRequestDt.Click
        RetrieveDate(AIRequestDt)
    End Sub

    Private Sub btnPreAssessCompleteDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreAssessCompleteDate.Click
        RetrieveDate(informedDte)
    End Sub

    Private Sub btnCertSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCertSent.Click
        RetrieveDate(certsentDte)
    End Sub


    Private Sub btnackdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnackdate.Click
        RetrieveDate(txtAckDate)

    End Sub



#End Region

#Region "Work to be done here"




    Private Sub btnPrintsepp71_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReferral.Click
        'TODO: Write  code for btnPrintsepp71 button why do we need it it is a memo alread send email

    End Sub


    Private Sub btnNotePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrint.Click
        'TODO: Write  code for btnNotePrint button

    End Sub

    Private Sub btnPrintRFSOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSOther.Click
        'TODO: Write  code for btnPrintRFSOther button - this is to be looked at in conjunction with SB towards end
    End Sub

    Private Sub btnPrintRFSSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSSub.Click
        'TODO: Write  code for btnPrintRFSSub button - this is to be looked at in conjunction with SB towards end
    End Sub




#End Region







    Private Sub ConstructionCerticate_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DALookup.Show()
    End Sub
End Class
