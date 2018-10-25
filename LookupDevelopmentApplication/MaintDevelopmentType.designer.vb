<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintDevelopmentType
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintDevelopmentType))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet
        Me.DevTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.DevTypeTableAdapter
        Me.DevTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LoadUpBusinessPaperCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadUpBusinessPaperCategoryTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.LoadUpBusinessPaperCategoryTableAdapter
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DevTypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DevTypeBindingNavigator.SuspendLayout()
        CType(Me.LoadUpBusinessPaperCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DevTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DevelopmentSQLDataSet
        '
        Me.DevelopmentSQLDataSet.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevTypeBindingSource
        '
        Me.DevTypeBindingSource.DataMember = "DevType"
        Me.DevTypeBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'DevTypeTableAdapter
        '
        Me.DevTypeTableAdapter.ClearBeforeFill = True
        '
        'DevTypeBindingNavigator
        '
        Me.DevTypeBindingNavigator.AddNewItem = Nothing
        Me.DevTypeBindingNavigator.BindingSource = Me.DevTypeBindingSource
        Me.DevTypeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DevTypeBindingNavigator.DeleteItem = Nothing
        Me.DevTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.DevTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DevTypeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DevTypeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DevTypeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DevTypeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DevTypeBindingNavigator.Name = "DevTypeBindingNavigator"
        Me.DevTypeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DevTypeBindingNavigator.Size = New System.Drawing.Size(346, 25)
        Me.DevTypeBindingNavigator.TabIndex = 0
        Me.DevTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'LoadUpBusinessPaperCategoryBindingSource
        '
        Me.LoadUpBusinessPaperCategoryBindingSource.DataMember = "LoadUpBusinessPaperCategory"
        Me.LoadUpBusinessPaperCategoryBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'LoadUpBusinessPaperCategoryTableAdapter
        '
        Me.LoadUpBusinessPaperCategoryTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(134, 371)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(242, 371)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 371)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DevTypeDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 340)
        Me.Panel1.TabIndex = 8
        '
        'DevTypeDataGridView
        '
        Me.DevTypeDataGridView.AllowUserToDeleteRows = False
        Me.DevTypeDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DevTypeDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DevTypeDataGridView.AutoGenerateColumns = False
        Me.DevTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DevTypeDataGridView.DataSource = Me.DevTypeBindingSource
        Me.DevTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DevTypeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DevTypeDataGridView.MultiSelect = False
        Me.DevTypeDataGridView.Name = "DevTypeDataGridView"
        Me.DevTypeDataGridView.ReadOnly = True
        Me.DevTypeDataGridView.RowHeadersWidth = 22
        Me.DevTypeDataGridView.Size = New System.Drawing.Size(346, 340)
        Me.DevTypeDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DevTypeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DevTypeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DevType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Development Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Enter the development type"
        Me.DataGridViewTextBoxColumn2.Width = 190
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BusPaperCategory"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.LoadUpBusinessPaperCategoryBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "BPCategoryDesc"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "BusPaperCategory"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "BPCode"
        Me.DataGridViewTextBoxColumn3.Width = 115
        '
        'MaintDevelopmentType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DevTypeBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintDevelopmentType"
        Me.Text = "Maintain Development Type"
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DevTypeBindingNavigator.ResumeLayout(False)
        Me.DevTypeBindingNavigator.PerformLayout()
        CType(Me.LoadUpBusinessPaperCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DevTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DevelopmentSQLDataSet As DevelopmentSQLDataSet
    Friend WithEvents DevTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevTypeTableAdapter As DevelopmentSQLDataSetTableAdapters.DevTypeTableAdapter
    Friend WithEvents DevTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoadUpBusinessPaperCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadUpBusinessPaperCategoryTableAdapter As LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.LoadUpBusinessPaperCategoryTableAdapter
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DevTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
