Module Program

    Sub Main()
        Dim myList As New MyList()
        myList.Add("First")
        myList.Add(2)

        For i As Integer = 3 To 99999
            myList.Add(i)
        Next

        myList(3) = "Fourth"

        For i As Integer = 0 To 99
            Console.WriteLine(myList(i))
        Next
        Console.ReadKey()
    End Sub
End Module
