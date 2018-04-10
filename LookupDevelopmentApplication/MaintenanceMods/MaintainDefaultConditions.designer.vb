<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainDefaultConditions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainDefaultConditions))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.AssessmentData = New LookupDevelopmentApplication.AssessmentData()
        Me.StandardDefaultConditionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StandardDefaultConditionsTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.StandardDefaultConditionsTableAdapter()
        Me.StandardDefaultConditionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvStdCond = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UspLoadUpStandardWordTemplateLetterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UspSELECTStandardConditionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UspLoadUpStandardConditionsCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UspDASETUPLoadUpAssessmentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usp_LoadUpStandardWordTemplateLetterListTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_LoadUpStandardWordTemplateLetterListTableAdapter()
        Me.Usp_DASETUP_LoadUpAssessmentTypesTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_DASETUP_LoadUpAssessmentTypesTableAdapter()
        Me.Usp_LoadUpStandardConditionsCodesTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_LoadUpStandardConditionsCodesTableAdapter()
        Me.Usp_SELECT_StandardConditionTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_SELECT_StandardConditionTableAdapter()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardDefaultConditionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardDefaultConditionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StandardDefaultConditionsBindingNavigator.SuspendLayout()
        CType(Me.dgvStdCond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspLoadUpStandardWordTemplateLetterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspSELECTStandardConditionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspLoadUpStandardConditionsCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspDASETUPLoadUpAssessmentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(98, 627)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 30)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(499, 627)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 627)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 30)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DevelopmentSQLDataSet
        '
        Me.DevelopmentSQLDataSet.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssessmentData
        '
        Me.AssessmentData.DataSetName = "AssessmentData"
        Me.AssessmentData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StandardDefaultConditionsBindingSource
        '
        Me.StandardDefaultConditionsBindingSource.DataMember = "StandardDefaultConditions"
        Me.StandardDefaultConditionsBindingSource.DataSource = Me.AssessmentData
        '
        'StandardDefaultConditionsTableAdapter
        '
        Me.StandardDefaultConditionsTableAdapter.ClearBeforeFill = True
        '
        'StandardDefaultConditionsBindingNavigator
        '
        Me.StandardDefaultConditionsBindingNavigator.AddNewItem = Nothing
        Me.StandardDefaultConditionsBindingNavigator.BindingSource = Me.StandardDefaultConditionsBindingSource
        Me.StandardDefaultConditionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StandardDefaultConditionsBindingNavigator.DeleteItem = Nothing
        Me.StandardDefaultConditionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.StandardDefaultConditionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StandardDefaultConditionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StandardDefaultConditionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StandardDefaultConditionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StandardDefaultConditionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StandardDefaultConditionsBindingNavigator.Name = "StandardDefaultConditionsBindingNavigator"
        Me.StandardDefaultConditionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StandardDefaultConditionsBindingNavigator.Size = New System.Drawing.Size(593, 25)
        Me.StandardDefaultConditionsBindingNavigator.TabIndex = 8
        Me.StandardDefaultConditionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dgvStdCond
        '
        Me.dgvStdCond.AllowUserToDeleteRows = False
        Me.dgvStdCond.AutoGenerateColumns = False
        Me.dgvStdCond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStdCond.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvStdCond.DataSource = Me.StandardDefaultConditionsBindingSource
        Me.dgvStdCond.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvStdCond.Location = New System.Drawing.Point(0, 25)
        Me.dgvStdCond.Name = "dgvStdCond"
        Me.dgvStdCond.ReadOnly = True
        Me.dgvStdCond.Size = New System.Drawing.Size(593, 588)
        Me.dgvStdCond.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idx"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idx"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DocumentTypeID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.UspLoadUpStandardWordTemplateLetterListBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "DisplayMember"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Document Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "valuemember"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'UspLoadUpStandardWordTemplateLetterListBindingSource
        '
        Me.UspLoadUpStandardWordTemplateLetterListBindingSource.DataMember = "usp_LoadUpStandardWordTemplateLetterList"
        Me.UspLoadUpStandardWordTemplateLetterListBindingSource.DataSource = Me.AssessmentDataBindingSource
        '
        'AssessmentDataBindingSource
        '
        Me.AssessmentDataBindingSource.DataSource = Me.AssessmentData
        Me.AssessmentDataBindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StandardConditionID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.UspSELECTStandardConditionBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "DisplayMember"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Standard Condition"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ValueMember"
        '
        'UspSELECTStandardConditionBindingSource
        '
        Me.UspSELECTStandardConditionBindingSource.DataMember = "usp_SELECT_StandardCondition"
        Me.UspSELECTStandardConditionBindingSource.DataSource = Me.AssessmentDataBindingSource
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ConditionID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.UspLoadUpStandardConditionsCodesBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "DisplayMember"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Condition"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "Valuemember"
        Me.DataGridViewTextBoxColumn4.Width = 76
        '
        'UspLoadUpStandardConditionsCodesBindingSource
        '
        Me.UspLoadUpStandardConditionsCodesBindingSource.DataMember = "usp_LoadUpStandardConditionsCodes"
        Me.UspLoadUpStandardConditionsCodesBindingSource.DataSource = Me.AssessmentDataBindingSource
        '
        'UspDASETUPLoadUpAssessmentTypesBindingSource
        '
        Me.UspDASETUPLoadUpAssessmentTypesBindingSource.DataMember = "usp_DASETUP_LoadUpAssessmentTypes"
        Me.UspDASETUPLoadUpAssessmentTypesBindingSource.DataSource = Me.AssessmentDataBindingSource
        '
        'Usp_LoadUpStandardWordTemplateLetterListTableAdapter
        '
        Me.Usp_LoadUpStandardWordTemplateLetterListTableAdapter.ClearBeforeFill = True
        '
        'Usp_DASETUP_LoadUpAssessmentTypesTableAdapter
        '
        Me.Usp_DASETUP_LoadUpAssessmentTypesTableAdapter.ClearBeforeFill = True
        '
        'Usp_LoadUpStandardConditionsCodesTableAdapter
        '
        Me.Usp_LoadUpStandardConditionsCodesTableAdapter.ClearBeforeFill = True
        '
        'Usp_SELECT_StandardConditionTableAdapter
        '
        Me.Usp_SELECT_StandardConditionTableAdapter.ClearBeforeFill = True
        '
        'MaintainDefaultConditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 669)
        Me.Controls.Add(Me.dgvStdCond)
        Me.Controls.Add(Me.StandardDefaultConditionsBindingNavigator)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainDefaultConditions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Default Condition Types"
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardDefaultConditionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardDefaultConditionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StandardDefaultConditionsBindingNavigator.ResumeLayout(False)
        Me.StandardDefaultConditionsBindingNavigator.PerformLayout()
        CType(Me.dgvStdCond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspLoadUpStandardWordTemplateLetterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspSELECTStandardConditionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspLoadUpStandardConditionsCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspDASETUPLoadUpAssessmentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DevelopmentSQLDataSet As LookupDevelopmentApplication.DevelopmentSQLDataSet
    Friend WithEvents AssessmentData As LookupDevelopmentApplication.AssessmentData
    Friend WithEvents StandardDefaultConditionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StandardDefaultConditionsTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.StandardDefaultConditionsTableAdapter
    Friend WithEvents StandardDefaultConditionsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvStdCond As System.Windows.Forms.DataGridView
    Friend WithEvents AssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UspLoadUpStandardWordTemplateLetterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_LoadUpStandardWordTemplateLetterListTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_LoadUpStandardWordTemplateLetterListTableAdapter
    Friend WithEvents UspDASETUPLoadUpAssessmentTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_DASETUP_LoadUpAssessmentTypesTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_DASETUP_LoadUpAssessmentTypesTableAdapter
    Friend WithEvents UspLoadUpStandardConditionsCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_LoadUpStandardConditionsCodesTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_LoadUpStandardConditionsCodesTableAdapter
    Friend WithEvents UspSELECTStandardConditionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_SELECT_StandardConditionTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.usp_SELECT_StandardConditionTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
