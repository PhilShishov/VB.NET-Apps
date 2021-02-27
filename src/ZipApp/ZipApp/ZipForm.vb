Public Class ZipForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using zip As New Ionic.Zip.ZipFile()
                zip.Password = "888"
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                zip.AddFile("D:\Downloads\Movies\tozip.txt", "")
                zip.AddFile("D:\Downloads\Movies\tozip (2).txt", "my zip")
                zip.AddFile("D:\Downloads\Movies\tozip (3).txt", "my zip\txt")
                zip.Save("D:\Downloads\Movies\tozip.zip")

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using zip As New Ionic.Zip.ZipFile()
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                zip.AddFile("D:\Downloads\Movies\tozip.txt", "")
                zip.AddFile("D:\Downloads\Movies\tozip (2).txt", "моят зип")
                zip.AddFile("D:\Downloads\Movies\tozip (3).txt", "my zip\txt")
                zip.Save("D:\Downloads\Movies\tozip.zip")

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using zip As New Ionic.Zip.ZipFile()

                zip.Password = "888"
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                zip.AddDirectory("D:\Downloads\Movies\txt", "docs")
                zip.Save("D:\Downloads\Movies\tozip.zip")

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
