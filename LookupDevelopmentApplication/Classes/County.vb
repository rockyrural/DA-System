Public Class County
    Private CountyName As String
    Private CountyCode As String

    Public Sub New(ByVal County As String, ByVal Code As String)
        CountyName = County
        CountyCode = Code
    End Sub

    Public ReadOnly Property County() As String
        Get
            Return CountyName
        End Get
    End Property

    Public ReadOnly Property Code() As String
        Get
            Return CountyCode
        End Get
    End Property
End Class
