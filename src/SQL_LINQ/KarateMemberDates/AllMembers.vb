Public Class AllMembers
    Private Sub AllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MembersTableAdapter.Fill(KarateDataSet.Members)
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            KarateMembersBindingSource.Filter = txtFilter.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class