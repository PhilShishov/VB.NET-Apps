Public Class RudimentaryTranslatorForm

    Structure Words
        Dim english As String
        Dim french As String
        Dim german As String
    End Structure

    Dim input() As String = IO.File.ReadAllLines("Dictionary.txt")
    Dim wordArr(input.Count() - 1) As Words
    Dim englishSentence() As String
    Dim frenchSentence As String
    Dim germanSentence As String

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        frenchSentence = ""
        germanSentence = ""

        Dim sentence = txtEnglish.Text

        If sentence.Length < 1 Then
            MessageBox.Show("Please enter a valid English sentence", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEnglish.Focus()
            Exit Sub
        End If

        GetWords(sentence)

        For i As Integer = 0 To englishSentence.Count() - 1
            TranslateWord(englishSentence(i))
        Next

        txtFrench.Text = frenchSentence
        txtGerman.Text = germanSentence
    End Sub

    Private Sub GetWords(sentence As String)
        Dim numWords As Integer = sentence.Split(" "c).Length
        ReDim englishSentence(numWords - 1)

        For i As Integer = 0 To englishSentence.Count() - 1
            englishSentence(i) = sentence.Split(" "c)(i)
        Next
    End Sub

    Private Sub TranslateWord(word As String)
        Dim frenchTranslation As String = " "
        Dim germanTranslation As String = " "
        Dim translated As Boolean = False

        For i As Integer = 0 To wordArr.Count - 1
            If wordArr(i).english.ToUpper() = word.ToUpper() Then
                frenchTranslation = wordArr(i).french
                germanTranslation = wordArr(i).german
                translated = True
            End If
        Next

        If translated Then
            frenchSentence += frenchTranslation & " "
            germanSentence += germanTranslation & " "
        Else
            frenchSentence += word & " "
            germanSentence += word & " "
        End If
    End Sub

    Private Sub frmRudimentaryTranslator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim line As String
        For i As Integer = 0 To input.Count() - 1
            line = input(i)
            wordArr(i).english = line.Split(","c)(0)
            wordArr(i).french = line.Split(","c)(1)
            wordArr(i).german = line.Split(","c)(2)
        Next
    End Sub
End Class
