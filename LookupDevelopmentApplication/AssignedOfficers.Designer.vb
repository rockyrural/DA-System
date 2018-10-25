<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignedOfficers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignedOfficers))
        Me.dgvOfficers = New System.Windows.Forms.DataGridView()
        Me.Officer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allocated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOfficers
        '
        Me.dgvOfficers.AllowUserToAddRows = False
        Me.dgvOfficers.AllowUserToDeleteRows = False
        Me.dgvOfficers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOfficers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Officer, Me.reason, Me.Allocated, Me.Changed})
        Me.dgvOfficers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOfficers.Location = New System.Drawing.Point(0, 0)
        Me.dgvOfficers.Name = "dgvOfficers"
        Me.dgvOfficers.ReadOnly = True
        Me.dgvOfficers.RowHeadersVisible = False
        Me.dgvOfficers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOfficers.Size = New System.Drawing.Size(781, 242)
        Me.dgvOfficers.TabIndex = 0
        '
        'Officer
        '
        Me.Officer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Officer.DataPropertyName = "Officer"
        Me.Officer.FillWeight = 30.0!
        Me.Officer.HeaderText = "Officer"
        Me.Officer.Name = "Officer"
        Me.Officer.ReadOnly = True
        '
        'reason
        '
        Me.reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.reason.DataPropertyName = "Reason"
        Me.reason.FillWeight = 40.0!
        Me.reason.HeaderText = "Reason"
        Me.reason.Name = "reason"
        Me.reason.ReadOnly = True
        '
        'Allocated
        '
        Me.Allocated.DataPropertyName = "AllocatedDate"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.Allocated.DefaultCellStyle = DataGridViewCellStyle1
        Me.Allocated.HeaderText = "Allocated"
        Me.Allocated.Name = "Allocated"
        Me.Allocated.ReadOnly = True
        Me.Allocated.Width = 75
        '
        'Changed
        '
        Me.Changed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Changed.DataPropertyName = "OfficerChanged"
        Me.Changed.FillWeight = 30.0!
        Me.Changed.HeaderText = "Changed By"
        Me.Changed.Name = "Changed"
        Me.Changed.ReadOnly = True
        '
        'AssignedOfficers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 242)
        Me.Controls.Add(Me.dgvOfficers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssignedOfficers"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assigned Officers"
        CType(Me.dgvOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvOfficers As System.Windows.Forms.DataGridView
    Friend WithEvents Officer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Allocated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Changed As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
