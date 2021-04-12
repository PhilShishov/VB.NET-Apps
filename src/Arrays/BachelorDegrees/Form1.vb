Public Class BachelorDegreesForm

    Dim input() As String = IO.File.ReadAllLines("Degrees.txt")
    Private Sub btnTable1_Click(sender As Object, e As EventArgs) Handles btnTable1.Click

        '-------------------------------------------------------
        'DISPLAY FORMATTED DATA IN GRID VIEW ORDERED BY FIELD OF STUDY
        '-------------------------------------------------------

        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year81 As String = record.Split(","c)(1)
                    Let year10 As String = record.Split(","c)(2)
                    Order By field
                    Select field, year81, year10

        dgvOutput.DataSource = query.ToList()
        dgvOutput.Columns(0).HeaderText = "Field of Study"
        dgvOutput.Columns(1).HeaderText = "Year 1981"
        dgvOutput.Columns(2).HeaderText = "Year 2010"

    End Sub

    '-------------------------------------------------------
    'DISPLAY FORMATTED DATA IN GRID VIEW. 
    'CALCULATE PERCENTAGE CHANGE
    'DATA IS DISPLAYED BY PERCENTAGE CHANGE IN DESC. ORDER
    '-------------------------------------------------------
    Private Sub btnTable2_Click(sender As Object, e As EventArgs) Handles btnTable2.Click
        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year81 As Integer = CInt(record.Split(","c)(1))
                    Let year10 As Integer = CInt(record.Split(","c)(2))
                    Let change As Double = (year10 - year81) / year81
                    Let changeOut As String = FormatPercent(change, 2)
                    Order By change Descending
                    Select field, changeOut

        dgvOutput.DataSource = query.ToList()
        dgvOutput.Columns(0).HeaderText = "Field of Study"
        dgvOutput.Columns(1).HeaderText = "% of change"
    End Sub

    Private Sub btnTable3_Click(sender As Object, e As EventArgs) Handles btnTable3.Click
        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year10 As Integer = CInt(record.Split(","c)(2))
                    Let chart As String = GetChart(year10)
                    Order By year10 Ascending
                    Select field, chart

        dgvOutput.DataSource = query.ToList()
        dgvOutput.Columns(0).HeaderText = "Field of Study"
        dgvOutput.Columns(1).HeaderText = "Number of Degrees in 2010"
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Function GetChart(year10 As Integer) As String
        Dim output As String
        Dim numOfDots As Integer = 0
        Dim dots As String = String.Empty

        numOfDots = CInt(Math.Round(year10, 0) / 10000)

        For i As Integer = 1 To numOfDots
            dots += "."
        Next

        output = dots & "  " & year10.ToString("N0")
        Return output
    End Function
End Class
