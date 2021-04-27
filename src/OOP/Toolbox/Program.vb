Module Program
    Sub Main()

        Dim Toolbox As New Toolbox(10000)
        Console.WriteLine(Toolbox)

        Toolbox.Put(New Hammer(1200, "Small hammer", False))
        Toolbox.Put(New Hammer(3000, "Big hammer", True))
        Toolbox.Put(New Hammer(4000, "Demolition hammer", True))
        Toolbox.Put(New Screwdriver(800, "Philips screwdriver"))
        Toolbox.Put(New Sawmill(2500, "Rusty sawmill"))
        Toolbox.Put(New ElectricScrewdriver(1800, "Bosh electric screwdriver", 4000))

        Console.WriteLine(Toolbox)

        For Each n As Tool In Toolbox.Tools
            n.Work()
        Next

        Console.WriteLine($"The weight of the two-handed hammers {Toolbox.weightOfTwoHandedHammers()} grams")

        Console.ReadKey()
    End Sub
End Module
