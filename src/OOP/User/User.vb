Public Class User
    Public Sub New(name As String, lastName As String, sex As Sex, birthDate As Date, eyes As EyeColor, hair As HairColor)
        Me.Name = name
        Me.LastName = lastName
        Me.Sex = sex
        Me.BirthDate = birthDate
        Me.Eyes = eyes
        Me.Hair = hair
    End Sub

    Public Property Name As String
    Public Property LastName As String
    Public Property BirthDate As Date
    Public Property Sex As Sex
    Public Property Eyes As EyeColor
    Public Property Hair As HairColor

    Public Shared Operator =(a As User, b As User) As Boolean
        Return a.Name = b.Name And a.LastName = b.LastName And a.BirthDate = b.BirthDate And a.Eyes = b.Eyes And a.Hair And b.Hair
    End Operator

    Public Shared Operator <>(a As User, b As User) As Boolean
        Return Not a = b
    End Operator

    Public Overrides Function Equals(obj As Object) As Boolean
        Return TypeOf obj Is User AndAlso Me = DirectCast(obj, User)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Name.GetHashCode() Xor LastName.GetHashCode() Xor BirthDate.GetHashCode() Xor Eyes.GetHashCode() Xor Hair.GetHashCode()
    End Function

    Public Overrides Function ToString() As String
        Return String.Format($"{Name} {LastName}, {BirthDate.Year}, eyes: {Eyes}, hair: {Hair}")
    End Function
End Class
