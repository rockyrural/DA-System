<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReferralResponse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferralResponse))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFrom = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSubject = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFileNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfoDate = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrSubreport = New DevExpress.XtraReports.UI.XRSubreport()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblMemorandum = New DevExpress.XtraReports.UI.XRLabel()
        Me.Address = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DADescription = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLine2, Me.XrLabel2, Me.XrLabel7, Me.XrLabel6, Me.lblFrom, Me.lblTo, Me.XrLabel5, Me.XrLabel4, Me.XrLabel1, Me.lblSubject, Me.lblFileNo, Me.lblDate, Me.XrPageInfoDate, Me.XrSubreport})
        Me.Detail.HeightF = 246.875!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 24.58334!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(711.4583!, 2!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(15.04167!, 177.0833!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(711.4583!, 2!)
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.RefResponse")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 183.2917!)
        Me.XrLabel2.Multiline = true
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(717.0833!, 23!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.DADescription")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 71.58331!)
        Me.XrLabel7.Multiline = true
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(627.5834!, 23!)
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.ReferralCode")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 42.58335!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(242.7083!, 23!)
        Me.XrLabel6.Text = "XrLabel6"
        '
        'lblFrom
        '
        Me.lblFrom.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 42.58335!)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblFrom.SizeF = New System.Drawing.SizeF(64.58334!, 27.12498!)
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 1.583333!)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblTo.SizeF = New System.Drawing.SizeF(35.41667!, 23!)
        Me.lblTo.Text = "To:"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.DAFileNo")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 122.875!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(120.8333!, 23.00001!)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.Address")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 94.5833!)
        Me.XrLabel4.Multiline = true
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(627.5834!, 23!)
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_ReferralResponse.Officer")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 1.583333!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'lblSubject
        '
        Me.lblSubject.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 71.58331!)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblSubject.SizeF = New System.Drawing.SizeF(64.58333!, 23.00001!)
        Me.lblSubject.Text = "Subject:"
        '
        'lblFileNo
        '
        Me.lblFileNo.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 122.875!)
        Me.lblFileNo.Name = "lblFileNo"
        Me.lblFileNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblFileNo.SizeF = New System.Drawing.SizeF(64.58333!, 23.00001!)
        Me.lblFileNo.Text = "File No.:"
        '
        'lblDate
        '
        Me.lblDate.LocationFloat = New DevExpress.Utils.PointFloat(11.91667!, 145.875!)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblDate.SizeF = New System.Drawing.SizeF(64.58333!, 23!)
        Me.lblDate.Text = "Date:"
        '
        'XrPageInfoDate
        '
        Me.XrPageInfoDate.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfoDate.LocationFloat = New DevExpress.Utils.PointFloat(101.4166!, 145.875!)
        Me.XrPageInfoDate.Name = "XrPageInfoDate"
        Me.XrPageInfoDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfoDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfoDate.SizeF = New System.Drawing.SizeF(100!, 23!)
        '
        'XrSubreport
        '
        Me.XrSubreport.LocationFloat = New DevExpress.Utils.PointFloat(0!, 213.875!)
        Me.XrSubreport.Name = "XrSubreport"
        Me.XrSubreport.ReportSource = New LookupDevelopmentApplication.ReferralResponseSubReport()
        Me.XrSubreport.SizeF = New System.Drawing.SizeF(729!, 23!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 31.25!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 34.375!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "LookupDevelopmentApplication.My.MySettings.cnDAsystem"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "usp_rpt_ReferralResponse"
        QueryParameter1.Name = "@REFID"
        QueryParameter1.Type = GetType(Integer)
        QueryParameter1.ValueInfo = "30882"
        QueryParameter2.Name = "@SYSTYPE"
        QueryParameter2.Type = GetType(String)
        QueryParameter2.ValueInfo = "DA"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.StoredProcName = "usp_rpt_ReferralResponse"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblMemorandum})
        Me.PageHeader.HeightF = 44.79167!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblMemorandum
        '
        Me.lblMemorandum.Font = New System.Drawing.Font("Calibri", 18!)
        Me.lblMemorandum.LocationFloat = New DevExpress.Utils.PointFloat(7.750002!, 5.208333!)
        Me.lblMemorandum.Name = "lblMemorandum"
        Me.lblMemorandum.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblMemorandum.SizeF = New System.Drawing.SizeF(193.6667!, 36.875!)
        Me.lblMemorandum.StylePriority.UseFont = false
        Me.lblMemorandum.Text = "Memorandum"
        '
        'Address
        '
        Me.Address.DataMember = "usp_rpt_ReferralResponse"
        Me.Address.Expression = "[DAStreetNo]  + ' ' + [DAStreet] + ', ' + [LocalityCode] + ' DP ' + [DADP] + ' Lo"& _ 
    "t ' + [DALot] + ' ' + [DASection]"
        Me.Address.Name = "Address"
        '
        'DADescription
        '
        Me.DADescription.DataMember = "usp_rpt_ReferralResponse"
        Me.DADescription.Expression = "[DANo] + ' ' + [DADesc]"
        Me.DADescription.Name = "DADescription"
        '
        'ReferralResponse
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Address, Me.DADescription})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margins = New System.Drawing.Printing.Margins(36, 52, 31, 34)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblMemorandum As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFrom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSubject As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFileNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfoDate As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Address As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DADescription As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrSubreport As DevExpress.XtraReports.UI.XRSubreport
End Class
