Public Class Sentence
    Private words() As String

    Public Sub New(text As String)
        Dim separators = {"."c, ","c, "!"c, ":"c, " "}
        words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
    End Sub

    Public Delegate Function MapFunction(word As String) As String
    Public Delegate Function AggregateFunction(result As String, word As String) As String

    Public Sub Map(func As MapFunction)
        For i As Integer = 0 To words.Length - 1
            words(i) = func(words(i))
        Next
    End Sub

    Public Function Aggregate(func As AggregateFunction) As String
        If words.Length = 0 Then
            Return Nothing
        End If
        Dim result As String = words(0)
        For i As Integer = 1 To words.Length - 1
            result = func(result, words(i))
        Next
        Return result
    End Function

    Public Overrides Function ToString() As String
        Return String.Join(" ", words) + "."
    End Function
End Class
