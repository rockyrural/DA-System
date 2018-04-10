Imports System.IO


Imports system.data.sqlclient
Public Class ABSReportSetup


    Private Sub btnABSstats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABSstats.Click

        Dim swOut As New StreamWriter("c:\temp\abs.txt", False)
        Dim LineToWrite As String = String.Empty


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnABSstats_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_abs"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Me.dtpDateFrom.Value
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Me.dtpFromTo.Value
                    End With

                    Dim objDT As New DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            LineToWrite = objDataReader.Item(0).ToString & objDataReader.Item(1).ToString.PadRight(4) & objDataReader.Item(2).ToString.PadRight(4) & objDataReader.Item(3).ToString.PadRight(20) & objDataReader.Item(4).ToString.PadRight(2) & _
                            objDataReader.Item(5).ToString.PadRight(1) & Format(CDate(objDataReader.Item(6)), "dd/MM/yyyy") & objDataReader.Item(7).ToString.PadRight(7) & objDataReader.Item(8).ToString.PadRight(3) & objDataReader.Item(9).ToString.PadRight(4) & _
                            objDataReader.Item(10).ToString.PadRight(20) & objDataReader.Item(11).ToString.PadRight(8) & objDataReader.Item(12).ToString.PadRight(10) & objDataReader.Item(13).ToString.PadRight(30) & objDataReader.Item(14).ToString.PadRight(30) & _
                            objDataReader.Item(15).ToString.PadRight(4) & objDataReader.Item(16).ToString.PadRight(4) & objDataReader.Item(17).ToString.PadRight(1) & objDataReader.Item(18).ToString.PadRight(1) & objDataReader.Item(19).ToString.PadRight(3) & _
                            objDataReader.Item(20).ToString.PadRight(250) & objDataReader.Item(21).ToString.PadRight(3) & objDataReader.Item(22).ToString.PadRight(2) & objDataReader.Item(23).ToString.PadRight(2) & objDataReader.Item(24).ToString.PadRight(2) & _
                            objDataReader.Item(25).ToString.PadRight(2) & objDataReader.Item(26).ToString.PadRight(6) & objDataReader.Item(27).ToString.PadRight(6) & Format(objDataReader.Item(28), "##########0").PadRight(10) & objDataReader.Item(29).ToString.PadRight(1) & _
                            objDataReader.Item(30).ToString.PadRight(1) & objDataReader.Item(31).ToString.PadRight(1) & objDataReader.Item(32).ToString.PadRight(2) & objDataReader.Item(33).ToString.PadRight(3) & objDataReader.Item(34).ToString.PadRight(8) & _
                            objDataReader.Item(35).ToString.PadRight(50) & objDataReader.Item(36).ToString.PadRight(10) & objDataReader.Item(37).ToString.PadRight(100) & objDataReader.Item(38).ToString.PadRight(30) & objDataReader.Item(39).ToString.PadRight(4) & _
                            objDataReader.Item(40).ToString.PadRight(14) & objDataReader.Item(41).ToString.PadRight(36) & objDataReader.Item(42).ToString.PadRight(10) & objDataReader.Item(43).ToString.PadRight(36) & objDataReader.Item(44).ToString.PadRight(30) & _
                            objDataReader.Item(45).ToString.PadRight(4) & objDataReader.Item(46).ToString.PadRight(14) & objDataReader.Item(47).ToString.PadRight(10) & objDataReader.Item(48).ToString.PadRight(10) & objDataReader.Item(49).ToString.PadRight(6) & _
                            objDataReader.Item(50).ToString.PadRight(6) & objDataReader.Item(51).ToString.PadRight(6) & objDataReader.Item(52).ToString.PadRight(20) & objDataReader.Item(53).ToString.PadRight(10) & objDataReader.Item(54).ToString.PadRight(10) & _
                            objDataReader.Item(55).ToString.PadRight(19) & objDataReader.Item(56).ToString.PadRight(20)
                            swOut.WriteLine(LineToWrite)
                        Loop

                    End Using

                    swOut.Close()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnABSstats_Click routine - form " & Me.Name)

            End Try
        End Using
        lblStatus.Text = "Finished" & vbCrLf & "Please find the Statistics in the file" & vbCrLf & "c:\temp\abs.txt" & vbCrLf & "Lodge as per IT Procedures"


    End Sub

    Private Sub ABSReportSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dtpDateFrom.Value = DateSerial(Year(Today.AddMonths(-3)), Month(Today.AddMonths(-3)), 1)
        Me.dtpFromTo.Value = DateAdd(DateInterval.Day, -1, DateSerial(Today.Year, Today.Month, 1))
    End Sub

    Private Sub btnConRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConRes.Click
        Dim swOut As New StreamWriter("c:\temp\absCRW.txt", False)
        Dim LineToWrite As String = String.Empty


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnABSstats_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_absCRW"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Me.dtpDateFrom.Value
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Me.dtpFromTo.Value
                    End With

                    Dim objDT As New DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            LineToWrite = objDataReader.Item(0).ToString & objDataReader.Item(1).ToString.PadRight(4) & objDataReader.Item(2).ToString.PadRight(4) & objDataReader.Item(3).ToString.PadRight(20) & objDataReader.Item(4).ToString.PadRight(2) & _
                            objDataReader.Item(5).ToString.PadRight(1) & Format(CDate(objDataReader.Item(6)), "dd/MM/yyyy") & objDataReader.Item(7).ToString.PadRight(7) & objDataReader.Item(8).ToString.PadRight(3) & objDataReader.Item(9).ToString.PadRight(4) & _
                            objDataReader.Item(10).ToString.PadRight(20) & objDataReader.Item(11).ToString.PadRight(8) & objDataReader.Item(12).ToString.PadRight(10) & objDataReader.Item(13).ToString.PadRight(30) & objDataReader.Item(14).ToString.PadRight(30) & _
                            objDataReader.Item(15).ToString.PadRight(4) & objDataReader.Item(16).ToString.PadRight(4) & objDataReader.Item(17).ToString.PadRight(1) & objDataReader.Item(18).ToString.PadRight(1) & objDataReader.Item(19).ToString.PadRight(3) & _
                            objDataReader.Item(20).ToString.PadRight(250) & objDataReader.Item(21).ToString.PadRight(3) & objDataReader.Item(22).ToString.PadRight(2) & objDataReader.Item(23).ToString.PadRight(2) & objDataReader.Item(24).ToString.PadRight(2) & _
                            objDataReader.Item(25).ToString.PadRight(2) & objDataReader.Item(26).ToString.PadRight(6) & objDataReader.Item(27).ToString.PadRight(6) & Format(objDataReader.Item(28), "##########0").PadRight(10) & objDataReader.Item(29).ToString.PadRight(1) & _
                            objDataReader.Item(30).ToString.PadRight(1) & objDataReader.Item(31).ToString.PadRight(1) & objDataReader.Item(32).ToString.PadRight(2) & objDataReader.Item(33).ToString.PadRight(3) & objDataReader.Item(34).ToString.PadRight(8) & _
                            objDataReader.Item(35).ToString.PadRight(50) & objDataReader.Item(36).ToString.PadRight(10) & objDataReader.Item(37).ToString.PadRight(100) & objDataReader.Item(38).ToString.PadRight(30) & objDataReader.Item(39).ToString.PadRight(4) & _
                            objDataReader.Item(40).ToString.PadRight(14) & objDataReader.Item(41).ToString.PadRight(36) & objDataReader.Item(42).ToString.PadRight(10) & objDataReader.Item(43).ToString.PadRight(36) & objDataReader.Item(44).ToString.PadRight(30) & _
                            objDataReader.Item(45).ToString.PadRight(4) & objDataReader.Item(46).ToString.PadRight(14) & objDataReader.Item(47).ToString.PadRight(10) & objDataReader.Item(48).ToString.PadRight(10) & objDataReader.Item(49).ToString.PadRight(6) & _
                            objDataReader.Item(50).ToString.PadRight(6) & objDataReader.Item(51).ToString.PadRight(6) & objDataReader.Item(52).ToString.PadRight(20) & objDataReader.Item(53).ToString.PadRight(10) & objDataReader.Item(54).ToString.PadRight(10) & _
                            objDataReader.Item(55).ToString.PadRight(19) & objDataReader.Item(56).ToString.PadRight(20)
                            swOut.WriteLine(LineToWrite)
                        Loop

                    End Using

                    swOut.Close()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnABSstats_Click routine - form " & Me.Name)

            End Try
        End Using
        lblStatus.Text = "Finished" & vbCrLf & "Please find the Statistics in the file" & vbCrLf & "c:\temp\absCRW.txt" & vbCrLf & "Lodge as per IT Procedures"

    End Sub
End Class