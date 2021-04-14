Public Class VotingMachineForm

    Dim totals() As Integer

    Private Sub btnNominate_Click(sender As Object, e As EventArgs) Handles btnNominate.Click
        Dim candidate As String = InputBox("Please enter the name of the candidate", "Candidate")
        lstCandidates.Items.Add(candidate)
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        'change instructions and disable buttons that are no longer used
        lblInstructions.Text = "Vote for a candidate by" &
                              " double-clicking on his/her name. " &
                              "End the voting by clicking on 'Tally Votes'."
    End Sub

    Private Sub lstCandidates_DoubleClick(sender As Object, e As EventArgs) Handles lstCandidates.SelectedIndexChanged
        ReDim Preserve totals(lstCandidates.Items.Count - 1)

        totals(lstCandidates.SelectedIndex) += 1
        MessageBox.Show("Thank you for voting for " + lstCandidates.SelectedItem.ToString())
    End Sub

    Private Sub btnTally_Click(sender As Object, e As EventArgs) Handles btnTally.Click
        lstVotes.Visible = True

        For Each vote In totals
            lstVotes.Items.Add(vote)
        Next

        Dim winners(totals.Length - 1) As Integer 'holds indexes of candidates with highest scores
        Dim highest As Integer = totals.Max()

        For i = 0 To totals.Length - 1
            If totals(i) = highest Then
                winners(i) = 1
            Else
                winners(i) = 0
            End If
        Next

        Dim allWinners As String = String.Empty
        For i = 0 To winners.Length - 1
            If winners(i) = 1 Then
                allWinners += lstCandidates.Items.Item(i).ToString() + ", "
            End If
        Next

        MessageBox.Show("The winner is/are " & allWinners & " who won with " & totals.Max & " votes.")
    End Sub
End Class
