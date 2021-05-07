Public Class MainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AppointmentsNewMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentsNewMenuItem.Click
        Dim frm As New frmNewAppointment
        If frm.ShowDialog() = DialogResult.OK Then
            frmAppointments.ShowDialog()
        End If
    End Sub

    Private Sub AppointmentsViewMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentsViewMenuItem.Click
        frmAppointments.ShowDialog()
    End Sub

    Private Sub CustomersNewMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersNewMenuItem.Click
        Dim frm As New frmNewCustomer
        If frm.ShowDialog() = DialogResult.OK Then
            frmCustomers.ShowDialog()
        End If
    End Sub

    Private Sub CustomersViewMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersViewMenuItem.Click
        frmCustomers.ShowDialog()
    End Sub
End Class
