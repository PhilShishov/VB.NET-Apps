Public Class SearchForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fileName As String = "D:\Downloads\" + Me.TextBox9.Text + "_info.txt"

        If System.IO.File.Exists(fileName) = True Then
            Me.TextBox1.Text = Me.TextBox9.Text

            Dim text As String =
            System.IO.File.ReadAllText(fileName, System.Text.Encoding.UTF8)

            Dim arrString() As String = Split(text, Environment.NewLine)

            Me.TextBox2.Text = arrString(0)
            Me.TextBox3.Text = arrString(1)
            Me.TextBox4.Text = arrString(2)
        Else
            Me.TextBox1.Text = "Not Found"
        End If

    End Sub
End Class