Imports System.Data.SqlClient

Module GlobalVariables
    Public Administration As Boolean = False
    Public GeneralMaint As Boolean = False
    Public Assessment As Boolean = False
    Public authority As Boolean = False
    Public SysAdmin As Boolean = False
    Public ViewOnly As Boolean = False
    Public UAT As Boolean = False
    Public AA As Boolean = False
    Public FullName As String = String.Empty
    Public ReferralMaint As Boolean = False
    Public sUserID As String
    Public MyUserId As Integer
    Public sAccessLevel As String

    Public Sub LockAccessIfViewOnly(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                If Not btn.Tag Is Nothing Then btn.Enabled = Not btn.Tag.ToString = "v"
            End If

            If ctrl.HasChildren Then
                LockAccessIfViewOnly(ctrl)
            End If

        Next


    End Sub

    Public Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()

        End Try


    End Sub


    Public Sub InsertComplianceRecordIntoDraftDocs(ByVal Appno As String, ByVal DocType As Integer, ByVal DraftDocPath As String, ByVal DocMth As String, ByVal docYear As Integer, ByVal OwnerName As String, ByVal OwnerAddress As String, ByVal FileNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_ComplianceCertificatesDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = Appno
                        .Parameters.Add("@PATH", SqlDbType.VarChar).Value = DraftDocPath
                        .Parameters.Add("@DATECREATED", SqlDbType.Date).Value = Today.Date
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = DocType
                        .Parameters.Add("@MTH", SqlDbType.VarChar).Value = DocMth
                        .Parameters.Add("@YEAR", SqlDbType.SmallInt).Value = docYear
                        .Parameters.Add("@FILENO", SqlDbType.VarChar).Value = FileNo
                        .Parameters.Add("@APPLICANT", SqlDbType.VarChar).Value = OwnerName
                        .Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = OwnerAddress
                        '.Parameters.Add("@TOWN", SqlDbType.VarChar).Value = Town
                        '.Parameters.Add("@POSTCODE", SqlDbType.VarChar).Value = DocMth
                        .ExecuteNonQuery()

                    End With


                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try
        End Using

    End Sub

End Module
