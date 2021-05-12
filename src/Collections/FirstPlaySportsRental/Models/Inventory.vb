Public Class Inventory
    Private inventoryList As New Dictionary(Of String, Item)

    Public ReadOnly Property Items As Dictionary(Of String, Item).ValueCollection
        Get
            Return inventoryList.Values
        End Get
    End Property

    Public Sub AddItem(item As Item)
        inventoryList.Add(item.IDNumber, item)
    End Sub

    Public Sub RemoveItem(id As String)
        inventoryList.Remove(id)
    End Sub

    Public Function GetItem(id As String) As Item
        Try
            Return inventoryList.Item(id)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
