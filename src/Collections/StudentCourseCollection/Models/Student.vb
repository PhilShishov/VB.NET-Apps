Public Class Student
    Private testAverage As Double

    Public Property IdNumber As String
    Public Property LastName As String
    Public Property Courses As Dictionary(Of String, Course)

    Public Property Average As Double
        Get
            Return testAverage
        End Get
        Set(value As Double)
            If value >= 0.0 And value <= 100.0 Then
                testAverage = value
            Else
                MessageBox.Show("Invalid test average", "Error")
            End If
        End Set
    End Property

    Public Sub New(id As String, lName As String, avg As Double)
        IdNumber = id
        LastName = lName
        Average = avg
        Courses = New Dictionary(Of String, Course)
    End Sub

    Public Overrides Function ToString() As String
        Return $"{IdNumber}, {LastName}, Test Average = {Average:N2}"
    End Function
End Class
