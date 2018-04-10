Public Class DraftConditionsList
    Private ID As Integer
    Private Description As String
    Private CondCode As String
    Private FreeForm As Boolean
    Private WordDocument As String




    Public Sub New(ByVal CondID As Integer, ByVal Desc As String, ByVal ConditCode As String, ByVal Fform As Boolean, ByVal DocLocation As String)
        ID = CondID
        Description = Desc
        CondCode = ConditCode
        FreeForm = Fform
        WordDocument = DocLocation
    End Sub

    Public ReadOnly Property CodeID() As Integer
        Get
            Return ID
        End Get
    End Property

    Public ReadOnly Property DocDescription() As String
        Get
            Return Description
        End Get
    End Property


    Public ReadOnly Property ConditionCode() As String
        Get
            Return CondCode
        End Get
    End Property

    Public ReadOnly Property IsFreeForm() As Boolean
        Get
            Return FreeForm
        End Get
    End Property
    Public ReadOnly Property WordDocLoc() As String
        Get
            Return WordDocument
        End Get
    End Property


    Public Overrides Function ToString() As String
        Return CondCode
    End Function

End Class
