Public Class MarketForm
    Private Sub GoodsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GoodsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GoodsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GoodsDataSet)

    End Sub

    Private Sub MarketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.GoodsTableAdapter.Fill(Me.GoodsDataSet.goods)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class