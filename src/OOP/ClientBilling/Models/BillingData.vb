Imports System.IO

Public Class BillingData
    Private billingFile As StreamWriter
    Private clientFile As StreamReader
    Private clientCollection As New Collection

    Sub New()
        If File.Exists("billing.txt") Then
            billingFile = File.AppendText("billing.txt")
        Else
            billingFile = File.CreateText("billing.txt")
        End If

        clientFile = File.OpenText("clients.txt")
        While clientFile.Peek <> -1
            clientCollection.Add(clientFile.ReadLine())
        End While
        clientFile.Close()
    End Sub

    Public ReadOnly Property ClientColl As Collection
        Get
            Return clientCollection
        End Get
    End Property

    Public Sub WriteBilling(record As String)
        billingFile.WriteLine(record)
    End Sub

    Public Sub CloseBilling()
        billingFile.Close()
    End Sub
End Class
