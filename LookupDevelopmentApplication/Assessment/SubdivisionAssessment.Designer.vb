<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubdivisionAssessment
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
        Dim SubDivFloraYesNoLabel As System.Windows.Forms.Label
        Dim SubDivLinkRoadYesNoLabel As System.Windows.Forms.Label
        Dim SubDivCycleYesNoLabel As System.Windows.Forms.Label
        Dim SubDivTrunkYesNoLabel As System.Windows.Forms.Label
        Dim SubdivGenComLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.SubDivFloraYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubDivLinkRoadYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubDivCycleYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubDivTrunkYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubdivGenComTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        SubDivFloraYesNoLabel = New System.Windows.Forms.Label()
        SubDivLinkRoadYesNoLabel = New System.Windows.Forms.Label()
        SubDivCycleYesNoLabel = New System.Windows.Forms.Label()
        SubDivTrunkYesNoLabel = New System.Windows.Forms.Label()
        SubdivGenComLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubDivFloraYesNoLabel
        '
        SubDivFloraYesNoLabel.AutoSize = True
        SubDivFloraYesNoLabel.Location = New System.Drawing.Point(72, 57)
        SubDivFloraYesNoLabel.Name = "SubDivFloraYesNoLabel"
        SubDivFloraYesNoLabel.Size = New System.Drawing.Size(384, 13)
        SubDivFloraYesNoLabel.TabIndex = 43
        SubDivFloraYesNoLabel.Text = "Connectivity of flora/fauna corridors from adjacent subdivisions/public reserves?" & _
    ""
        '
        'SubDivLinkRoadYesNoLabel
        '
        SubDivLinkRoadYesNoLabel.AutoSize = True
        SubDivLinkRoadYesNoLabel.Location = New System.Drawing.Point(72, 84)
        SubDivLinkRoadYesNoLabel.Name = "SubDivLinkRoadYesNoLabel"
        SubDivLinkRoadYesNoLabel.Size = New System.Drawing.Size(252, 13)
        SubDivLinkRoadYesNoLabel.TabIndex = 44
        SubDivLinkRoadYesNoLabel.Text = "Connectivity of link roads from existing subdivisions?"
        '
        'SubDivCycleYesNoLabel
        '
        SubDivCycleYesNoLabel.AutoSize = True
        SubDivCycleYesNoLabel.Location = New System.Drawing.Point(72, 111)
        SubDivCycleYesNoLabel.Name = "SubDivCycleYesNoLabel"
        SubDivCycleYesNoLabel.Size = New System.Drawing.Size(403, 13)
        SubDivCycleYesNoLabel.TabIndex = 45
        SubDivCycleYesNoLabel.Text = "Appropriate pedestrian/cycle infrastructure linkages between adjacent subdivision" & _
    "s?"
        '
        'SubDivTrunkYesNoLabel
        '
        SubDivTrunkYesNoLabel.AutoSize = True
        SubDivTrunkYesNoLabel.Location = New System.Drawing.Point(72, 138)
        SubDivTrunkYesNoLabel.Name = "SubDivTrunkYesNoLabel"
        SubDivTrunkYesNoLabel.Size = New System.Drawing.Size(393, 13)
        SubDivTrunkYesNoLabel.TabIndex = 46
        SubDivTrunkYesNoLabel.Text = "Means of contributing to trunk infrastructure when subdivisions not subsequential" & _
    "?"
        '
        'SubdivGenComLabel
        '
        SubdivGenComLabel.AutoSize = True
        SubdivGenComLabel.Location = New System.Drawing.Point(24, 166)
        SubdivGenComLabel.Name = "SubdivGenComLabel"
        SubdivGenComLabel.Size = New System.Drawing.Size(99, 13)
        SubdivGenComLabel.TabIndex = 47
        SubdivGenComLabel.Text = "General Comments:"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(482, 12)
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
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Subdivision"
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
        'SubDivFloraYesNoExtendedComboBox
        '
        Me.SubDivFloraYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SubDivFloraYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SubDivFloraYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SubDivFloraYesNo", True))
        Me.SubDivFloraYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.SubDivFloraYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SubDivFloraYesNoExtendedComboBox.FormattingEnabled = True
        Me.SubDivFloraYesNoExtendedComboBox.Location = New System.Drawing.Point(482, 54)
        Me.SubDivFloraYesNoExtendedComboBox.Name = "SubDivFloraYesNoExtendedComboBox"
        Me.SubDivFloraYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubDivFloraYesNoExtendedComboBox.TabIndex = 44
        Me.SubDivFloraYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'SubDivLinkRoadYesNoExtendedComboBox
        '
        Me.SubDivLinkRoadYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SubDivLinkRoadYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SubDivLinkRoadYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SubDivLinkRoadYesNo", True))
        Me.SubDivLinkRoadYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.SubDivLinkRoadYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SubDivLinkRoadYesNoExtendedComboBox.FormattingEnabled = True
        Me.SubDivLinkRoadYesNoExtendedComboBox.Location = New System.Drawing.Point(482, 81)
        Me.SubDivLinkRoadYesNoExtendedComboBox.Name = "SubDivLinkRoadYesNoExtendedComboBox"
        Me.SubDivLinkRoadYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubDivLinkRoadYesNoExtendedComboBox.TabIndex = 45
        Me.SubDivLinkRoadYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'SubDivCycleYesNoExtendedComboBox
        '
        Me.SubDivCycleYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SubDivCycleYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SubDivCycleYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SubDivCycleYesNo", True))
        Me.SubDivCycleYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.SubDivCycleYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SubDivCycleYesNoExtendedComboBox.FormattingEnabled = True
        Me.SubDivCycleYesNoExtendedComboBox.Location = New System.Drawing.Point(482, 108)
        Me.SubDivCycleYesNoExtendedComboBox.Name = "SubDivCycleYesNoExtendedComboBox"
        Me.SubDivCycleYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubDivCycleYesNoExtendedComboBox.TabIndex = 46
        Me.SubDivCycleYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'SubDivTrunkYesNoExtendedComboBox
        '
        Me.SubDivTrunkYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SubDivTrunkYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SubDivTrunkYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SubDivTrunkYesNo", True))
        Me.SubDivTrunkYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource3
        Me.SubDivTrunkYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SubDivTrunkYesNoExtendedComboBox.FormattingEnabled = True
        Me.SubDivTrunkYesNoExtendedComboBox.Location = New System.Drawing.Point(482, 135)
        Me.SubDivTrunkYesNoExtendedComboBox.Name = "SubDivTrunkYesNoExtendedComboBox"
        Me.SubDivTrunkYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubDivTrunkYesNoExtendedComboBox.TabIndex = 47
        Me.SubDivTrunkYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource3
        '
        Me.GenericAnswersToQuestionsBindingSource3.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource3.DataSource = Me.AAdata
        '
        'SubdivGenComTextBox
        '
        Me.SubdivGenComTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SubdivGenCom", True))
        Me.SubdivGenComTextBox.Location = New System.Drawing.Point(27, 182)
        Me.SubdivGenComTextBox.MaxLength = 3000
        Me.SubdivGenComTextBox.Multiline = True
        Me.SubdivGenComTextBox.Name = "SubdivGenComTextBox"
        Me.SubdivGenComTextBox.Size = New System.Drawing.Size(576, 68)
        Me.SubdivGenComTextBox.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Satisfactory as regards:-"
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'SubdivisionAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 266)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(SubdivGenComLabel)
        Me.Controls.Add(Me.SubdivGenComTextBox)
        Me.Controls.Add(SubDivTrunkYesNoLabel)
        Me.Controls.Add(Me.SubDivTrunkYesNoExtendedComboBox)
        Me.Controls.Add(SubDivCycleYesNoLabel)
        Me.Controls.Add(Me.SubDivCycleYesNoExtendedComboBox)
        Me.Controls.Add(SubDivLinkRoadYesNoLabel)
        Me.Controls.Add(Me.SubDivLinkRoadYesNoExtendedComboBox)
        Me.Controls.Add(SubDivFloraYesNoLabel)
        Me.Controls.Add(Me.SubDivFloraYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SubdivisionAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Subdivision Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents SubDivFloraYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubDivLinkRoadYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubDivCycleYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubDivTrunkYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubdivGenComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource3 As System.Windows.Forms.BindingSource
End Class
