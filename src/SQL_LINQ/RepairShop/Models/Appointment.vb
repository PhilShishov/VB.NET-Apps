Public Class Appointment
    Private adapter As New RepairServicesDataSetTableAdapters.AppointmentsTableAdapter
    Private origAppointment As RepairServicesDataSet.AppointmentsRow

    Public Shared LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function GetByCustomerId(custId As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "CustId = " & custId
        Return table
    End Function

    Public Function FindByApptId(apptId As Short) As RepairServicesDataSet.AppointmentsRow
        Dim table As RepairServicesDataSet.AppointmentsDataTable = adapter.GetData()
        Return table.FindByApptId(apptId)
    End Function

    Public Shared Function CombinedDateTime(aDate As DateTime, aTime As DateTime) As DateTime
        Dim ts As New TimeSpan(aTime.Hour, aTime.Minute, 0)
        Return aDate.Add(ts)
    End Function

    Public Function Insert(typeId As Short, description As String, licensed As Boolean, custId As Short,
                           scheduled As DateTime) As Boolean
        Try
            adapter.Insert(typeId, description, licensed, custId, scheduled)
            Return True
        Catch ex As Exception
            LastError = "Failed To Insert New Appointment. Reason: " & ex.Message
            Return False
        End Try
    End Function

    Public Function Update(apptId As Short, typeId As Short, description As String, licensed As Boolean, custId As Short,
                           scheduled As DateTime) As Boolean
        Try
            origAppointment = adapter.GetData().FindByApptId(apptId)
            adapter.Update(typeId, description, licensed, custId, scheduled,
                            origAppointment.ApptId, origAppointment.TypeId, origAppointment.Description, origAppointment.Licensed,
                            origAppointment.CustId, origAppointment.Scheduled, apptId)
            Return True
        Catch ex As Exception
            LastError = "Failed To Update Appointment. Reason: " & ex.Message
            Return False
        End Try
    End Function

    Public Function Delete(apptId As Short) As Boolean
        Dim rowsAffected As Integer = 0
        If MessageBox.Show("Delete Appointment?", "Delete Appointment?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            origAppointment = adapter.GetData().FindByApptId(apptId)
            rowsAffected = adapter.Delete(origAppointment.ApptId, origAppointment.TypeId, origAppointment.Description,
                            origAppointment.Licensed, origAppointment.CustId, origAppointment.Scheduled)
        End If

        Return rowsAffected > 0
    End Function
End Class
