Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports ADDINFO = ClassAdditionalInformation.AdditionalInfo
Imports ADHelpr = ADHelper.ADHelper
Imports WORD = Microsoft.Office.Interop.Word

Public Class IssueConstructionCertificate


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'LoadCCWorkDescriptions()
        'LoadCCBuildSol()
        'LoadCCAppType()
        'LoadLookupEdit(cboDAlocalityCode, "usp_LoadUpLocalityCodesList")
        'LoadLookupEdit(cboNoteType, "usp_LoadUpFileNoteTypeList")
        'LoadLookupEdit(cboNotesOfficer, "usp_LoadUpOfficerList")
        'LoadLookupEdit(cboDAAuthorityId, "usp_LoadUpDAAuthorityList")
        'LoadLookupEdit(cboDADecisionId, "usp_LoadUpDADecisionList")
        'LoadLookupEdit(cboReferralsIntProvision, "usp_LoadUpIntegratedProvisionList")
        'LoadLookupEdit(cboRefCodeId, "usp_LoadUpReferralCodeList")
        'LoadCCBuildingClasses()
        'LoadListOfWordTemplates() '<<<++++======
        'LoadRFSRFSSubDivisionType()
        'LoadInsuranceCompanies()

    End Sub

#Region "Declarations"
    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3
    Private ErrorProvider As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private isloading As Boolean
    Private ADHelper As New ADHelpr

    Private mydocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"


#End Region


#Region "Functions and Sub routines"


    Private Function CCReferralData() As DataTable
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_rpt_ConstCertReferralData"

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

    Private Sub LoadRFSRFSSubDivisionType()

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
            .ShowFooter = False
            .ShowHeader = False
        End With



        Dim colRFSSubDivisionType As LookUpColumnInfoCollection = cboRFSSubDivisionType.Properties.Columns
        colRFSSubDivisionType.Add(New LookUpColumnInfo("Name", 0))
        colRFSSubDivisionType.Add(New LookUpColumnInfo("Key", 0))

        colRFSSubDivisionType.Item(1).Visible = False


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

                    txtDALot.Text = String.Empty
                    txtDASection.Text = String.Empty
                    txtDADP.Text = String.Empty
                    txtPIN.Text = String.Empty
                    txtSubmClose.Text = String.Empty
                    txtDADetermined.Text = String.Empty
                    txtDAApplicantNotified.Text = String.Empty
                    txtDAAddress.Text = String.Empty
                    txtDAOwner.Text = String.Empty
                    txtDADescription.Text = String.Empty
                    txtDAEstimateCost.Text = String.Empty
                    txtDAClassification.Text = String.Empty
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
                    txtFileNo.Text = String.Empty

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        txtDALot.Text = objDataRow.Item("DALot").ToString
                        txtDASection.Text = objDataRow.Item("DASection").ToString
                        txtDADP.Text = objDataRow.Item("DADP").ToString
                        txtPIN.Text = objDataRow.Item("PIN").ToString
                        txtFileNo.Text = objDataRow.Item("DAFileNo").ToString
                        If Not IsDBNull(objDataRow.Item("DACompletedDt")) Then txtSubmClose.Text = Format(CDate(objDataRow.Item("DACompletedDt")), "dd/MM/yyyy")
                        If Not IsDBNull(objDataRow.Item("DAAppNotDt")) Then txtDAApplicantNotified.Text = Format(CDate(objDataRow.Item("DAAppNotDt")), "dd/MM/yyyy")
                        txtDAAddress.Text = objDataRow.Item("Address").ToString
                        txtDAOwner.Text = objDataRow.Item("DAOwnersName").ToString
                        If Not IsDBNull(objDataRow.Item("DADetermDt")) Then txtDADetermined.Text = Format(CDate(objDataRow.Item("DADetermDt")), "dd/MM/yyyy")
                        txtDADescription.Text = objDataRow.Item("DADesc").ToString
                        If Not IsDBNull(objDataRow.Item("DAEstCost")) Then txtDAEstimateCost.Text = Format(objDataRow.Item("DAEstCost"), "Currency")
                        txtDAClassification.Text = objDataRow.Item("DAClassification").ToString
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
                        If Not IsDBNull(objDataRow.Item("DALocalityCodeID")) Then cboDAlocalityCode.EditValue = CInt(objDataRow.Item("DALocalityCodeID"))

                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSummayData routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadApplicationDetails(CCno As String)

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
                        .CommandText = "usp_SELECT_CCApplication"

                        .Parameters.Add("@CCNO", SqlDbType.VarChar).Value = CCno
                        .Parameters.Add("@SYSREF", SqlDbType.VarChar).Value = "CC"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        isloading = True



                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        txtCCno.Text = objDataRow.Item("CCAppNo").ToString
                        txtDANo.Text = objDataRow.Item("DANo").ToString
                        If Not IsDBNull(objDataRow.Item("CCAppTypeId")) Then cboAppType.EditValue = NZ(objDataRow.Item("CCAppTypeId"))

                        If Not IsDBNull(objDataRow.Item("CCRegoDt")) Then
                            dtRegistered.EditValue = CDate(objDataRow.Item("CCRegoDt"))
                            dtRego.EditValue = CDate(objDataRow.Item("CCRegoDt"))
                        End If

                        If Not IsDBNull(objDataRow.Item("CCDescWorkId")) Then cboDescription.EditValue = NZ(objDataRow.Item("CCDescWorkId"))

                        txtCCDesc.Text = objDataRow.Item("CCDesc").ToString

                        txtCCValue.Text = objDataRow.Item("CCValue").ToString

                        lblOfficer.Tag = objDataRow.Item("CCOfficerID").ToString

                        'textbox1.Text = objDataRow.Item("CCClassId").ToString



                        If Not IsDBNull(objDataRow.Item("CCBuildSolId")) Then cboBldgSolution.EditValue = NZ(objDataRow.Item("CCBuildSolId"))

                        rgpBuilderType.EditValue = CInt(objDataRow.Item("CCOwnerBuilder"))

                        txtCCOwnerBuilderNo.Text = objDataRow.Item("CCOwnerBuilderNo").ToString

                        cboBuildersNames.EditValue = objDataRow.Item("CCLicBuilderName").ToString
                        txtLicBuilderNo.Text = objDataRow.Item("CCLicBuilderNo").ToString
                        txtLicBuilderPhone.Text = objDataRow.Item("CCLicBuilderPhone").ToString


                        txtCCInsuranceNo.Text = objDataRow.Item("CCInsuranceNo").ToString
                        If Not IsDBNull(objDataRow.Item("CCInsuranceName")) Then cboInsuranceName.EditValue = NZ(objDataRow.Item("CCInsuranceName"))

                        CCMatW1CheckBox.Checked = CBool(objDataRow.Item("CCMatW1"))
                        CCMatW2CheckBox.Checked = CBool(objDataRow.Item("CCMatW2"))
                        CCMatW3CheckBox.Checked = CBool(objDataRow.Item("CCMatW3"))
                        CCMatW4CheckBox.Checked = CBool(objDataRow.Item("CCMatW4"))
                        CCMatW5CheckBox.Checked = CBool(objDataRow.Item("CCMatW5"))
                        CCMatW6CheckBox.Checked = CBool(objDataRow.Item("CCMatW6"))
                        CCMatW7CheckBox.Checked = CBool(objDataRow.Item("CCMatW7"))
                        CCMatW8CheckBox.Checked = CBool(objDataRow.Item("CCMatW8"))
                        CCMatW9CheckBox.Checked = CBool(objDataRow.Item("CCMatW9"))
                        CCMatW10CheckBox.Checked = CBool(objDataRow.Item("CCMatW10"))
                        CCMatW11CheckBox.Checked = CBool(objDataRow.Item("CCMatW11"))
                        CCMatW12CheckBox.Checked = CBool(objDataRow.Item("CCMatW12"))
                        CCMatW13CheckBox.Checked = CBool(objDataRow.Item("CCMatW13"))
                        CCMatW14CheckBox.Checked = CBool(objDataRow.Item("CCMatW14"))

                        chkConcretefloor.Checked = CBool(objDataRow.Item("CCMatF1"))
                        chkTimberfloor.Checked = CBool(objDataRow.Item("CCMatF2"))
                        chkOtherFloor.Checked = CBool(objDataRow.Item("CCMatF3"))
                        chkunknownfloor.Checked = CBool(objDataRow.Item("CCMatF4"))

                        CCMatR1CheckBox.Checked = CBool(objDataRow.Item("CCMatR1"))
                        CCMatR2CheckBox.Checked = CBool(objDataRow.Item("CCMatR2"))
                        CCMatR3CheckBox.Checked = CBool(objDataRow.Item("CCMatR3"))
                        CCMatR4CheckBox.Checked = CBool(objDataRow.Item("CCMatR4"))
                        CCMatR5CheckBox.Checked = CBool(objDataRow.Item("CCMatR5"))
                        CCMatR6CheckBox.Checked = CBool(objDataRow.Item("CCMatR6"))
                        CCMatR7CheckBox.Checked = CBool(objDataRow.Item("CCMatR7"))
                        CCMatR8CheckBox.Checked = CBool(objDataRow.Item("CCMatR8"))
                        CCMatR9CheckBox.Checked = CBool(objDataRow.Item("CCMatR9"))
                        CCMatR10CheckBox.Checked = CBool(objDataRow.Item("CCMatR10"))
                        CCMatR11CheckBox.Checked = CBool(objDataRow.Item("CCMatR11"))


                        chkFrameTimber.Checked = CBool(objDataRow.Item("CCMatC1"))
                        CCMatC2CheckBox.Checked = CBool(objDataRow.Item("CCMatC2"))
                        chkFrameOther.Checked = CBool(objDataRow.Item("CCMatC3"))
                        chkFrameUnknown.Checked = CBool(objDataRow.Item("CCMatC4"))

                        txtMatRoofColour.Text = objDataRow.Item("CCMatRColour").ToString

                        If Not IsDBNull(objDataRow.Item("CCtoOfficerDt")) Then dtOfficer.EditValue = CDate(objDataRow.Item("CCtoOfficerDt"))
                        If Not IsDBNull(objDataRow.Item("CCDetrminedDt")) Then dtDetermined.EditValue = CDate(objDataRow.Item("CCDetrminedDt"))
                        If Not IsDBNull(objDataRow.Item("CCInformedDt")) Then dtNotified.EditValue = CDate(objDataRow.Item("CCInformedDt"))
                        If Not IsDBNull(objDataRow.Item("CCSiteInspectionDt")) Then dtSiteInspected.EditValue = CDate(objDataRow.Item("CCSiteInspectionDt"))
                        If Not IsDBNull(objDataRow.Item("CCPostedDt")) Then dtCertSent.EditValue = CDate(objDataRow.Item("CCPostedDt"))
                        If Not IsDBNull(objDataRow.Item("CCtoBldgSurveyorDt")) Then dtSurveyor.EditValue = CDate(objDataRow.Item("CCtoBldgSurveyorDt"))


                        If Not IsDBNull(objDataRow.Item("CCDesisionId")) Then cboDADecisionId.EditValue = CInt(objDataRow.Item("CCDesisionId"))

                        If Not IsDBNull(objDataRow.Item("CCAuthority")) Then cboDAAuthorityId.EditValue = CInt(objDataRow.Item("CCAuthority"))

                        txtAppName.Text = objDataRow.Item("CCName").ToString
                        txtAppAddress.Text = objDataRow.Item("CCStreet").ToString
                        txtAppTown.Text = objDataRow.Item("CCTown").ToString
                        txtAppPcode.Text = objDataRow.Item("CCPostCode").ToString
                        txtAppPhone.Text = objDataRow.Item("CCPhone").ToString
                        txtAppEmail.Text = objDataRow.Item("CCEmail").ToString

                        txtLongServiceLevy.Text = objDataRow.Item("CCLongServiceLevy").ToString
                        txtCouncilPlanNo.Text = objDataRow.Item("CouncilPlanNumber").ToString

                        txtProgressComment.Text = objDataRow.Item("OfficersComment").ToString

                        txtOfficer.Text = objDataRow.Item("Officer").ToString


                        If Not IsDBNull(objDataRow.Item("ConsentDocType")) Then cboConsentDocType.EditValue = CInt(objDataRow.Item("ConsentDocType"))

                        'textbox1.Text = objDataRow.Item("CCOfficerId").ToString
                        'textbox1.Text = objDataRow.Item("CCStreetName").ToString
                        'textbox1.Text = objDataRow.Item("CCLocalityCodeId").ToString
                        'textbox1.Text = objDataRow.Item("CCOwnersName").ToString
                        'textbox1.Text = objDataRow.Item("CCOwnersPAddr").ToString
                        'textbox1.Text = objDataRow.Item("CCOwnersTown").ToString



                    End If

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        isloading = False



    End Sub

    Private Sub LoadPINS(DANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPINS routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_PropertyNumbers"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    lstPINs.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadForm(ByVal CCno As String)


        ClearData(pnlApplication)
        ClearData(pnlMaterials)
        ClearData(pnlDisplayFees)
        ClearData(pnlStatus)
        ClearData(pnlReferrals)
        ClearData(pnlFileNotes)
        'ClearData(grpInsurance)

        LoadApplicationDetails(CCno)

        LoadSummaryData(txtDANo.Text)

        LoadPINS(txtDANo.Text)

        LoadPaymentsRecieved(CCno)

        LoadRefundsPaid(txtDANo.Text)

        CalculateRefundsandPayments(CCno)

        DisplayDraftDocuments(CCno)

        LoadHistoricalDocuments()

        RetrieveFileNotes(CCno)


        LoadCC_ClassIds(CCno)

        LoadListOfReferrals(CCno)


        Me.txtLongServiceLevy.ReadOnly = True

        LockTheForm(pnlApplication, False)
        LockTheForm(pnlMaterials, False)
        LockTheForm(pnlDisplayFees, False)
        LockTheForm(pnlStatus, False)
        LockTheForm(pnlReferrals, False)
        LockTheForm(pnlFileNotes, False)

        btnEditDA.Enabled = True
        btnRemoveDocument.Enabled = False
        btnEditReferralsTab.Enabled = True
        btnAddReferral.Enabled = True
        btnSaveDA.Enabled = False
        btnAddCC.Enabled = True
        btnEditReferralsTab.Enabled = False
        btnEditMaterials.Enabled = True
        btnEditStatus.Enabled = True
        'btnAssignOfficer.Enabled = True

    End Sub



    Private Function FileExists(ByVal sFileNumber As String, ByRef errorMessage As String) As Boolean
        ' Confirm there is text in the control.
        If sFileNumber.Length = 0 Then
            errorMessage = "File number is required"
            Return False
        End If


        Using Connection As New SqlConnection(My.Settings.connectionString)
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


    Private Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
    End Sub

    Private Sub LoadSearchList()

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    grdListOfCertificates.DataSource = objDT

                    isloading = False

                    Dim View As DevExpress.XtraGrid.Views.Base.ColumnView = CType(grdListOfCertificates.MainView, DevExpress.XtraGrid.Views.Base.ColumnView)

                    View.MoveFirst()






                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is SimpleButton Then

                Dim cb As SimpleButton = DirectCast(ctrl, SimpleButton)
                Select Case cb.Name
                    Case "btnViewOfficers", "btnAddFee", "btnAddRefund", "btnAddNote", "btnEditStatus", "btnViewBldgSolutions"
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

    Private Sub SaveHeaderData()
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If cboAppType.EditValue IsNot Nothing Then .Parameters.Add("@APPTYPE", SqlDbType.Int).Value = CInt(cboAppType.EditValue)
                        .Parameters.Add("@REGDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGDATE").Value = Format(CDate(dtRego.EditValue), "dd/MM/yyyy")

                        If cboDescription.EditValue IsNot Nothing Then .Parameters.Add("@DESCID", SqlDbType.Int).Value = CInt(cboDescription.EditValue)

                        If cboBldgSolution.EditValue IsNot Nothing Then .Parameters.Add("@BLDGSOLID", SqlDbType.Int).Value = CInt(Me.cboBldgSolution.EditValue)

                        'If cboDAOfficer.SelectedIndex <> -1 Then .Parameters.Add("@OFFICERID", SqlDbType.Int).Value = CInt(Me.cboDAOfficer.SelectedValue)

                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@STREET", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@POSTCODE", SqlDbType.NVarChar).Value = Me.txtAppPcode.Text
                        .Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Me.txtAppEmail.Text
                        .Parameters.Add("@CCDESC", SqlDbType.NVarChar).Value = Me.txtCCDesc.Text

                        If txtCCValue.Text <> String.Empty Then .Parameters.Add("@VALUE", SqlDbType.Money).Value = CDbl(txtCCValue.Text)

                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

        btnEmailAcknowledge.Enabled = txtAppEmail.Text <> String.Empty

    End Sub

    Private Function HasBeenDetermined() As Boolean
        Dim Result As Boolean

        Using cn As New SqlConnection(My.Settings.connectionString)
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



        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try

    End Sub

    Private Sub SaveBuilderData()
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_CCUPDATE_BuilderTab"

                        .Parameters.Add("@ccNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text

                        If CInt(rgpBuilderType.EditValue) = 1 Then

                            .Parameters.Add("@OWNERBLDER", SqlDbType.Int).Value = 1
                            .Parameters.Add("@LICBLDR", SqlDbType.Int).Value = 0

                        Else

                            .Parameters.Add("@OWNERBLDER", SqlDbType.Int).Value = 0
                            .Parameters.Add("@LICBLDR", SqlDbType.Int).Value = 1

                        End If


                        If txtCCOwnerBuilderNo.Text <> String.Empty Then .Parameters.Add("@OWNERBLDRNO", SqlDbType.NVarChar).Value = txtCCOwnerBuilderNo.Text
                        If cboBuildersNames.Text <> String.Empty Then .Parameters.Add("@LICBLDRNAME", SqlDbType.NVarChar).Value = cboBuildersNames.Text
                        If txtLicBuilderNo.Text <> String.Empty Then .Parameters.Add("@LICBLDRNO", SqlDbType.NVarChar).Value = txtLicBuilderNo.Text
                        If txtLicBuilderPhone.Text <> String.Empty Then .Parameters.Add("@LICBLDRPHONE", SqlDbType.NVarChar).Value = txtLicBuilderPhone.Text
                        If txtCCInsuranceNo.Text <> String.Empty Then .Parameters.Add("@INSURNO", SqlDbType.NVarChar).Value = txtCCInsuranceNo.Text
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

        If btnSaveDA.Enabled Or Me.btnSaveMaterials.Enabled Or Me.btnSaveStatus.Enabled Then
            changed = True
        End If

        If changed Then

            If MessageBox.Show("It appears you have updated some information, save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                If Me.btnSaveDA.Enabled Then

                    SaveHeaderData()

                    SaveBuilderData()

                End If

                If Me.btnSaveMaterials.Enabled Then SaveMaterialsData()

                If Me.btnSaveStatus.Enabled Then SaveStatusData()

            End If

        End If

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


    Private Function AddressNotSaved() As Boolean
        Dim result As Boolean = True


        Using cn As New SqlConnection(My.Settings.connectionString)
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



#End Region

#Region "Properties"


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

#End Region

#Region "PayMents and Refunds"


    Private Sub LoadPaymentsRecieved(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_PaymentsReceived"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdPaymentsReceived.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadRefundsPaid(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DARefundsPaid"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdDARefundsPaid.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

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

    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try




            Dim myobj As DataRowView = CType(gvwPaymentsReceived.GetFocusedRow, DataRowView)



            With My.Forms.AddPayment
                .TheSystemType = "CC"
                .IndexID = CInt(myobj.Row.Item("PaymentId"))
                .AppID = txtCCno.Text
                .PayId = CInt(myobj.Row.Item("InspTypeId"))
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(txtCCno.Text)
            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try



            With My.Forms.AddPayment

                .TheSystemType = "CC"
                .IndexID = 0
                .AppID = txtCCno.Text
                .PayId = 0
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(txtCCno.Text)
            CalculateRefundsandPayments(txtCCno.Text)

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
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

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


                LoadPaymentsRecieved(txtCCno.Text)
                CalculateRefundsandPayments(txtCCno.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            Dim myobj As DataRowView = CType(gvwDARefundsPaid.GetFocusedRow, DataRowView)


            With fFee

                .TheSystemType = "CC"
                .IDindex = CInt(myobj.Row.Item("RefundIDX"))

                .AppID = txtCCno.Text
                .PayId = CInt(myobj.Row.Item("RefundTypeId"))
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(txtCCno.Text)

            CalculateRefundsandPayments(txtCCno.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub btnAddRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try


            With My.Forms.AddRefund

                .TheSystemType = "CC"
                .IDindex = 0
                .AppID = txtCCno.Text
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(txtCCno.Text)

            CalculateRefundsandPayments(txtCCno.Text)

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
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

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


                LoadRefundsPaid(txtCCno.Text)

                CalculateRefundsandPayments(txtCCno.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub gvwPaymentsReceived_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwPaymentsReceived.RowClick

        Me.btnEditPayment.Enabled = True
        btnRemoveFee.Enabled = True

    End Sub

    Private Sub gvwDARefundsPaid_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwDARefundsPaid.RowClick
        Me.btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
    End Sub


#End Region

#Region "File Notes Tab"

    Private Sub RetrieveFileNotes(ByVal CDNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveFileNotes"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDNo
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "CC"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdFileNotes.DataSource = objDT


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub ClearNoteFields()
        Me.NoteDate.Text = String.Empty
        Me.txtNotesSubject.Text = String.Empty
        Me.txtNoteDetails.Text = String.Empty
        Me.txtNotesContactNo.Text = String.Empty
        Me.cboNoteType.EditValue = Nothing
        Me.txtNotesSpokeTo.Text = String.Empty
        Me.txtNotesCC.Text = String.Empty
        Me.txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        Me.cboNotesOfficer.EditValue = Nothing
        Me.btnEditNote.Enabled = False
        Me.btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
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
        Me.btnEditNote.Enabled = lock
        Me.btnSaveNote.Enabled = Not lock
        btnAddNote.Enabled = lock
        Me.btnNotePrint.Enabled = True
    End Sub
    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        ClearNoteFields()
        LockNotes(False)
        Me.btnSaveNote.Enabled = True
        btnAddNote.Enabled = False
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = False
    End Sub

    Private Sub btnNotesEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditNote.Click
        LockNotes(False)
        Me.btnSaveNote.Enabled = True
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = True

    End Sub

    Private Sub btnNotesSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        SaveNotesData()
        ClearNoteFields()
        LockNotes(True)
        Me.btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub SaveNotesData()
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = Me.cboNoteType.EditValue.ToString
                        .Parameters.Add("@SPOKEN", SqlDbType.NVarChar).Value = Me.txtNotesSpokeTo.Text
                        .Parameters.Add("@CC", SqlDbType.NVarChar).Value = Me.txtNotesCC.Text
                        .Parameters.Add("@FOLLOWUP", SqlDbType.NVarChar).Value = Me.txtNotesFollowUp.Text
                        If Not cboNotesOfficer.EditValue Is Nothing Then .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = Me.cboNotesOfficer.EditValue.ToString
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = Me.txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try
        End Using
        RetrieveFileNotes(txtCCno.Text)
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
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

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

                        Me.NoteDate.Text = Format(CDate(objDataRow.Item(0).ToString), "dd/MM/yyyy")
                        Me.txtNotesSubject.Text = objDataRow.Item(1).ToString
                        Me.txtNoteDetails.Text = objDataRow.Item(2).ToString
                        Me.txtNotesContactNo.Text = objDataRow.Item(3).ToString
                        Me.cboNoteType.EditValue = objDataRow.Item(4).ToString
                        Me.txtNotesSpokeTo.Text = objDataRow.Item(5).ToString
                        Me.txtNotesCC.Text = objDataRow.Item(6).ToString
                        Me.txtNotesFollowUp.Text = objDataRow.Item(7).ToString
                        Me.cboNotesOfficer.EditValue = CInt(objDataRow.Item(8).ToString)
                        Me.lblNotesID.Text = objDataRow.Item(9).ToString
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
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

            End Try
        End Using

    End Sub


#End Region

#Region "Materials"

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

    Private Sub SaveMaterialsData()
        Using cn As New SqlConnection(My.Settings.connectionString)
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


#End Region

#Region "Historical Docs"

    Private Sub LoadHistoricalDocuments()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_RetrieveHistoricalDevDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "CC"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    grdDocumentsList.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    'Private Sub btnSaveTheNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) 

    '    If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

    '    Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_UpdateDocumentNote"
    '                    .Parameters.Add("@NOTES", SqlDbType.NText).Value = Me.txtDocNote.Text
    '                    .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DocId"))
    '                    .ExecuteNonQuery()
    '                End With

    '            End Using

    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

    '        End Try
    '    End Using
    '    'reload file numbers
    '    txtDocNote.Text = String.Empty
    '    Try
    '        LoadHistoricalDocuments()
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub btnViewWord_Click(sender As Object, e As EventArgs) Handles btnViewWord.Click

        Dim DocumentName As String = String.Empty

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Me.Name)

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
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Me.Name)

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
            LoadHistoricalDocuments()
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

        'txtDocNote.Text = myobj.Row.Item("notes").ToString

        btnRemoveDocument.Enabled = True
        btnViewPDF.Enabled = True




        btnRemoveDocument.Visible = myobj.Row.Item("WORDDOC").ToString <> "N"
        btnViewWord.Visible = myobj.Row.Item("WORDDOC").ToString <> "N"
        btnViewPDF.Visible = myobj.Row.Item("WORDDOC").ToString = "N"



    End Sub

#End Region

#Region "Referrals"

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
                    PrintOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & Me.txtCCno.Text, "Sepp71Referral.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
            End Try
        End Using
    End Sub


    Private Function CheckReferralData() As Boolean
        Dim result As Boolean = True

        If Not IsDate(Refdt.Text) Then
            With ErrorProvider
                .SetError(Me.Refdt, "A referral date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.Refdt, "")

        End If
        If cboRefCodeId.EditValue Is Nothing Then
            ErrorProvider.SetError(Me.cboRefCodeId, "A referral source is required")

            result = False
        Else
            ErrorProvider.SetError(Me.cboRefCodeId, "")

        End If
        If txtRefComm.Text = String.Empty Then

            ErrorProvider.SetError(Me.txtRefComm, "A comment is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtRefComm, "")

        End If
        If cboRFSSubDivisionType.Visible Then
            If cboRFSSubDivisionType.EditValue Is Nothing Then

                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "A comment is required")

                result = False
            Else
                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "")

            End If

            If Me.txtRFSSubLots.Text = String.Empty Then
                ErrorProvider.SetError(Me.txtRFSSubLots, "A comment is required")

                result = False
            Else
                ErrorProvider.SetError(Me.txtRFSSubLots, "")

            End If
        End If
        Return result
    End Function


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        With My.Forms.ReferralsResponsePopUp
            .ResponseText = Me.txtRefResponse.Text
            .ShowDialog()
            txtRefResponse.Text = .ResponseText
            .Dispose()
        End With

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        With My.Forms.DraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = Me.txtCCno.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click

        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(pnlReferrals)
        Me.lblReferralID.Text = String.Empty


        'LockTheForm(pnlButtons, True)
        LockTheForm(pnlReferrals, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        txtRefComm.ReadOnly = False

        LoadLstIntegrated(txtCCno.Text)
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
                        If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
                        If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.EditValue)
                        .Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
                        .Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
                        .Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
                        .Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
                        .Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If Not cboRFSSubDivisionType.EditValue Is Nothing Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.EditValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadReferralsIntProvisionlList(txtCCno.Text)
        LoadLstIntegrated(txtCCno.Text)

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
        Me.btnEditReferralsTab.Enabled = True
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

            Case 2, 3
                Me.grpRFS.Visible = False
                btnRTA.Visible = True
                btnRTA.Enabled = True

            Case 59

                grpRFS.Visible = chksepp71.Checked

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
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

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
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

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
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "CC"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    PrintOnPlainPaperOnly(objDT, "Referral Response " & Me.txtCCno.Text, "ReferralResponse.rpt", 1)

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
        Dim sysType As String = "CC"


        Using cn As New SqlConnection(My.Settings.connectionString)
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


                PrintAndEASEWordDocs(docType, txtCCno.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & Me.txtCCno.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

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
        Dim sysType As String = "CC"


        Using cn As New SqlConnection(My.Settings.connectionString)
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


                PrintAndEASEWordDocs(docType, txtCCno.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & Me.txtCCno.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

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
        Dim sysType As String = "CC"


        Using cn As New SqlConnection(My.Settings.connectionString)
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


                PrintAndEASEWordDocs(docType, txtCCno.Text, docname, docfilename, sysType, "Referral letter for Roads and Maritime Service" & Me.txtCCno.Text, MacroName)




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnRemoveRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefer.Click


        If MessageBox.Show("Are you sure you want to remove this referral?", "Remove Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
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

        LoadReferralsIntProvisionlList(txtCCno.Text)
        LoadLstIntegrated(txtCCno.Text)



        LockTheForm(pnlButtons, False)
        LockTheForm(pnlReferrals, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        btnView.Enabled = True
        Me.btnEditReferralsTab.Enabled = False
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

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

        ClearReferralData(pnlReferrals)


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

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

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
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

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
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    LoadLstIntegrated(txtCCno.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.EditValue = Nothing
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & Me.lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.connectionString)
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
                LoadLstIntegrated(txtCCno.Text)

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
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReferralsIntegratedProvision"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CdNo
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "CC"

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
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadReferralsIntProvisionlList(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListReferrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "CC"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdLoadListReferrals.DataSource = objDT
                    grdLoadListReferrals.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Me.Name)

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

        Me.lblReferralID.Text = String.Empty

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
                filename = OpenFileDialoge.FileName.ToString
                fileType = IO.Path.GetExtension(filename)

                'Dim imageData As Byte() = ReadFile(filename)
                'Dim imageData As Byte() = File.ReadAllBytes(filename)

                Dim imageData As Byte()
                imageData = ReadFile(filename)



                Using cn As New SqlConnection(My.Settings.connectionString)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

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
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

                    End Try
                End Using

            End If

        Else

            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

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
                    MessageBox.Show(ex.Message, " Then In btnAddPDF_Click routine - form " & Me.Name)

                End Try
            End Using



        End If

    End Sub


    Public Sub PrintAndEASEWordDocs(ByVal doctype As Integer, ByVal AppNo As String, ByVal docname As String, ByVal docfilename As String, ByVal appsys As String, ByVal DocSummary As String, Optional ByVal macroName As String = "", Optional ByVal DocCode As String = "", Optional ByVal LHead As String = "Y")
        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document
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

            'objWordDoc = objWordApp.Application.Documents.Open(docfilename.ToString)
            objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename.ToString), NewTemplate:=False, DocumentType:=0)
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


                '.SaveAs(WordDocName.ToString, FileFormat:=WORD.WdSaveFormat.wdFormatXMLDocument)

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

#Region "Build Letters"

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




        End If
    End Sub

    Private Sub btnAssembleLetter_Click(sender As Object, e As EventArgs) Handles btnAssembleLetter.Click
        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "CC"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboConsentDocType.EditValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboConsentDocType.EditValue)
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

    Private Sub LoadListOfWordTemplates()



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
                        .CommandText = "usp_LoadUpda_DocType_WordTemplateList"
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "C"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboConsentDocType.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboConsentDocType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    'Private Sub LoadUpConditionsList(ByVal AANo As String)

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in LoadUpConditionsList routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_LoadUpConditionList"

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
    '                End With

    '                Dim objDT As New DataTable


    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '                dgvSTDConditions.DataSource = objDT
    '                dgvSTDConditions.Refresh()

    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in LoadUpConditionsList routine - form " & Me.Name)

    '        End Try
    '    End Using




    'End Sub

    Private Sub LoadUpOneUpConditions(ByVal AANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpOneUpConditions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadOneUpConditions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvOneUpConditions.DataSource = objDT
                    dgvOneUpConditions.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpOneUpConditions routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    'Private Sub LoadListOfConditionsByLetterType(ByVal DocId As Integer)
    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in LoadListOfConditionsByLetterType routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_ListofConditionsByLetterType"

    '                    .Parameters.Add("@DOCID", SqlDbType.Int).Value = DocId
    '                End With

    '                Dim objDT As New DataTable


    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using

    '                With cboSTDconditions.Properties
    '                    .DataSource = objDT
    '                    .DisplayMember = "Condition"
    '                    .ValueMember = "Id"
    '                End With

    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in LoadListOfConditionsByLetterType routine - form " & Me.Name)

    '        End Try
    '    End Using





    'End Sub

    'Private Sub cboConsentDocType_EditValueChanged(sender As Object, e As EventArgs) Handles cboConsentDocType.EditValueChanged
    '    If isloading Then Exit Sub


    '    If cboConsentDocType.IsLoading Then Return

    '    If cboConsentDocType.EditValue Is Nothing Then Return

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in cboConsentDocType_SelectedValueChanged routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_ListofConditionsByLetterType"

    '                    .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(cboConsentDocType.EditValue)
    '                End With

    '                Dim objDT As New DataTable


    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '                If objDT.Rows.Count = 0 Then

    '                    cboSTDconditions.Visible = False
    '                    btnAddCondition.Visible = False

    '                Else

    '                    With cboSTDconditions.Properties

    '                        .DataSource = objDT
    '                        .DisplayMember = "Condition"
    '                        .ValueMember = "Id"

    '                    End With

    '                    Dim col2 As LookUpColumnInfoCollection = cboSTDconditions.Properties.Columns
    '                    col2.Add(New LookUpColumnInfo("Condition", 0))
    '                    col2.Add(New LookUpColumnInfo("Id", 0))
    '                    col2.Add(New LookUpColumnInfo("Standard", 0))

    '                    col2.Item(1).Visible = False
    '                    col2.Item(2).Visible = False

    '                    cboSTDconditions.Visible = True
    '                    btnAddCondition.Visible = True

    '                End If



    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in cboConsentDocType_SelectedValueChanged routine - form " & Me.Name)

    '        End Try
    '    End Using


    'End Sub


    'Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    '    If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

    '    Dim myobj As DataRowView = CType(gvwSTDConditions.GetFocusedRow, DataRowView)

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_RemoveConditionCode"

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
    '                    .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("Id"))
    '                    .ExecuteNonQuery()
    '                End With



    '            End Using

    '            Try
    '                LoadUpConditionsList(Me.txtCCno.Text)
    '            Catch ex As System.Exception
    '                System.Windows.Forms.MessageBox.Show(ex.Message)
    '            End Try

    '            btnRemoveCondition.Enabled = False

    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

    '        End Try
    '    End Using


    'End Sub

    'Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    InsertNewCondition()
    '    cboSTDconditions.Focus()


    'End Sub


    'Private Sub InsertNewCondition()
    '    If cboSTDconditions.EditValue Is Nothing Then Return

    '    If CheckConditionAlreadyExists(CInt(cboSTDconditions.EditValue)) Then
    '        MessageBox.Show("Condition """ & Me.cboSTDconditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_InsertIndividualSTDCondition"

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
    '                    .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboSTDconditions.EditValue)
    '                    .ExecuteNonQuery()

    '                End With


    '                LoadUpConditionsList(txtCCno.Text)




    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

    '        End Try
    '    End Using
    'End Sub

    Private Sub btnEditCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCondition.Click

        Dim myobj As DataRowView = CType(gvwOneUpConditions.GetFocusedRow, DataRowView)

        With My.Forms.InsertOneUpCondition
            .ID = CInt(myobj.Row.Item("UniqueId"))
            .DAnumber = Me.txtCCno.Text
            .ShowDialog()
            .Dispose()

        End With

        'LoadUpConditionsList(txtCCno.Text)


    End Sub


    Private Sub btnRemoveOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOneOffCond.Click

        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwOneUpConditions.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("UniqueId"))
                        .ExecuteNonQuery()
                    End With



                End Using

                btnRemoveOneOffCond.Enabled = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadUpOneUpConditions(txtCCno.Text)

    End Sub

    Private Sub btnAddOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOneOffCond.Click
        With My.Forms.InsertOneUpCondition
            .DAnumber = Me.txtCCno.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadUpOneUpConditions(txtCCno.Text)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    'Private Sub gvwSTDConditions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)

    '    btnRemoveCondition.Enabled = True

    'End Sub

    'Private Sub gvwSTDConditions_RowCellClick(sender As Object, e As RowCellClickEventArgs)

    '    Dim celclick As GridHitInfo = gvwSTDConditions.CalcHitInfo(dgvSTDConditions.PointToClient(Control.MousePosition))


    '    If celclick.InRowCell Then
    '        Dim rowHandle As Integer = celclick.RowHandle
    '        Dim column As GridColumn = celclick.Column

    '        If column.Name = "colFreeFormInserts" Then

    '            Dim myobj As DataRowView = CType(gvwSTDConditions.GetFocusedRow, DataRowView)

    '            With My.Forms.DAConditionsFreeForm

    '                .ConditionCode = CInt(myobj.Row.Item("Id"))

    '                .DANumber = txtDANo.Text

    '                .ShowDialog()
    '                .Dispose()

    '            End With

    '        End If

    '    End If



    'End Sub


    Private Sub gvwOneUpConditions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwOneUpConditions.RowClick

        btnRemoveOneOffCond.Enabled = True
        btnEditCondition.Enabled = True


    End Sub

    Private Sub gvwDraftDocs_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwDraftDocs.RowClick

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)



        btnViewEditDocument.Enabled = True
        btnDeleteDoc.Enabled = True
        btnFinaliseDoc.Enabled = True

        btnEmailAcknowledge.Enabled = txtAppEmail.Text <> String.Empty


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
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

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
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            DisplayListOfDraftDocuments(txtCCno.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click



        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)

        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString
        Dim DocumentType As String = myobj.Row.Item("Description").ToString
        Dim DocID As Integer = CInt(myobj.Row.Item("DraftDocId"))



        'If dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "ModConsent" Or dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "StdConsent" Then

        If myobj.Row.Item("Docname").ToString = "ModConsent" Or myobj.Row.Item("Docname").ToString = "StdConsent" Then


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
                            .CommandText = "usp_SubmissionandObjections"

                            .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        End With

                        Dim objDT As New DataTable


                        Using objDataReader As SqlDataReader = cmd.ExecuteReader
                            objDT.Load(objDataReader)
                        End Using
                        If objDT.Rows.Count > 0 Then
                            If MessageBox.Show("Have you printed Objector Advice letters yet?", "Proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                        End If



                    End Using




                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

                End Try
            End Using
        End If

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & txtDANo.Text & " Document Type: " & DocumentType

        Dim Recepient As Integer


        With My.Forms.WhoAreYouSendingMailTo
            .ShowDialog()
            Recepient = .Recepient
            .Dispose()

        End With


        With My.Forms.InsertEASEDocument

            Select Case Recepient
                Case 1

                    .CustName = Me.txtDAOwnersName.Text
                    .CustAddress = Me.txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text

                Case 2

                    .CustName = Me.txtAppName.Text
                    .CustAddress = Me.txtAppAddress.Text & " " & Me.txtAppTown.Text & " " & Me.txtAppPcode.Text


            End Select

            .WordDocLocation = myobj.Row.Item("DraftDocPath").ToString
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With

        Dim NewRecordID As Integer

        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "CC"
            .DocumentType = myobj.Row.Item("Docname").ToString
            .ApplicationNo = Me.txtDANo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
            NewRecordID = .DocumentID

        End With


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
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = DocID
                        .ExecuteNonQuery()
                    End With
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        LoadHistoricalDocuments()
        DisplayListOfDraftDocuments(txtCCno.Text)




    End Sub


    Private Sub DisplayListOfDraftDocuments(ByVal AANo As String)

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
                        .CommandText = "usp_DisplayListOfDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdDraftDocs.DataSource = objDT
                    grdDraftDocs.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

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
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Me.Name)

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
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Me.Name)

            End Try
        End Using



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


                    grdDraftDocs.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayDraftDocuments routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnIssueCCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssueCCert.Click

        If gvwBuildingCode.RowCount = 0 Then
            MessageBox.Show("You are required to enter an Australian Building code before proceeding", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboBldgCodeAust.Focus()
            Return

        End If

        If Not AddressNotSaved() Then
            'MessageBox.Show("You need to save the data on the Property Tab before proceeding, click the Edit and Save buttons", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.tabDAdata.SelectedTab = pgProperty
            SaveHeaderData()
            'Me.tabDAdata.SelectedTab = pgStatus
        End If

        Dim TheReportName As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
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


                If CType(cboAppType.EditValue, Integer) = 1 Then

                    If MessageBox.Show("You are about to issue a Construction Certificate, you MUST save the data before proceeding,  OK to proceed?", "Print Compliance Certificate/Defective Notice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                    'TheReportName = "ConstructCert_DA.rpt"
                    CCType = "STANDARD"

                End If

        End Select


        PrintTheConstructionCertificate(CCType)


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

                Threading.Thread.Sleep(2000)

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


                'objWordApp.Quit()

                'releaseObject(objWordDoc)

                'releaseObject(objWordApp)


            End If


            InsertRecordIntoDraftDocs(txtCCno.Text, Doctype, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))


            DisplayDraftDocuments(CCNo)



            Dim WRD As New OpenDocument
            WRD.OpenVisible(WordDocName)

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in LoadSeizedItems routine - form " & Me.Name)


        Finally

            objWordApp.Quit()

            releaseObject(objWordDoc)
            releaseObject(objWordApp)



        End Try






    End Sub

    Private Function CheckConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtCCno.Text
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
        Using cn As New SqlConnection(My.Settings.connectionString)
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



#End Region

#Region "Status"

    Private Sub btnEditStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStatus.Click
        Me.btnSaveStatus.Enabled = True
        Me.btnEditStatus.Enabled = False
        LockTheForm(Me.grpAssessment, True)
    End Sub

    Private Sub btnSaveStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveStatus.Click
        Me.btnSaveStatus.Enabled = False
        Me.btnEditStatus.Enabled = True
        LockTheForm(grpAssessment, False)
        SaveStatusData()

    End Sub

    Private Sub SaveStatusData()
        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        If IsDate(dtOfficer.Text) Then .Parameters.Add("@TOOFFICER", SqlDbType.SmallDateTime).Value = Format(CDate(dtOfficer.EditValue), "dd/MM/yyyy")

                        If IsDate(dtSurveyor.Text) Then .Parameters.Add("@TOBLGSURV", SqlDbType.SmallDateTime).Value = Format(CDate(dtSurveyor.EditValue), "dd/MM/yyyy")

                        If IsDate(dtDetermined.Text) Then .Parameters.Add("@DETERMINED", SqlDbType.SmallDateTime).Value = Format(CDate(dtDetermined.EditValue), "dd/MM/yyyy")

                        If IsDate(dtNotified.Text) Then .Parameters.Add("@INFORMDTE", SqlDbType.SmallDateTime).Value = Format(CDate(dtNotified.EditValue), "dd/MM/yyyy")

                        If IsDate(dtSiteInspected.Text) Then .Parameters.Add("@SITEINSPECTDTE", SqlDbType.SmallDateTime).Value = Format(CDate(dtSiteInspected.EditValue), "dd/MM/yyyy")

                        If IsDate(dtCertSent.Text) Then .Parameters.Add("@POSTEDDT", SqlDbType.SmallDateTime).Value = Format(CDate(dtCertSent.EditValue), "dd/MM/yyyy")

                        If cboDADecisionId.EditValue IsNot Nothing Then .Parameters.Add("@DECISIONID", SqlDbType.NVarChar).Value = CInt(cboDADecisionId.EditValue)

                        If cboDAAuthorityId.EditValue IsNot Nothing Then .Parameters.Add("@AUTHORITYID", SqlDbType.Int).Value = CInt(Me.cboDAAuthorityId.EditValue)

                        .Parameters.Add("@FIRESAFETY", SqlDbType.Bit).Value = CBool(chkFireSafety.EditValue)

                        .Parameters.Add("@PLANNO", SqlDbType.NVarChar).Value = Me.txtCouncilPlanNo.Text

                        .Parameters.Add("@OFFICERSCOMMENT", SqlDbType.NVarChar).Value = txtProgressComment.Text

                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub




#End Region


#Region "Load combo"

    Private Sub LoadLookupEdit(ByVal cbo As LookUpEdit, ByVal SPROC As String)

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
                        .CommandText = SPROC

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cbo.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cbo.Properties.Columns
                col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                col2.Add(New LookUpColumnInfo("ValueMember", 0))

                col2.Item(1).Visible = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

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

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboBuildersNames.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "Name"
                        .ValueMember = "Name"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cboBuildersNames.Properties.Columns
                col2.Add(New LookUpColumnInfo("Name", 0))
                col2.Add(New LookUpColumnInfo("Acc_Lic_no", 0))
                col2.Add(New LookUpColumnInfo("Phone", 0))
                col2.Add(New LookUpColumnInfo("ID", 0))
                col2.Add(New LookUpColumnInfo("Address", 0))
                col2.Add(New LookUpColumnInfo("Town", 0))
                col2.Add(New LookUpColumnInfo("PC", 0))

                col2.Item(1).Visible = False
                col2.Item(2).Visible = False
                col2.Item(3).Visible = False
                col2.Item(4).Visible = False
                col2.Item(5).Visible = False
                col2.Item(6).Visible = False





            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadCCBuildingClasses()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCCWorkDescriptions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_CCClass"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboBldgCodeAust.Properties

                        .DataSource = objDT
                        .DisplayMember = "CCClass"
                        .ValueMember = "CCClassId"
                        .ShowHeader = False
                        .ShowFooter = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboBldgCodeAust.Properties.Columns
                    col2.Add(New LookUpColumnInfo("CCClass", 0))
                    col2.Add(New LookUpColumnInfo("CCClassId", 0))

                    col2.Item(1).Visible = False
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadListOfReferrals(CCno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfReferrals routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListReferrals"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = CCno
                        .Parameters.Add("@SYSTYPE", SqlDbType.VarChar).Value = "CC"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdLoadListReferrals.DataSource = objDT
                    'dgvSales.Refresh()

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadCC_ClassIds(ByVal CCNo As String)


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


                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdBuildingCode.DataSource = objDT


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCC_ClassIds routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub LoadCCWorkDescriptions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCCWorkDescriptions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_CCDescOfWork"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboDescription.Properties

                        .DataSource = objDT
                        .DisplayMember = "CCDescWork"
                        .ValueMember = "CCDescWorkId"
                        .ShowHeader = False
                        .ShowFooter = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboDescription.Properties.Columns
                    col2.Add(New LookUpColumnInfo("CCDescWork", 0))
                    col2.Add(New LookUpColumnInfo("CCDescWorkId", 0))

                    col2.Item(1).Visible = False
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadCCAppType()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCCWorkDescriptions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_CCAppType"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboAppType.Properties

                        .DataSource = objDT
                        .DisplayMember = "CCAppType"
                        .ValueMember = "CCAppTypeId"
                        .ShowHeader = False
                        .ShowFooter = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboAppType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("CCAppType", 0))
                    col2.Add(New LookUpColumnInfo("CCAppTypeId", 0))

                    col2.Item(1).Visible = False
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadInsuranceCompanies()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadInsuranceCompanies routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_InsuranceCompanies"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboInsuranceName.Properties

                        .DataSource = objDT
                        .DisplayMember = "Insurance"
                        .ValueMember = "InsuranceId"
                        .ShowHeader = False
                        .ShowFooter = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboInsuranceName.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Insurance", 0))
                    col2.Add(New LookUpColumnInfo("InsuranceId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadCCBuildSol()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCCWorkDescriptions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Const_SELECT_CCBuildSol"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboBldgSolution.Properties

                        .DataSource = objDT
                        .DisplayMember = "CCBuildSol"
                        .ValueMember = "CCBuildSolId"
                        .ShowHeader = False
                        .ShowFooter = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboBldgSolution.Properties.Columns
                    col2.Add(New LookUpColumnInfo("CCBuildSol", 0))
                    col2.Add(New LookUpColumnInfo("CCBuildSolId", 0))

                    col2.Item(1).Visible = False
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

#End Region


#Region "Form Events"


    Private Sub btnViewOfficers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewOfficers.Click
        With My.Forms.AssignedOfficers
            .AppNo = txtDANo.Text
            .sysRef = "CC"
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub rgpBuilderType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgpBuilderType.SelectedIndexChanged

        grpLicenceBuilder.Visible = CInt(rgpBuilderType.EditValue) = 0
        grpOwnerBuilder.Visible = CInt(rgpBuilderType.EditValue) = 1

    End Sub

    Private Sub IssueConstructionCertificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadCCWorkDescriptions()
        LoadCCBuildSol()
        LoadCCAppType()
        LoadLookupEdit(cboDAlocalityCode, "usp_LoadUpLocalityCodesList")
        LoadLookupEdit(cboNoteType, "usp_LoadUpFileNoteTypeList")
        LoadLookupEdit(cboNotesOfficer, "usp_LoadUpOfficerList")
        LoadLookupEdit(cboDAAuthorityId, "usp_LoadUpDAAuthorityList")
        LoadLookupEdit(cboDADecisionId, "usp_LoadUpDADecisionList")
        LoadLookupEdit(cboReferralsIntProvision, "usp_LoadUpIntegratedProvisionList")
        LoadLookupEdit(cboRefCodeId, "usp_LoadUpReferralCodeList")
        LoadCCBuildingClasses()
        LoadListOfWordTemplates() '<<<++++======
        LoadRFSRFSSubDivisionType()
        LoadInsuranceCompanies()
        LoadBuildersNames()


        LoadSearchList()


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

        If gvwListOfCertificates.RowCount > 0 Then

            Dim myobj As DataRowView = CType(gvwListOfCertificates.GetFocusedRow, DataRowView)

            LoadForm(myobj.Row.Item("CCAppNo").ToString)


        End If





    End Sub


    Private Sub btnAdditionalInfo_Click(sender As Object, e As EventArgs) Handles btnAdditionalInfo.Click
        Dim AdditionalInfo As New ADDINFO

        With AdditionalInfo
            .ServerName = "REC"
            .SystemType = "CC"
            .ApplicationNumber = txtCCno.Text
            .UserId = MyUserId
            .LoadMainInterface()
        End With
    End Sub

    Private Sub btnAddCC_Click(sender As Object, e As EventArgs) Handles btnAddCC.Click

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

        btnAddFee.Enabled = True
        btnAddRefund.Enabled = True

        ClearData(pnlApplication)
        ClearData(pnlMaterials)
        ClearData(pnlDisplayFees)
        ClearData(pnlStatus)
        ClearData(pnlReferrals)
        ClearData(pnlFileNotes)

        LoadSearchList()


        LoadForm(NewccNumbers)


        txtReceipts.Text = String.Empty
        txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty


        btnEditDA.Enabled = False

        btnSaveDA.Enabled = True
        btnAddCC.Enabled = False


    End Sub

    Private Sub btnEditDA_Click(sender As Object, e As EventArgs) Handles btnEditDA.Click


        LockTheForm(pnlApplication, True)
        LockTheForm(pnlMaterials, True)
        LockTheForm(pnlDisplayFees, True)
        'LockTheForm(pnlStatus, True)
        LockTheForm(pnlReferrals, True)
        LockTheForm(pnlFileNotes, True)
        txtLongServiceLevy.ReadOnly = False


        cboBldgCodeAust.ReadOnly = False

        btnEditDA.Enabled = False

        btnSaveDA.Enabled = True
        btnAddFee.Enabled = True
        btnAddRefund.Enabled = True
        txtOfficer.ReadOnly = True

    End Sub

    Private Sub btnSaveDA_Click(sender As Object, e As EventArgs) Handles btnSaveDA.Click

        LockTheForm(pnlApplication, False)
        LockTheForm(pnlMaterials, False)
        LockTheForm(pnlDisplayFees, False)
        LockTheForm(pnlStatus, False)
        LockTheForm(pnlReferrals, False)
        LockTheForm(pnlFileNotes, False)

        txtLongServiceLevy.ReadOnly = True
        cboBldgCodeAust.ReadOnly = True


        btnAdd.Enabled = False
        btnRemove.Enabled = False

        btnAddFee.Enabled = False
        btnAddRefund.Enabled = False
        btnEditDA.Enabled = True
        btnSaveDA.Enabled = False
        btnAddCC.Enabled = True
        SaveHeaderData()
        SaveBuilderData()

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        InsertNewCode(cboBldgCodeAust.Text)
        LoadCC_ClassIds(txtCCno.Text)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim myobj As DataRowView = CType(gvwBuildingCode.GetFocusedRow, DataRowView)


        RemoveClassID(myobj.Row.Item("CCClassId").ToString)

        LoadCC_ClassIds(txtCCno.Text)

        btnRemove.Enabled = False

    End Sub

    Private Sub gvwBuildingCode_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwBuildingCode.RowClick
        btnRemove.Enabled = True
    End Sub

    Private Sub gvwListOfCertificates_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwListOfCertificates.RowClick

        CheckIfDataChanged()

        Dim myobj As DataRowView = CType(gvwListOfCertificates.GetFocusedRow, DataRowView)

        LoadForm(myobj.Row.Item("CCAppNo").ToString)


    End Sub

    Private Sub btnPrintCoverSheet_Click(sender As Object, e As EventArgs) Handles btnPrintCoverSheet.Click


        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub btnEmailAcknowledge_Click(sender As Object, e As EventArgs) Handles btnEmailAcknowledge.Click


        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return


        With My.Forms.EmailConstructionCertificate

            .EmailAddress = txtAppEmail.Text

            .LetterBeingSent = "DAACK"

            .DANo = txtDANo.Text

            .DocumentName = myobj.Row.Item("DraftDocPath").ToString

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Sub cboBuildersNames_EditValueChanged(sender As Object, e As EventArgs) Handles cboBuildersNames.EditValueChanged

        If cboBuildersNames.IsLoading Then Return

        Dim editor As LookUpEdit = CType(cboBuildersNames, LookUpEdit)

        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)

        If row IsNot Nothing Then


            txtLicBuilderNo.Text = row.Item("Acc_Lic_no").ToString
            txtLicBuilderPhone.Text = row.Item("Phone").ToString

        End If



    End Sub



    Private Sub txtOfficer_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtOfficer.ButtonClick
        With My.Forms.AssignOfficerList
            .AppNumber = txtCCno.Text
            .SysRef = "CC"
            .ShowDialog()
            If .Officer <> String.Empty Then txtOfficer.Text = .Officer
            .Dispose()
        End With
    End Sub

    Private Sub cboBldgSolution_EditValueChanged(sender As Object, e As EventArgs) Handles cboBldgSolution.EditValueChanged

        If cboBldgSolution.IsLoading Or isloading Then Return

        If cboBldgSolution.EditValue = 2 Then


            With My.Forms.NCCBuildingSolutionsList

                .DANumber = txtDANo.Text

                .EditForm = False

                .ShowDialog()

                .Dispose()

            End With


        End If


    End Sub

    Private Sub btnViewBldgSolutions_Click(sender As Object, e As EventArgs) Handles btnViewBldgSolutions.Click

        With My.Forms.NCCBuildingSolutionsList

            .DANumber = txtDANo.Text

            .EditForm = True

            .ShowDialog()

            .Dispose()

        End With


    End Sub

    Private Sub gvwDocumentsList_DoubleClick(sender As Object, e As EventArgs) Handles gvwDocumentsList.DoubleClick
        DisplayPDFdocument()
    End Sub






#End Region


End Class