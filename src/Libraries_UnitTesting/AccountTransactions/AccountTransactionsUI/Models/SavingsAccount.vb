Public Class SavingsAccount
    Inherits Account

    Public Sub New(id As String, owner As String, cashBalance As Double, accountInterestRate As Double)
        MyBase.New(id, owner, cashBalance)
        InterestRate = accountInterestRate
        TransHistory = New TransactionHistory()
    End Sub

    Public Property InterestRate As Double
    Public Property TransHistory As TransactionHistory

End Class
