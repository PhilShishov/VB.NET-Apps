Public Class Wizard1Form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsNumeric(txtShipSize.Text) Then
            lblMessage.Visible = False
            MainForm.UserSelections.NumOfPassengers = CInt(txtShipSize.Text)
            MainForm.NextStep()
        Else
            lblMessage.Visible = True
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MainForm.PreviousStep()
    End Sub
End Class