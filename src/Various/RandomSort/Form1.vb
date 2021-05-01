Public Class SortIntegersForm

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim arraySize As Integer = Convert.ToInt32(nudValue.Value)
        Dim integerArray(arraySize) As Integer

        lstValues.Items.Clear()
        integerArray = SortIntegers(arraySize)

        For i = 0 To arraySize - 1
            lstValues.Items.Add(integerArray(i).ToString())
        Next

    End Sub

    Public Function SortIntegers(n As Integer) As Integer()
        Dim nArray(n) As Integer
        Dim sortRandom As Random = New Random()

        For i = 0 To n - 1
            nArray(i) = i
        Next

        Dim temp, s As Integer

        For i = n To 1 Step -1
            s = sortRandom.Next(0, i)
            temp = nArray(s)
            nArray(s) = nArray(i - 1)
            nArray(i - 1) = temp
        Next

        Return nArray
    End Function
End Class
