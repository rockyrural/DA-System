<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainBuilders
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintainBuilders))
        Me.grdBuilders = New DevExpress.XtraGrid.GridControl()
        Me.PCABuilderNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevelopmentSQLDataSet = New LookupDevelopmentApplication.DevelopmentSQLDataSet()
        Me.gvwBuilders = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNameType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboNameType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcc_Lic_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PCA_Builder_NamesTableAdapter = New LookupDevelopmentApplication.DevelopmentSQLDataSetTableAdapters.PCA_Builder_NamesTableAdapter()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdBuilders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCABuilderNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwBuilders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNameType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBuilders
        '
        Me.grdBuilders.DataSource = Me.PCABuilderNamesBindingSource
        Me.grdBuilders.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdBuilders.Location = New System.Drawing.Point(0, 0)
        Me.grdBuilders.MainView = Me.gvwBuilders
        Me.grdBuilders.Name = "grdBuilders"
        Me.grdBuilders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboNameType})
        Me.grdBuilders.Size = New System.Drawing.Size(1156, 461)
        Me.grdBuilders.TabIndex = 5
        Me.grdBuilders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwBuilders})
        '
        'PCABuilderNamesBindingSource
        '
        Me.PCABuilderNamesBindingSource.DataMember = "PCA_Builder_Names"
        Me.PCABuilderNamesBindingSource.DataSource = Me.DevelopmentSQLDataSet
        '
        'DevelopmentSQLDataSet
        '
        Me.DevelopmentSQLDataSet.DataSetName = "DevelopmentSQLDataSet"
        Me.DevelopmentSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvwBuilders
        '
        Me.gvwBuilders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNameType, Me.colName, Me.colAddress, Me.colTown, Me.colPC, Me.colAcc_Lic_no, Me.colPhone, Me.colemail})
        Me.gvwBuilders.GridControl = Me.grdBuilders
        Me.gvwBuilders.Name = "gvwBuilders"
        Me.gvwBuilders.OptionsBehavior.Editable = False
        Me.gvwBuilders.OptionsBehavior.ReadOnly = True
        Me.gvwBuilders.OptionsFind.AlwaysVisible = True
        Me.gvwBuilders.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNameType
        '
        Me.colNameType.Caption = "Type"
        Me.colNameType.ColumnEdit = Me.cboNameType
        Me.colNameType.FieldName = "NameType"
        Me.colNameType.Name = "colNameType"
        Me.colNameType.Visible = True
        Me.colNameType.VisibleIndex = 0
        Me.colNameType.Width = 41
        '
        'cboNameType
        '
        Me.cboNameType.AutoHeight = False
        Me.cboNameType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNameType.Name = "cboNameType"
        Me.cboNameType.NullText = "[?]"
        '
        'colName
        '
        Me.colName.Caption = "Name"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 217
        '
        'colAddress
        '
        Me.colAddress.Caption = "Address"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 2
        Me.colAddress.Width = 242
        '
        'colTown
        '
        Me.colTown.Caption = "Town"
        Me.colTown.FieldName = "Town"
        Me.colTown.Name = "colTown"
        Me.colTown.Visible = True
        Me.colTown.VisibleIndex = 3
        Me.colTown.Width = 140
        '
        'colPC
        '
        Me.colPC.Caption = "P. Code"
        Me.colPC.FieldName = "PC"
        Me.colPC.Name = "colPC"
        Me.colPC.Visible = True
        Me.colPC.VisibleIndex = 4
        Me.colPC.Width = 51
        '
        'colAcc_Lic_no
        '
        Me.colAcc_Lic_no.Caption = "Licence"
        Me.colAcc_Lic_no.FieldName = "Acc_Lic_no"
        Me.colAcc_Lic_no.Name = "colAcc_Lic_no"
        Me.colAcc_Lic_no.Visible = True
        Me.colAcc_Lic_no.VisibleIndex = 5
        Me.colAcc_Lic_no.Width = 65
        '
        'colPhone
        '
        Me.colPhone.Caption = "Phone"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 6
        Me.colPhone.Width = 123
        '
        'colemail
        '
        Me.colemail.Caption = "Email"
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 7
        Me.colemail.Width = 259
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1058, 477)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 34)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(956, 477)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(853, 477)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 34)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        '
        'PCA_Builder_NamesTableAdapter
        '
        Me.PCA_Builder_NamesTableAdapter.ClearBeforeFill = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(12, 477)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(86, 34)
        Me.btnExport.TabIndex = 9
        Me.btnExport.Text = "Export"
        '
        'MaintainBuilders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 523)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grdBuilders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainBuilders"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Maintain Builders"
        CType(Me.grdBuilders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCABuilderNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevelopmentSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwBuilders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNameType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdBuilders As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwBuilders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DevelopmentSQLDataSet As DevelopmentSQLDataSet
    Friend WithEvents PCABuilderNamesBindingSource As BindingSource
    Friend WithEvents PCA_Builder_NamesTableAdapter As DevelopmentSQLDataSetTableAdapters.PCA_Builder_NamesTableAdapter
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcc_Lic_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNameType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboNameType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
End Class
