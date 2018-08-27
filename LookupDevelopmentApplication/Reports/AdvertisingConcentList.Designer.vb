<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AdvertisingConcentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvertisingConcentList))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridLoadDCP_DArecordsTableAdapter1 = New LookupDevelopmentApplication.AAdataTableAdapters.GridLoadDCP_DArecordsTableAdapter()
        Me.buildProperty = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Reference = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblCouncilHasApproved = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDevelopmentApprovals = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel4, Me.XrLabel2})
        Me.Detail.Dpi = 254!
        Me.Detail.Font = New System.Drawing.Font("Calibri", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Detail.HeightF = 58.42!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.Detail.StylePriority.UseFont = false
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanShrink = true
        Me.XrLabel3.Dpi = 254!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Reference]")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1507.384!, 0!)
        Me.XrLabel3.Multiline = true
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel3.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.SuppressAndShrink
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(240.7706!, 58.42!)
        Me.XrLabel3.StylePriority.UseBorders = false
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.CanShrink = true
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADesc]")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(786.9766!, 0!)
        Me.XrLabel4.Multiline = true
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.SuppressAndShrink
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(720.4078!, 58.42!)
        Me.XrLabel4.StylePriority.UseBorders = false
        Me.XrLabel4.Text = "XrLabel4"
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7})
        Me.SubBand1.Dpi = 254!
        Me.SubBand1.HeightF = 63.50003!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.CanShrink = true
        Me.XrLabel7.Dpi = 254!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CondDesc]")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1748.366!, 0!)
        Me.XrLabel7.Multiline = true
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel7.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.SuppressAndShrink
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(526.309!, 58.42!)
        Me.XrLabel7.StylePriority.UseBorders = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254!
        Me.TopMargin.HeightF = 102!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254!
        Me.BottomMargin.HeightF = 91!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "LookupDevelopmentApplication.My.MySettings.DataConnection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "usp_SELECT_DA_Advert_Union"
        StoredProcQuery1.StoredProcName = "usp_SELECT_DA_Advert_Union"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridLoadDCP_DArecordsTableAdapter1
        '
        Me.GridLoadDCP_DArecordsTableAdapter1.ClearBeforeFill = true
        '
        'buildProperty
        '
        Me.buildProperty.DataMember = "usp_SELECT_DA_Advert_Union"
        Me.buildProperty.DisplayName = "property"
        Me.buildProperty.Expression = "[LocalityCode] + ' ' +[LotDP_formatted] + ' - ' +"&Global.Microsoft.VisualBasic.ChrW(10)&"[Street_Formatted]"
        Me.buildProperty.FieldType = DevExpress.XtraReports.UI.FieldType.[String]
        Me.buildProperty.Name = "buildProperty"
        '
        'Reference
        '
        Me.Reference.DataMember = "usp_SELECT_DA_Advert_Union"
        Me.Reference.Expression = "[DANo] + Char(10) + [DAFileNo]"
        Me.Reference.Name = "Reference"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblCouncilHasApproved, Me.lblDevelopmentApprovals})
        Me.ReportHeader.Dpi = 254!
        Me.ReportHeader.HeightF = 175!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblCouncilHasApproved
        '
        Me.lblCouncilHasApproved.Dpi = 254!
        Me.lblCouncilHasApproved.Font = New System.Drawing.Font("Calibri", 9!)
        Me.lblCouncilHasApproved.LocationFloat = New DevExpress.Utils.PointFloat(0!, 58.42001!)
        Me.lblCouncilHasApproved.Multiline = true
        Me.lblCouncilHasApproved.Name = "lblCouncilHasApproved"
        Me.lblCouncilHasApproved.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.lblCouncilHasApproved.SizeF = New System.Drawing.SizeF(2664.354!, 113.7708!)
        Me.lblCouncilHasApproved.StylePriority.UseFont = false
        Me.lblCouncilHasApproved.Text = resources.GetString("lblCouncilHasApproved.Text")
        '
        'lblDevelopmentApprovals
        '
        Me.lblDevelopmentApprovals.Dpi = 254!
        Me.lblDevelopmentApprovals.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Bold)
        Me.lblDevelopmentApprovals.LocationFloat = New DevExpress.Utils.PointFloat(25.40002!, 0!)
        Me.lblDevelopmentApprovals.Multiline = true
        Me.lblDevelopmentApprovals.Name = "lblDevelopmentApprovals"
        Me.lblDevelopmentApprovals.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.lblDevelopmentApprovals.SizeF = New System.Drawing.SizeF(590.0208!, 58.42!)
        Me.lblDevelopmentApprovals.StylePriority.UseFont = false
        Me.lblDevelopmentApprovals.Text = "Development approvals"
        '
        'lbl
        '
        Me.lbl.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.lbl.Dpi = 254!
        Me.lbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lbl.Multiline = true
        Me.lbl.Name = "lbl"
        Me.lbl.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.lbl.SizeF = New System.Drawing.SizeF(789.6223!, 58.42!)
        Me.lbl.StylePriority.UseBorders = false
        Me.lbl.StylePriority.UseFont = false
        Me.lbl.Text = "PROPERTY LOCATION"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Dpi = 254!
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(789.6223!, 0!)
        Me.XrLabel6.Multiline = true
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(717.7621!, 58.42!)
        Me.XrLabel6.StylePriority.UseBorders = false
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.Text = "DEVELOPMENT"
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Dpi = 254!
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1507.384!, 0!)
        Me.XrLabel8.Multiline = true
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(240.7709!, 58.42!)
        Me.XrLabel8.StylePriority.UseBorders = false
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.Text = "REFERENCE"
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Dpi = 254!
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1748.366!, 0!)
        Me.XrLabel9.Multiline = true
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(526.309!, 58.42!)
        Me.XrLabel9.StylePriority.UseBorders = false
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.Text = "DECISION REASON"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl, Me.XrLabel8, Me.XrLabel6, Me.XrLabel9, Me.XrLabel10})
        Me.PageHeader.Dpi = 254!
        Me.PageHeader.HeightF = 64!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Dpi = 254!
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(2274.675!, 0!)
        Me.XrLabel10.Multiline = true
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(511.7043!, 58.42!)
        Me.XrLabel10.StylePriority.UseBorders = false
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.Text = "COMMUNITY VIEWS"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6})
        Me.PageFooter.Dpi = 254!
        Me.PageFooter.HeightF = 10!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine6
        '
        Me.XrLine6.Dpi = 254!
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(6.45584!, 5.291667!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(2779.924!, 5.079999!)
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.CanShrink = true
        Me.XrLabel2.Dpi = 254!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[buildProperty]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 9!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6.45584!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel2.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.SuppressAndShrink
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(780.5206!, 58.42!)
        Me.XrLabel2.StylePriority.UseBorders = false
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.WordWrap = false
        '
        'AdvertisingConcentList
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.PageFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.buildProperty, Me.Reference})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataAdapter = Me.GridLoadDCP_DArecordsTableAdapter1
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Dpi = 254!
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Landscape = true
        Me.Margins = New System.Drawing.Printing.Margins(91, 91, 102, 91)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25!
        Me.Version = "18.1"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GridLoadDCP_DArecordsTableAdapter1 As AAdataTableAdapters.GridLoadDCP_DArecordsTableAdapter
    Friend WithEvents buildProperty As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Reference As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblCouncilHasApproved As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDevelopmentApprovals As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
