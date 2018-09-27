
Imports System.Data.SqlClient


Public Class reportSetupMayoral

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

        dtpFromDate.EditValue = DateAdd(DateInterval.Day, -30, Today.Date)
        dtpToDate.EditValue = Today.Date

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If DateDiff(DateInterval.Day, CDate(dtpFromDate.EditValue), CDate(dtpToDate.EditValue)) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        PrintTheReport()
    End Sub

    Private Sub PrintTheReport()

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
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                Try



                    'Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    'myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    'myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical



                    If reportname = "DAMayoralSummaryDeterm" Then

                        Dim rept As New MayoralDetermined

                        rept.DataSource = objDT
                        rept.lblTitle.Text = "Development Applications Determined " & Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")
                        rept.CreateDocument()

                        DocumentViewer1.DocumentSource = rept

                    Else

                        Dim rept As New MayoralReceived

                        rept.DataSource = objDT
                        rept.lblTitle.Text = "Development Applications Received " & Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")
                        rept.CreateDocument()

                        DocumentViewer1.DocumentSource = rept


                    End If






                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in PrintTheReport routine ")
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using
    End Sub


End Class