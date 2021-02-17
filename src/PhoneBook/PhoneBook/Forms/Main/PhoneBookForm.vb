Public Class PhoneBookForm
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        My.Forms.RegisterDataForm.MdiParent = Me
        My.Forms.RegisterDataForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim form As New SearchForm With {
            .MdiParent = Me
        }
        form.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\mspaint.exe"
        Me.Process1.Start()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim form As New AboutForm With {
            .MdiParent = Me
        }
        form.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        MessageBox.Show("Have a nice day!")
        Me.Close()
    End Sub

    Private Sub PhoneBookForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            ToolStripButton1_Click(sender, e)
        ElseIf e.KeyCode = Keys.F3 Then
            ToolStripButton2_Click(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            ToolStripButton3_Click(sender, e)
        ElseIf e.KeyCode = Keys.F5 Then
            ToolStripButton4_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            ToolStripButton5_Click(sender, e)
        End If
    End Sub
End Class
