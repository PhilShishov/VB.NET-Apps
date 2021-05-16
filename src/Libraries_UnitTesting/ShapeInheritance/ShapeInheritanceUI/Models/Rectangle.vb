Public Class Rectangle
    Inherits Shape

    Private p1 As Point
    Private p2 As Point

    Public Sub New(point1 As Point, point2 As Point)
        MyBase.New("Rectangle")
        p1 = point1
        p2 = point2
    End Sub

    Public Overrides Function GetArea() As Double
        Dim length As Integer = Math.Abs(p2.X - p1.X)
        Dim width As Integer = Math.Abs(p2.Y - p1.Y)

        Return CDbl(length * width)
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & ": " & p1.ToString() & ", " & p2.ToString()
    End Function
End Class
