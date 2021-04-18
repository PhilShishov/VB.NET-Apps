Public Class Wizard2Form
    Private Sub frmWizard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRegion.DataSource = RegionInfo.Names
        lstRegion.SelectedIndex = -1
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MainForm.PreviousStep()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If lstRegion.SelectedIndex = -1 Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
            MainForm.UserSelections.Region = lstRegion.SelectedItem.ToString()
            MainForm.NextStep()
        End If
    End Sub
End Class