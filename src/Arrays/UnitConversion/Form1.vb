Public Class UnitConversionForm
    Dim counter As Integer = 0
    Dim origUnitIndex, desiredUnitIndex As Integer

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim length As Double
        Dim inputFile() As String = IO.File.ReadAllLines("Units.txt")
        Dim units(inputFile.Length) As Double

        LoadUnits(inputFile, units)

        If Double.TryParse(txtLength.Text, length) And
           txtOriginal.Text <> "" And
           txtDesired.Text <> "" Then

            txtOutput.Text = (Calculate(units, length)).ToString("N")
        Else
            MessageBox.Show("Please enter valid length", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function Calculate(units() As Double, length As Double) As Double
        Return length * (units(origUnitIndex) / units(desiredUnitIndex))
    End Function

    Private Sub LoadUnits(ByRef inputFile() As String, ByRef units() As Double)
        For i = 0 To inputFile.Length - 1
            units(i) = CDbl(inputFile(i).Split(","c)(1))
        Next
    End Sub


    Private Sub lstUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnits.SelectedIndexChanged
        counter += 1

        If counter = 1 Then
            txtOriginal.Text = lstUnits.Text.Substring(2)
            origUnitIndex = lstUnits.SelectedIndex
        ElseIf counter = 2 Then
            txtDesired.Text = lstUnits.Text.Substring(2)
            desiredUnitIndex = lstUnits.SelectedIndex
        Else 'counter = 3, display unit in Original Text box, delete unit from Desired text box 
            txtOriginal.Text = lstUnits.Text.Substring(2)
            origUnitIndex = lstUnits.SelectedIndex
            txtDesired.Clear()
            counter = 1
        End If
    End Sub

End Class
