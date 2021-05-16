Public MustInherit Class Shape
    Public Property Name As String

    Public Sub New(nameOfShape As String)
        Name = nameOfShape
    End Sub

    Public MustOverride Function GetArea() As Double

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
