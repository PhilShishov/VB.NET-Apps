Public Class MainForm
    Private inv As New Inventory
    Private invFile As New InventoryFile("..\..\..\Inventory.txt")

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            invFile.LoadData(inv)
            FillCombo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cannot load data file")
        End Try
    End Sub

    Private Sub FillCombo()
        cboIdNumber.Items.Clear()
        For Each item As Item In inv.Items
            cboIdNumber.Items.Add(item.IDNumber)
        Next
    End Sub

    Private Sub cboIdNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdNumber.SelectedIndexChanged
        Dim item As Item = inv.GetItem(cboIdNumber.Text)

        If item Is Nothing Then
            MessageBox.Show("The Item ID was not found")
            ClearFields()
        Else
            txtDescription.Text = item.Description
            txtDaily.Text = item.DailyRate.ToString()
            txtWeekly.Text = item.WeeklyRate.ToString()
            txtMonthly.Text = item.MonthlyRate.ToString()
            txtQuantity.Text = item.Quantity.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtDescription.Clear()
        txtDaily.Clear()
        txtWeekly.Clear()
        txtMonthly.Clear()
        txtQuantity.Clear()
        cboIdNumber.Text = String.Empty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If cboIdNumber.Text IsNot String.Empty Then
                Dim item As New Item
                With item
                    .IDNumber = cboIdNumber.Text
                    .Description = txtDescription.Text
                    .DailyRate = CSng(txtDaily.Text)
                    .WeeklyRate = CSng(txtWeekly.Text)
                    .MonthlyRate = CSng(txtMonthly.Text)
                    .Quantity = CInt(txtQuantity.Text)
                End With
                inv.AddItem(item)
                FillCombo()
                MessageBox.Show("The item was added to the inventory")
            Else
                MessageBox.Show("Please select an ID Number")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If cboIdNumber.Text IsNot String.Empty Then
            Dim dlgResult As DialogResult = MessageBox.Show("Are you sure you want to remove the current item from the inventory?", "Delete Item?",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgResult = DialogResult.Yes Then
                inv.RemoveItem(cboIdNumber.Text)
                ClearFields()
                FillCombo()
            End If
        Else
            MessageBox.Show("Please select an ID Number")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        invFile.SaveData(inv)
        Close()
    End Sub
End Class
