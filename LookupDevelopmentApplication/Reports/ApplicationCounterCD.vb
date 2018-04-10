Imports system.data.sqlclient
Imports System.Math
Public Class ApplicationCounterCD

    Private FromDate As Date
    Private ToDate As Date = Today.Date

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Sub btnCurCY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurCY.Click
        FromDate = DateSerial(Year(Today.Date), 1, 1)
        ToDate = Today.Date
        CalculateData()
    End Sub

    Private Sub btnLastQtr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLastQtr.Click

        Select Case DatePart(DateInterval.Quarter, Today.Date)
            Case 1
                FromDate = DateSerial(Year(Today.Date) - 1, 10, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 12, 31)
            Case 2
                FromDate = DateSerial(Year(Today.Date), 1, 1)
                ToDate = DateSerial(Year(Today.Date), 3, 31)

            Case 3
                FromDate = DateSerial(Year(Today.Date), 4, 1)
                ToDate = DateSerial(Year(Today.Date), 6, 30)

            Case Else
                FromDate = DateSerial(Year(Today.Date), 7, 1)
                ToDate = DateSerial(Year(Today.Date), 9, 30)

        End Select

        CalculateData()
    End Sub

    Private Sub btnPrevQtr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevQtr.Click
        Select Case DatePart(DateInterval.Quarter, Today.Date)

            Case 2
                FromDate = DateSerial(Year(Today.Date) - 1, 10, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 12, 31)
            Case 3
                FromDate = DateSerial(Year(Today.Date), 1, 1)
                ToDate = DateSerial(Year(Today.Date), 3, 31)

            Case 4
                FromDate = DateSerial(Year(Today.Date), 4, 1)
                ToDate = DateSerial(Year(Today.Date), 6, 30)

            Case Else
                FromDate = DateSerial(Year(Today.Date) - 1, 7, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 9, 30)

        End Select

        CalculateData()
    End Sub

    Private Sub btnPrePrevQtr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrePrevQtr.Click
        Select Case DatePart(DateInterval.Quarter, Today.Date)


            Case 1
                FromDate = DateSerial(Year(Today.Date) - 1, 4, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 6, 30)
            Case 3
                FromDate = DateSerial(Year(Today.Date) - 1, 10, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 12, 31)
            Case 4
                FromDate = DateSerial(Year(Today.Date), 1, 1)
                ToDate = DateSerial(Year(Today.Date), 3, 31)

            Case Else
                FromDate = DateSerial(Year(Today.Date) - 1, 7, 1)
                ToDate = DateSerial(Year(Today.Date) - 1, 9, 30)

        End Select

        CalculateData()
    End Sub

    Private Sub btnCurFY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurFY.Click

        If Today.Month > 6 Then
            FromDate = DateSerial(Year(Today.Date), 7, 1)
        Else
            FromDate = DateSerial(Year(Today.Date) - 1, 7, 1)
        End If
        ToDate = Today.Date

        CalculateData()
    End Sub

    Private Sub btnLastFY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLastFY.Click
        If Today.Month > 6 Then
            FromDate = DateSerial(Year(Today.Date) - 1, 7, 1)
            ToDate = DateAdd(DateInterval.Day, -1, DateSerial(Year(Today.Date), 7, 1))
        Else
            FromDate = DateSerial(Year(Today.Date) - 2, 7, 1)
            ToDate = DateAdd(DateInterval.Day, -1, DateSerial(Year(Today.Date) - 1, 7, 1))
        End If

        CalculateData()
    End Sub

    Private Sub btnLastCY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastCY.Click
        FromDate = DateSerial(Year(Today.Date) - 1, 1, 1)
        ToDate = DateSerial(Year(Today.Date) - 1, 12, 31)
        CalculateData()
    End Sub

    Private Sub btnCurQtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurQtr.Click
        Select Case DatePart(DateInterval.Quarter, Today.Date)


            Case 1
                FromDate = DateSerial(Year(Today.Date), 1, 1)
            Case 2
                FromDate = DateSerial(Year(Today.Date), 4, 1)
            Case 3
                FromDate = DateSerial(Year(Today.Date), 7, 1)

            Case Else
                FromDate = DateSerial(Year(Today.Date), 10, 1)

        End Select
        ToDate = Today.Date

        CalculateData()

    End Sub

    Private Sub btnSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelected.Click
        FromDate = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")
        ToDate = Format(CDate(dtpToDate.Value), "dd/MM/yyyy")
        CalculateData()
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
                        .CommandText = "usp_ApplicationCountersCD"

                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(FromDate, "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(ToDate, "dd/MM/yyyy")
                        .Parameters.Add("@B1", SqlDbType.Int).Value = NZ(lblTargetD1.Text)
                        .Parameters.Add("@B2", SqlDbType.Int).Value = NZ(lblTargetD2.Text)
                        .Parameters.Add("@B3", SqlDbType.Int).Value = NZ(lblTargetD3.Text)
                        .Parameters.Add("@C1", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C2", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C3", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C4", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C5", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C6", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@C7", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D1", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D2", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D3", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D4", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D5", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@D6", SqlDbType.Int).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()

                        lblTot1.Text = .Parameters("@C1").Value.ToString
                        lblTot2.Text = .Parameters("@C2").Value.ToString
                        lblTot3.Text = .Parameters("@C3").Value.ToString
                        lblTot4.Text = .Parameters("@C4").Value.ToString
                        lblTot5.Text = .Parameters("@C5").Value.ToString
                        lblTot6.Text = .Parameters("@C6").Value.ToString
                        lblTot7.Text = .Parameters("@C7").Value.ToString
                        lblD1.Text = .Parameters("@D1").Value.ToString
                        lblD2.Text = .Parameters("@D2").Value.ToString
                        lblD3.Text = .Parameters("@D3").Value.ToString
                        lblD4.Text = .Parameters("@D4").Value.ToString
                        lblD5.Text = .Parameters("@D5").Value.ToString
                        lblD6.Text = .Parameters("@D6").Value.ToString

                    End With

                    If NZ(lblTot1.Text) > 0 Then
                        lblP1.Text = Round(100 * lblD1.Text / lblTot1.Text)
                    End If
                    If NZ(lblTot2.Text) > 0 Then
                        lblP2.Text = Round(100 * lblD2.Text / lblTot2.Text)
                    End If
                    If NZ(lblTot3.Text) > 0 Then
                        lblP3.Text = Round(100 * lblD3.Text / lblTot3.Text)
                    End If
                    If NZ(lblTot4.Text) > 0 Then
                        lblP4.Text = Round(100 * lblD4.Text / lblTot4.Text)
                    End If
                    If NZ(lblTot5.Text) > 0 Then
                        lblP5.Text = Round(100 * lblD5.Text / lblTot5.Text)
                    End If
                    If NZ(lblTot6.Text) > 0 Then
                        lblP6.Text = Round(100 * lblD6.Text / lblTot6.Text)
                    End If


                End Using
                 

                Me.dtpFromDate.Value = Format(FromDate, "dd/MM/yyyy")
                Me.dtpToDate.Value = Format(ToDate, "dd/MM/yyyy")

                lblNoDays.Text = (DateDiff(DateInterval.Day, FromDate, ToDate) + 1).ToString


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctCalculateDataionName routine - form " & Me.Name)

            End Try
        End Using
    End Sub

End Class