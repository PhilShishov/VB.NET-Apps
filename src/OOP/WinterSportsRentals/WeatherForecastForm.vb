Public Class WeatherForecastForm
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        WebBrowser1.Navigate(txtNavigateTo.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class