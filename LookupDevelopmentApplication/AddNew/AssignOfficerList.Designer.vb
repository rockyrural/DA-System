<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignOfficerList
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignOfficerList))
        Me.btnAssignOfficer = New DevExpress.XtraEditors.SimpleButton()
        Me.txtreasonAssigned = New DevExpress.XtraEditors.MemoEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbnInternal = New System.Windows.Forms.RadioButton()
        Me.rbnExternal = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdOfficers = New DevExpress.XtraGrid.GridControl()
        Me.gvwOfficers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOfficerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtreasonAssigned.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAssignOfficer
        '
        Me.btnAssignOfficer.Image = CType(resources.GetObject("btnAssignOfficer.Image"), System.Drawing.Image)
        Me.btnAssignOfficer.Location = New System.Drawing.Point(380, 375)
        Me.btnAssignOfficer.Name = "btnAssignOfficer"
        Me.btnAssignOfficer.Size = New System.Drawing.Size(99, 34)
        Me.btnAssignOfficer.TabIndex = 5
        Me.btnAssignOfficer.Text = "&Assign " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Officer"
        '
        'txtreasonAssigned
        '
        Me.txtreasonAssigned.Location = New System.Drawing.Point(12, 374)
        Me.txtreasonAssigned.Name = "txtreasonAssigned"
        Me.txtreasonAssigned.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtreasonAssigned.Size = New System.Drawing.Size(362, 35)
        Me.txtreasonAssigned.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reason Application is being reassigned"
        '
        'rbnInternal
        '
        Me.rbnInternal.AutoSize = True
        Me.rbnInternal.Checked = True
        Me.rbnInternal.Location = New System.Drawing.Point(15, 20)
        Me.rbnInternal.Name = "rbnInternal"
        Me.rbnInternal.Size = New System.Drawing.Size(63, 17)
        Me.rbnInternal.TabIndex = 8
        Me.rbnInternal.TabStop = True
        Me.rbnInternal.Text = "Internal"
        Me.rbnInternal.UseVisualStyleBackColor = True
        '
        'rbnExternal
        '
        Me.rbnExternal.AutoSize = True
        Me.rbnExternal.Location = New System.Drawing.Point(81, 20)
        Me.rbnExternal.Name = "rbnExternal"
        Me.rbnExternal.Size = New System.Drawing.Size(65, 17)
        Me.rbnExternal.TabIndex = 9
        Me.rbnExternal.Text = "External"
        Me.rbnExternal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnExternal)
        Me.GroupBox1.Controls.Add(Me.rbnInternal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 47)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter list for. . "
        '
        'grdOfficers
        '
        Me.grdOfficers.Location = New System.Drawing.Point(12, 54)
        Me.grdOfficers.MainView = Me.gvwOfficers
        Me.grdOfficers.Name = "grdOfficers"
        Me.grdOfficers.Size = New System.Drawing.Size(362, 291)
        Me.grdOfficers.TabIndex = 11
        Me.grdOfficers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOfficers})
        '
        'gvwOfficers
        '
        Me.gvwOfficers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOfficerId, Me.colOfficer})
        Me.gvwOfficers.GridControl = Me.grdOfficers
        Me.gvwOfficers.Name = "gvwOfficers"
        Me.gvwOfficers.OptionsBehavior.Editable = False
        Me.gvwOfficers.OptionsBehavior.ReadOnly = True
        Me.gvwOfficers.OptionsFind.AlwaysVisible = True
        Me.gvwOfficers.OptionsView.ShowGroupPanel = False
        '
        'colOfficerId
        '
        Me.colOfficerId.Caption = "id"
        Me.colOfficerId.FieldName = "OfficerId"
        Me.colOfficerId.Name = "colOfficerId"
        '
        'colOfficer
        '
        Me.colOfficer.Caption = "Officer"
        Me.colOfficer.FieldName = "Officer"
        Me.colOfficer.Name = "colOfficer"
        Me.colOfficer.Visible = True
        Me.colOfficer.VisibleIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(380, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 34)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        '
        'AssignOfficerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(487, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grdOfficers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtreasonAssigned)
        Me.Controls.Add(Me.btnAssignOfficer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssignOfficerList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assign Officer List"
        CType(Me.txtreasonAssigned.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAssignOfficer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtreasonAssigned As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbnInternal As System.Windows.Forms.RadioButton
    Friend WithEvents rbnExternal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdOfficers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOfficers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOfficerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
