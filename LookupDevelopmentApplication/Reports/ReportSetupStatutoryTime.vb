Imports system.data.sqlclient
Public Class ReportSetupStatutoryTime

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If DateDiff(DateInterval.Day, dtpFromDate.Value, dtpToDate.Value) <= 0 Then
            MessageBox.Show("The 'From' date MUST be less then the 'To' date", "Incorrect dates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            CalculateData()
        End If

    End Sub

    Private Sub CalculateData()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_StatutoryTime"

                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
                        .Parameters.Add("@SATIS", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@UNSATIS", SqlDbType.Int).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()

                        lblSatis.Text = .Parameters("@SATIS").Value.ToString
                        lblUnSatis.Text = .Parameters("@UNSATIS").Value.ToString


                    End With


                End Using
                 

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctCalculateDataionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

End Class