Public Class Wizard3Form
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MainForm.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        MainForm.UserSelections.Formal = radFormal.Checked
        MainForm.NextStep()
    End Sub
End Class