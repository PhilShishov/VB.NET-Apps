Imports MathNet.Numerics.Statistics

Public Class IntegerArray
    Public Property Data As Double()

    Public Function GetLargest() As Integer
        Dim largest As Integer = Integer.MinValue

        For i = 0 To Data.Length - 1
            If Data(i) > largest Then
                largest = Data(i)
            End If
        Next
        Return largest
    End Function

    Public Function GetSmallest() As Integer
        Dim smallest As Integer = Integer.MaxValue

        For i = 0 To Data.Length - 1
            If Data(i) < smallest Then
                smallest = Data(i)
            End If
        Next
        Return smallest
    End Function

    Public Function GetMedian() As Double
        Return Statistics.Median(Data)
    End Function
End Class
