Public Class AirlineReservationForm

  Const ROWS As Integer = 10
  Const COLS As Integer = 4
  Dim EMPTY_SEAT As String = Chr(149)
  Dim FULL_SEAT As String = "X"
  Dim passengerArray(ROWS - 1, COLS - 1) As String 'WILL HOLD NAMES OF PASANGERS
  Dim waitingList As New ArrayList 'WILL HOLD PASSANGERS ON WAITING LIST

  Private Sub frmAirlineReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    updateSeatingChart()
  End Sub

  Private Sub updateSeatingChart()
    Dim output As String = "   "

    lstOutput.Items.Clear()
    For r As Integer = 0 To ROWS - 1
      For c As Integer = 0 To COLS - 1
        If c = 2 Then
          output += "     "
        End If

        If isEmpty(passengerArray(r, c)) Then
          output += EMPTY_SEAT & "  "
        Else
          output += FULL_SEAT & "  "
        End If
      Next

      lstOutput.Items.Add(output)
      output = "   "
    Next
  End Sub

  '--------------------------------------------------------------------------------------
  'CHECK IF ANY SEAT IS STILL EMPTY
  'IT'S USED TO DECIDE WHETHER THE NAME CAN BE ADDED TO THE FLIGHT OR WAITING LIST
  '--------------------------------------------------------------------------------------
  Private Function availableSeats() As Boolean
    For r As Integer = 0 To ROWS - 1
      For c As Integer = 0 To COLS - 1
        If isEmpty(passengerArray(r, c)) Then
          Return True
        End If
      Next
    Next

    Return False
  End Function
  '-----------------------------------------------------
  'UPDATES THE LIST BOX WITH NAMES ON WAITING LIST
  'USING ARRAYLIST waitingList
  '-----------------------------------------------------
  Private Sub updateWaitingList()
    lstWaitingList.Items.Clear()

    For i As Integer = 0 To waitingList.Count - 1
      lstWaitingList.Items.Add(waitingList(i))
    Next
  End Sub

  '---------------------------------------
  'ERROR MESSAGES BASED ON INVALID INPUT
  '---------------------------------------
  Private Function badInput() As Boolean
    Dim badUserInput As Boolean = True

    If isEmpty(txtName.Text) Then
      MessageBox.Show("Please enter a valid name", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtName.Focus()
    ElseIf isEmpty(mtbSeatRow.Text) Or CInt(mtbSeatRow.Text) > ROWS Or CInt(mtbSeatRow.Text) < 1 Then
      MessageBox.Show("Please enter a valid seat row", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
      mtbSeatRow.Focus()
    ElseIf isEmpty(mtbSeatCol.Text) Or mtbSeatCol.Text.ToUpper > "D" Then
      MessageBox.Show("Please enter a valid seat column", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
      mtbSeatCol.Focus()
    Else
      badUserInput = False
    End If

    Return badUserInput
  End Function

  '-------------------------------------------------------------
  'ASSIGN COLUMN NUMBER BASED ON THE COLLUMN LETTER (A-D)
  '-------------------------------------------------------------
  Private Function getSeatCol() As Integer
    Dim column As String = mtbSeatCol.Text
    Dim seatCol As Integer

    If column.ToUpper() = "A" Then
      seatCol = 0
    ElseIf column.ToUpper() = "B" Then
      seatCol = 1
    ElseIf column.ToUpper = "C" Then
      seatCol = 2
    Else
      seatCol = 3
    End If

    Return seatCol
  End Function

  '-------------------------------------------------------------
  'CHECK IF INPUT VALUE STRING IS EMPTY. USED TO VALIDATE INPUT
  '-------------------------------------------------------------
  Private Function isEmpty(value As String) As Boolean
    If String.IsNullOrEmpty(value) Then
      Return True
    End If

    Return False
  End Function

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
    End
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Dim name As String
    Dim seatRow As Integer
    Dim seatCol As Integer

    If Not badInput() Then
      name = txtName.Text
      seatRow = CInt(mtbSeatRow.Text)
      seatCol = getSeatCol() 'GET THE COLUMN NUMBER

      '-----------------------------------------------------------------------------------------
      'CHECK IF THERE ARE EMPTY SEATS AVAILABLE. IF NOT, ADD NAME TO THE WAITING LIST
      'IF THERE ARE STILL SOME EMPTY SEATS, PROCEED AND CHECK IF THE REQUESTED SEAT IS TAKEN
      'IF NOT, ASSIGN PASSANGER NAME TO IT. OTHERWISE, DISPLAY A MESSAGE
      '-----------------------------------------------------------------------------------------

      If Not availableSeats() Then
        waitingList.Add(name)
        MessageBox.Show("No more empty seats. Adding the customer to waiting list", "Full capacity", MessageBoxButtons.OK, MessageBoxIcon.Information)
        updateWaitingList()
      ElseIf isEmpty(passengerArray(seatRow - 1, seatCol)) Then
        passengerArray(seatRow - 1, seatCol) = name
        updateSeatingChart()
      Else
        MessageBox.Show("Seat is already taken", "Full capacity", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    Dim name As String = txtName.Text
    Dim nameFound As Boolean = False

    '--------------------------------------------------------------------------------
    'LOOP THROUGH THE PASSENGER ARRAY TO FIND THE NAME TO BE REMOVED FROM THE LIST
    '--------------------------------------------------------------------------------
    For r As Integer = 0 To ROWS - 1
      For c As Integer = 0 To COLS - 1
        '--------------------------------------------------------------------
        'IF NAME IS FOUND, CHECK IF THERE ARE ANY NAMES ON WAITING LIST
        'IF SO, REPLACE THE NAME WITH THE NAME ON THE WAITING LIST
        'OTHERWISE JUST REMOVE THE NAME FROM THE FLIGHT
        '--------------------------------------------------------------------
        If passengerArray(r,c) = name Then
          If waitingList.Count > 0 Then
            passengerArray(r,c) = waitingList(0).ToString()
            waitingList.RemoveAt(0)
            updateWaitingList()
            nameFound = True
            MessageBox.Show(name & " has been removed, and " & passengerArray(r, c) & 
                            " has been added to the flight", "Record found", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else 
            passengerArray(r,c) = ""
            nameFound = True
            MessageBox.Show(name & " has been removed", "Record found", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If

          updateSeatingChart()
          Exit Sub
        End If
      Next
    Next

    MessageBox.Show(name & " has was not found", "Record NOT found", MessageBoxButtons.OK, MessageBoxIcon.Error)

  End Sub
End Class
