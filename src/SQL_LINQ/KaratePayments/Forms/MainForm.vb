Public Class MainForm
    Private db As New KarateClassesDataContext

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentBindingSource.DataSource = From aPayment In db.Payments
                                          Select aPayment

        PaymentBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            PaymentBindingSource.EndEdit()
            db.SubmitChanges()
            MessageBox.Show("Payment added")
            PaymentBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ShowPaymentsForm.ShowDialog()
    End Sub

    Private Sub btnGroupId_Click(sender As Object, e As EventArgs) Handles btnGroupId.Click
        GroupIdForm.ShowDialog()
    End Sub

    Private Sub btnGroupName_Click(sender As Object, e As EventArgs) Handles btnGroupName.Click
        GroupNameForm.ShowDialog()
    End Sub
End Class
