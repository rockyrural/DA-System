Imports system.data.sqlclient
Public Class RemoveDocument


    Private sDocumentNumber As String
    Private DADocID As Integer


    Public WriteOnly Property DocumentToRemove() As String
        Set(ByVal value As String)
            sDocumentNumber = value
        End Set
    End Property

    Public WriteOnly Property DocumentID() As Integer
        Set(ByVal value As Integer)
            DADocID = value
        End Set
    End Property

    Public Sub RemoveDocument()
        If RemoveEaseDocument() Then RemoveDADocument()



    End Sub

    Private Function RemoveEaseDocument() As Boolean

        Dim result As Boolean = True

        Using cn As New SqlConnection(My.Settings.cnEASE)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveEaseDocument routine in class RemoveDocument")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDocumentInsertReasonWhy"

                        .Parameters.Add("@DOCID", SqlDbType.NVarChar).Value = sDocumentNumber.Replace("_", ".")
                        .Parameters.Add("@REASON", SqlDbType.NVarChar).Value = "Reprinted in DA system "
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveEaseDocument routine in class RemoveDocument")
                result = False
            End Try
        End Using

        Return result

    End Function
    Private Sub RemoveDADocument()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveDADocument routine in class RemoveDocument")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDAdocument"

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = DADocID
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveDADocument routine in class RemoveDocument")

            End Try
        End Using



    End Sub
End Class
