Public Class TimeClock

    Private startApp As Date
    Private stopApp As Date

    Public Property ClientName As String

    Public ReadOnly Property StartTime As Date
        Get
            Return startApp
        End Get
    End Property

    Public ReadOnly Property StopTime As Date
        Get
            Return stopApp
        End Get
    End Property

    Public ReadOnly Property Elapsed As TimeSpan
        Get
            Return Now.Subtract(startApp)
        End Get
    End Property

    Public ReadOnly Property TotalElapsed As TimeSpan
        Get
            Return stopApp.Subtract(startApp)
        End Get
    End Property

    Public Sub StartClock()
        startApp = Now
    End Sub

    Public Sub StopClock()
        stopApp = Now
    End Sub

End Class
