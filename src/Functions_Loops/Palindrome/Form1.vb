Public Class PalindromeForm
  Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
    Dim word as String = txtWord.Text
    Dim wordNoPunctuation as String = ""

    For i as Integer = 0 To word.Length - 1
      Dim character as Char = Cchar(word.Substring(i,1).ToUpper())
      If Asc(character) >= 65 And Asc(character) <= 90 Then
        wordNoPunctuation += character
      End If
    Next

    If IsPalindrome(wordNoPunctuation) Then
      txtOutput.Text = "YES"
    Else 
      txtOutput.Text = "NO"
    End If
  End Sub

  Private Function IsPalindrome(word As String) As Boolean
    Dim reversedWord as String = ""

    For i as Integer = word.Length To 1 Step -1
      reversedWord += word.Substring(i - 1, 1)
    Next

    If reversedWord = word Then
      Return True
    Else 
      Return False
    End If

  End Function
End Class
