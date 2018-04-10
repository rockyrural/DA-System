Public Class RFSSubvisionType
    Private AreaName As String
    Private AreaKey As String

    Public Sub New(ByVal Name As String, ByVal Key As String)
        AreaName = Name
        AreaKey = Key
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return AreaName
        End Get
    End Property

    Public ReadOnly Property Key() As String
        Get
            Return AreaKey
        End Get
    End Property
End Class
