Imports System.Data.SqlClient

Public Class ReportViewer



    Private _rptName As DevExpress.XtraReports.UI.XtraReport
    Public WriteOnly Property reportName() As DevExpress.XtraReports.UI.XtraReport

        Set(ByVal value As DevExpress.XtraReports.UI.XtraReport)
            _rptName = value
        End Set

    End Property

    Private _rept As String
    Public WriteOnly Property ReportType() As String

        Set(ByVal value As String)
            _rept = value
        End Set
    End Property


    Private SprocName As String
    Public WriteOnly Property StoredProcedureName() As String
        Set(ByVal value As String)
            SprocName = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        dteStart.EditValue = DateAdd(DateInterval.Day, -30, Today.Date)
        dteEnd.EditValue = Today.Date


    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        If DateDiff(DateInterval.Day, CDate(dteStart.EditValue), CDate(dteEnd.EditValue)) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        PrintTheReport()

    End Sub


    Private Sub PrintTheReport()
        Dim objDT As New DataTable


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

                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dteStart.EditValue), "yyyy-MM-dd")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dteEnd.EditValue), "yyy-MM-dd")


                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "MayoralReceived")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\MayoralReceived.xsd")


                    Select Case _rept
                        Case "CCALLOC"


                            Dim rept As New ConstructionCertAllocatedByOfficer

                            rept.lblTitle.Text = "Construction Certs Allocated - by Officer between " & Format(CDate(dteStart.EditValue), "d-MMM-yyyy") & " and " & Format(CDate(dteEnd.EditValue), "d-MMM-yyyy")

                            'rept.DataSource = objDT

                            _rptName = rept

                        Case "DAALLOC"

                            Dim rept As New ConstructionCertAllocatedByOfficer

                            rept.lblTitle.Text = "Development Approvals Allocated - by Officer between " & Format(CDate(dteStart.EditValue), "d-MMM-yyyy") & " and " & Format(CDate(dteEnd.EditValue), "d-MMM-yyyy")

                            'rept.DataSource = objDT

                            _rptName = rept



                        Case "MAYORRECD"

                            Dim rept As New MayoralReceived

                            rept.lblTitle.Text = "Development Applications Received between " & Format(CDate(dteStart.EditValue), "d-MMM-yyyy") & " and " & Format(CDate(dteEnd.EditValue), "d-MMM-yyyy")

                            _rptName = rept

                        Case "MAYORDETERM"

                            Dim rept As New MayoralDetermined

                            rept.lblTitle.Text = "Development Applications Determined between " & Format(CDate(dteStart.EditValue), "d-MMM-yyyy") & " and " & Format(CDate(dteEnd.EditValue), "d-MMM-yyyy")

                            _rptName = rept

                    End Select

                    _rptName.DataSource = objDT


                    _rptName.CreateDocument()

                    DocumentViewer.DocumentSource = _rptName

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using

    End Sub


End Class