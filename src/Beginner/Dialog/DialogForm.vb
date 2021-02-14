Public Class DialogForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ColorDialog1.ShowDialog()
        Me.BackColor = Me.ColorDialog1.Color
        Me.Button1.ForeColor = Me.ColorDialog1.Color

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FolderBrowserDialog1.ShowDialog()

        Dim fn As String = Me.FolderBrowserDialog1.SelectedPath

        If (fn = "") Then
            MessageBox.Show("Please select a folder")
        Else
            Me.TextBoxPath.Text = fn
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.FontDialog1.ShowDialog()
        Me.Button3.Font = Me.FontDialog1.Font
        Me.TextBoxFont.Font = Me.FontDialog1.Font
        Me.TextBoxFont.Text = Me.FontDialog1.Font.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String = Me.OpenFileDialog1.FileName

        If (fn = "") Then
            MessageBox.Show("Please select a folder")
        Else
            Me.PictureBox1.Image = Image.FromFile(fn)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.SaveFileDialog1.ShowDialog()
        Dim fn As String = Me.SaveFileDialog1.FileName

        If (fn = "") Then
            MessageBox.Show("Please select a folder")
        Else
            Me.TextBoxSave.Text = fn
        End If
    End Sub
End Class