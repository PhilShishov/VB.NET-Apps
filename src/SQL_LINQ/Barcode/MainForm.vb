Public Class MainForm
    Private Sub Product_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Product_ListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BarcodeDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.ProductsTableAdapter.Fill(Me.BarcodeDataSet.Products)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ProductsTableAdapter.Fill(Me.BarcodeDataSet.Products)
        Me.DataGridViewTextBoxColumn4.Width = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductsTableAdapter.FillByBarcodeData(Me.BarcodeDataSet.Products)
        Me.DataGridViewTextBoxColumn4.Width = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ProductsTableAdapter.FillByBarcodeSearch(Me.BarcodeDataSet.Products, Me.TextBoxSearch.Text)
        Me.DataGridViewTextBoxColumn4.Width = 100
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
    End Sub

    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxSearch.SelectAll()
            Button3_Click(sender, e)
        End If
    End Sub
End Class
