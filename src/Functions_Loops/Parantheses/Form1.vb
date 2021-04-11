Public Class ParanthesesForm
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim input = txtSentence.Text

        Dim openParantheses = input.IndexOf("(")
        Dim closeParantheses = input.IndexOf(")")

        If openParantheses > 0 And closeParantheses > 0 Then
            txtOutput.Text = input.Remove(openParantheses, closeParantheses - openParantheses + 1)
        Else
            MessageBox.Show("Please enter open and close parantheses", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
