Public Class TankMode
    Private Mode As String
    Private ModeCode As String

    Public Sub New(ByVal sMode As String, ByVal Code As String)
        Mode = sMode
        ModeCode = Code
    End Sub

    Public ReadOnly Property TheMode() As String
        Get
            Return Mode
        End Get
    End Property

    Public ReadOnly Property Code() As String
        Get
            Return ModeCode
        End Get
    End Property
End Class
