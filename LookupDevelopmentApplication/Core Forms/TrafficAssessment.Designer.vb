<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrafficAssessment
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
        Dim TrafficLevelDescLabel As System.Windows.Forms.Label
        Dim TrafficRoadYesNoLabel As System.Windows.Forms.Label
        Dim TrafficAccessYesNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrafficAssessment))
        Dim TrafficAccessCommentsLabel As System.Windows.Forms.Label
        Dim TrafficLoadingYesNoLabel As System.Windows.Forms.Label
        Dim TrafficCarpkYesNoLabel As System.Windows.Forms.Label
        Dim TrafficCarExistLabel As System.Windows.Forms.Label
        Dim TrafficCarPrevLabel As System.Windows.Forms.Label
        Dim TrafficCarSurplusLabel As System.Windows.Forms.Label
        Dim TrafficCarRequiredLabel As System.Windows.Forms.Label
        Dim TrafficCarProposedLabel As System.Windows.Forms.Label
        Dim TrafficCarShortfallLabel As System.Windows.Forms.Label
        Dim TrafficCarContLabel As System.Windows.Forms.Label
        Dim TrafficCommitteeYesNoLabel As System.Windows.Forms.Label
        Dim TrafficPublicAccCommentsLabel As System.Windows.Forms.Label
        Dim TrafficGenComLabel As System.Windows.Forms.Label
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.TrafficLevelDescTextBox = New System.Windows.Forms.TextBox()
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrafficRoadYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficAccessYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficAccessCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficLoadingYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficCarpkYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficCarExistTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarPrevTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarSurplusTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarRequiredTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarProposedTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarShortfallTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCarContTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficCommitteeYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficPublicAccCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.TrafficGenComTextBox = New System.Windows.Forms.TextBox()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        TrafficLevelDescLabel = New System.Windows.Forms.Label()
        TrafficRoadYesNoLabel = New System.Windows.Forms.Label()
        TrafficAccessYesNoLabel = New System.Windows.Forms.Label()
        TrafficAccessCommentsLabel = New System.Windows.Forms.Label()
        TrafficLoadingYesNoLabel = New System.Windows.Forms.Label()
        TrafficCarpkYesNoLabel = New System.Windows.Forms.Label()
        TrafficCarExistLabel = New System.Windows.Forms.Label()
        TrafficCarPrevLabel = New System.Windows.Forms.Label()
        TrafficCarSurplusLabel = New System.Windows.Forms.Label()
        TrafficCarRequiredLabel = New System.Windows.Forms.Label()
        TrafficCarProposedLabel = New System.Windows.Forms.Label()
        TrafficCarShortfallLabel = New System.Windows.Forms.Label()
        TrafficCarContLabel = New System.Windows.Forms.Label()
        TrafficCommitteeYesNoLabel = New System.Windows.Forms.Label()
        TrafficPublicAccCommentsLabel = New System.Windows.Forms.Label()
        TrafficGenComLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrafficLevelDescLabel
        '
        TrafficLevelDescLabel.AutoSize = True
        TrafficLevelDescLabel.Location = New System.Drawing.Point(17, 46)
        TrafficLevelDescLabel.Name = "TrafficLevelDescLabel"
        TrafficLevelDescLabel.Size = New System.Drawing.Size(427, 13)
        TrafficLevelDescLabel.TabIndex = 2
        TrafficLevelDescLabel.Text = "Describe the level, type of traffic movement and cumulative impact likely to be g" & _
            "enerated:"
        '
        'TrafficRoadYesNoLabel
        '
        TrafficRoadYesNoLabel.AutoSize = True
        TrafficRoadYesNoLabel.Location = New System.Drawing.Point(17, 145)
        TrafficRoadYesNoLabel.Name = "TrafficRoadYesNoLabel"
        TrafficRoadYesNoLabel.Size = New System.Drawing.Size(304, 13)
        TrafficRoadYesNoLabel.TabIndex = 41
        TrafficRoadYesNoLabel.Text = "- is the road system adequate to carry those traffic movements?"
        '
        'TrafficAccessYesNoLabel
        '
        TrafficAccessYesNoLabel.Location = New System.Drawing.Point(17, 169)
        TrafficAccessYesNoLabel.Name = "TrafficAccessYesNoLabel"
        TrafficAccessYesNoLabel.Size = New System.Drawing.Size(493, 31)
        TrafficAccessYesNoLabel.TabIndex = 42
        TrafficAccessYesNoLabel.Text = resources.GetString("TrafficAccessYesNoLabel.Text")
        '
        'TrafficAccessCommentsLabel
        '
        TrafficAccessCommentsLabel.AutoSize = True
        TrafficAccessCommentsLabel.Location = New System.Drawing.Point(17, 217)
        TrafficAccessCommentsLabel.Name = "TrafficAccessCommentsLabel"
        TrafficAccessCommentsLabel.Size = New System.Drawing.Size(130, 13)
        TrafficAccessCommentsLabel.TabIndex = 43
        TrafficAccessCommentsLabel.Text = "Traffic Access Comments:"
        '
        'TrafficLoadingYesNoLabel
        '
        TrafficLoadingYesNoLabel.AutoSize = True
        TrafficLoadingYesNoLabel.Location = New System.Drawing.Point(17, 305)
        TrafficLoadingYesNoLabel.Name = "TrafficLoadingYesNoLabel"
        TrafficLoadingYesNoLabel.Size = New System.Drawing.Size(210, 13)
        TrafficLoadingYesNoLabel.TabIndex = 44
        TrafficLoadingYesNoLabel.Text = "- are loading/unloading facilities adequate?"
        '
        'TrafficCarpkYesNoLabel
        '
        TrafficCarpkYesNoLabel.AutoSize = True
        TrafficCarpkYesNoLabel.Location = New System.Drawing.Point(17, 332)
        TrafficCarpkYesNoLabel.Name = "TrafficCarpkYesNoLabel"
        TrafficCarpkYesNoLabel.Size = New System.Drawing.Size(127, 13)
        TrafficCarpkYesNoLabel.TabIndex = 45
        TrafficCarpkYesNoLabel.Text = "- is carparking adequate?"
        '
        'TrafficCarExistLabel
        '
        TrafficCarExistLabel.AutoSize = True
        TrafficCarExistLabel.Location = New System.Drawing.Point(140, 359)
        TrafficCarExistLabel.Name = "TrafficCarExistLabel"
        TrafficCarExistLabel.Size = New System.Drawing.Size(119, 13)
        TrafficCarExistLabel.TabIndex = 46
        TrafficCarExistLabel.Text = "- existing spaces on site"
        '
        'TrafficCarPrevLabel
        '
        TrafficCarPrevLabel.AutoSize = True
        TrafficCarPrevLabel.Location = New System.Drawing.Point(140, 385)
        TrafficCarPrevLabel.Name = "TrafficCarPrevLabel"
        TrafficCarPrevLabel.Size = New System.Drawing.Size(196, 13)
        TrafficCarPrevLabel.TabIndex = 47
        TrafficCarPrevLabel.Text = "- number required from previous consent"
        '
        'TrafficCarSurplusLabel
        '
        TrafficCarSurplusLabel.AutoSize = True
        TrafficCarSurplusLabel.Location = New System.Drawing.Point(140, 411)
        TrafficCarSurplusLabel.Name = "TrafficCarSurplusLabel"
        TrafficCarSurplusLabel.Size = New System.Drawing.Size(137, 13)
        TrafficCarSurplusLabel.TabIndex = 48
        TrafficCarSurplusLabel.Text = "- existing surplus/deficiency"
        '
        'TrafficCarRequiredLabel
        '
        TrafficCarRequiredLabel.AutoSize = True
        TrafficCarRequiredLabel.Location = New System.Drawing.Point(140, 437)
        TrafficCarRequiredLabel.Name = "TrafficCarRequiredLabel"
        TrafficCarRequiredLabel.Size = New System.Drawing.Size(138, 13)
        TrafficCarRequiredLabel.TabIndex = 49
        TrafficCarRequiredLabel.Text = "- number of spaces required"
        '
        'TrafficCarProposedLabel
        '
        TrafficCarProposedLabel.AutoSize = True
        TrafficCarProposedLabel.Location = New System.Drawing.Point(140, 463)
        TrafficCarProposedLabel.Name = "TrafficCarProposedLabel"
        TrafficCarProposedLabel.Size = New System.Drawing.Size(144, 13)
        TrafficCarProposedLabel.TabIndex = 50
        TrafficCarProposedLabel.Text = "- number of spaces proposed"
        '
        'TrafficCarShortfallLabel
        '
        TrafficCarShortfallLabel.AutoSize = True
        TrafficCarShortfallLabel.Location = New System.Drawing.Point(140, 489)
        TrafficCarShortfallLabel.Name = "TrafficCarShortfallLabel"
        TrafficCarShortfallLabel.Size = New System.Drawing.Size(87, 13)
        TrafficCarShortfallLabel.TabIndex = 51
        TrafficCarShortfallLabel.Text = "- shortfall/surplus"
        '
        'TrafficCarContLabel
        '
        TrafficCarContLabel.AutoSize = True
        TrafficCarContLabel.Location = New System.Drawing.Point(140, 515)
        TrafficCarContLabel.Name = "TrafficCarContLabel"
        TrafficCarContLabel.Size = New System.Drawing.Size(192, 13)
        TrafficCarContLabel.TabIndex = 52
        TrafficCarContLabel.Text = "- contribution for carparking appropriate"
        '
        'TrafficCommitteeYesNoLabel
        '
        TrafficCommitteeYesNoLabel.AutoSize = True
        TrafficCommitteeYesNoLabel.Location = New System.Drawing.Point(17, 538)
        TrafficCommitteeYesNoLabel.Name = "TrafficCommitteeYesNoLabel"
        TrafficCommitteeYesNoLabel.Size = New System.Drawing.Size(308, 13)
        TrafficCommitteeYesNoLabel.TabIndex = 53
        TrafficCommitteeYesNoLabel.Text = "- proposal satisfy comments/requirements of Traffic Committee/s"
        '
        'TrafficPublicAccCommentsLabel
        '
        TrafficPublicAccCommentsLabel.AutoSize = True
        TrafficPublicAccCommentsLabel.Location = New System.Drawing.Point(17, 563)
        TrafficPublicAccCommentsLabel.Name = "TrafficPublicAccCommentsLabel"
        TrafficPublicAccCommentsLabel.Size = New System.Drawing.Size(146, 13)
        TrafficPublicAccCommentsLabel.TabIndex = 54
        TrafficPublicAccCommentsLabel.Text = "Traffic Public Acc Comments:"
        '
        'TrafficGenComLabel
        '
        TrafficGenComLabel.AutoSize = True
        TrafficGenComLabel.Location = New System.Drawing.Point(17, 643)
        TrafficGenComLabel.Name = "TrafficGenComLabel"
        TrafficGenComLabel.Size = New System.Drawing.Size(87, 13)
        TrafficGenComLabel.TabIndex = 55
        TrafficGenComLabel.Text = "Traffic Gen Com:"
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
        'TrafficLevelDescTextBox
        '
        Me.TrafficLevelDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficLevelDesc", True))
        Me.TrafficLevelDescTextBox.Location = New System.Drawing.Point(20, 62)
        Me.TrafficLevelDescTextBox.Multiline = True
        Me.TrafficLevelDescTextBox.Name = "TrafficLevelDescTextBox"
        Me.TrafficLevelDescTextBox.Size = New System.Drawing.Size(617, 74)
        Me.TrafficLevelDescTextBox.TabIndex = 3
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(516, 12)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(121, 23)
        Me.btnMark.TabIndex = 41
        Me.btnMark.Text = "Mark All as N/A"
        Me.btnMark.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Traffic and Carparking:"
        '
        'TrafficRoadYesNoExtendedComboBox
        '
        Me.TrafficRoadYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TrafficRoadYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TrafficRoadYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "TrafficRoadYesNo", True))
        Me.TrafficRoadYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.TrafficRoadYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.TrafficRoadYesNoExtendedComboBox.FormattingEnabled = True
        Me.TrafficRoadYesNoExtendedComboBox.Location = New System.Drawing.Point(516, 142)
        Me.TrafficRoadYesNoExtendedComboBox.Name = "TrafficRoadYesNoExtendedComboBox"
        Me.TrafficRoadYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrafficRoadYesNoExtendedComboBox.TabIndex = 42
        Me.TrafficRoadYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'TrafficAccessYesNoExtendedComboBox
        '
        Me.TrafficAccessYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TrafficAccessYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TrafficAccessYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "TrafficAccessYesNo", True))
        Me.TrafficAccessYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.TrafficAccessYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.TrafficAccessYesNoExtendedComboBox.FormattingEnabled = True
        Me.TrafficAccessYesNoExtendedComboBox.Location = New System.Drawing.Point(516, 179)
        Me.TrafficAccessYesNoExtendedComboBox.Name = "TrafficAccessYesNoExtendedComboBox"
        Me.TrafficAccessYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrafficAccessYesNoExtendedComboBox.TabIndex = 43
        Me.TrafficAccessYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'TrafficAccessCommentsTextBox
        '
        Me.TrafficAccessCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficAccessComments", True))
        Me.TrafficAccessCommentsTextBox.Location = New System.Drawing.Point(20, 233)
        Me.TrafficAccessCommentsTextBox.Multiline = True
        Me.TrafficAccessCommentsTextBox.Name = "TrafficAccessCommentsTextBox"
        Me.TrafficAccessCommentsTextBox.Size = New System.Drawing.Size(617, 54)
        Me.TrafficAccessCommentsTextBox.TabIndex = 44
        '
        'TrafficLoadingYesNoExtendedComboBox
        '
        Me.TrafficLoadingYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TrafficLoadingYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TrafficLoadingYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "TrafficLoadingYesNo", True))
        Me.TrafficLoadingYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.TrafficLoadingYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.TrafficLoadingYesNoExtendedComboBox.FormattingEnabled = True
        Me.TrafficLoadingYesNoExtendedComboBox.Location = New System.Drawing.Point(516, 302)
        Me.TrafficLoadingYesNoExtendedComboBox.Name = "TrafficLoadingYesNoExtendedComboBox"
        Me.TrafficLoadingYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrafficLoadingYesNoExtendedComboBox.TabIndex = 45
        Me.TrafficLoadingYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'TrafficCarpkYesNoExtendedComboBox
        '
        Me.TrafficCarpkYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TrafficCarpkYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TrafficCarpkYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "TrafficCarpkYesNo", True))
        Me.TrafficCarpkYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource3
        Me.TrafficCarpkYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.TrafficCarpkYesNoExtendedComboBox.FormattingEnabled = True
        Me.TrafficCarpkYesNoExtendedComboBox.Location = New System.Drawing.Point(516, 329)
        Me.TrafficCarpkYesNoExtendedComboBox.Name = "TrafficCarpkYesNoExtendedComboBox"
        Me.TrafficCarpkYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrafficCarpkYesNoExtendedComboBox.TabIndex = 46
        Me.TrafficCarpkYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource3
        '
        Me.GenericAnswersToQuestionsBindingSource3.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource3.DataSource = Me.AAdata
        '
        'TrafficCarExistTextBox
        '
        Me.TrafficCarExistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarExist", True))
        Me.TrafficCarExistTextBox.Location = New System.Drawing.Point(516, 356)
        Me.TrafficCarExistTextBox.Name = "TrafficCarExistTextBox"
        Me.TrafficCarExistTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarExistTextBox.TabIndex = 47
        '
        'TrafficCarPrevTextBox
        '
        Me.TrafficCarPrevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarPrev", True))
        Me.TrafficCarPrevTextBox.Location = New System.Drawing.Point(516, 382)
        Me.TrafficCarPrevTextBox.Name = "TrafficCarPrevTextBox"
        Me.TrafficCarPrevTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarPrevTextBox.TabIndex = 48
        '
        'TrafficCarSurplusTextBox
        '
        Me.TrafficCarSurplusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarSurplus", True))
        Me.TrafficCarSurplusTextBox.Location = New System.Drawing.Point(516, 408)
        Me.TrafficCarSurplusTextBox.Name = "TrafficCarSurplusTextBox"
        Me.TrafficCarSurplusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarSurplusTextBox.TabIndex = 49
        '
        'TrafficCarRequiredTextBox
        '
        Me.TrafficCarRequiredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarRequired", True))
        Me.TrafficCarRequiredTextBox.Location = New System.Drawing.Point(516, 434)
        Me.TrafficCarRequiredTextBox.Name = "TrafficCarRequiredTextBox"
        Me.TrafficCarRequiredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarRequiredTextBox.TabIndex = 50
        '
        'TrafficCarProposedTextBox
        '
        Me.TrafficCarProposedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarProposed", True))
        Me.TrafficCarProposedTextBox.Location = New System.Drawing.Point(516, 460)
        Me.TrafficCarProposedTextBox.Name = "TrafficCarProposedTextBox"
        Me.TrafficCarProposedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarProposedTextBox.TabIndex = 51
        '
        'TrafficCarShortfallTextBox
        '
        Me.TrafficCarShortfallTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarShortfall", True))
        Me.TrafficCarShortfallTextBox.Location = New System.Drawing.Point(516, 486)
        Me.TrafficCarShortfallTextBox.Name = "TrafficCarShortfallTextBox"
        Me.TrafficCarShortfallTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarShortfallTextBox.TabIndex = 52
        '
        'TrafficCarContTextBox
        '
        Me.TrafficCarContTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficCarCont", True))
        Me.TrafficCarContTextBox.Location = New System.Drawing.Point(516, 512)
        Me.TrafficCarContTextBox.Name = "TrafficCarContTextBox"
        Me.TrafficCarContTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrafficCarContTextBox.TabIndex = 53
        '
        'TrafficCommitteeYesNoExtendedComboBox
        '
        Me.TrafficCommitteeYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TrafficCommitteeYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TrafficCommitteeYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "TrafficCommitteeYesNo", True))
        Me.TrafficCommitteeYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource4
        Me.TrafficCommitteeYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.TrafficCommitteeYesNoExtendedComboBox.FormattingEnabled = True
        Me.TrafficCommitteeYesNoExtendedComboBox.Location = New System.Drawing.Point(516, 538)
        Me.TrafficCommitteeYesNoExtendedComboBox.Name = "TrafficCommitteeYesNoExtendedComboBox"
        Me.TrafficCommitteeYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrafficCommitteeYesNoExtendedComboBox.TabIndex = 54
        Me.TrafficCommitteeYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource4
        '
        Me.GenericAnswersToQuestionsBindingSource4.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource4.DataSource = Me.AAdata
        '
        'TrafficPublicAccCommentsTextBox
        '
        Me.TrafficPublicAccCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficPublicAccComments", True))
        Me.TrafficPublicAccCommentsTextBox.Location = New System.Drawing.Point(20, 579)
        Me.TrafficPublicAccCommentsTextBox.Multiline = True
        Me.TrafficPublicAccCommentsTextBox.Name = "TrafficPublicAccCommentsTextBox"
        Me.TrafficPublicAccCommentsTextBox.Size = New System.Drawing.Size(617, 51)
        Me.TrafficPublicAccCommentsTextBox.TabIndex = 55
        '
        'TrafficGenComTextBox
        '
        Me.TrafficGenComTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "TrafficGenCom", True))
        Me.TrafficGenComTextBox.Location = New System.Drawing.Point(20, 659)
        Me.TrafficGenComTextBox.Multiline = True
        Me.TrafficGenComTextBox.Name = "TrafficGenComTextBox"
        Me.TrafficGenComTextBox.Size = New System.Drawing.Size(617, 52)
        Me.TrafficGenComTextBox.TabIndex = 56
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'TrafficAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 723)
        Me.Controls.Add(TrafficGenComLabel)
        Me.Controls.Add(Me.TrafficGenComTextBox)
        Me.Controls.Add(TrafficPublicAccCommentsLabel)
        Me.Controls.Add(Me.TrafficPublicAccCommentsTextBox)
        Me.Controls.Add(TrafficCommitteeYesNoLabel)
        Me.Controls.Add(Me.TrafficCommitteeYesNoExtendedComboBox)
        Me.Controls.Add(TrafficCarContLabel)
        Me.Controls.Add(Me.TrafficCarContTextBox)
        Me.Controls.Add(TrafficCarShortfallLabel)
        Me.Controls.Add(Me.TrafficCarShortfallTextBox)
        Me.Controls.Add(TrafficCarProposedLabel)
        Me.Controls.Add(Me.TrafficCarProposedTextBox)
        Me.Controls.Add(TrafficCarRequiredLabel)
        Me.Controls.Add(Me.TrafficCarRequiredTextBox)
        Me.Controls.Add(TrafficCarSurplusLabel)
        Me.Controls.Add(Me.TrafficCarSurplusTextBox)
        Me.Controls.Add(TrafficCarPrevLabel)
        Me.Controls.Add(Me.TrafficCarPrevTextBox)
        Me.Controls.Add(TrafficCarExistLabel)
        Me.Controls.Add(Me.TrafficCarExistTextBox)
        Me.Controls.Add(TrafficCarpkYesNoLabel)
        Me.Controls.Add(Me.TrafficCarpkYesNoExtendedComboBox)
        Me.Controls.Add(TrafficLoadingYesNoLabel)
        Me.Controls.Add(Me.TrafficLoadingYesNoExtendedComboBox)
        Me.Controls.Add(TrafficAccessCommentsLabel)
        Me.Controls.Add(Me.TrafficAccessCommentsTextBox)
        Me.Controls.Add(TrafficAccessYesNoLabel)
        Me.Controls.Add(Me.TrafficAccessYesNoExtendedComboBox)
        Me.Controls.Add(TrafficRoadYesNoLabel)
        Me.Controls.Add(Me.TrafficRoadYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(TrafficLevelDescLabel)
        Me.Controls.Add(Me.TrafficLevelDescTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TrafficAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Traffic Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents TrafficLevelDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrafficRoadYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrafficAccessYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrafficAccessCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficLoadingYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrafficCarpkYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrafficCarExistTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarPrevTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarSurplusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarRequiredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarProposedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarShortfallTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCarContTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficCommitteeYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrafficPublicAccCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrafficGenComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource4 As System.Windows.Forms.BindingSource
End Class
