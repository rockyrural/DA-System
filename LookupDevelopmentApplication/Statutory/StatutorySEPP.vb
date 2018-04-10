Imports System.Data.SqlClient
Imports spellCheckTextbox


Public Class StatutorySEPP

    'Private txtComment As spellCheckTextbox.UserControl1
    'Private SEPPCommentTextBox As spellCheckTextbox.UserControl1


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
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.lblSEPPid.Text = String.Empty
        Me.CboLoadSEPPcodesList.SelectedIndex = -1
        Me.SEPPCommentTextBox.Text = String.Empty
        Me.btnUpdateREPCode.Enabled = False

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




    Private Sub StatutorySEPP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveData()
    End Sub

    Private Sub StatutorySEPP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txtComment = New spellCheckTextbox.UserControl1
        'txtComment.InitializeComponent()
        'ElementHost1.Child = txtComment
        'txtComment.text = String.Empty

        'AddHandler txtComment.TextChanged, AddressOf avAddressCtrl_TextChanged


        'SEPPCommentTextBox = New spellCheckTextbox.UserControl1
        'SEPPCommentTextBox.InitializeComponent()
        'ElementHost2.Child = SEPPCommentTextBox

        txtComment.text = String.Empty

        'AddHandler SEPPCommentTextBox.TextChanged, AddressOf avAddressCtrl_TextChanged

        SEPPCommentTextBox.text = String.Empty

        LoadComments()

        Me.LoadSEPPcodesListTableAdapter.Fill(Me.AAdata.LoadSEPPcodesList)
        Try
            Me.Grid_Statutry_SEPP_RECORDSTableAdapter.Fill(Me.AAdata.Grid_Statutry_SEPP_RECORDS, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        LoadForm()
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
                        .CommandText = "usp_GetTheSepComment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@SEPPCOMMENT", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        txtComment.text = .Parameters("@SEPPCOMMENT").Value.ToString

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadComments routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub SaveData()

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
                        .CommandText = "usp_Statutory_SEPP_Update"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@SEPPCOMMENTS", SqlDbType.NText).Value = Me.SEPPCommentTextBox.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using


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
                        .CommandText = "usp_InsertUpdateSEPrecord"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(Me.lblSEPPid.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.CboLoadSEPPcodesList.SelectedValue.ToString
                        .Parameters.Add("@COMMENTS", SqlDbType.NText).Value = Me.txtComment.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateREPCode_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.lblSEPPid.Text = String.Empty
        Me.CboLoadSEPPcodesList.SelectedIndex = -1
        Me.SEPPCommentTextBox.Text = String.Empty
        Me.btnUpdateREPCode.Enabled = False

        Try
            Me.Grid_Statutry_SEPP_RECORDSTableAdapter.Fill(Me.AAdata.Grid_Statutry_SEPP_RECORDS, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.CboLoadSEPPcodesList.SelectedIndex = -1

    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Sub Grid_Statutry_SEPP_RECORDSDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Statutry_SEPP_RECORDSDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.lblSEPPid.Text = Me.Grid_Statutry_SEPP_RECORDSDataGridView.CurrentRow.Cells(0).Value.ToString
        Me.CboLoadSEPPcodesList.SelectedValue = CInt(Grid_Statutry_SEPP_RECORDSDataGridView.CurrentRow.Cells(3).Value)
        Me.txtComment.Text = Me.Grid_Statutry_SEPP_RECORDSDataGridView.CurrentRow.Cells(2).Value.ToString
        Me.btnUpdateREPCode.Enabled = Not _Islocked

    End Sub

    Private Sub CboLoadSEPPcodesList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboLoadSEPPcodesList.SelectedIndexChanged
        Me.btnUpdateREPCode.Enabled = Not _Islocked
    End Sub
End Class