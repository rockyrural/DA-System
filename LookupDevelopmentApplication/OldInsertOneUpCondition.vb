
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.DXErrorProvider


Public Class OldInsertOneUpCondition

    Private DAno As String
    Private err As ErrorProvider

    Private errorProvider As New DXErrorProvider


    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DAno = value
        End Set
    End Property

    Private ConditionID As Integer
    Public WriteOnly Property ID() As Integer
        Set(ByVal value As Integer)
            ConditionID = value
        End Set
    End Property

    Private Sub InsertOneUpCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ConditionCodeTableAdapter.Fill(Me.DAdatasets.ConditionCode)
        'Me.cboOneUpConditions.SelectedIndex = -1


        If ConditionID <> 0 Then

            Using cn As New SqlConnection(My.Settings.DataConnection)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in InsertOneUpCondition_Load routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_GetSpecialConditionForEdit"

                            .Parameters.Add("@ID", SqlDbType.Int).Value = ConditionID
                        End With



                        Using objDataReader As SqlDataReader = cmd.ExecuteReader
                            While objDataReader.Read
                                Me.cboOneUpConditions.EditValue = CInt(objDataReader.Item(0))
                                'Me.txtConditionText.Text = objDataReader.Item(1).ToString

                                If IsDBNull(objDataReader.Item(2)) Then

                                    RichEditControl1.Text = objDataReader.Item(1).ToString

                                Else

                                    RichEditControl1.RtfText = objDataReader.Item(2).ToString

                                End If

                            End While

                        End Using


                        'dgvSales.DataSource = objDT
                        'dgvSales.Refresh()

                    End Using
                     



                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in InsertOneUpCondition_Load routine - form " & Me.Name)

                End Try
            End Using

        End If

    End Sub

    Private Function CheckFormComplete() As Boolean
        Dim result As Boolean = True



        If Me.cboOneUpConditions.EditValue Is Nothing Then
            With errorProvider
                .SetError(cboOneUpConditions, "You are required to select a condition type")
                cboOneUpConditions.Focus()
                result = False
            End With
        Else
            errorProvider.SetError(cboOneUpConditions, "")
        End If

        If Me.RichEditControl1.Text.Length = 0 Then
            With err
                .SetIconAlignment(RichEditControl1, ErrorIconAlignment.MiddleRight)
                .SetIconPadding(RichEditControl1, 1)
                .SetError(RichEditControl1, "You are required to type in the condition")
                result = False
            End With
        Else
            err.SetError(RichEditControl1, "")
        End If

        Return result
    End Function

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If Not CheckFormComplete() Then Return

        If MessageBox.Show("Insert """ & cboOneUpConditions.Text & """ into the list?", "Insert condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If CheckOneUpConditionAlreadyExists(CInt(cboOneUpConditions.SelectedValue)) Then
        '    MessageBox.Show("Condition """ & Me.cboOneUpConditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsert_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertOneUpConditions"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = ConditionID
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboOneUpConditions.EditValue)
                        .Parameters.Add("@TEXT", SqlDbType.Text).Value = RichEditControl1.Text
                        .Parameters.Add("@INSERTTEXT", SqlDbType.Text).Value = RichEditControl1.RtfText

                        .ExecuteNonQuery()

                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsert_Click routine - form " & Me.Name)

            End Try
        End Using
        Me.Close()

    End Sub

    Private Function CheckOneUpConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckOneUpConditionAlreadyExists routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckIfOneUpCodeExists"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = condID
                        .Parameters.Add("@EXIST", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@EXIST").Value)

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckOneUpConditionAlreadyExists routine - form " & Me.Name)

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
End Class