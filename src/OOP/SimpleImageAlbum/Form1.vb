Imports System.IO

Public Class ImageAlbumForm
    Private folderPath As String = String.Empty
    Private pics() As PictureBox

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        If folderPath.Length = 0 Then
            folderBrowser.SelectedPath = Directory.GetCurrentDirectory
        End If

        If folderBrowser.ShowDialog() = DialogResult.Cancel Then Return

        folderPath = folderBrowser.SelectedPath()
        Dim fileNames() As String = Directory.GetFiles(folderPath)

        If fileNames.Length = 0 Then
            MessageBox.Show("Unable to find any image files")
            Return
        End If

        Me.Text = folderPath

        ReDim pics(fileNames.Length - 1)
        FlowPanel.Controls.Clear()

        For i As Integer = 0 To fileNames.Length - 1
            pics(i) = New PictureBox()
            With pics(i)
                .Size = New Size(50, 50)
                .SizeMode = PictureBoxSizeMode.Zoom
                Try
                    .Image = New Bitmap(fileNames(i))
                    .Tag = fileNames(i)
                    FlowPanel.Controls.Add(pics(i))
                    AddHandler pics(i).Click, AddressOf btn_Click
                Catch ex As Exception
                    MessageBox.Show("Unspecified error")
                End Try
            End With
        Next

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs)
        Dim pbox As PictureBox = CType(sender, PictureBox)
        Dim frm As New ImageForm
        frm.Text = pbox.Tag.ToString()
        frm.picBox.Image = New Bitmap(pbox.Tag.ToString())
        frm.ShowDialog()
    End Sub
End Class
