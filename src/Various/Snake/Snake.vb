Public Class Snake
    Private parts As New List(Of Block)
    Public Property Direction As Integer
    Public Property IsAlive As Boolean

    Private food As New Block(0, 0, ConsoleColor.Red)
    Private random As New Random()
    Private color As ConsoleColor = ConsoleColor.DarkMagenta

    Public Sub New()
        Direction = 0
        IsAlive = True

        parts.Add(New Block(15, 7, color))
        parts.Add(New Block(14, 7, color))
        parts.Add(New Block(14, 8, color))
        PlaceFood()
    End Sub

    Public Sub Draw()
        For Each part As Block In parts
            part.Draw()
        Next
        food.Draw()
    End Sub

    Public Sub Move()
        If (IsAlive) Then
            Dim newHead As New Block(parts(0).X, parts(0).Y, color)

            If (Direction = 0) Then
                newHead.X += 1
            End If
            If (Direction = 90) Then
                newHead.Y -= 1
            End If
            If (Direction = 180) Then
                newHead.X -= 1
            End If
            If (Direction = 270) Then
                newHead.Y += 1
            End If
            parts.Insert(0, newHead)

            If (parts(0).Collision(food)) Then
                PlaceFood()
            Else
                parts.RemoveAt(parts.Count - 1)
            End If
            If (parts(0).OutsideConsole) Then
                IsAlive = False
            End If

            For i As Integer = 1 To parts.Count - 1
                If (parts(0).Collision(parts(i))) Then
                    IsAlive = False
                End If
            Next
        End If
    End Sub

    Public Sub PlaceFood()
        If (OperatingSystem.IsWindows()) Then
            Console.Beep(900, 50)
        End If

        Dim isCollision As Boolean = True
        While (isCollision)
            food.X = random.Next(Console.WindowWidth / 2)
            food.Y = random.Next(Console.WindowHeight)
            isCollision = False

            For Each part As Block In parts
                If (food.Collision(part)) Then
                    isCollision = True
                End If
            Next
        End While
    End Sub
End Class
