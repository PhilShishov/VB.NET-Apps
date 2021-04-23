Public Class DetailsForm
    Public Property SingleWorkshop As Workshop

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With SingleWorkshop
            .Title = txtTitle.Text
            .Days = CInt(txtDays.Text)
            .Cost = CDbl(txtCost.Text)
            .Category = CType(cboCategory.SelectedIndex, Workshop.CategoryType)
        End With
        Close()
    End Sub

    Private Sub frmDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.DataSource = Workshop.Categories

        With SingleWorkshop
            txtTitle.Text = .Title
            txtDays.Text = .Days.ToString()
            txtCost.Text = .Cost.ToString("n")
            cboCategory.SelectedIndex = .Category
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class