Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class ReportSetupInspectionsByOfficer

    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private Function NotCompleted() As Boolean
        Dim result As Boolean = True



        If Me.cboOfficer.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboOfficer, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboOfficer, "You MUST select an officer")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboOfficer, "")

        End If



        Return result


    End Function


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

        Me.dtpFromDate.Value = Today.Date
        Me.dtpToDate.Value = Today.Date

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not NotCompleted() Then Exit Sub

        If DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            PrintTheReport()
            'Me.Close()
        End If
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
                        .CommandText = "usp_rpt_ComplianceInspect"
                        .Parameters.Add("@FROMDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@TODATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@OFFICERNAME", SqlDbType.NVarChar).Value = Me.cboOfficer.Text.ToString
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "ComplianceInspect.rpt"
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
    Private Sub ReportSetupInspectionsByOfficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListOfOfficersForReportSelectionTableAdapter.Fill(Me.CZONES.ListOfOfficersForReportSelection)
        cboOfficer.SelectedIndex = -1

    End Sub

 
End Class