Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class ConstructionCertificateCoverSheet


    Private _Referrals As DataTable
    Public WriteOnly Property ReferralsObjDT As DataTable

        Set(ByVal value As DataTable)
            _Referrals = value
        End Set
    End Property

    Private Sub subReferrals_BeforePrint(sender As Object, e As PrintEventArgs) Handles subReferrals.BeforePrint

        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _Referrals
        subreport.ReportSource.FillDataSource

    End Sub
End Class