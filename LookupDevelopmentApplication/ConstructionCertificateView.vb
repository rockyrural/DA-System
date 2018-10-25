Imports CRYSTAL = CrystalDecisions.CrystalReports.Engine

Public Class ConstructionCertificateView


    Private _Rept As CRYSTAL.ReportDocument


    Public WriteOnly Property ReportName() As CRYSTAL.ReportDocument

        Set(ByVal value As CRYSTAL.ReportDocument)
            _Rept = value
        End Set
    End Property



    Private Sub ConstructionCertificateView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With crv
            .ReportSource = _Rept
        End With
    End Sub

End Class