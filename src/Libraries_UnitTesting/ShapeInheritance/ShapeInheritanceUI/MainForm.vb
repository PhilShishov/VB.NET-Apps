Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As New Rectangle(New Point(5, 5), New Point(10, 10))
        Dim circ As New Circle(New Point(4, 4), 5.4)

        Label1.Text = rect.ToString() & ", Area = " & rect.GetArea().ToString("n")
        Label2.Text = circ.ToString() & ", Area = " & circ.GetArea().ToString("n")
    End Sub
End Class
