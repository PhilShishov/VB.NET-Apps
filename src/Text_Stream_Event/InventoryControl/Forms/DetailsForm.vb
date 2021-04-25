Public Class DetailsForm
  Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
    If txtTitle.Text = "" Or txtAuthor.Text = "" Or txtStock.Text = "" Or txtPrice.Text = "" Then
      MessageBox.Show("You must enter the title, author, stock and price.")
    Else 
      If BooksForm.flagNewBook Then
        ReDim Preserve BooksForm.books(BooksForm.numOfBooks)
        BooksForm.books(BooksForm.numOfBooks).title = txtTitle.Text
        BooksForm.books(BooksForm.numOfBooks).author = txtAuthor.Text
        BooksForm.books(BooksForm.numOfBooks).stock = CInt(txtStock.Text)
        BooksForm.books(BooksForm.numOfBooks).price = CDbl(txtPrice.Text)
        If radFiction.Checked Then
          BooksForm.books(BooksForm.numOfBooks).category = "F"
        Else 
          BooksForm.books(BooksForm.numOfBooks).category = "N"
        End If
        BooksForm.numOfBooks += 1
      Else
        BooksForm.books(BooksForm.n).title = txtTitle.Text
        BooksForm.books(BooksForm.n).author = txtAuthor.Text
        BooksForm.books(BooksForm.n).stock = CInt(txtStock.Text)
        BooksForm.books(BooksForm.n).price = CDbl(txtPrice.Text)
        If radFiction.Checked Then
          BooksForm.books(BooksForm.n).category = "F"
        Else 
          BooksForm.books(BooksForm.n).category = "N"
        End If
      End If
    End If

    Close()
  End Sub
End Class