Imports System.IO

Public Class MainForm

    Private ReadOnly filePath = "..\..\..\workshops.txt"
    Private workshops() As Workshop

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetFile()
        FillList()
    End Sub


    Private Function GetFile()
        Dim input As StreamReader = Nothing
        lblResult.Text = String.Empty

        Try
            input = File.OpenText(filePath)
            Dim numVals As Integer = File.ReadAllLines(filePath).Length
            ReDim workshops(numVals - 1)

            For i = 0 To numVals - 1
                Dim line As String = input.ReadLine()
                Dim fields() As String = line.Split("\"c)
                Dim workshop As New Workshop With {
                        .Category = CType(fields(0), Workshop.CategoryType),
                        .Days = CInt(fields(1)),
                        .Cost = CDbl(fields(2)),
                        .Title = fields(3)
                    }

                workshops(i) = workshop
            Next
            lblResult.Text = "Workshop successfully loaded"
            Return True
        Catch ex As Exception
            lblResult.Text = ex.Message
            Return False
        Finally
            If input IsNot Nothing Then input.Close()
        End Try

        Return False
    End Function

    Private Sub FillList()
        lstWorkshops.Items.Clear()

        For Each ws As Workshop In workshops
            lstWorkshops.Items.Add(ws)
        Next
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click

        Dim index As Integer = lstWorkshops.SelectedIndex

        If index = -1 Then
            lblResult.Text = "Please select a workshop"
            Return
        Else
            lblResult.Text = String.Empty
        End If


        Dim form As New DetailsForm()
        form.SingleWorkshop = workshops(index)
        form.ShowDialog()
        FillList()
    End Sub
End Class
