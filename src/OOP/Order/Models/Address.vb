Public Class Address

    Private _street As String
    Private _houseNumber As Integer
    Private _registryNumber As Integer
    Private _city As String
    Private _zipCode As String

    Public Sub New(street As String, houseNumber As Integer, registryNumber As Integer, city As String, zipCode As String)
        Me.Street = street
        Me.HouseNumber = houseNumber
        Me.RegistryNumber = registryNumber
        Me.City = city
        Me.ZipCode = zipCode
    End Sub

    Public Property Street As String
        Get
            Return _street
        End Get
        Private Set(value As String)
            _street = value
        End Set
    End Property


    Public Property HouseNumber As Integer
        Get
            Return _houseNumber
        End Get
        Private Set(value As Integer)
            _houseNumber = value
        End Set
    End Property


    Public Property RegistryNumber As Integer
        Get
            Return _registryNumber
        End Get
        Private Set(value As Integer)
            _registryNumber = value
        End Set
    End Property


    Public Property City As String
        Get
            Return _city
        End Get
        Private Set(value As String)
            _city = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return _zipCode
        End Get
        Set(value As String)
            _zipCode = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format($"{Street} {HouseNumber}/{RegistryNumber}, {City}")
    End Function

End Class
