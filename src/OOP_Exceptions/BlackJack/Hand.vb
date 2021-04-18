Public Class Hand
    Private _cards(5) As Card 'maxof 5 cards in a hand
    Private _lastStored As Integer 'Location of the last stored card

    Public ReadOnly Property LastStored() As Integer
        Get
            Return _lastStored
        End Get
    End Property

    Public ReadOnly Property Card(i As Integer) As Card
        Get
            Return _cards(i)
        End Get
    End Property

    Public ReadOnly Property Score() As Integer
        Get
            Dim total As Integer
            Dim ace As Boolean = False

            'add up all the card scores
            For i As Integer = 1 To LastStored
                total += _cards(i).Score
                If _cards(i).Denomination = 1 Then
                    ace = True
                End If
            Next

            'If ace in hand, and total score less than 12, then ace counts as 11
            If total <= 11 And ace Then
                total += 10
            End If

            Return total
        End Get
    End Property

    Public Sub Deal(card As Card)
        'Add card to hand
        If LastStored < 5 Then
            'increment counter and store card in array
            _lastStored += 1
            _cards(LastStored) = card
        End If
    End Sub

    Public Sub Clear()
        'remove all cards from hand
        _lastStored = 0
    End Sub

End Class
