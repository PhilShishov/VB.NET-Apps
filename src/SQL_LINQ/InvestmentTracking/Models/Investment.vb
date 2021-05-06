Public Class Investment
    Private Shared priceAdapter As New InvestTrackDbDataSetTableAdapters.PricesTableAdapter
    Private Shared investAdapter As New InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter
    Private Shared prices As New Collection

    Public Property Type As InvestmentType
    Public Property PurchaseDate As Date
    Public Property PricePerShare As Double
    Public Property NumOfShares As Integer
    Public Property Ticker As String

    Public ReadOnly Property PurchaseAmount As Double
        Get
            Return PricePerShare * NumOfShares
        End Get
    End Property

    Public Shared Sub LoadPrices()
        Dim table As InvestTrackDbDataSet.PricesDataTable = priceAdapter.GetData()
        For Each row As DataRow In table
            prices.Add(row("Price"), row("Ticker").ToString())
        Next
    End Sub

    Public Shared Function GetCurrentPrice(ticker As String) As Double
        If prices.Contains(ticker) Then
            Return CDbl(prices.Item(ticker))
        Else
            Return -1.0
        End If
    End Function

    Public Shared Sub Insert(inv As Investment)
        Dim rowToInsert As Integer = investAdapter.Insert(inv.Ticker, CShort(inv.Type), CDec(inv.PricePerShare),
                                                          inv.PurchaseDate, CShort(inv.NumOfShares))
    End Sub
End Class
