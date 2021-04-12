Public Class ISBNValidatorForm
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click

        Dim input As String = mtbISBN.Text
        Dim i = 10, total As Integer

        Dim splitted As String() = input.Split("-"c)
        Dim nums As String = String.Join("", splitted).ToUpper()

        For Each ch In nums

            Dim current As Integer = Char.GetNumericValue(ch)

            If ch = "X" Then
                current = 10
            ElseIf IsNumeric(ch) = False Then
                txtOutput.Text = "NO"
                MessageBox.Show("You entered invalid character!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            total += current * i
            i -= 1
        Next

        If total Mod 11 = 0 Then
            txtOutput.Text = "YES"
        Else
            txtOutput.Text = "NO"
        End If
    End Sub
End Class
