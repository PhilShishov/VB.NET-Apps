Public Class Commitee
    Private members As New List(Of String)

    Public ReadOnly Property Items As List(Of String)
        Get
            Return members
        End Get
    End Property
End Class
