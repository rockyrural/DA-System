Public Class ErosionStatus
    Private Status As String
    Private Code As String

    Public Sub New(ByVal sStatus As String, ByVal sCode As String)
        Status = sStatus
        Code = sCode
    End Sub

    Public ReadOnly Property TheStatus() As String
        Get
            Return Status
        End Get
    End Property

    Public ReadOnly Property TheCode() As String
        Get
            Return Code
        End Get
    End Property

End Class
