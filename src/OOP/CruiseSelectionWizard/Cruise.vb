Public Class Cruise
    Public Property NumOfPassengers As Integer
    Public Property Region As String
    Public Property Formal As Boolean
    Public Property AverageAge As Integer
    Public Property Name As String

    'weighted criteria settings
    Private Shared numPassengersWt As Single
    Private Shared regionWt As Single
    Private Shared formalWt As Single
    Private Shared averageAgeWt As Single

    Public Sub New()
    End Sub

    Public Sub New(numberPassengers As Integer, cruiseRegion As String, formalAttire As Boolean,
                    avgAge As Integer, cruiseName As String)
        NumOfPassengers = numberPassengers
        Region = cruiseRegion
        Formal = formalAttire
        AverageAge = avgAge
        Name = cruiseName
    End Sub

    ' Set percentage weights for determining the selection criteria.
    Public Shared Sub SetWeights(numPassangers As Single, cruiseRegion As Single, formalInformal As Single,
                                 avgAge As Single)
        numPassengersWt = numPassangers
        regionWt = cruiseRegion
        formalWt = formalInformal
        averageAgeWt = avgAge
    End Sub

    Public Function CountMatches(cruiseObj As Cruise) As Single
        Dim matches As Single = 0.0

        ' Add 1 if desired ship size is within 500 of the actual size.
        If Math.Abs(NumOfPassengers - cruiseObj.NumOfPassengers) <= 500 Then matches += numPassengersWt

        If Region = cruiseObj.Region Then matches += regionWt

        If Formal = cruiseObj.Formal Then matches += formalWt

        ' Add 1 if desired average age is within 5 of the actual average age.
        If Math.Abs(AverageAge - cruiseObj.AverageAge) <= 5 Then matches += averageAgeWt

        Return matches
    End Function

End Class
