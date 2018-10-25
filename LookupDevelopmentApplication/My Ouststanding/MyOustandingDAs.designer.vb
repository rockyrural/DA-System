<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyOustandingDAs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyOustandingDAs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboOfficers = New System.Windows.Forms.ComboBox()
        Me.SelectOfficersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt25 = New System.Windows.Forms.TextBox()
        Me.txt40 = New System.Windows.Forms.TextBox()
        Me.txt100 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Usp_UserCurrentDAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdOutStandingDA = New DevExpress.XtraGrid.GridControl()
        Me.gvwOutStandingDA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDANo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLapsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDaysOver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDADesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colStreet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARegoDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgressComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colPreAssessCompleteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdAdditionalInfo = New DevExpress.XtraGrid.GridControl()
        Me.ToDoListAdditionalInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwAdditionalInfo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDANo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLapsed1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStreet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAIComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grdOutstandingCC = New DevExpress.XtraGrid.GridControl()
        Me.ToDoListCCsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TodoListData = New LookupDevelopmentApplication.TodoListData()
        Me.gvwOutstandingCC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCCAppNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLapsed2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDaysFromDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colCCRegoDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDANo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetworkUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficersComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.grdReferralsList = New DevExpress.XtraGrid.GridControl()
        Me.ToDoListReferralsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwReferralsList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDANo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLapsed3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStreet2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colRefdt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.grdOutStandingAA = New DevExpress.XtraGrid.GridControl()
        Me.Usp_ToDoListAAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwOutStandingAA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAANo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLapsed4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAAType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStreet3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAARegoDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDADecision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.grdAAreferrals = New DevExpress.XtraGrid.GridControl()
        Me.gvwAAreferrals = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DevelopmentSQLDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usp_UserCurrentDAsTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.usp_UserCurrentDAsTableAdapter()
        Me.SelectOfficersTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.SelectOfficersTableAdapter()
        Me.ToDoListAdditionalInfoTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.ToDoListAdditionalInfoTableAdapter()
        Me.ToDoListCCsTableAdapter = New LookupDevelopmentApplication.TodoListDataTableAdapters.ToDoListCCsTableAdapter()
        Me.ToDoListReferralsTableAdapter = New LookupDevelopmentApplication.TodoListDataTableAdapters.ToDoListReferralsTableAdapter()
        Me.Usp_ToDoListAAsTableAdapter = New LookupDevelopmentApplication.TodoListDataTableAdapters.usp_ToDoListAAsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.SelectOfficersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Usp_UserCurrentDAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdOutStandingDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOutStandingDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdAdditionalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDoListAdditionalInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwAdditionalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.grdOutstandingCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDoListCCsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodoListData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOutstandingCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.grdReferralsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDoListReferralsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwReferralsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.grdOutStandingAA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usp_ToDoListAAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOutStandingAA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.grdAAreferrals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwAAreferrals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentSQLDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboOfficers)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 86)
        Me.Panel1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(1041, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(188, 50)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print My List"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(471, 26)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(52, 20)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(258, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total number of development applications:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select Officer to review"
        '
        'cboOfficers
        '
        Me.cboOfficers.DataSource = Me.SelectOfficersBindingSource
        Me.cboOfficers.DisplayMember = "Officer"
        Me.cboOfficers.FormattingEnabled = True
        Me.cboOfficers.Location = New System.Drawing.Point(22, 25)
        Me.cboOfficers.Name = "cboOfficers"
        Me.cboOfficers.Size = New System.Drawing.Size(195, 21)
        Me.cboOfficers.TabIndex = 5
        Me.cboOfficers.ValueMember = "NetworkUser"
        '
        'SelectOfficersBindingSource
        '
        Me.SelectOfficersBindingSource.DataMember = "SelectOfficers"
        Me.SelectOfficersBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'DevelopmentSQLDataSet
        '
        Me.DevelopmentSQLDataSet.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt25)
        Me.Panel2.Controls.Add(Me.txt40)
        Me.Panel2.Controls.Add(Me.txt100)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(603, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 77)
        Me.Panel2.TabIndex = 4
        '
        'txt25
        '
        Me.txt25.BackColor = System.Drawing.SystemColors.Window
        Me.txt25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25.Location = New System.Drawing.Point(121, 50)
        Me.txt25.Name = "txt25"
        Me.txt25.ReadOnly = True
        Me.txt25.Size = New System.Drawing.Size(63, 20)
        Me.txt25.TabIndex = 6
        Me.txt25.TabStop = False
        Me.txt25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt40
        '
        Me.txt40.BackColor = System.Drawing.SystemColors.Window
        Me.txt40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt40.Location = New System.Drawing.Point(121, 28)
        Me.txt40.Name = "txt40"
        Me.txt40.ReadOnly = True
        Me.txt40.Size = New System.Drawing.Size(63, 20)
        Me.txt40.TabIndex = 5
        Me.txt40.TabStop = False
        Me.txt40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt100
        '
        Me.txt100.BackColor = System.Drawing.SystemColors.Window
        Me.txt100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt100.Location = New System.Drawing.Point(121, 6)
        Me.txt100.Name = "txt100"
        Me.txt100.ReadOnly = True
        Me.txt100.Size = New System.Drawing.Size(63, 20)
        Me.txt100.TabIndex = 4
        Me.txt100.TabStop = False
        Me.txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Over 100 days:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(5, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No preass && > 25:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Over 40 days:"
        '
        'Usp_UserCurrentDAsBindingSource
        '
        Me.Usp_UserCurrentDAsBindingSource.DataMember = "usp_UserCurrentDAs"
        Me.Usp_UserCurrentDAsBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1241, 553)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdOutStandingDA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Outstanding DA's"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdOutStandingDA
        '
        Me.grdOutStandingDA.DataSource = Me.Usp_UserCurrentDAsBindingSource
        Me.grdOutStandingDA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOutStandingDA.Location = New System.Drawing.Point(3, 3)
        Me.grdOutStandingDA.MainView = Me.gvwOutStandingDA
        Me.grdOutStandingDA.Name = "grdOutStandingDA"
        Me.grdOutStandingDA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.grdOutStandingDA.Size = New System.Drawing.Size(1227, 521)
        Me.grdOutStandingDA.TabIndex = 2
        Me.grdOutStandingDA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOutStandingDA})
        '
        'gvwOutStandingDA
        '
        Me.gvwOutStandingDA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDANo, Me.colLapsed, Me.colDaysOver, Me.colDADesc, Me.colStreet, Me.colDARegoDt, Me.colProgressComment, Me.colPreAssessCompleteDate, Me.colAI})
        Me.gvwOutStandingDA.GridControl = Me.grdOutStandingDA
        Me.gvwOutStandingDA.Name = "gvwOutStandingDA"
        Me.gvwOutStandingDA.OptionsBehavior.ReadOnly = True
        Me.gvwOutStandingDA.OptionsView.ShowGroupPanel = False
        Me.gvwOutStandingDA.RowHeight = 50
        '
        'colDANo
        '
        Me.colDANo.AppearanceCell.Options.UseTextOptions = True
        Me.colDANo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDANo.Caption = "DA No"
        Me.colDANo.FieldName = "DANo"
        Me.colDANo.Name = "colDANo"
        Me.colDANo.OptionsColumn.AllowEdit = False
        Me.colDANo.OptionsColumn.ReadOnly = True
        Me.colDANo.Visible = True
        Me.colDANo.VisibleIndex = 0
        Me.colDANo.Width = 60
        '
        'colLapsed
        '
        Me.colLapsed.AppearanceCell.Options.UseTextOptions = True
        Me.colLapsed.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colLapsed.Caption = "Lapsed"
        Me.colLapsed.FieldName = "Lapsed"
        Me.colLapsed.Name = "colLapsed"
        Me.colLapsed.OptionsColumn.AllowEdit = False
        Me.colLapsed.OptionsColumn.ReadOnly = True
        Me.colLapsed.Visible = True
        Me.colLapsed.VisibleIndex = 1
        Me.colLapsed.Width = 49
        '
        'colDaysOver
        '
        Me.colDaysOver.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colDaysOver.AppearanceCell.Options.UseForeColor = True
        Me.colDaysOver.AppearanceCell.Options.UseTextOptions = True
        Me.colDaysOver.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDaysOver.Caption = "Days Over"
        Me.colDaysOver.FieldName = "DaysOver"
        Me.colDaysOver.Name = "colDaysOver"
        Me.colDaysOver.OptionsColumn.AllowEdit = False
        Me.colDaysOver.OptionsColumn.ReadOnly = True
        Me.colDaysOver.Visible = True
        Me.colDaysOver.VisibleIndex = 2
        Me.colDaysOver.Width = 68
        '
        'colDADesc
        '
        Me.colDADesc.AppearanceCell.Options.UseTextOptions = True
        Me.colDADesc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDADesc.Caption = "Type"
        Me.colDADesc.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colDADesc.FieldName = "DADesc"
        Me.colDADesc.Name = "colDADesc"
        Me.colDADesc.OptionsColumn.ReadOnly = True
        Me.colDADesc.Visible = True
        Me.colDADesc.VisibleIndex = 3
        Me.colDADesc.Width = 272
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colStreet
        '
        Me.colStreet.AppearanceCell.Options.UseTextOptions = True
        Me.colStreet.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colStreet.Caption = "Location"
        Me.colStreet.FieldName = "Street"
        Me.colStreet.Name = "colStreet"
        Me.colStreet.OptionsColumn.AllowEdit = False
        Me.colStreet.OptionsColumn.ReadOnly = True
        Me.colStreet.Visible = True
        Me.colStreet.VisibleIndex = 4
        Me.colStreet.Width = 215
        '
        'colDARegoDt
        '
        Me.colDARegoDt.AppearanceCell.Options.UseTextOptions = True
        Me.colDARegoDt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDARegoDt.Caption = "Registered"
        Me.colDARegoDt.FieldName = "DARegoDt"
        Me.colDARegoDt.Name = "colDARegoDt"
        Me.colDARegoDt.OptionsColumn.AllowEdit = False
        Me.colDARegoDt.OptionsColumn.ReadOnly = True
        Me.colDARegoDt.Visible = True
        Me.colDARegoDt.VisibleIndex = 5
        Me.colDARegoDt.Width = 79
        '
        'colProgressComment
        '
        Me.colProgressComment.AppearanceCell.Options.UseTextOptions = True
        Me.colProgressComment.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colProgressComment.Caption = "Comment"
        Me.colProgressComment.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colProgressComment.FieldName = "ProgressComment"
        Me.colProgressComment.Name = "colProgressComment"
        Me.colProgressComment.OptionsColumn.ReadOnly = True
        Me.colProgressComment.Visible = True
        Me.colProgressComment.VisibleIndex = 6
        Me.colProgressComment.Width = 306
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colPreAssessCompleteDate
        '
        Me.colPreAssessCompleteDate.AppearanceCell.Options.UseTextOptions = True
        Me.colPreAssessCompleteDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colPreAssessCompleteDate.Caption = "Pre Assess"
        Me.colPreAssessCompleteDate.FieldName = "PreAssessCompleteDate"
        Me.colPreAssessCompleteDate.Name = "colPreAssessCompleteDate"
        Me.colPreAssessCompleteDate.OptionsColumn.AllowEdit = False
        Me.colPreAssessCompleteDate.OptionsColumn.ReadOnly = True
        Me.colPreAssessCompleteDate.Visible = True
        Me.colPreAssessCompleteDate.VisibleIndex = 7
        Me.colPreAssessCompleteDate.Width = 134
        '
        'colAI
        '
        Me.colAI.AppearanceCell.Options.UseTextOptions = True
        Me.colAI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colAI.Caption = "AI"
        Me.colAI.FieldName = "AI"
        Me.colAI.Name = "colAI"
        Me.colAI.OptionsColumn.AllowEdit = False
        Me.colAI.OptionsColumn.ReadOnly = True
        Me.colAI.Visible = True
        Me.colAI.VisibleIndex = 8
        Me.colAI.Width = 32
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdAdditionalInfo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "My Outstanding Additional Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdAdditionalInfo
        '
        Me.grdAdditionalInfo.DataSource = Me.ToDoListAdditionalInfoBindingSource
        Me.grdAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAdditionalInfo.Location = New System.Drawing.Point(3, 3)
        Me.grdAdditionalInfo.MainView = Me.gvwAdditionalInfo
        Me.grdAdditionalInfo.Name = "grdAdditionalInfo"
        Me.grdAdditionalInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit3})
        Me.grdAdditionalInfo.Size = New System.Drawing.Size(1227, 521)
        Me.grdAdditionalInfo.TabIndex = 1
        Me.grdAdditionalInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwAdditionalInfo})
        '
        'ToDoListAdditionalInfoBindingSource
        '
        Me.ToDoListAdditionalInfoBindingSource.DataMember = "ToDoListAdditionalInfo"
        Me.ToDoListAdditionalInfoBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'gvwAdditionalInfo
        '
        Me.gvwAdditionalInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDANo1, Me.colLapsed1, Me.colStreet1, Me.colAIComment})
        Me.gvwAdditionalInfo.GridControl = Me.grdAdditionalInfo
        Me.gvwAdditionalInfo.Name = "gvwAdditionalInfo"
        Me.gvwAdditionalInfo.OptionsBehavior.ReadOnly = True
        Me.gvwAdditionalInfo.OptionsView.ShowGroupPanel = False
        Me.gvwAdditionalInfo.RowHeight = 40
        '
        'colDANo1
        '
        Me.colDANo1.AppearanceCell.Options.UseTextOptions = True
        Me.colDANo1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDANo1.Caption = "DA No"
        Me.colDANo1.FieldName = "DANo"
        Me.colDANo1.Name = "colDANo1"
        Me.colDANo1.OptionsColumn.AllowEdit = False
        Me.colDANo1.OptionsColumn.ReadOnly = True
        Me.colDANo1.Visible = True
        Me.colDANo1.VisibleIndex = 0
        Me.colDANo1.Width = 58
        '
        'colLapsed1
        '
        Me.colLapsed1.AppearanceCell.Options.UseTextOptions = True
        Me.colLapsed1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colLapsed1.Caption = "Lapsed"
        Me.colLapsed1.FieldName = "Lapsed"
        Me.colLapsed1.Name = "colLapsed1"
        Me.colLapsed1.OptionsColumn.AllowEdit = False
        Me.colLapsed1.OptionsColumn.ReadOnly = True
        Me.colLapsed1.Visible = True
        Me.colLapsed1.VisibleIndex = 1
        Me.colLapsed1.Width = 47
        '
        'colStreet1
        '
        Me.colStreet1.AppearanceCell.Options.UseTextOptions = True
        Me.colStreet1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colStreet1.Caption = "Street"
        Me.colStreet1.FieldName = "Street"
        Me.colStreet1.Name = "colStreet1"
        Me.colStreet1.OptionsColumn.AllowEdit = False
        Me.colStreet1.OptionsColumn.ReadOnly = True
        Me.colStreet1.Visible = True
        Me.colStreet1.VisibleIndex = 2
        Me.colStreet1.Width = 247
        '
        'colAIComment
        '
        Me.colAIComment.AppearanceCell.Options.UseTextOptions = True
        Me.colAIComment.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colAIComment.Caption = "Comment"
        Me.colAIComment.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colAIComment.FieldName = "AIComment"
        Me.colAIComment.Name = "colAIComment"
        Me.colAIComment.OptionsColumn.ReadOnly = True
        Me.colAIComment.Visible = True
        Me.colAIComment.VisibleIndex = 3
        Me.colAIComment.Width = 860
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.grdOutstandingCC)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My Outstanding CCs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grdOutstandingCC
        '
        Me.grdOutstandingCC.DataSource = Me.ToDoListCCsBindingSource
        Me.grdOutstandingCC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOutstandingCC.Location = New System.Drawing.Point(3, 3)
        Me.grdOutstandingCC.MainView = Me.gvwOutstandingCC
        Me.grdOutstandingCC.Name = "grdOutstandingCC"
        Me.grdOutstandingCC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5})
        Me.grdOutstandingCC.Size = New System.Drawing.Size(1227, 521)
        Me.grdOutstandingCC.TabIndex = 1
        Me.grdOutstandingCC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOutstandingCC})
        '
        'ToDoListCCsBindingSource
        '
        Me.ToDoListCCsBindingSource.DataMember = "ToDoListCCs"
        Me.ToDoListCCsBindingSource.DataSource = Me.TodoListData
        '
        'TodoListData
        '
        Me.TodoListData.DataSetName = "TodoListData"
        Me.TodoListData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvwOutstandingCC
        '
        Me.gvwOutstandingCC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCCAppNo, Me.colLapsed2, Me.colDaysFromDA, Me.colLocation, Me.colCCDesc, Me.colCCRegoDt, Me.colDANo2, Me.colNetworkUser, Me.colOfficersComment})
        Me.gvwOutstandingCC.GridControl = Me.grdOutstandingCC
        Me.gvwOutstandingCC.Name = "gvwOutstandingCC"
        Me.gvwOutstandingCC.OptionsBehavior.ReadOnly = True
        Me.gvwOutstandingCC.OptionsView.ShowGroupPanel = False
        Me.gvwOutstandingCC.RowHeight = 40
        '
        'colCCAppNo
        '
        Me.colCCAppNo.AppearanceCell.Options.UseTextOptions = True
        Me.colCCAppNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colCCAppNo.Caption = "CC No"
        Me.colCCAppNo.FieldName = "CCAppNo"
        Me.colCCAppNo.Name = "colCCAppNo"
        Me.colCCAppNo.OptionsColumn.AllowEdit = False
        Me.colCCAppNo.OptionsColumn.ReadOnly = True
        Me.colCCAppNo.Visible = True
        Me.colCCAppNo.VisibleIndex = 0
        Me.colCCAppNo.Width = 65
        '
        'colLapsed2
        '
        Me.colLapsed2.AppearanceCell.Options.UseTextOptions = True
        Me.colLapsed2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colLapsed2.Caption = "Lapsed"
        Me.colLapsed2.FieldName = "Lapsed"
        Me.colLapsed2.Name = "colLapsed2"
        Me.colLapsed2.OptionsColumn.AllowEdit = False
        Me.colLapsed2.OptionsColumn.ReadOnly = True
        Me.colLapsed2.Visible = True
        Me.colLapsed2.VisibleIndex = 1
        Me.colLapsed2.Width = 47
        '
        'colDaysFromDA
        '
        Me.colDaysFromDA.AppearanceCell.Options.UseTextOptions = True
        Me.colDaysFromDA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colDaysFromDA.Caption = "Days Over"
        Me.colDaysFromDA.FieldName = "DaysFromDA"
        Me.colDaysFromDA.Name = "colDaysFromDA"
        Me.colDaysFromDA.OptionsColumn.AllowEdit = False
        Me.colDaysFromDA.OptionsColumn.ReadOnly = True
        Me.colDaysFromDA.Visible = True
        Me.colDaysFromDA.VisibleIndex = 2
        Me.colDaysFromDA.Width = 65
        '
        'colLocation
        '
        Me.colLocation.AppearanceCell.Options.UseTextOptions = True
        Me.colLocation.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colLocation.Caption = "Location"
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.OptionsColumn.AllowEdit = False
        Me.colLocation.OptionsColumn.ReadOnly = True
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 3
        Me.colLocation.Width = 218
        '
        'colCCDesc
        '
        Me.colCCDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colCCDesc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colCCDesc.Caption = "Description"
        Me.colCCDesc.ColumnEdit = Me.RepositoryItemMemoEdit5
        Me.colCCDesc.FieldName = "CCDesc"
        Me.colCCDesc.Name = "colCCDesc"
        Me.colCCDesc.OptionsColumn.ReadOnly = True
        Me.colCCDesc.Visible = True
        Me.colCCDesc.VisibleIndex = 4
        Me.colCCDesc.Width = 354
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        '
        'colCCRegoDt
        '
        Me.colCCRegoDt.AppearanceCell.Options.UseTextOptions = True
        Me.colCCRegoDt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colCCRegoDt.Caption = "Registered"
        Me.colCCRegoDt.FieldName = "CCRegoDt"
        Me.colCCRegoDt.Name = "colCCRegoDt"
        Me.colCCRegoDt.OptionsColumn.AllowEdit = False
        Me.colCCRegoDt.OptionsColumn.ReadOnly = True
        Me.colCCRegoDt.Visible = True
        Me.colCCRegoDt.VisibleIndex = 5
        Me.colCCRegoDt.Width = 65
        '
        'colDANo2
        '
        Me.colDANo2.FieldName = "DANo"
        Me.colDANo2.Name = "colDANo2"
        '
        'colNetworkUser
        '
        Me.colNetworkUser.FieldName = "NetworkUser"
        Me.colNetworkUser.Name = "colNetworkUser"
        '
        'colOfficersComment
        '
        Me.colOfficersComment.AppearanceCell.Options.UseTextOptions = True
        Me.colOfficersComment.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colOfficersComment.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.colOfficersComment.Caption = "Comments"
        Me.colOfficersComment.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.colOfficersComment.FieldName = "OfficersComment"
        Me.colOfficersComment.Name = "colOfficersComment"
        Me.colOfficersComment.OptionsColumn.ReadOnly = True
        Me.colOfficersComment.Visible = True
        Me.colOfficersComment.VisibleIndex = 6
        Me.colOfficersComment.Width = 395
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.grdReferralsList)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "My Outstanding Referrals"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'grdReferralsList
        '
        Me.grdReferralsList.DataSource = Me.ToDoListReferralsBindingSource
        Me.grdReferralsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdReferralsList.Location = New System.Drawing.Point(3, 3)
        Me.grdReferralsList.MainView = Me.gvwReferralsList
        Me.grdReferralsList.Name = "grdReferralsList"
        Me.grdReferralsList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit6})
        Me.grdReferralsList.Size = New System.Drawing.Size(1227, 521)
        Me.grdReferralsList.TabIndex = 1
        Me.grdReferralsList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwReferralsList})
        '
        'ToDoListReferralsBindingSource
        '
        Me.ToDoListReferralsBindingSource.DataMember = "ToDoListReferrals"
        Me.ToDoListReferralsBindingSource.DataSource = Me.TodoListData
        '
        'gvwReferralsList
        '
        Me.gvwReferralsList.Appearance.Row.Options.UseTextOptions = True
        Me.gvwReferralsList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwReferralsList.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwReferralsList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDANo3, Me.colLapsed3, Me.colStreet2, Me.colRefComment, Me.colRefdt})
        Me.gvwReferralsList.GridControl = Me.grdReferralsList
        Me.gvwReferralsList.Name = "gvwReferralsList"
        Me.gvwReferralsList.OptionsBehavior.ReadOnly = True
        Me.gvwReferralsList.OptionsView.ShowGroupPanel = False
        Me.gvwReferralsList.RowHeight = 40
        '
        'colDANo3
        '
        Me.colDANo3.Caption = "DA No"
        Me.colDANo3.FieldName = "DANo"
        Me.colDANo3.Name = "colDANo3"
        Me.colDANo3.OptionsColumn.AllowEdit = False
        Me.colDANo3.OptionsColumn.ReadOnly = True
        Me.colDANo3.Visible = True
        Me.colDANo3.VisibleIndex = 0
        Me.colDANo3.Width = 66
        '
        'colLapsed3
        '
        Me.colLapsed3.Caption = "Lapsed"
        Me.colLapsed3.FieldName = "Lapsed"
        Me.colLapsed3.Name = "colLapsed3"
        Me.colLapsed3.OptionsColumn.AllowEdit = False
        Me.colLapsed3.OptionsColumn.ReadOnly = True
        Me.colLapsed3.Visible = True
        Me.colLapsed3.VisibleIndex = 1
        Me.colLapsed3.Width = 52
        '
        'colStreet2
        '
        Me.colStreet2.Caption = "Location"
        Me.colStreet2.FieldName = "Street"
        Me.colStreet2.Name = "colStreet2"
        Me.colStreet2.Visible = True
        Me.colStreet2.VisibleIndex = 2
        Me.colStreet2.Width = 327
        '
        'colRefComment
        '
        Me.colRefComment.Caption = "Comments"
        Me.colRefComment.ColumnEdit = Me.RepositoryItemMemoEdit6
        Me.colRefComment.FieldName = "RefComment"
        Me.colRefComment.Name = "colRefComment"
        Me.colRefComment.OptionsColumn.ReadOnly = True
        Me.colRefComment.Visible = True
        Me.colRefComment.VisibleIndex = 3
        Me.colRefComment.Width = 687
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RepositoryItemMemoEdit6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'colRefdt
        '
        Me.colRefdt.Caption = "Date"
        Me.colRefdt.FieldName = "Refdt"
        Me.colRefdt.Name = "colRefdt"
        Me.colRefdt.OptionsColumn.AllowEdit = False
        Me.colRefdt.OptionsColumn.ReadOnly = True
        Me.colRefdt.Visible = True
        Me.colRefdt.VisibleIndex = 4
        Me.colRefdt.Width = 83
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.grdOutStandingAA)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "My Outstanding AAs"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'grdOutStandingAA
        '
        Me.grdOutStandingAA.DataSource = Me.Usp_ToDoListAAsBindingSource
        Me.grdOutStandingAA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOutStandingAA.Location = New System.Drawing.Point(3, 3)
        Me.grdOutStandingAA.MainView = Me.gvwOutStandingAA
        Me.grdOutStandingAA.Name = "grdOutStandingAA"
        Me.grdOutStandingAA.Size = New System.Drawing.Size(1227, 521)
        Me.grdOutStandingAA.TabIndex = 1
        Me.grdOutStandingAA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOutStandingAA})
        '
        'Usp_ToDoListAAsBindingSource
        '
        Me.Usp_ToDoListAAsBindingSource.DataMember = "usp_ToDoListAAs"
        Me.Usp_ToDoListAAsBindingSource.DataSource = Me.TodoListData
        '
        'gvwOutStandingAA
        '
        Me.gvwOutStandingAA.Appearance.Row.Options.UseTextOptions = True
        Me.gvwOutStandingAA.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwOutStandingAA.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwOutStandingAA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAANo, Me.colLapsed4, Me.colAAType, Me.colStreet3, Me.colAARegoDt, Me.colAI1, Me.colDADecision})
        Me.gvwOutStandingAA.GridControl = Me.grdOutStandingAA
        Me.gvwOutStandingAA.Name = "gvwOutStandingAA"
        Me.gvwOutStandingAA.OptionsBehavior.Editable = False
        Me.gvwOutStandingAA.OptionsBehavior.ReadOnly = True
        Me.gvwOutStandingAA.OptionsView.ShowGroupPanel = False
        Me.gvwOutStandingAA.RowHeight = 30
        '
        'colAANo
        '
        Me.colAANo.Caption = "AA No"
        Me.colAANo.FieldName = "AANo"
        Me.colAANo.Name = "colAANo"
        Me.colAANo.Visible = True
        Me.colAANo.VisibleIndex = 0
        Me.colAANo.Width = 61
        '
        'colLapsed4
        '
        Me.colLapsed4.Caption = "Lapsed"
        Me.colLapsed4.FieldName = "Lapsed"
        Me.colLapsed4.Name = "colLapsed4"
        Me.colLapsed4.Visible = True
        Me.colLapsed4.VisibleIndex = 1
        Me.colLapsed4.Width = 55
        '
        'colAAType
        '
        Me.colAAType.Caption = "AA Type"
        Me.colAAType.FieldName = "AAType"
        Me.colAAType.Name = "colAAType"
        Me.colAAType.Visible = True
        Me.colAAType.VisibleIndex = 2
        Me.colAAType.Width = 283
        '
        'colStreet3
        '
        Me.colStreet3.Caption = "Location"
        Me.colStreet3.FieldName = "Street"
        Me.colStreet3.Name = "colStreet3"
        Me.colStreet3.Visible = True
        Me.colStreet3.VisibleIndex = 3
        Me.colStreet3.Width = 300
        '
        'colAARegoDt
        '
        Me.colAARegoDt.Caption = "Registered"
        Me.colAARegoDt.FieldName = "AARegoDt"
        Me.colAARegoDt.Name = "colAARegoDt"
        Me.colAARegoDt.Visible = True
        Me.colAARegoDt.VisibleIndex = 4
        Me.colAARegoDt.Width = 81
        '
        'colAI1
        '
        Me.colAI1.Caption = "AI"
        Me.colAI1.FieldName = "AI"
        Me.colAI1.Name = "colAI1"
        Me.colAI1.Visible = True
        Me.colAI1.VisibleIndex = 5
        Me.colAI1.Width = 51
        '
        'colDADecision
        '
        Me.colDADecision.Caption = "Status"
        Me.colDADecision.FieldName = "DADecision"
        Me.colDADecision.Name = "colDADecision"
        Me.colDADecision.Visible = True
        Me.colDADecision.VisibleIndex = 6
        Me.colDADecision.Width = 378
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.grdAAreferrals)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1233, 527)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "My Outstanding AA Referal"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'grdAAreferrals
        '
        Me.grdAAreferrals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAAreferrals.Location = New System.Drawing.Point(0, 0)
        Me.grdAAreferrals.MainView = Me.gvwAAreferrals
        Me.grdAAreferrals.Name = "grdAAreferrals"
        Me.grdAAreferrals.Size = New System.Drawing.Size(1233, 527)
        Me.grdAAreferrals.TabIndex = 2
        Me.grdAAreferrals.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwAAreferrals})
        '
        'gvwAAreferrals
        '
        Me.gvwAAreferrals.Appearance.Row.Options.UseTextOptions = True
        Me.gvwAAreferrals.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.gvwAAreferrals.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gvwAAreferrals.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvwAAreferrals.GridControl = Me.grdAAreferrals
        Me.gvwAAreferrals.Name = "gvwAAreferrals"
        Me.gvwAAreferrals.OptionsBehavior.Editable = False
        Me.gvwAAreferrals.OptionsBehavior.ReadOnly = True
        Me.gvwAAreferrals.OptionsView.ShowGroupPanel = False
        Me.gvwAAreferrals.RowHeight = 40
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "AA No"
        Me.GridColumn1.FieldName = "AANo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Lapsed"
        Me.GridColumn2.FieldName = "Lapsed"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 56
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Location"
        Me.GridColumn3.FieldName = "Street"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 269
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Comments"
        Me.GridColumn4.FieldName = "RefComment"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 712
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Date"
        Me.GridColumn5.FieldName = "Refdt"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 103
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "NetworkUser"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'DevelopmentSQLDataSetBindingSource
        '
        Me.DevelopmentSQLDataSetBindingSource.DataSource = Me.DevelopmentSQLDataSet
        Me.DevelopmentSQLDataSetBindingSource.Position = 0
        '
        'Usp_UserCurrentDAsTableAdapter
        '
        Me.Usp_UserCurrentDAsTableAdapter.ClearBeforeFill = True
        '
        'SelectOfficersTableAdapter
        '
        Me.SelectOfficersTableAdapter.ClearBeforeFill = True
        '
        'ToDoListAdditionalInfoTableAdapter
        '
        Me.ToDoListAdditionalInfoTableAdapter.ClearBeforeFill = True
        '
        'ToDoListCCsTableAdapter
        '
        Me.ToDoListCCsTableAdapter.ClearBeforeFill = True
        '
        'ToDoListReferralsTableAdapter
        '
        Me.ToDoListReferralsTableAdapter.ClearBeforeFill = True
        '
        'Usp_ToDoListAAsTableAdapter
        '
        Me.Usp_ToDoListAAsTableAdapter.ClearBeforeFill = True
        '
        'MyOustandingDAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 639)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MyOustandingDAs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Oustanding DA's"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SelectOfficersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Usp_UserCurrentDAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdOutStandingDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOutStandingDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdAdditionalInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDoListAdditionalInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwAdditionalInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.grdOutstandingCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDoListCCsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodoListData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOutstandingCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.grdReferralsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDoListReferralsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwReferralsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.grdOutStandingAA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usp_ToDoListAAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOutStandingAA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.grdAAreferrals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwAAreferrals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentSQLDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DevelopmentSQLDataSet As LookupDevelopmentApplication.DevelopmentSQLDataSet
    Friend WithEvents Usp_UserCurrentDAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_UserCurrentDAsTableAdapter As LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.usp_UserCurrentDAsTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboOfficers As System.Windows.Forms.ComboBox
    Friend WithEvents SelectOfficersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectOfficersTableAdapter As LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.SelectOfficersTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt25 As System.Windows.Forms.TextBox
    Friend WithEvents txt40 As System.Windows.Forms.TextBox
    Friend WithEvents txt100 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToDoListAdditionalInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToDoListAdditionalInfoTableAdapter As LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.ToDoListAdditionalInfoTableAdapter
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DevelopmentSQLDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TodoListData As LookupDevelopmentApplication.TodoListData
    Friend WithEvents ToDoListCCsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToDoListCCsTableAdapter As LookupDevelopmentApplication.TodoListDataTableAdapters.ToDoListCCsTableAdapter
    Friend WithEvents ToDoListReferralsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToDoListReferralsTableAdapter As LookupDevelopmentApplication.TodoListDataTableAdapters.ToDoListReferralsTableAdapter
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Usp_ToDoListAAsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_ToDoListAAsTableAdapter As LookupDevelopmentApplication.TodoListDataTableAdapters.usp_ToDoListAAsTableAdapter
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents grdOutStandingDA As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOutStandingDA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDANo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLapsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDaysOver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDADesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStreet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDARegoDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgressComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreAssessCompleteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grdAdditionalInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwAdditionalInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDANo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLapsed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStreet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAIComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grdOutstandingCC As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOutstandingCC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCCAppNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLapsed2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDaysFromDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colCCRegoDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDANo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetworkUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficersComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grdReferralsList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwReferralsList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDANo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLapsed3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStreet2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colRefdt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdOutStandingAA As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOutStandingAA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAANo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLapsed4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAAType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStreet3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAARegoDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDADecision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdAAreferrals As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwAAreferrals As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
