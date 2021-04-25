Public Class DigiAlarm
    Inherits AlarmClock

    Public Overrides Sub Ring()
        Console.WriteLine("Digital Alarm went off")
        CallRingingEvent(20)
    End Sub
End Class
