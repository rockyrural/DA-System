Public Class ApplicationStatus
    Private Status As String
    Private StatusID As Integer

    Public Sub New(ByVal sStatus As String, ByVal sID As Integer)
        Status = sStatus
        StatusID = sID
    End Sub

    Public ReadOnly Property ApplicationStatus() As String
        Get
            Return Status
        End Get
    End Property

    Public ReadOnly Property AppStatCode() As Integer
        Get
            Return StatusID
        End Get
    End Property
End Class
