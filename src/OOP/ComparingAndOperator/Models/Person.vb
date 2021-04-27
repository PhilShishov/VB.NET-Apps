Public Class Person
    Implements IComparable

    Private Shared generator As New Random()

    Public Sub New(name As String, lastName As String, birthDate As Date)
        Me.Name = name
        Me.LastName = lastName
        Me.BirthDate = birthDate
    End Sub

    Public Property Name As String
    Public Property LastName As String
    Public Property BirthDate As Date

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim c As Person = DirectCast(obj, Person)
        If Name = c.Name And LastName = c.LastName Then
            Return BirthDate.CompareTo(c.BirthDate)
        End If
        Return Name.CompareTo(c.Name)
    End Function

    Public Overrides Function ToString() As String
        Return String.Format($"{Name} {LastName} {BirthDate.Year.ToString().Substring(2, 2)}")
    End Function

    Public Shared Operator +(c1 As Person, c2 As Person) As Person
        If (c1.GetType() = c2.GetType()) Then
            Return Nothing
        End If
        Dim man As Man
        Dim woman As Woman
        If (TypeOf c1 Is Man) Then
            man = DirectCast(c1, Man)
            woman = DirectCast(c2, Woman)
        Else
            man = DirectCast(c2, Man)
            woman = DirectCast(c1, Woman)
        End If

        If (generator.Next(2) = 0) Then
            Return New Man("Adam", man.LastName, DateTime.Now)
        End If
        Return New Woman("Eva", woman.LastName, DateTime.Now)
    End Operator
End Class
