<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentDA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DANoLabel As System.Windows.Forms.Label
        Dim CCNoLabel As System.Windows.Forms.Label
        Dim DAStreetNoLabel As System.Windows.Forms.Label
        Dim DALocalityCodeIdLabel As System.Windows.Forms.Label
        Dim DALotLabel As System.Windows.Forms.Label
        Dim DADPLabel As System.Windows.Forms.Label
        Dim DAOwnersNameLabel As System.Windows.Forms.Label
        Dim DAOwnersPAddrLabel As System.Windows.Forms.Label
        Dim DAAppNameLabel As System.Windows.Forms.Label
        Dim DAAppAddrLabel As System.Windows.Forms.Label
        Dim CCLicBuilderNameLabel As System.Windows.Forms.Label
        Dim CCLicBuilderNoLabel As System.Windows.Forms.Label
        Dim CCLicBuilderPhoneLabel As System.Windows.Forms.Label
        Dim DADescLabel As System.Windows.Forms.Label
        Dim DAEstCostLabel As System.Windows.Forms.Label
        Dim DARegoDtLabel As System.Windows.Forms.Label
        Dim DAFileNoLabel As System.Windows.Forms.Label
        Dim DAToPlannerDtLabel As System.Windows.Forms.Label
        Dim DASiteInspectedDtLabel As System.Windows.Forms.Label
        Dim RefToPlanComLabel As System.Windows.Forms.Label
        Dim DAToTypingDtLabel As System.Windows.Forms.Label
        Dim DADetermDtLabel As System.Windows.Forms.Label
        Dim DAAppNotDtLabel As System.Windows.Forms.Label
        Dim ConsentPostedDateLabel As System.Windows.Forms.Label
        Dim DAConsentPubDtLabel As System.Windows.Forms.Label
        Dim AddInfoLabel As System.Windows.Forms.Label
        Dim AIRequestDtLabel As System.Windows.Forms.Label
        Dim DAAdvisedDtLabel As System.Windows.Forms.Label
        Dim DACommDtLabel As System.Windows.Forms.Label
        Dim DACompletedDtLabel As System.Windows.Forms.Label
        Dim DAAppNotDtLabel1 As System.Windows.Forms.Label
        Dim DAOfficerNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentDA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CurrentDAsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CurrentDAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZONES = New LookupDevelopmentApplication.CZONES()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.DANoTextBox = New System.Windows.Forms.TextBox()
        Me.CCNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DADPTextBox = New System.Windows.Forms.TextBox()
        Me.DALotTextBox = New System.Windows.Forms.TextBox()
        Me.DALocalityCodeIdTextBox = New System.Windows.Forms.TextBox()
        Me.DAStreetTextBox = New System.Windows.Forms.TextBox()
        Me.DAStreetNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DAOwnersTownTextBox = New System.Windows.Forms.TextBox()
        Me.DAOwnersPAddrTextBox = New System.Windows.Forms.TextBox()
        Me.DAOwnersNameTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DAAppTownTextBox = New System.Windows.Forms.TextBox()
        Me.DAAppAddrTextBox = New System.Windows.Forms.TextBox()
        Me.DAAppNameTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CCLicBuilderPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CCLicBuilderNoTextBox = New System.Windows.Forms.TextBox()
        Me.CCLicBuilderNameTextBox = New System.Windows.Forms.TextBox()
        Me.DADescTextBox = New System.Windows.Forms.TextBox()
        Me.DAEstCostTextBox = New System.Windows.Forms.TextBox()
        Me.DARegoDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DAFileNoTextBox = New System.Windows.Forms.TextBox()
        Me.DAToPlannerDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DASiteInspectedDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RefToPlanComMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DAToTypingDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DADetermDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DAAppNotDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ConsentPostedDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DAConsentPubDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DADecisionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AIRequestDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DAAdvisedDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DACommDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DACompletedDtMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ProgressCodeTextTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DAAppNotDtMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AddInfoCheckBox = New System.Windows.Forms.CheckBox()
        Me.dgvDAreferrals = New System.Windows.Forms.DataGridView()
        Me.DANoIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefRetDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferralCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAReferralsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAOfficerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentDAsTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.CurrentDAsTableAdapter()
        Me.DA_ReferralsTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.DA_ReferralsTableAdapter()
        DANoLabel = New System.Windows.Forms.Label()
        CCNoLabel = New System.Windows.Forms.Label()
        DAStreetNoLabel = New System.Windows.Forms.Label()
        DALocalityCodeIdLabel = New System.Windows.Forms.Label()
        DALotLabel = New System.Windows.Forms.Label()
        DADPLabel = New System.Windows.Forms.Label()
        DAOwnersNameLabel = New System.Windows.Forms.Label()
        DAOwnersPAddrLabel = New System.Windows.Forms.Label()
        DAAppNameLabel = New System.Windows.Forms.Label()
        DAAppAddrLabel = New System.Windows.Forms.Label()
        CCLicBuilderNameLabel = New System.Windows.Forms.Label()
        CCLicBuilderNoLabel = New System.Windows.Forms.Label()
        CCLicBuilderPhoneLabel = New System.Windows.Forms.Label()
        DADescLabel = New System.Windows.Forms.Label()
        DAEstCostLabel = New System.Windows.Forms.Label()
        DARegoDtLabel = New System.Windows.Forms.Label()
        DAFileNoLabel = New System.Windows.Forms.Label()
        DAToPlannerDtLabel = New System.Windows.Forms.Label()
        DASiteInspectedDtLabel = New System.Windows.Forms.Label()
        RefToPlanComLabel = New System.Windows.Forms.Label()
        DAToTypingDtLabel = New System.Windows.Forms.Label()
        DADetermDtLabel = New System.Windows.Forms.Label()
        DAAppNotDtLabel = New System.Windows.Forms.Label()
        ConsentPostedDateLabel = New System.Windows.Forms.Label()
        DAConsentPubDtLabel = New System.Windows.Forms.Label()
        AddInfoLabel = New System.Windows.Forms.Label()
        AIRequestDtLabel = New System.Windows.Forms.Label()
        DAAdvisedDtLabel = New System.Windows.Forms.Label()
        DACommDtLabel = New System.Windows.Forms.Label()
        DACompletedDtLabel = New System.Windows.Forms.Label()
        DAAppNotDtLabel1 = New System.Windows.Forms.Label()
        DAOfficerNameLabel = New System.Windows.Forms.Label()
        CType(Me.CurrentDAsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrentDAsBindingNavigator.SuspendLayout()
        CType(Me.CurrentDAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDAreferrals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAReferralsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DANoLabel
        '
        DANoLabel.AutoSize = True
        DANoLabel.Location = New System.Drawing.Point(12, 38)
        DANoLabel.Name = "DANoLabel"
        DANoLabel.Size = New System.Drawing.Size(42, 13)
        DANoLabel.TabIndex = 2
        DANoLabel.Text = "DA No:"
        '
        'CCNoLabel
        '
        CCNoLabel.AutoSize = True
        CCNoLabel.Location = New System.Drawing.Point(162, 38)
        CCNoLabel.Name = "CCNoLabel"
        CCNoLabel.Size = New System.Drawing.Size(41, 13)
        CCNoLabel.TabIndex = 3
        CCNoLabel.Text = "CC No:"
        '
        'DAStreetNoLabel
        '
        DAStreetNoLabel.AutoSize = True
        DAStreetNoLabel.Location = New System.Drawing.Point(14, 19)
        DAStreetNoLabel.Name = "DAStreetNoLabel"
        DAStreetNoLabel.Size = New System.Drawing.Size(38, 13)
        DAStreetNoLabel.TabIndex = 0
        DAStreetNoLabel.Text = "Street:"
        '
        'DALocalityCodeIdLabel
        '
        DALocalityCodeIdLabel.AutoSize = True
        DALocalityCodeIdLabel.Location = New System.Drawing.Point(6, 52)
        DALocalityCodeIdLabel.Name = "DALocalityCodeIdLabel"
        DALocalityCodeIdLabel.Size = New System.Drawing.Size(46, 13)
        DALocalityCodeIdLabel.TabIndex = 3
        DALocalityCodeIdLabel.Text = "Locality:"
        '
        'DALotLabel
        '
        DALotLabel.AutoSize = True
        DALotLabel.Location = New System.Drawing.Point(27, 75)
        DALotLabel.Name = "DALotLabel"
        DALotLabel.Size = New System.Drawing.Size(25, 13)
        DALotLabel.TabIndex = 5
        DALotLabel.Text = "Lot:"
        '
        'DADPLabel
        '
        DADPLabel.AutoSize = True
        DADPLabel.Location = New System.Drawing.Point(114, 75)
        DADPLabel.Name = "DADPLabel"
        DADPLabel.Size = New System.Drawing.Size(25, 13)
        DADPLabel.TabIndex = 7
        DADPLabel.Text = "DP:"
        '
        'DAOwnersNameLabel
        '
        DAOwnersNameLabel.AutoSize = True
        DAOwnersNameLabel.Location = New System.Drawing.Point(6, 21)
        DAOwnersNameLabel.Name = "DAOwnersNameLabel"
        DAOwnersNameLabel.Size = New System.Drawing.Size(38, 13)
        DAOwnersNameLabel.TabIndex = 0
        DAOwnersNameLabel.Text = "Name:"
        '
        'DAOwnersPAddrLabel
        '
        DAOwnersPAddrLabel.AutoSize = True
        DAOwnersPAddrLabel.Location = New System.Drawing.Point(12, 52)
        DAOwnersPAddrLabel.Name = "DAOwnersPAddrLabel"
        DAOwnersPAddrLabel.Size = New System.Drawing.Size(48, 13)
        DAOwnersPAddrLabel.TabIndex = 2
        DAOwnersPAddrLabel.Text = "Address:"
        '
        'DAAppNameLabel
        '
        DAAppNameLabel.AutoSize = True
        DAAppNameLabel.Location = New System.Drawing.Point(6, 21)
        DAAppNameLabel.Name = "DAAppNameLabel"
        DAAppNameLabel.Size = New System.Drawing.Size(38, 13)
        DAAppNameLabel.TabIndex = 0
        DAAppNameLabel.Text = "Name:"
        '
        'DAAppAddrLabel
        '
        DAAppAddrLabel.AutoSize = True
        DAAppAddrLabel.Location = New System.Drawing.Point(12, 52)
        DAAppAddrLabel.Name = "DAAppAddrLabel"
        DAAppAddrLabel.Size = New System.Drawing.Size(48, 13)
        DAAppAddrLabel.TabIndex = 2
        DAAppAddrLabel.Text = "Address:"
        '
        'CCLicBuilderNameLabel
        '
        CCLicBuilderNameLabel.AutoSize = True
        CCLicBuilderNameLabel.Location = New System.Drawing.Point(6, 21)
        CCLicBuilderNameLabel.Name = "CCLicBuilderNameLabel"
        CCLicBuilderNameLabel.Size = New System.Drawing.Size(38, 13)
        CCLicBuilderNameLabel.TabIndex = 0
        CCLicBuilderNameLabel.Text = "Name:"
        '
        'CCLicBuilderNoLabel
        '
        CCLicBuilderNoLabel.AutoSize = True
        CCLicBuilderNoLabel.Location = New System.Drawing.Point(6, 55)
        CCLicBuilderNoLabel.Name = "CCLicBuilderNoLabel"
        CCLicBuilderNoLabel.Size = New System.Drawing.Size(59, 13)
        CCLicBuilderNoLabel.TabIndex = 2
        CCLicBuilderNoLabel.Text = "Builder No:"
        '
        'CCLicBuilderPhoneLabel
        '
        CCLicBuilderPhoneLabel.AutoSize = True
        CCLicBuilderPhoneLabel.Location = New System.Drawing.Point(19, 83)
        CCLicBuilderPhoneLabel.Name = "CCLicBuilderPhoneLabel"
        CCLicBuilderPhoneLabel.Size = New System.Drawing.Size(41, 13)
        CCLicBuilderPhoneLabel.TabIndex = 4
        CCLicBuilderPhoneLabel.Text = "Phone:"
        '
        'DADescLabel
        '
        DADescLabel.AutoSize = True
        DADescLabel.Location = New System.Drawing.Point(287, 38)
        DADescLabel.Name = "DADescLabel"
        DADescLabel.Size = New System.Drawing.Size(63, 13)
        DADescLabel.TabIndex = 7
        DADescLabel.Text = "Description:"
        '
        'DAEstCostLabel
        '
        DAEstCostLabel.AutoSize = True
        DAEstCostLabel.Location = New System.Drawing.Point(170, 64)
        DAEstCostLabel.Name = "DAEstCostLabel"
        DAEstCostLabel.Size = New System.Drawing.Size(80, 13)
        DAEstCostLabel.TabIndex = 9
        DAEstCostLabel.Text = "Estimated Cost:"
        '
        'DARegoDtLabel
        '
        DARegoDtLabel.AutoSize = True
        DARegoDtLabel.Location = New System.Drawing.Point(37, 23)
        DARegoDtLabel.Name = "DARegoDtLabel"
        DARegoDtLabel.Size = New System.Drawing.Size(61, 13)
        DARegoDtLabel.TabIndex = 11
        DARegoDtLabel.Text = "Registered:"
        '
        'DAFileNoLabel
        '
        DAFileNoLabel.AutoSize = True
        DAFileNoLabel.Location = New System.Drawing.Point(11, 64)
        DAFileNoLabel.Name = "DAFileNoLabel"
        DAFileNoLabel.Size = New System.Drawing.Size(43, 13)
        DAFileNoLabel.TabIndex = 13
        DAFileNoLabel.Text = "File No:"
        '
        'DAToPlannerDtLabel
        '
        DAToPlannerDtLabel.AutoSize = True
        DAToPlannerDtLabel.Location = New System.Drawing.Point(36, 144)
        DAToPlannerDtLabel.Name = "DAToPlannerDtLabel"
        DAToPlannerDtLabel.Size = New System.Drawing.Size(62, 13)
        DAToPlannerDtLabel.TabIndex = 15
        DAToPlannerDtLabel.Text = "To Planner:"
        '
        'DASiteInspectedDtLabel
        '
        DASiteInspectedDtLabel.AutoSize = True
        DASiteInspectedDtLabel.Location = New System.Drawing.Point(232, 22)
        DASiteInspectedDtLabel.Name = "DASiteInspectedDtLabel"
        DASiteInspectedDtLabel.Size = New System.Drawing.Size(78, 13)
        DASiteInspectedDtLabel.TabIndex = 17
        DASiteInspectedDtLabel.Text = "Site Inspected:"
        '
        'RefToPlanComLabel
        '
        RefToPlanComLabel.AutoSize = True
        RefToPlanComLabel.Location = New System.Drawing.Point(199, 46)
        RefToPlanComLabel.Name = "RefToPlanComLabel"
        RefToPlanComLabel.Size = New System.Drawing.Size(111, 13)
        RefToPlanComLabel.TabIndex = 19
        RefToPlanComLabel.Text = "Ref To Plan Comittee:"
        '
        'DAToTypingDtLabel
        '
        DAToTypingDtLabel.AutoSize = True
        DAToTypingDtLabel.Location = New System.Drawing.Point(268, 71)
        DAToTypingDtLabel.Name = "DAToTypingDtLabel"
        DAToTypingDtLabel.Size = New System.Drawing.Size(42, 13)
        DAToTypingDtLabel.TabIndex = 21
        DAToTypingDtLabel.Text = "Typing:"
        '
        'DADetermDtLabel
        '
        DADetermDtLabel.AutoSize = True
        DADetermDtLabel.Location = New System.Drawing.Point(246, 95)
        DADetermDtLabel.Name = "DADetermDtLabel"
        DADetermDtLabel.Size = New System.Drawing.Size(64, 13)
        DADetermDtLabel.TabIndex = 23
        DADetermDtLabel.Text = "Determined:"
        '
        'DAAppNotDtLabel
        '
        DAAppNotDtLabel.AutoSize = True
        DAAppNotDtLabel.Location = New System.Drawing.Point(35, 46)
        DAAppNotDtLabel.Name = "DAAppNotDtLabel"
        DAAppNotDtLabel.Size = New System.Drawing.Size(63, 13)
        DAAppNotDtLabel.TabIndex = 25
        DAAppNotDtLabel.Text = "Notification:"
        '
        'ConsentPostedDateLabel
        '
        ConsentPostedDateLabel.AutoSize = True
        ConsentPostedDateLabel.Location = New System.Drawing.Point(225, 170)
        ConsentPostedDateLabel.Name = "ConsentPostedDateLabel"
        ConsentPostedDateLabel.Size = New System.Drawing.Size(85, 13)
        ConsentPostedDateLabel.TabIndex = 27
        ConsentPostedDateLabel.Text = "Consent Posted:"
        '
        'DAConsentPubDtLabel
        '
        DAConsentPubDtLabel.AutoSize = True
        DAConsentPubDtLabel.Location = New System.Drawing.Point(212, 144)
        DAConsentPubDtLabel.Name = "DAConsentPubDtLabel"
        DAConsentPubDtLabel.Size = New System.Drawing.Size(98, 13)
        DAConsentPubDtLabel.TabIndex = 29
        DAConsentPubDtLabel.Text = "Consent Published:"
        '
        'AddInfoLabel
        '
        AddInfoLabel.AutoSize = True
        AddInfoLabel.Location = New System.Drawing.Point(48, 206)
        AddInfoLabel.Name = "AddInfoLabel"
        AddInfoLabel.Size = New System.Drawing.Size(50, 13)
        AddInfoLabel.TabIndex = 33
        AddInfoLabel.Text = "Add Info:"
        '
        'AIRequestDtLabel
        '
        AIRequestDtLabel.AutoSize = True
        AIRequestDtLabel.Location = New System.Drawing.Point(135, 206)
        AIRequestDtLabel.Name = "AIRequestDtLabel"
        AIRequestDtLabel.Size = New System.Drawing.Size(62, 13)
        AIRequestDtLabel.TabIndex = 35
        AIRequestDtLabel.Text = "Requested:"
        '
        'DAAdvisedDtLabel
        '
        DAAdvisedDtLabel.AutoSize = True
        DAAdvisedDtLabel.Location = New System.Drawing.Point(262, 119)
        DAAdvisedDtLabel.Name = "DAAdvisedDtLabel"
        DAAdvisedDtLabel.Size = New System.Drawing.Size(48, 13)
        DAAdvisedDtLabel.TabIndex = 37
        DAAdvisedDtLabel.Text = "Advised:"
        '
        'DACommDtLabel
        '
        DACommDtLabel.AutoSize = True
        DACommDtLabel.Location = New System.Drawing.Point(29, 71)
        DACommDtLabel.Name = "DACommDtLabel"
        DACommDtLabel.Size = New System.Drawing.Size(69, 13)
        DACommDtLabel.TabIndex = 39
        DACommDtLabel.Text = "Commenced:"
        '
        'DACompletedDtLabel
        '
        DACompletedDtLabel.AutoSize = True
        DACompletedDtLabel.Location = New System.Drawing.Point(6, 95)
        DACompletedDtLabel.Name = "DACompletedDtLabel"
        DACompletedDtLabel.Size = New System.Drawing.Size(92, 13)
        DACompletedDtLabel.TabIndex = 41
        DACompletedDtLabel.Text = "Close Submission:"
        '
        'DAAppNotDtLabel1
        '
        DAAppNotDtLabel1.AutoSize = True
        DAAppNotDtLabel1.Location = New System.Drawing.Point(34, 119)
        DAAppNotDtLabel1.Name = "DAAppNotDtLabel1"
        DAAppNotDtLabel1.Size = New System.Drawing.Size(64, 13)
        DAAppNotDtLabel1.TabIndex = 42
        DAAppNotDtLabel1.Text = "Determined:"
        '
        'DAOfficerNameLabel
        '
        DAOfficerNameLabel.AutoSize = True
        DAOfficerNameLabel.Location = New System.Drawing.Point(9, 89)
        DAOfficerNameLabel.Name = "DAOfficerNameLabel"
        DAOfficerNameLabel.Size = New System.Drawing.Size(68, 13)
        DAOfficerNameLabel.TabIndex = 50
        DAOfficerNameLabel.Text = "Case Officer:"
        '
        'CurrentDAsBindingNavigator
        '
        Me.CurrentDAsBindingNavigator.AddNewItem = Nothing
        Me.CurrentDAsBindingNavigator.BindingSource = Me.CurrentDAsBindingSource
        Me.CurrentDAsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CurrentDAsBindingNavigator.DeleteItem = Nothing
        Me.CurrentDAsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.CurrentDAsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CurrentDAsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CurrentDAsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CurrentDAsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CurrentDAsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CurrentDAsBindingNavigator.Name = "CurrentDAsBindingNavigator"
        Me.CurrentDAsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CurrentDAsBindingNavigator.Size = New System.Drawing.Size(821, 25)
        Me.CurrentDAsBindingNavigator.TabIndex = 0
        Me.CurrentDAsBindingNavigator.Text = "BindingNavigator1"
        '
        'CurrentDAsBindingSource
        '
        Me.CurrentDAsBindingSource.DataMember = "CurrentDAs"
        Me.CurrentDAsBindingSource.DataSource = Me.CZONES
        '
        'CZONES
        '
        Me.CZONES.DataSetName = "CZONES"
        Me.CZONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'DANoTextBox
        '
        Me.DANoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DANoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DANo", True))
        Me.DANoTextBox.Location = New System.Drawing.Point(60, 35)
        Me.DANoTextBox.Name = "DANoTextBox"
        Me.DANoTextBox.ReadOnly = True
        Me.DANoTextBox.Size = New System.Drawing.Size(64, 20)
        Me.DANoTextBox.TabIndex = 3
        '
        'CCNoTextBox
        '
        Me.CCNoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CCNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "CCNo", True))
        Me.CCNoTextBox.Location = New System.Drawing.Point(206, 35)
        Me.CCNoTextBox.Name = "CCNoTextBox"
        Me.CCNoTextBox.ReadOnly = True
        Me.CCNoTextBox.Size = New System.Drawing.Size(66, 20)
        Me.CCNoTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DADPLabel)
        Me.GroupBox1.Controls.Add(Me.DADPTextBox)
        Me.GroupBox1.Controls.Add(DALotLabel)
        Me.GroupBox1.Controls.Add(Me.DALotTextBox)
        Me.GroupBox1.Controls.Add(DALocalityCodeIdLabel)
        Me.GroupBox1.Controls.Add(Me.DALocalityCodeIdTextBox)
        Me.GroupBox1.Controls.Add(Me.DAStreetTextBox)
        Me.GroupBox1.Controls.Add(DAStreetNoLabel)
        Me.GroupBox1.Controls.Add(Me.DAStreetNoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 105)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Property"
        '
        'DADPTextBox
        '
        Me.DADPTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DADPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DADP", True))
        Me.DADPTextBox.Location = New System.Drawing.Point(145, 72)
        Me.DADPTextBox.Name = "DADPTextBox"
        Me.DADPTextBox.ReadOnly = True
        Me.DADPTextBox.Size = New System.Drawing.Size(196, 20)
        Me.DADPTextBox.TabIndex = 8
        '
        'DALotTextBox
        '
        Me.DALotTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DALotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DALot", True))
        Me.DALotTextBox.Location = New System.Drawing.Point(58, 72)
        Me.DALotTextBox.Name = "DALotTextBox"
        Me.DALotTextBox.ReadOnly = True
        Me.DALotTextBox.Size = New System.Drawing.Size(50, 20)
        Me.DALotTextBox.TabIndex = 6
        '
        'DALocalityCodeIdTextBox
        '
        Me.DALocalityCodeIdTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DALocalityCodeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DALocalityCodeId", True))
        Me.DALocalityCodeIdTextBox.Location = New System.Drawing.Point(58, 49)
        Me.DALocalityCodeIdTextBox.Name = "DALocalityCodeIdTextBox"
        Me.DALocalityCodeIdTextBox.ReadOnly = True
        Me.DALocalityCodeIdTextBox.Size = New System.Drawing.Size(283, 20)
        Me.DALocalityCodeIdTextBox.TabIndex = 4
        '
        'DAStreetTextBox
        '
        Me.DAStreetTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAStreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAStreet", True))
        Me.DAStreetTextBox.Location = New System.Drawing.Point(93, 19)
        Me.DAStreetTextBox.Name = "DAStreetTextBox"
        Me.DAStreetTextBox.ReadOnly = True
        Me.DAStreetTextBox.Size = New System.Drawing.Size(248, 20)
        Me.DAStreetTextBox.TabIndex = 3
        '
        'DAStreetNoTextBox
        '
        Me.DAStreetNoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAStreetNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAStreetNo", True))
        Me.DAStreetNoTextBox.Location = New System.Drawing.Point(58, 19)
        Me.DAStreetNoTextBox.Name = "DAStreetNoTextBox"
        Me.DAStreetNoTextBox.ReadOnly = True
        Me.DAStreetNoTextBox.Size = New System.Drawing.Size(29, 20)
        Me.DAStreetNoTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 155)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(10, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(334, 140)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.DAOwnersTownTextBox)
        Me.TabPage1.Controls.Add(DAOwnersPAddrLabel)
        Me.TabPage1.Controls.Add(Me.DAOwnersPAddrTextBox)
        Me.TabPage1.Controls.Add(DAOwnersNameLabel)
        Me.TabPage1.Controls.Add(Me.DAOwnersNameTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(326, 114)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Owners"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DAOwnersTownTextBox
        '
        Me.DAOwnersTownTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAOwnersTownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAOwnersTown", True))
        Me.DAOwnersTownTextBox.Location = New System.Drawing.Point(66, 75)
        Me.DAOwnersTownTextBox.Name = "DAOwnersTownTextBox"
        Me.DAOwnersTownTextBox.ReadOnly = True
        Me.DAOwnersTownTextBox.Size = New System.Drawing.Size(254, 20)
        Me.DAOwnersTownTextBox.TabIndex = 5
        '
        'DAOwnersPAddrTextBox
        '
        Me.DAOwnersPAddrTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAOwnersPAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAOwnersPAddr", True))
        Me.DAOwnersPAddrTextBox.Location = New System.Drawing.Point(66, 49)
        Me.DAOwnersPAddrTextBox.Name = "DAOwnersPAddrTextBox"
        Me.DAOwnersPAddrTextBox.ReadOnly = True
        Me.DAOwnersPAddrTextBox.Size = New System.Drawing.Size(254, 20)
        Me.DAOwnersPAddrTextBox.TabIndex = 3
        '
        'DAOwnersNameTextBox
        '
        Me.DAOwnersNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAOwnersNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAOwnersName", True))
        Me.DAOwnersNameTextBox.Location = New System.Drawing.Point(50, 18)
        Me.DAOwnersNameTextBox.Name = "DAOwnersNameTextBox"
        Me.DAOwnersNameTextBox.ReadOnly = True
        Me.DAOwnersNameTextBox.Size = New System.Drawing.Size(270, 20)
        Me.DAOwnersNameTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.DAAppTownTextBox)
        Me.TabPage2.Controls.Add(DAAppAddrLabel)
        Me.TabPage2.Controls.Add(Me.DAAppAddrTextBox)
        Me.TabPage2.Controls.Add(DAAppNameLabel)
        Me.TabPage2.Controls.Add(Me.DAAppNameTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(326, 114)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Applicant"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DAAppTownTextBox
        '
        Me.DAAppTownTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAAppTownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAppTown", True))
        Me.DAAppTownTextBox.Location = New System.Drawing.Point(66, 75)
        Me.DAAppTownTextBox.Name = "DAAppTownTextBox"
        Me.DAAppTownTextBox.ReadOnly = True
        Me.DAAppTownTextBox.Size = New System.Drawing.Size(211, 20)
        Me.DAAppTownTextBox.TabIndex = 5
        '
        'DAAppAddrTextBox
        '
        Me.DAAppAddrTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAAppAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAppAddr", True))
        Me.DAAppAddrTextBox.Location = New System.Drawing.Point(66, 49)
        Me.DAAppAddrTextBox.Name = "DAAppAddrTextBox"
        Me.DAAppAddrTextBox.ReadOnly = True
        Me.DAAppAddrTextBox.Size = New System.Drawing.Size(211, 20)
        Me.DAAppAddrTextBox.TabIndex = 3
        '
        'DAAppNameTextBox
        '
        Me.DAAppNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAAppNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAppName", True))
        Me.DAAppNameTextBox.Location = New System.Drawing.Point(50, 18)
        Me.DAAppNameTextBox.Name = "DAAppNameTextBox"
        Me.DAAppNameTextBox.ReadOnly = True
        Me.DAAppNameTextBox.Size = New System.Drawing.Size(227, 20)
        Me.DAAppNameTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(CCLicBuilderPhoneLabel)
        Me.TabPage3.Controls.Add(Me.CCLicBuilderPhoneTextBox)
        Me.TabPage3.Controls.Add(CCLicBuilderNoLabel)
        Me.TabPage3.Controls.Add(Me.CCLicBuilderNoTextBox)
        Me.TabPage3.Controls.Add(CCLicBuilderNameLabel)
        Me.TabPage3.Controls.Add(Me.CCLicBuilderNameTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(326, 114)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Builder"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CCLicBuilderPhoneTextBox
        '
        Me.CCLicBuilderPhoneTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CCLicBuilderPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "CCLicBuilderPhone", True))
        Me.CCLicBuilderPhoneTextBox.Location = New System.Drawing.Point(71, 80)
        Me.CCLicBuilderPhoneTextBox.Name = "CCLicBuilderPhoneTextBox"
        Me.CCLicBuilderPhoneTextBox.ReadOnly = True
        Me.CCLicBuilderPhoneTextBox.Size = New System.Drawing.Size(160, 20)
        Me.CCLicBuilderPhoneTextBox.TabIndex = 5
        '
        'CCLicBuilderNoTextBox
        '
        Me.CCLicBuilderNoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CCLicBuilderNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "CCLicBuilderNo", True))
        Me.CCLicBuilderNoTextBox.Location = New System.Drawing.Point(71, 55)
        Me.CCLicBuilderNoTextBox.Name = "CCLicBuilderNoTextBox"
        Me.CCLicBuilderNoTextBox.ReadOnly = True
        Me.CCLicBuilderNoTextBox.Size = New System.Drawing.Size(160, 20)
        Me.CCLicBuilderNoTextBox.TabIndex = 3
        '
        'CCLicBuilderNameTextBox
        '
        Me.CCLicBuilderNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CCLicBuilderNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "CCLicBuilderName", True))
        Me.CCLicBuilderNameTextBox.Location = New System.Drawing.Point(50, 18)
        Me.CCLicBuilderNameTextBox.Name = "CCLicBuilderNameTextBox"
        Me.CCLicBuilderNameTextBox.ReadOnly = True
        Me.CCLicBuilderNameTextBox.Size = New System.Drawing.Size(233, 20)
        Me.CCLicBuilderNameTextBox.TabIndex = 1
        '
        'DADescTextBox
        '
        Me.DADescTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DADescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DADesc", True))
        Me.DADescTextBox.Location = New System.Drawing.Point(356, 35)
        Me.DADescTextBox.Name = "DADescTextBox"
        Me.DADescTextBox.ReadOnly = True
        Me.DADescTextBox.Size = New System.Drawing.Size(442, 20)
        Me.DADescTextBox.TabIndex = 8
        '
        'DAEstCostTextBox
        '
        Me.DAEstCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAEstCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAEstCost", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.DAEstCostTextBox.Location = New System.Drawing.Point(256, 61)
        Me.DAEstCostTextBox.Name = "DAEstCostTextBox"
        Me.DAEstCostTextBox.ReadOnly = True
        Me.DAEstCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DAEstCostTextBox.TabIndex = 10
        '
        'DARegoDtMaskedTextBox
        '
        Me.DARegoDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DARegoDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DARegoDt", True))
        Me.DARegoDtMaskedTextBox.Location = New System.Drawing.Point(104, 20)
        Me.DARegoDtMaskedTextBox.Name = "DARegoDtMaskedTextBox"
        Me.DARegoDtMaskedTextBox.ReadOnly = True
        Me.DARegoDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DARegoDtMaskedTextBox.TabIndex = 12
        '
        'DAFileNoTextBox
        '
        Me.DAFileNoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAFileNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAFileNo", True))
        Me.DAFileNoTextBox.Location = New System.Drawing.Point(60, 61)
        Me.DAFileNoTextBox.Name = "DAFileNoTextBox"
        Me.DAFileNoTextBox.ReadOnly = True
        Me.DAFileNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DAFileNoTextBox.TabIndex = 14
        '
        'DAToPlannerDtMaskedTextBox
        '
        Me.DAToPlannerDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAToPlannerDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAToPlannerDt", True))
        Me.DAToPlannerDtMaskedTextBox.Location = New System.Drawing.Point(104, 141)
        Me.DAToPlannerDtMaskedTextBox.Name = "DAToPlannerDtMaskedTextBox"
        Me.DAToPlannerDtMaskedTextBox.ReadOnly = True
        Me.DAToPlannerDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DAToPlannerDtMaskedTextBox.TabIndex = 16
        '
        'DASiteInspectedDtMaskedTextBox
        '
        Me.DASiteInspectedDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DASiteInspectedDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DASiteInspectedDt", True))
        Me.DASiteInspectedDtMaskedTextBox.Location = New System.Drawing.Point(316, 19)
        Me.DASiteInspectedDtMaskedTextBox.Name = "DASiteInspectedDtMaskedTextBox"
        Me.DASiteInspectedDtMaskedTextBox.ReadOnly = True
        Me.DASiteInspectedDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DASiteInspectedDtMaskedTextBox.TabIndex = 18
        '
        'RefToPlanComMaskedTextBox
        '
        Me.RefToPlanComMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.RefToPlanComMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "RefToPlanCom", True))
        Me.RefToPlanComMaskedTextBox.Location = New System.Drawing.Point(316, 43)
        Me.RefToPlanComMaskedTextBox.Name = "RefToPlanComMaskedTextBox"
        Me.RefToPlanComMaskedTextBox.ReadOnly = True
        Me.RefToPlanComMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.RefToPlanComMaskedTextBox.TabIndex = 20
        '
        'DAToTypingDtMaskedTextBox
        '
        Me.DAToTypingDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAToTypingDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAToTypingDt", True))
        Me.DAToTypingDtMaskedTextBox.Location = New System.Drawing.Point(316, 68)
        Me.DAToTypingDtMaskedTextBox.Name = "DAToTypingDtMaskedTextBox"
        Me.DAToTypingDtMaskedTextBox.ReadOnly = True
        Me.DAToTypingDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DAToTypingDtMaskedTextBox.TabIndex = 22
        '
        'DADetermDtMaskedTextBox
        '
        Me.DADetermDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DADetermDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DADetermDt", True))
        Me.DADetermDtMaskedTextBox.Location = New System.Drawing.Point(316, 92)
        Me.DADetermDtMaskedTextBox.Name = "DADetermDtMaskedTextBox"
        Me.DADetermDtMaskedTextBox.ReadOnly = True
        Me.DADetermDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DADetermDtMaskedTextBox.TabIndex = 24
        '
        'DAAppNotDtMaskedTextBox
        '
        Me.DAAppNotDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAAppNotDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAppNotDt", True))
        Me.DAAppNotDtMaskedTextBox.Location = New System.Drawing.Point(316, 116)
        Me.DAAppNotDtMaskedTextBox.Name = "DAAppNotDtMaskedTextBox"
        Me.DAAppNotDtMaskedTextBox.ReadOnly = True
        Me.DAAppNotDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DAAppNotDtMaskedTextBox.TabIndex = 26
        '
        'ConsentPostedDateMaskedTextBox
        '
        Me.ConsentPostedDateMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ConsentPostedDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "ConsentPostedDate", True))
        Me.ConsentPostedDateMaskedTextBox.Location = New System.Drawing.Point(316, 167)
        Me.ConsentPostedDateMaskedTextBox.Name = "ConsentPostedDateMaskedTextBox"
        Me.ConsentPostedDateMaskedTextBox.ReadOnly = True
        Me.ConsentPostedDateMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.ConsentPostedDateMaskedTextBox.TabIndex = 28
        '
        'DAConsentPubDtMaskedTextBox
        '
        Me.DAConsentPubDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAConsentPubDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAConsentPubDt", True))
        Me.DAConsentPubDtMaskedTextBox.Location = New System.Drawing.Point(316, 141)
        Me.DAConsentPubDtMaskedTextBox.Name = "DAConsentPubDtMaskedTextBox"
        Me.DAConsentPubDtMaskedTextBox.ReadOnly = True
        Me.DAConsentPubDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DAConsentPubDtMaskedTextBox.TabIndex = 30
        '
        'DADecisionIDTextBox
        '
        Me.DADecisionIDTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DADecisionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DADecisionID", True))
        Me.DADecisionIDTextBox.Location = New System.Drawing.Point(192, 22)
        Me.DADecisionIDTextBox.Name = "DADecisionIDTextBox"
        Me.DADecisionIDTextBox.ReadOnly = True
        Me.DADecisionIDTextBox.Size = New System.Drawing.Size(196, 20)
        Me.DADecisionIDTextBox.TabIndex = 32
        '
        'AIRequestDtMaskedTextBox
        '
        Me.AIRequestDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.AIRequestDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "AIRequestDt", True))
        Me.AIRequestDtMaskedTextBox.Location = New System.Drawing.Point(202, 203)
        Me.AIRequestDtMaskedTextBox.Name = "AIRequestDtMaskedTextBox"
        Me.AIRequestDtMaskedTextBox.ReadOnly = True
        Me.AIRequestDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.AIRequestDtMaskedTextBox.TabIndex = 36
        '
        'DAAdvisedDtMaskedTextBox
        '
        Me.DAAdvisedDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAAdvisedDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAdvisedDt", True))
        Me.DAAdvisedDtMaskedTextBox.Location = New System.Drawing.Point(104, 44)
        Me.DAAdvisedDtMaskedTextBox.Name = "DAAdvisedDtMaskedTextBox"
        Me.DAAdvisedDtMaskedTextBox.ReadOnly = True
        Me.DAAdvisedDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DAAdvisedDtMaskedTextBox.TabIndex = 38
        '
        'DACommDtMaskedTextBox
        '
        Me.DACommDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DACommDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DACommDt", True))
        Me.DACommDtMaskedTextBox.Location = New System.Drawing.Point(104, 68)
        Me.DACommDtMaskedTextBox.Name = "DACommDtMaskedTextBox"
        Me.DACommDtMaskedTextBox.ReadOnly = True
        Me.DACommDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DACommDtMaskedTextBox.TabIndex = 40
        '
        'DACompletedDtMaskedTextBox
        '
        Me.DACompletedDtMaskedTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DACompletedDtMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DACompletedDt", True))
        Me.DACompletedDtMaskedTextBox.Location = New System.Drawing.Point(104, 92)
        Me.DACompletedDtMaskedTextBox.Name = "DACompletedDtMaskedTextBox"
        Me.DACompletedDtMaskedTextBox.ReadOnly = True
        Me.DACompletedDtMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.DACompletedDtMaskedTextBox.TabIndex = 42
        '
        'ProgressCodeTextTextBox
        '
        Me.ProgressCodeTextTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressCodeTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "ProgressCodeText", True))
        Me.ProgressCodeTextTextBox.Location = New System.Drawing.Point(6, 22)
        Me.ProgressCodeTextTextBox.Name = "ProgressCodeTextTextBox"
        Me.ProgressCodeTextTextBox.ReadOnly = True
        Me.ProgressCodeTextTextBox.Size = New System.Drawing.Size(180, 20)
        Me.ProgressCodeTextTextBox.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ProgressCodeTextTextBox)
        Me.GroupBox3.Controls.Add(Me.DADecisionIDTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(385, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 56)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Application Status"
        '
        'DAAppNotDtMaskedTextBox1
        '
        Me.DAAppNotDtMaskedTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.DAAppNotDtMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAAppNotDt", True))
        Me.DAAppNotDtMaskedTextBox1.Location = New System.Drawing.Point(104, 116)
        Me.DAAppNotDtMaskedTextBox1.Name = "DAAppNotDtMaskedTextBox1"
        Me.DAAppNotDtMaskedTextBox1.ReadOnly = True
        Me.DAAppNotDtMaskedTextBox1.Size = New System.Drawing.Size(82, 20)
        Me.DAAppNotDtMaskedTextBox1.TabIndex = 43
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AddInfoCheckBox)
        Me.GroupBox4.Controls.Add(Me.DAAppNotDtMaskedTextBox1)
        Me.GroupBox4.Controls.Add(AIRequestDtLabel)
        Me.GroupBox4.Controls.Add(DAAppNotDtLabel1)
        Me.GroupBox4.Controls.Add(Me.AIRequestDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(Me.DAAppNotDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(AddInfoLabel)
        Me.GroupBox4.Controls.Add(DAAdvisedDtLabel)
        Me.GroupBox4.Controls.Add(Me.DACommDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(DACommDtLabel)
        Me.GroupBox4.Controls.Add(DACompletedDtLabel)
        Me.GroupBox4.Controls.Add(Me.DACompletedDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(Me.DAAdvisedDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(DAAppNotDtLabel)
        Me.GroupBox4.Controls.Add(DARegoDtLabel)
        Me.GroupBox4.Controls.Add(Me.DARegoDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(DADetermDtLabel)
        Me.GroupBox4.Controls.Add(ConsentPostedDateLabel)
        Me.GroupBox4.Controls.Add(Me.DADetermDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(DAConsentPubDtLabel)
        Me.GroupBox4.Controls.Add(DAToTypingDtLabel)
        Me.GroupBox4.Controls.Add(Me.ConsentPostedDateMaskedTextBox)
        Me.GroupBox4.Controls.Add(Me.DAToTypingDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(Me.DAToPlannerDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(RefToPlanComLabel)
        Me.GroupBox4.Controls.Add(Me.DAConsentPubDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(Me.RefToPlanComMaskedTextBox)
        Me.GroupBox4.Controls.Add(DAToPlannerDtLabel)
        Me.GroupBox4.Controls.Add(Me.DASiteInspectedDtMaskedTextBox)
        Me.GroupBox4.Controls.Add(DASiteInspectedDtLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(385, 135)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 242)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Key Dates"
        '
        'AddInfoCheckBox
        '
        Me.AddInfoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CurrentDAsBindingSource, "AddInfo", True))
        Me.AddInfoCheckBox.Location = New System.Drawing.Point(104, 201)
        Me.AddInfoCheckBox.Name = "AddInfoCheckBox"
        Me.AddInfoCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.AddInfoCheckBox.TabIndex = 50
        '
        'dgvDAreferrals
        '
        Me.dgvDAreferrals.AllowUserToAddRows = False
        Me.dgvDAreferrals.AllowUserToDeleteRows = False
        Me.dgvDAreferrals.AllowUserToOrderColumns = True
        Me.dgvDAreferrals.AutoGenerateColumns = False
        Me.dgvDAreferrals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDAreferrals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DANoIdDataGridViewTextBoxColumn, Me.RefdtDataGridViewTextBoxColumn, Me.RefRetDtDataGridViewTextBoxColumn, Me.ReferralCodeDataGridViewTextBoxColumn, Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn})
        Me.dgvDAreferrals.DataSource = Me.DAReferralsBindingSource
        Me.dgvDAreferrals.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDAreferrals.Location = New System.Drawing.Point(0, 397)
        Me.dgvDAreferrals.Name = "dgvDAreferrals"
        Me.dgvDAreferrals.ReadOnly = True
        Me.dgvDAreferrals.RowHeadersVisible = False
        Me.dgvDAreferrals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDAreferrals.Size = New System.Drawing.Size(821, 223)
        Me.dgvDAreferrals.TabIndex = 50
        '
        'DANoIdDataGridViewTextBoxColumn
        '
        Me.DANoIdDataGridViewTextBoxColumn.DataPropertyName = "DANoId"
        Me.DANoIdDataGridViewTextBoxColumn.HeaderText = "DANoId"
        Me.DANoIdDataGridViewTextBoxColumn.Name = "DANoIdDataGridViewTextBoxColumn"
        Me.DANoIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.DANoIdDataGridViewTextBoxColumn.Visible = False
        '
        'RefdtDataGridViewTextBoxColumn
        '
        Me.RefdtDataGridViewTextBoxColumn.DataPropertyName = "Refdt"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.RefdtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.RefdtDataGridViewTextBoxColumn.HeaderText = "Referred"
        Me.RefdtDataGridViewTextBoxColumn.Name = "RefdtDataGridViewTextBoxColumn"
        Me.RefdtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RefRetDtDataGridViewTextBoxColumn
        '
        Me.RefRetDtDataGridViewTextBoxColumn.DataPropertyName = "RefRetDt"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RefRetDtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RefRetDtDataGridViewTextBoxColumn.HeaderText = "Returned"
        Me.RefRetDtDataGridViewTextBoxColumn.Name = "RefRetDtDataGridViewTextBoxColumn"
        Me.RefRetDtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferralCodeDataGridViewTextBoxColumn
        '
        Me.ReferralCodeDataGridViewTextBoxColumn.DataPropertyName = "ReferralCode"
        Me.ReferralCodeDataGridViewTextBoxColumn.HeaderText = "To Whom"
        Me.ReferralCodeDataGridViewTextBoxColumn.Name = "ReferralCodeDataGridViewTextBoxColumn"
        Me.ReferralCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferralCodeDataGridViewTextBoxColumn.Width = 200
        '
        'ReferralCodeCategoryDescDataGridViewTextBoxColumn
        '
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn.DataPropertyName = "ReferralCodeCategoryDesc"
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn.Name = "ReferralCodeCategoryDescDataGridViewTextBoxColumn"
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferralCodeCategoryDescDataGridViewTextBoxColumn.Width = 380
        '
        'DAReferralsBindingSource
        '
        Me.DAReferralsBindingSource.DataMember = "DA_Referrals"
        Me.DAReferralsBindingSource.DataSource = Me.CZONES
        '
        'DAOfficerNameTextBox
        '
        Me.DAOfficerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DAOfficerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrentDAsBindingSource, "DAOfficerName", True))
        Me.DAOfficerNameTextBox.Location = New System.Drawing.Point(82, 87)
        Me.DAOfficerNameTextBox.Name = "DAOfficerNameTextBox"
        Me.DAOfficerNameTextBox.ReadOnly = True
        Me.DAOfficerNameTextBox.Size = New System.Drawing.Size(274, 20)
        Me.DAOfficerNameTextBox.TabIndex = 51
        '
        'CurrentDAsTableAdapter
        '
        Me.CurrentDAsTableAdapter.ClearBeforeFill = True
        '
        'DA_ReferralsTableAdapter
        '
        Me.DA_ReferralsTableAdapter.ClearBeforeFill = True
        '
        'CurrentDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 620)
        Me.Controls.Add(DAOfficerNameLabel)
        Me.Controls.Add(Me.DAOfficerNameTextBox)
        Me.Controls.Add(Me.dgvDAreferrals)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(DAFileNoLabel)
        Me.Controls.Add(Me.DAFileNoTextBox)
        Me.Controls.Add(DAEstCostLabel)
        Me.Controls.Add(Me.DAEstCostTextBox)
        Me.Controls.Add(DADescLabel)
        Me.Controls.Add(Me.DADescTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CCNoLabel)
        Me.Controls.Add(Me.CCNoTextBox)
        Me.Controls.Add(DANoLabel)
        Me.Controls.Add(Me.DANoTextBox)
        Me.Controls.Add(Me.CurrentDAsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CurrentDA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Current Development Application"
        CType(Me.CurrentDAsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrentDAsBindingNavigator.ResumeLayout(False)
        Me.CurrentDAsBindingNavigator.PerformLayout()
        CType(Me.CurrentDAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvDAreferrals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAReferralsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents CurrentDAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrentDAsTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.CurrentDAsTableAdapter
    Friend WithEvents CurrentDAsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DANoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DAStreetNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DADPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DALotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DALocalityCodeIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAStreetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DAOwnersTownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAOwnersPAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAOwnersNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAAppNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAAppTownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAAppAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CCLicBuilderPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCLicBuilderNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCLicBuilderNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DADescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAEstCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DARegoDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DAFileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAToPlannerDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DASiteInspectedDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RefToPlanComMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DAToTypingDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DADetermDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DAAppNotDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ConsentPostedDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DAConsentPubDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DADecisionIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AIRequestDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DAAdvisedDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DACommDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DACompletedDtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ProgressCodeTextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DAAppNotDtMaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents AddInfoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents dgvDAreferrals As System.Windows.Forms.DataGridView
    Friend WithEvents DAReferralsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DA_ReferralsTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.DA_ReferralsTableAdapter
    Friend WithEvents DAOfficerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DANoIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefdtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefRetDtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferralCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferralCodeCategoryDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
