Public Class USSenateForm
  Private Sub frmUSSenate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'get names of 112th senate
    Dim origSenate = From senator In IO.File.ReadAllLines("Senate112.txt")
                     Select senator

    'get retired senators
    Dim retiredSenate = From senator In IO.File.ReadAllLines("RetiredSen.txt")
                        Select senator

    'get new senators
    Dim newSenate = From senator In IO.File.ReadAllLines("NewSen.txt")
                    Select senator

    'remove retired senators
    Dim removeRetired = From senator In origSenate.Except(retiredSenate)
                        Select senator

    'add new senators. This is the final file
    Dim finalSenate = From senator In removeRetired.Concat(newSenate)
                      Select senator

    'write the new file
    IO.File.WriteAllLines("Senate113.txt", finalSenate)

    'determine number of senators for each party affiliation
    Dim query = From senator In finalSenate
                Let party As String = senator.Split(","c)(2)
                Select party

    Dim demCount As Integer = 0
    Dim repCount As Integer = 0
    Dim indCount As Integer = 0

    For i As Integer = 0 To query.Count() - 1
      If query(i) = "D" Then
        demCount += 1
      ElseIf query(i) = "R" Then
        repCount += 1
      Else
        indCount += 1
      End If
    Next

    'determine the number of states whose two senators are from the same party
    'each state will be represented in the file twice
    'so ordering them by state will give us a pair of states for each state
    Dim query2 = From senator In finalSenate
                 Let state As String = senator.Split(","c)(1)
                 Let party As String = senator.Split(","c)(2)
                 Order By state Ascending
                 Select party

    Dim numStatesWithSameParty As Integer = 0

    For i as Integer = 0 to query2.Count() -2 Step 2
      If query2(i) = query2(i + 1) Then
        numStatesWithSameParty += 1
      End If
    Next

        MessageBox.Show("Democrats: " & demCount.ToString & System.Environment.NewLine &
                    "Republicans: " & repCount.ToString & System.Environment.NewLine &
                    "Independent: " & indCount.ToString & System.Environment.NewLine &
                    "Number of states whose senators have the same party affiliation: " & numStatesWithSameParty.ToString)

        'load the list if states in the list box
        Dim query3 = From state In finalSenate
                 Let states as String = state.Split(","c)(1)
                 Order By states Ascending
                 Select states
                 Distinct

    lstState.DataSource = query3.ToList
  End Sub

  Private Sub lstState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstState.SelectedIndexChanged
    Dim selectedState = lstState.Text

        'display senators from the selected state
        Dim query = From data In IO.File.ReadAllLines("Senate113.txt")
                    Let senator As String = data.Split(","c)(0)
                    Let state As String = data.Split(","c)(1)
                    Where state = selectedState
                    Select senator

        lstSenators.DataSource = query.toList
  End Sub
End Class
