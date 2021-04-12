Public Class GameOfLifeForm
    Dim current(,) As Boolean
    Dim generation As Integer = 1

    Private Sub frmGameOfLife_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewGame()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'When the New button is pressed, start a new game
        NewGame()
    End Sub

    Private Sub btnGeneration_Click(sender As Object, e As EventArgs) Handles btnGeneration.Click
        'Advance to the next generation
        Dim size As Integer = current.GetUpperBound(0)
        'Create a new array for the future generation
        Dim future(size, size) As Boolean
        'Populate future using the current
        For row As Integer = 1 To size
            For column As Integer = 1 To size
                future(row, column) = Survives(row, column)
            Next
        Next
        'Update current generation with the future
        current = future
        generation += 1
        'Display the current generation
        Display()
    End Sub

    Private Sub NewGame()
        'Start a new game with the specified size
        Dim input As String

        'Get the size of the new game
        Dim size As Integer = CInt(InputBox("Enter the size of the grid"))
        'Redimension the current generation to the size
        ReDim current(size, size)
        'Set the defailt row to all dashes
        'Get the initial generation
        For row As Integer = 1 To size
            'Get the input from the user
            input = InputBox("Enter the row # " & row & " of " & size & " with 1s or dashes")
            'Parse the input into the array
            For column As Integer = 1 To size
                current(row, column) = (input.Substring(column - 1, 1) = "1")
            Next
        Next
        'Display current generation as number 1
        generation = 1
        Display()
    End Sub

    Private Sub Display()
        'Display current generation in the list box
        Dim output As String
        Dim size As Integer = current.GetUpperBound(0)
        'Build each row of output
        lstGeneration.Items.Clear()
        Dim count As Integer = 0
        For row As Integer = 1 To size
            output = ""
            For column As Integer = 1 To size
                If current(row, column) Then
                    output = output & "1"
                    count += 1
                Else
                    output = output & "-"
                End If
            Next
            lstGeneration.Items.Add(output)
        Next
        'Display the number of individuals
        txtIndividuals.Text = count.ToString()
        btnGeneration.Text = "Generation #" & generation

    End Sub

    Function Survives(row As Integer, column As Integer) As Boolean
        Dim size As Integer = current.GetUpperBound(0)
        Dim count As Integer = 0

        'Determine whether the individual at row, column survives
        'Loop over all neighbors of the individual
        'Loop from the row above to the row below
        For r As Integer = row - 1 To row + 1
            'Loop from the column before to the column after
            For c As Integer = column - 1 To column + 1
                If ((r <> row) Or (c <> column)) And (r >= 1) And (r <= size) And (c >= 1) And (c <= size) Then
                    'If neigbor is alive then count it
                    If current(r, c) Then
                        count += 1
                    End If
                End If
            Next
        Next
        'return results
        If current(row, column) Then
            'If individual exists then neighbors must be 2 or 3 to survive
            Return (count = 2) Or (count = 3)
        Else
            'An individual is born if there are exactly three neighbors
            Return (count = 3)
        End If
    End Function
End Class
