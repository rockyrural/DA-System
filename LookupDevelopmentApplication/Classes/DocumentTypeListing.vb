Public Class DocumentTypeListing
    Private DocumentType As String
    Private Description As String
    Private ReptName As String


    Public Sub New(ByVal DocType As String, ByVal Desc As String, ByVal RptName As String)
        DocumentType = DocType
        Description = Desc
        ReptName = RptName
    End Sub

    Public ReadOnly Property DocTypeName() As String
        Get
            Return DocumentType
        End Get
    End Property

    Public ReadOnly Property DocDescription() As String
        Get
            Return Description
        End Get
    End Property
 
    Public ReadOnly Property TheReportName() As String
        Get
            Return ReptName
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Description
    End Function

End Class
