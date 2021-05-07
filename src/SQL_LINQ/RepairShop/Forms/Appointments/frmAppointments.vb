Public Class frmAppointments
    Private appoint As New Appointment
    Private cust As New Customer
    Private formLoading As Boolean = True

    Private Sub frmAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboCustomer.ComboBox
            .DataSource = cust.Items
            .DisplayMember = "Name"
            .ValueMember = "CustId"
            .SelectedIndex = -1
        End With
        formLoading = False
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvAppointments.DataSource = appoint.Items
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged
        If Not formLoading Then
            Dim custId As Short = CShort(cboCustomer.ComboBox.SelectedValue)
            dgvAppointments.DataSource = appoint.GetByCustomerId(custId)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvAppointments.SelectedRows.Count > 0 Then
            Dim apptId As Short = CShort(dgvAppointments.SelectedRows(0).Cells(0).Value)
            Dim frm As New frmModifyAppontment
            frm.AppointmentId = apptId
            frm.ShowDialog()
            dgvAppointments.DataSource = appoint.Items
        Else
            MessageBox.Show("Please select the appointment to edit")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvAppointments.SelectedRows.Count > 0 Then
            Dim apptId As Short = CShort(dgvAppointments.SelectedRows(0).Cells(0).Value)
            If appoint.Delete(apptId) Then
                dgvAppointments.DataSource = appoint.Items
            End If
        Else
            MessageBox.Show("Unable to delete this appointment")
        End If
    End Sub
End Class