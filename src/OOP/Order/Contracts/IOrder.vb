Public Interface IOrder
    ReadOnly Property Number As Integer
    ReadOnly Property FirstName As String
    ReadOnly Property LastName As String
    ReadOnly Property Street As String
    ReadOnly Property HouseNumber As Integer
    ReadOnly Property RegistryNumber As Integer
    ReadOnly Property City As String
    ReadOnly Property Zip As String
    ReadOnly Property Country As String
    ReadOnly Property Products As String()
    ReadOnly Property Quantities As Integer()
    ReadOnly Property Prices As Double()
End Interface
