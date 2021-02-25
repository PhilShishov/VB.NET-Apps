Public Class ZipForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zip As New Ionic.Zip.ZipFile()

        zip.AddFile("D:\Downloads\Movies\tozip.txt")
        zip.Save("D:\Downloads\Movies\tozip.zip")
    End Sub
End Class
