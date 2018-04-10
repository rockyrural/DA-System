Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class ApprovalsReportViewer

    Private errorProvider As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider


    Private _rptName As DevExpress.XtraReports.UI.XtraReport
    Public WriteOnly Property reportName() As DevExpress.XtraReports.UI.XtraReport

        Set(ByVal value As DevExpress.XtraReports.UI.XtraReport)
            _rptName = value
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

        LoadTypeForDAReport()

        dteStart.EditValue = CDate(DateAdd(DateInterval.Day, -7, Today.Date))
        dteEnd.EditValue = Today.Date

    End Sub


    Private Sub LoadTypeForDAReport()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadTypeForDAReport routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT DAAppTypeId, DAAppType FROM DAAppType"



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With lupType

                        .DataSource = objDT
                        .DisplayMember = "DAAppType"
                        .ValueMember = "DAAppTypeId"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = lupType.Columns
                    col2.Add(New LookUpColumnInfo("DAAppType", 0))
                    col2.Add(New LookUpColumnInfo("DAAppTypeId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadTypeForDAReport routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub PrintReport()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintReport routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = SprocName

                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dteStart.EditValue), "yyyy-MM-dd")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dteEnd.EditValue), "yyyy-MM-dd")

                        Select Case SprocName

                            Case "usp_rpt_DAAddr"

                                If cboType.EditValue Is Nothing Then

                                    .Parameters.Add("@TYPE", SqlDbType.TinyInt).Value = 0

                                Else

                                    .Parameters.Add("@TYPE", SqlDbType.TinyInt).Value = CInt(cboType.EditValue)

                                End If



                            Case Else 'do nothing


                        End Select

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "CCAppd")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\DAreceived.xsd")



                    _rptName.DataSource = objDT


                    _rptName.CreateDocument()

                    DocumentViewer.DocumentSource = _rptName


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintReport routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnBuildReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuildReport.ItemClick

        If dteEnd.EditValue Is Nothing OrElse dteStart.EditValue Is Nothing Then

            MessageBox.Show("Start and End Dates are required", "DATES REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

        If DateDiff(DateInterval.Day, CDate(dteStart.EditValue), CDate(dteEnd.EditValue)) < 0 Then

            MessageBox.Show("End Date must be greater then Start Date", "DATES REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return


        End If

        'Select Case SprocName

        '    Case "usp_rpt_DAAddr"

        '        If cboType.EditValue Is Nothing Then

        '            MessageBox.Show("You need to select a report type", "REPORT TYPE", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '            Return

        '        End If



        '    Case Else 'do nothing


        'End Select

        PrintReport()

    End Sub

    Private Sub ApprovalsReportViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case SprocName

            Case "usp_rpt_DAAddr" : cboType.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Case Else : cboType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        End Select

    End Sub
End Class