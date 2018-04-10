<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainRoadFundingPercentages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainRoadFundingPercentages))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSec94RF = New DevExpress.XtraGrid.GridControl()
        Me.gvwSec94RF = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.S94CodeRFnumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.S94CodeRFnumbersTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.S94CodeRFnumbersTableAdapter()
        Me.cols94code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndex_PK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrfnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdSec94RF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSec94RF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S94CodeRFnumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(426, 55)
        Me.PanelControl1.TabIndex = 1
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
        Me.btnClose.Location = New System.Drawing.Point(331, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 38)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        '
        'grdSec94RF
        '
        Me.grdSec94RF.DataSource = Me.S94CodeRFnumbersBindingSource
        Me.grdSec94RF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSec94RF.Location = New System.Drawing.Point(0, 55)
        Me.grdSec94RF.MainView = Me.gvwSec94RF
        Me.grdSec94RF.Name = "grdSec94RF"
        Me.grdSec94RF.Size = New System.Drawing.Size(426, 762)
        Me.grdSec94RF.TabIndex = 2
        Me.grdSec94RF.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSec94RF})
        '
        'gvwSec94RF
        '
        Me.gvwSec94RF.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cols94code, Me.colIndex_PK, Me.colPercentage, Me.colrfnumber})
        Me.gvwSec94RF.GridControl = Me.grdSec94RF
        Me.gvwSec94RF.Name = "gvwSec94RF"
        Me.gvwSec94RF.OptionsFind.AlwaysVisible = True
        Me.gvwSec94RF.OptionsView.ShowGroupPanel = False
        '
        'DevelopmentSQLDataSet
        '
        Me.DevelopmentSQLDataSet.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'S94CodeRFnumbersBindingSource
        '
        Me.S94CodeRFnumbersBindingSource.DataMember = "S94CodeRFnumbers"
        Me.S94CodeRFnumbersBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'S94CodeRFnumbersTableAdapter
        '
        Me.S94CodeRFnumbersTableAdapter.ClearBeforeFill = True
        '
        'cols94code
        '
        Me.cols94code.Caption = "94 Code"
        Me.cols94code.FieldName = "s94code"
        Me.cols94code.Name = "cols94code"
        Me.cols94code.Visible = True
        Me.cols94code.VisibleIndex = 0
        Me.cols94code.Width = 111
        '
        'colIndex_PK
        '
        Me.colIndex_PK.FieldName = "Index_PK"
        Me.colIndex_PK.Name = "colIndex_PK"
        '
        'colPercentage
        '
        Me.colPercentage.Caption = "Percentage"
        Me.colPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPercentage.FieldName = "Percentage"
        Me.colPercentage.Name = "colPercentage"
        Me.colPercentage.Visible = True
        Me.colPercentage.VisibleIndex = 1
        Me.colPercentage.Width = 148
        '
        'colrfnumber
        '
        Me.colrfnumber.Caption = "Number"
        Me.colrfnumber.FieldName = "rfnumber"
        Me.colrfnumber.Name = "colrfnumber"
        Me.colrfnumber.Visible = True
        Me.colrfnumber.VisibleIndex = 2
        Me.colrfnumber.Width = 149
        '
        'MaintainRoadFundingPercentages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 817)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdSec94RF)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MaintainRoadFundingPercentages"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Road Funding Percentages"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdSec94RF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSec94RF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S94CodeRFnumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSec94RF As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSec94RF As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DevelopmentSQLDataSet As DevelopmentSQLDataSet
    Friend WithEvents S94CodeRFnumbersBindingSource As BindingSource
    Friend WithEvents S94CodeRFnumbersTableAdapter As DevelopmentSQLDataSetTableAdapters.S94CodeRFnumbersTableAdapter
    Friend WithEvents cols94code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndex_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrfnumber As DevExpress.XtraGrid.Columns.GridColumn
End Class
