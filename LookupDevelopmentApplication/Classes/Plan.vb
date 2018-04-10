Public Class Plan
    Private mdlPlanNumber As String
    Private mdlPlanSet As String
    Private mdlJobTitle As String
    Private mdldescription As String
    Private mdlStreet As String



    Public Sub New(ByVal PlanNumber As String, ByVal PlanSet As String, ByVal JobTitle As String, ByVal Description As String, ByVal Street As String)
        mdlPlanNumber = PlanNumber
        mdlPlanSet = PlanSet
        mdlJobTitle = JobTitle
        mdldescription = Description
        mdlStreet = Street

    End Sub

    Public ReadOnly Property PlanNumber() As String
        Get
            Return mdlPlanNumber
        End Get
    End Property

    Public ReadOnly Property PlanSet() As String
        Get
            Return mdlPlanSet
        End Get
    End Property

    Public ReadOnly Property JobTitle() As String
        Get
            Return mdlJobTitle
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return mdldescription
        End Get
    End Property

    Public ReadOnly Property Street() As String
        Get
            Return mdlStreet
        End Get
    End Property


    Public Overrides Function ToString() As String
        Return mdlPlanNumber
    End Function
End Class
