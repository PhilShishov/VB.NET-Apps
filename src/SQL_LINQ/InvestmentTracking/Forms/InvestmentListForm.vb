Public Class InvestmentListForm
    Private Sub frmInvestmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvestTrackDbDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDbDataSet.Investments)

    End Sub
End Class