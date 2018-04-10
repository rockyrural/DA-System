<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainSec94Codes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainSec94Codes))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSection94 = New DevExpress.XtraGrid.GridControl()
        Me.S94CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentSQLDataSet1 = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.gvwSection94 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cols94Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols94Plan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols94Subplan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94TrustNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94TypeC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94ex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS94Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.S94CodeTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.S94CodeTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdSection94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S94CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentSQLDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSection94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnChange)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 55)
        Me.PanelControl1.TabIndex = 0
        '
        'btnChange
        '
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.Location = New System.Drawing.Point(101, 5)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(90, 38)
        Me.btnChange.TabIndex = 2
        Me.btnChange.Text = "Change"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 38)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(898, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 38)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        '
        'grdSection94
        '
        Me.grdSection94.DataSource = Me.S94CodeBindingSource
        Me.grdSection94.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSection94.Location = New System.Drawing.Point(0, 55)
        Me.grdSection94.MainView = Me.gvwSection94
        Me.grdSection94.Name = "grdSection94"
        Me.grdSection94.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grdSection94.Size = New System.Drawing.Size(1000, 649)
        Me.grdSection94.TabIndex = 1
        Me.grdSection94.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSection94})
        '
        'S94CodeBindingSource
        '
        Me.S94CodeBindingSource.DataMember = "S94Code"
        Me.S94CodeBindingSource.DataSource = Me.DevelopmentSQLDataSet1
        '
        'DevelopmentSQLDataSet1
        '
        Me.DevelopmentSQLDataSet1.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvwSection94
        '
        Me.gvwSection94.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cols94Code, Me.cols94Plan, Me.cols94Subplan, Me.colS94TrustNo, Me.colS94TypeC, Me.colS94ex, Me.colS94Cost, Me.colActive})
        Me.gvwSection94.GridControl = Me.grdSection94
        Me.gvwSection94.Name = "gvwSection94"
        Me.gvwSection94.OptionsFind.AlwaysVisible = True
        Me.gvwSection94.OptionsView.ShowGroupPanel = False
        '
        'cols94Code
        '
        Me.cols94Code.Caption = "Code"
        Me.cols94Code.FieldName = "s94Code"
        Me.cols94Code.Name = "cols94Code"
        Me.cols94Code.Visible = True
        Me.cols94Code.VisibleIndex = 0
        Me.cols94Code.Width = 87
        '
        'cols94Plan
        '
        Me.cols94Plan.Caption = "Plan"
        Me.cols94Plan.FieldName = "s94Plan"
        Me.cols94Plan.Name = "cols94Plan"
        Me.cols94Plan.Visible = True
        Me.cols94Plan.VisibleIndex = 1
        Me.cols94Plan.Width = 320
        '
        'cols94Subplan
        '
        Me.cols94Subplan.Caption = "Sub Plan"
        Me.cols94Subplan.FieldName = "s94Subplan"
        Me.cols94Subplan.Name = "cols94Subplan"
        Me.cols94Subplan.Visible = True
        Me.cols94Subplan.VisibleIndex = 2
        Me.cols94Subplan.Width = 297
        '
        'colS94TrustNo
        '
        Me.colS94TrustNo.Caption = "Trust No"
        Me.colS94TrustNo.FieldName = "S94TrustNo"
        Me.colS94TrustNo.Name = "colS94TrustNo"
        Me.colS94TrustNo.Visible = True
        Me.colS94TrustNo.VisibleIndex = 3
        Me.colS94TrustNo.Width = 113
        '
        'colS94TypeC
        '
        Me.colS94TypeC.Caption = "Type Code"
        Me.colS94TypeC.FieldName = "S94TypeC"
        Me.colS94TypeC.Name = "colS94TypeC"
        Me.colS94TypeC.Width = 74
        '
        'colS94ex
        '
        Me.colS94ex.Caption = "Exclude"
        Me.colS94ex.FieldName = "S94ex"
        Me.colS94ex.Name = "colS94ex"
        Me.colS94ex.Visible = True
        Me.colS94ex.VisibleIndex = 5
        Me.colS94ex.Width = 56
        '
        'colS94Cost
        '
        Me.colS94Cost.Caption = "Cost"
        Me.colS94Cost.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colS94Cost.DisplayFormat.FormatString = "c2"
        Me.colS94Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colS94Cost.FieldName = "S94Cost"
        Me.colS94Cost.Name = "colS94Cost"
        Me.colS94Cost.Visible = True
        Me.colS94Cost.VisibleIndex = 4
        Me.colS94Cost.Width = 109
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "c2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colActive
        '
        Me.colActive.Caption = "Active"
        Me.colActive.FieldName = "ACTIVE"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 6
        '
        'S94CodeTableAdapter
        '
        Me.S94CodeTableAdapter.ClearBeforeFill = True
        '
        'MaintainSec94Codes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdSection94)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MaintainSec94Codes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Section 94 Codes"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdSection94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S94CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentSQLDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSection94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSection94 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSection94 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DevelopmentSQLDataSet As DevelopmentSQLDataSet
    Friend WithEvents cols94Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols94Plan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols94Subplan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94TrustNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94TypeC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94ex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS94Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DevelopmentSQLDataSet1 As DevelopmentSQLDataSet
    Friend WithEvents S94CodeBindingSource As BindingSource
    Friend WithEvents S94CodeTableAdapter As DevelopmentSQLDataSetTableAdapters.S94CodeTableAdapter
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
End Class
