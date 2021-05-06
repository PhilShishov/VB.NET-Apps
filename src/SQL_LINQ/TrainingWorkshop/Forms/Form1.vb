Public Class frmMain
    Private workshops As New Workshop

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvWorkshops.DataSource = workshops.Items
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        If dgvWorkshops.SelectedRows.Count = 0 Then
            lblResult.Text = "Please select a workshop"
            Return
        Else
            lblResult.Text = String.Empty
        End If

        Dim wk As New Workshop()
        wk.Id = CShort(dgvWorkshops.SelectedRows(0).Cells(0).Value)

        Dim frm As New frmDetailsForm
        frm.WorkshopId = wk.Id
        frm.ShowDialog()
        dgvWorkshops.DataSource = workshops.Items
    End Sub
End Class
