Public Class CasinoSlotForm

    Dim bankroll As Integer
    Dim myRandom As Random = New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bankroll = Convert.ToInt32(lblBank.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("You ended up with " + bankroll.ToString() + " dollars", "Game Over", MessageBoxButtons.OK)
        Close()
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        If bankroll = 0 Then
            MessageBox.Show("You are out of cash", "Game Over", MessageBoxButtons.OK)
            Close()
        End If

        bankroll -= 1
        lblBank.Text = bankroll.ToString()
        timSpin.Enabled = True
        timDone.Enabled = True
        btnSpin.Enabled = False
    End Sub

    Private Sub TimSpin_Tick(sender As Object, e As EventArgs) Handles timSpin.Tick
        picSlot0.Image = ShowImage(myRandom.Next(0, 4))
        picSlot1.Image = ShowImage(myRandom.Next(0, 4))
        picSlot2.Image = ShowImage(myRandom.Next(0, 4))
    End Sub

    Private Sub TimDone_Tick(sender As Object, e As EventArgs) Handles timDone.Tick
        Dim p0, p1, p2 As Integer
        Dim winnings As Integer = 0
        Const jackpot As Integer = 3

        timSpin.Enabled = False
        timDone.Enabled = False
        btnSpin.Enabled = True

        'pick final pictures and see if it is a winner
        p0 = myRandom.Next(0, 4)
        p1 = myRandom.Next(0, 4)
        p2 = myRandom.Next(0, 4)

        picSlot0.Image = ShowImage(p0)
        picSlot1.Image = ShowImage(p1)
        picSlot2.Image = ShowImage(p2)

        If p0 = jackpot Then
            winnings = 1
            If p1 = jackpot Then
                winnings = 3
                If p2 = jackpot Then
                    winnings = 10
                End If
            End If
        ElseIf p0 = p1 Then
            winnings = 2
            If p1 = p2 Then
                winnings = 4
            End If
        End If

        bankroll += winnings
        lblBank.Text = bankroll.ToString()
    End Sub

    Private Function ShowImage(i As Integer) As Image
        Select Case i
            Case 0
                Return picChoice0.Image
            Case 1
                Return picChoice1.Image
            Case 2
                Return picChoice2.Image
            Case Else
                Return picChoice3.Image
        End Select
    End Function

End Class
