Public Class Stock
    Implements IComparable

    Public Property Ticker As String
    Public Property Price As Double
    Public Property Earnings As Double

    Public ReadOnly Property PeRatio As Double
        Get
            If Earnings > 0 Then
                Return Price / Earnings
            Else
                Return 0.0
            End If
        End Get
    End Property

    Public Sub New(pTicker As String, pPrice As Double, pEarnings As Double)
        Ticker = pTicker
        Price = pPrice
        Earnings = pEarnings
    End Sub

    Public Overrides Function ToString() As String
        Return Ticker & ", price = " & Price.ToString("n") & ", P/E = " & PeRatio.ToString("n")
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return Ticker.CompareTo(CType(obj, Stock).Ticker)
    End Function
End Class
