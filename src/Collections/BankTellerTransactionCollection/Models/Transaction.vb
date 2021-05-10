Public Class Transaction
    Public ReadOnly Property AccountNumber As String
    Public ReadOnly Property TransactionDate As Date
    Public ReadOnly Property Amount As Decimal
    Public ReadOnly Property Balance As Decimal

    Public Sub New(acctNum As String, transDate As Date, amt As Decimal, bal As Decimal)
        AccountNumber = acctNum
        TransactionDate = transDate
        Amount = amt
        Balance = bal
    End Sub

    Public Overrides Function ToString() As String
        Return AccountNumber & ", " & TransactionDate & ", " & Amount & ", " & Balance
    End Function
End Class
