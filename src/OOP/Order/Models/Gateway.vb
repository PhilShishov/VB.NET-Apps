Public Class Gateway
    Public Sub ProcessOrder(order As IOrder)
        Console.WriteLine($"Order no. {order.Number}")
        Console.WriteLine("=============")
        Console.WriteLine($"Name:    {order.FirstName} { order.LastName}")
        Console.WriteLine($"Address: {order.Street} {order.HouseNumber}/{order.RegistryNumber}")
        Console.WriteLine($"         {order.City} {order.Zip}" )
        Console.WriteLine($"         {order.Country}")
        Console.WriteLine()
        For i As Integer = 0 To order.Products.Length - 1
            Console.WriteLine($"{order.Products(i)} {order.Quantities(i)}pcs per ${order.Prices(i)}")
        Next
        Console.WriteLine()
        Console.WriteLine($"Total price: ${order.Prices.Sum()}")
    End Sub
End Class
