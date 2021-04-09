Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ItemsTableAdapter.Fill(Me.ComboBoxDataset.Items)
        Load_LBLS_Data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ItemsTableAdapter.FillByDesc(Me.ComboBoxDataset.Items)
        Load_LBLS_Data()
    End Sub

    Private Sub ComboBoxSender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSender.SelectedIndexChanged
        Load_LBLS_Data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New AdvancedComboForm
        f.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim crud As New ComboItemsCrudForm
        crud.Show()
    End Sub

    Sub Load_LBLS_Data()
        Me.LabelSelectedItemIndex.Text = Me.ComboBoxSender.SelectedIndex.ToString
        Me.LabelSelectedItemText.Text = Me.ComboBoxSender.Text
        Me.LabelSelectedItemValue.Text = Me.ComboBoxSender.SelectedValue.ToString
    End Sub
End Class
