Imports system.data.sqlclient
Public Class ApplicationCounter


    Private FromDate As Date
    Private ToDate As Date = Today.Date


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
                        .CommandText = "usp_ApplicationCounters"

                        .Parameters.Add("@START", SqlDbType.SmallDateTime).Value = Format(FromDate, "dd/MM/yyyy")
                        .Parameters.Add("@END", SqlDbType.SmallDateTime).Value = Format(ToDate, "dd/MM/yyyy")
                        .Parameters.Add("@DACOUNT", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@CCCOUNT", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@CDCOUNT", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@AACOUNT", SqlDbType.Int).Direction = ParameterDirection.Output




                        .ExecuteNonQuery()

                        lblDA.Text = .Parameters("@DACOUNT").Value.ToString
                        lblCC.Text = .Parameters("@CCCOUNT").Value.ToString
                        lblCD.Text = .Parameters("@CDCOUNT").Value.ToString
                        lblAA.Text = .Parameters("@AACOUNT").Value.ToString


                    End With


                End Using
                 

                Me.dtpFromDate.Value = Format(FromDate, "dd/MM/yyyy")
                Me.dtpToDate.Value = Format(ToDate, "dd/MM/yyyy")

                lblNoDays.Text = (DateDiff(DateInterval.Day, FromDate, ToDate) + 1).ToString


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctCalculateDataionName routine - form " & Me.Name)

            End Try
        End Using



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
End Class