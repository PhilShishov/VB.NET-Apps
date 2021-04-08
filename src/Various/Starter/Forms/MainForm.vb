Public Class MainForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show(My.Resources.all_strings.frm1_Please_select_your_language)
            Exit Sub
        End If
        Dim msg As String
        msg = My.Resources.all_strings.frm1_Do_you_want_to_close_your_application
        If MessageBox.Show(msg, My.Resources.all_strings.frm1_Alert, MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim selected_lang As String
        selected_lang = "EN_DEFAULT"
        If Me.ComboBox1.SelectedIndex = 0 Then
            selected_lang = "EN_DEFAULT"
        End If
        If Me.ComboBox1.SelectedIndex = 1 Then
            selected_lang = "fr"
        End If
        If Me.ComboBox1.SelectedIndex = 2 Then
            selected_lang = "fr-CA"
        End If
        If Me.ComboBox1.SelectedIndex = 3 Then
            selected_lang = "ar"
        End If
        If Me.ComboBox1.SelectedIndex = 4 Then
            selected_lang = "ar-IQ"
        End If
        My.Settings.selected_language = selected_lang
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selected_lang As String
        selected_lang = My.Settings.selected_language
        If selected_lang = "EN_DEFAULT" Then
            Me.ComboBox1.SelectedIndex = 0
        ElseIf selected_lang = "fr" Then
            Me.ComboBox1.SelectedIndex = 1
        ElseIf selected_lang = "fr-CA" Then
            Me.ComboBox1.SelectedIndex = 2
        ElseIf selected_lang = "ar" Then
            Me.ComboBox1.SelectedIndex = 3
        ElseIf selected_lang = "ar-IQ" Then
        Me.ComboBox1.SelectedIndex = 4
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = My.Resources.all_strings.com_Done
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New HelloForm
        form.Show()
    End Sub
End Class
