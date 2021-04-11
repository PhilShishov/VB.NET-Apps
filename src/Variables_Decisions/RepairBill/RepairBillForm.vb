Public Class RepairBillForm
  Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
    Dim labor, parts, total As Double
    Dim name As String

    lstDisplay.Items.Clear()

    If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "" Then
      labor = CDbl(txtLabor.Text)
      parts = CDbl(txtParts.Text)
      name = txtName.Text

      Dim laborCost As Double = labor * 35
      Dim partsCost As Double = parts + (parts * 0.05)
      total = laborCost + partsCost

      lstDisplay.Items.Add("Customer: " & name)
      lstDisplay.Items.Add("Labor Cost: " & FormatCurrency(laborCost))
      lstDisplay.Items.Add("Parts Cost: " & FormatCurrency(partsCost))
      lstDisplay.Items.Add("Total Cost: " & FormatCurrency(total))
    Else
      MessageBox.Show("Please enter valid input")
    End If
  End Sub
End Class
