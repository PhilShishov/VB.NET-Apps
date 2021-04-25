Public Class FamilyTree
    ReadOnly root As Person

    Public Sub New(root As Person)
        Me.root = root
    End Sub

    Public Sub Print()
        Console.WriteLine("Family tree for {0}", root)
        PrintPersonAndAncestors(root)
    End Sub

    Private Sub PrintPersonAndAncestors(person As Person)
        If (person IsNot Nothing) Then
            Console.WriteLine(person)
            PrintPersonAndAncestors(person.Father)
            PrintPersonAndAncestors(person.Mother)
        End If
    End Sub
End Class
