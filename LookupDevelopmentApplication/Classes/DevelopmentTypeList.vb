Public Class DevelopmentTypeList
    Private _DevTypeID As Integer
    Private _DevType As String
    Private _IsRept As Boolean


    Public Sub New(ByVal DevTypeID As String, ByVal DevType As String, ByVal IsReport As Boolean)
        _DevTypeID = DevTypeID
        _DevType = DevType
        _IsRept = IsReport
    End Sub

    Public ReadOnly Property DevTypeID() As Integer
        Get
            Return _DevTypeID
        End Get
    End Property

    Public ReadOnly Property DevType() As String
        Get
            Return _DevType
        End Get
    End Property

    Public ReadOnly Property IsReport() As String
        Get
            Return _IsRept
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return _DevType
    End Function

End Class
