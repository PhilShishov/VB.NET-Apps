Module Program
    Sub Main()
        Dim customer As New Customer(1, "Thomas", "Smith")
        Dim address As New Address("Evergreen", 10, 2, "Austin, TX", "73301")
        Dim product As New Product("ict.social points", "Points to access premium content and achieve your dream job in IT.", 18)
        Dim order As New Order(1, product, customer, address, address)
        Dim gateway As New Gateway()
        gateway.ProcessOrder(order)
        Console.ReadKey()
    End Sub
End Module
