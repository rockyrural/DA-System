<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeritageAssessment
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
        Dim HeritageAborYesNoLabel As System.Windows.Forms.Label
        Dim HeritageProvYesNoLabel As System.Windows.Forms.Label
        Dim HeritageTilbaYesNoLabel As System.Windows.Forms.Label
        Dim HeritageImpactStatemtYesNoLabel As System.Windows.Forms.Label
        Dim HeritageCommentsLabel As System.Windows.Forms.Label
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.HeritageAborYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeritageProvYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeritageTilbaYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeritageImpactStatemtYesNoExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.GenericAnswersToQuestionsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeritageCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        HeritageAborYesNoLabel = New System.Windows.Forms.Label()
        HeritageProvYesNoLabel = New System.Windows.Forms.Label()
        HeritageTilbaYesNoLabel = New System.Windows.Forms.Label()
        HeritageImpactStatemtYesNoLabel = New System.Windows.Forms.Label()
        HeritageCommentsLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeritageAborYesNoLabel
        '
        HeritageAborYesNoLabel.AutoSize = True
        HeritageAborYesNoLabel.Location = New System.Drawing.Point(30, 66)
        HeritageAborYesNoLabel.Name = "HeritageAborYesNoLabel"
        HeritageAborYesNoLabel.Size = New System.Drawing.Size(319, 13)
        HeritageAborYesNoLabel.TabIndex = 45
        HeritageAborYesNoLabel.Text = "- any impact on Heritage item or an item of Aboriginal significance?"
        '
        'HeritageProvYesNoLabel
        '
        HeritageProvYesNoLabel.AutoSize = True
        HeritageProvYesNoLabel.Location = New System.Drawing.Point(30, 97)
        HeritageProvYesNoLabel.Name = "HeritageProvYesNoLabel"
        HeritageProvYesNoLabel.Size = New System.Drawing.Size(296, 13)
        HeritageProvYesNoLabel.TabIndex = 46
        HeritageProvYesNoLabel.Text = "- is the development subject to Heritage provisions or listings?"
        '
        'HeritageTilbaYesNoLabel
        '
        HeritageTilbaYesNoLabel.Location = New System.Drawing.Point(30, 126)
        HeritageTilbaYesNoLabel.Name = "HeritageTilbaYesNoLabel"
        HeritageTilbaYesNoLabel.Size = New System.Drawing.Size(441, 27)
        HeritageTilbaYesNoLabel.TabIndex = 47
        HeritageTilbaYesNoLabel.Text = "- is the property located within the Tilba Conservation Area or does the property" & _
    " contain a listed heritage item, or an item identifed in the Heritage Inventory " & _
    "or for further investigation?"
        '
        'HeritageImpactStatemtYesNoLabel
        '
        HeritageImpactStatemtYesNoLabel.AutoSize = True
        HeritageImpactStatemtYesNoLabel.Location = New System.Drawing.Point(173, 164)
        HeritageImpactStatemtYesNoLabel.Name = "HeritageImpactStatemtYesNoLabel"
        HeritageImpactStatemtYesNoLabel.Size = New System.Drawing.Size(285, 13)
        HeritageImpactStatemtYesNoLabel.TabIndex = 48
        HeritageImpactStatemtYesNoLabel.Text = "- if yes, has a Statement of Heritage Impact been submitted"
        '
        'HeritageCommentsLabel
        '
        HeritageCommentsLabel.AutoSize = True
        HeritageCommentsLabel.Location = New System.Drawing.Point(30, 231)
        HeritageCommentsLabel.Name = "HeritageCommentsLabel"
        HeritageCommentsLabel.Size = New System.Drawing.Size(102, 13)
        HeritageCommentsLabel.TabIndex = 49
        HeritageCommentsLabel.Text = "Heritage Comments:"
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
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Heritage"
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
        'HeritageAborYesNoExtendedComboBox
        '
        Me.HeritageAborYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HeritageAborYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HeritageAborYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "HeritageAborYesNo", True))
        Me.HeritageAborYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.HeritageAborYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.HeritageAborYesNoExtendedComboBox.FormattingEnabled = True
        Me.HeritageAborYesNoExtendedComboBox.Location = New System.Drawing.Point(477, 63)
        Me.HeritageAborYesNoExtendedComboBox.Name = "HeritageAborYesNoExtendedComboBox"
        Me.HeritageAborYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HeritageAborYesNoExtendedComboBox.TabIndex = 46
        Me.HeritageAborYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'HeritageProvYesNoExtendedComboBox
        '
        Me.HeritageProvYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HeritageProvYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HeritageProvYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "HeritageProvYesNo", True))
        Me.HeritageProvYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.HeritageProvYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.HeritageProvYesNoExtendedComboBox.FormattingEnabled = True
        Me.HeritageProvYesNoExtendedComboBox.Location = New System.Drawing.Point(477, 94)
        Me.HeritageProvYesNoExtendedComboBox.Name = "HeritageProvYesNoExtendedComboBox"
        Me.HeritageProvYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HeritageProvYesNoExtendedComboBox.TabIndex = 47
        Me.HeritageProvYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource1
        '
        Me.GenericAnswersToQuestionsBindingSource1.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource1.DataSource = Me.AAdata
        '
        'HeritageTilbaYesNoExtendedComboBox
        '
        Me.HeritageTilbaYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HeritageTilbaYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HeritageTilbaYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "HeritageTilbaYesNo", True))
        Me.HeritageTilbaYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource2
        Me.HeritageTilbaYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.HeritageTilbaYesNoExtendedComboBox.FormattingEnabled = True
        Me.HeritageTilbaYesNoExtendedComboBox.Location = New System.Drawing.Point(477, 132)
        Me.HeritageTilbaYesNoExtendedComboBox.Name = "HeritageTilbaYesNoExtendedComboBox"
        Me.HeritageTilbaYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HeritageTilbaYesNoExtendedComboBox.TabIndex = 48
        Me.HeritageTilbaYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource2
        '
        Me.GenericAnswersToQuestionsBindingSource2.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource2.DataSource = Me.AAdata
        '
        'HeritageImpactStatemtYesNoExtendedComboBox
        '
        Me.HeritageImpactStatemtYesNoExtendedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HeritageImpactStatemtYesNoExtendedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HeritageImpactStatemtYesNoExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "HeritageImpactStatemtYesNo", True))
        Me.HeritageImpactStatemtYesNoExtendedComboBox.DataSource = Me.GenericAnswersToQuestionsBindingSource3
        Me.HeritageImpactStatemtYesNoExtendedComboBox.DisplayMember = "ResultCodeDesc"
        Me.HeritageImpactStatemtYesNoExtendedComboBox.FormattingEnabled = True
        Me.HeritageImpactStatemtYesNoExtendedComboBox.Location = New System.Drawing.Point(477, 161)
        Me.HeritageImpactStatemtYesNoExtendedComboBox.Name = "HeritageImpactStatemtYesNoExtendedComboBox"
        Me.HeritageImpactStatemtYesNoExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HeritageImpactStatemtYesNoExtendedComboBox.TabIndex = 49
        Me.HeritageImpactStatemtYesNoExtendedComboBox.ValueMember = "ResultCode"
        '
        'GenericAnswersToQuestionsBindingSource3
        '
        Me.GenericAnswersToQuestionsBindingSource3.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource3.DataSource = Me.AAdata
        '
        'HeritageCommentsTextBox
        '
        Me.HeritageCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "HeritageComments", True))
        Me.HeritageCommentsTextBox.Location = New System.Drawing.Point(33, 247)
        Me.HeritageCommentsTextBox.MaxLength = 3000
        Me.HeritageCommentsTextBox.Multiline = True
        Me.HeritageCommentsTextBox.Name = "HeritageCommentsTextBox"
        Me.HeritageCommentsTextBox.Size = New System.Drawing.Size(576, 49)
        Me.HeritageCommentsTextBox.TabIndex = 50
        '
        'GenericAnswersToQuestionsTableAdapter
        '
        Me.GenericAnswersToQuestionsTableAdapter.ClearBeforeFill = True
        '
        'HeritageAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 319)
        Me.Controls.Add(HeritageCommentsLabel)
        Me.Controls.Add(Me.HeritageCommentsTextBox)
        Me.Controls.Add(HeritageImpactStatemtYesNoLabel)
        Me.Controls.Add(Me.HeritageImpactStatemtYesNoExtendedComboBox)
        Me.Controls.Add(HeritageTilbaYesNoLabel)
        Me.Controls.Add(Me.HeritageTilbaYesNoExtendedComboBox)
        Me.Controls.Add(HeritageProvYesNoLabel)
        Me.Controls.Add(Me.HeritageProvYesNoExtendedComboBox)
        Me.Controls.Add(HeritageAborYesNoLabel)
        Me.Controls.Add(Me.HeritageAborYesNoExtendedComboBox)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HeritageAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Heritage Assessment"
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
    Friend WithEvents HeritageAborYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HeritageProvYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HeritageTilbaYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HeritageImpactStatemtYesNoExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HeritageCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsBindingSource3 As System.Windows.Forms.BindingSource
End Class
