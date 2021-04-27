Public Class Hammer
    Inherits Tool

    Private _twoHanded As Boolean
    Public Sub New(weight As Integer, name As String, twoHanded As Boolean)
        MyBase.New(weight, name)
        Me.TwoHanded = twoHanded
    End Sub

    Public Property TwoHanded As Boolean
        Get
            Return _twoHanded
        End Get
        Private Set(value As Boolean)
            _twoHanded = value
        End Set
    End Property

    Public Overrides Sub Work()
        Console.WriteLine("I'm hammering")
    End Sub
End Class