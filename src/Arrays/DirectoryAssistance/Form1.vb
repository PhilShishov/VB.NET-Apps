Public Class DirectoryAssistanceForm
    ReadOnly employees() As String = IO.File.ReadAllLines("Employees.txt")

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ValidateHandler("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        ValidateHandler("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        ValidateHandler("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        ValidateHandler("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        ValidateHandler("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        ValidateHandler("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        ValidateHandler("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        ValidateHandler("8")
    End Sub

    Private Sub btnAnother_Click(sender As Object, e As EventArgs) Handles btnAnother.Click
        lstOutput.Items.Clear()
        txtCode.Text = ""
    End Sub

    Private Sub ValidateHandler(code As String)
        If txtCode.Text.Length < 4 Then
            txtCode.Text += code
            If txtCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub DisplayNames()
        Dim query = From line In employees
                    Let lastName As String = line.Split(","c)(0)
                    Let firstName As String = line.Split(","c)(1)
                    Let extension As String = line.Split(","c)(2)
                    Let code As String = GetCode(lastName, firstName)
                    Where code = txtCode.Text
                    Select firstName, lastName, extension

        If query.Count() = 0 Then
            lstOutput.Items.Add("The name was not found")
        Else
            For Each employee In query
                lstOutput.Items.Add(employee.firstName + ", " + employee.lastName + " ext:" + employee.extension)
            Next
        End If
    End Sub

    Private Function GetCode(last As String, first As String) As String
        Dim word As String
        Dim code As String = String.Empty
        word = (last.Substring(0, 3) & first.Substring(0, 1)).ToUpper()
        For i As Integer = 0 To 3
            code += Translate(word.Substring(i, 1)).ToString()
        Next

        Return code
    End Function

    Private Function Translate(letter As String) As Integer
        Dim pushCode As Integer
        Select Case letter
            Case "A", "B", "C"
                pushCode = 1
            Case "D", "E", "F"
                pushCode = 2
            Case "G", "H", "I"
                pushCode = 3
            Case "J", "K", "L"
                pushCode = 4
            Case "M", "N", "O"
                pushCode = 5
            Case "P", "Q", "R", "S"
                pushCode = 6
            Case "T", "U", "V"
                pushCode = 7
            Case "W", "X", "Y", "Z"
                pushCode = 8
        End Select
        Return pushCode
    End Function
End Class
