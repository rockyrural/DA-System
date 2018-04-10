Public Class AssessmentType
    Private AssessCodeID As Integer
    Private AssessDesc As String
    Private StdConditions As Boolean

    Public Sub New(ByVal AssessID As Integer, ByVal Description As String, ByVal STDCond As Boolean)
        AssessCodeID = AssessID
        AssessDesc = Description
        StdConditions = STDCond
    End Sub

    Public ReadOnly Property AssessID() As Integer
        Get
            Return AssessCodeID
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return AssessDesc
        End Get
    End Property

    Public ReadOnly Property STDCond() As Boolean
        Get
            Return StdConditions
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return AssessDesc
    End Function

End Class
