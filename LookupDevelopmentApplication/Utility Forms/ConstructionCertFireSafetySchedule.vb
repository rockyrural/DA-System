Imports system.data.sqlclient
Public Class ConstructionCertFireSafetySchedule

    Private AppID As String

    Public WriteOnly Property CCappNumber() As String
        Set(ByVal value As String)
            AppID = value
            Me.lblCCappID.Text = value
        End Set
    End Property


    Private Sub RemoveOldSchedules()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldSchedules routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_FireSchedules"

                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = AppID
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldSchedules routine - form " & Me.Name)

            End Try
        End Using




    End Sub
    Private Sub SaveSchedule()

        If Me.txtSchedule.Text = String.Empty Then Exit Sub


        Dim schedules() As String = txtSchedule.Text.Trim.Split(vbCrLf)


        RemoveOldSchedules()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveSchedule routine - form " & Me.Name)

            End Try


            Try
                For i As Integer = 0 To UBound(schedules)
                    If schedules(i).Trim <> String.Empty Then
                        Dim SchedItem As String = schedules(i).Trim

                        Using cmd As New SqlCommand


                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_Insert_FireSafetySchedule"

                                .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = AppID
                                .Parameters.Add("@SCHEDULE", SqlDbType.NVarChar).Value = SchedItem 'Me.txtSchedule.Text
                                .ExecuteNonQuery()
                            End With


                        End Using
                    End If

                Next
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveSchedule routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    
    Private Sub ConstructionCertFireSafetySchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForExistingCondition()
    End Sub

    Private Sub CheckForExistingCondition()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForExistingCondition routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckForExistingFireConditions"

                        .Parameters.Add("@CCID", SqlDbType.NVarChar).Value = AppID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        'Dim objDataRow As DataRow = objDT.Rows.Item(0)
                        Dim sched As String = String.Empty
                        For Each rowObjt As DataRow In objDT.Rows
                            sched &= rowObjt.Item("Conditions").ToString & vbCrLf

                        Next

                        Me.txtSchedule.Text = sched ' objDataRow.Item("Conditions").ToString

                    End If

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForExistingCondition routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveSchedule()
        DialogResult=DialogResult.OK
    End Sub
End Class