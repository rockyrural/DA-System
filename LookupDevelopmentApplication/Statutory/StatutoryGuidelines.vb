Imports system.data.sqlclient
Imports spellCheckTextbox


Public Class StatutoryGuidelines

    Private DANo As String
    Public WriteOnly Property AssessmentNo() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property


    Private _Islocked As Boolean
    Public WriteOnly Property Islocked() As Boolean
        Set(ByVal value As Boolean)
            _Islocked = value
        End Set
    End Property




    Private Sub LoadForm()
        Try
            Me.GridLoadGuidLinesTableAdapter.Fill(Me.AAdata.GridLoadGuidLines, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        If _Islocked Then LockTheForm(Me)


    End Sub


    Private Sub LockTheForm(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is Button Then

                Dim cb As Button = DirectCast(ctrl, Button)

                cb.Enabled = False


            ElseIf TypeOf ctrl Is Windows.Forms.ComboBox Then

                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)

                cb.Enabled = False


            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = True




            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = False



            End If


            If ctrl.HasChildren Then
                LockTheForm(ctrl)
            End If
        Next
    End Sub





    Private Sub StatutoryGuidelines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.LoadGuideLinesListTableAdapter.Fill(Me.AAdata.LoadGuideLinesList)
        Me.lblREPid.Text = String.Empty
        Me.cboLoadGuidLineList.SelectedIndex = -1
        Me.txtComment.Text = String.Empty
        LoadForm()
    End Sub

    Private Sub GridLoadGuidLinesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridLoadGuidLinesDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.lblREPid.Text = Me.GridLoadGuidLinesDataGridView.CurrentRow.Cells(0).Value.ToString
        Me.cboLoadGuidLineList.SelectedValue = Me.GridLoadGuidLinesDataGridView.CurrentRow.Cells(3).Value.ToString
        Me.txtComment.Text = Me.GridLoadGuidLinesDataGridView.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btnUpdateREPCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateREPCode.Click

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateREPCode_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateGuideLineRecords"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = nz(Me.lblREPid.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.cboLoadGuidLineList.SelectedValue.ToString
                        .Parameters.Add("@COMMENTS", SqlDbType.NText).Value = Me.txtComment.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateREPCode_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.lblREPid.Text = String.Empty
        Me.cboLoadGuidLineList.SelectedIndex = -1
        Me.txtComment.Text = String.Empty

        Try
            Me.GridLoadGuidLinesTableAdapter.Fill(Me.AAdata.GridLoadGuidLines, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

End Class