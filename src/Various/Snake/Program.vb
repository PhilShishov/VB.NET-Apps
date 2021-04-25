Imports System.Threading

Module Program
    Sub Main()
        Dim Snake As New Snake()
        While (Snake.IsAlive)
            Snake.Move()
            Console.BackgroundColor = ConsoleColor.Green
            Console.Clear()
            Snake.Draw()
            Thread.Sleep(50)

            If (Console.KeyAvailable) Then
                Dim key As ConsoleKeyInfo = Console.ReadKey()
                If key.Key = ConsoleKey.RightArrow Then
                    Snake.Direction = 0
                End If
                If key.Key = ConsoleKey.LeftArrow Then
                    Snake.Direction = 180
                End If
                If key.Key = ConsoleKey.DownArrow Then
                    Snake.Direction = 270
                End If
                If key.Key = ConsoleKey.UpArrow Then
                    Snake.Direction = 90
                End If
            End If
        End While
        Console.CursorLeft = 0
        Console.CursorTop = 0
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write("Game over...")
        Console.ReadKey()
    End Sub
End Module
