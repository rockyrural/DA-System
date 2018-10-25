<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouncilVoting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CouncilVoting))
        Me.CouncilVotingDataSet = New LookupDevelopmentApplication.CouncilVotingDataSet()
        Me.CouncilDeterminedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CouncilDeterminedTableAdapter = New LookupDevelopmentApplication.CouncilVotingDataSetTableAdapters.CouncilDeterminedTableAdapter()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CouncilDeterminedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CouncilDeterminedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DANoTextBox = New System.Windows.Forms.TextBox()
        Me.MinuteNoTextBox = New System.Windows.Forms.TextBox()
        Me.MotionTextBox = New System.Windows.Forms.TextBox()
        Me.btnMeetingDt = New System.Windows.Forms.Button()
        Me.MeetingDt = New System.Windows.Forms.MaskedTextBox()
        Me.cboThomsonF = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboVardonC = New System.Windows.Forms.ComboBox()
        Me.cboBrownA = New System.Windows.Forms.ComboBox()
        Me.cboBrownL = New System.Windows.Forms.ComboBox()
        Me.cboDanceK = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboScobieG = New System.Windows.Forms.ComboBox()
        Me.cboPollockR = New System.Windows.Forms.ComboBox()
        Me.cboMortonA = New System.Windows.Forms.ComboBox()
        Me.cboKowalC = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.CouncilVotingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouncilDeterminedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouncilDeterminedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CouncilDeterminedBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CouncilVotingDataSet
        '
        Me.CouncilVotingDataSet.DataSetName = "CouncilVotingDataSet"
        Me.CouncilVotingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CouncilDeterminedBindingSource
        '
        Me.CouncilDeterminedBindingSource.DataMember = "CouncilDetermined"
        Me.CouncilDeterminedBindingSource.DataSource = Me.CouncilVotingDataSet
        '
        'CouncilDeterminedTableAdapter
        '
        Me.CouncilDeterminedTableAdapter.ClearBeforeFill = True
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CouncilDeterminedBindingNavigatorSaveItem
        '
        Me.CouncilDeterminedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CouncilDeterminedBindingNavigatorSaveItem.Image = CType(resources.GetObject("CouncilDeterminedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CouncilDeterminedBindingNavigatorSaveItem.Name = "CouncilDeterminedBindingNavigatorSaveItem"
        Me.CouncilDeterminedBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CouncilDeterminedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CouncilDeterminedBindingNavigator
        '
        Me.CouncilDeterminedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CouncilDeterminedBindingNavigator.BindingSource = Me.CouncilDeterminedBindingSource
        Me.CouncilDeterminedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CouncilDeterminedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CouncilDeterminedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CouncilDeterminedBindingNavigatorSaveItem})
        Me.CouncilDeterminedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CouncilDeterminedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CouncilDeterminedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CouncilDeterminedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CouncilDeterminedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CouncilDeterminedBindingNavigator.Name = "CouncilDeterminedBindingNavigator"
        Me.CouncilDeterminedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CouncilDeterminedBindingNavigator.Size = New System.Drawing.Size(786, 25)
        Me.CouncilDeterminedBindingNavigator.TabIndex = 0
        Me.CouncilDeterminedBindingNavigator.Text = "BindingNavigator1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "DA No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Meeting Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minute No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Motion"
        '
        'DANoTextBox
        '
        Me.DANoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CouncilDeterminedBindingSource, "DANo", True))
        Me.DANoTextBox.Location = New System.Drawing.Point(102, 32)
        Me.DANoTextBox.Name = "DANoTextBox"
        Me.DANoTextBox.Size = New System.Drawing.Size(421, 20)
        Me.DANoTextBox.TabIndex = 5
        '
        'MinuteNoTextBox
        '
        Me.MinuteNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CouncilDeterminedBindingSource, "MinuteNo", True))
        Me.MinuteNoTextBox.Location = New System.Drawing.Point(102, 77)
        Me.MinuteNoTextBox.Name = "MinuteNoTextBox"
        Me.MinuteNoTextBox.Size = New System.Drawing.Size(421, 20)
        Me.MinuteNoTextBox.TabIndex = 7
        '
        'MotionTextBox
        '
        Me.MotionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CouncilDeterminedBindingSource, "Motion", True))
        Me.MotionTextBox.Location = New System.Drawing.Point(102, 99)
        Me.MotionTextBox.Name = "MotionTextBox"
        Me.MotionTextBox.Size = New System.Drawing.Size(421, 20)
        Me.MotionTextBox.TabIndex = 8
        '
        'btnMeetingDt
        '
        Me.btnMeetingDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMeetingDt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMeetingDt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMeetingDt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMeetingDt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeetingDt.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMeetingDt.Location = New System.Drawing.Point(169, 53)
        Me.btnMeetingDt.Name = "btnMeetingDt"
        Me.btnMeetingDt.Size = New System.Drawing.Size(20, 20)
        Me.btnMeetingDt.TabIndex = 54
        Me.btnMeetingDt.Text = "u"
        Me.btnMeetingDt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMeetingDt.UseVisualStyleBackColor = False
        '
        'MeetingDt
        '
        Me.MeetingDt.BackColor = System.Drawing.SystemColors.Window
        Me.MeetingDt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CouncilDeterminedBindingSource, "MeetingDate", True))
        Me.MeetingDt.Location = New System.Drawing.Point(102, 53)
        Me.MeetingDt.Name = "MeetingDt"
        Me.MeetingDt.ReadOnly = True
        Me.MeetingDt.Size = New System.Drawing.Size(65, 20)
        Me.MeetingDt.TabIndex = 53
        Me.MeetingDt.TabStop = False
        Me.MeetingDt.ValidatingType = GetType(Date)
        '
        'cboThomsonF
        '
        Me.cboThomsonF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "ThomsonF", True))
        Me.cboThomsonF.FormattingEnabled = True
        Me.cboThomsonF.Location = New System.Drawing.Point(137, 152)
        Me.cboThomsonF.Name = "cboThomsonF"
        Me.cboThomsonF.Size = New System.Drawing.Size(52, 21)
        Me.cboThomsonF.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "THOMSON, Fergus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "VARDON, Chris"
        '
        'cboVardonC
        '
        Me.cboVardonC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "VardonC", True))
        Me.cboVardonC.FormattingEnabled = True
        Me.cboVardonC.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboVardonC.Location = New System.Drawing.Point(137, 179)
        Me.cboVardonC.Name = "cboVardonC"
        Me.cboVardonC.Size = New System.Drawing.Size(52, 21)
        Me.cboVardonC.TabIndex = 58
        '
        'cboBrownA
        '
        Me.cboBrownA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "BrownA", True))
        Me.cboBrownA.FormattingEnabled = True
        Me.cboBrownA.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboBrownA.Location = New System.Drawing.Point(137, 206)
        Me.cboBrownA.Name = "cboBrownA"
        Me.cboBrownA.Size = New System.Drawing.Size(52, 21)
        Me.cboBrownA.TabIndex = 59
        '
        'cboBrownL
        '
        Me.cboBrownL.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "BrownL", True))
        Me.cboBrownL.FormattingEnabled = True
        Me.cboBrownL.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboBrownL.Location = New System.Drawing.Point(137, 233)
        Me.cboBrownL.Name = "cboBrownL"
        Me.cboBrownL.Size = New System.Drawing.Size(52, 21)
        Me.cboBrownL.TabIndex = 60
        '
        'cboDanceK
        '
        Me.cboDanceK.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "DanceK", True))
        Me.cboDanceK.FormattingEnabled = True
        Me.cboDanceK.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboDanceK.Location = New System.Drawing.Point(137, 260)
        Me.cboDanceK.Name = "cboDanceK"
        Me.cboDanceK.Size = New System.Drawing.Size(52, 21)
        Me.cboDanceK.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "BROWN, Allan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "BROWN, Lindsay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "DANCE, Keith"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "SCOBIE, Graham"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(248, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "POLLOCK, Rob"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Morton, Alan"
        '
        'cboScobieG
        '
        Me.cboScobieG.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "ScobieG", True))
        Me.cboScobieG.FormattingEnabled = True
        Me.cboScobieG.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboScobieG.Location = New System.Drawing.Point(376, 233)
        Me.cboScobieG.Name = "cboScobieG"
        Me.cboScobieG.Size = New System.Drawing.Size(52, 21)
        Me.cboScobieG.TabIndex = 69
        '
        'cboPollockR
        '
        Me.cboPollockR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "PollockR", True))
        Me.cboPollockR.FormattingEnabled = True
        Me.cboPollockR.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboPollockR.Location = New System.Drawing.Point(376, 206)
        Me.cboPollockR.Name = "cboPollockR"
        Me.cboPollockR.Size = New System.Drawing.Size(52, 21)
        Me.cboPollockR.TabIndex = 68
        '
        'cboMortonA
        '
        Me.cboMortonA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "MortonA", True))
        Me.cboMortonA.FormattingEnabled = True
        Me.cboMortonA.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboMortonA.Location = New System.Drawing.Point(376, 179)
        Me.cboMortonA.Name = "cboMortonA"
        Me.cboMortonA.Size = New System.Drawing.Size(52, 21)
        Me.cboMortonA.TabIndex = 67
        '
        'cboKowalC
        '
        Me.cboKowalC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CouncilDeterminedBindingSource, "KowalC", True))
        Me.cboKowalC.FormattingEnabled = True
        Me.cboKowalC.Items.AddRange(New Object() {"Y", "N", "A"})
        Me.cboKowalC.Location = New System.Drawing.Point(376, 152)
        Me.cboKowalC.Name = "cboKowalC"
        Me.cboKowalC.Size = New System.Drawing.Size(52, 21)
        Me.cboKowalC.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(248, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "KOWAL, Chris"
        '
        'CouncilVoting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 327)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboScobieG)
        Me.Controls.Add(Me.cboPollockR)
        Me.Controls.Add(Me.cboMortonA)
        Me.Controls.Add(Me.cboKowalC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboDanceK)
        Me.Controls.Add(Me.cboBrownL)
        Me.Controls.Add(Me.cboBrownA)
        Me.Controls.Add(Me.cboVardonC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboThomsonF)
        Me.Controls.Add(Me.btnMeetingDt)
        Me.Controls.Add(Me.MeetingDt)
        Me.Controls.Add(Me.MotionTextBox)
        Me.Controls.Add(Me.MinuteNoTextBox)
        Me.Controls.Add(Me.DANoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CouncilDeterminedBindingNavigator)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CouncilDeterminedBindingSource, "ThomsonF", True))
        Me.Name = "CouncilVoting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CouncilVoting"
        CType(Me.CouncilVotingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouncilDeterminedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouncilDeterminedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CouncilDeterminedBindingNavigator.ResumeLayout(False)
        Me.CouncilDeterminedBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CouncilVotingDataSet As LookupDevelopmentApplication.CouncilVotingDataSet
    Friend WithEvents CouncilDeterminedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CouncilDeterminedTableAdapter As LookupDevelopmentApplication.CouncilVotingDataSetTableAdapters.CouncilDeterminedTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CouncilDeterminedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CouncilDeterminedBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DANoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinuteNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnMeetingDt As System.Windows.Forms.Button
    Friend WithEvents MeetingDt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboThomsonF As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboVardonC As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrownA As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrownL As System.Windows.Forms.ComboBox
    Friend WithEvents cboDanceK As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboScobieG As System.Windows.Forms.ComboBox
    Friend WithEvents cboPollockR As System.Windows.Forms.ComboBox
    Friend WithEvents cboMortonA As System.Windows.Forms.ComboBox
    Friend WithEvents cboKowalC As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
