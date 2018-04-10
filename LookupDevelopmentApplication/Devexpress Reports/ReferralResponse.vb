Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class ReferralResponse


    Private _ReferralCond As DataTable
    Public WriteOnly Property ReferralConditions As DataTable

        Set(ByVal value As DataTable)
            _ReferralCond = value
        End Set
    End Property

    Private Sub XrSubreport_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrSubreport.BeforePrint
                
        Dim subreport As XRSubreport = CType(sender, XRSubreport)
        subreport.ReportSource.DataSource = _ReferralCond
        subreport.ReportSource.FillDataSource()

    End Sub
End Class