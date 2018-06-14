Imports System.Data.SqlClient
Imports System.Text

Public Class NCCBuildingSolutionsList
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadGrid()

    End Sub


    Private _daNumber As String
    Public WriteOnly Property DANumber() As String
        Set(ByVal value As String)
            _daNumber = value
        End Set
    End Property

    Private _editing As Boolean
    Public WriteOnly Property EditForm() As Boolean

        Set(ByVal value As Boolean)
            _editing = value
        End Set
    End Property

    Private Sub LoadGrid()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_NCC_PerformanceSolutionCode"




                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdNCCcodes.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadGrid routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function BuildCheckedItemsList() As String

        Dim sItemsList As String = String.Empty

        Dim Rows As New ArrayList()
        Dim sb As New StringBuilder

        For I As Integer = 0 To gvwNCCcodes.SelectedRowsCount() - 1

            If (gvwNCCcodes.GetSelectedRows()(I) >= 0) Then

                Rows.Add(gvwNCCcodes.GetDataRow(gvwNCCcodes.GetSelectedRows()(I)))

            End If
        Next

        For I As Integer = 0 To Rows.Count - 1
            Dim Row As DataRow = CType(Rows(I), DataRow)

            sb.Append(Row("CodeIdx").ToString & "|")


        Next

        sItemsList = sb.ToString

        Return sItemsList

    End Function

    Private Sub InsertNCCCode(codeIdx As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertNCCCode routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_DABuildingSolutionCodes"

                        .Parameters.Add("@DANo", SqlDbType.VarChar).Value = _daNumber
                        .Parameters.Add("@CodeIdx", SqlDbType.Int).Value = codeIdx

                        .ExecuteNonQuery()


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertNCCCode routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadExistingSolutions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadExistingSolutions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_LoadExistingBuildingSolutionsForDA"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = _daNumber




                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            For I As Integer = 0 To gvwNCCcodes.DataRowCount - 1

                                If (gvwNCCcodes.GetRowCellValue(i, "CodeIdx").ToString = objDataReader.Item("CodeIdx").ToString)  Then

                                    gvwNCCcodes.SelectRow(i)

                                End If
                            Next


                        Loop
                    End Using


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadExistingSolutions routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private sub RemoveData

        Using cn As New SqlConnection(my.settings.ConnectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveData routine - form " & Me.name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_ExistingBuildingSolutionsForDA"

                        .Parameters.Add("@DANO", SqlDbType.varchar).Value = _daNumber

                        .ExecuteNonQuery


                    End With

 

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveData routine - form " & Me.name)

            End Try
        End Using


    End sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click


        If _editing Then RemoveData


        Dim Rows As New ArrayList()

        For I As Integer = 0 To gvwNCCcodes.SelectedRowsCount() - 1

            If (gvwNCCcodes.GetSelectedRows()(I) >= 0) Then

                Rows.Add(gvwNCCcodes.GetDataRow(gvwNCCcodes.GetSelectedRows()(I)))
                Dim Row As DataRow = CType(Rows(I), DataRow)

                InsertNCCCode(Row("CodeIdx"))


            End If
        Next

        DialogResult = DialogResult.OK

    End Sub

    Private Sub NCCBuildingSolutionsList_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _editing Then LoadExistingSolutions()

    End Sub
End Class