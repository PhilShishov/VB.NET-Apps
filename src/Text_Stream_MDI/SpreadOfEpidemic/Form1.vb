Public Class SpreadOfEpidemicForm

    Dim dayNumber As Integer

    'people(0) = number susceptible, people(1) = number sick one day
    'people(2) = number sick two days, people(3) = number immune
    Dim people() As Integer = {9700, 200, 100, 0}

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        DrawGraph()
    End Sub

    Private Sub DrawGraph()
        Dim g As Graphics = picOutput.CreateGraphics()
        picOutput.Refresh()
        g.DrawLine(Pens.Black, 45, 100, picOutput.Width, 100) 'draws the x-axis
        g.DrawLine(Pens.Black, 45, 100, 45, 0) 'draws the y-axis
        g.DrawLine(Pens.Black, 40, 0, 50, 0)   'Draw tick mark
        g.DrawString("10,000", Me.Font, Brushes.Blue, 0, 0)  'Label tick mark.
        g.DrawString("Susceptible    Sick 1 Day   Sick 2 Days   Immune", Me.Font, Brushes.Blue, 42, 102)

        For i = 0 To people.Count() - 1
            g.FillRectangle(Brushes.Blue, 60 + i * 75, CInt(100 - people(i) / 100), 25, CInt(people(i) / 100))
        Next

        g.DrawString("Day " & dayNumber, Me.Font, Brushes.Blue, 125, 0)  'Label tick mark.
    End Sub

    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        Dim totalSick As Integer
        dayNumber += 1
        totalSick = people(1) + people(2)

        If totalSick = 0 Then
            MessageBox.Show("All people are immune!", "Epidemic Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        people(3) = people(3) + people(2)
        people(2) = people(1)
        people(1) = CInt(0.0001735 * totalSick * people(0))
        people(0) = 10000 - people(1) - people(2) - people(3)
        DrawGraph()
    End Sub
End Class
