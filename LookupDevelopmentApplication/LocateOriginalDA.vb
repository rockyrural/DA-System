Imports System.Data.SqlClient


Public Class LocateOriginalDA

    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3
    Private Const iCC As Integer = 4
    Private Const iOWNERNAME As Integer = 5
    Private Const iPROPADDRESS As Integer = 6
    Private Const iDANO As Integer = 9


    Private OriginalDANo As String = String.Empty
    Public ReadOnly Property OriginalDANumber() As String
        Get
            Return OriginalDANo
        End Get
    End Property


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("You are required to enter a search value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearch.Focus()
            Exit Sub
        ElseIf cboSearchType.Text = "" Then
            MessageBox.Show("You are required to enter the field to search..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboSearchType.Focus()
            Exit Sub
        Else
            Select Case cboSearchType.Text.Trim.ToUpper
                Case "PIN"
                    If Not IsNumeric(txtSearch.Text) Then
                        MessageBox.Show("You are required to enter a numeric value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Focus()
                        Exit Sub
                    Else
                        'LoadForm(Me.txtSearch.Text.ToString)
                        'txtSearch.Text = String.Empty
                        'Exit Sub

                    End If
            End Select
            Call CheckForRecords()

            txtSearch.Text = String.Empty
        End If


    End Sub

    Public Sub CheckForRecords()
        'Initialize a new instance of the data access base class
        Dim Search As Integer

        Using cn1 As New SqlConnection(My.Settings.DataConnection)
            Try
                cn1.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForRecords routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn1
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAsearch"

                        .Parameters.Add("@SEARCHTYPE", SqlDbType.Int)
                        .Parameters.Add("@SEARCHFOR", SqlDbType.VarChar, 20).Value = Me.txtSearch.Text

                        Select Case cboSearchType.Text.ToUpper.Trim
                            Case "DA NUMBER"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iDANO
                                Search = iDANO

                            Case "FILE NO"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iFILENO
                                Search = iFILENO

                            Case "CUSTOMER NAME"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iNAME
                                Search = iNAME

                            Case "PIN"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iPIN
                                Search = iPIN

                            Case "ADDRESS"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iADDRESS
                                Search = iADDRESS
                            Case Else : Exit Sub
                        End Select
                    End With



                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount1 As Integer = objDT.Rows.Count

                    Select Case RowCount1
                        Case 0
                            MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case 1

                            Dim objDataRow As DataRow = objDT.Rows.Item(0)

                            OriginalDANo = objDataRow.Item("DANo").ToString
                            Me.Close()

                        Case Else
                            With dgvDAs
                                .DataSource = objDT
                                .Refresh()
                            End With
                    End Select






                End Using
                cn1.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForRecords routine - form " & Me.Name)

            End Try
        End Using


    End Sub
   


    Private Sub dgvDAs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDAs.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If dgvDAs.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        OriginalDANo = dgvDAs.CurrentRow.Cells(0).Value.ToString
        Me.Close()

    End Sub
End Class