Public Class MainForm
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        My.Forms.SelectLanguageForm.ShowDialog()
        'Dim f As New select_language
        If My.Forms.SelectLanguageForm.DialogResult = DialogResult.OK Then
            Application.Exit()
            ' Me.Close()
        End If
    End Sub
End Class
