Public Class RegisterDataForm
    Private Sub RegisterDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolStripButton2.Enabled = False
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton2.Enabled = True
        Me.GroupBox1.Enabled = True

        Me.TextBox1.ResetText()
        Me.TextBox2.ResetText()
        Me.TextBox3.ResetText()
        Me.TextBox4.ResetText()
        Me.TextBox5.ResetText()
        Me.TextBox6.ResetText()
        Me.TextBox7.ResetText()
        Me.TextBox8.ResetText()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        If Me.TextBox1.Text = "" Then
            MessageBox.Show("Please enter your ID!")
            Exit Sub
        End If

        Me.ToolStripButton1.Enabled = True
        Me.ToolStripButton2.Enabled = False
        Me.GroupBox1.Enabled = False

        Dim builder As New System.Text.StringBuilder

        builder.AppendLine(Me.TextBox2.Text)
        builder.AppendLine(Me.TextBox3.Text)
        builder.AppendLine(Me.TextBox4.Text)
        builder.AppendLine(Me.TextBox5.Text)
        builder.AppendLine(Me.TextBox6.Text)
        builder.AppendLine(Me.TextBox7.Text)
        builder.AppendLine(Me.TextBox8.Text)

        Dim fileName As String = "D:\Downloads\" + Me.TextBox1.Text + "_info.txt"
        System.IO.File.WriteAllText(fileName, builder.ToString(), System.Text.Encoding.UTF8)

        ' Same for other fields

        MessageBox.Show("Saved")
    End Sub
End Class