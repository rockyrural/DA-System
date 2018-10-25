Imports CRYSTAL = CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared

Public Class TestViewer
    Private sReportName As CRYSTAL.ReportDocument
    Public WriteOnly Property ReportName() As CRYSTAL.ReportDocument
        Set(ByVal value As CRYSTAL.ReportDocument)
            sReportName = value
        End Set
    End Property

    Private Sub ShowReport()

        Try
            With CrystalReportViewer1
                .ShowGroupTreeButton = False
                .ShowCloseButton = False
                .ShowPrintButton = True
                .ShowRefreshButton = False
                .ShowTextSearchButton = False
                .ShowZoomButton = True
                .ShowGotoPageButton = True
                .ReportSource = sReportName
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, " in ShowReport routine ")
        End Try

    End Sub

    Private Sub TestViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowReport()
    End Sub
End Class