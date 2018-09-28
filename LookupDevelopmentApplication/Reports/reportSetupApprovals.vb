
Imports System.Data.SqlClient


Public Class reportSetupApprovals

    Private reportname As DevExpress.XtraReports.UI.XtraReport

    Public WriteOnly Property ReportToPrint() As DevExpress.XtraReports.UI.XtraReport
        Set(ByVal value As DevExpress.XtraReports.UI.XtraReport)
            reportname = value
        End Set
    End Property
    Private SprocName As String
    Public WriteOnly Property StoredProcedureName() As String
        Set(ByVal value As String)
            SprocName = value
        End Set
    End Property

    'Private _xsdName As String
    'Public WriteOnly Property XSDName() As String
    '    Set(ByVal value As String)
    '        _xsdName = value
    '    End Set
    'End Property

    Private _reportTitle As String
    Public WriteOnly Property ReportTitle() As String
        Set(ByVal value As String)
            _reportTitle = value
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
            Exit Sub
        End If
        PrintTheReport()
    End Sub

    Private Sub PrintTheReport()
        'Dim thisFormula As FormulaFieldDefinition
        'Dim rptDocument As New ReportDocument
        'Dim strReportPath As String = String.Empty
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
                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, _xsdName)

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\" & _xsdName & ".xsd")

                End Using


                Try

                    reportname.DataSource = objDT

                    Dim lblctrl As DevExpress.XtraReports.UI.XRLabel = reportname.FindControl("lblTitle", True)

                    lblctrl.Text = _reportTitle & " " & Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")

                    reportname.CreateDocument()

                    DocumentViewer1.DocumentSource = reportname





                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in PrintTheReport routine ")
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using
    End Sub

End Class