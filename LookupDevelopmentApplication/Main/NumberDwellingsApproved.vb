Imports System.Data.SqlClient

Public Class NumberDwellingsApproved


    Private Sub LoadData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_NumberOfDwellingsApproved"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvApproval.DataSource = objDT
                    dgvApproval.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadData routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()
    End Sub
End Class