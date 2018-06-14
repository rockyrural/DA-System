<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCCBuildingSolutionsList
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NCCBuildingSolutionsList))
        Me.grpNCCBuildingSolutionCodes = New DevExpress.XtraEditors.GroupControl()
        Me.grdNCCcodes = New DevExpress.XtraGrid.GridControl()
        Me.gvwNCCcodes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grpNCCBuildingSolutionCodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpNCCBuildingSolutionCodes.SuspendLayout
        CType(Me.grdNCCcodes,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwNCCcodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'grpNCCBuildingSolutionCodes
        '
        Me.grpNCCBuildingSolutionCodes.CaptionImageOptions.Image = CType(resources.GetObject("grpNCCBuildingSolutionCodes.CaptionImageOptions.Image"),System.Drawing.Image)
        Me.grpNCCBuildingSolutionCodes.Controls.Add(Me.btnOk)
        Me.grpNCCBuildingSolutionCodes.Controls.Add(Me.btnCancel)
        Me.grpNCCBuildingSolutionCodes.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpNCCBuildingSolutionCodes.Location = New System.Drawing.Point(0, 0)
        Me.grpNCCBuildingSolutionCodes.Name = "grpNCCBuildingSolutionCodes"
        Me.grpNCCBuildingSolutionCodes.Size = New System.Drawing.Size(387, 62)
        Me.grpNCCBuildingSolutionCodes.TabIndex = 2
        Me.grpNCCBuildingSolutionCodes.Text = "N.C.C. Building Solution Codes"
        '
        'grdNCCcodes
        '
        Me.grdNCCcodes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNCCcodes.Location = New System.Drawing.Point(0, 62)
        Me.grdNCCcodes.MainView = Me.gvwNCCcodes
        Me.grdNCCcodes.Name = "grdNCCcodes"
        Me.grdNCCcodes.Size = New System.Drawing.Size(387, 354)
        Me.grdNCCcodes.TabIndex = 3
        Me.grdNCCcodes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwNCCcodes})
        '
        'gvwNCCcodes
        '
        Me.gvwNCCcodes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gvwNCCcodes.GridControl = Me.grdNCCcodes
        Me.gvwNCCcodes.Name = "gvwNCCcodes"
        Me.gvwNCCcodes.OptionsBehavior.Editable = false
        Me.gvwNCCcodes.OptionsBehavior.ReadOnly = true
        Me.gvwNCCcodes.OptionsSelection.MultiSelect = true
        Me.gvwNCCcodes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvwNCCcodes.OptionsView.ShowGroupPanel = false
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(303, 26)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"),System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(5, 26)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(77, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "CodeIdx"
        Me.GridColumn1.FieldName = "CodeIdx"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Code"
        Me.GridColumn2.FieldName = "Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = true
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Vol."
        Me.GridColumn3.FieldName = "Volume"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = true
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 38
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Description"
        Me.GridColumn4.FieldName = "Description"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = true
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 200
        '
        'NCCBuildingSolutionsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(387, 416)
        Me.ControlBox = false
        Me.Controls.Add(Me.grdNCCcodes)
        Me.Controls.Add(Me.grpNCCBuildingSolutionCodes)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NCCBuildingSolutionsList"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.grpNCCBuildingSolutionCodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpNCCBuildingSolutionCodes.ResumeLayout(false)
        CType(Me.grdNCCcodes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwNCCcodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents grpNCCBuildingSolutionCodes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdNCCcodes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwNCCcodes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
