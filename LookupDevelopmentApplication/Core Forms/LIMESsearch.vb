Imports System.Data
Imports System.Data.SqlClient

Public Class LIMESsearch
    Private Const iNAME As Integer = 0
    Private Const iSTREET As Integer = 1
    Private Const iDP As Integer = 2
    Private Const iPROPERTY As Integer = 3
    Private Const iLOT_STREET As Integer = 4
    Private Const iHSE_DPNUM As Integer = 5
    Private Const iRESERVES As Integer = 6

    Private Const FORMHEIGHT As Integer = 79
    Private Const FORMVWHEIGHT As Integer = 226
    Private lPIN As Integer

    Private objData As DABase
    Private objGroupsDS As DataSet
#Region " Form Events"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Height = FORMHEIGHT

        ' Add any initialization after the InitializeComponent() call.
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub cboSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSearch.GotFocus
        Me.cboSearch.DroppedDown = True
    End Sub


    Private Sub cboSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearch.SelectedIndexChanged
        Select Case Trim(cboSearch.Text.ToUpper)
            Case "LOT/STREET"
                txtLot.Visible = True
                txtLot.Text = ""
                lblValue.Text = "Street Name"
                With lblSearch
                    .Text = "Lot No."
                    .Visible = True
                End With
            Case "HOUSE NO/DP"
                txtLot.Visible = True
                txtLot.Text = ""
                lblValue.Text = "DP/SP Number"
                With lblSearch
                    .Text = "House No."
                    .Visible = True
                End With
            Case "PIN"
                txtLot.Visible = False
                lblValue.Text = "Enter PIN"
                lblSearch.Visible = False
            Case "DP NUMBER"
                txtLot.Visible = False
                lblValue.Text = "Enter DP/SP Number"
                lblSearch.Visible = False
            Case "NAME"
                txtLot.Visible = False
                lblValue.Text = "Enter Name"
                lblSearch.Visible = False
            Case "ADDRESS", "RESERVES ETC"
                txtLot.Visible = False
                lblSearch.Visible = False
                lblValue.Text = "Enter Address"
            Case Else 'Property number
                txtLot.Visible = False
                lblSearch.Visible = False
                lblValue.Text = "Property No"

        End Select
        Me.Height = FORMHEIGHT
        With txtSearch
            .Text = ""
            If .Visible Then .Focus()
        End With

    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("You are required to enter a search value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearch.Focus()
            Exit Sub
        ElseIf cboSearch.Text = "" Then
            MessageBox.Show("You are required to enter the field to search..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboSearch.Focus()
            Exit Sub
        Else
            Select Case Trim(cboSearch.Text.ToUpper)
                Case "LOT/STREET"
                    If txtLot.Text = "" Then
                        MessageBox.Show("You are required to enter a search value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtLot.Focus()
                        Exit Sub
                    Else
                        If Not IsNumeric(txtLot.Text) Then
                            MessageBox.Show("You are required to enter a numeric value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtLot.Focus()
                            Exit Sub

                        End If

                    End If
                Case "HOUSE NO/DP"
                    If txtLot.Text = "" Then
                        MessageBox.Show("You are required to enter a search value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtLot.Focus()
                        Exit Sub
                    Else
                        If Not IsNumeric(txtLot.Text) Then
                            MessageBox.Show("You are required to enter a numeric value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtLot.Focus()
                            Exit Sub

                        End If
                        If Not IsNumeric(txtSearch.Text) Then
                            MessageBox.Show("You are required to enter a numeric value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtSearch.Focus()
                            Exit Sub

                        End If

                    End If

            End Select
            Call CheckForRecords()
        End If

    End Sub




    Private Sub lvwResults_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwResults.Click
        Try
            mdl_lPIN = CInt(lvwResults.SelectedItems.Item(0).Tag)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "In lvwResults_click")
        End Try

    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True


        End If
    End Sub



    Private Sub txtLot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLot.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True
        End If
    End Sub

    Protected Overrides Sub Finalize()
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next

        MyBase.Finalize()
    End Sub
#End Region
#Region "Private Routines"
    Private Sub SetupListView(ByVal SearchType As Integer)
        Select Case SearchType
            Case iDP
                lvwResults.Columns.Clear()
                lvwResults.Columns.Add(New ColumnHeader)
                lvwResults.Columns(0).Text = "Name"
                lvwResults.Columns(0).Width = 250
                lvwResults.Columns.Add(New ColumnHeader)
                lvwResults.Columns(1).Text = "DP/SP Number"
                lvwResults.Columns(1).Width = 120
            Case Else
                lvwResults.Columns.Clear()
                lvwResults.Columns.Add(New ColumnHeader)
                lvwResults.Columns(0).Text = "Name"
                lvwResults.Columns(0).Width = 150
                lvwResults.Columns.Add(New ColumnHeader)
                lvwResults.Columns(1).Text = "Address"
                lvwResults.Columns(1).Width = 210

        End Select
    End Sub
    Public Sub CheckForRecords()
        'Initialize a new instance of the data access base class
        objData = New DABase
        Dim objDataSet As DataSet
        Dim Search As Integer
        Try

            With lvwResults
                .Items.Clear()
                .Sorting = Windows.Forms.SortOrder.Ascending
                .View = View.Details
            End With



            Select Case Trim(cboSearch.Text.ToUpper)
                Case "PIN"
                    If CheckPIN(CLng(txtSearch.Text)) Then
                        mdl_lPIN = CInt(txtSearch.Text)
                        Me.Close()
                        Exit Sub
                    Else
                        MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "DP NUMBER"
                    ' Set command properties
                    objData.SQL = "spDPNUMLookup"
                    objData.InitializeCommand()
                    objData.AddParameter("@DPNUM", SqlDbType.VarChar, 25, txtSearch.Text)
                    SetupListView(iDP)
                    Search = iDP
                Case "NAME"
                    ' Set command properties
                    objData.SQL = "spNameLookUp"
                    objData.InitializeCommand()
                    objData.AddParameter("@NameToFind", SqlDbType.VarChar, 25, Replace(txtSearch.Text, "'", "_"))
                    SetupListView(iNAME)
                    Search = iNAME
                Case "ADDRESS"
                    ' Set command properties
                    objData.SQL = "spFindByAddress"
                    objData.InitializeCommand()
                    objData.AddParameter("@ADDRESS", SqlDbType.VarChar, 30, txtSearch.Text)
                    SetupListView(iSTREET)
                    Search = iSTREET


                Case "PROPERTY NUMBER"
                    Dim iSTREET As Integer
                    Dim iSeq As Integer
                    Dim iSin As Integer
                    Dim iFirstPosn As Integer
                    Dim iSecPosn As Integer


                    iFirstPosn = InStr(txtSearch.Text, ".") ' Indicates that there is a second part
                    iSecPosn = InStr(iFirstPosn + 1, txtSearch.Text, ".") 'Indicates there is a third part

                    'SecPosn = 0 it could be that a "/" instead of "." separator check for this next
                    If iSecPosn = 0 Then
                        iSecPosn = InStr(iFirstPosn + 1, txtSearch.Text, "/")
                    End If

                    If iFirstPosn <> 0 Then 'means that a second value exists
                        iSTREET = CInt(txtSearch.Text.Substring(iFirstPosn - 1)) 'get the first value

                        If iSecPosn <> 0 Then 'indicates there is a second part which means we have a third part as well
                            iSeq = CInt(Mid(txtSearch.Text, iFirstPosn + 1, (iSecPosn - 1) - iFirstPosn)) 'get the second value
                            iSin = CInt(Mid(txtSearch.Text, iSecPosn + 1)) 'get the third value
                        Else 'indicates we only have a second value
                            iSeq = CInt(Mid(txtSearch.Text, iFirstPosn + 1)) 'get the second value
                            iSin = 0 'Set third value to arbitury value of 0
                        End If


                    Else ' there is no second part so set first part  and defaults
                        iSTREET = CInt(txtSearch.Text) 'get the first value
                        iSeq = 0 'Set second value to arbitury value of 0
                        iSin = 0 'Set third value to arbitury value of 0
                    End If
                    objData.SQL = "spFindbyPropertyNo"
                    objData.InitializeCommand()
                    objData.AddParameter("@badger1", SqlDbType.Char, 5, iSTREET)
                    objData.AddParameter("@badger2", SqlDbType.Char, 5, iSeq)
                    objData.AddParameter("@badger3", SqlDbType.Char, 5, iSin)
                    SetupListView(iPROPERTY)
                    Search = iPROPERTY


                Case "LOT/STREET"

                    ' Set command properties
                    objData.SQL = "usp_LIMES_FindByLotStreet"
                    objData.InitializeCommand()
                    objData.AddParameter("@LOT", SqlDbType.VarChar, 4, txtLot.Text)
                    objData.AddParameter("@ADDRESS", SqlDbType.VarChar, 255, txtSearch.Text)
                    SetupListView(iLOT_STREET)
                    Search = iLOT_STREET


                Case "HOUSE NO/DP"
                    ' Set command properties
                    objData.SQL = "usp_LIMES_FindByHSENoDPNo"
                    objData.InitializeCommand()
                    ' Specify input parameter values
                    objData.AddParameter("@LOT", SqlDbType.VarChar, 4, txtLot.Text)
                    objData.AddParameter("@DPNUM", SqlDbType.VarChar, 25, txtSearch.Text)
                    SetupListView(iHSE_DPNUM)
                    Search = iHSE_DPNUM

                Case Else : Exit Sub
            End Select

            ' Execute the command
            'objData.InitializeCommand()
            objData.OpenConnection()
            objDataSet = New DataSet
            objData.FillDataSet(objDataSet, "Properties")
            'Find the number of rows


            Dim RowCount As Integer = objDataSet.Tables("properties").Rows.Count

            Me.Height = FORMHEIGHT

            Select Case RowCount
                Case 0
                    MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 1
                    Dim objDataRow As DataRow = objDataSet.Tables("Properties").Rows.Item(0)
                    mdl_lPIN = CInt(objDataRow.Item("RRN"))
                    Me.Close()
                Case Else
                    Dim objListViewItem As ListViewItem

                    Me.SuspendLayout()


                    Dim objDataRow As DataRow
                    'Process all rows
                    For Each objDataRow In objDataSet.Tables("Properties").Rows

                        'Create a new ListViewItem
                        objListViewItem = New ListViewItem
                        Select Case Search
                            Case iNAME, iSTREET, iLOT_STREET, iHSE_DPNUM, iPROPERTY
                                'Add the data to the ListViewItem
                                objListViewItem.Text = objDataRow.Item("NAME").ToString
                                objListViewItem.Tag = objDataRow.Item("RRN").ToString
                                'Add the sub items to the listview item
                                objListViewItem.SubItems.Add(objDataRow.Item("ADDRESS").ToString)
                                'Add the ListViewItem to the ListView control
                                lvwResults.Items.Add(objListViewItem)
                            Case iDP
                                'Add the data to the ListViewItem
                                objListViewItem.Text = CStr(objDataRow.Item("DEPOSIT NO"))
                                objListViewItem.Tag = CStr(objDataRow.Item("RRN"))
                                'Add the ListViewItem to the ListView control
                                lvwResults.Items.Add(objListViewItem)

                        End Select
                    Next
                    Me.Height = FORMVWHEIGHT
                    Me.ResumeLayout(False)


            End Select



        Catch ex As Exception
            MessageBox.Show(ex.Message, "In CheckForRecords")
        End Try

    End Sub
    '---------------------------------------------------------------------------------------
    ' Procedure : CheckPIN
    ' DateTime  : 27/05/2004 15:34
    ' Author    : rocallag
    ' Purpose   : Validates that the PIN entered is valid
    '---------------------------------------------------------------------------------------
    '
    Private Function CheckPIN(ByVal lPIN As Long) As Boolean

        Dim lResult As Boolean = False
        Dim cn As SqlConnection

        cn = New SqlConnection(My.Settings.cnLIMES)


        Dim cmd As New SqlCommand


        With cmd
            .Connection = cn
            .CommandType = CommandType.StoredProcedure
            .CommandText = "usp_LIMES_ValidPIN"
            .Parameters.Add("@PIN", SqlDbType.Int, 0, Nothing)
            .Parameters.Add("@VALID", SqlDbType.Bit, 0, Nothing)
            .Parameters.Add("@ROADID", SqlDbType.Int, 0, Nothing)
            .Parameters.Add("@ROADNAME", SqlDbType.VarChar, 40, Nothing)


            .Parameters("@VALID").Direction = ParameterDirection.Output
            .Parameters("@ROADID").Direction = ParameterDirection.Output
            .Parameters("@ROADNAME").Direction = ParameterDirection.Output

            .Parameters("@PIN").Value = CStr(lPIN)
        End With
        cn.Open()
        cmd.ExecuteNonQuery()

        ' Retrieve stored procedure return value and output parameters
        lResult = CBool(cmd.Parameters("@VALID").Value)

         
        CheckPIN = lResult

    End Function
    Private mdl_lPIN As Integer
    Public ReadOnly Property PIN() As Integer
        Get
            Return mdl_lPIN
        End Get
    End Property
#End Region
 
End Class