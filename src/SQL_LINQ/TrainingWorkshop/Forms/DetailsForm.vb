Public Class frmDetailsForm
    Public Property WorkshopId As Short
    Private workshops As New Workshop

    Private Sub frmDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.DataSource = workshops.Categories
        cboCategory.DisplayMember = "Description"
        cboCategory.ValueMember = "ID"

        Dim row As TrainingDataSet.WorkshopsRow = workshops.FindById(WorkshopId)
        txtTitle.Text = row.Title
        txtDays.Text = row.NumOfDays.ToString()
        txtCost.Text = row.Cost.ToString("n")
        cboCategory.SelectedValue = row.CategoryId
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If workshops.Update(WorkshopId, CShort(cboCategory.SelectedValue), CShort(txtDays.Text),
                           CDec(txtCost.Text), txtTitle.Text) Then
            Close()
        Else
            MessageBox.Show("Cannot update the Workshops table")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class