Public Class Student
    Public Property Id As Integer
    Public Property LastName As String
    Public Property Status As Integer
    Public Property Major As String
    Public Property Courses As List(Of Course)

    Public Sub New()
        Courses = New List(Of Course)
    End Sub
End Class
