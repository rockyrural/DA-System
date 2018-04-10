Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class ConstructionCertificate_Commercial

    Private _ClassId As DataTable
    Public WriteOnly Property ClassIDObjDT As DataTable

        Set(ByVal value As DataTable)
            _ClassId = value
        End Set
    End Property


    Private _FireSched As DataTable
    Public WriteOnly Property FireSchedObjDT As DataTable

        Set(ByVal value As DataTable)
            _FireSched = value
        End Set
    End Property

    Private Sub subClassifications_BeforePrint(sender As Object, e As PrintEventArgs) Handles subClassifications.BeforePrint

        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _ClassId
        subreport.ReportSource.FillDataSource()

    End Sub

    Private Sub subFireSchedule_BeforePrint(sender As Object, e As PrintEventArgs) Handles subFireSchedule.BeforePrint

        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _FireSched
        subreport.ReportSource.FillDataSource()

    End Sub
End Class