Public Class AirplaneTakeOffForm
    Private ReadOnly Names() As String = {"A-747", "A-737", "C-150", "D-240"}
    Private ReadOnly TakeOffVelocity() As Double = {250, 264, 270, 240}
    Private ReadOnly Acceleration() As Double = {33.5, 44.2, 37.1, 51.9}
    Private planes() As Aircraft

    Private Sub frmAirplaneTakeOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim planes(Names.Length - 1)

        For i As Integer = 0 To planes.Length - 1
            planes(i) = New Aircraft With {
                .Name = Names(i),
                .TakeOffVelocity = TakeOffVelocity(i),
                .Acceleration = Acceleration(i)
            }
        Next

        lstAircraft.DataSource = planes

    End Sub

    Private Sub lstAircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAircraft.SelectedIndexChanged
        Dim aircraft As Aircraft = CType(lstAircraft.SelectedItem, Aircraft)

        lblResult.Text = $"The {aircraft.Name} aircraft has a required take off velocity of {aircraft.TakeOffVelocity:n} " &
                         $"ft/sec and acceleration constant of {aircraft.Acceleration:n}. " &
                         $"Therefore, it requires {aircraft.TakeOffTime:n} seconds to take off, with the distance " &
                         $"{aircraft.TakeOffDistance:n} feet."
    End Sub
End Class
