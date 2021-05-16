Public Class Circle
    Inherits Shape

    Private center As Point
    Private radius As Double

    Public Sub New(centerCircle As Point, radiusCircle As Double)
        MyBase.New("Circle")
        center = centerCircle
        radius = radiusCircle
    End Sub

    Public Overrides Function GetArea() As Double
        Return Math.PI * radius * radius
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & ": center =  " & center.ToString() & ", radius" & radius.ToString()
    End Function
End Class
