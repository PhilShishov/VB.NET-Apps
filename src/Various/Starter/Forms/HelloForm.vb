Public Class HelloForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Text = My.Resources.all_strings.frm2_Last_Name
        Me.Button1.Text = My.Resources.all_strings.frm2_Hi_Philip
        Me.Text = My.Resources.all_strings.frm2_Welcome_to_my_App
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = My.Resources.all_strings.com_Done
    End Sub
End Class