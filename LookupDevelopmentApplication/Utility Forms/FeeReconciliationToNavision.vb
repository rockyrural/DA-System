
Imports EXCEL = Microsoft.Office.Interop.Excel
Imports System.IO


Imports system.data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class FeeReconciliationToNavision

    Private Sub FeeReconciliationToNavision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadUpPaymentComboBoxTableAdapter.Fill(Me.CZONES.LoadUpPaymentComboBox)
        Me.cboLoadUpPayment.EditValue = Nothing

        Dim col2 As LookUpColumnInfoCollection = cboLoadUpPayment.Properties.Columns
        col2.Add(New LookUpColumnInfo("Payment", 0))
        col2.Add(New LookUpColumnInfo("PaymentId", 0))

        col2.Item(1).Visible = False
    End Sub

    Private Sub btnNavision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavision.Click
        Dim x As Integer = Shell("C:\Program Files\Microsoft Dynamics NAV\CSIDE Client\FINSQL.EXE")

    End Sub

    Private Sub btnSpreadSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpreadSheet.Click


        InsertReconciliationParams()

        If Not ImportCSVData() Then Exit Sub


        Dim r As Integer
        Dim c As Integer = 1

        Me.Cursor = Cursors.WaitCursor



        Dim xlApp As EXCEL.Application
        Dim xlBook As EXCEL.Workbook
        Dim xlsheet As EXCEL.Worksheet
        Dim objSheets As EXCEL.Sheets


        Dim objDt As DataTable
        Dim currentfield As String = String.Empty


        Try
            xlApp = New EXCEL.Application
            xlBook = xlApp.Workbooks.Add("\\fs\common\db\development\lsl_templatenew.xlt")
            'xlApp.Visible = True
            xlBook.Activate()
            objSheets = xlBook.Sheets
            xlsheet = CType(objSheets.Item(2), EXCEL.Worksheet)


            objDt = NavisionReqQry()

            Dim j As Integer = 5

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 8
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            xlsheet.Cells(2, 2) = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
            xlsheet.Cells(2, 4) = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")


            xlsheet = CType(objSheets.Item(3), EXCEL.Worksheet)

            objDt = LSL_DA_Tran()

            j = 5

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 24
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next


            xlsheet.Cells(1, 16) = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
            xlsheet.Cells(1, 22) = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")


            xlsheet.Cells(j + 1, 7) = "Refunds:"
            xlsheet.Cells(j + 1, 17) = "Cheque No.:"

            objDt = LSL_DARefundsFullDetails()

            j += 2


            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 24
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            xlsheet = CType(objSheets.Item(1), EXCEL.Worksheet)

            objDt = NavRegQryWithoutMatchingLSL_DA_Trans_XL()

            j = 16

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 4
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next


            objDt = LSL_Duplicates()

            j += 6

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 5
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            objDt = LSL_DA_TRANS()

            j += 6

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 5
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next



            objDt = LSL_DA_REFUNDS()

            j += 5

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 5
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            xlsheet = CType(objSheets.Item(4), EXCEL.Worksheet)


            objDt = NAVISION_LSL_MATCHES()


            j = 3

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 11
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            xlApp.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in NavisionReqQry routine - form " & Me.Name)
        End Try



        Me.Cursor = Cursors.Default


    End Sub
    Private Sub InsertReconciliationParams()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertReconciliationParams routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertReconciliationParameters"

                        .Parameters.Add("@PARAMNO", SqlDbType.Int).Value = CInt(cboLoadUpPayment.EditValue)
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)
                        .Parameters.Add("@GST", SqlDbType.Bit).Value = chkGST.CheckState
                        .ExecuteNonQuery()

                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertReconciliationParams routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function NAVISION_LSL_MATCHES() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavRegQryWithoutMatchingLSL_DA_Trans_XL routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_NavisionLSLMatches"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavRegQryWithoutMatchingLSL_DA_Trans_XL routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function


    Private Function NavRegQryWithoutMatchingLSL_DA_Trans_XL() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavRegQryWithoutMatchingLSL_DA_Trans_XL routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_NavRegWithoutMatchingLSL_DA_Trans_XL"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavRegQryWithoutMatchingLSL_DA_Trans_XL routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function

    Private Function LSL_DA_REFUNDS() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_REFUNDS routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_DA_REfunds"
                        .Parameters.Add("@PARAMNO", SqlDbType.Int).Value = CInt(cboLoadUpPayment.EditValue)
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_REFUNDS routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function


    Private Function LSL_DA_TRANS() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_TRANS routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_TRANSwithoutMatchingNavRegQry"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_TRANS routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function

    Private Function LSL_Duplicates() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_Duplicates routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_DuplicatesExcel"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_Duplicates routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function


    Private Function LSL_DARefundsFullDetails() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DARefundsFullDetails routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_DA_REFUNDS_FullDetails"
                        .Parameters.Add("@PARAMNO", SqlDbType.Int).Value = CInt(cboLoadUpPayment.EditValue)
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DARefundsFullDetails routine - form " & Me.Name)

            End Try
        End Using



        Return result
    End Function

    Private Function LSL_DA_Tran() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_Tran routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_DA_Trans"
                        .Parameters.Add("@PARAMNO", SqlDbType.Int).Value = CInt(cboLoadUpPayment.EditValue)
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_DA_Tran routine - form " & Me.Name)

            End Try
        End Using



        Return result
    End Function



    Private Function NavisionReqQry() As DataTable
        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavisionReqQry routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Navision_Req_Qry"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in NavisionReqQry routine - form " & Me.Name)

            End Try
        End Using



        Return result
    End Function

    Private Function ImportCSVData() As Boolean


        Dim filereader As System.IO.StreamReader
        Dim line As String
        Dim words() As String
        Dim test() As String = {""","""}
        Dim result As Boolean = True
        Dim delimiter As Char = ","c

        Dim TheDate As Date 

        Try

            RemoveOldRegisterData()


            filereader = My.Computer.FileSystem.OpenTextFileReader("c:\fees\registers.csv")
            line = filereader.ReadLine()

            Do While Not line Is Nothing

                words = line.Split(delimiter)

                If words(0).Length <= 10  Then

                    TheDate =cdate(words(0))

               Else
                    TheDate =cdate(words(0).Substring(0,9))
                        
                End If

                InsertRowIntoRegister(theDate, words(3).ToString, words(5).ToString, CDbl(words(11)))

                line = filereader.ReadLine()




            Loop
            filereader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in btnReferral_Click routine ")
            result = False
        End Try

        Return result

    End Function
    Private Sub RemoveOldRegisterData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldRegisterData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOldRegisterData"
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldRegisterData routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub InsertRowIntoRegister(ByVal theDate As Date, ByVal description As String, ByVal jobNo As String, ByVal Amount As Double)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRowIntoRegister routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertValueIntoRegister"

                        .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = theDate
                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = description
                        .Parameters.Add("@JOBNO", SqlDbType.NVarChar).Value = jobNo
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = Amount
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRowIntoRegister routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnCreateLSLreturnHardCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateLSLreturnHardCopy.Click
        Dim xlApp As EXCEL.Application
        Dim xlBook As EXCEL.Workbook
        Dim xlsheet As EXCEL.Worksheet
        Dim objSheets As EXCEL.Sheets
        Dim r As Integer
        Dim c As Integer


        Dim objDt As DataTable
        Dim currentfield As String = String.Empty


        Try
            xlApp = New EXCEL.Application
            xlBook = xlApp.Workbooks.Add("\\fs\common\db\development\lsl_template.xlt")
            xlApp.Visible = True
            xlBook.Activate()
            objSheets = xlBook.Sheets
            xlsheet = CType(objSheets.Item(1), EXCEL.Worksheet)


            objDt = NAVISION_LSL_MATCHES()

            Dim j As Integer = 5

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 8
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next

            xlsheet.Cells(2, 2) = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
            xlsheet.Cells(2, 4) = Format(CDate(dtpToDate.EditValue), "dd/MM/yyyy")




        Catch ex As Exception
            MessageBox.Show(ex.Message, " in btnCreateLSLreturnHardCopy_Click routine - form " & Me.Name)
        End Try



        Me.Cursor = Cursors.Default


    End Sub

    Private Sub btnCreateLSLreturnElectronic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateLSLreturnElectronic.Click
        Dim xlApp As EXCEL.Application
        Dim xlBook As EXCEL.Workbook
        Dim xlsheet As EXCEL.Worksheet
        Dim objSheets As EXCEL.Sheets
        Dim r As Integer
        Dim c As Integer


        Dim objDt As DataTable
        Dim currentfield As String = String.Empty


        Try
            xlApp = New EXCEL.Application
            xlBook = xlApp.Workbooks.Add(My.Settings.LSLtemplate)
            xlApp.Visible = True
            xlBook.Activate()
            objSheets = xlBook.Sheets
            xlsheet = CType(objSheets.Item(2), EXCEL.Worksheet)
            xlsheet.Activate()

            objDt = LSL_ElectronicReturn()

            Dim j As Integer = 6

            For r = 0 To objDt.Rows.Count - 1
                'xlsheet.Rows(j + 1).Insert()
                For c = 0 To 3
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                xlsheet.Cells(j, 9) = objDt.Rows(r).Item(10).ToString
                xlsheet.Cells(j, 10) = objDt.Rows(r).Item(9).ToString
                j += 1
            Next

            'xlsheet.Cells(1, 10) = Format(CDate(dtpFromDate.Value), "dd/MM/yyyy")

            'xlsheet.Rows(j).Delete()


        Catch ex As Exception
            MessageBox.Show(ex.Message, " in btnCreateLSLreturnElectronic_Click routine - form " & Me.Name)
        End Try



        Me.Cursor = Cursors.Default

    End Sub

    Private Function LSL_ElectronicReturn() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_ElectronicReturn routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LSL_ElectronicReturn"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_ElectronicReturn routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function

    Private Sub btnPlanningNSW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanningNSW.Click

        InsertReconciliationParams()

        Dim xlApp As EXCEL.Application
        Dim xlBook As EXCEL.Workbook
        Dim xlsheet As EXCEL.Worksheet
        Dim objSheets As EXCEL.Sheets
        Dim r As Integer
        Dim c As Integer


        Dim objDt As DataTable
        Dim currentfield As String = String.Empty


        Try






            xlApp = New EXCEL.Application
            xlBook = xlApp.Workbooks.Add()
            xlApp.Visible = True
            xlBook.Activate()
            objSheets = xlBook.Sheets
            xlsheet = CType(objSheets.Item(1), EXCEL.Worksheet)


            objDt = LSL_PLANNINGNSWFEE()

            Dim j As Integer = 1

            For r = 0 To objDt.Rows.Count - 1
                xlsheet.Rows(j + 1).Insert()
                For c = 0 To 5
                    currentfield = objDt.Rows(r).Item(c).ToString
                    xlsheet.Cells(j, c + 1) = currentfield
                Next
                j += 1
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, " in btnPlanningNSW_Click routine - form " & Me.Name)
        End Try



        Me.Cursor = Cursors.Default

    End Sub

    Private Function LSL_PLANNINGNSWFEE() As DataTable

        Dim result As DataTable = Nothing


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_PLANNINGNSWFEE routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_NSWPlanFees"
                        .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(dtpFromDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = CDate(dtpToDate.EditValue)

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    result = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LSL_PLANNINGNSWFEE routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function
End Class