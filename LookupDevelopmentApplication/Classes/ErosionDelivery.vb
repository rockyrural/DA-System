Public Class ErosionDelivery
    Private Method As String
    Private Code As String

    Public Sub New(ByVal sLocation As String, ByVal sCode As String)
        Method = sLocation
        Code = sCode
    End Sub

    Public ReadOnly Property Delivery() As String
        Get
            Return Method
        End Get
    End Property

    Public ReadOnly Property DeliveryCode() As String
        Get
            Return Code
        End Get
    End Property
End Class
