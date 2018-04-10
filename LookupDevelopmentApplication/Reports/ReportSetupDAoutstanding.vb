Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports ADHelpr = ADHelper.ADHelper



Public Class ReportSetupDAoutstanding
    Private rptDocument As New ReportDocument
    Private LOCALRECORDFOLDER As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"
    Private ADHelper As New ADHelpr


    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private Function NotCompleted() As Boolean
        Dim result As Boolean = True



        If Me.cboType.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboType, "You MUST select an officer")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboType, "")

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
        'If Not NotCompleted() Then Exit Sub

        If DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            PrintTheReport()
            'Me.btnEmail.Enabled = True
            'Me.Close()
        End If
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
                        .CommandText = "usp_rpt_DAAddr"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@TYPE", SqlDbType.TinyInt).Value = CInt(cboType.SelectedValue)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "DAAddr.rpt"
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
        Me.DAAppTypeTableAdapter.Fill(Me.DAdatasets.DAAppType)
        cboType.SelectedIndex = -1
        dtpFromDate.Value = DateAdd(DateInterval.Day, -7, Today.Date)

    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click

        Dim objDT As New DataTable

        If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
            FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
        End If

        rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\DAReg.pdf")


        Dim sBodyOfMsg As String = "Development Applications Register"

        Dim emails As String = GetEmailAddress()

        Dim WebMails() As String = Split(emails, "|")

        'Dim mailaddress As String = ADHelper.GetEmailAddress(ADHelper.GetLoginName)

        'MailHelper.MailHelper.SendMailMessage(mailaddress, WebMails(0) & ";", "", WebMails(1), "DA Register", sBodyOfMsg, LOCALRECORDFOLDER & "\DAReg.pdf")

        Dim OutlookHlp As New OutlookHelper

        OutlookHlp.SendMail(WebMails(0), "", WebMails(1), "DA Register", sBodyOfMsg, LOCALRECORDFOLDER & "\DAReg.pdf")




        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEmailAddress routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetReportEmails"
                        .ExecuteNonQuery()
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using
                 

                For Each objDR As DataRow In objDT.Rows
                   OutlookHlp.SendMail(objDR(0) & "@eurocoast.nsw.gov.au;", "", "", "DA Register", sBodyOfMsg, LOCALRECORDFOLDER & "\DAReg.pdf")

                    'MailHelper.MailHelper.SendMailMessage(mailaddress, objDR(0) & "@eurocoast.nsw.gov.au;", "", "", "DA Register", sBodyOfMsg, LOCALRECORDFOLDER & "\DAReg.pdf")
                Next

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEmailAddress routine - form " & Me.Name)

            End Try
        End Using



        MessageBox.Show("A PDF file has been created in " & LOCALRECORDFOLDER & "\DAReg.pdf and has been emailed for upload to WEB", "DA Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Function GetEmailAddress() As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEmailAddress routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetWebMasterEmails"
                        .Parameters.Add("@WEBMASTER", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output
                        .Parameters.Add("@SECWEB", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@WEBMASTER").Value.ToString & "@eurocoast.nsw.gov.au|" & .Parameters("@SECWEB").Value.ToString & "@eurocoast.nsw.gov.au"

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEmailAddress routine - form " & Me.Name)

            End Try
        End Using




        Return result
    End Function

End Class