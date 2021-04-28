Public Class MyList

    Private items(10) As Object
    Private _count As Integer

    Default Public Property Item(ByVal i As Integer) As Object
        Get
            Return items(i)
        End Get
        Set(value As Object)
            items(i) = value
        End Set
    End Property

    Public Property Count As Integer
        Get
            Return _count
        End Get
        Private Set(value As Integer)
            _count = value
        End Set
    End Property

    Public Sub Add(item As Object)
        items(Count) = item
        Count += 1

        If Count = items.Length Then
            Dim longerItems(Count * 2) As Object
            items.CopyTo(longerItems, 0)
            items = longerItems
        End If
    End Sub
End Class