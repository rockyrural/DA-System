

Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports System.Text
Imports WORD = Microsoft.Office.Interop.Word
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class EngineeringPostConsentModule

    Private errorProvider As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private mydocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadEventTypes()
        LoadEventStatus()
        'LoadPlanNumbersCombo()
        LoadOfficersListCombo(cboNotesOfficer)
        LoadOfficersListCombo(cboOfficer)
        LoadFileNoteTypesList()
        LoadListOfWordTemplates()


    End Sub


    Private _DANo As String '= "1055/03"
    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            _DANo = value
        End Set
    End Property

#Region "Main Form Events"

    'Private Sub LoadPlanNumbersCombo()

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in EngineerPostConsent_Load routine - form " & Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_RetrievePlanDetails"

    '                End With

    '                Dim objDT As New DataTable

    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using

    '                With cboPlanNo.Properties
    '                    .DataSource = objDT
    '                    .DisplayMember = "Plan Number"
    '                    .ValueMember = "Plan Number"
    '                    .ShowHeader = False
    '                    .ShowFooter = False


    '                End With

    '            End Using

    '            Dim col2 As LookUpColumnInfoCollection = cboPlanNo.Properties.Columns
    '            col2.Add(New LookUpColumnInfo("Plan Number", 0))
    '            col2.Add(New LookUpColumnInfo("Description", 0))
    '            col2.Add(New LookUpColumnInfo("Set", 0))
    '            col2.Add(New LookUpColumnInfo("Job Title", 0))
    '            col2.Add(New LookUpColumnInfo("Street", 0))

    '            col2.Item(2).Visible = False
    '            col2.Item(3).Visible = False
    '            col2.Item(4).Visible = False


    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in EngineerPostConsent_Load routine - form " & Name)

    '        End Try
    '    End Using




    'End Sub

    Private Sub LoadOfficersListCombo(combo As LookUpEdit)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT OfficerID, Officer FROM   Officer WHERE (Quit = 0) AND (ExternalAuthorityYN = 0) AND (AssessmentOfficer = 1) ORDER BY Officer"



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With combo.Properties
                        .DataSource = objDT
                        .DisplayMember = "Officer"
                        .ValueMember = "OfficerID"
                        .ShowFooter = False
                        .ShowHeader = False


                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = combo.Properties.Columns
                col2.Add(New LookUpColumnInfo("Officer", 0))
                col2.Add(New LookUpColumnInfo("OfficerID", 0))

                col2.Item(1).Visible = False

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using

    End Sub

    Private Sub LoadSearchList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ENG_Listing"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = _DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdListOfCertificates.DataSource = objDT



                    Dim View As DevExpress.XtraGrid.Views.Base.ColumnView = CType(grdListOfCertificates.MainView, DevExpress.XtraGrid.Views.Base.ColumnView)

                    View.MoveFirst()



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is SimpleButton Then

                Dim cb As SimpleButton = DirectCast(ctrl, SimpleButton)
                Select Case cb.Name
                    Case "btnViewOfficers", "btnAddFee", "btnAddRefund", "btnAddNote", "btnEditStatus"
                        cb.Enabled = True

                    Case "btnEditPayment", "btnRemoveFee", "btnEditRefund", "btnRemoveRefund"
                        cb.Enabled = False

                    Case Else
                        cb.Enabled = bLock

                End Select

            ElseIf TypeOf ctrl Is LookUpEdit Then

                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is TextEdit Then

                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is CheckEdit Then

                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is CheckBox Then

                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock

            ElseIf TypeOf ctrl Is RadioButton Then

                Dim cb As RadioButton = DirectCast(ctrl, RadioButton)
                cb.Enabled = bLock

            ElseIf TypeOf ctrl Is RadioGroup Then

                Dim cb As RadioGroup = DirectCast(ctrl, RadioGroup)
                cb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is ButtonEdit Then

                Dim cb As ButtonEdit = DirectCast(ctrl, ButtonEdit)
                cb.ReadOnly = True


            End If



            If ctrl.HasChildren Then
                LockTheForm(ctrl, bLock)
            End If

        Next
    End Sub

    Private Sub ClearData(ByVal pnl As Control)

        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing
            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is DateEdit Then
                Dim cb As DateEdit = DirectCast(ctrl, DateEdit)
                cb.EditValue = Nothing
            ElseIf TypeOf ctrl Is memoEdit Then
                Dim cb As MemoEdit = DirectCast(ctrl, MemoEdit)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.EditValue = Nothing
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            End If

            If ctrl.HasChildren Then
                ClearData(ctrl)
            End If


        Next

    End Sub

    Private Sub LoadListOfReferrals(CCno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfReferrals routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListReferrals"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = CCno
                        .Parameters.Add("@SYSTYPE", SqlDbType.VarChar).Value = "EG"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdLoadListReferrals.DataSource = objDT
                    'dgvSales.Refresh()

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub RetrievePostConsentData(EngID As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SelectEngineerPostConsent"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = EngID


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        lblEngDetNo.Text = EngID.ToString


                        If Not IsDBNull(objDataRow.Item("OriginalSubmissionDate")) Then dteOriginalSubmission.EditValue = CDate(objDataRow.Item("OriginalSubmissionDate"))

                        txtYourRef.Text = objDataRow.Item("YourRef").ToString

                        txtCCPlanNo.EditValue = objDataRow.Item("CCPlanNo").ToString
                        txtPlanSet.Text = objDataRow.Item("PlanSet").ToString

                        txtPlanProject.Text = objDataRow.Item("ProjectName").ToString
                        txtPlanDescription.Text = objDataRow.Item("Description").ToString

                        If Not IsDBNull(objDataRow.Item("Officer")) Then cboOfficer.EditValue = NZ(objDataRow.Item("Officer"))

                        txtEstate.Text = objDataRow.Item("CCEstate").ToString
                        txtStreet.Text = objDataRow.Item("Street").ToString
                        txtCCConsultant.Text = objDataRow.Item("CCConsultant").ToString
                        txtCCConsultantAdd.Text = objDataRow.Item("CCConsultantAdd").ToString
                        txtCCConsultantTown.Text = objDataRow.Item("CCConsultantTown").ToString
                        txtCCConsultantPCode.Text = objDataRow.Item("CCConsultantPCode").ToString
                        txtCCConsultantPhone.Text = objDataRow.Item("CCConsultantPhone").ToString
                        txtCCLotsCreated.Text = objDataRow.Item("CCLotsCreated").ToString
                        txtCCLinealMetres.Text = objDataRow.Item("CCLinealMetres").ToString


                        txtRequisitionText.Text = objDataRow.Item("RequisitionText").ToString

                        If Not IsDBNull(objDataRow.Item("RequisitionLetterDate")) Then dteRequisitionLetterDate.EditValue = CDate(objDataRow.Item("RequisitionLetterDate"))
                        If Not IsDBNull(objDataRow.Item("SignedPlansDate")) Then dteSignedPlansDate.EditValue = CDate(objDataRow.Item("SignedPlansDate"))

                        txtSubCertNo.Text = objDataRow.Item("SubCertNo").ToString

                        If Not IsDBNull(objDataRow.Item("LinenReleasedDate")) Then dteLinenReleasedDate.EditValue = CDate(objDataRow.Item("LinenReleasedDate"))

                        txtNewDPNumber.Text = objDataRow.Item("NewDPNumber").ToString

                        If Not IsDBNull(objDataRow.Item("NewDPRegistrationDate")) Then dteNewDPRegistrationDate.EditValue = CDate(objDataRow.Item("NewDPRegistrationDate"))

                        txtNewDPImagePath.Text = objDataRow.Item("NewDPImagePath").ToString

                    End If


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub btnSaveDA_ClickExtracted()

        btnEditDA.Enabled = True
        btnSaveDA.Enabled = False
        btnAddCC.Enabled = True
        LockTheForm(pnlApplication, False)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdatetEngineerPostConsent"

                        .Parameters.Add("@EngDetNo", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                        If txtCCPlanNo.Text <> String.Empty Then .Parameters.Add("@CCPlanNo", SqlDbType.Int).Value = CInt(txtCCPlanNo.Text)
                        .Parameters.Add("@PlanSet", SqlDbType.NVarChar).Value = txtPlanSet.Text

                        .Parameters.Add("@CCLotsCreated", SqlDbType.Int).Value = NZ(txtCCLotsCreated.Text)

                        .Parameters.Add("@CCLinealMetres", SqlDbType.Int).Value = NZ(txtCCLinealMetres.Text)
                        .Parameters.Add("@CCEstate", SqlDbType.NVarChar).Value = txtEstate.Text
                        .Parameters.Add("@CCConsultant", SqlDbType.NVarChar).Value = txtCCConsultant.Text

                        .Parameters.Add("@NewDPNumber", SqlDbType.NVarChar).Value = txtNewDPNumber.Text

                        .Parameters.Add("@NewDPRegistrationDate", SqlDbType.SmallDateTime)

                        If dteNewDPRegistrationDate.EditValue IsNot Nothing Then

                            If dteNewDPRegistrationDate.EditValue.ToString <> String.Empty Then

                                .Parameters("@NewDPRegistrationDate").Value = Format(CDate(dteNewDPRegistrationDate.EditValue), "yyyy-MM-dd")

                            End If

                        End If


                        .Parameters.Add("@NewDPImagePath", SqlDbType.NVarChar).Value = txtNewDPImagePath.Text
                        .Parameters.Add("@Officer", SqlDbType.Int)
                        If cboOfficer.EditValue IsNot Nothing Then .Parameters("@Officer").Value = CInt(cboOfficer.EditValue)

                        .Parameters.Add("@CCConsultantAdd", SqlDbType.NVarChar).Value = txtCCConsultantAdd.Text
                        .Parameters.Add("@CCConsultantTown", SqlDbType.NVarChar).Value = txtCCConsultantTown.Text

                        If txtCCConsultantPCode.Text <> String.Empty Then .Parameters.Add("@CCConsultantPCode", SqlDbType.SmallInt).Value = CInt(txtCCConsultantPCode.Text)

                        .Parameters.Add("@CCConsultantPhone", SqlDbType.NVarChar).Value = txtCCConsultantPhone.Text
                        .Parameters.Add("@RequisitionText", SqlDbType.NText).Value = txtRequisitionText.Text


                        If dteRequisitionLetterDate.EditValue IsNot Nothing Then

                            If dteRequisitionLetterDate.EditValue.ToString <> String.Empty Then

                                .Parameters.Add("@RequisitionLetterDate", SqlDbType.SmallDateTime).Value = Format(CDate(dteRequisitionLetterDate.EditValue), "yyyy-MM-dd")

                            End If

                        End If


                        If dteOriginalSubmission.EditValue IsNot Nothing Then

                            If dteOriginalSubmission.EditValue.ToString <> String.Empty Then

                                .Parameters.Add("@OriginalSubmissionDate", SqlDbType.SmallDateTime).Value = Format(CDate(dteOriginalSubmission.EditValue), "yyyy-MM-dd")

                            End If

                        End If


                        If dteSignedPlansDate.EditValue IsNot Nothing Then

                            If dteSignedPlansDate.EditValue.ToString <> String.Empty Then

                                .Parameters.Add("@SignedPlansDate", SqlDbType.SmallDateTime).Value = Format(CDate(dteSignedPlansDate.EditValue), "yyyy-MM-dd")
                            End If

                        End If


                        If dteLinenReleasedDate.EditValue IsNot Nothing Then

                            If dteLinenReleasedDate.EditValue.ToString <> String.Empty Then

                                .Parameters.Add("@LinenReleasedDate", SqlDbType.SmallDateTime).Value = Format(CDate(dteLinenReleasedDate.EditValue), "yyyy-MM-dd")

                            End If

                        End If

                        .Parameters.Add("@ProjectName", SqlDbType.NVarChar).Value = txtPlanProject.Text
                        .Parameters.Add("@Description", SqlDbType.NVarChar).Value = txtPlanDescription.Text


                        .Parameters.Add("@SubCertNo", SqlDbType.NVarChar).Value = txtSubCertNo.Text
                        .Parameters.Add("@Street", SqlDbType.NVarChar).Value = txtStreet.Text
                        .Parameters.Add("@YourRef", SqlDbType.NVarChar).Value = txtYourRef.Text

                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Name)

            End Try
        End Using
    End Sub

    Private Sub LoadForm(ByVal EngNumber As Integer)

        If btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If

        ClearData(pnlApplication)

        Try

            txtDANo.Text = _DANo

            RetrievePostConsentData(EngNumber)

            LoadPaymentsRecieved(EngNumber)
            LoadRefundsPaid(EngNumber)
            LoadSection94(_DANo)
            LoadDASummaryData(_DANo)


            LoadCharges(EngNumber)


            'LoadPaymentsRecieved(_DANo)

            'LoadRefundsPaid(_DANo)

            'DisplayDraftDocuments(EngNumber)

            DisplayListOfDraftDocuments()

            LoadHistoricalDocuments(EngNumber)

            RetrieveFileNotes(EngNumber)

            LoadEngineeringChargesSummary(EngNumber)

            CalculateRefundsandPayments(EngNumber)

            LoadListOfReferrals(EngNumber)

            LoadTimeLineGrid(EngNumber)



            LoadReferralsIntProvisionlList(_DANo)

            DisplayListOfDraftDocuments(lblEngDetNo.Text)

            cboLetterType.Enabled = True

            btnEditDA.Enabled = True

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadDASummaryData(ByVal DANo As String)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DASummaryData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            txtPIN.Text = objDataReader.Item("PIN").ToString
                            If Not IsDBNull(objDataReader.Item("DADetermDt")) Then txtDADetermined.Text = Format(CDate(objDataReader.Item("DADetermDt")), "dd/MM/yyyy")
                            txtDALot.Text = objDataReader.Item("DALot").ToString
                            txtDADP.Text = objDataReader.Item("DADP").ToString
                            txtDASection.Text = objDataReader.Item("DASection").ToString
                            txtDAAddress.Text = objDataReader.Item("Address").ToString
                            txtApplicant.Text = objDataReader.Item("DAOwnersName").ToString
                            txtStatus.Text = objDataReader.Item("DADecision").ToString
                            txtFileNo.Text = objDataReader.Item("DAFileNo").ToString
                            txtOfficer.Text = objDataReader.Item("Officer").ToString
                            lblOfficer.Tag = objDataReader.Item("DaOfficerID").ToString
                            txtDANo.Text = objDataReader.Item("DANo").ToString
                            txtDADescription.Text = objDataReader.Item("DADesc").ToString



                        Loop
                    End Using




                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub EngineeringPostConsentModule_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim RFS As New ArrayList

        ' Add division structure entries to the arraylist
        With RFS
            .Add(New RFSSubvisionType("Residential", "2"))
            .Add(New RFSSubvisionType("Rural", "1"))
        End With

        With cboRFSSubDivisionType.Properties
            .DataSource = RFS
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowHeader = False
            .ShowFooter = False

        End With

        LoadSearchList()


        If gvwListOfCertificates.RowCount > 0 Then

            Dim myobj As DataRowView = CType(gvwListOfCertificates.GetFocusedRow, DataRowView)

            Dim Whatever As Integer = CInt(myobj.Row.Item("EngDetNo"))

            LoadForm(Whatever)


        End If

        gvwEngineeringTimeLine.OptionsBehavior.Editable = False


    End Sub

    Private Sub btnAddCC_Click(sender As Object, e As EventArgs) Handles btnAddCC.Click
        Dim NewEngDetNo As Integer

        lblEngDetNo.Text = "0"
        LockTheForm(pnlApplication, True)

        ClearData(pnlApplication)
        ClearData(pnlReferrals)
        ClearData(pnlFileNotes)

        If MessageBox.Show("Create a new Engineer Post consent now?", "Create New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        NewEngDetNo = CreatNewRecord()


        If NewEngDetNo <> 0 Then LoadForm(NewEngDetNo)

        txtReceipts.Text = String.Empty
        txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty

        btnEditDA.Enabled = False

        btnSaveDA.Enabled = True
        btnAddCC.Enabled = False


    End Sub

    Private Function CreatNewRecord() As Integer

        Dim result As Integer

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CreatNewRecord routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateNewEngPostConsent"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = _DANo
                        .Parameters.Add("@ENGNO", SqlDbType.Int).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CInt(.Parameters("@ENGNO").Value)
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CreatNewRecord routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function

    Private Sub btnViewPlans_Click(sender As Object, e As EventArgs) Handles btnViewPlans.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim FileToView As String = String.Empty
        Dim x As Integer

        With openFileDialog1
            .Title = "This is used to attach the Deposit Plan"
            .InitialDirectory = "\\fs\common\gis\lto\"
            .Filter = "TIF files (*.tif)|*.tif"
            .FilterIndex = 1
            .RestoreDirectory = True
            .ShowDialog()
            If .FileName <> String.Empty Then
                FileToView = .FileName.ToString
            End If

        End With



        If FileToView <> String.Empty Then
            IO.File.Copy(FileToView, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif", True)
            Dim folderTolookat As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif"
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & folderTolookat) 'DPFolderLocation & DepositedPlan)
        Else
            MessageBox.Show("Unable to find a DP file, it may not be linked, see Heidi ", "Unable to display plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnViewDp_Click(sender As Object, e As EventArgs) Handles btnViewDp.Click
        Dim x As Integer
        If Not IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview") Then
            IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview")
        End If


        If txtNewDPImagePath.Text <> String.Empty Then
            IO.File.Copy(txtNewDPImagePath.Text, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif", True)
            Dim folderTolookat As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif"
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & folderTolookat) 'DPFolderLocation & DepositedPlan)
        Else
            MessageBox.Show("Unable to find a DP file, it may not be linked. ", "Unable to display plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNewDPImagePath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtNewDPImagePath.ButtonClick
        Dim openFileDialog1 As New OpenFileDialog()

        With openFileDialog1
            .Title = "This is used to attach the Deposit Plan"
            .InitialDirectory = "\\fs\common\gis\lto\"
            .Filter = "TIF files (*.tif)|*.tif"
            .FilterIndex = 1
            .RestoreDirectory = True
            .ShowDialog()
            If .FileName <> String.Empty Then
                txtNewDPImagePath.Text = .FileName.ToString
            End If
        End With

    End Sub

    Private Sub btnEditDA_Click(sender As Object, e As EventArgs) Handles btnEditDA.Click

        LockTheForm(pnlApplication, True)

        btnEditDA.Enabled = False

        btnSaveDA.Enabled = True

    End Sub

    Private Sub btnSaveDA_Click(sender As Object, e As EventArgs) Handles btnSaveDA.Click

        btnSaveDA_ClickExtracted()

    End Sub



#End Region

#Region "Historical Docs"

    Private Sub LoadHistoricalDocuments(AppNo As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_RetrieveHistoricalDevDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "EG"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    grdDocumentsList.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub btnSaveTheNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveTheNote.Click

        If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateDocumentNote"
                        .Parameters.Add("@NOTES", SqlDbType.NText).Value = txtDocNote.Text
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DocId"))
                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Name)

            End Try
        End Using
        'reload file numbers
        txtDocNote.Text = String.Empty
        Try
            LoadHistoricalDocuments(lblEngDetNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnViewWord_Click(sender As Object, e As EventArgs) Handles btnViewWord.Click

        Dim DocumentName As String = String.Empty

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_RetrieveWordDocument"

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DocId"))


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        DocumentName = objDataRow.Item("WordDocName").ToString

                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName) Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

                        If Not IsDBNull(objDataRow.Item("WordObject")) Then

                            Dim blob As [Byte]() = DirectCast(objDataRow.Item("WordObject"), [Byte]())


                            Dim ms As MemoryStream = New MemoryStream(blob)


                            Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

                                ms.WriteTo(fs)
                                'ms.Close()

                            End Using


                        End If


                    End If

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Name)

            End Try
        End Using



        Dim mailObject As New OpenDocument

        mailObject.OpenVisible(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

    End Sub


    Private Sub btnViewPDF_Click(sender As Object, e As EventArgs) Handles btnViewPDF.Click


        DisplayPDFdocument()

    End Sub

    Private Sub btnRemoveDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDocument.Click

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        Dim documentToRemove As String = myobj.Row.Item("DocumentDesc").ToString & " created " & Format(CDate(myobj.Row.Item("DateCreated")), "dd/MM/yyyy")



        If MessageBox.Show("Remove " & documentToRemove & " from the list?", "Remove this document", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim removedocument As New RemoveDocument

        With removedocument
            .DocumentID = CInt(myobj.Row.Item("DocId"))
            .DocumentToRemove = myobj.Row.Item("FileName").ToString
            .RemoveDocument()
        End With

        Try
            LoadHistoricalDocuments(lblEngDetNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DisplayPDFdocument()

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        'If dgvDocumentsList.CurrentRow.Cells(8).Value.ToString = String.Empty Then Exit Sub

        'Dim sDocname As String = dgvDocumentsList.CurrentRow.Cells(8).Value.ToString
        'Dim sMTH As String = dgvDocumentsList.CurrentRow.Cells(5).Value.ToString
        'Dim sYr As String = dgvDocumentsList.CurrentRow.Cells(6).Value.ToString
        'Dim sPDFDoc As String = String.Empty

        Dim sDocname As String = myobj.Row.Item("FileName").ToString
        Dim sMTH As String = myobj.Row.Item("DocMTH").ToString
        Dim sYr As String = myobj.Row.Item("DocYr").ToString
        Dim sPDFDoc As String = String.Empty


        If sDocname.Length <= 8 Then
            Dim YeartoCheck As String = "20" & sDocname.Substring(InStr(sDocname, "_"), 2)
            If CLng(YeartoCheck) <> CLng(Today.Year) Then
                sPDFDoc = My.Settings.ARCHIVE & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            Else
                sPDFDoc = My.Settings.HASHBIN & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            End If


        ElseIf sDocname.Length <> 0 Then
            If CLng(sYr) = Today.Year Then
                sPDFDoc = My.Settings.HASHBIN & sYr & "\" & sMTH & "\" & sDocname

            Else
                sPDFDoc = My.Settings.ARCHIVE & sYr & "\" & sMTH & "\" & sDocname

            End If

        End If


        'If Is64BitOperatingSystem Then

        '    If sPDFDoc <> String.Empty Then WebBrowser1.Navigate(sPDFDoc)

        'Else

        If sPDFDoc <> String.Empty Then


            Dim WRD As New OpenDocument
            WRD.OpenVisible(sPDFDoc)


            'Dim PDFviewer As New PDFviewer
            'With PDFviewer
            '    .DocumentToDisplay = sPDFDoc
            '    .ShowDialog()
            '    .Dispose()
            'End With


        End If


        'End If




    End Sub

    Private Sub gvwDocumentsList_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwDocumentsList.RowClick

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)

        txtDocNote.Text = myobj.Row.Item("notes").ToString

        btnRemoveDocument.Enabled = True
        btnViewPDF.Enabled = True




        btnViewWord.Enabled = myobj.Row.Item("WORDDOC").ToString <> "N"



    End Sub

#End Region

#Region "Referrals"


    Private Sub btnMailResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailResponse.Click
        If Me.txtRefResponse.Text = String.Empty Then
            MessageBox.Show("There is nothing typed in the response area - please complete and try again", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Subject As String = "Referral Response for Appl No: " & lblEngDetNo.Text
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

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Function GetEmailAddress() As String
        Dim result As String = String.Empty

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


    Private Sub btnPrintsepp71_Click(sender As Object, e As EventArgs) Handles btnPrintsepp71.Click
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
                    PrintOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & lblEngDetNo.Text, "Sepp71Referral.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
            End Try
        End Using
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
                Throw (New Exception("Unable to locate report file:  " & vbCrLf & strReportPath))
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
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try

    End Sub

    Private Function CheckReferralData() As Boolean
        Dim result As Boolean = True

        If Not IsDate(Refdt.Text) Then
            With errorProvider
                .SetError(Refdt, "A referral date is required")
            End With
            result = False
        Else
            errorProvider.SetError(Refdt, "")

        End If
        If cboRefCodeId.EditValue Is Nothing Then
            errorProvider.SetError(cboRefCodeId, "A referral source is required")

            result = False
        Else
            errorProvider.SetError(cboRefCodeId, "")

        End If
        If txtRefComm.Text = String.Empty Then

            errorProvider.SetError(txtRefComm, "A comment is required")

            result = False
        Else
            errorProvider.SetError(txtRefComm, "")

        End If
        If cboRFSSubDivisionType.Visible Then
            If cboRFSSubDivisionType.EditValue Is Nothing Then

                errorProvider.SetError(cboRFSSubDivisionType, "A comment is required")

                result = False
            Else
                errorProvider.SetError(cboRFSSubDivisionType, "")

            End If

            If txtRFSSubLots.Text = String.Empty Then
                errorProvider.SetError(txtRFSSubLots, "A comment is required")

                result = False
            Else
                errorProvider.SetError(txtRFSSubLots, "")

            End If
        End If
        Return result
    End Function

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        With My.Forms.ReferralsResponsePopUp
            .ResponseText = txtRefResponse.Text
            .ShowDialog()
            txtRefResponse.Text = .ResponseText
            .Dispose()
        End With

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        With My.Forms.DraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = lblEngDetNo.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click

        btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(pnlReferrals)
        lblReferralID.Text = String.Empty


        'LockTheForm(pnlButtons, True)
        LockTheForm(pnlReferrals, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        txtRefComm.ReadOnly = False

        LoadLstIntegrated(lblEngDetNo.Text)
        btnAddReferral.Enabled = False
        btnEditReferralsTab.Enabled = False

    End Sub

    Private Sub SaveReferralData()
        btnEditReferralsTab.Enabled = True
        btnSaveReferralsTab.Enabled = False
        LockTheForm(pnlReferrals, False)
        LockTheForm(pnlButtons, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(pnlReferrals, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Referrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblEngDetNo.Text
                        .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                        .Parameters.Add("@REFDATE", SqlDbType.SmallDateTime)
                        If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
                        If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.EditValue)
                        .Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = chksepp71.CheckState
                        .Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = chkIntDev.CheckState
                        .Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = chkSensitive.CheckState
                        .Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = chk100Mark.CheckState
                        .Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If Not cboRFSSubDivisionType.EditValue Is Nothing Then .Parameters("@RFSSUBDIV").Value = cboRFSSubDivisionType.EditValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Name)

            End Try
        End Using

        LoadReferralsIntProvisionlList(lblEngDetNo.Text)
        LoadLstIntegrated(lblEngDetNo.Text)

    End Sub

    Private Sub btnEditReferralsTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditReferralsTab.Click
        btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        'LockTheForm(pnlButtons, True)
        LockTheForm(pnlReferrals, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        'LockTheForm(grpSepp71, True)

    End Sub

    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        SaveReferralData()
        ClearReferralData(pnlReferrals)

    End Sub

    Private Sub gvwLoadListReferrals_RowClick(ByVal sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwLoadListReferrals.RowClick



        Try

            Dim myobj As DataRowView = CType(gvwLoadListReferrals.GetFocusedRow, DataRowView)


            LoadReferralDetails(CInt(myobj.Row.Item("ReferralId")))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        LockTheForm(pnlButtons, True)

        btnView.Enabled = True
        btnEditReferralsTab.Enabled = True
        btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

            Case 2, 3
                grpRFS.Visible = False
                btnRTA.Visible = True
                btnRTA.Enabled = True

            Case 59

                grpRFS.Visible = chksepp71.Checked

                btnRTA.Visible = False
                btnPrintRFSOther.Enabled = True
                btnPrintRFSSub.Enabled = True

            Case Else
                grpRFS.Visible = False
                btnRTA.Visible = False

        End Select



        If lblReferralID.Text.Length = 0 Then
            btnAddIntegrated.Enabled = False
            btnRemoveIntegated.Enabled = False
        End If
        btnRemoveRefer.Enabled = True



    End Sub

    Private Sub LoadReferralDetails(ByVal ID As Integer)


        lblReferralID.Text = String.Empty
        Refdt.EditValue = Nothing
        RefRetDt.EditValue = Nothing
        cboRefCodeId.EditValue = Nothing
        txtRefComm.Text = String.Empty
        txtRefResponse.Text = String.Empty
        chksepp71.Checked = False
        chkIntDev.Checked = False
        chkSensitive.Checked = False
        chk100Mark.Checked = False
        chkSch3.Checked = False
        cboRFSSubDivisionType.EditValue = Nothing
        txtRFSSubLots.Text = String.Empty
        txtEngInternalComments.Text = String.Empty
        EngDueReturnDate.EditValue = Nothing



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveReferalInfo"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)


                        lblReferralID.Text = objDataRow.Item("ReferralID").ToString
                        If Not IsDBNull(objDataRow.Item("Refdt")) Then Refdt.EditValue = CDate(objDataRow.Item("Refdt"))
                        If Not IsDBNull(objDataRow.Item("RefRetDt")) Then RefRetDt.EditValue = CDate(objDataRow.Item("RefRetDt"))
                        DaysElapsedTextBox.Text = objDataRow.Item("DaysElapsed").ToString
                        If Not IsDBNull(objDataRow.Item("RefCodeId")) Then cboRefCodeId.EditValue = CInt(objDataRow.Item("RefCodeId"))
                        'txtSepp71LikelyImpacts.Text = objDataRow.Item("Sepp71LikelyImpacts").ToString
                        txtRefComm.Text = objDataRow.Item("RefComm").ToString
                        txtRefResponse.Text = objDataRow.Item("RefResponse").ToString
                        chksepp71.Checked = CBool(objDataRow.Item("Sepp71Refer"))

                        grpRFS.Visible = chksepp71.Checked

                        If Not IsDBNull(objDataRow.Item("BinaryDocument")) Then

                            btnAddPDF.Text = "View Document"
                            btnAddPDF.Tag = "VIEW"

                        Else

                            btnAddPDF.Text = "Add PDF/Image"
                            btnAddPDF.Tag = "ADD"

                        End If

                        chkIntDev.Checked = CBool(objDataRow.Item("Sepp71IntDev"))
                        chkSensitive.Checked = CBool(objDataRow.Item("Sepp71Sensitive"))
                        chk100Mark.Checked = CBool(objDataRow.Item("Sepp71100Mark"))
                        chkSch3.Checked = CBool(objDataRow.Item("Sepp71Schedule3"))
                        If Not IsDBNull(objDataRow.Item("RFSSubDiv")) Then cboRFSSubDivisionType.EditValue = objDataRow.Item("RFSSubDiv").ToString
                        txtRFSSubLots.Text = objDataRow.Item("RFSSubLots").ToString
                        txtEngInternalComments.Text = objDataRow.Item("EngInternalComments").ToString
                        If Not IsDBNull(objDataRow.Item("EngDueReturnDate")) Then EngDueReturnDate.EditValue = CDate(objDataRow.Item("EngDueReturnDate"))



                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub btnReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferral.Click
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "EG"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    PrintOnPlainPaperOnly(objDT, "Referral Response " & lblEngDetNo.Text, "ReferralResponse.rpt", 1)

                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message & " in function btnReferral_Click")
            End Try

        End Using

    End Sub

    Private Sub btnPrintRFSOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSOther.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim docType As Integer = 55
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "EG"


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = docType
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, lblEngDetNo.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & lblEngDetNo.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub btnPrintRFSSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSSub.Click

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim docType As Integer = 56
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "EG"


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = docType
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, lblEngDetNo.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & lblEngDetNo.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub btnRTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRTA.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Roads and Traffic Authority. OK to proceed?", "Print RTA Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim docType As Integer = 48
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "EG"


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = 48 'RTA referral letter
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, lblEngDetNo.Text, docname, docfilename, sysType, "Referral letter for Roads and Maritime Service" & lblEngDetNo.Text, MacroName)




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try
        End Using

    End Sub

    Private Sub btnRemoveRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefer.Click


        If MessageBox.Show("Are you sure you want to remove this referral?", "Remove Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Name)

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
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Name)

            End Try
        End Using

        LoadReferralsIntProvisionlList(lblEngDetNo.Text)
        LoadLstIntegrated(lblEngDetNo.Text)



        LockTheForm(pnlButtons, False)
        LockTheForm(pnlReferrals, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        btnView.Enabled = True
        btnEditReferralsTab.Enabled = False
        btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

            Case 2, 3
                grpRFS.Visible = False
                btnRTA.Visible = True
                btnRTA.Enabled = True

            Case 59
                grpRFS.Visible = True
                btnRTA.Visible = False
                btnPrintRFSOther.Enabled = True
                btnPrintRFSSub.Enabled = True

            Case Else
                grpRFS.Visible = False
                btnRTA.Visible = False

        End Select

        If lblReferralID.Text.Length = 0 Then
            btnAddIntegrated.Enabled = False
            btnRemoveIntegated.Enabled = False
        End If
        btnRemoveRefer.Enabled = True

        ClearReferralData(pnlReferrals)


    End Sub


    Private Sub cboReferralsIntProvision_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.EditValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If Not cboReferralsIntProvision.EditValue Is Nothing Then

            If MessageBox.Show("Add  " & cboReferralsIntProvision.Text & " ?", "Add ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.connectionString)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_InsertNewReferralIntProvision"
                                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                                .Parameters.Add("@PROVISIONID", SqlDbType.Int).Value = CInt(cboReferralsIntProvision.EditValue)
                                .ExecuteNonQuery()
                            End With

                        End Using

                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    LoadLstIntegrated(lblEngDetNo.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.EditValue = Nothing
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Name)

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
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Name)

                End Try
            End Using
            'reload file numbers
            Try
                LoadLstIntegrated(lblEngDetNo.Text)

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub LoadLstIntegrated(ByVal CdNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReferralsIntegratedProvision"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CdNo
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With lstIntegrated
                        .DataSource = objDT
                        .DisplayMember = "IntActName"
                        .ValueMember = "id"
                        .SelectedIndex = -1
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub LoadReferralsIntProvisionlList(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListReferrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdLoadListReferrals.DataSource = objDT
                    grdLoadListReferrals.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub ClearReferralData(ByVal Pnl As Control)

        For Each ctrl As Control In Pnl.Controls

            If TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
                cb.SelectedIndex = -1


            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing

            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.EditValue = Nothing



            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.EditValue = Nothing



            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty



            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty


            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked

            End If
        Next

        lblReferralID.Text = String.Empty

    End Sub



    Private Function ReadFile(ByVal sPath As String) As Byte()
        'Initialize byte array with a null value initially.        
        Dim data As Byte() = Nothing
        'Use FileInfo object to get file size.      
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        'Open FileStream to read file        
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)
        'Use BinaryReader to read file stream into byte array.       
        Dim br As New BinaryReader(fStream)
        'When you use BinaryReader, you need to supply number of bytes to read from file.        
        'In this case we want to read entire file. So supplying total number of bytes.         
        data = br.ReadBytes(CInt(numBytes))

        fStream.Close()

        Return data
    End Function

    Private Sub btnAddPDF_Click(sender As Object, e As EventArgs) Handles btnAddPDF.Click

        Dim btn As DevExpress.XtraEditors.SimpleButton = TryCast(sender, DevExpress.XtraEditors.SimpleButton)



        If btn.Tag = "ADD" Then

            Dim OpenFileDialoge As New OpenFileDialog

            With OpenFileDialoge
                .Tag = "SELECT FILE TO INSERT"
                .Filter = "pdf files (*.pdf)|*.pdf|Image Files (*.jpg)|*.jpg"
            End With
            Dim filename As String = String.Empty
            Dim fileType As String = String.Empty

            If (OpenFileDialoge.ShowDialog = DialogResult.OK) Then
                filename = OpenFileDialoge.FileName
                fileType = IO.Path.GetExtension(filename)

                'Dim imageData As Byte() = ReadFile(filename)
                'Dim imageData As Byte() = File.ReadAllBytes(filename)

                Dim imageData As Byte()
                imageData = ReadFile(filename)



                Using cn As New SqlConnection(My.Settings.connectionString)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_UPDATE_Referrals_Image"

                                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                                .Parameters.Add("@BinaryDocument", SqlDbType.VarBinary).Value = imageData
                                .Parameters.Add("@DocumentType", SqlDbType.VarChar).Value = fileType


                                .ExecuteNonQuery()

                                btnAddPDF.Text = "View Document"
                                btnAddPDF.Tag = "VIEW"


                            End With



                        End Using



                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Name)

                    End Try
                End Using

            End If

        Else

            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_referral_SELECT_ImageData"

                            .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)

                        End With

                        Dim objDT As New DataTable


                        Using objDataReader As SqlDataReader = cmd.ExecuteReader
                            objDT.Load(objDataReader)
                        End Using


                        If objDT.Rows.Count > 0 Then

                            Dim objDataRow As DataRow = objDT.Rows.Item(0)

                            If Not IsDBNull(objDataRow.Item("BinaryDocument")) Then

                                Dim blob As [Byte]() = DirectCast(objDataRow.Item("BinaryDocument"), [Byte]())

                                If Not blob Is Nothing Then

                                    Dim encoding As New UnicodeEncoding

                                    Dim ms As MemoryStream = New MemoryStream(blob)




                                    If objDataRow.Item("DocumentType").ToString.ToUpper = ".PDF" Then

                                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

                                        Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

                                            ms.WriteTo(fs)

                                        End Using

                                        Dim PdfView As New OpenDocument
                                        PdfView.OpenVisible(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")



                                        'With My.Forms.ViewerForPDF


                                        '    '.FileLocation = New MemoryStream(blob)

                                        '    .ShowDialog()

                                        '    .Dispose()

                                        'End With



                                    Else

                                        Dim myimage As Image = Image.FromStream(New IO.MemoryStream(blob))


                                        With My.Forms.ViewImage

                                            .PictureToShow = myimage

                                            .ShowDialog()

                                            .Dispose()

                                        End With

                                    End If





                                End If

                            End If

                        End If
                    End Using



                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " Then In btnAddPDF_Click routine - form " & Name)

                End Try
            End Using



        End If

    End Sub


    Public Sub PrintAndEASEWordDocs(ByVal doctype As Integer, ByVal AppNo As String, ByVal docname As String, ByVal docfilename As String, ByVal appsys As String, ByVal DocSummary As String, Optional ByVal macroName As String = "", Optional ByVal DocCode As String = "", Optional ByVal LHead As String = "Y")
        Dim objWordApp As New Microsoft.Office.Interop.Word.Application
        Dim objWordDoc As New Microsoft.Office.Interop.Word.Document
        Dim addressformat As String = String.Empty
        Dim lotformat As String = String.Empty
        Dim keepprinter As String = String.Empty
        Dim bookcode As String = String.Empty
        Dim fieldcode As String = String.Empty
        Dim fieldval As String = String.Empty
        Dim WordDocFileName As String = String.Empty
        Dim bcappno As String = String.Empty
        Dim ConsentDataExtractQueryName As String = String.Empty
        Dim CommonFieldsLinkQueryName As String = String.Empty
        Dim ConditionComponentQueryName As String = String.Empty
        Dim sdate As String = String.Empty
        Dim objDataRow As DataRow
        Dim WordDocName As String

        Try

            sdate = Format(Today.Date, "dd/MM/yyyy")

            bcappno = AppNo


            ConsentDataExtractQueryName = "usp_CC_ConsentDatExtract"
            CommonFieldsLinkQueryName = "usp_CC_CommonFieldsLink"
            ConditionComponentQueryName = "usp_ConditionComponents_CC"


            objWordApp.Visible = False

            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            'objWordDoc = objWordApp.Application.Documents.Open(docfilena ToString)
            objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename), NewTemplate:=False, DocumentType:=0)
            With objWordDoc


                'Retrieve the base data for this application

                Dim objDTextract As DataTable = GetTheBaseData(ConsentDataExtractQueryName, AppNo)
                Dim RowCount As Integer = objDTextract.Rows.Count
                'if there is not base data then no need to continue
                If objDTextract.Rows.Count <= 0 Then
                    Exit Sub
                Else
                    objDataRow = objDTextract.Rows.Item(0)
                End If


                'Insert CommonFields---------------------------------

                ' Get the common fields to be used to extract the data from the base data
                Dim objDRCommonFields As DataTable = GetTheCommonFields(CommonFieldsLinkQueryName, AppNo, doctype)

                If objDRCommonFields.Rows.Count > 0 Then
                    'Loop thru the commonfields and extract the data and populate the word document



                    For i As Integer = 0 To objDRCommonFields.Rows.Count - 1
                        fieldcode = objDRCommonFields.Rows(i).Item(0).ToString
                        bookcode = objDRCommonFields.Rows(i).Item(1).ToString
                        .Bookmarks(bookcode).Select()
                        If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
                            .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
                        End If

                    Next


                End If

                'END INSERT COMMON FIELDS------------------------------

                ' OK TO HERE <<<<--------



                'Insert Attached Conditions and headings if applicable

                Dim objDRSTDcond As DataTable = GetConditionsAndHeadings(AppNo, doctype)


                'Loop thru the commonfields and extract the data and populate the word document
                If objDRSTDcond.Rows.Count > 0 Then
                    'Loop thru the commonfields and extract the data and populate the word document

                    For i As Integer = 0 To objDRSTDcond.Rows.Count - 1
                        fieldcode = objDRSTDcond.Rows(i).Item(2).ToString
                        bookcode = objDRSTDcond.Rows(i).Item(3).ToString

                        If CBool(objDRSTDcond.Rows(i).Item(5).ToString) = False Then

                            .Bookmarks(bookcode).Select()

                            If fieldcode <> String.Empty Then
                                .Application.Selection.Text = GetOneOffCondition(CInt(fieldcode))
                            End If
                        Else
                            .Bookmarks(bookcode).Range.Select()
                            objWordApp.Selection.InsertFile(fieldcode)

                        End If

                    Next


                End If
                'END INSERT STD CONDITIONS-----------------------------------








                'Insert Attached Conditions and headings if applicable -----------


                Dim objDROneUpDcond As DataTable = GetTheCommonFields(ConditionComponentQueryName, AppNo, doctype)


                If objDROneUpDcond.Rows.Count > 0 Then
                    'Loop thru the commonfields and extract the data and populate the word document

                    For i As Integer = 0 To objDROneUpDcond.Rows.Count - 1
                        fieldcode = objDROneUpDcond.Rows(i).Item(1).ToString
                        bookcode = objDROneUpDcond.Rows(i).Item(0).ToString
                        .Bookmarks(bookcode).Select()
                        If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
                            .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
                        End If


                    Next


                End If


                'END Insert Attached Conditions and headings-------------------------------



                'Insert free-format inserts for standard conditions------------------------

                Dim objDRFreeForm As DataTable = GetFreeFormText(AppNo, doctype)

                'Loop thru the commonfields and extract the data and populate the word document

                If objDRFreeForm.Rows.Count > 0 Then
                    'Loop thru the commonfields and extract the data and populate the word document

                    For i As Integer = 0 To objDRFreeForm.Rows.Count - 1
                        fieldcode = objDRFreeForm.Rows(i).Item(1).ToString
                        bookcode = objDRFreeForm.Rows(i).Item(3).ToString
                        Try
                            .Bookmarks(bookcode).Select()
                            If fieldcode.ToString <> String.Empty Then
                                .Application.Selection.Text = fieldcode
                            End If

                        Catch ex As Exception

                        End Try

                    Next


                End If



                'END Insert free-format inserts for standard conditions------------------------




                If macroName <> String.Empty Then .Application.Run(macroName)


                ''If LHead = "Y" Then
                '.PageSetup.FirstPageTray = WORD.WdPaperTray.wdPrinterMiddleBin
                '.PageSetup.OtherPagesTray = WORD.WdPaperTray.wdPrinterLargeCapacityBin
                '.PrintOut(Background:=False, Copies:=2)


                ''Else
                ''.PrintOut(Background:=False, Copies:=2)
                ''End If


                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
                End If

                WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & docname & "_" & AppNo.Replace("/", "_") & "_DATE_" & sdate.Replace("/", "_") & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"


                '.SaveAs(WordDocNa ToString, FileFormat:=WORD.WdSaveFormat.wdFormatXMLDocument)

                With objWordApp.ActiveDocument.PageSetup

                    .FirstPageTray = WORD.WdPaperTray.wdPrinterMiddleBin
                    .OtherPagesTray = WORD.WdPaperTray.wdPrinterLargeCapacityBin
                End With


                objWordApp.ActiveDocument.PrintOut(Range:=WORD.WdPrintOutRange.wdPrintAllDocument, Item:=WORD.WdPrintOutItem.wdPrintDocumentWithMarkup, Copies:=1, Pages:="", PageType:=WORD.WdPrintOutPages.wdPrintAllPages, Collate:=True, Background:=True, PrintToFile:=False)

                objWordApp.ActiveDocument.ExportAsFixedFormat(OutputFileName:=mydocuments & "\" & strEASEdocumentName, ExportFormat:=WORD.WdExportFormat.wdExportFormatPDF, OpenAfterExport:=False, OptimizeFor:=WORD.WdExportOptimizeFor.wdExportOptimizeForPrint, Range:=WORD.WdExportRange.wdExportAllDocument)

                objWordApp.ActiveDocument.Close(SaveChanges:=False)




            End With

            objWordApp.Quit()
            releaseObject(objWordDoc)

            releaseObject(objWordApp)


            Dim PublicId As Integer


            With My.Forms.EASEInsertWordDocument

                Select Case doctype
                    Case 55, 56 'RFSDAREFERRAL, RFSSUBREFERRAL
                        PublicId = 278599

                    Case 48 'RTAREFERRAL
                        PublicId = 287392
                End Select
                .PublicID = PublicId
                .FileNumber = txtFileNo.Text
                .DocSummary = DocSummary
                .DocNumber = strDocumentNo
                .ShowDialog()
                .Dispose()
            End With




            'My.Computer.FileSystem.DeleteFile(WordDocName)


            FileIO.FileSystem.MoveFile(mydocuments & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)




        Catch ex As Exception
            MessageBox.Show(ex.Message, " in CreateWordDocs routine in CreateWordDocuments module ")

        End Try





    End Sub

#End Region

#Region "Fee Summary"

    Private Sub LoadSection94(ByVal DANo As String)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94 routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Engineer_Section94Contributions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdSection94Contributions.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94 routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub LoadEngineeringChargesSummary(AppID As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ENG_Charges"

                        .Parameters.Add("@APPID", SqlDbType.Int).Value = AppID


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdEngineeringCharges.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using


    End Sub

#End Region

#Region "PayMents and Refunds"


    Private Sub LoadPaymentsRecieved(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_PaymentsReceived"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdPaymentsReceived.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub LoadRefundsPaid(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DARefundsPaid"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdDARefundsPaid.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub LoadCharges(ID As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ChargeTransactions"

                        .Parameters.Add("@EGID", SqlDbType.NVarChar).Value = ID

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdCharges.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Name)

            End Try
        End Using




    End Sub

    Private Sub CalculateRefundsandPayments(ByVal dano As String)

        Dim Receipt As String = String.Empty
        Dim Refund As String = String.Empty
        Dim difference As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_TotalPaymentandRefunds"
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = dano
                        .Parameters.Add("@SYSID", SqlDbType.VarChar).Value = "EG"

                        .Parameters.Add("@TOTALREFUNDS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .Parameters.Add("@TOTALPAYMENTS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        Receipt = .Parameters("@TOTALPAYMENTS").Value.ToString
                        Refund = .Parameters("@TOTALREFUNDS").Value.ToString
                        difference = CStr(NZ(Receipt) - NZ(Refund))
                    End With


                End Using

                txtReceipts.Text = Format(Receipt, "currency")
                txtRefunds.Text = Format(Refund, "currency")
                txtDifference.Text = Format(difference, "currency")


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try




            Dim myobj As DataRowView = CType(gvwPaymentsReceived.GetFocusedRow, DataRowView)



            With My.Forms.AddPayment
                .TheSystemType = "EG"
                .IndexID = CInt(myobj.Row.Item("PaymentId"))
                .AppID = lblEngDetNo.Text
                .PayId = CInt(myobj.Row.Item("InspTypeId"))
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(lblEngDetNo.Text)
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try



            With My.Forms.AddPayment

                .TheSystemType = "EG"
                .IndexID = 0
                .AppID = lblEngDetNo.Text
                .PayId = 0
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(lblEngDetNo.Text)
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnRemoveFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFee.Click


        If MessageBox.Show("Are you sure about this, remove this fee?", "Remove Fee ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim myobj As DataRowView = CType(gvwPaymentsReceived.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveAPayment"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("PaymentId"))
                        .ExecuteNonQuery()

                    End With


                End Using


                LoadPaymentsRecieved(lblEngDetNo.Text)
                CalculateRefundsandPayments(lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            Dim myobj As DataRowView = CType(gvwDARefundsPaid.GetFocusedRow, DataRowView)


            With fFee

                .TheSystemType = "EG"
                .IDindex = CInt(myobj.Row.Item("RefundIDX"))

                .AppID = lblEngDetNo.Text
                .PayId = CInt(myobj.Row.Item("RefundTypeId"))
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(lblEngDetNo.Text)

            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnAddRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try


            With My.Forms.AddRefund

                .TheSystemType = "EG"
                .IDindex = 0
                .AppID = lblEngDetNo.Text
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(lblEngDetNo.Text)

            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemoveRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefund.Click

        If MessageBox.Show("Are you sure about this, remove this refund?", "Remove refund ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwDARefundsPaid.GetFocusedRow, DataRowView)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveARefund"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("RefundIDX"))
                        .ExecuteNonQuery()

                    End With


                End Using


                LoadRefundsPaid(lblEngDetNo.Text)

                CalculateRefundsandPayments(lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Name)

            End Try
        End Using

    End Sub

    Private Sub gvwPaymentsReceived_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwPaymentsReceived.RowClick

        btnEditPayment.Enabled = True
        btnRemoveFee.Enabled = True

    End Sub

    Private Sub gvwDARefundsPaid_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwDARefundsPaid.RowClick
        btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
    End Sub

    Private Sub btnAddUrbanCharges_Click(sender As Object, e As EventArgs) Handles btnAddUrbanCharges.Click

        If MessageBox.Show("Insert the Urban standard charges now?", "Insert Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddUrbanCharges_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertStandardChargesPostEng"

                        .Parameters.Add("@ENGREFID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@LOTS", SqlDbType.Int).Value = NZ(txtCCLotsCreated.Text)
                        .Parameters.Add("@LINEAR", SqlDbType.NVarChar).Value = txtCCLinealMetres.Text
                        .Parameters.Add("@URBANORRURAL", SqlDbType.Int).Value = 1
                        .ExecuteNonQuery()


                    End With


                End Using


                LoadCharges(lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddUrbanCharges_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnAddRuralCharges_Click(sender As Object, e As EventArgs) Handles btnAddRuralCharges.Click

        If MessageBox.Show("Insert the Rural standard charges now?", "Insert Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddRuralCharges_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertStandardChargesPostEng"

                        .Parameters.Add("@ENGREFID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@LOTS", SqlDbType.Int).Value = NZ(txtCCLotsCreated.Text)
                        .Parameters.Add("@LINEAR", SqlDbType.NVarChar).Value = txtCCLinealMetres.Text
                        .Parameters.Add("@URBANORRURAL", SqlDbType.Int).Value = 2
                        .ExecuteNonQuery()


                    End With


                End Using

                LoadCharges(lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddRuralCharges_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub


#End Region

#Region "Event TimeLine"




    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click

        LockTheForm(grpEventRecord, True)
        ClearData(grpEventRecord)

        btnEditEvent.Enabled = False
        btnSaveEvent.Enabled = True
        btnAddEvent.Enabled = False

        lblEventId.Tag = "0"
        dteEventDate.EditValue = Today.Date


    End Sub

    Private Sub btnEditEvent_Click(sender As Object, e As EventArgs) Handles btnEditEvent.Click


        LockTheForm(grpEventRecord, True)
        btnEditEvent.Enabled = False
        btnSaveEvent.Enabled = True
        btnAddEvent.Enabled = True


    End Sub

    Private Function FieldsAreNotComplete() As Boolean

        Dim result As Boolean = False

        If Not IsDate(dteEventDate.Text) Then
            With errorProvider
                .SetError(dteEventDate, "A referral date is required")
            End With
            result = True
        Else
            errorProvider.SetError(dteEventDate, "")

        End If

        If cboEventStatus.EditValue Is Nothing Then
            errorProvider.SetError(cboEventStatus, "Select a status")

            result = True
        Else
            errorProvider.SetError(cboEventStatus, "")

        End If

        If cboEventType.EditValue Is Nothing Then
            errorProvider.SetError(cboEventType, "Select a event type")

            result = True
        Else
            errorProvider.SetError(cboEventType, "")

        End If



        Return result

    End Function

    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click

        If FieldsAreNotComplete() Then Return


        LockTheForm(grpEventRecord, False)
        btnEditEvent.Enabled = True
        btnSaveEvent.Enabled = False
        btnAddEvent.Enabled = True

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveEvent_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateEngTimeLineEvent"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblEventId.Tag)

                        .Parameters.Add("@EVENTTYPE", SqlDbType.Int).Value = CInt(cboEventType.EditValue)


                        If dteEventDate.EditValue IsNot Nothing Then .Parameters.Add("@EVENTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dteEventDate.EditValue), "dd/MM/yyyy")

                        .Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = txtNote.Text


                        If dteCompleted.Text <> String.Empty Then .Parameters.Add("@COMPLTE", SqlDbType.SmallDateTime).Value = Format(CDate(dteCompleted.EditValue), "dd/MM/yyyy")

                        If cboEventStatus.EditValue IsNot Nothing Then .Parameters.Add("@STATUS", SqlDbType.Int).Value = CInt(cboEventStatus.EditValue)

                        .Parameters.Add("@DETNO", SqlDbType.Int).Value = NZ(lblEngDetNo.Text)

                        .ExecuteNonQuery()


                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveEvent_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadTimeLineGrid(lblEngDetNo.Text)

    End Sub

    Private Sub gvwEngineeringTimeLine_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwEngineeringTimeLine.RowClick

        LockTheForm(grpEventRecord, False)
        btnEditEvent.Enabled = True
        btnSaveEvent.Enabled = False
        btnAddEvent.Enabled = True

        Dim myobj As DataRowView = CType(gvwEngineeringTimeLine.GetFocusedRow, DataRowView)


        Dim Whatever As Integer = CInt(myobj.Row.Item("EventId"))

        RetrieveTimeLimeRecord(Whatever)

    End Sub

    Private Sub RetrieveTimeLimeRecord(EventID As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveTimeLimeRecord routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "dbo.usp_RetrieveEventTimeRecord"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = EventID



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)


                        lblEventId.Tag = EventID.ToString
                        cboEventType.EditValue = CInt(objDataRow.Item("EventType"))
                        dteEventDate.EditValue = CDate(objDataRow.Item("EventDate"))
                        cboEventStatus.EditValue = CInt(objDataRow.Item("EventStatus"))
                        If Not IsDBNull(objDataRow.Item("CompletionDate")) Then dteCompleted.EditValue = CDate(objDataRow.Item("CompletionDate"))
                        txtNote.Text = objDataRow.Item("Notes").ToString


                    End If

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveTimeLimeRecord routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadEventTypes()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadEventTypes routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT     EventTypeId, EventTypeDescription FROM  EngEventType ORDER BY EventTypeDescription; "




                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboEventType.properties

                        .DataSource = objDT
                        .DisplayMember = "EventTypeDescription"
                        .ValueMember = "EventTypeId"
                        .ShowFooter = False
                        .ShowHeader = False


                    End With


                    Dim col2 As LookUpColumnInfoCollection = cboEventType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("EventTypeDescription", 0))
                    col2.Add(New LookUpColumnInfo("EventTypeId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadEventTypes routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub LoadTimeLineGrid(EngDetNo As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadTimeLineGrid routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveEngineeringTimeLine"

                        .Parameters.Add("@ENGDETNO", SqlDbType.Int).Value = EngDetNo



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdEngineeringTimeLine.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadTimeLineGrid routine - form " & Name)

            End Try
        End Using


    End Sub


    Private Sub LoadEventStatus()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadEventStatus routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT EngEventStatus.EventStatusId, EngEventStatus.EventStatusDesc FROM EngEventStatus ORDER BY EngEventStatus.EventStatusDesc;"



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboEventStatus.Properties
                        .DataSource = objDT
                        .DisplayMember = "EventStatusDesc"
                        .ValueMember = "EventStatusId"
                        .ShowFooter = False
                        .ShowHeader = False


                    End With

                End Using


                Dim col2 As LookUpColumnInfoCollection = cboEventStatus.Properties.Columns
                col2.Add(New LookUpColumnInfo("EventStatusDesc", 0))
                col2.Add(New LookUpColumnInfo("EventStatusId", 0))

                col2.Item(1).Visible = False



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadEventStatus routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub gvwCharges_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwCharges.RowClick

        btnEditCharge.Enabled = True
        btnRemoveCharge.Enabled = True

    End Sub

    Private Sub btnEditCharge_Click(sender As Object, e As EventArgs) Handles btnEditCharge.Click

        Try


            Dim myobj As DataRowView = CType(gvwCharges.GetFocusedRow, DataRowView)


            With My.Forms.AddCharge

                .ChargeId = CInt(myobj.Row.Item("id"))

                .InspectionID = lblEngDetNo.Text

                .ShowDialog()

                If .DialogResult = DialogResult.OK Then LoadCharges(lblEngDetNo.Text)

                .Dispose()

            End With




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddCharge_Click(sender As Object, e As EventArgs) Handles btnAddCharge.Click

        Try


            With My.Forms.AddCharge

                .ChargeId = 0

                .InspectionID = lblEngDetNo.Text

                .ShowDialog()

                If .DialogResult = DialogResult.OK Then LoadCharges(lblEngDetNo.Text)

                .Dispose()

            End With




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemoveCharge_Click(sender As Object, e As EventArgs) Handles btnRemoveCharge.Click

        If MessageBox.Show("Remove this charge from the system?", "Remove charge confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Return

        Dim myobj As DataRowView = CType(gvwCharges.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCharge_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveChargeTransaction"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
                        .ExecuteNonQuery()

                    End With

                    LoadCharges(lblEngDetNo.Text)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCharge_Click routine - form " & Name)

            End Try
        End Using


    End Sub

    Private Sub gvwListOfCertificates_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwListOfCertificates.RowClick
        If btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If

        Dim myobj As DataRowView = CType(gvwListOfCertificates.GetFocusedRow, DataRowView)


        Dim Whatever As Integer = CInt(myobj.Row.Item("EngDetNo"))

        LoadForm(Whatever)

        btnAddEvent.Enabled = True
    End Sub





#End Region

#Region "File Notes Tab"

    Private Sub LoadFileNoteTypesList()

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
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT     FileNoteTypeCode, FileNoteType FROM  FileNoteType"



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboNoteType.Properties

                        .DataSource = objDT
                        .DisplayMember = "FileNoteType"
                        .ValueMember = "FileNoteTypeCode"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cboNoteType.Properties.Columns
                col2.Add(New LookUpColumnInfo("FileNoteType", 0))
                col2.Add(New LookUpColumnInfo("FileNoteTypeCode", 0))

                col2.Item(1).Visible = False

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub RetrieveFileNotes(ByVal CDNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveFileNotes"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDNo
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdFileNotes.DataSource = objDT


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub ClearNoteFields()
        NoteDate.Text = String.Empty
        txtNotesSubject.Text = String.Empty
        txtNoteDetails.Text = String.Empty
        txtNotesContactNo.Text = String.Empty
        cboNoteType.EditValue = Nothing
        txtNotesSpokeTo.Text = String.Empty
        txtNotesCC.Text = String.Empty
        txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        cboNotesOfficer.EditValue = Nothing
        btnEditNote.Enabled = False
        btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
        btnNotePrint.Enabled = False
    End Sub

    Private Sub LockNotes(ByVal lock As Boolean)
        NoteDate.ReadOnly = lock
        txtNotesSubject.ReadOnly = lock
        txtNoteDetails.ReadOnly = lock
        txtNotesContactNo.ReadOnly = lock
        cboNoteType.ReadOnly = lock
        txtNotesSpokeTo.ReadOnly = lock
        txtNotesCC.ReadOnly = lock
        txtNotesFollowUp.ReadOnly = lock
        cboNotesOfficer.ReadOnly = lock
        btnEditNote.Enabled = lock
        btnSaveNote.Enabled = Not lock
        btnAddNote.Enabled = lock
        btnNotePrint.Enabled = True
    End Sub
    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        ClearNoteFields()
        LockNotes(False)
        btnSaveNote.Enabled = True
        btnAddNote.Enabled = False
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = False
    End Sub

    Private Sub btnNotesEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditNote.Click
        LockNotes(False)
        btnSaveNote.Enabled = True
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = True

    End Sub

    Private Sub btnNotesSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        SaveNotesData()
        ClearNoteFields()
        LockNotes(True)
        btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub SaveNotesData()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateFileNotes"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblNotesID.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblEngDetNo.Text
                        .Parameters.Add("@NOTEDATE", SqlDbType.SmallDateTime).Value = Format(CDate(NoteDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@SUBJECT", SqlDbType.NVarChar).Value = txtNotesSubject.Text
                        .Parameters.Add("@DETAIL", SqlDbType.NText).Value = txtNoteDetails.Text
                        .Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = txtNotesContactNo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "EG"
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = cboNoteType.EditValue.ToString
                        .Parameters.Add("@SPOKEN", SqlDbType.NVarChar).Value = txtNotesSpokeTo.Text
                        .Parameters.Add("@CC", SqlDbType.NVarChar).Value = txtNotesCC.Text
                        .Parameters.Add("@FOLLOWUP", SqlDbType.NVarChar).Value = txtNotesFollowUp.Text
                        If Not cboNotesOfficer.EditValue Is Nothing Then .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = CInt(cboNotesOfficer.EditValue)
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = txtFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Name)

            End Try
        End Using
        RetrieveFileNotes(lblEngDetNo.Text)
    End Sub

    Private Sub btnNotePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrint.Click

        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "FILENOTES")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\FileNotes.xsd")


                    Dim rept As New FileNotes

                    rept.DataSource = objDT


                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine ")
            End Try
        End Using
    End Sub


    Private Sub gvwFileNotes_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwFileNotes.RowClick




        Dim myobj As DataRowView = CType(gvwFileNotes.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadNoteDetailsForEdit"

                        .Parameters.Add("@NOTEID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        NoteDate.Text = Format(CDate(objDataRow.Item(0).ToString), "dd/MM/yyyy")
                        txtNotesSubject.Text = objDataRow.Item(1).ToString
                        txtNoteDetails.Text = objDataRow.Item(2).ToString
                        txtNotesContactNo.Text = objDataRow.Item(3).ToString
                        cboNoteType.EditValue = objDataRow.Item(4).ToString
                        txtNotesSpokeTo.Text = objDataRow.Item(5).ToString
                        txtNotesCC.Text = objDataRow.Item(6).ToString
                        txtNotesFollowUp.Text = objDataRow.Item(7).ToString
                        cboNotesOfficer.EditValue = CInt(objDataRow.Item(8).ToString)
                        lblNotesID.Text = objDataRow.Item(9).ToString
                        btnEditNote.Enabled = True
                        btnSaveNote.Enabled = False
                        btnAddNote.Enabled = True
                        btnNotePrint.Enabled = True
                        LockNotes(True)

                    Else
                        ClearNoteFields()
                    End If

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Name)

            End Try
        End Using

    End Sub


#End Region

#Region "Build Letters"

    Private Sub btnAssembleLetter_Click(sender As Object, e As EventArgs) Handles btnAssembleLetter.Click
        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If  dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "EG"


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboLetterType.EditValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboLetterType.EditValue)
                            docname = objDataReader.Item(0).ToString
                            docfilename = objDataReader.Item(1).ToString
                            MacroName = objDataReader.Item(2).ToString
                        Loop
                        objDataReader.Close()
                    End Using



                End Using

                PrintEngineeringLetter("Document Type: " & cboLetterType.Text & " Application No. " & txtDANo.Text, docname)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub LoadListOfWordTemplates()



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpda_DocType_WordTemplateList"
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "E"
                        '.CommandText = "usp_LoadCreateLetterListBox"
                        '.Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = "O"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboLetterType.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboLetterType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Name)

            End Try
        End Using


    End Sub

#End Region

#Region "Word Functions"



    Private Function BuildDocumentData(DocName As String) As DataTable

        Dim objDatatable As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReportSelectionData"

                        .Parameters.Add("@REPTTYPE", SqlDbType.NVarChar).Value = DocName
                        .Parameters.Add("@LANID", SqlDbType.NVarChar).Value = sUserID
                        .Parameters.Add("@COInspID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDatatable.Load(objDataReader)
                    End Using

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine ")
            End Try
        End Using

        Return objDatatable


    End Function

    Private Sub PrintEngineeringLetter(ByVal Summary As String, ByVal DocType As String)

        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document

        Dim WordDocName As String = String.Empty
        Dim LetterName As String = String.Empty

        Dim sdate As String = Format(Today.Date, "dd_MM_yyyy")

        Dim documentType As String = String.Empty

        Dim objDTable As DataTable = BuildDocumentData(DocType)

        Try

            If objDTable.Rows.Count > 0 Then


                Dim objDataRow As DataRow = objDTable.Rows.Item(0)

                Select Case DocType

                    Case "EGAQ"

                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGSubFeesAck Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGSubFeesAck Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering acknowledgement quoting fees"
                        LetterName = "EngConsentSubAcknQuoteFees.dotx"

                    Case "EGAL"
                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGSubFeesAckLSL Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGSubFeesAckLSL Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering acknowledgement quoting fees and LSL"
                        LetterName = "EngConsentSubAcknowledeQuoteLSL.dotx"


                    Case "EGAP"

                    Case "EGAI"

                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGInterimSubFeesAck Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGInterimSubFeesAck Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering interim Fees acknowledgment"
                        LetterName = "EngInterimSubFeesAckn.dotx"


                    Case "EGRP"

                End Select


                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
                End If




                objWordDoc = objWordApp.Application.Documents.Add(Template:=(My.Settings.ConstructionCertificates & LetterName), NewTemplate:=False, DocumentType:=0)

                Dim newname As String = objWordDoc.Name.ToString



                With objWordApp

                    .Visible = True


                    .ActiveDocument.Bookmarks("FileNo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DAFileNo").ToString

                    .ActiveDocument.Bookmarks("CCConsultant").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultant").ToString



                    .ActiveDocument.Bookmarks("CCConsultantAdd").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantAdd").ToString

                    .ActiveDocument.Bookmarks("CCConsultantTown").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantTown").ToString

                    .ActiveDocument.Bookmarks("CCConsultantPCode").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantPCode").ToString

                    .ActiveDocument.Bookmarks("DANo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DANo").ToString

                    .ActiveDocument.Bookmarks("CCEstate").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCEstate").ToString

                    .ActiveDocument.Bookmarks("Description").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("Description").ToString

                    .ActiveDocument.Bookmarks("CCPlanNo").Select()
                    .Application.Selection.Text = objDataRow.Item("CCPlanNo").ToString

                    .ActiveDocument.Bookmarks("PlanSet").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("PlanSet").ToString

                    If DocType <> "EGAI" Then

                        If Not IsDBNull(objDataRow.Item("OriginalSubmissionDate")) Then

                            .ActiveDocument.Bookmarks("SubMissionDate").Select()
                            .ActiveDocument.Application.Selection.Text = Format(CDate(objDataRow.Item("OriginalSubmissionDate")), "dd MMMM, yyyy")

                        End If


                        .ActiveDocument.Bookmarks("CCPlanNo2").Select()
                        .Application.Selection.Text = objDataRow.Item("CCPlanNo")

                        .ActiveDocument.Bookmarks("PlanSet2").Select()
                        .ActiveDocument.Application.Selection.Text = objDataRow.Item("PlanSet").ToString


                        .ActiveDocument.Bookmarks("LinealText").Select()

                        Dim LinearText As String = String.Empty

                        If CInt(objDataRow.Item("CCLinealMetres")) > 0 Then

                            LinearText = "The plans submitted indicate sewer and/or water design to service " & objDataRow.Item("CCLotsCreated").ToString & " lots and a total road length of " & objDataRow.Item("CCLinealMetres").ToString & " metres."

                        Else

                            LinearText = "The plans submitted indicate sewer and/or water design to service " & objDataRow.Item("CCLotsCreated").ToString & " lots."

                        End If


                        .ActiveDocument.Application.Selection.Text = LinearText

                    End If

                    .ActiveDocument.Bookmarks("Officer").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("EGOfficer").ToString



                    Dim tablecell As Integer = 1
                    Dim tablerow As Integer = 2
                    '.Application.Activate()
                    Dim ObjDT As DataTable = SubReportData(CInt(lblEngDetNo.Text))

                    Dim RowCount As Integer = ObjDT.Rows.Count
                    'if there is not base data then no need to continue
                    Dim GrandTotal As Double

                    If ObjDT.Rows.Count > 0 Then

                        For i As Integer = 0 To ObjDT.Rows.Count - 1


                            GrandTotal = CDbl(ObjDT.Rows(i).Item("TotalDue"))

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("Payment")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("Payment").ToString & vbCrLf & ObjDT.Rows(i).Item("GLAccount").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord
                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)


                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeQuant")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeQuant").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)



                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeUnitDesc")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeUnitDesc").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)



                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeMultiplier")) Then
                                .Application.Selection.Text = Format(ObjDT.Rows(i).Item("ChargeMultiplier"), "Currency")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeAmt")) Then
                                .Application.Selection.Text = Format(ObjDT.Rows(i).Item("ChargeAmt"), "Currency")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeRef")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeRef")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If



                            If i <> RowCount - 1 Then .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            If tablecell = 6 Then tablecell = 1
                            tablerow += 1
                        Next




                    End If



                    .ActiveDocument.Bookmarks("GrandTotal").Select()
                    .ActiveDocument.Application.Selection.Text = Format(GrandTotal, "Currency")


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



                InsertRecordIntoEGDraftDocs(lblEngDetNo.Text, documentType, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))


                DisplayListOfDraftDocuments()

                Dim WRD As New OpenDocument
                WRD.OpenVisible(WordDocName)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, " in LoadSeizedItems routine - form " & Me.Name)
            objWordApp.Quit()

            releaseObject(objWordDoc)
            releaseObject(objWordApp)

        End Try

    End Sub

    Private Sub DisplayListOfDraftDocuments()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DisplayListOfEGDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblEngDetNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdDraftDocs.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function SubReportData(ByVal InspectionID As Integer) As DataTable

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

                        .CommandText = "usp_rpt_EGFeesSubReport"
                        .Parameters.Add("@INSPECTID", SqlDbType.Int).Value = InspectionID
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

    Private Sub gvwDraftDocs_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwDraftDocs.RowClick

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)



        btnViewEditDocument.Enabled = True
        btnDeleteDoc.Enabled = True
        btnFinaliseDoc.Enabled = True


    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return



        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(myobj.Row.Item("DraftDocPath").ToString)


        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)



        If myobj.Row.Item("AppNo").ToString = String.Empty Then Return


        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString


        If MessageBox.Show("You are about to delete this word document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DraftDocId"))
                        .ExecuteNonQuery()
                    End With


                End Using


                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Name)

            End Try
        End Using

        Try
            DisplayListOfDraftDocuments(lblEngDetNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click



        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)

        Dim FilePath As String = myobj.Row.Item("DraftDocPath").ToString

        Dim summary As String = String.Empty
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_EngineeringPostConsentApplicantsDetails"

                        .Parameters.Add("@COInspID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                    End With

                    Dim objDT As New DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    summary = "Document Type: " & myobj.Row.Item("Description").ToString & " - " & lblEngDetNo.Text

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        OwnerName = objDataRow.Item("DAAppName").ToString
                        OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
                        FileNo = objDataRow.Item("DAFileNo").ToString

                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine ")
            End Try
        End Using



        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If myobj.Row.Item("AppNo").ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)


        With My.Forms.InsertEASEDocument
            .CustName = OwnerName
            .CustAddress = OwnerAddress

            .WordDocLocation = FilePath.ToString
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = FileNo
            .ShowDialog()
            .Dispose()
        End With


        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "EG"
            .DocumentType = myobj.Row.Item("Description").ToString
            .ApplicationNo = Me.lblEngDetNo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
        End With


        'With InsertDocData
        '    .ApplicationType = "EG"
        '    .DocumentType = DocType
        '    .ApplicationNo = Me.lblEngDetNo.Text
        '    .TheAuthor = MyUserId
        '    .TheImageName = Replace(strDocumentNo, ".", "_")
        '    .Notes = txtLetterNotes.Text
        '    .InsertDocumentsIntoDAsystem()
        'End With




        Dim FileToDelete As String = FilePath.ToString
        My.Computer.FileSystem.DeleteFile(FileToDelete)

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_RemoveDraftEGDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DraftDocId").ToString)
                        .ExecuteNonQuery()
                    End With
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using




        LoadHistoricalDocuments(lblEngDetNo.Text)
        DisplayListOfDraftDocuments(lblEngDetNo.Text)




    End Sub

    Private Sub DisplayListOfDraftDocuments(ByVal EngNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DisplayListOfEGDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = EngNo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdDraftDocs.DataSource = objDT
                    grdDraftDocs.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Name)

            End Try
        End Using



    End Sub

    Private Sub InsertWordDocumentIntoTable(WordDocument As String, DocID As Integer)

        'Dim tmpFile As New FileStream(WordDocument, FileMode.Open, FileAccess.Read)
        'Dim btSaveFile(CInt(tmpFile.Length)) As Byte
        'tmpFile.Read(btSaveFile, 0, CInt(tmpFile.Length))
        'tmpFile.Close()

        Dim btSaveFile As Byte()

        btSaveFile = ReadFile(WordDocument)

        Dim DocumentName As String = My.Computer.FileSystem.GetName(WordDocument)

        'Dim blob As [Byte]() = DirectCast(btSaveFile, [Byte]())


        'Dim ms As MemoryStream = New MemoryStream(blob)


        'Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

        '    ms.WriteTo(fs)
        '    'ms.Close()

        'End Using

        'ms.Close()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_DAStandardLetterWordDocument"

                        .Parameters.Add("@DOCUMENTTITLE", SqlDbType.VarChar).Value = DocumentName
                        .Parameters.Add("@WORDOBJECT", SqlDbType.VarBinary).Value = btSaveFile
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = DocID

                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Name)

            End Try
        End Using



    End Sub

    'Private Sub DisplayDraftDocuments(CCno As String)

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DisplayDraftDocuments routine - form " & Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "DisplayListOfDraftDocuments"

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CCno
    '                End With

    '                Dim objDT As New DataTable


    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '                grdDraftDocs.DataSource = objDT

    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DisplayDraftDocuments routine - form " & Name)

    '        End Try
    '    End Using


    'End Sub

    Private Sub InsertIntoDADocumentsTable(ByVal DocType As String, ByVal FileName As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertDocumentData"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblEngDetNo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "EG"
                        .Parameters.Add("@AUTHOR", SqlDbType.Int).Value = MyUserId
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = FileName
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Name)

            End Try
        End Using

    End Sub



#End Region




End Class