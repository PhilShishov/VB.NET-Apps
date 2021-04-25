Public Class Grandma
    Inherits Person

    Public Overrides Sub WakeUp(sender As Object, e As AlarmEventProperties)
        If (e.volume >= 20) Then
            Console.WriteLine("Grandma wakes up")
        End If
    End Sub
End Class
