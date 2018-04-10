<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocateOriginalDA
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDAs = New System.Windows.Forms.DataGridView()
        Me.DANo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Applicant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDAs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnFind)
        Me.Panel1.Controls.Add(Me.lblValue)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.cboSearchType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 53)
        Me.Panel1.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(281, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(141, 27)
        Me.btnFind.TabIndex = 17
        Me.btnFind.Text = "Retrieve Properties"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(121, 5)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(104, 13)
        Me.lblValue.TabIndex = 16
        Me.lblValue.Text = "Item to search for. . ."
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(121, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(141, 20)
        Me.txtSearch.TabIndex = 15
        '
        'cboSearchType
        '
        Me.cboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchType.DropDownWidth = 149
        Me.cboSearchType.FormattingEnabled = True
        Me.cboSearchType.Items.AddRange(New Object() {"DA Number", "File No", "PIN", "Address ", "Customer Name"})
        Me.cboSearchType.Location = New System.Drawing.Point(15, 20)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(100, 21)
        Me.cboSearchType.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Search Using:"
        '
        'dgvDAs
        '
        Me.dgvDAs.AllowUserToAddRows = False
        Me.dgvDAs.AllowUserToDeleteRows = False
        Me.dgvDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDAs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DANo, Me.Applicant, Me.Address})
        Me.dgvDAs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDAs.Location = New System.Drawing.Point(0, 53)
        Me.dgvDAs.Name = "dgvDAs"
        Me.dgvDAs.ReadOnly = True
        Me.dgvDAs.RowHeadersWidth = 22
        Me.dgvDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDAs.Size = New System.Drawing.Size(756, 307)
        Me.dgvDAs.TabIndex = 1
        '
        'DANo
        '
        Me.DANo.DataPropertyName = "DANo"
        Me.DANo.HeaderText = "DA No"
        Me.DANo.Name = "DANo"
        Me.DANo.ReadOnly = True
        Me.DANo.Width = 80
        '
        'Applicant
        '
        Me.Applicant.DataPropertyName = "DAAppName"
        Me.Applicant.HeaderText = "Applicant"
        Me.Applicant.Name = "Applicant"
        Me.Applicant.ReadOnly = True
        Me.Applicant.Width = 260
        '
        'Address
        '
        Me.Address.DataPropertyName = "ADDRESS"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 370
        '
        'LocateOriginalDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 360)
        Me.Controls.Add(Me.dgvDAs)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LocateOriginalDA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Locate Original DA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDAs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboSearchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDAs As System.Windows.Forms.DataGridView
    Friend WithEvents DANo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Applicant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
