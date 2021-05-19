Public Class Airport
    Public Property Code As String
    Public Property UTCOffset As Integer
    Public Sub New(pCode As String, utc As Integer)
        Code = pCode
        UTCOffset = utc
    End Sub
End Class
