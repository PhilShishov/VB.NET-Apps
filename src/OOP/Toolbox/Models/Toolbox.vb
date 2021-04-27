Public Class Toolbox
    Private maxWeight As Integer
    Private _weight As Integer
    Private _tools As New List(Of Tool)

    Public Sub New(maxWeight As Integer)
        Me.maxWeight = maxWeight
        Weight = 1000
    End Sub

    Public Property Weight As Integer
        Get
            Return _weight
        End Get
        Private Set(value As Integer)
            _weight = value
        End Set
    End Property

    Public ReadOnly Property Tools As IEnumerable(Of Tool)
        Get
            Return _tools.ToArray()
        End Get
    End Property

    Public Function weightOfTwoHandedHammers() As Integer
        Dim sum As Integer = 0
        For Each tool As Tool In Tools
            If TypeOf tool Is Hammer AndAlso DirectCast(tool, Hammer).TwoHanded Then
                sum += tool.Weight
            End If
        Next
        Return sum
    End Function

    Public Function Put(tool As Tool) As Boolean
        If Not (Weight + tool.Weight > maxWeight) Then
            _tools.Add(tool)
            Weight += tool.Weight
            Return True
        End If
        Return False
    End Function

    Public Function Remove(tool As Tool) As Boolean
        If (_tools.Remove(tool)) Then
            Weight -= tool.Weight
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ToString() As String
        If Tools.Count > 0 Then
            Return "Box contents: " + String.Join(", ", Tools)
        End If
        Return "The box is empty."
    End Function
End Class
