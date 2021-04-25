Module Program
    Sub Main()
        ' Create and link people
        Dim abraham As Person = New Person("Abraham Simpson", Nothing, Nothing)
        Dim penelope As Person = New Person("Penelope Olsen", Nothing, Nothing)
        Dim pan As Person = New Person("Pan Bouvier", Nothing, Nothing)
        Dim jackie As Person = New Person("Jackie Bouvier", Nothing, Nothing)
        Dim herb As Person = New Person("Herb Powers", abraham, penelope)
        Dim homer As Person = New Person("Homer Simpson", abraham, penelope)
        Dim marge As Person = New Person("Marge Bouvier", pan, jackie)
        Dim selma As Person = New Person("Selma Bouvier", pan, jackie)
        Dim bart As Person = New Person("Bart Simpson", homer, marge)
        ' Create and print the family trees
        Dim firstFamilyTree As FamilyTree = New FamilyTree(bart)
        Dim secondFamilyTree As FamilyTree = New FamilyTree(marge)
        firstFamilyTree.Print()
        Console.WriteLine()

        secondFamilyTree.Print()
        Console.ReadLine()
    End Sub
End Module
