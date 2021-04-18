Public Class DeckOfCards
    Private _deck(52) As Card
    Private _dealt As Integer 'Last card dealt (1, 2, ...52)
    Public Event Shuffling(n As Integer, nMax As Integer)

    Public Sub New()
        'Make the first thirteen cards hearts, the
        'next thirteen cards diamonds, and so on.
        Dim suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        For i As Integer = 0 To 3
            For j As Integer = 1 To 13
                'Assign numbers from 1 through 13 to the cards of each suit.
                _deck(i * 13 + j) = New Card()
                _deck(i * 13 + j).Suit = suits(i)
                _deck(i * 13 + j).Denomination = j
            Next
        Next
    End Sub

    Public Function Deal() As Card
        If _dealt < 52 Then
            _dealt += 1
        Else
            _dealt = 1
        End If

        Return _deck(_dealt)
    End Function

    Private Sub Swap(i As Integer, j As Integer)
        'swap i-th card with the j-the card in the deck
        Dim tempCard As Card
        tempCard = _deck(i)
        _deck(i) = _deck(j)
        _deck(j) = tempCard
    End Sub

    Public Sub ShuffleDeck()
        'Do 2000 passes through the deck.  On each pass,
        'swap each card with a randomly selected card.
        Dim index As Integer
        Dim randomIndex As New Random()

        For i As Integer = 1 To 2000
            For j As Integer = 1 To 52
                index = randomIndex.Next(1, 53)
                Swap(j, index)
            Next
            'Raise the shuffling event to track the progress of the shuffle.
            RaiseEvent Shuffling(i, 2000)
        Next
    End Sub

End Class
