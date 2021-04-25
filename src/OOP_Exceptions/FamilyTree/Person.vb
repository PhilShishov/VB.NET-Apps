Public Class Person

    Public Father As Person

    Public Mother As Person

    Dim name As String

    Public Sub New(name As String, father As Person, mother As Person)
        Me.name = name
        Me.Father = father
        Me.Mother = mother
    End Sub

    Public Overrides Function ToString() As String
        Return name
    End Function
End Class
