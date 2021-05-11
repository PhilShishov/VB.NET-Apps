Imports System.IO

Public Class TransactionLog
    Private Property LastError As String
    ReadOnly Property Items As New List(Of Transaction)
    Public Property FilePath As String = "..\..\..\Transaction.log"

    Public Sub Add(tran As Transaction)
        Items.Add(tran)
    End Sub

    Public Function Save() As Boolean
        Dim tFile As StreamWriter = Nothing
        Try
            tFile = File.CreateText(FilePath)
            For Each trans As Transaction In Items
                tFile.WriteLine(trans.ToString())
            Next
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        Finally
            If tFile IsNot Nothing Then tFile.Close()
        End Try
    End Function
End Class
