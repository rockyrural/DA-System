Imports System.Data.SqlClient
Imports WORD = Microsoft.Office.Interop.Word

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.IO
Imports ADHelpr = ADHelper.ADHelper
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI



Public Class ConstructionCertifcate

#Region "Declarations"
    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private isloading As Boolean
    Private ADHelper As New ADHelpr

#End Region

#Region "Functions and Sub routines"

    Private DAUse As Integer
    Public WriteOnly Property DAUseType() As Integer
        Set(ByVal value As Integer)
            DAUse = value
        End Set
    End Property

    Private DAno As String
    Public WriteOnly Property DANumber() As String
        Set(ByVal value As String)
            DAno = value
        End Set
    End Property

    Public WriteOnly Property FileNumber() As String
        Set(ByVal value As String)
            Me.txtFileNo.Text = value
        End Set
    End Property


    Public ReadOnly Property CCNo() As String
        Get
            Return Me.txtCCno.Text
        End Get
    End Property
    'Private Function CalculateElapsedDays(ByVal DAno As String) As Integer

    '    Dim dateVar As Date = CDate("1/1/1900")
    '    Dim objDT As New DataTable
    '    Dim dayscount As Integer

    '    Using cn As New SqlConnection(My.Settings.DataConnection)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_NetReferalDays"

    '                    .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DAno
    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '            End Using
    '             



    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

    '        End Try
    '    End Using




    '    If objDT.Rows.Count > 0 Then
    '        For count2 As Integer = 0 To objDT.Rows.Count - 1
    '            Dim objdatarow2 As DataRow = objDT.Rows.Item(count2)

    '            If Not IsDBNull(objdatarow2.Item("RefRetDt")) And Not IsDBNull(objdatarow2.Item("Refdt")) Then

    '                'If (objdatarow2.Item("RefRetDt") <> null) And (objdatarow2.Item("RefDt") <> null) Then
    '                If DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar) > 0 Then

    '                ElseIf DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("Refdt"))) <= 0 Then
    '                    dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar))
    '                    dateVar = CDate(objdatarow2.Item("RefRetDt"))

    '                Else
    '                    dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("Refdt")), CDate(objdatarow2.Item("RefRetDt"))))
    '                    dateVar = CDate(objdatarow2.Item("RefRetDt"))

    '                End If
    '            End If
    '        Next
    '    End If
    '    Return dayscount
    'End Function

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        'If TheNewDate <> String.Empty Then datefield.Text = TheNewDate
        datefield.Text = TheNewDate

    End Sub

    Private Sub LoadSummaryData(ByVal DaNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSummayData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DASummaryData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DaNo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    DALotTextBox.Text = String.Empty
                    DASectionTextBox.Text = String.Empty
                    DADPTextBox.Text = String.Empty
                    PINTextBox.Text = String.Empty
                    DAPropNoTextBox.Text = String.Empty
                    DACompletedDtMaskedTextBox.Text = String.Empty
                    DAAppNotDtMaskedTextBox.Text = String.Empty
                    AddressTextBox.Text = String.Empty
                    DAOwnersNameTextBox.Text = String.Empty
                    DADetermDtMaskedTextBox.Text = String.Empty
                    DADescTextBox.Text = String.Empty
                    DAEstCostTextBox.Text = String.Empty
                    DAClassificationTextBox.Text = String.Empty
                    txtLot.Text = String.Empty
                    txtDP.Text = String.Empty
                    txtSection.Text = String.Empty
                    txtStreetNo.Text = String.Empty
                    txtStreetName.Text = String.Empty
                    txtDAOwnersName.Text = String.Empty
                    txtDAOwnersAddress.Text = String.Empty
                    txtDAOwnersTown.Text = String.Empty
                    txtDAOwnersPcode.Text = String.Empty
                    txtDAOwnersPhone.Text = String.Empty
                    cboDAlocalityCode.SelectedIndex = -1
                    txtFileNo.Text = String.Empty

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        DALotTextBox.Text = objDataRow.Item("DALot").ToString
                        DASectionTextBox.Text = objDataRow.Item("DASection").ToString
                        DADPTextBox.Text = objDataRow.Item("DADP").ToString
                        PINTextBox.Text = objDataRow.Item("PIN").ToString
                        txtFileNo.Text = objDataRow.Item("DAFileNo").ToString
                        DAPropNoTextBox.Text = objDataRow.Item("DAPropNo").ToString
                        If Not IsDBNull(objDataRow.Item("DACompletedDt")) Then DACompletedDtMaskedTextBox.Text = Format(CDate(objDataRow.Item("DACompletedDt")), "dd/MM/yyyy")
                        If Not IsDBNull(objDataRow.Item("DAAppNotDt")) Then DAAppNotDtMaskedTextBox.Text = Format(CDate(objDataRow.Item("DAAppNotDt")), "dd/MM/yyyy")
                        AddressTextBox.Text = objDataRow.Item("Address").ToString
                        DAOwnersNameTextBox.Text = objDataRow.Item("DAOwnersName").ToString
                        If Not IsDBNull(objDataRow.Item("DADetermDt")) Then DADetermDtMaskedTextBox.Text = Format(CDate(objDataRow.Item("DADetermDt")), "dd/MM/yyyy")
                        DADescTextBox.Text = objDataRow.Item("DADesc").ToString
                        If Not IsDBNull(objDataRow.Item("DAEstCost")) Then DAEstCostTextBox.Text = Format(objDataRow.Item("DAEstCost"), "Currency")
                        DAClassificationTextBox.Text = objDataRow.Item("DAClassification").ToString
                        txtLot.Text = objDataRow.Item("DALot").ToString
                        txtDP.Text = objDataRow.Item("DADP").ToString
                        txtSection.Text = objDataRow.Item("DASection").ToString
                        txtStreetNo.Text = objDataRow.Item("DAStreetNo").ToString
                        txtStreetName.Text = objDataRow.Item("DAStreet").ToString
                        txtDAOwnersName.Text = objDataRow.Item("DAOwnersName").ToString
                        txtDAOwnersAddress.Text = objDataRow.Item("DAOwnersPAddr").ToString
                        txtDAOwnersTown.Text = objDataRow.Item("DAOwnersTown").ToString
                        txtDAOwnersPcode.Text = objDataRow.Item("DAOwnersPC").ToString
                        txtDAOwnersPhone.Text = objDataRow.Item("DAOwnersPhone").ToString
                        cboDAlocalityCode.SelectedValue = objDataRow.Item("DALocalityCodeID").ToString

                    End If

                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSummayData routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadForm(ByVal CCno As String)
        Me.btnRemoveDocument.Enabled = False

        Try
            Me.CCApplicationTableAdapter.Fill(Me.CCdata.CCApplication, CCno, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        LoadSummaryData(txtDANo.Text)

        'Try
        '    Me.DASummaryDataTableAdapter.Fill(Me.DAdatasets.DASummaryData, Me.txtDANo.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        Try
            Me.Property_NumbersTableAdapter.Fill(Me.DAdatasets.Property_Numbers, Me.txtDANo.Text)
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
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "CC", Me.txtCCno.Text)
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


        DisplayDraftDocuments(CCno)

        'Try
        '    Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, CCno)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try


        Try
            Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtCCno.Text, "CC")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "CC", txtCCno.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        LoadBuildersNames()
        LoadCC_ClassIds(CCno)

        btnEditDA.Enabled = True
        Me.btnEditAddinfoTab.Enabled = True
        Me.btnEditReferralsTab.Enabled = True
        Me.btnAddReferral.Enabled = True
        btnEditAddinfoTab.Enabled = True
        Me.btnSaveDA.Enabled = False
        Me.btnAddCC.Enabled = True
        Me.btnEditReferralsTab.Enabled = False
        btnEditBuilder.Enabled = True
        btnEditMaterials.Enabled = True
        btnEditStatus.Enabled = True

        LockTheForm(Me.pnlPrimaryDetail, False)
        LockTheForm(Me.grpOwnerBuilder, False)
        LockTheForm(Me.grpInsurance, False)
        LockTheForm(Me.grpLicenceBuilder, False)
        Me.txtLongServiceLevy.ReadOnly = True
        LockTheForm(Me.grpPropertyLotAddress, True)
        LockTheForm(Me.grpPropertyOwner, False)
        LockTheForm(Me.grpAssessment, False)
        LockTheForm(Me.grpMatWalls, False)
        LockTheForm(Me.grpMatRoof, False)
        LockTheForm(Me.grpFloor, False)
        LockTheForm(Me.grpFrame, False)



    End Sub



    Private Sub DisplayDraftDocuments(CCno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayDraftDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "DisplayListOfDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CCno
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvDraftDocs.DataSource = objDT
                    dgvDraftDocs.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayDraftDocuments routine - form " & Me.Name)

            End Try
        End Using


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


        Using Connection As New SqlConnection(My.Settings.DataConnection)
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

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
        Using cn As New SqlConnection(My.Settings.DataConnection)
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




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub InsertIntoDADocumentsTable(ByVal DocType As String, ByVal FileName As String)
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "CC"
                        .Parameters.Add("@AUTHOR", SqlDbType.Int).Value = MyUserId
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = FileName
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function GetEmailAddress() As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblOfficer.Tag)
                        .Parameters.Add("@EMAIL", SqlDbType.NVarChar, 200).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@EMAIL").Value.ToString
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub ClearReferralData(ByVal Pnl As Control)
        For Each ctrl As Control In Pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
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
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
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


        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                            cboBuildersNames.Items.Add(New BuilderNames(objDataReader("Name").ToString, objDataReader("Acc_Lic_no").ToString, objDataReader("Address").ToString, objDataReader("Town").ToString, objDataReader("PC").ToString, objDataReader("Phone").ToString, CInt(objDataReader("ID"))))
                        Loop
                        objDataReader.Close()
                        cboBuildersNames.SelectedIndex = -1
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadSearchList()

        Using cn As New SqlConnection(My.Settings.DataConnection)
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




                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                Select Case cb.Name
                    Case "btnViewOfficers", "btnAssignOfficer"
                        cb.Enabled = True

                    Case Else
                        cb.Enabled = bLock

                End Select
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = Not bLock
            ElseIf TypeOf ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                Dim cb As DevExpress.XtraEditors.LookUpEdit = DirectCast(ctrl, DevExpress.XtraEditors.LookUpEdit)
                cb.ReadOnly = Not bLock
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim cb As RadioButton = DirectCast(ctrl, RadioButton)
                cb.Enabled = bLock

            End If
        Next
    End Sub

    Private Sub ClearData(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
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

    Private Sub SaveCCDatat()

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_CCUPDATE_PropertyTab"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@DALOT", SqlDbType.NVarChar).Value = Me.txtLot.Text
                        .Parameters.Add("@DADP", SqlDbType.NVarChar).Value = Me.txtDP.Text
                        .Parameters.Add("@DASECT", SqlDbType.NVarChar).Value = Me.txtSection.Text
                        .Parameters.Add("@DASTREETNO", SqlDbType.NVarChar).Value = Me.txtStreetNo.Text
                        .Parameters.Add("@DASTREETNAME", SqlDbType.NVarChar).Value = Me.txtStreetName.Text
                        .Parameters.Add("@LOCALITY", SqlDbType.Int)
                        If cboDAlocalityCode.SelectedIndex <> -1 Then .Parameters("@LOCALITY").Value = CInt(cboDAlocalityCode.SelectedValue)


                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = Me.txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = Me.txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = Me.txtDAOwnersTown.Text
                        .Parameters.Add("@OWNERPCODE", SqlDbType.SmallInt)
                        If txtDAOwnersPcode.Text <> String.Empty Then .Parameters("@OWNERPCODE").Value = CInt(txtDAOwnersPcode.Text)
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = Me.txtDAOwnersPhone.Text
                        .Parameters.Add("@CCDESC", SqlDbType.NVarChar).Value = Me.txtCCDesc.Text
                        .Parameters.Add("@VALUE", SqlDbType.Money)
                        If txtCCValue.Text <> String.Empty Then .Parameters("@VALUE").Value = CDbl(txtCCValue.Text)
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub SaveStatusData()
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_CCUPDATE_StatusTab"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text


                        .Parameters.Add("@TOOFFICER", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToPlannerDt.Text) Then .Parameters("@TOOFFICER").Value = Format(CDate(DAToPlannerDt.Text), "dd/MM/yyyy")

                        If IsDate(Me.bldgSurveyorDte.Text) Then .Parameters.Add("@TOBLGSURV", SqlDbType.SmallDateTime).Value = Format(CDate(bldgSurveyorDte.Text), "dd/MM/yyyy")

                        .Parameters.Add("@DETERMINED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DecisionDt.Text) Then .Parameters("@DETERMINED").Value = Format(CDate(DecisionDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@INFORMDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.informedDte.Text) Then .Parameters("@INFORMDTE").Value = Format(CDate(informedDte.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SITEINSPECTDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.SiteInspectDte.Text) Then .Parameters("@SITEINSPECTDTE").Value = Format(CDate(SiteInspectDte.Text), "dd/MM/yyyy")
                        .Parameters.Add("@POSTEDDT", SqlDbType.SmallDateTime)
                        If IsDate(Me.certsentDte.Text) Then .Parameters("@POSTEDDT").Value = Format(CDate(certsentDte.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DECISIONID", SqlDbType.NVarChar)
                        If cboDADecisionId.SelectedIndex <> -1 Then .Parameters("@DECISIONID").Value = CInt(cboDADecisionId.SelectedValue)
                        .Parameters.Add("@AUTHORITYID", SqlDbType.SmallInt)
                        If cboDAAuthorityId.SelectedIndex <> -1 Then .Parameters("@AUTHORITYID").Value = CInt(Me.cboDAAuthorityId.SelectedValue)
                        .Parameters.Add("@FIRESAFETY", SqlDbType.Bit).Value = Me.chkFireSafety.CheckState
                        .Parameters.Add("@PLANNO", SqlDbType.NVarChar).Value = Me.txtCouncilPlanNo.Text
                        .Parameters.Add("@OFFICERSCOMMENT", SqlDbType.NVarChar).Value = Me.txtOfficerComment.Text

                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub SaveMaterialsData()
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_CCUPDATE_MaterialTab"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
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
                        .Parameters.Add("@ROOFCOLOR", SqlDbType.NVarChar).Value = Me.txtMatRoofColour.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub SaveHeaderData()
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_UPDATE_ConstructionCertificateHeader"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        If cboAppType.SelectedIndex <> -1 Then .Parameters.Add("@APPTYPE", SqlDbType.Int).Value = CInt(cboAppType.SelectedValue)
                        .Parameters.Add("@REGDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGDATE").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DESCID", SqlDbType.Int)
                        If cboDecision.SelectedIndex <> -1 Then .Parameters("@DESCID").Value = CInt(cboDecision.SelectedValue)
                        .Parameters.Add("@BLDGSOLID", SqlDbType.Int)
                        If cboBldgSolution.SelectedIndex <> -1 Then .Parameters("@BLDGSOLID").Value = CInt(Me.cboBldgSolution.SelectedValue)
                        .Parameters.Add("@OFFICERID", SqlDbType.Int)
                        'If cboDAOfficer.SelectedIndex <> -1 Then .Parameters("@OFFICERID").Value = CInt(Me.cboDAOfficer.SelectedValue)
                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@STREET", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@POSTCODE", SqlDbType.NVarChar).Value = Me.txtAppPcode.Text
                        .Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .Parameters.Add("@CCDESC", SqlDbType.NVarChar).Value = Me.txtCCDesc.Text
                        If txtCCValue.Text <> String.Empty Then .Parameters.Add("@VALUE", SqlDbType.Money).Value = CDbl(txtCCValue.Text)

                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Function HasBeenDetermined() As Boolean
        Dim Result As Boolean

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in HasBeenDetermined routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CC_FindOutIfDetermined"

                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@DETERMINED", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        Result = CInt(.Parameters("@DETERMINED").Value)
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in HasBeenDetermined routine - form " & Me.Name)

            End Try
        End Using


        Return Result


    End Function

    Private Sub PrintLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer)

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("CCName").ToString
            OwnerAddress = objDataRow.Item("Street").ToString & " " & objDataRow.Item("CCTown").ToString
            FileNo = txtFileNo.Text

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
            End With


            rptDocument.PrintToPrinter(1, False, 1, 99)

            If Copies = 2 Then

                Dim myPrintOptionsTwo As PrintOptions = rptDocument.PrintOptions
                myPrintOptionsTwo.PrinterName = My.Settings.DefaultPrinter
                myPrintOptionsTwo.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
                myPrintOptionsTwo.CustomPaperSource = GetSelectedSecondPaperSource()
                rptDocument.PrintToPrinter(1, False, 1, 99)

            End If
            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")

            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            Dim fEase As New OutwardEaseCorro

            With fEase
                .CustName = OwnerName
                .CustAddress = OwnerAddress
                .FileNumber = FileNo
                .DocSummary = Summary & Me.txtCCno.Text
                .DocumnetNo = strDocumentNo
                .ShowDialog()
                .Dispose()
            End With

            If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
                FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
            End If

            rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)
            FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)

            Dim InsertDocData As New InsertDocumentData
            With InsertDocData
                .ApplicationType = "CC"
                .DocumentType = "CC"
                .ApplicationNo = Me.txtCCno.Text
                .TheAuthor = MyUserId
                .TheImageName = Replace(strDocumentNo, ".", "_")
                .Notes = Summary & Me.txtCCno.Text
                .InsertDocumentsIntoDAsystem()
            End With


        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintLetter")
        Finally
            rptDocument.Close()

        End Try


    End Sub

    Private Sub SaveReferralData()
        LockTheForm(grpAddinfo, False)
        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = True

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
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
                        .Parameters.Add("@RequestNo", SqlDbType.Int).Direction = ParameterDirection.Output

                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"

                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveAddInfoTab_Click routine - form " & Me.Name)

            End Try
        End Using



        Try
            Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "CC", txtCCno.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PrintReferralLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, ByVal DocType As String)

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("DAAppName").ToString
            OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
            FileNo = objDataRow.Item("DAFileNo").ToString

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedPaperSource()
            With rptDocument
                .Load(strReportPath)

                If DocType = "N" Then
                    .SetDataSource("C:\GIS\DOCS\mapmerge.txt")

                Else
                    .SetDataSource(objDtable)

                End If
                .VerifyDatabase()
            End With


            rptDocument.PrintToPrinter(1, False, 1, 99)

            If Copies = 2 Then

                Dim myPrintOptionsTwo As PrintOptions = rptDocument.PrintOptions
                myPrintOptionsTwo.PrinterName = My.Settings.DefaultPrinter
                myPrintOptionsTwo.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
                myPrintOptionsTwo.CustomPaperSource = GetSelectedSecondPaperSource()
                rptDocument.PrintToPrinter(1, False, 1, 99)

            End If


            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")


            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"


            Dim fEase As New OutwardEaseCorro

            With fEase
                .CustName = OwnerName
                .CustAddress = OwnerAddress
                .FileNumber = FileNo
                .DocSummary = Summary & Me.txtCCno.Text
                .DocumnetNo = strDocumentNo
                .ShowDialog()
                .Dispose()
            End With

            If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
                FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
            End If

            rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)

            FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)

            If DocType <> "NO" Then
                Dim InsertDocData As New InsertDocumentData
                With InsertDocData
                    .ApplicationType = "CC"
                    .DocumentType = DocType
                    .ApplicationNo = Me.txtCCno.Text
                    .TheAuthor = MyUserId
                    .TheImageName = Replace(strDocumentNo, ".", "_")
                    '.Notes = txtLetterNotes.Text
                    .InsertDocumentsIntoDAsystem()
                End With

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try


    End Sub

    Private Sub PrintButDontEase(ByVal objDtable As DataTable, ByVal reportName As String)
        Dim rptDocument As New ReportDocument

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
            End With


            rptDocument.PrintToPrinter(1, False, 1, 99)


        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintButDontEase")
        Finally
            rptDocument.Close()

        End Try

    End Sub

    Private Sub PrintOnPlainPaperOnly(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer)
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("DAAppName").ToString
            OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
            FileNo = objDataRow.Item("DAFileNo").ToString

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
            End With


            rptDocument.PrintToPrinter(1, False, 1, 99)


            'Dim strDocumentNo As String = GetNextDocumentNumber()
            'Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            'Dim fEase As New OutwardEaseCorro

            'With fEase
            '    .CustName = OwnerName
            '    .CustAddress = OwnerAddress
            '    .FileNumber = FileNo
            '    .DocSummary = Summary & Me.txtDANo.Text
            '    .DocumnetNo = strDocumentNo
            '    .ShowDialog()
            '    .Dispose()
            'End With

            'If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
            '    FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
            'End If

            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)
            'FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)


        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try

    End Sub

    Private Sub SaveBuilderData()
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "[usp_CCUPDATE_BuilderTab]"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@OWNERBLDER", SqlDbType.Bit).Value = Me.chkOwnerBuilder.CheckState
                        .Parameters.Add("@OWNERBLDRNO", SqlDbType.NVarChar).Value = txtCCOwnerBuilderNo.Text
                        .Parameters.Add("@LICBLDR", SqlDbType.Bit).Value = chkCCLicBuilder.CheckState
                        .Parameters.Add("@LICBLDRNAME", SqlDbType.NVarChar).Value = cboBuildersNames.Text
                        .Parameters.Add("@LICBLDRNO", SqlDbType.NVarChar).Value = txtLicBuilderNo.Text
                        .Parameters.Add("@LICBLDRPHONE", SqlDbType.NVarChar).Value = txtLicBuilderPhone.Text
                        .Parameters.Add("@INSURNO", SqlDbType.NVarChar).Value = txtCCInsuranceNo.Text
                        If Not cboInsuranceName.EditValue Is Nothing Then .Parameters.Add("@INSURNAME", SqlDbType.NVarChar).Value = cboInsuranceName.EditValue.ToString
                        .Parameters.Add("@LSL", SqlDbType.NVarChar).Value = txtLongServiceLevy.Text


                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub CheckIfDataChanged()
        Dim changed As Boolean = False

        If btnSaveDA.Enabled Or Me.btnSaveBuilder.Enabled Or Me.btnSaveMaterials.Enabled Or Me.btnSaveStatus.Enabled Then
            changed = True
        End If

        If changed Then
            If MessageBox.Show("It appears you have updated some information, save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                If Me.btnSaveDA.Enabled Then SaveHeaderData()

                If Me.btnSaveBuilder.Enabled Then SaveBuilderData()

                If Me.btnSaveMaterials.Enabled Then SaveMaterialsData()

                If Me.btnSaveStatus.Enabled Then SaveStatusData()
            End If
        End If

    End Sub

#End Region

#Region "EASE Functions"

    'Private Function GetNextDocumentNumber() As String
    '    Dim Returnvalue As String = String.Empty

    '    Try

    '        Dim cmd As New SqlCommand
    '        Dim cn As New SqlConnection(My.Settings.cnEASE)


    '        With cmd
    '            .Connection = cn
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "usp_Common_GetNextDocumentNo"
    '            .Parameters.Add("@NEWDOCID", SqlDbType.VarChar, 15, Nothing)

    '            .Parameters("@NEWDOCID").Direction = ParameterDirection.Output
    '        End With


    '        cn.Open()
    '        cmd.ExecuteNonQuery()


    '        Returnvalue = cmd.Parameters("@NEWDOCID").Value.ToString
    '         

    '        Return Returnvalue
    '    Catch ex As Exception
    '        MessageBox.Show("The following error has occured in routine GetNextDocumentNumber " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return Returnvalue
    '    End Try





    '    Return Returnvalue

    'End Function

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
    '                 
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


#Region "Integrated Development Tab"

    Private Sub cboReferralsIntProvision_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.SelectedValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If cboReferralsIntProvision.SelectedIndex <> -1 Then
            If MessageBox.Show("Add  " & cboReferralsIntProvision.Text & " ?", "Add ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.DataConnection)
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

                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtCCno.Text, "CC")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & Me.lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.DataConnection)
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

                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Me.Name)

                End Try
            End Using
            'reload file numbers
            Try
                Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtCCno.Text, "CC")
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
            Me.btnRemoveDocument.Enabled = True

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




        Try

            Dim PDFVIEW As New OpenDocument
            PDFVIEW.OpenVisible(sPDFDoc)


        Catch ex As Exception

        End Try



        'If Is64BitOperatingSystem Then

        '    If sPDFDoc <> String.Empty Then WebBrowser1.Navigate(sPDFDoc)

        'Else

        '    If sPDFDoc <> String.Empty Then
        '        Dim PDFviewer As New PDFviewer
        '        With PDFviewer
        '            .DocumentToDisplay = sPDFDoc
        '            .ShowDialog()
        '            .Dispose()
        '        End With
        '    End If


        'End If




    End Sub
#End Region

#Region "File Notes Tab"
    Private Sub btnDocNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocNote.Click
        If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .Parameters.Add("@NOTES", SqlDbType.NText).Value = Me.txtDocNote.Text
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(dgvDocumentsList.CurrentRow.Cells(10).Value)
                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        txtDocNote.Text = String.Empty
        Try
            RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "CC", txtCCno.Text)
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
        Me.cboNoteType.Enabled = Not lock
        Me.txtNotesSpokeTo.ReadOnly = lock
        Me.txtNotesCC.ReadOnly = lock
        Me.txtNotesFollowUp.ReadOnly = lock
        Me.cboNotesOfficer.Enabled = Not lock
        Me.btnNotesEdit.Enabled = lock
        Me.btnNotesSave.Enabled = Not lock
        btnNotesAdd.Enabled = lock
        'Me.btnNotePrint.Enabled = Not lock

    End Sub

    Private Sub dgvFileNotes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFileNotes.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@NOTEDATE", SqlDbType.SmallDateTime).Value = Format(CDate(NoteDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SUBJECT", SqlDbType.NVarChar).Value = Me.txtNotesSubject.Text
                        .Parameters.Add("@DETAIL", SqlDbType.NText).Value = Me.txtNoteDetails.Text
                        .Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = Me.txtNotesContactNo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "CC"
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
        cboDAAuthorityId.SelectedIndex = -1
        cboDADecisionId.SelectedIndex = -1
        cboDAlocalityCode.SelectedIndex = -1
        Me.cboConsentDocType.SelectedIndex = -1
        Me.cboSTDconditions.SelectedIndex = -1
        cboRefCodeId.SelectedIndex = -1
        Me.cboBuildersNames.SelectedIndex = -1
        cboBldgCodeAust.SelectedIndex = -1
        cboBldgSolution.SelectedIndex = -1
        If lstSearchResults.Items.Count > 0 Then lstSearchResults.SelectedIndex = 0
        LoadForm(lstSearchResults.Text)



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

        With lvwCodes
            .Columns.Clear()
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "Code"
            .Columns(0).Width = .Width - 22



        End With

        'LoadCC_ClassIds(txtCCno.Text)


        'Me.txtDANo.Text = DAno


        btnAddCC.Enabled = Administration

        If ViewOnly Then
            LockAccessIfViewOnly(Me)
        End If



    End Sub


    Private Sub LoadCC_ClassIds(ByVal CCNo As String)

        lvwCodes.Items.Clear()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCC_ClassIds routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_ConstructionCertClassIds"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = CCNo
                    End With



                    Using objDR As SqlDataReader = cmd.ExecuteReader
                        Do While objDR.Read
                            Dim objListViewItem As New ListViewItem

                            objListViewItem.Text = objDR.Item("CCClassId").ToString
                            objListViewItem.Tag = objDR.Item("CCClassId").ToString
                            'Add the ListViewItem to the ListView control
                            lvwCodes.Items.Add(objListViewItem)


                        Loop
                    End Using


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCC_ClassIds routine - form " & Me.Name)

            End Try
        End Using



    End Sub
    Private Sub lstSearchResults_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSearchResults.SelectedValueChanged
        If isloading Then Exit Sub
        CheckIfDataChanged()
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

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboSTDconditions.SelectedValue)
                        .ExecuteNonQuery()

                    End With

                    Try
                        Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, Me.txtCCno.Text)
                    Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnAddOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOneOffCond.Click
        Dim fOneUpCond As New InsertOneUpCondition
        With fOneUpCond
            .DAnumber = Me.txtCCno.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, Me.txtCCno.Text)
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
                    .DANumber = Me.txtCCno.Text

                    .ShowDialog()
                    .Dispose()

                End With
            End If

        End If

    End Sub

    Private Sub btnRemoveOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOneOffCond.Click

        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvOneUpConditions.CurrentRow.Cells(2).Value)
                        .ExecuteNonQuery()
                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click


        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvSTDConditions.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()
                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click
        If Me.dgvDraftDocs.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString)

            'Dim objWordApp As New Microsoft.Office.Interop.Word.Application
            'Dim objWordDoc As Microsoft.Office.Interop.Word.Document = objWordApp.Application.Documents.Open(Me.dgvDraftDocs.CurrentRow.Cells(0).Value.ToString)
            'objWordDoc.Activate()
            'objWordApp.Visible = True

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click
        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub
        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString

        If MessageBox.Show("You are about to delete this word document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells("colDraftDocId").Value)
                        .ExecuteNonQuery()
                    End With


                End Using


                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        DisplayDraftDocuments(txtCCno.Text)


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        'InsertIntoDADocumentsTable(dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString, sDocumentNo.Replace(".", "_"))

        Dim summary As String = "Application No. " & txtDANo.Text & " Application Type: DA Document Type: " & dgvDraftDocs.CurrentRow.Cells("colDocname").Value.ToString




        Dim fEASE As New InsertEASEDocument
        With fEASE
            .WordDocLocation = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString
            .CustName = Me.txtDAOwnersName.Text
            .CustAddress = Me.txtDAOwnersAddress.Text & " " & Me.txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With


        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "CC"
            .DocumentType = dgvDraftDocs.CurrentRow.Cells("colDocname").Value.ToString
            .ApplicationNo = Me.txtCCno.Text
            .TheAuthor = MyUserId
            .TheImageName = Replace(sDocumentNo, ".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
        End With



        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString
        My.Computer.FileSystem.DeleteFile(FileToDelete)

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells("colDraftDocId").Value)
                        .ExecuteNonQuery()
                    End With
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        DisplayDraftDocuments(txtCCno.Text)



    End Sub

    Private Sub btnPrintAddinfoLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAddinfoLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue an AddInfo Request letter. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAddinfoLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Additional Information Request letter" & Me.txtCCno.Text, "AddInfo_Request_Letter.rpt", 2, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAddinfoLetter_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrint100DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint100DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the first follow-up letter for AddInfo over 100 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint100DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "First follow-up letter for AddInfo over 100 days " & Me.txtCCno.Text, "Over100DayLetter.rpt", 2, "NO")

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint100DayLetter_Click routine ")
            End Try
        End Using
        Over100LetterDate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveReferralData()

    End Sub

    Private Sub btnPrint200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint200DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the first follow-up letter for AddInfo over 200 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint200DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "First follow-up letter for AddInfo over 200 days" & Me.txtCCno.Text, "Over200Day_A_Letter.rpt", 2, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint200DayLetter_Click routine ")
            End Try
        End Using
        Over200LetterADate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveReferralData()

    End Sub

    Private Sub btnPrintOver200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOver200DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the FINAL follow-up letter for AddInfo over 200 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintOver200DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "FINAL follow-up letter for AddInfo over 200 days" & Me.txtCCno.Text, "Over200Day_B_Letter.rpt", 2, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintOver200DayLetter_Click routine ")
            End Try
        End Using

        Over200LetterBDate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveReferralData()

    End Sub

    Private Sub btnEditAddinfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAddinfoTab.Click
        LockTheForm(grpAddinfo, True)
        btnSaveAddInfoTab.Enabled = True
        btnEditAddinfoTab.Enabled = False

    End Sub

    Private Sub btnSaveAddInfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAddInfoTab.Click
        If Not CheckAdditionalInfo() Then Exit Sub
        SaveReferralData()

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        Dim fDraftConditions As New DraftConditions
        With fDraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = Me.txtCCno.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub btnMailResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailResponse.Click
        If Me.txtRefResponse.Text = String.Empty Then
            MessageBox.Show("There is nothing typed in the response area - please complete and try again", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Subject As String = "Referral Response for Appl No: " & Me.txtCCno.Text
        Dim Body As String = "Please find attached my response to your referral regarding application number " & vbCrLf & txtRefResponse.Text

        'Dim mailaddress As String = ADHelper.GetEmailAddress(ADHelper.GetLoginName)
        Dim emailaddress As String = GetEmailAddress()
        If emailaddress = String.Empty Then
            MessageBox.Show("Responsible Officer Not selected - Can't send e-mail !", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            'MAIL.SendMailMessage(mailaddress, emailaddress, "", "", Subject, Body, "")

            Dim OutlookHlp As New OutlookHelper

            OutlookHlp.SendMail(emailaddress, "", "", Subject, Body, "")






            MessageBox.Show("Responsible Officer has been notified.", "EMail sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub lvwCodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwCodes.Click
        If lvwCodes.SelectedItems.Item(0).ToString <> String.Empty Then _
        Me.btnRemove.Enabled = True
    End Sub

    Private Sub cboBldgCodeAust_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBldgCodeAust.SelectedValueChanged
        btnAdd.Enabled = cboBldgCodeAust.SelectedIndex >= 0
    End Sub

    Private Sub InsertNewCode(ByVal ClassId As String)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertNewCode routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertNewClassID"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = txtCCno.Text
                        .Parameters.Add("@CLASSID", SqlDbType.NVarChar).Value = ClassId
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertNewCode routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub RemoveClassID(ByVal ClassID As String)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveClassID routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveClassIDFromList"


                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = txtCCno.Text
                        .Parameters.Add("@CLASSID", SqlDbType.NVarChar).Value = ClassID
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveClassID routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnEditDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditDA.Click
        LockTheForm(Me.pnlPrimaryDetail, True)
        cboBldgCodeAust.Enabled = True
        lvwCodes.Enabled = True

        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True
        btnAddFee.Enabled = True
        Me.btnAddRefund.Enabled = True

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objListViewItem As New ListViewItem

        objListViewItem.Text = cboBldgCodeAust.Text
        objListViewItem.Tag = cboBldgCodeAust.Text
        'Add the ListViewItem to the ListView control
        lvwCodes.Items.Add(objListViewItem)

        InsertNewCode(cboBldgCodeAust.Text)
        cboBldgCodeAust.SelectedIndex = -1



    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        RemoveClassID(lvwCodes.SelectedItems.Item(0).Text)

        Me.lvwCodes.SelectedItems.Item(0).Remove()

        Me.btnRemove.Enabled = False

    End Sub


    Private Sub btnSaveDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveDA.Click
        LockTheForm(Me.pnlPrimaryDetail, False)
        cboBldgCodeAust.Enabled = False
        lvwCodes.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False

        btnAddFee.Enabled = False
        Me.btnAddRefund.Enabled = False
        btnEditDA.Enabled = True
        Me.btnSaveDA.Enabled = False
        btnAddCC.Enabled = True
        SaveHeaderData()



    End Sub

    Private Sub btnAssembleLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssembleLetter.Click
        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "CC"


        Using cn As New SqlConnection(My.Settings.DataConnection)
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


                CreateWordDocs(docType, Me.txtCCno.Text, docname, docfilename, sysType, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub cboRefCodeId_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRefCodeId.SelectedValueChanged
        Select Case CInt(cboRefCodeId.SelectedValue)

            Case 2, 3
                Me.grpRFS.Visible = False
                btnRTA.Visible = True
            Case 59
                Me.grpRFS.Visible = True
                btnRTA.Visible = False
            Case Else
                Me.grpRFS.Visible = False
                btnRTA.Visible = False

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

            LockTheForm(pnlButtons, True)
            LockTheForm(grpMain, False)
            LockTheForm(grpRFS, False)
            LockTheForm(grpIntDesig, False)
            LockTheForm(grpEngineers, False)
            LockTheForm(grpSepp71, False)
            btnView.Enabled = True
            Me.btnEditReferralsTab.Enabled = True
            Me.btnAddReferral.Enabled = True
            btnSaveReferralsTab.Enabled = False
            btnPrintRFSOther.Enabled = False
            btnPrintRFSSub.Enabled = False
            btnRTA.Visible = False

            Select Case CInt(cboRefCodeId.SelectedValue)

                Case 2, 3
                    Me.grpRFS.Visible = False
                    btnRTA.Visible = True
                    btnRTA.Enabled = True

                Case 59
                    Me.grpRFS.Visible = True
                    btnRTA.Visible = False
                    btnPrintRFSOther.Enabled = True
                    btnPrintRFSSub.Enabled = True

                Case Else
                    Me.grpRFS.Visible = False
                    btnRTA.Visible = False

            End Select




        End If

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True


    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click
        'btnAddReferral.Enabled = False
        'Me.btnEditReferralsTab.Enabled = False
        'btnSaveReferralsTab.Enabled = True
        'ClearReferralData(grpMain)
        'Me.lblReferralID.Text = String.Empty
        'lstIntegrated.SelectedIndex = -1
        'LockTheForm(grpMain, True)
        'LockTheForm(grpRFS, True)
        'LockTheForm(grpIntDesig, True)
        'LockTheForm(grpEngineers, True)
        'LockTheForm(grpSepp71, True)

        btnAddReferral.Enabled = False
        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty
        lstIntegrated.DataSource = Nothing
        LockTheForm(pnlButtons, False)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)
        txtRefComm.ReadOnly = False

        Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtCCno.Text, "CC")




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
        btnRefdt.Enabled = True
        btnRefRetDt.Enabled = True

        LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)
        txtRefResponse.ReadOnly = False
        txtRefComm.ReadOnly = False

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
        txtRefResponse.ReadOnly = True
        txtRefComm.ReadOnly = True

        Using cn As New SqlConnection(My.Settings.DataConnection)
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
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
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"

                        .ExecuteNonQuery()
                    End With


                End Using



                Try
                    Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtCCno.Text, "CC")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnAddCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCC.Click
        Dim NewccNumbers As String = String.Empty

        Dim fAddNew As New AddNewCC
        With fAddNew
            .DAnumber = DAno
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            NewccNumbers = .NewCCNumber
            .Dispose()
        End With

        If NewccNumbers = String.Empty Then Exit Sub
        txtRefResponse.ReadOnly = False
        txtRefComm.ReadOnly = False

        LockTheForm(Me.grpPropertyLotAddress, False)
        LockTheForm(Me.grpPropertyOwner, False)
        LockTheForm(Me.grpOwnerBuilder, False)
        LockTheForm(Me.grpInsurance, False)
        LockTheForm(Me.grpLicenceBuilder, False)
        LockTheForm(Me.grpMatWalls, False)
        LockTheForm(Me.grpMatRoof, False)
        LockTheForm(Me.grpFloor, False)
        LockTheForm(Me.grpFrame, False)
        LockTheForm(Me.grpAssessment, False)
        LockTheForm(Me.pnlPrimaryDetail, False)
        btnAddFee.Enabled = True
        Me.btnAddRefund.Enabled = True

        ClearData(Me.grpPropertyLotAddress)
        ClearData(Me.grpPropertyOwner)
        ClearData(Me.grpOwnerBuilder)
        ClearData(Me.grpInsurance)
        ClearData(Me.grpLicenceBuilder)
        ClearData(Me.grpMatWalls)
        ClearData(Me.grpMatRoof)
        ClearData(Me.grpFloor)
        ClearData(Me.grpFrame)
        ClearData(Me.grpAssessment)
        ClearData(Me.pnlPrimaryDetail)

        LoadSearchList()
        Me.lstSearchResults.SelectedItem = "NewccNumbers"

        LoadForm(NewccNumbers)


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




    End Sub

    Private Sub btnReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferral.Click
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnReferral_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_ReferralResponse"
                        .Parameters.Add("@REFID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "CC"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "Referral Response " & Me.txtCCno.Text, "ReferralResponse.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnReferral_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintsepp71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintsepp71.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a SEPP 71 Referral to fax to Planning NSW. OK to proceed?", "Print Sepp71 Facimile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_Sepp71Refer"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & Me.txtDANo.Text, "Sepp71Referral.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnNotePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrint.Click

        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_FileNotes"
                        .Parameters.Add("@FNID", SqlDbType.Int).Value = NZ(lblNotesID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    'PrintOnPlainPaperOnly(objDT, "File note " & Me.txtDANo.Text, "FileNotes.rpt", 1)
                    PrintButDontEase(objDT, "filenotes.rpt")

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintRFSOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSOther.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RFSReferral"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtCCno.Text, "RFSReferralDA.rpt", 1, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintRFSSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSSub.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RFSReferral"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtCCno.Text, "RFSReferralSubDiv.rpt", 1, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine ")
            End Try
        End Using
    End Sub

    'Private Sub PrintReferralLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer)

    '    Dim OwnerName As String = String.Empty
    '    Dim OwnerAddress As String = String.Empty
    '    Dim FileNo As String = String.Empty
    '    Dim rptDocument As New ReportDocument


    '    Dim RowCount As Integer = objDtable.Rows.Count
    '    If objDtable.Rows.Count > 0 Then

    '        Dim objDataRow As DataRow = objDtable.Rows.Item(0)

    '        OwnerName = objDataRow.Item("DAAppName").ToString
    '        OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
    '        FileNo = objDataRow.Item("DAFileNo").ToString

    '    End If

    '    Try

    '        'Pass the reportname to string variable 
    '        Dim strReportPath As String = My.Settings.ReportLocation & reportName

    '        'Check file exists
    '        If Not IO.File.Exists(strReportPath) Then
    '            Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
    '        End If

    '        Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
    '        myPrintOptions.PrinterName = My.Settings.DefaultPrinter
    '        myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
    '        myPrintOptions.CustomPaperSource = GetSelectedPaperSource()


    '        With rptDocument
    '            .Load(strReportPath)
    '            .SetDataSource(objDtable)
    '            .VerifyDatabase()
    '        End With


    '        rptDocument.PrintToPrinter(1, False, 1, 1)

    '        If Copies = 2 Then

    '            Dim myPrintOptionsTwo As PrintOptions = rptDocument.PrintOptions
    '            myPrintOptionsTwo.PrinterName = My.Settings.DefaultPrinter
    '            myPrintOptionsTwo.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
    '            myPrintOptionsTwo.CustomPaperSource = GetSelectedSecondPaperSource()
    '            rptDocument.PrintToPrinter(1, False, 1, 1)

    '        End If

    '        Dim strDocumentNo As String = GetNextDocumentNumber()
    '        Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

    '        Dim fEase As New OutwardEaseCorro

    '        With fEase
    '            .CustName = OwnerName
    '            .CustAddress = OwnerAddress
    '            .FileNumber = FileNo
    '            .DocSummary = Summary & Me.txtDANo.Text
    '            .DocumnetNo = strDocumentNo
    '            .ShowDialog()
    '            .Dispose()
    '        End With

    '        'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")
    '        'TODO: Uncomment this before putting into production
    '        If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
    '            FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
    '        End If

    '        rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)
    '        FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message & " in function PrintReferralLetter")
    '    Finally
    '        rptDocument.Close()

    '    End Try


    'End Sub

    Private Sub ConstructionCerticate_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        CheckIfDataChanged()
        ''DALookup.Show()
    End Sub

    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try

            Dim fFee As New AddPayment

            With fFee

                .TheSystemType = "CC"
                .IndexID = 0
                .AppID = txtCCno.Text
                .PayId = 0
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, Me.txtCCno.Text, "CC")
            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddRefund_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "CC"
                .IDindex = 0
                .AppID = txtCCno.Text
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtCCno.Text, "CC")
            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemoveRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefer.Click


        If MessageBox.Show("Are you sure you want to remove this referral?", "Remove Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveReferral"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                        .ExecuteNonQuery()
                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtCCno.Text, "CC")

        Try
            Me.ReferalInfoTableAdapter.Fill(Me.DAdatasets.ReferalInfo, 0)
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
        Me.btnEditReferralsTab.Enabled = False
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.SelectedValue)

            Case 2, 3
                Me.grpRFS.Visible = False
                btnRTA.Visible = True
                btnRTA.Enabled = True

            Case 59
                Me.grpRFS.Visible = True
                btnRTA.Visible = False
                btnPrintRFSOther.Enabled = True
                btnPrintRFSSub.Enabled = True

            Case Else
                Me.grpRFS.Visible = False
                btnRTA.Visible = False

        End Select

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True


    End Sub

#Region "Date Buttons"
    Private Sub btnRefToPlanCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefToPlanCom.Click
        RetrieveDate(SiteInspectDte)

    End Sub

    Private Sub btnbldgSurveyorDte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbldgSurveyorDte.Click
        RetrieveDate(bldgSurveyorDte)

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




#End Region

    Private Sub btnRTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRTA.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Roads and Traffic Authority. OK to proceed?", "Print RTA Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRTA_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RTAReferral"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Roads and Traffic Authority" & Me.txtCCno.Text, "RTAReferral.rpt", 1, "NO")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRTA_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnKeep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeep1.Click



        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(Me.txtAppName.Text)
        objStreamWriter.WriteLine(Me.txtAppAddress.Text)
        objStreamWriter.WriteLine(Me.txtAppTown.Text)
        objStreamWriter.WriteLine(Me.txtAppPcode.Text)
        objStreamWriter.WriteLine(Me.txtAppPhone.Text)


        'Close the file.
        objStreamWriter.Close()


    End Sub



    Private Sub btnUse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse1.Click
        Dim objStreamReader As StreamReader
        Dim strLine As String
        objStreamReader = New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp")

        strLine = objStreamReader.ReadLine
        txtAppName.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppAddress.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppTown.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppPcode.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppPhone.Text = strLine


        objStreamReader.Close()



    End Sub



    Private Function AddressNotSaved() As Boolean
        Dim result As Boolean = True


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in AddressNotSaved routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckToSeeIfAddress"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = txtCCno.Text
                        .Parameters.Add("@STREET", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@STREET").Value)

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in AddressNotSaved routine - form " & Me.Name)

            End Try
        End Using





        Return result

    End Function

    Private Sub btnIssueCCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssueCCert.Click

        If lvwCodes.Items.Count = 0 Then
            MessageBox.Show("You are required to enter an Australian Building code before proceeding", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboBldgCodeAust.Focus()
            Exit Sub

        End If

        If Not AddressNotSaved() Then
            'MessageBox.Show("You need to save the data on the Property Tab before proceeding, click the Edit and Save buttons", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.tabDAdata.SelectedTab = pgProperty
            SaveHeaderData()
            'Me.tabDAdata.SelectedTab = pgStatus
        End If

        Dim TheReportName As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnIssueCCert_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckToSeeAnyOutstandingConditions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                    End With

                    Dim objDT1 As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT1.Load(objDataReader)
                    End Using

                    Dim check As Boolean = HasBeenDetermined()


                    If objDT1.Rows.Count <> 0 Then

                        MessageBox.Show("There are still conditions marked as outstanding prior to release of CC", "Conditions Outstanding", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub

                    ElseIf Not check Then

                        MessageBox.Show("DA has not been finalised", "DA Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub

                    End If

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnIssueCCert_Click routine - form " & Me.Name)

            End Try
        End Using



        If MessageBox.Show("Do you require to enter a Fire Safety Schedule with this certificate?", "Fire Safety Certyificate", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            With My.Forms.ConstructionCertFireSafetySchedule
                .CCappNumber = Me.txtCCno.Text
                .ShowDialog()
                .Dispose()
            End With

        End If


        Dim CCType As String = String.Empty


        Select Case DAUse
            Case 2, 3

                If MessageBox.Show("You are about to issue a Commercial Construction Certificate, you MUST save the data before proceeding,  OK to proceed?", "Print Compliance Certificate/Defective Notice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                'TheReportName = "ConstructCert_Commercial.rpt"
                CCType = "COMMERCIAL"

            Case Else


                If cboAppType.SelectedValue = 1 Then

                    If MessageBox.Show("You are about to issue a Construction Certificate, you MUST save the data before proceeding,  OK to proceed?", "Print Compliance Certificate/Defective Notice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                    'TheReportName = "ConstructCert_DA.rpt"
                    CCType = "STANDARD"

                    'Else
                    '    If MessageBox.Show("You are about to issue a Construction Certificate for 'SUBDIVISION' , you MUST save the data before proceeding,  OK to proceed?", "Print Compliance Certificate/Defective Notice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                    '    TheReportName = "ConstructCert_SubDiv.rpt"

                End If

        End Select


        PrintTheConstructionCertificate(CCType)



        'Dim objDT As New DataTable


        'Using cn As New SqlConnection(My.Settings.DataConnection)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnIssueCert_Click routine")

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_rpt_ConstructionCert"
        '                '.Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
        '                .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
        '            End With



        '            Using objDataReader As SqlDataReader = cmd.ExecuteReader
        '                objDT.Load(objDataReader)
        '            End Using

        '            Dim strReportPath As String = My.Settings.ReportLocation & TheReportName

        '            'Check file exists
        '            If Not IO.File.Exists(strReportPath) Then
        '                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
        '            End If

        '            'Dim rptDocument As New ReportDocument


        '            'With rptDocument
        '            '    .Load(strReportPath)
        '            '    .SetDataSource(objDT)
        '            '    .VerifyDatabase()
        '            'End With

        '            'With My.Forms.ConstructionCertificateView
        '            '    .ReportName = rptDocument
        '            '    .ShowDialog()
        '            '    .Dispose()
        '            'End With



        '            PrintLetter(objDT, "Construction Certificate  " & Me.txtCCno.Text, TheReportName, 2)


        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnIssueCert_Click routine ")
        '    End Try
        'End Using
    End Sub

    Private Sub PrintTheConstructionCertificate(ByVal CCType As String)



        Dim sdate As String = String.Empty
        sdate = Format(Today.Date, "dd/MM/yyyy")
        Dim Doctype As Integer


        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document


        Dim strDocumentNo As String = GetNextDocumentNumber()
        Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"
        Dim LetterName As String = String.Empty

        Dim WordDocName As String = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\ConstructionCertificate_" & txtCCno.Text.Replace("/", "_") & "_DATE_" & sdate.Replace("/", "_") & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"



        If My.Computer.FileSystem.FileExists(WordDocName) Then My.Computer.FileSystem.DeleteFile(WordDocName)



        Dim ObjDataset As DataTable = ReportData()

        Try

            If ObjDataset.Rows.Count > 0 Then


                Dim objDataRow As DataRow = ObjDataset.Rows.Item(0)

                Select Case CCType

                    Case "COMMERCIAL"

                        LetterName = "ConstructionCertificateCommercial.dotx"
                        Doctype = 60

                    Case "STANDARD"
                        LetterName = "ConstructionCertificateStandard.dotx"
                        Doctype = 61

                    Case Else
                        LetterName = "ConstructionCertificateSubDivision.dotx"
                        Doctype = 62

                End Select



                objWordDoc = objWordApp.Application.Documents.Add(Template:=(My.Settings.ConstructionCertificates & LetterName), NewTemplate:=False, DocumentType:=0)

                Dim newname As String = objWordDoc.Name.ToString


                With objWordApp

                    .Visible = False

                    .ActiveDocument.Bookmarks("CCName").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCName").ToString


                    .ActiveDocument.Bookmarks("CCStreet").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCStreet").ToString


                    .ActiveDocument.Bookmarks("CCTown").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCTown").ToString

                    .ActiveDocument.Bookmarks("CCPostCode").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCPostCode").ToString

                    .ActiveDocument.Bookmarks("CCAPPNo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCAPPNo").ToString

                    .ActiveDocument.Bookmarks("CCDesc").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCDesc").ToString

                    Select Case CCType

                        Case "COMMERCIAL", "STANDARD"

                            Dim CCClassIDs As String = SubReportClassData(txtCCno.Text)

                            .ActiveDocument.Bookmarks("CCClass").Select()
                            .ActiveDocument.Application.Selection.Text = CCClassIDs


                        Case Else

                            .ActiveDocument.Bookmarks("CoucilPlanNo").Select()
                            .ActiveDocument.Application.Selection.Text = objDataRow.Item("CouncilPlanNumber").ToString

                    End Select


                    .ActiveDocument.Bookmarks("DALot").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DALot").ToString

                    .ActiveDocument.Bookmarks("DADP").Select()
                    .Application.Selection.Text = objDataRow.Item("DADP").ToString

                    .ActiveDocument.Bookmarks("Street").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("Street").ToString

                    .ActiveDocument.Bookmarks("LocalityCode").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("LocalityCode").ToString


                    .ActiveDocument.Bookmarks("DAFileNo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DAFileNo").ToString

                    .ActiveDocument.Bookmarks("DANo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DANo").ToString


                    If Not IsDBNull(objDataRow.Item("DADetermDt")) Then

                        .ActiveDocument.Bookmarks("DADetermDt").Select()
                        .ActiveDocument.Application.Selection.Text = Format(CDate(objDataRow.Item("DADetermDt")), "dd MMMM, yyyy")

                    End If

                    .ActiveDocument.Bookmarks("BuildersProfBoard").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("BuildersProfBoard").ToString


                    If CCType = "COMMERCIAL" Then

                        .ActiveDocument.Bookmarks("DANo2").Select()
                        .ActiveDocument.Application.Selection.Text = objDataRow.Item("DANo").ToString

                        .ActiveDocument.Bookmarks("CCAppNo2").Select()
                        .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCAPPNo").ToString


                        Dim FireSchedule As String = SubReportData(txtCCno.Text)



                        .ActiveDocument.Bookmarks("Schedule").Select()
                        .ActiveDocument.Application.Selection.Text = FireSchedule


                    End If


                    With .ActiveDocument
                        .UpdateStylesOnOpen = False
                        .AttachedTemplate = ""
                        '.XMLSchemaReferences.AutomaticValidation = True
                        '.XMLSchemaReferences.AllowSaveAsXMLWithoutValidation = False
                    End With





                    .ActiveDocument.SaveAs(FileName:=WordDocName.ToString, FileFormat:=
                    WORD.WdSaveFormat.wdFormatXMLDocument, LockComments:=False, Password:="", AddToRecentFiles _
                    :=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts _
                    :=False, SaveNativePictureFormat:=False, SaveFormsData:=False,
                    SaveAsAOCELetter:=False)

                    .ActiveDocument.Close(SaveChanges:=False)


                End With
                'PopulateTable(WordDocName.ToString)


                objWordApp.Quit()

                releaseObject(objWordDoc)

                releaseObject(objWordApp)


            End If


            InsertRecordIntoDraftDocs(txtCCno.Text, Doctype, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))


            DisplayDraftDocuments(CCNo)



            Dim WRD As New OpenDocument
            WRD.OpenVisible(WordDocName)

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in LoadSeizedItems routine - form " & Me.Name)
            objWordApp.Quit()

            releaseObject(objWordDoc)
            releaseObject(objWordApp)

        End Try






    End Sub


    Private Function ReportData() As DataTable
        Dim objReturn As New DataTable

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

                        .CommandText = "usp_rpt_ConstructionCert"
                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objReturn.Load(objDataReader)
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        Return objReturn



    End Function


    Private Function SubReportData(ByVal CCAppNo As String) As String

        Dim objReturn As String = String.Empty

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

                        .CommandText = "usp_rpt_FireSafetySchedule"
                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = CCAppNo
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            objReturn &= objDataReader.Item(0).ToString & vbCrLf


                        Loop
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        Return objReturn


    End Function


    Private Function SubReportClassData(ByVal CCAppNo As String) As String

        Dim objReturn As String = String.Empty

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

                        .CommandText = "usp_rpt_ConstructionCertClassIds"
                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = CCAppNo
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            objReturn &= objDataReader.Item(0).ToString & " "


                        Loop
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        Return objReturn


    End Function


    Private Sub btnProduceSubConstCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduceSubConstCert.Click


        If txtCouncilPlanNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtCouncilPlanNo, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.txtCouncilPlanNo, "The Council Plan Number field cannot be blank.  Please provide a plan number")
            End With
            MessageBox.Show("The Council Plan Number field cannot be blank.  Please provide a plan number", "Print Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Exit Sub

        Else

            ErrorProvider.SetError(Me.txtCouncilPlanNo, "")

            If MessageBox.Show("You are about to issue a Construction Certificate, you MUST save the data before proceeding, OK to proceed?", "Print ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

            PrintTheConstructionCertificate("SUBDIVISION")



            'Dim TheReportName As String = "ConstructCert_SubDiv.rpt"
            'Dim ReportType As String = "CC"

            'Dim objDT As New DataTable


            'Using cn As New SqlConnection(My.Settings.DataConnection)
            '    Try
            '        cn.Open()
            '    Catch ex As SqlException
            '        MessageBox.Show(ex.Message, " in btnIssueCert_Click routine")

            '    End Try


            '    Try

            '        Using cmd As New SqlCommand

            '            With cmd
            '                .Connection = cn
            '                .CommandType = CommandType.StoredProcedure
            '                .CommandText = "usp_rpt_ConstructionCert"
            '                .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
            '            End With



            '            Using objDataReader As SqlDataReader = cmd.ExecuteReader
            '                objDT.Load(objDataReader)
            '            End Using




            '            PrintLetter(objDT, "Construction Certificate  " & Me.txtCCno.Text, TheReportName, 2)


            '        End Using
            '         



            '    Catch ex As SqlException
            '        MessageBox.Show(ex.Message, " in btnIssueCert_Click routine ")
            '    End Try

            'End Using

        End If
    End Sub

    Private Sub chkOwnerBuilder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerBuilder.CheckedChanged
        If chkOwnerBuilder.CheckState = CheckState.Checked Then
            grpLicenceBuilder.Enabled = False
            cboBuildersNames.Text = "N/A"
        Else
            grpLicenceBuilder.Enabled = True

        End If
    End Sub

    Private Sub chkCCLicBuilder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCCLicBuilder.CheckedChanged
        If chkCCLicBuilder.CheckState = CheckState.Checked Then
            grpOwnerBuilder.Enabled = False
        Else
            grpOwnerBuilder.Enabled = True

        End If

    End Sub

    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try

            Dim fFee As New AddPayment

            With fFee

                .TheSystemType = "CC"
                .IndexID = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(7).Value)
                .AppID = txtCCno.Text
                .PayId = CShort(PaymentsReceivedDataGridView.CurrentRow.Cells(6).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, txtCCno.Text, "CC")
            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub PaymentsReceivedDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentsReceivedDataGridView.CellClick
        If e.RowIndex = -1 Then Exit Sub
        'If Me.btnSaveDA.Enabled Then
        Me.btnEditPayment.Enabled = True
        Me.btnRemoveFee.Enabled = True
        'End If
    End Sub

    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "CC"
                .IDindex = CInt(DARefundsPaidDataGridView.CurrentRow.Cells(6).Value)
                .AppID = txtCCno.Text
                .PayId = CShort(DARefundsPaidDataGridView.CurrentRow.Cells(5).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtCCno.Text, "CC")
            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemoveRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefund.Click
        If MessageBox.Show("Are you sure about this, remove this refund?", "Remove refund ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveARefund"

                        .Parameters.Add("@ID", SqlDbType.SmallInt).Value = CInt(DARefundsPaidDataGridView.CurrentRow.Cells(6).Value)
                        .ExecuteNonQuery()

                    End With


                End Using


                Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtCCno.Text, "CC")
                CalculateRefundsandPayments(txtCCno.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub DARefundsPaidDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DARefundsPaidDataGridView.CellClick
        If e.RowIndex = -1 Then Exit Sub
        'If Me.btnSaveDA.Enabled Then
        Me.btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
        'End If
    End Sub

    Private Sub btnRemoveFee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveFee.Click


        If MessageBox.Show("Are you sure about this, remove this fee?", "Remove Fee ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveAPayment"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(7).Value)
                        .ExecuteNonQuery()

                    End With


                End Using


                Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, txtCCno.Text, "CC")
                CalculateRefundsandPayments(txtCCno.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnEditStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStatus.Click
        Me.btnSaveStatus.Enabled = True
        Me.btnEditStatus.Enabled = False
        LockTheForm(Me.grpAssessment, True)
    End Sub

    Private Sub btnSaveStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveStatus.Click
        Me.btnSaveStatus.Enabled = False
        Me.btnEditStatus.Enabled = True
        LockTheForm(Me.grpAssessment, False)
        SaveStatusData()

    End Sub




    Private Sub btnEditBuilder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditBuilder.Click
        btnEditBuilder.Enabled = False
        btnSaveBuilder.Enabled = True
        LockTheForm(Me.grpOwnerBuilder, True)
        LockTheForm(Me.grpInsurance, True)
        LockTheForm(Me.grpLicenceBuilder, True)
        Me.txtLongServiceLevy.ReadOnly = False

    End Sub

    Private Sub btnSaveBuilder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveBuilder.Click
        btnEditBuilder.Enabled = True
        btnSaveBuilder.Enabled = False
        LockTheForm(Me.grpOwnerBuilder, False)
        LockTheForm(Me.grpInsurance, False)
        LockTheForm(Me.grpLicenceBuilder, False)
        Me.txtLongServiceLevy.ReadOnly = True
        SaveBuilderData()

    End Sub

    Private Sub btnEditMaterials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditMaterials.Click
        btnEditMaterials.Enabled = False
        btnSaveMaterials.Enabled = True
        LockTheForm(Me.grpMatWalls, True)
        LockTheForm(Me.grpMatRoof, True)
        LockTheForm(Me.grpFloor, True)
        LockTheForm(Me.grpFrame, True)
    End Sub

    Private Sub btnSaveMaterials_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveMaterials.Click
        btnEditMaterials.Enabled = True
        btnSaveMaterials.Enabled = False
        LockTheForm(Me.grpMatWalls, False)
        LockTheForm(Me.grpMatRoof, False)
        LockTheForm(Me.grpFloor, False)
        LockTheForm(Me.grpFrame, False)

        SaveMaterialsData()
    End Sub

    Private Sub btnRemoveDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDocument.Click
        Dim documentToRemove As String = dgvDocumentsList.CurrentRow.Cells(4).Value.ToString & " created " & Format(CDate(dgvDocumentsList.CurrentRow.Cells(5).Value), "dd/MM/yyyy")
        If MessageBox.Show("Remove " & documentToRemove & " from the list?", "Remove this document", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim removedocument As New RemoveDocument

        With removedocument
            .DocumentID = CType(dgvDocumentsList.CurrentRow.Cells(10).Value, Integer)
            .DocumentToRemove = dgvDocumentsList.CurrentRow.Cells(2).Value.ToString
            .RemoveDocument()
        End With

        Try
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "CC", Me.txtCCno.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub


#End Region


    Private Function CCReferralData() As DataTable
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CCReferralData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_CCCertReferral"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text


                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CCReferralData routine - form " & Me.Name)

            End Try
        End Using

        Return objDT

    End Function




    Private Sub btnPrintCoverSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCoverSheet.Click
        'Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintCoverSheet_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_CCCert"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "CCCertReferral")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\CCCertReferral.xsd")


                End Using



                Dim rept As New ConstructionCertificateCoverSheet

                rept.DataSource = objDT
                rept.ReferralsObjDT = CCReferralData()

                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintCoverSheet_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnAssignOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignOfficer.Click
        With My.Forms.AssignOfficerList
            .AppNumber = txtCCno.Text
            .SysRef = "CC"
            .ShowDialog()
            If .Officer <> String.Empty Then txtOfficer.Text = .Officer
            .Dispose()
        End With
    End Sub

    Private Sub btnViewOfficers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewOfficers.Click
        With My.Forms.AssignedOfficers
            .AppNo = txtCCno.Text
            .sysRef = "CC"
            .ShowDialog()
            .Dispose()
        End With

    End Sub
End Class