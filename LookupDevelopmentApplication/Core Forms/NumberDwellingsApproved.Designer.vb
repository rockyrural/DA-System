<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberDwellingsApproved
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
        Me.dgvApproval = New System.Windows.Forms.DataGridView()
        Me.colDwellingsAppd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvApproval
        '
        Me.dgvApproval.AllowUserToAddRows = False
        Me.dgvApproval.AllowUserToDeleteRows = False
        Me.dgvApproval.AllowUserToOrderColumns = True
        Me.dgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApproval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDwellingsAppd, Me.colMonth, Me.colYear})
        Me.dgvApproval.Location = New System.Drawing.Point(8, 9)
        Me.dgvApproval.Name = "dgvApproval"
        Me.dgvApproval.ReadOnly = True
        Me.dgvApproval.RowHeadersVisible = False
        Me.dgvApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvApproval.Size = New System.Drawing.Size(448, 788)
        Me.dgvApproval.TabIndex = 0
        '
        'colDwellingsAppd
        '
        Me.colDwellingsAppd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDwellingsAppd.DataPropertyName = "Dwellings Approved"
        Me.colDwellingsAppd.FillWeight = 34.0!
        Me.colDwellingsAppd.HeaderText = "No."
        Me.colDwellingsAppd.Name = "colDwellingsAppd"
        Me.colDwellingsAppd.ReadOnly = True
        '
        'colMonth
        '
        Me.colMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMonth.DataPropertyName = "Month Approved"
        Me.colMonth.FillWeight = 33.0!
        Me.colMonth.HeaderText = "Month"
        Me.colMonth.Name = "colMonth"
        Me.colMonth.ReadOnly = True
        '
        'colYear
        '
        Me.colYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colYear.DataPropertyName = "Year Approved"
        Me.colYear.FillWeight = 33.0!
        Me.colYear.HeaderText = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.ReadOnly = True
        '
        'NumberDwellingsApproved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 805)
        Me.Controls.Add(Me.dgvApproval)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NumberDwellingsApproved"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Number Dwellings Approved"
        CType(Me.dgvApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvApproval As System.Windows.Forms.DataGridView
    Friend WithEvents colDwellingsAppd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYear As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
