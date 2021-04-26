Public Class Customer

    Private _id As Integer
    Private _name As String
    Private _lastName As String

    Public Sub New(id As Integer, name As String, surname As String)
        Me.Id = id
        Me.Name = name
        Me.LastName = surname
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

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Private Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format($"{Name} {LastName}")
    End Function
End Class
