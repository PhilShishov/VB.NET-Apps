Public Class Account
    Public Property ID As String
    Public Property Owner As String
    Public Property CashBalance As Double

    Public Sub New(accountId As String, accountOwner As String, accountBalance As Double)
        ID = accountId
        Owner = accountOwner
        CashBalance = accountBalance
    End Sub

    Public Overrides Function ToString() As String
        Return ID & ", " & Owner & ", " & CashBalance.ToString("c")
    End Function
End Class
