Public Class SelectLanguageForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '------------------------
        If Me.ListBox1.SelectedIndex = -1 Then
            MessageBox.Show(My.Resources.all_strings.frm1_Please_select_your_language)
            Exit Sub
        End If
        '------------------------
        Dim msg As String
        msg = My.Resources.all_strings.frm1_Do_you_want_to_close_your_application
        If MessageBox.Show(msg, My.Resources.all_strings.frm1_Alert, MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
            Exit Sub
        End If
        '------------------------
        Dim sl As String
        sl = "EN_DEFAULT"
        '----------------------------------
        If Me.ListBox1.SelectedIndex = 0 Then
            sl = "EN_DEFAULT"
        End If
        '------------
        If Me.ListBox1.SelectedIndex = 1 Then
            sl = "fr"
        End If
        '------------
        If Me.ListBox1.SelectedIndex = 2 Then
            sl = "de"
        End If
        '------------
        If Me.ListBox1.SelectedIndex = 3 Then
            sl = "ar"
        End If
        '------------
        If Me.ListBox1.SelectedIndex = 4 Then
            sl = "zh-Hans"
        End If
        '------------------------------------
        My.Settings.selected_language = sl
        My.Settings.Save()
        '------------------
        Me.DialogResult = DialogResult.OK
        'Application.Exit()
    End Sub

    Private Sub select_language_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sl As String
        sl = My.Settings.selected_language
        '---------------------
        If sl = "EN_DEFAULT" Then
            Me.ListBox1.SelectedIndex = 0
        End If
        '-----------
        If sl = "fr" Then
            Me.ListBox1.SelectedIndex = 1
        End If
        '-----------
        If sl = "de" Then
            Me.ListBox1.SelectedIndex = 2
        End If
        '-----------
        If sl = "ar" Then
            Me.ListBox1.SelectedIndex = 3
        End If
        '-----------
        If sl = "zh-Hans" Then
            Me.ListBox1.SelectedIndex = 4
        End If
        '-----------
    End Sub
End Class