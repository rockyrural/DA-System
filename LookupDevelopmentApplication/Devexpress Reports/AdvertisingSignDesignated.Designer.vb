<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class AdvertisingSignDesignated
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvertisingSignDesignated))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDepotAdvert = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Applicant = New DevExpress.XtraReports.UI.CalculatedField()
        Me.LocationOfProperty = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PropertyDesc = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Available = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrLabelDEVELOPMENTPROPOSAL = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelDEVELOPMENTPROPOSAL, Me.XrLabel12, Me.XrLabel6, Me.XrLabel7, Me.lblDepotAdvert, Me.XrLabel10, Me.XrLabel11, Me.XrLabel14, Me.XrLabel5, Me.XrLabel2, Me.XrLabel3})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 752.1986!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DANo")})
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Calibri", 48.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(510.7!, 4.00001!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(245.3!, 61.84!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "SHIRE OF EUROBODALLA"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.PropertyDesc")})
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 284.9506!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 10, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(753.885!, 57.92651!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.Available")})
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 342.8771!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 5, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(753.885!, 92.79166!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblDepotAdvert
        '
        Me.lblDepotAdvert.CanShrink = True
        Me.lblDepotAdvert.Dpi = 100.0!
        Me.lblDepotAdvert.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lblDepotAdvert.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 437.9991!)
        Me.lblDepotAdvert.Multiline = True
        Me.lblDepotAdvert.Name = "lblDepotAdvert"
        Me.lblDepotAdvert.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDepotAdvert.SizeF = New System.Drawing.SizeF(753.885!, 33.78442!)
        Me.lblDepotAdvert.StylePriority.UseFont = False
        Me.lblDepotAdvert.StylePriority.UseTextAlignment = False
        Me.lblDepotAdvert.Text = "lblDepotAdvert"
        Me.lblDepotAdvert.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.CanShrink = True
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DesignatedText")})
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 521.6276!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 10, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(753.885!, 53.50482!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel11
        '
        Me.XrLabel11.CanShrink = True
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.DACompletedDt", "{0:dd MMMM yyyy}")})
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 48.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 577.1324!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(753.885!, 66.35785!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.CanShrink = True
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.PlaningDepartmentAddress")})
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 473.7834!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 10, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(753.885!, 45.87622!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.LocationOfProperty")})
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 234.3771!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(753.885!, 50.57346!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 120.73!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(753.885!, 35.50005!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ENVIRONMENTAL PLANNING & ASSESSMENT ACT 1979"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usp_rpt_AdvertSigns.Applicant")})
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(5.114986!, 156.2301!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 20, 20, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(753.885!, 78.14709!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 27.08333!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.Font = New System.Drawing.Font("Calibri", 28.0!)
        Me.BottomMargin.HeightF = 28.77916!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StylePriority.UseFont = False
        Me.BottomMargin.StylePriority.UseTextAlignment = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "LookupDevelopmentApplication.My.MySettings.connectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "usp_rpt_AdvertSigns"
        QueryParameter1.Name = "@DANO"
        QueryParameter1.Type = GetType(String)
        QueryParameter1.ValueInfo = "253/17"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "usp_rpt_AdvertSigns"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Applicant
        '
        Me.Applicant.DataMember = "usp_rpt_AdvertSigns"
        Me.Applicant.Expression = "'COUNCIL HAS RECEIVED A DEVELOPMENT APPLICATION FROM'  + Char(13) + Upper([DAAppN" &
    "ame]) +  Char(13) + ' FOR ' + Char(13) + [DADesc]"
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
        Me.Available.Expression = "'THE APPLICATION, PLANS AND ENVIRONMENTAL IMPACT STUDY MAY BE INSPECTED FOR A PER" &
    "IOD OF 30 DAYS FROM:  ' + Substring([DACommDt], 0 ,10 )"
        Me.Available.Name = "Available"
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 2.0!
        Me.XrCrossBandBox1.Dpi = 100.0!
        Me.XrCrossBandBox1.EndBand = Me.BottomMargin
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(2.844179!, 5.918231!)
        Me.XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.844179!, 24.35065!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.TopMargin
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(2.844179!, 24.35065!)
        Me.XrCrossBandBox1.WidthF = 762.9871!
        '
        'XrLabelDEVELOPMENTPROPOSAL
        '
        Me.XrLabelDEVELOPMENTPROPOSAL.Dpi = 100.0!
        Me.XrLabelDEVELOPMENTPROPOSAL.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelDEVELOPMENTPROPOSAL.LocationFloat = New DevExpress.Utils.PointFloat(7.041708!, 73.84001!)
        Me.XrLabelDEVELOPMENTPROPOSAL.Name = "XrLabelDEVELOPMENTPROPOSAL"
        Me.XrLabelDEVELOPMENTPROPOSAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelDEVELOPMENTPROPOSAL.SizeF = New System.Drawing.SizeF(748.9583!, 44.80667!)
        Me.XrLabelDEVELOPMENTPROPOSAL.StylePriority.UseFont = False
        Me.XrLabelDEVELOPMENTPROPOSAL.StylePriority.UseTextAlignment = False
        Me.XrLabelDEVELOPMENTPROPOSAL.Text = "DESIGNATED DEVELOPMENT PROPOSAL"
        Me.XrLabelDEVELOPMENTPROPOSAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'AdvertisingSignDesignated
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Applicant, Me.LocationOfProperty, Me.PropertyDesc, Me.Available})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox1})
        Me.DataMember = "usp_rpt_AdvertSigns"
        Me.DataSource = Me.SqlDataSource1
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(28, 33, 27, 29)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.2"
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
    Friend WithEvents lblDepotAdvert As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LocationOfProperty As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PropertyDesc As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Available As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabelDEVELOPMENTPROPOSAL As DevExpress.XtraReports.UI.XRLabel
End Class
