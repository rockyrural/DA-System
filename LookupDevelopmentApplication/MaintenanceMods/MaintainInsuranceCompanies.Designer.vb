<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainInsuranceCompanies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainInsuranceCompanies))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdFees = New DevExpress.XtraGrid.GridControl()
        Me.InsuranceCompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCdata = New LookupDevelopmentApplication.CCdata()
        Me.gvwFees = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInsuranceId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInsurance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InsuranceCompaniesTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.InsuranceCompaniesTableAdapter()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.grdFees)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(325, 461)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Maintain Insurance Companies"
        '
        'grdFees
        '
        Me.grdFees.DataSource = Me.InsuranceCompaniesBindingSource
        Me.grdFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFees.Location = New System.Drawing.Point(2, 39)
        Me.grdFees.MainView = Me.gvwFees
        Me.grdFees.Name = "grdFees"
        Me.grdFees.Size = New System.Drawing.Size(321, 420)
        Me.grdFees.TabIndex = 0
        Me.grdFees.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFees})
        '
        'InsuranceCompaniesBindingSource
        '
        Me.InsuranceCompaniesBindingSource.DataMember = "InsuranceCompanies"
        Me.InsuranceCompaniesBindingSource.DataSource = Me.CCdata
        '
        'CCdata
        '
        Me.CCdata.DataSetName = "CCdata"
        Me.CCdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvwFees
        '
        Me.gvwFees.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInsuranceId, Me.colInsurance})
        Me.gvwFees.GridControl = Me.grdFees
        Me.gvwFees.Name = "gvwFees"
        Me.gvwFees.OptionsView.ShowGroupPanel = False
        '
        'colInsuranceId
        '
        Me.colInsuranceId.FieldName = "InsuranceId"
        Me.colInsuranceId.Name = "colInsuranceId"
        '
        'colInsurance
        '
        Me.colInsurance.Caption = "Company Name"
        Me.colInsurance.FieldName = "Insurance"
        Me.colInsurance.Name = "colInsurance"
        Me.colInsurance.Visible = True
        Me.colInsurance.VisibleIndex = 0
        '
        'InsuranceCompaniesTableAdapter
        '
        Me.InsuranceCompaniesTableAdapter.ClearBeforeFill = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnChange)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 399)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 62)
        Me.PanelControl1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(223, 14)
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
        'MaintainInsuranceCompanies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MaintainInsuranceCompanies"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdFees As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwFees As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CCdata As CCdata
    Friend WithEvents InsuranceCompaniesBindingSource As BindingSource
    Friend WithEvents InsuranceCompaniesTableAdapter As CCdataTableAdapters.InsuranceCompaniesTableAdapter
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colInsuranceId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInsurance As DevExpress.XtraGrid.Columns.GridColumn
End Class
