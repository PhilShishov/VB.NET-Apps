Public Class IOForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String = Me.OpenFileDialog1.FileName
        '-----------------------------
        System.IO.File.Copy(fn, "D:\Downloads\new_file.pdf", True)
        '-----------------------------
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String = Me.OpenFileDialog1.FileName
        '-----------------------------
        Dim df As String = "D:\Downloads\new_file.pdf"
        '------------------------------
        Dim b As Boolean = System.IO.File.Exists(df)
        '-----------------------------
        If (b = True) Then
            System.IO.File.Delete(df)
        End If
        '-----------------------------
        System.IO.File.Move(fn, df)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String = Me.OpenFileDialog1.FileName
        '-----------------------------
        System.IO.File.Delete(fn)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim b As Boolean = System.IO.File.Exists("C:\temp\new_file.pdf")
        If (b = True) Then
            MessageBox.Show("I found your file!")
        Else
            MessageBox.Show("I didn't find your file!")
        End If
    End Sub
End Class
