Public Class RestaurantBillForm

    Const pizzaPrice As Double = 1.75
    Const friesPrice As Double = 2.0
    Const drinkPrice As Double = 1.25

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim pizza, fries, drinks As Integer

        If Integer.TryParse(txtPizza.Text, pizza) And
           Integer.TryParse(txtFries.Text, fries) And
           Integer.TryParse(txtDrinks.Text, drinks) Then

            Dim total As Double = CalculateTotalCost(pizza, fries, drinks)
            DisplayBill(total, pizza, fries, drinks)
        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DisplayBill(total As Double, pizza As Integer, fries As Integer, drinks As Integer)

        lstDisplay.Items.Add("ITEM" + vbTab + "     QUANTITY" + vbTab + "PRICE")

        If pizza > 0 Then
            lstDisplay.Items.Add("Pizza" + vbTab + "            " + pizza.ToString() + vbTab + vbTab + FormatCurrency(pizza * pizzaPrice))
        End If

        If fries > 0 Then
            lstDisplay.Items.Add("Fries" + vbTab + "            " + fries.ToString() + vbTab + vbTab + FormatCurrency(fries * friesPrice))
        End If

        If drinks > 0 Then
            lstDisplay.Items.Add("Drinks" + vbTab + "            " + drinks.ToString() + vbTab + vbTab + FormatCurrency(drinks * drinkPrice))
        End If

        lstDisplay.Items.Add("---------------------------------------")
        lstDisplay.Items.Add("TOTAL: " + vbTab + FormatCurrency(total))
    End Sub

    Private Function CalculateTotalCost(countPizza As Integer, countFries As Integer, countDrinks As Integer) As Double
        Dim total As Double = (countPizza * pizzaPrice) + (countFries * friesPrice) + (countDrinks * drinkPrice)
        Return total
    End Function
End Class
