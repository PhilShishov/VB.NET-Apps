Module Program
    Sub Main()
        Dim people As New List(Of Person)

        Dim charles As New Man("Charles", "New", New DateTime(1988, 2, 5))
        people.Add(charles)
        people.Add(New Man("Josef", "New", New DateTime(1978, 3, 19)))
        people.Add(New Man("Jan", "Marek", New DateTime(1968, 4, 28)))
        people.Add(New Man("Charles", "New", New DateTime(1958, 6, 25)))
        Dim marie As New Woman("Marie", "New", New DateTime(1988, 8, 15))
        people.Add(marie)
        people.Add(New Woman("Lucy", "New", New DateTime(1978, 10, 2)))
        people.Add(New Woman("Simon", "Young", New DateTime(1968, 1, 8)))
        people.Add(New Woman("Michael", "Futile", New DateTime(1958, 12, 6)))

        people.Sort()
        For Each c As Person In people
            Console.WriteLine(c)
        Next
        Console.WriteLine()

        Dim child As Person = charles + marie
        Console.WriteLine($"{charles} and {marie} have a child named {child}")
        Console.ReadKey()
    End Sub
End Module
