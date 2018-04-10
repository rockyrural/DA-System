
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI

Public Class reportSetupApprovalsByOfficer
    Private ErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

    Private _Type As String

    Public WriteOnly Property ReportType() As String
        Set(ByVal value As String)
            _Type = value
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

        LoadOfficerList()

        dtpFromDate.EditValue = DateAdd(DateInterval.Day, -30, Today.Date)
        dtpToDate.EditValue = Today.Date

    End Sub

    Private Sub LoadOfficerList()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficerList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ListOfficersForReportSelection"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    cboOfficer.DataSource = objDT
                    cboOfficer.DisplayMember = "Officer"
                    cboOfficer.ValueMember = "OfficerId"

                    Dim col2 As LookUpColumnInfoCollection = cboOfficer.Columns
                    col2.Add(New LookUpColumnInfo("Officer", 0))
                    col2.Add(New LookUpColumnInfo("OfficerId", 0))
                    col2.Item(1).Visible = False


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficerList routine - form " & Me.Name)

            End Try
        End Using

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
                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@OFFICERID", SqlDbType.Int).Value = CInt(lupOfficer.EditValue)


                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "Approvals")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\CCapprovals.xsd")



                End Using


                Select Case _Type

                    Case "ApprovalsByOfficer"

                        Dim rept As New ApprovalsByOfficer

                        rept.DataSource = objDT

                        rept.lblTitle.Text = "Number DA's Determined " & Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")

                        rept.CreateDocument()

                        DocumentViewer.DocumentSource = rept

                    Case "ConstructionCertificatesByOfficer"

                        Dim rept As New ConstructionCertificatesByOfficer

                        rept.lblTitle.Text = "Number CC's Determined " & Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy") & " to " & Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")

                        rept.DataSource = objDT
                        rept.CreateDocument()

                        DocumentViewer.DocumentSource = rept

                End Select






            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try


        End Using
    End Sub



    Private Sub btnCreate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreate.ItemClick

        If DateDiff(DateInterval.Day, CDate(dtpFromDate.EditValue), CDate(dtpToDate.EditValue)) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

            PrintTheReport()

        End If

    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
End Class