<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SocialEconomicImpactsAssessment
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
        Dim SocialEcoYesNoLabel As System.Windows.Forms.Label
        Dim SocialEcoCommentsLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.SocialEcoYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SocialEcoCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        SocialEcoYesNoLabel = New System.Windows.Forms.Label()
        SocialEcoCommentsLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SocialEcoYesNoLabel
        '
        SocialEcoYesNoLabel.AutoSize = True
        SocialEcoYesNoLabel.Location = New System.Drawing.Point(19, 44)
        SocialEcoYesNoLabel.Name = "SocialEcoYesNoLabel"
        SocialEcoYesNoLabel.Size = New System.Drawing.Size(446, 13)
        SocialEcoYesNoLabel.TabIndex = 43
        SocialEcoYesNoLabel.Text = "Is proposal satis. having regard to the social && economic effects on the localit" & _
            "y, town or shire?"
        '
        'SocialEcoCommentsLabel
        '
        SocialEcoCommentsLabel.AutoSize = True
        SocialEcoCommentsLabel.Location = New System.Drawing.Point(19, 77)
        SocialEcoCommentsLabel.Name = "SocialEcoCommentsLabel"
        SocialEcoCommentsLabel.Size = New System.Drawing.Size(59, 13)
        SocialEcoCommentsLabel.TabIndex = 44
        SocialEcoCommentsLabel.Text = "Comments:"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(477, 12)
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
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Social and Economic Impacts"
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
        'SocialEcoYesNoExtendedComboBox
        '
        Me.SocialEcoYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SocialEcoYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SocialEcoYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "SocialEcoYesNo", True))
        Me.SocialEcoYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.SocialEcoYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.SocialEcoYesNoExtendedComboBox.FormattingEnabled = True
        Me.SocialEcoYesNoExtendedComboBox.Location = New System.Drawing.Point(477, 41)
        Me.SocialEcoYesNoExtendedComboBox.Name = "SocialEcoYesNoExtendedComboBox"
        Me.SocialEcoYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SocialEcoYesNoExtendedComboBox.TabIndex = 44
        Me.SocialEcoYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'SocialEcoCommentsTextBox
        '
        Me.SocialEcoCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "SocialEcoComments", True))
        Me.SocialEcoCommentsTextBox.Location = New System.Drawing.Point(22, 93)
        Me.SocialEcoCommentsTextBox.MaxLength = 1000
        Me.SocialEcoCommentsTextBox.Multiline = True
        Me.SocialEcoCommentsTextBox.Name = "SocialEcoCommentsTextBox"
        Me.SocialEcoCommentsTextBox.Size = New System.Drawing.Size(576, 55)
        Me.SocialEcoCommentsTextBox.TabIndex = 45
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'SocialEconomicImpactsAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 160)
        Me.Controls.Add(SocialEcoCommentsLabel)
        Me.Controls.Add(Me.SocialEcoCommentsTextBox)
        Me.Controls.Add(SocialEcoYesNoLabel)
        Me.Controls.Add(Me.SocialEcoYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SocialEconomicImpactsAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Social and Economic Impacts Assessment"
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
    Friend WithEvents SocialEcoYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SocialEcoCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
End Class
