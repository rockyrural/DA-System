<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainDCPGuidelines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainDCPGuidelines))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ReferralCategories = New LookupDevelopmentApplication.ReferralCategories()
        Me.Usp_ReferralCode_SELECTBindingSource = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvDCPGuideLinesCodes = New System.Windows.Forms.DataGridView()
        Me.GuideCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuideLineDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuidelineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuidelineCodeTableAdapter = New LookupDevelopmentApplication.ReferralCategoriesTableAdapters.GuidelineCodeTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.ReferralCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usp_ReferralCode_SELECTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Usp_ReferralCode_SELECTBindingSource.SuspendLayout()
        CType(Me.dgvDCPGuideLinesCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuidelineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReferralCategories
        '
        Me.ReferralCategories.DataSetName = "ReferralCategories"
        Me.ReferralCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_ReferralCode_SELECTBindingSource
        '
        Me.Usp_ReferralCode_SELECTBindingSource.AddNewItem = Nothing
        Me.Usp_ReferralCode_SELECTBindingSource.CountItem = Me.BindingNavigatorCountItem
        Me.Usp_ReferralCode_SELECTBindingSource.DeleteItem = Nothing
        Me.Usp_ReferralCode_SELECTBindingSource.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Usp_ReferralCode_SELECTBindingSource.Location = New System.Drawing.Point(0, 0)
        Me.Usp_ReferralCode_SELECTBindingSource.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Usp_ReferralCode_SELECTBindingSource.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Usp_ReferralCode_SELECTBindingSource.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Usp_ReferralCode_SELECTBindingSource.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Usp_ReferralCode_SELECTBindingSource.Name = "Usp_ReferralCode_SELECTBindingSource"
        Me.Usp_ReferralCode_SELECTBindingSource.PositionItem = Me.BindingNavigatorPositionItem
        Me.Usp_ReferralCode_SELECTBindingSource.Size = New System.Drawing.Size(466, 25)
        Me.Usp_ReferralCode_SELECTBindingSource.TabIndex = 3
        Me.Usp_ReferralCode_SELECTBindingSource.Text = "BindingNavigator1"
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
        'dgvDCPGuideLinesCodes
        '
        Me.dgvDCPGuideLinesCodes.AllowUserToAddRows = False
        Me.dgvDCPGuideLinesCodes.AllowUserToDeleteRows = False
        Me.dgvDCPGuideLinesCodes.AutoGenerateColumns = False
        Me.dgvDCPGuideLinesCodes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuideCodeDataGridViewTextBoxColumn, Me.GuideLineDescDataGridViewTextBoxColumn})
        Me.dgvDCPGuideLinesCodes.DataSource = Me.GuidelineCodeBindingSource
        Me.dgvDCPGuideLinesCodes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDCPGuideLinesCodes.Location = New System.Drawing.Point(0, 25)
        Me.dgvDCPGuideLinesCodes.Name = "dgvDCPGuideLinesCodes"
        Me.dgvDCPGuideLinesCodes.ReadOnly = True
        Me.dgvDCPGuideLinesCodes.RowHeadersWidth = 22
        Me.dgvDCPGuideLinesCodes.Size = New System.Drawing.Size(466, 524)
        Me.dgvDCPGuideLinesCodes.TabIndex = 4
        '
        'GuideCodeDataGridViewTextBoxColumn
        '
        Me.GuideCodeDataGridViewTextBoxColumn.DataPropertyName = "GuideCode"
        Me.GuideCodeDataGridViewTextBoxColumn.HeaderText = "id"
        Me.GuideCodeDataGridViewTextBoxColumn.Name = "GuideCodeDataGridViewTextBoxColumn"
        Me.GuideCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuideCodeDataGridViewTextBoxColumn.Width = 40
        '
        'GuideLineDescDataGridViewTextBoxColumn
        '
        Me.GuideLineDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GuideLineDescDataGridViewTextBoxColumn.DataPropertyName = "GuideLineDesc"
        Me.GuideLineDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.GuideLineDescDataGridViewTextBoxColumn.Name = "GuideLineDescDataGridViewTextBoxColumn"
        Me.GuideLineDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GuidelineCodeBindingSource
        '
        Me.GuidelineCodeBindingSource.DataMember = "GuidelineCode"
        Me.GuidelineCodeBindingSource.DataSource = Me.ReferralCategories
        '
        'GuidelineCodeTableAdapter
        '
        Me.GuidelineCodeTableAdapter.ClearBeforeFill = True
        '
        'MaintainDCPGuidelines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 607)
        Me.Controls.Add(Me.dgvDCPGuideLinesCodes)
        Me.Controls.Add(Me.Usp_ReferralCode_SELECTBindingSource)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainDCPGuidelines"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain DCP Guidelines"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ReferralCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usp_ReferralCode_SELECTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Usp_ReferralCode_SELECTBindingSource.ResumeLayout(False)
        Me.Usp_ReferralCode_SELECTBindingSource.PerformLayout()
        CType(Me.dgvDCPGuideLinesCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuidelineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ReferralCategories As LookupDevelopmentApplication.ReferralCategories
    Friend WithEvents Usp_ReferralCode_SELECTBindingSource As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvDCPGuideLinesCodes As System.Windows.Forms.DataGridView
    Friend WithEvents GuidelineCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuidelineCodeTableAdapter As LookupDevelopmentApplication.ReferralCategoriesTableAdapters.GuidelineCodeTableAdapter
    Friend WithEvents GuideCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuideLineDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
