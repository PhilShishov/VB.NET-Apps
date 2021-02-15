Public Class EventForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("I'm Clicked!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("I'm Clicked!!!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "I'm Form  load Event..."
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Text = "I'm Hovered!"
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("I'm Closing...")
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Text = "I'm Clicked as Form..."
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Text = "I'm Resized..."
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Me.Text = "You Pressed a Key: " + e.KeyCode.ToString()
        ''''''If (e.KeyCode = Keys.F4) Then
        ''''''    ' MessageBox.Show("You pressed F4")
        ''''''    Button1_Click(sender, e)
        ''''''End If
        '''''''------------------------------
        ''''''If (e.KeyCode = Keys.F5) Then
        ''''''    ' Button1_Click(sender, e)
        ''''''End If
        '''''''------------------------------
        ''''''If (e.KeyCode = Keys.F6) Then
        ''''''    'Button1_Click(sender, e)
        ''''''End If
        '''''''------------------------------
        ''''''If (e.KeyCode = Keys.Escape) Then
        ''''''    Me.Close()
        ''''''End If
        '''''''---------------------------
        Select Case e.KeyCode
            Case Keys.F4
                Button1_Click(sender, e)

            Case Keys.Escape
                Me.Close()

        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Text = Me.TextBox1.Text
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        Me.TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Me.TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        Me.TextBox2.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        Me.TextBox2.BackColor = Color.White
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        Me.TextBox3.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        Me.TextBox3.BackColor = Color.White
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.Button2.BackColor = Color.Yellow
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.LightGray
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        '''''Me.Text = Me.CheckBox1.Checked.ToString()
        '''''If (Me.CheckBox1.Checked = True) Then
        '''''    Me.Text = "You Checked Me!"
        '''''End If
        '''''If (Me.CheckBox1.Checked = False) Then
        '''''    Me.Text = "You Unchecked Me!"
        '''''End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        '-------------------------------------------
        Me.Text = Me.CheckBox1.Checked.ToString()
        If (Me.CheckBox1.Checked = True) Then
            Me.Text = "You Checked Me!"
        End If
        If (Me.CheckBox1.Checked = False) Then
            Me.Text = "You Unchecked Me!"
        End If
        '-------------------------------------------
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TextBox1.Text = Me.ComboBox1.SelectedIndex.ToString()
        Me.TextBox2.Text = Me.ComboBox1.Text
    End Sub

    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox1.DropDownClosed
        MessageBox.Show("I'm Closing!!!")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.TextBox1.Text = Me.ListBox1.SelectedIndex.ToString()
        Me.TextBox2.Text = Me.ListBox1.Text
    End Sub
End Class
