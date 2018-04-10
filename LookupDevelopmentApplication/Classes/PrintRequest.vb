Imports System.Data
Imports System.Data.SqlClient
Imports System.String
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.text

Public Class PrintRequest
    Private rptDocument As New ReportDocument
    Private mdlCSRNumber As Integer

    Public WriteOnly Property CSRNO() As Integer
        Set(ByVal value As Integer)
            mdlCSRNumber = value
        End Set
    End Property


    Public Sub PrintReport()
        Loadreport()
    End Sub

    Private Sub Loadreport()
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in Loadreport routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RequestForBinReptData"
                        .Parameters.Add("@CSRNO", SqlDbType.Int).Value = mdlCSRNumber
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in Loadreport routine ")
            End Try
        End Using
        Dim strReportName As String

        Try
            strReportName = "DomesticBinsRequests.rpt"

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & strReportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDT)
                .VerifyDatabase()
            End With


            rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "c:\records\" & mdlCSRNumber.ToString & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function LoadReport")
        Finally
        End Try

    End Sub




End Class
