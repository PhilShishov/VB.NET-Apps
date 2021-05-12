Imports System.IO

Public Class InventoryFile
    Private inFile As StreamReader
    Private outFile As StreamWriter
    Private fileName As String

    Public Sub New(nameOfFile As String)
        fileName = nameOfFile
    End Sub

    Public Sub LoadData(inv As Inventory)
        inFile = File.OpenText(fileName)
        Dim item As New Item()

        Do Until inFile.Peek = -1
            item = ReadOneItem()
            If Not item Is Nothing Then
                inv.AddItem(item)
            End If
        Loop

        inFile.Close()
    End Sub

    Public Sub SaveData(inv As Inventory)
        outFile = File.CreateText(fileName)
        Dim item As New Item()

        For Each item In inv.Items
            WriteOneItem(item)
        Next

        outFile.Close()
    End Sub

    Private Sub WriteOneItem(item As Item)
        With outFile
            .WriteLine(item.IDNumber)
            .WriteLine(item.Description)
            .WriteLine(item.DailyRate)
            .WriteLine(item.WeeklyRate)
            .WriteLine(item.MonthlyRate)
            .WriteLine(item.Quantity)
        End With
    End Sub

    Private Function ReadOneItem() As Item
        Dim item As New Item()
        With inFile
            item.IDNumber = .ReadLine()
            item.Description = .ReadLine()
            item.DailyRate = CSng(.ReadLine())
            item.WeeklyRate = CSng(.ReadLine())
            item.MonthlyRate = CSng(.ReadLine())
            item.Quantity = CInt(.ReadLine())
        End With
        Return item
    End Function

End Class
