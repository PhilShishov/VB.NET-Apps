Public Class MealsForm
    Public seat As String
    Private Sub frmMeals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case seat
            Case "R"
                radRegular.Checked = True
            Case "L"
                radLowCal.Checked = True
            Case "V"
                radVeg.Checked = True
            Case Else
                radUnoccupied.Checked = True
        End Select
    End Sub

    Private Sub radUnoccupied_CheckedChanged(sender As Object, e As EventArgs) Handles radUnoccupied.CheckedChanged
        seat = "."
        Close()
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        seat = "R"
        Close()
    End Sub

    Private Sub radLowCal_CheckedChanged(sender As Object, e As EventArgs) Handles radLowCal.CheckedChanged
        seat = "L"
        Close()
    End Sub

    Private Sub radVeg_CheckedChanged(sender As Object, e As EventArgs) Handles radVeg.CheckedChanged
        seat = "V"
        Close()
    End Sub
End Class