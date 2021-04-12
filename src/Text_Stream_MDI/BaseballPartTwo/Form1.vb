Public Class BaseballForm
    Dim file As XElement = XElement.Load("Baseball.xml")
    Private Sub frmBaseball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the list box with team names
        Dim query = From teams In file.Descendants("player")
                    Let team As String = teams.<team>.Value()
                    Order By team Ascending
                    Select team
                    Distinct

        lstTeams.DataSource = query.ToList
    End Sub

    Private Function getAvg(hits As Integer, atBat As Integer) As Double
        Dim avg As Double

        avg = hits / atBat
        FormatNumber(avg, 2)
        Return avg
    End Function

    Private Sub lstTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeams.SelectedIndexChanged
        Dim teamHits As Integer
        Dim teamAtBats As Integer
        Dim teamAvg As Double

        'get data for each player in a selected team
        Dim query = From players In file.Descendants("player")
                    Let team As String = players.<team>.Value
                    Let name As String = players.<name>.Value
                    Let hits As Integer = Convert.ToInt32(players.<hits>.Value)
                    Let atBats As Integer = Convert.ToInt32(players.<atBats>.Value)
                    Let batAvg As Double = getAvg(hits, atBats)
                    Where team = lstTeams.Text
                    Select name, team, hits, atBats, batAvg

        'get team average
        For i As Integer = 0 To query.Count() - 1
            teamAtBats += query(i).atBats
            teamHits += query(i).hits
        Next

        teamAvg = getAvg(teamHits, teamAtBats)
        'get the list of players from the selected team who meet the criteria (their batting avg > than team avg)
        Dim finalPlayers = From player In query
                           Let avgOutput = FormatNumber(player.batAvg, 3)
                           Where player.batAvg > teamAvg
                           Select player.name, avgOutput

        dgvOutput.DataSource = finalPlayers.ToList
        dgvOutput.Columns(0).HeaderText = "Player"
        dgvOutput.Columns(1).HeaderText = "Batting Average"
    End Sub
End Class
