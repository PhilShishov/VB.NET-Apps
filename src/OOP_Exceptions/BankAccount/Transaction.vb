Public Class Transaction
    Private _name As String 'account name (checking or savings)
    Private _amount As Double
    Private _date As Date
    Private _credit As Boolean

    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Amount() As Double
        Get
            Return _amount
        End Get
    End Property

    Public ReadOnly Property TransDate() As Date
        Get
            Return _date
        End Get
    End Property

    Public ReadOnly Property Credit() As Boolean
        Get
            Return _credit
        End Get
    End Property

    Public Sub New(dt As Date, name As String, amount As Double, credit As Boolean)
        _name = name
        _amount = amount
        _credit = credit
        _date = dt
    End Sub

    Public Function Format() As String
        'Put information into the proper form for insertion into one of the two text files
        Return TransDate.ToString() & "," & Name & "," & Amount.ToString() & "," & Credit.ToString()
    End Function

End Class
