Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Me.TextBoxID.Text = "") Then
            MessageBox.Show("Please enter your ID.")
            Exit Sub
        End If

        If (Me.TextBoxInfo.Text = "") Then
            MessageBox.Show("Please enter your info.")
            Exit Sub
        End If

        Dim fn As String = "D:\Downloads\info_" + Me.TextBoxID.Text + ".txt"


        System.IO.File.WriteAllText(fn, Me.TextBoxInfo.Text, System.Text.Encoding.UTF8)
        MessageBox.Show("Saved!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (Me.TextBoxID.Text = "") Then
            MessageBox.Show("Please enter your ID.")
            Exit Sub
        End If

        Dim fn As String = "D:\Downloads\info_" + Me.TextBoxID.Text + ".txt"

        If (System.IO.File.Exists(fn) = True) Then
            Dim content As String =
            System.IO.File.ReadAllText(fn, System.Text.Encoding.UTF8)
            Me.TextBoxInfo.Text = content

            MessageBox.Show("Loaded")
        Else
            MessageBox.Show(fn + " not found!")
            Me.TextBoxInfo.Clear()
        End If

    End Sub
End Class
