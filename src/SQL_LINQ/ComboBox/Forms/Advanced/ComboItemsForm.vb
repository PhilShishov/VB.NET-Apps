Public Class ComboItemsForm
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ComboItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gi As Int32
        Try
            Int32.TryParse(Me.group_id_Label1.Text, gi)
            Me.ItemsTableAdapter.FillByGroupId(Me.ComboBoxDataset.Items, gi)
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message)
        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Dim rc As Integer
            rc = Me.ComboBoxDataset.Items.Rows.Count
            Dim gi As Integer
            Int32.TryParse(Me.group_id_Label1.Text, gi)
            For index = 0 To rc - 1
                If Me.ComboBoxDataset.Items.Rows.Item(index).RowState = DataRowState.Added Then
                    Me.ComboBoxDataset.Items.Rows.Item(index).Item(2) = gi 'group_id column
                End If
            Next
            Me.ItemsBindingSource.EndEdit()
            Dim r As Integer
            r = Me.ItemsTableAdapter.Update(Me.ComboBoxDataset.Items)
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 2 Then 'delete button
            Me.ItemsBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim rc As Integer
        rc = Me.ComboBoxDataset.Items.Rows.Count
        MessageBox.Show(rc.ToString)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim cc As Integer
        cc = Me.ComboBoxDataset.Items.Columns.Count
        MessageBox.Show(cc.ToString)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim rs As String
        rs = Me.ComboBoxDataset.Items.Rows.Item(3).RowState.ToString()
        MessageBox.Show(rs)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.listBox1.Items.Clear()
        Dim rc As Integer
        rc = Me.ComboBoxDataset.Items.Rows.Count
        For index = 0 To rc - 1
            Dim rs As String
            rs = Me.ComboBoxDataset.Items.Rows.Item(index).RowState.ToString()
            Me.listBox1.Items.Add(rs)
        Next
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.ComboBoxDataset.Items.Rows.Item(0).AcceptChanges()
        Me.ComboBoxDataset.Items.AcceptChanges()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.listBox1.Items.Clear()
        Dim cv As New Object

        Dim rc As Integer
        rc = Me.ComboBoxDataset.Items.Rows.Count
        For index = 0 To rc - 1
            cv = Me.ComboBoxDataset.Items.Rows.Item(index).Item(2)
            If cv Is DBNull.Value Then
            Else
                Me.listBox1.Items.Add(cv.ToString)
            End If
        Next

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim rc As Integer
        rc = Me.ComboBoxDataset.Items.Rows.Count
        For index = 0 To rc - 1
            Me.ComboBoxDataset.Items.Rows.Item(index).Item(2) = 100 'group_id column
            Me.ComboBoxDataset.Items.Rows.Item(index).Item("item_title") = "Test"
        Next
    End Sub
End Class