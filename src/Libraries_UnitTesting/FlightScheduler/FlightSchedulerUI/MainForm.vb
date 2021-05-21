Imports FlightSchedulerLibrary

Public Class MainForm
    Private Sub frmFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flight.GetData("..\..\..\FlightData.txt")

        For Each ap As Airport In Flight.AirportList
            cboDepartureAirport.Items.Add(ap.Code)
            cboArrivalAirport.Items.Add(ap.Code)
        Next
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cboDepartureAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboDepartureAirport, "You must select a departure airport")
            Return
        Else
            ErrorProvider1.SetError(cboDepartureAirport, "")
        End If

        If cboArrivalAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboArrivalAirport, "You must select a arrival airport")
            Return
        Else
            ErrorProvider1.SetError(cboArrivalAirport, "")
        End If

        Dim depTime As Date = CDate(txtDepartureTime.Text)
        Dim ts As New TimeSpan(depTime.Hour, depTime.Minute, 0)
        Dim departsWhen As Date = dtpDepartureDate.Value.Date.Add(ts)

        Dim aFlight As New Flight(cboDepartureAirport.SelectedIndex, cboArrivalAirport.SelectedIndex, departsWhen)
        Dim arriveWhen As Date = aFlight.GetArrival()

        lblArriveWhen.Text = arriveWhen.ToString("d") & " " & arriveWhen.ToString("a\t hh:mm tt") & Environment.NewLine &
            "Travel Time is " & aFlight.Duration & " hours."

        lblArriveWhen.Visible = True
    End Sub
End Class
