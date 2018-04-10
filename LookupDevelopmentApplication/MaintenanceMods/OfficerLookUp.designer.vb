<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficerLookUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficerLookUp))
        Me.grdOfficers = New DevExpress.XtraGrid.GridControl()
        Me.gvwOfficers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnameID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficersName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOfficers
        '
        Me.grdOfficers.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdOfficers.Location = New System.Drawing.Point(0, 0)
        Me.grdOfficers.MainView = Me.gvwOfficers
        Me.grdOfficers.Name = "grdOfficers"
        Me.grdOfficers.Size = New System.Drawing.Size(197, 332)
        Me.grdOfficers.TabIndex = 4
        Me.grdOfficers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOfficers})
        '
        'gvwOfficers
        '
        Me.gvwOfficers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnameID, Me.colOfficersName})
        Me.gvwOfficers.GridControl = Me.grdOfficers
        Me.gvwOfficers.Name = "gvwOfficers"
        Me.gvwOfficers.OptionsBehavior.Editable = False
        Me.gvwOfficers.OptionsBehavior.ReadOnly = True
        Me.gvwOfficers.OptionsFind.AlwaysVisible = True
        Me.gvwOfficers.OptionsFind.ShowClearButton = False
        Me.gvwOfficers.OptionsView.ShowGroupPanel = False
        '
        'colUnameID
        '
        Me.colUnameID.Caption = "id"
        Me.colUnameID.FieldName = "UnameID"
        Me.colUnameID.Name = "colUnameID"
        '
        'colOfficersName
        '
        Me.colOfficersName.Caption = "Officer"
        Me.colOfficersName.FieldName = "OfficersName"
        Me.colOfficersName.Name = "colOfficersName"
        Me.colOfficersName.Visible = True
        Me.colOfficersName.VisibleIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(203, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 35)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        '
        'OfficerLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(302, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grdOfficers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OfficerLookUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Officer"
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdOfficers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOfficers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnameID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficersName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
