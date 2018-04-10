
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls


Public Class ReportSetupReferralsByOfficer
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        dtpFromDate.EditValue = DateAdd(DateInterval.Day, -30, Today.Date)
        dtpToDate.EditValue = Today.Date

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If dtpFromDate.EditValue Is Nothing OrElse dtpToDate.EditValue Is Nothing Then

            MessageBox.Show("You MUST Select both dates", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If

        If DateDiff(DateInterval.Day, CDate(dtpFromDate.EditValue), CDate(dtpToDate.EditValue)) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If cboReferralID.EditValue Is Nothing Then
            MessageBox.Show("You need to select a referral source", "Referral code required", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        .CommandText = "usp_rpt_ReferralsByOfficerandDate"
                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "yyyy-MM-dd")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.EditValue), "yyyy-MM-dd")
                        .Parameters.Add("@OFFICER", SqlDbType.Int).Value = CInt(cboReferralID.EditValue)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "OfficerReferral")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\OfficerReferral.xsd")


                End Using


                Dim rept As New ReferralsByOfficerAndDate

                With rept
                    .DataSource = objDT
                    .lblDateRange.Text = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")

                    .CreateDocument()

                End With

                DocumentViewer.DocumentSource = rept

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try
        End Using


    End Sub
    Private Sub ReportSetupReferralsByOfficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReferralCodeTableAdapter.Fill(Me.DAdatasets.ReferralCode)

        cboReferralID.Properties.ShowFooter = False
        cboReferralID.Properties.ShowHeader = False


        Dim col2 As LookUpColumnInfoCollection = cboReferralID.Properties.Columns
        col2.Add(New LookUpColumnInfo("ReferralCode", 0))
        col2.Add(New LookUpColumnInfo("ReferralCodeId", 0))
        col2.Item(1).Visible = False

    End Sub



End Class