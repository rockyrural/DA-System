<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAdjacentPropertiesForMailMerge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAdjacentPropertiesForMailMerge))
        Me.chkStrataProperties = New DevExpress.XtraEditors.CheckEdit()
        Me.bedtMergeFile = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblSelectMailMergeData = New DevExpress.XtraEditors.LabelControl()
        Me.btnRun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.grdAdjacentProperties = New DevExpress.XtraGrid.GridControl()
        Me.gvwProperties = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.chkStrataProperties.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bedtMergeFile.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grdAdjacentProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwProperties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'chkStrataProperties
        '
        Me.chkStrataProperties.Location = New System.Drawing.Point(170, 5)
        Me.chkStrataProperties.Name = "chkStrataProperties"
        Me.chkStrataProperties.Properties.Caption = "Strata / Units"
        Me.chkStrataProperties.Size = New System.Drawing.Size(116, 19)
        Me.chkStrataProperties.TabIndex = 0
        '
        'bedtMergeFile
        '
        Me.bedtMergeFile.EditValue = ""
        Me.bedtMergeFile.Location = New System.Drawing.Point(12, 28)
        Me.bedtMergeFile.Name = "bedtMergeFile"
        Me.bedtMergeFile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bedtMergeFile.Properties.ReadOnly = true
        Me.bedtMergeFile.Size = New System.Drawing.Size(371, 20)
        Me.bedtMergeFile.TabIndex = 1
        '
        'lblSelectMailMergeData
        '
        Me.lblSelectMailMergeData.Location = New System.Drawing.Point(12, 8)
        Me.lblSelectMailMergeData.Name = "lblSelectMailMergeData"
        Me.lblSelectMailMergeData.Size = New System.Drawing.Size(109, 13)
        Me.lblSelectMailMergeData.TabIndex = 2
        Me.lblSelectMailMergeData.Text = "Select Mail Merge Data"
        '
        'btnRun
        '
        Me.btnRun.Enabled = false
        Me.btnRun.ImageOptions.Image = CType(resources.GetObject("btnRun.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRun.Location = New System.Drawing.Point(283, 54)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(100, 36)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "Run"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(437, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'grdAdjacentProperties
        '
        Me.grdAdjacentProperties.Location = New System.Drawing.Point(12, 103)
        Me.grdAdjacentProperties.MainView = Me.gvwProperties
        Me.grdAdjacentProperties.Name = "grdAdjacentProperties"
        Me.grdAdjacentProperties.Size = New System.Drawing.Size(525, 244)
        Me.grdAdjacentProperties.TabIndex = 5
        Me.grdAdjacentProperties.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwProperties})
        '
        'gvwProperties
        '
        Me.gvwProperties.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvwProperties.GridControl = Me.grdAdjacentProperties
        Me.gvwProperties.Name = "gvwProperties"
        Me.gvwProperties.OptionsBehavior.Editable = false
        Me.gvwProperties.OptionsBehavior.ReadOnly = true
        Me.gvwProperties.OptionsView.ShowGroupPanel = false
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "idxKey"
        Me.GridColumn1.FieldName = "idxKey"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "DANO"
        Me.GridColumn2.FieldName = "DANO"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Owners Name"
        Me.GridColumn3.FieldName = "Owners_Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = true
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 159
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Address"
        Me.GridColumn4.FieldName = "Owners_Addr1"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = true
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 174
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Location"
        Me.GridColumn5.FieldName = "Owners_Addr2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = true
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 174
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tag_Key"
        Me.GridColumn6.FieldName = "Tag_Key"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = false
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(12, 61)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 36)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Property"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Enabled = false
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"),System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(437, 52)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 36)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Proceed"
        '
        'ImportAdjacentPropertiesForMailMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 359)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.grdAdjacentProperties)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblSelectMailMergeData)
        Me.Controls.Add(Me.bedtMergeFile)
        Me.Controls.Add(Me.chkStrataProperties)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ImportAdjacentPropertiesForMailMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Adjacent Properties "
        CType(Me.chkStrataProperties.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bedtMergeFile.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdAdjacentProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwProperties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents chkStrataProperties As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bedtMergeFile As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblSelectMailMergeData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRun As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdAdjacentProperties As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwProperties As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
End Class
