Public Class Form1
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "2"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "3"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "4"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "5"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "6"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "7"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "9"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LabelOperator.ResetText()
        Me.LabelFirstNum.ResetText()
        Me.LabelDisplay.ResetText()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.LabelOperator.Text = "+"

        If (Me.LabelDisplay.Text = "") Then
        Else
            Me.LabelFirstNum.Text = Me.LabelDisplay.Text
        End If

        Me.LabelDisplay.ResetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.LabelOperator.Text = "-"

        If (Me.LabelDisplay.Text = "") Then
        Else
            Me.LabelFirstNum.Text = Me.LabelDisplay.Text
        End If

        Me.LabelDisplay.ResetText()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.LabelOperator.Text = "x"

        If (Me.LabelDisplay.Text = "") Then
        Else
            Me.LabelFirstNum.Text = Me.LabelDisplay.Text
        End If

        Me.LabelDisplay.ResetText()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.LabelOperator.Text = "/"

        If (Me.LabelDisplay.Text = "") Then
        Else
            Me.LabelFirstNum.Text = Me.LabelDisplay.Text
        End If

        Me.LabelDisplay.ResetText()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim fn As Double = Val(Me.LabelFirstNum.Text)
        Dim sn As Double = Val(Me.LabelDisplay.Text)
        Dim res As Double

        If (Me.LabelOperator.Text = "+") Then
            res = fn + sn
        ElseIf (Me.LabelOperator.Text = "-") Then
            res = fn - sn
        ElseIf (Me.LabelOperator.Text = "x") Then
            res = fn * sn
        ElseIf (Me.LabelOperator.Text = "/") Then
            res = fn / sn
        End If

        Me.LabelDisplay.Text = res.ToString()
        Me.LabelOperator.ResetText()
        Me.LabelFirstNum.ResetText()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.LabelDisplay.Text = Me.LabelDisplay.Text + "."
    End Sub
End Class
