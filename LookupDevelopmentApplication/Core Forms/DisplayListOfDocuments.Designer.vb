<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayListOfDocuments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayListOfDocuments))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFileNumber = New DevExpress.XtraEditors.TextEdit()
        Me.grdListOfDocuments = New DevExpress.XtraGrid.GridControl()
        Me.gvwListOfDocuments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDWrittenDT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnInsertDocument = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.txtFileNumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grdListOfDocuments,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwListOfDocuments,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnInsertDocument)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnLoad)
        Me.PanelControl1.Controls.Add(Me.txtFileNumber)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(820, 43)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "File Number"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(713, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnLoad
        '
        Me.btnLoad.ImageOptions.Image = CType(resources.GetObject("btnLoad.ImageOptions.Image"),System.Drawing.Image)
        Me.btnLoad.Location = New System.Drawing.Point(136, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(102, 37)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Documents"
        '
        'txtFileNumber
        '
        Me.txtFileNumber.Location = New System.Drawing.Point(5, 19)
        Me.txtFileNumber.Name = "txtFileNumber"
        Me.txtFileNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFileNumber.TabIndex = 0
        '
        'grdListOfDocuments
        '
        Me.grdListOfDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdListOfDocuments.Location = New System.Drawing.Point(0, 43)
        Me.grdListOfDocuments.MainView = Me.gvwListOfDocuments
        Me.grdListOfDocuments.Name = "grdListOfDocuments"
        Me.grdListOfDocuments.Size = New System.Drawing.Size(820, 359)
        Me.grdListOfDocuments.TabIndex = 1
        Me.grdListOfDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwListOfDocuments})
        '
        'gvwListOfDocuments
        '
        Me.gvwListOfDocuments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocNumber, Me.colCustName, Me.colDSummary, Me.colDWrittenDT})
        Me.gvwListOfDocuments.GridControl = Me.grdListOfDocuments
        Me.gvwListOfDocuments.Name = "gvwListOfDocuments"
        Me.gvwListOfDocuments.OptionsBehavior.Editable = false
        Me.gvwListOfDocuments.OptionsBehavior.ReadOnly = true
        Me.gvwListOfDocuments.OptionsView.ShowGroupPanel = false
        '
        'colDocNumber
        '
        Me.colDocNumber.Caption = "Doc. No."
        Me.colDocNumber.FieldName = "DId"
        Me.colDocNumber.Name = "colDocNumber"
        Me.colDocNumber.Visible = true
        Me.colDocNumber.VisibleIndex = 0
        Me.colDocNumber.Width = 86
        '
        'colCustName
        '
        Me.colCustName.Caption = "Correspondent"
        Me.colCustName.FieldName = "CustName"
        Me.colCustName.Name = "colCustName"
        Me.colCustName.Visible = true
        Me.colCustName.VisibleIndex = 1
        Me.colCustName.Width = 204
        '
        'colDSummary
        '
        Me.colDSummary.Caption = "Summary"
        Me.colDSummary.FieldName = "DSummary"
        Me.colDSummary.Name = "colDSummary"
        Me.colDSummary.Visible = true
        Me.colDSummary.VisibleIndex = 2
        Me.colDSummary.Width = 419
        '
        'colDWrittenDT
        '
        Me.colDWrittenDT.Caption = "Written"
        Me.colDWrittenDT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colDWrittenDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDWrittenDT.FieldName = "DWrittenDT"
        Me.colDWrittenDT.Name = "colDWrittenDT"
        Me.colDWrittenDT.Visible = true
        Me.colDWrittenDT.VisibleIndex = 3
        Me.colDWrittenDT.Width = 93
        '
        'btnInsertDocument
        '
        Me.btnInsertDocument.Enabled = false
        Me.btnInsertDocument.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"),System.Drawing.Image)
        Me.btnInsertDocument.Location = New System.Drawing.Point(255, 3)
        Me.btnInsertDocument.Name = "btnInsertDocument"
        Me.btnInsertDocument.Size = New System.Drawing.Size(102, 37)
        Me.btnInsertDocument.TabIndex = 4
        Me.btnInsertDocument.Text = "Insert "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Document"
        '
        'DisplayListOfDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(820, 402)
        Me.ControlBox = false
        Me.Controls.Add(Me.grdListOfDocuments)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DisplayListOfDocuments"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DisplayListOfDocuments"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        Me.PanelControl1.PerformLayout
        CType(Me.txtFileNumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdListOfDocuments,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwListOfDocuments,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdListOfDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwListOfDocuments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDocNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDWrittenDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnInsertDocument As DevExpress.XtraEditors.SimpleButton
End Class
