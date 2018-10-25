Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class ConstructionCertificate_DA

    Private _ClassId As DataTable
    Public WriteOnly Property ClassIDObjDT As DataTable

        Set(ByVal value As DataTable)
            _ClassId = value
        End Set
    End Property

    Private Sub subClassifications_BeforePrint(sender As Object, e As PrintEventArgs) Handles subClassifications.BeforePrint

        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _ClassId
        subreport.ReportSource.FillDataSource()

    End Sub


End Class