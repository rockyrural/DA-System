<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEPVariationsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LEPVariationsReport))
        Me.pnlTop = New DevExpress.XtraEditors.PanelControl()
        Me.btnExcelExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.grdLEPvariations = New DevExpress.XtraGrid.GridControl()
        Me.gvwLEPvariations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.grdLEPvariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwLEPvariations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnExcelExport)
        Me.pnlTop.Controls.Add(Me.btnCancel)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(906, 42)
        Me.pnlTop.TabIndex = 0
        '
        'btnExcelExport
        '
        Me.btnExcelExport.Image = CType(resources.GetObject("btnExcelExport.Image"), System.Drawing.Image)
        Me.btnExcelExport.Location = New System.Drawing.Point(545, 4)
        Me.btnExcelExport.Name = "btnExcelExport"
        Me.btnExcelExport.Size = New System.Drawing.Size(95, 33)
        Me.btnExcelExport.TabIndex = 1
        Me.btnExcelExport.Text = "Export " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excel"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(806, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 33)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'grdLEPvariations
        '
        Me.grdLEPvariations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLEPvariations.Location = New System.Drawing.Point(0, 42)
        Me.grdLEPvariations.MainView = Me.gvwLEPvariations
        Me.grdLEPvariations.Name = "grdLEPvariations"
        Me.grdLEPvariations.Size = New System.Drawing.Size(906, 689)
        Me.grdLEPvariations.TabIndex = 1
        Me.grdLEPvariations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwLEPvariations})
        '
        'gvwLEPvariations
        '
        Me.gvwLEPvariations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3})
        Me.gvwLEPvariations.GridControl = Me.grdLEPvariations
        Me.gvwLEPvariations.Name = "gvwLEPvariations"
        Me.gvwLEPvariations.OptionsBehavior.Editable = False
        Me.gvwLEPvariations.OptionsBehavior.ReadOnly = True
        Me.gvwLEPvariations.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "DA No"
        Me.GridColumn1.FieldName = "appno"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 78
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Received"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "DARegoDt"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 92
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Details"
        Me.GridColumn2.FieldName = "detail"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 538
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Variation"
        Me.GridColumn3.FieldName = "Variation"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 180
        '
        'LEPVariationsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(906, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdLEPvariations)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LEPVariationsReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LEP Variations Report"
        CType(Me.pnlTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.grdLEPvariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwLEPvariations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExcelExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdLEPvariations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwLEPvariations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
