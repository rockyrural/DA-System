Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class DAcoverSheet


    Private _ReferralsDT As DataTable
    Public WriteOnly Property ReferralsObjDT As DataTable

        Set(ByVal value As DataTable)
            _ReferralsDT = value
        End Set
    End Property

    Private Sub subrptReferrals_BeforePrint(sender As Object, e As PrintEventArgs) Handles subrptReferrals.BeforePrint

        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _ReferralsDT
        subreport.ReportSource.FillDataSource()

    End Sub
End Class