Public Class BankAccountForm
    Dim WithEvents checking As New Account("Checking")
    Dim WithEvents savings As New Account("Savings")
    Dim check As Boolean 'true if current mode is checking
    Dim committed As Boolean 'true if transaction was committed
    Dim curDate As Date 'current date

    Structure Trans
        Dim dt As Date 'date
        Dim trsType As String 'transaction type (credit or debit)
        Dim newBal As Double 'new balance (after each transaction)
        Dim amt As Double 'amount of transaction
        Dim cred As Boolean 'credit (or debit)
    End Structure

    Dim trs() As Trans

    Private Sub frmBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup user interface for Checking.
        'Load the transactions from the data files.
        checking.Load()
        savings.Load()
        'Select checking account as account to transfer from
        cboTransfer.SelectedIndex = 0
        'Select checking account as the first account to see
        cboAccount.SelectedIndex = 0
        txtDate.Text = Today.ToString()
        UpdateGrid()
    End Sub

    Private Sub UpdateGrid()
        Dim temp() As String
        If cboAccount.SelectedIndex = 0 Then
            temp = IO.File.ReadAllLines("Checking.txt")
        Else
            temp = IO.File.ReadAllLines("Savings.txt")
        End If

        Dim n = temp.Count() - 1
        Dim line() As String
        ReDim trs(n)

        For i As Integer = 0 To n
            Dim previousBalance As Double = 0
            line = temp(i).Split(","c)
            trs(i).dt = Convert.ToDateTime(line(0), Globalization.CultureInfo.InvariantCulture)
            trs(i).trsType = line(1)
            trs(i).amt = CDbl(line(2))
            If i = 0 Then
                previousBalance = 0
            Else
                previousBalance = trs(i - 1).newBal
            End If
            If CBool(line(3)) Then
                trs(i).newBal = previousBalance + trs(i).amt
            Else
                trs(i).newBal = previousBalance - trs(i).amt
            End If
        Next

        Dim query = From s In trs
                    Let amt = s.amt.ToString("C")
                    Let newBal = s.newBal.ToString("C")
                    Select s.dt, s.trsType, s.amt, s.newBal

        dgvTransactions.DataSource = query.ToList
        dgvTransactions.Columns("dt").HeaderText = "Date"
        dgvTransactions.Columns("trsType").HeaderText = "Type of Transaction"
        dgvTransactions.Columns("amt").HeaderText = "Amount"
        dgvTransactions.Columns("newBal").HeaderText = "New Balance"

    End Sub

    Sub Insufficient(over As Double) Handles checking.InsufficientFunds, savings.InsufficientFunds
        'If insufficient funds, set the committed flag to false and display message
        committed = False
        MessageBox.Show("Insufficient Funds: " & over.ToString("C"), "Insufficient Funds")
    End Sub

    Sub CommittedTrans() Handles checking.TransactionCommitted, savings.TransactionCommitted
        'If transaction committed, set the committed flag to True
        committed = True
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged
        'Show the check group box if checking is enabled
        check = (cboAccount.SelectedIndex = 0)
        grpCheck.Visible = check
        Display()
        UpdateGrid()
    End Sub

    Private Sub Display()
        'Display the transactions belonging to the account
        If check Then
            'Display the balance in the text box
            txtBalance.Text = checking.Balance.ToString("C")
        Else
            txtBalance.Text = (savings.Balance).ToString("C")
        End If
        UpdateGrid()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'Deposit an amount into an account
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Deposit", CDbl(txtDeposit.Text), True)
        Dim sw As IO.StreamWriter = Nothing
        'Store transaction and update display
        If check Then
            checking.Add(trans)
            sw = IO.File.AppendText("Checking.txt")
        Else
            savings.Add(trans)
            sw = IO.File.AppendText("Savings.txt")
        End If

        sw.WriteLine(trans.Format())
        sw.Close()
        'Display new transaction
        Display()
        txtDeposit.Clear()
    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        'Withdraw an amount from an account
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Withdrawal", CDbl(txtWithdrawal.Text), False)
        Dim sw As IO.StreamWriter = Nothing
        'Store transaction and update display
        If check Then
            checking.Add(trans)
            If committed Then
                sw = IO.File.AppendText("Checking.txt")
            End If
        Else
            savings.Add(trans)
            If committed Then
                sw = IO.File.AppendText("Savings.txt")
            End If
        End If

        sw.WriteLine(trans.Format())
        sw.Close()
        'Display new transaction
        Display()
        txtWithdrawal.Clear()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Withdraw an amount from an account
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Check cashed By " & txtCheckTo.Text, CDbl(txtCheck.Text), False)
        'Store transaction and update display
        checking.Add(trans)
        If committed Then
            Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
            sw.WriteLine(trans.Format)
            sw.Close()
        End If
        'Display new transaction
        Display()
        txtCheck.Clear()
        txtCheckTo.Clear()
    End Sub

    Private Sub cboTransfer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransfer.SelectedIndexChanged
        'Display the proper account label caption.
        If cboTransfer.SelectedIndex = 0 Then
            lblTransferTo.Text = "to Savings"
        Else
            lblTransferTo.Text = "to Checking"
        End If
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        'Transfer money from one account to the other.
        Dim trans As Transaction
        Dim amount As Double = CDbl(txtTransfer.Text)
        curDate = CDate(txtDate.Text)
        Dim sw As IO.StreamWriter = Nothing
        Dim swLT As IO.StreamWriter = Nothing

        If cboTransfer.SelectedIndex = 0 Then
            'Store transaction from checking account
            trans = New Transaction(curDate, "Transfer to Savings", amount, False)
            checking.Add(trans)
            If committed Then
                sw = IO.File.AppendText("Checking.txt")
            End If
        Else
            'Store transaction from savings account.
            trans = New Transaction(curDate, "Transfer to Checking", amount, False)
            savings.Add(trans)
            If committed Then
                sw = IO.File.AppendText("Savings.txt")
            End If
        End If

        sw.WriteLine(trans.Format)
        sw.Close()
        'Deposit to other account only if last transaction was committed.
        If committed Then
            If cboTransfer.SelectedIndex = 0 Then
                'Store transaction to savings
                trans = New Transaction(curDate, "Transfer from Checking", amount, True)
                savings.Add(trans)
                swLT = IO.File.AppendText("Savings.txt")
            Else
                'Store transaction to checking
                trans = New Transaction(curDate, "Transfer from Savings", amount, True)
                checking.Add(trans)
                swLT = IO.File.AppendText("Checking.txt")
            End If

            Display()
            txtTransfer.Clear()
        End If

        swLT.WriteLine(trans.Format)
        swLT.Close()
    End Sub
End Class
