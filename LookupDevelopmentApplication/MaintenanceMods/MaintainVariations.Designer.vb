<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainVariations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainVariations))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdVariations = New DevExpress.XtraGrid.GridControl()
        Me.VariationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.gvwVariations = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVariationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OriginCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VariationsTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.VariationsTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwVariations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnChange)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 366)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(339, 62)
        Me.PanelControl1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(230, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.Location = New System.Drawing.Point(108, 14)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(97, 40)
        Me.btnChange.TabIndex = 8
        Me.btnChange.Text = "&Change"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(5, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.grdVariations)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(339, 366)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Maintain Variation List"
        '
        'grdVariations
        '
        Me.grdVariations.DataSource = Me.VariationsBindingSource
        Me.grdVariations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVariations.Location = New System.Drawing.Point(2, 39)
        Me.grdVariations.MainView = Me.gvwVariations
        Me.grdVariations.Name = "grdVariations"
        Me.grdVariations.Size = New System.Drawing.Size(335, 325)
        Me.grdVariations.TabIndex = 0
        Me.grdVariations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVariations})
        '
        'VariationsBindingSource
        '
        Me.VariationsBindingSource.DataMember = "Variations"
        Me.VariationsBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvwVariations
        '
        Me.gvwVariations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVariationId, Me.colVariation})
        Me.gvwVariations.GridControl = Me.grdVariations
        Me.gvwVariations.Name = "gvwVariations"
        Me.gvwVariations.OptionsView.ShowGroupPanel = False
        '
        'colVariationId
        '
        Me.colVariationId.FieldName = "VariationId"
        Me.colVariationId.Name = "colVariationId"
        '
        'colVariation
        '
        Me.colVariation.Caption = "Variation"
        Me.colVariation.FieldName = "Variation"
        Me.colVariation.Name = "colVariation"
        Me.colVariation.Visible = True
        Me.colVariation.VisibleIndex = 0
        '
        'OriginCodeBindingSource
        '
        Me.OriginCodeBindingSource.DataMember = "OriginCode"
        '
        'VariationsTableAdapter
        '
        Me.VariationsTableAdapter.ClearBeforeFill = True
        '
        'MaintainVariations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MaintainVariations"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwVariations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdVariations As DevExpress.XtraGrid.GridControl
    Friend WithEvents OriginCodeBindingSource As BindingSource
    Friend WithEvents gvwVariations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DAdatasets As DAdatasets
    Friend WithEvents VariationsBindingSource As BindingSource
    Friend WithEvents VariationsTableAdapter As DAdatasetsTableAdapters.VariationsTableAdapter
    Friend WithEvents colVariationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariation As DevExpress.XtraGrid.Columns.GridColumn
End Class
