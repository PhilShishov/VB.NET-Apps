Public Class Wizard4Form
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MainForm.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsNumeric(txtAverageAge.Text) Then
            lblMessage.Visible = False
            MainForm.UserSelections.AverageAge = CSng(txtAverageAge.Text)
            MainForm.NextStep()
        Else
            lblMessage.Visible = True
        End If
    End Sub
End Class