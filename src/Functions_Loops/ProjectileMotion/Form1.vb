Public Class ProjectileMotionForm
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnMaxHeight_Click(sender As Object, e As EventArgs) Handles btnMaxHeight.Click
        lstOutput.Items.Clear()
        Dim v, h As Double
        ValidateInput(h, v)
        Dim maxHeight As Double = HeightOfTheBall(h, v, v / 32)
        lstOutput.Items.Add("The maximum height is ")
        lstOutput.Items.Add(maxHeight & " feet")
    End Sub

    Private Sub btnApproxTime_Click(sender As Object, e As EventArgs) Handles btnApproxTime.Click
        lstOutput.Items.Clear()
        Dim h, v As Double
        ValidateInput(h, v)
        Dim t As Double = TimeToHit(h, v)

        lstOutput.Items.Add("The ball will hit the ground")
        lstOutput.Items.Add("after approximately")
        lstOutput.Items.Add(t & " seconds.")
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        lstOutput.Items.Clear()
        Dim h, v As Double
        ValidateInput(h, v)
        ShowTable(h, v)
    End Sub

    Private Sub ValidateInput(ByRef h As Double, ByRef v As Double)
        If IsNumeric(txtInitialHeight.Text) And IsNumeric(txtInitialVelocity.Text) Then
            h = CDbl(txtInitialHeight.Text)
            v = CDbl(txtInitialVelocity.Text)
        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ShowTable(h As Double, v As Double)
        Dim t As Double
        lstOutput.Items.Add("     Time          Height")
        t = 0
        Dim height = HeightOfTheBall(h, v, t)

        Do
            lstOutput.Items.Add("     " & t.ToString("N") & "          " & height.ToString("N1"))
            t += 0.25
            height = HeightOfTheBall(h, v, t)
        Loop Until (t > 5) Or (height < 0)
    End Sub

    Private Function HeightOfTheBall(h As Double, v As Double, t As Double) As Double
        Return h + v * t - 16 * t * t
    End Function

    Private Function TimeToHit(h As Double, v As Double) As Double
        Dim t As Double = 0
        Do While HeightOfTheBall(h, v, t) > 0
            t += 0.1
        Loop

        Return t
    End Function

End Class
