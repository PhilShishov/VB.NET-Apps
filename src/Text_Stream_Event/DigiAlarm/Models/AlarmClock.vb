Public Class AlarmClock
    Public Event Ringing As EventHandler(Of AlarmEventProperties)

    Protected Sub CallRingingEvent(volume As Integer)
        RaiseEvent Ringing(Me, New AlarmEventProperties(volume))
    End Sub

    Public Overridable Sub Ring()
        Console.WriteLine("The alarm went off")
        CallRingingEvent(10)
    End Sub
End Class
