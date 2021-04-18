Public Class BlackJackForm

    Dim player, dealer As Hand 'two hands
    Dim WithEvents deck As DeckOfCards

    Private Sub frmBlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player = New Hand()
        dealer = New Hand()
        deck = New DeckOfCards()

        'deal the first hand
        NewHand()
        txtOutput.Clear()
    End Sub

    Private Sub NewHand()
        'Reset hands and result.
        btnHold.Enabled = True
        btnHit.Enabled = True
        player.Clear()
        dealer.Clear()
        lstPlayer.Items.Clear()
        lstDealer.Items.Clear()
        txtPlayer.Clear()
        txtDealer.Clear()
        txtOutput.Clear()
        'Shuffle the Deck
        deck.ShuffleDeck()
        'Deal 1 card to dealer and 2 cards to player
        DealDealer()
        DealPlayer()
        DealPlayer()
    End Sub

    Private Sub DealPlayer()
        Dim card As Card
        card = deck.Deal()
        player.Deal(card)
        'display card and scores
        lstPlayer.Items.Add(card.IdentifyCard())
        txtPlayer.Text = player.Score.ToString()
    End Sub

    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        'Only hit if player has less than 5 cards, has not yet bust and not held
        If (player.LastStored < 5) And (player.Score < 21) And (dealer.LastStored = 1) Then
            DealPlayer()
        End If

        'If reached 5 cards or busted then player must hold
        If (player.LastStored = 5) Or (player.Score > 21) Then
            Hold()
        End If
    End Sub

    Private Sub Hold()
        'Deal one card to dealer until number reaches 5 or score reaches 17.
        'If player has busted, then just deal one more card.
        Do
            DealDealer()
        Loop Until (player.Score > 21) Or (dealer.Score > 16) Or (dealer.LastStored = 5)

        txtOutput.Text = Result()
    End Sub

    Private Function Result() As String

        btnHold.Enabled = False
        btnHit.Enabled = False
        'Determines the result of the hands, If player or dealer busted
        If player.Score > 21 Then
            Return "You Busted - Dealer Wins"
        End If

        If dealer.Score > 21 Then
            Return "Dealer Busted - You win"
        End If

        'If a hand reaches 5 cards then it is a winner
        If player.LastStored = 5 Then
            If dealer.LastStored = 5 Then
                Return "Both hands reached 5 - Push"
            End If
            Return "Hand reached 5 - You win"
        End If

        If dealer.LastStored = 5 Then
            Return "Dealer hand reached 5 - Dealer Wins"
        End If

        'Compare Scores
        Select Case player.Score
            Case Is > dealer.Score
                Return "You Win"
            Case dealer.Score
                Return "Push"
            Case Else
                Return "Dealer Wins"
        End Select
    End Function

    Private Sub btnNewHand_Click(sender As Object, e As EventArgs) Handles btnNewHand.Click
        'Only deal a new hand if the hand is not finished
        If dealer.LastStored <> 1 Then
            NewHand()
        End If
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        'Only stay if not stayed before and player has not busted yet
        If player.Score <= 21 And dealer.LastStored = 1 Then
            Hold()
        End If
    End Sub

    Private Sub DealDealer()
        Dim card As Card
        card = deck.Deal()
        dealer.Deal(card)
        'display card and scores
        lstDealer.Items.Add(card.IdentifyCard())
        txtDealer.Text = dealer.Score.ToString()
    End Sub

    Private Sub CardsShuffling(n As Integer, nMax As Integer) Handles deck.Shuffling
        'n is the number of the specific pass through the deck (1, 2, 3...).
        'nMax is the total number of passes when the deck is shuffled.
        txtOutput.Text = "Shufflinf Pass: " & n & " out of " & nMax
        For i As Integer = 1 To 1000000 'slows down the shuffle
        Next
        txtOutput.Update()
    End Sub

End Class
