<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositedPlanAssessment
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim DPRestrictsYNLabel As System.Windows.Forms.Label
        Dim DPEasementsYNLabel As System.Windows.Forms.Label
        Dim DPRestrictCommentLabel As System.Windows.Forms.Label
        Dim DPEasementsCommentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepositedPlanAssessment))
        Me.btnMark = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.cboDPRestrictsYN = New DevExpress.XtraEditors.LookUpEdit()
        Me.GenericAnswersToQuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDPEasementsYN = New DevExpress.XtraEditors.LookUpEdit()
        Me.GenericAnswersToQuestionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenericAnswersToQuestionsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter()
        Me.txtDPRestrictComment = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDPEasements = New DevExpress.XtraEditors.MemoEdit()
        DPRestrictsYNLabel = New System.Windows.Forms.Label()
        DPEasementsYNLabel = New System.Windows.Forms.Label()
        DPRestrictCommentLabel = New System.Windows.Forms.Label()
        DPEasementsCommentLabel = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDPRestrictsYN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDPEasementsYN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDPRestrictComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDPEasements.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DPRestrictsYNLabel
        '
        DPRestrictsYNLabel.AutoSize = True
        DPRestrictsYNLabel.Location = New System.Drawing.Point(73, 52)
        DPRestrictsYNLabel.Name = "DPRestrictsYNLabel"
        DPRestrictsYNLabel.Size = New System.Drawing.Size(243, 13)
        DPRestrictsYNLabel.TabIndex = 45
        DPRestrictsYNLabel.Text = "Do any 'restrictions as to user' apply on the land?"
        '
        'DPEasementsYNLabel
        '
        DPEasementsYNLabel.AutoSize = True
        DPEasementsYNLabel.Location = New System.Drawing.Point(73, 280)
        DPEasementsYNLabel.Name = "DPEasementsYNLabel"
        DPEasementsYNLabel.Size = New System.Drawing.Size(191, 13)
        DPEasementsYNLabel.TabIndex = 46
        DPEasementsYNLabel.Text = "Are there any easements on the land?"
        '
        'DPRestrictCommentLabel
        '
        DPRestrictCommentLabel.AutoSize = True
        DPRestrictCommentLabel.Location = New System.Drawing.Point(16, 76)
        DPRestrictCommentLabel.Name = "DPRestrictCommentLabel"
        DPRestrictCommentLabel.Size = New System.Drawing.Size(56, 13)
        DPRestrictCommentLabel.TabIndex = 47
        DPRestrictCommentLabel.Text = "Comment:"
        '
        'DPEasementsCommentLabel
        '
        DPEasementsCommentLabel.AutoSize = True
        DPEasementsCommentLabel.Location = New System.Drawing.Point(16, 306)
        DPEasementsCommentLabel.Name = "DPEasementsCommentLabel"
        DPEasementsCommentLabel.Size = New System.Drawing.Size(56, 13)
        DPEasementsCommentLabel.TabIndex = 48
        DPEasementsCommentLabel.Text = "Comment:"
        '
        'btnMark
        '
        Me.btnMark.Image = CType(resources.GetObject("btnMark.Image"), System.Drawing.Image)
        Me.btnMark.Location = New System.Drawing.Point(645, 12)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(121, 23)
        Me.btnMark.TabIndex = 43
        Me.btnMark.Text = "Mark All as N/A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Deposited Plan"
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
        'cboDPRestrictsYN
        '
        Me.cboDPRestrictsYN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DAAssessmentDataBindingSource, "DPRestrictsYN", True))
        Me.cboDPRestrictsYN.Location = New System.Drawing.Point(645, 47)
        Me.cboDPRestrictsYN.Name = "cboDPRestrictsYN"
        Me.cboDPRestrictsYN.Properties.DataSource = Me.GenericAnswersToQuestionsBindingSource
        Me.cboDPRestrictsYN.Properties.DisplayMember = "ResultCodeDesc"
        Me.cboDPRestrictsYN.Properties.NullText = "[Restrictions Apply?]"
        Me.cboDPRestrictsYN.Properties.ValueMember = "ResultCode"
        Me.cboDPRestrictsYN.Size = New System.Drawing.Size(121, 20)
        Me.cboDPRestrictsYN.TabIndex = 0
        '
        'GenericAnswersToQuestionsBindingSource
        '
        Me.GenericAnswersToQuestionsBindingSource.DataMember = "GenericAnswersToQuestions"
        Me.GenericAnswersToQuestionsBindingSource.DataSource = Me.AAdata
        '
        'cboDPEasementsYN
        '
        Me.cboDPEasementsYN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DAAssessmentDataBindingSource, "DPEasementsYN", True))
        Me.cboDPEasementsYN.Location = New System.Drawing.Point(645, 277)
        Me.cboDPEasementsYN.Name = "cboDPEasementsYN"
        Me.cboDPEasementsYN.Properties.DataSource = Me.GenericAnswersToQuestionsBindingSource1
        Me.cboDPEasementsYN.Properties.DisplayMember = "ResultCodeDesc"
        Me.cboDPEasementsYN.Properties.NullText = "[Any Easements?]"
        Me.cboDPEasementsYN.Properties.ValueMember = "ResultCode"
        Me.cboDPEasementsYN.Size = New System.Drawing.Size(121, 20)
        Me.cboDPEasementsYN.TabIndex = 2
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
        'txtDPRestrictComment
        '
        Me.txtDPRestrictComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DPRestrictComment", True))
        Me.txtDPRestrictComment.Location = New System.Drawing.Point(76, 73)
        Me.txtDPRestrictComment.Name = "txtDPRestrictComment"
        Me.txtDPRestrictComment.Size = New System.Drawing.Size(690, 183)
        Me.txtDPRestrictComment.TabIndex = 1
        '
        'txtDPEasements
        '
        Me.txtDPEasements.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DPEasementsComment", True))
        Me.txtDPEasements.Location = New System.Drawing.Point(76, 303)
        Me.txtDPEasements.Name = "txtDPEasements"
        Me.txtDPEasements.Size = New System.Drawing.Size(690, 183)
        Me.txtDPEasements.TabIndex = 3
        '
        'DepositedPlanAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 497)
        Me.Controls.Add(DPEasementsCommentLabel)
        Me.Controls.Add(DPRestrictCommentLabel)
        Me.Controls.Add(DPEasementsYNLabel)
        Me.Controls.Add(Me.cboDPEasementsYN)
        Me.Controls.Add(DPRestrictsYNLabel)
        Me.Controls.Add(Me.cboDPRestrictsYN)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDPRestrictComment)
        Me.Controls.Add(Me.txtDPEasements)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DepositedPlanAssessment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Deposited Plan Assessment"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDPRestrictsYN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDPEasementsYN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenericAnswersToQuestionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDPRestrictComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDPEasements.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents cboDPRestrictsYN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDPEasementsYN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GenericAnswersToQuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenericAnswersToQuestionsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GenericAnswersToQuestionsTableAdapter
    Friend WithEvents GenericAnswersToQuestionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtDPRestrictComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDPEasements As DevExpress.XtraEditors.MemoEdit
End Class
