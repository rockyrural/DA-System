Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO


Public Class ReportSetupDAAllocatedToOfficers

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.dtpFromDate.Value = DateAdd(DateInterval.Day, -30, Today.Date)
        Me.dtpToDate.Value = Today.Date

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            PrintTheReport()
            'Me.Close()
        End If
    End Sub

    Private Sub PrintTheReport()
        Dim thisFormula As FormulaFieldDefinition
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
                        .CommandText = "usp_rpt_DAs_AllocatedToOfficers"
                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "DAs_AllocatedByOfficer.rpt"
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

                        For Each thisFormula In .DataDefinition.FormulaFields
                            If thisFormula.FormulaName = "{@Title}" Then
                                thisFormula.Text = "'Development Appls Allocated - by Officer between " & Format(CDate(dtpFromDate.Value), "dd/MM/yyyy") & " and " & Format(CDate(dtpToDate.Value), "dd/MM/yyyy") & "'"
                            End If
                        Next



                        '.PrintToPrinter(1, False, 1, 99)
                    End With

                    With crv
                        .ShowGroupTreeButton = True
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