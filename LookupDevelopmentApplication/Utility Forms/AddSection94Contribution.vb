Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class AddSection94Contribution

    Private errorProvider As New DXErrorProvider.DXErrorProvider

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadSection94TypeList()
        LoadSection94CodeList()

    End Sub


    Private _DANo As String

    Public WriteOnly Property DANo() As String

        Set(ByVal value As String)
            _DANo = value
        End Set

    End Property



    Private Sub LoadSection94TypeList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94TypeList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpS94TypeList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboS94Type.Properties
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cboS94Type.Properties.Columns
                col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                col2.Add(New LookUpColumnInfo("ValueMember", 0))

                col2.Item(1).Visible = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94TypeList routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadSection94CodeList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94CodeList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_LoadUpS94CodeList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboSection94Code.Properties
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cboSection94Code.Properties.Columns
                col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                col2.Add(New LookUpColumnInfo("ValueMember", 0))

                col2.Item(1).Visible = False

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94CodeList routine - form " & Me.Name)

            End Try
        End Using


    End Sub


    Private Function DataFieldsNotComplete() As Boolean
        Dim result As Boolean = False


        If Me.cboSection94Code.EditValue Is Nothing Then
            With errorProvider
                .SetError(Me.cboSection94Code, "Section 94 code is a required field")
            End With
            result = True
        Else
            errorProvider.SetError(Me.cboSection94Code, "")

        End If

        If Me.cboS94Type.EditValue Is Nothing Then
            With errorProvider
                .SetError(Me.cboS94Type, "Section 94 type is a required field")
            End With
            result = True
        Else
            errorProvider.SetError(Me.cboS94Type, "")

        End If

        If Me.txtS94ContCalc.Text = String.Empty Then
            With errorProvider
                .SetError(Me.txtS94ContCalc, "Contribution calculation is a required field")
            End With
            result = True
        Else
            errorProvider.SetError(Me.txtS94ContCalc, "")

        End If


        Return result
    End Function

    Private Sub SaveTheData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_Section94Contibution"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = _DANo
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = cboSection94Code.EditValue
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(txtS94ContCalc.Text)
                        .Parameters.Add("@NOTE", SqlDbType.NVarChar).Value = Me.txtS94CalcNote.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboS94Type.EditValue)


                        .ExecuteNonQuery()

                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If DataFieldsNotComplete() Then Return

        SaveTheData()

        DialogResult = DialogResult.OK



    End Sub

End Class