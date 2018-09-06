Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
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

        lupOfficers.EditValue = sUserID
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



                    With lupOfficers.Properties

                        .Columns.Clear()
                        .DataSource = objDT
                        .DisplayMember = "Officer"
                        .ValueMember = "NetworkUser"
                        .BestFitMode = BestFitMode.BestFitResizePopup
                        .SearchMode = SearchMode.AutoComplete
                        .AutoSearchColumnIndex = 1
                        .ShowFooter = False
                        .ShowHeader = False

                    End With
                    Dim col2 As LookUpColumnInfoCollection = lupOfficers.Properties.Columns
                    col2.Add(New LookUpColumnInfo("NetworkUser", 0))
                    col2.Add(New LookUpColumnInfo("Officer", 0))

                    col2.Item(0).Visible = False


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

    Private Sub LoadUsersOutstandingDAs(UserID As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersOutstandingDAs routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UserCurrentDAs"

                        .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = UserID



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdOutStandingDA.DataSource = objDT


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersOutstandingDAs routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadUsersOutstandingAAs(userId As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersOutstandingAAs routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ToDoListAAs"

                        .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = userId



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdOutStandingAA.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersOutstandingAAs routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadListofUsersReferrals(userId As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListofUsersReferrals routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ToDoListReferrals"

                        .Parameters.Add("@USERID", SqlDbType.VarChar).Value = userId



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdReferralsList.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListofUsersReferrals routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadListOfUsersCCReferrals(userID As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfUsersCCReferrals routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ToDoListCCs"

                        .Parameters.Add("@USERID", SqlDbType.VarChar).Value = userID

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdOutstandingCC.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfUsersCCReferrals routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadUsersAdditionalInfo(userId As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersAdditionalInfo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ToDoListAdditionalInfo"

                        .Parameters.Add("@USERID", SqlDbType.VarChar).Value = userId



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdAdditionalInfo.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUsersAdditionalInfo routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub MyOustandingDAs_LoadExtracted(ByVal UserID As String)


        Try
            LoadOfficerStats(UserID)
            LoadUsersOutstandingDAs(UserID)
            LoadUsersOutstandingAAs(UserID)
            LoadListofUsersReferrals(UserID)
            LoadListOfUsersCCReferrals(UserID)
            LoadUsersAdditionalInfo(UserID)
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



    Public Sub New()
        Loading = True

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loading = False

    End Sub





    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click



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
                                .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = lupOfficers.EditValue.ToString
                            Case "CC"
                                .CommandText = "usp_ToDoListCCs"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = lupOfficers.EditValue.ToString

                            Case "REFER"
                                .CommandText = "usp_ToDoListReferrals"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = lupOfficers.EditValue.ToString

                            Case "AA"
                                .CommandText = "usp_ToDoListAAs"
                                .Parameters.Add("@GLUSER", SqlDbType.VarChar).Value = lupOfficers.EditValue.ToString

                            Case "AAREFER"
                                .CommandText = "usp_SELECT_AAReferalListByOfficerID"
                                .Parameters.Add("@USERID", SqlDbType.VarChar).Value = lupOfficers.EditValue.ToString


                        End Select


                    End With


                    Dim objDT As New System.Data.DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "PROPERTYNOTES")

                    'mylist.WriteXmlSchema("FileLocation")


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



    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Dim i As Integer = TabControl1.SelectedIndex + 1

        Select Case i
            Case 1
                With btnPrint
                    .Enabled = True
                    .Tag = "DA"
                    .Text = "Print my DAs list"
                End With
                With btnExportExcel
                    .Enabled = True
                    .Tag = "DA"
                    .Text = "Export DAs list"
                End With

            Case 2

                With btnPrint
                    .Enabled = False
                    .Tag = ""
                    .Text = "Nothing to print"
                End With
                With btnExportExcel
                    .Enabled = False
                    .Tag = ""
                    .Text = "Nothing to export"
                End With

            Case 3
                With btnPrint
                    .Enabled = True
                    .Tag = "CC"
                    .Text = "Print my CCs list"
                End With
                With btnExportExcel
                    .Enabled = True
                    .Tag = "CC"
                    .Text = "Export CCs list"
                End With

            Case 4
                With btnPrint
                    .Enabled = True
                    .Tag = "REFER"
                    .Text = "Print my referrals"
                End With
                With btnExportExcel
                    .Enabled = True
                    .Tag = "REFER"
                    .Text = "Export CCs referrals"
                End With

            Case 5
                With btnPrint
                    .Enabled = True
                    .Tag = "AA"
                    .Text = "Print my AAs list"
                End With

                With btnExportExcel
                    .Enabled = True
                    .Tag = "AA"
                    .Text = "Export AAs list"
                End With


            Case 6
                With btnPrint
                    .Enabled = True
                    .Tag = "AAREFER"
                    .Text = "Print my AAs referrals"
                End With
                With btnExportExcel
                    .Enabled = True
                    .Tag = "AAREFER"
                    .Text = "Export AAs referrals"
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

    Private Sub lupOfficers_EditValueChanged(sender As Object, e As EventArgs) Handles lupOfficers.EditValueChanged
        If lupOfficers.IsLoading Then Return

        If Loading Then Return

        Try
            MyOustandingDAs_LoadExtracted(lupOfficers.EditValue.ToString)
            btnPrint.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click

        Cursor = Cursors.WaitCursor

        Select Case btnPrint.Tag

            Case "DA"


                Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdOutStandingDA.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                Dim saveData As New SaveFileDialog
                Dim myStream As System.IO.Stream

                With saveData
                    .Filter = "Excel files (*.xlsx)|*.xlsx"
                    .RestoreDirectory = True
                    If .ShowDialog = DialogResult.OK Then
                        myStream = .OpenFile

                        If Not View Is Nothing Then
                            View.OptionsPrint.ExpandAllDetails = True
                            View.ExportToXlsx(myStream)
                            'View.ExportToPdf("MainViewData.pdf")
                        End If


                        If (myStream IsNot Nothing) Then

                            myStream.Close()
                        End If

                    End If

                End With


            Case "CC"


                Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdOutstandingCC.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                Dim saveData As New SaveFileDialog
                Dim myStream As System.IO.Stream

                With saveData
                    .Filter = "Excel files (*.xlsx)|*.xlsx"
                    .RestoreDirectory = True
                    If .ShowDialog = DialogResult.OK Then
                        myStream = .OpenFile

                        If Not View Is Nothing Then
                            View.OptionsPrint.ExpandAllDetails = True
                            View.ExportToXlsx(myStream)
                            'View.ExportToPdf("MainViewData.pdf")
                        End If


                        If (myStream IsNot Nothing) Then

                            myStream.Close()
                        End If

                    End If

                End With

            Case "REFER"


                Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdReferralsList.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                Dim saveData As New SaveFileDialog
                Dim myStream As System.IO.Stream

                With saveData
                    .Filter = "Excel files (*.xlsx)|*.xlsx"
                    .RestoreDirectory = True
                    If .ShowDialog = DialogResult.OK Then
                        myStream = .OpenFile

                        If Not View Is Nothing Then
                            View.OptionsPrint.ExpandAllDetails = True
                            View.ExportToXlsx(myStream)
                            'View.ExportToPdf("MainViewData.pdf")
                        End If


                        If (myStream IsNot Nothing) Then

                            myStream.Close()
                        End If

                    End If

                End With

            Case "AA"


                Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdOutStandingAA.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                Dim saveData As New SaveFileDialog
                Dim myStream As System.IO.Stream

                With saveData
                    .Filter = "Excel files (*.xlsx)|*.xlsx"
                    .RestoreDirectory = True
                    If .ShowDialog = DialogResult.OK Then
                        myStream = .OpenFile

                        If Not View Is Nothing Then
                            View.OptionsPrint.ExpandAllDetails = True
                            View.ExportToXlsx(myStream)
                            'View.ExportToPdf("MainViewData.pdf")
                        End If


                        If (myStream IsNot Nothing) Then

                            myStream.Close()
                        End If

                    End If

                End With

            Case "AAREFER"


                Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdAAreferrals.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                Dim saveData As New SaveFileDialog
                Dim myStream As System.IO.Stream

                With saveData
                    .Filter = "Excel files (*.xlsx)|*.xlsx"
                    .RestoreDirectory = True
                    If .ShowDialog = DialogResult.OK Then
                        myStream = .OpenFile

                        If Not View Is Nothing Then
                            View.OptionsPrint.ExpandAllDetails = True
                            View.ExportToXlsx(myStream)
                            'View.ExportToPdf("MainViewData.pdf")
                        End If


                        If (myStream IsNot Nothing) Then

                            myStream.Close()
                        End If

                    End If

                End With

        End Select

        Cursor = Cursors.Default

    End Sub
End Class