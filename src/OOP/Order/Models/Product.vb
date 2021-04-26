Public Class Product
    Private _id As Integer
    Private _name As String
    Private _description As String
    Private _price As Integer

    Public Sub New(name As String, description As String, price As Integer)
        Me.Name = name
        Me.Description = description
        Me.Price = price
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Private Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Private Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Price As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
