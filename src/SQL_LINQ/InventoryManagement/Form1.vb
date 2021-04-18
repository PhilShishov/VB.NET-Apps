Public Class InventoryManagementForm
    Private Sub InventoryManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MICROLANDDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.MICROLANDDataSet.Orders)
        'TODO: This line of code loads data into the 'MICROLANDDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.MICROLANDDataSet.Inventory)
        'TODO: This line of code loads data into the 'MICROLANDDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.MICROLANDDataSet.Customers)

    End Sub
    'The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine
    'https://www.connectionstrings.com/the-microsoft-ace-oledb-12-0-provider-is-not-registered-on-the-local-machine/


    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        lstOutput.Items.Clear()
        lstOutput.Items.Add("These are the item that need to be reordered")
        lstOutput.Items.Add("The number shows current inventory for the item")

        Dim query1 = From item In MICROLANDDataSet.Orders
                     Select item.itemID, item.quantity

        Dim query2 = From item In MICROLANDDataSet.Inventory
                     Select item.itemID, item.quantity, item.description

        Dim Id, desc As String
        Dim qty As Integer

        For Each item In query2
            Id = item.itemID
            desc = item.description
            qty = item.quantity

            Dim query3 = From product In query1
                         Where product.itemID = Id
                         Select CInt(product.quantity)

            If qty <= query3.Sum Then
                lstOutput.Items.Add(Id & "   " & qty - query3.Sum & "    " & desc)
            End If
        Next
    End Sub

    Private Sub btnBills_Click(sender As Object, e As EventArgs) Handles btnBills.Click
        lstOutput.Items.Clear()

        'list of customers who made a purchase
        Dim query1 = From cust In MICROLANDDataSet.Orders
                     Select cust.custID
                     Distinct

        For Each id In query1
            'list of customer names and addresses
            Dim query2 = From cust In MICROLANDDataSet.Customers
                         Where cust.custID = id
                         Select cust.custID, cust.name, cust.street, cust.city

            lstOutput.Items.Add(query2.First().name)
            lstOutput.Items.Add(query2.First().street)
            lstOutput.Items.Add(query2.First().city)
            lstOutput.Items.Add("")

            Dim query3 = From product In MICROLANDDataSet.Orders
                         Join product2 In MICROLANDDataSet.Inventory
                         On product.itemID Equals product2.itemID
                         Where product.custID = id
                         Let amount As Double = product.quantity * product2.price
                         Select product.quantity, product2.description, amount

            Dim totalOrder As Double = 0
            For Each item In query3
                lstOutput.Items.Add(item.quantity & "   " & item.description & "   " & item.amount.ToString("C"))
                totalOrder += item.amount
            Next
            lstOutput.Items.Add("Total cost: " & totalOrder.ToString("C"))
            lstOutput.Items.Add("")
            lstOutput.Items.Add("")
        Next
    End Sub
End Class
