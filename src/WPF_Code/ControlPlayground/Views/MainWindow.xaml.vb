Public Class MainWindow
    Private Sub btnFirst_Click(sender As Object, e As RoutedEventArgs) Handles btnFirst.Click
        MessageBox.Show("I'm the first button")
        MessageBox.Show("2")
        MessageBox.Show("3")
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As RoutedEventArgs) Handles btnSecond.Click
        MessageBox.Show("I'm the 2nd Button", "Info")
    End Sub

    Private Sub btnChangeTitle_Click(sender As Object, e As RoutedEventArgs) Handles btnChangeTitle.Click
        MainWindow.Title = ""
        Me.Title = "The title has changed!"
    End Sub

    Private Sub btnChangeText_Click(sender As Object, e As RoutedEventArgs) Handles btnChangeText.Click
        lblMessage.Content = "It's True"
        textMessage.Text = "But it's False !"
    End Sub

    Private Sub btnWindowGridColor_Click(sender As Object, e As RoutedEventArgs) Handles btnWindowGridColor.Click
        Me.Background = Brushes.Brown
        Me.grdMain.Background = Brushes.Bisque
    End Sub

    Private Sub btnControlsColor_Click(sender As Object, e As RoutedEventArgs) Handles btnControlsColor.Click
        Me.btnWindowGridColor.Background = Brushes.Yellow
        Me.lblMessage.Background = Brushes.GreenYellow
        Me.textMessage.Background = Brushes.LightBlue
    End Sub

    Private Sub btnControlsTextColor_Click(sender As Object, e As RoutedEventArgs) Handles btnControlsTextColor.Click
        Me.btnControlsColor.Foreground = Brushes.Red
        Me.textMessage.Foreground = Brushes.Blue
        Me.lblMessage.Foreground = Brushes.OrangeRed
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As RoutedEventArgs) Handles btnDisable.Click
        Me.btnControlsColor.IsEnabled = False
        Me.grdSub.IsEnabled = False
        Me.btnEnable.IsEnabled = True
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As RoutedEventArgs) Handles btnEnable.Click
        Me.btnControlsColor.IsEnabled = True
        Me.grdSub.IsEnabled = True
        Me.IsEnabled = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As RoutedEventArgs) Handles btnHide.Click
        Me.grdSub.Visibility = Visibility.Hidden
    End Sub

    Private Sub btnShow_Click(sender As Object, e As RoutedEventArgs) Handles btnShow.Click
        Me.grdSub.Visibility = Visibility.Visible
    End Sub
End Class
