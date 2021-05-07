Public Class RepairType
    Private adapter As New RepairServicesDataSetTableAdapters.RepairTypesTableAdapter

    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Description"
            Return table
        End Get
    End Property
End Class
