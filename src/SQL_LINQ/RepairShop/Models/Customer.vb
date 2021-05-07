Public Class Customer
    Const INCREMENT_VALUE As Short = 10

    Private adapter As New RepairServicesDataSetTableAdapters.CustomersTableAdapter
    Private origCustomerRow As RepairServicesDataSet.CustomersRow

    Public Shared LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property

    Public ReadOnly Property NextCustomerId As Short
        Get
            Dim lastCustId As Short = adapter.GetLastCustId()

            If lastCustId = 0 Then
                Return 1000
            Else
                Return lastCustId + INCREMENT_VALUE
            End If
        End Get
    End Property

    Public Function PhoneNumberDuplicate(id As Short, phone As String) As Boolean
        Dim existingCustomer As DataRow = adapter.FindPhoneNumber(phone).FirstOrDefault()
        If existingCustomer Is Nothing Then
            Return False
        End If

        Return id <> existingCustomer(0)
    End Function

    Public Function FindById(custId As Short) As RepairServicesDataSet.CustomersRow
        Dim table As DataTable = adapter.FindById(custId)
        Return CType(table.Rows(0), RepairServicesDataSet.CustomersRow)
    End Function

    Public Function Insert(custId As Short, name As String, phone As String) As Boolean
        Try
            adapter.Insert(custId, name, phone)
            Return True
        Catch ex As Exception
            LastError = "Failed To Insert New Customer. Reason: " & ex.Message
            Return False
        End Try
    End Function

    Public Function Update(custId As Short, name As String, phone As String) As Boolean
        Try
            origCustomerRow = adapter.GetData().FindByCustId(custId)
            adapter.Update(custId, name, phone, origCustomerRow.CustId, origCustomerRow.Name, origCustomerRow.Phone)
            Return True
        Catch ex As Exception
            LastError = "Failed to insert new Customer. Reason: " & ex.Message
            Return False
        End Try
    End Function

    Public Function Delete(custId As Short) As Boolean
        Dim rowsAffected As Integer = 0
        If MessageBox.Show("Delete Customer?", "Delete Customer?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            origCustomerRow = adapter.GetData().FindByCustId(custId)
            rowsAffected = adapter.Delete(origCustomerRow.CustId, origCustomerRow.Name, origCustomerRow.Phone)
        End If

        Return rowsAffected > 0
    End Function
End Class
