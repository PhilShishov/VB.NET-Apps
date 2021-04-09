Public Class NutritionForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const fatCaloriesPerGram = 9
        Dim food As String = txtNameOfFood.Text
        Dim AHAapproved As String
        Dim caloriesPerServing, gramsOfFat, percentCaloriesFromFat As Double

        If food <> "" And
           Double.TryParse(txtCaloriesPerServing.Text, caloriesPerServing) And
           Double.TryParse(txtGramsOfFat.Text, gramsOfFat) Then

            Dim totalCaloriesFromFat As Double = gramsOfFat * fatCaloriesPerGram
            percentCaloriesFromFat = totalCaloriesFromFat / caloriesPerServing

            Dim isAHA As Boolean = percentCaloriesFromFat < 0.3

            If isAHA Then
                AHAapproved = "AHA Approved"
            Else
                AHAapproved = "NOT AHA Approved"
            End If

            txtDisplay.Text = food & " contains " & FormatPercent(percentCaloriesFromFat, 2) & " calories from fat." & System.Environment.NewLine &
                    "It is " & AHAapproved & "."
        Else
            MessageBox.Show("Please enter valid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class
