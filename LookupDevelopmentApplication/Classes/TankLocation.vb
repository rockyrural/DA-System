Public Class TankLocation
    Private Location As String
    Private LocCode As String

    Public Sub New(ByVal sLocation As String, ByVal Code As String)
        Location = sLocation
        LocCode = Code
    End Sub

    Public ReadOnly Property UporDown() As String
        Get
            Return Location
        End Get
    End Property

    Public ReadOnly Property Code() As String
        Get
            Return LocCode
        End Get
    End Property
End Class
