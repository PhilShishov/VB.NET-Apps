Public Class BackupForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim path As String = Me.FolderBrowserDialog1.SelectedPath

        If path = "" Then
            Exit Sub
        End If

        Dim file_name As String =
            System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm") +
            ".p19"

        Me.TextBox1.Text = path + "\" + file_name
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Me.TextBox1.Text = "" Then
            MessageBox.Show("Please select backup folder")
            Exit Sub
        End If

        Me.ProgressBarSub.Value = 0
        Me.ProgressBarOverall.Value = 0
        Me.LabelSub.Text = "0"
        Me.LabelOverall.Text = "0"
        Me.PanelProgress.Visible = True
        Me.PanelProgress.Refresh()

        Try
            Using zip As New Ionic.Zip.ZipFile()

                zip.Password = "888"
                zip.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                zip.AlternateEncoding = System.Text.Encoding.UTF8

                Dim path As String = Application.StartupPath

                zip.AddDirectory(path + "\Data")
                Dim sub_index As Integer = 1

                For index = 1 To 7
                    If index = 7 Then
                        Me.Label2.Text = "Saving Backup..."
                        Me.Label2.Refresh()
                        zip.Save(Me.TextBox1.Text)
                        sub_index = 2
                    End If

                    Progress_Validator(index, 7, sub_index, 2)

                    If sub_index = 2 Then
                        sub_index = 1
                    Else
                        sub_index += 1
                    End If
                Next

                Dim fi As New System.IO.FileInfo(Me.TextBox1.Text)
                Dim fs As Long = fi.Length

                Me.PanelProgress.Visible = False

                If fs = 0 Then
                    MessageBox.Show("Backup has failed!")
                Else
                    Dim fsKb As Long = fs \ 1024
                    MessageBox.Show("Backup is done! File size: " + fsKb.ToString() + "KB")
                End If

            End Using
        Catch ex As Exception
            Me.PanelProgress.Visible = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Text = PersentageCalc(41, 70).ToString()

    End Sub

    Private Sub Progress_Validator(curr_item As Integer, total As Integer,
                                   sub_curr_item As Integer, sub_total As Integer)
        Me.ProgressBarOverall.Value = PersentageCalc(curr_item, total)
        Me.ProgressBarOverall.Refresh()

        Me.LabelOverall.Text = Me.ProgressBarOverall.Value.ToString() + " %"
        Me.LabelOverall.Refresh()

        Me.ProgressBarSub.Value = PersentageCalc(sub_curr_item, sub_total)
        Me.ProgressBarSub.Refresh()

        Me.LabelSub.Text = Me.ProgressBarSub.Value.ToString() + " %"
        Me.LabelSub.Refresh()

        System.Threading.Thread.Sleep(200)
    End Sub

    Function PersentageCalc(curr_item As Int32, items As Int32) As Int32
        Dim persentage As Double = (curr_item / items) * 100

        Dim result As Int32 = CType(persentage, Int32)
        Return result
    End Function
End Class