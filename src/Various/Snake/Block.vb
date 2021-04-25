Public Class Block
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Color As ConsoleColor

    Public ReadOnly Property OutsideConsole() As Boolean
        Get
            Return (X >= Console.WindowWidth / 2 Or Y >= Console.WindowHeight Or X < 0 Or Y < 0)
        End Get
    End Property

    Public Sub New(x As Integer, y As Integer, color As ConsoleColor)
        Me.X = x
        Me.Y = y
        Me.Color = color
    End Sub

    Public Sub Draw()
        If (Not OutsideConsole) Then
            Console.CursorLeft = X * 2
            Console.CursorTop = Y
            Console.ForegroundColor = Color
            Console.Write("██")
        End If
    End Sub

    Public Function Collision(block As Block) As Boolean
        Return (X = block.X And Y = block.Y)
    End Function

End Class
