Public Class TextFileForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.IO.File.WriteAllText("D:\Downloads\info.txt", Me.TextBox1.Text, System.Text.Encoding.UTF8)
        MessageBox.Show("Done")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim content As String =
            System.IO.File.ReadAllText("D:\Downloads\info.txt", System.Text.Encoding.UTF8)
        Me.TextBox1.Text = content
        MessageBox.Show("Done")
    End Sub
End Class
