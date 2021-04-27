Public Class ElectricScrewdriver
    Inherits Tool

    Private _batteryCapacity As Integer

    Public Sub New(weight As Integer, name As String, batteryCapacity As Integer)
        MyBase.New(weight, name)
        Me.BatteryCapacity = batteryCapacity
    End Sub

    Public Property BatteryCapacity As Integer
        Get
            Return _batteryCapacity
        End Get
        Private Set(value As Integer)
            _batteryCapacity = value
        End Set
    End Property

    Public Overrides Sub Work()
        Console.WriteLine("I'm screwing electrically")
    End Sub
End Class