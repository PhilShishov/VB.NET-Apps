Imports System.Windows.Forms.VisualStyles

Public Class BooksForm

  Structure Book
    Dim title As String           'Title
    Dim author As String          'Author's name
    Dim category As String        'True = fiction, False = nonfiction
    Dim stock As Integer          'Quantity in stock
    Dim price As Double           'Wholesale price
  End Structure

  Public books() As Book
  Public numOfBooks as Integer
  Public flagNewBook as Boolean = False
  Public n as Integer 'current index

  Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If IO.File.Exists("Books.txt") Then
      Dim fileBooks() as String = IO.File.ReadAllLines("Books.txt")
      numOfBooks = fileBooks.Count()
      ReDim books(numOfBooks - 1)
      For i as Integer = 0 To numOfBooks - 1
        Dim ar() = fileBooks(i).Split(","c)
        books(i).title = ar(0)
        books(i).author = ar(1)
        books(i).category = ar(2)
        books(i).stock = CInt(ar(3))
        books(i).price = CDbl(ar(4))
      Next

      Dim query = From book In books
                  Let title as String = book.title
                  Select title

      lstBooks.DataSource = query.ToList
    End If
  End Sub
  
  Private Sub Display(cat1 As String, cat2 As String)
    Dim query = From book In books
                Where book.category = cat1 or book.category = cat2
                Select book.title

    lstBooks.DataSource = query.ToList

  End Sub

  Private Sub mnuDisplayAll_Click(sender As Object, e As EventArgs) Handles mnuDisplayAll.Click
    Display("N", "F")
    mnuDisplayAll.Checked = True
    mnuDisplayFiction.Checked = False
    mnuDisplayNonfiction.Checked = false
  End Sub

  Private Sub mnuDisplayFiction_Click(sender As Object, e As EventArgs) Handles mnuDisplayFiction.Click
    Display("F", "")
    mnuDisplayFiction.Checked = True
    mnuDisplayAll.Checked = False
    mnuDisplayNonfiction.Checked = False
  End Sub

  Private Sub mnuDisplayNonfiction_Click(sender As Object, e As EventArgs) Handles mnuDisplayNonfiction.Click
    Display("N", "")
    mnuDisplayNonfiction.Checked = True
    mnuDisplayAll.Checked = False
    mnuDisplayFiction.Checked = False
  End Sub

  Private Sub mnuBookAdd_Click(sender As Object, e As EventArgs) Handles mnuBookAdd.Click
    flagNewBook = True
    DetailsForm.txtTitle.Clear()
    DetailsForm.txtAuthor.Clear()
    DetailsForm.txtStock.Clear()
    DetailsForm.txtPrice.Clear()
    DetailsForm.radFiction.Checked = True
    DetailsForm.ShowDialog()
  End Sub

  Private Sub mnuBookDelete_Click(sender As Object, e As EventArgs) Handles mnuBookDelete.Click
    n = lstBooks.SelectedIndex
    If n >= 0 Then
      numOfBooks = numOfBooks - 1
      For i = n To numOfBooks - 1
        books(i) = books(i + 1)
      Next
      ReDim Preserve books(numOfBooks - 1)
      Display("N","F")
    End If
  End Sub

  Private Sub mnuBookUpdate_Click(sender As Object, e As EventArgs) Handles mnuBookUpdate.Click
    n = lstBooks.SelectedIndex
    If n >= 0 Then
      flagNewBook = False
      DetailsForm.txtTitle.Text = books(n).title
      DetailsForm.txtAuthor.Text = books(n).author
      DetailsForm.txtStock.Text = books(n).stock.ToString()
      DetailsForm.txtPrice.Text = (books(n).price).ToString("C")

      If books(n).category = "F" Then
        DetailsForm.radFiction.Checked = True
      Else 
        DetailsForm.radNonFiction.Checked = True
      End If

      DetailsForm.ShowDialog()
    End If
  End Sub

  Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
    Dim query = From book In books
                Let line = book.title & "," & book.author & "," & book.category & "," & book.stock & "," & book.price
                Select line

    IO.File.WriteAllLines("Books.txt",query)
    MessageBox.Show("File saved")
  End Sub

  Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
    End
  End Sub

  Private Sub mnuValuesAll_Click(sender As Object, e As EventArgs) Handles mnuValuesAll.Click
    Dim query = From book In books
                Select book.price * book.stock

    MessageBox.Show("Value of All books: " & query.Sum().ToString("C"))
  End Sub

  Private Sub mnuValuesFiction_Click(sender As Object, e As EventArgs) Handles mnuValuesFiction.Click
    Dim query = From book In books
                Where book.category = "F"
                Select book.price * book.stock

    MessageBox.Show("Value of Fiction books: " & query.Sum().ToString("C"))
  End Sub

  Private Sub mnuValuesNonfiction_Click(sender As Object, e As EventArgs) Handles mnuValuesNonfiction.Click
    Dim query = From book In books
                Where book.category = "N"
                Select book.price * book.stock

    MessageBox.Show("Value of Non-Fiction books: " & query.Sum().ToString("C"))
  End Sub
End Class
