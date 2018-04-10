Imports System.Data.SqlClient

Public Class InsertDocumentData

    Private strEmailFileSize As String = String.Empty

    Private AppNo As String
    Public WriteOnly Property ApplicationNo() As String
        Set(ByVal value As String)
            AppNo = value
        End Set
    End Property

    Private AppType As String
    Public WriteOnly Property ApplicationType() As String
        Set(ByVal value As String)
            AppType = value
        End Set
    End Property

    Private Author As Integer
    Public WriteOnly Property TheAuthor() As Integer
        Set(ByVal value As Integer)
            Author = value
        End Set
    End Property

    Private DocType As String
    Public WriteOnly Property DocumentType() As String
        Set(ByVal value As String)
            DocType = value
        End Set
    End Property
    Private ImageName As String
    Public WriteOnly Property TheImageName() As String
        Set(ByVal value As String)
            ImageName = value
        End Set
    End Property
    Private Note As String
    Public WriteOnly Property Notes() As String
        Set(ByVal value As String)
            Note = value
        End Set
    End Property

    Private _DocumentID As Integer
    Public ReadOnly Property DocumentID() As Integer
        Get
            Return _DocumentID
        End Get

    End Property


    Public Sub InsertDocumentsIntoDAsystem()



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertDocumentsIntoDAsystem routine - CommonPrintFunction ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_DALetterData"

                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = AppType
                        .Parameters.Add("@AUTHORID", SqlDbType.Int).Value = Author
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@IMAGENAME", SqlDbType.NVarChar).Value = ImageName
                        .Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = Note
                        .Parameters.Add("@RETURN", SqlDbType.Int).Direction = ParameterDirection.Output


                        .ExecuteNonQuery()

                        _DocumentID = CInt(.Parameters("@RETURN").Value)


                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertDocumentsIntoDAsystem routine - CommonPrintFunction ")

            End Try
        End Using



    End Sub

End Class
