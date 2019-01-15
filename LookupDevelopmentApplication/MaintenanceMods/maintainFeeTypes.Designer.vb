<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maintainFeeTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maintainFeeTypes))
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Maintenance = New LookupDevelopmentApplication.Maintenance()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdFees = New DevExpress.XtraGrid.GridControl()
        Me.gvwFees = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPaymentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCategories = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colChargeCalcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeFlatFee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargePerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeUnitType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeMinimum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGLAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PaymentTableAdapter = New LookupDevelopmentApplication.MaintenanceTableAdapters.PaymentTableAdapter()
        CType(Me.PaymentBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Maintenance,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.grdFees,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvwFees,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCategories,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        Me.SuspendLayout
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Maintenance
        '
        'Maintenance
        '
        Me.Maintenance.DataSetName = "Maintenance"
        Me.Maintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"),System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.grdFees)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(712, 535)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Maintain payment types"
        '
        'grdFees
        '
        Me.grdFees.DataSource = Me.PaymentBindingSource
        Me.grdFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFees.Location = New System.Drawing.Point(2, 39)
        Me.grdFees.MainView = Me.gvwFees
        Me.grdFees.Name = "grdFees"
        Me.grdFees.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboCategories})
        Me.grdFees.Size = New System.Drawing.Size(708, 444)
        Me.grdFees.TabIndex = 7
        Me.grdFees.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFees})
        '
        'gvwFees
        '
        Me.gvwFees.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPaymentId, Me.colPayment, Me.colChargeCategory, Me.colChargeCalcType, Me.colChargeFlatFee, Me.colChargePerUnit, Me.colChargeUnitType, Me.colChargeMinimum, Me.colGLAccount})
        Me.gvwFees.GridControl = Me.grdFees
        Me.gvwFees.Name = "gvwFees"
        Me.gvwFees.OptionsView.ShowGroupPanel = false
        '
        'colPaymentId
        '
        Me.colPaymentId.FieldName = "PaymentId"
        Me.colPaymentId.Name = "colPaymentId"
        '
        'colPayment
        '
        Me.colPayment.FieldName = "Payment"
        Me.colPayment.Name = "colPayment"
        Me.colPayment.Visible = true
        Me.colPayment.VisibleIndex = 0
        Me.colPayment.Width = 310
        '
        'colChargeCategory
        '
        Me.colChargeCategory.ColumnEdit = Me.cboCategories
        Me.colChargeCategory.FieldName = "ChargeCategory"
        Me.colChargeCategory.Name = "colChargeCategory"
        Me.colChargeCategory.Visible = true
        Me.colChargeCategory.VisibleIndex = 1
        Me.colChargeCategory.Width = 103
        '
        'cboCategories
        '
        Me.cboCategories.AutoHeight = false
        Me.cboCategories.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.NullText = "[Select Category]"
        '
        'colChargeCalcType
        '
        Me.colChargeCalcType.FieldName = "ChargeCalcType"
        Me.colChargeCalcType.Name = "colChargeCalcType"
        '
        'colChargeFlatFee
        '
        Me.colChargeFlatFee.DisplayFormat.FormatString = "C2"
        Me.colChargeFlatFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChargeFlatFee.FieldName = "ChargeFlatFee"
        Me.colChargeFlatFee.Name = "colChargeFlatFee"
        Me.colChargeFlatFee.Visible = true
        Me.colChargeFlatFee.VisibleIndex = 2
        Me.colChargeFlatFee.Width = 96
        '
        'colChargePerUnit
        '
        Me.colChargePerUnit.DisplayFormat.FormatString = "C2"
        Me.colChargePerUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChargePerUnit.FieldName = "ChargePerUnit"
        Me.colChargePerUnit.Name = "colChargePerUnit"
        Me.colChargePerUnit.Visible = true
        Me.colChargePerUnit.VisibleIndex = 3
        Me.colChargePerUnit.Width = 98
        '
        'colChargeUnitType
        '
        Me.colChargeUnitType.FieldName = "ChargeUnitType"
        Me.colChargeUnitType.Name = "colChargeUnitType"
        '
        'colChargeMinimum
        '
        Me.colChargeMinimum.DisplayFormat.FormatString = "C2"
        Me.colChargeMinimum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChargeMinimum.FieldName = "ChargeMinimum"
        Me.colChargeMinimum.Name = "colChargeMinimum"
        Me.colChargeMinimum.Visible = true
        Me.colChargeMinimum.VisibleIndex = 4
        Me.colChargeMinimum.Width = 85
        '
        'colGLAccount
        '
        Me.colGLAccount.FieldName = "GLAccount"
        Me.colGLAccount.Name = "colGLAccount"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnChange)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 483)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(708, 50)
        Me.PanelControl1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"),System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(223, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'btnChange
        '
        Me.btnChange.Enabled = false
        Me.btnChange.ImageOptions.Image = CType(resources.GetObject("btnChange.ImageOptions.Image"),System.Drawing.Image)
        Me.btnChange.Location = New System.Drawing.Point(108, 5)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(97, 40)
        Me.btnChange.TabIndex = 8
        Me.btnChange.Text = "&Change"
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = true
        '
        'maintainFeeTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 535)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "maintainFeeTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain FeeTypes"
        CType(Me.PaymentBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Maintenance,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.grdFees,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvwFees,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCategories,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Maintenance As Maintenance
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As MaintenanceTableAdapters.PaymentTableAdapter
    Friend WithEvents grdFees As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwFees As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPaymentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeCategory As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents cboCategories As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colChargeCalcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeFlatFee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargePerUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeUnitType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeMinimum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGLAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
End Class
