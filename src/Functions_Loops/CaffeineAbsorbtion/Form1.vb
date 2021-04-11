Public Class CaffeineAbsorbtionForm
    Const CaffeinePerCup As Double = 130 'mg of caffeine in hte coffee
    Const Absorbed As Double = 0.13 'hourly absorbtion is 13%

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txt1.Text = Question1().ToString("N0") & " hours"
        txt2.Text = Question2().ToString("N") & " mg"
        txt3.Text = Question3().ToString("N") & " mg"
    End Sub

    Private Function Question1() As Integer
        Dim hours As Integer
        Dim amount As Double = CaffeinePerCup

        Do Until amount <= CaffeinePerCup / 2
            amount = (1 - Absorbed) * amount
            hours += 1
        Loop

        Return hours
    End Function

    Private Function Question2() As Double
        Dim amount As Double = CaffeinePerCup

        For i = 1 To 24
            amount = (1 - Absorbed) * amount
        Next

        Return amount
    End Function

    Private Function Question3() As Double
        Dim amount As Double = CaffeinePerCup
        Dim counter As Integer = 1

        While counter <= 24
            amount = (1 - Absorbed) * amount + CaffeinePerCup
            counter += 1
        End While

        Return amount
    End Function

End Class
