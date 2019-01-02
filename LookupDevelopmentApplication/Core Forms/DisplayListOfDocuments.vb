Imports System.Data.SqlClient

Public Class DisplayListOfDocuments

    Private _appid As string
    Public WriteOnly Property ApplicationID() As string
        Set(ByVal value As string)
            _appid = value
        End Set
    End Property
    Private _fileNumber as string
    Public WriteOnly Property FileNumber() As string
        Set(ByVal value As string)
            _fileNumber = value
        End Set
    End Property

    Private Sub LoadDocumentList(FileNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDocumentList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_138_LoadUpListOfDocumentsAvailableOnFile"

                        .Parameters.Add("@FILEID", SqlDbType.VarChar).Value = FileNo


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdListOfDocuments.DataSource = objDT


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDocumentList routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub InsertNewDocument()


        Dim myobj As DataRowView = CType(gvwListOfDocuments.GetFocusedRow, DataRowView)


        Dim InsertDocData As New InsertDocumentData

        With InsertDocData
            .ApplicationType = "DA"
            .DocumentType = myobj.Row.Item("DSummary").ToString
            .ApplicationNo = _appid
            .TheAuthor = MyUserId
            .TheImageName = myobj.Row.Item("DId").ToString.Replace(".", "_") 
            .Notes = myobj.Row.Item("DSummary").ToString
            .InsertDocumentsIntoDAsystem()

        End With

        'Using cn As New SqlConnection(My.Settings.cnDAsystem)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in InsertNewDocument routine - form " & Me.Name)

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_138_Insert_EASE_Document"

        '                .Parameters.Add("@APPID", SqlDbType.Int).Value = _appid
        '                .Parameters.Add("@DOCID", SqlDbType.NVarChar).Value = myobj.Row.Item("DId").ToString()
        '                .ExecuteNonQuery()
        '            End With

        '        End Using


        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in InsertNewDocument routine - form " & Me.Name)

        '    End Try
        'End Using



    End Sub

    Private Sub btnInsertDocument_Click(sender As Object, e As EventArgs) Handles btnInsertDocument.Click
        InsertNewDocument()
    End Sub

    Private Sub gvwListOfDocuments_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwListOfDocuments.RowClick
        btnInsertDocument.Enabled = True

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If txtFileNumber.Text = String.Empty Then
            MessageBox.Show("You MUST enter a valid file number to search", "File Number Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            LoadDocumentList(txtFileNumber.Text)

            btnInsertDocument.Enabled = True

        End If

    End Sub

    Private Sub DisplayListOfDocuments_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtFileNumber.Text=_fileNumber
    End Sub
End Class