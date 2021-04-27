Public Class Sawmill
    Inherits Tool

    Public Sub New(weight As Integer, name As String)
        MyBase.New(weight, name)
    End Sub

    Public Overrides Sub Work()
        Console.WriteLine("I'm cutting")
    End Sub
End Class
