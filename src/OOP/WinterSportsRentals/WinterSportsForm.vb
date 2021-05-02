Public Class WinterSportsForm
    Private ReadOnly TaxRate As Double = 0.07
    Private rentalPrices As New Price

    Private Sub frmWinterSports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToShortDateString
    End Sub

    Private Sub lnkForecast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForecast.LinkClicked
        WeatherForecastForm.WebBrowser1.Navigate("http://www.google.com/search?q=scranton+PA+weather")
        WeatherForecastForm.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If lstEquipment.SelectedIndices.Count = 0 Then
            errProvider.SetError(lstEquipment, "Please select an equipment to rent")
            Return
        Else
            errProvider.SetError(lstEquipment, "")
        End If

        Dim duration As DurationType = CType(cboDuration.SelectedIndex, DurationType)
        If duration = -1 Then
            errProvider.SetError(cboDuration, "Please select valid duration")
            Return
        Else
            errProvider.SetError(cboDuration, "")
        End If

        Dim deposit As Double
        If Not Double.TryParse(txtDeposit.Text, deposit) Then
            errProvider.SetError(txtDeposit, "Deposit must be a positive number")
            Return
        Else
            errProvider.SetError(txtDeposit, "")
        End If

        Dim subtotal As Double = 0
        For Each index As Integer In lstEquipment.SelectedIndices
            Dim equipType As EquipmentType = CType(index, EquipmentType)
            subtotal += rentalPrices.GetRentalPrice(equipType, duration)
        Next

        Dim insurance As Double = 0
        If chkInsurance.Checked Then
            insurance = Price.InsuranceCost(subtotal)
        End If

        subtotal += insurance

        Dim tax As Double = subtotal * TaxRate

        Dim balance As Double = subtotal + tax - deposit

        lblSubtotal.Text = subtotal.ToString("n")
        lblTax.Text = tax.ToString("n")
        lblBalance.Text = balance.ToString("c")

    End Sub
End Class
