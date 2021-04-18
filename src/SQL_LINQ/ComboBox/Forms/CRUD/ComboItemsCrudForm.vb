Public Class ComboItemsCrudForm
    Private Sub ComboItemsCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLoader()
        Me.ItemsBindingSource.Sort = "ID ASC"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value As Integer
        Dim group_id As Int32
        Int32.TryParse(Me.parent_group_id.Text, group_id)
        value = Me.ItemsTableAdapter.InsertQuery(Me.TextBoxTitle.Text, group_id)
        If value > 0 Then 'Inserted
            DataLoader()
            Me.ItemsBindingSource.MoveLast()
            MessageBox.Show("Done! Count: " + value.ToString)
        Else
            MessageBox.Show("Failed!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim value, group_id As Integer
        Dim id As Long
        Dim dr As DialogResult

        dr = MessageBox.Show("Do you want to delete this record?", "Alert!", MessageBoxButtons.OKCancel)
        If dr = DialogResult.OK Then 'user is selected the ok button
            Int64.TryParse(Me.IdLabel1.Text, id)
            Int32.TryParse(Me.Group_idLabel1.Text, group_id)
            value = Me.ItemsTableAdapter.DeleteQuery(id)
            If value > 0 Then 'deleted

                DataLoader()

                MessageBox.Show("Done! Count: " + value.ToString)
            Else
                MessageBox.Show("Failed!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim new_item_title As String
        new_item_title = InputBox("Please enter new value:", "Edit your record", Me.Item_titleLabel1.Text)
        Dim result As Integer
        Dim id, group_id As Long

        Int64.TryParse(Me.IdLabel1.Text, id)
        Int32.TryParse(Me.Group_idLabel1.Text, group_id)
        Dim mgi As Int32
        Int32.TryParse(Me.parent_group_id.Text, mgi)
        result = Me.ItemsTableAdapter.UpdateQuery(new_item_title, mgi, id)
        If result > 0 Then 'updated
            DataLoader()
            MessageBox.Show("Done! Count: " + result.ToString)
        Else
            MessageBox.Show("Failed!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub DataLoader()
        Dim group_id As Int32
        Try
            Int32.TryParse(Me.parent_group_id.Text, group_id)
            Me.ItemsTableAdapter.FillByGroupId(Me.ComboBoxDataset.Items, group_id)
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message)
        End Try
    End Sub
End Class