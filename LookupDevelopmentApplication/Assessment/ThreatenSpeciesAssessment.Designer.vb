<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThreatenSpeciesAssessment
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
        Dim PropImpFaunaYesNoLabel As System.Windows.Forms.Label
        Dim PropImpHabitatYesNoLabel As System.Windows.Forms.Label
        Dim ThreatSpecFurtherAssYesNoLabel As System.Windows.Forms.Label
        Dim ThreatSpecGenComLabel As System.Windows.Forms.Label
        Dim WaterNoneLabel As System.Windows.Forms.Label
        Dim WaterPermCrkLabel As System.Windows.Forms.Label
        Dim WaterEphCrkLabel As System.Windows.Forms.Label
        Dim WaterPermPndLabel As System.Windows.Forms.Label
        Dim WaterEphPndLabel As System.Windows.Forms.Label
        Dim WaterDamLabel As System.Windows.Forms.Label
        Dim WaterOpenDrnLabel As System.Windows.Forms.Label
        Dim WaterWetlandLabel As System.Windows.Forms.Label
        Dim RockNoneLabel As System.Windows.Forms.Label
        Dim RockCavesLabel As System.Windows.Forms.Label
        Dim RockOutcropsLabel As System.Windows.Forms.Label
        Dim RockOhangsLabel As System.Windows.Forms.Label
        Dim RockCreviceLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.PropImpFaunaYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropImpHabitatYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ThreatSpecGenComTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbLiveTreeAbsent = New System.Windows.Forms.RadioButton()
        Me.rbLiveTreePresent = New System.Windows.Forms.RadioButton()
        Me.rbDeadTreeAbsent = New System.Windows.Forms.RadioButton()
        Me.rbDeadTreePresent = New System.Windows.Forms.RadioButton()
        Me.rbUnderstoryNone = New System.Windows.Forms.RadioButton()
        Me.rbUnderstoryFew = New System.Windows.Forms.RadioButton()
        Me.rbUnderstoryWelDevel = New System.Windows.Forms.RadioButton()
        Me.rbUnderstoryContinuous = New System.Windows.Forms.RadioButton()
        Me.rbVegAbsent = New System.Windows.Forms.RadioButton()
        Me.rbVegPresent = New System.Windows.Forms.RadioButton()
        Me.rbWaterEpheCreek = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WaterWetlandCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterOpenDrnCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterDamCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterEphPndCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterPermPndCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterEphCrkCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterPermCrkCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaterNoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RockCreviceCheckBox = New System.Windows.Forms.CheckBox()
        Me.RockOhangsCheckBox = New System.Windows.Forms.CheckBox()
        Me.RockOutcropsCheckBox = New System.Windows.Forms.CheckBox()
        Me.RockCavesCheckBox = New System.Windows.Forms.CheckBox()
        Me.RockNoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboEnvironPlanner = New System.Windows.Forms.ComboBox()
        PropImpFaunaYesNoLabel = New System.Windows.Forms.Label()
        PropImpHabitatYesNoLabel = New System.Windows.Forms.Label()
        ThreatSpecFurtherAssYesNoLabel = New System.Windows.Forms.Label()
        ThreatSpecGenComLabel = New System.Windows.Forms.Label()
        WaterNoneLabel = New System.Windows.Forms.Label()
        WaterPermCrkLabel = New System.Windows.Forms.Label()
        WaterEphCrkLabel = New System.Windows.Forms.Label()
        WaterPermPndLabel = New System.Windows.Forms.Label()
        WaterEphPndLabel = New System.Windows.Forms.Label()
        WaterDamLabel = New System.Windows.Forms.Label()
        WaterOpenDrnLabel = New System.Windows.Forms.Label()
        WaterWetlandLabel = New System.Windows.Forms.Label()
        RockNoneLabel = New System.Windows.Forms.Label()
        RockCavesLabel = New System.Windows.Forms.Label()
        RockOutcropsLabel = New System.Windows.Forms.Label()
        RockOhangsLabel = New System.Windows.Forms.Label()
        RockCreviceLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropImpFaunaYesNoLabel
        '
        PropImpFaunaYesNoLabel.AutoSize = True
        PropImpFaunaYesNoLabel.Location = New System.Drawing.Point(31, 44)
        PropImpFaunaYesNoLabel.Name = "PropImpFaunaYesNoLabel"
        PropImpFaunaYesNoLabel.Size = New System.Drawing.Size(167, 13)
        PropImpFaunaYesNoLabel.TabIndex = 45
        PropImpFaunaYesNoLabel.Text = "- protected fauna  (S98 NPW Act)"
        '
        'PropImpHabitatYesNoLabel
        '
        PropImpHabitatYesNoLabel.AutoSize = True
        PropImpHabitatYesNoLabel.Location = New System.Drawing.Point(31, 72)
        PropImpHabitatYesNoLabel.Name = "PropImpHabitatYesNoLabel"
        PropImpHabitatYesNoLabel.Size = New System.Drawing.Size(202, 13)
        PropImpHabitatYesNoLabel.TabIndex = 46
        PropImpHabitatYesNoLabel.Text = "- critical habitat (Threatened Species Act)"
        '
        'ThreatSpecFurtherAssYesNoLabel
        '
        ThreatSpecFurtherAssYesNoLabel.AutoSize = True
        ThreatSpecFurtherAssYesNoLabel.Location = New System.Drawing.Point(31, 496)
        ThreatSpecFurtherAssYesNoLabel.Name = "ThreatSpecFurtherAssYesNoLabel"
        ThreatSpecFurtherAssYesNoLabel.Size = New System.Drawing.Size(424, 13)
        ThreatSpecFurtherAssYesNoLabel.TabIndex = 47
        ThreatSpecFurtherAssYesNoLabel.Text = "Is Further Assessment Required? (If any item marked '*' has been checked, referra" & _
            "l req'd)"
        '
        'ThreatSpecGenComLabel
        '
        ThreatSpecGenComLabel.AutoSize = True
        ThreatSpecGenComLabel.Location = New System.Drawing.Point(31, 523)
        ThreatSpecGenComLabel.Name = "ThreatSpecGenComLabel"
        ThreatSpecGenComLabel.Size = New System.Drawing.Size(96, 13)
        ThreatSpecGenComLabel.TabIndex = 48
        ThreatSpecGenComLabel.Text = "General Comments"
        '
        'WaterNoneLabel
        '
        WaterNoneLabel.AutoSize = True
        WaterNoneLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterNoneLabel.Location = New System.Drawing.Point(12, 21)
        WaterNoneLabel.Name = "WaterNoneLabel"
        WaterNoneLabel.Size = New System.Drawing.Size(36, 13)
        WaterNoneLabel.TabIndex = 0
        WaterNoneLabel.Text = "None:"
        '
        'WaterPermCrkLabel
        '
        WaterPermCrkLabel.AutoSize = True
        WaterPermCrkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterPermCrkLabel.Location = New System.Drawing.Point(102, 21)
        WaterPermCrkLabel.Name = "WaterPermCrkLabel"
        WaterPermCrkLabel.Size = New System.Drawing.Size(93, 13)
        WaterPermCrkLabel.TabIndex = 2
        WaterPermCrkLabel.Text = "Permanent Creek*"
        '
        'WaterEphCrkLabel
        '
        WaterEphCrkLabel.AutoSize = True
        WaterEphCrkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterEphCrkLabel.Location = New System.Drawing.Point(241, 21)
        WaterEphCrkLabel.Name = "WaterEphCrkLabel"
        WaterEphCrkLabel.Size = New System.Drawing.Size(162, 13)
        WaterEphCrkLabel.TabIndex = 4
        WaterEphCrkLabel.Text = "Ephemeral Creek*  ie Occasional"
        '
        'WaterPermPndLabel
        '
        WaterPermPndLabel.AutoSize = True
        WaterPermPndLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterPermPndLabel.Location = New System.Drawing.Point(431, 21)
        WaterPermPndLabel.Name = "WaterPermPndLabel"
        WaterPermPndLabel.Size = New System.Drawing.Size(90, 13)
        WaterPermPndLabel.TabIndex = 6
        WaterPermPndLabel.Text = "Permanent Pond*"
        '
        'WaterEphPndLabel
        '
        WaterEphPndLabel.AutoSize = True
        WaterEphPndLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterEphPndLabel.Location = New System.Drawing.Point(251, 44)
        WaterEphPndLabel.Name = "WaterEphPndLabel"
        WaterEphPndLabel.Size = New System.Drawing.Size(156, 13)
        WaterEphPndLabel.TabIndex = 8
        WaterEphPndLabel.Text = "Ephemeral Pond* ie Occasional"
        '
        'WaterDamLabel
        '
        WaterDamLabel.AutoSize = True
        WaterDamLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterDamLabel.Location = New System.Drawing.Point(14, 44)
        WaterDamLabel.Name = "WaterDamLabel"
        WaterDamLabel.Size = New System.Drawing.Size(29, 13)
        WaterDamLabel.TabIndex = 10
        WaterDamLabel.Text = "Dam"
        '
        'WaterOpenDrnLabel
        '
        WaterOpenDrnLabel.AutoSize = True
        WaterOpenDrnLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterOpenDrnLabel.Location = New System.Drawing.Point(134, 44)
        WaterOpenDrnLabel.Name = "WaterOpenDrnLabel"
        WaterOpenDrnLabel.Size = New System.Drawing.Size(61, 13)
        WaterOpenDrnLabel.TabIndex = 12
        WaterOpenDrnLabel.Text = "Open Drain"
        '
        'WaterWetlandLabel
        '
        WaterWetlandLabel.AutoSize = True
        WaterWetlandLabel.ForeColor = System.Drawing.SystemColors.ControlText
        WaterWetlandLabel.Location = New System.Drawing.Point(473, 44)
        WaterWetlandLabel.Name = "WaterWetlandLabel"
        WaterWetlandLabel.Size = New System.Drawing.Size(51, 13)
        WaterWetlandLabel.TabIndex = 14
        WaterWetlandLabel.Text = "Wetland*"
        '
        'RockNoneLabel
        '
        RockNoneLabel.AutoSize = True
        RockNoneLabel.ForeColor = System.Drawing.SystemColors.ControlText
        RockNoneLabel.Location = New System.Drawing.Point(12, 24)
        RockNoneLabel.Name = "RockNoneLabel"
        RockNoneLabel.Size = New System.Drawing.Size(36, 13)
        RockNoneLabel.TabIndex = 0
        RockNoneLabel.Text = "None:"
        '
        'RockCavesLabel
        '
        RockCavesLabel.AutoSize = True
        RockCavesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        RockCavesLabel.Location = New System.Drawing.Point(114, 24)
        RockCavesLabel.Name = "RockCavesLabel"
        RockCavesLabel.Size = New System.Drawing.Size(40, 13)
        RockCavesLabel.TabIndex = 2
        RockCavesLabel.Text = "Caves:"
        '
        'RockOutcropsLabel
        '
        RockOutcropsLabel.AutoSize = True
        RockOutcropsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        RockOutcropsLabel.Location = New System.Drawing.Point(202, 24)
        RockOutcropsLabel.Name = "RockOutcropsLabel"
        RockOutcropsLabel.Size = New System.Drawing.Size(49, 13)
        RockOutcropsLabel.TabIndex = 4
        RockOutcropsLabel.Text = "Outcrop*"
        '
        'RockOhangsLabel
        '
        RockOhangsLabel.AutoSize = True
        RockOhangsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        RockOhangsLabel.Location = New System.Drawing.Point(311, 24)
        RockOhangsLabel.Name = "RockOhangsLabel"
        RockOhangsLabel.Size = New System.Drawing.Size(59, 13)
        RockOhangsLabel.TabIndex = 6
        RockOhangsLabel.Text = "Overhangs"
        '
        'RockCreviceLabel
        '
        RockCreviceLabel.AutoSize = True
        RockCreviceLabel.ForeColor = System.Drawing.SystemColors.ControlText
        RockCreviceLabel.Location = New System.Drawing.Point(441, 24)
        RockCreviceLabel.Name = "RockCreviceLabel"
        RockCreviceLabel.Size = New System.Drawing.Size(52, 13)
        RockCreviceLabel.TabIndex = 8
        RockCreviceLabel.Text = "Crevices*"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(31, 100)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(215, 13)
        Label4.TabIndex = 59
        Label4.Text = "- was this referred to environmental planner?"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(473, 12)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(121, 23)
        Me.btnMark.TabIndex = 43
        Me.btnMark.Text = "Mark All as N/A"
        Me.btnMark.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Threatened Species"
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DAAssessmentDataBindingSource
        '
        Me.DAAssessmentDataBindingSource.DataMember = "DAAssessmentData"
        Me.DAAssessmentDataBindingSource.DataSource = Me.AAdata
        '
        'DAAssessmentDataTableAdapter
        '
        Me.DAAssessmentDataTableAdapter.ClearBeforeFill = True
        '
        'PropImpFaunaYesNoExtendedComboBox
        '
        Me.PropImpFaunaYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PropImpFaunaYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PropImpFaunaYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "PropImpFaunaYesNo", True))
        Me.PropImpFaunaYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.PropImpFaunaYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.PropImpFaunaYesNoExtendedComboBox.FormattingEnabled = True
        Me.PropImpFaunaYesNoExtendedComboBox.Location = New System.Drawing.Point(473, 41)
        Me.PropImpFaunaYesNoExtendedComboBox.Name = "PropImpFaunaYesNoExtendedComboBox"
        Me.PropImpFaunaYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PropImpFaunaYesNoExtendedComboBox.TabIndex = 46
        Me.PropImpFaunaYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'PropImpHabitatYesNoExtendedComboBox
        '
        Me.PropImpHabitatYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PropImpHabitatYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PropImpHabitatYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "PropImpHabitatYesNo", True))
        Me.PropImpHabitatYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.PropImpHabitatYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.PropImpHabitatYesNoExtendedComboBox.FormattingEnabled = True
        Me.PropImpHabitatYesNoExtendedComboBox.Location = New System.Drawing.Point(473, 69)
        Me.PropImpHabitatYesNoExtendedComboBox.Name = "PropImpHabitatYesNoExtendedComboBox"
        Me.PropImpHabitatYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PropImpHabitatYesNoExtendedComboBox.TabIndex = 47
        Me.PropImpHabitatYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'ThreatSpecFurtherAssYesNoExtendedComboBox
        '
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "ThreatSpecFurtherAssYesNo", True))
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.FormattingEnabled = True
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.Location = New System.Drawing.Point(473, 493)
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.Name = "ThreatSpecFurtherAssYesNoExtendedComboBox"
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.TabIndex = 48
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'ThreatSpecGenComTextBox
        '
        Me.ThreatSpecGenComTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "ThreatSpecGenCom", True))
        Me.ThreatSpecGenComTextBox.Location = New System.Drawing.Point(34, 539)
        Me.ThreatSpecGenComTextBox.MaxLength = 3000
        Me.ThreatSpecGenComTextBox.Multiline = True
        Me.ThreatSpecGenComTextBox.Name = "ThreatSpecGenComTextBox"
        Me.ThreatSpecGenComTextBox.Size = New System.Drawing.Size(560, 98)
        Me.ThreatSpecGenComTextBox.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(31, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Threatened Species - Preliminary Assessment of the site:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(35, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Trees With Hollows:"
        '
        'rbLiveTreeAbsent
        '
        Me.rbLiveTreeAbsent.AutoSize = True
        Me.rbLiveTreeAbsent.Location = New System.Drawing.Point(17, 19)
        Me.rbLiveTreeAbsent.Name = "rbLiveTreeAbsent"
        Me.rbLiveTreeAbsent.Size = New System.Drawing.Size(58, 17)
        Me.rbLiveTreeAbsent.TabIndex = 52
        Me.rbLiveTreeAbsent.TabStop = True
        Me.rbLiveTreeAbsent.Text = "Absent"
        Me.rbLiveTreeAbsent.UseVisualStyleBackColor = True
        '
        'rbLiveTreePresent
        '
        Me.rbLiveTreePresent.AutoSize = True
        Me.rbLiveTreePresent.Location = New System.Drawing.Point(90, 19)
        Me.rbLiveTreePresent.Name = "rbLiveTreePresent"
        Me.rbLiveTreePresent.Size = New System.Drawing.Size(65, 17)
        Me.rbLiveTreePresent.TabIndex = 52
        Me.rbLiveTreePresent.TabStop = True
        Me.rbLiveTreePresent.Text = "Present*"
        Me.rbLiveTreePresent.UseVisualStyleBackColor = True
        '
        'rbDeadTreeAbsent
        '
        Me.rbDeadTreeAbsent.AutoSize = True
        Me.rbDeadTreeAbsent.Location = New System.Drawing.Point(9, 19)
        Me.rbDeadTreeAbsent.Name = "rbDeadTreeAbsent"
        Me.rbDeadTreeAbsent.Size = New System.Drawing.Size(58, 17)
        Me.rbDeadTreeAbsent.TabIndex = 52
        Me.rbDeadTreeAbsent.TabStop = True
        Me.rbDeadTreeAbsent.Text = "Absent"
        Me.rbDeadTreeAbsent.UseVisualStyleBackColor = True
        '
        'rbDeadTreePresent
        '
        Me.rbDeadTreePresent.AutoSize = True
        Me.rbDeadTreePresent.Location = New System.Drawing.Point(83, 19)
        Me.rbDeadTreePresent.Name = "rbDeadTreePresent"
        Me.rbDeadTreePresent.Size = New System.Drawing.Size(65, 17)
        Me.rbDeadTreePresent.TabIndex = 52
        Me.rbDeadTreePresent.TabStop = True
        Me.rbDeadTreePresent.Text = "Present*"
        Me.rbDeadTreePresent.UseVisualStyleBackColor = True
        '
        'rbUnderstoryNone
        '
        Me.rbUnderstoryNone.AutoSize = True
        Me.rbUnderstoryNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbUnderstoryNone.Location = New System.Drawing.Point(15, 22)
        Me.rbUnderstoryNone.Name = "rbUnderstoryNone"
        Me.rbUnderstoryNone.Size = New System.Drawing.Size(51, 17)
        Me.rbUnderstoryNone.TabIndex = 52
        Me.rbUnderstoryNone.TabStop = True
        Me.rbUnderstoryNone.Text = "None"
        Me.rbUnderstoryNone.UseVisualStyleBackColor = True
        '
        'rbUnderstoryFew
        '
        Me.rbUnderstoryFew.AutoSize = True
        Me.rbUnderstoryFew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbUnderstoryFew.Location = New System.Drawing.Point(83, 22)
        Me.rbUnderstoryFew.Name = "rbUnderstoryFew"
        Me.rbUnderstoryFew.Size = New System.Drawing.Size(98, 17)
        Me.rbUnderstoryFew.TabIndex = 52
        Me.rbUnderstoryFew.TabStop = True
        Me.rbUnderstoryFew.Text = "Few Individuals"
        Me.rbUnderstoryFew.UseVisualStyleBackColor = True
        '
        'rbUnderstoryWelDevel
        '
        Me.rbUnderstoryWelDevel.AutoSize = True
        Me.rbUnderstoryWelDevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbUnderstoryWelDevel.Location = New System.Drawing.Point(203, 22)
        Me.rbUnderstoryWelDevel.Name = "rbUnderstoryWelDevel"
        Me.rbUnderstoryWelDevel.Size = New System.Drawing.Size(161, 17)
        Me.rbUnderstoryWelDevel.TabIndex = 52
        Me.rbUnderstoryWelDevel.TabStop = True
        Me.rbUnderstoryWelDevel.Text = "Well Developed, With Gaps*"
        Me.rbUnderstoryWelDevel.UseVisualStyleBackColor = True
        '
        'rbUnderstoryContinuous
        '
        Me.rbUnderstoryContinuous.AutoSize = True
        Me.rbUnderstoryContinuous.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbUnderstoryContinuous.Location = New System.Drawing.Point(383, 22)
        Me.rbUnderstoryContinuous.Name = "rbUnderstoryContinuous"
        Me.rbUnderstoryContinuous.Size = New System.Drawing.Size(156, 17)
        Me.rbUnderstoryContinuous.TabIndex = 52
        Me.rbUnderstoryContinuous.TabStop = True
        Me.rbUnderstoryContinuous.Text = "Continuous Cover no grass*"
        Me.rbUnderstoryContinuous.UseVisualStyleBackColor = True
        '
        'rbVegAbsent
        '
        Me.rbVegAbsent.AutoSize = True
        Me.rbVegAbsent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbVegAbsent.Location = New System.Drawing.Point(13, 19)
        Me.rbVegAbsent.Name = "rbVegAbsent"
        Me.rbVegAbsent.Size = New System.Drawing.Size(58, 17)
        Me.rbVegAbsent.TabIndex = 52
        Me.rbVegAbsent.TabStop = True
        Me.rbVegAbsent.Text = "Absent"
        Me.rbVegAbsent.UseVisualStyleBackColor = True
        '
        'rbVegPresent
        '
        Me.rbVegPresent.AutoSize = True
        Me.rbVegPresent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbVegPresent.Location = New System.Drawing.Point(169, 19)
        Me.rbVegPresent.Name = "rbVegPresent"
        Me.rbVegPresent.Size = New System.Drawing.Size(65, 17)
        Me.rbVegPresent.TabIndex = 52
        Me.rbVegPresent.TabStop = True
        Me.rbVegPresent.Text = "Present*"
        Me.rbVegPresent.UseVisualStyleBackColor = True
        '
        'rbWaterEpheCreek
        '
        Me.rbWaterEpheCreek.AutoSize = True
        Me.rbWaterEpheCreek.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DAAssessmentDataBindingSource, "WaterEphCrk", True))
        Me.rbWaterEpheCreek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbWaterEpheCreek.Location = New System.Drawing.Point(414, 198)
        Me.rbWaterEpheCreek.Name = "rbWaterEpheCreek"
        Me.rbWaterEpheCreek.Size = New System.Drawing.Size(180, 17)
        Me.rbWaterEpheCreek.TabIndex = 52
        Me.rbWaterEpheCreek.TabStop = True
        Me.rbWaterEpheCreek.Text = "Ephemeral Creek*  ie Occasional"
        Me.rbWaterEpheCreek.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbVegPresent)
        Me.GroupBox1.Controls.Add(Me.rbVegAbsent)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(38, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 43)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Will Significant Native Vegetation be Removed?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(WaterWetlandLabel)
        Me.GroupBox2.Controls.Add(Me.WaterWetlandCheckBox)
        Me.GroupBox2.Controls.Add(WaterOpenDrnLabel)
        Me.GroupBox2.Controls.Add(Me.WaterOpenDrnCheckBox)
        Me.GroupBox2.Controls.Add(WaterDamLabel)
        Me.GroupBox2.Controls.Add(Me.WaterDamCheckBox)
        Me.GroupBox2.Controls.Add(WaterEphPndLabel)
        Me.GroupBox2.Controls.Add(Me.WaterEphPndCheckBox)
        Me.GroupBox2.Controls.Add(WaterPermPndLabel)
        Me.GroupBox2.Controls.Add(Me.WaterPermPndCheckBox)
        Me.GroupBox2.Controls.Add(WaterEphCrkLabel)
        Me.GroupBox2.Controls.Add(Me.WaterEphCrkCheckBox)
        Me.GroupBox2.Controls.Add(WaterPermCrkLabel)
        Me.GroupBox2.Controls.Add(Me.WaterPermCrkCheckBox)
        Me.GroupBox2.Controls.Add(WaterNoneLabel)
        Me.GroupBox2.Controls.Add(Me.WaterNoneCheckBox)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(38, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 69)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Water Bodies:"
        '
        'WaterWetlandCheckBox
        '
        Me.WaterWetlandCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterWetland", True))
        Me.WaterWetlandCheckBox.Location = New System.Drawing.Point(525, 39)
        Me.WaterWetlandCheckBox.Name = "WaterWetlandCheckBox"
        Me.WaterWetlandCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.WaterWetlandCheckBox.TabIndex = 15
        '
        'WaterOpenDrnCheckBox
        '
        Me.WaterOpenDrnCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterOpenDrn", True))
        Me.WaterOpenDrnCheckBox.Location = New System.Drawing.Point(201, 39)
        Me.WaterOpenDrnCheckBox.Name = "WaterOpenDrnCheckBox"
        Me.WaterOpenDrnCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.WaterOpenDrnCheckBox.TabIndex = 13
        '
        'WaterDamCheckBox
        '
        Me.WaterDamCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterDam", True))
        Me.WaterDamCheckBox.Location = New System.Drawing.Point(49, 39)
        Me.WaterDamCheckBox.Name = "WaterDamCheckBox"
        Me.WaterDamCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.WaterDamCheckBox.TabIndex = 11
        '
        'WaterEphPndCheckBox
        '
        Me.WaterEphPndCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterEphPnd", True))
        Me.WaterEphPndCheckBox.Location = New System.Drawing.Point(409, 39)
        Me.WaterEphPndCheckBox.Name = "WaterEphPndCheckBox"
        Me.WaterEphPndCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.WaterEphPndCheckBox.TabIndex = 9
        '
        'WaterPermPndCheckBox
        '
        Me.WaterPermPndCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterPermPnd", True))
        Me.WaterPermPndCheckBox.Location = New System.Drawing.Point(525, 16)
        Me.WaterPermPndCheckBox.Name = "WaterPermPndCheckBox"
        Me.WaterPermPndCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.WaterPermPndCheckBox.TabIndex = 7
        '
        'WaterEphCrkCheckBox
        '
        Me.WaterEphCrkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterEphCrk", True))
        Me.WaterEphCrkCheckBox.Location = New System.Drawing.Point(409, 16)
        Me.WaterEphCrkCheckBox.Name = "WaterEphCrkCheckBox"
        Me.WaterEphCrkCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.WaterEphCrkCheckBox.TabIndex = 5
        '
        'WaterPermCrkCheckBox
        '
        Me.WaterPermCrkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterPermCrk", True))
        Me.WaterPermCrkCheckBox.Location = New System.Drawing.Point(201, 16)
        Me.WaterPermCrkCheckBox.Name = "WaterPermCrkCheckBox"
        Me.WaterPermCrkCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.WaterPermCrkCheckBox.TabIndex = 3
        '
        'WaterNoneCheckBox
        '
        Me.WaterNoneCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "WaterNone", True))
        Me.WaterNoneCheckBox.Location = New System.Drawing.Point(50, 16)
        Me.WaterNoneCheckBox.Name = "WaterNoneCheckBox"
        Me.WaterNoneCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.WaterNoneCheckBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(RockCreviceLabel)
        Me.GroupBox3.Controls.Add(Me.RockCreviceCheckBox)
        Me.GroupBox3.Controls.Add(RockOhangsLabel)
        Me.GroupBox3.Controls.Add(Me.RockOhangsCheckBox)
        Me.GroupBox3.Controls.Add(RockOutcropsLabel)
        Me.GroupBox3.Controls.Add(Me.RockOutcropsCheckBox)
        Me.GroupBox3.Controls.Add(RockCavesLabel)
        Me.GroupBox3.Controls.Add(Me.RockCavesCheckBox)
        Me.GroupBox3.Controls.Add(RockNoneLabel)
        Me.GroupBox3.Controls.Add(Me.RockNoneCheckBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(38, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 53)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rock"
        '
        'RockCreviceCheckBox
        '
        Me.RockCreviceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "RockCrevice", True))
        Me.RockCreviceCheckBox.Location = New System.Drawing.Point(499, 19)
        Me.RockCreviceCheckBox.Name = "RockCreviceCheckBox"
        Me.RockCreviceCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.RockCreviceCheckBox.TabIndex = 9
        '
        'RockOhangsCheckBox
        '
        Me.RockOhangsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "RockOhangs", True))
        Me.RockOhangsCheckBox.Location = New System.Drawing.Point(376, 19)
        Me.RockOhangsCheckBox.Name = "RockOhangsCheckBox"
        Me.RockOhangsCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.RockOhangsCheckBox.TabIndex = 7
        '
        'RockOutcropsCheckBox
        '
        Me.RockOutcropsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "RockOutcrops", True))
        Me.RockOutcropsCheckBox.Location = New System.Drawing.Point(254, 19)
        Me.RockOutcropsCheckBox.Name = "RockOutcropsCheckBox"
        Me.RockOutcropsCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.RockOutcropsCheckBox.TabIndex = 5
        '
        'RockCavesCheckBox
        '
        Me.RockCavesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "RockCaves", True))
        Me.RockCavesCheckBox.Location = New System.Drawing.Point(157, 19)
        Me.RockCavesCheckBox.Name = "RockCavesCheckBox"
        Me.RockCavesCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.RockCavesCheckBox.TabIndex = 3
        '
        'RockNoneCheckBox
        '
        Me.RockNoneCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DAAssessmentDataBindingSource, "RockNone", True))
        Me.RockNoneCheckBox.Location = New System.Drawing.Point(51, 19)
        Me.RockNoneCheckBox.Name = "RockNoneCheckBox"
        Me.RockNoneCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.RockNoneCheckBox.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbUnderstoryContinuous)
        Me.GroupBox4.Controls.Add(Me.rbUnderstoryNone)
        Me.GroupBox4.Controls.Add(Me.rbUnderstoryWelDevel)
        Me.GroupBox4.Controls.Add(Me.rbUnderstoryFew)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(38, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 51)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Understorey/Groundcover Density:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbLiveTreePresent)
        Me.GroupBox5.Controls.Add(Me.rbLiveTreeAbsent)
        Me.GroupBox5.Location = New System.Drawing.Point(224, 174)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(160, 43)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Living Trees"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbDeadTreePresent)
        Me.GroupBox6.Controls.Add(Me.rbDeadTreeAbsent)
        Me.GroupBox6.Location = New System.Drawing.Point(38, 174)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(160, 43)
        Me.GroupBox6.TabIndex = 58
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dead Trees"
        '
        'cboEnvironPlanner
        '
        Me.cboEnvironPlanner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEnvironPlanner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEnvironPlanner.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "ReferredToEnvironPlanner", True))
        Me.cboEnvironPlanner.FormattingEnabled = True
        Me.cboEnvironPlanner.Location = New System.Drawing.Point(473, 97)
        Me.cboEnvironPlanner.Name = "cboEnvironPlanner"
        Me.cboEnvironPlanner.Size = New System.Drawing.Size(121, 21)
        Me.cboEnvironPlanner.TabIndex = 60
        '
        'ThreatenSpeciesAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 660)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.cboEnvironPlanner)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.rbWaterEpheCreek)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(ThreatSpecGenComLabel)
        Me.Controls.Add(Me.ThreatSpecGenComTextBox)
        Me.Controls.Add(ThreatSpecFurtherAssYesNoLabel)
        Me.Controls.Add(Me.ThreatSpecFurtherAssYesNoExtendedComboBox)
        Me.Controls.Add(PropImpHabitatYesNoLabel)
        Me.Controls.Add(Me.PropImpHabitatYesNoExtendedComboBox)
        Me.Controls.Add(PropImpFaunaYesNoLabel)
        Me.Controls.Add(Me.PropImpFaunaYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ThreatenSpeciesAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Threaten Species Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents PropImpFaunaYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PropImpHabitatYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ThreatSpecFurtherAssYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ThreatSpecGenComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbLiveTreeAbsent As System.Windows.Forms.RadioButton
    Friend WithEvents rbLiveTreePresent As System.Windows.Forms.RadioButton
    Friend WithEvents rbDeadTreeAbsent As System.Windows.Forms.RadioButton
    Friend WithEvents rbDeadTreePresent As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnderstoryNone As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnderstoryFew As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnderstoryWelDevel As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnderstoryContinuous As System.Windows.Forms.RadioButton
    Friend WithEvents rbVegAbsent As System.Windows.Forms.RadioButton
    Friend WithEvents rbVegPresent As System.Windows.Forms.RadioButton
    Friend WithEvents rbWaterEpheCreek As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents WaterWetlandCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterOpenDrnCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterDamCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterEphPndCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterPermPndCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterEphCrkCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterPermCrkCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaterNoneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RockCreviceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RockOhangsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RockOutcropsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RockCavesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RockNoneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cboEnvironPlanner As System.Windows.Forms.ComboBox
End Class
