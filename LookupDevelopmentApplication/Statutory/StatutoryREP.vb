Imports system.data.sqlclient
Imports spellCheckTextbox


Public Class StatutoryREP
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    'Private txtComment As spellCheckTextbox.UserControl1
    'Private RepCommentssTextBox As spellCheckTextbox.UserControl1

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
        LoadThegrid()

        LoadComments()


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



    Private Sub avAddressCtrl_TextChanged(ByVal sender As Object, ByVal args As System.Windows.Controls.TextChangedEventArgs)

    End Sub


    Private Sub LoadComments()

        txtComment.text = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadComments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetTheRepComment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@REPCOMMENT", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        RepCommentssTextBox.Text = .Parameters("@REPCOMMENT").Value.ToString

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadComments routine - form " & Me.Name)

            End Try
        End Using



    End Sub



    Private Sub SaveREPData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Statutory_REP_Update"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@REPCOMMENTS", SqlDbType.NText).Value = RepCommentssTextBox.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub StatutoryREP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then SaveREPData()
    End Sub


    Private Sub StatutoryREP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RepCommentssTextBox = New spellCheckTextbox.UserControl1
        'txtComment.InitializeComponent()
        'ElementHost1.Child = txtComment

        'AddHandler RepCommentssTextBox.TextChanged, AddressOf avAddressCtrl_TextChanged


        'RepCommentssTextBox = New spellCheckTextbox.UserControl1
        'RepCommentssTextBox.InitializeComponent()
        'ElementHost2.Child = RepCommentssTextBox

        'AddHandler RepCommentssTextBox.TextChanged, AddressOf avAddressCtrl_TextChanged

        txtComment.text = String.Empty

        LoadCombo()
        LoadForm()

        Me.lblREPid.Text = String.Empty

        Me.txtComment.Text = String.Empty

    End Sub

    Private Sub dgvStatutory_REP_Records_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStatutory_REP_Records.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.lblREPid.Text = Me.dgvStatutory_REP_Records.CurrentRow.Cells("colID").Value.ToString
        Me.cboLoadREPcodesList.Text = Me.dgvStatutory_REP_Records.CurrentRow.Cells("colRepCode").Value.ToString
        Me.txtComment.text = Me.dgvStatutory_REP_Records.CurrentRow.Cells("colComments").Value.ToString

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
                        .CommandText = "usp_InsertUpdateREPrecord"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(Me.lblREPid.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.cboLoadREPcodesList.SelectedValue.ToString
                        .Parameters.Add("@COMMENTS", SqlDbType.NText).Value = Me.txtComment.text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateREPCode_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.lblREPid.Text = String.Empty
        Me.cboLoadREPcodesList.SelectedIndex = -1
        Me.txtComment.text = String.Empty

        Try
            LoadThegrid()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadThegrid()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadThegrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Statutory_REP_Records"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using





                    dgvStatutory_REP_Records.DataSource = objDT
                    dgvStatutory_REP_Records.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadThegrid routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadCombo()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadREPcodesList"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboLoadREPcodesList
                        .DataSource = objDT
                        .DisplayMember = "RepTitle"
                        .ValueMember = "Id"
                        .SelectedIndex = -1
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCombo routine - form " & Me.Name)

            End Try
        End Using



    End Sub



    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

End Class