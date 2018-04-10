<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandscapingAssessment
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
        Dim LandScapProvYesNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim LandScapAppropYesNoLabel As System.Windows.Forms.Label
        Dim LandScapVegeYesNoLabel As System.Windows.Forms.Label
        Dim LandScapCommentsLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.LandScapProvYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LandScapAppropYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LandScapVegeYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LandScapCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        LandScapProvYesNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        LandScapAppropYesNoLabel = New System.Windows.Forms.Label()
        LandScapVegeYesNoLabel = New System.Windows.Forms.Label()
        LandScapCommentsLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LandScapProvYesNoLabel
        '
        LandScapProvYesNoLabel.AutoSize = True
        LandScapProvYesNoLabel.Location = New System.Drawing.Point(177, 55)
        LandScapProvYesNoLabel.Name = "LandScapProvYesNoLabel"
        LandScapProvYesNoLabel.Size = New System.Drawing.Size(188, 13)
        LandScapProvYesNoLabel.TabIndex = 45
        LandScapProvYesNoLabel.Text = "- provision for landscaping on the site?"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(20, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(277, 13)
        Label2.TabIndex = 45
        Label2.Text = "Is the proposal satisfactory having regard to the following:"
        '
        'LandScapAppropYesNoLabel
        '
        LandScapAppropYesNoLabel.AutoSize = True
        LandScapAppropYesNoLabel.Location = New System.Drawing.Point(177, 90)
        LandScapAppropYesNoLabel.Name = "LandScapAppropYesNoLabel"
        LandScapAppropYesNoLabel.Size = New System.Drawing.Size(291, 13)
        LandScapAppropYesNoLabel.TabIndex = 46
        LandScapAppropYesNoLabel.Text = "- appropriate landscaping (including screening and fencing)?"
        '
        'LandScapVegeYesNoLabel
        '
        LandScapVegeYesNoLabel.AutoSize = True
        LandScapVegeYesNoLabel.Location = New System.Drawing.Point(177, 128)
        LandScapVegeYesNoLabel.Name = "LandScapVegeYesNoLabel"
        LandScapVegeYesNoLabel.Size = New System.Drawing.Size(295, 13)
        LandScapVegeYesNoLabel.TabIndex = 47
        LandScapVegeYesNoLabel.Text = "- any existing vegetation or trees which should be preserved?"
        '
        'LandScapCommentsLabel
        '
        LandScapCommentsLabel.AutoSize = True
        LandScapCommentsLabel.Location = New System.Drawing.Point(20, 155)
        LandScapCommentsLabel.Name = "LandScapCommentsLabel"
        LandScapCommentsLabel.Size = New System.Drawing.Size(59, 13)
        LandScapCommentsLabel.TabIndex = 48
        LandScapCommentsLabel.Text = "Comments:"
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(478, 12)
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
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Landscaping"
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
        'LandScapProvYesNoExtendedComboBox
        '
        Me.LandScapProvYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LandScapProvYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LandScapProvYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "LandScapProvYesNo", True))
        Me.LandScapProvYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.LandScapProvYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.LandScapProvYesNoExtendedComboBox.FormattingEnabled = True
        Me.LandScapProvYesNoExtendedComboBox.Location = New System.Drawing.Point(478, 52)
        Me.LandScapProvYesNoExtendedComboBox.Name = "LandScapProvYesNoExtendedComboBox"
        Me.LandScapProvYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LandScapProvYesNoExtendedComboBox.TabIndex = 46
        Me.LandScapProvYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'LandScapAppropYesNoExtendedComboBox
        '
        Me.LandScapAppropYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LandScapAppropYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LandScapAppropYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "LandScapAppropYesNo", True))
        Me.LandScapAppropYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.LandScapAppropYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.LandScapAppropYesNoExtendedComboBox.FormattingEnabled = True
        Me.LandScapAppropYesNoExtendedComboBox.Location = New System.Drawing.Point(478, 87)
        Me.LandScapAppropYesNoExtendedComboBox.Name = "LandScapAppropYesNoExtendedComboBox"
        Me.LandScapAppropYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LandScapAppropYesNoExtendedComboBox.TabIndex = 47
        Me.LandScapAppropYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'LandScapVegeYesNoExtendedComboBox
        '
        Me.LandScapVegeYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LandScapVegeYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LandScapVegeYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "LandScapVegeYesNo", True))
        Me.LandScapVegeYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.LandScapVegeYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.LandScapVegeYesNoExtendedComboBox.FormattingEnabled = True
        Me.LandScapVegeYesNoExtendedComboBox.Location = New System.Drawing.Point(478, 125)
        Me.LandScapVegeYesNoExtendedComboBox.Name = "LandScapVegeYesNoExtendedComboBox"
        Me.LandScapVegeYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LandScapVegeYesNoExtendedComboBox.TabIndex = 48
        Me.LandScapVegeYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'LandScapCommentsTextBox
        '
        Me.LandScapCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "LandScapComments", True))
        Me.LandScapCommentsTextBox.Location = New System.Drawing.Point(23, 171)
        Me.LandScapCommentsTextBox.MaxLength = 3000
        Me.LandScapCommentsTextBox.Multiline = True
        Me.LandScapCommentsTextBox.Name = "LandScapCommentsTextBox"
        Me.LandScapCommentsTextBox.Size = New System.Drawing.Size(576, 78)
        Me.LandScapCommentsTextBox.TabIndex = 49
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'LandscapingAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 261)
        Me.Controls.Add(LandScapCommentsLabel)
        Me.Controls.Add(Me.LandScapCommentsTextBox)
        Me.Controls.Add(LandScapVegeYesNoLabel)
        Me.Controls.Add(Me.LandScapVegeYesNoExtendedComboBox)
        Me.Controls.Add(LandScapAppropYesNoLabel)
        Me.Controls.Add(Me.LandScapAppropYesNoExtendedComboBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(LandScapProvYesNoLabel)
        Me.Controls.Add(Me.LandScapProvYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LandscapingAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Landscaping Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents LandScapProvYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LandScapAppropYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LandScapVegeYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LandScapCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
End Class
