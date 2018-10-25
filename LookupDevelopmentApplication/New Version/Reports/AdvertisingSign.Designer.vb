<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AdvertisingSign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvertisingSign))
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Applicant = New DevExpress.XtraReports.UI.CalculatedField()
        Me.LocationOfProperty = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PropertyDesc = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Available = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 2.573518!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel1, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2})
        Me.BottomMargin.Font = New System.Drawing.Font("Calibri", 28.0!)
        Me.BottomMargin.HeightF = 1595.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StylePriority.UseFont = False
        Me.BottomMargin.StylePriority.UseTextAlignment = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DANo")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(926.3889!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(180.2291!, 51.54639!)
        Me.XrLabel12.Text = "XrLabel12"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Black
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 100.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(3.676997!, 51.54639!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1102.941!, 365.733!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "DEVELOPMENT PROPOSAL"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.00004238552!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(1106.618!, 51.54639!)
        Me.XrLabel13.Text = "SHIRE OF EUROBODALLA"
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DACompletedDt", "{0:dd MMMM yyyy}")})
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 72.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1043.746!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(1106.618!, 94.69116!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 915.9083!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(1106.618!, 126.8382!)
        Me.XrLabel10.Text = resources.GetString("XrLabel10.Text")
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.AdvertSignDepotText")})
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 28.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 835.6325!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(1108.0!, 67.11768!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "XrLabel9"
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.Available")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 770.3531!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(1108.0!, 65.27942!)
        Me.XrLabel8.Text = "XrLabel8"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 28.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 716.103!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(1108.0!, 54.25!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "THE APPLICATION, PLANS AND ASSOCIATED DOCUMENTATION MAY BE INSPECTED FOR A PERIOD" &
    " OF "
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.PropertyDesc")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 658.1765!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(1108.0!, 57.92645!)
        Me.XrLabel6.Text = "XrLabel6"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.LocationOfProperty")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 607.603!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(1108.0!, 50.57355!)
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DADesc")})
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 52.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 549.6765!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1108.0!, 57.92651!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.Applicant")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 28.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 471.5294!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1108.0!, 78.14713!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 417.2794!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1108.0!, 54.25!)
        Me.XrLabel2.Text = "ENVIRONMENTAL PLANNING & ASSESSMENT ACT 1979"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "LookupDevelopmentApplication.My.MySettings.cnDAsystem"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "usp_rpt_AdvertSigns"
        QueryParameter1.Name = "@DANO"
        QueryParameter1.Type = GetType(String)
        QueryParameter1.ValueInfo = "380/16"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "usp_rpt_AdvertSigns"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Applicant
        '
        Me.Applicant.DataMember = "usp_rpt_AdvertSigns"
        Me.Applicant.Expression = "'COUNCIL HAS RECEIVED A DEVELOPMENT APPLICATION FROM'  + Char(13) + [DAAppName] +" &
    " ' for '"
        Me.Applicant.Name = "Applicant"
        '
        'LocationOfProperty
        '
        Me.LocationOfProperty.DataMember = "usp_rpt_AdvertSigns"
        Me.LocationOfProperty.Expression = "[Street]  +  ' ' + [LocalityCode]"
        Me.LocationOfProperty.Name = "LocationOfProperty"
        '
        'PropertyDesc
        '
        Me.PropertyDesc.DataMember = "usp_rpt_AdvertSigns"
        Me.PropertyDesc.Expression = "Iif([DASection]='', 'DP ' + [DADP] + ' Lot ' + [DALot] , 'DP ' + [DADP] + ' Lot '" &
    " + [DALot]+ ' Sec ' + [DASection] )"
        Me.PropertyDesc.Name = "PropertyDesc"
        '
        'Available
        '
        Me.Available.DataMember = "usp_rpt_AdvertSigns"
        Me.Available.Expression = "[lAPSEDAYS]+ ' DAYS FROM  ' + Substring([DACommDt], 0 ,10 )"
        Me.Available.Name = "Available"
        '
        'AdvertisingSign
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Applicant, Me.LocationOfProperty, Me.PropertyDesc, Me.Available})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(28, 33, 0, 1595)
        Me.PageHeight = 1654
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A3
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Applicant As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LocationOfProperty As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PropertyDesc As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Available As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
