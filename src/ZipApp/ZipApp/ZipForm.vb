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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim fn As String = "D:\Downloads\Movies\tozip.zip"

            Using zip As New Ionic.Zip.ZipFile(fn)
                zip.Password = "888"
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                zip.ExtractAll("D:\Downloads\Movies",
                               Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim backup As New BackupForm
        backup.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim restore As New RestoreForm
        restore.Show()
    End Sub
End Class
