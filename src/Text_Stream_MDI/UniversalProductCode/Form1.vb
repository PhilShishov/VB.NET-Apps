Public Class UPCForm
  Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
    'prepare scren for next customer
    mtbUPC.Clear()
    mtbUPC.Focus()
    IO.File.Delete("TempFile.txt")
    lstReceipt.Items.Clear()
    MessageBox.Show("The cash register is ready for the next Customer","New Customer",MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Private Function checkUPC(upc As String) As Boolean
    Dim upcOK as Boolean = False
    Dim d(11) as Integer
    Dim code as Integer = 0

    For i as Integer = 0 To 11
      d(i) = Cint(upc.Substring(i,1))
    Next

    'formula to validate the UPC
    code = (3 * d(0)) + d(1) + (3 * d(2)) + d(3) + (3 * d(4)) + d(5) + (3 * d(6)) + d(7) + (3 * d(8)) + d(9) + (3 * d(10)) + d(11)

    If code Mod 10 = 0 Then
      upcOK = True
    End If
    
    Return upcOK
  End Function

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Dim tempFile As IO.StreamWriter = IO.File.AppendText("TempFile.txt")
    Dim upc as String

    If mtbUPC.Text.Length <> 12 Then
      MessageBox.Show("Please fill in the 12-digit UPC code","Invalid UPC", MessageBoxButtons.OK, MessageBoxIcon.Error)
      mtbUPC.Focus()
      Exit Sub
    End If

    upc = mtbUPC.Text
    If checkUPC(upc) Then
      lstReceipt.Items.Add(upc + " --- OK")
      mtbUPC.Focus()
      tempFile.WriteLine(upc)
    Else 
      MessageBox.Show("Invalid UPC Code was entered","Invalid UPC", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    tempFile.Close()

  End Sub

  Private Sub btnDisplayReceipt_Click(sender As Object, e As EventArgs) Handles btnDisplayReceipt.Click
    lstReceipt.Items.Clear()
    Dim purchaseUPC() = IO.File.ReadAllLines("TempFile.txt")
    Dim sum as Double = 0

    For i as Integer = 0 To purchaseUPC.Count() - 1
      Dim query = From product In IO.File.ReadAllLines("UPC.txt")
                  Let UPC As String = product.Split(","c)(0)
                  Let productDesc As String = product.Split(","c)(1)
                  Let price As Double = Cdbl(product.Split(","c)(2))
                  Where UPC = purchaseUPC(i)
                  Select UPC, productDesc, price

      lstReceipt.Items.Add(query(0).productDesc + "   " + FormatCurrency(query(0).price,2))
      sum += query(0).price
    Next

    lstReceipt.Items.Add(" ")
    lstReceipt.Items.Add("Total: " + FormatCurrency(sum))

  End Sub
End Class
