Public MustInherit Class Tool

    Private _weight As Integer
    Private _name As String

    Public Sub New(weight As Integer, name As String)
        Me.Name = name
        Me.Weight = weight
    End Sub

    Public Property Weight As Integer
        Get
            Return _weight
        End Get
        Private Set(value As Integer)
            _weight = value
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

    Public MustOverride Sub Work()

    Public Overrides Function ToString() As String
        Return _name
    End Function
End Class