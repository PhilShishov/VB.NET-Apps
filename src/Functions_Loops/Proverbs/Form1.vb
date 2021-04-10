Public Class ProverbsForms
    'the first letter (T or F) shows if it is true or false
    Const One As String = "TThe squeeky wheel gets the greese."
    Const Two As String = "TGiving is better than receiving."
    Const Three As String = "TOpposites attract."
    Const Four As String = "FSpare the rod and spoil the child."
    Const Five As String = "TActions speak louder than words."
    Const Six As String = "FFlattery will get you nowhere."
    Const Seven As String = "TMarry in haste, repent leisure."
    Dim counter As Integer = 0
    Dim correctAnswers As Integer
    Dim currentProverb As String

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        counter += 1
        If counter <= 7 Then
            Proverbs()
            txtAnswer.Enabled = True
            btnDisplay.Enabled = False
            btnAnswer.Enabled = True
        Else
            DisplayResults()
            counter = 0
            correctAnswers = 0
            btnAnswer.Enabled = False
            txtAnswer.Enabled = False
        End If
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        If txtAnswer.Text.ToUpper() = "T" Or txtAnswer.Text.ToUpper() = "F" Then
            AddCorrectAnswer()
            txtAnswer.Clear()
            txtAnswer.Focus()
            btnDisplay.Enabled = True
            btnAnswer.Enabled = False
            txtAnswer.Enabled = False
            lblProverb.Text = ""
        Else
            MessageBox.Show("Please enter T or F", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnswer.Focus()
        End If
    End Sub

    Private Sub AddCorrectAnswer()
        If txtAnswer.Text.ToUpper() = currentProverb.Substring(0, 1) Then
            correctAnswers += 1
        End If
    End Sub

    Private Sub DisplayResults()
        Select Case correctAnswers
            Case 7
                MessageBox.Show("Perfect.  " & correctAnswers & " correct")
            Case 5, 6
                MessageBox.Show("Excellent.  " & correctAnswers & " correct")
            Case Else
                MessageBox.Show("You might consider taking Psychology 101.  " &
                                correctAnswers & " correct")
        End Select
    End Sub

    Private Sub Proverbs()
        Select Case counter
            Case 1
                currentProverb = One
            Case 2
                currentProverb = Two
            Case 3
                currentProverb = Three
            Case 4
                currentProverb = Four
            Case 5
                currentProverb = Five
            Case 6
                currentProverb = Six
            Case 7
                currentProverb = Seven
        End Select

        lblProverb.Text = currentProverb.Substring(1)
    End Sub

End Class
