Public Class AlphabeticalOrderForm
  Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
    Dim word as String = txtWord.Text

    If isTrippleConsecutive(word) Then
      txtOutput.Text = "YES"
    Else 
      txtOutput.Text = "NO"
    End If
  End Sub

  Private Function isTrippleConsecutive(word As String) As Boolean
    Dim result As Boolean = False
    Dim L1, L2, L3 As Integer

    For i As Integer = 0 To word.Length - 3
      L1 = Asc(word.ToUpper().Substring(i, 1))
      L2 = Asc(word.ToUpper().Substring(i + 1, 1))
      L3 = Asc(word.ToUpper().Substring(i + 2, 1))

      If L1 + 1 = L2 And L2 + 1 = L3 Then
        result = true
      End If
    Next

    Return result
  End Function
End Class
