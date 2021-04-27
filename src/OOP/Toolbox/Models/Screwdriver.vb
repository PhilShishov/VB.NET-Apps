Public Class Screwdriver
    Inherits Tool

    Public Sub New(weight As Integer, name As String)
        MyBase.New(weight, name)
    End Sub

    Public Overrides Sub Work()
        Console.WriteLine("I'm screwing")
    End Sub
End Class
