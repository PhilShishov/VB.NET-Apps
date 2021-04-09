Public Class AdvancedComboForm
    Private Sub AdvancedComboForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboItemsTableAdapter.FillBySenderGenderPriority(Me.ComboBoxDataset.Items)
        Me.SenderBindingSource.Filter = "GroupId = 1"
        Me.SenderBindingSource.Sort = "GroupId ASC"
        Me.PriorityBindingSource1.Filter = "GroupId = 20"
        Me.PriorityBindingSource1.Sort = ""
        Me.GenderBindingSource1.Filter = "GroupId = 100"
        Me.GenderBindingSource1.Sort = ""
        Me.CustomersInfoTableAdapter.Fill(Me.ComboBoxDataset.CustomersInfo)
    End Sub

    Private Sub ButtonAddSender_Click(sender As Object, e As EventArgs) Handles ButtonAddSender.Click
        Dim frm As New ComboItemsForm
        frm.group_id_Label1.Text = "1"
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            Call AdvancedComboForm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub ButtonAddPriority_Click(sender As Object, e As EventArgs) Handles ButtonAddPriority.Click
        Dim frm As New ComboItemsForm
        frm.group_id_Label1.Text = "20"
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            Call AdvancedComboForm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub ButtonAddGender_Click(sender As Object, e As EventArgs) Handles ButtonAddGender.Click
        Dim frm As New ComboItemsForm
        frm.group_id_Label1.Text = "100"
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            Call AdvancedComboForm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.CustomersInfoBindingSource.EndEdit()
            Dim r As Integer
            r = Me.CustomersInfoTableAdapter.Update(Me.ComboBoxDataset.CustomersInfo)
            If r > 0 Then
                MessageBox.Show("Saved!")
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Not Saved! Try again!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New ComboItemsCrudForm
        frm.parent_group_id.Text = "1"
        frm.ShowDialog()
        Call AdvancedComboForm_Load(sender, e)
        frm.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New ComboItemsCrudForm
        frm.parent_group_id.Text = "20"
        frm.ShowDialog()
        Call AdvancedComboForm_Load(sender, e)
        frm.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New ComboItemsCrudForm
        frm.parent_group_id.Text = "100"
        frm.ShowDialog()
        Call AdvancedComboForm_Load(sender, e)
        frm.Dispose()
    End Sub
End Class