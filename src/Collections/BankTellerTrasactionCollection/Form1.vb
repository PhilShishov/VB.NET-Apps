Imports System.IO

Public Class frmBankTeller
    Private currAccount As Account
    Private ReadOnly filePath As String = "..\..\accounts.dat"

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        currAccount = New Account() With {
            .FilePath = filePath
        }

        If currAccount.GetData(txtAccountNum.Text) Then
            lblAccountName.Text = currAccount.AccountName
            lblBalance.Text = currAccount.Balance.ToString("c")
            btnDeposit.Enabled = True
            btnWithdraw.Enabled = True
        Else
            MessageBox.Show(currAccount.ErrorMsg, "Error")
            Clear()
        End If

    End Sub

    Private Sub Clear()
        lblAccountName.Text = String.Empty
        lblBalance.Text = String.Empty
        btnDeposit.Enabled = False
        btnWithdraw.Enabled = False
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Try
            currAccount.Deposit(CDec(txtAmount.Text))
            lblBalance.Text = currAccount.Balance.ToString("c")
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error")
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric deposit amount", "Error")
        End Try
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Try
            If currAccount.Withdraw(CDec(txtAmount.Text)) Then
                lblBalance.Text = currAccount.Balance.ToString("c")
            Else
                MessageBox.Show(currAccount.ErrorMsg, "Error")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error")
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric withdrawal amount", "Error")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click
        MessageBox.Show($"Total deposits = {currAccount.TotalDeposits:C}, " &
                        $"Total Withdrawals = {currAccount.TotalWithdrawals:C}")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If currAccount.GetData() Then
            Using writer As New StreamWriter(filePath, False)
                For i As Integer = 0 To currAccount.Records.Count - 1
                    If currAccount.AccountId = currAccount.Records(i).AccountId Then
                        writer.WriteLine(currAccount.AccountId & "," &
                                         currAccount.AccountName & "," &
                                         currAccount.Balance.ToString())
                    Else
                        writer.WriteLine(currAccount.Records(i).AccountId & "," &
                                         currAccount.Records(i).AccountName & "," &
                                         currAccount.Records(i).Balance.ToString())
                    End If
                Next
            End Using
        Else
            MessageBox.Show(currAccount.ErrorMsg, "Error")
            Clear()
        End If
    End Sub
End Class