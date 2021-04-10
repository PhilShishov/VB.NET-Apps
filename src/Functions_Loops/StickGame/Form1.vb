Public Class StickGameForm
    Dim sticksRemaining As Integer
    Dim sticks As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim message As String

        message = "Please choose how many matchsticks (between 5 and 50) to place on the pile."
        sticks = "||||||||||||||||||||||||||||||||||||||||||||||||||"

        Dim input As String = InputBox(message)

        If Integer.TryParse(input, sticksRemaining) Then

            If sticksRemaining < 5 Or sticksRemaining > 50 Then
                MessageBox.Show("Number must be between 5 and 50", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            txtPileStatus.Text = sticks.Substring(0, sticksRemaining)

            If sticksRemaining Mod 4 = 1 Then
                MessageBox.Show("Please start the game")
            Else
                MessageBox.Show("Computer starts the game")
                ComputerTurn()
            End If
        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UserTurn(userPick As Integer)
        If sticksRemaining <> 1 Then
            sticksRemaining = sticksRemaining - userPick
            txtPileStatus.Text = sticks.Substring(0, sticksRemaining)
            If sticksRemaining = 1 Then
                MessageBox.Show("You win. Congratulations")
            Else
                ComputerTurn()
            End If
        End If
    End Sub

    Private Sub ComputerTurn()
        Dim computerPick As Integer
        Dim sticksRemMod4 As Integer = sticksRemaining Mod 4

        Select Case sticksRemMod4
            Case 0
                computerPick = 3
            Case 2
                computerPick = 1
            Case 3
                computerPick = 2
        End Select

        sticksRemaining = sticksRemaining - computerPick
        If sticksRemaining = 1 Then
            MessageBox.Show("Computer selects " & computerPick & " matchsticks... Computer wins!!!.")
        Else
            MessageBox.Show("Computer selects " & computerPick & " matchsticks. ")
        End If

        txtPileStatus.Text = sticks.Substring(0, sticksRemaining)
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        UserTurn(1)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        UserTurn(2)
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        UserTurn(3)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
