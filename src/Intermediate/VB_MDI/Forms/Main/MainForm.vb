Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Settings.MdiParent = Me
        My.Forms.Settings.BackColor = Color.White
        My.Forms.Settings.MaximizeBox = False
        My.Forms.Settings.MinimizeBox = False
        '-------------------
        My.Forms.Settings.LabelVersion.Text = "2021.02.16"
        My.Forms.Settings.LabelVersion.BorderStyle = BorderStyle.FixedSingle
        '--------------------
        My.Forms.Settings.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bf As New Backup With {
            .MdiParent = Me,
            .BackColor = Color.Red,
            .MaximizeBox = False,
            .MinimizeBox = False,
            .Text = "Hi!"
        }
        bf.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Forms.Settings.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bf As New Backup
        bf.ShowDialog()
    End Sub
End Class
