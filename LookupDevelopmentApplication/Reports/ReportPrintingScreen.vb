Imports CRYSTAL = CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared

Public Class ReportPrintScreen

    Private Sub ReportPrintScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        rptDocument.Dispose()
    End Sub

    Private Sub ReportPrintingScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowReport()
    End Sub

    Private rptDocument As CRYSTAL.ReportDocument
    Public WriteOnly Property ReportName() As CRYSTAL.ReportDocument
        Set(ByVal value As CRYSTAL.ReportDocument)
            rptDocument = value
        End Set
    End Property

    Private Sub ShowReport()

        Try

            With crv
                .ShowCloseButton = False
                .ShowPrintButton = True
                .ShowRefreshButton = False
                .ShowTextSearchButton = False
                .ShowZoomButton = True
                .ShowGotoPageButton = True
                .ReportSource = rptDocument
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, " in ShowReport routine ")
        End Try

    End Sub


End Class