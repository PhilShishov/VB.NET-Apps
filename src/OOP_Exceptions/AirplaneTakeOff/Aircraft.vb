Public Class Aircraft
    Public Property Name As String
    Public Property TakeOffVelocity As Double
    Public Property Acceleration As Double

    Public ReadOnly Property TakeOffTime As Double
        Get
            Return TakeOffVelocity / Acceleration
        End Get
    End Property

    Public ReadOnly Property TakeOffDistance As Double
        Get
            Return Acceleration * (TakeOffTime ^ 2)
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
