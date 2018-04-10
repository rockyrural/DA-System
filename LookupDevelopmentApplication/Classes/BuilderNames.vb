Public Class BuilderNames
    Private BuildersName As String
    Private BuildersAddress As String
    Private BuildersTown As String
    Private BuildersPCODE As String

    Private LicenceNo As String
    Private PhoneNo As String
    Private ID As Integer


    Public Sub New(ByVal Name As String, ByVal Licence As String, ByVal Address As String, ByVal Town As String, ByVal PCode As String, _
                    ByVal Phone As String, ByVal IDno As Integer)
        BuildersName = Name
        BuildersAddress = Address
        BuildersTown = Town
        BuildersPCODE = PCode
        LicenceNo = Licence
        PhoneNo = Phone
        ID = IDno

    End Sub

    Public ReadOnly Property BldName() As String
        Get
            Return BuildersName
        End Get
    End Property

    Public ReadOnly Property BldAddress() As String
        Get
            Return BuildersAddress
        End Get
    End Property
    Public ReadOnly Property BldTown() As String
        Get
            Return BuildersTown
        End Get
    End Property
    Public ReadOnly Property BldPcode() As String
        Get
            Return BuildersPCODE
        End Get
    End Property


    Public ReadOnly Property Licence() As String
        Get
            Return LicenceNo
        End Get
    End Property

    Public ReadOnly Property Phone() As String
        Get
            Return PhoneNo
        End Get
    End Property

    Public ReadOnly Property IDno() As Integer
        Get
            Return ID
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return BuildersName
    End Function

End Class
