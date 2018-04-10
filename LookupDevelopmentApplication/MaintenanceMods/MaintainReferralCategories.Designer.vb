<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainReferralCategories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainReferralCategories))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvReferralCategories = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UspLoadUpListOfReferralCodeCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReferralCategories = New LookupDevelopmentApplication.ReferralCategories()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Usp_ReferralCode_SELECTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Usp_ReferralCode_SELECTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Usp_ReferralCode_SELECTTableAdapter = New LookupDevelopmentApplication.ReferralCategoriesTableAdapters.usp_ReferralCode_SELECTTableAdapter()
        Me.Usp_LoadUpListOfReferralCodeCategoriesTableAdapter = New LookupDevelopmentApplication.ReferralCategoriesTableAdapters.usp_LoadUpListOfReferralCodeCategoriesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReferralCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspLoadUpListOfReferralCodeCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferralCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usp_ReferralCode_SELECTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usp_ReferralCode_SELECTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Usp_ReferralCode_SELECTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 549)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 58)
        Me.Panel1.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(198, 18)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(306, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(86, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvReferralCategories
        '
        Me.dgvReferralCategories.AutoGenerateColumns = False
        Me.dgvReferralCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.dgvReferralCategories.DataSource = Me.Usp_ReferralCode_SELECTBindingSource
        Me.dgvReferralCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReferralCategories.Location = New System.Drawing.Point(0, 25)
        Me.dgvReferralCategories.Name = "dgvReferralCategories"
        Me.dgvReferralCategories.ReadOnly = True
        Me.dgvReferralCategories.RowHeadersWidth = 22
        Me.dgvReferralCategories.Size = New System.Drawing.Size(466, 524)
        Me.dgvReferralCategories.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ReferralCodeId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ReferralCode"
        Me.DataGridViewTextBoxColumn2.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Referral Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ReferralCodeCategory"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.UspLoadUpListOfReferralCodeCategoriesBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ReferralCodeCategoryDesc"
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Referral Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        '
        'UspLoadUpListOfReferralCodeCategoriesBindingSource
        '
        Me.UspLoadUpListOfReferralCodeCategoriesBindingSource.DataMember = "usp_LoadUpListOfReferralCodeCategories"
        Me.UspLoadUpListOfReferralCodeCategoriesBindingSource.DataSource = Me.ReferralCategories
        '
        'ReferralCategories
        '
        Me.ReferralCategories.DataSetName = "ReferralCategories"
        Me.ReferralCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 43
        '
        'Usp_ReferralCode_SELECTBindingSource
        '
        Me.Usp_ReferralCode_SELECTBindingSource.DataMember = "usp_ReferralCode_SELECT"
        Me.Usp_ReferralCode_SELECTBindingSource.DataSource = Me.ReferralCategories
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Usp_ReferralCode_SELECTBindingNavigator
        '
        Me.Usp_ReferralCode_SELECTBindingNavigator.AddNewItem = Nothing
        Me.Usp_ReferralCode_SELECTBindingNavigator.BindingSource = Me.Usp_ReferralCode_SELECTBindingSource
        Me.Usp_ReferralCode_SELECTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.DeleteItem = Nothing
        Me.Usp_ReferralCode_SELECTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Usp_ReferralCode_SELECTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Usp_ReferralCode_SELECTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.Name = "Usp_ReferralCode_SELECTBindingNavigator"
        Me.Usp_ReferralCode_SELECTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Usp_ReferralCode_SELECTBindingNavigator.Size = New System.Drawing.Size(466, 25)
        Me.Usp_ReferralCode_SELECTBindingNavigator.TabIndex = 1
        Me.Usp_ReferralCode_SELECTBindingNavigator.Text = "BindingNavigator1"
        '
        'Usp_ReferralCode_SELECTTableAdapter
        '
        Me.Usp_ReferralCode_SELECTTableAdapter.ClearBeforeFill = True
        '
        'Usp_LoadUpListOfReferralCodeCategoriesTableAdapter
        '
        Me.Usp_LoadUpListOfReferralCodeCategoriesTableAdapter.ClearBeforeFill = True
        '
        'MaintainReferralCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 607)
        Me.Controls.Add(Me.dgvReferralCategories)
        Me.Controls.Add(Me.Usp_ReferralCode_SELECTBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MaintainReferralCategories"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Referral Categories"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvReferralCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspLoadUpListOfReferralCodeCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferralCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usp_ReferralCode_SELECTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usp_ReferralCode_SELECTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Usp_ReferralCode_SELECTBindingNavigator.ResumeLayout(False)
        Me.Usp_ReferralCode_SELECTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReferralCategories As LookupDevelopmentApplication.ReferralCategories
    Friend WithEvents Usp_ReferralCode_SELECTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_ReferralCode_SELECTTableAdapter As LookupDevelopmentApplication.ReferralCategoriesTableAdapters.usp_ReferralCode_SELECTTableAdapter
    Friend WithEvents dgvReferralCategories As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Usp_ReferralCode_SELECTBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents UspLoadUpListOfReferralCodeCategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usp_LoadUpListOfReferralCodeCategoriesTableAdapter As LookupDevelopmentApplication.ReferralCategoriesTableAdapters.usp_LoadUpListOfReferralCodeCategoriesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
