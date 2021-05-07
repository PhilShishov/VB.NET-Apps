Public Class frmModifyCustomer
    Public Property CustomerId As Short
    Dim cust As New Customer

    Private Sub frmModifyCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As RepairServicesDataSet.CustomersRow = cust.FindById(CustomerId)
        lblCustomerId.Text = row.CustId.ToString()
        txtName.Text = row.Name
        txtPhone.Text = row.Phone
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cust.PhoneNumberDuplicate(CustomerId, txtPhone.Text) Then
            errProvider.SetError(txtPhone, "This phone number belongs to anothe customer. Please enter another number.")
        Else
            errProvider.SetError(txtPhone, "")
            If cust.Update(CustomerId, txtName.Text, txtPhone.Text) Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End If
    End Sub
End Class