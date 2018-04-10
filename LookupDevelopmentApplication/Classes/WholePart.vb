Public Class WholePart
    Private Name As String
    Private Code As String

    Public Sub New(ByVal sName As String, ByVal scode As String)
        Name = sName
        Code = scode
    End Sub

    Public ReadOnly Property WholeorPart() As String
        Get
            Return Name
        End Get
    End Property

    Public ReadOnly Property WholeorPartCode() As String
        Get
            Return Code
        End Get
    End Property
End Class
