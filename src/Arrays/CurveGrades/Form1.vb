Public Class CurveGradesForm
    Dim m, s As Double
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click

        Dim inputFile() As String = IO.File.ReadAllLines("Scores.txt")
        Dim scores(inputFile.Length - 1) As Integer

        LoadScores(inputFile, scores)
        Array.Sort(scores)
        m = GetMean(scores)
        s = GetDeviation(scores, m)

        txtNumExams.Text = scores.Length.ToString()
        txtMean.Text = m.ToString("N")
        txtStandDev.Text = s.ToString("N")

        Dim query = From score In scores
                    Let grade = GetGrade(score, m, s)
                    Select score, grade

        dgvScores.DataSource = query.ToList
        dgvScores.Columns(0).HeaderText = "Score"
        dgvScores.Columns(1).HeaderText = "Grade"
    End Sub

    Private Function GetGrade(score As Integer, m As Double, s As Double) As String

        Dim grade As String = String.Empty

        If score >= m + 1.5 * s Then
            grade = "A"
        ElseIf score < m + 1.5 * s And score >= m + 0.5 * s Then
            grade = "B"
        ElseIf score < m + 0.5 * s And score >= m - 0.5 * s Then
            grade = "C"
        ElseIf score < m - 0.5 * s And score >= m - 1.5 * s Then
            grade = "D"
        ElseIf score < m - 1.5 * s Then
            grade = "F"
        End If

        Return grade
    End Function

    Private Function GetDeviation(scores() As Integer, m As Double) As Double
        Dim result As Double
        For i = 0 To scores.Length - 1
            result += Math.Pow((scores(i) - m), 2)
        Next

        Return Math.Sqrt(result / scores.Length)
    End Function

    Private Function GetMean(scores() As Integer) As Double
        Return scores.Sum() / scores.Length
    End Function

    Private Sub LoadScores(inputFile() As String, scores() As Integer)
        For i = 0 To inputFile.Length - 1
            scores(i) = CInt(inputFile(i))
        Next
    End Sub
End Class
