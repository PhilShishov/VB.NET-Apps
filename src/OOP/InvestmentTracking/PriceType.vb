Public Class PriceType
    Public Property Ticker As String
    Public Property Price As Double

    Public Property Investment As InvestmentType

    Enum InvestmentType
        Stock
        MutualFund
        Commodity
        MoneyMarket
    End Enum
End Class
