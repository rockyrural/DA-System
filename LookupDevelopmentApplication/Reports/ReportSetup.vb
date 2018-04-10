Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO



Public Class ReportSetup



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.dtpFromDate.Value = Today.Date
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
                        .CommandText = "usp_rpt_CouncilRep"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "CouncilRep.rpt"
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
                            If thisFormula.FormulaName = "{@ReportTitle}" Then
                                thisFormula.Text = "'Development Applications Determined under Delegated Authority by  the Development and Natural Resources Group for " & Format(CDate(dtpFromDate.Value), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.Value), "dd/MM/yyyy") & "'"
                            End If
                        Next



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

    Private Sub ReportSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.crv.RefreshReport()
    End Sub
End Class