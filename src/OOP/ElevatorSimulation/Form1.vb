Public Class ElevatorForm

    Private ReadOnly NumFloors As Integer = 8
    Private ReadOnly FloorHeight As Integer = 28
    Private floors(NumFloors) As Integer
    Private waitLabels(NumFloors - 1) As Label
    Private elevator As New Elevator
    Private rand As New Random

    Private Sub ElevatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X As Integer = 150
        Dim Y As Integer = 215
        pnlElevator.Location = New Point(X - 100, Y - 5)
        elevator.Direction = Elevator.DirectionType.Up

        For i = 0 To NumFloors - 1
            waitLabels(i) = New Label With {
                .Location = New Point(X, Y)
                }
            Controls.Add(waitLabels(i))
            Y -= FloorHeight
        Next

        FillFloors(0, 7)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If elevator.Direction = Elevator.DirectionType.Up Then
            If elevator.CurrFloor < NumFloors - 1 Then
                LoadPassengers()
                MoveElevator(1)
            Else
                elevator.Direction = Elevator.DirectionType.Down
                elevator.NumPass = 0
                FillFloors(0, NumFloors - 2)
            End If
        Else
            If elevator.CurrFloor > 0 Then
                LoadPassengers()
                MoveElevator(-1)
            Else
                elevator.Direction = Elevator.DirectionType.Up
                elevator.NumPass = 0
                FillFloors(1, NumFloors - 1)
            End If
        End If
    End Sub

    Private Sub UpdateFloorLabels()
        For i = 0 To NumFloors - 1
            waitLabels(i).Text = floors(i).ToString()
        Next
    End Sub

    Private Sub LoadPassengers()
        elevator.NumPass += floors(elevator.CurrFloor)
        floors(elevator.CurrFloor) = 0
        lblPassengers.Text = elevator.NumPass.ToString()
        UpdateFloorLabels()
    End Sub

    Private Sub FillFloors(first As Integer, last As Integer)
        For i = first To last
            floors(i) = rand.Next(6)
        Next
        UpdateFloorLabels()
    End Sub

    Private Sub MoveElevator(direction As Integer)
        elevator.CurrFloor += direction
        Dim Y As Integer = pnlElevator.Location.Y - (FloorHeight * direction)
        pnlElevator.Location = New Point(pnlElevator.Location.X, Y)
        lblFloorNumber.Text = (elevator.CurrFloor + 1).ToString()
    End Sub
End Class
