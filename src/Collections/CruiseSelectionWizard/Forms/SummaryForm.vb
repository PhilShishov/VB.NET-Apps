Public Class SummaryForm
    Private treshold As Single = 75

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MainForm.PreviousStep()
    End Sub

    Private Sub FillListBox()
        lvwCruises.Items.Clear()

        Dim desiredCruise As Cruise = MainForm.UserSelections

        For Each currCruise As Cruise In MainForm.AllCruises.Items
            Dim match As Single = currCruise.CountMatches(desiredCruise)

            If match >= treshold Then
                Dim item As ListViewItem = lvwCruises.Items.Add(match & "% - " & currCruise.Name)

                With item.SubItems
                    .Add(currCruise.Region)
                    .Add(currCruise.NumOfPassengers)
                    .Add(currCruise.Formal)
                    .Add(currCruise.AverageAge)
                End With
            End If
        Next
    End Sub

    Private Sub summary_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FillListBox()
    End Sub

    Private Sub rad100_CheckedChanged(sender As Object, e As EventArgs) Handles rad100.CheckedChanged,
            rad75.CheckedChanged, rad50.CheckedChanged, rad25.CheckedChanged, radZero.CheckedChanged

        Try
            treshold = CInt(CType(sender, RadioButton).Text)
            FillListBox()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class