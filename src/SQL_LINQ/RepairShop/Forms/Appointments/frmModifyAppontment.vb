Public Class frmModifyAppontment
    Private appointment As New Appointment
    Private repairType As New RepairType
    Private customer As New Customer
    Public Property AppointmentId As Short

    Private Sub frmModifyAppontment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRepairType.DataSource = repairType.Items
        cboRepairType.DisplayMember = "Description"
        cboRepairType.ValueMember = "TypeId"

        cboCustomer.DataSource = customer.Items
        cboCustomer.DisplayMember = "Name"
        cboCustomer.ValueMember = "CustId"

        Dim row As RepairServicesDataSet.AppointmentsRow
        row = appointment.FindByApptId(AppointmentId)
        dtpDate.Value = row.Scheduled.Date
        txtTime.Text = row.Scheduled.TimeOfDay.ToString()
        chkLicensed.Checked = row.Licensed
        txtDescription.Text = row.Description
        cboRepairType.SelectedValue = row.TypeId
        cboCustomer.SelectedValue = row.CustId
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim scheduledAt As DateTime
        Try
            scheduledAt = Appointment.CombinedDateTime(dtpDate.Value.Date, txtTime.Text)
        Catch ex As Exception
            errProvider.SetError(txtTime, "Please enter a valid appointment time")
            Return
        End Try

        Dim typeId As Short = cboRepairType.SelectedValue
        Dim custId As Short = cboCustomer.SelectedValue
        Dim licensed As Boolean = chkLicensed.Checked

        If appointment.Update(AppointmentId, typeId, txtDescription.Text, licensed, custId, scheduledAt) Then
            Close()
        Else
            lblStatus.Text = "Cannot update appointment. " & Appointment.LastError
        End If
    End Sub
End Class