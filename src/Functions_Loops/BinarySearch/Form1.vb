Public Class BinarySearchForm
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim letters As String = mtbInput.Text.ToUpper()
        Dim flag As Boolean = False
        Dim state As String = String.Empty
        Dim first, middle, last As Integer

        first = 0
        last = lstStates.Items.Count - 1

        Do While (Not flag) And (first <= last)
            middle = CInt((first + last) / 2)
            Select Case CStr(lstStates.Items(middle)).Substring(0, 2).ToUpper()
                Case letters
                    state = CStr(lstStates.Items(middle))
                    flag = True
                Case Is > letters
                    last = middle - 1
                Case Is < letters
                    first = middle + 1
            End Select
        Loop

        If flag Then
            txtOutput.Text = state
        Else
            txtOutput.Text = "No state begins with " & letters
        End If
    End Sub
End Class
