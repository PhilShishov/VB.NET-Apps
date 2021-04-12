Imports System.Globalization


Public Class FileOfNamesForm
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim newName As String = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text)
        Const filename As String = "Names.txt"
        Dim names() = IO.File.ReadAllLines(filename)

        If newName.Length < 1 Then
            MessageBox.Show("Please enter a name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf names.Contains(newName) Then
            MessageBox.Show("The name already exists", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        IO.File.AppendAllText(filename, newName)

        'sort the file, with the new name already added
        Dim query = From name In IO.File.ReadAllLines(filename)
                    Order By name Ascending
                    Select name

        'ovewrite the file with a sorted one
        IO.File.WriteAllLines(filename, query)
        MessageBox.Show("Name was entered", "OK input", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
