Public Class Price
    Private Shared Property InsuranceRate As Double = 0.1

    Private prices(,) As Double =
        {{35, 45, 80, 150, 280},
        {45, 55, 90, 170, 320},
        {32, 42, 78, 148, 275},
        {45, 55, 100, 175, 335},
        {10, 15, 25, 50, 90},
        {10, 15, 20, 45, 80},
        {10, 12, 15, 50, 90},
        {15, 20, 25, 70, 110}}

    Public Shared ReadOnly Property InsuranceCost(rentalAmount As Double)
        Get
            Return rentalAmount * InsuranceRate
        End Get
    End Property

    Public Function GetRentalPrice(equip As EquipmentType, duration As DurationType) As Double
        Return prices(equip, duration)
    End Function
End Class
