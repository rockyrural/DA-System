
Imports system.data.sqlclient
Public Class DAConditionsFreeForm


    Private err As ErrorProvider

    Private ConditCode As Integer
    Public WriteOnly Property ConditionCode() As Integer
        Set(ByVal value As Integer)
            ConditCode = value
        End Set
    End Property
    Private DAno As String
    Public WriteOnly Property DANumber() As String
        Set(ByVal value As String)
            DAno = value
        End Set
    End Property

    Private Sub DAConditionsFreeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.FreeFormConditionCodesTableAdapter.Fill(Me.DAdatasets.FreeFormConditionCodes, New System.Nullable(Of Integer)(CType(ConditCode, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        lblID.Text = 0
        Me.txtFreefromText.Text = String.Empty
        Me.cboConditions.SelectedIndex = -1

        Try
            Me.LoadFreeFormGridTableAdapter.Fill(Me.DAdatasets.LoadFreeFormGrid, DAno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.btnRemove.Enabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not CheckFormComplete() Then Exit Sub

        If CheckConditionAlreadyExists(CInt(cboConditions.SelectedValue)) Then
            MessageBox.Show("Condition """ & Me.cboConditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Insert this free form text now?", "Insert free form text", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAdd_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertFreeFormText"

                        .Parameters.Add("@CODEID", SqlDbType.Int).Value = CInt(lblID.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboConditions.SelectedValue)
                        .Parameters.Add("@TEXT", SqlDbType.NText).Value = Me.txtFreefromText.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                lblID.Text = 0
                Me.txtFreefromText.Text = String.Empty
                Me.cboConditions.SelectedIndex = -1

                Try
                    Me.LoadFreeFormGridTableAdapter.Fill(Me.DAdatasets.LoadFreeFormGrid, DAno)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAdd_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function CheckFormComplete() As Boolean
        Dim result As Boolean = True
        If Me.cboConditions.SelectedIndex = -1 Then
            With err
                .SetIconAlignment(cboConditions, ErrorIconAlignment.MiddleRight)
                .SetIconPadding(cboConditions, 1)
                .SetError(cboConditions, "You are required to select a condition type")
                cboConditions.Focus()
                result = False
            End With
        Else
            Err.SetError(cboConditions, "")
        End If

        If Me.txtFreefromText.Text.Length = 0 Then
            With err
                .SetIconAlignment(txtFreefromText, ErrorIconAlignment.MiddleRight)
                .SetIconPadding(txtFreefromText, 1)
                .SetError(txtFreefromText, "You are required to type in the condition")
                result = False
            End With
        Else
            Err.SetError(txtFreefromText, "")
        End If

        Return result
    End Function

    Private Function CheckConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckToSeeifFreeFormBookMArkExists"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = condID
                        .Parameters.Add("@EXIST", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@EXIST").Value)

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        err = New ErrorProvider
        err.BlinkStyle = ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If MessageBox.Show("Remove """ & Me.dgvConditions.CurrentRow.Cells(1).Value.ToString & """ from list?", "Remove free form text", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemove_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveFreeFormText"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(dgvConditions.CurrentRow.Cells(3).Value)
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                Try
                    Me.LoadFreeFormGridTableAdapter.Fill(Me.DAdatasets.LoadFreeFormGrid, DAno)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Me.btnRemove.Enabled = False
                lblID.Text = 0
                Me.txtFreefromText.Text = String.Empty
                Me.cboConditions.SelectedIndex = -1


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemove_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub dgvConditions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConditions.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        lblID.Text = dgvConditions.CurrentRow.Cells(3).Value.ToString
        Me.txtFreefromText.Text = dgvConditions.CurrentRow.Cells(1).Value.ToString
        Me.btnRemove.Enabled = True


    End Sub
End Class