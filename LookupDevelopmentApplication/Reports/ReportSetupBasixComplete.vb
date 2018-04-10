Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient


Public Class ReportSetupBasixComplete


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.dtpFromDate.Value = Today.Date

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        PrintTheReport()
        'Me.Close()
    End Sub

    Private Sub PrintTheReport()
        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_ESCFinalInspects"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "ESCFinalInspects.rpt"
                Try

                    If Not IO.File.Exists(strReportPath) Then
                        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                    End If

                    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical

                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()

                        '.PrintToPrinter(1, False, 1, 99)
                    End With

                    With crv
                        .ShowGroupTreeButton = False
                        .ShowCloseButton = False
                        .ShowPrintButton = True
                        .ShowRefreshButton = False
                        .ShowTextSearchButton = False
                        .ShowZoomButton = True
                        .ShowGotoPageButton = True
                        .ReportSource = rptDocument
                    End With



                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in PrintTheReport routine ")
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using
    End Sub
End Class