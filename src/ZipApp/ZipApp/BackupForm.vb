Public Class BackupForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim path As String = Me.FolderBrowserDialog1.SelectedPath

        If path = "" Then
            Exit Sub
        End If

        Dim fn As String =
            System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm") +
            ".p19"

        Me.TextBox1.Text = path + "\" + fn
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using zip As New Ionic.Zip.ZipFile()
                zip.Password = "888"
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                zip.AddDirectory("D:\Projects\VB.NET-Apps\src\ZipApp\ZipApp\Data")
                zip.Save(Me.TextBox1.Text)

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class