Public Class AlarmEventProperties
    Inherits EventArgs

    Public volume As Integer

    Public Sub New(volume As Integer)
        Me.volume = volume
    End Sub
End Class
