Public Class SeatingChartForm

    Dim seats(15, 6) As String
    Dim frmAssign As New MealsForm()

    Private Sub frmSeatingChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRows.Items.Add(" ABC DEF ")
        For i As Integer = 1 To 15
            For j As Integer = 1 To 6
                seats(i, j) = "."
            Next
            lstRows.Items.Add(" ... ... ")
        Next
    End Sub

    Private Sub lstRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRows.SelectedIndexChanged
        Dim row As Integer = lstRows.SelectedIndex
        If row > 0 Then
            UpdateRow(row)
        End If
    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click
        Assign(1)
    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click
        Assign(2)
    End Sub

    Private Sub txtC_Click(sender As Object, e As EventArgs) Handles txtC.Click
        Assign(3)
    End Sub

    Private Sub txtD_Click(sender As Object, e As EventArgs) Handles txtD.Click
        Assign(4)
    End Sub

    Private Sub txtE_Click(sender As Object, e As EventArgs) Handles txtE.Click
        Assign(5)
    End Sub

    Private Sub txtF_Click(sender As Object, e As EventArgs) Handles txtF.Click
        Assign(6)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim meals(3) As Integer
        Dim vacant As Integer = 0
        Dim window As Integer = 0

        For i = 1 To 15
            For j = 1 To 6
                Select Case seats(i, j)
                    Case "R"
                        meals(1) += 1
                    Case "L"
                        meals(2) += 1
                    Case "V"
                        meals(3) += 1
                    Case Else
                        vacant += 1
                        If j = 1 Or j = 6 Then
                            window += 1
                        End If
                End Select
            Next
        Next

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Seats filled: " & (15 * 6 - vacant))
        lstDisplay.Items.Add("Windows available: " & window)
        lstDisplay.Items.Add("Regular Meals: " & meals(1))
        lstDisplay.Items.Add("Low Calorie Meals: " & meals(2))
        lstDisplay.Items.Add("Vegetarian Meals: " & meals(3))
    End Sub

    Private Sub UpdateRow(row As Integer)
        txtRow.Text = row.ToString()
        txtA.Text = seats(row, 1)
        txtB.Text = seats(row, 2)
        txtC.Text = seats(row, 3)
        txtD.Text = seats(row, 4)
        txtE.Text = seats(row, 5)
        txtF.Text = seats(row, 6)
    End Sub

    Private Sub Assign(seat As Integer)
        Dim row As Integer = lstRows.SelectedIndex
        If row > 0 Then
            frmAssign.seat = seats(row, seat)
            frmAssign.ShowDialog()
            seats(row, seat) = frmAssign.seat
            UpdateRow(row)
            lstRows.Items(row) = " " & seats(row, 1) & seats(row, 2) & seats(row, 3) & " " & seats(row, 4) &
                                       seats(row, 5) & seats(row, 6) & " "
        End If
    End Sub

End Class
