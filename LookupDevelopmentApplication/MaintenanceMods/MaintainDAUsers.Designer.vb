<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainDAUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainDAUsers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.DevelopmentAuthority = New LookupDevelopmentApplication.DevelopmentAuthority()
        Me.DAUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAUserTableAdapter = New LookupDevelopmentApplication.DevelopmentAuthorityTableAdapters.DAUserTableAdapter()
        Me.grdDAUsers = New DevExpress.XtraGrid.GridControl()
        Me.gvwDAUsers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMyUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMyUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLanUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DevelopmentAuthority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDAUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwDAUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnChange)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 57)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(593, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 44)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'btnChange
        '
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.Location = New System.Drawing.Point(102, 6)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(84, 44)
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "C&hange"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(12, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 44)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        '
        'DevelopmentAuthority
        '
        Me.DevelopmentAuthority.DataSetName = "DevelopmentAuthority"
        Me.DevelopmentAuthority.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DAUserBindingSource
        '
        Me.DAUserBindingSource.DataMember = "DAUser"
        Me.DAUserBindingSource.DataSource = Me.DevelopmentAuthority
        '
        'DAUserTableAdapter
        '
        Me.DAUserTableAdapter.ClearBeforeFill = True
        '
        'grdDAUsers
        '
        Me.grdDAUsers.DataSource = Me.DAUserBindingSource
        Me.grdDAUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDAUsers.Location = New System.Drawing.Point(0, 0)
        Me.grdDAUsers.MainView = Me.gvwDAUsers
        Me.grdDAUsers.Name = "grdDAUsers"
        Me.grdDAUsers.Size = New System.Drawing.Size(685, 390)
        Me.grdDAUsers.TabIndex = 3
        Me.grdDAUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDAUsers})
        '
        'gvwDAUsers
        '
        Me.gvwDAUsers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMyUserId, Me.colMyUser, Me.colLanUserID, Me.colFullName})
        Me.gvwDAUsers.GridControl = Me.grdDAUsers
        Me.gvwDAUsers.Name = "gvwDAUsers"
        Me.gvwDAUsers.OptionsFind.AlwaysVisible = True
        Me.gvwDAUsers.OptionsView.ShowGroupPanel = False
        '
        'colMyUserId
        '
        Me.colMyUserId.FieldName = "MyUserId"
        Me.colMyUserId.Name = "colMyUserId"
        Me.colMyUserId.Width = 95
        '
        'colMyUser
        '
        Me.colMyUser.FieldName = "MyUser"
        Me.colMyUser.Name = "colMyUser"
        Me.colMyUser.Visible = True
        Me.colMyUser.VisibleIndex = 0
        Me.colMyUser.Width = 123
        '
        'colLanUserID
        '
        Me.colLanUserID.FieldName = "LanUserID"
        Me.colLanUserID.Name = "colLanUserID"
        Me.colLanUserID.Visible = True
        Me.colLanUserID.VisibleIndex = 1
        Me.colLanUserID.Width = 123
        '
        'colFullName
        '
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 2
        Me.colFullName.Width = 329
        '
        'MaintainDAUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdDAUsers)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainDAUsers"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain DA Users"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DevelopmentAuthority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDAUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwDAUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DevelopmentAuthority As LookupDevelopmentApplication.DevelopmentAuthority
    Friend WithEvents DAUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAUserTableAdapter As LookupDevelopmentApplication.DevelopmentAuthorityTableAdapters.DAUserTableAdapter
    Friend WithEvents grdDAUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwDAUsers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMyUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMyUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
End Class
