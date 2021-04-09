Public Class UnitPriceForm
  Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
    Dim price, pricePerOunce as Double
    Dim pounds, ounces as Integer

    price = CDbl(txtPriceOfItem.Text)
    pounds = CInt(txtPounds.Text)
    ounces = CInt(txtOunces.Text)

    Dim totalOunces = ounces + (pounds * 16)

    pricePerOunce = price / totalOunces
    txtPricePerOunce.Text = pricePerOunce.ToString("C2")
  End Sub
End Class
