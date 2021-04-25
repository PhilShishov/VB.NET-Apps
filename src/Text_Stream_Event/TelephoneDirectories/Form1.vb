Public Class PhoneDirectoriesForm

    Dim directories() As String = IO.File.ReadAllLines("Directories.txt")

    Private Sub frmPhoneDirectories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each directory In directories
            lstPhoneDirectories.Items.Add(directory)
        Next
    End Sub

    Private Sub btnNewDirectory_Click(sender As Object, e As EventArgs) Handles btnNewDirectory.Click

        'create new directory file
        Dim filename = InputBox("Please enter the name of the new directory")

        'add new directory to the Directories.txt and to the list box
        If Not directories.Contains(filename) Then
            IO.File.Create(filename)
            IO.File.AppendAllText("Directories.txt", filename + System.Environment.NewLine)
            directories = IO.File.ReadAllLines("Directories.txt")
            lstPhoneDirectories.Items.Clear()
            For Each directory In directories
                lstPhoneDirectories.Items.Add(directory)
            Next
        Else
            MessageBox.Show("Directory " + filename + " already exists!", "Duplicate Directory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lstPhoneDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPhoneDirectories.SelectedIndexChanged
        txtCurrentDirectory.Text = lstPhoneDirectories.SelectedItem.ToString()
        DisplayData(txtCurrentDirectory.Text)
    End Sub

    Private Sub DisplayData(selectedDirectory As String)

        Dim query = From dir In IO.File.ReadAllLines(selectedDirectory)
                    Let name As String = dir.Split(","c)(0)
                    Let phone As String = dir.Split(","c)(1)
                    Order By name
                    Select name, phone

        dgvOutput.DataSource = query.ToList
        dgvOutput.Columns(0).HeaderText = "Name"
        dgvOutput.Columns(1).HeaderText = "Phone Number"

    End Sub

    Private Sub btnAddListing_Click(sender As Object, e As EventArgs) Handles btnAddListing.Click
        Dim name As String = txtName.Text
        Dim phone As String = txtPhoneNumber.Text
        Dim selectedDirectory As String = txtCurrentDirectory.Text

        If name.Trim().Length > 0 And phone.Trim().Length > 0 And selectedDirectory.Trim().Length > 0 Then
            Dim sr As IO.StreamWriter = IO.File.AppendText(selectedDirectory)
            sr.WriteLine(name + "," + phone)
            sr.Close()
            DisplayData(selectedDirectory)
        Else
            MessageBox.Show("Select directory and enter name and phone to add", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim nameToDelete As String = txtName.Text
        Dim selectedDirectory As String = txtCurrentDirectory.Text
        Dim sr As IO.StreamWriter

        If nameToDelete.Trim().Length > 0 And selectedDirectory.Trim().Length > 0 Then
            Dim query = From data In IO.File.ReadAllLines(selectedDirectory)
                        Let name As String = data.Split(","c)(0)
                        Let phone As String = data.Split(","c)(1)
                        Where name <> nameToDelete
                        Let output As String = name + "," + phone
                        Select output

            sr = IO.File.CreateText(selectedDirectory)
            For i As Integer = 0 To query.Count() - 1
                sr.WriteLine(query(i))
            Next

            sr.Close()
            DisplayData(selectedDirectory)
        Else
            MessageBox.Show("Select record to delete", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvOutput_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutput.CellContentClick
        Dim row = dgvOutput.CurrentRow.Index
        txtName.Text = dgvOutput.Item(0, row).Value.ToString()
        txtPhoneNumber.Text = dgvOutput.Item(1, row).Value.ToString()
    End Sub
End Class
