Imports Microsoft.Win32

Public Class MainWindow
    Private Sub btnLoad_Click(sender As Object, e As RoutedEventArgs) Handles btnLoad.Click
        If Me.lblFileName.Content.ToString = "" Then
            MessageBox.Show("Please select an image file!")
            Exit Sub
        End If
        Dim imagePath As New Uri(Me.lblFileName.Content.ToString)
        Me.img.Source = New BitmapImage(imagePath)
    End Sub

    Private Sub btnFill_Click(sender As Object, e As RoutedEventArgs) Handles btnFill.Click
        Me.img.Stretch = Stretch.Fill
    End Sub

    Private Sub btnZoom_Click(sender As Object, e As RoutedEventArgs) Handles btnZoom.Click
        Me.img.Stretch = Stretch.Uniform

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As RoutedEventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog With {
            .Title = "Select the Image to Show",
            .Filter = "JPG Files|*.jpg|PNG Files|*.png|Image Files(*.BMP;*.JPG;*.PNG)|*.bmp;*.jpg;*.png",
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        }
        ofd.ShowDialog()
        Me.lblFileName.Content = ofd.FileName
    End Sub
End Class
