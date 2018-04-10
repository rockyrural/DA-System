Imports System.Data.SqlClient

Public Class OfficerLookUp

    Private KeyPressed As Boolean
    Private isloadingList As Boolean

    Private mdlOfficerID As Integer
    Public ReadOnly Property Officerid() As Integer
        Get
            Return mdlOfficerID
        End Get
    End Property
    'Private Sub FindMyString(ByVal searchString As String)
    '    ' Ensure we have a proper string to search for.
    '    If searchString <> String.Empty Then
    '        ' Find the item in the list and store the index to the item.
    '        Dim index As Integer = lstOfficers.FindString(searchString)
    '        ' Determine if a valid index is returned. Select the item if it is valid.
    '        If index <> -1 Then
    '            lstOfficers.SetSelected(index, True)
    '            'Else
    '            '    MessageBox.Show("The search string did not match any items in the ListBox")
    '        End If
    '    End If
    'End Sub

    Private Sub LoadOfficerList()
        Using cn As New SqlConnection(My.Settings.cnnLogon)
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
                        .CommandText = "usp_ListNameAndIdAllCurrentOfficers"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'With lstOfficers
                    '    .DataSource = objDT
                    '    .DisplayMember = "OfficersName"
                    '    .ValueMember = "UnameID"
                    'End With

                    grdOfficers.DataSource = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub
    Private Sub OfficerLookUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        isloadingList = True
        LoadOfficerList()
        isloadingList = False
    End Sub

    'Private Sub txtListSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtListSearch.TextChanged
    '    FindMyString(txtListSearch.Text)
    'End Sub

    'Private Sub lstOfficers_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOfficers.SelectedValueChanged
    '    If isloadingList Then Exit Sub
    '    mdlOfficerID = CInt(lstOfficers.SelectedValue)
    'End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Me.Close()
    End Sub

    Private Sub gvwOfficers_KeyDown(sender As Object, e As KeyEventArgs) Handles gvwOfficers.KeyDown
        KeyPressed = False

        If e.KeyCode = Keys.Enter Then


            Dim myobj As DataRowView = CType(gvwOfficers.GetFocusedRow, DataRowView)


            mdlOfficerID = CInt(myobj.Row.Item("UnameID"))

            KeyPressed = True

            DialogResult = DialogResult.OK


        End If


    End Sub

    Private Sub gvwOfficers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvwOfficers.KeyPress
        If KeyPressed = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub gvwOfficers_DoubleClick(sender As Object, e As EventArgs) Handles gvwOfficers.DoubleClick
        Dim myobj As DataRowView = CType(gvwOfficers.GetFocusedRow, DataRowView)


        mdlOfficerID = CInt(myobj.Row.Item("UnameID"))

        DialogResult = DialogResult.OK

    End Sub

    'Private Sub lstOfficers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOfficers.DoubleClick
    '    mdlOfficerID = CInt(lstOfficers.SelectedValue)
    '    Me.Close()
    'End Sub

    'Private Sub txtListSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtListSearch.KeyPress
    '    Dim KeyAscii As Integer = Asc(e.KeyChar)
    '    If KeyAscii = System.Windows.Forms.Keys.Return Then 'Catch Return Key
    '        mdlOfficerID = CInt(lstOfficers.SelectedValue)
    '        Me.Close()
    '        KeyAscii = 0 'Eat the Key to prevent a Beep
    '    End If
    '    e.KeyChar = Chr(KeyAscii)
    '    If KeyAscii = 0 Then
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtListSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtListSearch.KeyDown
    '    If e.KeyCode = Keys.Down Then
    '        My.Computer.Keyboard.SendKeys("{TAB}")
    '    End If
    'End Sub
End Class