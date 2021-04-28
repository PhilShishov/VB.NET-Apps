Module Program
    Sub Main()
        Dim users As New List(Of User) From {
            New User("Charles", "New", Sex.Man, New DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond),
            New User("Josef", "New", Sex.Man, New DateTime(1978, 3, 19), EyeColor.Brown, HairColor.Brown),
            New User("Jan", "Marek", Sex.Man, New DateTime(1968, 4, 28), EyeColor.Black Or EyeColor.Brown, HairColor.NotSpecified),
            New User("Charles", "New", Sex.Man, New DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond),
            New User("Marie", "New", Sex.Woman, New DateTime(1988, 8, 15), EyeColor.Blue, HairColor.Black),
            New User("Lucy", "Novak", Sex.Woman, New DateTime(1978, 10, 2), EyeColor.Cyan, HairColor.Blond),
            New User("Simon", "Young", Sex.Woman, New DateTime(1968, 1, 8), EyeColor.NotSpecified, HairColor.Brown),
            New User("Michael", "Futigue", Sex.Woman, New DateTime(1958, 12, 6), EyeColor.Blue, HairColor.Ginger)
        }

        users = users.Distinct().ToList()

        For Each user As User In users
            Console.WriteLine(user)
        Next

        Console.ReadLine()
    End Sub
End Module
