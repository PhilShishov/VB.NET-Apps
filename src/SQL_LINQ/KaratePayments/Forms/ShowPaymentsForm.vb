Public Class ShowPaymentsForm

    Private db As New KarateClassesDataContext

    Private Sub frmShowPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvPayments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Return
        End If

        Dim paymentId As Integer = CInt(dgvPayments.SelectedRows(0).Cells(0).Value)
        Dim query = From aPayment In db.Payments
                    Select aPayment
                    Where aPayment.ID = paymentId

        Try
            db.Payments.DeleteOnSubmit(query.First())
            db.SubmitChanges()
            MessageBox.Show("Entry deleted")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub RefreshGrid()
        PaymentBindingSource.DataSource = From aPayment In db.Payments
                                          Select aPayment
    End Sub
End Class