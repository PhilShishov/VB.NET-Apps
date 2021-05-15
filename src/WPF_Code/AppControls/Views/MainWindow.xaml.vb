Public Class MainWindow
    Private Sub btnExitSub_Click(sender As Object, e As RoutedEventArgs) Handles btnExitSub.Click
        MessageBox.Show("1")
        MessageBox.Show("2")
        MessageBox.Show("3")
        Exit Sub
        MessageBox.Show("4")
    End Sub

    Private Sub btnCloseWindow_Click(sender As Object, e As RoutedEventArgs) Handles btnCloseWindow.Click
        Me.Close()
    End Sub

    Private Sub btnCloseApp_Click(sender As Object, e As RoutedEventArgs) Handles btnCloseApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnAppPath_Click(sender As Object, e As RoutedEventArgs) Handles btnAppPath.Click
        Me.lblAppPath.Content = AppDomain.CurrentDomain.BaseDirectory
    End Sub

    Private Sub btnAppFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnAppFolder.Click
        Process.Start(AppDomain.CurrentDomain.BaseDirectory)
    End Sub

    Private Sub btnImageAppFolders_Click(sender As Object, e As RoutedEventArgs) Handles btnImageAppFolder.Click
        Process.Start(AppDomain.CurrentDomain.BaseDirectory + "koala_resized.jpg")
    End Sub

    Private Sub btnPaintAppFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnPaintAppFolder.Click
        Me.lblAppPath.Content = AppDomain.CurrentDomain.BaseDirectory + "Paint.lnk"
        Process.Start(Me.lblAppPath.Content.ToString)
    End Sub

    Private Sub btnSpecialFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnSpecialFolder.Click
        Me.lblSpecialFolder.Content = Environment.GetFolderPath(Environment.SpecialFolder.System)
    End Sub

    Private Sub btnPaintSpecialFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnPaintSpecialFolder.Click
        Me.lblSpecialFolder.Content = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\mspaint.exe"
        Process.Start(Me.lblSpecialFolder.Content.ToString)
    End Sub

    Private Sub btnCustomFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnCustomFolder.Click
        Process.Start("D:\")
    End Sub

    Private Sub btnImageCustomFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnImageCustomFolder.Click
        Process.Start("D:\v.jpg")
    End Sub

    Private Sub btnAppCustomFolder_Click(sender As Object, e As RoutedEventArgs) Handles btnAppCustomFolder.Click
        Process.Start(Me.textCustomFolder.Text)
    End Sub
End Class
