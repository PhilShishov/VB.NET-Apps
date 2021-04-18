Public Class CruiseCollection
    Public ReadOnly Property Items As New List(Of Cruise)

    Public Sub New()
        Items.Add(New Cruise(1000, RegionInfo.Names(0), True, 45, "Fjords of Norway, 5 days"))
        Items.Add(New Cruise(2000, RegionInfo.Names(0), False, 35, "Fjords of Norway, 4 days"))
        Items.Add(New Cruise(3000, RegionInfo.Names(0), False, 25, "Norwegian Family Cruise, 3 days"))

        Items.Add(New Cruise(1500, RegionInfo.Names(0), True, 55, "Scotland, 4 days"))
        Items.Add(New Cruise(2000, RegionInfo.Names(0), False, 35, "Ireland, 3 days"))

        Items.Add(New Cruise(1500, RegionInfo.Names(1), True, 45, "Bahamas, 5"))
        Items.Add(New Cruise(2000, RegionInfo.Names(1), True, 20, "Western Caribbean Family"))
        Items.Add(New Cruise(2500, RegionInfo.Names(1), True, 35, "Miami to Barbados"))
        Items.Add(New Cruise(2500, RegionInfo.Names(1), True, 25, "Miami to Bimini"))

        Items.Add(New Cruise(2500, RegionInfo.Names(2), True, 30, "Alaska InsidePassage, 7 days"))
        Items.Add(New Cruise(1800, RegionInfo.Names(2), False, 35, "Alaska - Glacier, 6 days"))
        Items.Add(New Cruise(1200, RegionInfo.Names(2), False, 25, "Alaska - Glacier Bay , 4 days"))
        Items.Add(New Cruise(2200, RegionInfo.Names(2), True, 45, "Alaska - Kenai Peninsula, 3 days"))
    End Sub
End Class
