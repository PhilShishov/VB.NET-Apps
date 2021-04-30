Module Program
    Sub Main()
        Dim sentence As New Sentence("Delegates in VB .NET work like method references.")
        sentence.Map(Function(s) If(s.Length > 5, s.ToUpper(), s))
        Console.WriteLine(sentence)
        Dim aggregate1 As String = sentence.Aggregate(Function(a, b) a & " " & b)
        Dim aggregate2 As String = sentence.Aggregate(Function(a, b) "(" & a & ") " & b)
        Dim aggregate3 As String = sentence.Aggregate(Function(a, b) a & " " & (If(b.Length > 4, b.Substring(0, 3) & ".", b)))

        Console.WriteLine($"Aggregates: {vbCrLf}{aggregate1}{vbCrLf}{aggregate2}{vbCrLf}{aggregate3}")
        Console.ReadKey()
    End Sub
End Module
