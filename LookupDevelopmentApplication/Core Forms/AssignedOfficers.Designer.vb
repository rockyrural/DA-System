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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignedOfficers))
        Me.dgvOfficers = New DevExpress.XtraGrid.GridControl()
        Me.gvwOfficers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOfficer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficerChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.dgvOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOfficers
        '
        Me.dgvOfficers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOfficers.Location = New System.Drawing.Point(0, 0)
        Me.dgvOfficers.MainView = Me.gvwOfficers
        Me.dgvOfficers.Name = "dgvOfficers"
        Me.dgvOfficers.Size = New System.Drawing.Size(781, 253)
        Me.dgvOfficers.TabIndex = 1
        Me.dgvOfficers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOfficers})
        '
        'gvwOfficers
        '
        Me.gvwOfficers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOfficer, Me.colReason, Me.colAllocatedDate, Me.colOfficerChanged})
        Me.gvwOfficers.GridControl = Me.dgvOfficers
        Me.gvwOfficers.Name = "gvwOfficers"
        Me.gvwOfficers.OptionsBehavior.Editable = False
        Me.gvwOfficers.OptionsBehavior.ReadOnly = True
        Me.gvwOfficers.OptionsView.ShowGroupPanel = False
        '
        'colOfficer
        '
        Me.colOfficer.Caption = "Officer"
        Me.colOfficer.FieldName = "Officer"
        Me.colOfficer.Name = "colOfficer"
        Me.colOfficer.Visible = True
        Me.colOfficer.VisibleIndex = 0
        Me.colOfficer.Width = 190
        '
        'colReason
        '
        Me.colReason.Caption = "Reason"
        Me.colReason.FieldName = "Reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 1
        Me.colReason.Width = 284
        '
        'colAllocatedDate
        '
        Me.colAllocatedDate.Caption = "Allocated"
        Me.colAllocatedDate.FieldName = "AllocatedDate"
        Me.colAllocatedDate.Name = "colAllocatedDate"
        Me.colAllocatedDate.Visible = True
        Me.colAllocatedDate.VisibleIndex = 2
        Me.colAllocatedDate.Width = 95
        '
        'colOfficerChanged
        '
        Me.colOfficerChanged.Caption = "Changed By"
        Me.colOfficerChanged.FieldName = "OfficerChanged"
        Me.colOfficerChanged.Name = "colOfficerChanged"
        Me.colOfficerChanged.Visible = True
        Me.colOfficerChanged.VisibleIndex = 3
        Me.colOfficerChanged.Width = 194
        '
        'AssignedOfficers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 253)
        Me.Controls.Add(Me.dgvOfficers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssignedOfficers"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assigned Officers"
        CType(Me.dgvOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOfficers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOfficers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOfficer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficerChanged As DevExpress.XtraGrid.Columns.GridColumn
End Class
