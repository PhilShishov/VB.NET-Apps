Public Class ComboForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String
        t = Me.TextBox1.Text
        '------------------------
        If (t = "") Then
            MessageBox.Show("You can't enter empty text!")
        Else
            Me.ComboBox1.Items.Add(t)
        End If
        '------------------------
        Me.count_Label3.Text = Me.ComboBox1.Items.Count.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = Me.ComboBox1.SelectedIndex
        '------------------------------
        If (i = -1) Then
            MessageBox.Show("First select your item!")
        Else
            Me.ComboBox1.Items.RemoveAt(i)
        End If
        '------------------------------
        Me.count_Label3.Text = Me.ComboBox1.Items.Count.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ComboBox1.Items.Clear()
        Me.count_Label3.Text = Me.ComboBox1.Items.Count.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Label1.Text = Me.ComboBox1.SelectedIndex.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Text = Me.ComboBox1.SelectedIndex.ToString()
        Me.count_Label3.Text = Me.ComboBox1.Items.Count.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fi As Integer
        fi = Me.ComboBox2.FindStringExact(Me.search_TextBox2.Text)
        '--------------------------------
        Me.Text = fi.ToString()
        Me.ComboBox2.SelectedIndex = fi
        '--------------------------------
        If (fi = -1) Then 'Not Found any item!
            MessageBox.Show("Not Found!")
        End If
        '--------------------------------
    End Sub
End Class
