Public Class IRAForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim balance, earlBalanceAfter15Years, earlBalanceUponRetirement, larryBalanceUponRetirement As Double

        txtEarlTotalDeposits.Text = (15 * 5000).ToString("C")
        txtLarryTotalDeposits.Text = (33 * 5000).ToString("C")

        'Earl
        balance = 0

        For i = 1 To 15
            balance = 1.04 * balance + 5000
        Next

        earlBalanceAfter15Years = balance
        earlBalanceUponRetirement = earlBalanceAfter15Years * (1.04) ^ 33

        txtEarlTotalIRA.Text = earlBalanceUponRetirement.ToString("C")

        'Larry
        balance = 0

        For i = 1 To 33
            balance = 1.04 * balance + 5000
        Next

        larryBalanceUponRetirement = balance

        txtLarryTotalIRA.Text = larryBalanceUponRetirement.ToString("C")

    End Sub
End Class
