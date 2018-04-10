Imports System.Data
Imports System.Data.SqlClient

Public Class DABase
    Implements IDisposable

    Private disposedValue As Boolean = False        ' To detect redundant calls
    'Class level variables atha are available to the classes that instantiate me
    Public SQL As String

    Public Connection As SqlConnection
    Public Command As SqlCommand
    Public DataAdapter As SqlDataAdapter
    Public DataReader As SqlDataReader

    Public Sub New()
        'Build the SQL connection string and initialise the connection object
        Connection = New SqlConnection(My.Settings.cnLIMES)
    End Sub

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If Not DataReader Is Nothing Then
                    DataReader.Close()
                    DataReader = Nothing
                End If
                If Not DataAdapter Is Nothing Then
                    DataAdapter.Dispose()
                    DataAdapter = Nothing
                End If
                If Not Command Is Nothing Then
                    Command.Dispose()
                    Command = Nothing
                End If
                If Not Connection Is Nothing Then
                    Connection.Close()
                    Connection.Dispose()
                    Connection = Nothing
                End If

            End If

        End If
        Me.disposedValue = True
    End Sub
    Public Sub OpenConnection()
        Try
            Connection.Open()
        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
                      sqlExceptionErr.InnerException)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Throw New System.Exception(InvalidOperationExceptionErr.Message, _
            InvalidOperationExceptionErr.InnerException)

        End Try
    End Sub
    Public Sub CloseConnection()
        Connection.Close()
    End Sub
    Public Sub InitializeCommand()
        If Command Is Nothing Then
            Try
                Command = New SqlCommand(SQL, Connection)
                'see if this is a stored procedure
                If Not SQL.ToUpper.StartsWith("SELECT ") _
                And Not SQL.ToUpper.StartsWith("INSERT ") _
                And Not SQL.ToUpper.StartsWith("UPDATE ") _
                And Not SQL.ToUpper.StartsWith("DELETE ") Then
                    Command.CommandType = CommandType.StoredProcedure
                End If
            Catch sqlExceptionErr As SqlException
                Throw New System.Exception(sqlExceptionErr.Message, _
                sqlExceptionErr.InnerException)

            End Try
        End If
    End Sub
    Public Sub AddParameter(ByVal Name As String, ByVal Type As SqlDbType, _
                            ByVal Size As Integer, ByVal Value As Object)
        Try
            Command.Parameters.Add(Name, Type, Size).Value = Value

        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
            sqlExceptionErr.InnerException)

        End Try

    End Sub
    Public Sub InitializeDataAdapter()
        Try
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = Command

        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
            sqlExceptionErr.InnerException)

        End Try
    End Sub
    Public Sub FillDataSet(ByRef oDataSet As DataSet, ByVal TableName As String)
        Try
            InitializeCommand()
            InitializeDataAdapter()
            DataAdapter.Fill(oDataSet, TableName)

        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
            sqlExceptionErr.InnerException)
        Finally
            Command.Dispose()
            Command = Nothing
            DataAdapter.Dispose()
            DataAdapter = Nothing
        End Try
    End Sub
    Public Sub FillDataTable(ByRef oDataTable As DataTable)
        Try
            InitializeCommand()
            InitializeDataAdapter()
            DataAdapter.Fill(oDataTable)

        Catch sqlExceptionErr As sqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
            sqlExceptionErr.InnerException)
        Finally
            Command.Dispose()
            Command = Nothing
            DataAdapter.Dispose()
            DataAdapter = Nothing

        End Try
    End Sub
    Public Function ExecuteStoredProcedure() As Integer
        Try
            OpenConnection()
            ExecuteStoredProcedure = Command.ExecuteNonQuery
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        Finally
            CloseConnection()

        End Try
    End Function

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
