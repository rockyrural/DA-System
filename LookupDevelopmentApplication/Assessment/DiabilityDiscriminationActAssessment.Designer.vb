<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiabilityDiscriminationActAssessment
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
        Dim DDAImpactYesNoLabel As System.Windows.Forms.Label
        Dim DDACommitteeYesNoLabel As System.Windows.Forms.Label
        Dim DDAAccessYesNoLabel As System.Windows.Forms.Label
        Dim DDAAccessAvailYesNoLabel As System.Windows.Forms.Label
        Dim DDAAccessAdequateYesNoLabel As System.Windows.Forms.Label
        Dim DDACommentsLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.DDAImpactYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDACommitteeYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDAAccessYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDAAccessAvailYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDAAccessAdequateYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDACommentsTextBox = New System.Windows.Forms.TextBox()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        DDAImpactYesNoLabel = New System.Windows.Forms.Label()
        DDACommitteeYesNoLabel = New System.Windows.Forms.Label()
        DDAAccessYesNoLabel = New System.Windows.Forms.Label()
        DDAAccessAvailYesNoLabel = New System.Windows.Forms.Label()
        DDAAccessAdequateYesNoLabel = New System.Windows.Forms.Label()
        DDACommentsLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DDAImpactYesNoLabel
        '
        DDAImpactYesNoLabel.AutoSize = True
        DDAImpactYesNoLabel.Location = New System.Drawing.Point(21, 46)
        DDAImpactYesNoLabel.Name = "DDAImpactYesNoLabel"
        DDAImpactYesNoLabel.Size = New System.Drawing.Size(237, 13)
        DDAImpactYesNoLabel.TabIndex = 45
        DDAImpactYesNoLabel.Text = "- Does the development impact on BCA or DDA?"
        '
        'DDACommitteeYesNoLabel
        '
        DDACommitteeYesNoLabel.AutoSize = True
        DDACommitteeYesNoLabel.Location = New System.Drawing.Point(21, 79)
        DDACommitteeYesNoLabel.Name = "DDACommitteeYesNoLabel"
        DDACommitteeYesNoLabel.Size = New System.Drawing.Size(355, 13)
        DDACommitteeYesNoLabel.TabIndex = 46
        DDACommitteeYesNoLabel.Text = "- Does the development require reference to Disabled Access Committee?"
        '
        'DDAAccessYesNoLabel
        '
        DDAAccessYesNoLabel.AutoSize = True
        DDAAccessYesNoLabel.Location = New System.Drawing.Point(21, 111)
        DDAAccessYesNoLabel.Name = "DDAAccessYesNoLabel"
        DDAAccessYesNoLabel.Size = New System.Drawing.Size(342, 13)
        DDAAccessYesNoLabel.TabIndex = 47
        DDAAccessYesNoLabel.Text = "Disabled access - is access for disabled persons necessary (AS 1428)?"
        '
        'DDAAccessAvailYesNoLabel
        '
        DDAAccessAvailYesNoLabel.AutoSize = True
        DDAAccessAvailYesNoLabel.Location = New System.Drawing.Point(400, 142)
        DDAAccessAvailYesNoLabel.Name = "DDAAccessAvailYesNoLabel"
        DDAAccessAvailYesNoLabel.Size = New System.Drawing.Size(64, 13)
        DDAAccessAvailYesNoLabel.TabIndex = 48
        DDAAccessAvailYesNoLabel.Text = " - available?"
        '
        'DDAAccessAdequateYesNoLabel
        '
        DDAAccessAdequateYesNoLabel.AutoSize = True
        DDAAccessAdequateYesNoLabel.Location = New System.Drawing.Point(400, 172)
        DDAAccessAdequateYesNoLabel.Name = "DDAAccessAdequateYesNoLabel"
        DDAAccessAdequateYesNoLabel.Size = New System.Drawing.Size(64, 13)
        DDAAccessAdequateYesNoLabel.TabIndex = 49
        DDAAccessAdequateYesNoLabel.Text = "- adequate?"
        '
        'DDACommentsLabel
        '
        DDACommentsLabel.AutoSize = True
        DDACommentsLabel.Location = New System.Drawing.Point(21, 193)
        DDACommentsLabel.Name = "DDACommentsLabel"
        DDACommentsLabel.Size = New System.Drawing.Size(59, 13)
        DDACommentsLabel.TabIndex = 50
        DDACommentsLabel.Text = "Comments:"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(479, 12)
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
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Disability Discrimination Act (DDA)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'DDAImpactYesNoExtendedComboBox
        '
        Me.DDAImpactYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DDAImpactYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDAImpactYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DDAImpactYesNo", True))
        Me.DDAImpactYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.DDAImpactYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.DDAImpactYesNoExtendedComboBox.FormattingEnabled = True
        Me.DDAImpactYesNoExtendedComboBox.Location = New System.Drawing.Point(479, 43)
        Me.DDAImpactYesNoExtendedComboBox.Name = "DDAImpactYesNoExtendedComboBox"
        Me.DDAImpactYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DDAImpactYesNoExtendedComboBox.TabIndex = 46
        Me.DDAImpactYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'DDACommitteeYesNoExtendedComboBox
        '
        Me.DDACommitteeYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DDACommitteeYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDACommitteeYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DDACommitteeYesNo", True))
        Me.DDACommitteeYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.DDACommitteeYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.DDACommitteeYesNoExtendedComboBox.FormattingEnabled = True
        Me.DDACommitteeYesNoExtendedComboBox.Location = New System.Drawing.Point(479, 76)
        Me.DDACommitteeYesNoExtendedComboBox.Name = "DDACommitteeYesNoExtendedComboBox"
        Me.DDACommitteeYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DDACommitteeYesNoExtendedComboBox.TabIndex = 47
        Me.DDACommitteeYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'DDAAccessYesNoExtendedComboBox
        '
        Me.DDAAccessYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DDAAccessYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDAAccessYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DDAAccessYesNo", True))
        Me.DDAAccessYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.DDAAccessYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.DDAAccessYesNoExtendedComboBox.FormattingEnabled = True
        Me.DDAAccessYesNoExtendedComboBox.Location = New System.Drawing.Point(479, 108)
        Me.DDAAccessYesNoExtendedComboBox.Name = "DDAAccessYesNoExtendedComboBox"
        Me.DDAAccessYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DDAAccessYesNoExtendedComboBox.TabIndex = 48
        Me.DDAAccessYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'DDAAccessAvailYesNoExtendedComboBox
        '
        Me.DDAAccessAvailYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DDAAccessAvailYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDAAccessAvailYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DDAAccessAvailYesNo", True))
        Me.DDAAccessAvailYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource3
        Me.DDAAccessAvailYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.DDAAccessAvailYesNoExtendedComboBox.FormattingEnabled = True
        Me.DDAAccessAvailYesNoExtendedComboBox.Location = New System.Drawing.Point(479, 139)
        Me.DDAAccessAvailYesNoExtendedComboBox.Name = "DDAAccessAvailYesNoExtendedComboBox"
        Me.DDAAccessAvailYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DDAAccessAvailYesNoExtendedComboBox.TabIndex = 49
        Me.DDAAccessAvailYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource3
        '
        Me.GenericAnswersToQuestionsBindingSource3.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource3.DataSource = Me.AAdata
        '
        'DDAAccessAdequateYesNoExtendedComboBox
        '
        Me.DDAAccessAdequateYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DDAAccessAdequateYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDAAccessAdequateYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DDAAccessAdequateYesNo", True))
        Me.DDAAccessAdequateYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource4
        Me.DDAAccessAdequateYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.DDAAccessAdequateYesNoExtendedComboBox.FormattingEnabled = True
        Me.DDAAccessAdequateYesNoExtendedComboBox.Location = New System.Drawing.Point(479, 169)
        Me.DDAAccessAdequateYesNoExtendedComboBox.Name = "DDAAccessAdequateYesNoExtendedComboBox"
        Me.DDAAccessAdequateYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DDAAccessAdequateYesNoExtendedComboBox.TabIndex = 50
        Me.DDAAccessAdequateYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource4
        '
        Me.GenericAnswersToQuestionsBindingSource4.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource4.DataSource = Me.AAdata
        '
        'DDACommentsTextBox
        '
        Me.DDACommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DDAComments", True))
        Me.DDACommentsTextBox.Location = New System.Drawing.Point(24, 209)
        Me.DDACommentsTextBox.MaxLength = 3000
        Me.DDACommentsTextBox.Multiline = True
        Me.DDACommentsTextBox.Name = "DDACommentsTextBox"
        Me.DDACommentsTextBox.Size = New System.Drawing.Size(576, 49)
        Me.DDACommentsTextBox.TabIndex = 51
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'DiabilityDiscriminationActAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 273)
        Me.Controls.Add(DDACommentsLabel)
        Me.Controls.Add(Me.DDACommentsTextBox)
        Me.Controls.Add(DDAAccessAdequateYesNoLabel)
        Me.Controls.Add(Me.DDAAccessAdequateYesNoExtendedComboBox)
        Me.Controls.Add(DDAAccessAvailYesNoLabel)
        Me.Controls.Add(Me.DDAAccessAvailYesNoExtendedComboBox)
        Me.Controls.Add(DDAAccessYesNoLabel)
        Me.Controls.Add(Me.DDAAccessYesNoExtendedComboBox)
        Me.Controls.Add(DDACommitteeYesNoLabel)
        Me.Controls.Add(Me.DDACommitteeYesNoExtendedComboBox)
        Me.Controls.Add(DDAImpactYesNoLabel)
        Me.Controls.Add(Me.DDAImpactYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DiabilityDiscriminationActAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Diability Discrimination Act Assessment"
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
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents DDAImpactYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DDACommitteeYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DDAAccessYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DDAAccessAvailYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DDAAccessAdequateYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DDACommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource4 As System.Windows.Forms.BindingSource
End Class
