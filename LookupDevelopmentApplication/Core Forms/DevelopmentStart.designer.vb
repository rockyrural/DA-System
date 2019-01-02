<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevelopmentStart
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CurrentLandUseLabel As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim OfficerLabel As System.Windows.Forms.Label
        Dim CoPCAnameLabel As System.Windows.Forms.Label
        Dim DADecisionLabel As System.Windows.Forms.Label
        Dim CCAppNoLabel As System.Windows.Forms.Label
        Dim DACompletedDtLabel1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ConsentPlanNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevelopmentStart))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList5 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgSmll = New System.Windows.Forms.ImageList(Me.components)
        Me.imlNavigation = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabPanels = New DevExpress.XtraTab.XtraTabControl()
        Me.tpgApplication = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlApplicationData = New DevExpress.XtraEditors.PanelControl()
        Me.grpBasix = New DevExpress.XtraEditors.GroupControl()
        Me.txtBASIXRcptNo = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.chkBASIXRecd = New System.Windows.Forms.CheckBox()
        Me.txtBASIXCertNo = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtBASIXwater = New System.Windows.Forms.TextBox()
        Me.txtBASIXthermal = New System.Windows.Forms.TextBox()
        Me.txtBASIXenergy = New System.Windows.Forms.TextBox()
        Me.grpFileNumber = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemoveFile = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddFile = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lstFile = New System.Windows.Forms.ListBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lblDesignated = New System.Windows.Forms.Label()
        Me.lblAdvertising = New System.Windows.Forms.Label()
        Me.grpOwner = New DevExpress.XtraEditors.GroupControl()
        Me.btnUse2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKeep2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDAOwnersPcode = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDAOwnersName = New System.Windows.Forms.TextBox()
        Me.txtDAOwnersAddress = New System.Windows.Forms.TextBox()
        Me.txtDAOwnersTown = New System.Windows.Forms.TextBox()
        Me.txtDAOwnersPhone = New System.Windows.Forms.TextBox()
        Me.grpAdditional = New DevExpress.XtraEditors.GroupControl()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cboDAClass2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAClass1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAClass3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cboDAtype1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAtype3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAType2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.grpPurpose = New DevExpress.XtraEditors.GroupControl()
        Me.chkDADesc8 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc7 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc6 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc5 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc4 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc3 = New System.Windows.Forms.CheckBox()
        Me.chkDADesc2 = New System.Windows.Forms.CheckBox()
        Me.chkDesc1 = New System.Windows.Forms.CheckBox()
        Me.grpDescription = New DevExpress.XtraEditors.GroupControl()
        Me.lupOccupancyStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboDAClass = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblOccupancy = New System.Windows.Forms.Label()
        Me.lblAttachement = New System.Windows.Forms.Label()
        Me.cboAttachmentStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDemolishedDwelings = New DevExpress.XtraEditors.TextEdit()
        Me.lblNoDemolishedDwellings = New System.Windows.Forms.Label()
        Me.txtExistingDwelings = New DevExpress.XtraEditors.TextEdit()
        Me.lblExistingDwellings = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cboIntendedLandUse = New DevExpress.XtraEditors.LookUpEdit()
        Me.nudDwellings = New DevExpress.XtraEditors.TextEdit()
        Me.lblNoDwellings = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cboBuildingType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCurrentLandUse = New System.Windows.Forms.TextBox()
        Me.chkGiftDonation = New System.Windows.Forms.CheckBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lblModDesc = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtModDesc = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDAFloor = New System.Windows.Forms.TextBox()
        Me.txtDAestCost = New System.Windows.Forms.TextBox()
        Me.txtDADesc = New System.Windows.Forms.TextBox()
        Me.cboConsentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDevUse = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDevType = New DevExpress.XtraEditors.LookUpEdit()
        Me.grpLand = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.grdPIN = New DevExpress.XtraGrid.GridControl()
        Me.gvwPIN = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ibExit = New DevExpress.XtraBars.BarButtonItem()
        Me.BiSection94 = New DevExpress.XtraBars.BarButtonItem()
        Me.BiCompliance = New DevExpress.XtraBars.BarButtonItem()
        Me.BiConstructionCert = New DevExpress.XtraBars.BarButtonItem()
        Me.BiEngineerConsent = New DevExpress.XtraBars.BarButtonItem()
        Me.BiAssessment = New DevExpress.XtraBars.BarButtonItem()
        Me.BiMyOSDas = New DevExpress.XtraBars.BarButtonItem()
        Me.BiAddDA = New DevExpress.XtraBars.BarButtonItem()
        Me.BiEditDA = New DevExpress.XtraBars.BarButtonItem()
        Me.BiSaveDA = New DevExpress.XtraBars.BarButtonItem()
        Me.ibImages = New DevExpress.XtraBars.BarSubItem()
        Me.ibOldSystemImages = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCurrentImages = New DevExpress.XtraBars.BarButtonItem()
        Me.ibVideos = New DevExpress.XtraBars.BarButtonItem()
        Me.ibPrintCoverSheet = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCreateTemplate = New DevExpress.XtraBars.BarButtonItem()
        Me.ibRptsExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ibMaintExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ibOfficers = New DevExpress.XtraBars.BarButtonItem()
        Me.ibLookupLists = New DevExpress.XtraBars.BarSubItem()
        Me.ibDevelopmentTypes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibPCAbuilders = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAuthorities = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDAUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.ibReferralList = New DevExpress.XtraBars.BarButtonItem()
        Me.ibSEPPcodes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDCPtypes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDCPGuidlines = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInspectionTypes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibStdCondCodes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInsuranceCoy = New DevExpress.XtraBars.BarButtonItem()
        Me.ibSection94Codes = New DevExpress.XtraBars.BarButtonItem()
        Me.ibSection94RF = New DevExpress.XtraBars.BarButtonItem()
        Me.ibConsentAdvert = New DevExpress.XtraBars.BarButtonItem()
        Me.ibABSStats = New DevExpress.XtraBars.BarButtonItem()
        Me.ibNavision = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAppCounters = New DevExpress.XtraBars.BarSubItem()
        Me.ibAllResults = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDAresults = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCDresults = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCCresults = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.ibReports = New DevExpress.XtraBars.BarSubItem()
        Me.ibApprovals = New DevExpress.XtraBars.BarButtonItem()
        Me.ibOfficerAllocations = New DevExpress.XtraBars.BarSubItem()
        Me.ibDevelopmentApps = New DevExpress.XtraBars.BarButtonItem()
        Me.ibConstructionCertificates = New DevExpress.XtraBars.BarButtonItem()
        Me.ibMayoral = New DevExpress.XtraBars.BarSubItem()
        Me.ibMayoralRecd = New DevExpress.XtraBars.BarButtonItem()
        Me.ibMayoralDetermined = New DevExpress.XtraBars.BarButtonItem()
        Me.ibReferrrals = New DevExpress.XtraBars.BarSubItem()
        Me.ibOSreferrals = New DevExpress.XtraBars.BarButtonItem()
        Me.ibReferralsByOfficer = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDAreceived = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCCreceived = New DevExpress.XtraBars.BarSubItem()
        Me.ibCCOwner = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCCPCA = New DevExpress.XtraBars.BarButtonItem()
        Me.ibOutstandingDA = New DevExpress.XtraBars.BarButtonItem()
        Me.ibDAdetermined = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCCdetermined = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInspections = New DevExpress.XtraBars.BarSubItem()
        Me.ibInspectionByOfficer = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInspectOfficerAndType = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInspectOfficerSummary = New DevExpress.XtraBars.BarButtonItem()
        Me.ibInspectFileNumber = New DevExpress.XtraBars.BarButtonItem()
        Me.ibApprovalsByTown = New DevExpress.XtraBars.BarButtonItem()
        Me.ibOccupByTown = New DevExpress.XtraBars.BarButtonItem()
        Me.ibSepticByTown = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAppliByOfficer = New DevExpress.XtraBars.BarButtonItem()
        Me.ibStatutoryTime = New DevExpress.XtraBars.BarButtonItem()
        Me.ibCCwithoutOC = New DevExpress.XtraBars.BarButtonItem()
        Me.ibExpiredIOC = New DevExpress.XtraBars.BarButtonItem()
        Me.ibNumberDwellingsAppd = New DevExpress.XtraBars.BarButtonItem()
        Me.ibOutstandCC = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAppdDelegation = New DevExpress.XtraBars.BarButtonItem()
        Me.ibLTW = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAverageTime = New DevExpress.XtraBars.BarButtonItem()
        Me.ibLEPRegister = New DevExpress.XtraBars.BarButtonItem()
        Me.ibTotalNoDACC = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.ibAdditionalIfo = New DevExpress.XtraBars.BarButtonItem()
        Me.ibLinked = New DevExpress.XtraBars.BarButtonItem()
        Me.ibIntraMaps = New DevExpress.XtraBars.BarButtonItem()
        Me.ibGoogleMaps = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReports = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnRetrieveProperty = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemovePIN = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddPIN = New DevExpress.XtraEditors.SimpleButton()
        Me.grpPropertyLotAddress = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboAreaType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.cboDACensusCode = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDAlocalityCode = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.txtDP = New System.Windows.Forms.TextBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtStreetNo = New System.Windows.Forms.TextBox()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grpCCSum = New DevExpress.XtraEditors.GroupControl()
        Me.lblinsurValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblInsuranceNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblBuilderName = New DevExpress.XtraEditors.LabelControl()
        Me.lblOwnerBuilder = New DevExpress.XtraEditors.LabelControl()
        Me.lblOwnerBuilderNo = New DevExpress.XtraEditors.LabelControl()
        Me.txtCCInsuranceNo = New System.Windows.Forms.TextBox()
        Me.txtCCLicBuilderName = New System.Windows.Forms.TextBox()
        Me.txtCCOwnerBuilderNo = New System.Windows.Forms.TextBox()
        Me.CCValueTextBox = New System.Windows.Forms.TextBox()
        Me.OfficerTextBox = New System.Windows.Forms.TextBox()
        Me.CoPCAnameTextBox = New System.Windows.Forms.TextBox()
        Me.DADecisionTextBox = New System.Windows.Forms.TextBox()
        Me.CCAppNoTextBox = New System.Windows.Forms.TextBox()
        Me.grpDetails = New DevExpress.XtraEditors.GroupControl()
        Me.btnUse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKeep = New DevExpress.XtraEditors.SimpleButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAppemail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAppPhone = New System.Windows.Forms.TextBox()
        Me.txtAppPcode = New System.Windows.Forms.TextBox()
        Me.txtAppTown = New System.Windows.Forms.TextBox()
        Me.txtAppAddress = New System.Windows.Forms.TextBox()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.txtOfficer = New DevExpress.XtraEditors.ButtonEdit()
        Me.cboSector = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnViewOfficers = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDADecision = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.dtRego = New System.Windows.Forms.MaskedTextBox()
        Me.cboAppType = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblOfficer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkSec94 = New System.Windows.Forms.CheckBox()
        Me.txtFileNo = New System.Windows.Forms.TextBox()
        Me.txtCCno = New System.Windows.Forms.TextBox()
        Me.txtDANo = New System.Windows.Forms.TextBox()
        Me.tpgFees = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayFees = New DevExpress.XtraEditors.PanelControl()
        Me.btnRemoveRefund = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditRefund = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddRefund = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.grdDARefundsPaid = New DevExpress.XtraGrid.GridControl()
        Me.gvwDARefundsPaid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefundPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefundIDX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtReceipts = New System.Windows.Forms.TextBox()
        Me.txtRefunds = New System.Windows.Forms.TextBox()
        Me.btnRemoveFee = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditPayment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddFee = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPaymentsReceived = New DevExpress.XtraGrid.GridControl()
        Me.gvwPaymentsReceived = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecdpayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiptNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInspectionPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInspTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tpgSection68 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplaySect68IntDev = New DevExpress.XtraEditors.PanelControl()
        Me.grpSepp71 = New DevExpress.XtraEditors.PanelControl()
        Me.cboDesignatedYN = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboIntDevYN = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.grp68 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemove68 = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSection68 = New DevExpress.XtraGrid.GridControl()
        Me.gvwSection68 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lupSection68 = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnInsert68 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox9 = New DevExpress.XtraEditors.GroupControl()
        Me.grdIntDev = New DevExpress.XtraGrid.GridControl()
        Me.gvwIntDev = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTheAct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSetIntDevDate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMaitList = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveIntDev = New DevExpress.XtraEditors.SimpleButton()
        Me.cboIntDevActs = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAddIntDev = New DevExpress.XtraEditors.SimpleButton()
        Me.mskDateAct = New DevExpress.XtraEditors.DateEdit()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpgReferrals = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayReferrals = New DevExpress.XtraEditors.PanelControl()
        Me.grpMain = New DevExpress.XtraEditors.GroupControl()
        Me.chksepp71 = New DevExpress.XtraEditors.CheckEdit()
        Me.btnRemovePDF = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.lblReferralID = New System.Windows.Forms.Label()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRTA = New DevExpress.XtraEditors.SimpleButton()
        Me.DaysElapsedTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.btnRemoveRefer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveReferralsTab = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditReferralsTab = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddReferral = New DevExpress.XtraEditors.SimpleButton()
        Me.cboRefCodeId = New DevExpress.XtraEditors.LookUpEdit()
        Me.RefRetDt = New DevExpress.XtraEditors.DateEdit()
        Me.Refdt = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.grpIntDesig = New DevExpress.XtraEditors.GroupControl()
        Me.btnAddIntegrated = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveIntegated = New DevExpress.XtraEditors.SimpleButton()
        Me.cboReferralsIntProvision = New DevExpress.XtraEditors.LookUpEdit()
        Me.lstIntegrated = New System.Windows.Forms.ListBox()
        Me.grpRFS = New DevExpress.XtraEditors.GroupControl()
        Me.txtRFSSubLots = New DevExpress.XtraEditors.TextEdit()
        Me.btnPrintRFSSub = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintRFSOther = New DevExpress.XtraEditors.SimpleButton()
        Me.cboRFSSubDivisionType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.grpEngineers = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl()
        Me.EngDueReturnDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtEngInternalComments = New DevExpress.XtraEditors.TextEdit()
        Me.txtRefComm = New DevExpress.XtraEditors.TextEdit()
        Me.pnlButtons = New DevExpress.XtraEditors.PanelControl()
        Me.btnMailResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReferral = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDraftconditions = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvLoadListReferrals = New DevExpress.XtraGrid.GridControl()
        Me.gvwLoadListReferrals = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReferralId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefdt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferralCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRefResponse = New DevExpress.XtraEditors.MemoEdit()
        Me.tpgStatus = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayStatus = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSaveDesignatedText = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModifyDesignatedText = New DevExpress.XtraEditors.SimpleButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDesignatedText = New DevExpress.XtraEditors.MemoEdit()
        Me.btnSaveDeptPlanning = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModifyDeptPlanning = New DevExpress.XtraEditors.SimpleButton()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDepartPlanning = New DevExpress.XtraEditors.MemoEdit()
        Me.btnModifyAdvertAddress = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAdvertSignIntDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDepotAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.btnDesignIntegr = New DevExpress.XtraEditors.SimpleButton()
        Me.cboAdvertSignDepot = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnDesignated = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintAdvNotice = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintAdvert = New DevExpress.XtraEditors.SimpleButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.btnMapMerge = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveStatus = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditStatus = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox18 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDaysTaken = New System.Windows.Forms.TextBox()
        Me.txtDaysElapsed = New System.Windows.Forms.TextBox()
        Me.txtDaysAddinfo = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.lblReferralCount = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.grpAssessment = New DevExpress.XtraEditors.GroupControl()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.DAToTypingDt = New DevExpress.XtraEditors.DateEdit()
        Me.DAToPlannerDt = New DevExpress.XtraEditors.DateEdit()
        Me.DASiteInspectedDt = New DevExpress.XtraEditors.DateEdit()
        Me.PreAssessCompleteDate = New DevExpress.XtraEditors.DateEdit()
        Me.RefToPlanCom = New DevExpress.XtraEditors.DateEdit()
        Me.grpNotification = New DevExpress.XtraEditors.GroupControl()
        Me.DACompletedDt = New DevExpress.XtraEditors.DateEdit()
        Me.rbNotifyAdvert = New System.Windows.Forms.RadioButton()
        Me.DACommDt = New DevExpress.XtraEditors.DateEdit()
        Me.rbNotify = New System.Windows.Forms.RadioButton()
        Me.DAAdvisedDt = New DevExpress.XtraEditors.DateEdit()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.grpDetermination = New DevExpress.XtraEditors.GroupControl()
        Me.DAPermExDt = New DevExpress.XtraEditors.DateEdit()
        Me.cboProgressCode = New DevExpress.XtraEditors.LookUpEdit()
        Me.DAOccDt = New DevExpress.XtraEditors.DateEdit()
        Me.cboReasonOver40 = New DevExpress.XtraEditors.LookUpEdit()
        Me.DAConsentPubDt = New DevExpress.XtraEditors.DateEdit()
        Me.chkAPZYesNo = New System.Windows.Forms.CheckBox()
        Me.cboDADecisionId = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAAuthorityId = New DevExpress.XtraEditors.LookUpEdit()
        Me.DAFreeTreeDt = New DevExpress.XtraEditors.DateEdit()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.ConsentPostedDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.DAAppNotDt = New DevExpress.XtraEditors.DateEdit()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.DADetermDt = New DevExpress.XtraEditors.DateEdit()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtProgressComment = New System.Windows.Forms.TextBox()
        Me.tpgDocuments = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayDocs = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox32 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSaveTheNote = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewWord = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDocumentsList = New DevExpress.XtraGrid.GridControl()
        Me.gvwDocumentsList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colApNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateCreated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocnotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocMTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocYr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWORDDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.txtDocNote = New System.Windows.Forms.TextBox()
        Me.tpgVariations = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayVariations = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox28 = New DevExpress.XtraEditors.GroupControl()
        Me.grdVariations = New DevExpress.XtraGrid.GridControl()
        Me.gvwVariations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVarID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariationdetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colVariationResultDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colDelegatedAuthority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDecisionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserStamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboVariationAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVariationResult = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSaveVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.btneditVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.variationDecisionDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.cboVariationType = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRemoveVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddNewVariationType = New DevExpress.XtraEditors.SimpleButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.txtVariationDetails = New System.Windows.Forms.TextBox()
        Me.tpgSubmissions = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplaySubmisions = New DevExpress.XtraEditors.PanelControl()
        Me.DACompletedDtLabel2 = New System.Windows.Forms.Label()
        Me.GroupBox30 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEmailAcknowledgement = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFinaliseSubmission = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteSubmission = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditSubmision = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSubmissionDrafts = New DevExpress.XtraGrid.GridControl()
        Me.gvwSubmissionDrafts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSubmissionandObjections = New DevExpress.XtraGrid.GridControl()
        Me.gvwSubmissionandObjections = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.chkUseEmail = New DevExpress.XtraEditors.CheckEdit()
        Me.btnRemoveSub = New DevExpress.XtraEditors.SimpleButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtAuthorEmail = New System.Windows.Forms.TextBox()
        Me.btnSaveSub = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditSub = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddSub = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSubmissionType = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAckSub = New DevExpress.XtraEditors.SimpleButton()
        Me.SubRecdDate = New DevExpress.XtraEditors.DateEdit()
        Me.chkSubGift = New System.Windows.Forms.CheckBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.txtOfficerComment = New System.Windows.Forms.TextBox()
        Me.txtSubmissionSummary = New System.Windows.Forms.TextBox()
        Me.txtAuthorPhone = New System.Windows.Forms.TextBox()
        Me.txtAuthorTown = New System.Windows.Forms.TextBox()
        Me.txtAuthorPCode = New System.Windows.Forms.TextBox()
        Me.txtAuthurAddress = New System.Windows.Forms.TextBox()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.lblSubID = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.tpgPCAConditions = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayPCAconditions = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox36 = New DevExpress.XtraEditors.GroupControl()
        Me.btnOneOffCondDone = New DevExpress.XtraEditors.SimpleButton()
        Me.grdOneOffConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwOneOffConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOneOffUniqueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOneOffCondCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConditionalText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colOneOffCCMetDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox35 = New DevExpress.XtraEditors.GroupControl()
        Me.btnStdCondDone = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSTDCond = New DevExpress.XtraGrid.GridControl()
        Me.gvwSTDCond = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAppCondId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdCondCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdCCMetDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tpgFileNotes = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayFileNotes = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.grdFileNotes = New DevExpress.XtraGrid.GridControl()
        Me.gvwFileNotes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFileNoteType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colContactNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpFileNotes = New DevExpress.XtraEditors.GroupControl()
        Me.cboNotesOfficer = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboNoteType = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSaveNote = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditNote = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddNote = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNotePrint = New DevExpress.XtraEditors.SimpleButton()
        Me.NoteDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblNotesID = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.txtNotesSubject = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.txtNotesReferredTo = New System.Windows.Forms.TextBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.txtNotesFollowUp = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.txtNotesCC = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.txtNotesContactNo = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.txtNotesSpokeTo = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.txtNoteDetails = New System.Windows.Forms.TextBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.tpgBuildLetters = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlBuildLetters = New DevExpress.XtraEditors.PanelControl()
        Me.btnAddDefaultCondition = New DevExpress.XtraEditors.SimpleButton()
        Me.cboAssessmentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSaveConsent = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsertIntoLive = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCreateOtherLetter = New DevExpress.XtraEditors.SimpleButton()
        Me.cboOtherDocs = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAssembleLetter = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEditCondition = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveOneOffCond = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddOneOffCond = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvOneUpConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwOneUpConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUniqueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConditionCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConditionText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemoveCondition = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddCondition = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvSTDConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwSTDConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.costdlId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdCondition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreeFormInserts = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSTDconditions = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.cboConsentDocType = New DevExpress.XtraEditors.LookUpEdit()
        Me.ConsentPlanNumberTextBox = New System.Windows.Forms.TextBox()
        Me.grpLetters = New DevExpress.XtraEditors.GroupControl()
        Me.btnEmailAcknowledge = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFinaliseDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewEditDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDraftDocs = New DevExpress.XtraGrid.GridControl()
        Me.gvwDraftDocs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAppNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDraftDocPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDraftDocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tpgAssociated = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayAssociatedApps = New DevExpress.XtraEditors.PanelControl()
        Me.grdAssociatedApps = New DevExpress.XtraGrid.GridControl()
        Me.gvwAssociatedApps = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAssocAppNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRegistered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypeOf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssocDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssocDADecision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tpgEnlighten = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayEnlighten = New DevExpress.XtraEditors.PanelControl()
        Me.btnClearEnlightenMap = New System.Windows.Forms.Button()
        Me.btnSaveEnlighten = New System.Windows.Forms.Button()
        Me.btnInsertEnlightenMap = New System.Windows.Forms.Button()
        Me.picEnlightenMap = New System.Windows.Forms.PictureBox()
        Me.pnlSearch = New DevExpress.XtraEditors.PanelControl()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblapplicationNo = New System.Windows.Forms.Label()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.mskEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.mskStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnAddExistingRecordDocument = New DevExpress.XtraEditors.SimpleButton()
        CurrentLandUseLabel = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        OfficerLabel = New System.Windows.Forms.Label()
        CoPCAnameLabel = New System.Windows.Forms.Label()
        DADecisionLabel = New System.Windows.Forms.Label()
        CCAppNoLabel = New System.Windows.Forms.Label()
        DACompletedDtLabel1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ConsentPlanNumberLabel = New System.Windows.Forms.Label()
        CType(Me.tabPanels,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPanels.SuspendLayout
        Me.tpgApplication.SuspendLayout
        CType(Me.pnlApplicationData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlApplicationData.SuspendLayout
        CType(Me.grpBasix,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpBasix.SuspendLayout
        CType(Me.grpFileNumber,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFileNumber.SuspendLayout
        CType(Me.grpOwner,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpOwner.SuspendLayout
        CType(Me.grpAdditional,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpAdditional.SuspendLayout
        CType(Me.cboDAClass2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAClass1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAClass3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAtype1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAtype3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAType2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpPurpose,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpPurpose.SuspendLayout
        CType(Me.grpDescription,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpDescription.SuspendLayout
        CType(Me.lupOccupancyStatus.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAClass.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAttachmentStatus.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDemolishedDwelings.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtExistingDwelings.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboIntendedLandUse.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudDwellings.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboBuildingType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboConsentType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDevUse.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDevType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpLand,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpLand.SuspendLayout
        Me.GroupBox21.SuspendLayout
        CType(Me.grdPIN,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwPIN,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RibbonControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpPropertyLotAddress.SuspendLayout
        CType(Me.cboAreaType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDACensusCode.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAlocalityCode.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpCCSum,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpCCSum.SuspendLayout
        CType(Me.grpDetails,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpDetails.SuspendLayout
        CType(Me.txtOfficer.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboSector.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAppType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgFees.SuspendLayout
        CType(Me.pnlDisplayFees,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayFees.SuspendLayout
        CType(Me.GroupControl6,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl6.SuspendLayout
        CType(Me.grdDARefundsPaid,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwDARefundsPaid,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl4.SuspendLayout
        CType(Me.grdPaymentsReceived,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwPaymentsReceived,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgSection68.SuspendLayout
        CType(Me.pnlDisplaySect68IntDev,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplaySect68IntDev.SuspendLayout
        CType(Me.grpSepp71,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpSepp71.SuspendLayout
        CType(Me.cboDesignatedYN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboIntDevYN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grp68,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp68.SuspendLayout
        CType(Me.grdSection68,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwSection68,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lupSection68.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupBox9,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox9.SuspendLayout
        CType(Me.grdIntDev,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwIntDev,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboIntDevActs.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mskDateAct.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mskDateAct.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgReferrals.SuspendLayout
        CType(Me.pnlDisplayReferrals,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayReferrals.SuspendLayout
        CType(Me.grpMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpMain.SuspendLayout
        CType(Me.chksepp71.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DaysElapsedTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRefCodeId.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RefRetDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RefRetDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Refdt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Refdt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpIntDesig,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpIntDesig.SuspendLayout
        CType(Me.cboReferralsIntProvision.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpRFS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpRFS.SuspendLayout
        CType(Me.txtRFSSubLots.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRFSSubDivisionType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpEngineers,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpEngineers.SuspendLayout
        CType(Me.EngDueReturnDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EngDueReturnDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtEngInternalComments.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRefComm.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pnlButtons,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlButtons.SuspendLayout
        CType(Me.dgvLoadListReferrals,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwLoadListReferrals,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRefResponse.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgStatus.SuspendLayout
        CType(Me.pnlDisplayStatus,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayStatus.SuspendLayout
        CType(Me.GroupControl10,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl10.SuspendLayout
        CType(Me.txtDesignatedText.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDepartPlanning.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAdvertSignIntDetails.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDepotAddress.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAdvertSignDepot.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupBox18,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox18.SuspendLayout
        CType(Me.grpAssessment,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpAssessment.SuspendLayout
        CType(Me.DAToTypingDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAToTypingDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAToPlannerDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAToPlannerDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DASiteInspectedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DASiteInspectedDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PreAssessCompleteDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PreAssessCompleteDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RefToPlanCom.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RefToPlanCom.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpNotification,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpNotification.SuspendLayout
        CType(Me.DACompletedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DACompletedDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DACommDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DACommDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAAdvisedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAAdvisedDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpDetermination,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpDetermination.SuspendLayout
        CType(Me.DAPermExDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAPermExDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboProgressCode.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAOccDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAOccDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboReasonOver40.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAConsentPubDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAConsentPubDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDADecisionId.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDAAuthorityId.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAFreeTreeDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAFreeTreeDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsentPostedDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsentPostedDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAAppNotDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DAAppNotDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DADetermDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DADetermDt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgDocuments.SuspendLayout
        CType(Me.pnlDisplayDocs,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayDocs.SuspendLayout
        CType(Me.GroupBox32,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox32.SuspendLayout
        CType(Me.grdDocumentsList,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwDocumentsList,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgVariations.SuspendLayout
        CType(Me.pnlDisplayVariations,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayVariations.SuspendLayout
        CType(Me.GroupBox28,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox28.SuspendLayout
        CType(Me.grdVariations,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwVariations,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit5,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox8.SuspendLayout
        CType(Me.cboVariationAuthority.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboVariationResult.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.variationDecisionDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.variationDecisionDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox29.SuspendLayout
        CType(Me.cboVariationType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgSubmissions.SuspendLayout
        CType(Me.pnlDisplaySubmisions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplaySubmisions.SuspendLayout
        CType(Me.GroupBox30,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox30.SuspendLayout
        CType(Me.GroupControl8,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl8.SuspendLayout
        CType(Me.grdSubmissionDrafts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwSubmissionDrafts,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grdSubmissionandObjections,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwSubmissionandObjections,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox31.SuspendLayout
        CType(Me.chkUseEmail.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboSubmissionType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubRecdDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubRecdDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgPCAConditions.SuspendLayout
        CType(Me.pnlDisplayPCAconditions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayPCAconditions.SuspendLayout
        CType(Me.GroupBox36,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox36.SuspendLayout
        CType(Me.grdOneOffConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwOneOffConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupBox35,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox35.SuspendLayout
        CType(Me.grdSTDCond,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwSTDCond,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgFileNotes.SuspendLayout
        CType(Me.pnlDisplayFileNotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayFileNotes.SuspendLayout
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.GroupControl5,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl5.SuspendLayout
        CType(Me.grdFileNotes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwFileNotes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpFileNotes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFileNotes.SuspendLayout
        CType(Me.cboNotesOfficer.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboNoteType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NoteDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NoteDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgBuildLetters.SuspendLayout
        CType(Me.pnlBuildLetters,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlBuildLetters.SuspendLayout
        CType(Me.cboAssessmentType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.cboOtherDocs.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl9,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl9.SuspendLayout
        CType(Me.dgvOneUpConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwOneUpConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl3.SuspendLayout
        CType(Me.dgvSTDConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwSTDConditions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboSTDconditions.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboConsentDocType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpLetters,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpLetters.SuspendLayout
        CType(Me.grdDraftDocs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwDraftDocs,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgAssociated.SuspendLayout
        CType(Me.pnlDisplayAssociatedApps,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayAssociatedApps.SuspendLayout
        CType(Me.grdAssociatedApps,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwAssociatedApps,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpgEnlighten.SuspendLayout
        CType(Me.pnlDisplayEnlighten,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlDisplayEnlighten.SuspendLayout
        CType(Me.picEnlightenMap,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pnlSearch,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlSearch.SuspendLayout
        Me.grpSearch.SuspendLayout
        CType(Me.mskEndDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mskEndDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mskStartDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mskStartDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CurrentLandUseLabel
        '
        CurrentLandUseLabel.AutoSize = true
        CurrentLandUseLabel.Location = New System.Drawing.Point(1, 193)
        CurrentLandUseLabel.Name = "CurrentLandUseLabel"
        CurrentLandUseLabel.Size = New System.Drawing.Size(69, 13)
        CurrentLandUseLabel.TabIndex = 192
        CurrentLandUseLabel.Text = "Current Use:"
        '
        'Label27
        '
        Label27.AutoSize = true
        Label27.Location = New System.Drawing.Point(364, 257)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(113, 13)
        Label27.TabIndex = 175
        Label27.Text = "Political Gift/Donation:"
        '
        'OfficerLabel
        '
        OfficerLabel.AutoSize = true
        OfficerLabel.Location = New System.Drawing.Point(6, 123)
        OfficerLabel.Name = "OfficerLabel"
        OfficerLabel.Size = New System.Drawing.Size(92, 13)
        OfficerLabel.TabIndex = 6
        OfficerLabel.Text = "C.C. Assigned to:"
        '
        'CoPCAnameLabel
        '
        CoPCAnameLabel.AutoSize = true
        CoPCAnameLabel.Location = New System.Drawing.Point(6, 83)
        CoPCAnameLabel.Name = "CoPCAnameLabel"
        CoPCAnameLabel.Size = New System.Drawing.Size(109, 13)
        CoPCAnameLabel.TabIndex = 4
        CoPCAnameLabel.Text = "Certifying  Authority:"
        '
        'DADecisionLabel
        '
        DADecisionLabel.AutoSize = true
        DADecisionLabel.Location = New System.Drawing.Point(126, 28)
        DADecisionLabel.Name = "DADecisionLabel"
        DADecisionLabel.Size = New System.Drawing.Size(59, 13)
        DADecisionLabel.TabIndex = 2
        DADecisionLabel.Text = "CC Status:"
        '
        'CCAppNoLabel
        '
        CCAppNoLabel.AutoSize = true
        CCAppNoLabel.Location = New System.Drawing.Point(6, 28)
        CCAppNoLabel.Name = "CCAppNoLabel"
        CCAppNoLabel.Size = New System.Drawing.Size(49, 13)
        CCAppNoLabel.TabIndex = 0
        CCAppNoLabel.Text = "C.C. No:"
        '
        'DACompletedDtLabel1
        '
        DACompletedDtLabel1.AutoSize = true
        DACompletedDtLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        DACompletedDtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DACompletedDtLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DACompletedDtLabel1.Location = New System.Drawing.Point(411, 14)
        DACompletedDtLabel1.Name = "DACompletedDtLabel1"
        DACompletedDtLabel1.Size = New System.Drawing.Size(55, 18)
        DACompletedDtLabel1.TabIndex = 5
        DACompletedDtLabel1.Text = "Closes:"
        '
        'Label5
        '
        Label5.AutoSize = true
        Label5.Location = New System.Drawing.Point(734, 155)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(113, 13)
        Label5.TabIndex = 53
        Label5.Text = "Political Gift/Donation:"
        '
        'ConsentPlanNumberLabel
        '
        ConsentPlanNumberLabel.AutoSize = true
        ConsentPlanNumberLabel.Location = New System.Drawing.Point(8, 13)
        ConsentPlanNumberLabel.Name = "ConsentPlanNumberLabel"
        ConsentPlanNumberLabel.Size = New System.Drawing.Size(114, 13)
        ConsentPlanNumberLabel.TabIndex = 90
        ConsentPlanNumberLabel.Text = "Consent Plan Number:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "dollar.ico")
        Me.ImageList1.Images.SetKeyName(6, "info.ico")
        Me.ImageList1.Images.SetKeyName(7, "mail.ico")
        Me.ImageList1.Images.SetKeyName(8, "ok.ico")
        Me.ImageList1.Images.SetKeyName(9, "question.ico")
        Me.ImageList1.Images.SetKeyName(10, "resize.ico")
        Me.ImageList1.Images.SetKeyName(11, "Users.ico")
        Me.ImageList1.Images.SetKeyName(12, "Folder.ico")
        Me.ImageList1.Images.SetKeyName(13, "doc.ico")
        Me.ImageList1.Images.SetKeyName(14, "FILES06.ICO")
        Me.ImageList1.Images.SetKeyName(15, "ARW09UP.ICO")
        Me.ImageList1.Images.SetKeyName(16, "MISC44.ICO")
        Me.ImageList1.Images.SetKeyName(17, "Tutorial.ico")
        Me.ImageList1.Images.SetKeyName(18, "Artdesigner-Urban-Stories-Map.ico")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "PowerShot S1 IS.ico")
        Me.ImageList3.Images.SetKeyName(1, "Tips.ico")
        Me.ImageList3.Images.SetKeyName(2, "BINOCULR.ICO")
        Me.ImageList3.Images.SetKeyName(3, "NOTE14.ICO")
        Me.ImageList3.Images.SetKeyName(4, "Printer_OFF.ico")
        Me.ImageList3.Images.SetKeyName(5, "Artdesigner-Urban-Stories-Map.ico")
        Me.ImageList3.Images.SetKeyName(6, "Hire me.ico")
        Me.ImageList3.Images.SetKeyName(7, "Chromatix-Aerial-Work.ico")
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "PowerShot S1 IS.ico")
        Me.ImageList4.Images.SetKeyName(1, "Tips.ico")
        Me.ImageList4.Images.SetKeyName(2, "BINOCULR.ICO")
        Me.ImageList4.Images.SetKeyName(3, "NOTE14.ICO")
        Me.ImageList4.Images.SetKeyName(4, "Printer_OFF.ico")
        Me.ImageList4.Images.SetKeyName(5, "Artdesigner-Urban-Stories-Map.ico")
        Me.ImageList4.Images.SetKeyName(6, "Hire me.ico")
        Me.ImageList4.Images.SetKeyName(7, "Chromatix-Aerial-Work.ico")
        '
        'ImageList5
        '
        Me.ImageList5.ImageStream = CType(resources.GetObject("ImageList5.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList5.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList5.Images.SetKeyName(0, "Camera.ico")
        Me.ImageList5.Images.SetKeyName(1, "Google2.png")
        Me.ImageList5.Images.SetKeyName(2, "CSR.ico")
        Me.ImageList5.Images.SetKeyName(3, "enlighten.ico")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Camera.ico")
        Me.ImageList2.Images.SetKeyName(1, "Google2.png")
        Me.ImageList2.Images.SetKeyName(2, "CSR.ico")
        '
        'imgSmll
        '
        Me.imgSmll.ImageStream = CType(resources.GetObject("imgSmll.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imgSmll.TransparentColor = System.Drawing.Color.Transparent
        Me.imgSmll.Images.SetKeyName(0, "CloseWorkrerquest.ico")
        Me.imgSmll.Images.SetKeyName(1, "TAMS.ico")
        Me.imgSmll.Images.SetKeyName(2, "BINOCULR.ICO")
        '
        'imlNavigation
        '
        Me.imlNavigation.ImageStream = CType(resources.GetObject("imlNavigation.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imlNavigation.TransparentColor = System.Drawing.Color.Transparent
        Me.imlNavigation.Images.SetKeyName(0, "Selection Bar Selected.bmp")
        Me.imlNavigation.Images.SetKeyName(1, "Selection Bar Unselected.bmp")
        Me.imlNavigation.Images.SetKeyName(2, "Selection Bar Highlighted.bmp")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Use"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'tabPanels
        '
        Me.tabPanels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPanels.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.tabPanels.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.tabPanels.Location = New System.Drawing.Point(0, 190)
        Me.tabPanels.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabPanels.Name = "tabPanels"
        Me.tabPanels.SelectedTabPage = Me.tpgApplication
        Me.tabPanels.Size = New System.Drawing.Size(1590, 727)
        Me.tabPanels.TabIndex = 4
        Me.tabPanels.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpgApplication, Me.tpgFees, Me.tpgSection68, Me.tpgReferrals, Me.tpgStatus, Me.tpgDocuments, Me.tpgVariations, Me.tpgSubmissions, Me.tpgPCAConditions, Me.tpgFileNotes, Me.tpgBuildLetters, Me.tpgAssociated, Me.tpgEnlighten})
        '
        'tpgApplication
        '
        Me.tpgApplication.Controls.Add(Me.pnlApplicationData)
        Me.tpgApplication.ImageOptions.Image = CType(resources.GetObject("tpgApplication.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgApplication.Name = "tpgApplication"
        Me.tpgApplication.Size = New System.Drawing.Size(1423, 721)
        Me.tpgApplication.Text = "Application Details"
        '
        'pnlApplicationData
        '
        Me.pnlApplicationData.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlApplicationData.Appearance.Options.UseBackColor = true
        Me.pnlApplicationData.Controls.Add(Me.grpBasix)
        Me.pnlApplicationData.Controls.Add(Me.grpFileNumber)
        Me.pnlApplicationData.Controls.Add(Me.lblDesignated)
        Me.pnlApplicationData.Controls.Add(Me.lblAdvertising)
        Me.pnlApplicationData.Controls.Add(Me.grpOwner)
        Me.pnlApplicationData.Controls.Add(Me.grpAdditional)
        Me.pnlApplicationData.Controls.Add(Me.grpPurpose)
        Me.pnlApplicationData.Controls.Add(Me.grpDescription)
        Me.pnlApplicationData.Controls.Add(Me.grpLand)
        Me.pnlApplicationData.Controls.Add(Me.grpCCSum)
        Me.pnlApplicationData.Controls.Add(Me.grpDetails)
        Me.pnlApplicationData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlApplicationData.Location = New System.Drawing.Point(0, 0)
        Me.pnlApplicationData.Name = "pnlApplicationData"
        Me.pnlApplicationData.Size = New System.Drawing.Size(1423, 721)
        Me.pnlApplicationData.TabIndex = 2
        '
        'grpBasix
        '
        Me.grpBasix.Controls.Add(Me.txtBASIXRcptNo)
        Me.grpBasix.Controls.Add(Me.Label54)
        Me.grpBasix.Controls.Add(Me.chkBASIXRecd)
        Me.grpBasix.Controls.Add(Me.txtBASIXCertNo)
        Me.grpBasix.Controls.Add(Me.Label55)
        Me.grpBasix.Controls.Add(Me.Label56)
        Me.grpBasix.Controls.Add(Me.Label63)
        Me.grpBasix.Controls.Add(Me.Label67)
        Me.grpBasix.Controls.Add(Me.txtBASIXwater)
        Me.grpBasix.Controls.Add(Me.txtBASIXthermal)
        Me.grpBasix.Controls.Add(Me.txtBASIXenergy)
        Me.grpBasix.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpBasix.Location = New System.Drawing.Point(1219, 307)
        Me.grpBasix.Name = "grpBasix"
        Me.grpBasix.Size = New System.Drawing.Size(182, 184)
        Me.grpBasix.TabIndex = 156
        Me.grpBasix.Text = "BASIX"
        '
        'txtBASIXRcptNo
        '
        Me.txtBASIXRcptNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASIXRcptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBASIXRcptNo.Location = New System.Drawing.Point(63, 68)
        Me.txtBASIXRcptNo.Name = "txtBASIXRcptNo"
        Me.txtBASIXRcptNo.ReadOnly = true
        Me.txtBASIXRcptNo.Size = New System.Drawing.Size(81, 21)
        Me.txtBASIXRcptNo.TabIndex = 1
        '
        'Label54
        '
        Me.Label54.AutoSize = true
        Me.Label54.Location = New System.Drawing.Point(4, 73)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(53, 13)
        Me.Label54.TabIndex = 40
        Me.Label54.Text = "Rcpt No.:"
        '
        'chkBASIXRecd
        '
        Me.chkBASIXRecd.AutoSize = true
        Me.chkBASIXRecd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBASIXRecd.Enabled = false
        Me.chkBASIXRecd.Location = New System.Drawing.Point(13, 19)
        Me.chkBASIXRecd.Name = "chkBASIXRecd"
        Me.chkBASIXRecd.Size = New System.Drawing.Size(55, 17)
        Me.chkBASIXRecd.TabIndex = 0
        Me.chkBASIXRecd.Text = "BASIX"
        Me.chkBASIXRecd.UseVisualStyleBackColor = true
        '
        'txtBASIXCertNo
        '
        Me.txtBASIXCertNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASIXCertNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBASIXCertNo.Location = New System.Drawing.Point(63, 42)
        Me.txtBASIXCertNo.Name = "txtBASIXCertNo"
        Me.txtBASIXCertNo.ReadOnly = true
        Me.txtBASIXCertNo.Size = New System.Drawing.Size(81, 21)
        Me.txtBASIXCertNo.TabIndex = 0
        '
        'Label55
        '
        Me.Label55.AutoSize = true
        Me.Label55.Location = New System.Drawing.Point(8, 45)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(52, 13)
        Me.Label55.TabIndex = 35
        Me.Label55.Text = "Cert No.:"
        '
        'Label56
        '
        Me.Label56.AutoSize = true
        Me.Label56.Location = New System.Drawing.Point(14, 148)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(45, 13)
        Me.Label56.TabIndex = 38
        Me.Label56.Text = "Energy:"
        '
        'Label63
        '
        Me.Label63.AutoSize = true
        Me.Label63.Location = New System.Drawing.Point(18, 96)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(41, 13)
        Me.Label63.TabIndex = 36
        Me.Label63.Text = "Water:"
        '
        'Label67
        '
        Me.Label67.AutoSize = true
        Me.Label67.Location = New System.Drawing.Point(9, 122)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(49, 13)
        Me.Label67.TabIndex = 37
        Me.Label67.Text = "Thermal:"
        '
        'txtBASIXwater
        '
        Me.txtBASIXwater.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASIXwater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBASIXwater.Location = New System.Drawing.Point(63, 94)
        Me.txtBASIXwater.Name = "txtBASIXwater"
        Me.txtBASIXwater.ReadOnly = true
        Me.txtBASIXwater.Size = New System.Drawing.Size(46, 21)
        Me.txtBASIXwater.TabIndex = 2
        '
        'txtBASIXthermal
        '
        Me.txtBASIXthermal.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASIXthermal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBASIXthermal.Location = New System.Drawing.Point(63, 120)
        Me.txtBASIXthermal.Name = "txtBASIXthermal"
        Me.txtBASIXthermal.ReadOnly = true
        Me.txtBASIXthermal.Size = New System.Drawing.Size(64, 21)
        Me.txtBASIXthermal.TabIndex = 3
        '
        'txtBASIXenergy
        '
        Me.txtBASIXenergy.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASIXenergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBASIXenergy.Location = New System.Drawing.Point(63, 146)
        Me.txtBASIXenergy.Name = "txtBASIXenergy"
        Me.txtBASIXenergy.ReadOnly = true
        Me.txtBASIXenergy.Size = New System.Drawing.Size(46, 21)
        Me.txtBASIXenergy.TabIndex = 4
        '
        'grpFileNumber
        '
        Me.grpFileNumber.Controls.Add(Me.btnRemoveFile)
        Me.grpFileNumber.Controls.Add(Me.btnAddFile)
        Me.grpFileNumber.Controls.Add(Me.txtFile)
        Me.grpFileNumber.Controls.Add(Me.lstFile)
        Me.grpFileNumber.Controls.Add(Me.Label59)
        Me.grpFileNumber.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpFileNumber.Location = New System.Drawing.Point(1003, 13)
        Me.grpFileNumber.Name = "grpFileNumber"
        Me.grpFileNumber.Size = New System.Drawing.Size(198, 184)
        Me.grpFileNumber.TabIndex = 193
        Me.grpFileNumber.Text = "File Number/s"
        '
        'btnRemoveFile
        '
        Me.btnRemoveFile.ImageOptions.Image = CType(resources.GetObject("btnRemoveFile.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveFile.Location = New System.Drawing.Point(106, 85)
        Me.btnRemoveFile.Name = "btnRemoveFile"
        Me.btnRemoveFile.Size = New System.Drawing.Size(75, 34)
        Me.btnRemoveFile.TabIndex = 28
        Me.btnRemoveFile.Text = "Remove"
        '
        'btnAddFile
        '
        Me.btnAddFile.ImageOptions.Image = CType(resources.GetObject("btnAddFile.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddFile.Location = New System.Drawing.Point(106, 26)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(75, 34)
        Me.btnAddFile.TabIndex = 27
        Me.btnAddFile.Text = "Add"
        '
        'txtFile
        '
        Me.txtFile.AcceptsReturn = true
        Me.txtFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFile.Location = New System.Drawing.Point(10, 149)
        Me.txtFile.MaxLength = 0
        Me.txtFile.Name = "txtFile"
        Me.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFile.Size = New System.Drawing.Size(107, 21)
        Me.txtFile.TabIndex = 23
        Me.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstFile
        '
        Me.lstFile.BackColor = System.Drawing.SystemColors.Window
        Me.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFile.DisplayMember = "FId"
        Me.lstFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFile.Location = New System.Drawing.Point(10, 26)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFile.Size = New System.Drawing.Size(90, 93)
        Me.lstFile.TabIndex = 24
        Me.lstFile.ValueMember = "PBarCode"
        '
        'Label59
        '
        Me.Label59.AutoSize = true
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label59.Location = New System.Drawing.Point(11, 135)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(89, 13)
        Me.Label59.TabIndex = 25
        Me.Label59.Text = "Enter file number"
        '
        'lblDesignated
        '
        Me.lblDesignated.AutoSize = true
        Me.lblDesignated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDesignated.ForeColor = System.Drawing.Color.Red
        Me.lblDesignated.Location = New System.Drawing.Point(1217, 43)
        Me.lblDesignated.Name = "lblDesignated"
        Me.lblDesignated.Size = New System.Drawing.Size(0, 13)
        Me.lblDesignated.TabIndex = 191
        '
        'lblAdvertising
        '
        Me.lblAdvertising.AutoSize = true
        Me.lblAdvertising.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAdvertising.ForeColor = System.Drawing.Color.Blue
        Me.lblAdvertising.Location = New System.Drawing.Point(1217, 19)
        Me.lblAdvertising.Name = "lblAdvertising"
        Me.lblAdvertising.Size = New System.Drawing.Size(0, 15)
        Me.lblAdvertising.TabIndex = 190
        '
        'grpOwner
        '
        Me.grpOwner.Controls.Add(Me.btnUse2)
        Me.grpOwner.Controls.Add(Me.btnKeep2)
        Me.grpOwner.Controls.Add(Me.txtDAOwnersPcode)
        Me.grpOwner.Controls.Add(Me.Label23)
        Me.grpOwner.Controls.Add(Me.Label24)
        Me.grpOwner.Controls.Add(Me.Label25)
        Me.grpOwner.Controls.Add(Me.Label26)
        Me.grpOwner.Controls.Add(Me.txtDAOwnersName)
        Me.grpOwner.Controls.Add(Me.txtDAOwnersAddress)
        Me.grpOwner.Controls.Add(Me.txtDAOwnersTown)
        Me.grpOwner.Controls.Add(Me.txtDAOwnersPhone)
        Me.grpOwner.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpOwner.Location = New System.Drawing.Point(597, 206)
        Me.grpOwner.Name = "grpOwner"
        Me.grpOwner.Size = New System.Drawing.Size(398, 210)
        Me.grpOwner.TabIndex = 159
        Me.grpOwner.Text = "Owners Details"
        '
        'btnUse2
        '
        Me.btnUse2.ImageOptions.Image = CType(resources.GetObject("btnUse2.ImageOptions.Image"),System.Drawing.Image)
        Me.btnUse2.Location = New System.Drawing.Point(338, 108)
        Me.btnUse2.Name = "btnUse2"
        Me.btnUse2.Size = New System.Drawing.Size(59, 31)
        Me.btnUse2.TabIndex = 69
        Me.btnUse2.Text = "Use"
        '
        'btnKeep2
        '
        Me.btnKeep2.ImageOptions.Image = CType(resources.GetObject("btnKeep2.ImageOptions.Image"),System.Drawing.Image)
        Me.btnKeep2.Location = New System.Drawing.Point(338, 38)
        Me.btnKeep2.Name = "btnKeep2"
        Me.btnKeep2.Size = New System.Drawing.Size(59, 31)
        Me.btnKeep2.TabIndex = 68
        Me.btnKeep2.Text = "&Keep"
        '
        'txtDAOwnersPcode
        '
        Me.txtDAOwnersPcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAOwnersPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAOwnersPcode.Location = New System.Drawing.Point(297, 116)
        Me.txtDAOwnersPcode.Name = "txtDAOwnersPcode"
        Me.txtDAOwnersPcode.ReadOnly = true
        Me.txtDAOwnersPcode.Size = New System.Drawing.Size(35, 21)
        Me.txtDAOwnersPcode.TabIndex = 67
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Location = New System.Drawing.Point(5, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Location = New System.Drawing.Point(7, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Address:"
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Location = New System.Drawing.Point(7, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "Town:"
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Location = New System.Drawing.Point(7, 146)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Phone:"
        '
        'txtDAOwnersName
        '
        Me.txtDAOwnersName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.txtDAOwnersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAOwnersName.Location = New System.Drawing.Point(59, 38)
        Me.txtDAOwnersName.Multiline = true
        Me.txtDAOwnersName.Name = "txtDAOwnersName"
        Me.txtDAOwnersName.ReadOnly = true
        Me.txtDAOwnersName.Size = New System.Drawing.Size(273, 38)
        Me.txtDAOwnersName.TabIndex = 59
        '
        'txtDAOwnersAddress
        '
        Me.txtDAOwnersAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAOwnersAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAOwnersAddress.Location = New System.Drawing.Point(59, 75)
        Me.txtDAOwnersAddress.Multiline = true
        Me.txtDAOwnersAddress.Name = "txtDAOwnersAddress"
        Me.txtDAOwnersAddress.ReadOnly = true
        Me.txtDAOwnersAddress.Size = New System.Drawing.Size(273, 42)
        Me.txtDAOwnersAddress.TabIndex = 60
        '
        'txtDAOwnersTown
        '
        Me.txtDAOwnersTown.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAOwnersTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAOwnersTown.Location = New System.Drawing.Point(59, 116)
        Me.txtDAOwnersTown.Name = "txtDAOwnersTown"
        Me.txtDAOwnersTown.ReadOnly = true
        Me.txtDAOwnersTown.Size = New System.Drawing.Size(216, 21)
        Me.txtDAOwnersTown.TabIndex = 61
        '
        'txtDAOwnersPhone
        '
        Me.txtDAOwnersPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAOwnersPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAOwnersPhone.Location = New System.Drawing.Point(59, 142)
        Me.txtDAOwnersPhone.Name = "txtDAOwnersPhone"
        Me.txtDAOwnersPhone.ReadOnly = true
        Me.txtDAOwnersPhone.Size = New System.Drawing.Size(123, 21)
        Me.txtDAOwnersPhone.TabIndex = 62
        '
        'grpAdditional
        '
        Me.grpAdditional.Controls.Add(Me.Label42)
        Me.grpAdditional.Controls.Add(Me.Label41)
        Me.grpAdditional.Controls.Add(Me.Label40)
        Me.grpAdditional.Controls.Add(Me.cboDAClass2)
        Me.grpAdditional.Controls.Add(Me.cboDAClass1)
        Me.grpAdditional.Controls.Add(Me.cboDAClass3)
        Me.grpAdditional.Controls.Add(Me.Label46)
        Me.grpAdditional.Controls.Add(Me.Label45)
        Me.grpAdditional.Controls.Add(Me.Label44)
        Me.grpAdditional.Controls.Add(Me.cboDAtype1)
        Me.grpAdditional.Controls.Add(Me.cboDAtype3)
        Me.grpAdditional.Controls.Add(Me.cboDAType2)
        Me.grpAdditional.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpAdditional.Location = New System.Drawing.Point(1003, 206)
        Me.grpAdditional.Name = "grpAdditional"
        Me.grpAdditional.Size = New System.Drawing.Size(398, 95)
        Me.grpAdditional.TabIndex = 174
        Me.grpAdditional.Text = "Addition Development"
        '
        'Label42
        '
        Me.Label42.AutoSize = true
        Me.Label42.Location = New System.Drawing.Point(261, 68)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(36, 13)
        Me.Label42.TabIndex = 44
        Me.Label42.Text = "Class:"
        Me.Label42.Visible = false
        '
        'Label41
        '
        Me.Label41.AutoSize = true
        Me.Label41.Location = New System.Drawing.Point(261, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(36, 13)
        Me.Label41.TabIndex = 43
        Me.Label41.Text = "Class:"
        Me.Label41.Visible = false
        '
        'Label40
        '
        Me.Label40.AutoSize = true
        Me.Label40.Location = New System.Drawing.Point(261, 28)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(36, 13)
        Me.Label40.TabIndex = 42
        Me.Label40.Text = "Class:"
        Me.Label40.Visible = false
        '
        'cboDAClass2
        '
        Me.cboDAClass2.Location = New System.Drawing.Point(309, 46)
        Me.cboDAClass2.Name = "cboDAClass2"
        Me.cboDAClass2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAClass2.Properties.DisplayMember = "DAClassification"
        Me.cboDAClass2.Properties.NullText = "[Class?]"
        Me.cboDAClass2.Properties.ReadOnly = true
        Me.cboDAClass2.Properties.ValueMember = "DAClassification"
        Me.cboDAClass2.Size = New System.Drawing.Size(67, 20)
        Me.cboDAClass2.TabIndex = 40
        Me.cboDAClass2.Visible = false
        '
        'cboDAClass1
        '
        Me.cboDAClass1.Location = New System.Drawing.Point(309, 26)
        Me.cboDAClass1.Name = "cboDAClass1"
        Me.cboDAClass1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAClass1.Properties.DisplayMember = "DAClassification"
        Me.cboDAClass1.Properties.NullText = "[Class?]"
        Me.cboDAClass1.Properties.ReadOnly = true
        Me.cboDAClass1.Properties.ValueMember = "DAClassification"
        Me.cboDAClass1.Size = New System.Drawing.Size(67, 20)
        Me.cboDAClass1.TabIndex = 39
        Me.cboDAClass1.Visible = false
        '
        'cboDAClass3
        '
        Me.cboDAClass3.Location = New System.Drawing.Point(309, 66)
        Me.cboDAClass3.Name = "cboDAClass3"
        Me.cboDAClass3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAClass3.Properties.DisplayMember = "DAClassification"
        Me.cboDAClass3.Properties.NullText = "[Class?]"
        Me.cboDAClass3.Properties.ReadOnly = true
        Me.cboDAClass3.Properties.ValueMember = "DAClassification"
        Me.cboDAClass3.Size = New System.Drawing.Size(67, 20)
        Me.cboDAClass3.TabIndex = 41
        Me.cboDAClass3.Visible = false
        '
        'Label46
        '
        Me.Label46.AutoSize = true
        Me.Label46.Location = New System.Drawing.Point(16, 49)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(35, 13)
        Me.Label46.TabIndex = 34
        Me.Label46.Text = "Type:"
        '
        'Label45
        '
        Me.Label45.AutoSize = true
        Me.Label45.Location = New System.Drawing.Point(15, 69)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(35, 13)
        Me.Label45.TabIndex = 33
        Me.Label45.Text = "Type:"
        '
        'Label44
        '
        Me.Label44.AutoSize = true
        Me.Label44.Location = New System.Drawing.Point(15, 29)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(35, 13)
        Me.Label44.TabIndex = 32
        Me.Label44.Text = "Type:"
        '
        'cboDAtype1
        '
        Me.cboDAtype1.Location = New System.Drawing.Point(55, 26)
        Me.cboDAtype1.Name = "cboDAtype1"
        Me.cboDAtype1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAtype1.Properties.DisplayMember = "DevType"
        Me.cboDAtype1.Properties.NullText = "[Select Type]"
        Me.cboDAtype1.Properties.ReadOnly = true
        Me.cboDAtype1.Properties.ValueMember = "DevTypeId"
        Me.cboDAtype1.Size = New System.Drawing.Size(196, 20)
        Me.cboDAtype1.TabIndex = 0
        '
        'cboDAtype3
        '
        Me.cboDAtype3.Location = New System.Drawing.Point(55, 66)
        Me.cboDAtype3.Name = "cboDAtype3"
        Me.cboDAtype3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAtype3.Properties.DisplayMember = "DevType"
        Me.cboDAtype3.Properties.NullText = "[Select Type]"
        Me.cboDAtype3.Properties.ReadOnly = true
        Me.cboDAtype3.Properties.ValueMember = "DevTypeId"
        Me.cboDAtype3.Size = New System.Drawing.Size(196, 20)
        Me.cboDAtype3.TabIndex = 2
        '
        'cboDAType2
        '
        Me.cboDAType2.Location = New System.Drawing.Point(55, 46)
        Me.cboDAType2.Name = "cboDAType2"
        Me.cboDAType2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAType2.Properties.DisplayMember = "DevType"
        Me.cboDAType2.Properties.NullText = "[Select Type]"
        Me.cboDAType2.Properties.ReadOnly = true
        Me.cboDAType2.Properties.ValueMember = "DevTypeId"
        Me.cboDAType2.Size = New System.Drawing.Size(196, 20)
        Me.cboDAType2.TabIndex = 1
        '
        'grpPurpose
        '
        Me.grpPurpose.Controls.Add(Me.chkDADesc8)
        Me.grpPurpose.Controls.Add(Me.chkDADesc7)
        Me.grpPurpose.Controls.Add(Me.chkDADesc6)
        Me.grpPurpose.Controls.Add(Me.chkDADesc5)
        Me.grpPurpose.Controls.Add(Me.chkDADesc4)
        Me.grpPurpose.Controls.Add(Me.chkDADesc3)
        Me.grpPurpose.Controls.Add(Me.chkDADesc2)
        Me.grpPurpose.Controls.Add(Me.chkDesc1)
        Me.grpPurpose.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpPurpose.Location = New System.Drawing.Point(1003, 307)
        Me.grpPurpose.Name = "grpPurpose"
        Me.grpPurpose.Size = New System.Drawing.Size(207, 184)
        Me.grpPurpose.TabIndex = 187
        Me.grpPurpose.Text = "Purpose"
        '
        'chkDADesc8
        '
        Me.chkDADesc8.AutoSize = true
        Me.chkDADesc8.Enabled = false
        Me.chkDADesc8.Location = New System.Drawing.Point(8, 167)
        Me.chkDADesc8.Name = "chkDADesc8"
        Me.chkDADesc8.Size = New System.Drawing.Size(54, 17)
        Me.chkDADesc8.TabIndex = 7
        Me.chkDADesc8.Text = "Other"
        Me.chkDADesc8.UseVisualStyleBackColor = true
        '
        'chkDADesc7
        '
        Me.chkDADesc7.AutoSize = true
        Me.chkDADesc7.Enabled = false
        Me.chkDADesc7.Location = New System.Drawing.Point(8, 146)
        Me.chkDADesc7.Name = "chkDADesc7"
        Me.chkDADesc7.Size = New System.Drawing.Size(75, 17)
        Me.chkDADesc7.TabIndex = 6
        Me.chkDADesc7.Text = "Demolition"
        Me.chkDADesc7.UseVisualStyleBackColor = true
        '
        'chkDADesc6
        '
        Me.chkDADesc6.AutoSize = true
        Me.chkDADesc6.Enabled = false
        Me.chkDADesc6.Location = New System.Drawing.Point(8, 126)
        Me.chkDADesc6.Name = "chkDADesc6"
        Me.chkDADesc6.Size = New System.Drawing.Size(171, 17)
        Me.chkDADesc6.TabIndex = 5
        Me.chkDADesc6.Text = "Building Additions / Alterations"
        Me.chkDADesc6.UseVisualStyleBackColor = true
        '
        'chkDADesc5
        '
        Me.chkDADesc5.AutoSize = true
        Me.chkDADesc5.Enabled = false
        Me.chkDADesc5.Location = New System.Drawing.Point(8, 106)
        Me.chkDADesc5.Name = "chkDADesc5"
        Me.chkDADesc5.Size = New System.Drawing.Size(158, 17)
        Me.chkDADesc5.TabIndex = 4
        Me.chkDADesc5.Text = "Subdivision of Land/Building"
        Me.chkDADesc5.UseVisualStyleBackColor = true
        '
        'chkDADesc4
        '
        Me.chkDADesc4.AutoSize = true
        Me.chkDADesc4.Enabled = false
        Me.chkDADesc4.Location = New System.Drawing.Point(8, 86)
        Me.chkDADesc4.Name = "chkDADesc4"
        Me.chkDADesc4.Size = New System.Drawing.Size(116, 17)
        Me.chkDADesc4.TabIndex = 3
        Me.chkDADesc4.Text = "Land Clearing/Dam"
        Me.chkDADesc4.UseVisualStyleBackColor = true
        '
        'chkDADesc3
        '
        Me.chkDADesc3.AutoSize = true
        Me.chkDADesc3.Enabled = false
        Me.chkDADesc3.Location = New System.Drawing.Point(8, 66)
        Me.chkDADesc3.Name = "chkDADesc3"
        Me.chkDADesc3.Size = New System.Drawing.Size(127, 17)
        Me.chkDADesc3.TabIndex = 2
        Me.chkDADesc3.Text = "Carrying out of Work"
        Me.chkDADesc3.UseVisualStyleBackColor = true
        '
        'chkDADesc2
        '
        Me.chkDADesc2.AutoSize = true
        Me.chkDADesc2.Enabled = false
        Me.chkDADesc2.Location = New System.Drawing.Point(8, 46)
        Me.chkDADesc2.Name = "chkDADesc2"
        Me.chkDADesc2.Size = New System.Drawing.Size(117, 17)
        Me.chkDADesc2.TabIndex = 1
        Me.chkDADesc2.Text = "Erection of Building"
        Me.chkDADesc2.UseVisualStyleBackColor = true
        '
        'chkDesc1
        '
        Me.chkDesc1.AutoSize = true
        Me.chkDesc1.Enabled = false
        Me.chkDesc1.Location = New System.Drawing.Point(8, 26)
        Me.chkDesc1.Name = "chkDesc1"
        Me.chkDesc1.Size = New System.Drawing.Size(129, 17)
        Me.chkDesc1.TabIndex = 0
        Me.chkDesc1.Text = "Use of Land / Building"
        Me.chkDesc1.UseVisualStyleBackColor = true
        '
        'grpDescription
        '
        Me.grpDescription.Controls.Add(Me.lupOccupancyStatus)
        Me.grpDescription.Controls.Add(Me.Label39)
        Me.grpDescription.Controls.Add(Me.cboDAClass)
        Me.grpDescription.Controls.Add(Me.lblOccupancy)
        Me.grpDescription.Controls.Add(Me.lblAttachement)
        Me.grpDescription.Controls.Add(Me.cboAttachmentStatus)
        Me.grpDescription.Controls.Add(Me.txtDemolishedDwelings)
        Me.grpDescription.Controls.Add(Me.lblNoDemolishedDwellings)
        Me.grpDescription.Controls.Add(Me.txtExistingDwelings)
        Me.grpDescription.Controls.Add(Me.lblExistingDwellings)
        Me.grpDescription.Controls.Add(Me.Label50)
        Me.grpDescription.Controls.Add(Me.cboIntendedLandUse)
        Me.grpDescription.Controls.Add(Me.nudDwellings)
        Me.grpDescription.Controls.Add(Me.lblNoDwellings)
        Me.grpDescription.Controls.Add(Me.Label43)
        Me.grpDescription.Controls.Add(Me.cboBuildingType)
        Me.grpDescription.Controls.Add(CurrentLandUseLabel)
        Me.grpDescription.Controls.Add(Me.txtCurrentLandUse)
        Me.grpDescription.Controls.Add(Label27)
        Me.grpDescription.Controls.Add(Me.chkGiftDonation)
        Me.grpDescription.Controls.Add(Me.Label94)
        Me.grpDescription.Controls.Add(Me.lblModDesc)
        Me.grpDescription.Controls.Add(Me.Label38)
        Me.grpDescription.Controls.Add(Me.txtModDesc)
        Me.grpDescription.Controls.Add(Me.Label37)
        Me.grpDescription.Controls.Add(Me.Label36)
        Me.grpDescription.Controls.Add(Me.Label35)
        Me.grpDescription.Controls.Add(Me.Label34)
        Me.grpDescription.Controls.Add(Me.txtDAFloor)
        Me.grpDescription.Controls.Add(Me.txtDAestCost)
        Me.grpDescription.Controls.Add(Me.txtDADesc)
        Me.grpDescription.Controls.Add(Me.cboConsentType)
        Me.grpDescription.Controls.Add(Me.cboDevUse)
        Me.grpDescription.Controls.Add(Me.cboDevType)
        Me.grpDescription.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpDescription.Location = New System.Drawing.Point(16, 388)
        Me.grpDescription.Name = "grpDescription"
        Me.grpDescription.Size = New System.Drawing.Size(571, 330)
        Me.grpDescription.TabIndex = 177
        Me.grpDescription.Text = "Description"
        '
        'lupOccupancyStatus
        '
        Me.lupOccupancyStatus.Location = New System.Drawing.Point(473, 117)
        Me.lupOccupancyStatus.Name = "lupOccupancyStatus"
        Me.lupOccupancyStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lupOccupancyStatus.Properties.DisplayMember = "DAClassification"
        Me.lupOccupancyStatus.Properties.NullText = "[Ocupancy?]"
        Me.lupOccupancyStatus.Properties.ReadOnly = true
        Me.lupOccupancyStatus.Properties.ValueMember = "DAClassification"
        Me.lupOccupancyStatus.Size = New System.Drawing.Size(77, 20)
        Me.lupOccupancyStatus.TabIndex = 221
        '
        'Label39
        '
        Me.Label39.AutoSize = true
        Me.Label39.Location = New System.Drawing.Point(364, 98)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(36, 13)
        Me.Label39.TabIndex = 220
        Me.Label39.Text = "Class:"
        Me.Label39.Visible = false
        '
        'cboDAClass
        '
        Me.cboDAClass.Location = New System.Drawing.Point(473, 95)
        Me.cboDAClass.Name = "cboDAClass"
        Me.cboDAClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAClass.Properties.DisplayMember = "DAClassification"
        Me.cboDAClass.Properties.NullText = "[Class?]"
        Me.cboDAClass.Properties.ReadOnly = true
        Me.cboDAClass.Properties.ValueMember = "DAClassification"
        Me.cboDAClass.Size = New System.Drawing.Size(77, 20)
        Me.cboDAClass.TabIndex = 219
        Me.cboDAClass.Visible = false
        '
        'lblOccupancy
        '
        Me.lblOccupancy.AutoSize = true
        Me.lblOccupancy.Location = New System.Drawing.Point(364, 118)
        Me.lblOccupancy.Name = "lblOccupancy"
        Me.lblOccupancy.Size = New System.Drawing.Size(64, 13)
        Me.lblOccupancy.TabIndex = 218
        Me.lblOccupancy.Text = "Occupancy:"
        '
        'lblAttachement
        '
        Me.lblAttachement.AutoSize = true
        Me.lblAttachement.Location = New System.Drawing.Point(1, 113)
        Me.lblAttachement.Name = "lblAttachement"
        Me.lblAttachement.Size = New System.Drawing.Size(101, 13)
        Me.lblAttachement.TabIndex = 216
        Me.lblAttachement.Text = "Attachment Status:"
        '
        'cboAttachmentStatus
        '
        Me.cboAttachmentStatus.Location = New System.Drawing.Point(112, 110)
        Me.cboAttachmentStatus.Name = "cboAttachmentStatus"
        Me.cboAttachmentStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAttachmentStatus.Properties.DisplayMember = "DevUse"
        Me.cboAttachmentStatus.Properties.NullText = "[Select Attachment Type]"
        Me.cboAttachmentStatus.Properties.ReadOnly = true
        Me.cboAttachmentStatus.Properties.ValueMember = "DevUseId"
        Me.cboAttachmentStatus.Size = New System.Drawing.Size(240, 20)
        Me.cboAttachmentStatus.TabIndex = 215
        '
        'txtDemolishedDwelings
        '
        Me.txtDemolishedDwelings.Location = New System.Drawing.Point(506, 72)
        Me.txtDemolishedDwelings.Name = "txtDemolishedDwelings"
        Me.txtDemolishedDwelings.Properties.Appearance.Options.UseTextOptions = true
        Me.txtDemolishedDwelings.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDemolishedDwelings.Properties.Mask.EditMask = "d"
        Me.txtDemolishedDwelings.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDemolishedDwelings.Properties.ReadOnly = true
        Me.txtDemolishedDwelings.Size = New System.Drawing.Size(44, 20)
        Me.txtDemolishedDwelings.TabIndex = 214
        '
        'lblNoDemolishedDwellings
        '
        Me.lblNoDemolishedDwellings.AutoSize = true
        Me.lblNoDemolishedDwellings.Location = New System.Drawing.Point(364, 75)
        Me.lblNoDemolishedDwellings.Name = "lblNoDemolishedDwellings"
        Me.lblNoDemolishedDwellings.Size = New System.Drawing.Size(140, 13)
        Me.lblNoDemolishedDwellings.TabIndex = 213
        Me.lblNoDemolishedDwellings.Text = "No. of dwellings Demolished"
        '
        'txtExistingDwelings
        '
        Me.txtExistingDwelings.Location = New System.Drawing.Point(506, 49)
        Me.txtExistingDwelings.Name = "txtExistingDwelings"
        Me.txtExistingDwelings.Properties.Appearance.Options.UseTextOptions = true
        Me.txtExistingDwelings.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtExistingDwelings.Properties.Mask.EditMask = "d"
        Me.txtExistingDwelings.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExistingDwelings.Properties.ReadOnly = true
        Me.txtExistingDwelings.Size = New System.Drawing.Size(44, 20)
        Me.txtExistingDwelings.TabIndex = 212
        '
        'lblExistingDwellings
        '
        Me.lblExistingDwellings.AutoSize = true
        Me.lblExistingDwellings.Location = New System.Drawing.Point(364, 52)
        Me.lblExistingDwellings.Name = "lblExistingDwellings"
        Me.lblExistingDwellings.Size = New System.Drawing.Size(123, 13)
        Me.lblExistingDwellings.TabIndex = 211
        Me.lblExistingDwellings.Text = "No. of Existing dwellings"
        '
        'Label50
        '
        Me.Label50.AutoSize = true
        Me.Label50.Location = New System.Drawing.Point(1, 92)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(102, 13)
        Me.Label50.TabIndex = 210
        Me.Label50.Text = "Intended Land Use:"
        '
        'cboIntendedLandUse
        '
        Me.cboIntendedLandUse.Location = New System.Drawing.Point(112, 89)
        Me.cboIntendedLandUse.Name = "cboIntendedLandUse"
        Me.cboIntendedLandUse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIntendedLandUse.Properties.DisplayMember = "DevUse"
        Me.cboIntendedLandUse.Properties.NullText = "[Select Intended Use]"
        Me.cboIntendedLandUse.Properties.ReadOnly = true
        Me.cboIntendedLandUse.Properties.ValueMember = "DevUseId"
        Me.cboIntendedLandUse.Size = New System.Drawing.Size(240, 20)
        Me.cboIntendedLandUse.TabIndex = 209
        '
        'nudDwellings
        '
        Me.nudDwellings.Location = New System.Drawing.Point(506, 26)
        Me.nudDwellings.Name = "nudDwellings"
        Me.nudDwellings.Properties.Appearance.Options.UseTextOptions = true
        Me.nudDwellings.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nudDwellings.Properties.Mask.EditMask = "d"
        Me.nudDwellings.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.nudDwellings.Properties.ReadOnly = true
        Me.nudDwellings.Size = New System.Drawing.Size(44, 20)
        Me.nudDwellings.TabIndex = 208
        '
        'lblNoDwellings
        '
        Me.lblNoDwellings.AutoSize = true
        Me.lblNoDwellings.Location = New System.Drawing.Point(364, 29)
        Me.lblNoDwellings.Name = "lblNoDwellings"
        Me.lblNoDwellings.Size = New System.Drawing.Size(125, 13)
        Me.lblNoDwellings.TabIndex = 207
        Me.lblNoDwellings.Text = "No. of dwellings Created"
        '
        'Label43
        '
        Me.Label43.AutoSize = true
        Me.Label43.Location = New System.Drawing.Point(1, 71)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(87, 13)
        Me.Label43.TabIndex = 195
        Me.Label43.Text = "Type of Building:"
        '
        'cboBuildingType
        '
        Me.cboBuildingType.Location = New System.Drawing.Point(112, 68)
        Me.cboBuildingType.Name = "cboBuildingType"
        Me.cboBuildingType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuildingType.Properties.DisplayMember = "DevUse"
        Me.cboBuildingType.Properties.NullText = "[Select Type of Building]"
        Me.cboBuildingType.Properties.ReadOnly = true
        Me.cboBuildingType.Properties.ValueMember = "DevUseId"
        Me.cboBuildingType.Size = New System.Drawing.Size(240, 20)
        Me.cboBuildingType.TabIndex = 194
        '
        'txtCurrentLandUse
        '
        Me.txtCurrentLandUse.BackColor = System.Drawing.SystemColors.Info
        Me.txtCurrentLandUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentLandUse.Location = New System.Drawing.Point(112, 191)
        Me.txtCurrentLandUse.MaxLength = 225
        Me.txtCurrentLandUse.Name = "txtCurrentLandUse"
        Me.txtCurrentLandUse.ReadOnly = true
        Me.txtCurrentLandUse.Size = New System.Drawing.Size(450, 21)
        Me.txtCurrentLandUse.TabIndex = 193
        '
        'chkGiftDonation
        '
        Me.chkGiftDonation.Enabled = false
        Me.chkGiftDonation.Location = New System.Drawing.Point(543, 254)
        Me.chkGiftDonation.Name = "chkGiftDonation"
        Me.chkGiftDonation.Size = New System.Drawing.Size(19, 21)
        Me.chkGiftDonation.TabIndex = 12
        '
        'Label94
        '
        Me.Label94.AutoSize = true
        Me.Label94.Location = New System.Drawing.Point(388, 224)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(95, 13)
        Me.Label94.TabIndex = 173
        Me.Label94.Text = "Floor Space Ratio:"
        '
        'lblModDesc
        '
        Me.lblModDesc.Location = New System.Drawing.Point(1, 284)
        Me.lblModDesc.Name = "lblModDesc"
        Me.lblModDesc.Size = New System.Drawing.Size(76, 43)
        Me.lblModDesc.TabIndex = 189
        Me.lblModDesc.Text = "Description of Modifications:"
        Me.lblModDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblModDesc.Visible = false
        '
        'Label38
        '
        Me.Label38.AutoSize = true
        Me.Label38.Location = New System.Drawing.Point(1, 258)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 13)
        Me.Label38.TabIndex = 171
        Me.Label38.Text = "Consent Type:"
        '
        'txtModDesc
        '
        Me.txtModDesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtModDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModDesc.Location = New System.Drawing.Point(111, 282)
        Me.txtModDesc.Multiline = true
        Me.txtModDesc.Name = "txtModDesc"
        Me.txtModDesc.ReadOnly = true
        Me.txtModDesc.Size = New System.Drawing.Size(451, 43)
        Me.txtModDesc.TabIndex = 0
        Me.txtModDesc.Visible = false
        '
        'Label37
        '
        Me.Label37.AutoSize = true
        Me.Label37.Location = New System.Drawing.Point(1, 222)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(83, 13)
        Me.Label37.TabIndex = 170
        Me.Label37.Text = "Estimated Cost:"
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Location = New System.Drawing.Point(1, 150)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 13)
        Me.Label36.TabIndex = 169
        Me.Label36.Text = "Description:"
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Location = New System.Drawing.Point(1, 50)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(29, 13)
        Me.Label35.TabIndex = 168
        Me.Label35.Text = "Use:"
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Location = New System.Drawing.Point(1, 29)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 13)
        Me.Label34.TabIndex = 167
        Me.Label34.Text = "Type:"
        '
        'txtDAFloor
        '
        Me.txtDAFloor.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAFloor.Location = New System.Drawing.Point(489, 220)
        Me.txtDAFloor.Name = "txtDAFloor"
        Me.txtDAFloor.ReadOnly = true
        Me.txtDAFloor.Size = New System.Drawing.Size(73, 21)
        Me.txtDAFloor.TabIndex = 11
        '
        'txtDAestCost
        '
        Me.txtDAestCost.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAestCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAestCost.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDAestCost.Location = New System.Drawing.Point(112, 218)
        Me.txtDAestCost.Name = "txtDAestCost"
        Me.txtDAestCost.ReadOnly = true
        Me.txtDAestCost.Size = New System.Drawing.Size(134, 31)
        Me.txtDAestCost.TabIndex = 9
        Me.txtDAestCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDADesc
        '
        Me.txtDADesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtDADesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDADesc.Location = New System.Drawing.Point(112, 143)
        Me.txtDADesc.Multiline = true
        Me.txtDADesc.Name = "txtDADesc"
        Me.txtDADesc.ReadOnly = true
        Me.txtDADesc.Size = New System.Drawing.Size(450, 38)
        Me.txtDADesc.TabIndex = 8
        '
        'cboConsentType
        '
        Me.cboConsentType.Location = New System.Drawing.Point(111, 255)
        Me.cboConsentType.Name = "cboConsentType"
        Me.cboConsentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConsentType.Properties.DisplayMember = "ConsentType"
        Me.cboConsentType.Properties.NullText = "[Select Consent Type]"
        Me.cboConsentType.Properties.ReadOnly = true
        Me.cboConsentType.Properties.ValueMember = "ConsentTypeId"
        Me.cboConsentType.Size = New System.Drawing.Size(240, 20)
        Me.cboConsentType.TabIndex = 10
        '
        'cboDevUse
        '
        Me.cboDevUse.Location = New System.Drawing.Point(112, 47)
        Me.cboDevUse.Name = "cboDevUse"
        Me.cboDevUse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDevUse.Properties.DisplayMember = "DevUse"
        Me.cboDevUse.Properties.NullText = "[Select use]"
        Me.cboDevUse.Properties.ReadOnly = true
        Me.cboDevUse.Properties.ValueMember = "DevUseId"
        Me.cboDevUse.Size = New System.Drawing.Size(240, 20)
        Me.cboDevUse.TabIndex = 6
        '
        'cboDevType
        '
        Me.cboDevType.Location = New System.Drawing.Point(112, 26)
        Me.cboDevType.Name = "cboDevType"
        Me.cboDevType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDevType.Properties.DisplayMember = "DevType"
        Me.cboDevType.Properties.NullText = "[Select Type]"
        Me.cboDevType.Properties.ReadOnly = true
        Me.cboDevType.Properties.ValueMember = "DevTypeId"
        Me.cboDevType.Size = New System.Drawing.Size(240, 20)
        Me.cboDevType.TabIndex = 5
        '
        'grpLand
        '
        Me.grpLand.Controls.Add(Me.GroupBox21)
        Me.grpLand.Controls.Add(Me.grpPropertyLotAddress)
        Me.grpLand.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpLand.Location = New System.Drawing.Point(16, 206)
        Me.grpLand.Name = "grpLand"
        Me.grpLand.Size = New System.Drawing.Size(571, 184)
        Me.grpLand.TabIndex = 159
        Me.grpLand.Text = "Land to develop and Owners details"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.grdPIN)
        Me.GroupBox21.Controls.Add(Me.btnRetrieveProperty)
        Me.GroupBox21.Controls.Add(Me.btnRemovePIN)
        Me.GroupBox21.Controls.Add(Me.btnAddPIN)
        Me.GroupBox21.Location = New System.Drawing.Point(336, 21)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(226, 156)
        Me.GroupBox21.TabIndex = 158
        Me.GroupBox21.TabStop = false
        Me.GroupBox21.Text = "Associated "
        '
        'grdPIN
        '
        Me.grdPIN.Location = New System.Drawing.Point(7, 17)
        Me.grdPIN.MainView = Me.gvwPIN
        Me.grdPIN.MenuManager = Me.RibbonControl
        Me.grdPIN.Name = "grdPIN"
        Me.grdPIN.Size = New System.Drawing.Size(96, 96)
        Me.grdPIN.TabIndex = 31
        Me.grdPIN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPIN})
        '
        'gvwPIN
        '
        Me.gvwPIN.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn19, Me.GridColumn20})
        Me.gvwPIN.GridControl = Me.grdPIN
        Me.gvwPIN.Name = "gvwPIN"
        Me.gvwPIN.OptionsBehavior.Editable = false
        Me.gvwPIN.OptionsBehavior.ReadOnly = true
        Me.gvwPIN.OptionsView.ShowGroupPanel = false
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "PIN"
        Me.GridColumn19.FieldName = "PIN"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = true
        Me.GridColumn19.VisibleIndex = 0
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "CADID"
        Me.GridColumn20.FieldName = "Cadid"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.ibExit, Me.BiSection94, Me.BiCompliance, Me.BiConstructionCert, Me.BiEngineerConsent, Me.BiAssessment, Me.BiMyOSDas, Me.BiAddDA, Me.BiEditDA, Me.BiSaveDA, Me.ibImages, Me.ibOldSystemImages, Me.ibCurrentImages, Me.ibVideos, Me.ibPrintCoverSheet, Me.ibCreateTemplate, Me.ibRptsExit, Me.ibMaintExit, Me.ibOfficers, Me.ibLookupLists, Me.ibSection94Codes, Me.ibSection94RF, Me.ibDevelopmentTypes, Me.ibPCAbuilders, Me.ibAuthorities, Me.ibDAUsers, Me.ibReferralList, Me.ibSEPPcodes, Me.ibDCPtypes, Me.ibDCPGuidlines, Me.ibInspectionTypes, Me.ibStdCondCodes, Me.ibInsuranceCoy, Me.ibConsentAdvert, Me.ibABSStats, Me.ibNavision, Me.ibAppCounters, Me.BarButtonItem4, Me.ibAllResults, Me.ibDAresults, Me.ibCDresults, Me.ibCCresults, Me.ibReports, Me.ibApprovals, Me.ibOfficerAllocations, Me.ibDevelopmentApps, Me.ibConstructionCertificates, Me.ibReferrrals, Me.ibMayoral, Me.ibDAreceived, Me.ibCCreceived, Me.ibOutstandingDA, Me.ibDAdetermined, Me.ibCCdetermined, Me.ibInspections, Me.ibApprovalsByTown, Me.ibOccupByTown, Me.ibSepticByTown, Me.ibAppliByOfficer, Me.ibTotalNoDACC, Me.ibStatutoryTime, Me.ibCCwithoutOC, Me.ibExpiredIOC, Me.ibNumberDwellingsAppd, Me.ibOutstandCC, Me.ibAppdDelegation, Me.ibLTW, Me.ibAverageTime, Me.ibLEPRegister, Me.ibMayoralRecd, Me.ibOSreferrals, Me.ibReferralsByOfficer, Me.ibMayoralDetermined, Me.ibCCOwner, Me.ibCCPCA, Me.ibInspectionByOfficer, Me.ibInspectOfficerAndType, Me.ibInspectOfficerSummary, Me.ibInspectFileNumber, Me.BarButtonItem8, Me.ibAdditionalIfo, Me.ibLinked, Me.ibIntraMaps, Me.ibGoogleMaps, Me.SkinDropDownButtonItem1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 102
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.rpgReports, Me.RibbonPage2})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl.ShowQatLocationSelector = false
        Me.RibbonControl.ShowToolbarCustomizeItem = false
        Me.RibbonControl.Size = New System.Drawing.Size(1590, 143)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = false
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'ibExit
        '
        Me.ibExit.Caption = "Exit"
        Me.ibExit.Id = 1
        Me.ibExit.ImageOptions.Image = CType(resources.GetObject("ibExit.ImageOptions.Image"),System.Drawing.Image)
        Me.ibExit.ImageOptions.LargeImage = CType(resources.GetObject("ibExit.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibExit.Name = "ibExit"
        '
        'BiSection94
        '
        Me.BiSection94.Caption = "Section 94"
        Me.BiSection94.Enabled = false
        Me.BiSection94.Id = 4
        Me.BiSection94.ImageOptions.Image = CType(resources.GetObject("BiSection94.ImageOptions.Image"),System.Drawing.Image)
        Me.BiSection94.ImageOptions.LargeImage = CType(resources.GetObject("BiSection94.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiSection94.Name = "BiSection94"
        '
        'BiCompliance
        '
        Me.BiCompliance.Caption = "Compliance"
        Me.BiCompliance.Enabled = false
        Me.BiCompliance.Id = 5
        Me.BiCompliance.ImageOptions.Image = CType(resources.GetObject("BiCompliance.ImageOptions.Image"),System.Drawing.Image)
        Me.BiCompliance.ImageOptions.LargeImage = CType(resources.GetObject("BiCompliance.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiCompliance.Name = "BiCompliance"
        '
        'BiConstructionCert
        '
        Me.BiConstructionCert.Caption = "Construction Certificate"
        Me.BiConstructionCert.Enabled = false
        Me.BiConstructionCert.Id = 6
        Me.BiConstructionCert.ImageOptions.Image = CType(resources.GetObject("BiConstructionCert.ImageOptions.Image"),System.Drawing.Image)
        Me.BiConstructionCert.ImageOptions.LargeImage = CType(resources.GetObject("BiConstructionCert.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiConstructionCert.Name = "BiConstructionCert"
        '
        'BiEngineerConsent
        '
        Me.BiEngineerConsent.Caption = "Engineer Post Consent"
        Me.BiEngineerConsent.Enabled = false
        Me.BiEngineerConsent.Id = 7
        Me.BiEngineerConsent.ImageOptions.Image = CType(resources.GetObject("BiEngineerConsent.ImageOptions.Image"),System.Drawing.Image)
        Me.BiEngineerConsent.ImageOptions.LargeImage = CType(resources.GetObject("BiEngineerConsent.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiEngineerConsent.Name = "BiEngineerConsent"
        '
        'BiAssessment
        '
        Me.BiAssessment.Caption = "Assessment"
        Me.BiAssessment.Enabled = false
        Me.BiAssessment.Id = 8
        Me.BiAssessment.ImageOptions.Image = CType(resources.GetObject("BiAssessment.ImageOptions.Image"),System.Drawing.Image)
        Me.BiAssessment.ImageOptions.LargeImage = CType(resources.GetObject("BiAssessment.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiAssessment.Name = "BiAssessment"
        '
        'BiMyOSDas
        '
        Me.BiMyOSDas.Caption = "My Outstanding DAs"
        Me.BiMyOSDas.Id = 9
        Me.BiMyOSDas.ImageOptions.Image = CType(resources.GetObject("BiMyOSDas.ImageOptions.Image"),System.Drawing.Image)
        Me.BiMyOSDas.ImageOptions.LargeImage = CType(resources.GetObject("BiMyOSDas.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiMyOSDas.Name = "BiMyOSDas"
        '
        'BiAddDA
        '
        Me.BiAddDA.Caption = "Add DA"
        Me.BiAddDA.Id = 21
        Me.BiAddDA.ImageOptions.Image = CType(resources.GetObject("BiAddDA.ImageOptions.Image"),System.Drawing.Image)
        Me.BiAddDA.ImageOptions.LargeImage = CType(resources.GetObject("BiAddDA.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiAddDA.Name = "BiAddDA"
        '
        'BiEditDA
        '
        Me.BiEditDA.Caption = "Edit DA"
        Me.BiEditDA.Enabled = false
        Me.BiEditDA.Id = 22
        Me.BiEditDA.ImageOptions.Image = CType(resources.GetObject("BiEditDA.ImageOptions.Image"),System.Drawing.Image)
        Me.BiEditDA.ImageOptions.LargeImage = CType(resources.GetObject("BiEditDA.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiEditDA.Name = "BiEditDA"
        '
        'BiSaveDA
        '
        Me.BiSaveDA.Caption = "Save DA"
        Me.BiSaveDA.Enabled = false
        Me.BiSaveDA.Id = 23
        Me.BiSaveDA.ImageOptions.Image = CType(resources.GetObject("BiSaveDA.ImageOptions.Image"),System.Drawing.Image)
        Me.BiSaveDA.ImageOptions.LargeImage = CType(resources.GetObject("BiSaveDA.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BiSaveDA.Name = "BiSaveDA"
        '
        'ibImages
        '
        Me.ibImages.Caption = "Images"
        Me.ibImages.Enabled = false
        Me.ibImages.Id = 24
        Me.ibImages.ImageOptions.Image = CType(resources.GetObject("ibImages.ImageOptions.Image"),System.Drawing.Image)
        Me.ibImages.ImageOptions.LargeImage = CType(resources.GetObject("ibImages.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibImages.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibOldSystemImages), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCurrentImages), New DevExpress.XtraBars.LinkPersistInfo(Me.ibVideos)})
        Me.ibImages.Name = "ibImages"
        '
        'ibOldSystemImages
        '
        Me.ibOldSystemImages.Caption = "Old System Images"
        Me.ibOldSystemImages.Id = 25
        Me.ibOldSystemImages.Name = "ibOldSystemImages"
        '
        'ibCurrentImages
        '
        Me.ibCurrentImages.Caption = "Photos"
        Me.ibCurrentImages.Id = 26
        Me.ibCurrentImages.Name = "ibCurrentImages"
        '
        'ibVideos
        '
        Me.ibVideos.Caption = "Videos"
        Me.ibVideos.Id = 27
        Me.ibVideos.Name = "ibVideos"
        '
        'ibPrintCoverSheet
        '
        Me.ibPrintCoverSheet.Caption = "Print Cover Sheet"
        Me.ibPrintCoverSheet.Id = 28
        Me.ibPrintCoverSheet.ImageOptions.Image = CType(resources.GetObject("ibPrintCoverSheet.ImageOptions.Image"),System.Drawing.Image)
        Me.ibPrintCoverSheet.ImageOptions.LargeImage = CType(resources.GetObject("ibPrintCoverSheet.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibPrintCoverSheet.Name = "ibPrintCoverSheet"
        '
        'ibCreateTemplate
        '
        Me.ibCreateTemplate.Caption = "Create Template"
        Me.ibCreateTemplate.Id = 29
        Me.ibCreateTemplate.ImageOptions.Image = CType(resources.GetObject("ibCreateTemplate.ImageOptions.Image"),System.Drawing.Image)
        Me.ibCreateTemplate.ImageOptions.LargeImage = CType(resources.GetObject("ibCreateTemplate.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibCreateTemplate.Name = "ibCreateTemplate"
        '
        'ibRptsExit
        '
        Me.ibRptsExit.Caption = "Exit"
        Me.ibRptsExit.Id = 30
        Me.ibRptsExit.ImageOptions.Image = CType(resources.GetObject("ibRptsExit.ImageOptions.Image"),System.Drawing.Image)
        Me.ibRptsExit.ImageOptions.LargeImage = CType(resources.GetObject("ibRptsExit.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibRptsExit.Name = "ibRptsExit"
        '
        'ibMaintExit
        '
        Me.ibMaintExit.Caption = "Exit"
        Me.ibMaintExit.Id = 31
        Me.ibMaintExit.ImageOptions.Image = CType(resources.GetObject("ibMaintExit.ImageOptions.Image"),System.Drawing.Image)
        Me.ibMaintExit.ImageOptions.LargeImage = CType(resources.GetObject("ibMaintExit.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibMaintExit.Name = "ibMaintExit"
        '
        'ibOfficers
        '
        Me.ibOfficers.Caption = "Officers"
        Me.ibOfficers.Id = 32
        Me.ibOfficers.ImageOptions.Image = CType(resources.GetObject("ibOfficers.ImageOptions.Image"),System.Drawing.Image)
        Me.ibOfficers.ImageOptions.LargeImage = CType(resources.GetObject("ibOfficers.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibOfficers.Name = "ibOfficers"
        '
        'ibLookupLists
        '
        Me.ibLookupLists.Caption = "Lookup Lists"
        Me.ibLookupLists.Id = 33
        Me.ibLookupLists.ImageOptions.Image = CType(resources.GetObject("ibLookupLists.ImageOptions.Image"),System.Drawing.Image)
        Me.ibLookupLists.ImageOptions.LargeImage = CType(resources.GetObject("ibLookupLists.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibLookupLists.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibDevelopmentTypes), New DevExpress.XtraBars.LinkPersistInfo(Me.ibPCAbuilders), New DevExpress.XtraBars.LinkPersistInfo(Me.ibAuthorities), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDAUsers), New DevExpress.XtraBars.LinkPersistInfo(Me.ibReferralList), New DevExpress.XtraBars.LinkPersistInfo(Me.ibSEPPcodes), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDCPtypes), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDCPGuidlines), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspectionTypes), New DevExpress.XtraBars.LinkPersistInfo(Me.ibStdCondCodes), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInsuranceCoy)})
        Me.ibLookupLists.Name = "ibLookupLists"
        '
        'ibDevelopmentTypes
        '
        Me.ibDevelopmentTypes.Caption = "Development Types"
        Me.ibDevelopmentTypes.Id = 36
        Me.ibDevelopmentTypes.Name = "ibDevelopmentTypes"
        '
        'ibPCAbuilders
        '
        Me.ibPCAbuilders.Caption = "PCA Builders List"
        Me.ibPCAbuilders.Id = 37
        Me.ibPCAbuilders.Name = "ibPCAbuilders"
        '
        'ibAuthorities
        '
        Me.ibAuthorities.Caption = "Authorities"
        Me.ibAuthorities.Id = 38
        Me.ibAuthorities.Name = "ibAuthorities"
        '
        'ibDAUsers
        '
        Me.ibDAUsers.Caption = "DA Users"
        Me.ibDAUsers.Id = 39
        Me.ibDAUsers.Name = "ibDAUsers"
        '
        'ibReferralList
        '
        Me.ibReferralList.Caption = "Referral List"
        Me.ibReferralList.Id = 40
        Me.ibReferralList.Name = "ibReferralList"
        '
        'ibSEPPcodes
        '
        Me.ibSEPPcodes.Caption = "SEPP Codes"
        Me.ibSEPPcodes.Id = 41
        Me.ibSEPPcodes.Name = "ibSEPPcodes"
        '
        'ibDCPtypes
        '
        Me.ibDCPtypes.Caption = "DCP Types"
        Me.ibDCPtypes.Id = 42
        Me.ibDCPtypes.Name = "ibDCPtypes"
        '
        'ibDCPGuidlines
        '
        Me.ibDCPGuidlines.Caption = "DCP Guidlines"
        Me.ibDCPGuidlines.Id = 43
        Me.ibDCPGuidlines.Name = "ibDCPGuidlines"
        '
        'ibInspectionTypes
        '
        Me.ibInspectionTypes.Caption = "Inspection Types"
        Me.ibInspectionTypes.Id = 44
        Me.ibInspectionTypes.Name = "ibInspectionTypes"
        '
        'ibStdCondCodes
        '
        Me.ibStdCondCodes.Caption = "Maintain Standard Condition Codes"
        Me.ibStdCondCodes.Id = 45
        Me.ibStdCondCodes.Name = "ibStdCondCodes"
        '
        'ibInsuranceCoy
        '
        Me.ibInsuranceCoy.Caption = "Maintain Insurance Companies"
        Me.ibInsuranceCoy.Id = 46
        Me.ibInsuranceCoy.Name = "ibInsuranceCoy"
        '
        'ibSection94Codes
        '
        Me.ibSection94Codes.Caption = "Section 94 Codes"
        Me.ibSection94Codes.Id = 34
        Me.ibSection94Codes.ImageOptions.Image = CType(resources.GetObject("ibSection94Codes.ImageOptions.Image"),System.Drawing.Image)
        Me.ibSection94Codes.ImageOptions.LargeImage = CType(resources.GetObject("ibSection94Codes.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibSection94Codes.Name = "ibSection94Codes"
        '
        'ibSection94RF
        '
        Me.ibSection94RF.Caption = "Section 94 RF%"
        Me.ibSection94RF.Id = 35
        Me.ibSection94RF.ImageOptions.LargeImage = CType(resources.GetObject("ibSection94RF.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibSection94RF.Name = "ibSection94RF"
        '
        'ibConsentAdvert
        '
        Me.ibConsentAdvert.Caption = "Consent Advertising List"
        Me.ibConsentAdvert.Id = 47
        Me.ibConsentAdvert.ImageOptions.Image = CType(resources.GetObject("ibConsentAdvert.ImageOptions.Image"),System.Drawing.Image)
        Me.ibConsentAdvert.ImageOptions.LargeImage = CType(resources.GetObject("ibConsentAdvert.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibConsentAdvert.Name = "ibConsentAdvert"
        '
        'ibABSStats
        '
        Me.ibABSStats.Caption = "ABS Stats"
        Me.ibABSStats.Id = 48
        Me.ibABSStats.ImageOptions.Image = CType(resources.GetObject("ibABSStats.ImageOptions.Image"),System.Drawing.Image)
        Me.ibABSStats.ImageOptions.LargeImage = CType(resources.GetObject("ibABSStats.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibABSStats.Name = "ibABSStats"
        '
        'ibNavision
        '
        Me.ibNavision.Caption = "Navision Fee Reconciliation"
        Me.ibNavision.Id = 49
        Me.ibNavision.ImageOptions.Image = CType(resources.GetObject("ibNavision.ImageOptions.Image"),System.Drawing.Image)
        Me.ibNavision.ImageOptions.LargeImage = CType(resources.GetObject("ibNavision.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibNavision.Name = "ibNavision"
        '
        'ibAppCounters
        '
        Me.ibAppCounters.Caption = "Application Counters"
        Me.ibAppCounters.Id = 50
        Me.ibAppCounters.ImageOptions.Image = CType(resources.GetObject("ibAppCounters.ImageOptions.Image"),System.Drawing.Image)
        Me.ibAppCounters.ImageOptions.LargeImage = CType(resources.GetObject("ibAppCounters.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibAppCounters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibAllResults), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDAresults), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCDresults), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCresults)})
        Me.ibAppCounters.Name = "ibAppCounters"
        '
        'ibAllResults
        '
        Me.ibAllResults.Caption = "All Results"
        Me.ibAllResults.Id = 52
        Me.ibAllResults.Name = "ibAllResults"
        '
        'ibDAresults
        '
        Me.ibDAresults.Caption = "DA Results"
        Me.ibDAresults.Id = 53
        Me.ibDAresults.Name = "ibDAresults"
        '
        'ibCDresults
        '
        Me.ibCDresults.Caption = "CD Results"
        Me.ibCDresults.Id = 54
        Me.ibCDresults.Name = "ibCDresults"
        '
        'ibCCresults
        '
        Me.ibCCresults.Caption = "CC Results"
        Me.ibCCresults.Id = 55
        Me.ibCCresults.Name = "ibCCresults"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Application Counters"
        Me.BarButtonItem4.Id = 51
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'ibReports
        '
        Me.ibReports.Caption = "Reports"
        Me.ibReports.Id = 57
        Me.ibReports.ImageOptions.Image = CType(resources.GetObject("ibReports.ImageOptions.Image"),System.Drawing.Image)
        Me.ibReports.ImageOptions.LargeImage = CType(resources.GetObject("ibReports.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibReports.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibApprovals), New DevExpress.XtraBars.LinkPersistInfo(Me.ibOfficerAllocations), New DevExpress.XtraBars.LinkPersistInfo(Me.ibMayoral), New DevExpress.XtraBars.LinkPersistInfo(Me.ibReferrrals), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDAreceived), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCreceived), New DevExpress.XtraBars.LinkPersistInfo(Me.ibOutstandingDA), New DevExpress.XtraBars.LinkPersistInfo(Me.ibDAdetermined), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCdetermined), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspections), New DevExpress.XtraBars.LinkPersistInfo(Me.ibApprovalsByTown), New DevExpress.XtraBars.LinkPersistInfo(Me.ibOccupByTown), New DevExpress.XtraBars.LinkPersistInfo(Me.ibSepticByTown), New DevExpress.XtraBars.LinkPersistInfo(Me.ibAppliByOfficer), New DevExpress.XtraBars.LinkPersistInfo(Me.ibStatutoryTime), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCwithoutOC), New DevExpress.XtraBars.LinkPersistInfo(Me.ibExpiredIOC), New DevExpress.XtraBars.LinkPersistInfo(Me.ibNumberDwellingsAppd), New DevExpress.XtraBars.LinkPersistInfo(Me.ibOutstandCC), New DevExpress.XtraBars.LinkPersistInfo(Me.ibAppdDelegation), New DevExpress.XtraBars.LinkPersistInfo(Me.ibLTW), New DevExpress.XtraBars.LinkPersistInfo(Me.ibAverageTime), New DevExpress.XtraBars.LinkPersistInfo(Me.ibLEPRegister), New DevExpress.XtraBars.LinkPersistInfo(Me.ibTotalNoDACC)})
        Me.ibReports.Name = "ibReports"
        '
        'ibApprovals
        '
        Me.ibApprovals.Caption = "Approvals"
        Me.ibApprovals.Id = 58
        Me.ibApprovals.Name = "ibApprovals"
        '
        'ibOfficerAllocations
        '
        Me.ibOfficerAllocations.Caption = "Officer Allocations"
        Me.ibOfficerAllocations.Id = 59
        Me.ibOfficerAllocations.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibDevelopmentApps), New DevExpress.XtraBars.LinkPersistInfo(Me.ibConstructionCertificates)})
        Me.ibOfficerAllocations.Name = "ibOfficerAllocations"
        '
        'ibDevelopmentApps
        '
        Me.ibDevelopmentApps.Caption = "Development Applications"
        Me.ibDevelopmentApps.Id = 60
        Me.ibDevelopmentApps.Name = "ibDevelopmentApps"
        '
        'ibConstructionCertificates
        '
        Me.ibConstructionCertificates.Caption = "Construction Certificates"
        Me.ibConstructionCertificates.Id = 61
        Me.ibConstructionCertificates.Name = "ibConstructionCertificates"
        '
        'ibMayoral
        '
        Me.ibMayoral.Caption = "Mayoral Reports"
        Me.ibMayoral.Id = 63
        Me.ibMayoral.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibMayoralRecd), New DevExpress.XtraBars.LinkPersistInfo(Me.ibMayoralDetermined)})
        Me.ibMayoral.Name = "ibMayoral"
        '
        'ibMayoralRecd
        '
        Me.ibMayoralRecd.Caption = "Received"
        Me.ibMayoralRecd.Id = 84
        Me.ibMayoralRecd.Name = "ibMayoralRecd"
        '
        'ibMayoralDetermined
        '
        Me.ibMayoralDetermined.Caption = "Determined"
        Me.ibMayoralDetermined.Id = 87
        Me.ibMayoralDetermined.Name = "ibMayoralDetermined"
        '
        'ibReferrrals
        '
        Me.ibReferrrals.Caption = "Referral Reports"
        Me.ibReferrrals.Id = 62
        Me.ibReferrrals.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibOSreferrals), New DevExpress.XtraBars.LinkPersistInfo(Me.ibReferralsByOfficer)})
        Me.ibReferrrals.Name = "ibReferrrals"
        '
        'ibOSreferrals
        '
        Me.ibOSreferrals.Caption = "Outstanding Referrals"
        Me.ibOSreferrals.Id = 85
        Me.ibOSreferrals.Name = "ibOSreferrals"
        '
        'ibReferralsByOfficer
        '
        Me.ibReferralsByOfficer.Caption = "Referrals by Officer and Date"
        Me.ibReferralsByOfficer.Id = 86
        Me.ibReferralsByOfficer.Name = "ibReferralsByOfficer"
        '
        'ibDAreceived
        '
        Me.ibDAreceived.Caption = "DA's Received"
        Me.ibDAreceived.Id = 64
        Me.ibDAreceived.Name = "ibDAreceived"
        '
        'ibCCreceived
        '
        Me.ibCCreceived.Caption = "CC's Received"
        Me.ibCCreceived.Id = 65
        Me.ibCCreceived.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCOwner), New DevExpress.XtraBars.LinkPersistInfo(Me.ibCCPCA)})
        Me.ibCCreceived.Name = "ibCCreceived"
        '
        'ibCCOwner
        '
        Me.ibCCOwner.Caption = "CC's by Property Owner"
        Me.ibCCOwner.Id = 88
        Me.ibCCOwner.Name = "ibCCOwner"
        '
        'ibCCPCA
        '
        Me.ibCCPCA.Caption = "CC's(PCA)"
        Me.ibCCPCA.Id = 89
        Me.ibCCPCA.Name = "ibCCPCA"
        '
        'ibOutstandingDA
        '
        Me.ibOutstandingDA.Caption = "Outstanding DA's"
        Me.ibOutstandingDA.Id = 66
        Me.ibOutstandingDA.Name = "ibOutstandingDA"
        '
        'ibDAdetermined
        '
        Me.ibDAdetermined.Caption = "Determined DA's by Officer"
        Me.ibDAdetermined.Id = 67
        Me.ibDAdetermined.Name = "ibDAdetermined"
        '
        'ibCCdetermined
        '
        Me.ibCCdetermined.Caption = "Determined CC's by Officer"
        Me.ibCCdetermined.Id = 68
        Me.ibCCdetermined.Name = "ibCCdetermined"
        '
        'ibInspections
        '
        Me.ibInspections.Caption = "Inspections"
        Me.ibInspections.Id = 69
        Me.ibInspections.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspectionByOfficer), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspectOfficerAndType), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspectOfficerSummary), New DevExpress.XtraBars.LinkPersistInfo(Me.ibInspectFileNumber)})
        Me.ibInspections.Name = "ibInspections"
        '
        'ibInspectionByOfficer
        '
        Me.ibInspectionByOfficer.Caption = "By Officer"
        Me.ibInspectionByOfficer.Id = 90
        Me.ibInspectionByOfficer.Name = "ibInspectionByOfficer"
        '
        'ibInspectOfficerAndType
        '
        Me.ibInspectOfficerAndType.Caption = "Totals by Officer and Type"
        Me.ibInspectOfficerAndType.Id = 91
        Me.ibInspectOfficerAndType.Name = "ibInspectOfficerAndType"
        Me.ibInspectOfficerAndType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'ibInspectOfficerSummary
        '
        Me.ibInspectOfficerSummary.Caption = "By Officer Summary"
        Me.ibInspectOfficerSummary.Id = 92
        Me.ibInspectOfficerSummary.Name = "ibInspectOfficerSummary"
        Me.ibInspectOfficerSummary.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'ibInspectFileNumber
        '
        Me.ibInspectFileNumber.Caption = "By File Number"
        Me.ibInspectFileNumber.Id = 93
        Me.ibInspectFileNumber.Name = "ibInspectFileNumber"
        Me.ibInspectFileNumber.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'ibApprovalsByTown
        '
        Me.ibApprovalsByTown.Caption = "Approvals by Town and Type"
        Me.ibApprovalsByTown.Id = 70
        Me.ibApprovalsByTown.Name = "ibApprovalsByTown"
        '
        'ibOccupByTown
        '
        Me.ibOccupByTown.Caption = "Occupation Certificates by Town and Type"
        Me.ibOccupByTown.Id = 71
        Me.ibOccupByTown.Name = "ibOccupByTown"
        '
        'ibSepticByTown
        '
        Me.ibSepticByTown.Caption = "Septic Approvals by Town and Type"
        Me.ibSepticByTown.Id = 72
        Me.ibSepticByTown.Name = "ibSepticByTown"
        '
        'ibAppliByOfficer
        '
        Me.ibAppliByOfficer.Caption = "Applications Registered by Officer"
        Me.ibAppliByOfficer.Id = 73
        Me.ibAppliByOfficer.Name = "ibAppliByOfficer"
        '
        'ibStatutoryTime
        '
        Me.ibStatutoryTime.Caption = "Statutory Time %"
        Me.ibStatutoryTime.Id = 75
        Me.ibStatutoryTime.Name = "ibStatutoryTime"
        '
        'ibCCwithoutOC
        '
        Me.ibCCwithoutOC.Caption = "CC without Occuppation Certificate"
        Me.ibCCwithoutOC.Id = 76
        Me.ibCCwithoutOC.Name = "ibCCwithoutOC"
        '
        'ibExpiredIOC
        '
        Me.ibExpiredIOC.Caption = "Expired Interim Occupation Certificates"
        Me.ibExpiredIOC.Id = 77
        Me.ibExpiredIOC.Name = "ibExpiredIOC"
        '
        'ibNumberDwellingsAppd
        '
        Me.ibNumberDwellingsAppd.Caption = "Number of Dwellings Approved"
        Me.ibNumberDwellingsAppd.Id = 78
        Me.ibNumberDwellingsAppd.Name = "ibNumberDwellingsAppd"
        '
        'ibOutstandCC
        '
        Me.ibOutstandCC.Caption = "Outstanding Construction Certificates"
        Me.ibOutstandCC.Id = 79
        Me.ibOutstandCC.Name = "ibOutstandCC"
        '
        'ibAppdDelegation
        '
        Me.ibAppdDelegation.Caption = "Approved under Delegated Authority"
        Me.ibAppdDelegation.Id = 80
        Me.ibAppdDelegation.Name = "ibAppdDelegation"
        '
        'ibLTW
        '
        Me.ibLTW.Caption = "Liquid Trade Waste Applications"
        Me.ibLTW.Id = 81
        Me.ibLTW.Name = "ibLTW"
        '
        'ibAverageTime
        '
        Me.ibAverageTime.Caption = "Average Inspection Times"
        Me.ibAverageTime.Id = 82
        Me.ibAverageTime.Name = "ibAverageTime"
        '
        'ibLEPRegister
        '
        Me.ibLEPRegister.Caption = "LEP Variations Register"
        Me.ibLEPRegister.Id = 83
        Me.ibLEPRegister.Name = "ibLEPRegister"
        '
        'ibTotalNoDACC
        '
        Me.ibTotalNoDACC.Caption = "Total Number of DAs and CCs posted"
        Me.ibTotalNoDACC.Id = 74
        Me.ibTotalNoDACC.Name = "ibTotalNoDACC"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Total DAs and CCs Summary"
        Me.BarButtonItem8.Id = 95
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'ibAdditionalIfo
        '
        Me.ibAdditionalIfo.Caption = "Additional Information"
        Me.ibAdditionalIfo.Id = 96
        Me.ibAdditionalIfo.ImageOptions.Image = CType(resources.GetObject("ibAdditionalIfo.ImageOptions.Image"),System.Drawing.Image)
        Me.ibAdditionalIfo.ImageOptions.LargeImage = CType(resources.GetObject("ibAdditionalIfo.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibAdditionalIfo.Name = "ibAdditionalIfo"
        '
        'ibLinked
        '
        Me.ibLinked.Caption = "Linked Applications"
        Me.ibLinked.Enabled = false
        Me.ibLinked.Id = 98
        Me.ibLinked.ImageOptions.Image = CType(resources.GetObject("ibLinked.ImageOptions.Image"),System.Drawing.Image)
        Me.ibLinked.ImageOptions.LargeImage = CType(resources.GetObject("ibLinked.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.ibLinked.Name = "ibLinked"
        '
        'ibIntraMaps
        '
        Me.ibIntraMaps.Caption = "G.I.S."
        Me.ibIntraMaps.Enabled = false
        Me.ibIntraMaps.Id = 99
        Me.ibIntraMaps.ImageOptions.LargeImage = Global.LookupDevelopmentApplication.My.Resources.Resources.intramaps
        Me.ibIntraMaps.Name = "ibIntraMaps"
        '
        'ibGoogleMaps
        '
        Me.ibGoogleMaps.Caption = "Google Maps"
        Me.ibGoogleMaps.Enabled = false
        Me.ibGoogleMaps.Id = 100
        Me.ibGoogleMaps.ImageOptions.LargeImage = Global.LookupDevelopmentApplication.My.Resources.Resources.Google_Maps_icon
        Me.ibGoogleMaps.Name = "ibGoogleMaps"
        '
        'SkinDropDownButtonItem1
        '
        Me.SkinDropDownButtonItem1.Id = 101
        Me.SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup7})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "File"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = false
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibExit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BiAddDA)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BiEditDA)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BiSaveDA)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibPrintCoverSheet)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibCreateTemplate)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibLinked)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibIntraMaps)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ibGoogleMaps)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = false
        Me.RibbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup1.Text = "Home"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = false
        Me.RibbonPageGroup2.ItemLinks.Add(Me.ibImages)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiSection94)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiCompliance)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiConstructionCert)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiEngineerConsent)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiAssessment)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BiMyOSDas)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.ibAdditionalIfo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = false
        Me.RibbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = false
        Me.RibbonPageGroup7.ItemLinks.Add(Me.SkinDropDownButtonItem1)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = false
        Me.RibbonPageGroup7.Text = "Appearance"
        '
        'rpgReports
        '
        Me.rpgReports.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.rpgReports.Name = "rpgReports"
        Me.rpgReports.Text = "Reports"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = false
        Me.RibbonPageGroup3.ItemLinks.Add(Me.ibRptsExit)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = false
        Me.RibbonPageGroup3.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup3.Text = "Home"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = false
        Me.RibbonPageGroup4.ItemLinks.Add(Me.ibConsentAdvert)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.ibABSStats)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.ibNavision)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.ibAppCounters)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.ibReports)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = false
        Me.RibbonPageGroup4.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup4.Text = "Reports"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Maintenance"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = false
        Me.RibbonPageGroup5.ItemLinks.Add(Me.ibMaintExit)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = false
        Me.RibbonPageGroup5.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup5.Text = "Home"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = false
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ibOfficers)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ibLookupLists)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ibSection94Codes)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ibSection94RF)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = false
        Me.RibbonPageGroup6.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.RibbonPageGroup6.Text = "Actions"
        '
        'btnRetrieveProperty
        '
        Me.btnRetrieveProperty.ImageOptions.Image = CType(resources.GetObject("btnRetrieveProperty.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRetrieveProperty.Location = New System.Drawing.Point(7, 119)
        Me.btnRetrieveProperty.Name = "btnRetrieveProperty"
        Me.btnRetrieveProperty.Size = New System.Drawing.Size(75, 31)
        Me.btnRetrieveProperty.TabIndex = 30
        Me.btnRetrieveProperty.Text = "Retrieve"
        '
        'btnRemovePIN
        '
        Me.btnRemovePIN.ImageOptions.Image = CType(resources.GetObject("btnRemovePIN.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemovePIN.Location = New System.Drawing.Point(139, 45)
        Me.btnRemovePIN.Name = "btnRemovePIN"
        Me.btnRemovePIN.Size = New System.Drawing.Size(75, 23)
        Me.btnRemovePIN.TabIndex = 29
        Me.btnRemovePIN.Text = "Remove"
        '
        'btnAddPIN
        '
        Me.btnAddPIN.ImageOptions.Image = CType(resources.GetObject("btnAddPIN.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddPIN.Location = New System.Drawing.Point(139, 17)
        Me.btnAddPIN.Name = "btnAddPIN"
        Me.btnAddPIN.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPIN.TabIndex = 28
        Me.btnAddPIN.Text = "Add"
        '
        'grpPropertyLotAddress
        '
        Me.grpPropertyLotAddress.Controls.Add(Me.Label22)
        Me.grpPropertyLotAddress.Controls.Add(Me.cboAreaType)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtArea)
        Me.grpPropertyLotAddress.Controls.Add(Me.cboDACensusCode)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label14)
        Me.grpPropertyLotAddress.Controls.Add(Me.cboDAlocalityCode)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtLot)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtDP)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtSection)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtStreetNo)
        Me.grpPropertyLotAddress.Controls.Add(Me.txtStreetName)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label16)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label17)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label21)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label18)
        Me.grpPropertyLotAddress.Controls.Add(Me.Label20)
        Me.grpPropertyLotAddress.Location = New System.Drawing.Point(7, 21)
        Me.grpPropertyLotAddress.Name = "grpPropertyLotAddress"
        Me.grpPropertyLotAddress.Size = New System.Drawing.Size(321, 156)
        Me.grpPropertyLotAddress.TabIndex = 157
        Me.grpPropertyLotAddress.TabStop = false
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(159, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 13)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Area:"
        '
        'cboAreaType
        '
        Me.cboAreaType.Location = New System.Drawing.Point(241, 42)
        Me.cboAreaType.Name = "cboAreaType"
        Me.cboAreaType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAreaType.Properties.NullText = "[Type?]"
        Me.cboAreaType.Properties.ReadOnly = true
        Me.cboAreaType.Size = New System.Drawing.Size(62, 20)
        Me.cboAreaType.TabIndex = 3
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.SystemColors.Info
        Me.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArea.Location = New System.Drawing.Point(193, 42)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = true
        Me.txtArea.Size = New System.Drawing.Size(42, 21)
        Me.txtArea.TabIndex = 29
        '
        'cboDACensusCode
        '
        Me.cboDACensusCode.Location = New System.Drawing.Point(96, 127)
        Me.cboDACensusCode.Name = "cboDACensusCode"
        Me.cboDACensusCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDACensusCode.Properties.DisplayMember = "PNM"
        Me.cboDACensusCode.Properties.ReadOnly = true
        Me.cboDACensusCode.Properties.ValueMember = "PAR"
        Me.cboDACensusCode.Size = New System.Drawing.Size(200, 20)
        Me.cboDACensusCode.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(6, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Census Code:"
        '
        'cboDAlocalityCode
        '
        Me.cboDAlocalityCode.Location = New System.Drawing.Point(61, 99)
        Me.cboDAlocalityCode.Name = "cboDAlocalityCode"
        Me.cboDAlocalityCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAlocalityCode.Properties.DisplayMember = "LocalityCode"
        Me.cboDAlocalityCode.Properties.ReadOnly = true
        Me.cboDAlocalityCode.Properties.ValueMember = "LocalityCodeId"
        Me.cboDAlocalityCode.Size = New System.Drawing.Size(200, 20)
        Me.cboDAlocalityCode.TabIndex = 5
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.SystemColors.Info
        Me.txtLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLot.Location = New System.Drawing.Point(61, 17)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.ReadOnly = true
        Me.txtLot.Size = New System.Drawing.Size(50, 21)
        Me.txtLot.TabIndex = 0
        '
        'txtDP
        '
        Me.txtDP.BackColor = System.Drawing.SystemColors.Info
        Me.txtDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDP.Location = New System.Drawing.Point(147, 17)
        Me.txtDP.Name = "txtDP"
        Me.txtDP.ReadOnly = true
        Me.txtDP.Size = New System.Drawing.Size(119, 21)
        Me.txtDP.TabIndex = 1
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.SystemColors.Info
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Location = New System.Drawing.Point(61, 42)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = true
        Me.txtSection.Size = New System.Drawing.Size(88, 21)
        Me.txtSection.TabIndex = 2
        '
        'txtStreetNo
        '
        Me.txtStreetNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtStreetNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreetNo.Location = New System.Drawing.Point(61, 73)
        Me.txtStreetNo.Name = "txtStreetNo"
        Me.txtStreetNo.ReadOnly = true
        Me.txtStreetNo.Size = New System.Drawing.Size(41, 21)
        Me.txtStreetNo.TabIndex = 4
        '
        'txtStreetName
        '
        Me.txtStreetName.BackColor = System.Drawing.SystemColors.Info
        Me.txtStreetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreetName.Location = New System.Drawing.Point(104, 73)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.ReadOnly = true
        Me.txtStreetName.Size = New System.Drawing.Size(192, 21)
        Me.txtStreetName.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(7, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Lot:"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(115, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "DP:"
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(9, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Locality:"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(7, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Section:"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Location = New System.Drawing.Point(7, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Street:"
        '
        'grpCCSum
        '
        Me.grpCCSum.Controls.Add(Me.lblinsurValue)
        Me.grpCCSum.Controls.Add(Me.lblInsuranceNo)
        Me.grpCCSum.Controls.Add(Me.lblBuilderName)
        Me.grpCCSum.Controls.Add(Me.lblOwnerBuilder)
        Me.grpCCSum.Controls.Add(Me.lblOwnerBuilderNo)
        Me.grpCCSum.Controls.Add(Me.txtCCInsuranceNo)
        Me.grpCCSum.Controls.Add(Me.txtCCLicBuilderName)
        Me.grpCCSum.Controls.Add(Me.txtCCOwnerBuilderNo)
        Me.grpCCSum.Controls.Add(Me.CCValueTextBox)
        Me.grpCCSum.Controls.Add(OfficerLabel)
        Me.grpCCSum.Controls.Add(Me.OfficerTextBox)
        Me.grpCCSum.Controls.Add(CoPCAnameLabel)
        Me.grpCCSum.Controls.Add(Me.CoPCAnameTextBox)
        Me.grpCCSum.Controls.Add(DADecisionLabel)
        Me.grpCCSum.Controls.Add(Me.DADecisionTextBox)
        Me.grpCCSum.Controls.Add(CCAppNoLabel)
        Me.grpCCSum.Controls.Add(Me.CCAppNoTextBox)
        Me.grpCCSum.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.grpCCSum.Location = New System.Drawing.Point(597, 512)
        Me.grpCCSum.Name = "grpCCSum"
        Me.grpCCSum.Size = New System.Drawing.Size(804, 168)
        Me.grpCCSum.TabIndex = 154
        Me.grpCCSum.Text = "Construction Certificate Summary"
        '
        'lblinsurValue
        '
        Me.lblinsurValue.Location = New System.Drawing.Point(541, 99)
        Me.lblinsurValue.Name = "lblinsurValue"
        Me.lblinsurValue.Size = New System.Drawing.Size(30, 13)
        Me.lblinsurValue.TabIndex = 21
        Me.lblinsurValue.Text = "Value:"
        '
        'lblInsuranceNo
        '
        Me.lblInsuranceNo.Location = New System.Drawing.Point(499, 75)
        Me.lblInsuranceNo.Name = "lblInsuranceNo"
        Me.lblInsuranceNo.Size = New System.Drawing.Size(72, 13)
        Me.lblInsuranceNo.TabIndex = 20
        Me.lblInsuranceNo.Text = "Insurance No.:"
        '
        'lblBuilderName
        '
        Me.lblBuilderName.Location = New System.Drawing.Point(467, 51)
        Me.lblBuilderName.Name = "lblBuilderName"
        Me.lblBuilderName.Size = New System.Drawing.Size(104, 13)
        Me.lblBuilderName.TabIndex = 19
        Me.lblBuilderName.Text = "Licence Builder Name:"
        '
        'lblOwnerBuilder
        '
        Me.lblOwnerBuilder.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOwnerBuilder.Appearance.Options.UseFont = true
        Me.lblOwnerBuilder.Location = New System.Drawing.Point(577, 31)
        Me.lblOwnerBuilder.Name = "lblOwnerBuilder"
        Me.lblOwnerBuilder.Size = New System.Drawing.Size(78, 13)
        Me.lblOwnerBuilder.TabIndex = 18
        Me.lblOwnerBuilder.Text = "Owner Builder"
        '
        'lblOwnerBuilderNo
        '
        Me.lblOwnerBuilderNo.Location = New System.Drawing.Point(480, 51)
        Me.lblOwnerBuilderNo.Name = "lblOwnerBuilderNo"
        Me.lblOwnerBuilderNo.Size = New System.Drawing.Size(91, 13)
        Me.lblOwnerBuilderNo.TabIndex = 17
        Me.lblOwnerBuilderNo.Text = "Owner Builder No.:"
        '
        'txtCCInsuranceNo
        '
        Me.txtCCInsuranceNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCCInsuranceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCInsuranceNo.Location = New System.Drawing.Point(577, 73)
        Me.txtCCInsuranceNo.Name = "txtCCInsuranceNo"
        Me.txtCCInsuranceNo.ReadOnly = true
        Me.txtCCInsuranceNo.Size = New System.Drawing.Size(129, 21)
        Me.txtCCInsuranceNo.TabIndex = 6
        '
        'txtCCLicBuilderName
        '
        Me.txtCCLicBuilderName.BackColor = System.Drawing.SystemColors.Info
        Me.txtCCLicBuilderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCLicBuilderName.Location = New System.Drawing.Point(577, 49)
        Me.txtCCLicBuilderName.Name = "txtCCLicBuilderName"
        Me.txtCCLicBuilderName.ReadOnly = true
        Me.txtCCLicBuilderName.Size = New System.Drawing.Size(205, 21)
        Me.txtCCLicBuilderName.TabIndex = 8
        Me.txtCCLicBuilderName.Visible = false
        '
        'txtCCOwnerBuilderNo
        '
        Me.txtCCOwnerBuilderNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCCOwnerBuilderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCOwnerBuilderNo.Location = New System.Drawing.Point(577, 49)
        Me.txtCCOwnerBuilderNo.Name = "txtCCOwnerBuilderNo"
        Me.txtCCOwnerBuilderNo.ReadOnly = true
        Me.txtCCOwnerBuilderNo.Size = New System.Drawing.Size(205, 21)
        Me.txtCCOwnerBuilderNo.TabIndex = 7
        Me.txtCCOwnerBuilderNo.Visible = false
        '
        'CCValueTextBox
        '
        Me.CCValueTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CCValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CCValueTextBox.Location = New System.Drawing.Point(577, 97)
        Me.CCValueTextBox.Name = "CCValueTextBox"
        Me.CCValueTextBox.ReadOnly = true
        Me.CCValueTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CCValueTextBox.TabIndex = 9
        '
        'OfficerTextBox
        '
        Me.OfficerTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.OfficerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OfficerTextBox.Location = New System.Drawing.Point(9, 139)
        Me.OfficerTextBox.Name = "OfficerTextBox"
        Me.OfficerTextBox.ReadOnly = true
        Me.OfficerTextBox.Size = New System.Drawing.Size(379, 21)
        Me.OfficerTextBox.TabIndex = 3
        '
        'CoPCAnameTextBox
        '
        Me.CoPCAnameTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CoPCAnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CoPCAnameTextBox.ForeColor = System.Drawing.Color.Navy
        Me.CoPCAnameTextBox.Location = New System.Drawing.Point(9, 99)
        Me.CoPCAnameTextBox.Name = "CoPCAnameTextBox"
        Me.CoPCAnameTextBox.ReadOnly = true
        Me.CoPCAnameTextBox.Size = New System.Drawing.Size(458, 21)
        Me.CoPCAnameTextBox.TabIndex = 2
        '
        'DADecisionTextBox
        '
        Me.DADecisionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DADecisionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DADecisionTextBox.Location = New System.Drawing.Point(129, 49)
        Me.DADecisionTextBox.Name = "DADecisionTextBox"
        Me.DADecisionTextBox.ReadOnly = true
        Me.DADecisionTextBox.Size = New System.Drawing.Size(221, 21)
        Me.DADecisionTextBox.TabIndex = 1
        '
        'CCAppNoTextBox
        '
        Me.CCAppNoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CCAppNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CCAppNoTextBox.Location = New System.Drawing.Point(9, 49)
        Me.CCAppNoTextBox.Name = "CCAppNoTextBox"
        Me.CCAppNoTextBox.ReadOnly = true
        Me.CCAppNoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CCAppNoTextBox.TabIndex = 0
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.btnUse)
        Me.grpDetails.Controls.Add(Me.btnKeep)
        Me.grpDetails.Controls.Add(Me.Label19)
        Me.grpDetails.Controls.Add(Me.txtAppemail)
        Me.grpDetails.Controls.Add(Me.Label12)
        Me.grpDetails.Controls.Add(Me.Label11)
        Me.grpDetails.Controls.Add(Me.Label9)
        Me.grpDetails.Controls.Add(Me.Label8)
        Me.grpDetails.Controls.Add(Me.txtAppPhone)
        Me.grpDetails.Controls.Add(Me.txtAppPcode)
        Me.grpDetails.Controls.Add(Me.txtAppTown)
        Me.grpDetails.Controls.Add(Me.txtAppAddress)
        Me.grpDetails.Controls.Add(Me.txtAppName)
        Me.grpDetails.Controls.Add(Me.txtOfficer)
        Me.grpDetails.Controls.Add(Me.cboSector)
        Me.grpDetails.Controls.Add(Me.Label33)
        Me.grpDetails.Controls.Add(Me.btnViewOfficers)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.txtDADecision)
        Me.grpDetails.Controls.Add(Me.lblType)
        Me.grpDetails.Controls.Add(Me.dtRego)
        Me.grpDetails.Controls.Add(Me.cboAppType)
        Me.grpDetails.Controls.Add(Me.lblOfficer)
        Me.grpDetails.Controls.Add(Me.Label1)
        Me.grpDetails.Controls.Add(Me.Label6)
        Me.grpDetails.Controls.Add(Me.Label2)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.Label10)
        Me.grpDetails.Controls.Add(Me.chkSec94)
        Me.grpDetails.Controls.Add(Me.txtFileNo)
        Me.grpDetails.Controls.Add(Me.txtCCno)
        Me.grpDetails.Controls.Add(Me.txtDANo)
        Me.grpDetails.Location = New System.Drawing.Point(15, 13)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(980, 183)
        Me.grpDetails.TabIndex = 152
        '
        'btnUse
        '
        Me.btnUse.ImageOptions.Image = CType(resources.GetObject("btnUse.ImageOptions.Image"),System.Drawing.Image)
        Me.btnUse.Location = New System.Drawing.Point(910, 68)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(65, 31)
        Me.btnUse.TabIndex = 188
        Me.btnUse.Text = "Use"
        '
        'btnKeep
        '
        Me.btnKeep.ImageOptions.Image = CType(resources.GetObject("btnKeep.ImageOptions.Image"),System.Drawing.Image)
        Me.btnKeep.Location = New System.Drawing.Point(910, 31)
        Me.btnKeep.Name = "btnKeep"
        Me.btnKeep.Size = New System.Drawing.Size(65, 31)
        Me.btnKeep.TabIndex = 187
        Me.btnKeep.Text = "&Keep"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(575, 156)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 186
        Me.Label19.Text = "E-Mail:"
        '
        'txtAppemail
        '
        Me.txtAppemail.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppemail.Location = New System.Drawing.Point(629, 154)
        Me.txtAppemail.Name = "txtAppemail"
        Me.txtAppemail.ReadOnly = true
        Me.txtAppemail.Size = New System.Drawing.Size(273, 21)
        Me.txtAppemail.TabIndex = 180
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(575, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 185
        Me.Label12.Text = "Phone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(575, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "Town:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(575, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(575, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Name:"
        '
        'txtAppPhone
        '
        Me.txtAppPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPhone.Location = New System.Drawing.Point(629, 132)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.ReadOnly = true
        Me.txtAppPhone.Size = New System.Drawing.Size(192, 21)
        Me.txtAppPhone.TabIndex = 179
        '
        'txtAppPcode
        '
        Me.txtAppPcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPcode.Location = New System.Drawing.Point(863, 110)
        Me.txtAppPcode.Name = "txtAppPcode"
        Me.txtAppPcode.ReadOnly = true
        Me.txtAppPcode.Size = New System.Drawing.Size(39, 21)
        Me.txtAppPcode.TabIndex = 181
        '
        'txtAppTown
        '
        Me.txtAppTown.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppTown.Location = New System.Drawing.Point(629, 110)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.ReadOnly = true
        Me.txtAppTown.Size = New System.Drawing.Size(216, 21)
        Me.txtAppTown.TabIndex = 178
        '
        'txtAppAddress
        '
        Me.txtAppAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppAddress.Location = New System.Drawing.Point(629, 75)
        Me.txtAppAddress.Multiline = true
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.ReadOnly = true
        Me.txtAppAddress.Size = New System.Drawing.Size(273, 36)
        Me.txtAppAddress.TabIndex = 177
        '
        'txtAppName
        '
        Me.txtAppName.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppName.Location = New System.Drawing.Point(629, 31)
        Me.txtAppName.Multiline = true
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.ReadOnly = true
        Me.txtAppName.Size = New System.Drawing.Size(273, 45)
        Me.txtAppName.TabIndex = 176
        '
        'txtOfficer
        '
        Me.txtOfficer.Location = New System.Drawing.Point(287, 128)
        Me.txtOfficer.Name = "txtOfficer"
        Me.txtOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtOfficer.Size = New System.Drawing.Size(181, 20)
        Me.txtOfficer.TabIndex = 158
        '
        'cboSector
        '
        Me.cboSector.Location = New System.Drawing.Point(287, 77)
        Me.cboSector.Name = "cboSector"
        Me.cboSector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSector.Properties.DisplayMember = "DAAppType"
        Me.cboSector.Properties.NullText = "[Select Sector]"
        Me.cboSector.Properties.ReadOnly = true
        Me.cboSector.Properties.ValueMember = "DAAppTypeId"
        Me.cboSector.Size = New System.Drawing.Size(131, 20)
        Me.cboSector.TabIndex = 157
        '
        'Label33
        '
        Me.Label33.AutoSize = true
        Me.Label33.Location = New System.Drawing.Point(235, 82)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 13)
        Me.Label33.TabIndex = 156
        Me.Label33.Text = "Sector:"
        '
        'btnViewOfficers
        '
        Me.btnViewOfficers.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.btnViewOfficers.Appearance.Options.UseForeColor = true
        Me.btnViewOfficers.ImageOptions.Image = CType(resources.GetObject("btnViewOfficers.ImageOptions.Image"),System.Drawing.Image)
        Me.btnViewOfficers.Location = New System.Drawing.Point(474, 126)
        Me.btnViewOfficers.Name = "btnViewOfficers"
        Me.btnViewOfficers.Size = New System.Drawing.Size(61, 23)
        Me.btnViewOfficers.TabIndex = 151
        Me.btnViewOfficers.Text = "View"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(27, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Registered:"
        '
        'txtDADecision
        '
        Me.txtDADecision.BackColor = System.Drawing.SystemColors.Info
        Me.txtDADecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDADecision.Location = New System.Drawing.Point(287, 103)
        Me.txtDADecision.Name = "txtDADecision"
        Me.txtDADecision.ReadOnly = true
        Me.txtDADecision.Size = New System.Drawing.Size(181, 21)
        Me.txtDADecision.TabIndex = 10
        '
        'lblType
        '
        Me.lblType.AutoSize = true
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblType.Location = New System.Drawing.Point(232, 59)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 13)
        Me.lblType.TabIndex = 145
        '
        'dtRego
        '
        Me.dtRego.BackColor = System.Drawing.SystemColors.Info
        Me.dtRego.Location = New System.Drawing.Point(96, 81)
        Me.dtRego.Mask = "00/00/0000"
        Me.dtRego.Name = "dtRego"
        Me.dtRego.ReadOnly = true
        Me.dtRego.Size = New System.Drawing.Size(65, 21)
        Me.dtRego.TabIndex = 8
        Me.dtRego.ValidatingType = GetType(Date)
        '
        'cboAppType
        '
        Me.cboAppType.Location = New System.Drawing.Point(96, 54)
        Me.cboAppType.Name = "cboAppType"
        Me.cboAppType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.cboAppType.Properties.Appearance.Options.UseBackColor = true
        Me.cboAppType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAppType.Properties.DisplayMember = "DAAppType"
        Me.cboAppType.Properties.NullText = "[Select Type]"
        Me.cboAppType.Properties.ReadOnly = true
        Me.cboAppType.Properties.ValueMember = "DAAppTypeId"
        Me.cboAppType.Size = New System.Drawing.Size(131, 20)
        Me.cboAppType.TabIndex = 140
        '
        'lblOfficer
        '
        Me.lblOfficer.AutoSize = true
        Me.lblOfficer.Location = New System.Drawing.Point(245, 130)
        Me.lblOfficer.Name = "lblOfficer"
        Me.lblOfficer.Size = New System.Drawing.Size(44, 13)
        Me.lblOfficer.TabIndex = 139
        Me.lblOfficer.Text = "Officer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(180, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "CC No,:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(246, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(39, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "File No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(50, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(39, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "DA No.:"
        '
        'chkSec94
        '
        Me.chkSec94.AutoSize = true
        Me.chkSec94.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSec94.Enabled = false
        Me.chkSec94.Location = New System.Drawing.Point(336, 30)
        Me.chkSec94.Name = "chkSec94"
        Me.chkSec94.Size = New System.Drawing.Size(92, 17)
        Me.chkSec94.TabIndex = 2
        Me.chkSec94.Text = "Sec94 Applies"
        Me.chkSec94.UseVisualStyleBackColor = true
        '
        'txtFileNo
        '
        Me.txtFileNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtFileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileNo.Location = New System.Drawing.Point(96, 103)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.ReadOnly = true
        Me.txtFileNo.Size = New System.Drawing.Size(131, 21)
        Me.txtFileNo.TabIndex = 9
        '
        'txtCCno
        '
        Me.txtCCno.BackColor = System.Drawing.SystemColors.Info
        Me.txtCCno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCno.Location = New System.Drawing.Point(225, 28)
        Me.txtCCno.Name = "txtCCno"
        Me.txtCCno.ReadOnly = true
        Me.txtCCno.Size = New System.Drawing.Size(79, 21)
        Me.txtCCno.TabIndex = 1
        '
        'txtDANo
        '
        Me.txtDANo.BackColor = System.Drawing.SystemColors.Info
        Me.txtDANo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDANo.Location = New System.Drawing.Point(96, 28)
        Me.txtDANo.Name = "txtDANo"
        Me.txtDANo.ReadOnly = true
        Me.txtDANo.Size = New System.Drawing.Size(79, 21)
        Me.txtDANo.TabIndex = 0
        '
        'tpgFees
        '
        Me.tpgFees.Controls.Add(Me.pnlDisplayFees)
        Me.tpgFees.ImageOptions.Image = CType(resources.GetObject("tpgFees.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgFees.Name = "tpgFees"
        Me.tpgFees.Size = New System.Drawing.Size(1423, 721)
        Me.tpgFees.Text = "Fees"
        '
        'pnlDisplayFees
        '
        Me.pnlDisplayFees.Controls.Add(Me.btnRemoveRefund)
        Me.pnlDisplayFees.Controls.Add(Me.btnEditRefund)
        Me.pnlDisplayFees.Controls.Add(Me.btnAddRefund)
        Me.pnlDisplayFees.Controls.Add(Me.GroupControl6)
        Me.pnlDisplayFees.Controls.Add(Me.btnRemoveFee)
        Me.pnlDisplayFees.Controls.Add(Me.btnEditPayment)
        Me.pnlDisplayFees.Controls.Add(Me.btnAddFee)
        Me.pnlDisplayFees.Controls.Add(Me.GroupControl4)
        Me.pnlDisplayFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayFees.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayFees.Name = "pnlDisplayFees"
        Me.pnlDisplayFees.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayFees.TabIndex = 6
        '
        'btnRemoveRefund
        '
        Me.btnRemoveRefund.Enabled = false
        Me.btnRemoveRefund.ImageOptions.Image = CType(resources.GetObject("btnRemoveRefund.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveRefund.Location = New System.Drawing.Point(922, 639)
        Me.btnRemoveRefund.Name = "btnRemoveRefund"
        Me.btnRemoveRefund.Size = New System.Drawing.Size(104, 39)
        Me.btnRemoveRefund.TabIndex = 91
        Me.btnRemoveRefund.Text = "Remove"
        '
        'btnEditRefund
        '
        Me.btnEditRefund.Enabled = false
        Me.btnEditRefund.ImageOptions.Image = CType(resources.GetObject("btnEditRefund.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditRefund.Location = New System.Drawing.Point(922, 512)
        Me.btnEditRefund.Name = "btnEditRefund"
        Me.btnEditRefund.Size = New System.Drawing.Size(104, 39)
        Me.btnEditRefund.TabIndex = 90
        Me.btnEditRefund.Text = "Change"
        '
        'btnAddRefund
        '
        Me.btnAddRefund.ImageOptions.Image = CType(resources.GetObject("btnAddRefund.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddRefund.Location = New System.Drawing.Point(922, 467)
        Me.btnAddRefund.Name = "btnAddRefund"
        Me.btnAddRefund.Size = New System.Drawing.Size(104, 39)
        Me.btnAddRefund.TabIndex = 89
        Me.btnAddRefund.Text = "ADD"
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.grdDARefundsPaid)
        Me.GroupControl6.Controls.Add(Me.txtDifference)
        Me.GroupControl6.Controls.Add(Me.Label60)
        Me.GroupControl6.Controls.Add(Me.Label61)
        Me.GroupControl6.Controls.Add(Me.Label62)
        Me.GroupControl6.Controls.Add(Me.txtReceipts)
        Me.GroupControl6.Controls.Add(Me.txtRefunds)
        Me.GroupControl6.Location = New System.Drawing.Point(26, 351)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(888, 327)
        Me.GroupControl6.TabIndex = 88
        Me.GroupControl6.Text = "Refunds"
        '
        'grdDARefundsPaid
        '
        Me.grdDARefundsPaid.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDARefundsPaid.Location = New System.Drawing.Point(2, 20)
        Me.grdDARefundsPaid.MainView = Me.gvwDARefundsPaid
        Me.grdDARefundsPaid.Name = "grdDARefundsPaid"
        Me.grdDARefundsPaid.Size = New System.Drawing.Size(884, 254)
        Me.grdDARefundsPaid.TabIndex = 0
        Me.grdDARefundsPaid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDARefundsPaid})
        '
        'gvwDARefundsPaid
        '
        Me.gvwDARefundsPaid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefundPayment, Me.colRefundAmt, Me.colRefundDt, Me.colRefundCheque, Me.colRefundNotes, Me.colRefundTypeId, Me.colRefundIDX})
        Me.gvwDARefundsPaid.GridControl = Me.grdDARefundsPaid
        Me.gvwDARefundsPaid.Name = "gvwDARefundsPaid"
        Me.gvwDARefundsPaid.OptionsBehavior.Editable = false
        Me.gvwDARefundsPaid.OptionsBehavior.ReadOnly = true
        Me.gvwDARefundsPaid.OptionsView.ShowGroupPanel = false
        '
        'colRefundPayment
        '
        Me.colRefundPayment.Caption = "Payment"
        Me.colRefundPayment.FieldName = "Payment"
        Me.colRefundPayment.Name = "colRefundPayment"
        Me.colRefundPayment.Visible = true
        Me.colRefundPayment.VisibleIndex = 0
        Me.colRefundPayment.Width = 332
        '
        'colRefundAmt
        '
        Me.colRefundAmt.Caption = "Amount"
        Me.colRefundAmt.DisplayFormat.FormatString = "c2"
        Me.colRefundAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRefundAmt.FieldName = "RefundAmt"
        Me.colRefundAmt.Name = "colRefundAmt"
        Me.colRefundAmt.Visible = true
        Me.colRefundAmt.VisibleIndex = 1
        Me.colRefundAmt.Width = 106
        '
        'colRefundDt
        '
        Me.colRefundDt.Caption = "Refunded"
        Me.colRefundDt.FieldName = "RefundDt"
        Me.colRefundDt.Name = "colRefundDt"
        Me.colRefundDt.Visible = true
        Me.colRefundDt.VisibleIndex = 2
        Me.colRefundDt.Width = 98
        '
        'colRefundCheque
        '
        Me.colRefundCheque.Caption = "Cheque"
        Me.colRefundCheque.FieldName = "RefundCheque"
        Me.colRefundCheque.Name = "colRefundCheque"
        Me.colRefundCheque.Visible = true
        Me.colRefundCheque.VisibleIndex = 3
        Me.colRefundCheque.Width = 90
        '
        'colRefundNotes
        '
        Me.colRefundNotes.Caption = "Notes"
        Me.colRefundNotes.FieldName = "Refund Notes"
        Me.colRefundNotes.Name = "colRefundNotes"
        Me.colRefundNotes.Visible = true
        Me.colRefundNotes.VisibleIndex = 4
        Me.colRefundNotes.Width = 240
        '
        'colRefundTypeId
        '
        Me.colRefundTypeId.Caption = "GridColumn17"
        Me.colRefundTypeId.FieldName = "RefundTypeId"
        Me.colRefundTypeId.Name = "colRefundTypeId"
        '
        'colRefundIDX
        '
        Me.colRefundIDX.Caption = "GridColumn18"
        Me.colRefundIDX.FieldName = "RefundIDX"
        Me.colRefundIDX.Name = "colRefundIDX"
        '
        'txtDifference
        '
        Me.txtDifference.BackColor = System.Drawing.SystemColors.Info
        Me.txtDifference.Location = New System.Drawing.Point(667, 290)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.ReadOnly = true
        Me.txtDifference.Size = New System.Drawing.Size(100, 21)
        Me.txtDifference.TabIndex = 77
        '
        'Label60
        '
        Me.Label60.AutoSize = true
        Me.Label60.Location = New System.Drawing.Point(134, 293)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(74, 13)
        Me.Label60.TabIndex = 72
        Me.Label60.Text = "Total Receipt:"
        '
        'Label61
        '
        Me.Label61.AutoSize = true
        Me.Label61.Location = New System.Drawing.Point(362, 293)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(70, 13)
        Me.Label61.TabIndex = 73
        Me.Label61.Text = "Total refund:"
        '
        'Label62
        '
        Me.Label62.AutoSize = true
        Me.Label62.Location = New System.Drawing.Point(570, 293)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(92, 13)
        Me.Label62.TabIndex = 74
        Me.Label62.Text = "Receipt - Refund:"
        '
        'txtReceipts
        '
        Me.txtReceipts.BackColor = System.Drawing.SystemColors.Info
        Me.txtReceipts.Location = New System.Drawing.Point(211, 290)
        Me.txtReceipts.Name = "txtReceipts"
        Me.txtReceipts.ReadOnly = true
        Me.txtReceipts.Size = New System.Drawing.Size(87, 21)
        Me.txtReceipts.TabIndex = 75
        '
        'txtRefunds
        '
        Me.txtRefunds.BackColor = System.Drawing.SystemColors.Info
        Me.txtRefunds.Location = New System.Drawing.Point(435, 290)
        Me.txtRefunds.Name = "txtRefunds"
        Me.txtRefunds.ReadOnly = true
        Me.txtRefunds.Size = New System.Drawing.Size(100, 21)
        Me.txtRefunds.TabIndex = 76
        '
        'btnRemoveFee
        '
        Me.btnRemoveFee.Enabled = false
        Me.btnRemoveFee.ImageOptions.Image = CType(resources.GetObject("btnRemoveFee.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveFee.Location = New System.Drawing.Point(922, 302)
        Me.btnRemoveFee.Name = "btnRemoveFee"
        Me.btnRemoveFee.Size = New System.Drawing.Size(104, 39)
        Me.btnRemoveFee.TabIndex = 87
        Me.btnRemoveFee.Text = "Remove"
        '
        'btnEditPayment
        '
        Me.btnEditPayment.Enabled = false
        Me.btnEditPayment.ImageOptions.Image = CType(resources.GetObject("btnEditPayment.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditPayment.Location = New System.Drawing.Point(922, 175)
        Me.btnEditPayment.Name = "btnEditPayment"
        Me.btnEditPayment.Size = New System.Drawing.Size(104, 39)
        Me.btnEditPayment.TabIndex = 86
        Me.btnEditPayment.Text = "Change"
        '
        'btnAddFee
        '
        Me.btnAddFee.ImageOptions.Image = CType(resources.GetObject("btnAddFee.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddFee.Location = New System.Drawing.Point(922, 130)
        Me.btnAddFee.Name = "btnAddFee"
        Me.btnAddFee.Size = New System.Drawing.Size(104, 39)
        Me.btnAddFee.TabIndex = 85
        Me.btnAddFee.Text = "ADD"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grdPaymentsReceived)
        Me.GroupControl4.Location = New System.Drawing.Point(26, 16)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(890, 327)
        Me.GroupControl4.TabIndex = 84
        Me.GroupControl4.Text = "Receipts"
        '
        'grdPaymentsReceived
        '
        Me.grdPaymentsReceived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPaymentsReceived.Location = New System.Drawing.Point(2, 20)
        Me.grdPaymentsReceived.MainView = Me.gvwPaymentsReceived
        Me.grdPaymentsReceived.Name = "grdPaymentsReceived"
        Me.grdPaymentsReceived.Size = New System.Drawing.Size(886, 305)
        Me.grdPaymentsReceived.TabIndex = 0
        Me.grdPaymentsReceived.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPaymentsReceived})
        '
        'gvwPaymentsReceived
        '
        Me.gvwPaymentsReceived.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecdpayment, Me.colReceiptAmt, Me.colReceiptDt, Me.colReceiptNo, Me.colReceiptNotes, Me.colInspectionPaid, Me.colInspTypeId, Me.colPaymentId})
        Me.gvwPaymentsReceived.GridControl = Me.grdPaymentsReceived
        Me.gvwPaymentsReceived.Name = "gvwPaymentsReceived"
        Me.gvwPaymentsReceived.OptionsBehavior.Editable = false
        Me.gvwPaymentsReceived.OptionsBehavior.ReadOnly = true
        Me.gvwPaymentsReceived.OptionsView.ShowGroupPanel = false
        '
        'colRecdpayment
        '
        Me.colRecdpayment.Caption = "Payment"
        Me.colRecdpayment.FieldName = "Payment"
        Me.colRecdpayment.Name = "colRecdpayment"
        Me.colRecdpayment.Visible = true
        Me.colRecdpayment.VisibleIndex = 0
        Me.colRecdpayment.Width = 166
        '
        'colReceiptAmt
        '
        Me.colReceiptAmt.Caption = "Amount"
        Me.colReceiptAmt.DisplayFormat.FormatString = "c2"
        Me.colReceiptAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReceiptAmt.FieldName = "ReceiptAmt"
        Me.colReceiptAmt.Name = "colReceiptAmt"
        Me.colReceiptAmt.Visible = true
        Me.colReceiptAmt.VisibleIndex = 1
        Me.colReceiptAmt.Width = 97
        '
        'colReceiptDt
        '
        Me.colReceiptDt.Caption = "Date Rec'd"
        Me.colReceiptDt.FieldName = "ReceiptDt"
        Me.colReceiptDt.Name = "colReceiptDt"
        Me.colReceiptDt.Visible = true
        Me.colReceiptDt.VisibleIndex = 2
        Me.colReceiptDt.Width = 108
        '
        'colReceiptNo
        '
        Me.colReceiptNo.Caption = "Receipt No"
        Me.colReceiptNo.FieldName = "ReceiptNo"
        Me.colReceiptNo.Name = "colReceiptNo"
        Me.colReceiptNo.Visible = true
        Me.colReceiptNo.VisibleIndex = 3
        Me.colReceiptNo.Width = 79
        '
        'colReceiptNotes
        '
        Me.colReceiptNotes.Caption = "Receipt Notes"
        Me.colReceiptNotes.FieldName = "ReceiptNotes"
        Me.colReceiptNotes.Name = "colReceiptNotes"
        Me.colReceiptNotes.Visible = true
        Me.colReceiptNotes.VisibleIndex = 4
        Me.colReceiptNotes.Width = 309
        '
        'colInspectionPaid
        '
        Me.colInspectionPaid.Caption = "Inspect Paid"
        Me.colInspectionPaid.FieldName = "InspectionsPaid"
        Me.colInspectionPaid.Name = "colInspectionPaid"
        Me.colInspectionPaid.Visible = true
        Me.colInspectionPaid.VisibleIndex = 5
        Me.colInspectionPaid.Width = 109
        '
        'colInspTypeId
        '
        Me.colInspTypeId.Caption = "InsID"
        Me.colInspTypeId.FieldName = "InspTypeId"
        Me.colInspTypeId.Name = "colInspTypeId"
        '
        'colPaymentId
        '
        Me.colPaymentId.Caption = "PaymentId"
        Me.colPaymentId.FieldName = "PaymentId"
        Me.colPaymentId.Name = "colPaymentId"
        '
        'tpgSection68
        '
        Me.tpgSection68.Controls.Add(Me.pnlDisplaySect68IntDev)
        Me.tpgSection68.ImageOptions.Image = CType(resources.GetObject("tpgSection68.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgSection68.Name = "tpgSection68"
        Me.tpgSection68.Size = New System.Drawing.Size(1423, 721)
        Me.tpgSection68.Text = "INTEGRATED DEV."
        '
        'pnlDisplaySect68IntDev
        '
        Me.pnlDisplaySect68IntDev.Controls.Add(Me.grpSepp71)
        Me.pnlDisplaySect68IntDev.Controls.Add(Me.grp68)
        Me.pnlDisplaySect68IntDev.Controls.Add(Me.GroupBox9)
        Me.pnlDisplaySect68IntDev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplaySect68IntDev.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplaySect68IntDev.Name = "pnlDisplaySect68IntDev"
        Me.pnlDisplaySect68IntDev.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplaySect68IntDev.TabIndex = 3
        '
        'grpSepp71
        '
        Me.grpSepp71.Controls.Add(Me.cboDesignatedYN)
        Me.grpSepp71.Controls.Add(Me.cboIntDevYN)
        Me.grpSepp71.Controls.Add(Me.Label28)
        Me.grpSepp71.Controls.Add(Me.Label29)
        Me.grpSepp71.Location = New System.Drawing.Point(16, 17)
        Me.grpSepp71.Name = "grpSepp71"
        Me.grpSepp71.Size = New System.Drawing.Size(670, 104)
        Me.grpSepp71.TabIndex = 100
        '
        'cboDesignatedYN
        '
        Me.cboDesignatedYN.Location = New System.Drawing.Point(561, 66)
        Me.cboDesignatedYN.Name = "cboDesignatedYN"
        Me.cboDesignatedYN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboDesignatedYN.Properties.Appearance.Options.UseFont = true
        Me.cboDesignatedYN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDesignatedYN.Properties.NullText = "[Select]"
        Me.cboDesignatedYN.Properties.ReadOnly = true
        Me.cboDesignatedYN.Size = New System.Drawing.Size(87, 26)
        Me.cboDesignatedYN.TabIndex = 70
        '
        'cboIntDevYN
        '
        Me.cboIntDevYN.Location = New System.Drawing.Point(561, 15)
        Me.cboIntDevYN.Name = "cboIntDevYN"
        Me.cboIntDevYN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboIntDevYN.Properties.Appearance.Options.UseFont = true
        Me.cboIntDevYN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIntDevYN.Properties.NullText = "[Select]"
        Me.cboIntDevYN.Properties.ReadOnly = true
        Me.cboIntDevYN.Size = New System.Drawing.Size(87, 26)
        Me.cboIntDevYN.TabIndex = 71
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label28.Location = New System.Drawing.Point(21, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(533, 19)
        Me.Label28.TabIndex = 71
        Me.Label28.Text = "Is the proposal DESIGNATED under Schedule 3 of the EP&&A Act of 1979?"
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label29.Location = New System.Drawing.Point(21, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(481, 19)
        Me.Label29.TabIndex = 70
        Me.Label29.Text = "Is the proposal INTEGRATED under s91 of the EP&&A Act of 1979?"
        '
        'grp68
        '
        Me.grp68.Controls.Add(Me.btnRemove68)
        Me.grp68.Controls.Add(Me.grdSection68)
        Me.grp68.Controls.Add(Me.lupSection68)
        Me.grp68.Controls.Add(Me.btnInsert68)
        Me.grp68.Location = New System.Drawing.Point(849, 17)
        Me.grp68.Name = "grp68"
        Me.grp68.Size = New System.Drawing.Size(554, 267)
        Me.grp68.TabIndex = 99
        Me.grp68.Text = "Section 68"
        '
        'btnRemove68
        '
        Me.btnRemove68.Enabled = false
        Me.btnRemove68.ImageOptions.Image = CType(resources.GetObject("btnRemove68.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemove68.Location = New System.Drawing.Point(431, 206)
        Me.btnRemove68.Name = "btnRemove68"
        Me.btnRemove68.Size = New System.Drawing.Size(109, 37)
        Me.btnRemove68.TabIndex = 106
        Me.btnRemove68.Text = "Remove"
        '
        'grdSection68
        '
        Me.grdSection68.Location = New System.Drawing.Point(25, 60)
        Me.grdSection68.MainView = Me.gvwSection68
        Me.grdSection68.Name = "grdSection68"
        Me.grdSection68.Size = New System.Drawing.Size(391, 183)
        Me.grdSection68.TabIndex = 105
        Me.grdSection68.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSection68})
        '
        'gvwSection68
        '
        Me.gvwSection68.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemDescription})
        Me.gvwSection68.GridControl = Me.grdSection68
        Me.gvwSection68.Name = "gvwSection68"
        Me.gvwSection68.OptionsBehavior.Editable = false
        Me.gvwSection68.OptionsBehavior.ReadOnly = true
        Me.gvwSection68.OptionsView.ShowGroupPanel = false
        '
        'colItemId
        '
        Me.colItemId.Caption = "ItemId"
        Me.colItemId.FieldName = "sectIdx"
        Me.colItemId.Name = "colItemId"
        '
        'colItemDescription
        '
        Me.colItemDescription.Caption = "Item"
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.Visible = true
        Me.colItemDescription.VisibleIndex = 0
        '
        'lupSection68
        '
        Me.lupSection68.Location = New System.Drawing.Point(20, 29)
        Me.lupSection68.Name = "lupSection68"
        Me.lupSection68.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lupSection68.Properties.NullText = "[Select appropriate section 68 code]"
        Me.lupSection68.Size = New System.Drawing.Size(396, 20)
        Me.lupSection68.TabIndex = 104
        '
        'btnInsert68
        '
        Me.btnInsert68.Enabled = false
        Me.btnInsert68.ImageOptions.Image = CType(resources.GetObject("btnInsert68.ImageOptions.Image"),System.Drawing.Image)
        Me.btnInsert68.Location = New System.Drawing.Point(431, 60)
        Me.btnInsert68.Name = "btnInsert68"
        Me.btnInsert68.Size = New System.Drawing.Size(109, 37)
        Me.btnInsert68.TabIndex = 102
        Me.btnInsert68.Text = "Insert"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.grdIntDev)
        Me.GroupBox9.Controls.Add(Me.btnSetIntDevDate)
        Me.GroupBox9.Controls.Add(Me.btnMaitList)
        Me.GroupBox9.Controls.Add(Me.btnRemoveIntDev)
        Me.GroupBox9.Controls.Add(Me.cboIntDevActs)
        Me.GroupBox9.Controls.Add(Me.btnAddIntDev)
        Me.GroupBox9.Controls.Add(Me.mskDateAct)
        Me.GroupBox9.Controls.Add(Me.Label49)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 143)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(786, 374)
        Me.GroupBox9.TabIndex = 98
        Me.GroupBox9.Text = "Integrated Development Check List"
        '
        'grdIntDev
        '
        Me.grdIntDev.Location = New System.Drawing.Point(25, 117)
        Me.grdIntDev.MainView = Me.gvwIntDev
        Me.grdIntDev.Name = "grdIntDev"
        Me.grdIntDev.Size = New System.Drawing.Size(577, 246)
        Me.grdIntDev.TabIndex = 102
        Me.grdIntDev.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwIntDev})
        '
        'gvwIntDev
        '
        Me.gvwIntDev.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.colTheAct, Me.colCheckDate})
        Me.gvwIntDev.GridControl = Me.grdIntDev
        Me.gvwIntDev.Name = "gvwIntDev"
        Me.gvwIntDev.OptionsBehavior.Editable = false
        Me.gvwIntDev.OptionsBehavior.ReadOnly = true
        Me.gvwIntDev.OptionsView.ShowGroupPanel = false
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "GridColumn12"
        Me.GridColumn12.FieldName = "id"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'colTheAct
        '
        Me.colTheAct.Caption = "Act"
        Me.colTheAct.FieldName = "TheAct"
        Me.colTheAct.Name = "colTheAct"
        Me.colTheAct.Visible = true
        Me.colTheAct.VisibleIndex = 0
        Me.colTheAct.Width = 471
        '
        'colCheckDate
        '
        Me.colCheckDate.Caption = "Date"
        Me.colCheckDate.FieldName = "CheckDate"
        Me.colCheckDate.Name = "colCheckDate"
        Me.colCheckDate.Visible = true
        Me.colCheckDate.VisibleIndex = 1
        Me.colCheckDate.Width = 88
        '
        'btnSetIntDevDate
        '
        Me.btnSetIntDevDate.Enabled = false
        Me.btnSetIntDevDate.ImageOptions.Image = CType(resources.GetObject("btnSetIntDevDate.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSetIntDevDate.Location = New System.Drawing.Point(608, 326)
        Me.btnSetIntDevDate.Name = "btnSetIntDevDate"
        Me.btnSetIntDevDate.Size = New System.Drawing.Size(109, 37)
        Me.btnSetIntDevDate.TabIndex = 101
        Me.btnSetIntDevDate.Text = "Set Date"
        '
        'btnMaitList
        '
        Me.btnMaitList.ImageOptions.Image = CType(resources.GetObject("btnMaitList.ImageOptions.Image"),System.Drawing.Image)
        Me.btnMaitList.Location = New System.Drawing.Point(608, 46)
        Me.btnMaitList.Name = "btnMaitList"
        Me.btnMaitList.Size = New System.Drawing.Size(138, 37)
        Me.btnMaitList.TabIndex = 100
        Me.btnMaitList.Text = "Maintain "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"List Of Acts"
        '
        'btnRemoveIntDev
        '
        Me.btnRemoveIntDev.Enabled = false
        Me.btnRemoveIntDev.ImageOptions.Image = CType(resources.GetObject("btnRemoveIntDev.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveIntDev.Location = New System.Drawing.Point(608, 157)
        Me.btnRemoveIntDev.Name = "btnRemoveIntDev"
        Me.btnRemoveIntDev.Size = New System.Drawing.Size(138, 37)
        Me.btnRemoveIntDev.TabIndex = 100
        Me.btnRemoveIntDev.Text = "Remove Integrated "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Devel."
        '
        'cboIntDevActs
        '
        Me.cboIntDevActs.Location = New System.Drawing.Point(25, 67)
        Me.cboIntDevActs.Name = "cboIntDevActs"
        Me.cboIntDevActs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIntDevActs.Properties.NullText = "[Select Act that Applies]"
        Me.cboIntDevActs.Size = New System.Drawing.Size(467, 20)
        Me.cboIntDevActs.TabIndex = 99
        '
        'btnAddIntDev
        '
        Me.btnAddIntDev.Enabled = false
        Me.btnAddIntDev.ImageOptions.Image = CType(resources.GetObject("btnAddIntDev.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddIntDev.Location = New System.Drawing.Point(608, 114)
        Me.btnAddIntDev.Name = "btnAddIntDev"
        Me.btnAddIntDev.Size = New System.Drawing.Size(138, 37)
        Me.btnAddIntDev.TabIndex = 99
        Me.btnAddIntDev.Text = "Add Integrated"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Devel."
        '
        'mskDateAct
        '
        Me.mskDateAct.EditValue = Nothing
        Me.mskDateAct.Location = New System.Drawing.Point(496, 67)
        Me.mskDateAct.Name = "mskDateAct"
        Me.mskDateAct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskDateAct.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskDateAct.Size = New System.Drawing.Size(100, 20)
        Me.mskDateAct.TabIndex = 98
        '
        'Label49
        '
        Me.Label49.AutoSize = true
        Me.Label49.Location = New System.Drawing.Point(493, 44)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(61, 13)
        Me.Label49.TabIndex = 95
        Me.Label49.Text = "Select date"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(26, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Select Act that applies"
        '
        'tpgReferrals
        '
        Me.tpgReferrals.Controls.Add(Me.pnlDisplayReferrals)
        Me.tpgReferrals.ImageOptions.Image = CType(resources.GetObject("tpgReferrals.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgReferrals.Name = "tpgReferrals"
        Me.tpgReferrals.Size = New System.Drawing.Size(1423, 721)
        Me.tpgReferrals.Text = "Referrals"
        '
        'pnlDisplayReferrals
        '
        Me.pnlDisplayReferrals.Controls.Add(Me.grpMain)
        Me.pnlDisplayReferrals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayReferrals.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayReferrals.Name = "pnlDisplayReferrals"
        Me.pnlDisplayReferrals.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayReferrals.TabIndex = 2
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.chksepp71)
        Me.grpMain.Controls.Add(Me.btnRemovePDF)
        Me.grpMain.Controls.Add(Me.btnAddPDF)
        Me.grpMain.Controls.Add(Me.lblReferralID)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.btnRTA)
        Me.grpMain.Controls.Add(Me.DaysElapsedTextBox)
        Me.grpMain.Controls.Add(Me.btnRemoveRefer)
        Me.grpMain.Controls.Add(Me.btnSaveReferralsTab)
        Me.grpMain.Controls.Add(Me.btnEditReferralsTab)
        Me.grpMain.Controls.Add(Me.btnAddReferral)
        Me.grpMain.Controls.Add(Me.cboRefCodeId)
        Me.grpMain.Controls.Add(Me.RefRetDt)
        Me.grpMain.Controls.Add(Me.Refdt)
        Me.grpMain.Controls.Add(Me.LabelControl67)
        Me.grpMain.Controls.Add(Me.LabelControl66)
        Me.grpMain.Controls.Add(Me.LabelControl65)
        Me.grpMain.Controls.Add(Me.LabelControl64)
        Me.grpMain.Controls.Add(Me.LabelControl61)
        Me.grpMain.Controls.Add(Me.LabelControl60)
        Me.grpMain.Controls.Add(Me.grpIntDesig)
        Me.grpMain.Controls.Add(Me.grpRFS)
        Me.grpMain.Controls.Add(Me.grpEngineers)
        Me.grpMain.Controls.Add(Me.txtRefComm)
        Me.grpMain.Controls.Add(Me.pnlButtons)
        Me.grpMain.Controls.Add(Me.dgvLoadListReferrals)
        Me.grpMain.Controls.Add(Me.txtRefResponse)
        Me.grpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMain.Location = New System.Drawing.Point(2, 2)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1419, 717)
        Me.grpMain.TabIndex = 1
        '
        'chksepp71
        '
        Me.chksepp71.Location = New System.Drawing.Point(904, 127)
        Me.chksepp71.Name = "chksepp71"
        Me.chksepp71.Properties.Caption = "Integrated Development?"
        Me.chksepp71.Properties.ReadOnly = true
        Me.chksepp71.Size = New System.Drawing.Size(161, 19)
        Me.chksepp71.TabIndex = 70
        '
        'btnRemovePDF
        '
        Me.btnRemovePDF.Enabled = false
        Me.btnRemovePDF.ImageOptions.Image = CType(resources.GetObject("btnRemovePDF.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemovePDF.Location = New System.Drawing.Point(904, 70)
        Me.btnRemovePDF.Name = "btnRemovePDF"
        Me.btnRemovePDF.Size = New System.Drawing.Size(112, 41)
        Me.btnRemovePDF.TabIndex = 70
        Me.btnRemovePDF.Text = "Remove "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"PDF/Image"
        '
        'btnAddPDF
        '
        Me.btnAddPDF.ImageOptions.Image = CType(resources.GetObject("btnAddPDF.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddPDF.Location = New System.Drawing.Point(904, 23)
        Me.btnAddPDF.Name = "btnAddPDF"
        Me.btnAddPDF.Size = New System.Drawing.Size(112, 41)
        Me.btnAddPDF.TabIndex = 69
        Me.btnAddPDF.Tag = "ADD"
        Me.btnAddPDF.Text = "Add "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"PDF/Image"
        '
        'lblReferralID
        '
        Me.lblReferralID.AutoSize = true
        Me.lblReferralID.ForeColor = System.Drawing.Color.Transparent
        Me.lblReferralID.Location = New System.Drawing.Point(33, 20)
        Me.lblReferralID.Name = "lblReferralID"
        Me.lblReferralID.Size = New System.Drawing.Size(0, 13)
        Me.lblReferralID.TabIndex = 53
        '
        'btnView
        '
        Me.btnView.ImageOptions.Image = CType(resources.GetObject("btnView.ImageOptions.Image"),System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(545, 244)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(92, 37)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View"
        Me.btnView.Visible = false
        '
        'btnRTA
        '
        Me.btnRTA.ImageOptions.Image = CType(resources.GetObject("btnRTA.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRTA.Location = New System.Drawing.Point(526, 31)
        Me.btnRTA.Name = "btnRTA"
        Me.btnRTA.Size = New System.Drawing.Size(112, 41)
        Me.btnRTA.TabIndex = 26
        Me.btnRTA.Text = "Print RMS "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Letter"
        '
        'DaysElapsedTextBox
        '
        Me.DaysElapsedTextBox.Location = New System.Drawing.Point(1117, 299)
        Me.DaysElapsedTextBox.Name = "DaysElapsedTextBox"
        Me.DaysElapsedTextBox.Properties.ReadOnly = true
        Me.DaysElapsedTextBox.Size = New System.Drawing.Size(42, 20)
        Me.DaysElapsedTextBox.TabIndex = 25
        '
        'btnRemoveRefer
        '
        Me.btnRemoveRefer.ImageOptions.Image = CType(resources.GetObject("btnRemoveRefer.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveRefer.Location = New System.Drawing.Point(1271, 91)
        Me.btnRemoveRefer.Name = "btnRemoveRefer"
        Me.btnRemoveRefer.Size = New System.Drawing.Size(117, 44)
        Me.btnRemoveRefer.TabIndex = 24
        Me.btnRemoveRefer.Text = "Remove"
        '
        'btnSaveReferralsTab
        '
        Me.btnSaveReferralsTab.ImageOptions.Image = CType(resources.GetObject("btnSaveReferralsTab.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveReferralsTab.Location = New System.Drawing.Point(1271, 216)
        Me.btnSaveReferralsTab.Name = "btnSaveReferralsTab"
        Me.btnSaveReferralsTab.Size = New System.Drawing.Size(117, 44)
        Me.btnSaveReferralsTab.TabIndex = 23
        Me.btnSaveReferralsTab.Text = "Save"
        '
        'btnEditReferralsTab
        '
        Me.btnEditReferralsTab.ImageOptions.Image = CType(resources.GetObject("btnEditReferralsTab.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditReferralsTab.Location = New System.Drawing.Point(1271, 152)
        Me.btnEditReferralsTab.Name = "btnEditReferralsTab"
        Me.btnEditReferralsTab.Size = New System.Drawing.Size(117, 44)
        Me.btnEditReferralsTab.TabIndex = 22
        Me.btnEditReferralsTab.Text = "Change"
        '
        'btnAddReferral
        '
        Me.btnAddReferral.ImageOptions.Image = CType(resources.GetObject("btnAddReferral.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddReferral.Location = New System.Drawing.Point(1271, 29)
        Me.btnAddReferral.Name = "btnAddReferral"
        Me.btnAddReferral.Size = New System.Drawing.Size(117, 44)
        Me.btnAddReferral.TabIndex = 21
        Me.btnAddReferral.Text = "Add"
        '
        'cboRefCodeId
        '
        Me.cboRefCodeId.Location = New System.Drawing.Point(874, 299)
        Me.cboRefCodeId.Name = "cboRefCodeId"
        Me.cboRefCodeId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefCodeId.Properties.NullText = "[Referred to?]"
        Me.cboRefCodeId.Properties.ReadOnly = true
        Me.cboRefCodeId.Properties.ShowFooter = false
        Me.cboRefCodeId.Properties.ShowHeader = false
        Me.cboRefCodeId.Size = New System.Drawing.Size(225, 20)
        Me.cboRefCodeId.TabIndex = 20
        '
        'RefRetDt
        '
        Me.RefRetDt.EditValue = Nothing
        Me.RefRetDt.Location = New System.Drawing.Point(764, 299)
        Me.RefRetDt.Name = "RefRetDt"
        Me.RefRetDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RefRetDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RefRetDt.Properties.ReadOnly = true
        Me.RefRetDt.Size = New System.Drawing.Size(100, 20)
        Me.RefRetDt.TabIndex = 19
        '
        'Refdt
        '
        Me.Refdt.EditValue = Nothing
        Me.Refdt.Location = New System.Drawing.Point(653, 299)
        Me.Refdt.Name = "Refdt"
        Me.Refdt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Refdt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Refdt.Properties.ReadOnly = true
        Me.Refdt.Size = New System.Drawing.Size(100, 20)
        Me.Refdt.TabIndex = 18
        '
        'LabelControl67
        '
        Me.LabelControl67.Location = New System.Drawing.Point(653, 280)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl67.TabIndex = 17
        Me.LabelControl67.Text = "Referred"
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(764, 280)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl66.TabIndex = 16
        Me.LabelControl66.Text = "Returned"
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(874, 280)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl65.TabIndex = 15
        Me.LabelControl65.Text = "Referred to"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(1117, 280)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl64.TabIndex = 14
        Me.LabelControl64.Text = "Days elapsed"
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(22, 249)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl61.TabIndex = 13
        Me.LabelControl61.Text = "Response by Referee:"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(22, 204)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl60.TabIndex = 12
        Me.LabelControl60.Text = "Comments"
        '
        'grpIntDesig
        '
        Me.grpIntDesig.Controls.Add(Me.btnAddIntegrated)
        Me.grpIntDesig.Controls.Add(Me.btnRemoveIntegated)
        Me.grpIntDesig.Controls.Add(Me.cboReferralsIntProvision)
        Me.grpIntDesig.Controls.Add(Me.lstIntegrated)
        Me.grpIntDesig.Location = New System.Drawing.Point(653, 23)
        Me.grpIntDesig.Name = "grpIntDesig"
        Me.grpIntDesig.Size = New System.Drawing.Size(238, 251)
        Me.grpIntDesig.TabIndex = 10
        Me.grpIntDesig.Text = "Integrated/Designated Provision"
        '
        'btnAddIntegrated
        '
        Me.btnAddIntegrated.ImageOptions.Image = CType(resources.GetObject("btnAddIntegrated.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddIntegrated.Location = New System.Drawing.Point(127, 194)
        Me.btnAddIntegrated.Name = "btnAddIntegrated"
        Me.btnAddIntegrated.Size = New System.Drawing.Size(98, 43)
        Me.btnAddIntegrated.TabIndex = 59
        Me.btnAddIntegrated.Text = "Add"
        '
        'btnRemoveIntegated
        '
        Me.btnRemoveIntegated.ImageOptions.Image = CType(resources.GetObject("btnRemoveIntegated.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveIntegated.Location = New System.Drawing.Point(19, 194)
        Me.btnRemoveIntegated.Name = "btnRemoveIntegated"
        Me.btnRemoveIntegated.Size = New System.Drawing.Size(98, 43)
        Me.btnRemoveIntegated.TabIndex = 58
        Me.btnRemoveIntegated.Text = "Remove"
        '
        'cboReferralsIntProvision
        '
        Me.cboReferralsIntProvision.Location = New System.Drawing.Point(19, 168)
        Me.cboReferralsIntProvision.Name = "cboReferralsIntProvision"
        Me.cboReferralsIntProvision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReferralsIntProvision.Properties.NullText = "[Select Integrated Type]"
        Me.cboReferralsIntProvision.Properties.ReadOnly = true
        Me.cboReferralsIntProvision.Properties.ShowFooter = false
        Me.cboReferralsIntProvision.Properties.ShowHeader = false
        Me.cboReferralsIntProvision.Size = New System.Drawing.Size(206, 20)
        Me.cboReferralsIntProvision.TabIndex = 57
        '
        'lstIntegrated
        '
        Me.lstIntegrated.DisplayMember = "IntActName"
        Me.lstIntegrated.FormattingEnabled = true
        Me.lstIntegrated.Location = New System.Drawing.Point(19, 28)
        Me.lstIntegrated.Name = "lstIntegrated"
        Me.lstIntegrated.Size = New System.Drawing.Size(206, 134)
        Me.lstIntegrated.TabIndex = 56
        Me.lstIntegrated.ValueMember = "id"
        '
        'grpRFS
        '
        Me.grpRFS.Controls.Add(Me.txtRFSSubLots)
        Me.grpRFS.Controls.Add(Me.btnPrintRFSSub)
        Me.grpRFS.Controls.Add(Me.btnPrintRFSOther)
        Me.grpRFS.Controls.Add(Me.cboRFSSubDivisionType)
        Me.grpRFS.Controls.Add(Me.LabelControl63)
        Me.grpRFS.Controls.Add(Me.LabelControl62)
        Me.grpRFS.Location = New System.Drawing.Point(653, 453)
        Me.grpRFS.Name = "grpRFS"
        Me.grpRFS.Size = New System.Drawing.Size(550, 103)
        Me.grpRFS.TabIndex = 9
        Me.grpRFS.Text = "Rural Fire Service"
        Me.grpRFS.Visible = false
        '
        'txtRFSSubLots
        '
        Me.txtRFSSubLots.Location = New System.Drawing.Point(133, 49)
        Me.txtRFSSubLots.Name = "txtRFSSubLots"
        Me.txtRFSSubLots.Properties.ReadOnly = true
        Me.txtRFSSubLots.Size = New System.Drawing.Size(30, 20)
        Me.txtRFSSubLots.TabIndex = 5
        '
        'btnPrintRFSSub
        '
        Me.btnPrintRFSSub.ImageOptions.Image = CType(resources.GetObject("btnPrintRFSSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnPrintRFSSub.Location = New System.Drawing.Point(400, 38)
        Me.btnPrintRFSSub.Name = "btnPrintRFSSub"
        Me.btnPrintRFSSub.Size = New System.Drawing.Size(137, 41)
        Me.btnPrintRFSSub.TabIndex = 4
        Me.btnPrintRFSSub.Text = "Print RFS Sub"
        '
        'btnPrintRFSOther
        '
        Me.btnPrintRFSOther.ImageOptions.Image = CType(resources.GetObject("btnPrintRFSOther.ImageOptions.Image"),System.Drawing.Image)
        Me.btnPrintRFSOther.Location = New System.Drawing.Point(242, 38)
        Me.btnPrintRFSOther.Name = "btnPrintRFSOther"
        Me.btnPrintRFSOther.Size = New System.Drawing.Size(137, 41)
        Me.btnPrintRFSOther.TabIndex = 3
        Me.btnPrintRFSOther.Text = "Print RFS Other"
        '
        'cboRFSSubDivisionType
        '
        Me.cboRFSSubDivisionType.Location = New System.Drawing.Point(14, 49)
        Me.cboRFSSubDivisionType.Name = "cboRFSSubDivisionType"
        Me.cboRFSSubDivisionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRFSSubDivisionType.Properties.NullText = "[Type?]"
        Me.cboRFSSubDivisionType.Properties.ShowFooter = false
        Me.cboRFSSubDivisionType.Properties.ShowHeader = false
        Me.cboRFSSubDivisionType.Size = New System.Drawing.Size(100, 20)
        Me.cboRFSSubDivisionType.TabIndex = 2
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(133, 30)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl63.TabIndex = 1
        Me.LabelControl63.Text = "Total Lots:"
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(14, 30)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl62.TabIndex = 0
        Me.LabelControl62.Text = "Block Type:"
        '
        'grpEngineers
        '
        Me.grpEngineers.Controls.Add(Me.LabelControl69)
        Me.grpEngineers.Controls.Add(Me.EngDueReturnDate)
        Me.grpEngineers.Controls.Add(Me.txtEngInternalComments)
        Me.grpEngineers.Location = New System.Drawing.Point(653, 562)
        Me.grpEngineers.Name = "grpEngineers"
        Me.grpEngineers.Size = New System.Drawing.Size(550, 103)
        Me.grpEngineers.TabIndex = 8
        Me.grpEngineers.Text = "Instructions to Engineers"
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(441, 36)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl69.TabIndex = 18
        Me.LabelControl69.Text = "Return by"
        '
        'EngDueReturnDate
        '
        Me.EngDueReturnDate.EditValue = Nothing
        Me.EngDueReturnDate.Location = New System.Drawing.Point(441, 55)
        Me.EngDueReturnDate.Name = "EngDueReturnDate"
        Me.EngDueReturnDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EngDueReturnDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EngDueReturnDate.Properties.ReadOnly = true
        Me.EngDueReturnDate.Size = New System.Drawing.Size(96, 20)
        Me.EngDueReturnDate.TabIndex = 8
        '
        'txtEngInternalComments
        '
        Me.txtEngInternalComments.Location = New System.Drawing.Point(14, 33)
        Me.txtEngInternalComments.Name = "txtEngInternalComments"
        Me.txtEngInternalComments.Properties.Appearance.Options.UseTextOptions = true
        Me.txtEngInternalComments.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtEngInternalComments.Properties.AutoHeight = false
        Me.txtEngInternalComments.Properties.ReadOnly = true
        Me.txtEngInternalComments.Size = New System.Drawing.Size(415, 52)
        Me.txtEngInternalComments.TabIndex = 7
        '
        'txtRefComm
        '
        Me.txtRefComm.Location = New System.Drawing.Point(22, 223)
        Me.txtRefComm.Name = "txtRefComm"
        Me.txtRefComm.Properties.Appearance.Options.UseTextOptions = true
        Me.txtRefComm.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtRefComm.Properties.AutoHeight = false
        Me.txtRefComm.Properties.ReadOnly = true
        Me.txtRefComm.Size = New System.Drawing.Size(615, 21)
        Me.txtRefComm.TabIndex = 5
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnMailResponse)
        Me.pnlButtons.Controls.Add(Me.btnReferral)
        Me.pnlButtons.Controls.Add(Me.btnDraftconditions)
        Me.pnlButtons.Location = New System.Drawing.Point(367, 31)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(153, 154)
        Me.pnlButtons.TabIndex = 2
        '
        'btnMailResponse
        '
        Me.btnMailResponse.ImageOptions.Image = CType(resources.GetObject("btnMailResponse.ImageOptions.Image"),System.Drawing.Image)
        Me.btnMailResponse.Location = New System.Drawing.Point(16, 99)
        Me.btnMailResponse.Name = "btnMailResponse"
        Me.btnMailResponse.Size = New System.Drawing.Size(112, 41)
        Me.btnMailResponse.TabIndex = 2
        Me.btnMailResponse.Text = "Mail Response"
        '
        'btnReferral
        '
        Me.btnReferral.ImageOptions.Image = CType(resources.GetObject("btnReferral.ImageOptions.Image"),System.Drawing.Image)
        Me.btnReferral.Location = New System.Drawing.Point(16, 52)
        Me.btnReferral.Name = "btnReferral"
        Me.btnReferral.Size = New System.Drawing.Size(112, 41)
        Me.btnReferral.TabIndex = 1
        Me.btnReferral.Text = "Print"
        '
        'btnDraftconditions
        '
        Me.btnDraftconditions.ImageOptions.Image = CType(resources.GetObject("btnDraftconditions.ImageOptions.Image"),System.Drawing.Image)
        Me.btnDraftconditions.Location = New System.Drawing.Point(16, 5)
        Me.btnDraftconditions.Name = "btnDraftconditions"
        Me.btnDraftconditions.Size = New System.Drawing.Size(112, 41)
        Me.btnDraftconditions.TabIndex = 0
        Me.btnDraftconditions.Text = "Draft "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Conditions"
        '
        'dgvLoadListReferrals
        '
        GridLevelNode1.RelationName = "Level1"
        Me.dgvLoadListReferrals.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgvLoadListReferrals.Location = New System.Drawing.Point(22, 31)
        Me.dgvLoadListReferrals.MainView = Me.gvwLoadListReferrals
        Me.dgvLoadListReferrals.Name = "dgvLoadListReferrals"
        Me.dgvLoadListReferrals.Size = New System.Drawing.Size(339, 167)
        Me.dgvLoadListReferrals.TabIndex = 0
        Me.dgvLoadListReferrals.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwLoadListReferrals})
        '
        'gvwLoadListReferrals
        '
        Me.gvwLoadListReferrals.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReferralId, Me.colRefdt, Me.colReferralCode})
        Me.gvwLoadListReferrals.GridControl = Me.dgvLoadListReferrals
        Me.gvwLoadListReferrals.Name = "gvwLoadListReferrals"
        Me.gvwLoadListReferrals.OptionsBehavior.Editable = false
        Me.gvwLoadListReferrals.OptionsBehavior.ReadOnly = true
        Me.gvwLoadListReferrals.OptionsView.ShowGroupPanel = false
        '
        'colReferralId
        '
        Me.colReferralId.Caption = "id"
        Me.colReferralId.FieldName = "ReferralId"
        Me.colReferralId.Name = "colReferralId"
        '
        'colRefdt
        '
        Me.colRefdt.Caption = "Date"
        Me.colRefdt.DisplayFormat.FormatString = "d"
        Me.colRefdt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRefdt.FieldName = "Refdt"
        Me.colRefdt.Name = "colRefdt"
        Me.colRefdt.Visible = true
        Me.colRefdt.VisibleIndex = 0
        Me.colRefdt.Width = 80
        '
        'colReferralCode
        '
        Me.colReferralCode.Caption = "Referred to"
        Me.colReferralCode.FieldName = "ReferralCode"
        Me.colReferralCode.Name = "colReferralCode"
        Me.colReferralCode.Visible = true
        Me.colReferralCode.VisibleIndex = 1
        Me.colReferralCode.Width = 219
        '
        'txtRefResponse
        '
        Me.txtRefResponse.Location = New System.Drawing.Point(22, 268)
        Me.txtRefResponse.Name = "txtRefResponse"
        Me.txtRefResponse.Properties.Appearance.Options.UseTextOptions = true
        Me.txtRefResponse.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtRefResponse.Properties.ReadOnly = true
        Me.txtRefResponse.Size = New System.Drawing.Size(615, 397)
        Me.txtRefResponse.TabIndex = 6
        '
        'tpgStatus
        '
        Me.tpgStatus.Controls.Add(Me.pnlDisplayStatus)
        Me.tpgStatus.ImageOptions.Image = CType(resources.GetObject("tpgStatus.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgStatus.Name = "tpgStatus"
        Me.tpgStatus.Size = New System.Drawing.Size(1423, 721)
        Me.tpgStatus.Text = "Status"
        '
        'pnlDisplayStatus
        '
        Me.pnlDisplayStatus.Controls.Add(Me.GroupControl10)
        Me.pnlDisplayStatus.Controls.Add(Me.btnMapMerge)
        Me.pnlDisplayStatus.Controls.Add(Me.btnSaveStatus)
        Me.pnlDisplayStatus.Controls.Add(Me.btnEditStatus)
        Me.pnlDisplayStatus.Controls.Add(Me.GroupBox18)
        Me.pnlDisplayStatus.Controls.Add(Me.grpAssessment)
        Me.pnlDisplayStatus.Controls.Add(Me.grpNotification)
        Me.pnlDisplayStatus.Controls.Add(Me.grpDetermination)
        Me.pnlDisplayStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayStatus.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayStatus.Name = "pnlDisplayStatus"
        Me.pnlDisplayStatus.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayStatus.TabIndex = 23
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.btnSaveDesignatedText)
        Me.GroupControl10.Controls.Add(Me.btnModifyDesignatedText)
        Me.GroupControl10.Controls.Add(Me.Label32)
        Me.GroupControl10.Controls.Add(Me.txtDesignatedText)
        Me.GroupControl10.Controls.Add(Me.btnSaveDeptPlanning)
        Me.GroupControl10.Controls.Add(Me.btnModifyDeptPlanning)
        Me.GroupControl10.Controls.Add(Me.Label31)
        Me.GroupControl10.Controls.Add(Me.txtDepartPlanning)
        Me.GroupControl10.Controls.Add(Me.btnModifyAdvertAddress)
        Me.GroupControl10.Controls.Add(Me.txtAdvertSignIntDetails)
        Me.GroupControl10.Controls.Add(Me.txtDepotAddress)
        Me.GroupControl10.Controls.Add(Me.btnDesignIntegr)
        Me.GroupControl10.Controls.Add(Me.cboAdvertSignDepot)
        Me.GroupControl10.Controls.Add(Me.btnDesignated)
        Me.GroupControl10.Controls.Add(Me.btnPrintAdvNotice)
        Me.GroupControl10.Controls.Add(Me.btnPrintAdvert)
        Me.GroupControl10.Controls.Add(Me.Label15)
        Me.GroupControl10.Controls.Add(Me.Label86)
        Me.GroupControl10.Location = New System.Drawing.Point(876, 21)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(521, 647)
        Me.GroupControl10.TabIndex = 109
        Me.GroupControl10.Text = "Advertising Sign"
        '
        'btnSaveDesignatedText
        '
        Me.btnSaveDesignatedText.Enabled = false
        Me.btnSaveDesignatedText.ImageOptions.Image = CType(resources.GetObject("btnSaveDesignatedText.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveDesignatedText.Location = New System.Drawing.Point(412, 595)
        Me.btnSaveDesignatedText.Name = "btnSaveDesignatedText"
        Me.btnSaveDesignatedText.Size = New System.Drawing.Size(93, 34)
        Me.btnSaveDesignatedText.TabIndex = 115
        Me.btnSaveDesignatedText.Tag = "v"
        Me.btnSaveDesignatedText.Text = "Update"
        '
        'btnModifyDesignatedText
        '
        Me.btnModifyDesignatedText.ImageOptions.Image = CType(resources.GetObject("btnModifyDesignatedText.ImageOptions.Image"),System.Drawing.Image)
        Me.btnModifyDesignatedText.Location = New System.Drawing.Point(17, 595)
        Me.btnModifyDesignatedText.Name = "btnModifyDesignatedText"
        Me.btnModifyDesignatedText.Size = New System.Drawing.Size(93, 34)
        Me.btnModifyDesignatedText.TabIndex = 118
        Me.btnModifyDesignatedText.Text = "Modify"
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Location = New System.Drawing.Point(14, 472)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 13)
        Me.Label32.TabIndex = 117
        Me.Label32.Text = "Designated Text"
        '
        'txtDesignatedText
        '
        Me.txtDesignatedText.Location = New System.Drawing.Point(17, 488)
        Me.txtDesignatedText.Name = "txtDesignatedText"
        Me.txtDesignatedText.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesignatedText.Size = New System.Drawing.Size(488, 101)
        Me.txtDesignatedText.TabIndex = 116
        '
        'btnSaveDeptPlanning
        '
        Me.btnSaveDeptPlanning.Enabled = false
        Me.btnSaveDeptPlanning.ImageOptions.Image = CType(resources.GetObject("btnSaveDeptPlanning.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveDeptPlanning.Location = New System.Drawing.Point(412, 425)
        Me.btnSaveDeptPlanning.Name = "btnSaveDeptPlanning"
        Me.btnSaveDeptPlanning.Size = New System.Drawing.Size(93, 34)
        Me.btnSaveDeptPlanning.TabIndex = 110
        Me.btnSaveDeptPlanning.Tag = "v"
        Me.btnSaveDeptPlanning.Text = "Update"
        '
        'btnModifyDeptPlanning
        '
        Me.btnModifyDeptPlanning.ImageOptions.Image = CType(resources.GetObject("btnModifyDeptPlanning.ImageOptions.Image"),System.Drawing.Image)
        Me.btnModifyDeptPlanning.Location = New System.Drawing.Point(17, 425)
        Me.btnModifyDeptPlanning.Name = "btnModifyDeptPlanning"
        Me.btnModifyDeptPlanning.Size = New System.Drawing.Size(93, 34)
        Me.btnModifyDeptPlanning.TabIndex = 114
        Me.btnModifyDeptPlanning.Text = "Modify"
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Location = New System.Drawing.Point(14, 333)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(150, 13)
        Me.Label31.TabIndex = 113
        Me.Label31.Text = "Planning Department Location"
        '
        'txtDepartPlanning
        '
        Me.txtDepartPlanning.Location = New System.Drawing.Point(17, 349)
        Me.txtDepartPlanning.Name = "txtDepartPlanning"
        Me.txtDepartPlanning.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepartPlanning.Size = New System.Drawing.Size(488, 70)
        Me.txtDepartPlanning.TabIndex = 112
        '
        'btnModifyAdvertAddress
        '
        Me.btnModifyAdvertAddress.ImageOptions.Image = CType(resources.GetObject("btnModifyAdvertAddress.ImageOptions.Image"),System.Drawing.Image)
        Me.btnModifyAdvertAddress.Location = New System.Drawing.Point(17, 295)
        Me.btnModifyAdvertAddress.Name = "btnModifyAdvertAddress"
        Me.btnModifyAdvertAddress.Size = New System.Drawing.Size(93, 34)
        Me.btnModifyAdvertAddress.TabIndex = 111
        Me.btnModifyAdvertAddress.Text = "Modify"
        '
        'txtAdvertSignIntDetails
        '
        Me.txtAdvertSignIntDetails.Location = New System.Drawing.Point(17, 38)
        Me.txtAdvertSignIntDetails.Name = "txtAdvertSignIntDetails"
        Me.txtAdvertSignIntDetails.Size = New System.Drawing.Size(475, 99)
        Me.txtAdvertSignIntDetails.TabIndex = 110
        '
        'txtDepotAddress
        '
        Me.txtDepotAddress.Location = New System.Drawing.Point(17, 225)
        Me.txtDepotAddress.Name = "txtDepotAddress"
        Me.txtDepotAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepotAddress.Size = New System.Drawing.Size(488, 65)
        Me.txtDepotAddress.TabIndex = 109
        '
        'btnDesignIntegr
        '
        Me.btnDesignIntegr.ImageOptions.Image = CType(resources.GetObject("btnDesignIntegr.ImageOptions.Image"),System.Drawing.Image)
        Me.btnDesignIntegr.Location = New System.Drawing.Point(378, 143)
        Me.btnDesignIntegr.Name = "btnDesignIntegr"
        Me.btnDesignIntegr.Size = New System.Drawing.Size(114, 39)
        Me.btnDesignIntegr.TabIndex = 100
        Me.btnDesignIntegr.Text = "Designated && "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Integrated"
        '
        'cboAdvertSignDepot
        '
        Me.cboAdvertSignDepot.Location = New System.Drawing.Point(55, 196)
        Me.cboAdvertSignDepot.Name = "cboAdvertSignDepot"
        Me.cboAdvertSignDepot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAdvertSignDepot.Properties.NullText = "[Select Depot]"
        Me.cboAdvertSignDepot.Size = New System.Drawing.Size(166, 20)
        Me.cboAdvertSignDepot.TabIndex = 108
        '
        'btnDesignated
        '
        Me.btnDesignated.ImageOptions.Image = CType(resources.GetObject("btnDesignated.ImageOptions.Image"),System.Drawing.Image)
        Me.btnDesignated.Location = New System.Drawing.Point(259, 143)
        Me.btnDesignated.Name = "btnDesignated"
        Me.btnDesignated.Size = New System.Drawing.Size(114, 39)
        Me.btnDesignated.TabIndex = 99
        Me.btnDesignated.Text = "Designated"
        '
        'btnPrintAdvNotice
        '
        Me.btnPrintAdvNotice.ImageOptions.Image = CType(resources.GetObject("btnPrintAdvNotice.ImageOptions.Image"),System.Drawing.Image)
        Me.btnPrintAdvNotice.Location = New System.Drawing.Point(139, 143)
        Me.btnPrintAdvNotice.Name = "btnPrintAdvNotice"
        Me.btnPrintAdvNotice.Size = New System.Drawing.Size(114, 39)
        Me.btnPrintAdvNotice.TabIndex = 98
        Me.btnPrintAdvNotice.Text = "Print Advert. "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Notice"
        '
        'btnPrintAdvert
        '
        Me.btnPrintAdvert.ImageOptions.Image = CType(resources.GetObject("btnPrintAdvert.ImageOptions.Image"),System.Drawing.Image)
        Me.btnPrintAdvert.Location = New System.Drawing.Point(20, 143)
        Me.btnPrintAdvert.Name = "btnPrintAdvert"
        Me.btnPrintAdvert.Size = New System.Drawing.Size(114, 39)
        Me.btnPrintAdvert.TabIndex = 97
        Me.btnPrintAdvert.Text = "Print Advert. "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Sign"
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(14, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Integrated to Display on Sign:"
        '
        'Label86
        '
        Me.Label86.AutoSize = true
        Me.Label86.Location = New System.Drawing.Point(14, 199)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(40, 13)
        Me.Label86.TabIndex = 11
        Me.Label86.Text = "Depot:"
        '
        'btnMapMerge
        '
        Me.btnMapMerge.ImageOptions.Image = CType(resources.GetObject("btnMapMerge.ImageOptions.Image"),System.Drawing.Image)
        Me.btnMapMerge.Location = New System.Drawing.Point(322, 401)
        Me.btnMapMerge.Name = "btnMapMerge"
        Me.btnMapMerge.Size = New System.Drawing.Size(105, 39)
        Me.btnMapMerge.TabIndex = 103
        Me.btnMapMerge.Text = "Create DA "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Map Merge"
        Me.btnMapMerge.Visible = false
        '
        'btnSaveStatus
        '
        Me.btnSaveStatus.Enabled = false
        Me.btnSaveStatus.ImageOptions.Image = CType(resources.GetObject("btnSaveStatus.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveStatus.Location = New System.Drawing.Point(167, 467)
        Me.btnSaveStatus.Name = "btnSaveStatus"
        Me.btnSaveStatus.Size = New System.Drawing.Size(105, 39)
        Me.btnSaveStatus.TabIndex = 102
        Me.btnSaveStatus.Tag = "v"
        Me.btnSaveStatus.Text = "Save Status"
        '
        'btnEditStatus
        '
        Me.btnEditStatus.Enabled = false
        Me.btnEditStatus.ImageOptions.Image = CType(resources.GetObject("btnEditStatus.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditStatus.Location = New System.Drawing.Point(26, 467)
        Me.btnEditStatus.Name = "btnEditStatus"
        Me.btnEditStatus.Size = New System.Drawing.Size(105, 39)
        Me.btnEditStatus.TabIndex = 101
        Me.btnEditStatus.Text = "Edit Status"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.txtDaysTaken)
        Me.GroupBox18.Controls.Add(Me.txtDaysElapsed)
        Me.GroupBox18.Controls.Add(Me.txtDaysAddinfo)
        Me.GroupBox18.Controls.Add(Me.Label84)
        Me.GroupBox18.Controls.Add(Me.Label85)
        Me.GroupBox18.Controls.Add(Me.lblReferralCount)
        Me.GroupBox18.Controls.Add(Me.Label87)
        Me.GroupBox18.Controls.Add(Me.Label89)
        Me.GroupBox18.Controls.Add(Me.Label88)
        Me.GroupBox18.Location = New System.Drawing.Point(452, 299)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(418, 141)
        Me.GroupBox18.TabIndex = 93
        Me.GroupBox18.Text = "Statistics - Stop the Clock"
        '
        'txtDaysTaken
        '
        Me.txtDaysTaken.BackColor = System.Drawing.SystemColors.Info
        Me.txtDaysTaken.Location = New System.Drawing.Point(184, 74)
        Me.txtDaysTaken.Name = "txtDaysTaken"
        Me.txtDaysTaken.ReadOnly = true
        Me.txtDaysTaken.Size = New System.Drawing.Size(46, 21)
        Me.txtDaysTaken.TabIndex = 6
        Me.txtDaysTaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDaysElapsed
        '
        Me.txtDaysElapsed.BackColor = System.Drawing.SystemColors.Info
        Me.txtDaysElapsed.Location = New System.Drawing.Point(184, 27)
        Me.txtDaysElapsed.Name = "txtDaysElapsed"
        Me.txtDaysElapsed.ReadOnly = true
        Me.txtDaysElapsed.Size = New System.Drawing.Size(46, 21)
        Me.txtDaysElapsed.TabIndex = 4
        Me.txtDaysElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDaysAddinfo
        '
        Me.txtDaysAddinfo.BackColor = System.Drawing.SystemColors.Info
        Me.txtDaysAddinfo.Location = New System.Drawing.Point(184, 46)
        Me.txtDaysAddinfo.Name = "txtDaysAddinfo"
        Me.txtDaysAddinfo.ReadOnly = true
        Me.txtDaysAddinfo.Size = New System.Drawing.Size(46, 21)
        Me.txtDaysAddinfo.TabIndex = 5
        Me.txtDaysAddinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label84
        '
        Me.Label84.AutoSize = true
        Me.Label84.Location = New System.Drawing.Point(13, 30)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(166, 13)
        Me.Label84.TabIndex = 9
        Me.Label84.Text = "Days Elapsed (Determined-Rego)"
        '
        'Label85
        '
        Me.Label85.AutoSize = true
        Me.Label85.Location = New System.Drawing.Point(13, 54)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(121, 13)
        Me.Label85.TabIndex = 10
        Me.Label85.Text = "Days for Additional Info"
        '
        'lblReferralCount
        '
        Me.lblReferralCount.AutoSize = true
        Me.lblReferralCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblReferralCount.Location = New System.Drawing.Point(289, 82)
        Me.lblReferralCount.Name = "lblReferralCount"
        Me.lblReferralCount.Size = New System.Drawing.Size(14, 13)
        Me.lblReferralCount.TabIndex = 15
        Me.lblReferralCount.Text = "0"
        Me.lblReferralCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label87
        '
        Me.Label87.AutoSize = true
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label87.Location = New System.Drawing.Point(13, 77)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(147, 13)
        Me.Label87.TabIndex = 12
        Me.Label87.Text = "Days taken to Determine"
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label89.Location = New System.Drawing.Point(266, 46)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(122, 31)
        Me.Label89.TabIndex = 14
        Me.Label89.Text = "Days taken (nett) for returned Referrals"
        '
        'Label88
        '
        Me.Label88.AutoSize = true
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label88.Location = New System.Drawing.Point(266, 27)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(58, 13)
        Me.Label88.TabIndex = 13
        Me.Label88.Text = "Referrals"
        '
        'grpAssessment
        '
        Me.grpAssessment.Controls.Add(Me.Label72)
        Me.grpAssessment.Controls.Add(Me.Label71)
        Me.grpAssessment.Controls.Add(Me.Label70)
        Me.grpAssessment.Controls.Add(Me.Label69)
        Me.grpAssessment.Controls.Add(Me.Label68)
        Me.grpAssessment.Controls.Add(Me.DAToTypingDt)
        Me.grpAssessment.Controls.Add(Me.DAToPlannerDt)
        Me.grpAssessment.Controls.Add(Me.DASiteInspectedDt)
        Me.grpAssessment.Controls.Add(Me.PreAssessCompleteDate)
        Me.grpAssessment.Controls.Add(Me.RefToPlanCom)
        Me.grpAssessment.Location = New System.Drawing.Point(26, 20)
        Me.grpAssessment.Name = "grpAssessment"
        Me.grpAssessment.Size = New System.Drawing.Size(229, 121)
        Me.grpAssessment.TabIndex = 84
        Me.grpAssessment.Text = "Assessment"
        '
        'Label72
        '
        Me.Label72.AutoSize = true
        Me.Label72.Location = New System.Drawing.Point(11, 149)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(51, 13)
        Me.Label72.TabIndex = 11
        Me.Label72.Text = "To Typist"
        Me.Label72.Visible = false
        '
        'Label71
        '
        Me.Label71.AutoSize = true
        Me.Label71.Location = New System.Drawing.Point(11, 121)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(94, 13)
        Me.Label71.TabIndex = 10
        Me.Label71.Text = "Ref to Plan Cmtee"
        Me.Label71.Visible = false
        '
        'Label70
        '
        Me.Label70.AutoSize = true
        Me.Label70.Location = New System.Drawing.Point(11, 93)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(88, 13)
        Me.Label70.TabIndex = 9
        Me.Label70.Text = "PreAssess Compl"
        '
        'Label69
        '
        Me.Label69.AutoSize = true
        Me.Label69.Location = New System.Drawing.Point(11, 64)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(76, 13)
        Me.Label69.TabIndex = 8
        Me.Label69.Text = "Site Inspected"
        '
        'Label68
        '
        Me.Label68.AutoSize = true
        Me.Label68.Location = New System.Drawing.Point(11, 37)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(58, 13)
        Me.Label68.TabIndex = 7
        Me.Label68.Text = "To Planner"
        '
        'DAToTypingDt
        '
        Me.DAToTypingDt.EditValue = Nothing
        Me.DAToTypingDt.Location = New System.Drawing.Point(111, 146)
        Me.DAToTypingDt.Name = "DAToTypingDt"
        Me.DAToTypingDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAToTypingDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAToTypingDt.Properties.ReadOnly = true
        Me.DAToTypingDt.Size = New System.Drawing.Size(100, 20)
        Me.DAToTypingDt.TabIndex = 100
        Me.DAToTypingDt.Visible = false
        '
        'DAToPlannerDt
        '
        Me.DAToPlannerDt.EditValue = Nothing
        Me.DAToPlannerDt.Location = New System.Drawing.Point(111, 34)
        Me.DAToPlannerDt.Name = "DAToPlannerDt"
        Me.DAToPlannerDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAToPlannerDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAToPlannerDt.Properties.ReadOnly = true
        Me.DAToPlannerDt.Size = New System.Drawing.Size(100, 20)
        Me.DAToPlannerDt.TabIndex = 30
        '
        'DASiteInspectedDt
        '
        Me.DASiteInspectedDt.EditValue = Nothing
        Me.DASiteInspectedDt.Location = New System.Drawing.Point(111, 62)
        Me.DASiteInspectedDt.Name = "DASiteInspectedDt"
        Me.DASiteInspectedDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DASiteInspectedDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DASiteInspectedDt.Properties.ReadOnly = true
        Me.DASiteInspectedDt.Size = New System.Drawing.Size(100, 20)
        Me.DASiteInspectedDt.TabIndex = 97
        '
        'PreAssessCompleteDate
        '
        Me.PreAssessCompleteDate.EditValue = Nothing
        Me.PreAssessCompleteDate.Location = New System.Drawing.Point(111, 90)
        Me.PreAssessCompleteDate.Name = "PreAssessCompleteDate"
        Me.PreAssessCompleteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PreAssessCompleteDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PreAssessCompleteDate.Properties.ReadOnly = true
        Me.PreAssessCompleteDate.Size = New System.Drawing.Size(100, 20)
        Me.PreAssessCompleteDate.TabIndex = 98
        '
        'RefToPlanCom
        '
        Me.RefToPlanCom.EditValue = Nothing
        Me.RefToPlanCom.Location = New System.Drawing.Point(111, 118)
        Me.RefToPlanCom.Name = "RefToPlanCom"
        Me.RefToPlanCom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RefToPlanCom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RefToPlanCom.Properties.ReadOnly = true
        Me.RefToPlanCom.Size = New System.Drawing.Size(100, 20)
        Me.RefToPlanCom.TabIndex = 99
        Me.RefToPlanCom.Visible = false
        '
        'grpNotification
        '
        Me.grpNotification.Controls.Add(Me.DACompletedDt)
        Me.grpNotification.Controls.Add(Me.rbNotifyAdvert)
        Me.grpNotification.Controls.Add(Me.DACommDt)
        Me.grpNotification.Controls.Add(Me.rbNotify)
        Me.grpNotification.Controls.Add(Me.DAAdvisedDt)
        Me.grpNotification.Controls.Add(Me.rbNone)
        Me.grpNotification.Controls.Add(Me.Label93)
        Me.grpNotification.Controls.Add(Me.Label92)
        Me.grpNotification.Controls.Add(Me.Label91)
        Me.grpNotification.Location = New System.Drawing.Point(26, 301)
        Me.grpNotification.Name = "grpNotification"
        Me.grpNotification.Size = New System.Drawing.Size(290, 139)
        Me.grpNotification.TabIndex = 86
        Me.grpNotification.Text = "Notification"
        '
        'DACompletedDt
        '
        Me.DACompletedDt.EditValue = Nothing
        Me.DACompletedDt.Location = New System.Drawing.Point(165, 107)
        Me.DACompletedDt.Name = "DACompletedDt"
        Me.DACompletedDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DACompletedDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DACompletedDt.Properties.ReadOnly = true
        Me.DACompletedDt.Size = New System.Drawing.Size(100, 20)
        Me.DACompletedDt.TabIndex = 110
        '
        'rbNotifyAdvert
        '
        Me.rbNotifyAdvert.AutoSize = true
        Me.rbNotifyAdvert.Enabled = false
        Me.rbNotifyAdvert.Location = New System.Drawing.Point(177, 24)
        Me.rbNotifyAdvert.Name = "rbNotifyAdvert"
        Me.rbNotifyAdvert.Size = New System.Drawing.Size(103, 17)
        Me.rbNotifyAdvert.TabIndex = 8
        Me.rbNotifyAdvert.TabStop = true
        Me.rbNotifyAdvert.Text = "Notify + Advert'"
        Me.rbNotifyAdvert.UseVisualStyleBackColor = true
        '
        'DACommDt
        '
        Me.DACommDt.EditValue = Nothing
        Me.DACommDt.Location = New System.Drawing.Point(165, 78)
        Me.DACommDt.Name = "DACommDt"
        Me.DACommDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DACommDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DACommDt.Properties.ReadOnly = true
        Me.DACommDt.Size = New System.Drawing.Size(100, 20)
        Me.DACommDt.TabIndex = 109
        '
        'rbNotify
        '
        Me.rbNotify.AutoSize = true
        Me.rbNotify.Enabled = false
        Me.rbNotify.Location = New System.Drawing.Point(83, 24)
        Me.rbNotify.Name = "rbNotify"
        Me.rbNotify.Size = New System.Drawing.Size(79, 17)
        Me.rbNotify.TabIndex = 7
        Me.rbNotify.TabStop = true
        Me.rbNotify.Text = "Notify Only"
        Me.rbNotify.UseVisualStyleBackColor = true
        '
        'DAAdvisedDt
        '
        Me.DAAdvisedDt.EditValue = Nothing
        Me.DAAdvisedDt.Location = New System.Drawing.Point(165, 49)
        Me.DAAdvisedDt.Name = "DAAdvisedDt"
        Me.DAAdvisedDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAAdvisedDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAAdvisedDt.Properties.ReadOnly = true
        Me.DAAdvisedDt.Size = New System.Drawing.Size(100, 20)
        Me.DAAdvisedDt.TabIndex = 108
        '
        'rbNone
        '
        Me.rbNone.AutoSize = true
        Me.rbNone.Enabled = false
        Me.rbNone.Location = New System.Drawing.Point(14, 24)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(50, 17)
        Me.rbNone.TabIndex = 6
        Me.rbNone.TabStop = true
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = true
        '
        'Label93
        '
        Me.Label93.AutoSize = true
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label93.Location = New System.Drawing.Point(29, 110)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(126, 13)
        Me.Label93.TabIndex = 2
        Me.Label93.Text = "Close of Submissions"
        '
        'Label92
        '
        Me.Label92.AutoSize = true
        Me.Label92.Location = New System.Drawing.Point(29, 81)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(108, 13)
        Me.Label92.TabIndex = 1
        Me.Label92.Text = "Advert in Paper Date"
        '
        'Label91
        '
        Me.Label91.AutoSize = true
        Me.Label91.Location = New System.Drawing.Point(29, 52)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(96, 13)
        Me.Label91.TabIndex = 0
        Me.Label91.Text = "Letter to Adjoining"
        '
        'grpDetermination
        '
        Me.grpDetermination.Controls.Add(Me.DAPermExDt)
        Me.grpDetermination.Controls.Add(Me.cboProgressCode)
        Me.grpDetermination.Controls.Add(Me.DAOccDt)
        Me.grpDetermination.Controls.Add(Me.cboReasonOver40)
        Me.grpDetermination.Controls.Add(Me.DAConsentPubDt)
        Me.grpDetermination.Controls.Add(Me.chkAPZYesNo)
        Me.grpDetermination.Controls.Add(Me.cboDADecisionId)
        Me.grpDetermination.Controls.Add(Me.cboDAAuthorityId)
        Me.grpDetermination.Controls.Add(Me.DAFreeTreeDt)
        Me.grpDetermination.Controls.Add(Me.Label58)
        Me.grpDetermination.Controls.Add(Me.ConsentPostedDate)
        Me.grpDetermination.Controls.Add(Me.Label57)
        Me.grpDetermination.Controls.Add(Me.DAAppNotDt)
        Me.grpDetermination.Controls.Add(Me.Label82)
        Me.grpDetermination.Controls.Add(Me.DADetermDt)
        Me.grpDetermination.Controls.Add(Me.Label81)
        Me.grpDetermination.Controls.Add(Me.Label80)
        Me.grpDetermination.Controls.Add(Me.Label79)
        Me.grpDetermination.Controls.Add(Me.Label78)
        Me.grpDetermination.Controls.Add(Me.Label77)
        Me.grpDetermination.Controls.Add(Me.Label76)
        Me.grpDetermination.Controls.Add(Me.Label75)
        Me.grpDetermination.Controls.Add(Me.Label74)
        Me.grpDetermination.Controls.Add(Me.Label73)
        Me.grpDetermination.Controls.Add(Me.txtProgressComment)
        Me.grpDetermination.Location = New System.Drawing.Point(261, 20)
        Me.grpDetermination.Name = "grpDetermination"
        Me.grpDetermination.Size = New System.Drawing.Size(609, 249)
        Me.grpDetermination.TabIndex = 85
        Me.grpDetermination.Text = "Determination"
        '
        'DAPermExDt
        '
        Me.DAPermExDt.EditValue = Nothing
        Me.DAPermExDt.Location = New System.Drawing.Point(125, 196)
        Me.DAPermExDt.Name = "DAPermExDt"
        Me.DAPermExDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAPermExDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAPermExDt.Properties.ReadOnly = true
        Me.DAPermExDt.Size = New System.Drawing.Size(100, 20)
        Me.DAPermExDt.TabIndex = 107
        '
        'cboProgressCode
        '
        Me.cboProgressCode.Location = New System.Drawing.Point(330, 216)
        Me.cboProgressCode.Name = "cboProgressCode"
        Me.cboProgressCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProgressCode.Properties.NullText = "[Select Progress Code]"
        Me.cboProgressCode.Size = New System.Drawing.Size(269, 20)
        Me.cboProgressCode.TabIndex = 107
        '
        'DAOccDt
        '
        Me.DAOccDt.EditValue = Nothing
        Me.DAOccDt.Location = New System.Drawing.Point(125, 168)
        Me.DAOccDt.Name = "DAOccDt"
        Me.DAOccDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAOccDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAOccDt.Properties.ReadOnly = true
        Me.DAOccDt.Size = New System.Drawing.Size(100, 20)
        Me.DAOccDt.TabIndex = 106
        '
        'cboReasonOver40
        '
        Me.cboReasonOver40.Location = New System.Drawing.Point(425, 182)
        Me.cboReasonOver40.Name = "cboReasonOver40"
        Me.cboReasonOver40.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReasonOver40.Properties.NullText = "[Select Reason]"
        Me.cboReasonOver40.Size = New System.Drawing.Size(174, 20)
        Me.cboReasonOver40.TabIndex = 106
        '
        'DAConsentPubDt
        '
        Me.DAConsentPubDt.EditValue = Nothing
        Me.DAConsentPubDt.Location = New System.Drawing.Point(125, 140)
        Me.DAConsentPubDt.Name = "DAConsentPubDt"
        Me.DAConsentPubDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAConsentPubDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAConsentPubDt.Properties.ReadOnly = true
        Me.DAConsentPubDt.Size = New System.Drawing.Size(100, 20)
        Me.DAConsentPubDt.TabIndex = 105
        '
        'chkAPZYesNo
        '
        Me.chkAPZYesNo.AutoSize = true
        Me.chkAPZYesNo.Enabled = false
        Me.chkAPZYesNo.Location = New System.Drawing.Point(323, 80)
        Me.chkAPZYesNo.Name = "chkAPZYesNo"
        Me.chkAPZYesNo.Size = New System.Drawing.Size(203, 17)
        Me.chkAPZYesNo.TabIndex = 22
        Me.chkAPZYesNo.Text = "Asset Protection Zone (APZ) applies?"
        Me.chkAPZYesNo.UseVisualStyleBackColor = true
        '
        'cboDADecisionId
        '
        Me.cboDADecisionId.Location = New System.Drawing.Point(323, 51)
        Me.cboDADecisionId.Name = "cboDADecisionId"
        Me.cboDADecisionId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDADecisionId.Properties.NullText = "[Select Status]"
        Me.cboDADecisionId.Size = New System.Drawing.Size(201, 20)
        Me.cboDADecisionId.TabIndex = 105
        '
        'cboDAAuthorityId
        '
        Me.cboDAAuthorityId.Location = New System.Drawing.Point(323, 28)
        Me.cboDAAuthorityId.Name = "cboDAAuthorityId"
        Me.cboDAAuthorityId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAAuthorityId.Properties.NullText = "[Select Approval Authority]"
        Me.cboDAAuthorityId.Size = New System.Drawing.Size(276, 20)
        Me.cboDAAuthorityId.TabIndex = 104
        '
        'DAFreeTreeDt
        '
        Me.DAFreeTreeDt.EditValue = Nothing
        Me.DAFreeTreeDt.Location = New System.Drawing.Point(125, 112)
        Me.DAFreeTreeDt.Name = "DAFreeTreeDt"
        Me.DAFreeTreeDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAFreeTreeDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAFreeTreeDt.Properties.ReadOnly = true
        Me.DAFreeTreeDt.Size = New System.Drawing.Size(100, 20)
        Me.DAFreeTreeDt.TabIndex = 104
        Me.DAFreeTreeDt.Visible = false
        '
        'Label58
        '
        Me.Label58.AutoSize = true
        Me.Label58.Location = New System.Drawing.Point(280, 54)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(38, 13)
        Me.Label58.TabIndex = 21
        Me.Label58.Text = "Status"
        '
        'ConsentPostedDate
        '
        Me.ConsentPostedDate.EditValue = Nothing
        Me.ConsentPostedDate.Location = New System.Drawing.Point(125, 84)
        Me.ConsentPostedDate.Name = "ConsentPostedDate"
        Me.ConsentPostedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConsentPostedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConsentPostedDate.Properties.ReadOnly = true
        Me.ConsentPostedDate.Size = New System.Drawing.Size(100, 20)
        Me.ConsentPostedDate.TabIndex = 103
        '
        'Label57
        '
        Me.Label57.AutoSize = true
        Me.Label57.Location = New System.Drawing.Point(242, 31)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(77, 13)
        Me.Label57.TabIndex = 20
        Me.Label57.Text = "Determined by"
        '
        'DAAppNotDt
        '
        Me.DAAppNotDt.EditValue = Nothing
        Me.DAAppNotDt.Location = New System.Drawing.Point(125, 56)
        Me.DAAppNotDt.Name = "DAAppNotDt"
        Me.DAAppNotDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAAppNotDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAAppNotDt.Properties.ReadOnly = true
        Me.DAAppNotDt.Size = New System.Drawing.Size(100, 20)
        Me.DAAppNotDt.TabIndex = 102
        '
        'Label82
        '
        Me.Label82.AutoSize = true
        Me.Label82.Location = New System.Drawing.Point(245, 185)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(180, 13)
        Me.Label82.TabIndex = 19
        Me.Label82.Text = "Reason why DA approval > 40 days"
        '
        'DADetermDt
        '
        Me.DADetermDt.EditValue = Nothing
        Me.DADetermDt.Location = New System.Drawing.Point(125, 28)
        Me.DADetermDt.Name = "DADetermDt"
        Me.DADetermDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DADetermDt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DADetermDt.Properties.ReadOnly = true
        Me.DADetermDt.Size = New System.Drawing.Size(100, 20)
        Me.DADetermDt.TabIndex = 101
        '
        'Label81
        '
        Me.Label81.AutoSize = true
        Me.Label81.Location = New System.Drawing.Point(248, 108)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(140, 13)
        Me.Label81.TabIndex = 18
        Me.Label81.Text = "Officer's Progress Comment"
        '
        'Label80
        '
        Me.Label80.AutoSize = true
        Me.Label80.Location = New System.Drawing.Point(248, 219)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(77, 13)
        Me.Label80.TabIndex = 17
        Me.Label80.Text = "Progress Code"
        '
        'Label79
        '
        Me.Label79.AutoSize = true
        Me.Label79.Location = New System.Drawing.Point(10, 199)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(100, 13)
        Me.Label79.TabIndex = 16
        Me.Label79.Text = "Consent Lapses On"
        '
        'Label78
        '
        Me.Label78.AutoSize = true
        Me.Label78.Location = New System.Drawing.Point(10, 171)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(64, 13)
        Me.Label78.TabIndex = 15
        Me.Label78.Text = "Occupation "
        '
        'Label77
        '
        Me.Label77.AutoSize = true
        Me.Label77.Location = New System.Drawing.Point(10, 143)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(95, 13)
        Me.Label77.TabIndex = 14
        Me.Label77.Text = "Consent Published"
        '
        'Label76
        '
        Me.Label76.AutoSize = true
        Me.Label76.Location = New System.Drawing.Point(10, 115)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(99, 13)
        Me.Label76.TabIndex = 13
        Me.Label76.Text = "Tree Voucher Sent "
        Me.Label76.Visible = false
        '
        'Label75
        '
        Me.Label75.AutoSize = true
        Me.Label75.Location = New System.Drawing.Point(10, 87)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(110, 13)
        Me.Label75.TabIndex = 12
        Me.Label75.Text = "Determination Posted"
        '
        'Label74
        '
        Me.Label74.AutoSize = true
        Me.Label74.Location = New System.Drawing.Point(10, 59)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(105, 13)
        Me.Label74.TabIndex = 11
        Me.Label74.Text = "Consent Letter Date"
        '
        'Label73
        '
        Me.Label73.AutoSize = true
        Me.Label73.Location = New System.Drawing.Point(10, 31)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(88, 13)
        Me.Label73.TabIndex = 10
        Me.Label73.Text = "Date Determined"
        '
        'txtProgressComment
        '
        Me.txtProgressComment.BackColor = System.Drawing.SystemColors.Info
        Me.txtProgressComment.Location = New System.Drawing.Point(248, 122)
        Me.txtProgressComment.Multiline = true
        Me.txtProgressComment.Name = "txtProgressComment"
        Me.txtProgressComment.ReadOnly = true
        Me.txtProgressComment.Size = New System.Drawing.Size(351, 46)
        Me.txtProgressComment.TabIndex = 7
        '
        'tpgDocuments
        '
        Me.tpgDocuments.Controls.Add(Me.pnlDisplayDocs)
        Me.tpgDocuments.ImageOptions.Image = CType(resources.GetObject("tpgDocuments.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgDocuments.Name = "tpgDocuments"
        Me.tpgDocuments.Size = New System.Drawing.Size(1423, 721)
        Me.tpgDocuments.Text = "Documents"
        '
        'pnlDisplayDocs
        '
        Me.pnlDisplayDocs.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDisplayDocs.Appearance.Options.UseBackColor = true
        Me.pnlDisplayDocs.Controls.Add(Me.btnAddExistingRecordDocument)
        Me.pnlDisplayDocs.Controls.Add(Me.GroupBox32)
        Me.pnlDisplayDocs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayDocs.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayDocs.Name = "pnlDisplayDocs"
        Me.pnlDisplayDocs.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayDocs.TabIndex = 21
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.btnSaveTheNote)
        Me.GroupBox32.Controls.Add(Me.btnRemoveDocument)
        Me.GroupBox32.Controls.Add(Me.btnViewPDF)
        Me.GroupBox32.Controls.Add(Me.btnViewWord)
        Me.GroupBox32.Controls.Add(Me.grdDocumentsList)
        Me.GroupBox32.Controls.Add(Me.Label102)
        Me.GroupBox32.Controls.Add(Me.txtDocNote)
        Me.GroupBox32.Location = New System.Drawing.Point(21, 13)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(967, 610)
        Me.GroupBox32.TabIndex = 32
        Me.GroupBox32.Text = "Historical Documents"
        '
        'btnSaveTheNote
        '
        Me.btnSaveTheNote.ImageOptions.Image = CType(resources.GetObject("btnSaveTheNote.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveTheNote.Location = New System.Drawing.Point(405, 557)
        Me.btnSaveTheNote.Name = "btnSaveTheNote"
        Me.btnSaveTheNote.Size = New System.Drawing.Size(111, 35)
        Me.btnSaveTheNote.TabIndex = 10
        Me.btnSaveTheNote.Text = "Save Note"
        '
        'btnRemoveDocument
        '
        Me.btnRemoveDocument.Enabled = false
        Me.btnRemoveDocument.ImageOptions.Image = CType(resources.GetObject("btnRemoveDocument.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveDocument.Location = New System.Drawing.Point(599, 557)
        Me.btnRemoveDocument.Name = "btnRemoveDocument"
        Me.btnRemoveDocument.Size = New System.Drawing.Size(111, 35)
        Me.btnRemoveDocument.TabIndex = 9
        Me.btnRemoveDocument.Text = "Remove"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Document"
        '
        'btnViewPDF
        '
        Me.btnViewPDF.Enabled = false
        Me.btnViewPDF.ImageOptions.Image = CType(resources.GetObject("btnViewPDF.ImageOptions.Image"),System.Drawing.Image)
        Me.btnViewPDF.Location = New System.Drawing.Point(716, 557)
        Me.btnViewPDF.Name = "btnViewPDF"
        Me.btnViewPDF.Size = New System.Drawing.Size(111, 35)
        Me.btnViewPDF.TabIndex = 8
        Me.btnViewPDF.Text = "View PDF"
        '
        'btnViewWord
        '
        Me.btnViewWord.Enabled = false
        Me.btnViewWord.ImageOptions.Image = CType(resources.GetObject("btnViewWord.ImageOptions.Image"),System.Drawing.Image)
        Me.btnViewWord.Location = New System.Drawing.Point(839, 557)
        Me.btnViewWord.Name = "btnViewWord"
        Me.btnViewWord.Size = New System.Drawing.Size(111, 35)
        Me.btnViewWord.TabIndex = 7
        Me.btnViewWord.Text = "Open "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Word Doc"
        '
        'grdDocumentsList
        '
        Me.grdDocumentsList.Location = New System.Drawing.Point(20, 33)
        Me.grdDocumentsList.MainView = Me.gvwDocumentsList
        Me.grdDocumentsList.Name = "grdDocumentsList"
        Me.grdDocumentsList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.grdDocumentsList.Size = New System.Drawing.Size(930, 518)
        Me.grdDocumentsList.TabIndex = 6
        Me.grdDocumentsList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDocumentsList})
        '
        'gvwDocumentsList
        '
        Me.gvwDocumentsList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colApNo, Me.colApType, Me.colFileName, Me.colFullname, Me.colDocumentDesc, Me.colDateCreated, Me.colDocnotes, Me.colDocMTH, Me.colDocYr, Me.colDocId, Me.colWORDDOC})
        Me.gvwDocumentsList.GridControl = Me.grdDocumentsList
        Me.gvwDocumentsList.Name = "gvwDocumentsList"
        Me.gvwDocumentsList.OptionsBehavior.Editable = false
        Me.gvwDocumentsList.OptionsBehavior.ReadOnly = true
        Me.gvwDocumentsList.OptionsFind.AlwaysVisible = true
        Me.gvwDocumentsList.OptionsView.ShowGroupPanel = false
        '
        'colApNo
        '
        Me.colApNo.Caption = "App#"
        Me.colApNo.FieldName = "ApNo"
        Me.colApNo.Name = "colApNo"
        '
        'colApType
        '
        Me.colApType.Caption = "Type"
        Me.colApType.FieldName = "ApType"
        Me.colApType.Name = "colApType"
        '
        'colFileName
        '
        Me.colFileName.Caption = "FileName"
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.Name = "colFileName"
        '
        'colFullname
        '
        Me.colFullname.Caption = "Author"
        Me.colFullname.FieldName = "Fullname"
        Me.colFullname.Name = "colFullname"
        Me.colFullname.Width = 117
        '
        'colDocumentDesc
        '
        Me.colDocumentDesc.Caption = "Document"
        Me.colDocumentDesc.FieldName = "DocumentDesc"
        Me.colDocumentDesc.Name = "colDocumentDesc"
        Me.colDocumentDesc.Visible = true
        Me.colDocumentDesc.VisibleIndex = 0
        Me.colDocumentDesc.Width = 177
        '
        'colDateCreated
        '
        Me.colDateCreated.Caption = "Created"
        Me.colDateCreated.FieldName = "DateCreated"
        Me.colDateCreated.Name = "colDateCreated"
        Me.colDateCreated.Visible = true
        Me.colDateCreated.VisibleIndex = 1
        Me.colDateCreated.Width = 89
        '
        'colDocnotes
        '
        Me.colDocnotes.Caption = "Notes"
        Me.colDocnotes.FieldName = "notes"
        Me.colDocnotes.Name = "colDocnotes"
        Me.colDocnotes.Visible = true
        Me.colDocnotes.VisibleIndex = 2
        Me.colDocnotes.Width = 527
        '
        'colDocMTH
        '
        Me.colDocMTH.Caption = "mth"
        Me.colDocMTH.FieldName = "DocMTH"
        Me.colDocMTH.Name = "colDocMTH"
        '
        'colDocYr
        '
        Me.colDocYr.Caption = "year"
        Me.colDocYr.FieldName = "DocYr"
        Me.colDocYr.Name = "colDocYr"
        '
        'colDocId
        '
        Me.colDocId.Caption = "doc"
        Me.colDocId.FieldName = "DocId"
        Me.colDocId.Name = "colDocId"
        '
        'colWORDDOC
        '
        Me.colWORDDOC.Caption = "WordDoc"
        Me.colWORDDOC.FieldName = "WORDDOC"
        Me.colWORDDOC.Name = "colWORDDOC"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.InitialImageOptions.Image = CType(resources.GetObject("RepositoryItemPictureEdit1.InitialImageOptions.Image"),System.Drawing.Image)
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'Label102
        '
        Me.Label102.AutoSize = true
        Me.Label102.Location = New System.Drawing.Point(23, 569)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(34, 13)
        Me.Label102.TabIndex = 2
        Me.Label102.Text = "Note:"
        '
        'txtDocNote
        '
        Me.txtDocNote.Location = New System.Drawing.Point(62, 565)
        Me.txtDocNote.Name = "txtDocNote"
        Me.txtDocNote.Size = New System.Drawing.Size(331, 21)
        Me.txtDocNote.TabIndex = 1
        '
        'tpgVariations
        '
        Me.tpgVariations.Controls.Add(Me.pnlDisplayVariations)
        Me.tpgVariations.ImageOptions.Image = CType(resources.GetObject("tpgVariations.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgVariations.Name = "tpgVariations"
        Me.tpgVariations.Size = New System.Drawing.Size(1423, 721)
        Me.tpgVariations.Text = "Variations"
        '
        'pnlDisplayVariations
        '
        Me.pnlDisplayVariations.Controls.Add(Me.GroupBox28)
        Me.pnlDisplayVariations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayVariations.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayVariations.Name = "pnlDisplayVariations"
        Me.pnlDisplayVariations.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayVariations.TabIndex = 24
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.grdVariations)
        Me.GroupBox28.Controls.Add(Me.GroupBox8)
        Me.GroupBox28.Controls.Add(Me.GroupBox29)
        Me.GroupBox28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox28.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(1419, 717)
        Me.GroupBox28.TabIndex = 1
        Me.GroupBox28.Text = "Variation/s:"
        '
        'grdVariations
        '
        Me.grdVariations.Location = New System.Drawing.Point(23, 32)
        Me.grdVariations.MainView = Me.gvwVariations
        Me.grdVariations.Name = "grdVariations"
        Me.grdVariations.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5})
        Me.grdVariations.Size = New System.Drawing.Size(875, 373)
        Me.grdVariations.TabIndex = 3
        Me.grdVariations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVariations})
        '
        'gvwVariations
        '
        Me.gvwVariations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVarID, Me.colVariation, Me.colVariationdetail, Me.colVariationResultDesc, Me.colDelegatedAuthority, Me.colDecisionDate, Me.colUserStamp, Me.colType})
        Me.gvwVariations.GridControl = Me.grdVariations
        Me.gvwVariations.Name = "gvwVariations"
        Me.gvwVariations.OptionsBehavior.ReadOnly = true
        Me.gvwVariations.OptionsView.ShowGroupPanel = false
        Me.gvwVariations.RowHeight = 50
        '
        'colVarID
        '
        Me.colVarID.Caption = "id"
        Me.colVarID.FieldName = "id"
        Me.colVarID.Name = "colVarID"
        '
        'colVariation
        '
        Me.colVariation.AppearanceCell.Options.UseTextOptions = true
        Me.colVariation.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colVariation.Caption = "Type"
        Me.colVariation.FieldName = "Variation"
        Me.colVariation.Name = "colVariation"
        Me.colVariation.OptionsColumn.AllowEdit = false
        Me.colVariation.OptionsColumn.ReadOnly = true
        Me.colVariation.Visible = true
        Me.colVariation.VisibleIndex = 0
        Me.colVariation.Width = 99
        '
        'colVariationdetail
        '
        Me.colVariationdetail.Caption = "Details"
        Me.colVariationdetail.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.colVariationdetail.FieldName = "detail"
        Me.colVariationdetail.Name = "colVariationdetail"
        Me.colVariationdetail.Visible = true
        Me.colVariationdetail.VisibleIndex = 1
        Me.colVariationdetail.Width = 385
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'colVariationResultDesc
        '
        Me.colVariationResultDesc.AppearanceCell.Options.UseTextOptions = true
        Me.colVariationResultDesc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colVariationResultDesc.Caption = "Result"
        Me.colVariationResultDesc.ColumnEdit = Me.RepositoryItemMemoEdit5
        Me.colVariationResultDesc.FieldName = "VariationResultDesc"
        Me.colVariationResultDesc.Name = "colVariationResultDesc"
        Me.colVariationResultDesc.OptionsColumn.AllowEdit = false
        Me.colVariationResultDesc.OptionsColumn.ReadOnly = true
        Me.colVariationResultDesc.Visible = true
        Me.colVariationResultDesc.VisibleIndex = 2
        Me.colVariationResultDesc.Width = 92
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        Me.RepositoryItemMemoEdit5.ReadOnly = true
        Me.RepositoryItemMemoEdit5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        '
        'colDelegatedAuthority
        '
        Me.colDelegatedAuthority.AppearanceCell.Options.UseTextOptions = true
        Me.colDelegatedAuthority.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDelegatedAuthority.Caption = "Authority"
        Me.colDelegatedAuthority.FieldName = "DelegatedAuthority"
        Me.colDelegatedAuthority.Name = "colDelegatedAuthority"
        Me.colDelegatedAuthority.OptionsColumn.AllowEdit = false
        Me.colDelegatedAuthority.OptionsColumn.ReadOnly = true
        Me.colDelegatedAuthority.Visible = true
        Me.colDelegatedAuthority.VisibleIndex = 3
        Me.colDelegatedAuthority.Width = 92
        '
        'colDecisionDate
        '
        Me.colDecisionDate.AppearanceCell.Options.UseTextOptions = true
        Me.colDecisionDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDecisionDate.Caption = "Decision"
        Me.colDecisionDate.FieldName = "DecisionDate"
        Me.colDecisionDate.Name = "colDecisionDate"
        Me.colDecisionDate.OptionsColumn.AllowEdit = false
        Me.colDecisionDate.OptionsColumn.ReadOnly = true
        Me.colDecisionDate.Visible = true
        Me.colDecisionDate.VisibleIndex = 4
        Me.colDecisionDate.Width = 92
        '
        'colUserStamp
        '
        Me.colUserStamp.AppearanceCell.Options.UseTextOptions = true
        Me.colUserStamp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colUserStamp.Caption = "User Stamp"
        Me.colUserStamp.FieldName = "UserStamp"
        Me.colUserStamp.Name = "colUserStamp"
        Me.colUserStamp.OptionsColumn.AllowEdit = false
        Me.colUserStamp.OptionsColumn.ReadOnly = true
        Me.colUserStamp.Visible = true
        Me.colUserStamp.VisibleIndex = 5
        Me.colUserStamp.Width = 99
        '
        'colType
        '
        Me.colType.Caption = "GridColumn13"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboVariationAuthority)
        Me.GroupBox8.Controls.Add(Me.cboVariationResult)
        Me.GroupBox8.Controls.Add(Me.btnSaveVariationResponse)
        Me.GroupBox8.Controls.Add(Me.btneditVariationResponse)
        Me.GroupBox8.Controls.Add(Me.variationDecisionDate)
        Me.GroupBox8.Controls.Add(Me.Label100)
        Me.GroupBox8.Controls.Add(Me.Label99)
        Me.GroupBox8.Controls.Add(Me.Label101)
        Me.GroupBox8.Location = New System.Drawing.Point(911, 32)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(284, 168)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = false
        Me.GroupBox8.Text = "Response"
        '
        'cboVariationAuthority
        '
        Me.cboVariationAuthority.Location = New System.Drawing.Point(14, 84)
        Me.cboVariationAuthority.Name = "cboVariationAuthority"
        Me.cboVariationAuthority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVariationAuthority.Properties.NullText = "[Select Authority]"
        Me.cboVariationAuthority.Properties.ReadOnly = true
        Me.cboVariationAuthority.Size = New System.Drawing.Size(150, 20)
        Me.cboVariationAuthority.TabIndex = 46
        '
        'cboVariationResult
        '
        Me.cboVariationResult.Location = New System.Drawing.Point(14, 40)
        Me.cboVariationResult.Name = "cboVariationResult"
        Me.cboVariationResult.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVariationResult.Properties.NullText = "[Select Result]"
        Me.cboVariationResult.Properties.ReadOnly = true
        Me.cboVariationResult.Size = New System.Drawing.Size(150, 20)
        Me.cboVariationResult.TabIndex = 45
        '
        'btnSaveVariationResponse
        '
        Me.btnSaveVariationResponse.Enabled = false
        Me.btnSaveVariationResponse.ImageOptions.Image = CType(resources.GetObject("btnSaveVariationResponse.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveVariationResponse.Location = New System.Drawing.Point(186, 114)
        Me.btnSaveVariationResponse.Name = "btnSaveVariationResponse"
        Me.btnSaveVariationResponse.Size = New System.Drawing.Size(84, 37)
        Me.btnSaveVariationResponse.TabIndex = 44
        Me.btnSaveVariationResponse.Text = "Save"
        '
        'btneditVariationResponse
        '
        Me.btneditVariationResponse.Enabled = false
        Me.btneditVariationResponse.ImageOptions.Image = CType(resources.GetObject("btneditVariationResponse.ImageOptions.Image"),System.Drawing.Image)
        Me.btneditVariationResponse.Location = New System.Drawing.Point(186, 23)
        Me.btneditVariationResponse.Name = "btneditVariationResponse"
        Me.btneditVariationResponse.Size = New System.Drawing.Size(84, 37)
        Me.btneditVariationResponse.TabIndex = 43
        Me.btneditVariationResponse.Text = "Change"
        '
        'variationDecisionDate
        '
        Me.variationDecisionDate.EditValue = Nothing
        Me.variationDecisionDate.Location = New System.Drawing.Point(14, 131)
        Me.variationDecisionDate.Name = "variationDecisionDate"
        Me.variationDecisionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.variationDecisionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.variationDecisionDate.Size = New System.Drawing.Size(100, 20)
        Me.variationDecisionDate.TabIndex = 42
        '
        'Label100
        '
        Me.Label100.AutoSize = true
        Me.Label100.Location = New System.Drawing.Point(14, 67)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(56, 13)
        Me.Label100.TabIndex = 36
        Me.Label100.Text = "Authority:"
        '
        'Label99
        '
        Me.Label99.AutoSize = true
        Me.Label99.Location = New System.Drawing.Point(14, 22)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(41, 13)
        Me.Label99.TabIndex = 35
        Me.Label99.Text = "Result:"
        '
        'Label101
        '
        Me.Label101.AutoSize = true
        Me.Label101.Location = New System.Drawing.Point(14, 110)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(76, 13)
        Me.Label101.TabIndex = 37
        Me.Label101.Text = "Decision Date:"
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.cboVariationType)
        Me.GroupBox29.Controls.Add(Me.btnRemoveVariation)
        Me.GroupBox29.Controls.Add(Me.btnSaveVariation)
        Me.GroupBox29.Controls.Add(Me.btnEditVariation)
        Me.GroupBox29.Controls.Add(Me.btnAddVariation)
        Me.GroupBox29.Controls.Add(Me.btnAddNewVariationType)
        Me.GroupBox29.Controls.Add(Me.lblID)
        Me.GroupBox29.Controls.Add(Me.Label98)
        Me.GroupBox29.Controls.Add(Me.Label97)
        Me.GroupBox29.Controls.Add(Me.txtVariationDetails)
        Me.GroupBox29.Location = New System.Drawing.Point(23, 416)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(801, 237)
        Me.GroupBox29.TabIndex = 1
        Me.GroupBox29.TabStop = false
        '
        'cboVariationType
        '
        Me.cboVariationType.Location = New System.Drawing.Point(8, 33)
        Me.cboVariationType.Name = "cboVariationType"
        Me.cboVariationType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVariationType.Properties.NullText = "[Select Variation Type]"
        Me.cboVariationType.Properties.ReadOnly = true
        Me.cboVariationType.Size = New System.Drawing.Size(175, 20)
        Me.cboVariationType.TabIndex = 49
        '
        'btnRemoveVariation
        '
        Me.btnRemoveVariation.Enabled = false
        Me.btnRemoveVariation.ImageOptions.Image = CType(resources.GetObject("btnRemoveVariation.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveVariation.Location = New System.Drawing.Point(229, 184)
        Me.btnRemoveVariation.Name = "btnRemoveVariation"
        Me.btnRemoveVariation.Size = New System.Drawing.Size(99, 38)
        Me.btnRemoveVariation.TabIndex = 48
        Me.btnRemoveVariation.Text = "Remove"
        '
        'btnSaveVariation
        '
        Me.btnSaveVariation.Enabled = false
        Me.btnSaveVariation.ImageOptions.Image = CType(resources.GetObject("btnSaveVariation.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveVariation.Location = New System.Drawing.Point(345, 184)
        Me.btnSaveVariation.Name = "btnSaveVariation"
        Me.btnSaveVariation.Size = New System.Drawing.Size(99, 38)
        Me.btnSaveVariation.TabIndex = 47
        Me.btnSaveVariation.Text = "Save"
        '
        'btnEditVariation
        '
        Me.btnEditVariation.Enabled = false
        Me.btnEditVariation.ImageOptions.Image = CType(resources.GetObject("btnEditVariation.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditVariation.Location = New System.Drawing.Point(120, 184)
        Me.btnEditVariation.Name = "btnEditVariation"
        Me.btnEditVariation.Size = New System.Drawing.Size(99, 38)
        Me.btnEditVariation.TabIndex = 46
        Me.btnEditVariation.Text = "Change"
        '
        'btnAddVariation
        '
        Me.btnAddVariation.ImageOptions.Image = CType(resources.GetObject("btnAddVariation.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddVariation.Location = New System.Drawing.Point(15, 184)
        Me.btnAddVariation.Name = "btnAddVariation"
        Me.btnAddVariation.Size = New System.Drawing.Size(99, 38)
        Me.btnAddVariation.TabIndex = 45
        Me.btnAddVariation.Text = "Add"
        '
        'btnAddNewVariationType
        '
        Me.btnAddNewVariationType.ImageOptions.Image = CType(resources.GetObject("btnAddNewVariationType.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddNewVariationType.Location = New System.Drawing.Point(8, 60)
        Me.btnAddNewVariationType.Name = "btnAddNewVariationType"
        Me.btnAddNewVariationType.Size = New System.Drawing.Size(120, 35)
        Me.btnAddNewVariationType.TabIndex = 44
        Me.btnAddNewVariationType.Text = "Add New"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" ""Type"" Code"
        '
        'lblID
        '
        Me.lblID.AutoSize = true
        Me.lblID.ForeColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(471, 82)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 42
        '
        'Label98
        '
        Me.Label98.AutoSize = true
        Me.Label98.Location = New System.Drawing.Point(186, 18)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(97, 13)
        Me.Label98.TabIndex = 34
        Me.Label98.Text = "Details/Comments:"
        '
        'Label97
        '
        Me.Label97.AutoSize = true
        Me.Label97.Location = New System.Drawing.Point(9, 16)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(80, 13)
        Me.Label97.TabIndex = 33
        Me.Label97.Text = "Variation Type:"
        '
        'txtVariationDetails
        '
        Me.txtVariationDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVariationDetails.Location = New System.Drawing.Point(189, 34)
        Me.txtVariationDetails.Multiline = true
        Me.txtVariationDetails.Name = "txtVariationDetails"
        Me.txtVariationDetails.ReadOnly = true
        Me.txtVariationDetails.Size = New System.Drawing.Size(590, 133)
        Me.txtVariationDetails.TabIndex = 1
        '
        'tpgSubmissions
        '
        Me.tpgSubmissions.Controls.Add(Me.pnlDisplaySubmisions)
        Me.tpgSubmissions.ImageOptions.Image = CType(resources.GetObject("tpgSubmissions.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgSubmissions.Name = "tpgSubmissions"
        Me.tpgSubmissions.Size = New System.Drawing.Size(1423, 721)
        Me.tpgSubmissions.Text = "Submissions"
        '
        'pnlDisplaySubmisions
        '
        Me.pnlDisplaySubmisions.Controls.Add(DACompletedDtLabel1)
        Me.pnlDisplaySubmisions.Controls.Add(Me.DACompletedDtLabel2)
        Me.pnlDisplaySubmisions.Controls.Add(Me.GroupBox30)
        Me.pnlDisplaySubmisions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplaySubmisions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pnlDisplaySubmisions.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplaySubmisions.Name = "pnlDisplaySubmisions"
        Me.pnlDisplaySubmisions.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplaySubmisions.TabIndex = 25
        '
        'DACompletedDtLabel2
        '
        Me.DACompletedDtLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DACompletedDtLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DACompletedDtLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DACompletedDtLabel2.Location = New System.Drawing.Point(472, 12)
        Me.DACompletedDtLabel2.Name = "DACompletedDtLabel2"
        Me.DACompletedDtLabel2.Size = New System.Drawing.Size(111, 23)
        Me.DACompletedDtLabel2.TabIndex = 6
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.GroupControl8)
        Me.GroupBox30.Controls.Add(Me.grdSubmissionandObjections)
        Me.GroupBox30.Controls.Add(Me.GroupBox31)
        Me.GroupBox30.Location = New System.Drawing.Point(11, 42)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(1163, 631)
        Me.GroupBox30.TabIndex = 4
        Me.GroupBox30.Text = "Submissions Received"
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.btnEmailAcknowledgement)
        Me.GroupControl8.Controls.Add(Me.btnFinaliseSubmission)
        Me.GroupControl8.Controls.Add(Me.btnDeleteSubmission)
        Me.GroupControl8.Controls.Add(Me.btnEditSubmision)
        Me.GroupControl8.Controls.Add(Me.grdSubmissionDrafts)
        Me.GroupControl8.Location = New System.Drawing.Point(15, 451)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(996, 170)
        Me.GroupControl8.TabIndex = 8
        Me.GroupControl8.Text = "DRAFT LETTERS"
        '
        'btnEmailAcknowledgement
        '
        Me.btnEmailAcknowledgement.Enabled = false
        Me.btnEmailAcknowledgement.ImageOptions.Image = CType(resources.GetObject("btnEmailAcknowledgement.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEmailAcknowledgement.Location = New System.Drawing.Point(786, 35)
        Me.btnEmailAcknowledgement.Name = "btnEmailAcknowledgement"
        Me.btnEmailAcknowledgement.Size = New System.Drawing.Size(134, 37)
        Me.btnEmailAcknowledgement.TabIndex = 62
        Me.btnEmailAcknowledgement.Text = "Email "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Acknowledgement"
        '
        'btnFinaliseSubmission
        '
        Me.btnFinaliseSubmission.Enabled = false
        Me.btnFinaliseSubmission.ImageOptions.Image = CType(resources.GetObject("btnFinaliseSubmission.ImageOptions.Image"),System.Drawing.Image)
        Me.btnFinaliseSubmission.Location = New System.Drawing.Point(656, 121)
        Me.btnFinaliseSubmission.Name = "btnFinaliseSubmission"
        Me.btnFinaliseSubmission.Size = New System.Drawing.Size(108, 37)
        Me.btnFinaliseSubmission.TabIndex = 28
        Me.btnFinaliseSubmission.Text = "Finalise"
        '
        'btnDeleteSubmission
        '
        Me.btnDeleteSubmission.Enabled = false
        Me.btnDeleteSubmission.ImageOptions.Image = CType(resources.GetObject("btnDeleteSubmission.ImageOptions.Image"),System.Drawing.Image)
        Me.btnDeleteSubmission.Location = New System.Drawing.Point(656, 78)
        Me.btnDeleteSubmission.Name = "btnDeleteSubmission"
        Me.btnDeleteSubmission.Size = New System.Drawing.Size(108, 37)
        Me.btnDeleteSubmission.TabIndex = 27
        Me.btnDeleteSubmission.Text = "Delete"
        '
        'btnEditSubmision
        '
        Me.btnEditSubmision.Enabled = false
        Me.btnEditSubmision.ImageOptions.Image = CType(resources.GetObject("btnEditSubmision.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditSubmision.Location = New System.Drawing.Point(656, 35)
        Me.btnEditSubmision.Name = "btnEditSubmision"
        Me.btnEditSubmision.Size = New System.Drawing.Size(108, 37)
        Me.btnEditSubmision.TabIndex = 26
        Me.btnEditSubmision.Text = "View/Edit"
        '
        'grdSubmissionDrafts
        '
        Me.grdSubmissionDrafts.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdSubmissionDrafts.Location = New System.Drawing.Point(9, 35)
        Me.grdSubmissionDrafts.MainView = Me.gvwSubmissionDrafts
        Me.grdSubmissionDrafts.Name = "grdSubmissionDrafts"
        Me.grdSubmissionDrafts.Size = New System.Drawing.Size(627, 123)
        Me.grdSubmissionDrafts.TabIndex = 0
        Me.grdSubmissionDrafts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSubmissionDrafts})
        '
        'gvwSubmissionDrafts
        '
        Me.gvwSubmissionDrafts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.gvwSubmissionDrafts.GridControl = Me.grdSubmissionDrafts
        Me.gvwSubmissionDrafts.Name = "gvwSubmissionDrafts"
        Me.gvwSubmissionDrafts.OptionsBehavior.Editable = false
        Me.gvwSubmissionDrafts.OptionsBehavior.ReadOnly = true
        Me.gvwSubmissionDrafts.OptionsView.ShowGroupPanel = false
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "GridColumn1"
        Me.GridColumn13.FieldName = "AppNo"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Document Type"
        Me.GridColumn14.FieldName = "Description"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = true
        Me.GridColumn14.VisibleIndex = 0
        Me.GridColumn14.Width = 517
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Document"
        Me.GridColumn15.FieldName = "Docname"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 523
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Created"
        Me.GridColumn16.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn16.FieldName = "DateCreated"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = true
        Me.GridColumn16.VisibleIndex = 1
        Me.GridColumn16.Width = 94
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "GridColumn4"
        Me.GridColumn17.FieldName = "DraftDocPath"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "GridColumn5"
        Me.GridColumn18.FieldName = "DraftDocId"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'grdSubmissionandObjections
        '
        Me.grdSubmissionandObjections.Location = New System.Drawing.Point(15, 27)
        Me.grdSubmissionandObjections.MainView = Me.gvwSubmissionandObjections
        Me.grdSubmissionandObjections.Name = "grdSubmissionandObjections"
        Me.grdSubmissionandObjections.Size = New System.Drawing.Size(1143, 233)
        Me.grdSubmissionandObjections.TabIndex = 3
        Me.grdSubmissionandObjections.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSubmissionandObjections})
        '
        'gvwSubmissionandObjections
        '
        Me.gvwSubmissionandObjections.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.gvwSubmissionandObjections.GridControl = Me.grdSubmissionandObjections
        Me.gvwSubmissionandObjections.Name = "gvwSubmissionandObjections"
        Me.gvwSubmissionandObjections.OptionsBehavior.Editable = false
        Me.gvwSubmissionandObjections.OptionsBehavior.ReadOnly = true
        Me.gvwSubmissionandObjections.OptionsView.ShowGroupPanel = false
        Me.gvwSubmissionandObjections.RowHeight = 40
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn2.Caption = "Type"
        Me.GridColumn2.FieldName = "SubmissionType"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = true
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 64
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn3.Caption = "Received"
        Me.GridColumn3.FieldName = "DateReceived"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = true
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn4.Caption = "File No"
        Me.GridColumn4.FieldName = "FileNo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = true
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 83
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "Summary"
        Me.GridColumn5.FieldName = "SubmissionSummary"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = true
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 241
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.Caption = "Officers Notes"
        Me.GridColumn6.FieldName = "OfficerNotes"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = true
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 183
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn7.Caption = "LastUpdate"
        Me.GridColumn7.FieldName = "LastUpdate"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "AppNoId"
        Me.GridColumn8.FieldName = "AppNoId"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn9.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn9.Caption = "Address"
        Me.GridColumn9.FieldName = "Address"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = true
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 177
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn10.Caption = "Phone"
        Me.GridColumn10.FieldName = "AuthorPhone"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = true
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 90
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = true
        Me.GridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn11.Caption = "Gift"
        Me.GridColumn11.FieldName = "SubGiftDonationYN"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = true
        Me.GridColumn11.VisibleIndex = 7
        Me.GridColumn11.Width = 33
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.chkUseEmail)
        Me.GroupBox31.Controls.Add(Me.btnRemoveSub)
        Me.GroupBox31.Controls.Add(Me.Label30)
        Me.GroupBox31.Controls.Add(Me.txtAuthorEmail)
        Me.GroupBox31.Controls.Add(Me.btnSaveSub)
        Me.GroupBox31.Controls.Add(Me.btnEditSub)
        Me.GroupBox31.Controls.Add(Me.btnAddSub)
        Me.GroupBox31.Controls.Add(Me.cboSubmissionType)
        Me.GroupBox31.Controls.Add(Me.btnAckSub)
        Me.GroupBox31.Controls.Add(Me.SubRecdDate)
        Me.GroupBox31.Controls.Add(Label5)
        Me.GroupBox31.Controls.Add(Me.chkSubGift)
        Me.GroupBox31.Controls.Add(Me.Label109)
        Me.GroupBox31.Controls.Add(Me.Label108)
        Me.GroupBox31.Controls.Add(Me.Label106)
        Me.GroupBox31.Controls.Add(Me.txtOfficerComment)
        Me.GroupBox31.Controls.Add(Me.txtSubmissionSummary)
        Me.GroupBox31.Controls.Add(Me.txtAuthorPhone)
        Me.GroupBox31.Controls.Add(Me.txtAuthorTown)
        Me.GroupBox31.Controls.Add(Me.txtAuthorPCode)
        Me.GroupBox31.Controls.Add(Me.txtAuthurAddress)
        Me.GroupBox31.Controls.Add(Me.txtAuthorName)
        Me.GroupBox31.Controls.Add(Me.lblSubID)
        Me.GroupBox31.Controls.Add(Me.Label103)
        Me.GroupBox31.Controls.Add(Me.Label104)
        Me.GroupBox31.Controls.Add(Me.Label105)
        Me.GroupBox31.Controls.Add(Me.Label107)
        Me.GroupBox31.Location = New System.Drawing.Point(13, 261)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(1145, 181)
        Me.GroupBox31.TabIndex = 2
        Me.GroupBox31.TabStop = false
        '
        'chkUseEmail
        '
        Me.chkUseEmail.EditValue = true
        Me.chkUseEmail.Location = New System.Drawing.Point(551, 30)
        Me.chkUseEmail.MenuManager = Me.RibbonControl
        Me.chkUseEmail.Name = "chkUseEmail"
        Me.chkUseEmail.Properties.Caption = "Use Email Address"
        Me.chkUseEmail.Size = New System.Drawing.Size(123, 19)
        Me.chkUseEmail.TabIndex = 63
        '
        'btnRemoveSub
        '
        Me.btnRemoveSub.Enabled = false
        Me.btnRemoveSub.ImageOptions.Image = CType(resources.GetObject("btnRemoveSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveSub.Location = New System.Drawing.Point(1036, 50)
        Me.btnRemoveSub.Name = "btnRemoveSub"
        Me.btnRemoveSub.Size = New System.Drawing.Size(92, 32)
        Me.btnRemoveSub.TabIndex = 62
        Me.btnRemoveSub.Text = "Remove"
        '
        'Label30
        '
        Me.Label30.AutoSize = true
        Me.Label30.Location = New System.Drawing.Point(734, 123)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = "Email:"
        '
        'txtAuthorEmail
        '
        Me.txtAuthorEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorEmail.Location = New System.Drawing.Point(788, 117)
        Me.txtAuthorEmail.Name = "txtAuthorEmail"
        Me.txtAuthorEmail.ReadOnly = true
        Me.txtAuthorEmail.Size = New System.Drawing.Size(210, 21)
        Me.txtAuthorEmail.TabIndex = 60
        '
        'btnSaveSub
        '
        Me.btnSaveSub.Enabled = false
        Me.btnSaveSub.ImageOptions.Image = CType(resources.GetObject("btnSaveSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveSub.Location = New System.Drawing.Point(1036, 124)
        Me.btnSaveSub.Name = "btnSaveSub"
        Me.btnSaveSub.Size = New System.Drawing.Size(92, 32)
        Me.btnSaveSub.TabIndex = 59
        Me.btnSaveSub.Text = "Save"
        '
        'btnEditSub
        '
        Me.btnEditSub.Enabled = false
        Me.btnEditSub.ImageOptions.Image = CType(resources.GetObject("btnEditSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditSub.Location = New System.Drawing.Point(1036, 87)
        Me.btnEditSub.Name = "btnEditSub"
        Me.btnEditSub.Size = New System.Drawing.Size(92, 32)
        Me.btnEditSub.TabIndex = 58
        Me.btnEditSub.Text = "Change"
        '
        'btnAddSub
        '
        Me.btnAddSub.ImageOptions.Image = CType(resources.GetObject("btnAddSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddSub.Location = New System.Drawing.Point(1036, 13)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(92, 32)
        Me.btnAddSub.TabIndex = 57
        Me.btnAddSub.Text = "Add"
        '
        'cboSubmissionType
        '
        Me.cboSubmissionType.Location = New System.Drawing.Point(12, 32)
        Me.cboSubmissionType.Name = "cboSubmissionType"
        Me.cboSubmissionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubmissionType.Properties.NullText = "[Select Type]"
        Me.cboSubmissionType.Properties.ReadOnly = true
        Me.cboSubmissionType.Size = New System.Drawing.Size(156, 20)
        Me.cboSubmissionType.TabIndex = 56
        '
        'btnAckSub
        '
        Me.btnAckSub.Enabled = false
        Me.btnAckSub.ImageOptions.Image = CType(resources.GetObject("btnAckSub.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAckSub.Location = New System.Drawing.Point(411, 20)
        Me.btnAckSub.Name = "btnAckSub"
        Me.btnAckSub.Size = New System.Drawing.Size(134, 40)
        Me.btnAckSub.TabIndex = 55
        Me.btnAckSub.Text = "Create "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Acknowledgement"
        '
        'SubRecdDate
        '
        Me.SubRecdDate.EditValue = Nothing
        Me.SubRecdDate.Location = New System.Drawing.Point(207, 33)
        Me.SubRecdDate.Name = "SubRecdDate"
        Me.SubRecdDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubRecdDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubRecdDate.Size = New System.Drawing.Size(100, 20)
        Me.SubRecdDate.TabIndex = 30
        '
        'chkSubGift
        '
        Me.chkSubGift.Location = New System.Drawing.Point(854, 150)
        Me.chkSubGift.Name = "chkSubGift"
        Me.chkSubGift.Size = New System.Drawing.Size(28, 24)
        Me.chkSubGift.TabIndex = 54
        '
        'Label109
        '
        Me.Label109.AutoSize = true
        Me.Label109.Location = New System.Drawing.Point(5, 60)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(129, 13)
        Me.Label109.TabIndex = 52
        Me.Label109.Text = "Summary of Suubmission:"
        '
        'Label108
        '
        Me.Label108.AutoSize = true
        Me.Label108.Location = New System.Drawing.Point(5, 117)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(79, 13)
        Me.Label108.TabIndex = 51
        Me.Label108.Text = "Officers notes:"
        '
        'Label106
        '
        Me.Label106.AutoSize = true
        Me.Label106.Location = New System.Drawing.Point(734, 93)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(41, 13)
        Me.Label106.TabIndex = 50
        Me.Label106.Text = "Phone:"
        '
        'txtOfficerComment
        '
        Me.txtOfficerComment.BackColor = System.Drawing.SystemColors.Info
        Me.txtOfficerComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOfficerComment.Location = New System.Drawing.Point(8, 134)
        Me.txtOfficerComment.Multiline = true
        Me.txtOfficerComment.Name = "txtOfficerComment"
        Me.txtOfficerComment.ReadOnly = true
        Me.txtOfficerComment.Size = New System.Drawing.Size(373, 38)
        Me.txtOfficerComment.TabIndex = 49
        '
        'txtSubmissionSummary
        '
        Me.txtSubmissionSummary.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubmissionSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubmissionSummary.Location = New System.Drawing.Point(8, 76)
        Me.txtSubmissionSummary.Multiline = true
        Me.txtSubmissionSummary.Name = "txtSubmissionSummary"
        Me.txtSubmissionSummary.ReadOnly = true
        Me.txtSubmissionSummary.Size = New System.Drawing.Size(373, 38)
        Me.txtSubmissionSummary.TabIndex = 48
        '
        'txtAuthorPhone
        '
        Me.txtAuthorPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthorPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorPhone.Location = New System.Drawing.Point(788, 90)
        Me.txtAuthorPhone.Name = "txtAuthorPhone"
        Me.txtAuthorPhone.ReadOnly = true
        Me.txtAuthorPhone.Size = New System.Drawing.Size(210, 21)
        Me.txtAuthorPhone.TabIndex = 47
        '
        'txtAuthorTown
        '
        Me.txtAuthorTown.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthorTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorTown.Location = New System.Drawing.Point(788, 60)
        Me.txtAuthorTown.Name = "txtAuthorTown"
        Me.txtAuthorTown.ReadOnly = true
        Me.txtAuthorTown.Size = New System.Drawing.Size(181, 21)
        Me.txtAuthorTown.TabIndex = 46
        '
        'txtAuthorPCode
        '
        Me.txtAuthorPCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthorPCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorPCode.Location = New System.Drawing.Point(968, 60)
        Me.txtAuthorPCode.Name = "txtAuthorPCode"
        Me.txtAuthorPCode.ReadOnly = true
        Me.txtAuthorPCode.Size = New System.Drawing.Size(30, 21)
        Me.txtAuthorPCode.TabIndex = 45
        '
        'txtAuthurAddress
        '
        Me.txtAuthurAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthurAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthurAddress.Location = New System.Drawing.Point(788, 41)
        Me.txtAuthurAddress.Name = "txtAuthurAddress"
        Me.txtAuthurAddress.ReadOnly = true
        Me.txtAuthurAddress.Size = New System.Drawing.Size(210, 21)
        Me.txtAuthurAddress.TabIndex = 44
        '
        'txtAuthorName
        '
        Me.txtAuthorName.BackColor = System.Drawing.SystemColors.Info
        Me.txtAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorName.Location = New System.Drawing.Point(788, 15)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.ReadOnly = true
        Me.txtAuthorName.Size = New System.Drawing.Size(210, 21)
        Me.txtAuthorName.TabIndex = 43
        '
        'lblSubID
        '
        Me.lblSubID.AutoSize = true
        Me.lblSubID.ForeColor = System.Drawing.Color.Transparent
        Me.lblSubID.Location = New System.Drawing.Point(423, 134)
        Me.lblSubID.Name = "lblSubID"
        Me.lblSubID.Size = New System.Drawing.Size(0, 13)
        Me.lblSubID.TabIndex = 42
        '
        'Label103
        '
        Me.Label103.AutoSize = true
        Me.Label103.Location = New System.Drawing.Point(204, 16)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(81, 13)
        Me.Label103.TabIndex = 37
        Me.Label103.Text = "Date Recieved:"
        '
        'Label104
        '
        Me.Label104.AutoSize = true
        Me.Label104.Location = New System.Drawing.Point(734, 44)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(50, 13)
        Me.Label104.TabIndex = 36
        Me.Label104.Text = "Address:"
        '
        'Label105
        '
        Me.Label105.AutoSize = true
        Me.Label105.Location = New System.Drawing.Point(734, 18)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(38, 13)
        Me.Label105.TabIndex = 35
        Me.Label105.Text = "Name:"
        '
        'Label107
        '
        Me.Label107.AutoSize = true
        Me.Label107.Location = New System.Drawing.Point(9, 16)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(90, 13)
        Me.Label107.TabIndex = 33
        Me.Label107.Text = "Submission Type:"
        '
        'tpgPCAConditions
        '
        Me.tpgPCAConditions.Controls.Add(Me.pnlDisplayPCAconditions)
        Me.tpgPCAConditions.ImageOptions.Image = CType(resources.GetObject("tpgPCAConditions.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgPCAConditions.Name = "tpgPCAConditions"
        Me.tpgPCAConditions.Size = New System.Drawing.Size(1423, 721)
        Me.tpgPCAConditions.Text = "PCA Conditions"
        '
        'pnlDisplayPCAconditions
        '
        Me.pnlDisplayPCAconditions.Controls.Add(Me.GroupBox36)
        Me.pnlDisplayPCAconditions.Controls.Add(Me.GroupBox35)
        Me.pnlDisplayPCAconditions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayPCAconditions.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayPCAconditions.Name = "pnlDisplayPCAconditions"
        Me.pnlDisplayPCAconditions.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayPCAconditions.TabIndex = 26
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.btnOneOffCondDone)
        Me.GroupBox36.Controls.Add(Me.grdOneOffConditions)
        Me.GroupBox36.Location = New System.Drawing.Point(43, 306)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(1141, 337)
        Me.GroupBox36.TabIndex = 3
        Me.GroupBox36.Text = "One-Off Conditions Prior to Construction Certificate Release"
        '
        'btnOneOffCondDone
        '
        Me.btnOneOffCondDone.Enabled = false
        Me.btnOneOffCondDone.ImageOptions.Image = CType(resources.GetObject("btnOneOffCondDone.ImageOptions.Image"),System.Drawing.Image)
        Me.btnOneOffCondDone.Location = New System.Drawing.Point(1033, 23)
        Me.btnOneOffCondDone.Name = "btnOneOffCondDone"
        Me.btnOneOffCondDone.Size = New System.Drawing.Size(103, 39)
        Me.btnOneOffCondDone.TabIndex = 6
        Me.btnOneOffCondDone.Text = "Done"
        '
        'grdOneOffConditions
        '
        Me.grdOneOffConditions.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdOneOffConditions.Location = New System.Drawing.Point(2, 20)
        Me.grdOneOffConditions.MainView = Me.gvwOneOffConditions
        Me.grdOneOffConditions.Name = "grdOneOffConditions"
        Me.grdOneOffConditions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit6})
        Me.grdOneOffConditions.Size = New System.Drawing.Size(1009, 315)
        Me.grdOneOffConditions.TabIndex = 5
        Me.grdOneOffConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOneOffConditions})
        '
        'gvwOneOffConditions
        '
        Me.gvwOneOffConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOneOffUniqueId, Me.colOneOffCondCode, Me.colConditionalText, Me.colOneOffCCMetDate})
        Me.gvwOneOffConditions.GridControl = Me.grdOneOffConditions
        Me.gvwOneOffConditions.Name = "gvwOneOffConditions"
        Me.gvwOneOffConditions.OptionsBehavior.ReadOnly = true
        Me.gvwOneOffConditions.OptionsView.ShowGroupPanel = false
        Me.gvwOneOffConditions.RowHeight = 200
        '
        'colOneOffUniqueId
        '
        Me.colOneOffUniqueId.Caption = "GridColumn13"
        Me.colOneOffUniqueId.FieldName = "UniqueId"
        Me.colOneOffUniqueId.Name = "colOneOffUniqueId"
        Me.colOneOffUniqueId.OptionsColumn.AllowEdit = false
        Me.colOneOffUniqueId.OptionsColumn.ReadOnly = true
        '
        'colOneOffCondCode
        '
        Me.colOneOffCondCode.AppearanceCell.Options.UseTextOptions = true
        Me.colOneOffCondCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colOneOffCondCode.Caption = "Code"
        Me.colOneOffCondCode.FieldName = "CondCode"
        Me.colOneOffCondCode.Name = "colOneOffCondCode"
        Me.colOneOffCondCode.OptionsColumn.AllowEdit = false
        Me.colOneOffCondCode.OptionsColumn.ReadOnly = true
        Me.colOneOffCondCode.Width = 82
        '
        'colConditionalText
        '
        Me.colConditionalText.Caption = "Condition"
        Me.colConditionalText.ColumnEdit = Me.RepositoryItemMemoEdit6
        Me.colConditionalText.FieldName = "ConditionText"
        Me.colConditionalText.Name = "colConditionalText"
        Me.colConditionalText.OptionsColumn.AllowEdit = false
        Me.colConditionalText.OptionsColumn.ReadOnly = true
        Me.colConditionalText.Visible = true
        Me.colConditionalText.VisibleIndex = 0
        Me.colConditionalText.Width = 686
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'colOneOffCCMetDate
        '
        Me.colOneOffCCMetDate.AppearanceCell.Options.UseTextOptions = true
        Me.colOneOffCCMetDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colOneOffCCMetDate.Caption = "Date"
        Me.colOneOffCCMetDate.FieldName = "CCMetDate"
        Me.colOneOffCCMetDate.Name = "colOneOffCCMetDate"
        Me.colOneOffCCMetDate.OptionsColumn.AllowEdit = false
        Me.colOneOffCCMetDate.OptionsColumn.ReadOnly = true
        Me.colOneOffCCMetDate.Visible = true
        Me.colOneOffCCMetDate.VisibleIndex = 1
        Me.colOneOffCCMetDate.Width = 112
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.btnStdCondDone)
        Me.GroupBox35.Controls.Add(Me.grdSTDCond)
        Me.GroupBox35.Location = New System.Drawing.Point(41, 16)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(1141, 284)
        Me.GroupBox35.TabIndex = 2
        Me.GroupBox35.Text = "Standard  Conditions Prior to Construction Certificate Release"
        '
        'btnStdCondDone
        '
        Me.btnStdCondDone.Enabled = false
        Me.btnStdCondDone.ImageOptions.Image = CType(resources.GetObject("btnStdCondDone.ImageOptions.Image"),System.Drawing.Image)
        Me.btnStdCondDone.Location = New System.Drawing.Point(1033, 23)
        Me.btnStdCondDone.Name = "btnStdCondDone"
        Me.btnStdCondDone.Size = New System.Drawing.Size(103, 39)
        Me.btnStdCondDone.TabIndex = 5
        Me.btnStdCondDone.Text = "Done"
        '
        'grdSTDCond
        '
        Me.grdSTDCond.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdSTDCond.Location = New System.Drawing.Point(2, 20)
        Me.grdSTDCond.MainView = Me.gvwSTDCond
        Me.grdSTDCond.Name = "grdSTDCond"
        Me.grdSTDCond.Size = New System.Drawing.Size(1009, 262)
        Me.grdSTDCond.TabIndex = 4
        Me.grdSTDCond.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSTDCond})
        '
        'gvwSTDCond
        '
        Me.gvwSTDCond.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAppCondId, Me.colStdCondCode, Me.colCondDesc, Me.colStdCCMetDate})
        Me.gvwSTDCond.GridControl = Me.grdSTDCond
        Me.gvwSTDCond.Name = "gvwSTDCond"
        Me.gvwSTDCond.OptionsBehavior.Editable = false
        Me.gvwSTDCond.OptionsBehavior.ReadOnly = true
        Me.gvwSTDCond.OptionsView.ShowGroupPanel = false
        '
        'colAppCondId
        '
        Me.colAppCondId.Caption = "GridColumn13"
        Me.colAppCondId.FieldName = "AppCondId"
        Me.colAppCondId.Name = "colAppCondId"
        '
        'colStdCondCode
        '
        Me.colStdCondCode.Caption = "Code"
        Me.colStdCondCode.FieldName = "CondCode"
        Me.colStdCondCode.Name = "colStdCondCode"
        Me.colStdCondCode.Visible = true
        Me.colStdCondCode.VisibleIndex = 0
        Me.colStdCondCode.Width = 68
        '
        'colCondDesc
        '
        Me.colCondDesc.Caption = "Description"
        Me.colCondDesc.FieldName = "CondDesc"
        Me.colCondDesc.Name = "colCondDesc"
        Me.colCondDesc.Visible = true
        Me.colCondDesc.VisibleIndex = 1
        Me.colCondDesc.Width = 808
        '
        'colStdCCMetDate
        '
        Me.colStdCCMetDate.Caption = "Date"
        Me.colStdCCMetDate.FieldName = "CCMetDate"
        Me.colStdCCMetDate.Name = "colStdCCMetDate"
        Me.colStdCCMetDate.Visible = true
        Me.colStdCCMetDate.VisibleIndex = 2
        Me.colStdCCMetDate.Width = 115
        '
        'tpgFileNotes
        '
        Me.tpgFileNotes.Controls.Add(Me.pnlDisplayFileNotes)
        Me.tpgFileNotes.ImageOptions.Image = CType(resources.GetObject("tpgFileNotes.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgFileNotes.Name = "tpgFileNotes"
        Me.tpgFileNotes.Size = New System.Drawing.Size(1423, 721)
        Me.tpgFileNotes.Text = "File Notes"
        '
        'pnlDisplayFileNotes
        '
        Me.pnlDisplayFileNotes.Controls.Add(Me.GroupControl2)
        Me.pnlDisplayFileNotes.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayFileNotes.Name = "pnlDisplayFileNotes"
        Me.pnlDisplayFileNotes.Size = New System.Drawing.Size(1208, 660)
        Me.pnlDisplayFileNotes.TabIndex = 8
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GroupControl5)
        Me.GroupControl2.Controls.Add(Me.grpFileNotes)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1204, 656)
        Me.GroupControl2.TabIndex = 3
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grdFileNotes)
        Me.GroupControl5.Location = New System.Drawing.Point(15, 23)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1174, 430)
        Me.GroupControl5.TabIndex = 4
        '
        'grdFileNotes
        '
        Me.grdFileNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFileNotes.Location = New System.Drawing.Point(2, 20)
        Me.grdFileNotes.MainView = Me.gvwFileNotes
        Me.grdFileNotes.Name = "grdFileNotes"
        Me.grdFileNotes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3})
        Me.grdFileNotes.Size = New System.Drawing.Size(1170, 408)
        Me.grdFileNotes.TabIndex = 3
        Me.grdFileNotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFileNotes})
        '
        'gvwFileNotes
        '
        Me.gvwFileNotes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFileNoteType, Me.colNoteDate, Me.colSubject, Me.colDetail, Me.colContactNumber, Me.colOfficer, Me.colid})
        Me.gvwFileNotes.GridControl = Me.grdFileNotes
        Me.gvwFileNotes.Name = "gvwFileNotes"
        Me.gvwFileNotes.OptionsBehavior.ReadOnly = true
        Me.gvwFileNotes.OptionsView.ShowGroupPanel = false
        Me.gvwFileNotes.RowHeight = 240
        '
        'colFileNoteType
        '
        Me.colFileNoteType.AppearanceCell.Options.UseTextOptions = true
        Me.colFileNoteType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colFileNoteType.Caption = "Type"
        Me.colFileNoteType.FieldName = "FileNoteType"
        Me.colFileNoteType.Name = "colFileNoteType"
        Me.colFileNoteType.OptionsColumn.AllowEdit = false
        Me.colFileNoteType.Visible = true
        Me.colFileNoteType.VisibleIndex = 0
        Me.colFileNoteType.Width = 137
        '
        'colNoteDate
        '
        Me.colNoteDate.AppearanceCell.Options.UseTextOptions = true
        Me.colNoteDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colNoteDate.Caption = "Date"
        Me.colNoteDate.FieldName = "NoteDate"
        Me.colNoteDate.Name = "colNoteDate"
        Me.colNoteDate.OptionsColumn.AllowEdit = false
        Me.colNoteDate.Visible = true
        Me.colNoteDate.VisibleIndex = 1
        Me.colNoteDate.Width = 88
        '
        'colSubject
        '
        Me.colSubject.AppearanceCell.Options.UseTextOptions = true
        Me.colSubject.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colSubject.Caption = "Subject"
        Me.colSubject.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.OptionsColumn.AllowEdit = false
        Me.colSubject.Visible = true
        Me.colSubject.VisibleIndex = 2
        Me.colSubject.Width = 300
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colDetail
        '
        Me.colDetail.AppearanceCell.Options.UseTextOptions = true
        Me.colDetail.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDetail.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDetail.Caption = "Detail"
        Me.colDetail.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colDetail.FieldName = "Detail"
        Me.colDetail.Name = "colDetail"
        Me.colDetail.OptionsColumn.ReadOnly = true
        Me.colDetail.Visible = true
        Me.colDetail.VisibleIndex = 3
        Me.colDetail.Width = 371
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colContactNumber
        '
        Me.colContactNumber.AppearanceCell.Options.UseTextOptions = true
        Me.colContactNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colContactNumber.Caption = "Phone"
        Me.colContactNumber.FieldName = "ContactNumber"
        Me.colContactNumber.Name = "colContactNumber"
        Me.colContactNumber.OptionsColumn.AllowEdit = false
        Me.colContactNumber.Visible = true
        Me.colContactNumber.VisibleIndex = 4
        Me.colContactNumber.Width = 97
        '
        'colOfficer
        '
        Me.colOfficer.AppearanceCell.Options.UseTextOptions = true
        Me.colOfficer.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colOfficer.Caption = "Officer"
        Me.colOfficer.FieldName = "Officer"
        Me.colOfficer.Name = "colOfficer"
        Me.colOfficer.OptionsColumn.AllowEdit = false
        Me.colOfficer.Visible = true
        Me.colOfficer.VisibleIndex = 5
        Me.colOfficer.Width = 159
        '
        'colid
        '
        Me.colid.Caption = "id"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'grpFileNotes
        '
        Me.grpFileNotes.Controls.Add(Me.cboNotesOfficer)
        Me.grpFileNotes.Controls.Add(Me.cboNoteType)
        Me.grpFileNotes.Controls.Add(Me.btnSaveNote)
        Me.grpFileNotes.Controls.Add(Me.btnEditNote)
        Me.grpFileNotes.Controls.Add(Me.btnAddNote)
        Me.grpFileNotes.Controls.Add(Me.btnNotePrint)
        Me.grpFileNotes.Controls.Add(Me.NoteDate)
        Me.grpFileNotes.Controls.Add(Me.lblNotesID)
        Me.grpFileNotes.Controls.Add(Me.Label119)
        Me.grpFileNotes.Controls.Add(Me.txtNotesSubject)
        Me.grpFileNotes.Controls.Add(Me.Label110)
        Me.grpFileNotes.Controls.Add(Me.Label111)
        Me.grpFileNotes.Controls.Add(Me.Label112)
        Me.grpFileNotes.Controls.Add(Me.txtNotesReferredTo)
        Me.grpFileNotes.Controls.Add(Me.Label113)
        Me.grpFileNotes.Controls.Add(Me.txtNotesFollowUp)
        Me.grpFileNotes.Controls.Add(Me.Label114)
        Me.grpFileNotes.Controls.Add(Me.txtNotesCC)
        Me.grpFileNotes.Controls.Add(Me.Label115)
        Me.grpFileNotes.Controls.Add(Me.txtNotesContactNo)
        Me.grpFileNotes.Controls.Add(Me.Label116)
        Me.grpFileNotes.Controls.Add(Me.txtNotesSpokeTo)
        Me.grpFileNotes.Controls.Add(Me.Label117)
        Me.grpFileNotes.Controls.Add(Me.txtNoteDetails)
        Me.grpFileNotes.Controls.Add(Me.Label118)
        Me.grpFileNotes.Location = New System.Drawing.Point(15, 459)
        Me.grpFileNotes.Name = "grpFileNotes"
        Me.grpFileNotes.Size = New System.Drawing.Size(1170, 188)
        Me.grpFileNotes.TabIndex = 2
        '
        'cboNotesOfficer
        '
        Me.cboNotesOfficer.Location = New System.Drawing.Point(11, 92)
        Me.cboNotesOfficer.Name = "cboNotesOfficer"
        Me.cboNotesOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNotesOfficer.Properties.NullText = "[Select Author]"
        Me.cboNotesOfficer.Properties.ReadOnly = true
        Me.cboNotesOfficer.Size = New System.Drawing.Size(151, 20)
        Me.cboNotesOfficer.TabIndex = 40
        '
        'cboNoteType
        '
        Me.cboNoteType.Location = New System.Drawing.Point(9, 47)
        Me.cboNoteType.Name = "cboNoteType"
        Me.cboNoteType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNoteType.Properties.NullText = "[Select Note Type]"
        Me.cboNoteType.Properties.ReadOnly = true
        Me.cboNoteType.Size = New System.Drawing.Size(151, 20)
        Me.cboNoteType.TabIndex = 39
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Enabled = false
        Me.btnSaveNote.ImageOptions.Image = CType(resources.GetObject("btnSaveNote.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveNote.Location = New System.Drawing.Point(1060, 146)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(96, 35)
        Me.btnSaveNote.TabIndex = 38
        Me.btnSaveNote.Text = "Save"
        '
        'btnEditNote
        '
        Me.btnEditNote.Enabled = false
        Me.btnEditNote.ImageOptions.Image = CType(resources.GetObject("btnEditNote.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditNote.Location = New System.Drawing.Point(1060, 105)
        Me.btnEditNote.Name = "btnEditNote"
        Me.btnEditNote.Size = New System.Drawing.Size(96, 35)
        Me.btnEditNote.TabIndex = 37
        Me.btnEditNote.Text = "Modify"
        '
        'btnAddNote
        '
        Me.btnAddNote.Enabled = false
        Me.btnAddNote.ImageOptions.Image = CType(resources.GetObject("btnAddNote.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddNote.Location = New System.Drawing.Point(1060, 64)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(96, 35)
        Me.btnAddNote.TabIndex = 36
        Me.btnAddNote.Text = "Add"
        '
        'btnNotePrint
        '
        Me.btnNotePrint.Enabled = false
        Me.btnNotePrint.ImageOptions.Image = CType(resources.GetObject("btnNotePrint.ImageOptions.Image"),System.Drawing.Image)
        Me.btnNotePrint.Location = New System.Drawing.Point(1060, 23)
        Me.btnNotePrint.Name = "btnNotePrint"
        Me.btnNotePrint.Size = New System.Drawing.Size(96, 35)
        Me.btnNotePrint.TabIndex = 35
        Me.btnNotePrint.Text = "Print"
        '
        'NoteDate
        '
        Me.NoteDate.EditValue = Nothing
        Me.NoteDate.Location = New System.Drawing.Point(424, 49)
        Me.NoteDate.Name = "NoteDate"
        Me.NoteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NoteDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NoteDate.Size = New System.Drawing.Size(100, 20)
        Me.NoteDate.TabIndex = 30
        '
        'lblNotesID
        '
        Me.lblNotesID.AutoSize = true
        Me.lblNotesID.ForeColor = System.Drawing.Color.Transparent
        Me.lblNotesID.Location = New System.Drawing.Point(34, 193)
        Me.lblNotesID.Name = "lblNotesID"
        Me.lblNotesID.Size = New System.Drawing.Size(13, 13)
        Me.lblNotesID.TabIndex = 34
        Me.lblNotesID.Text = "0"
        '
        'Label119
        '
        Me.Label119.AutoSize = true
        Me.Label119.Location = New System.Drawing.Point(421, 31)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(34, 13)
        Me.Label119.TabIndex = 33
        Me.Label119.Text = "Date:"
        '
        'txtNotesSubject
        '
        Me.txtNotesSubject.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesSubject.Location = New System.Drawing.Point(179, 48)
        Me.txtNotesSubject.Name = "txtNotesSubject"
        Me.txtNotesSubject.ReadOnly = true
        Me.txtNotesSubject.Size = New System.Drawing.Size(225, 21)
        Me.txtNotesSubject.TabIndex = 2
        '
        'Label110
        '
        Me.Label110.AutoSize = true
        Me.Label110.Location = New System.Drawing.Point(8, 31)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(61, 13)
        Me.Label110.TabIndex = 9
        Me.Label110.Text = "Note Type:"
        '
        'Label111
        '
        Me.Label111.AutoSize = true
        Me.Label111.Location = New System.Drawing.Point(8, 76)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(40, 13)
        Me.Label111.TabIndex = 10
        Me.Label111.Text = "Author"
        '
        'Label112
        '
        Me.Label112.AutoSize = true
        Me.Label112.Location = New System.Drawing.Point(176, 31)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(47, 13)
        Me.Label112.TabIndex = 11
        Me.Label112.Text = "Subject:"
        '
        'txtNotesReferredTo
        '
        Me.txtNotesReferredTo.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesReferredTo.Location = New System.Drawing.Point(674, 152)
        Me.txtNotesReferredTo.Name = "txtNotesReferredTo"
        Me.txtNotesReferredTo.ReadOnly = true
        Me.txtNotesReferredTo.Size = New System.Drawing.Size(138, 21)
        Me.txtNotesReferredTo.TabIndex = 23
        Me.txtNotesReferredTo.Visible = false
        '
        'Label113
        '
        Me.Label113.AutoSize = true
        Me.Label113.Location = New System.Drawing.Point(176, 76)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(43, 13)
        Me.Label113.TabIndex = 12
        Me.Label113.Text = "Details:"
        '
        'txtNotesFollowUp
        '
        Me.txtNotesFollowUp.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesFollowUp.Location = New System.Drawing.Point(674, 126)
        Me.txtNotesFollowUp.Name = "txtNotesFollowUp"
        Me.txtNotesFollowUp.ReadOnly = true
        Me.txtNotesFollowUp.Size = New System.Drawing.Size(138, 21)
        Me.txtNotesFollowUp.TabIndex = 22
        Me.txtNotesFollowUp.Visible = false
        '
        'Label114
        '
        Me.Label114.AutoSize = true
        Me.Label114.Location = New System.Drawing.Point(611, 50)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(55, 13)
        Me.Label114.TabIndex = 13
        Me.Label114.Text = "Spoke To:"
        '
        'txtNotesCC
        '
        Me.txtNotesCC.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesCC.Location = New System.Drawing.Point(674, 100)
        Me.txtNotesCC.Name = "txtNotesCC"
        Me.txtNotesCC.ReadOnly = true
        Me.txtNotesCC.Size = New System.Drawing.Size(138, 21)
        Me.txtNotesCC.TabIndex = 21
        Me.txtNotesCC.Visible = false
        '
        'Label115
        '
        Me.Label115.AutoSize = true
        Me.Label115.Location = New System.Drawing.Point(601, 76)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(69, 13)
        Me.Label115.TabIndex = 14
        Me.Label115.Text = "Contact No.:"
        '
        'txtNotesContactNo
        '
        Me.txtNotesContactNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesContactNo.Location = New System.Drawing.Point(674, 73)
        Me.txtNotesContactNo.Name = "txtNotesContactNo"
        Me.txtNotesContactNo.ReadOnly = true
        Me.txtNotesContactNo.Size = New System.Drawing.Size(138, 21)
        Me.txtNotesContactNo.TabIndex = 20
        '
        'Label116
        '
        Me.Label116.AutoSize = true
        Me.Label116.Location = New System.Drawing.Point(644, 103)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(25, 13)
        Me.Label116.TabIndex = 15
        Me.Label116.Text = "CC:"
        Me.Label116.Visible = false
        '
        'txtNotesSpokeTo
        '
        Me.txtNotesSpokeTo.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotesSpokeTo.Location = New System.Drawing.Point(674, 47)
        Me.txtNotesSpokeTo.Name = "txtNotesSpokeTo"
        Me.txtNotesSpokeTo.ReadOnly = true
        Me.txtNotesSpokeTo.Size = New System.Drawing.Size(138, 21)
        Me.txtNotesSpokeTo.TabIndex = 19
        '
        'Label117
        '
        Me.Label117.AutoSize = true
        Me.Label117.Location = New System.Drawing.Point(611, 129)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(57, 13)
        Me.Label117.TabIndex = 16
        Me.Label117.Text = "Follow Up:"
        Me.Label117.Visible = false
        '
        'txtNoteDetails
        '
        Me.txtNoteDetails.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoteDetails.Location = New System.Drawing.Point(179, 92)
        Me.txtNoteDetails.Multiline = true
        Me.txtNoteDetails.Name = "txtNoteDetails"
        Me.txtNoteDetails.ReadOnly = true
        Me.txtNoteDetails.Size = New System.Drawing.Size(356, 63)
        Me.txtNoteDetails.TabIndex = 18
        '
        'Label118
        '
        Me.Label118.AutoSize = true
        Me.Label118.Location = New System.Drawing.Point(616, 155)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(53, 13)
        Me.Label118.TabIndex = 17
        Me.Label118.Text = "Refer To:"
        Me.Label118.Visible = false
        '
        'tpgBuildLetters
        '
        Me.tpgBuildLetters.Controls.Add(Me.pnlBuildLetters)
        Me.tpgBuildLetters.ImageOptions.Image = CType(resources.GetObject("tpgBuildLetters.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgBuildLetters.Name = "tpgBuildLetters"
        Me.tpgBuildLetters.Size = New System.Drawing.Size(1423, 721)
        Me.tpgBuildLetters.Text = "Build Letters"
        '
        'pnlBuildLetters
        '
        Me.pnlBuildLetters.Controls.Add(Me.btnAddDefaultCondition)
        Me.pnlBuildLetters.Controls.Add(Me.cboAssessmentType)
        Me.pnlBuildLetters.Controls.Add(Me.btnSaveConsent)
        Me.pnlBuildLetters.Controls.Add(Me.btnInsertIntoLive)
        Me.pnlBuildLetters.Controls.Add(Me.GroupControl1)
        Me.pnlBuildLetters.Controls.Add(Me.btnAssembleLetter)
        Me.pnlBuildLetters.Controls.Add(Me.GroupControl9)
        Me.pnlBuildLetters.Controls.Add(Me.GroupControl3)
        Me.pnlBuildLetters.Controls.Add(Me.LabelControl57)
        Me.pnlBuildLetters.Controls.Add(ConsentPlanNumberLabel)
        Me.pnlBuildLetters.Controls.Add(Me.cboConsentDocType)
        Me.pnlBuildLetters.Controls.Add(Me.ConsentPlanNumberTextBox)
        Me.pnlBuildLetters.Controls.Add(Me.grpLetters)
        Me.pnlBuildLetters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBuildLetters.Location = New System.Drawing.Point(0, 0)
        Me.pnlBuildLetters.Name = "pnlBuildLetters"
        Me.pnlBuildLetters.Size = New System.Drawing.Size(1423, 721)
        Me.pnlBuildLetters.TabIndex = 1
        '
        'btnAddDefaultCondition
        '
        Me.btnAddDefaultCondition.ImageOptions.Image = CType(resources.GetObject("btnAddDefaultCondition.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddDefaultCondition.Location = New System.Drawing.Point(849, 18)
        Me.btnAddDefaultCondition.Name = "btnAddDefaultCondition"
        Me.btnAddDefaultCondition.Size = New System.Drawing.Size(158, 37)
        Me.btnAddDefaultCondition.TabIndex = 99
        Me.btnAddDefaultCondition.Text = "Add "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Default Conditions"
        '
        'cboAssessmentType
        '
        Me.cboAssessmentType.Location = New System.Drawing.Point(573, 26)
        Me.cboAssessmentType.Name = "cboAssessmentType"
        Me.cboAssessmentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAssessmentType.Properties.NullText = "[Select Assessment Type]"
        Me.cboAssessmentType.Size = New System.Drawing.Size(256, 20)
        Me.cboAssessmentType.TabIndex = 98
        '
        'btnSaveConsent
        '
        Me.btnSaveConsent.ImageOptions.Image = CType(resources.GetObject("btnSaveConsent.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSaveConsent.Location = New System.Drawing.Point(445, 17)
        Me.btnSaveConsent.Name = "btnSaveConsent"
        Me.btnSaveConsent.Size = New System.Drawing.Size(108, 38)
        Me.btnSaveConsent.TabIndex = 97
        Me.btnSaveConsent.Text = "Save "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Consent No"
        '
        'btnInsertIntoLive
        '
        Me.btnInsertIntoLive.ImageOptions.Image = CType(resources.GetObject("btnInsertIntoLive.ImageOptions.Image"),System.Drawing.Image)
        Me.btnInsertIntoLive.Location = New System.Drawing.Point(1210, 349)
        Me.btnInsertIntoLive.Name = "btnInsertIntoLive"
        Me.btnInsertIntoLive.Size = New System.Drawing.Size(178, 59)
        Me.btnInsertIntoLive.TabIndex = 96
        Me.btnInsertIntoLive.Text = "Copy ""Proposed"" "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Contributions to "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"""Live"" System"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnCreateOtherLetter)
        Me.GroupControl1.Controls.Add(Me.cboOtherDocs)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 505)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(512, 75)
        Me.GroupControl1.TabIndex = 95
        Me.GroupControl1.Text = "Create Other Documents"
        '
        'btnCreateOtherLetter
        '
        Me.btnCreateOtherLetter.ImageOptions.Image = CType(resources.GetObject("btnCreateOtherLetter.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCreateOtherLetter.Location = New System.Drawing.Point(355, 23)
        Me.btnCreateOtherLetter.Name = "btnCreateOtherLetter"
        Me.btnCreateOtherLetter.Size = New System.Drawing.Size(144, 42)
        Me.btnCreateOtherLetter.TabIndex = 1
        Me.btnCreateOtherLetter.Text = "Create Document"
        '
        'cboOtherDocs
        '
        Me.cboOtherDocs.Location = New System.Drawing.Point(9, 31)
        Me.cboOtherDocs.Name = "cboOtherDocs"
        Me.cboOtherDocs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOtherDocs.Properties.NullText = "[Select Document to print]"
        Me.cboOtherDocs.Size = New System.Drawing.Size(327, 20)
        Me.cboOtherDocs.TabIndex = 0
        '
        'btnAssembleLetter
        '
        Me.btnAssembleLetter.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAssembleLetter.Appearance.Options.UseFont = true
        Me.btnAssembleLetter.ImageOptions.Image = CType(resources.GetObject("btnAssembleLetter.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAssembleLetter.Location = New System.Drawing.Point(1210, 288)
        Me.btnAssembleLetter.Name = "btnAssembleLetter"
        Me.btnAssembleLetter.Size = New System.Drawing.Size(178, 51)
        Me.btnAssembleLetter.TabIndex = 13
        Me.btnAssembleLetter.Text = "Assemble "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Draft Letter"
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.btnEditCondition)
        Me.GroupControl9.Controls.Add(Me.btnRemoveOneOffCond)
        Me.GroupControl9.Controls.Add(Me.btnAddOneOffCond)
        Me.GroupControl9.Controls.Add(Me.dgvOneUpConditions)
        Me.GroupControl9.Location = New System.Drawing.Point(11, 285)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(996, 214)
        Me.GroupControl9.TabIndex = 11
        Me.GroupControl9.Text = "One Off Condition Codes"
        '
        'btnEditCondition
        '
        Me.btnEditCondition.Enabled = false
        Me.btnEditCondition.ImageOptions.Image = CType(resources.GetObject("btnEditCondition.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEditCondition.Location = New System.Drawing.Point(866, 133)
        Me.btnEditCondition.Name = "btnEditCondition"
        Me.btnEditCondition.Size = New System.Drawing.Size(102, 35)
        Me.btnEditCondition.TabIndex = 13
        Me.btnEditCondition.Text = "Edit "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Condition"
        '
        'btnRemoveOneOffCond
        '
        Me.btnRemoveOneOffCond.Enabled = false
        Me.btnRemoveOneOffCond.ImageOptions.Image = CType(resources.GetObject("btnRemoveOneOffCond.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveOneOffCond.Location = New System.Drawing.Point(866, 174)
        Me.btnRemoveOneOffCond.Name = "btnRemoveOneOffCond"
        Me.btnRemoveOneOffCond.Size = New System.Drawing.Size(102, 35)
        Me.btnRemoveOneOffCond.TabIndex = 12
        Me.btnRemoveOneOffCond.Text = "Remove"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Condition"
        '
        'btnAddOneOffCond
        '
        Me.btnAddOneOffCond.ImageOptions.Image = CType(resources.GetObject("btnAddOneOffCond.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddOneOffCond.Location = New System.Drawing.Point(866, 29)
        Me.btnAddOneOffCond.Name = "btnAddOneOffCond"
        Me.btnAddOneOffCond.Size = New System.Drawing.Size(102, 35)
        Me.btnAddOneOffCond.TabIndex = 11
        Me.btnAddOneOffCond.Text = "Add "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Condition"
        '
        'dgvOneUpConditions
        '
        Me.dgvOneUpConditions.Location = New System.Drawing.Point(5, 27)
        Me.dgvOneUpConditions.MainView = Me.gvwOneUpConditions
        Me.dgvOneUpConditions.Name = "dgvOneUpConditions"
        Me.dgvOneUpConditions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.dgvOneUpConditions.Size = New System.Drawing.Size(848, 182)
        Me.dgvOneUpConditions.TabIndex = 10
        Me.dgvOneUpConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOneUpConditions})
        '
        'gvwOneUpConditions
        '
        Me.gvwOneUpConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUniqueId, Me.colConditionCode, Me.colConditionText})
        Me.gvwOneUpConditions.GridControl = Me.dgvOneUpConditions
        Me.gvwOneUpConditions.Name = "gvwOneUpConditions"
        Me.gvwOneUpConditions.OptionsBehavior.Editable = false
        Me.gvwOneUpConditions.OptionsBehavior.SmartVertScrollBar = false
        Me.gvwOneUpConditions.OptionsView.ShowGroupPanel = false
        Me.gvwOneUpConditions.RowHeight = 150
        '
        'colUniqueId
        '
        Me.colUniqueId.FieldName = "UniqueId"
        Me.colUniqueId.Name = "colUniqueId"
        '
        'colConditionCode
        '
        Me.colConditionCode.Caption = "Condition Code"
        Me.colConditionCode.FieldName = "ConditionCode"
        Me.colConditionCode.Name = "colConditionCode"
        '
        'colConditionText
        '
        Me.colConditionText.AppearanceCell.Options.UseTextOptions = true
        Me.colConditionText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colConditionText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConditionText.Caption = "Condition Text"
        Me.colConditionText.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colConditionText.FieldName = "ConditionText"
        Me.colConditionText.Name = "colConditionText"
        Me.colConditionText.Visible = true
        Me.colConditionText.VisibleIndex = 0
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnRemoveCondition)
        Me.GroupControl3.Controls.Add(Me.btnAddCondition)
        Me.GroupControl3.Controls.Add(Me.dgvSTDConditions)
        Me.GroupControl3.Controls.Add(Me.cboSTDconditions)
        Me.GroupControl3.Location = New System.Drawing.Point(11, 65)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1377, 214)
        Me.GroupControl3.TabIndex = 10
        Me.GroupControl3.Text = "Standard Conditions"
        '
        'btnRemoveCondition
        '
        Me.btnRemoveCondition.Enabled = false
        Me.btnRemoveCondition.ImageOptions.Image = CType(resources.GetObject("btnRemoveCondition.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemoveCondition.Location = New System.Drawing.Point(866, 168)
        Me.btnRemoveCondition.Name = "btnRemoveCondition"
        Me.btnRemoveCondition.Size = New System.Drawing.Size(102, 35)
        Me.btnRemoveCondition.TabIndex = 12
        Me.btnRemoveCondition.Text = "Remove"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Condition"
        '
        'btnAddCondition
        '
        Me.btnAddCondition.ImageOptions.Image = CType(resources.GetObject("btnAddCondition.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddCondition.Location = New System.Drawing.Point(866, 50)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(102, 35)
        Me.btnAddCondition.TabIndex = 11
        Me.btnAddCondition.Text = "Add "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Condition"
        '
        'dgvSTDConditions
        '
        Me.dgvSTDConditions.Location = New System.Drawing.Point(5, 27)
        Me.dgvSTDConditions.MainView = Me.gvwSTDConditions
        Me.dgvSTDConditions.Name = "dgvSTDConditions"
        Me.dgvSTDConditions.Size = New System.Drawing.Size(848, 176)
        Me.dgvSTDConditions.TabIndex = 10
        Me.dgvSTDConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSTDConditions})
        '
        'gvwSTDConditions
        '
        Me.gvwSTDConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.costdlId, Me.colStdCondition, Me.colFreeFormInserts})
        Me.gvwSTDConditions.GridControl = Me.dgvSTDConditions
        Me.gvwSTDConditions.Name = "gvwSTDConditions"
        Me.gvwSTDConditions.OptionsBehavior.Editable = false
        Me.gvwSTDConditions.OptionsBehavior.SmartVertScrollBar = false
        Me.gvwSTDConditions.OptionsView.ShowGroupPanel = false
        '
        'costdlId
        '
        Me.costdlId.Caption = "id"
        Me.costdlId.FieldName = "Id"
        Me.costdlId.Name = "costdlId"
        '
        'colStdCondition
        '
        Me.colStdCondition.Caption = "Condition"
        Me.colStdCondition.FieldName = "Condition"
        Me.colStdCondition.Name = "colStdCondition"
        Me.colStdCondition.Visible = true
        Me.colStdCondition.VisibleIndex = 0
        Me.colStdCondition.Width = 764
        '
        'colFreeFormInserts
        '
        Me.colFreeFormInserts.Caption = "Inserts"
        Me.colFreeFormInserts.FieldName = "FreeFormInserts"
        Me.colFreeFormInserts.Name = "colFreeFormInserts"
        Me.colFreeFormInserts.Visible = true
        Me.colFreeFormInserts.VisibleIndex = 1
        Me.colFreeFormInserts.Width = 66
        '
        'cboSTDconditions
        '
        Me.cboSTDconditions.Location = New System.Drawing.Point(866, 24)
        Me.cboSTDconditions.Name = "cboSTDconditions"
        Me.cboSTDconditions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSTDconditions.Properties.NullText = "[Select Condition]"
        Me.cboSTDconditions.Properties.ShowFooter = false
        Me.cboSTDconditions.Properties.ShowHeader = false
        Me.cboSTDconditions.Size = New System.Drawing.Size(456, 20)
        Me.cboSTDconditions.TabIndex = 9
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(136, 11)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl57.TabIndex = 9
        Me.LabelControl57.Text = "Letter Types"
        '
        'cboConsentDocType
        '
        Me.cboConsentDocType.Location = New System.Drawing.Point(131, 30)
        Me.cboConsentDocType.Name = "cboConsentDocType"
        Me.cboConsentDocType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConsentDocType.Properties.NullText = "[Select Letter Type]"
        Me.cboConsentDocType.Properties.ShowFooter = false
        Me.cboConsentDocType.Properties.ShowHeader = false
        Me.cboConsentDocType.Size = New System.Drawing.Size(298, 20)
        Me.cboConsentDocType.TabIndex = 8
        '
        'ConsentPlanNumberTextBox
        '
        Me.ConsentPlanNumberTextBox.Location = New System.Drawing.Point(11, 29)
        Me.ConsentPlanNumberTextBox.Name = "ConsentPlanNumberTextBox"
        Me.ConsentPlanNumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ConsentPlanNumberTextBox.TabIndex = 89
        '
        'grpLetters
        '
        Me.grpLetters.Controls.Add(Me.btnEmailAcknowledge)
        Me.grpLetters.Controls.Add(Me.btnFinaliseDoc)
        Me.grpLetters.Controls.Add(Me.btnDeleteDoc)
        Me.grpLetters.Controls.Add(Me.btnViewEditDocument)
        Me.grpLetters.Controls.Add(Me.grdDraftDocs)
        Me.grpLetters.Location = New System.Drawing.Point(554, 505)
        Me.grpLetters.Name = "grpLetters"
        Me.grpLetters.Size = New System.Drawing.Size(834, 170)
        Me.grpLetters.TabIndex = 7
        Me.grpLetters.Text = "DRAFT LETTERS"
        '
        'btnEmailAcknowledge
        '
        Me.btnEmailAcknowledge.Enabled = false
        Me.btnEmailAcknowledge.ImageOptions.Image = CType(resources.GetObject("btnEmailAcknowledge.ImageOptions.Image"),System.Drawing.Image)
        Me.btnEmailAcknowledge.Location = New System.Drawing.Point(681, 35)
        Me.btnEmailAcknowledge.Name = "btnEmailAcknowledge"
        Me.btnEmailAcknowledge.Size = New System.Drawing.Size(134, 37)
        Me.btnEmailAcknowledge.TabIndex = 63
        Me.btnEmailAcknowledge.Text = "Email DA"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Acknowledgement"
        '
        'btnFinaliseDoc
        '
        Me.btnFinaliseDoc.Enabled = false
        Me.btnFinaliseDoc.ImageOptions.Image = CType(resources.GetObject("btnFinaliseDoc.ImageOptions.Image"),System.Drawing.Image)
        Me.btnFinaliseDoc.Location = New System.Drawing.Point(548, 121)
        Me.btnFinaliseDoc.Name = "btnFinaliseDoc"
        Me.btnFinaliseDoc.Size = New System.Drawing.Size(108, 37)
        Me.btnFinaliseDoc.TabIndex = 28
        Me.btnFinaliseDoc.Text = "Finalise"
        '
        'btnDeleteDoc
        '
        Me.btnDeleteDoc.Enabled = false
        Me.btnDeleteDoc.ImageOptions.Image = CType(resources.GetObject("btnDeleteDoc.ImageOptions.Image"),System.Drawing.Image)
        Me.btnDeleteDoc.Location = New System.Drawing.Point(548, 78)
        Me.btnDeleteDoc.Name = "btnDeleteDoc"
        Me.btnDeleteDoc.Size = New System.Drawing.Size(108, 37)
        Me.btnDeleteDoc.TabIndex = 27
        Me.btnDeleteDoc.Text = "Delete"
        '
        'btnViewEditDocument
        '
        Me.btnViewEditDocument.Enabled = false
        Me.btnViewEditDocument.ImageOptions.Image = CType(resources.GetObject("btnViewEditDocument.ImageOptions.Image"),System.Drawing.Image)
        Me.btnViewEditDocument.Location = New System.Drawing.Point(548, 35)
        Me.btnViewEditDocument.Name = "btnViewEditDocument"
        Me.btnViewEditDocument.Size = New System.Drawing.Size(108, 37)
        Me.btnViewEditDocument.TabIndex = 26
        Me.btnViewEditDocument.Text = "View/Edit"
        '
        'grdDraftDocs
        '
        Me.grdDraftDocs.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdDraftDocs.Location = New System.Drawing.Point(9, 35)
        Me.grdDraftDocs.MainView = Me.gvwDraftDocs
        Me.grdDraftDocs.Name = "grdDraftDocs"
        Me.grdDraftDocs.Size = New System.Drawing.Size(533, 123)
        Me.grdDraftDocs.TabIndex = 0
        Me.grdDraftDocs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDraftDocs})
        '
        'gvwDraftDocs
        '
        Me.gvwDraftDocs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAppNo, Me.colDescription, Me.colDocname, Me.colCreatedDate, Me.colDraftDocPath, Me.colDraftDocId})
        Me.gvwDraftDocs.GridControl = Me.grdDraftDocs
        Me.gvwDraftDocs.Name = "gvwDraftDocs"
        Me.gvwDraftDocs.OptionsBehavior.Editable = false
        Me.gvwDraftDocs.OptionsBehavior.ReadOnly = true
        Me.gvwDraftDocs.OptionsView.ShowGroupPanel = false
        '
        'colAppNo
        '
        Me.colAppNo.Caption = "GridColumn1"
        Me.colAppNo.FieldName = "AppNo"
        Me.colAppNo.Name = "colAppNo"
        '
        'colDescription
        '
        Me.colDescription.Caption = "Document Type"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = true
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 517
        '
        'colDocname
        '
        Me.colDocname.Caption = "Document"
        Me.colDocname.FieldName = "Docname"
        Me.colDocname.Name = "colDocname"
        Me.colDocname.Width = 523
        '
        'colCreatedDate
        '
        Me.colCreatedDate.Caption = "Created"
        Me.colCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate.FieldName = "DateCreated"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = true
        Me.colCreatedDate.VisibleIndex = 1
        Me.colCreatedDate.Width = 94
        '
        'colDraftDocPath
        '
        Me.colDraftDocPath.Caption = "GridColumn4"
        Me.colDraftDocPath.FieldName = "DraftDocPath"
        Me.colDraftDocPath.Name = "colDraftDocPath"
        '
        'colDraftDocId
        '
        Me.colDraftDocId.Caption = "GridColumn5"
        Me.colDraftDocId.FieldName = "DraftDocId"
        Me.colDraftDocId.Name = "colDraftDocId"
        '
        'tpgAssociated
        '
        Me.tpgAssociated.Controls.Add(Me.pnlDisplayAssociatedApps)
        Me.tpgAssociated.ImageOptions.Image = CType(resources.GetObject("tpgAssociated.ImageOptions.Image"),System.Drawing.Image)
        Me.tpgAssociated.Name = "tpgAssociated"
        Me.tpgAssociated.Size = New System.Drawing.Size(1423, 721)
        Me.tpgAssociated.Text = "Associated Applications"
        '
        'pnlDisplayAssociatedApps
        '
        Me.pnlDisplayAssociatedApps.Controls.Add(Me.grdAssociatedApps)
        Me.pnlDisplayAssociatedApps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayAssociatedApps.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayAssociatedApps.Name = "pnlDisplayAssociatedApps"
        Me.pnlDisplayAssociatedApps.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayAssociatedApps.TabIndex = 7
        '
        'grdAssociatedApps
        '
        Me.grdAssociatedApps.Location = New System.Drawing.Point(100, 28)
        Me.grdAssociatedApps.MainView = Me.gvwAssociatedApps
        Me.grdAssociatedApps.Name = "grdAssociatedApps"
        Me.grdAssociatedApps.Size = New System.Drawing.Size(1003, 595)
        Me.grdAssociatedApps.TabIndex = 2
        Me.grdAssociatedApps.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwAssociatedApps})
        '
        'gvwAssociatedApps
        '
        Me.gvwAssociatedApps.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAssocAppNo, Me.colRegistered, Me.colTypeOf, Me.colAssocDescription, Me.colAssocDADecision, Me.colCCNo})
        Me.gvwAssociatedApps.GridControl = Me.grdAssociatedApps
        Me.gvwAssociatedApps.Name = "gvwAssociatedApps"
        Me.gvwAssociatedApps.OptionsBehavior.Editable = false
        Me.gvwAssociatedApps.OptionsBehavior.ReadOnly = true
        Me.gvwAssociatedApps.OptionsView.ShowGroupPanel = false
        '
        'colAssocAppNo
        '
        Me.colAssocAppNo.Caption = "App No."
        Me.colAssocAppNo.FieldName = "AppNo"
        Me.colAssocAppNo.Name = "colAssocAppNo"
        Me.colAssocAppNo.Visible = true
        Me.colAssocAppNo.VisibleIndex = 0
        Me.colAssocAppNo.Width = 67
        '
        'colRegistered
        '
        Me.colRegistered.Caption = "Registered"
        Me.colRegistered.FieldName = "Registered"
        Me.colRegistered.Name = "colRegistered"
        Me.colRegistered.Visible = true
        Me.colRegistered.VisibleIndex = 1
        Me.colRegistered.Width = 102
        '
        'colTypeOf
        '
        Me.colTypeOf.Caption = "Type"
        Me.colTypeOf.FieldName = "TypeOf"
        Me.colTypeOf.Name = "colTypeOf"
        Me.colTypeOf.Visible = true
        Me.colTypeOf.VisibleIndex = 2
        Me.colTypeOf.Width = 178
        '
        'colAssocDescription
        '
        Me.colAssocDescription.Caption = "Description"
        Me.colAssocDescription.FieldName = "Description"
        Me.colAssocDescription.Name = "colAssocDescription"
        Me.colAssocDescription.Visible = true
        Me.colAssocDescription.VisibleIndex = 3
        Me.colAssocDescription.Width = 490
        '
        'colAssocDADecision
        '
        Me.colAssocDADecision.Caption = "Status"
        Me.colAssocDADecision.FieldName = "DADecision"
        Me.colAssocDADecision.Name = "colAssocDADecision"
        Me.colAssocDADecision.Visible = true
        Me.colAssocDADecision.VisibleIndex = 4
        Me.colAssocDADecision.Width = 128
        '
        'colCCNo
        '
        Me.colCCNo.Caption = "C.C. No"
        Me.colCCNo.FieldName = "CCNo"
        Me.colCCNo.Name = "colCCNo"
        Me.colCCNo.Visible = true
        Me.colCCNo.VisibleIndex = 5
        '
        'tpgEnlighten
        '
        Me.tpgEnlighten.Controls.Add(Me.pnlDisplayEnlighten)
        Me.tpgEnlighten.Name = "tpgEnlighten"
        Me.tpgEnlighten.PageVisible = false
        Me.tpgEnlighten.Size = New System.Drawing.Size(1423, 721)
        Me.tpgEnlighten.Text = "GIS Map"
        '
        'pnlDisplayEnlighten
        '
        Me.pnlDisplayEnlighten.Controls.Add(Me.btnClearEnlightenMap)
        Me.pnlDisplayEnlighten.Controls.Add(Me.btnSaveEnlighten)
        Me.pnlDisplayEnlighten.Controls.Add(Me.btnInsertEnlightenMap)
        Me.pnlDisplayEnlighten.Controls.Add(Me.picEnlightenMap)
        Me.pnlDisplayEnlighten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayEnlighten.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayEnlighten.Name = "pnlDisplayEnlighten"
        Me.pnlDisplayEnlighten.Size = New System.Drawing.Size(1423, 721)
        Me.pnlDisplayEnlighten.TabIndex = 27
        '
        'btnClearEnlightenMap
        '
        Me.btnClearEnlightenMap.Enabled = false
        Me.btnClearEnlightenMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearEnlightenMap.ImageKey = "Artdesigner-Urban-Stories-Map.ico"
        Me.btnClearEnlightenMap.ImageList = Me.ImageList3
        Me.btnClearEnlightenMap.Location = New System.Drawing.Point(1016, 63)
        Me.btnClearEnlightenMap.Name = "btnClearEnlightenMap"
        Me.btnClearEnlightenMap.Size = New System.Drawing.Size(128, 40)
        Me.btnClearEnlightenMap.TabIndex = 10
        Me.btnClearEnlightenMap.Text = "Clear GIS Map"
        Me.btnClearEnlightenMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearEnlightenMap.UseVisualStyleBackColor = true
        '
        'btnSaveEnlighten
        '
        Me.btnSaveEnlighten.Enabled = false
        Me.btnSaveEnlighten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveEnlighten.ImageKey = "Artdesigner-Urban-Stories-Map.ico"
        Me.btnSaveEnlighten.ImageList = Me.ImageList4
        Me.btnSaveEnlighten.Location = New System.Drawing.Point(1016, 109)
        Me.btnSaveEnlighten.Name = "btnSaveEnlighten"
        Me.btnSaveEnlighten.Size = New System.Drawing.Size(128, 40)
        Me.btnSaveEnlighten.TabIndex = 9
        Me.btnSaveEnlighten.Text = "Save GIS Map"
        Me.btnSaveEnlighten.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveEnlighten.UseVisualStyleBackColor = true
        '
        'btnInsertEnlightenMap
        '
        Me.btnInsertEnlightenMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertEnlightenMap.ImageKey = "Artdesigner-Urban-Stories-Map.ico"
        Me.btnInsertEnlightenMap.ImageList = Me.ImageList3
        Me.btnInsertEnlightenMap.Location = New System.Drawing.Point(1016, 17)
        Me.btnInsertEnlightenMap.Name = "btnInsertEnlightenMap"
        Me.btnInsertEnlightenMap.Size = New System.Drawing.Size(128, 40)
        Me.btnInsertEnlightenMap.TabIndex = 8
        Me.btnInsertEnlightenMap.Text = "Insert GIS Map"
        Me.btnInsertEnlightenMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsertEnlightenMap.UseVisualStyleBackColor = true
        '
        'picEnlightenMap
        '
        Me.picEnlightenMap.Location = New System.Drawing.Point(28, 17)
        Me.picEnlightenMap.Name = "picEnlightenMap"
        Me.picEnlightenMap.Size = New System.Drawing.Size(960, 591)
        Me.picEnlightenMap.TabIndex = 0
        Me.picEnlightenMap.TabStop = false
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnFind)
        Me.pnlSearch.Controls.Add(Me.Label13)
        Me.pnlSearch.Controls.Add(Me.lblapplicationNo)
        Me.pnlSearch.Controls.Add(Me.lblSearchFor)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.cboSearchType)
        Me.pnlSearch.Controls.Add(Me.grpSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 143)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1590, 47)
        Me.pnlSearch.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnFind.Appearance.Options.UseFont = true
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"),System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(687, 5)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(123, 36)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Locate"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(823, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 24)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "DA Number"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblapplicationNo
        '
        Me.lblapplicationNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblapplicationNo.Location = New System.Drawing.Point(936, 8)
        Me.lblapplicationNo.Name = "lblapplicationNo"
        Me.lblapplicationNo.Size = New System.Drawing.Size(176, 30)
        Me.lblapplicationNo.TabIndex = 41
        Me.lblapplicationNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSearchFor
        '
        Me.lblSearchFor.AutoSize = true
        Me.lblSearchFor.Location = New System.Drawing.Point(201, 17)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(94, 13)
        Me.lblSearchFor.TabIndex = 11
        Me.lblSearchFor.Text = "to search for. . . ."
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(299, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(172, 21)
        Me.txtSearch.TabIndex = 1
        '
        'cboSearchType
        '
        Me.cboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchType.FormattingEnabled = true
        Me.cboSearchType.Items.AddRange(New Object() {"DA Number", "Construction Certificate", "File No", "PIN", "Applicant Address ", "Property Address", "Applicant  Name", "Owners Name", "Development Type", "Description"})
        Me.cboSearchType.Location = New System.Drawing.Point(12, 13)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(181, 21)
        Me.cboSearchType.TabIndex = 0
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.mskEndDate)
        Me.grpSearch.Controls.Add(Me.mskStartDate)
        Me.grpSearch.Controls.Add(Me.Label47)
        Me.grpSearch.Controls.Add(Me.Label48)
        Me.grpSearch.Controls.Add(Me.cboSearch)
        Me.grpSearch.Location = New System.Drawing.Point(199, 4)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(464, 36)
        Me.grpSearch.TabIndex = 28
        Me.grpSearch.TabStop = false
        Me.grpSearch.Visible = false
        '
        'mskEndDate
        '
        Me.mskEndDate.EditValue = Nothing
        Me.mskEndDate.Location = New System.Drawing.Point(358, 11)
        Me.mskEndDate.Name = "mskEndDate"
        Me.mskEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskEndDate.Size = New System.Drawing.Size(100, 20)
        Me.mskEndDate.TabIndex = 2
        '
        'mskStartDate
        '
        Me.mskStartDate.EditValue = Nothing
        Me.mskStartDate.Location = New System.Drawing.Point(234, 11)
        Me.mskStartDate.Name = "mskStartDate"
        Me.mskStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mskStartDate.Size = New System.Drawing.Size(100, 20)
        Me.mskStartDate.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.AutoSize = true
        Me.Label47.Location = New System.Drawing.Point(340, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(17, 13)
        Me.Label47.TabIndex = 27
        Me.Label47.Text = "to"
        '
        'Label48
        '
        Me.Label48.AutoSize = true
        Me.Label48.Location = New System.Drawing.Point(204, 14)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(31, 13)
        Me.Label48.TabIndex = 26
        Me.Label48.Text = "From"
        '
        'cboSearch
        '
        Me.cboSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.FormattingEnabled = true
        Me.cboSearch.Location = New System.Drawing.Point(6, 11)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(182, 21)
        Me.cboSearch.TabIndex = 0
        '
        'btnAddExistingRecordDocument
        '
        Me.btnAddExistingRecordDocument.ImageOptions.Image = CType(resources.GetObject("btnAddExistingRecordDocument.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddExistingRecordDocument.Location = New System.Drawing.Point(1005, 13)
        Me.btnAddExistingRecordDocument.Name = "btnAddExistingRecordDocument"
        Me.btnAddExistingRecordDocument.Size = New System.Drawing.Size(154, 52)
        Me.btnAddExistingRecordDocument.TabIndex = 33
        Me.btnAddExistingRecordDocument.Text = "Add existing EASE "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"document from File to"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" this application"
        '
        'DevelopmentStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.ClientSize = New System.Drawing.Size(1590, 917)
        Me.Controls.Add(Me.tabPanels)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "DevelopmentStart"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Development Application"
        CType(Me.tabPanels,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPanels.ResumeLayout(false)
        Me.tpgApplication.ResumeLayout(false)
        CType(Me.pnlApplicationData,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlApplicationData.ResumeLayout(false)
        Me.pnlApplicationData.PerformLayout
        CType(Me.grpBasix,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpBasix.ResumeLayout(false)
        Me.grpBasix.PerformLayout
        CType(Me.grpFileNumber,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFileNumber.ResumeLayout(false)
        Me.grpFileNumber.PerformLayout
        CType(Me.grpOwner,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpOwner.ResumeLayout(false)
        Me.grpOwner.PerformLayout
        CType(Me.grpAdditional,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpAdditional.ResumeLayout(false)
        Me.grpAdditional.PerformLayout
        CType(Me.cboDAClass2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAClass1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAClass3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAtype1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAtype3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAType2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpPurpose,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpPurpose.ResumeLayout(false)
        Me.grpPurpose.PerformLayout
        CType(Me.grpDescription,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDescription.ResumeLayout(false)
        Me.grpDescription.PerformLayout
        CType(Me.lupOccupancyStatus.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAClass.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAttachmentStatus.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDemolishedDwelings.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtExistingDwelings.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboIntendedLandUse.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudDwellings.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboBuildingType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboConsentType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDevUse.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDevType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpLand,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLand.ResumeLayout(false)
        Me.GroupBox21.ResumeLayout(false)
        CType(Me.grdPIN,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwPIN,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RibbonControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpPropertyLotAddress.ResumeLayout(false)
        Me.grpPropertyLotAddress.PerformLayout
        CType(Me.cboAreaType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDACensusCode.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAlocalityCode.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpCCSum,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpCCSum.ResumeLayout(false)
        Me.grpCCSum.PerformLayout
        CType(Me.grpDetails,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDetails.ResumeLayout(false)
        Me.grpDetails.PerformLayout
        CType(Me.txtOfficer.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboSector.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAppType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgFees.ResumeLayout(false)
        CType(Me.pnlDisplayFees,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayFees.ResumeLayout(false)
        CType(Me.GroupControl6,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl6.ResumeLayout(false)
        Me.GroupControl6.PerformLayout
        CType(Me.grdDARefundsPaid,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwDARefundsPaid,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl4.ResumeLayout(false)
        CType(Me.grdPaymentsReceived,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwPaymentsReceived,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgSection68.ResumeLayout(false)
        CType(Me.pnlDisplaySect68IntDev,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplaySect68IntDev.ResumeLayout(false)
        CType(Me.grpSepp71,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpSepp71.ResumeLayout(false)
        Me.grpSepp71.PerformLayout
        CType(Me.cboDesignatedYN.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboIntDevYN.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grp68,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp68.ResumeLayout(false)
        CType(Me.grdSection68,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwSection68,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lupSection68.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupBox9,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox9.ResumeLayout(false)
        Me.GroupBox9.PerformLayout
        CType(Me.grdIntDev,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwIntDev,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboIntDevActs.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mskDateAct.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mskDateAct.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgReferrals.ResumeLayout(false)
        CType(Me.pnlDisplayReferrals,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayReferrals.ResumeLayout(false)
        CType(Me.grpMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpMain.ResumeLayout(false)
        Me.grpMain.PerformLayout
        CType(Me.chksepp71.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DaysElapsedTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRefCodeId.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RefRetDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RefRetDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Refdt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Refdt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpIntDesig,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpIntDesig.ResumeLayout(false)
        CType(Me.cboReferralsIntProvision.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpRFS,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpRFS.ResumeLayout(false)
        Me.grpRFS.PerformLayout
        CType(Me.txtRFSSubLots.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRFSSubDivisionType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpEngineers,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpEngineers.ResumeLayout(false)
        Me.grpEngineers.PerformLayout
        CType(Me.EngDueReturnDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EngDueReturnDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtEngInternalComments.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRefComm.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pnlButtons,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlButtons.ResumeLayout(false)
        CType(Me.dgvLoadListReferrals,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwLoadListReferrals,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRefResponse.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgStatus.ResumeLayout(false)
        CType(Me.pnlDisplayStatus,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayStatus.ResumeLayout(false)
        CType(Me.GroupControl10,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl10.ResumeLayout(false)
        Me.GroupControl10.PerformLayout
        CType(Me.txtDesignatedText.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDepartPlanning.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAdvertSignIntDetails.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDepotAddress.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAdvertSignDepot.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupBox18,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox18.ResumeLayout(false)
        Me.GroupBox18.PerformLayout
        CType(Me.grpAssessment,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpAssessment.ResumeLayout(false)
        Me.grpAssessment.PerformLayout
        CType(Me.DAToTypingDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAToTypingDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAToPlannerDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAToPlannerDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DASiteInspectedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DASiteInspectedDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PreAssessCompleteDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PreAssessCompleteDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RefToPlanCom.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RefToPlanCom.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpNotification,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpNotification.ResumeLayout(false)
        Me.grpNotification.PerformLayout
        CType(Me.DACompletedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DACompletedDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DACommDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DACommDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAAdvisedDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAAdvisedDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpDetermination,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDetermination.ResumeLayout(false)
        Me.grpDetermination.PerformLayout
        CType(Me.DAPermExDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAPermExDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboProgressCode.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAOccDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAOccDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboReasonOver40.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAConsentPubDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAConsentPubDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDADecisionId.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDAAuthorityId.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAFreeTreeDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAFreeTreeDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsentPostedDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsentPostedDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAAppNotDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DAAppNotDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DADetermDt.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DADetermDt.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgDocuments.ResumeLayout(false)
        CType(Me.pnlDisplayDocs,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayDocs.ResumeLayout(false)
        CType(Me.GroupBox32,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox32.ResumeLayout(false)
        Me.GroupBox32.PerformLayout
        CType(Me.grdDocumentsList,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwDocumentsList,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgVariations.ResumeLayout(false)
        CType(Me.pnlDisplayVariations,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayVariations.ResumeLayout(false)
        CType(Me.GroupBox28,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox28.ResumeLayout(false)
        CType(Me.grdVariations,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwVariations,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit5,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox8.ResumeLayout(false)
        Me.GroupBox8.PerformLayout
        CType(Me.cboVariationAuthority.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboVariationResult.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.variationDecisionDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.variationDecisionDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox29.ResumeLayout(false)
        Me.GroupBox29.PerformLayout
        CType(Me.cboVariationType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgSubmissions.ResumeLayout(false)
        CType(Me.pnlDisplaySubmisions,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplaySubmisions.ResumeLayout(false)
        Me.pnlDisplaySubmisions.PerformLayout
        CType(Me.GroupBox30,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox30.ResumeLayout(false)
        CType(Me.GroupControl8,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl8.ResumeLayout(false)
        CType(Me.grdSubmissionDrafts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwSubmissionDrafts,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdSubmissionandObjections,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwSubmissionandObjections,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox31.ResumeLayout(false)
        Me.GroupBox31.PerformLayout
        CType(Me.chkUseEmail.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboSubmissionType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubRecdDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubRecdDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgPCAConditions.ResumeLayout(false)
        CType(Me.pnlDisplayPCAconditions,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayPCAconditions.ResumeLayout(false)
        CType(Me.GroupBox36,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox36.ResumeLayout(false)
        CType(Me.grdOneOffConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwOneOffConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupBox35,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox35.ResumeLayout(false)
        CType(Me.grdSTDCond,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwSTDCond,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgFileNotes.ResumeLayout(false)
        CType(Me.pnlDisplayFileNotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayFileNotes.ResumeLayout(false)
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        CType(Me.GroupControl5,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl5.ResumeLayout(false)
        CType(Me.grdFileNotes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwFileNotes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFileNotes,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFileNotes.ResumeLayout(false)
        Me.grpFileNotes.PerformLayout
        CType(Me.cboNotesOfficer.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboNoteType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NoteDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NoteDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgBuildLetters.ResumeLayout(false)
        CType(Me.pnlBuildLetters,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlBuildLetters.ResumeLayout(false)
        Me.pnlBuildLetters.PerformLayout
        CType(Me.cboAssessmentType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.cboOtherDocs.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl9,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl9.ResumeLayout(false)
        CType(Me.dgvOneUpConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwOneUpConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(false)
        CType(Me.dgvSTDConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwSTDConditions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboSTDconditions.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboConsentDocType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpLetters,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLetters.ResumeLayout(false)
        CType(Me.grdDraftDocs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwDraftDocs,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgAssociated.ResumeLayout(false)
        CType(Me.pnlDisplayAssociatedApps,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayAssociatedApps.ResumeLayout(false)
        CType(Me.grdAssociatedApps,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwAssociatedApps,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpgEnlighten.ResumeLayout(false)
        CType(Me.pnlDisplayEnlighten,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDisplayEnlighten.ResumeLayout(false)
        CType(Me.picEnlightenMap,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pnlSearch,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlSearch.ResumeLayout(false)
        Me.pnlSearch.PerformLayout
        Me.grpSearch.ResumeLayout(false)
        Me.grpSearch.PerformLayout
        CType(Me.mskEndDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mskEndDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mskStartDate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mskStartDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imlNavigation As System.Windows.Forms.ImageList
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrapTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerAddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TownDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveredDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveredByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrapNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OnLoanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustAddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustTownDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustPhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCollarRequestedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCollarIssuedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCollarReturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WantListByIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferencesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imgSmll As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList5 As System.Windows.Forms.ImageList
    Friend WithEvents tabPanels As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpgApplication As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgFees As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgSection68 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgReferrals As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgStatus As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgDocuments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgVariations As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgSubmissions As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgPCAConditions As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgFileNotes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgBuildLetters As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgAssociated As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgEnlighten As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlApplicationData As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpBasix As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtBASIXRcptNo As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents chkBASIXRecd As CheckBox
    Friend WithEvents txtBASIXCertNo As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtBASIXwater As TextBox
    Friend WithEvents txtBASIXthermal As TextBox
    Friend WithEvents txtBASIXenergy As TextBox
    Friend WithEvents lblDesignated As Label
    Friend WithEvents lblAdvertising As Label
    Friend WithEvents grpOwner As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpPurpose As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkDADesc8 As CheckBox
    Friend WithEvents chkDADesc7 As CheckBox
    Friend WithEvents chkDADesc6 As CheckBox
    Friend WithEvents chkDADesc5 As CheckBox
    Friend WithEvents chkDADesc4 As CheckBox
    Friend WithEvents chkDADesc3 As CheckBox
    Friend WithEvents chkDADesc2 As CheckBox
    Friend WithEvents chkDesc1 As CheckBox
    Friend WithEvents grpDescription As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label43 As Label
    Friend WithEvents cboBuildingType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCurrentLandUse As TextBox
    Friend WithEvents chkGiftDonation As CheckBox
    Friend WithEvents Label94 As Label
    Friend WithEvents lblModDesc As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtModDesc As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtDAFloor As TextBox
    Friend WithEvents txtDAestCost As TextBox
    Friend WithEvents txtDADesc As TextBox
    Friend WithEvents cboConsentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDevUse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDevType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpAdditional As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents cboDAtype1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAtype3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAType2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpLand As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents grpPropertyLotAddress As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cboAreaType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtArea As TextBox
    Friend WithEvents cboDACensusCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents cboDAlocalityCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLot As TextBox
    Friend WithEvents txtDP As TextBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtStreetNo As TextBox
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents grpCCSum As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCCInsuranceNo As TextBox
    Friend WithEvents txtCCLicBuilderName As TextBox
    Friend WithEvents txtCCOwnerBuilderNo As TextBox
    Friend WithEvents CCValueTextBox As TextBox
    Friend WithEvents OfficerTextBox As TextBox
    Friend WithEvents CoPCAnameTextBox As TextBox
    Friend WithEvents DADecisionTextBox As TextBox
    Friend WithEvents CCAppNoTextBox As TextBox
    Friend WithEvents grpDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboSector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label33 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDADecision As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents dtRego As MaskedTextBox
    Friend WithEvents cboAppType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblOfficer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents chkSec94 As CheckBox
    Friend WithEvents txtFileNo As TextBox
    Friend WithEvents txtCCno As TextBox
    Friend WithEvents txtDANo As TextBox
    Friend WithEvents pnlDisplayAssociatedApps As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlDisplayDocs As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox32 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaveTheNote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdDocumentsList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwDocumentsList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colApNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateCreated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocnotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocMTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocYr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWORDDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Label102 As Label
    Friend WithEvents txtDocNote As TextBox
    Friend WithEvents pnlDisplayEnlighten As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClearEnlightenMap As Button
    Friend WithEvents btnSaveEnlighten As Button
    Friend WithEvents btnInsertEnlightenMap As Button
    Friend WithEvents picEnlightenMap As PictureBox
    Friend WithEvents pnlDisplayFees As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDifference As TextBox
    Friend WithEvents txtRefunds As TextBox
    Friend WithEvents txtReceipts As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents pnlDisplayFileNotes As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblNotesID As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents txtNotesReferredTo As TextBox
    Friend WithEvents txtNotesFollowUp As TextBox
    Friend WithEvents txtNotesCC As TextBox
    Friend WithEvents txtNotesContactNo As TextBox
    Friend WithEvents txtNotesSpokeTo As TextBox
    Friend WithEvents txtNoteDetails As TextBox
    Friend WithEvents Label118 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents txtNotesSubject As TextBox
    Friend WithEvents pnlDisplayPCAconditions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox36 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox35 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlDisplayReferrals As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlDisplaySect68IntDev As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label49 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlDisplayStatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox18 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDaysTaken As TextBox
    Friend WithEvents txtDaysElapsed As TextBox
    Friend WithEvents txtDaysAddinfo As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents lblReferralCount As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents grpAssessment As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label72 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents grpNotification As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rbNotifyAdvert As RadioButton
    Friend WithEvents rbNotify As RadioButton
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents Label93 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents grpDetermination As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkAPZYesNo As CheckBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents txtProgressComment As TextBox
    Friend WithEvents pnlDisplaySubmisions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DACompletedDtLabel2 As Label
    Friend WithEvents GroupBox30 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents chkSubGift As CheckBox
    Friend WithEvents Label109 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents txtOfficerComment As TextBox
    Friend WithEvents txtSubmissionSummary As TextBox
    Friend WithEvents txtAuthorPhone As TextBox
    Friend WithEvents txtAuthorTown As TextBox
    Friend WithEvents txtAuthorPCode As TextBox
    Friend WithEvents txtAuthurAddress As TextBox
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents lblSubID As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents pnlDisplayVariations As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox28 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label100 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents txtVariationDetails As TextBox
    Friend WithEvents pnlSearch As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents lblSearchFor As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboSearchType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblapplicationNo As Label
    Friend WithEvents mskStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents mskEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents mskDateAct As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SubRecdDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DACompletedDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DACommDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAAdvisedDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAPermExDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAOccDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAConsentPubDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAFreeTreeDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ConsentPostedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAAppNotDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DADetermDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAToPlannerDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DASiteInspectedDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PreAssessCompleteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RefToPlanCom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DAToTypingDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents NoteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents variationDecisionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents pnlBuildLetters As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gvwOneUpConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUniqueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConditionCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConditionText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gvwSTDConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents costdlId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdCondition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreeFormInserts As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpLetters As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdDraftDocs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwDraftDocs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConsentPlanNumberTextBox As TextBox
    Friend WithEvents colDraftDocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDraftDocPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnViewEditDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFinaliseDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboConsentDocType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboSTDconditions As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgvSTDConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnAddCondition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveCondition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvOneUpConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnAddOneOffCond As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveOneOffCond As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAssembleLetter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditCondition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboOtherDocs As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCreateOtherLetter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInsertIntoLive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveConsent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAssessmentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAddDefaultCondition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdFileNotes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwFileNotes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFileNoteType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpFileNotes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaveNote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditNote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddNote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNotePrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAckSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSubmissionandObjections As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSubmissionandObjections As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnMapMerge As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDesignIntegr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDesignated As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintAdvNotice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintAdvert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboNotesOfficer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboNoteType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboSubmissionType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnSaveSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdVariations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwVariations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVarID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariationdetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariationResultDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelegatedAuthority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDecisionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserStamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cboVariationAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVariationResult As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnSaveVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btneditVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboVariationType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRemoveVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddNewVariationType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPaymentsReceived As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwPaymentsReceived As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecdpayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiptNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInspectionPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInspTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRemoveFee As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddFee As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveRefund As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditRefund As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddRefund As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdDARefundsPaid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwDARefundsPaid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefundPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefundIDX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblReferralID As Label
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRTA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DaysElapsedTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRemoveRefer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveReferralsTab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditReferralsTab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddReferral As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboRefCodeId As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RefRetDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Refdt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpIntDesig As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAddIntegrated As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveIntegated As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboReferralsIntProvision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lstIntegrated As ListBox
    Friend WithEvents grpRFS As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRFSSubLots As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrintRFSSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintRFSOther As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboRFSSubDivisionType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEngineers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EngDueReturnDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEngInternalComments As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRefComm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlButtons As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnMailResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReferral As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDraftconditions As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvLoadListReferrals As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwLoadListReferrals As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReferralId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefdt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferralCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAdvertSignDepot As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboProgressCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboReasonOver40 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDADecisionId As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAAuthorityId As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboIntDevActs As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grdIntDev As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwIntDev As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTheAct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSetIntDevDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMaitList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveIntDev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddIntDev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdAssociatedApps As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwAssociatedApps As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAssocAppNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegistered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypeOf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssocDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssocDADecision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdOneOffConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOneOffConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOneOffUniqueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOneOffCondCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConditionalText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOneOffCCMetDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdSTDCond As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSTDCond As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAppCondId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdCondCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdCCMetDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOneOffCondDone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStdCondDone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemMemoEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnRetrieveProperty As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemovePIN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddPIN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpFileNumber As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRemoveFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddFile As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtFile As TextBox
    Public WithEvents lstFile As ListBox
    Public WithEvents Label59 As Label
    Friend WithEvents btnViewOfficers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label30 As Label
    Friend WithEvents txtAuthorEmail As TextBox
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnEmailAcknowledgement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFinaliseSubmission As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteSubmission As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditSubmision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSubmissionDrafts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSubmissionDrafts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEmailAcknowledge As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chksepp71 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colCCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOfficer As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtAdvertSignIntDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDepotAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnModifyAdvertAddress As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDeptPlanning As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModifyDeptPlanning As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label31 As Label
    Friend WithEvents txtDepartPlanning As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnSaveDesignatedText As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModifyDesignatedText As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label32 As Label
    Friend WithEvents txtDesignatedText As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnRemoveSub As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemovePDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblBuilderName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOwnerBuilder As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOwnerBuilderNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInsuranceNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblinsurValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefResponse As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ibExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiSection94 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiCompliance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiConstructionCert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiEngineerConsent As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiAssessment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiMyOSDas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiAddDA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiEditDA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BiSaveDA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibImages As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibOldSystemImages As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCurrentImages As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibVideos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibPrintCoverSheet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCreateTemplate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibRptsExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgReports As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ibMaintExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibOfficers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibLookupLists As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibSection94Codes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibSection94RF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ibDevelopmentTypes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibPCAbuilders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAuthorities As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibDAUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibReferralList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibSEPPcodes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibDCPtypes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibDCPGuidlines As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspectionTypes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibStdCondCodes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInsuranceCoy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibConsentAdvert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibABSStats As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibNavision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAppCounters As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibAllResults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibDAresults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCDresults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCresults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibReports As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibApprovals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibOfficerAllocations As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibDevelopmentApps As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibConstructionCertificates As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibReferrrals As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibMayoral As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibDAreceived As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCreceived As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibOutstandingDA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibDAdetermined As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCdetermined As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspections As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibApprovalsByTown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibOccupByTown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibSepticByTown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAppliByOfficer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibTotalNoDACC As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ibStatutoryTime As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCwithoutOC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibExpiredIOC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibNumberDwellingsAppd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibOutstandCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAppdDelegation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibLTW As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAverageTime As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibLEPRegister As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibMayoralRecd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibMayoralDetermined As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibOSreferrals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibReferralsByOfficer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCOwner As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibCCPCA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspectionByOfficer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspectOfficerAndType As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspectOfficerSummary As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibInspectFileNumber As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibAdditionalIfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibLinked As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdPIN As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwPIN As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ibIntraMaps As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ibGoogleMaps As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label19 As Label
    Friend WithEvents txtAppemail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAppPhone As TextBox
    Friend WithEvents txtAppPcode As TextBox
    Friend WithEvents txtAppTown As TextBox
    Friend WithEvents txtAppAddress As TextBox
    Friend WithEvents txtAppName As TextBox
    Friend WithEvents txtDAOwnersPcode As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtDAOwnersName As TextBox
    Friend WithEvents txtDAOwnersAddress As TextBox
    Friend WithEvents txtDAOwnersTown As TextBox
    Friend WithEvents txtDAOwnersPhone As TextBox
    Friend WithEvents grp68 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRemove68 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSection68 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSection68 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lupSection68 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnInsert68 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents cboDAClass2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAClass1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAClass3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label39 As Label
    Friend WithEvents cboDAClass As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblOccupancy As Label
    Friend WithEvents lblAttachement As Label
    Friend WithEvents cboAttachmentStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDemolishedDwelings As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNoDemolishedDwellings As Label
    Friend WithEvents txtExistingDwelings As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblExistingDwellings As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents cboIntendedLandUse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents nudDwellings As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNoDwellings As Label
    Friend WithEvents lupOccupancyStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnUse2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKeep2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKeep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkUseEmail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpSepp71 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboDesignatedYN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboIntDevYN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnAddExistingRecordDocument As DevExpress.XtraEditors.SimpleButton
End Class
