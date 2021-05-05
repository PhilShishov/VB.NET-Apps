Public Class frmFindByName
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MembersTableAdapter.FillBySearchName(KarateDataSet.Members, txtLastName.Text)
    End Sub
End Class