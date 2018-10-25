<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestAssessmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestAssessmentForm))
        Dim ModSubmConsYNLabel As System.Windows.Forms.Label
        Dim ModNotificationYNLabel As System.Windows.Forms.Label
        Dim ModSubStSameCommentLabel As System.Windows.Forms.Label
        Dim ModSubstSameYNLabel As System.Windows.Forms.Label
        Dim ModReasonLabel As System.Windows.Forms.Label
        Dim ModDetailsLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnPrintAssessment = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDetermineDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblapplicationNo = New System.Windows.Forms.Label()
        Me.tabAssessment = New DevExpress.XtraTab.XtraTabControl()
        Me.tpgHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlDisplayHistory = New DevExpress.XtraEditors.PanelControl()
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
        Me.DevHistoryCommentTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblAssessmentReportEased = New System.Windows.Forms.Label()
        Me.gbxAssessmentRept = New System.Windows.Forms.GroupBox()
        Me.lblAssessmentreport = New System.Windows.Forms.Label()
        Me.btnFinaliseDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewEditDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveDevHistComment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRetrievePreviousDAHistory = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewDa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpDateHistory = New DevExpress.XtraEditors.SimpleButton()
        Me.cboActedOn = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDAno = New System.Windows.Forms.Label()
        Me.CommentTextBox = New DevExpress.XtraEditors.MemoEdit()
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
        Me.cboVariationResult = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVariationAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSaveVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.btneditVariationResponse = New DevExpress.XtraEditors.SimpleButton()
        Me.variationDecisionDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.btnDecisionDate = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
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
        Me.btnRemoveBond = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove94 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove64 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvProposedBondContrib = New System.Windows.Forms.DataGridView()
        Me.dgvBondid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBondProposed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBondAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBondNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBondType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection94 = New System.Windows.Forms.DataGridView()
        Me.dgvSection94Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection94ProposeSec94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection94Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection94Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection94Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSection64Contributions = New System.Windows.Forms.DataGridView()
        Me.dgvSec64Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSec64ProposedSec64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSec64Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSec64Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSec64Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.txtApplicationConclreasons = New DevExpress.XtraEditors.MemoEdit()
        Me.ComplianceStatProvCommentsTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.txtVariationComment = New DevExpress.XtraEditors.MemoEdit()
        Me.Button11 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnViewConclusion = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConclusionDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnViewComplainceReason = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvConditionText = New System.Windows.Forms.DataGridView()
        Me.cntConditionCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cntConditionText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cntId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.dgvConditions = New System.Windows.Forms.DataGridView()
        Me.condId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condConditions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condInsert = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvConclusionVariations = New System.Windows.Forms.DataGridView()
        Me.conID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conVariation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conAuthority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssReasons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conUserStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlModificationConclusion = New DevExpress.XtraEditors.PanelControl()
        Me.ApplicationConclreasonsTextBox = New DevExpress.XtraEditors.MemoEdit()
        Me.btnViewReco = New DevExpress.XtraEditors.SimpleButton()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.btnProposedDetermDate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProposedDetermDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboModAuthority = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgvOneOffConditions = New System.Windows.Forms.DataGridView()
        Me.dgvOneOffConditionsConditionCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvOneOffConditionsConditionText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStandConditions = New System.Windows.Forms.DataGridView()
        Me.dgvStdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStdConditions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStdInserts = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cboModAssessmentDecision = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModSec79Satisfactory = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboModSec96Comply = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblRecommendTwo = New System.Windows.Forms.Label()
        Me.lblRecommendation = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.pnlLabel = New DevExpress.XtraEditors.PanelControl()
        Me.btnUpdateConclusion = New DevExpress.XtraEditors.SimpleButton()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.tabAssessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAssessment.SuspendLayout()
        Me.tpgHistory.SuspendLayout()
        CType(Me.pnlDisplayHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayHistory.SuspendLayout()
        CType(Me.grdHistoricalDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwHistoricalDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevHistoryCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbxAssessmentRept.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cboActedOn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox4.SuspendLayout()
        CType(Me.txt64Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboS64Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt64Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboContribType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSection64Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProposedBondContrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSection94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSection64Contributions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtApplicationConclreasons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplianceStatProvCommentsTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariationComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAuthority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConditionText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConclusionVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboReferralsYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboComplianceStatProvYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVariationsYesNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboApplicationConclResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlModificationConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModificationConclusion.SuspendLayout()
        CType(Me.ApplicationConclreasonsTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModAuthority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOneOffConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStandConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSec79Satisfactory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModSec96Comply.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLabel.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
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
        Label128.Location = New System.Drawing.Point(5, 152)
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
        'PanelControl1
        '
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
        'btnPrintAssessment
        '
        Me.btnPrintAssessment.Image = CType(resources.GetObject("btnPrintAssessment.Image"), System.Drawing.Image)
        Me.btnPrintAssessment.Location = New System.Drawing.Point(962, 7)
        Me.btnPrintAssessment.Name = "btnPrintAssessment"
        Me.btnPrintAssessment.Size = New System.Drawing.Size(131, 34)
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
        Me.tabAssessment.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpgHistory, Me.tpgStatutory, Me.tpgVariations, Me.tpgContributions, Me.tpgModifications, Me.tpgConclusion})
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
        Me.pnlDisplayHistory.Controls.Add(Me.GroupControl1)
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
        'btnRetrievePreviousDAHistory
        '
        Me.btnRetrievePreviousDAHistory.Location = New System.Drawing.Point(1117, 31)
        Me.btnRetrievePreviousDAHistory.Name = "btnRetrievePreviousDAHistory"
        Me.btnRetrievePreviousDAHistory.Size = New System.Drawing.Size(147, 48)
        Me.btnRetrievePreviousDAHistory.TabIndex = 10
        Me.btnRetrievePreviousDAHistory.Text = "Retrieve Previous DA's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (since 1/7/98)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewDa)
        Me.GroupBox2.Controls.Add(Me.btnUpDateHistory)
        Me.GroupBox2.Controls.Add(CommentLabel)
        Me.GroupBox2.Controls.Add(ActedOnLabel)
        Me.GroupBox2.Controls.Add(Me.cboActedOn)
        Me.GroupBox2.Controls.Add(Me.lblDAno)
        Me.GroupBox2.Controls.Add(Me.CommentTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1083, 75)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
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
        Me.pnlDisplayVariations.Controls.Add(Me.grdVariations)
        Me.pnlDisplayVariations.Controls.Add(Me.GroupBox1)
        Me.pnlDisplayVariations.Controls.Add(Me.grpVariations)
        Me.pnlDisplayVariations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplayVariations.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplayVariations.Name = "pnlDisplayVariations"
        Me.pnlDisplayVariations.Size = New System.Drawing.Size(1389, 761)
        Me.pnlDisplayVariations.TabIndex = 30
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
        Me.GroupBox1.Controls.Add(Me.cboVariationResult)
        Me.GroupBox1.Controls.Add(Me.cboVariationAuthority)
        Me.GroupBox1.Controls.Add(Me.btnSaveVariationResponse)
        Me.GroupBox1.Controls.Add(Me.btneditVariationResponse)
        Me.GroupBox1.Controls.Add(Me.variationDecisionDate)
        Me.GroupBox1.Controls.Add(Me.Label99)
        Me.GroupBox1.Controls.Add(Me.btnDecisionDate)
        Me.GroupBox1.Controls.Add(Me.Label100)
        Me.GroupBox1.Controls.Add(Me.Label101)
        Me.GroupBox1.Location = New System.Drawing.Point(809, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 235)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Response"
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
        'variationDecisionDate
        '
        Me.variationDecisionDate.Location = New System.Drawing.Point(168, 96)
        Me.variationDecisionDate.Name = "variationDecisionDate"
        Me.variationDecisionDate.Size = New System.Drawing.Size(65, 21)
        Me.variationDecisionDate.TabIndex = 31
        Me.variationDecisionDate.TabStop = False
        Me.variationDecisionDate.ValidatingType = GetType(Date)
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
        'btnDecisionDate
        '
        Me.btnDecisionDate.Appearance.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnDecisionDate.Appearance.Options.UseFont = True
        Me.btnDecisionDate.Enabled = False
        Me.btnDecisionDate.Location = New System.Drawing.Point(237, 96)
        Me.btnDecisionDate.Name = "btnDecisionDate"
        Me.btnDecisionDate.Size = New System.Drawing.Size(20, 20)
        Me.btnDecisionDate.TabIndex = 6
        Me.btnDecisionDate.Text = "u"
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
        Me.btnSaveVariation.Location = New System.Drawing.Point(692, 328)
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
        Me.cboOfficerRecomforVariation.Enabled = False
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
        Me.cboVariationType.Enabled = False
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
        Me.pnlDisplayContributions.Controls.Add(Me.btnRemoveBond)
        Me.pnlDisplayContributions.Controls.Add(Me.btnRemove94)
        Me.pnlDisplayContributions.Controls.Add(Me.btnRemove64)
        Me.pnlDisplayContributions.Controls.Add(Me.Label25)
        Me.pnlDisplayContributions.Controls.Add(Me.Label24)
        Me.pnlDisplayContributions.Controls.Add(Me.Label23)
        Me.pnlDisplayContributions.Controls.Add(Me.dgvProposedBondContrib)
        Me.pnlDisplayContributions.Controls.Add(Me.dgvSection94)
        Me.pnlDisplayContributions.Controls.Add(Me.dgvSection64Contributions)
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
        Me.GroupBox4.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 174)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
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
        Me.BtnInsertNewSection64.Location = New System.Drawing.Point(389, 145)
        Me.BtnInsertNewSection64.Name = "BtnInsertNewSection64"
        Me.BtnInsertNewSection64.Size = New System.Drawing.Size(59, 23)
        Me.BtnInsertNewSection64.TabIndex = 71
        Me.BtnInsertNewSection64.Text = "Insert"
        '
        'txt64Note
        '
        Me.txt64Note.Location = New System.Drawing.Point(6, 119)
        Me.txt64Note.Name = "txt64Note"
        Me.txt64Note.Size = New System.Drawing.Size(442, 20)
        Me.txt64Note.TabIndex = 70
        '
        'cboContribType
        '
        Me.cboContribType.Location = New System.Drawing.Point(6, 79)
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
        Me.Label28.Location = New System.Drawing.Point(3, 64)
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
        Me.Label29.Location = New System.Drawing.Point(6, 103)
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
        'btnRemoveBond
        '
        Me.btnRemoveBond.Enabled = False
        Me.btnRemoveBond.Location = New System.Drawing.Point(475, 623)
        Me.btnRemoveBond.Name = "btnRemoveBond"
        Me.btnRemoveBond.Size = New System.Drawing.Size(59, 23)
        Me.btnRemoveBond.TabIndex = 19
        Me.btnRemoveBond.Tag = "v"
        Me.btnRemoveBond.Text = "Remove"
        '
        'btnRemove94
        '
        Me.btnRemove94.Enabled = False
        Me.btnRemove94.Location = New System.Drawing.Point(475, 471)
        Me.btnRemove94.Name = "btnRemove94"
        Me.btnRemove94.Size = New System.Drawing.Size(59, 23)
        Me.btnRemove94.TabIndex = 18
        Me.btnRemove94.Tag = "v"
        Me.btnRemove94.Text = "Remove"
        '
        'btnRemove64
        '
        Me.btnRemove64.Enabled = False
        Me.btnRemove64.Location = New System.Drawing.Point(475, 326)
        Me.btnRemove64.Name = "btnRemove64"
        Me.btnRemove64.Size = New System.Drawing.Size(59, 23)
        Me.btnRemove64.TabIndex = 17
        Me.btnRemove64.Tag = "v"
        Me.btnRemove64.Text = "Remove"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 506)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(146, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Proposed Bond Contributions"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 361)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(172, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Proposed Section 94 Contributions"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 216)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(172, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Proposed Section 64 Contributions"
        '
        'dgvProposedBondContrib
        '
        Me.dgvProposedBondContrib.AllowUserToAddRows = False
        Me.dgvProposedBondContrib.AllowUserToDeleteRows = False
        Me.dgvProposedBondContrib.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvBondid, Me.dgvBondProposed, Me.dgvBondAmount, Me.dgvBondNote, Me.dgvBondType})
        Me.dgvProposedBondContrib.Location = New System.Drawing.Point(16, 529)
        Me.dgvProposedBondContrib.Name = "dgvProposedBondContrib"
        Me.dgvProposedBondContrib.ReadOnly = True
        Me.dgvProposedBondContrib.RowHeadersVisible = False
        Me.dgvProposedBondContrib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProposedBondContrib.Size = New System.Drawing.Size(453, 117)
        Me.dgvProposedBondContrib.TabIndex = 13
        '
        'dgvBondid
        '
        Me.dgvBondid.DataPropertyName = "S94ID"
        Me.dgvBondid.HeaderText = ""
        Me.dgvBondid.Name = "dgvBondid"
        Me.dgvBondid.ReadOnly = True
        Me.dgvBondid.Visible = False
        '
        'dgvBondProposed
        '
        Me.dgvBondProposed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvBondProposed.DataPropertyName = "s94Plan"
        Me.dgvBondProposed.HeaderText = "Proposed Bond"
        Me.dgvBondProposed.Name = "dgvBondProposed"
        Me.dgvBondProposed.ReadOnly = True
        '
        'dgvBondAmount
        '
        Me.dgvBondAmount.DataPropertyName = "S94ContCalc"
        DataGridViewCellStyle1.Format = "C2"
        Me.dgvBondAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBondAmount.HeaderText = "Amount"
        Me.dgvBondAmount.Name = "dgvBondAmount"
        Me.dgvBondAmount.ReadOnly = True
        Me.dgvBondAmount.Width = 80
        '
        'dgvBondNote
        '
        Me.dgvBondNote.DataPropertyName = "S94CalcNote"
        Me.dgvBondNote.HeaderText = "Notes"
        Me.dgvBondNote.Name = "dgvBondNote"
        Me.dgvBondNote.ReadOnly = True
        Me.dgvBondNote.Width = 200
        '
        'dgvBondType
        '
        Me.dgvBondType.DataPropertyName = "S94Type"
        Me.dgvBondType.HeaderText = "Type"
        Me.dgvBondType.Name = "dgvBondType"
        Me.dgvBondType.ReadOnly = True
        Me.dgvBondType.Width = 50
        '
        'dgvSection94
        '
        Me.dgvSection94.AllowUserToAddRows = False
        Me.dgvSection94.AllowUserToDeleteRows = False
        Me.dgvSection94.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSection94Id, Me.dgvSection94ProposeSec94, Me.dgvSection94Amount, Me.dgvSection94Notes, Me.dgvSection94Type})
        Me.dgvSection94.Location = New System.Drawing.Point(16, 377)
        Me.dgvSection94.Name = "dgvSection94"
        Me.dgvSection94.ReadOnly = True
        Me.dgvSection94.RowHeadersVisible = False
        Me.dgvSection94.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSection94.Size = New System.Drawing.Size(453, 117)
        Me.dgvSection94.TabIndex = 11
        '
        'dgvSection94Id
        '
        Me.dgvSection94Id.DataPropertyName = "S94ID"
        Me.dgvSection94Id.HeaderText = ""
        Me.dgvSection94Id.Name = "dgvSection94Id"
        Me.dgvSection94Id.ReadOnly = True
        Me.dgvSection94Id.Visible = False
        '
        'dgvSection94ProposeSec94
        '
        Me.dgvSection94ProposeSec94.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvSection94ProposeSec94.DataPropertyName = "s94Plan"
        Me.dgvSection94ProposeSec94.HeaderText = "Proposed Sec 94"
        Me.dgvSection94ProposeSec94.Name = "dgvSection94ProposeSec94"
        Me.dgvSection94ProposeSec94.ReadOnly = True
        '
        'dgvSection94Amount
        '
        Me.dgvSection94Amount.DataPropertyName = "S94ContCalc"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dgvSection94Amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSection94Amount.HeaderText = "Amount"
        Me.dgvSection94Amount.Name = "dgvSection94Amount"
        Me.dgvSection94Amount.ReadOnly = True
        Me.dgvSection94Amount.Width = 80
        '
        'dgvSection94Notes
        '
        Me.dgvSection94Notes.DataPropertyName = "S94CalcNote"
        Me.dgvSection94Notes.HeaderText = "Notes"
        Me.dgvSection94Notes.Name = "dgvSection94Notes"
        Me.dgvSection94Notes.ReadOnly = True
        Me.dgvSection94Notes.Width = 200
        '
        'dgvSection94Type
        '
        Me.dgvSection94Type.DataPropertyName = "S94Type"
        Me.dgvSection94Type.HeaderText = "Type"
        Me.dgvSection94Type.Name = "dgvSection94Type"
        Me.dgvSection94Type.ReadOnly = True
        Me.dgvSection94Type.Width = 50
        '
        'dgvSection64Contributions
        '
        Me.dgvSection64Contributions.AllowUserToAddRows = False
        Me.dgvSection64Contributions.AllowUserToDeleteRows = False
        Me.dgvSection64Contributions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSec64Id, Me.dgvSec64ProposedSec64, Me.dgvSec64Amount, Me.dgvSec64Notes, Me.dgvSec64Type})
        Me.dgvSection64Contributions.Location = New System.Drawing.Point(16, 232)
        Me.dgvSection64Contributions.Name = "dgvSection64Contributions"
        Me.dgvSection64Contributions.ReadOnly = True
        Me.dgvSection64Contributions.RowHeadersVisible = False
        Me.dgvSection64Contributions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSection64Contributions.Size = New System.Drawing.Size(453, 117)
        Me.dgvSection64Contributions.TabIndex = 12
        '
        'dgvSec64Id
        '
        Me.dgvSec64Id.DataPropertyName = "S94ID"
        Me.dgvSec64Id.HeaderText = ""
        Me.dgvSec64Id.Name = "dgvSec64Id"
        Me.dgvSec64Id.ReadOnly = True
        Me.dgvSec64Id.Visible = False
        '
        'dgvSec64ProposedSec64
        '
        Me.dgvSec64ProposedSec64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvSec64ProposedSec64.DataPropertyName = "s94Plan"
        Me.dgvSec64ProposedSec64.HeaderText = "Proposed Sec 64"
        Me.dgvSec64ProposedSec64.Name = "dgvSec64ProposedSec64"
        Me.dgvSec64ProposedSec64.ReadOnly = True
        '
        'dgvSec64Amount
        '
        Me.dgvSec64Amount.DataPropertyName = "S94ContCalc"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgvSec64Amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSec64Amount.HeaderText = "Amount"
        Me.dgvSec64Amount.Name = "dgvSec64Amount"
        Me.dgvSec64Amount.ReadOnly = True
        Me.dgvSec64Amount.Width = 80
        '
        'dgvSec64Notes
        '
        Me.dgvSec64Notes.DataPropertyName = "S94CalcNote"
        Me.dgvSec64Notes.HeaderText = "Notes"
        Me.dgvSec64Notes.Name = "dgvSec64Notes"
        Me.dgvSec64Notes.ReadOnly = True
        Me.dgvSec64Notes.Width = 200
        '
        'dgvSec64Type
        '
        Me.dgvSec64Type.DataPropertyName = "S94Type"
        Me.dgvSec64Type.HeaderText = "Type"
        Me.dgvSec64Type.Name = "dgvSec64Type"
        Me.dgvSec64Type.ReadOnly = True
        Me.dgvSec64Type.Width = 50
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
        Me.btnUpdateModDetails.Location = New System.Drawing.Point(693, 25)
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
        Me.pnlDisplayConclusions.Controls.Add(Me.pnlModificationConclusion)
        Me.pnlDisplayConclusions.Controls.Add(Me.pnlLabel)
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
        Me.scrolMainConclusion.Size = New System.Drawing.Size(1389, 714)
        Me.scrolMainConclusion.TabIndex = 11
        '
        'pnlConclusion
        '
        Me.pnlConclusion.Controls.Add(Me.txtApplicationConclreasons)
        Me.pnlConclusion.Controls.Add(Me.ComplianceStatProvCommentsTextBox)
        Me.pnlConclusion.Controls.Add(Me.txtVariationComment)
        Me.pnlConclusion.Controls.Add(Me.Button11)
        Me.pnlConclusion.Controls.Add(Me.btnViewConclusion)
        Me.pnlConclusion.Controls.Add(Me.txtConclusionDate)
        Me.pnlConclusion.Controls.Add(Me.cboAuthority)
        Me.pnlConclusion.Controls.Add(Me.Label80)
        Me.pnlConclusion.Controls.Add(Me.Label127)
        Me.pnlConclusion.Controls.Add(Me.Label52)
        Me.pnlConclusion.Controls.Add(Me.btnViewComplainceReason)
        Me.pnlConclusion.Controls.Add(Me.dgvConditionText)
        Me.pnlConclusion.Controls.Add(Me.Label53)
        Me.pnlConclusion.Controls.Add(Me.dgvConditions)
        Me.pnlConclusion.Controls.Add(Me.dgvConclusionVariations)
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
        Me.pnlConclusion.Location = New System.Drawing.Point(3, 0)
        Me.pnlConclusion.Name = "pnlConclusion"
        Me.pnlConclusion.Size = New System.Drawing.Size(1368, 782)
        Me.pnlConclusion.TabIndex = 103
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
        'Button11
        '
        Me.Button11.Appearance.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button11.Appearance.Options.UseFont = True
        Me.Button11.Location = New System.Drawing.Point(457, 721)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(20, 20)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "u"
        '
        'btnViewConclusion
        '
        Me.btnViewConclusion.Location = New System.Drawing.Point(671, 434)
        Me.btnViewConclusion.Name = "btnViewConclusion"
        Me.btnViewConclusion.Size = New System.Drawing.Size(54, 23)
        Me.btnViewConclusion.TabIndex = 100
        Me.btnViewConclusion.Text = "View"
        '
        'txtConclusionDate
        '
        Me.txtConclusionDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtConclusionDate.Location = New System.Drawing.Point(390, 721)
        Me.txtConclusionDate.Name = "txtConclusionDate"
        Me.txtConclusionDate.ReadOnly = True
        Me.txtConclusionDate.Size = New System.Drawing.Size(65, 21)
        Me.txtConclusionDate.TabIndex = 96
        Me.txtConclusionDate.ValidatingType = GetType(Date)
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
        'dgvConditionText
        '
        Me.dgvConditionText.AllowUserToAddRows = False
        Me.dgvConditionText.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvConditionText.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvConditionText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConditionText.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cntConditionCode, Me.cntConditionText, Me.cntId})
        Me.dgvConditionText.Location = New System.Drawing.Point(751, 608)
        Me.dgvConditionText.Name = "dgvConditionText"
        Me.dgvConditionText.ReadOnly = True
        Me.dgvConditionText.RowHeadersVisible = False
        Me.dgvConditionText.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgvConditionText.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConditionText.RowTemplate.Height = 50
        Me.dgvConditionText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConditionText.Size = New System.Drawing.Size(609, 155)
        Me.dgvConditionText.TabIndex = 94
        '
        'cntConditionCode
        '
        Me.cntConditionCode.DataPropertyName = "ConditionCode"
        Me.cntConditionCode.HeaderText = ""
        Me.cntConditionCode.Name = "cntConditionCode"
        Me.cntConditionCode.ReadOnly = True
        Me.cntConditionCode.Visible = False
        '
        'cntConditionText
        '
        Me.cntConditionText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cntConditionText.DataPropertyName = "ConditionText"
        Me.cntConditionText.HeaderText = "ConditionText"
        Me.cntConditionText.Name = "cntConditionText"
        Me.cntConditionText.ReadOnly = True
        '
        'cntId
        '
        Me.cntId.DataPropertyName = "UniqueId"
        Me.cntId.HeaderText = ""
        Me.cntId.Name = "cntId"
        Me.cntId.ReadOnly = True
        Me.cntId.Visible = False
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
        'dgvConditions
        '
        Me.dgvConditions.AllowUserToAddRows = False
        Me.dgvConditions.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvConditions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.condId, Me.condConditions, Me.condInsert})
        Me.dgvConditions.Location = New System.Drawing.Point(750, 413)
        Me.dgvConditions.Name = "dgvConditions"
        Me.dgvConditions.ReadOnly = True
        Me.dgvConditions.RowHeadersVisible = False
        Me.dgvConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConditions.Size = New System.Drawing.Size(610, 167)
        Me.dgvConditions.TabIndex = 93
        '
        'condId
        '
        Me.condId.DataPropertyName = "id"
        Me.condId.HeaderText = ""
        Me.condId.Name = "condId"
        Me.condId.ReadOnly = True
        Me.condId.Visible = False
        '
        'condConditions
        '
        Me.condConditions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.condConditions.DataPropertyName = "Condition"
        Me.condConditions.HeaderText = "Conditions"
        Me.condConditions.Name = "condConditions"
        Me.condConditions.ReadOnly = True
        '
        'condInsert
        '
        Me.condInsert.DataPropertyName = "FreeformInserts"
        Me.condInsert.HeaderText = "Insert"
        Me.condInsert.Name = "condInsert"
        Me.condInsert.ReadOnly = True
        Me.condInsert.Width = 45
        '
        'dgvConclusionVariations
        '
        Me.dgvConclusionVariations.AllowUserToAddRows = False
        Me.dgvConclusionVariations.AllowUserToDeleteRows = False
        Me.dgvConclusionVariations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.conID, Me.conVariation, Me.conDetail, Me.conResult, Me.conAuthority, Me.conDate, Me.AssResult, Me.AssReasons, Me.conUserStamp})
        Me.dgvConclusionVariations.Location = New System.Drawing.Point(8, 168)
        Me.dgvConclusionVariations.Name = "dgvConclusionVariations"
        Me.dgvConclusionVariations.ReadOnly = True
        Me.dgvConclusionVariations.RowHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConclusionVariations.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvConclusionVariations.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgvConclusionVariations.RowTemplate.Height = 44
        Me.dgvConclusionVariations.Size = New System.Drawing.Size(1352, 220)
        Me.dgvConclusionVariations.TabIndex = 98
        '
        'conID
        '
        Me.conID.DataPropertyName = "id"
        Me.conID.HeaderText = ""
        Me.conID.Name = "conID"
        Me.conID.ReadOnly = True
        Me.conID.Visible = False
        '
        'conVariation
        '
        Me.conVariation.DataPropertyName = "Variation"
        Me.conVariation.HeaderText = "Variation"
        Me.conVariation.Name = "conVariation"
        Me.conVariation.ReadOnly = True
        Me.conVariation.Width = 200
        '
        'conDetail
        '
        Me.conDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.conDetail.DataPropertyName = "Detail"
        Me.conDetail.HeaderText = "Detail"
        Me.conDetail.Name = "conDetail"
        Me.conDetail.ReadOnly = True
        '
        'conResult
        '
        Me.conResult.DataPropertyName = "VariationResultDesc"
        Me.conResult.HeaderText = "Result"
        Me.conResult.Name = "conResult"
        Me.conResult.ReadOnly = True
        '
        'conAuthority
        '
        Me.conAuthority.DataPropertyName = "DelegatedAuthority"
        Me.conAuthority.HeaderText = "Authority"
        Me.conAuthority.Name = "conAuthority"
        Me.conAuthority.ReadOnly = True
        Me.conAuthority.Visible = False
        '
        'conDate
        '
        Me.conDate.DataPropertyName = "DecisionDate"
        DataGridViewCellStyle6.Format = "dd/MM/yyyy"
        Me.conDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.conDate.HeaderText = "Date"
        Me.conDate.Name = "conDate"
        Me.conDate.ReadOnly = True
        Me.conDate.Width = 80
        '
        'AssResult
        '
        Me.AssResult.DataPropertyName = "AssResult"
        Me.AssResult.HeaderText = ""
        Me.AssResult.MinimumWidth = 2
        Me.AssResult.Name = "AssResult"
        Me.AssResult.ReadOnly = True
        Me.AssResult.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssResult.Visible = False
        Me.AssResult.Width = 2
        '
        'AssReasons
        '
        Me.AssReasons.DataPropertyName = "AssReasons"
        Me.AssReasons.HeaderText = ""
        Me.AssReasons.MinimumWidth = 2
        Me.AssReasons.Name = "AssReasons"
        Me.AssReasons.ReadOnly = True
        Me.AssReasons.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssReasons.Visible = False
        Me.AssReasons.Width = 2
        '
        'conUserStamp
        '
        Me.conUserStamp.DataPropertyName = "UserStamp"
        Me.conUserStamp.HeaderText = ""
        Me.conUserStamp.Name = "conUserStamp"
        Me.conUserStamp.ReadOnly = True
        Me.conUserStamp.Visible = False
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
        'pnlModificationConclusion
        '
        Me.pnlModificationConclusion.Controls.Add(Me.ApplicationConclreasonsTextBox)
        Me.pnlModificationConclusion.Controls.Add(Me.btnViewReco)
        Me.pnlModificationConclusion.Controls.Add(Me.Label129)
        Me.pnlModificationConclusion.Controls.Add(Me.btnProposedDetermDate)
        Me.pnlModificationConclusion.Controls.Add(Me.txtProposedDetermDate)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModAuthority)
        Me.pnlModificationConclusion.Controls.Add(Me.dgvOneOffConditions)
        Me.pnlModificationConclusion.Controls.Add(Me.dgvStandConditions)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModAssessmentDecision)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModSec79Satisfactory)
        Me.pnlModificationConclusion.Controls.Add(Me.cboModSec96Comply)
        Me.pnlModificationConclusion.Controls.Add(Me.lblRecommendTwo)
        Me.pnlModificationConclusion.Controls.Add(Me.lblRecommendation)
        Me.pnlModificationConclusion.Controls.Add(Me.Label49)
        Me.pnlModificationConclusion.Controls.Add(Me.Label51)
        Me.pnlModificationConclusion.Controls.Add(Me.Label50)
        Me.pnlModificationConclusion.Controls.Add(Me.Label47)
        Me.pnlModificationConclusion.Controls.Add(Me.Label48)
        Me.pnlModificationConclusion.Controls.Add(Me.Label43)
        Me.pnlModificationConclusion.Controls.Add(Me.Label33)
        Me.pnlModificationConclusion.Controls.Add(Me.Label32)
        Me.pnlModificationConclusion.Controls.Add(Me.Label31)
        Me.pnlModificationConclusion.Location = New System.Drawing.Point(5, 47)
        Me.pnlModificationConclusion.Name = "pnlModificationConclusion"
        Me.pnlModificationConclusion.Size = New System.Drawing.Size(750, 711)
        Me.pnlModificationConclusion.TabIndex = 9
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
        Me.Label129.Location = New System.Drawing.Point(409, 509)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(148, 13)
        Me.Label129.TabIndex = 92
        Me.Label129.Text = "Proposed Determination Date"
        '
        'btnProposedDetermDate
        '
        Me.btnProposedDetermDate.Appearance.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnProposedDetermDate.Appearance.Options.UseFont = True
        Me.btnProposedDetermDate.Location = New System.Drawing.Point(625, 504)
        Me.btnProposedDetermDate.Name = "btnProposedDetermDate"
        Me.btnProposedDetermDate.Size = New System.Drawing.Size(20, 20)
        Me.btnProposedDetermDate.TabIndex = 59
        Me.btnProposedDetermDate.Text = "u"
        '
        'txtProposedDetermDate
        '
        Me.txtProposedDetermDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtProposedDetermDate.Location = New System.Drawing.Point(558, 505)
        Me.txtProposedDetermDate.Name = "txtProposedDetermDate"
        Me.txtProposedDetermDate.ReadOnly = True
        Me.txtProposedDetermDate.Size = New System.Drawing.Size(65, 21)
        Me.txtProposedDetermDate.TabIndex = 58
        Me.txtProposedDetermDate.ValidatingType = GetType(Date)
        '
        'cboModAuthority
        '
        Me.cboModAuthority.Location = New System.Drawing.Point(283, 504)
        Me.cboModAuthority.Name = "cboModAuthority"
        Me.cboModAuthority.Properties.DisplayMember = "Description"
        Me.cboModAuthority.Properties.NullText = "[Select]"
        Me.cboModAuthority.Properties.ShowFooter = False
        Me.cboModAuthority.Properties.ShowHeader = False
        Me.cboModAuthority.Properties.ValueMember = "id"
        Me.cboModAuthority.Size = New System.Drawing.Size(121, 20)
        Me.cboModAuthority.TabIndex = 20
        '
        'dgvOneOffConditions
        '
        Me.dgvOneOffConditions.AllowUserToAddRows = False
        Me.dgvOneOffConditions.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvOneOffConditions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvOneOffConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOneOffConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvOneOffConditionsConditionCode, Me.dgvOneOffConditionsConditionText, Me.DataGridViewTextBoxColumn77})
        Me.dgvOneOffConditions.Location = New System.Drawing.Point(366, 337)
        Me.dgvOneOffConditions.Name = "dgvOneOffConditions"
        Me.dgvOneOffConditions.ReadOnly = True
        Me.dgvOneOffConditions.RowHeadersVisible = False
        Me.dgvOneOffConditions.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgvOneOffConditions.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOneOffConditions.RowTemplate.Height = 50
        Me.dgvOneOffConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOneOffConditions.Size = New System.Drawing.Size(278, 155)
        Me.dgvOneOffConditions.TabIndex = 20
        '
        'dgvOneOffConditionsConditionCode
        '
        Me.dgvOneOffConditionsConditionCode.DataPropertyName = "ConditionCode"
        Me.dgvOneOffConditionsConditionCode.HeaderText = "Code"
        Me.dgvOneOffConditionsConditionCode.Name = "dgvOneOffConditionsConditionCode"
        Me.dgvOneOffConditionsConditionCode.ReadOnly = True
        Me.dgvOneOffConditionsConditionCode.Visible = False
        '
        'dgvOneOffConditionsConditionText
        '
        Me.dgvOneOffConditionsConditionText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvOneOffConditionsConditionText.DataPropertyName = "ConditionText"
        Me.dgvOneOffConditionsConditionText.HeaderText = "Condition"
        Me.dgvOneOffConditionsConditionText.Name = "dgvOneOffConditionsConditionText"
        Me.dgvOneOffConditionsConditionText.ReadOnly = True
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "UniqueId"
        Me.DataGridViewTextBoxColumn77.HeaderText = "UniqueId"
        Me.DataGridViewTextBoxColumn77.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        Me.DataGridViewTextBoxColumn77.ReadOnly = True
        Me.DataGridViewTextBoxColumn77.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn77.Visible = False
        Me.DataGridViewTextBoxColumn77.Width = 2
        '
        'dgvStandConditions
        '
        Me.dgvStandConditions.AllowUserToAddRows = False
        Me.dgvStandConditions.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvStandConditions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvStandConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStandConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvStdID, Me.dgvStdConditions, Me.dgvStdInserts})
        Me.dgvStandConditions.Location = New System.Drawing.Point(3, 337)
        Me.dgvStandConditions.Name = "dgvStandConditions"
        Me.dgvStandConditions.ReadOnly = True
        Me.dgvStandConditions.RowHeadersVisible = False
        Me.dgvStandConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStandConditions.Size = New System.Drawing.Size(357, 155)
        Me.dgvStandConditions.TabIndex = 18
        '
        'dgvStdID
        '
        Me.dgvStdID.DataPropertyName = "id"
        Me.dgvStdID.HeaderText = "id"
        Me.dgvStdID.Name = "dgvStdID"
        Me.dgvStdID.ReadOnly = True
        Me.dgvStdID.Visible = False
        '
        'dgvStdConditions
        '
        Me.dgvStdConditions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvStdConditions.DataPropertyName = "Condition"
        Me.dgvStdConditions.HeaderText = "Condition"
        Me.dgvStdConditions.Name = "dgvStdConditions"
        Me.dgvStdConditions.ReadOnly = True
        '
        'dgvStdInserts
        '
        Me.dgvStdInserts.DataPropertyName = "FreeFormInserts"
        Me.dgvStdInserts.HeaderText = "Inserts"
        Me.dgvStdInserts.Name = "dgvStdInserts"
        Me.dgvStdInserts.ReadOnly = True
        Me.dgvStdInserts.Width = 45
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
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(374, 321)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(96, 13)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "OneOff Conditions"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(0, 321)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(104, 13)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Standard Conditions"
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
        Me.Label33.Location = New System.Drawing.Point(184, 502)
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
        'pnlLabel
        '
        Me.pnlLabel.Controls.Add(Me.btnUpdateConclusion)
        Me.pnlLabel.Controls.Add(Me.lblConclusion)
        Me.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabel.Location = New System.Drawing.Point(2, 2)
        Me.pnlLabel.Name = "pnlLabel"
        Me.pnlLabel.Size = New System.Drawing.Size(1385, 46)
        Me.pnlLabel.TabIndex = 12
        '
        'btnUpdateConclusion
        '
        Me.btnUpdateConclusion.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUpdateConclusion.Location = New System.Drawing.Point(1264, 2)
        Me.btnUpdateConclusion.Name = "btnUpdateConclusion"
        Me.btnUpdateConclusion.Size = New System.Drawing.Size(119, 42)
        Me.btnUpdateConclusion.TabIndex = 12
        Me.btnUpdateConclusion.Text = "Update Conclusion"
        '
        'lblConclusion
        '
        Me.lblConclusion.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblConclusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConclusion.Location = New System.Drawing.Point(2, 2)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(844, 42)
        Me.lblConclusion.TabIndex = 10
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grdHistoricalDA)
        Me.GroupControl1.Controls.Add(Me.btnRetrievePreviousDAHistory)
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1276, 434)
        Me.GroupControl1.TabIndex = 29
        Me.GroupControl1.Text = "Historical DA's"
        '
        'TestAssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 855)
        Me.Controls.Add(Me.tabAssessment)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TestAssessmentForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Assessment "
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.tabAssessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAssessment.ResumeLayout(False)
        Me.tpgHistory.ResumeLayout(False)
        CType(Me.pnlDisplayHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayHistory.ResumeLayout(False)
        Me.pnlDisplayHistory.PerformLayout()
        CType(Me.grdHistoricalDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwHistoricalDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevHistoryCommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxAssessmentRept.ResumeLayout(False)
        Me.gbxAssessmentRept.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cboActedOn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txt64Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboS64Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt64Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboContribType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSection64Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProposedBondContrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSection94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSection64Contributions, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtApplicationConclreasons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplianceStatProvCommentsTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariationComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAuthority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConditionText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConclusionVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboReferralsYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboComplianceStatProvYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVariationsYesNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboApplicationConclResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlModificationConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModificationConclusion.ResumeLayout(False)
        Me.pnlModificationConclusion.PerformLayout()
        CType(Me.ApplicationConclreasonsTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModAuthority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOneOffConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStandConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModAssessmentDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSec79Satisfactory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModSec96Comply.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLabel.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnViewDa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpDateHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboActedOn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDAno As Label
    Friend WithEvents pnlDisplayConclusions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUpdateConclusion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlModificationConclusion As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnViewReco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label129 As Label
    Friend WithEvents btnProposedDetermDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProposedDetermDate As MaskedTextBox
    Friend WithEvents cboModAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgvOneOffConditions As DataGridView
    Friend WithEvents dgvOneOffConditionsConditionCode As DataGridViewTextBoxColumn
    Friend WithEvents dgvOneOffConditionsConditionText As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As DataGridViewTextBoxColumn
    Friend WithEvents dgvStandConditions As DataGridView
    Friend WithEvents dgvStdID As DataGridViewTextBoxColumn
    Friend WithEvents dgvStdConditions As DataGridViewTextBoxColumn
    Friend WithEvents dgvStdInserts As DataGridViewCheckBoxColumn
    Friend WithEvents cboModAssessmentDecision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModSec79Satisfactory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboModSec96Comply As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRecommendTwo As Label
    Friend WithEvents lblRecommendation As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
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
    Friend WithEvents dgvConclusionVariations As DataGridView
    Friend WithEvents conID As DataGridViewTextBoxColumn
    Friend WithEvents conVariation As DataGridViewTextBoxColumn
    Friend WithEvents conDetail As DataGridViewTextBoxColumn
    Friend WithEvents conResult As DataGridViewTextBoxColumn
    Friend WithEvents conAuthority As DataGridViewTextBoxColumn
    Friend WithEvents conDate As DataGridViewTextBoxColumn
    Friend WithEvents AssResult As DataGridViewTextBoxColumn
    Friend WithEvents AssReasons As DataGridViewTextBoxColumn
    Friend WithEvents conUserStamp As DataGridViewTextBoxColumn
    Friend WithEvents Button11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtConclusionDate As MaskedTextBox
    Friend WithEvents cboAuthority As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgvConditionText As DataGridView
    Friend WithEvents cntConditionCode As DataGridViewTextBoxColumn
    Friend WithEvents cntConditionText As DataGridViewTextBoxColumn
    Friend WithEvents cntId As DataGridViewTextBoxColumn
    Friend WithEvents dgvConditions As DataGridView
    Friend WithEvents condId As DataGridViewTextBoxColumn
    Friend WithEvents condConditions As DataGridViewTextBoxColumn
    Friend WithEvents condInsert As DataGridViewCheckBoxColumn
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
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dgvProposedBondContrib As DataGridView
    Friend WithEvents dgvBondid As DataGridViewTextBoxColumn
    Friend WithEvents dgvBondProposed As DataGridViewTextBoxColumn
    Friend WithEvents dgvBondAmount As DataGridViewTextBoxColumn
    Friend WithEvents dgvBondNote As DataGridViewTextBoxColumn
    Friend WithEvents dgvBondType As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection94 As DataGridView
    Friend WithEvents dgvSection94Id As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection94ProposeSec94 As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection94Amount As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection94Notes As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection94Type As DataGridViewTextBoxColumn
    Friend WithEvents dgvSection64Contributions As DataGridView
    Friend WithEvents dgvSec64Id As DataGridViewTextBoxColumn
    Friend WithEvents dgvSec64ProposedSec64 As DataGridViewTextBoxColumn
    Friend WithEvents dgvSec64Amount As DataGridViewTextBoxColumn
    Friend WithEvents dgvSec64Notes As DataGridViewTextBoxColumn
    Friend WithEvents dgvSec64Type As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlDisplayVariations As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSaveVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btneditVariationResponse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents variationDecisionDate As MaskedTextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents btnDecisionDate As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
