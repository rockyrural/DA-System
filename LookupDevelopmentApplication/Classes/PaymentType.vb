Public Class PaymentType
    Private PaymentID As Integer
    Private PaymentDesc As String
    Private CalculationType As String
    Private FlatFee As Double
    Private PerUnitCost As Double
    Private ChargeUnitType As String
    Private MinimumCharge As Double
    Private ChargeCategory As String



    Public Sub New(ByVal PayID As Integer, ByVal Description As String, ByVal ChargeCalcType As String, ByVal ChargeFlatFee As Double, ByVal ChargePerUnit As Double, ByVal UnitType As String, ByVal ChargeMinimum As Double, ByVal Category As String)
        PaymentID = PayID
        PaymentDesc = Description
        CalculationType = ChargeCalcType
        FlatFee = ChargeFlatFee
        PerUnitCost = ChargePerUnit
        MinimumCharge = ChargeMinimum
        ChargeUnitType = UnitType
        ChargeCategory = Category

    End Sub

    Public ReadOnly Property PayID() As Integer
        Get
            Return PaymentID
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return PaymentDesc
        End Get
    End Property

    Public ReadOnly Property UnitType() As String
        Get
            Return ChargeUnitType
        End Get
    End Property

    Public ReadOnly Property Category() As String
        Get
            Return ChargeCategory
        End Get
    End Property


    Public ReadOnly Property ChargeCalcType() As String
        Get
            Return CalculationType
        End Get
    End Property


    Public ReadOnly Property ChargeFlatFee() As Double
        Get
            Return FlatFee
        End Get
    End Property

    Public ReadOnly Property ChargePerUnit() As Double
        Get
            Return PerUnitCost
        End Get
    End Property


    Public ReadOnly Property ChargeMinimum() As Double
        Get
            Return MinimumCharge
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return PaymentDesc
    End Function
End Class
