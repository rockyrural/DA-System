Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient


Public Class reportSetupApprovals

    Private reportname As String

    Public WriteOnly Property ReportToPrint() As String
        Set(ByVal value As String)
            reportname = value
        End Set
    End Property
    Private SprocName As String
    Public WriteOnly Property StoredProcedureName() As String
        Set(ByVal value As String)
            SprocName = value
        End Set
    End Property
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
        End If
        PrintTheReport()
    End Sub

    Private Sub PrintTheReport()
        Dim thisFormula As FormulaFieldDefinition
        Dim rptDocument As New ReportDocument
        Dim strReportPath As String = String.Empty
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
                        .CommandText = SprocName
                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                    End With

                    strReportPath = My.Settings.ReportLocation & reportname


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Try

                    If Not IO.File.Exists(strReportPath) Then
                        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                    End If

                    'Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    'myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    'myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical

                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()

                        For Each thisFormula In .DataDefinition.FormulaFields
                            If thisFormula.FormulaName = "{@DateRange}" Then
                                thisFormula.Text = "'" & Format(CDate(dtpFromDate.Value), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.Value), "dd/MM/yyyy") & "'"
                            End If
                        Next



                        '.PrintToPrinter(1, False, 1, 99)
                    End With

                    With crv
                        .ShowGroupTreeButton = True
                        .ShowCloseButton = False
                        .ShowPrintButton = True
                        .ShowRefreshButton = True
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