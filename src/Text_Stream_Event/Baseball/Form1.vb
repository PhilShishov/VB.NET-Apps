Public Class BaseballForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newFile As IO.StreamWriter = IO.File.CreateText("ALE2.txt")

        Dim query = From data In IO.File.ReadAllLines("ALE.txt")
                    Let team As String = data.ToString().Split(","c)(0)
                    Let wins As Integer = CInt(data.ToString().Split(","c)(1))
                    Let loses As Integer = CInt(data.ToString().Split(","c)(2))
                    Let percentage As Double = CDbl(wins / (wins + loses))
                    Order By percentage Descending
                    Select team & "," & wins & "," & loses & "," & FormatNumber(percentage.ToString(), 3)

        For i As Integer = 0 To query.Count - 1
            newFile.WriteLine(query(i))
        Next

        newFile.Close()
    End Sub
End Class
