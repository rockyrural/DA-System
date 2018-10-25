<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DraftConditions
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
        Me.pnlConditions = New System.Windows.Forms.Panel()
        Me.btnRemoveCondition = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstConditions = New System.Windows.Forms.ListBox()
        Me.LoadReferralDraftConditionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCdata = New LookupDevelopmentApplication.CCdata()
        Me.cboConditionCode = New System.Windows.Forms.ComboBox()
        Me.txtcondition = New System.Windows.Forms.TextBox()
        Me.btnViewCondition = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnIncludeConditions = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBookMarks = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFreeformtext = New System.Windows.Forms.TextBox()
        Me.grpFreeForm = New System.Windows.Forms.GroupBox()
        Me.dgvReferralFreeformText = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetrieveBookmarksAndFreeTextBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRemoveFreeForm = New System.Windows.Forms.Button()
        Me.lblFreeFormID = New System.Windows.Forms.Label()
        Me.btnAddFreeformText = New System.Windows.Forms.Button()
        Me.LoadReferralDraftConditionsTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.LoadReferralDraftConditionsTableAdapter()
        Me.RetrieveBookmarksAndFreeTextTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.RetrieveBookmarksAndFreeTextTableAdapter()
        Me.pnlConditions.SuspendLayout()
        CType(Me.LoadReferralDraftConditionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.grpFreeForm.SuspendLayout()
        CType(Me.dgvReferralFreeformText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrieveBookmarksAndFreeTextBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlConditions
        '
        Me.pnlConditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConditions.Controls.Add(Me.btnRemoveCondition)
        Me.pnlConditions.Controls.Add(Me.Label3)
        Me.pnlConditions.Controls.Add(Me.lstConditions)
        Me.pnlConditions.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlConditions.Location = New System.Drawing.Point(0, 0)
        Me.pnlConditions.Name = "pnlConditions"
        Me.pnlConditions.Size = New System.Drawing.Size(249, 474)
        Me.pnlConditions.TabIndex = 0
        '
        'btnRemoveCondition
        '
        Me.btnRemoveCondition.Location = New System.Drawing.Point(8, 351)
        Me.btnRemoveCondition.Name = "btnRemoveCondition"
        Me.btnRemoveCondition.Size = New System.Drawing.Size(60, 23)
        Me.btnRemoveCondition.TabIndex = 4
        Me.btnRemoveCondition.Text = "Remove"
        Me.btnRemoveCondition.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Conditions selected for this referral"
        '
        'lstConditions
        '
        Me.lstConditions.DataSource = Me.LoadReferralDraftConditionsBindingSource
        Me.lstConditions.DisplayMember = "CondDesc"
        Me.lstConditions.FormattingEnabled = True
        Me.lstConditions.Location = New System.Drawing.Point(8, 29)
        Me.lstConditions.Name = "lstConditions"
        Me.lstConditions.Size = New System.Drawing.Size(231, 316)
        Me.lstConditions.TabIndex = 0
        Me.lstConditions.ValueMember = "AppCondid"
        '
        'LoadReferralDraftConditionsBindingSource
        '
        Me.LoadReferralDraftConditionsBindingSource.DataMember = "LoadReferralDraftConditions"
        Me.LoadReferralDraftConditionsBindingSource.DataSource = Me.CCdata
        '
        'CCdata
        '
        Me.CCdata.DataSetName = "CCdata"
        Me.CCdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboConditionCode
        '
        Me.cboConditionCode.FormattingEnabled = True
        Me.cboConditionCode.Location = New System.Drawing.Point(5, 29)
        Me.cboConditionCode.Name = "cboConditionCode"
        Me.cboConditionCode.Size = New System.Drawing.Size(85, 21)
        Me.cboConditionCode.TabIndex = 1
        '
        'txtcondition
        '
        Me.txtcondition.Location = New System.Drawing.Point(96, 29)
        Me.txtcondition.Name = "txtcondition"
        Me.txtcondition.ReadOnly = True
        Me.txtcondition.Size = New System.Drawing.Size(291, 20)
        Me.txtcondition.TabIndex = 2
        '
        'btnViewCondition
        '
        Me.btnViewCondition.Enabled = False
        Me.btnViewCondition.Location = New System.Drawing.Point(393, 26)
        Me.btnViewCondition.Name = "btnViewCondition"
        Me.btnViewCondition.Size = New System.Drawing.Size(60, 23)
        Me.btnViewCondition.TabIndex = 3
        Me.btnViewCondition.Text = "Preview"
        Me.btnViewCondition.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.btnIncludeConditions)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.txtcondition)
        Me.pnlTop.Controls.Add(Me.btnViewCondition)
        Me.pnlTop.Controls.Add(Me.cboConditionCode)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(249, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(617, 84)
        Me.pnlTop.TabIndex = 1
        '
        'btnIncludeConditions
        '
        Me.btnIncludeConditions.ForeColor = System.Drawing.Color.Blue
        Me.btnIncludeConditions.Location = New System.Drawing.Point(469, 17)
        Me.btnIncludeConditions.Name = "btnIncludeConditions"
        Me.btnIncludeConditions.Size = New System.Drawing.Size(117, 42)
        Me.btnIncludeConditions.TabIndex = 6
        Me.btnIncludeConditions.Text = "Include Conditions in Consent"
        Me.btnIncludeConditions.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Condition:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Condition Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCondition.Location = New System.Drawing.Point(394, 419)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(150, 43)
        Me.btnAddCondition.TabIndex = 5
        Me.btnAddCondition.Text = "< < < <   Add"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FreeForm Inserts for this condition:"
        '
        'cboBookMarks
        '
        Me.cboBookMarks.FormattingEnabled = True
        Me.cboBookMarks.Location = New System.Drawing.Point(8, 58)
        Me.cboBookMarks.Name = "cboBookMarks"
        Me.cboBookMarks.Size = New System.Drawing.Size(121, 21)
        Me.cboBookMarks.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Insert Bookmark"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Insert Bookmark"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFreeformtext
        '
        Me.txtFreeformtext.Location = New System.Drawing.Point(139, 58)
        Me.txtFreeformtext.Multiline = True
        Me.txtFreeformtext.Name = "txtFreeformtext"
        Me.txtFreeformtext.Size = New System.Drawing.Size(432, 52)
        Me.txtFreeformtext.TabIndex = 5
        '
        'grpFreeForm
        '
        Me.grpFreeForm.Controls.Add(Me.dgvReferralFreeformText)
        Me.grpFreeForm.Controls.Add(Me.btnRemoveFreeForm)
        Me.grpFreeForm.Controls.Add(Me.lblFreeFormID)
        Me.grpFreeForm.Controls.Add(Me.btnAddFreeformText)
        Me.grpFreeForm.Controls.Add(Me.txtFreeformtext)
        Me.grpFreeForm.Controls.Add(Me.Label5)
        Me.grpFreeForm.Controls.Add(Me.cboBookMarks)
        Me.grpFreeForm.Controls.Add(Me.Label6)
        Me.grpFreeForm.Controls.Add(Me.Label4)
        Me.grpFreeForm.Location = New System.Drawing.Point(255, 90)
        Me.grpFreeForm.Name = "grpFreeForm"
        Me.grpFreeForm.Size = New System.Drawing.Size(591, 304)
        Me.grpFreeForm.TabIndex = 6
        Me.grpFreeForm.TabStop = False
        Me.grpFreeForm.Visible = False
        '
        'dgvReferralFreeformText
        '
        Me.dgvReferralFreeformText.AllowUserToAddRows = False
        Me.dgvReferralFreeformText.AllowUserToDeleteRows = False
        Me.dgvReferralFreeformText.AutoGenerateColumns = False
        Me.dgvReferralFreeformText.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvReferralFreeformText.DataSource = Me.RetrieveBookmarksAndFreeTextBindingSource
        Me.dgvReferralFreeformText.Location = New System.Drawing.Point(10, 145)
        Me.dgvReferralFreeformText.Name = "dgvReferralFreeformText"
        Me.dgvReferralFreeformText.ReadOnly = True
        Me.dgvReferralFreeformText.RowHeadersVisible = False
        Me.dgvReferralFreeformText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReferralFreeformText.Size = New System.Drawing.Size(571, 123)
        Me.dgvReferralFreeformText.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppFreeFormCondid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppFreeFormCondid"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FreeFormid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cond Cde"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FreeFormText"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FreeForm Text"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 440
        '
        'RetrieveBookmarksAndFreeTextBindingSource
        '
        Me.RetrieveBookmarksAndFreeTextBindingSource.DataMember = "RetrieveBookmarksAndFreeText"
        Me.RetrieveBookmarksAndFreeTextBindingSource.DataSource = Me.CCdata
        '
        'btnRemoveFreeForm
        '
        Me.btnRemoveFreeForm.Location = New System.Drawing.Point(525, 274)
        Me.btnRemoveFreeForm.Name = "btnRemoveFreeForm"
        Me.btnRemoveFreeForm.Size = New System.Drawing.Size(60, 23)
        Me.btnRemoveFreeForm.TabIndex = 4
        Me.btnRemoveFreeForm.Text = "Remove"
        Me.btnRemoveFreeForm.UseVisualStyleBackColor = True
        '
        'lblFreeFormID
        '
        Me.lblFreeFormID.AutoSize = True
        Me.lblFreeFormID.Location = New System.Drawing.Point(536, 16)
        Me.lblFreeFormID.Name = "lblFreeFormID"
        Me.lblFreeFormID.Size = New System.Drawing.Size(13, 13)
        Me.lblFreeFormID.TabIndex = 7
        Me.lblFreeFormID.Text = "0"
        '
        'btnAddFreeformText
        '
        Me.btnAddFreeformText.Location = New System.Drawing.Point(391, 116)
        Me.btnAddFreeformText.Name = "btnAddFreeformText"
        Me.btnAddFreeformText.Size = New System.Drawing.Size(180, 23)
        Me.btnAddFreeformText.TabIndex = 6
        Me.btnAddFreeformText.Text = "Add to the list below V"
        Me.btnAddFreeformText.UseVisualStyleBackColor = True
        '
        'LoadReferralDraftConditionsTableAdapter
        '
        Me.LoadReferralDraftConditionsTableAdapter.ClearBeforeFill = True
        '
        'RetrieveBookmarksAndFreeTextTableAdapter
        '
        Me.RetrieveBookmarksAndFreeTextTableAdapter.ClearBeforeFill = True
        '
        'DraftConditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 474)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.grpFreeForm)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlConditions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DraftConditions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Draft Conditions"
        Me.pnlConditions.ResumeLayout(False)
        Me.pnlConditions.PerformLayout()
        CType(Me.LoadReferralDraftConditionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.grpFreeForm.ResumeLayout(False)
        Me.grpFreeForm.PerformLayout()
        CType(Me.dgvReferralFreeformText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrieveBookmarksAndFreeTextBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlConditions As System.Windows.Forms.Panel
    Friend WithEvents cboConditionCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtcondition As System.Windows.Forms.TextBox
    Friend WithEvents btnViewCondition As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveCondition As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstConditions As System.Windows.Forms.ListBox
    Friend WithEvents btnIncludeConditions As System.Windows.Forms.Button
    Friend WithEvents btnAddCondition As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBookMarks As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFreeformtext As System.Windows.Forms.TextBox
    Friend WithEvents grpFreeForm As System.Windows.Forms.GroupBox
    Friend WithEvents CCdata As LookupDevelopmentApplication.CCdata
    Friend WithEvents lblFreeFormID As System.Windows.Forms.Label
    Friend WithEvents btnAddFreeformText As System.Windows.Forms.Button
    Friend WithEvents LoadReferralDraftConditionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadReferralDraftConditionsTableAdapter As LookupDevelopmentApplication.CCdataTableAdapters.LoadReferralDraftConditionsTableAdapter
    Friend WithEvents btnRemoveFreeForm As System.Windows.Forms.Button
    Friend WithEvents RetrieveBookmarksAndFreeTextBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RetrieveBookmarksAndFreeTextTableAdapter As LookupDevelopmentApplication.CCdataTableAdapters.RetrieveBookmarksAndFreeTextTableAdapter
    Friend WithEvents dgvReferralFreeformText As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
