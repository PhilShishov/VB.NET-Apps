Public Class frmAddMember
    Dim id As Integer
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            KarateMembersBindingSource.EndEdit()
            MembersTableAdapter.Update(KarateDataSet.Members)
            Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDTextBox.Text = String.Empty
        KarateMembersBindingSource.AddNew()
        id = MembersTableAdapter.GetNewMemberID()
        IDTextBox.Text = id.ToString()
        Last_NameTextBox.Text = 5.ToString()
        MessageBox.Show(IDTextBox.Text)
    End Sub

    Private Sub frmAddMember_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KarateMembersBindingSource.CancelEdit()
    End Sub
End Class