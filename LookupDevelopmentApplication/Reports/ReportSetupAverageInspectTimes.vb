
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class ReportSetupAverageInspectTimes


    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If cboYear.Text = String.Empty Then
            MessageBox.Show("You MUST select a Year", "Incorrect Year", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            PrintTheReport()
            'Me.Close()
        End If
    End Sub

    Private Sub PrintTheReport()
        'Dim rptDocument As New ReportDocument

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
                        .CommandText = "usp_rpt_InspectionTime"
                        .Parameters.Add("@YEAR", SqlDbType.Int).Value = CInt(cboYear.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "inspectionTimes")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\inspectionTimes.xsd")


                End Using


                Dim rept As New AverageInspectionTimes

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
End Class