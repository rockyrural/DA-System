<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NumberOfDaCCapprovedSummary
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NumberOfDaCCapprovedSummary))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.fieldOfficer = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldType = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldNumber = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PrintDate = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.DataMember = "usp_rpt_NumberDAsApprovedSummary"
        Me.XrPivotGrid1.DataSource = Me.SqlDataSource1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldOfficer, Me.fieldType, Me.fieldNumber})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 41.66667!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(767.0001!, 50!)
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "LookupDevelopmentApplication.My.MySettings.DataConnection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "usp_rpt_NumberDAsApprovedSummary"
        QueryParameter1.Name = "@START"
        QueryParameter1.Type = GetType(Date)
        QueryParameter1.ValueInfo = "2018-01-01"
        QueryParameter2.Name = "@END"
        QueryParameter2.Type = GetType(Date)
        QueryParameter2.ValueInfo = "2018-06-01"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.StoredProcName = "usp_rpt_NumberDAsApprovedSummary"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'fieldOfficer
        '
        Me.fieldOfficer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldOfficer.AreaIndex = 0
        Me.fieldOfficer.FieldName = "Officer"
        Me.fieldOfficer.Name = "fieldOfficer"
        Me.fieldOfficer.Options.ShowInFilter = true
        Me.fieldOfficer.Width = 380
        '
        'fieldType
        '
        Me.fieldType.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldType.AreaIndex = 0
        Me.fieldType.FieldName = "Type"
        Me.fieldType.Name = "fieldType"
        Me.fieldType.Options.ShowInFilter = true
        Me.fieldType.Width = 102
        '
        'fieldNumber
        '
        Me.fieldNumber.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNumber.AreaIndex = 0
        Me.fieldNumber.FieldName = "Number"
        Me.fieldNumber.Name = "fieldNumber"
        Me.fieldNumber.Options.ShowInFilter = true
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 30!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 30!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1, Me.lblTitle})
        Me.PageHeader.HeightF = 94.79166!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14!)
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lblTitle.Multiline = true
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(767.0001!, 27.16667!)
        Me.lblTitle.StylePriority.UseFont = false
        Me.lblTitle.Text = "Inspectins By Officer Summary from"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo, Me.PrintDate})
        Me.PageFooter.HeightF = 27.08333!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo
        '
        Me.XrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(601.25!, 0!)
        Me.XrPageInfo.Name = "XrPageInfo"
        Me.XrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrPageInfo.TextFormatString = "Page {0} of  {1}"
        '
        'PrintDate
        '
        Me.PrintDate.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.PrintDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.PrintDate.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.PrintDate.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'NumberOfDaCCapprovedSummary
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataSource = Me.SqlDataSource1
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "18.1"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents fieldOfficer As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldType As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldNumber As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PrintDate As DevExpress.XtraReports.UI.XRPageInfo
End Class
