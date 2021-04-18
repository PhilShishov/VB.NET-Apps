Public Class MainForm

    Private ReadOnly wizardForms As Form() = {Nothing, New Wizard1Form, New Wizard2Form,
                                     New Wizard3Form, New Wizard4Form, New SummaryForm}

    Private currentStep As Integer = 0
    Private allCruisesPr As New CruiseCollection
    Private userSelectionsPr As New Cruise

    Public ReadOnly Property AllCruises As CruiseCollection
        Get
            Return allCruisesPr
        End Get
    End Property

    Public Property UserSelections As Cruise
        Get
            Return userSelectionsPr
        End Get
        Set(value As Cruise)
            userSelectionsPr = value
        End Set
    End Property

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        If Not (IsNumeric(txtNumPassengers.Text) AndAlso IsNumeric(txtAge.Text) AndAlso IsNumeric(txtFormal.Text) AndAlso
            IsNumeric(txtRegion.Text)) Then
            Return
        End If

        If Not CheckWeights() Then
            lblWeights.ForeColor = Color.Red
            Return
        End If

        Cruise.SetWeights(CSng(txtNumPassengers.Text), CSng(txtRegion.Text), CSng(txtFormal.Text), CSng(txtAge.Text))
        currentStep += 1
        With wizardForms(currentStep)
            .Show()
        End With
    End Sub

    Private Sub txtNumPassengers_TextChanged(sender As Object, e As EventArgs) Handles txtNumPassengers.TextChanged
        If IsNumeric(txtNumPassengers.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Number of passengers percentage must be numeric")
        End If
    End Sub

    Private Sub txtRegion_TextChanged(sender As Object, e As EventArgs) Handles txtRegion.TextChanged
        If IsNumeric(txtRegion.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Region percentage must be numeric")
        End If
    End Sub

    Private Sub txtFormal_TextChanged(sender As Object, e As EventArgs) Handles txtFormal.TextChanged
        If IsNumeric(txtFormal.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Formal attire percentage must be numeric")
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        If IsNumeric(txtAge.Text) Then

            If CInt(txtAge.Text) > 100 Or CInt(txtAge.Text) < 0 Then
                errProvider.SetError(sender, "Age percentage must be bigger than 0 and less or equal to 100")
            End If
        Else
            errProvider.SetError(sender, "Age percentage must be numeric")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Public Sub NextStep()
        Dim top As Integer = wizardForms(currentStep).Top
        Dim left As Integer = wizardForms(currentStep).Left

        wizardForms(currentStep).Hide()
        currentStep += 1

        ' Display the next step window in exactly the same position as the current step.
        With wizardForms(currentStep)
            .Top = top
            .Left = left
            .Show()
        End With
    End Sub

    Public Sub PreviousStep()
        Dim top As Integer = wizardForms(currentStep).Top
        Dim left As Integer = wizardForms(currentStep).Left

        wizardForms(currentStep).Hide()

        If currentStep > 0 Then
            currentStep -= 1
        End If

        If currentStep > 0 Then
            With wizardForms(currentStep)
                .Top = top
                .Left = left
                .Show()
            End With
        End If

    End Sub

    Private Function CheckWeights() As Boolean
        If (CSng(txtNumPassengers.Text) + CSng(txtRegion.Text) + CSng(txtFormal.Text) + CSng(txtAge.Text) = 100) Then
            Return True
        End If

        Return False
    End Function
End Class
