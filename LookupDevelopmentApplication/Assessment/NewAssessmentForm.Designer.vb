<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewAssessmentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label20 As System.Windows.Forms.Label
        Dim DevHistoryCommentLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim ActedOnLabel As System.Windows.Forms.Label
        Dim Label95 As System.Windows.Forms.Label
        Dim AssessmentDecisionLabel As System.Windows.Forms.Label
        Dim Label128 As System.Windows.Forms.Label
        Dim VariationsYesNoLabel As System.Windows.Forms.Label
        Dim Label83 As System.Windows.Forms.Label
        Dim Label81 As System.Windows.Forms.Label
        Dim ComplianceStatProvYesNoLabel As System.Windows.Forms.Label
        Dim ReferralsYesNoLabel As System.Windows.Forms.Label
        Dim ComplianceStatProvCommentsLabel As System.Windows.Forms.Label
        Dim ModSect94CommentLabel As System.Windows.Forms.Label
        Dim ModSect94YNLabel As System.Windows.Forms.Label
        Dim ModSect79cCommentLabel As System.Windows.Forms.Label
        Dim Modsect79cYNLabel As System.Windows.Forms.Label
        Dim ModMinEnvImpCommentLabel As System.Windows.Forms.Label
        Dim ModMinEnvImpactYNLabel As System.Windows.Forms.Label
        Dim ModSect96Label As System.Windows.Forms.Label
        Dim ModThreatCommentLabel As System.Windows.Forms.Label
        Dim ModThreatComplYNLabel As System.Windows.Forms.Label
        Dim ModThreatSpecYNLabel As System.Windows.Forms.Label
        Dim ModMinisterCommentLabel As System.Windows.Forms.Label
        Dim ModMinisterOBjYNLabel As System.Windows.Forms.Label
        Dim ModConsMinisterYNLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAssessmentForm))
        Dim ModSubmConsYNLabel As System.Windows.Forms.Label
        Dim ModNotificationYNLabel As System.Windows.Forms.Label
        Dim ModSubStSameCommentLabel As System.Windows.Forms.Label
        Dim ModSubstSameYNLabel As System.Windows.Forms.Label
        Dim ModReasonLabel As System.Windows.Forms.Label
        Dim ModDetailsLabel As System.Windows.Forms.Label
        Me.RepositoryItemMemoEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLockAssessment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintAssessment = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDetermineDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblapplicationNo = New System.Windows.Forms.Label()
        Me.tabAssessment = New DevExpress.XtraTab.XtraTabControl()
        Me.tpgHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayHistory = New DevExpress.XtraEditors.PanelControl()
        Me.grpHistoricalDA = New DevExpress.XtraEditors.GroupControl()
        Me.grdHistoricalDA = New DevExpress.XtraGrid.GridControl()
        Me.gvwHistoricalDA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrevDANo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProposal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colDecision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_DecisionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.btnRetrievePreviousDAHistory = New DevExpress.XtraEditors.SimpleButton()
        Me.grpHisDa = New System.Windows.Forms.GroupBox()
        Me.btnViewDa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpDateHistory = New DevExpress.XtraEditors.SimpleButton()
        Me.cboActedOn = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDAno = New System.Windows.Forms.Label()
        Me.CommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.DevHistoryCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblAssessmentReportEased = New System.Windows.Forms.Label()
        Me.gbxAssessmentRept = New System.Windows.Forms.GroupBox()
        Me.lblAssessmentreport = New System.Windows.Forms.Label()
        Me.btnFinaliseDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewEditDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveDevHistComment = New DevExpress.XtraEditors.SimpleButton()
        Me.tpgStatutory = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayStatutory = New DevExpress.XtraEditors.PanelControl()
        Me.txtOther79Cissues = New DevExpress.XtraEditors.MemoEdit()
        Me.btnSave79 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit79 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.picSubDivision = New System.Windows.Forms.PictureBox()
        Me.picSustain = New System.Windows.Forms.PictureBox()
        Me.picLandscape = New System.Windows.Forms.PictureBox()
        Me.picHeritage = New System.Windows.Forms.PictureBox()
        Me.picDDA = New System.Windows.Forms.PictureBox()
        Me.btnSubdivision = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSustainability = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLandscaping = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHeritage = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDisabDiscrimAct = New DevExpress.XtraEditors.SimpleButton()
        Me.picSocial = New System.Windows.Forms.PictureBox()
        Me.picTraffic = New System.Windows.Forms.PictureBox()
        Me.picThreaten = New System.Windows.Forms.PictureBox()
        Me.picDP = New System.Windows.Forms.PictureBox()
        Me.picGenImpacts = New System.Windows.Forms.PictureBox()
        Me.btnSocialEconomic = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTraficCarParks = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThreatenSpecies = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDepositedPlan = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGenImpacts = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.picDCPchkList = New System.Windows.Forms.PictureBox()
        Me.picDAMS = New System.Windows.Forms.PictureBox()
        Me.picDCP = New System.Windows.Forms.PictureBox()
        Me.picGUIDES = New System.Windows.Forms.PictureBox()
        Me.picSEPP = New System.Windows.Forms.PictureBox()
        Me.picLEP = New System.Windows.Forms.PictureBox()
        Me.picREP = New System.Windows.Forms.PictureBox()
        Me.btnDams = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDCPCheckList = New DevExpress.XtraEditors.SimpleButton()
        Me.btnREP = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDCP = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuidLines = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSepp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLEP = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tpgVariations = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayVariations = New DevExpress.XtraEditors.PanelControl()
        Me.btnRemoveVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.grdVariations = New DevExpress.XtraGrid.GridControl()
        Me.gvwVariations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colVariationResultDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelegatedAuthority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDecisionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssReasons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colUserStamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResultCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.variationDecisionDate = New DevExpress.XtraEditors.DateEdit()
        Me.cboVariationResult = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVariationAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSaveVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.btneditVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.grpVariations = New System.Windows.Forms.GroupBox()
        Me.txtOfficersReasons = New DevExpress.XtraEditors.MemoEdit()
        Me.txtVariationDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnAddVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditVariation = New DevExpress.XtraEditors.SimpleButton()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.cboOfficerRecomforVariation = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVariationType = New DevExpress.XtraEditors.LookUpEdit()
        Me.tpgContributions = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayContributions = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox4 = New DevExpress.XtraEditors.GroupControl()
        Me.txt64Amount = New DevExpress.XtraEditors.TextEdit()
        Me.cboS64Type = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnInsertNewSection64 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt64Note = New DevExpress.XtraEditors.TextEdit()
        Me.cboContribType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSection64Type = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grdProposedBondContrib = New DevExpress.XtraGrid.GridControl()
        Me.gvwProposedBondContrib = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemoveBond = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grdSection94 = New DevExpress.XtraGrid.GridControl()
        Me.gvwSection94 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemove94 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grdSection64Contributions = New DevExpress.XtraGrid.GridControl()
        Me.gvwSection64Contributions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colS94ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94Plan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94ContCalc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94CalcNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemove64 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tpgModifications = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayModifications = New DevExpress.XtraEditors.PanelControl()
        Me.grpMod = New DevExpress.XtraEditors.GroupControl()
        Me.scrolModification = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.pnlMod1 = New DevExpress.XtraEditors.PanelControl()
        Me.ModSect94CommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.ModSect79cCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ModSect94YNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.Modsect79cYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.pnlMod1A = New DevExpress.XtraEditors.PanelControl()
        Me.ModMinEnvImpCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.ModMinEnvImpactYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModSect96 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModDetailsTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.ModReasonTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.pnlMod1andMod2 = New DevExpress.XtraEditors.PanelControl()
        Me.ModSubStSameCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.ModSubmConsYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModNotificationYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModSubstSameYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.pnlMod2 = New DevExpress.XtraEditors.PanelControl()
        Me.ModThreatCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.ModThreatComplYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModThreatSpecYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModMinisterOBjYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModConsMinisterYNComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.ModMinisterCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.btnUpdateModData = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpdateModDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.lblModeType = New System.Windows.Forms.Label()
        Me.tpgConclusion = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayConclusions = New DevExpress.XtraEditors.PanelControl()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.scrolMainConclusion = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.pnlConclusion = New DevExpress.XtraEditors.PanelControl()
        Me.dteConclusionDate = New DevExpress.XtraEditors.DateEdit()
        Me.dgvConditionText = New DevExpress.XtraGrid.GridControl()
        Me.gvwOneUpConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUniqueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConditionCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConditionText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.dgvConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwSTDConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.costdlId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdCondition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreeFormInserts = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdConclusionVariations = New DevExpress.XtraGrid.GridControl()
        Me.gvwConclusionVariations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtApplicationConclreasons = New DevExpress.XtraEditors.MemoEdit()
        Me.ComplianceStatProvCommentsTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.txtVariationComment = New DevExpress.XtraEditors.MemoEdit()
        Me.btnViewConclusion = New DevExpress.XtraEditors.SimpleButton()
        Me.cboAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnViewComplainceReason = New DevExpress.XtraEditors.SimpleButton()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.cboReferralsYesNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboAssessmentDecision = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboComplianceStatProvYesNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.cboVariationsYesNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboApplicationConclResult = New DevExpress.XtraEditors.LookUpEdit()
        Me.pnlLabel = New DevExpress.XtraEditors.PanelControl()
        Me.btnUpdateConclusion = New DevExpress.XtraEditors.SimpleButton()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.pnlModificationConclusion = New DevExpress.XtraEditors.PanelControl()
        Me.dteProposedDetermDate = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvOneOffConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwOneOffConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemoveCondition = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvStandConditions = New DevExpress.XtraGrid.GridControl()
        Me.gvwStandConditions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApplicationConclreasonsTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.btnViewReco = New DevExpress.XtraEditors.SimpleButton()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.cboModAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModAssessmentDecision = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModSec79Satisfactory = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModSec96Comply = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblRecommendTwo = New System.Windows.Forms.Label()
        Me.lblRecommendation = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tpgPlans = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnFinalisePlan = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
        Me.PdfFileSaveAsBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
        Me.PdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
        Me.PdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
        Me.PdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
        Me.PdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
        Me.PdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
        Me.PdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
        Me.PdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
        Me.PdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
        Me.PdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
        Me.PdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
        Me.PdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
        Me.PdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
        Me.PdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
        Me.PdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
        Me.PdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
        Me.PdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
        Me.PdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
        Me.PdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
        Me.PdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
        Me.PdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
        Me.PdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
        Me.PdfExportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
        Me.PdfImportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.PdfFileOpenBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
        Me.PdfFileSaveAsBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
        Me.PdfFilePrintBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
        Me.PdfPreviousPageBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
        Me.PdfNextPageBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
        Me.PdfZoomOutBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
        Me.PdfZoomInBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
        Me.PdfExactZoomListBarSubItem2 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
        Me.PdfZoom10CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
        Me.PdfZoom25CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
        Me.PdfZoom50CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
        Me.PdfZoom75CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
        Me.PdfZoom100CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
        Me.PdfZoom125CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
        Me.PdfZoom150CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
        Me.PdfZoom200CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
        Me.PdfZoom400CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
        Me.PdfZoom500CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
        Me.PdfSetActualSizeZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
        Me.PdfSetPageLevelZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
        Me.PdfSetFitWidthZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
        Me.PdfSetFitVisibleZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
        Me.PdfExportFormDataBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
        Me.PdfImportFormDataBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
        Me.PdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
        Me.PdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
        Me.PdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
        Me.btnSavePlan = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdPlans = New DevExpress.XtraGrid.GridControl()
        Me.gvwPlans = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPlanName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInEASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFindPlan = New DevExpress.XtraEditors.SimpleButton()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Label20 = New System.Windows.Forms.Label()
        DevHistoryCommentLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        ActedOnLabel = New System.Windows.Forms.Label()
        Label95 = New System.Windows.Forms.Label()
        AssessmentDecisionLabel = New System.Windows.Forms.Label()
        Label128 = New System.Windows.Forms.Label()
        VariationsYesNoLabel = New System.Windows.Forms.Label()
        Label83 = New System.Windows.Forms.Label()
        Label81 = New System.Windows.Forms.Label()
        ComplianceStatProvYesNoLabel = New System.Windows.Forms.Label()
        ReferralsYesNoLabel = New System.Windows.Forms.Label()
        ComplianceStatProvCommentsLabel = New System.Windows.Forms.Label()
        ModSect94CommentLabel = New System.Windows.Forms.Label()
        ModSect94YNLabel = New System.Windows.Forms.Label()
        ModSect79cCommentLabel = New System.Windows.Forms.Label()
        Modsect79cYNLabel = New System.Windows.Forms.Label()
        ModMinEnvImpCommentLabel = New System.Windows.Forms.Label()
        ModMinEnvImpactYNLabel = New System.Windows.Forms.Label()
        ModSect96Label = New System.Windows.Forms.Label()
        ModThreatCommentLabel = New System.Windows.Forms.Label()
        ModThreatComplYNLabel = New System.Windows.Forms.Label()
        ModThreatSpecYNLabel = New System.Windows.Forms.Label()
        ModMinisterCommentLabel = New System.Windows.Forms.Label()
        ModMinisterOBjYNLabel = New System.Windows.Forms.Label()
        ModConsMinisterYNLabel = New System.Windows.Forms.Label()
        ModSubmConsYNLabel = New System.Windows.Forms.Label()
        ModNotificationYNLabel = New System.Windows.Forms.Label()
        ModSubStSameCommentLabel = New System.Windows.Forms.Label()
        ModSubstSameYNLabel = New System.Windows.Forms.Label()
        ModReasonLabel = New System.Windows.Forms.Label()
        ModDetailsLabel = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemMemoEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.tabAssessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAssessment.SuspendLayout()
        Me.tpgHistory.SuspendLayout()
        CType(Me.pnlDisplayHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayHistory.SuspendLayout()
        CType(Me.grpHistoricalDA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHistoricalDA.SuspendLayout()
        CType(Me.grdHistoricalDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwHistoricalDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHisDa.SuspendLayout()
        CType(Me.cboActedOn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevHistoryCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbxAssessmentRept.SuspendLayout()
        Me.tpgStatutory.SuspendLayout()
        CType(Me.pnlDisplayStatutory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayStatutory.SuspendLayout()
        CType(Me.txtOther79Cissues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picSubDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSustain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLandscape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeritage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTraffic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThreaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGenImpacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.picDCPchkList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDAMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGUIDES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSEPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picREP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgVariations.SuspendLayout()
        CType(Me.pnlDisplayVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayVariations.SuspendLayout()
        CType(Me.grdVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.variationDecisionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.variationDecisionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVariationResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVariationAuthority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVariations.SuspendLayout()
        CType(Me.txtOfficersReasons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariationDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOfficerRecomforVariation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVariationType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgContributions.SuspendLayout()
        CType(Me.pnlDisplayContributions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayContributions.SuspendLayout()
        CType(Me.GroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txt64Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboS64Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt64Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContribType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSection64Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grdProposedBondContrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwProposedBondContrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grdSection94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSection94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdSection64Contributions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSection64Contributions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgModifications.SuspendLayout()
        CType(Me.pnlDisplayModifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayModifications.SuspendLayout()
        CType(Me.grpMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMod.SuspendLayout()
        Me.scrolModification.SuspendLayout()
        CType(Me.pnlMod1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMod1.SuspendLayout()
        CType(Me.ModSect94CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModSect79cCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModSect94YNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modsect79cYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMod1A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMod1A.SuspendLayout()
        CType(Me.ModMinEnvImpCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModMinEnvImpactYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSect96.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModDetailsTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModReasonTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMod1andMod2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMod1andMod2.SuspendLayout()
        CType(Me.ModSubStSameCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModSubmConsYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModNotificationYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModSubstSameYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMod2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMod2.SuspendLayout()
        CType(Me.ModThreatCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModThreatComplYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModThreatSpecYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModMinisterOBjYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModConsMinisterYNComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModMinisterCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgConclusion.SuspendLayout()
        CType(Me.pnlDisplayConclusions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayConclusions.SuspendLayout()
        Me.scrolMainConclusion.SuspendLayout()
        CType(Me.pnlConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConclusion.SuspendLayout()
        CType(Me.dteConclusionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteConclusionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConditionText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOneUpConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSTDConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdConclusionVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwConclusionVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApplicationConclreasons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplianceStatProvCommentsTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariationComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAuthority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboReferralsYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboComplianceStatProvYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVariationsYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboApplicationConclResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabel.SuspendLayout()
        CType(Me.pnlModificationConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModificationConclusion.SuspendLayout()
        CType(Me.dteProposedDetermDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteProposedDetermDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.dgvOneOffConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOneOffConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.dgvStandConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwStandConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationConclreasonsTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModAuthority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSec79Satisfactory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSec96Comply.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgPlans.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdPlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(13, 402)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(97, 13)
        Label20.TabIndex = 115
        Label20.Text = "Other 79(c) Issues"
        '
        'DevHistoryCommentLabel
        '
        DevHistoryCommentLabel.AutoSize = True
        DevHistoryCommentLabel.Location = New System.Drawing.Point(6, 442)
        DevHistoryCommentLabel.Name = "DevHistoryCommentLabel"
        DevHistoryCommentLabel.Size = New System.Drawing.Size(115, 13)
        DevHistoryCommentLabel.TabIndex = 11
        DevHistoryCommentLabel.Text = "Dev History Comment:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(325, 22)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(56, 13)
        CommentLabel.TabIndex = 3
        CommentLabel.Text = "Comment:"
        '
        'ActedOnLabel
        '
        ActedOnLabel.AutoSize = True
        ActedOnLabel.Location = New System.Drawing.Point(127, 22)
        ActedOnLabel.Name = "ActedOnLabel"
        ActedOnLabel.Size = New System.Drawing.Size(56, 13)
        ActedOnLabel.TabIndex = 1
        ActedOnLabel.Text = "Acted On:"
        '
        'Label95
        '
        Label95.AutoSize = True
        Label95.Location = New System.Drawing.Point(13, 633)
        Label95.Name = "Label95"
        Label95.Size = New System.Drawing.Size(551, 13)
        Label95.TabIndex = 89
        Label95.Text = "of the Environmental Planning and Assessment Act conditions and including the fol" &
    "lowing advices to the applicant:"
        '
        'AssessmentDecisionLabel
        '
        AssessmentDecisionLabel.AutoSize = True
        AssessmentDecisionLabel.Location = New System.Drawing.Point(12, 610)
        AssessmentDecisionLabel.Name = "AssessmentDecisionLabel"
        AssessmentDecisionLabel.Size = New System.Drawing.Size(99, 13)
        AssessmentDecisionLabel.TabIndex = 89
        AssessmentDecisionLabel.Text = "This application be:"
        '
        'Label128
        '
        Label128.AutoSize = True
        Label128.Location = New System.Drawing.Point(5, 147)
        Label128.Name = "Label128"
        Label128.Size = New System.Drawing.Size(345, 13)
        Label128.TabIndex = 16
        Label128.Text = "The following variation determinations be made for the reasons listed: "
        '
        'VariationsYesNoLabel
        '
        VariationsYesNoLabel.AutoSize = True
        VariationsYesNoLabel.Location = New System.Drawing.Point(116, 55)
        VariationsYesNoLabel.Name = "VariationsYesNoLabel"
        VariationsYesNoLabel.Size = New System.Drawing.Size(412, 13)
        VariationsYesNoLabel.TabIndex = 16
        VariationsYesNoLabel.Text = "- Does the proposal seek or require variation to SEPP1, Council Codes, EPI or pol" &
    "icy?"
        '
        'Label83
        '
        Label83.AutoSize = True
        Label83.Location = New System.Drawing.Point(424, 403)
        Label83.Name = "Label83"
        Label83.Size = New System.Drawing.Size(130, 13)
        Label83.TabIndex = 87
        Label83.Text = "for the following reasons:"
        '
        'Label81
        '
        Label81.AutoSize = True
        Label81.Location = New System.Drawing.Point(109, 403)
        Label81.Name = "Label81"
        Label81.Size = New System.Drawing.Size(173, 13)
        Label81.TabIndex = 87
        Label81.Text = "This application is considered to be"
        '
        'ComplianceStatProvYesNoLabel
        '
        ComplianceStatProvYesNoLabel.AutoSize = True
        ComplianceStatProvYesNoLabel.Location = New System.Drawing.Point(754, 12)
        ComplianceStatProvYesNoLabel.Name = "ComplianceStatProvYesNoLabel"
        ComplianceStatProvYesNoLabel.Size = New System.Drawing.Size(434, 13)
        ComplianceStatProvYesNoLabel.TabIndex = 15
        ComplianceStatProvYesNoLabel.Text = "- Does proposal comply with statutory and non-statutory provisions applying to th" &
    "e land?"
        '
        'ReferralsYesNoLabel
        '
        ReferralsYesNoLabel.AutoSize = True
        ReferralsYesNoLabel.Location = New System.Drawing.Point(114, 12)
        ReferralsYesNoLabel.Name = "ReferralsYesNoLabel"
        ReferralsYesNoLabel.Size = New System.Drawing.Size(225, 13)
        ReferralsYesNoLabel.TabIndex = 14
        ReferralsYesNoLabel.Text = "Were referrals necessary for this application?"
        '
        'ComplianceStatProvCommentsLabel
        '
        ComplianceStatProvCommentsLabel.AutoSize = True
        ComplianceStatProvCommentsLabel.Location = New System.Drawing.Point(6, 92)
        ComplianceStatProvCommentsLabel.Name = "ComplianceStatProvCommentsLabel"
        ComplianceStatProvCommentsLabel.Size = New System.Drawing.Size(61, 13)
        ComplianceStatProvCommentsLabel.TabIndex = 8
        ComplianceStatProvCommentsLabel.Text = "Comments:"
        '
        'ModSect94CommentLabel
        '
        ModSect94CommentLabel.AutoSize = True
        ModSect94CommentLabel.Location = New System.Drawing.Point(10, 139)
        ModSect94CommentLabel.Name = "ModSect94CommentLabel"
        ModSect94CommentLabel.Size = New System.Drawing.Size(56, 13)
        ModSect94CommentLabel.TabIndex = 6
        ModSect94CommentLabel.Text = "Comment:"
        '
        'ModSect94YNLabel
        '
        ModSect94YNLabel.AutoSize = True
        ModSect94YNLabel.Location = New System.Drawing.Point(5, 114)
        ModSect94YNLabel.Name = "ModSect94YNLabel"
        ModSect94YNLabel.Size = New System.Drawing.Size(404, 13)
        ModSect94YNLabel.TabIndex = 4
        ModSect94YNLabel.Text = "Is the proposed modification satisfactory with regard to Section 94 consideration" &
    "s?"
        '
        'ModSect79cCommentLabel
        '
        ModSect79cCommentLabel.AutoSize = True
        ModSect79cCommentLabel.Location = New System.Drawing.Point(12, 63)
        ModSect79cCommentLabel.Name = "ModSect79cCommentLabel"
        ModSect79cCommentLabel.Size = New System.Drawing.Size(56, 13)
        ModSect79cCommentLabel.TabIndex = 2
        ModSect79cCommentLabel.Text = "Comment:"
        '
        'Modsect79cYNLabel
        '
        Modsect79cYNLabel.Location = New System.Drawing.Point(5, 24)
        Modsect79cYNLabel.Name = "Modsect79cYNLabel"
        Modsect79cYNLabel.Size = New System.Drawing.Size(516, 29)
        Modsect79cYNLabel.TabIndex = 0
        Modsect79cYNLabel.Text = "Is the proposed modification of consent satisfactory with regard to Section 79C (" &
    "1) including relevant planning instruments, development standards, Council Codes" &
    ", policies etc?"
        '
        'ModMinEnvImpCommentLabel
        '
        ModMinEnvImpCommentLabel.AutoSize = True
        ModMinEnvImpCommentLabel.Location = New System.Drawing.Point(10, 39)
        ModMinEnvImpCommentLabel.Name = "ModMinEnvImpCommentLabel"
        ModMinEnvImpCommentLabel.Size = New System.Drawing.Size(56, 13)
        ModMinEnvImpCommentLabel.TabIndex = 2
        ModMinEnvImpCommentLabel.Text = "Comment:"
        '
        'ModMinEnvImpactYNLabel
        '
        ModMinEnvImpactYNLabel.AutoSize = True
        ModMinEnvImpactYNLabel.Location = New System.Drawing.Point(8, 11)
        ModMinEnvImpactYNLabel.Name = "ModMinEnvImpactYNLabel"
        ModMinEnvImpactYNLabel.Size = New System.Drawing.Size(320, 13)
        ModMinEnvImpactYNLabel.TabIndex = 0
        ModMinEnvImpactYNLabel.Text = "(d) Is the proposed modification of minimal environmental impact?"
        '
        'ModSect96Label
        '
        ModSect96Label.AutoSize = True
        ModSect96Label.Location = New System.Drawing.Point(8, 114)
        ModSect96Label.Name = "ModSect96Label"
        ModSect96Label.Size = New System.Drawing.Size(193, 13)
        ModSect96Label.TabIndex = 4
        ModSect96Label.Text = "The application is subject to Section 96"
        '
        'ModThreatCommentLabel
        '
        ModThreatCommentLabel.AutoSize = True
        ModThreatCommentLabel.Location = New System.Drawing.Point(11, 197)
        ModThreatCommentLabel.Name = "ModThreatCommentLabel"
        ModThreatCommentLabel.Size = New System.Drawing.Size(56, 13)
        ModThreatCommentLabel.TabIndex = 10
        ModThreatCommentLabel.Text = "Comment:"
        '
        'ModThreatComplYNLabel
        '
        ModThreatComplYNLabel.Location = New System.Drawing.Point(7, 162)
        ModThreatComplYNLabel.Name = "ModThreatComplYNLabel"
        ModThreatComplYNLabel.Size = New System.Drawing.Size(510, 27)
        ModThreatComplYNLabel.TabIndex = 8
        ModThreatComplYNLabel.Text = "Is so, has section 79B (3)-(7) been complied with in relation to the proposed mod" &
    "ification as if the proposed modification were an application for development co" &
    "nsent?"
        '
        'ModThreatSpecYNLabel
        '
        ModThreatSpecYNLabel.AutoSize = True
        ModThreatSpecYNLabel.Location = New System.Drawing.Point(7, 129)
        ModThreatSpecYNLabel.Name = "ModThreatSpecYNLabel"
        ModThreatSpecYNLabel.Size = New System.Drawing.Size(357, 26)
        ModThreatSpecYNLabel.TabIndex = 6
        ModThreatSpecYNLabel.Text = "SUBSECTION (5) - Threatened Species" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Is the Development consent of the kind refer" &
    "red to in 79B (3) of the Act?"
        '
        'ModMinisterCommentLabel
        '
        ModMinisterCommentLabel.AutoSize = True
        ModMinisterCommentLabel.Location = New System.Drawing.Point(16, 79)
        ModMinisterCommentLabel.Name = "ModMinisterCommentLabel"
        ModMinisterCommentLabel.Size = New System.Drawing.Size(56, 13)
        ModMinisterCommentLabel.TabIndex = 4
        ModMinisterCommentLabel.Text = "Comment:"
        '
        'ModMinisterOBjYNLabel
        '
        ModMinisterOBjYNLabel.AutoSize = True
        ModMinisterOBjYNLabel.Location = New System.Drawing.Point(8, 56)
        ModMinisterOBjYNLabel.Name = "ModMinisterOBjYNLabel"
        ModMinisterOBjYNLabel.Size = New System.Drawing.Size(378, 13)
        ModMinisterOBjYNLabel.TabIndex = 2
        ModMinisterOBjYNLabel.Text = "(e) Have all submissions been considered? See submission tab from comments"
        '
        'ModConsMinisterYNLabel
        '
        ModConsMinisterYNLabel.Location = New System.Drawing.Point(8, 8)
        ModConsMinisterYNLabel.Name = "ModConsMinisterYNLabel"
        ModConsMinisterYNLabel.Size = New System.Drawing.Size(502, 48)
        ModConsMinisterYNLabel.TabIndex = 0
        ModConsMinisterYNLabel.Text = resources.GetString("ModConsMinisterYNLabel.Text")
        '
        'ModSubmConsYNLabel
        '
        ModSubmConsYNLabel.AutoSize = True
        ModSubmConsYNLabel.Location = New System.Drawing.Point(8, 159)
        ModSubmConsYNLabel.Name = "ModSubmConsYNLabel"
        ModSubmConsYNLabel.Size = New System.Drawing.Size(377, 13)
        ModSubmConsYNLabel.TabIndex = 6
        ModSubmConsYNLabel.Text = "(c) Have all submissions been considered? See submission tab from comments"
        '
        'ModNotificationYNLabel
        '
        ModNotificationYNLabel.Location = New System.Drawing.Point(8, 93)
        ModNotificationYNLabel.Name = "ModNotificationYNLabel"
        ModNotificationYNLabel.Size = New System.Drawing.Size(514, 58)
        ModNotificationYNLabel.TabIndex = 4
        ModNotificationYNLabel.Text = resources.GetString("ModNotificationYNLabel.Text")
        '
        'ModSubStSameCommentLabel
        '
        ModSubStSameCommentLabel.AutoSize = True
        ModSubStSameCommentLabel.Location = New System.Drawing.Point(13, 50)
        ModSubStSameCommentLabel.Name = "ModSubStSameCommentLabel"
        ModSubStSameCommentLabel.Size = New System.Drawing.Size(56, 13)
        ModSubStSameCommentLabel.TabIndex = 2
        ModSubStSameCommentLabel.Text = "Comment:"
        '
        'ModSubstSameYNLabel
        '
        ModSubstSameYNLabel.Location = New System.Drawing.Point(8, 2)
        ModSubstSameYNLabel.Name = "ModSubstSameYNLabel"
        ModSubstSameYNLabel.Size = New System.Drawing.Size(514, 43)
        ModSubstSameYNLabel.TabIndex = 0
        ModSubstSameYNLabel.Text = resources.GetString("ModSubstSameYNLabel.Text")
        '
        'ModReasonLabel
        '
        ModReasonLabel.AutoSize = True
        ModReasonLabel.Location = New System.Drawing.Point(8, 52)
        ModReasonLabel.Name = "ModReasonLabel"
        ModReasonLabel.Size = New System.Drawing.Size(200, 13)
        ModReasonLabel.TabIndex = 2
        ModReasonLabel.Text = "Reasons why modification being sought:"
        '
        'ModDetailsLabel
        '
        ModDetailsLabel.AutoSize = True
        ModDetailsLabel.Location = New System.Drawing.Point(8, 4)
        ModDetailsLabel.Name = "ModDetailsLabel"
        ModDetailsLabel.Size = New System.Drawing.Size(152, 13)
        ModDetailsLabel.TabIndex = 0
        ModDetailsLabel.Text = "Details of modification sought:"
        '
        'RepositoryItemMemoEdit8
        '
        Me.RepositoryItemMemoEdit8.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit8.Name = "RepositoryItemMemoEdit8"
        '
        'RepositoryItemMemoEdit9
        '
        Me.RepositoryItemMemoEdit9.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit9.Name = "RepositoryItemMemoEdit9"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLockAssessment)
        Me.PanelControl1.Controls.Add(Me.btnPrintAssessment)
        Me.PanelControl1.Controls.Add(Me.lblDetermineDate)
        Me.PanelControl1.Controls.Add(Me.Label13)
        Me.PanelControl1.Controls.Add(Me.lblapplicationNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1395, 47)
        Me.PanelControl1.TabIndex = 0
        '
        'btnLockAssessment
        '
        Me.btnLockAssessment.Image = CType(resources.GetObject("btnLockAssessment.Image"), System.Drawing.Image)
        Me.btnLockAssessment.Location = New System.Drawing.Point(1252, 3)
        Me.btnLockAssessment.Name = "btnLockAssessment"
        Me.btnLockAssessment.Size = New System.Drawing.Size(131, 41)
        Me.btnLockAssessment.TabIndex = 45
        Me.btnLockAssessment.Text = "Lock Assessment"
        '
        'btnPrintAssessment
        '
        Me.btnPrintAssessment.Image = CType(resources.GetObject("btnPrintAssessment.Image"), System.Drawing.Image)
        Me.btnPrintAssessment.Location = New System.Drawing.Point(962, 3)
        Me.btnPrintAssessment.Name = "btnPrintAssessment"
        Me.btnPrintAssessment.Size = New System.Drawing.Size(131, 41)
        Me.btnPrintAssessment.TabIndex = 44
        Me.btnPrintAssessment.Text = "Print Assessment"
        '
        'lblDetermineDate
        '
        Me.lblDetermineDate.Location = New System.Drawing.Point(267, 11)
        Me.lblDetermineDate.Name = "lblDetermineDate"
        Me.lblDetermineDate.Size = New System.Drawing.Size(100, 22)
        Me.lblDetermineDate.TabIndex = 43
        Me.lblDetermineDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 21)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "DA Number"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblapplicationNo
        '
        Me.lblapplicationNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapplicationNo.Location = New System.Drawing.Point(131, 9)
        Me.lblapplicationNo.Name = "lblapplicationNo"
        Me.lblapplicationNo.Size = New System.Drawing.Size(176, 22)
        Me.lblapplicationNo.TabIndex = 41
        Me.lblapplicationNo.Text = "673/07"
        Me.lblapplicationNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabAssessment
        '
        Me.tabAssessment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAssessment.Location = New System.Drawing.Point(0, 47)
        Me.tabAssessment.Name = "tabAssessment"
        Me.tabAssessment.SelectedTabPage = Me.tpgHistory
        Me.tabAssessment.Size = New System.Drawing.Size(1395, 808)
        Me.tabAssessment.TabIndex = 1
        Me.tabAssessment.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpgHistory, Me.tpgStatutory, Me.tpgVariations, Me.tpgContributions, Me.tpgModifications, Me.tpgConclusion, Me.tpgPlans})
        '
        'tpgHistory
        '
        Me.tpgHistory.Controls.Add(Me.pnlDisplayHistory)
        Me.tpgHistory.Image = CType(resources.GetObject("tpgHistory.Image"), System.Drawing.Image)
        Me.tpgHistory.Name = "tpgHistory"
        Me.tpgHistory.Size = New System.Drawing.Size(1389, 761)
        Me.tpgHistory.Text = "History"
        '
        'pnlDisplayHistory
        '
        Me.pnlDisplayHistory.Controls.Add(Me.grpHistoricalDA)
        Me.pnlDisplayHistory.Controls.Add(Me.DevHistoryCommentTextBox)
        Me.pnlDisplayHistory.Controls.Add(Me.Panel1)
        Me.pnlDisplayHistory.Controls.Add(Me.gbxAssessmentRept)
        Me.pnlDisplayHistory.Controls.Add(Me.btnSaveDevHistComment)
        Me.pnlDisplayHistory.Controls.Add(DevHistoryCommentLabel)
        Me.pnlDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayHistory.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayHistory.Name = "pnlDisplayHistory"
        Me.pnlDisplayHistory.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayHistory.TabIndex = 4
        '
        'grpHistoricalDA
        '
        Me.grpHistoricalDA.Controls.Add(Me.grdHistoricalDA)
        Me.grpHistoricalDA.Controls.Add(Me.btnRetrievePreviousDAHistory)
        Me.grpHistoricalDA.Controls.Add(Me.grpHisDa)
        Me.grpHistoricalDA.Location = New System.Drawing.Point(9, 5)
        Me.grpHistoricalDA.Name = "grpHistoricalDA"
        Me.grpHistoricalDA.Size = New System.Drawing.Size(1276, 434)
        Me.grpHistoricalDA.TabIndex = 29
        Me.grpHistoricalDA.Text = "Historical DA's"
        '
        'grdHistoricalDA
        '
        Me.grdHistoricalDA.Location = New System.Drawing.Point(20, 31)
        Me.grdHistoricalDA.MainView = Me.gvwHistoricalDA
        Me.grdHistoricalDA.Name = "grdHistoricalDA"
        Me.grdHistoricalDA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit5, Me.RepositoryItemMemoEdit6})
        Me.grdHistoricalDA.Size = New System.Drawing.Size(1083, 316)
        Me.grdHistoricalDA.TabIndex = 28
        Me.grdHistoricalDA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwHistoricalDA})
        '
        'gvwHistoricalDA
        '
        Me.gvwHistoricalDA.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvwHistoricalDA.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwHistoricalDA.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwHistoricalDA.Appearance.Row.Options.UseTextOptions = True
        Me.gvwHistoricalDA.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwHistoricalDA.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwHistoricalDA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrevDANo, Me.colProposal, Me.colDecision, Me.col_DecisionDate, Me.colActedOn, Me.colComment})
        Me.gvwHistoricalDA.GridControl = Me.grdHistoricalDA
        Me.gvwHistoricalDA.Name = "gvwHistoricalDA"
        Me.gvwHistoricalDA.OptionsBehavior.ReadOnly = True
        Me.gvwHistoricalDA.OptionsView.ShowGroupPanel = False
        Me.gvwHistoricalDA.RowHeight = 40
        '
        'colPrevDANo
        '
        Me.colPrevDANo.Caption = "Previous#"
        Me.colPrevDANo.FieldName = "PrevDANo"
        Me.colPrevDANo.Name = "colPrevDANo"
        Me.colPrevDANo.OptionsColumn.AllowEdit = False
        Me.colPrevDANo.OptionsColumn.ReadOnly = True
        Me.colPrevDANo.Visible = True
        Me.colPrevDANo.VisibleIndex = 0
        Me.colPrevDANo.Width = 65
        '
        'colProposal
        '
        Me.colProposal.Caption = "Proposal"
        Me.colProposal.ColumnEdit = Me.RepositoryItemMemoEdit5
        Me.colProposal.FieldName = "Proposal"
        Me.colProposal.Name = "colProposal"
        Me.colProposal.OptionsColumn.ReadOnly = True
        Me.colProposal.Visible = True
        Me.colProposal.VisibleIndex = 1
        Me.colProposal.Width = 267
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        '
        'colDecision
        '
        Me.colDecision.Caption = "Decision"
        Me.colDecision.FieldName = "Decision"
        Me.colDecision.Name = "colDecision"
        Me.colDecision.OptionsColumn.AllowEdit = False
        Me.colDecision.OptionsColumn.ReadOnly = True
        Me.colDecision.Visible = True
        Me.colDecision.VisibleIndex = 2
        Me.colDecision.Width = 174
        '
        'col_DecisionDate
        '
        Me.col_DecisionDate.Caption = "Date"
        Me.col_DecisionDate.FieldName = "DecisionDate"
        Me.col_DecisionDate.Name = "col_DecisionDate"
        Me.col_DecisionDate.OptionsColumn.AllowEdit = False
        Me.col_DecisionDate.OptionsColumn.ReadOnly = True
        Me.col_DecisionDate.Visible = True
        Me.col_DecisionDate.VisibleIndex = 3
        Me.col_DecisionDate.Width = 91
        '
        'colActedOn
        '
        Me.colActedOn.Caption = "Enacted"
        Me.colActedOn.FieldName = "ActedOn"
        Me.colActedOn.Name = "colActedOn"
        Me.colActedOn.OptionsColumn.AllowEdit = False
        Me.colActedOn.OptionsColumn.ReadOnly = True
        Me.colActedOn.Visible = True
        Me.colActedOn.VisibleIndex = 4
        Me.colActedOn.Width = 57
        '
        'colComment
        '
        Me.colComment.Caption = "Comment"
        Me.colComment.ColumnEdit = Me.RepositoryItemMemoEdit6
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.OptionsColumn.ReadOnly = True
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 5
        Me.colComment.Width = 476
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'btnRetrievePreviousDAHistory
        '
        Me.btnRetrievePreviousDAHistory.Location = New System.Drawing.Point(1117, 31)
        Me.btnRetrievePreviousDAHistory.Name = "btnRetrievePreviousDAHistory"
        Me.btnRetrievePreviousDAHistory.Size = New System.Drawing.Size(147, 48)
        Me.btnRetrievePreviousDAHistory.TabIndex = 10
        Me.btnRetrievePreviousDAHistory.Text = "Retrieve Previous DA's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (since 1/7/98)"
        '
        'grpHisDa
        '
        Me.grpHisDa.Controls.Add(Me.btnViewDa)
        Me.grpHisDa.Controls.Add(Me.btnUpDateHistory)
        Me.grpHisDa.Controls.Add(CommentLabel)
        Me.grpHisDa.Controls.Add(ActedOnLabel)
        Me.grpHisDa.Controls.Add(Me.cboActedOn)
        Me.grpHisDa.Controls.Add(Me.lblDAno)
        Me.grpHisDa.Controls.Add(Me.CommentTextBox)
        Me.grpHisDa.Location = New System.Drawing.Point(20, 351)
        Me.grpHisDa.Name = "grpHisDa"
        Me.grpHisDa.Size = New System.Drawing.Size(1083, 75)
        Me.grpHisDa.TabIndex = 9
        Me.grpHisDa.TabStop = False
        '
        'btnViewDa
        '
        Me.btnViewDa.Enabled = False
        Me.btnViewDa.Location = New System.Drawing.Point(1002, 16)
        Me.btnViewDa.Name = "btnViewDa"
        Me.btnViewDa.Size = New System.Drawing.Size(75, 23)
        Me.btnViewDa.TabIndex = 6
        Me.btnViewDa.Text = "View DA"
        Me.btnViewDa.Visible = False
        '
        'btnUpDateHistory
        '
        Me.btnUpDateHistory.Enabled = False
        Me.btnUpDateHistory.Location = New System.Drawing.Point(1002, 45)
        Me.btnUpDateHistory.Name = "btnUpDateHistory"
        Me.btnUpDateHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnUpDateHistory.TabIndex = 5
        Me.btnUpDateHistory.Text = "Update"
        '
        'cboActedOn
        '
        Me.cboActedOn.Location = New System.Drawing.Point(188, 19)
        Me.cboActedOn.Name = "cboActedOn"
        Me.cboActedOn.Properties.NullText = "[Select]"
        Me.cboActedOn.Properties.ShowFooter = False
        Me.cboActedOn.Properties.ShowHeader = False
        Me.cboActedOn.Size = New System.Drawing.Size(79, 20)
        Me.cboActedOn.TabIndex = 2
        '
        'lblDAno
        '
        Me.lblDAno.Location = New System.Drawing.Point(9, 16)
        Me.lblDAno.Name = "lblDAno"
        Me.lblDAno.Size = New System.Drawing.Size(100, 23)
        Me.lblDAno.TabIndex = 1
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Location = New System.Drawing.Point(385, 19)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(558, 49)
        Me.CommentTextBox.TabIndex = 4
        '
        'DevHistoryCommentTextBox
        '
        Me.DevHistoryCommentTextBox.Location = New System.Drawing.Point(9, 458)
        Me.DevHistoryCommentTextBox.Name = "DevHistoryCommentTextBox"
        Me.DevHistoryCommentTextBox.Size = New System.Drawing.Size(1083, 124)
        Me.DevHistoryCommentTextBox.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAssessmentReportEased)
        Me.Panel1.Location = New System.Drawing.Point(414, 601)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 55)
        Me.Panel1.TabIndex = 26
        '
        'lblAssessmentReportEased
        '
        Me.lblAssessmentReportEased.AutoSize = True
        Me.lblAssessmentReportEased.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssessmentReportEased.ForeColor = System.Drawing.Color.Red
        Me.lblAssessmentReportEased.Location = New System.Drawing.Point(16, 20)
        Me.lblAssessmentReportEased.Name = "lblAssessmentReportEased"
        Me.lblAssessmentReportEased.Size = New System.Drawing.Size(384, 16)
        Me.lblAssessmentReportEased.TabIndex = 25
        Me.lblAssessmentReportEased.Text = "ASSESSMENT REPORT HAS BEEN PLACED IN EASE"
        Me.lblAssessmentReportEased.Visible = False
        '
        'gbxAssessmentRept
        '
        Me.gbxAssessmentRept.Controls.Add(Me.lblAssessmentreport)
        Me.gbxAssessmentRept.Controls.Add(Me.btnFinaliseDoc)
        Me.gbxAssessmentRept.Controls.Add(Me.btnDeleteDoc)
        Me.gbxAssessmentRept.Controls.Add(Me.btnViewEditDocument)
        Me.gbxAssessmentRept.Location = New System.Drawing.Point(9, 601)
        Me.gbxAssessmentRept.Name = "gbxAssessmentRept"
        Me.gbxAssessmentRept.Size = New System.Drawing.Size(399, 110)
        Me.gbxAssessmentRept.TabIndex = 24
        Me.gbxAssessmentRept.TabStop = False
        Me.gbxAssessmentRept.Text = "Assessment Report"
        Me.gbxAssessmentRept.Visible = False
        '
        'lblAssessmentreport
        '
        Me.lblAssessmentreport.AutoSize = True
        Me.lblAssessmentreport.Location = New System.Drawing.Point(9, 93)
        Me.lblAssessmentreport.Name = "lblAssessmentreport"
        Me.lblAssessmentreport.Size = New System.Drawing.Size(0, 13)
        Me.lblAssessmentreport.TabIndex = 4
        Me.lblAssessmentreport.Visible = False
        '
        'btnFinaliseDoc
        '
        Me.btnFinaliseDoc.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btnFinaliseDoc.Appearance.Options.UseForeColor = True
        Me.btnFinaliseDoc.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Adobe_Acrobat_Reader
        Me.btnFinaliseDoc.Location = New System.Drawing.Point(260, 19)
        Me.btnFinaliseDoc.Name = "btnFinaliseDoc"
        Me.btnFinaliseDoc.Size = New System.Drawing.Size(119, 75)
        Me.btnFinaliseDoc.TabIndex = 3
        Me.btnFinaliseDoc.Text = "F I N A L I S E"
        '
        'btnDeleteDoc
        '
        Me.btnDeleteDoc.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteDoc.Appearance.Options.UseForeColor = True
        Me.btnDeleteDoc.Image = CType(resources.GetObject("btnDeleteDoc.Image"), System.Drawing.Image)
        Me.btnDeleteDoc.Location = New System.Drawing.Point(134, 19)
        Me.btnDeleteDoc.Name = "btnDeleteDoc"
        Me.btnDeleteDoc.Size = New System.Drawing.Size(119, 75)
        Me.btnDeleteDoc.TabIndex = 2
        Me.btnDeleteDoc.Text = "D E L E T E"
        '
        'btnViewEditDocument
        '
        Me.btnViewEditDocument.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.btnViewEditDocument.Appearance.Options.UseForeColor = True
        Me.btnViewEditDocument.Image = CType(resources.GetObject("btnViewEditDocument.Image"), System.Drawing.Image)
        Me.btnViewEditDocument.Location = New System.Drawing.Point(9, 19)
        Me.btnViewEditDocument.Name = "btnViewEditDocument"
        Me.btnViewEditDocument.Size = New System.Drawing.Size(119, 75)
        Me.btnViewEditDocument.TabIndex = 1
        Me.btnViewEditDocument.Text = "V I E W"
        '
        'btnSaveDevHistComment
        '
        Me.btnSaveDevHistComment.Image = CType(resources.GetObject("btnSaveDevHistComment.Image"), System.Drawing.Image)
        Me.btnSaveDevHistComment.Location = New System.Drawing.Point(1098, 459)
        Me.btnSaveDevHistComment.Name = "btnSaveDevHistComment"
        Me.btnSaveDevHistComment.Size = New System.Drawing.Size(139, 46)
        Me.btnSaveDevHistComment.TabIndex = 13
        Me.btnSaveDevHistComment.Text = "Save Comment"
        '
        'tpgStatutory
        '
        Me.tpgStatutory.Controls.Add(Me.pnlDisplayStatutory)
        Me.tpgStatutory.Image = CType(resources.GetObject("tpgStatutory.Image"), System.Drawing.Image)
        Me.tpgStatutory.Name = "tpgStatutory"
        Me.tpgStatutory.Size = New System.Drawing.Size(1389, 761)
        Me.tpgStatutory.Text = "Statutory"
        '
        'pnlDisplayStatutory
        '
        Me.pnlDisplayStatutory.Controls.Add(Me.txtOther79Cissues)
        Me.pnlDisplayStatutory.Controls.Add(Me.btnSave79)
        Me.pnlDisplayStatutory.Controls.Add(Me.btnEdit79)
        Me.pnlDisplayStatutory.Controls.Add(Label20)
        Me.pnlDisplayStatutory.Controls.Add(Me.GroupBox3)
        Me.pnlDisplayStatutory.Controls.Add(Me.GroupBox6)
        Me.pnlDisplayStatutory.Controls.Add(Me.Label5)
        Me.pnlDisplayStatutory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayStatutory.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayStatutory.Name = "pnlDisplayStatutory"
        Me.pnlDisplayStatutory.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayStatutory.TabIndex = 26
        '
        'txtOther79Cissues
        '
        Me.txtOther79Cissues.Location = New System.Drawing.Point(16, 418)
        Me.txtOther79Cissues.Name = "txtOther79Cissues"
        Me.txtOther79Cissues.Size = New System.Drawing.Size(1083, 158)
        Me.txtOther79Cissues.TabIndex = 118
        '
        'btnSave79
        '
        Me.btnSave79.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave79.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave79.Appearance.Options.UseFont = True
        Me.btnSave79.Appearance.Options.UseForeColor = True
        Me.btnSave79.Enabled = False
        Me.btnSave79.Image = CType(resources.GetObject("btnSave79.Image"), System.Drawing.Image)
        Me.btnSave79.Location = New System.Drawing.Point(604, 599)
        Me.btnSave79.Name = "btnSave79"
        Me.btnSave79.Size = New System.Drawing.Size(160, 43)
        Me.btnSave79.TabIndex = 117
        Me.btnSave79.Tag = "v"
        Me.btnSave79.Text = "Save Other 79(c)"
        '
        'btnEdit79
        '
        Me.btnEdit79.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit79.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit79.Appearance.Options.UseFont = True
        Me.btnEdit79.Appearance.Options.UseForeColor = True
        Me.btnEdit79.Image = CType(resources.GetObject("btnEdit79.Image"), System.Drawing.Image)
        Me.btnEdit79.Location = New System.Drawing.Point(438, 599)
        Me.btnEdit79.Name = "btnEdit79"
        Me.btnEdit79.Size = New System.Drawing.Size(160, 43)
        Me.btnEdit79.TabIndex = 116
        Me.btnEdit79.Tag = "v"
        Me.btnEdit79.Text = "Edit Other 79(c)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.picSubDivision)
        Me.GroupBox3.Controls.Add(Me.picSustain)
        Me.GroupBox3.Controls.Add(Me.picLandscape)
        Me.GroupBox3.Controls.Add(Me.picHeritage)
        Me.GroupBox3.Controls.Add(Me.picDDA)
        Me.GroupBox3.Controls.Add(Me.btnSubdivision)
        Me.GroupBox3.Controls.Add(Me.btnSustainability)
        Me.GroupBox3.Controls.Add(Me.btnLandscaping)
        Me.GroupBox3.Controls.Add(Me.btnHeritage)
        Me.GroupBox3.Controls.Add(Me.btnDisabDiscrimAct)
        Me.GroupBox3.Controls.Add(Me.picSocial)
        Me.GroupBox3.Controls.Add(Me.picTraffic)
        Me.GroupBox3.Controls.Add(Me.picThreaten)
        Me.GroupBox3.Controls.Add(Me.picDP)
        Me.GroupBox3.Controls.Add(Me.picGenImpacts)
        Me.GroupBox3.Controls.Add(Me.btnSocialEconomic)
        Me.GroupBox3.Controls.Add(Me.btnTraficCarParks)
        Me.GroupBox3.Controls.Add(Me.btnThreatenSpecies)
        Me.GroupBox3.Controls.Add(Me.btnDepositedPlan)
        Me.GroupBox3.Controls.Add(Me.btnGenImpacts)
        Me.GroupBox3.Location = New System.Drawing.Point(540, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 374)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Impacts - Section 79C(1)(b)(c)"
        '
        'picSubDivision
        '
        Me.picSubDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSubDivision.ErrorImage = Nothing
        Me.picSubDivision.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picSubDivision.Location = New System.Drawing.Point(488, 287)
        Me.picSubDivision.Name = "picSubDivision"
        Me.picSubDivision.Size = New System.Drawing.Size(43, 33)
        Me.picSubDivision.TabIndex = 104
        Me.picSubDivision.TabStop = False
        Me.picSubDivision.Visible = False
        '
        'picSustain
        '
        Me.picSustain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSustain.ErrorImage = Nothing
        Me.picSustain.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picSustain.Location = New System.Drawing.Point(488, 224)
        Me.picSustain.Name = "picSustain"
        Me.picSustain.Size = New System.Drawing.Size(43, 33)
        Me.picSustain.TabIndex = 106
        Me.picSustain.TabStop = False
        Me.picSustain.Visible = False
        '
        'picLandscape
        '
        Me.picLandscape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLandscape.ErrorImage = Nothing
        Me.picLandscape.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picLandscape.Location = New System.Drawing.Point(488, 161)
        Me.picLandscape.Name = "picLandscape"
        Me.picLandscape.Size = New System.Drawing.Size(43, 33)
        Me.picLandscape.TabIndex = 105
        Me.picLandscape.TabStop = False
        Me.picLandscape.Visible = False
        '
        'picHeritage
        '
        Me.picHeritage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHeritage.ErrorImage = Nothing
        Me.picHeritage.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picHeritage.Location = New System.Drawing.Point(488, 98)
        Me.picHeritage.Name = "picHeritage"
        Me.picHeritage.Size = New System.Drawing.Size(43, 33)
        Me.picHeritage.TabIndex = 108
        Me.picHeritage.TabStop = False
        Me.picHeritage.Visible = False
        '
        'picDDA
        '
        Me.picDDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDDA.ErrorImage = Nothing
        Me.picDDA.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picDDA.Location = New System.Drawing.Point(488, 34)
        Me.picDDA.Name = "picDDA"
        Me.picDDA.Size = New System.Drawing.Size(43, 33)
        Me.picDDA.TabIndex = 107
        Me.picDDA.TabStop = False
        Me.picDDA.Visible = False
        '
        'btnSubdivision
        '
        Me.btnSubdivision.Location = New System.Drawing.Point(295, 282)
        Me.btnSubdivision.Name = "btnSubdivision"
        Me.btnSubdivision.Size = New System.Drawing.Size(176, 38)
        Me.btnSubdivision.TabIndex = 103
        Me.btnSubdivision.Text = "Subdivision"
        '
        'btnSustainability
        '
        Me.btnSustainability.Location = New System.Drawing.Point(295, 219)
        Me.btnSustainability.Name = "btnSustainability"
        Me.btnSustainability.Size = New System.Drawing.Size(176, 38)
        Me.btnSustainability.TabIndex = 102
        Me.btnSustainability.Text = "Sustainability"
        '
        'btnLandscaping
        '
        Me.btnLandscaping.Location = New System.Drawing.Point(295, 156)
        Me.btnLandscaping.Name = "btnLandscaping"
        Me.btnLandscaping.Size = New System.Drawing.Size(176, 38)
        Me.btnLandscaping.TabIndex = 101
        Me.btnLandscaping.Text = "Landscaping"
        '
        'btnHeritage
        '
        Me.btnHeritage.Location = New System.Drawing.Point(295, 93)
        Me.btnHeritage.Name = "btnHeritage"
        Me.btnHeritage.Size = New System.Drawing.Size(176, 38)
        Me.btnHeritage.TabIndex = 100
        Me.btnHeritage.Text = "Heritage"
        '
        'btnDisabDiscrimAct
        '
        Me.btnDisabDiscrimAct.Location = New System.Drawing.Point(295, 30)
        Me.btnDisabDiscrimAct.Name = "btnDisabDiscrimAct"
        Me.btnDisabDiscrimAct.Size = New System.Drawing.Size(176, 38)
        Me.btnDisabDiscrimAct.TabIndex = 99
        Me.btnDisabDiscrimAct.Text = "Diability Discrimination Act"
        '
        'picSocial
        '
        Me.picSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSocial.ErrorImage = Nothing
        Me.picSocial.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picSocial.Location = New System.Drawing.Point(220, 287)
        Me.picSocial.Name = "picSocial"
        Me.picSocial.Size = New System.Drawing.Size(43, 33)
        Me.picSocial.TabIndex = 94
        Me.picSocial.TabStop = False
        Me.picSocial.Visible = False
        '
        'picTraffic
        '
        Me.picTraffic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTraffic.ErrorImage = Nothing
        Me.picTraffic.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picTraffic.Location = New System.Drawing.Point(220, 224)
        Me.picTraffic.Name = "picTraffic"
        Me.picTraffic.Size = New System.Drawing.Size(43, 33)
        Me.picTraffic.TabIndex = 96
        Me.picTraffic.TabStop = False
        Me.picTraffic.Visible = False
        '
        'picThreaten
        '
        Me.picThreaten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picThreaten.ErrorImage = Nothing
        Me.picThreaten.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picThreaten.Location = New System.Drawing.Point(220, 161)
        Me.picThreaten.Name = "picThreaten"
        Me.picThreaten.Size = New System.Drawing.Size(43, 33)
        Me.picThreaten.TabIndex = 95
        Me.picThreaten.TabStop = False
        Me.picThreaten.Visible = False
        '
        'picDP
        '
        Me.picDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDP.ErrorImage = Nothing
        Me.picDP.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picDP.Location = New System.Drawing.Point(219, 93)
        Me.picDP.Name = "picDP"
        Me.picDP.Size = New System.Drawing.Size(43, 33)
        Me.picDP.TabIndex = 98
        Me.picDP.TabStop = False
        Me.picDP.Visible = False
        '
        'picGenImpacts
        '
        Me.picGenImpacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picGenImpacts.ErrorImage = Nothing
        Me.picGenImpacts.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picGenImpacts.Location = New System.Drawing.Point(219, 34)
        Me.picGenImpacts.Name = "picGenImpacts"
        Me.picGenImpacts.Size = New System.Drawing.Size(43, 33)
        Me.picGenImpacts.TabIndex = 97
        Me.picGenImpacts.TabStop = False
        Me.picGenImpacts.Visible = False
        '
        'btnSocialEconomic
        '
        Me.btnSocialEconomic.Location = New System.Drawing.Point(29, 282)
        Me.btnSocialEconomic.Name = "btnSocialEconomic"
        Me.btnSocialEconomic.Size = New System.Drawing.Size(176, 38)
        Me.btnSocialEconomic.TabIndex = 93
        Me.btnSocialEconomic.Text = "Social and Economic"
        '
        'btnTraficCarParks
        '
        Me.btnTraficCarParks.Location = New System.Drawing.Point(29, 219)
        Me.btnTraficCarParks.Name = "btnTraficCarParks"
        Me.btnTraficCarParks.Size = New System.Drawing.Size(176, 38)
        Me.btnTraficCarParks.TabIndex = 92
        Me.btnTraficCarParks.Text = "Traffic and Carparking"
        '
        'btnThreatenSpecies
        '
        Me.btnThreatenSpecies.Location = New System.Drawing.Point(29, 156)
        Me.btnThreatenSpecies.Name = "btnThreatenSpecies"
        Me.btnThreatenSpecies.Size = New System.Drawing.Size(176, 38)
        Me.btnThreatenSpecies.TabIndex = 91
        Me.btnThreatenSpecies.Text = "Threatened Species"
        '
        'btnDepositedPlan
        '
        Me.btnDepositedPlan.Location = New System.Drawing.Point(29, 93)
        Me.btnDepositedPlan.Name = "btnDepositedPlan"
        Me.btnDepositedPlan.Size = New System.Drawing.Size(176, 38)
        Me.btnDepositedPlan.TabIndex = 90
        Me.btnDepositedPlan.Text = "Deposited Plan"
        '
        'btnGenImpacts
        '
        Me.btnGenImpacts.Location = New System.Drawing.Point(29, 30)
        Me.btnGenImpacts.Name = "btnGenImpacts"
        Me.btnGenImpacts.Size = New System.Drawing.Size(176, 38)
        Me.btnGenImpacts.TabIndex = 89
        Me.btnGenImpacts.Text = "General Impacts"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.picDCPchkList)
        Me.GroupBox6.Controls.Add(Me.picDAMS)
        Me.GroupBox6.Controls.Add(Me.picDCP)
        Me.GroupBox6.Controls.Add(Me.picGUIDES)
        Me.GroupBox6.Controls.Add(Me.picSEPP)
        Me.GroupBox6.Controls.Add(Me.picLEP)
        Me.GroupBox6.Controls.Add(Me.picREP)
        Me.GroupBox6.Controls.Add(Me.btnDams)
        Me.GroupBox6.Controls.Add(Me.btnDCPCheckList)
        Me.GroupBox6.Controls.Add(Me.btnREP)
        Me.GroupBox6.Controls.Add(Me.btnDCP)
        Me.GroupBox6.Controls.Add(Me.btnGuidLines)
        Me.GroupBox6.Controls.Add(Me.btnSepp)
        Me.GroupBox6.Controls.Add(Me.btnLEP)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(274, 374)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Considerations - Section 79C(1)(b)(c)"
        '
        'picDCPchkList
        '
        Me.picDCPchkList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDCPchkList.ErrorImage = Nothing
        Me.picDCPchkList.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picDCPchkList.Location = New System.Drawing.Point(216, 324)
        Me.picDCPchkList.Name = "picDCPchkList"
        Me.picDCPchkList.Size = New System.Drawing.Size(43, 33)
        Me.picDCPchkList.TabIndex = 95
        Me.picDCPchkList.TabStop = False
        Me.picDCPchkList.Visible = False
        '
        'picDAMS
        '
        Me.picDAMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDAMS.ErrorImage = Nothing
        Me.picDAMS.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picDAMS.Location = New System.Drawing.Point(215, 177)
        Me.picDAMS.Name = "picDAMS"
        Me.picDAMS.Size = New System.Drawing.Size(43, 33)
        Me.picDAMS.TabIndex = 92
        Me.picDAMS.TabStop = False
        Me.picDAMS.Visible = False
        '
        'picDCP
        '
        Me.picDCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDCP.ErrorImage = Nothing
        Me.picDCP.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picDCP.Location = New System.Drawing.Point(215, 130)
        Me.picDCP.Name = "picDCP"
        Me.picDCP.Size = New System.Drawing.Size(43, 33)
        Me.picDCP.TabIndex = 91
        Me.picDCP.TabStop = False
        Me.picDCP.Visible = False
        '
        'picGUIDES
        '
        Me.picGUIDES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picGUIDES.ErrorImage = Nothing
        Me.picGUIDES.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picGUIDES.Location = New System.Drawing.Point(216, 275)
        Me.picGUIDES.Name = "picGUIDES"
        Me.picGUIDES.Size = New System.Drawing.Size(43, 33)
        Me.picGUIDES.TabIndex = 94
        Me.picGUIDES.TabStop = False
        Me.picGUIDES.Visible = False
        '
        'picSEPP
        '
        Me.picSEPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSEPP.ErrorImage = Nothing
        Me.picSEPP.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picSEPP.Location = New System.Drawing.Point(215, 84)
        Me.picSEPP.Name = "picSEPP"
        Me.picSEPP.Size = New System.Drawing.Size(43, 33)
        Me.picSEPP.TabIndex = 90
        Me.picSEPP.TabStop = False
        Me.picSEPP.Visible = False
        '
        'picLEP
        '
        Me.picLEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLEP.ErrorImage = Nothing
        Me.picLEP.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picLEP.Location = New System.Drawing.Point(215, 37)
        Me.picLEP.Name = "picLEP"
        Me.picLEP.Size = New System.Drawing.Size(43, 33)
        Me.picLEP.TabIndex = 89
        Me.picLEP.TabStop = False
        Me.picLEP.Visible = False
        '
        'picREP
        '
        Me.picREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picREP.ErrorImage = Nothing
        Me.picREP.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Tick1
        Me.picREP.Location = New System.Drawing.Point(216, 227)
        Me.picREP.Name = "picREP"
        Me.picREP.Size = New System.Drawing.Size(43, 33)
        Me.picREP.TabIndex = 93
        Me.picREP.TabStop = False
        Me.picREP.Visible = False
        '
        'btnDams
        '
        Me.btnDams.Location = New System.Drawing.Point(20, 176)
        Me.btnDams.Name = "btnDams"
        Me.btnDams.Size = New System.Drawing.Size(176, 38)
        Me.btnDams.TabIndex = 3
        Me.btnDams.Text = "Dams"
        '
        'btnDCPCheckList
        '
        Me.btnDCPCheckList.Location = New System.Drawing.Point(20, 322)
        Me.btnDCPCheckList.Name = "btnDCPCheckList"
        Me.btnDCPCheckList.Size = New System.Drawing.Size(176, 38)
        Me.btnDCPCheckList.TabIndex = 8
        Me.btnDCPCheckList.Text = "DCP CheckList"
        '
        'btnREP
        '
        Me.btnREP.Location = New System.Drawing.Point(20, 224)
        Me.btnREP.Name = "btnREP"
        Me.btnREP.Size = New System.Drawing.Size(176, 38)
        Me.btnREP.TabIndex = 5
        Me.btnREP.Text = "Regional Environment Plans"
        '
        'btnDCP
        '
        Me.btnDCP.Location = New System.Drawing.Point(20, 128)
        Me.btnDCP.Name = "btnDCP"
        Me.btnDCP.Size = New System.Drawing.Size(176, 38)
        Me.btnDCP.TabIndex = 2
        Me.btnDCP.Text = "DCPs Applicable"
        '
        'btnGuidLines
        '
        Me.btnGuidLines.Location = New System.Drawing.Point(20, 273)
        Me.btnGuidLines.Name = "btnGuidLines"
        Me.btnGuidLines.Size = New System.Drawing.Size(176, 38)
        Me.btnGuidLines.TabIndex = 6
        Me.btnGuidLines.Text = "GuideLines (other)"
        '
        'btnSepp
        '
        Me.btnSepp.Location = New System.Drawing.Point(20, 82)
        Me.btnSepp.Name = "btnSepp"
        Me.btnSepp.Size = New System.Drawing.Size(176, 38)
        Me.btnSepp.TabIndex = 1
        Me.btnSepp.Text = "SEPPS (Inc Drafts)"
        '
        'btnLEP
        '
        Me.btnLEP.Location = New System.Drawing.Point(20, 37)
        Me.btnLEP.Name = "btnLEP"
        Me.btnLEP.Size = New System.Drawing.Size(176, 38)
        Me.btnLEP.TabIndex = 0
        Me.btnLEP.Text = "LEP / Zone Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, -10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 8
        '
        'tpgVariations
        '
        Me.tpgVariations.Controls.Add(Me.pnlDisplayVariations)
        Me.tpgVariations.Image = CType(resources.GetObject("tpgVariations.Image"), System.Drawing.Image)
        Me.tpgVariations.Name = "tpgVariations"
        Me.tpgVariations.Size = New System.Drawing.Size(1389, 761)
        Me.tpgVariations.Text = "Variations"
        '
        'pnlDisplayVariations
        '
        Me.pnlDisplayVariations.Controls.Add(Me.btnRemoveVariation)
        Me.pnlDisplayVariations.Controls.Add(Me.grdVariations)
        Me.pnlDisplayVariations.Controls.Add(Me.GroupBox1)
        Me.pnlDisplayVariations.Controls.Add(Me.grpVariations)
        Me.pnlDisplayVariations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayVariations.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayVariations.Name = "pnlDisplayVariations"
        Me.pnlDisplayVariations.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayVariations.TabIndex = 30
        '
        'btnRemoveVariation
        '
        Me.btnRemoveVariation.Enabled = False
        Me.btnRemoveVariation.Image = CType(resources.GetObject("btnRemoveVariation.Image"), System.Drawing.Image)
        Me.btnRemoveVariation.Location = New System.Drawing.Point(1106, 273)
        Me.btnRemoveVariation.Name = "btnRemoveVariation"
        Me.btnRemoveVariation.Size = New System.Drawing.Size(114, 42)
        Me.btnRemoveVariation.TabIndex = 43
        Me.btnRemoveVariation.Tag = ""
        Me.btnRemoveVariation.Text = "Remove " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Variation"
        '
        'grdVariations
        '
        Me.grdVariations.Location = New System.Drawing.Point(9, 3)
        Me.grdVariations.MainView = Me.gvwVariations
        Me.grdVariations.Name = "grdVariations"
        Me.grdVariations.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4})
        Me.grdVariations.Size = New System.Drawing.Size(1080, 312)
        Me.grdVariations.TabIndex = 39
        Me.grdVariations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVariations})
        '
        'gvwVariations
        '
        Me.gvwVariations.Appearance.Row.Options.UseTextOptions = True
        Me.gvwVariations.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwVariations.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwVariations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colVariation, Me.coldetail, Me.colVariationResultDesc, Me.colDelegatedAuthority, Me.colDecisionDate, Me.colAssResult, Me.colAssReasons, Me.colUserStamp, Me.colResultCode})
        Me.gvwVariations.GridControl = Me.grdVariations
        Me.gvwVariations.Name = "gvwVariations"
        Me.gvwVariations.OptionsBehavior.ReadOnly = True
        Me.gvwVariations.OptionsView.ShowGroupPanel = False
        Me.gvwVariations.RowHeight = 100
        '
        'colid
        '
        Me.colid.Caption = "id"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colVariation
        '
        Me.colVariation.Caption = "Variation"
        Me.colVariation.FieldName = "Variation"
        Me.colVariation.Name = "colVariation"
        Me.colVariation.OptionsColumn.AllowEdit = False
        Me.colVariation.OptionsColumn.ReadOnly = True
        Me.colVariation.Visible = True
        Me.colVariation.VisibleIndex = 0
        Me.colVariation.Width = 129
        '
        'coldetail
        '
        Me.coldetail.Caption = "Detail"
        Me.coldetail.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.coldetail.FieldName = "detail"
        Me.coldetail.Name = "coldetail"
        Me.coldetail.OptionsColumn.ReadOnly = True
        Me.coldetail.Visible = True
        Me.coldetail.VisibleIndex = 1
        Me.coldetail.Width = 194
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'colVariationResultDesc
        '
        Me.colVariationResultDesc.Caption = "Result"
        Me.colVariationResultDesc.FieldName = "VariationResultDesc"
        Me.colVariationResultDesc.Name = "colVariationResultDesc"
        Me.colVariationResultDesc.OptionsColumn.AllowEdit = False
        Me.colVariationResultDesc.OptionsColumn.ReadOnly = True
        Me.colVariationResultDesc.Visible = True
        Me.colVariationResultDesc.VisibleIndex = 2
        Me.colVariationResultDesc.Width = 66
        '
        'colDelegatedAuthority
        '
        Me.colDelegatedAuthority.Caption = "Authority"
        Me.colDelegatedAuthority.FieldName = "DelegatedAuthority"
        Me.colDelegatedAuthority.Name = "colDelegatedAuthority"
        Me.colDelegatedAuthority.OptionsColumn.AllowEdit = False
        Me.colDelegatedAuthority.OptionsColumn.ReadOnly = True
        Me.colDelegatedAuthority.Visible = True
        Me.colDelegatedAuthority.VisibleIndex = 3
        Me.colDelegatedAuthority.Width = 83
        '
        'colDecisionDate
        '
        Me.colDecisionDate.Caption = "Date"
        Me.colDecisionDate.FieldName = "DecisionDate"
        Me.colDecisionDate.Name = "colDecisionDate"
        Me.colDecisionDate.OptionsColumn.AllowEdit = False
        Me.colDecisionDate.OptionsColumn.ReadOnly = True
        Me.colDecisionDate.Visible = True
        Me.colDecisionDate.VisibleIndex = 4
        '
        'colAssResult
        '
        Me.colAssResult.Caption = "Recommendation"
        Me.colAssResult.FieldName = "AssResult"
        Me.colAssResult.Name = "colAssResult"
        Me.colAssResult.OptionsColumn.AllowEdit = False
        Me.colAssResult.OptionsColumn.ReadOnly = True
        Me.colAssResult.Visible = True
        Me.colAssResult.VisibleIndex = 5
        Me.colAssResult.Width = 106
        '
        'colAssReasons
        '
        Me.colAssReasons.Caption = "Reason"
        Me.colAssReasons.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colAssReasons.FieldName = "AssReasons"
        Me.colAssReasons.Name = "colAssReasons"
        Me.colAssReasons.OptionsColumn.ReadOnly = True
        Me.colAssReasons.Visible = True
        Me.colAssReasons.VisibleIndex = 6
        Me.colAssReasons.Width = 401
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colUserStamp
        '
        Me.colUserStamp.Caption = "GridColumn9"
        Me.colUserStamp.FieldName = "UserStamp"
        Me.colUserStamp.Name = "colUserStamp"
        '
        'colResultCode
        '
        Me.colResultCode.Caption = "Result"
        Me.colResultCode.FieldName = "Result"
        Me.colResultCode.Name = "colResultCode"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.variationDecisionDate)
        Me.GroupBox1.Controls.Add(Me.cboVariationResult)
        Me.GroupBox1.Controls.Add(Me.cboVariationAuthority)
        Me.GroupBox1.Controls.Add(Me.btnSaveVariationResponse)
        Me.GroupBox1.Controls.Add(Me.btneditVariationResponse)
        Me.GroupBox1.Controls.Add(Me.Label99)
        Me.GroupBox1.Controls.Add(Me.Label100)
        Me.GroupBox1.Controls.Add(Me.Label101)
        Me.GroupBox1.Location = New System.Drawing.Point(809, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 235)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Response"
        '
        'variationDecisionDate
        '
        Me.variationDecisionDate.EditValue = Nothing
        Me.variationDecisionDate.Location = New System.Drawing.Point(168, 96)
        Me.variationDecisionDate.Name = "variationDecisionDate"
        Me.variationDecisionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.variationDecisionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.variationDecisionDate.Properties.ReadOnly = True
        Me.variationDecisionDate.Size = New System.Drawing.Size(100, 20)
        Me.variationDecisionDate.TabIndex = 46
        '
        'cboVariationResult
        '
        Me.cboVariationResult.Location = New System.Drawing.Point(9, 37)
        Me.cboVariationResult.Name = "cboVariationResult"
        Me.cboVariationResult.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVariationResult.Properties.NullText = "[Select Result]"
        Me.cboVariationResult.Properties.ReadOnly = True
        Me.cboVariationResult.Properties.ShowFooter = False
        Me.cboVariationResult.Properties.ShowHeader = False
        Me.cboVariationResult.Size = New System.Drawing.Size(147, 20)
        Me.cboVariationResult.TabIndex = 45
        '
        'cboVariationAuthority
        '
        Me.cboVariationAuthority.Location = New System.Drawing.Point(9, 96)
        Me.cboVariationAuthority.Name = "cboVariationAuthority"
        Me.cboVariationAuthority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVariationAuthority.Properties.NullText = "[Select Authority]"
        Me.cboVariationAuthority.Properties.ReadOnly = True
        Me.cboVariationAuthority.Properties.ShowFooter = False
        Me.cboVariationAuthority.Properties.ShowHeader = False
        Me.cboVariationAuthority.Size = New System.Drawing.Size(147, 20)
        Me.cboVariationAuthority.TabIndex = 44
        '
        'btnSaveVariationResponse
        '
        Me.btnSaveVariationResponse.Enabled = False
        Me.btnSaveVariationResponse.Image = CType(resources.GetObject("btnSaveVariationResponse.Image"), System.Drawing.Image)
        Me.btnSaveVariationResponse.Location = New System.Drawing.Point(168, 193)
        Me.btnSaveVariationResponse.Name = "btnSaveVariationResponse"
        Me.btnSaveVariationResponse.Size = New System.Drawing.Size(94, 36)
        Me.btnSaveVariationResponse.TabIndex = 43
        Me.btnSaveVariationResponse.Tag = "v"
        Me.btnSaveVariationResponse.Text = "Save"
        '
        'btneditVariationResponse
        '
        Me.btneditVariationResponse.Enabled = False
        Me.btneditVariationResponse.Image = CType(resources.GetObject("btneditVariationResponse.Image"), System.Drawing.Image)
        Me.btneditVariationResponse.Location = New System.Drawing.Point(12, 193)
        Me.btneditVariationResponse.Name = "btneditVariationResponse"
        Me.btneditVariationResponse.Size = New System.Drawing.Size(94, 36)
        Me.btneditVariationResponse.TabIndex = 42
        Me.btneditVariationResponse.Tag = "v"
        Me.btneditVariationResponse.Text = "Edit"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(9, 21)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(41, 13)
        Me.Label99.TabIndex = 35
        Me.Label99.Text = "Result:"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(9, 75)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(56, 13)
        Me.Label100.TabIndex = 36
        Me.Label100.Text = "Authority:"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(165, 75)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(76, 13)
        Me.Label101.TabIndex = 37
        Me.Label101.Text = "Decision Date:"
        '
        'grpVariations
        '
        Me.grpVariations.Controls.Add(Me.txtOfficersReasons)
        Me.grpVariations.Controls.Add(Me.txtVariationDetails)
        Me.grpVariations.Controls.Add(Me.lblID)
        Me.grpVariations.Controls.Add(Me.btnAddVariation)
        Me.grpVariations.Controls.Add(Me.btnSaveVariation)
        Me.grpVariations.Controls.Add(Me.btnEditVariation)
        Me.grpVariations.Controls.Add(Me.Label131)
        Me.grpVariations.Controls.Add(Me.Label98)
        Me.grpVariations.Controls.Add(Me.Label130)
        Me.grpVariations.Controls.Add(Me.Label97)
        Me.grpVariations.Controls.Add(Me.cboOfficerRecomforVariation)
        Me.grpVariations.Controls.Add(Me.cboVariationType)
        Me.grpVariations.Location = New System.Drawing.Point(11, 321)
        Me.grpVariations.Name = "grpVariations"
        Me.grpVariations.Size = New System.Drawing.Size(792, 369)
        Me.grpVariations.TabIndex = 1
        Me.grpVariations.TabStop = False
        '
        'txtOfficersReasons
        '
        Me.txtOfficersReasons.Location = New System.Drawing.Point(189, 179)
        Me.txtOfficersReasons.Name = "txtOfficersReasons"
        Me.txtOfficersReasons.Properties.ReadOnly = True
        Me.txtOfficersReasons.Size = New System.Drawing.Size(597, 132)
        Me.txtOfficersReasons.TabIndex = 44
        '
        'txtVariationDetails
        '
        Me.txtVariationDetails.Location = New System.Drawing.Point(189, 34)
        Me.txtVariationDetails.Name = "txtVariationDetails"
        Me.txtVariationDetails.Properties.ReadOnly = True
        Me.txtVariationDetails.Size = New System.Drawing.Size(597, 108)
        Me.txtVariationDetails.TabIndex = 43
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(812, 110)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 42
        '
        'btnAddVariation
        '
        Me.btnAddVariation.Image = CType(resources.GetObject("btnAddVariation.Image"), System.Drawing.Image)
        Me.btnAddVariation.Location = New System.Drawing.Point(12, 327)
        Me.btnAddVariation.Name = "btnAddVariation"
        Me.btnAddVariation.Size = New System.Drawing.Size(94, 36)
        Me.btnAddVariation.TabIndex = 41
        Me.btnAddVariation.Tag = "v"
        Me.btnAddVariation.Text = "Add"
        '
        'btnSaveVariation
        '
        Me.btnSaveVariation.Enabled = False
        Me.btnSaveVariation.Image = CType(resources.GetObject("btnSaveVariation.Image"), System.Drawing.Image)
        Me.btnSaveVariation.Location = New System.Drawing.Point(692, 327)
        Me.btnSaveVariation.Name = "btnSaveVariation"
        Me.btnSaveVariation.Size = New System.Drawing.Size(94, 36)
        Me.btnSaveVariation.TabIndex = 7
        Me.btnSaveVariation.Tag = "v"
        Me.btnSaveVariation.Text = "Save"
        '
        'btnEditVariation
        '
        Me.btnEditVariation.Image = CType(resources.GetObject("btnEditVariation.Image"), System.Drawing.Image)
        Me.btnEditVariation.Location = New System.Drawing.Point(123, 327)
        Me.btnEditVariation.Name = "btnEditVariation"
        Me.btnEditVariation.Size = New System.Drawing.Size(94, 36)
        Me.btnEditVariation.TabIndex = 38
        Me.btnEditVariation.Tag = "v"
        Me.btnEditVariation.Text = "Edit"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(186, 160)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(90, 13)
        Me.Label131.TabIndex = 34
        Me.Label131.Text = "Officer's Reason:"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(186, 18)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(97, 13)
        Me.Label98.TabIndex = 34
        Me.Label98.Text = "Details/Comments:"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(8, 160)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(132, 13)
        Me.Label130.TabIndex = 33
        Me.Label130.Text = "Officer's Recommendation"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(9, 16)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(80, 13)
        Me.Label97.TabIndex = 33
        Me.Label97.Text = "Variation Type:"
        '
        'cboOfficerRecomforVariation
        '
        Me.cboOfficerRecomforVariation.Location = New System.Drawing.Point(7, 180)
        Me.cboOfficerRecomforVariation.Name = "cboOfficerRecomforVariation"
        Me.cboOfficerRecomforVariation.Properties.DisplayMember = "VariationResultDesc"
        Me.cboOfficerRecomforVariation.Properties.NullText = "[Select recommendation]"
        Me.cboOfficerRecomforVariation.Properties.ShowFooter = False
        Me.cboOfficerRecomforVariation.Properties.ShowHeader = False
        Me.cboOfficerRecomforVariation.Properties.ValueMember = "VariationResultCode"
        Me.cboOfficerRecomforVariation.Size = New System.Drawing.Size(175, 20)
        Me.cboOfficerRecomforVariation.TabIndex = 2
        '
        'cboVariationType
        '
        Me.cboVariationType.Location = New System.Drawing.Point(8, 36)
        Me.cboVariationType.Name = "cboVariationType"
        Me.cboVariationType.Properties.DisplayMember = "Variation"
        Me.cboVariationType.Properties.NullText = "[Select Variation]"
        Me.cboVariationType.Properties.ShowFooter = False
        Me.cboVariationType.Properties.ShowHeader = False
        Me.cboVariationType.Properties.ValueMember = "VariationId"
        Me.cboVariationType.Size = New System.Drawing.Size(175, 20)
        Me.cboVariationType.TabIndex = 0
        '
        'tpgContributions
        '
        Me.tpgContributions.Controls.Add(Me.pnlDisplayContributions)
        Me.tpgContributions.Image = CType(resources.GetObject("tpgContributions.Image"), System.Drawing.Image)
        Me.tpgContributions.Name = "tpgContributions"
        Me.tpgContributions.Size = New System.Drawing.Size(1389, 761)
        Me.tpgContributions.Text = "Contributions"
        '
        'pnlDisplayContributions
        '
        Me.pnlDisplayContributions.Controls.Add(Me.GroupBox4)
        Me.pnlDisplayContributions.Controls.Add(Me.GroupControl4)
        Me.pnlDisplayContributions.Controls.Add(Me.GroupControl3)
        Me.pnlDisplayContributions.Controls.Add(Me.GroupControl2)
        Me.pnlDisplayContributions.Controls.Add(Me.Label14)
        Me.pnlDisplayContributions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayContributions.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayContributions.Name = "pnlDisplayContributions"
        Me.pnlDisplayContributions.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayContributions.TabIndex = 28
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt64Amount)
        Me.GroupBox4.Controls.Add(Me.cboS64Type)
        Me.GroupBox4.Controls.Add(Me.BtnInsertNewSection64)
        Me.GroupBox4.Controls.Add(Me.txt64Note)
        Me.GroupBox4.Controls.Add(Me.cboContribType)
        Me.GroupBox4.Controls.Add(Me.cboSection64Type)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(874, 114)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.Text = "Add a new contribution"
        '
        'txt64Amount
        '
        Me.txt64Amount.Location = New System.Drawing.Point(229, 38)
        Me.txt64Amount.Name = "txt64Amount"
        Me.txt64Amount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt64Amount.Size = New System.Drawing.Size(100, 18)
        Me.txt64Amount.TabIndex = 73
        '
        'cboS64Type
        '
        Me.cboS64Type.Location = New System.Drawing.Point(345, 37)
        Me.cboS64Type.Name = "cboS64Type"
        Me.cboS64Type.Properties.DisplayMember = "S94Type"
        Me.cboS64Type.Properties.NullText = "[Select Type]"
        Me.cboS64Type.Properties.ShowFooter = False
        Me.cboS64Type.Properties.ShowHeader = False
        Me.cboS64Type.Properties.ValueMember = "S94TypeId"
        Me.cboS64Type.Size = New System.Drawing.Size(129, 20)
        Me.cboS64Type.TabIndex = 72
        '
        'BtnInsertNewSection64
        '
        Me.BtnInsertNewSection64.Image = CType(resources.GetObject("BtnInsertNewSection64.Image"), System.Drawing.Image)
        Me.BtnInsertNewSection64.Location = New System.Drawing.Point(747, 27)
        Me.BtnInsertNewSection64.Name = "BtnInsertNewSection64"
        Me.BtnInsertNewSection64.Size = New System.Drawing.Size(115, 37)
        Me.BtnInsertNewSection64.TabIndex = 71
        Me.BtnInsertNewSection64.Text = "Insert"
        '
        'txt64Note
        '
        Me.txt64Note.Location = New System.Drawing.Point(5, 80)
        Me.txt64Note.Name = "txt64Note"
        Me.txt64Note.Size = New System.Drawing.Size(581, 20)
        Me.txt64Note.TabIndex = 70
        '
        'cboContribType
        '
        Me.cboContribType.Location = New System.Drawing.Point(494, 38)
        Me.cboContribType.Name = "cboContribType"
        Me.cboContribType.Properties.NullText = "[Category?]"
        Me.cboContribType.Properties.ShowFooter = False
        Me.cboContribType.Properties.ShowHeader = False
        Me.cboContribType.Size = New System.Drawing.Size(92, 20)
        Me.cboContribType.TabIndex = 69
        '
        'cboSection64Type
        '
        Me.cboSection64Type.Location = New System.Drawing.Point(6, 38)
        Me.cboSection64Type.Name = "cboSection64Type"
        Me.cboSection64Type.Properties.DisplayMember = "s94PLAN"
        Me.cboSection64Type.Properties.NullText = "[Select Plan]"
        Me.cboSection64Type.Properties.ShowFooter = False
        Me.cboSection64Type.Properties.ShowHeader = False
        Me.cboSection64Type.Properties.ValueMember = "s94Code"
        Me.cboSection64Type.Size = New System.Drawing.Size(198, 20)
        Me.cboSection64Type.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(491, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 13)
        Me.Label28.TabIndex = 67
        Me.Label28.Text = "Category:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(342, 22)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 67
        Me.Label30.Text = "Type:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(226, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Amount:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "Note:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 13)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "Plan Type:"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grdProposedBondContrib)
        Me.GroupControl4.Controls.Add(Me.btnRemoveBond)
        Me.GroupControl4.Location = New System.Drawing.Point(16, 551)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(874, 201)
        Me.GroupControl4.TabIndex = 26
        Me.GroupControl4.Text = "Proposed Bond Contributions"
        '
        'grdProposedBondContrib
        '
        Me.grdProposedBondContrib.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdProposedBondContrib.Location = New System.Drawing.Point(2, 20)
        Me.grdProposedBondContrib.MainView = Me.gvwProposedBondContrib
        Me.grdProposedBondContrib.Name = "grdProposedBondContrib"
        Me.grdProposedBondContrib.Size = New System.Drawing.Size(740, 179)
        Me.grdProposedBondContrib.TabIndex = 23
        Me.grdProposedBondContrib.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwProposedBondContrib})
        '
        'gvwProposedBondContrib
        '
        Me.gvwProposedBondContrib.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvwProposedBondContrib.GridControl = Me.grdProposedBondContrib
        Me.gvwProposedBondContrib.Name = "gvwProposedBondContrib"
        Me.gvwProposedBondContrib.OptionsBehavior.Editable = False
        Me.gvwProposedBondContrib.OptionsBehavior.ReadOnly = True
        Me.gvwProposedBondContrib.OptionsView.ShowFooter = True
        Me.gvwProposedBondContrib.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "id"
        Me.GridColumn6.FieldName = "S94ID"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Proposed Bond"
        Me.GridColumn7.FieldName = "s94Plan"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 212
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Amount"
        Me.GridColumn8.DisplayFormat.FormatString = "c2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "S94ContCalc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "S94ContCalc", "{0:c2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 96
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Notes"
        Me.GridColumn9.FieldName = "S94CalcNote"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 353
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Type"
        Me.GridColumn10.FieldName = "S94Type"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 60
        '
        'btnRemoveBond
        '
        Me.btnRemoveBond.Enabled = False
        Me.btnRemoveBond.Image = CType(resources.GetObject("btnRemoveBond.Image"), System.Drawing.Image)
        Me.btnRemoveBond.Location = New System.Drawing.Point(746, 23)
        Me.btnRemoveBond.Name = "btnRemoveBond"
        Me.btnRemoveBond.Size = New System.Drawing.Size(115, 37)
        Me.btnRemoveBond.TabIndex = 19
        Me.btnRemoveBond.Tag = "v"
        Me.btnRemoveBond.Text = "Remove"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdSection94)
        Me.GroupControl3.Controls.Add(Me.btnRemove94)
        Me.GroupControl3.Location = New System.Drawing.Point(16, 344)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(874, 201)
        Me.GroupControl3.TabIndex = 25
        Me.GroupControl3.Text = "Proposed Section 94 Contributions"
        '
        'grdSection94
        '
        Me.grdSection94.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdSection94.Location = New System.Drawing.Point(2, 20)
        Me.grdSection94.MainView = Me.gvwSection94
        Me.grdSection94.Name = "grdSection94"
        Me.grdSection94.Size = New System.Drawing.Size(740, 179)
        Me.grdSection94.TabIndex = 22
        Me.grdSection94.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSection94})
        '
        'gvwSection94
        '
        Me.gvwSection94.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvwSection94.GridControl = Me.grdSection94
        Me.gvwSection94.Name = "gvwSection94"
        Me.gvwSection94.OptionsBehavior.Editable = False
        Me.gvwSection94.OptionsBehavior.ReadOnly = True
        Me.gvwSection94.OptionsView.ShowFooter = True
        Me.gvwSection94.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "S94ID"
        Me.GridColumn1.FieldName = "S94ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Proposed Sec 94"
        Me.GridColumn2.FieldName = "s94Plan"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 212
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Amount"
        Me.GridColumn3.DisplayFormat.FormatString = "c2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "S94ContCalc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "S94ContCalc", "{0:c2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 96
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Notes"
        Me.GridColumn4.FieldName = "S94CalcNote"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 353
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Type"
        Me.GridColumn5.FieldName = "S94Type"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 60
        '
        'btnRemove94
        '
        Me.btnRemove94.Enabled = False
        Me.btnRemove94.Image = CType(resources.GetObject("btnRemove94.Image"), System.Drawing.Image)
        Me.btnRemove94.Location = New System.Drawing.Point(747, 23)
        Me.btnRemove94.Name = "btnRemove94"
        Me.btnRemove94.Size = New System.Drawing.Size(115, 37)
        Me.btnRemove94.TabIndex = 18
        Me.btnRemove94.Tag = "v"
        Me.btnRemove94.Text = "Remove"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grdSection64Contributions)
        Me.GroupControl2.Controls.Add(Me.btnRemove64)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 133)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(874, 201)
        Me.GroupControl2.TabIndex = 24
        Me.GroupControl2.Text = "Propsed Section 64 Contributions"
        '
        'grdSection64Contributions
        '
        Me.grdSection64Contributions.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdSection64Contributions.Location = New System.Drawing.Point(2, 20)
        Me.grdSection64Contributions.MainView = Me.gvwSection64Contributions
        Me.grdSection64Contributions.Name = "grdSection64Contributions"
        Me.grdSection64Contributions.Size = New System.Drawing.Size(739, 179)
        Me.grdSection64Contributions.TabIndex = 21
        Me.grdSection64Contributions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSection64Contributions})
        '
        'gvwSection64Contributions
        '
        Me.gvwSection64Contributions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colS94ID, Me.colS94Plan, Me.colS94ContCalc, Me.colS94CalcNote, Me.colS94Type})
        Me.gvwSection64Contributions.GridControl = Me.grdSection64Contributions
        Me.gvwSection64Contributions.Name = "gvwSection64Contributions"
        Me.gvwSection64Contributions.OptionsBehavior.Editable = False
        Me.gvwSection64Contributions.OptionsBehavior.ReadOnly = True
        Me.gvwSection64Contributions.OptionsView.ShowFooter = True
        Me.gvwSection64Contributions.OptionsView.ShowGroupPanel = False
        '
        'colS94ID
        '
        Me.colS94ID.Caption = "S94ID"
        Me.colS94ID.FieldName = "S94ID"
        Me.colS94ID.Name = "colS94ID"
        Me.colS94ID.Width = 21
        '
        'colS94Plan
        '
        Me.colS94Plan.Caption = "Proposed Sec 64"
        Me.colS94Plan.FieldName = "s94Plan"
        Me.colS94Plan.Name = "colS94Plan"
        Me.colS94Plan.Visible = True
        Me.colS94Plan.VisibleIndex = 0
        Me.colS94Plan.Width = 212
        '
        'colS94ContCalc
        '
        Me.colS94ContCalc.Caption = "Amount"
        Me.colS94ContCalc.DisplayFormat.FormatString = "c2"
        Me.colS94ContCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colS94ContCalc.FieldName = "S94ContCalc"
        Me.colS94ContCalc.Name = "colS94ContCalc"
        Me.colS94ContCalc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "S94ContCalc", "{0:c2}")})
        Me.colS94ContCalc.Visible = True
        Me.colS94ContCalc.VisibleIndex = 1
        Me.colS94ContCalc.Width = 96
        '
        'colS94CalcNote
        '
        Me.colS94CalcNote.Caption = "Notes"
        Me.colS94CalcNote.FieldName = "S94CalcNote"
        Me.colS94CalcNote.Name = "colS94CalcNote"
        Me.colS94CalcNote.Visible = True
        Me.colS94CalcNote.VisibleIndex = 2
        Me.colS94CalcNote.Width = 353
        '
        'colS94Type
        '
        Me.colS94Type.Caption = "Type"
        Me.colS94Type.FieldName = "S94Type"
        Me.colS94Type.Name = "colS94Type"
        Me.colS94Type.Visible = True
        Me.colS94Type.VisibleIndex = 3
        Me.colS94Type.Width = 60
        '
        'btnRemove64
        '
        Me.btnRemove64.Enabled = False
        Me.btnRemove64.Image = CType(resources.GetObject("btnRemove64.Image"), System.Drawing.Image)
        Me.btnRemove64.Location = New System.Drawing.Point(747, 23)
        Me.btnRemove64.Name = "btnRemove64"
        Me.btnRemove64.Size = New System.Drawing.Size(115, 37)
        Me.btnRemove64.TabIndex = 17
        Me.btnRemove64.Tag = "v"
        Me.btnRemove64.Text = "Remove"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, -10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 16)
        Me.Label14.TabIndex = 8
        '
        'tpgModifications
        '
        Me.tpgModifications.Controls.Add(Me.pnlDisplayModifications)
        Me.tpgModifications.Image = CType(resources.GetObject("tpgModifications.Image"), System.Drawing.Image)
        Me.tpgModifications.Name = "tpgModifications"
        Me.tpgModifications.Size = New System.Drawing.Size(1389, 761)
        Me.tpgModifications.Text = "Modification"
        '
        'pnlDisplayModifications
        '
        Me.pnlDisplayModifications.Controls.Add(Me.grpMod)
        Me.pnlDisplayModifications.Controls.Add(Me.btnUpdateModData)
        Me.pnlDisplayModifications.Controls.Add(Me.btnUpdateModDetails)
        Me.pnlDisplayModifications.Controls.Add(Me.lblModeType)
        Me.pnlDisplayModifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayModifications.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayModifications.Name = "pnlDisplayModifications"
        Me.pnlDisplayModifications.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayModifications.TabIndex = 25
        '
        'grpMod
        '
        Me.grpMod.Controls.Add(Me.scrolModification)
        Me.grpMod.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpMod.Location = New System.Drawing.Point(2, 2)
        Me.grpMod.Name = "grpMod"
        Me.grpMod.Size = New System.Drawing.Size(662, 757)
        Me.grpMod.TabIndex = 11
        '
        'scrolModification
        '
        Me.scrolModification.Controls.Add(Me.pnlMod1)
        Me.scrolModification.Controls.Add(Me.pnlMod1A)
        Me.scrolModification.Controls.Add(ModSect96Label)
        Me.scrolModification.Controls.Add(Me.cboModSect96)
        Me.scrolModification.Controls.Add(ModReasonLabel)
        Me.scrolModification.Controls.Add(ModDetailsLabel)
        Me.scrolModification.Controls.Add(Me.ModDetailsTextBox)
        Me.scrolModification.Controls.Add(Me.ModReasonTextBox)
        Me.scrolModification.Controls.Add(Me.pnlMod1andMod2)
        Me.scrolModification.Controls.Add(Me.pnlMod2)
        Me.scrolModification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrolModification.Location = New System.Drawing.Point(2, 20)
        Me.scrolModification.Name = "scrolModification"
        Me.scrolModification.Size = New System.Drawing.Size(658, 735)
        Me.scrolModification.TabIndex = 7
        '
        'pnlMod1
        '
        Me.pnlMod1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMod1.Controls.Add(Me.ModSect94CommentTextBox)
        Me.pnlMod1.Controls.Add(Me.ModSect79cCommentTextBox)
        Me.pnlMod1.Controls.Add(Me.Label22)
        Me.pnlMod1.Controls.Add(ModSect94CommentLabel)
        Me.pnlMod1.Controls.Add(ModSect94YNLabel)
        Me.pnlMod1.Controls.Add(Me.ModSect94YNComboBox)
        Me.pnlMod1.Controls.Add(ModSect79cCommentLabel)
        Me.pnlMod1.Controls.Add(Modsect79cYNLabel)
        Me.pnlMod1.Controls.Add(Me.Modsect79cYNComboBox)
        Me.pnlMod1.Enabled = False
        Me.pnlMod1.Location = New System.Drawing.Point(8, 567)
        Me.pnlMod1.Name = "pnlMod1"
        Me.pnlMod1.Size = New System.Drawing.Size(627, 185)
        Me.pnlMod1.TabIndex = 6
        Me.pnlMod1.Visible = False
        '
        'ModSect94CommentTextBox
        '
        Me.ModSect94CommentTextBox.Location = New System.Drawing.Point(73, 135)
        Me.ModSect94CommentTextBox.Name = "ModSect94CommentTextBox"
        Me.ModSect94CommentTextBox.Properties.ReadOnly = True
        Me.ModSect94CommentTextBox.Size = New System.Drawing.Size(547, 47)
        Me.ModSect94CommentTextBox.TabIndex = 14
        '
        'ModSect79cCommentTextBox
        '
        Me.ModSect79cCommentTextBox.Location = New System.Drawing.Point(72, 56)
        Me.ModSect79cCommentTextBox.Name = "ModSect79cCommentTextBox"
        Me.ModSect79cCommentTextBox.Properties.ReadOnly = True
        Me.ModSect79cCommentTextBox.Size = New System.Drawing.Size(547, 47)
        Me.ModSect79cCommentTextBox.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "PLANNING ASSESSMENT"
        '
        'ModSect94YNComboBox
        '
        Me.ModSect94YNComboBox.Location = New System.Drawing.Point(524, 109)
        Me.ModSect94YNComboBox.Name = "ModSect94YNComboBox"
        Me.ModSect94YNComboBox.Properties.DisplayMember = "Desc"
        Me.ModSect94YNComboBox.Properties.NullText = "[Select one]"
        Me.ModSect94YNComboBox.Properties.ShowFooter = False
        Me.ModSect94YNComboBox.Properties.ShowHeader = False
        Me.ModSect94YNComboBox.Properties.ValueMember = "Code"
        Me.ModSect94YNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModSect94YNComboBox.TabIndex = 5
        '
        'Modsect79cYNComboBox
        '
        Me.Modsect79cYNComboBox.Location = New System.Drawing.Point(524, 32)
        Me.Modsect79cYNComboBox.Name = "Modsect79cYNComboBox"
        Me.Modsect79cYNComboBox.Properties.DisplayMember = "Desc"
        Me.Modsect79cYNComboBox.Properties.NullText = "[Select one]"
        Me.Modsect79cYNComboBox.Properties.ShowFooter = False
        Me.Modsect79cYNComboBox.Properties.ShowHeader = False
        Me.Modsect79cYNComboBox.Properties.ValueMember = "Code"
        Me.Modsect79cYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.Modsect79cYNComboBox.TabIndex = 1
        '
        'pnlMod1A
        '
        Me.pnlMod1A.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMod1A.Controls.Add(Me.ModMinEnvImpCommentTextBox)
        Me.pnlMod1A.Controls.Add(ModMinEnvImpCommentLabel)
        Me.pnlMod1A.Controls.Add(ModMinEnvImpactYNLabel)
        Me.pnlMod1A.Controls.Add(Me.ModMinEnvImpactYNComboBox)
        Me.pnlMod1A.Enabled = False
        Me.pnlMod1A.Location = New System.Drawing.Point(8, 322)
        Me.pnlMod1A.Name = "pnlMod1A"
        Me.pnlMod1A.Size = New System.Drawing.Size(628, 85)
        Me.pnlMod1A.TabIndex = 2
        Me.pnlMod1A.Visible = False
        '
        'ModMinEnvImpCommentTextBox
        '
        Me.ModMinEnvImpCommentTextBox.Location = New System.Drawing.Point(73, 37)
        Me.ModMinEnvImpCommentTextBox.Name = "ModMinEnvImpCommentTextBox"
        Me.ModMinEnvImpCommentTextBox.Properties.ReadOnly = True
        Me.ModMinEnvImpCommentTextBox.Size = New System.Drawing.Size(547, 38)
        Me.ModMinEnvImpCommentTextBox.TabIndex = 12
        '
        'ModMinEnvImpactYNComboBox
        '
        Me.ModMinEnvImpactYNComboBox.Location = New System.Drawing.Point(525, 11)
        Me.ModMinEnvImpactYNComboBox.Name = "ModMinEnvImpactYNComboBox"
        Me.ModMinEnvImpactYNComboBox.Properties.DisplayMember = "Desc"
        Me.ModMinEnvImpactYNComboBox.Properties.NullText = "[Select one]"
        Me.ModMinEnvImpactYNComboBox.Properties.ShowFooter = False
        Me.ModMinEnvImpactYNComboBox.Properties.ShowHeader = False
        Me.ModMinEnvImpactYNComboBox.Properties.ValueMember = "Code"
        Me.ModMinEnvImpactYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModMinEnvImpactYNComboBox.TabIndex = 1
        '
        'cboModSect96
        '
        Me.cboModSect96.Enabled = False
        Me.cboModSect96.Location = New System.Drawing.Point(207, 111)
        Me.cboModSect96.Name = "cboModSect96"
        Me.cboModSect96.Properties.NullText = "[Select one]"
        Me.cboModSect96.Properties.ShowFooter = False
        Me.cboModSect96.Properties.ShowHeader = False
        Me.cboModSect96.Size = New System.Drawing.Size(60, 20)
        Me.cboModSect96.TabIndex = 5
        '
        'ModDetailsTextBox
        '
        Me.ModDetailsTextBox.Location = New System.Drawing.Point(8, 20)
        Me.ModDetailsTextBox.Name = "ModDetailsTextBox"
        Me.ModDetailsTextBox.Properties.ReadOnly = True
        Me.ModDetailsTextBox.Size = New System.Drawing.Size(627, 29)
        Me.ModDetailsTextBox.TabIndex = 1
        '
        'ModReasonTextBox
        '
        Me.ModReasonTextBox.Location = New System.Drawing.Point(8, 68)
        Me.ModReasonTextBox.Name = "ModReasonTextBox"
        Me.ModReasonTextBox.Properties.ReadOnly = True
        Me.ModReasonTextBox.Size = New System.Drawing.Size(627, 33)
        Me.ModReasonTextBox.TabIndex = 3
        '
        'pnlMod1andMod2
        '
        Me.pnlMod1andMod2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMod1andMod2.Controls.Add(Me.ModSubStSameCommentTextBox)
        Me.pnlMod1andMod2.Controls.Add(ModSubmConsYNLabel)
        Me.pnlMod1andMod2.Controls.Add(Me.ModSubmConsYNComboBox)
        Me.pnlMod1andMod2.Controls.Add(ModNotificationYNLabel)
        Me.pnlMod1andMod2.Controls.Add(Me.ModNotificationYNComboBox)
        Me.pnlMod1andMod2.Controls.Add(ModSubStSameCommentLabel)
        Me.pnlMod1andMod2.Controls.Add(ModSubstSameYNLabel)
        Me.pnlMod1andMod2.Controls.Add(Me.ModSubstSameYNComboBox)
        Me.pnlMod1andMod2.Enabled = False
        Me.pnlMod1andMod2.Location = New System.Drawing.Point(8, 140)
        Me.pnlMod1andMod2.Name = "pnlMod1andMod2"
        Me.pnlMod1andMod2.Size = New System.Drawing.Size(628, 183)
        Me.pnlMod1andMod2.TabIndex = 1
        Me.pnlMod1andMod2.Visible = False
        '
        'ModSubStSameCommentTextBox
        '
        Me.ModSubStSameCommentTextBox.Location = New System.Drawing.Point(73, 43)
        Me.ModSubStSameCommentTextBox.Name = "ModSubStSameCommentTextBox"
        Me.ModSubStSameCommentTextBox.Properties.ReadOnly = True
        Me.ModSubStSameCommentTextBox.Size = New System.Drawing.Size(547, 47)
        Me.ModSubStSameCommentTextBox.TabIndex = 11
        '
        'ModSubmConsYNComboBox
        '
        Me.ModSubmConsYNComboBox.Location = New System.Drawing.Point(524, 154)
        Me.ModSubmConsYNComboBox.Name = "ModSubmConsYNComboBox"
        Me.ModSubmConsYNComboBox.Properties.DisplayMember = "Desc"
        Me.ModSubmConsYNComboBox.Properties.NullText = "[Select one]"
        Me.ModSubmConsYNComboBox.Properties.ShowFooter = False
        Me.ModSubmConsYNComboBox.Properties.ShowHeader = False
        Me.ModSubmConsYNComboBox.Properties.ValueMember = "Code"
        Me.ModSubmConsYNComboBox.Size = New System.Drawing.Size(96, 20)
        Me.ModSubmConsYNComboBox.TabIndex = 7
        '
        'ModNotificationYNComboBox
        '
        Me.ModNotificationYNComboBox.Location = New System.Drawing.Point(525, 129)
        Me.ModNotificationYNComboBox.Name = "ModNotificationYNComboBox"
        Me.ModNotificationYNComboBox.Properties.DisplayMember = "Desc"
        Me.ModNotificationYNComboBox.Properties.NullText = "[Select one]"
        Me.ModNotificationYNComboBox.Properties.ShowFooter = False
        Me.ModNotificationYNComboBox.Properties.ShowHeader = False
        Me.ModNotificationYNComboBox.Properties.ValueMember = "Code"
        Me.ModNotificationYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModNotificationYNComboBox.TabIndex = 5
        '
        'ModSubstSameYNComboBox
        '
        Me.ModSubstSameYNComboBox.Location = New System.Drawing.Point(525, 7)
        Me.ModSubstSameYNComboBox.Name = "ModSubstSameYNComboBox"
        Me.ModSubstSameYNComboBox.Properties.DisplayMember = "Desc"
        Me.ModSubstSameYNComboBox.Properties.NullText = "[Select one]"
        Me.ModSubstSameYNComboBox.Properties.ShowFooter = False
        Me.ModSubstSameYNComboBox.Properties.ShowHeader = False
        Me.ModSubstSameYNComboBox.Properties.ValueMember = "Code"
        Me.ModSubstSameYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModSubstSameYNComboBox.TabIndex = 1
        '
        'pnlMod2
        '
        Me.pnlMod2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMod2.Controls.Add(Me.ModThreatCommentTextBox)
        Me.pnlMod2.Controls.Add(ModThreatCommentLabel)
        Me.pnlMod2.Controls.Add(ModThreatComplYNLabel)
        Me.pnlMod2.Controls.Add(Me.ModThreatComplYNComboBox)
        Me.pnlMod2.Controls.Add(ModThreatSpecYNLabel)
        Me.pnlMod2.Controls.Add(Me.ModThreatSpecYNComboBox)
        Me.pnlMod2.Controls.Add(ModMinisterCommentLabel)
        Me.pnlMod2.Controls.Add(ModMinisterOBjYNLabel)
        Me.pnlMod2.Controls.Add(Me.ModMinisterOBjYNComboBox)
        Me.pnlMod2.Controls.Add(ModConsMinisterYNLabel)
        Me.pnlMod2.Controls.Add(Me.ModConsMinisterYNComboBox)
        Me.pnlMod2.Controls.Add(Me.ModMinisterCommentTextBox)
        Me.pnlMod2.Enabled = False
        Me.pnlMod2.Location = New System.Drawing.Point(8, 322)
        Me.pnlMod2.Name = "pnlMod2"
        Me.pnlMod2.Size = New System.Drawing.Size(628, 245)
        Me.pnlMod2.TabIndex = 3
        Me.pnlMod2.Visible = False
        '
        'ModThreatCommentTextBox
        '
        Me.ModThreatCommentTextBox.Location = New System.Drawing.Point(72, 192)
        Me.ModThreatCommentTextBox.Name = "ModThreatCommentTextBox"
        Me.ModThreatCommentTextBox.Properties.ReadOnly = True
        Me.ModThreatCommentTextBox.Size = New System.Drawing.Size(547, 42)
        Me.ModThreatCommentTextBox.TabIndex = 13
        '
        'ModThreatComplYNComboBox
        '
        Me.ModThreatComplYNComboBox.Location = New System.Drawing.Point(523, 165)
        Me.ModThreatComplYNComboBox.Name = "ModThreatComplYNComboBox"
        Me.ModThreatComplYNComboBox.Properties.DisplayMember = "ResultCode"
        Me.ModThreatComplYNComboBox.Properties.NullText = "[Select one]"
        Me.ModThreatComplYNComboBox.Properties.ShowFooter = False
        Me.ModThreatComplYNComboBox.Properties.ShowHeader = False
        Me.ModThreatComplYNComboBox.Properties.ValueMember = "ResultCode"
        Me.ModThreatComplYNComboBox.Size = New System.Drawing.Size(96, 20)
        Me.ModThreatComplYNComboBox.TabIndex = 9
        '
        'ModThreatSpecYNComboBox
        '
        Me.ModThreatSpecYNComboBox.Location = New System.Drawing.Point(523, 134)
        Me.ModThreatSpecYNComboBox.Name = "ModThreatSpecYNComboBox"
        Me.ModThreatSpecYNComboBox.Properties.DisplayMember = "ResultCode"
        Me.ModThreatSpecYNComboBox.Properties.NullText = "[Select one]"
        Me.ModThreatSpecYNComboBox.Properties.ShowFooter = False
        Me.ModThreatSpecYNComboBox.Properties.ShowHeader = False
        Me.ModThreatSpecYNComboBox.Properties.ValueMember = "ResultCode"
        Me.ModThreatSpecYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModThreatSpecYNComboBox.TabIndex = 7
        '
        'ModMinisterOBjYNComboBox
        '
        Me.ModMinisterOBjYNComboBox.Location = New System.Drawing.Point(524, 53)
        Me.ModMinisterOBjYNComboBox.Name = "ModMinisterOBjYNComboBox"
        Me.ModMinisterOBjYNComboBox.Properties.DisplayMember = "ResultCode"
        Me.ModMinisterOBjYNComboBox.Properties.ValueMember = "ResultCode"
        Me.ModMinisterOBjYNComboBox.Size = New System.Drawing.Size(96, 20)
        Me.ModMinisterOBjYNComboBox.TabIndex = 3
        '
        'ModConsMinisterYNComboBox
        '
        Me.ModConsMinisterYNComboBox.Location = New System.Drawing.Point(524, 21)
        Me.ModConsMinisterYNComboBox.Name = "ModConsMinisterYNComboBox"
        Me.ModConsMinisterYNComboBox.Properties.DisplayMember = "ResultCode"
        Me.ModConsMinisterYNComboBox.Properties.ValueMember = "ResultCode"
        Me.ModConsMinisterYNComboBox.Size = New System.Drawing.Size(95, 20)
        Me.ModConsMinisterYNComboBox.TabIndex = 1
        '
        'ModMinisterCommentTextBox
        '
        Me.ModMinisterCommentTextBox.Location = New System.Drawing.Point(75, 76)
        Me.ModMinisterCommentTextBox.Name = "ModMinisterCommentTextBox"
        Me.ModMinisterCommentTextBox.Properties.ReadOnly = True
        Me.ModMinisterCommentTextBox.Size = New System.Drawing.Size(543, 42)
        Me.ModMinisterCommentTextBox.TabIndex = 5
        '
        'btnUpdateModData
        '
        Me.btnUpdateModData.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateModData.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btnUpdateModData.Appearance.Options.UseFont = True
        Me.btnUpdateModData.Appearance.Options.UseForeColor = True
        Me.btnUpdateModData.Enabled = False
        Me.btnUpdateModData.Image = CType(resources.GetObject("btnUpdateModData.Image"), System.Drawing.Image)
        Me.btnUpdateModData.Location = New System.Drawing.Point(693, 89)
        Me.btnUpdateModData.Name = "btnUpdateModData"
        Me.btnUpdateModData.Size = New System.Drawing.Size(177, 49)
        Me.btnUpdateModData.TabIndex = 9
        Me.btnUpdateModData.Text = "Save Section 96 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Details"
        '
        'btnUpdateModDetails
        '
        Me.btnUpdateModDetails.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateModDetails.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btnUpdateModDetails.Appearance.Options.UseFont = True
        Me.btnUpdateModDetails.Appearance.Options.UseForeColor = True
        Me.btnUpdateModDetails.Image = CType(resources.GetObject("btnUpdateModDetails.Image"), System.Drawing.Image)
        Me.btnUpdateModDetails.Location = New System.Drawing.Point(693, 22)
        Me.btnUpdateModDetails.Name = "btnUpdateModDetails"
        Me.btnUpdateModDetails.Size = New System.Drawing.Size(177, 49)
        Me.btnUpdateModDetails.TabIndex = 10
        Me.btnUpdateModDetails.Text = "Add/Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Section 96 Details"
        '
        'lblModeType
        '
        Me.lblModeType.AutoSize = True
        Me.lblModeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeType.Location = New System.Drawing.Point(11, 7)
        Me.lblModeType.Name = "lblModeType"
        Me.lblModeType.Size = New System.Drawing.Size(0, 16)
        Me.lblModeType.TabIndex = 8
        '
        'tpgConclusion
        '
        Me.tpgConclusion.Controls.Add(Me.pnlDisplayConclusions)
        Me.tpgConclusion.Image = CType(resources.GetObject("tpgConclusion.Image"), System.Drawing.Image)
        Me.tpgConclusion.Name = "tpgConclusion"
        Me.tpgConclusion.Size = New System.Drawing.Size(1389, 761)
        Me.tpgConclusion.Text = "Conclusions"
        '
        'pnlDisplayConclusions
        '
        Me.pnlDisplayConclusions.Controls.Add(Me.Label16)
        Me.pnlDisplayConclusions.Controls.Add(Me.scrolMainConclusion)
        Me.pnlDisplayConclusions.Controls.Add(Me.pnlLabel)
        Me.pnlDisplayConclusions.Controls.Add(Me.pnlModificationConclusion)
        Me.pnlDisplayConclusions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayConclusions.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayConclusions.Name = "pnlDisplayConclusions"
        Me.pnlDisplayConclusions.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayConclusions.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, -10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 16)
        Me.Label16.TabIndex = 8
        '
        'scrolMainConclusion
        '
        Me.scrolMainConclusion.Controls.Add(Me.pnlConclusion)
        Me.scrolMainConclusion.Location = New System.Drawing.Point(5, 47)
        Me.scrolMainConclusion.Name = "scrolMainConclusion"
        Me.scrolMainConclusion.Size = New System.Drawing.Size(1381, 714)
        Me.scrolMainConclusion.TabIndex = 11
        '
        'pnlConclusion
        '
        Me.pnlConclusion.Controls.Add(Me.dteConclusionDate)
        Me.pnlConclusion.Controls.Add(Me.dgvConditionText)
        Me.pnlConclusion.Controls.Add(Me.dgvConditions)
        Me.pnlConclusion.Controls.Add(Me.grdConclusionVariations)
        Me.pnlConclusion.Controls.Add(Me.txtApplicationConclreasons)
        Me.pnlConclusion.Controls.Add(Me.ComplianceStatProvCommentsTextBox)
        Me.pnlConclusion.Controls.Add(Me.txtVariationComment)
        Me.pnlConclusion.Controls.Add(Me.btnViewConclusion)
        Me.pnlConclusion.Controls.Add(Me.cboAuthority)
        Me.pnlConclusion.Controls.Add(Me.Label80)
        Me.pnlConclusion.Controls.Add(Me.Label127)
        Me.pnlConclusion.Controls.Add(Me.Label52)
        Me.pnlConclusion.Controls.Add(Me.btnViewComplainceReason)
        Me.pnlConclusion.Controls.Add(Me.Label53)
        Me.pnlConclusion.Controls.Add(Me.Label54)
        Me.pnlConclusion.Controls.Add(Me.Label125)
        Me.pnlConclusion.Controls.Add(Me.Label55)
        Me.pnlConclusion.Controls.Add(Me.Label126)
        Me.pnlConclusion.Controls.Add(Label95)
        Me.pnlConclusion.Controls.Add(ComplianceStatProvCommentsLabel)
        Me.pnlConclusion.Controls.Add(AssessmentDecisionLabel)
        Me.pnlConclusion.Controls.Add(Me.cboReferralsYesNo)
        Me.pnlConclusion.Controls.Add(Me.cboAssessmentDecision)
        Me.pnlConclusion.Controls.Add(ReferralsYesNoLabel)
        Me.pnlConclusion.Controls.Add(Me.cboComplianceStatProvYesNo)
        Me.pnlConclusion.Controls.Add(Me.Label56)
        Me.pnlConclusion.Controls.Add(Label83)
        Me.pnlConclusion.Controls.Add(Label81)
        Me.pnlConclusion.Controls.Add(ComplianceStatProvYesNoLabel)
        Me.pnlConclusion.Controls.Add(Me.cboVariationsYesNo)
        Me.pnlConclusion.Controls.Add(VariationsYesNoLabel)
        Me.pnlConclusion.Controls.Add(Label128)
        Me.pnlConclusion.Controls.Add(Me.cboApplicationConclResult)
        Me.pnlConclusion.Location = New System.Drawing.Point(-3, 0)
        Me.pnlConclusion.Name = "pnlConclusion"
        Me.pnlConclusion.Size = New System.Drawing.Size(1366, 817)
        Me.pnlConclusion.TabIndex = 103
        '
        'dteConclusionDate
        '
        Me.dteConclusionDate.EditValue = Nothing
        Me.dteConclusionDate.Location = New System.Drawing.Point(392, 720)
        Me.dteConclusionDate.Name = "dteConclusionDate"
        Me.dteConclusionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteConclusionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteConclusionDate.Size = New System.Drawing.Size(100, 20)
        Me.dteConclusionDate.TabIndex = 108
        '
        'dgvConditionText
        '
        Me.dgvConditionText.Location = New System.Drawing.Point(750, 607)
        Me.dgvConditionText.MainView = Me.gvwOneUpConditions
        Me.dgvConditionText.Name = "dgvConditionText"
        Me.dgvConditionText.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit7})
        Me.dgvConditionText.Size = New System.Drawing.Size(610, 176)
        Me.dgvConditionText.TabIndex = 107
        Me.dgvConditionText.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOneUpConditions})
        '
        'gvwOneUpConditions
        '
        Me.gvwOneUpConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUniqueId, Me.colConditionCode, Me.colConditionText})
        Me.gvwOneUpConditions.GridControl = Me.dgvConditionText
        Me.gvwOneUpConditions.Name = "gvwOneUpConditions"
        Me.gvwOneUpConditions.OptionsBehavior.Editable = False
        Me.gvwOneUpConditions.OptionsBehavior.SmartVertScrollBar = False
        Me.gvwOneUpConditions.OptionsView.ShowGroupPanel = False
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
        Me.colConditionText.AppearanceCell.Options.UseTextOptions = True
        Me.colConditionText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colConditionText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConditionText.Caption = "Condition Text"
        Me.colConditionText.ColumnEdit = Me.RepositoryItemMemoEdit7
        Me.colConditionText.FieldName = "ConditionText"
        Me.colConditionText.Name = "colConditionText"
        Me.colConditionText.Visible = True
        Me.colConditionText.VisibleIndex = 0
        '
        'RepositoryItemMemoEdit7
        '
        Me.RepositoryItemMemoEdit7.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit7.Name = "RepositoryItemMemoEdit7"
        '
        'dgvConditions
        '
        Me.dgvConditions.Location = New System.Drawing.Point(750, 412)
        Me.dgvConditions.MainView = Me.gvwSTDConditions
        Me.dgvConditions.Name = "dgvConditions"
        Me.dgvConditions.Size = New System.Drawing.Size(610, 176)
        Me.dgvConditions.TabIndex = 106
        Me.dgvConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSTDConditions})
        '
        'gvwSTDConditions
        '
        Me.gvwSTDConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.costdlId, Me.colStdCondition, Me.colFreeFormInserts})
        Me.gvwSTDConditions.GridControl = Me.dgvConditions
        Me.gvwSTDConditions.Name = "gvwSTDConditions"
        Me.gvwSTDConditions.OptionsBehavior.Editable = False
        Me.gvwSTDConditions.OptionsBehavior.SmartVertScrollBar = False
        Me.gvwSTDConditions.OptionsView.ShowGroupPanel = False
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
        Me.colStdCondition.Visible = True
        Me.colStdCondition.VisibleIndex = 0
        Me.colStdCondition.Width = 764
        '
        'colFreeFormInserts
        '
        Me.colFreeFormInserts.Caption = "Inserts"
        Me.colFreeFormInserts.FieldName = "FreeFormInserts"
        Me.colFreeFormInserts.Name = "colFreeFormInserts"
        Me.colFreeFormInserts.Visible = True
        Me.colFreeFormInserts.VisibleIndex = 1
        Me.colFreeFormInserts.Width = 66
        '
        'grdConclusionVariations
        '
        Me.grdConclusionVariations.Location = New System.Drawing.Point(9, 164)
        Me.grdConclusionVariations.MainView = Me.gvwConclusionVariations
        Me.grdConclusionVariations.Name = "grdConclusionVariations"
        Me.grdConclusionVariations.Size = New System.Drawing.Size(1351, 229)
        Me.grdConclusionVariations.TabIndex = 105
        Me.grdConclusionVariations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwConclusionVariations})
        '
        'gvwConclusionVariations
        '
        Me.gvwConclusionVariations.Appearance.Row.Options.UseTextOptions = True
        Me.gvwConclusionVariations.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwConclusionVariations.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwConclusionVariations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.gvwConclusionVariations.GridControl = Me.grdConclusionVariations
        Me.gvwConclusionVariations.Name = "gvwConclusionVariations"
        Me.gvwConclusionVariations.OptionsBehavior.ReadOnly = True
        Me.gvwConclusionVariations.OptionsView.ShowGroupPanel = False
        Me.gvwConclusionVariations.RowHeight = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "id"
        Me.GridColumn11.FieldName = "id"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Variation"
        Me.GridColumn12.FieldName = "Variation"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 183
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Detail"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemMemoEdit8
        Me.GridColumn13.FieldName = "detail"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 873
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Result"
        Me.GridColumn14.FieldName = "VariationResultDesc"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 154
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Authority"
        Me.GridColumn15.FieldName = "DelegatedAuthority"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Width = 83
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Date"
        Me.GridColumn16.FieldName = "DecisionDate"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        Me.GridColumn16.Width = 106
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Recommendation"
        Me.GridColumn17.FieldName = "AssResult"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Width = 106
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Reason"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemMemoEdit9
        Me.GridColumn18.FieldName = "AssReasons"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Width = 401
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "GridColumn9"
        Me.GridColumn19.FieldName = "UserStamp"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'txtApplicationConclreasons
        '
        Me.txtApplicationConclreasons.Location = New System.Drawing.Point(9, 434)
        Me.txtApplicationConclreasons.Name = "txtApplicationConclreasons"
        Me.txtApplicationConclreasons.Size = New System.Drawing.Size(649, 121)
        Me.txtApplicationConclreasons.TabIndex = 104
        '
        'ComplianceStatProvCommentsTextBox
        '
        Me.ComplianceStatProvCommentsTextBox.Location = New System.Drawing.Point(707, 37)
        Me.ComplianceStatProvCommentsTextBox.Name = "ComplianceStatProvCommentsTextBox"
        Me.ComplianceStatProvCommentsTextBox.Size = New System.Drawing.Size(593, 101)
        Me.ComplianceStatProvCommentsTextBox.TabIndex = 103
        '
        'txtVariationComment
        '
        Me.txtVariationComment.Location = New System.Drawing.Point(73, 91)
        Me.txtVariationComment.Name = "txtVariationComment"
        Me.txtVariationComment.Size = New System.Drawing.Size(593, 47)
        Me.txtVariationComment.TabIndex = 102
        '
        'btnViewConclusion
        '
        Me.btnViewConclusion.Location = New System.Drawing.Point(671, 434)
        Me.btnViewConclusion.Name = "btnViewConclusion"
        Me.btnViewConclusion.Size = New System.Drawing.Size(54, 23)
        Me.btnViewConclusion.TabIndex = 100
        Me.btnViewConclusion.Text = "View"
        '
        'cboAuthority
        '
        Me.cboAuthority.Location = New System.Drawing.Point(111, 720)
        Me.cboAuthority.Name = "cboAuthority"
        Me.cboAuthority.Properties.DisplayMember = "Description"
        Me.cboAuthority.Properties.NullText = "[Select]"
        Me.cboAuthority.Properties.ShowFooter = False
        Me.cboAuthority.Properties.ShowHeader = False
        Me.cboAuthority.Properties.ValueMember = "id"
        Me.cboAuthority.Size = New System.Drawing.Size(121, 20)
        Me.cboAuthority.TabIndex = 8
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(238, 724)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(148, 13)
        Me.Label80.TabIndex = 91
        Me.Label80.Text = "Proposed Determination Date"
        '
        'Label127
        '
        Me.Label127.BackColor = System.Drawing.Color.Black
        Me.Label127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.ForeColor = System.Drawing.Color.White
        Me.Label127.Location = New System.Drawing.Point(19, 719)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(86, 23)
        Me.Label127.TabIndex = 1
        Me.Label127.Text = "Authority:"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Black
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(5, 7)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(100, 23)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "Referrals:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewComplainceReason
        '
        Me.btnViewComplainceReason.Location = New System.Drawing.Point(1306, 38)
        Me.btnViewComplainceReason.Name = "btnViewComplainceReason"
        Me.btnViewComplainceReason.Size = New System.Drawing.Size(54, 23)
        Me.btnViewComplainceReason.TabIndex = 99
        Me.btnViewComplainceReason.Text = "View"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Black
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(643, 7)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(100, 23)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Compliance:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Black
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(5, 50)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 23)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Variations:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Location = New System.Drawing.Point(747, 591)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(96, 13)
        Me.Label125.TabIndex = 91
        Me.Label125.Text = "OneOff Conditions"
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Black
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(8, 398)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(100, 23)
        Me.Label55.TabIndex = 1
        Me.Label55.Text = "Summary:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(748, 396)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(104, 13)
        Me.Label126.TabIndex = 92
        Me.Label126.Text = "Standard Conditions"
        '
        'cboReferralsYesNo
        '
        Me.cboReferralsYesNo.Location = New System.Drawing.Point(343, 7)
        Me.cboReferralsYesNo.Name = "cboReferralsYesNo"
        Me.cboReferralsYesNo.Properties.DisplayMember = "Desc"
        Me.cboReferralsYesNo.Properties.NullText = "[Select]"
        Me.cboReferralsYesNo.Properties.ShowFooter = False
        Me.cboReferralsYesNo.Properties.ShowHeader = False
        Me.cboReferralsYesNo.Properties.ValueMember = "Code"
        Me.cboReferralsYesNo.Size = New System.Drawing.Size(121, 20)
        Me.cboReferralsYesNo.TabIndex = 0
        '
        'cboAssessmentDecision
        '
        Me.cboAssessmentDecision.Location = New System.Drawing.Point(115, 607)
        Me.cboAssessmentDecision.Name = "cboAssessmentDecision"
        Me.cboAssessmentDecision.Properties.DisplayMember = "RecoResultDesc"
        Me.cboAssessmentDecision.Properties.NullText = "[Select]"
        Me.cboAssessmentDecision.Properties.ShowFooter = False
        Me.cboAssessmentDecision.Properties.ShowHeader = False
        Me.cboAssessmentDecision.Properties.ValueMember = "RecommendedResult"
        Me.cboAssessmentDecision.Size = New System.Drawing.Size(550, 20)
        Me.cboAssessmentDecision.TabIndex = 7
        '
        'cboComplianceStatProvYesNo
        '
        Me.cboComplianceStatProvYesNo.Location = New System.Drawing.Point(1189, 7)
        Me.cboComplianceStatProvYesNo.Name = "cboComplianceStatProvYesNo"
        Me.cboComplianceStatProvYesNo.Properties.DisplayMember = "ResultCodeDesc"
        Me.cboComplianceStatProvYesNo.Properties.NullText = "[Select]"
        Me.cboComplianceStatProvYesNo.Properties.ShowFooter = False
        Me.cboComplianceStatProvYesNo.Properties.ShowHeader = False
        Me.cboComplianceStatProvYesNo.Properties.ValueMember = "ResultCode"
        Me.cboComplianceStatProvYesNo.Size = New System.Drawing.Size(121, 20)
        Me.cboComplianceStatProvYesNo.TabIndex = 1
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Black
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(9, 577)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(147, 23)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "Recommendation"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboVariationsYesNo
        '
        Me.cboVariationsYesNo.Location = New System.Drawing.Point(543, 52)
        Me.cboVariationsYesNo.Name = "cboVariationsYesNo"
        Me.cboVariationsYesNo.Properties.DisplayMember = "Desc"
        Me.cboVariationsYesNo.Properties.NullText = "[Select]"
        Me.cboVariationsYesNo.Properties.ShowFooter = False
        Me.cboVariationsYesNo.Properties.ShowHeader = False
        Me.cboVariationsYesNo.Properties.ValueMember = "Code"
        Me.cboVariationsYesNo.Size = New System.Drawing.Size(121, 20)
        Me.cboVariationsYesNo.TabIndex = 3
        '
        'cboApplicationConclResult
        '
        Me.cboApplicationConclResult.Location = New System.Drawing.Point(297, 401)
        Me.cboApplicationConclResult.Name = "cboApplicationConclResult"
        Me.cboApplicationConclResult.Properties.DisplayMember = "RecommendedResult"
        Me.cboApplicationConclResult.Properties.NullText = "[Select]"
        Me.cboApplicationConclResult.Properties.ShowFooter = False
        Me.cboApplicationConclResult.Properties.ShowHeader = False
        Me.cboApplicationConclResult.Properties.ValueMember = "RecommendedResult"
        Me.cboApplicationConclResult.Size = New System.Drawing.Size(121, 20)
        Me.cboApplicationConclResult.TabIndex = 5
        '
        'pnlLabel
        '
        Me.pnlLabel.Controls.Add(Me.btnUpdateConclusion)
        Me.pnlLabel.Controls.Add(Me.lblConclusion)
        Me.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabel.Location = New System.Drawing.Point(2, 2)
        Me.pnlLabel.Name = "pnlLabel"
        Me.pnlLabel.Size = New System.Drawing.Size(1385, 39)
        Me.pnlLabel.TabIndex = 12
        '
        'btnUpdateConclusion
        '
        Me.btnUpdateConclusion.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUpdateConclusion.Image = CType(resources.GetObject("btnUpdateConclusion.Image"), System.Drawing.Image)
        Me.btnUpdateConclusion.Location = New System.Drawing.Point(1235, 2)
        Me.btnUpdateConclusion.Name = "btnUpdateConclusion"
        Me.btnUpdateConclusion.Size = New System.Drawing.Size(148, 35)
        Me.btnUpdateConclusion.TabIndex = 12
        Me.btnUpdateConclusion.Text = "Update Conclusion"
        '
        'lblConclusion
        '
        Me.lblConclusion.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConclusion.Location = New System.Drawing.Point(2, 2)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(844, 35)
        Me.lblConclusion.TabIndex = 10
        '
        'pnlModificationConclusion
        '
        Me.pnlModificationConclusion.Controls.Add(Me.dteProposedDetermDate)
        Me.pnlModificationConclusion.Controls.Add(Me.GroupControl9)
        Me.pnlModificationConclusion.Controls.Add(Me.GroupControl5)
        Me.pnlModificationConclusion.Controls.Add(Me.ApplicationConclreasonsTextBox)
        Me.pnlModificationConclusion.Controls.Add(Me.btnViewReco)
        Me.pnlModificationConclusion.Controls.Add(Me.Label129)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModAuthority)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModAssessmentDecision)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModSec79Satisfactory)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModSec96Comply)
        Me.pnlModificationConclusion.Controls.Add(Me.lblRecommendTwo)
        Me.pnlModificationConclusion.Controls.Add(Me.lblRecommendation)
        Me.pnlModificationConclusion.Controls.Add(Me.Label49)
        Me.pnlModificationConclusion.Controls.Add(Me.Label47)
        Me.pnlModificationConclusion.Controls.Add(Me.Label48)
        Me.pnlModificationConclusion.Controls.Add(Me.Label43)
        Me.pnlModificationConclusion.Controls.Add(Me.Label33)
        Me.pnlModificationConclusion.Controls.Add(Me.Label32)
        Me.pnlModificationConclusion.Controls.Add(Me.Label31)
        Me.pnlModificationConclusion.Location = New System.Drawing.Point(5, 47)
        Me.pnlModificationConclusion.Name = "pnlModificationConclusion"
        Me.pnlModificationConclusion.Size = New System.Drawing.Size(1363, 711)
        Me.pnlModificationConclusion.TabIndex = 9
        Me.pnlModificationConclusion.Visible = False
        '
        'dteProposedDetermDate
        '
        Me.dteProposedDetermDate.EditValue = Nothing
        Me.dteProposedDetermDate.Location = New System.Drawing.Point(385, 546)
        Me.dteProposedDetermDate.Name = "dteProposedDetermDate"
        Me.dteProposedDetermDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteProposedDetermDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteProposedDetermDate.Size = New System.Drawing.Size(100, 20)
        Me.dteProposedDetermDate.TabIndex = 108
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.dgvOneOffConditions)
        Me.GroupControl9.Location = New System.Drawing.Point(556, 324)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(486, 199)
        Me.GroupControl9.TabIndex = 107
        Me.GroupControl9.Text = "One Off Condition Codes"
        '
        'dgvOneOffConditions
        '
        Me.dgvOneOffConditions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOneOffConditions.Location = New System.Drawing.Point(2, 20)
        Me.dgvOneOffConditions.MainView = Me.gvwOneOffConditions
        Me.dgvOneOffConditions.Name = "dgvOneOffConditions"
        Me.dgvOneOffConditions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit10})
        Me.dgvOneOffConditions.Size = New System.Drawing.Size(482, 177)
        Me.dgvOneOffConditions.TabIndex = 10
        Me.dgvOneOffConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOneOffConditions})
        '
        'gvwOneOffConditions
        '
        Me.gvwOneOffConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn24, Me.GridColumn25})
        Me.gvwOneOffConditions.GridControl = Me.dgvOneOffConditions
        Me.gvwOneOffConditions.Name = "gvwOneOffConditions"
        Me.gvwOneOffConditions.OptionsBehavior.Editable = False
        Me.gvwOneOffConditions.OptionsBehavior.SmartVertScrollBar = False
        Me.gvwOneOffConditions.OptionsView.ShowGroupPanel = False
        Me.gvwOneOffConditions.RowHeight = 150
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "UniqueId"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Condition Code"
        Me.GridColumn24.FieldName = "ConditionCode"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridColumn25.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn25.Caption = "Condition Text"
        Me.GridColumn25.ColumnEdit = Me.RepositoryItemMemoEdit10
        Me.GridColumn25.FieldName = "ConditionText"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        '
        'RepositoryItemMemoEdit10
        '
        Me.RepositoryItemMemoEdit10.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit10.Name = "RepositoryItemMemoEdit10"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.btnRemoveCondition)
        Me.GroupControl5.Controls.Add(Me.dgvStandConditions)
        Me.GroupControl5.Location = New System.Drawing.Point(3, 324)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(533, 199)
        Me.GroupControl5.TabIndex = 106
        Me.GroupControl5.Text = "Standard Conditions"
        '
        'btnRemoveCondition
        '
        Me.btnRemoveCondition.Enabled = False
        Me.btnRemoveCondition.Image = CType(resources.GetObject("btnRemoveCondition.Image"), System.Drawing.Image)
        Me.btnRemoveCondition.Location = New System.Drawing.Point(866, 168)
        Me.btnRemoveCondition.Name = "btnRemoveCondition"
        Me.btnRemoveCondition.Size = New System.Drawing.Size(102, 35)
        Me.btnRemoveCondition.TabIndex = 12
        Me.btnRemoveCondition.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Condition"
        '
        'dgvStandConditions
        '
        Me.dgvStandConditions.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvStandConditions.Location = New System.Drawing.Point(2, 20)
        Me.dgvStandConditions.MainView = Me.gvwStandConditions
        Me.dgvStandConditions.Name = "dgvStandConditions"
        Me.dgvStandConditions.Size = New System.Drawing.Size(529, 176)
        Me.dgvStandConditions.TabIndex = 10
        Me.dgvStandConditions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwStandConditions})
        '
        'gvwStandConditions
        '
        Me.gvwStandConditions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn20, Me.GridColumn21, Me.GridColumn22})
        Me.gvwStandConditions.GridControl = Me.dgvStandConditions
        Me.gvwStandConditions.Name = "gvwStandConditions"
        Me.gvwStandConditions.OptionsBehavior.Editable = False
        Me.gvwStandConditions.OptionsBehavior.SmartVertScrollBar = False
        Me.gvwStandConditions.OptionsView.ShowGroupPanel = False
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "id"
        Me.GridColumn20.FieldName = "Id"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Condition"
        Me.GridColumn21.FieldName = "Condition"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        Me.GridColumn21.Width = 764
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Inserts"
        Me.GridColumn22.FieldName = "FreeFormInserts"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        Me.GridColumn22.Width = 66
        '
        'ApplicationConclreasonsTextBox
        '
        Me.ApplicationConclreasonsTextBox.Location = New System.Drawing.Point(3, 204)
        Me.ApplicationConclreasonsTextBox.Name = "ApplicationConclreasonsTextBox"
        Me.ApplicationConclreasonsTextBox.Size = New System.Drawing.Size(641, 114)
        Me.ApplicationConclreasonsTextBox.TabIndex = 105
        '
        'btnViewReco
        '
        Me.btnViewReco.Location = New System.Drawing.Point(650, 205)
        Me.btnViewReco.Name = "btnViewReco"
        Me.btnViewReco.Size = New System.Drawing.Size(54, 23)
        Me.btnViewReco.TabIndex = 100
        Me.btnViewReco.Text = "View"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(231, 549)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(148, 13)
        Me.Label129.TabIndex = 92
        Me.Label129.Text = "Proposed Determination Date"
        '
        'cboModAuthority
        '
        Me.cboModAuthority.Location = New System.Drawing.Point(105, 544)
        Me.cboModAuthority.Name = "cboModAuthority"
        Me.cboModAuthority.Properties.DisplayMember = "Description"
        Me.cboModAuthority.Properties.NullText = "[Select]"
        Me.cboModAuthority.Properties.ShowFooter = False
        Me.cboModAuthority.Properties.ShowHeader = False
        Me.cboModAuthority.Properties.ValueMember = "id"
        Me.cboModAuthority.Size = New System.Drawing.Size(121, 20)
        Me.cboModAuthority.TabIndex = 20
        '
        'cboModAssessmentDecision
        '
        Me.cboModAssessmentDecision.Location = New System.Drawing.Point(3, 143)
        Me.cboModAssessmentDecision.Name = "cboModAssessmentDecision"
        Me.cboModAssessmentDecision.Properties.NullText = "[Select]"
        Me.cboModAssessmentDecision.Properties.ShowFooter = False
        Me.cboModAssessmentDecision.Properties.ShowHeader = False
        Me.cboModAssessmentDecision.Size = New System.Drawing.Size(117, 20)
        Me.cboModAssessmentDecision.TabIndex = 2
        '
        'cboModSec79Satisfactory
        '
        Me.cboModSec79Satisfactory.Location = New System.Drawing.Point(179, 53)
        Me.cboModSec79Satisfactory.Name = "cboModSec79Satisfactory"
        Me.cboModSec79Satisfactory.Properties.NullText = "[Select One]"
        Me.cboModSec79Satisfactory.Properties.ShowFooter = False
        Me.cboModSec79Satisfactory.Properties.ShowHeader = False
        Me.cboModSec79Satisfactory.Size = New System.Drawing.Size(117, 20)
        Me.cboModSec79Satisfactory.TabIndex = 1
        '
        'cboModSec96Comply
        '
        Me.cboModSec96Comply.Location = New System.Drawing.Point(179, 26)
        Me.cboModSec96Comply.Name = "cboModSec96Comply"
        Me.cboModSec96Comply.Properties.NullText = "{Select One]"
        Me.cboModSec96Comply.Properties.ShowFooter = False
        Me.cboModSec96Comply.Properties.ShowHeader = False
        Me.cboModSec96Comply.Size = New System.Drawing.Size(142, 20)
        Me.cboModSec96Comply.TabIndex = 0
        '
        'lblRecommendTwo
        '
        Me.lblRecommendTwo.Location = New System.Drawing.Point(0, 167)
        Me.lblRecommendTwo.Name = "lblRecommendTwo"
        Me.lblRecommendTwo.Size = New System.Drawing.Size(644, 38)
        Me.lblRecommendTwo.TabIndex = 1
        Me.lblRecommendTwo.Text = resources.GetString("lblRecommendTwo.Text")
        '
        'lblRecommendation
        '
        Me.lblRecommendation.Location = New System.Drawing.Point(0, 110)
        Me.lblRecommendation.Name = "lblRecommendation"
        Me.lblRecommendation.Size = New System.Drawing.Size(644, 38)
        Me.lblRecommendation.TabIndex = 1
        Me.lblRecommendation.Text = resources.GetString("lblRecommendation.Text")
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(302, 56)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(299, 13)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "upon review of Section 79C (1) and Section 94 Consideration"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(333, 29)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(233, 13)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "with the requirments of Section 96 under which"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(0, 56)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(177, 13)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Council can modify a consent and is"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(0, 29)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(175, 13)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "The modification of consent sought"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Black
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(6, 542)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(91, 23)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Authority:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Black
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(3, 78)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(140, 23)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Recommendation:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Black
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(6, 6)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 23)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Conclusion:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpgPlans
        '
        Me.tpgPlans.Controls.Add(Me.PanelControl2)
        Me.tpgPlans.Image = CType(resources.GetObject("tpgPlans.Image"), System.Drawing.Image)
        Me.tpgPlans.Name = "tpgPlans"
        Me.tpgPlans.Size = New System.Drawing.Size(1389, 761)
        Me.tpgPlans.Text = "Plans"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnFinalisePlan)
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.btnSavePlan)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Controls.Add(Me.btnPDF)
        Me.PanelControl2.Controls.Add(Me.btnFindPlan)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1389, 761)
        Me.PanelControl2.TabIndex = 0
        '
        'btnFinalisePlan
        '
        Me.btnFinalisePlan.Enabled = False
        Me.btnFinalisePlan.Image = CType(resources.GetObject("btnFinalisePlan.Image"), System.Drawing.Image)
        Me.btnFinalisePlan.Location = New System.Drawing.Point(152, 306)
        Me.btnFinalisePlan.Name = "btnFinalisePlan"
        Me.btnFinalisePlan.Size = New System.Drawing.Size(108, 37)
        Me.btnFinalisePlan.TabIndex = 29
        Me.btnFinalisePlan.Text = "Finalise"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PdfViewer)
        Me.PanelControl3.Controls.Add(Me.RibbonControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(269, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1118, 757)
        Me.PanelControl3.TabIndex = 6
        '
        'PdfViewer
        '
        Me.PdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewer.Location = New System.Drawing.Point(2, 97)
        Me.PdfViewer.MenuManager = Me.BarManager1
        Me.PdfViewer.Name = "PdfViewer"
        Me.PdfViewer.Size = New System.Drawing.Size(1114, 658)
        Me.PdfViewer.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PdfFileOpenBarItem1, Me.PdfFileSaveAsBarItem1, Me.PdfFilePrintBarItem1, Me.PdfPreviousPageBarItem1, Me.PdfNextPageBarItem1, Me.PdfFindTextBarItem1, Me.PdfZoomOutBarItem1, Me.PdfZoomInBarItem1, Me.PdfExactZoomListBarSubItem1, Me.PdfZoom10CheckItem1, Me.PdfZoom25CheckItem1, Me.PdfZoom50CheckItem1, Me.PdfZoom75CheckItem1, Me.PdfZoom100CheckItem1, Me.PdfZoom125CheckItem1, Me.PdfZoom150CheckItem1, Me.PdfZoom200CheckItem1, Me.PdfZoom400CheckItem1, Me.PdfZoom500CheckItem1, Me.PdfSetActualSizeZoomModeCheckItem1, Me.PdfSetPageLevelZoomModeCheckItem1, Me.PdfSetFitWidthZoomModeCheckItem1, Me.PdfSetFitVisibleZoomModeCheckItem1, Me.PdfExportFormDataBarItem1, Me.PdfImportFormDataBarItem1})
        Me.BarManager1.MaxItemId = 25
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1395, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 855)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1395, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 855)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1395, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 855)
        '
        'PdfFileOpenBarItem1
        '
        Me.PdfFileOpenBarItem1.Id = 24
        Me.PdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
        Me.PdfFileOpenBarItem1.Name = "PdfFileOpenBarItem1"
        '
        'PdfFileSaveAsBarItem1
        '
        Me.PdfFileSaveAsBarItem1.Id = 0
        Me.PdfFileSaveAsBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.PdfFileSaveAsBarItem1.Name = "PdfFileSaveAsBarItem1"
        '
        'PdfFilePrintBarItem1
        '
        Me.PdfFilePrintBarItem1.Id = 1
        Me.PdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.PdfFilePrintBarItem1.Name = "PdfFilePrintBarItem1"
        '
        'PdfPreviousPageBarItem1
        '
        Me.PdfPreviousPageBarItem1.Id = 2
        Me.PdfPreviousPageBarItem1.Name = "PdfPreviousPageBarItem1"
        '
        'PdfNextPageBarItem1
        '
        Me.PdfNextPageBarItem1.Id = 3
        Me.PdfNextPageBarItem1.Name = "PdfNextPageBarItem1"
        '
        'PdfFindTextBarItem1
        '
        Me.PdfFindTextBarItem1.Id = 4
        Me.PdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.PdfFindTextBarItem1.Name = "PdfFindTextBarItem1"
        '
        'PdfZoomOutBarItem1
        '
        Me.PdfZoomOutBarItem1.Id = 5
        Me.PdfZoomOutBarItem1.Name = "PdfZoomOutBarItem1"
        '
        'PdfZoomInBarItem1
        '
        Me.PdfZoomInBarItem1.Id = 6
        Me.PdfZoomInBarItem1.Name = "PdfZoomInBarItem1"
        '
        'PdfExactZoomListBarSubItem1
        '
        Me.PdfExactZoomListBarSubItem1.Id = 7
        Me.PdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom10CheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom25CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom50CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom75CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom100CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom125CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom150CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom200CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom400CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom500CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetActualSizeZoomModeCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageLevelZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitWidthZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitVisibleZoomModeCheckItem1)})
        Me.PdfExactZoomListBarSubItem1.Name = "PdfExactZoomListBarSubItem1"
        Me.PdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'PdfZoom10CheckItem1
        '
        Me.PdfZoom10CheckItem1.Id = 8
        Me.PdfZoom10CheckItem1.Name = "PdfZoom10CheckItem1"
        '
        'PdfZoom25CheckItem1
        '
        Me.PdfZoom25CheckItem1.Id = 9
        Me.PdfZoom25CheckItem1.Name = "PdfZoom25CheckItem1"
        '
        'PdfZoom50CheckItem1
        '
        Me.PdfZoom50CheckItem1.Id = 10
        Me.PdfZoom50CheckItem1.Name = "PdfZoom50CheckItem1"
        '
        'PdfZoom75CheckItem1
        '
        Me.PdfZoom75CheckItem1.Id = 11
        Me.PdfZoom75CheckItem1.Name = "PdfZoom75CheckItem1"
        '
        'PdfZoom100CheckItem1
        '
        Me.PdfZoom100CheckItem1.Id = 12
        Me.PdfZoom100CheckItem1.Name = "PdfZoom100CheckItem1"
        '
        'PdfZoom125CheckItem1
        '
        Me.PdfZoom125CheckItem1.Id = 13
        Me.PdfZoom125CheckItem1.Name = "PdfZoom125CheckItem1"
        '
        'PdfZoom150CheckItem1
        '
        Me.PdfZoom150CheckItem1.Id = 14
        Me.PdfZoom150CheckItem1.Name = "PdfZoom150CheckItem1"
        '
        'PdfZoom200CheckItem1
        '
        Me.PdfZoom200CheckItem1.Id = 15
        Me.PdfZoom200CheckItem1.Name = "PdfZoom200CheckItem1"
        '
        'PdfZoom400CheckItem1
        '
        Me.PdfZoom400CheckItem1.Id = 16
        Me.PdfZoom400CheckItem1.Name = "PdfZoom400CheckItem1"
        '
        'PdfZoom500CheckItem1
        '
        Me.PdfZoom500CheckItem1.Id = 17
        Me.PdfZoom500CheckItem1.Name = "PdfZoom500CheckItem1"
        '
        'PdfSetActualSizeZoomModeCheckItem1
        '
        Me.PdfSetActualSizeZoomModeCheckItem1.Id = 18
        Me.PdfSetActualSizeZoomModeCheckItem1.Name = "PdfSetActualSizeZoomModeCheckItem1"
        '
        'PdfSetPageLevelZoomModeCheckItem1
        '
        Me.PdfSetPageLevelZoomModeCheckItem1.Id = 19
        Me.PdfSetPageLevelZoomModeCheckItem1.Name = "PdfSetPageLevelZoomModeCheckItem1"
        '
        'PdfSetFitWidthZoomModeCheckItem1
        '
        Me.PdfSetFitWidthZoomModeCheckItem1.Id = 20
        Me.PdfSetFitWidthZoomModeCheckItem1.Name = "PdfSetFitWidthZoomModeCheckItem1"
        '
        'PdfSetFitVisibleZoomModeCheckItem1
        '
        Me.PdfSetFitVisibleZoomModeCheckItem1.Id = 21
        Me.PdfSetFitVisibleZoomModeCheckItem1.Name = "PdfSetFitVisibleZoomModeCheckItem1"
        '
        'PdfExportFormDataBarItem1
        '
        Me.PdfExportFormDataBarItem1.Id = 22
        Me.PdfExportFormDataBarItem1.Name = "PdfExportFormDataBarItem1"
        '
        'PdfImportFormDataBarItem1
        '
        Me.PdfImportFormDataBarItem1.Id = 23
        Me.PdfImportFormDataBarItem1.Name = "PdfImportFormDataBarItem1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.PdfFileOpenBarItem2, Me.PdfFileSaveAsBarItem2, Me.PdfFilePrintBarItem2, Me.PdfPreviousPageBarItem2, Me.PdfNextPageBarItem2, Me.PdfZoomOutBarItem2, Me.PdfZoomInBarItem2, Me.PdfExactZoomListBarSubItem2, Me.PdfZoom10CheckItem2, Me.PdfZoom25CheckItem2, Me.PdfZoom50CheckItem2, Me.PdfZoom75CheckItem2, Me.PdfZoom100CheckItem2, Me.PdfZoom125CheckItem2, Me.PdfZoom150CheckItem2, Me.PdfZoom200CheckItem2, Me.PdfZoom400CheckItem2, Me.PdfZoom500CheckItem2, Me.PdfSetActualSizeZoomModeCheckItem2, Me.PdfSetPageLevelZoomModeCheckItem2, Me.PdfSetFitWidthZoomModeCheckItem2, Me.PdfSetFitVisibleZoomModeCheckItem2, Me.PdfExportFormDataBarItem2, Me.PdfImportFormDataBarItem2})
        Me.RibbonControl1.Location = New System.Drawing.Point(2, 2)
        Me.RibbonControl1.MaxItemId = 26
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PdfRibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1114, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'PdfFileOpenBarItem2
        '
        Me.PdfFileOpenBarItem2.Id = 1
        Me.PdfFileOpenBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
        Me.PdfFileOpenBarItem2.Name = "PdfFileOpenBarItem2"
        '
        'PdfFileSaveAsBarItem2
        '
        Me.PdfFileSaveAsBarItem2.Id = 2
        Me.PdfFileSaveAsBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.PdfFileSaveAsBarItem2.Name = "PdfFileSaveAsBarItem2"
        '
        'PdfFilePrintBarItem2
        '
        Me.PdfFilePrintBarItem2.Id = 3
        Me.PdfFilePrintBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.PdfFilePrintBarItem2.Name = "PdfFilePrintBarItem2"
        '
        'PdfPreviousPageBarItem2
        '
        Me.PdfPreviousPageBarItem2.Id = 4
        Me.PdfPreviousPageBarItem2.Name = "PdfPreviousPageBarItem2"
        '
        'PdfNextPageBarItem2
        '
        Me.PdfNextPageBarItem2.Id = 5
        Me.PdfNextPageBarItem2.Name = "PdfNextPageBarItem2"
        '
        'PdfZoomOutBarItem2
        '
        Me.PdfZoomOutBarItem2.Id = 7
        Me.PdfZoomOutBarItem2.Name = "PdfZoomOutBarItem2"
        '
        'PdfZoomInBarItem2
        '
        Me.PdfZoomInBarItem2.Id = 8
        Me.PdfZoomInBarItem2.Name = "PdfZoomInBarItem2"
        '
        'PdfExactZoomListBarSubItem2
        '
        Me.PdfExactZoomListBarSubItem2.Id = 9
        Me.PdfExactZoomListBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom10CheckItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom25CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom50CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom75CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom100CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom125CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom150CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom200CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom400CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom500CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetActualSizeZoomModeCheckItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageLevelZoomModeCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitWidthZoomModeCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitVisibleZoomModeCheckItem2)})
        Me.PdfExactZoomListBarSubItem2.Name = "PdfExactZoomListBarSubItem2"
        Me.PdfExactZoomListBarSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'PdfZoom10CheckItem2
        '
        Me.PdfZoom10CheckItem2.Id = 10
        Me.PdfZoom10CheckItem2.Name = "PdfZoom10CheckItem2"
        '
        'PdfZoom25CheckItem2
        '
        Me.PdfZoom25CheckItem2.Id = 11
        Me.PdfZoom25CheckItem2.Name = "PdfZoom25CheckItem2"
        '
        'PdfZoom50CheckItem2
        '
        Me.PdfZoom50CheckItem2.Id = 12
        Me.PdfZoom50CheckItem2.Name = "PdfZoom50CheckItem2"
        '
        'PdfZoom75CheckItem2
        '
        Me.PdfZoom75CheckItem2.Id = 13
        Me.PdfZoom75CheckItem2.Name = "PdfZoom75CheckItem2"
        '
        'PdfZoom100CheckItem2
        '
        Me.PdfZoom100CheckItem2.Id = 14
        Me.PdfZoom100CheckItem2.Name = "PdfZoom100CheckItem2"
        '
        'PdfZoom125CheckItem2
        '
        Me.PdfZoom125CheckItem2.Id = 15
        Me.PdfZoom125CheckItem2.Name = "PdfZoom125CheckItem2"
        '
        'PdfZoom150CheckItem2
        '
        Me.PdfZoom150CheckItem2.Id = 16
        Me.PdfZoom150CheckItem2.Name = "PdfZoom150CheckItem2"
        '
        'PdfZoom200CheckItem2
        '
        Me.PdfZoom200CheckItem2.Id = 17
        Me.PdfZoom200CheckItem2.Name = "PdfZoom200CheckItem2"
        '
        'PdfZoom400CheckItem2
        '
        Me.PdfZoom400CheckItem2.Id = 18
        Me.PdfZoom400CheckItem2.Name = "PdfZoom400CheckItem2"
        '
        'PdfZoom500CheckItem2
        '
        Me.PdfZoom500CheckItem2.Id = 19
        Me.PdfZoom500CheckItem2.Name = "PdfZoom500CheckItem2"
        '
        'PdfSetActualSizeZoomModeCheckItem2
        '
        Me.PdfSetActualSizeZoomModeCheckItem2.Id = 20
        Me.PdfSetActualSizeZoomModeCheckItem2.Name = "PdfSetActualSizeZoomModeCheckItem2"
        '
        'PdfSetPageLevelZoomModeCheckItem2
        '
        Me.PdfSetPageLevelZoomModeCheckItem2.Id = 21
        Me.PdfSetPageLevelZoomModeCheckItem2.Name = "PdfSetPageLevelZoomModeCheckItem2"
        '
        'PdfSetFitWidthZoomModeCheckItem2
        '
        Me.PdfSetFitWidthZoomModeCheckItem2.Id = 22
        Me.PdfSetFitWidthZoomModeCheckItem2.Name = "PdfSetFitWidthZoomModeCheckItem2"
        '
        'PdfSetFitVisibleZoomModeCheckItem2
        '
        Me.PdfSetFitVisibleZoomModeCheckItem2.Id = 23
        Me.PdfSetFitVisibleZoomModeCheckItem2.Name = "PdfSetFitVisibleZoomModeCheckItem2"
        '
        'PdfExportFormDataBarItem2
        '
        Me.PdfExportFormDataBarItem2.Id = 24
        Me.PdfExportFormDataBarItem2.Name = "PdfExportFormDataBarItem2"
        '
        'PdfImportFormDataBarItem2
        '
        Me.PdfImportFormDataBarItem2.Id = 25
        Me.PdfImportFormDataBarItem2.Name = "PdfImportFormDataBarItem2"
        '
        'PdfRibbonPage1
        '
        Me.PdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PdfNavigationRibbonPageGroup1, Me.PdfZoomRibbonPageGroup1})
        Me.PdfRibbonPage1.Name = "PdfRibbonPage1"
        '
        'PdfNavigationRibbonPageGroup1
        '
        Me.PdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.PdfPreviousPageBarItem2)
        Me.PdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.PdfNextPageBarItem2)
        Me.PdfNavigationRibbonPageGroup1.Name = "PdfNavigationRibbonPageGroup1"
        '
        'PdfZoomRibbonPageGroup1
        '
        Me.PdfZoomRibbonPageGroup1.ItemLinks.Add(Me.PdfZoomOutBarItem2)
        Me.PdfZoomRibbonPageGroup1.ItemLinks.Add(Me.PdfZoomInBarItem2)
        Me.PdfZoomRibbonPageGroup1.ItemLinks.Add(Me.PdfExactZoomListBarSubItem2)
        Me.PdfZoomRibbonPageGroup1.Name = "PdfZoomRibbonPageGroup1"
        '
        'btnSavePlan
        '
        Me.btnSavePlan.Enabled = False
        Me.btnSavePlan.Image = CType(resources.GetObject("btnSavePlan.Image"), System.Drawing.Image)
        Me.btnSavePlan.Location = New System.Drawing.Point(147, 15)
        Me.btnSavePlan.Name = "btnSavePlan"
        Me.btnSavePlan.Size = New System.Drawing.Size(115, 36)
        Me.btnSavePlan.TabIndex = 5
        Me.btnSavePlan.Text = "Save Plan"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grdPlans)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 60)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(251, 241)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Plans Attached"
        '
        'grdPlans
        '
        Me.grdPlans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPlans.Location = New System.Drawing.Point(2, 20)
        Me.grdPlans.MainView = Me.gvwPlans
        Me.grdPlans.Name = "grdPlans"
        Me.grdPlans.Size = New System.Drawing.Size(247, 219)
        Me.grdPlans.TabIndex = 3
        Me.grdPlans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPlans})
        '
        'gvwPlans
        '
        Me.gvwPlans.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPlanName, Me.colInEASE, Me.colDocId, Me.GridColumn26})
        Me.gvwPlans.GridControl = Me.grdPlans
        Me.gvwPlans.Name = "gvwPlans"
        Me.gvwPlans.OptionsBehavior.Editable = False
        Me.gvwPlans.OptionsBehavior.ReadOnly = True
        Me.gvwPlans.OptionsView.ShowGroupPanel = False
        '
        'colPlanName
        '
        Me.colPlanName.Caption = "Plan File Name"
        Me.colPlanName.FieldName = "PlanName"
        Me.colPlanName.Name = "colPlanName"
        Me.colPlanName.Visible = True
        Me.colPlanName.VisibleIndex = 0
        '
        'colInEASE
        '
        Me.colInEASE.Caption = "inEASE"
        Me.colInEASE.FieldName = "InEASE"
        Me.colInEASE.Name = "colInEASE"
        '
        'colDocId
        '
        Me.colDocId.Caption = "DocId"
        Me.colDocId.FieldName = "DocId"
        Me.colDocId.Name = "colDocId"
        '
        'btnPDF
        '
        Me.btnPDF.Enabled = False
        Me.btnPDF.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.Adobe_Acrobat_Reader
        Me.btnPDF.Location = New System.Drawing.Point(11, 307)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(115, 36)
        Me.btnPDF.TabIndex = 2
        Me.btnPDF.Text = "Open Plan"
        '
        'btnFindPlan
        '
        Me.btnFindPlan.Image = CType(resources.GetObject("btnFindPlan.Image"), System.Drawing.Image)
        Me.btnFindPlan.Location = New System.Drawing.Point(11, 15)
        Me.btnFindPlan.Name = "btnFindPlan"
        Me.btnFindPlan.Size = New System.Drawing.Size(115, 36)
        Me.btnFindPlan.TabIndex = 1
        Me.btnFindPlan.Text = "Locate Plan"
        '
        'PdfBarController1
        '
        Me.PdfBarController1.BarItems.Add(Me.PdfFileOpenBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFileSaveAsBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFilePrintBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfPreviousPageBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfNextPageBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFindTextBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomOutBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomInBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfExactZoomListBarSubItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom10CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom25CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom50CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom75CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom100CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom125CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom150CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom200CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom400CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom500CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetActualSizeZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetPageLevelZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitWidthZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitVisibleZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfExportFormDataBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfImportFormDataBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFileOpenBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfFileSaveAsBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfFilePrintBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfPreviousPageBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfNextPageBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomOutBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomInBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfExactZoomListBarSubItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom10CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom25CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom50CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom75CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom100CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom125CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom150CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom200CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom400CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom500CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetActualSizeZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetPageLevelZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitWidthZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitVisibleZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfExportFormDataBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfImportFormDataBarItem2)
        Me.PdfBarController1.Control = Me.PdfViewer
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "idx"
        Me.GridColumn26.FieldName = "PlanIDX"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'NewAssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 855)
        Me.Controls.Add(Me.tabAssessment)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NewAssessmentForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Assessment "
        CType(Me.RepositoryItemMemoEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.tabAssessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAssessment.ResumeLayout(False)
        Me.tpgHistory.ResumeLayout(False)
        CType(Me.pnlDisplayHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayHistory.ResumeLayout(False)
        Me.pnlDisplayHistory.PerformLayout()
        CType(Me.grpHistoricalDA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHistoricalDA.ResumeLayout(False)
        CType(Me.grdHistoricalDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwHistoricalDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHisDa.ResumeLayout(False)
        Me.grpHisDa.PerformLayout()
        CType(Me.cboActedOn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevHistoryCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxAssessmentRept.ResumeLayout(False)
        Me.gbxAssessmentRept.PerformLayout()
        Me.tpgStatutory.ResumeLayout(False)
        CType(Me.pnlDisplayStatutory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayStatutory.ResumeLayout(False)
        Me.pnlDisplayStatutory.PerformLayout()
        CType(Me.txtOther79Cissues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.picSubDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSustain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLandscape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeritage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTraffic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThreaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGenImpacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.picDCPchkList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDAMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGUIDES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSEPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picREP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgVariations.ResumeLayout(False)
        CType(Me.pnlDisplayVariations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayVariations.ResumeLayout(False)
        CType(Me.grdVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.variationDecisionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.variationDecisionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVariationResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVariationAuthority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVariations.ResumeLayout(False)
        Me.grpVariations.PerformLayout()
        CType(Me.txtOfficersReasons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariationDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOfficerRecomforVariation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVariationType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgContributions.ResumeLayout(False)
        CType(Me.pnlDisplayContributions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayContributions.ResumeLayout(False)
        Me.pnlDisplayContributions.PerformLayout()
        CType(Me.GroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txt64Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboS64Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt64Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContribType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSection64Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grdProposedBondContrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwProposedBondContrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grdSection94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSection94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdSection64Contributions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSection64Contributions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgModifications.ResumeLayout(False)
        CType(Me.pnlDisplayModifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayModifications.ResumeLayout(False)
        Me.pnlDisplayModifications.PerformLayout()
        CType(Me.grpMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMod.ResumeLayout(False)
        Me.scrolModification.ResumeLayout(False)
        Me.scrolModification.PerformLayout()
        CType(Me.pnlMod1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMod1.ResumeLayout(False)
        Me.pnlMod1.PerformLayout()
        CType(Me.ModSect94CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModSect79cCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModSect94YNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modsect79cYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMod1A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMod1A.ResumeLayout(False)
        Me.pnlMod1A.PerformLayout()
        CType(Me.ModMinEnvImpCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModMinEnvImpactYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSect96.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModDetailsTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModReasonTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMod1andMod2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMod1andMod2.ResumeLayout(False)
        Me.pnlMod1andMod2.PerformLayout()
        CType(Me.ModSubStSameCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModSubmConsYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModNotificationYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModSubstSameYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMod2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMod2.ResumeLayout(False)
        Me.pnlMod2.PerformLayout()
        CType(Me.ModThreatCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModThreatComplYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModThreatSpecYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModMinisterOBjYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModConsMinisterYNComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModMinisterCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgConclusion.ResumeLayout(False)
        CType(Me.pnlDisplayConclusions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayConclusions.ResumeLayout(False)
        Me.pnlDisplayConclusions.PerformLayout()
        Me.scrolMainConclusion.ResumeLayout(False)
        CType(Me.pnlConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConclusion.ResumeLayout(False)
        Me.pnlConclusion.PerformLayout()
        CType(Me.dteConclusionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteConclusionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConditionText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOneUpConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSTDConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdConclusionVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwConclusionVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApplicationConclreasons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplianceStatProvCommentsTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariationComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAuthority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboReferralsYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboComplianceStatProvYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVariationsYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboApplicationConclResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabel.ResumeLayout(False)
        CType(Me.pnlModificationConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModificationConclusion.ResumeLayout(False)
        Me.pnlModificationConclusion.PerformLayout()
        CType(Me.dteProposedDetermDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteProposedDetermDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.dgvOneOffConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOneOffConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.dgvStandConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwStandConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationConclreasonsTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModAuthority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSec79Satisfactory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSec96Comply.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgPlans.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdPlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabAssessment As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpgHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgStatutory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgVariations As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgContributions As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgModifications As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpgConclusion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlDisplayStatutory As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave79 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit79 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents picSubDivision As PictureBox
    Friend WithEvents picSustain As PictureBox
    Friend WithEvents picLandscape As PictureBox
    Friend WithEvents picHeritage As PictureBox
    Friend WithEvents picDDA As PictureBox
    Friend WithEvents btnSubdivision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSustainability As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLandscaping As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHeritage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDisabDiscrimAct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picSocial As PictureBox
    Friend WithEvents picTraffic As PictureBox
    Friend WithEvents picThreaten As PictureBox
    Friend WithEvents picDP As PictureBox
    Friend WithEvents picGenImpacts As PictureBox
    Friend WithEvents btnSocialEconomic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTraficCarParks As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThreatenSpecies As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDepositedPlan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGenImpacts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents picDCPchkList As PictureBox
    Friend WithEvents picDAMS As PictureBox
    Friend WithEvents picDCP As PictureBox
    Friend WithEvents picGUIDES As PictureBox
    Friend WithEvents picSEPP As PictureBox
    Friend WithEvents picLEP As PictureBox
    Friend WithEvents picREP As PictureBox
    Friend WithEvents btnDams As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDCPCheckList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnREP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDCP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuidLines As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSepp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLEP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlDisplayHistory As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblAssessmentReportEased As Label
    Friend WithEvents gbxAssessmentRept As GroupBox
    Friend WithEvents lblAssessmentreport As Label
    Friend WithEvents btnFinaliseDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewEditDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDevHistComment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRetrievePreviousDAHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpHisDa As GroupBox
    Friend WithEvents btnViewDa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpDateHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboActedOn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDAno As Label
    Friend WithEvents pnlDisplayConclusions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlModificationConclusion As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnViewReco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label129 As Label
    Friend WithEvents cboModAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModAssessmentDecision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModSec79Satisfactory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModSec96Comply As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRecommendTwo As Label
    Friend WithEvents lblRecommendation As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblConclusion As Label
    Friend WithEvents scrolMainConclusion As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents btnViewConclusion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewComplainceReason As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label80 As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents cboAssessmentDecision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboApplicationConclResult As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVariationsYesNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboComplianceStatProvYesNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboReferralsYesNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label127 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents pnlDisplayModifications As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUpdateModData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdateModDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblModeType As Label
    Friend WithEvents scrolModification As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents pnlMod1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label22 As Label
    Friend WithEvents ModSect94YNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Modsect79cYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlMod1A As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ModMinEnvImpactYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlMod2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ModThreatComplYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ModThreatSpecYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ModMinisterOBjYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ModConsMinisterYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModSect96 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlMod1andMod2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ModSubmConsYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ModNotificationYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ModSubstSameYNComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlDisplayContributions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt64Amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboS64Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnInsertNewSection64 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt64Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboContribType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboSection64Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnRemoveBond As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove94 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove64 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlDisplayVariations As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSaveVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btneditVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label99 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents grpVariations As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnAddVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label131 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents cboOfficerRecomforVariation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVariationType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents lblapplicationNo As Label
    Friend WithEvents lblDetermineDate As Label
    Friend WithEvents btnPrintAssessment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboVariationAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVariationResult As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grdVariations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwVariations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents coldetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariationResultDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelegatedAuthority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDecisionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssReasons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colUserStamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResultCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents pnlLabel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlConclusion As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DevHistoryCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtOther79Cissues As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtOfficersReasons As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtVariationDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModSect94CommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModSect79cCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModMinEnvImpCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModThreatCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModMinisterCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModSubStSameCommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtApplicationConclreasons As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ComplianceStatProvCommentsTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtVariationComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ApplicationConclreasonsTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CommentTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents grpMod As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ModDetailsTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ModReasonTextBox As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents grdHistoricalDA As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwHistoricalDA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrevDANo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProposal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colDecision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_DecisionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grpHistoricalDA As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdProposedBondContrib As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwProposedBondContrib As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdSection94 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSection94 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdSection64Contributions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSection64Contributions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colS94ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94Plan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94ContCalc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94CalcNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94Type As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents grdConclusionVariations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwConclusionVariations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSTDConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents costdlId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdCondition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreeFormInserts As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvConditionText As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOneUpConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUniqueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConditionCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConditionText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRemoveCondition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvStandConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwStandConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvOneOffConditions As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOneOffConditions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnUpdateConclusion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveVariation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents variationDecisionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteConclusionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteProposedDetermDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnLockAssessment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tpgPlans As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPlans As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwPlans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindPlan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PdfViewer As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents btnSavePlan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents PdfFileSaveAsBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
    Friend WithEvents PdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
    Friend WithEvents PdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
    Friend WithEvents PdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
    Friend WithEvents PdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
    Friend WithEvents PdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
    Friend WithEvents PdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
    Friend WithEvents PdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
    Friend WithEvents PdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
    Friend WithEvents PdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
    Friend WithEvents PdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
    Friend WithEvents PdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
    Friend WithEvents PdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
    Friend WithEvents PdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
    Friend WithEvents PdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
    Friend WithEvents PdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
    Friend WithEvents PdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
    Friend WithEvents PdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
    Friend WithEvents PdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
    Friend WithEvents PdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
    Friend WithEvents PdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
    Friend WithEvents PdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
    Friend WithEvents PdfExportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem
    Friend WithEvents PdfImportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
    Friend WithEvents colPlanName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents PdfFileOpenBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
    Friend WithEvents PdfFileSaveAsBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
    Friend WithEvents PdfFilePrintBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
    Friend WithEvents PdfPreviousPageBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
    Friend WithEvents PdfNextPageBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
    Friend WithEvents PdfZoomOutBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
    Friend WithEvents PdfZoomInBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
    Friend WithEvents PdfExactZoomListBarSubItem2 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
    Friend WithEvents PdfZoom10CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
    Friend WithEvents PdfZoom25CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
    Friend WithEvents PdfZoom50CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
    Friend WithEvents PdfZoom75CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
    Friend WithEvents PdfZoom100CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
    Friend WithEvents PdfZoom125CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
    Friend WithEvents PdfZoom150CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
    Friend WithEvents PdfZoom200CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
    Friend WithEvents PdfZoom400CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
    Friend WithEvents PdfZoom500CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
    Friend WithEvents PdfSetActualSizeZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
    Friend WithEvents PdfSetPageLevelZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
    Friend WithEvents PdfSetFitWidthZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
    Friend WithEvents PdfSetFitVisibleZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
    Friend WithEvents PdfExportFormDataBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem
    Friend WithEvents PdfImportFormDataBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem
    Friend WithEvents PdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage
    Friend WithEvents PdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup
    Friend WithEvents PdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup
    Friend WithEvents btnFinalisePlan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colInEASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
End Class
