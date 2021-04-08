Public Class RestoreForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        '--------------------
        If fn = "OpenFileDialog1" Then
            Me.textBox1.Text = ""
            Exit Sub
        End If
        '--------------------
        Me.textBox1.Text = fn
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        '------------------------
        If Me.textBox1.Text = "" Then
            MessageBox.Show("Please select a file!")
            Exit Sub
        End If
        '------------------------
        Dim exists As Boolean = System.IO.File.Exists(Me.textBox1.Text)
        If exists = False Then
            MessageBox.Show("Backup file not found!")
            Exit Sub
        End If
        '------------------------
        Me.panel2.Visible = True
        Me.panel2.Refresh()
        System.Threading.Thread.Sleep(600)
        '------------------------
        Try
            Dim fn As String = Me.textBox1.Text
            Using z As New Ionic.Zip.ZipFile(fn)
                z.Password = "888"
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8
                '--------------
                Dim df As String
                df = Application.StartupPath
                z.ExtractAll(df, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
                '---------------------------------
                Me.panel2.Visible = False
                '----------------------------------
                MessageBox.Show("Restoration is done! Please check the data!")
            End Using
        Catch ex As Exception
            '---------------------------------
            Me.panel2.Visible = False
            '----------------------------------
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class