Public Class frmFilterByDates

    Private Sub UpdateGrid()
        dgrMembers.DataSource = KarateMembersBindingSource

        If radBefore.Checked Then
            MembersTableAdapter.FillDatesBefore(KarateDataSet.Members, dtpJoinDate.Value)
        Else
            MembersTableAdapter.FillByDatesAfter(KarateDataSet.Members, dtpJoinDate.Value)
        End If
    End Sub

    Private Sub radBefore_CheckedChanged(sender As Object, e As EventArgs) Handles radBefore.CheckedChanged
        UpdateGrid()
    End Sub

    Private Sub radAfter_CheckedChanged(sender As Object, e As EventArgs) Handles radAfter.CheckedChanged
        UpdateGrid()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
