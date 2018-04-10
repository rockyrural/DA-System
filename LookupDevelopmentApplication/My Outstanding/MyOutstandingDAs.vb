Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
'Imports CrystalDecisions.CrystalReports
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared



Public Class MyOutstandingDAs

    'Private UserLANID As String = String.Empty
    'Public WriteOnly Property UserID As String
    '    Set(value As String)
    '        UserLANID = value
    '    End Set
    'End Property

    Private Loading As Boolean

    Private Sub MyOustandingDAs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'UserLANID = My.User.Name
        'UserLANID = "itd\adunne"

        Loading = True

        'Me.SelectOfficersTableAdapter.Fill(Me.DevelopmentSQLDataSet.SelectOfficers)
        LoadOfficersDropDown()
        'Me.cboOfficers.Text = GetUsersName(UserLANID.Substring(4))
        'MyOustandingDAs_LoadExtracted(UserLANID.Substring(4))

        Me.cboOfficers.Text = GetUsersName(sUserID)
        MyOustandingDAs_LoadExtracted(sUserID)

        Loading = False

        With btnPrint
            .Enabled = True
            .Tag = "DA"
            .Text = "Print my DAs list"
        End With


    End Sub

    Private Sub LoadOfficersDropDown()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SelectOfficers"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboOfficers

                        .DataSource = objDT
                        .DisplayMember = "Officer"
                        .ValueMember = "Networkuser"
                        .SelectedIndex = -1

                    End With
                    'dgvSales 'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub LoadOfficerStats(ByVal userid As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficerStats routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_IndividualOfficerOutstandingCount"

                        .Parameters.Add("@USERID", SqlDbType.VarChar).Value = userid
                    End With

                    Dim objDT As New System.Data.DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count <> 0 Then
                        Dim objRow As DataRow = objDT.Rows(0)
                        txt100.Text = objRow.Item(0).ToString
                        txt40.Text = objRow.Item(1).ToString
                        txt25.Text = objRow.Item(2).ToString
                        txtTotal.Text = objRow.Item(3).ToString
                    Else
                        txt100.Text = String.Empty
                        txt40.Text = String.Empty
                        txt25.Text = String.Empty
                        txtTotal.Text = String.Empty
                    End If





                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficerStats routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub MyOustandingDAs_LoadExtracted(ByVal UserID As String)


        Try
            LoadOfficerStats(UserID)
            Me.Usp_UserCurrentDAsTableAdapter.Fill(Me.DevelopmentSQLDataSet.usp_UserCurrentDAs, UserID)
            Me.ToDoListAdditionalInfoTableAdapter.Fill(Me.DevelopmentSQLDataSet.ToDoListAdditionalInfo, UserID)
            Me.ToDoListCCsTableAdapter.Fill(Me.TodoListData.ToDoListCCs, UserID)
            Me.ToDoListReferralsTableAdapter.Fill(Me.TodoListData.ToDoListReferrals, UserID)
            Me.Usp_ToDoListAAsTableAdapter.Fill(Me.TodoListData.usp_ToDoListAAs, UserID)

            loadAAReferralsList(UserID)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub loadAAReferralsList(ByVal UserID As String)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_AAReferalListByOfficerID"

                        .Parameters.Add("@USERID", SqlDbType.NVarChar).Value = UserID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    grdAAreferrals.DataSource = objDT
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function GetUsersName(ByVal UsersID As String) As String
        Dim result As String = String.Empty
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetUsersName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetOfficersNAme"

                        .Parameters.Add("@USERID", SqlDbType.VarChar).Value = UsersID
                        .Parameters.Add("@USERNAME", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@USERNAME").Value.ToString
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetUsersName routine - form " & Me.Name)

            End Try
        End Using



        Return result

    End Function


    Private Sub cboOfficers_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOfficers.SelectedValueChanged
        If Loading Then Exit Sub
        Try
            MyOustandingDAs_LoadExtracted(cboOfficers.SelectedValue.ToString)
            Me.btnPrint.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Public Sub New()
        Loading = True

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loading = False

    End Sub


    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    '    Dim r As Integer
    '    Dim c As Integer = 1
    '    Dim s As String

    '    Me.Cursor = Cursors.WaitCursor

    '    Dim xlApp As EXCEL.Application
    '    Dim xlBook As EXCEL._Workbook
    '    Dim objBooks As EXCEL.Workbooks
    '    Dim objSheets As EXCEL.Sheets
    '    Dim xlsheet As EXCEL._Worksheet

    '    xlApp = New EXCEL.Application
    '    objBooks = xlApp.Workbooks
    '    xlBook = objBooks.Add
    '    objSheets = xlBook.Worksheets

    '    xlsheet = CType(objSheets.Item(1), EXCEL._Worksheet)


    '    'xlApp = CType(CreateObject("Excel.Application"), _
    '    '        Microsoft.Office.Interop.Excel.Application)
    '    'xlBook = CType(xlApp.Workbooks.Add, _
    '    '      Microsoft.Office.Interop.Excel.Workbook)
    '    'xlsheet = CType(xlBook.Worksheets(1), _
    '    '      Microsoft.Office.Interop.Excel.Worksheet)

    '    'xlsheet.Application.Visible = True

    '    xlsheet.Cells.Select()

    '    xlsheet.Cells(1, 1).Value = "DANO"

    '    xlsheet.Range(


    '    xlsheet.Cells(1, 1).value = "DANO"
    '    xlsheet.Cells(1, 2).value = "Lapsed"
    '    xlsheet.Cells(1, 3).value = "DaysOver"
    '    xlsheet.Cells(1, 4).value = "Type"
    '    xlsheet.Cells(1, 5).value = "Location"
    '    xlsheet.Cells(1, 6).value = "Date Registered"
    '    xlsheet.Cells(1, 7).value = "Progress Comments"
    '    xlsheet.Cells(1, 8).value = "Preassessment Date"
    '    xlsheet.Cells(1, 9).value = "AI"


    '    Dim rc As Integer = 2

    '    For r = 0 To Usp_UserCurrentDAsDataGridView.Rows.Count - 1

    '        For c = 0 To Usp_UserCurrentDAsDataGridView.Rows(r).Cells.Count - 1

    '            s = Usp_UserCurrentDAsDataGridView.Rows(r).Cells(c).Value.ToString

    '            xlsheet.Cells(rc, c + 1).value = s

    '        Next

    '        rc = rc + 1

    '    Next
    '    Dim FileName As String
    '    If cboOfficers.SelectedIndex = -1 Then
    '        FileName = "Myoutstanding.xlsx"
    '    Else
    '        FileName = cboOfficers.Text & ".xlsx"
    '    End If

    '    xlsheet.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & FileName)
    '    xlApp.Quit()
    '    MessageBox.Show("An excel workbook has been created in your My Documents folder called " & FileName)
    '    Me.Cursor = Cursors.Default


    'End Sub








    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim rptDocument As New ReportDocument

        ''Pass the reportname to string variable 
        'Dim strReportPath As String = String.Empty

        'Select Case btnPrint.Tag
        '    Case "DA"
        '        strReportPath = My.Settings.ReportLocation & "mydas.rpt"
        '    Case "CC"
        '        strReportPath = My.Settings.ReportLocation & "MyCCs.rpt"

        '    Case "REFER"
        '        strReportPath = My.Settings.ReportLocation & "MyReferrals.rpt"

        '    Case "AA"
        '        strReportPath = My.Settings.ReportLocation & "myAAs.rpt"

        '    Case "AAREFER"
        '        strReportPath = My.Settings.ReportLocation & "myAAReferrals.rpt"

        'End Select


        'Check file exists
        'If Not IO.File.Exists(strReportPath) Then
        '    Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
        'End If

        'Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
        'myPrintOptions.PrinterName = My.Settings.DefaultPrinter
        'myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
        'myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        Select Case btnPrint.Tag
                            Case "DA"
                                .CommandText = "usp_UserCurrentDAs"
                                .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = cboOfficers.SelectedValue.ToString
                            Case "CC"
                                .CommandText = "usp_ToDoListCCs"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = cboOfficers.SelectedValue.ToString

                            Case "REFER"
                                .CommandText = "usp_ToDoListReferrals"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = cboOfficers.SelectedValue.ToString

                            Case "AA"
                                .CommandText = "usp_ToDoListAAs"
                                .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = cboOfficers.SelectedValue.ToString

                            Case "AAREFER"
                                .CommandText = "usp_SELECT_AAReferalListByOfficerID"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = cboOfficers.SelectedValue.ToString


                        End Select


                    End With


                    Dim objDT As New System.Data.DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    Select Case btnPrint.Tag
                        Case "DA"

                            Dim rept As New MyOutstandingDA
                            rept.DataSource = objDT
                            rept.CreateDocument()


                            Using printTool As New ReportPrintTool(rept)
                                ' Invoke the Ribbon Print Preview form modally, 
                                ' and load the report document into it.
                                printTool.ShowPreviewDialog()

                                ' Invoke the Ribbon Print Preview form
                                ' with the specified look and feel setting.
                                printTool.ShowPreview(UserLookAndFeel.Default)
                            End Using


                        Case "CC"

                            Dim rept As New MyOutstandingCC

                            rept.DataSource = objDT
                            rept.CreateDocument()

                            Using printTool As New ReportPrintTool(rept)
                                ' Invoke the Ribbon Print Preview form modally, 
                                ' and load the report document into it.
                                printTool.ShowPreviewDialog()

                                ' Invoke the Ribbon Print Preview form
                                ' with the specified look and feel setting.
                                printTool.ShowPreview(UserLookAndFeel.Default)
                            End Using

                        Case "REFER"

                            Dim rept As New MyReferrals
                            rept.DataSource = objDT
                            rept.CreateDocument()

                            Using printTool As New ReportPrintTool(rept)
                                ' Invoke the Ribbon Print Preview form modally, 
                                ' and load the report document into it.
                                printTool.ShowPreviewDialog()

                                ' Invoke the Ribbon Print Preview form
                                ' with the specified look and feel setting.
                                printTool.ShowPreview(UserLookAndFeel.Default)
                            End Using

                        Case "AA"


                            Dim rept As New MyOutstandingAA
                            rept.DataSource = objDT
                            rept.CreateDocument()

                            Using printTool As New ReportPrintTool(rept)
                                ' Invoke the Ribbon Print Preview form modally, 
                                ' and load the report document into it.
                                printTool.ShowPreviewDialog()

                                ' Invoke the Ribbon Print Preview form
                                ' with the specified look and feel setting.
                                printTool.ShowPreview(UserLookAndFeel.Default)
                            End Using


                        Case "AAREFER"

                            Dim rept As New MyAAreferrals
                            rept.DataSource = objDT
                            rept.CreateDocument()

                            Using printTool As New ReportPrintTool(rept)
                                ' Invoke the Ribbon Print Preview form modally, 
                                ' and load the report document into it.
                                printTool.ShowPreviewDialog()

                                ' Invoke the Ribbon Print Preview form
                                ' with the specified look and feel setting.
                                printTool.ShowPreview(UserLookAndFeel.Default)
                            End Using

                    End Select






                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    'Private Sub Usp_ToDoListAAsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If e.ColumnIndex = -1 Then Exit Sub
    '    With DAApplication
    '        .StartPosition = FormStartPosition.CenterParent
    '        .ShowDialog()
    '        .Dispose()
    '    End With

    'End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Dim i As Integer = TabControl1.SelectedIndex + 1

        Select Case i
            Case 1
                With btnPrint
                    .Enabled = True
                    .Tag = "DA"
                    .Text = "Print my DAs list"
                End With
            Case 2

                With btnPrint
                    .Enabled = False
                    .Tag = ""
                    .Text = "Nothing to print"
                End With

            Case 3
                With btnPrint
                    .Enabled = True
                    .Tag = "CC"
                    .Text = "Print my CCs list"
                End With

            Case 4
                With btnPrint
                    .Enabled = True
                    .Tag = "REFER"
                    .Text = "Print my referrals"
                End With

            Case 5
                With btnPrint
                    .Enabled = True
                    .Tag = "AA"
                    .Text = "Print my AAs list"
                End With
            Case 6
                With btnPrint
                    .Enabled = True
                    .Tag = "AAREFER"
                    .Text = "Print my AAs referrals"
                End With


        End Select


    End Sub

    Private Sub gvwOutStandingDA_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwOutStandingDA.RowClick




        Dim myobj As DataRowView = CType(gvwOutStandingDA.GetFocusedRow, DataRowView)


        DevelopmentStart.DisplayMyDA = myobj.Row.Item("DANo").ToString


    End Sub

    Private Sub gvwAdditionalInfo_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwAdditionalInfo.RowClick



        Dim myobj As DataRowView = CType(gvwAdditionalInfo.GetFocusedRow, DataRowView)


        DevelopmentStart.DisplayMyDA = myobj.Row.Item("DANo").ToString

    End Sub

    Private Sub gvwOutstandingCC_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwOutstandingCC.RowClick

        Dim myobj As DataRowView = CType(gvwOutstandingCC.GetFocusedRow, DataRowView)


        DevelopmentStart.DisplayMyDA = myobj.Row.Item("DANo").ToString


    End Sub

    Private Sub gvwReferralsList_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwReferralsList.RowClick


        Dim myobj As DataRowView = CType(gvwReferralsList.GetFocusedRow, DataRowView)


        DevelopmentStart.DisplayMyDA = myobj.Row.Item("DANo").ToString


    End Sub
End Class