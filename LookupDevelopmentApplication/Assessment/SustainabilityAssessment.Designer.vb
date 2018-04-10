<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SustainabilityAssessment
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
        Dim SustImpactYesNoLabel As System.Windows.Forms.Label
        Dim SustImpactWasteCommentsLabel As System.Windows.Forms.Label
        Dim SustImpactWaterCommentsLabel As System.Windows.Forms.Label
        Dim SustImpactVegeCommentsLabel As System.Windows.Forms.Label
        Dim SustainGenComLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.SustImpactYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        Me.SustImpactWasteCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SustImpactWaterCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SustImpactVegeCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SustainGenComTextBox = New System.Windows.Forms.TextBox()
        SustImpactYesNoLabel = New System.Windows.Forms.Label()
        SustImpactWasteCommentsLabel = New System.Windows.Forms.Label()
        SustImpactWaterCommentsLabel = New System.Windows.Forms.Label()
        SustImpactVegeCommentsLabel = New System.Windows.Forms.Label()
        SustainGenComLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SustImpactYesNoLabel
        '
        SustImpactYesNoLabel.AutoSize = True
        SustImpactYesNoLabel.Location = New System.Drawing.Point(20, 52)
        SustImpactYesNoLabel.Name = "SustImpactYesNoLabel"
        SustImpactYesNoLabel.Size = New System.Drawing.Size(125, 13)
        SustImpactYesNoLabel.TabIndex = 43
        SustImpactYesNoLabel.Text = "Impact on sustainability?:"
        '
        'SustImpactWasteCommentsLabel
        '
        SustImpactWasteCommentsLabel.AutoSize = True
        SustImpactWasteCommentsLabel.Location = New System.Drawing.Point(20, 93)
        SustImpactWasteCommentsLabel.Name = "SustImpactWasteCommentsLabel"
        SustImpactWasteCommentsLabel.Size = New System.Drawing.Size(96, 13)
        SustImpactWasteCommentsLabel.TabIndex = 44
        SustImpactWasteCommentsLabel.Text = "Comments - Waste"
        '
        'SustImpactWaterCommentsLabel
        '
        SustImpactWaterCommentsLabel.AutoSize = True
        SustImpactWaterCommentsLabel.Location = New System.Drawing.Point(20, 181)
        SustImpactWaterCommentsLabel.Name = "SustImpactWaterCommentsLabel"
        SustImpactWaterCommentsLabel.Size = New System.Drawing.Size(94, 13)
        SustImpactWaterCommentsLabel.TabIndex = 45
        SustImpactWaterCommentsLabel.Text = "Comments - Water"
        '
        'SustImpactVegeCommentsLabel
        '
        SustImpactVegeCommentsLabel.AutoSize = True
        SustImpactVegeCommentsLabel.Location = New System.Drawing.Point(20, 269)
        SustImpactVegeCommentsLabel.Name = "SustImpactVegeCommentsLabel"
        SustImpactVegeCommentsLabel.Size = New System.Drawing.Size(116, 13)
        SustImpactVegeCommentsLabel.TabIndex = 46
        SustImpactVegeCommentsLabel.Text = "Comments - Vegetation"
        '
        'SustainGenComLabel
        '
        SustainGenComLabel.AutoSize = True
        SustainGenComLabel.Location = New System.Drawing.Point(20, 355)
        SustainGenComLabel.Name = "SustainGenComLabel"
        SustainGenComLabel.Size = New System.Drawing.Size(99, 13)
        SustainGenComLabel.TabIndex = 47
        SustainGenComLabel.Text = "General Comments:"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(478, 12)
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
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Sustainability"
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
        'SustImpactYesNoExtendedComboBox
        '
        Me.SustImpactYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SustImpactYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SustImpactYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SustImpactYesNo", True))
        Me.SustImpactYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.SustImpactYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SustImpactYesNoExtendedComboBox.FormattingEnabled = True
        Me.SustImpactYesNoExtendedComboBox.Location = New System.Drawing.Point(151, 49)
        Me.SustImpactYesNoExtendedComboBox.Name = "SustImpactYesNoExtendedComboBox"
        Me.SustImpactYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SustImpactYesNoExtendedComboBox.TabIndex = 44
        Me.SustImpactYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'SustImpactWasteCommentsTextBox
        '
        Me.SustImpactWasteCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SustImpactWasteComments", True))
        Me.SustImpactWasteCommentsTextBox.Location = New System.Drawing.Point(23, 109)
        Me.SustImpactWasteCommentsTextBox.MaxLength = 3000
        Me.SustImpactWasteCommentsTextBox.Multiline = True
        Me.SustImpactWasteCommentsTextBox.Name = "SustImpactWasteCommentsTextBox"
        Me.SustImpactWasteCommentsTextBox.Size = New System.Drawing.Size(576, 55)
        Me.SustImpactWasteCommentsTextBox.TabIndex = 45
        '
        'SustImpactWaterCommentsTextBox
        '
        Me.SustImpactWaterCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SustImpactWaterComments", True))
        Me.SustImpactWaterCommentsTextBox.Location = New System.Drawing.Point(23, 197)
        Me.SustImpactWaterCommentsTextBox.MaxLength = 3000
        Me.SustImpactWaterCommentsTextBox.Multiline = True
        Me.SustImpactWaterCommentsTextBox.Name = "SustImpactWaterCommentsTextBox"
        Me.SustImpactWaterCommentsTextBox.Size = New System.Drawing.Size(576, 55)
        Me.SustImpactWaterCommentsTextBox.TabIndex = 46
        '
        'SustImpactVegeCommentsTextBox
        '
        Me.SustImpactVegeCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SustImpactVegeComments", True))
        Me.SustImpactVegeCommentsTextBox.Location = New System.Drawing.Point(23, 285)
        Me.SustImpactVegeCommentsTextBox.MaxLength = 3000
        Me.SustImpactVegeCommentsTextBox.Multiline = True
        Me.SustImpactVegeCommentsTextBox.Name = "SustImpactVegeCommentsTextBox"
        Me.SustImpactVegeCommentsTextBox.Size = New System.Drawing.Size(576, 55)
        Me.SustImpactVegeCommentsTextBox.TabIndex = 47
        '
        'SustainGenComTextBox
        '
        Me.SustainGenComTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SustainGenCom", True))
        Me.SustainGenComTextBox.Location = New System.Drawing.Point(23, 371)
        Me.SustainGenComTextBox.MaxLength = 3000
        Me.SustainGenComTextBox.Multiline = True
        Me.SustainGenComTextBox.Name = "SustainGenComTextBox"
        Me.SustainGenComTextBox.Size = New System.Drawing.Size(576, 55)
        Me.SustainGenComTextBox.TabIndex = 48
        '
        'SustainabilityAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 444)
        Me.Controls.Add(SustainGenComLabel)
        Me.Controls.Add(Me.SustainGenComTextBox)
        Me.Controls.Add(SustImpactVegeCommentsLabel)
        Me.Controls.Add(Me.SustImpactVegeCommentsTextBox)
        Me.Controls.Add(SustImpactWaterCommentsLabel)
        Me.Controls.Add(Me.SustImpactWaterCommentsTextBox)
        Me.Controls.Add(SustImpactWasteCommentsLabel)
        Me.Controls.Add(Me.SustImpactWasteCommentsTextBox)
        Me.Controls.Add(Me.SustImpactYesNoExtendedComboBox)
        Me.Controls.Add(SustImpactYesNoLabel)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SustainabilityAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sustainability Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents SustImpactYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents SustImpactWasteCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SustImpactWaterCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SustImpactVegeCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SustainGenComTextBox As System.Windows.Forms.TextBox
End Class
