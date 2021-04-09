Public Class LengthConversionForm
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim miles, yards, feet, inches As Double
        Dim kilometers, meters, centimeters As Double

        miles = CDbl(txtMiles.Text)
        yards = CDbl(txtYards.Text)
        feet = CDbl(txtFeet.Text)
        inches = CDbl(txtInches.Text)

        Dim totalInches As Double = 63360 * miles + 36 * yards + 12 * feet + inches

        meters = totalInches / 39.37

        kilometers = Int(meters / 1000)
        lstMetric.Items.Add(kilometers & " kilometers")

        Dim temp As Double = meters - (kilometers * 1000)
        meters = Int(temp)
        lstMetric.Items.Add(meters & " meters")

        temp = (temp - meters) * 100
        centimeters = temp
        lstMetric.Items.Add(centimeters.ToString("N1") & " centimeters")
    End Sub
End Class
