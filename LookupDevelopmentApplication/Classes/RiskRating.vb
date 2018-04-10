Public Class RiskRating
    Private mdlRiskName As String
    Private mdlRiskID As Integer

    Public Sub New(ByVal Risk As String, ByVal RiskID As Integer)
        mdlRiskName = Risk
        mdlRiskID = RiskID
    End Sub

    Public ReadOnly Property Risk() As String
        Get
            Return mdlRiskName
        End Get
    End Property

    Public ReadOnly Property RiskID() As Integer
        Get
            Return mdlRiskID
        End Get
    End Property
End Class
