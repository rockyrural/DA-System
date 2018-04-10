Imports CRYSTAL = CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared


Public Class AddAdvertPrinter
    Private ObjDt As DataTable
    Public WriteOnly Property objDataTable() As DataTable

        Set(ByVal value As DataTable)
            ObjDt = value
        End Set
    End Property

    Private sReportName As String
    Public WriteOnly Property ReportName() As String
        Set(ByVal value As String)
            sReportName = value
        End Set
    End Property

    Private Sub ShowReport()
        Dim rptDocument As New CRYSTAL.ReportDocument

        Dim strReportPath As String = My.Settings.ReportLocation & sReportName
        Try

            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

            End If

            With rptDocument
                .Load(strReportPath)
                .SetDataSource(ObjDt)
                .VerifyDatabase()
            End With



            With crvAdvert
                Select Case sReportName
                    Case "OutstandingReferrals.rpt", "DA_ToDoList.rpt"
                        .ShowGroupTreeButton = True
                    Case Else
                        .ShowGroupTreeButton = False

                End Select
                .ShowCloseButton = False
                .ShowPrintButton = True
                .ShowExportButton = True
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

    Private Sub AddAdvertPrinter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowReport()
    End Sub


End Class