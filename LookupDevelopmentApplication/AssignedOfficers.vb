Imports System.Data.SqlClient

Public Class AssignedOfficers

    Private _AppNo As String
    Public WriteOnly Property AppNo As String
        Set(ByVal value As String)
            _AppNo = value
        End Set
    End Property

    Private _sysRef As String
    Public WriteOnly Property sysRef As String
        Set(ByVal value As String)
            _sysRef = value
        End Set
    End Property

    Private Sub LoadAssignedOfficersList()

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAssignedOfficersList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_Assigned_Officers"

                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = _AppNo
                        .Parameters.Add("@SYSREF", SqlDbType.NVarChar).Value = _sysRef
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvOfficers.DataSource = objDT
                    dgvOfficers.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAssignedOfficersList routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub AssignedOfficers_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LoadAssignedOfficersList()
    End Sub
End Class