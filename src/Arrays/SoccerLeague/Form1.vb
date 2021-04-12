Public Class SoccerLeagueForm

    Const numTeams = 6
    Structure Teams
        Dim name As String
        Dim wins As Integer
    End Structure

    ReadOnly teamArr(numTeams - 1) As Teams
    ReadOnly data(,) As Integer = {
                                {-1, 1, 1, 0, 0, 1},
                                {0, -1, 1, 1, 0, 0},
                                {0, 0, -1, 0, 1, 1},
                                {1, 0, 1, -1, 1, 1},
                                {1, 1, 0, 0, -1, 1},
                                {0, 1, 0, 0, 0, -1}
                             }

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        AssignNames()

        For r = 0 To numTeams - 1
            For c = 0 To numTeams - 1
                If data(r, c) = 1 Then
                    teamArr(r).wins += 1
                End If
            Next
        Next

        Dim query = From team In teamArr
                    Let Name As String = team.name
                    Let Wins As Integer = team.wins
                    Order By Wins Descending
                    Select Name, Wins

        dgvOutput.DataSource = query.ToList
        dgvOutput.Columns(0).HeaderText = "Team"
        dgvOutput.Columns(1).HeaderText = "Wins"

    End Sub

    Private Sub AssignNames()
        teamArr(0).name = "Jazz"
        teamArr(1).name = "Jets"
        teamArr(2).name = "Owls"
        teamArr(3).name = "Rams"
        teamArr(4).name = "Cubs"
        teamArr(5).name = "Zips"
    End Sub
End Class
