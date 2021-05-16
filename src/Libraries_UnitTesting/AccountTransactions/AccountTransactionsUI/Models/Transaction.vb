Public Class Transaction
    Public Property TransDate As Date
    Public Property Type As TransactionType
    Public Property Amount As Double

    Public Sub New(transactionDate As Date, transactionType As TransactionType, transactionAmount As Double)
        TransDate = transactionDate
        Type = transactionType
        Amount = transactionAmount
    End Sub

    Public Overrides Function ToString() As String
        Dim typeStr As String = "Deposit"

        If Type = TransactionType.Withdrawal Then typeStr = "Withdrawal"

        Return TransDate & ", " & typeStr & ", " & Amount.ToString("c")
    End Function
End Class
