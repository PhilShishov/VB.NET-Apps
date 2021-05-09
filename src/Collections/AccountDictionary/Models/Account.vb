Public Class Account
    Public Property ID As String
    Public Property Name As String
    Public Property Balance As Decimal

    Public Sub New(pId As String, pName As String, pBalance As Decimal)
        ID = pId
        Name = pName
        Balance = pBalance
    End Sub

    Public Overrides Function ToString() As String
        Return ID & ", " & Name & ", " & Balance.ToString("n")
    End Function
End Class
