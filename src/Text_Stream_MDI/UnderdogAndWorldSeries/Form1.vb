Public Class UnderdogWorldSeriesForm
    ReadOnly randomNumber As New Random

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Dim games As Integer
        Dim winner As String = ""
        ResetControls()
        For i As Integer = 1 To 10000
            PlaySeries(winner, games)
            If winner = "Underdog Wins" Then
                hsbUnderdog.Value += 1
            Else
                hsbFavorite.Value += 1
            End If

            Select Case games
                Case 4
                    hsbFour.Value += 1
                Case 5
                    hsbFive.Value += 1
                Case 6
                    hsbSix.Value += 1
                Case 7
                    hsbSeven.Value += 1
            End Select

            If i Mod 10 = 0 Then
                Updates(i)
                txtUnderdog.Refresh()
                txtFavorite.Refresh()
                txtFour.Refresh()
                txtFive.Refresh()
                txtSix.Refresh()
                txtSeven.Refresh()
                txtUnderdogPercent.Refresh()
                txtFavoritePercent.Refresh()
                txtFourPercent.Refresh()
                txtFivePercent.Refresh()
                txtSixPercent.Refresh()
                txtSevenPercent.Refresh()
            End If
        Next

        txtAverageDuration.Text = ((4 * CDbl(hsbFour.Value) +
                                    5 * CDbl(hsbFive.Value) +
                                    6 * CDbl(hsbSix.Value) +
                                    7 * CDbl(hsbSeven.Value)) / 10000).ToString("N") & " games"
    End Sub

    Private Sub Updates(numGames As Integer)
        txtUnderdog.Text = hsbUnderdog.Value.ToString()
        txtFavorite.Text = hsbFavorite.Value.ToString()
        txtFour.Text = hsbFour.Value.ToString()
        txtFive.Text = hsbFive.Value.ToString()
        txtSix.Text = hsbSix.Value.ToString()
        txtSeven.Text = hsbSeven.Value.ToString()
        txtUnderdogPercent.Text = (CInt(txtUnderdog.Text) / numGames).ToString("P")
        txtFavoritePercent.Text = (CInt(txtFavorite.Text) / numGames).ToString("P")
        txtFourPercent.Text = (hsbFour.Value / numGames).ToString("P")
        txtFivePercent.Text = (hsbFive.Value / numGames).ToString("P")
        txtSixPercent.Text = (hsbSix.Value / numGames).ToString("P")
        txtSevenPercent.Text = (hsbSeven.Value / numGames).ToString("P")
    End Sub

    Private Sub PlaySeries(ByRef winner As String, ByRef games As Integer)
        Dim underdogWins As Integer = 0
        Dim favoriteWins As Integer = 0
        Dim numGames As Integer = 0
        Dim probability As Integer = CInt(txtProb.Text)
        Dim seriesOver As Boolean = False

        Do While seriesOver = False
            If randomNumber.Next(0, 100) < probability Then
                underdogWins += 1
            Else
                favoriteWins += 1
            End If

            If underdogWins = 4 Then
                winner = "Underdog Wins"
                seriesOver = True
            ElseIf favoriteWins = 4 Then
                winner = "Favorite Wins"
                seriesOver = True
            End If
            numGames += 1
        Loop
        games = numGames
    End Sub

    Private Sub ResetControls()
        hsbUnderdog.Value = 0
        hsbFavorite.Value = 0
        hsbFour.Value = 0
        hsbFive.Value = 0
        hsbSix.Value = 0
        hsbSeven.Value = 0
        Updates(1) 'reuse procedure to set all percentages to zero
        txtAverageDuration.Clear()
    End Sub
End Class
