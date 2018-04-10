Public Class Depots
    Private DepotName As String
    Private DepotKey As String

    Public Sub New(ByVal Name As String, ByVal Key As String)
        DepotName = Name
        DepotKey = Key
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return DepotName
        End Get
    End Property

    Public ReadOnly Property Key() As String
        Get
            Return DepotKey
        End Get
    End Property
End Class
