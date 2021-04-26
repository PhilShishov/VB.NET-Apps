Public Class Order
    Implements IOrder

    Private _number As Integer
    Private _quantities() As Integer
    Private customer As Customer
    Private shippingAddress As Address
    Private billingAddress As Address
    Private product As Product

    Public Sub New(number As Integer, product As Product, customer As Customer, shippingAddress As Address, billingAddress As Address)
        Me.Number = number
        Me.product = product
        Me.customer = customer
        Me.shippingAddress = shippingAddress
        Me.billingAddress = billingAddress
    End Sub

    Public Property Number As Integer Implements IOrder.Number
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    Public ReadOnly Property FirstName As String Implements IOrder.FirstName
        Get
            Return customer.Name
        End Get
    End Property

    Public ReadOnly Property LastName As String Implements IOrder.LastName
        Get
            Return customer.LastName
        End Get
    End Property

    Public ReadOnly Property Street As String Implements IOrder.Street
        Get
            Return billingAddress.Street
        End Get
    End Property

    Public ReadOnly Property HouseNumber As Integer Implements IOrder.HouseNumber
        Get
            Return billingAddress.HouseNumber
        End Get
    End Property

    Public ReadOnly Property RegistryNumber As Integer Implements IOrder.RegistryNumber
        Get
            Return billingAddress.RegistryNumber
        End Get
    End Property

    Public ReadOnly Property City As String Implements IOrder.City
        Get
            Return billingAddress.City
        End Get
    End Property

    Public ReadOnly Property Zip As String Implements IOrder.Zip
        Get
            Return billingAddress.ZipCode
        End Get
    End Property

    Public ReadOnly Property Country As String Implements IOrder.Country
        Get
            Return "USA"
        End Get
    End Property

    Public ReadOnly Property Products As String() Implements IOrder.Products
        Get
            Return {product.Name}
        End Get
    End Property

    Public ReadOnly Property Quantities As Integer() Implements IOrder.Quantities
        Get
            Return {1}
        End Get
    End Property

    Public ReadOnly Property Prices As Double() Implements IOrder.Prices
        Get
            Return {product.Price}
        End Get
    End Property
End Class
