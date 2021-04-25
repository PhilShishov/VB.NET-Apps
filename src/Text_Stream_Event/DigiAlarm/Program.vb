Module Program
    Sub Main()
        Dim person As Person = New Person()
        Dim grandma As Grandma = New Grandma()
        Dim alarm As AlarmClock = New AlarmClock()
        AddHandler alarm.Ringing, AddressOf person.WakeUp
        AddHandler alarm.Ringing, AddressOf grandma.WakeUp
        Dim digiAlarm As DigiAlarm = New DigiAlarm()
        AddHandler digiAlarm.Ringing, AddressOf person.WakeUp
        AddHandler digiAlarm.Ringing, AddressOf grandma.WakeUp

        alarm.Ring()
        digiAlarm.Ring()
        Console.ReadKey()
    End Sub
End Module
