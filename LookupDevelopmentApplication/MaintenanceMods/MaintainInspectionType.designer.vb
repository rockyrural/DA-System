<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainInspectionType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainInspectionType))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.CoTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoTypeTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.CoTypeTableAdapter()
        Me.CoTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvCoType = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CCAppTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentData = New LookupDevelopmentApplication.AssessmentData()
        Me.ComplianceDataSet = New LookupDevelopmentApplication.ComplianceDataSet()
        Me.CCAppTypeTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.CCAppTypeTableAdapter()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoTypeBindingNavigator.SuspendLayout()
        CType(Me.dgvCoType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCAppTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplianceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(101, 619)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 30)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(390, 619)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 619)
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
        'CoTypeBindingSource
        '
        Me.CoTypeBindingSource.DataMember = "CoType"
        Me.CoTypeBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'CoTypeTableAdapter
        '
        Me.CoTypeTableAdapter.ClearBeforeFill = True
        '
        'CoTypeBindingNavigator
        '
        Me.CoTypeBindingNavigator.AddNewItem = Nothing
        Me.CoTypeBindingNavigator.BindingSource = Me.CoTypeBindingSource
        Me.CoTypeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CoTypeBindingNavigator.DeleteItem = Nothing
        Me.CoTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CoTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CoTypeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CoTypeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CoTypeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CoTypeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CoTypeBindingNavigator.Name = "CoTypeBindingNavigator"
        Me.CoTypeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CoTypeBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.CoTypeBindingNavigator.TabIndex = 8
        Me.CoTypeBindingNavigator.Text = "BindingNavigator1"
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
        'dgvCoType
        '
        Me.dgvCoType.AllowUserToDeleteRows = False
        Me.dgvCoType.AutoGenerateColumns = False
        Me.dgvCoType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCoType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvCoType.DataSource = Me.CoTypeBindingSource
        Me.dgvCoType.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvCoType.Location = New System.Drawing.Point(0, 25)
        Me.dgvCoType.Name = "dgvCoType"
        Me.dgvCoType.Size = New System.Drawing.Size(484, 588)
        Me.dgvCoType.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CoTypeId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CoTypeId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CoType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CoType"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "sysref"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.CCAppTypeBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "CCAppType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "sysref"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "CCAppTypeId"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'CCAppTypeBindingSource
        '
        Me.CCAppTypeBindingSource.DataMember = "CCAppType"
        Me.CCAppTypeBindingSource.DataSource = Me.AssessmentData
        '
        'AssessmentData
        '
        Me.AssessmentData.DataSetName = "AssessmentData"
        Me.AssessmentData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComplianceDataSet
        '
        Me.ComplianceDataSet.DataSetName = "ComplianceDataSet"
        Me.ComplianceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCAppTypeTableAdapter
        '
        Me.CCAppTypeTableAdapter.ClearBeforeFill = True
        '
        'MaintainInspectionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.dgvCoType)
        Me.Controls.Add(Me.CoTypeBindingNavigator)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainInspectionType"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Inspection Type"
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoTypeBindingNavigator.ResumeLayout(False)
        Me.CoTypeBindingNavigator.PerformLayout()
        CType(Me.dgvCoType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCAppTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplianceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DevelopmentSQLDataSet As LookupDevelopmentApplication.DevelopmentSQLDataSet
    Friend WithEvents CoTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoTypeTableAdapter As LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.CoTypeTableAdapter
    Friend WithEvents CoTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvCoType As System.Windows.Forms.DataGridView
    Friend WithEvents ComplianceDataSet As LookupDevelopmentApplication.ComplianceDataSet
    Friend WithEvents AssessmentData As LookupDevelopmentApplication.AssessmentData
    Friend WithEvents CCAppTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CCAppTypeTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.CCAppTypeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
