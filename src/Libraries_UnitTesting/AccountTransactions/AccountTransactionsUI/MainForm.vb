Public Class MainForm
    Dim accounts As New List(Of SavingsAccount)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim acct1 As New SavingsAccount("00012", "Almasi, Pavol", 2500, 0.04)
        Dim acct2 As New SavingsAccount("00304", "Johnson, Bob", 1500, 0.028)

        acct1.TransHistory.Items.Add(#9/20/2019#, New Transaction(#9/20/2019#, TransactionType.Deposit, 250.0))
        acct1.TransHistory.Items.Add(#9/21/2019#, New Transaction(#9/21/2019#, TransactionType.Withdrawal, 850.0))
        acct1.TransHistory.Items.Add(#9/22/2019#, New Transaction(#9/22/2019#, TransactionType.Deposit, 625.0))

        accounts.Add(acct1)

        acct2.TransHistory.Items.Add(#9/20/2019#, New Transaction(#9/20/2019#, TransactionType.Deposit, 150.0))
        acct2.TransHistory.Items.Add(#9/21/2019#, New Transaction(#9/21/2019#, TransactionType.Withdrawal, 350.0))
        acct2.TransHistory.Items.Add(#9/22/2019#, New Transaction(#9/22/2019#, TransactionType.Deposit, 425.0))

        accounts.Add(acct2)

        lstAccounts.DataSource = accounts
        lstAccounts.SetSelected(0, False)
        lstHistory.Items.Clear()
    End Sub

    Private Sub lstAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccounts.SelectedIndexChanged
        If lstAccounts.SelectedIndex = -1 Then Return

        Try
            Dim id As String = lstAccounts.SelectedItem.ToString().Split(","c)(0)
            Dim index As Integer = lstAccounts.SelectedIndex

            lstHistory.Items.Clear()
            For Each trans As Transaction In accounts.Item(index).TransHistory.Items.Values
                lstHistory.Items.Add(trans)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
