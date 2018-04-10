Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient


Public Class ReportSetupOutStandingDAs


    Private Sub PrintTheReport(ByVal cutoff As Integer)

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
                        .CommandText = "usp_rpt_qryOutstanding"
                        .Parameters.Add("@CUTOFF", SqlDbType.Int).Value = cutoff
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using

                Dim rept As New OutStandingDArept

                With rept
                    .DataSource = objDT
                    .CreateDocument()
                End With

                DocumentViewer.DocumentSource = rept


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using
    End Sub





    Private Sub btnPrintOS100_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintOS100.ItemClick
        PrintTheReport(100)
    End Sub

    Private Sub btnPrintOS40_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintOS40.ItemClick
        PrintTheReport(40)

    End Sub

    Private Sub btnPrintOSDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintOSDA.ItemClick
        PrintTheReport(0)
    End Sub
End Class