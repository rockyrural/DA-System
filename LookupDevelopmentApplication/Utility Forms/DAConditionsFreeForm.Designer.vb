<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAConditionsFreeForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtFreefromText = New System.Windows.Forms.TextBox()
        Me.cboConditions = New System.Windows.Forms.ComboBox()
        Me.FreeFormConditionCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvConditions = New System.Windows.Forms.DataGridView()
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreeFormTextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppFreeFormCondid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadFreeFormGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreeFormConditionCodesTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.FreeFormConditionCodesTableAdapter()
        Me.LoadFreeFormGridTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.LoadFreeFormGridTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.FreeFormConditionCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadFreeFormGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFreefromText
        '
        Me.txtFreefromText.Location = New System.Drawing.Point(12, 78)
        Me.txtFreefromText.Multiline = True
        Me.txtFreefromText.Name = "txtFreefromText"
        Me.txtFreefromText.Size = New System.Drawing.Size(406, 104)
        Me.txtFreefromText.TabIndex = 0
        '
        'cboConditions
        '
        Me.cboConditions.DataSource = Me.FreeFormConditionCodesBindingSource
        Me.cboConditions.DisplayMember = "Description"
        Me.cboConditions.FormattingEnabled = True
        Me.cboConditions.Location = New System.Drawing.Point(12, 25)
        Me.cboConditions.Name = "cboConditions"
        Me.cboConditions.Size = New System.Drawing.Size(406, 21)
        Me.cboConditions.TabIndex = 1
        Me.cboConditions.ValueMember = "id"
        '
        'FreeFormConditionCodesBindingSource
        '
        Me.FreeFormConditionCodesBindingSource.DataMember = "FreeFormConditionCodes"
        Me.FreeFormConditionCodesBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select a condition type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter the condition:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvConditions)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 277)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'dgvConditions
        '
        Me.dgvConditions.AllowUserToAddRows = False
        Me.dgvConditions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvConditions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConditions.AutoGenerateColumns = False
        Me.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn, Me.ConditionDescDataGridViewTextBoxColumn, Me.FreeFormTextDataGridViewTextBoxColumn, Me.AppFreeFormCondid, Me.id})
        Me.dgvConditions.DataSource = Me.LoadFreeFormGridBindingSource
        Me.dgvConditions.Location = New System.Drawing.Point(6, 19)
        Me.dgvConditions.Name = "dgvConditions"
        Me.dgvConditions.ReadOnly = True
        Me.dgvConditions.RowHeadersVisible = False
        Me.dgvConditions.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgvConditions.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConditions.RowTemplate.Height = 50
        Me.dgvConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConditions.Size = New System.Drawing.Size(576, 239)
        Me.dgvConditions.TabIndex = 0
        '
        'ConditionCodeFreeFormIDDataGridViewTextBoxColumn
        '
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.DataPropertyName = "ConditionCodeFreeFormID"
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.HeaderText = "ConditionCodeFreeFormID"
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.Name = "ConditionCodeFreeFormIDDataGridViewTextBoxColumn"
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.Visible = False
        Me.ConditionCodeFreeFormIDDataGridViewTextBoxColumn.Width = 2
        '
        'ConditionDescDataGridViewTextBoxColumn
        '
        Me.ConditionDescDataGridViewTextBoxColumn.DataPropertyName = "ConditionDesc"
        Me.ConditionDescDataGridViewTextBoxColumn.HeaderText = "Book Mark"
        Me.ConditionDescDataGridViewTextBoxColumn.Name = "ConditionDescDataGridViewTextBoxColumn"
        Me.ConditionDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConditionDescDataGridViewTextBoxColumn.Width = 150
        '
        'FreeFormTextDataGridViewTextBoxColumn
        '
        Me.FreeFormTextDataGridViewTextBoxColumn.DataPropertyName = "FreeFormText"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FreeFormTextDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FreeFormTextDataGridViewTextBoxColumn.HeaderText = "Value to be inserted"
        Me.FreeFormTextDataGridViewTextBoxColumn.Name = "FreeFormTextDataGridViewTextBoxColumn"
        Me.FreeFormTextDataGridViewTextBoxColumn.ReadOnly = True
        Me.FreeFormTextDataGridViewTextBoxColumn.Width = 400
        '
        'AppFreeFormCondid
        '
        Me.AppFreeFormCondid.DataPropertyName = "AppFreeFormCondid"
        Me.AppFreeFormCondid.HeaderText = "AppFreeFormCondid"
        Me.AppFreeFormCondid.MinimumWidth = 2
        Me.AppFreeFormCondid.Name = "AppFreeFormCondid"
        Me.AppFreeFormCondid.ReadOnly = True
        Me.AppFreeFormCondid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AppFreeFormCondid.Visible = False
        Me.AppFreeFormCondid.Width = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 2
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id.Visible = False
        Me.id.Width = 2
        '
        'LoadFreeFormGridBindingSource
        '
        Me.LoadFreeFormGridBindingSource.DataMember = "LoadFreeFormGrid"
        Me.LoadFreeFormGridBindingSource.DataSource = Me.DAdatasets
        '
        'FreeFormConditionCodesTableAdapter
        '
        Me.FreeFormConditionCodesTableAdapter.ClearBeforeFill = True
        '
        'LoadFreeFormGridTableAdapter
        '
        Me.LoadFreeFormGridTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(424, 78)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Text"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(424, 159)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(608, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "0"
        '
        'DAConditionsFreeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 498)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboConditions)
        Me.Controls.Add(Me.txtFreefromText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DAConditionsFreeForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DA Conditions FreeForm"
        CType(Me.FreeFormConditionCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadFreeFormGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFreefromText As System.Windows.Forms.TextBox
    Friend WithEvents cboConditions As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvConditions As System.Windows.Forms.DataGridView
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents FreeFormConditionCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FreeFormConditionCodesTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.FreeFormConditionCodesTableAdapter
    Friend WithEvents LoadFreeFormGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadFreeFormGridTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.LoadFreeFormGridTableAdapter
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents ConditionCodeFreeFormIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConditionDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeFormTextDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppFreeFormCondid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
