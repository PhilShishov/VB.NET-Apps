Public Class frmCustomers
    Private cust As New Customer

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepairServicesDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.RepairServicesDataSet.Customers)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCustomers.SelectedRows.Count = 0 Then
            lblStatus.Text = "Please select a row to edit"
            Return
        End If

        Dim frm As New frmModifyCustomer
        frm.CustomerId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value)
        If frm.ShowDialog() = DialogResult.OK Then
            CustomersTableAdapter.Fill(RepairServicesDataSet.Customers) 'this works, but to stay consistent, you could also use 
            'dgvCustomers.DataSource = cust.Items
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim custId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value)
            If cust.Delete(custId) Then
                dgvCustomers.DataSource = cust.Items
                MessageBox.Show("Customer Deleted")
            Else
                MessageBox.Show("Customer NOT Deleted")
            End If
        End If
    End Sub
End Class