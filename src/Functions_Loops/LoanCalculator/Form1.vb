Public Class LoanCalculatorForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amount As String = txtAmount.Text
        Dim intRate As String = txtInterestRate.Text
        Dim duration As String = txtDuration.Text
        Dim payment As String = txtMonthlyPayment.Text

        If radAmountOfLoan.Checked And ValidateInput(intRate, duration, payment) Then
            txtAmount.Text = (PV(CDbl(intRate) / 1200, CDbl(duration), -CDbl(payment))).ToString("C")
        ElseIf radInterestRate.Checked And ValidateInput(amount, duration, payment) Then
            txtInterestRate.Text = ((1200 * Rate(CDbl(duration), CDbl(payment), -CDbl(amount))) * 0.01).ToString("P")
        ElseIf radDurationOfLoan.Checked And ValidateInput(amount, intRate, payment) Then
            txtDuration.Text = (NPer(CDbl(intRate) / 1200, CDbl(payment), -CDbl(amount))).ToString("N0")
        ElseIf radMonthlyPayment.Checked And ValidateInput(amount, intRate, duration) Then
            txtMonthlyPayment.Text = (Pmt(CDbl(intRate) / 1200, CDbl(duration), -CDbl(amount))).ToString("C")
        Else
            MessageBox.Show("Please correct your input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInput(val1 As String, val2 As String, val3 As String) As Boolean
        If IsNumeric(val1) And IsNumeric(val2) And IsNumeric(val3) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtInterestRate.Clear()
        txtDuration.Clear()
        txtMonthlyPayment.Clear()
    End Sub
End Class
