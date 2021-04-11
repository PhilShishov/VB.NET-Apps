Public Class Rule72Form
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim years As Integer
        Dim amount As Double

        For intRate As Integer = 1 To 20
            amount = 100
            years = 0

            Do While amount < 200
                years += 1
                amount = (1 + intRate / 100) * amount
            Loop

            lstOutput.Items.Add("Interest Rate " & (intRate / 100).ToString("P0"))
            lstOutput.Items.Add("Rule of 72: " & Math.Round(72 / intRate))
            lstOutput.Items.Add("Actual Doubling time: " & years)
            lstOutput.Items.Add("")
        Next
    End Sub
End Class
