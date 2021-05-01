Public Class InvestmentTrackingForm
    Private Sub InvestmentTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTicker.CharacterCasing = CharacterCasing.Upper
        dtpPurchDate.Value = Today

        If Not Investment.LoadPrices("..\..\..\InvestPrices.txt") Then
            MessageBox.Show("Cannot load the text file")
        End If
    End Sub

    Private Sub txtTicker_TextChanged(sender As Object, e As EventArgs) Handles txtTicker.TextChanged

        Dim price As Double = Investment.GetCurrentPrice(txtTicker.Text)
        If price > 0 Then
            lblPricePerShare.Text = price.ToString("n")
        Else
            lblPricePerShare.Text = String.Empty
        End If
    End Sub

    Private Sub KeyPressForShares(sender As Object, e As KeyPressEventArgs) Handles txtShares.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim invest As New Investment
        If cboInvestmentType.SelectedIndex = -1 Or txtShares.Text = "" Or txtTicker.Text = "" Then
            MessageBox.Show("Please enter correct input")
            Exit Sub
        End If

        With invest
            .Type = CType(cboInvestmentType.SelectedIndex, InvestmentType)
            .PurchaseDate = dtpPurchDate.Value.Date
            .TickerSymbol = txtTicker.Text
            .PricePerShare = CDbl(lblPricePerShare.Text)
            .NumberPurchasedShares = CInt(txtShares.Text)
        End With

        lblTotal.Text = invest.PurchaseAmount.ToString("c")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
