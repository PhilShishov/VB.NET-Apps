Imports System.ComponentModel

Public Class PokerForm
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim hand(3, 12), suits(3), denoms(12) As Integer

        InputCard(hand, suits, denoms, txtDenomination1.Text, mtbSuit1.Text)
        InputCard(hand, suits, denoms, txtDenomination2.Text, mtbSuit2.Text)
        InputCard(hand, suits, denoms, txtDenomination3.Text, mtbSuit3.Text)
        InputCard(hand, suits, denoms, txtDenomination4.Text, mtbSuit4.Text)
        InputCard(hand, suits, denoms, txtDenomination5.Text, mtbSuit5.Text)

        'determine and display the score
        txtOutput.Text = "The hand is " & GetScore(hand, suits, denoms)
    End Sub

    Private Sub InputCard(ByRef hand(,) As Integer, ByRef suits() As Integer, ByRef denoms() As Integer,
                        denomStr As String, suitStr As String)
        'Store the card into array
        Dim denom As Integer = CInt(denomStr) - 1
        Dim suit As Integer

        Select Case suitStr.ToUpper()
            Case "C" 'clubs
                suit = 0
            Case "D" 'diamonds
                suit = 1
            Case "H"
                suit = 2 'hearts
            Case Else
                suit = 3 'spades
        End Select

        hand(suit, denom) = 1
        suits(suit) += 1 'increment counter for suit
        denoms(denom) += 1 'increment counter for denomination

    End Sub

    Private Function GetScore(hand(,) As Integer, suits() As Integer, denoms() As Integer) As String
        'determine score of the hand
        If IsFlush(suits) And IsStraight(hand) Then
            Return "Straight Flush"
        End If
        If IsFlush(suits) Then
            Return "Flush"
        End If
        If IsFullHouse(denoms) Then
            Return "Full House"
        End If
        If IsFourOfKind(denoms) Then
            Return "Four Of A Kind"
        End If
        If IsStraight(hand) Then
            Return "Straight"
        End If
        If IsThreeOfKind(denoms) Then
            Return "three of a kind"
        End If
        If IsTwoPairs(denoms) Then
            Return "two pairs"
        End If
        If IsOnePair(denoms) Then
            Return "one pair"
        End If
        Return "Nothing"
    End Function

    Function IsFlush(suits() As Integer) As Boolean
        For suit As Integer = 0 To 3
            If suits(suit) = 5 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsFullHouse(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 1) Or (denoms(denom) > 3) Then 'if any denomination is 1, 4, or 5, then NO full house
                Return False
            End If
        Next
        Return True 'all denominations are either 0,2, or 3
    End Function

    Private Function IsFourOfKind(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 4) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function IsThreeOfKind(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 3) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function IsTwoPairs(denoms() As Integer) As Boolean
        Dim count As Integer = 0
        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                count += 1
            End If
        Next

        If count = 2 Then
            Return True
        End If

        Return False
    End Function

    Private Function IsOnePair(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function IsStraight(hand(,) As Integer) As Boolean
        Dim denom As Integer = 13
        'A=0i, 2=1i, 3=2i....10=9i, J=10i, Q=11i, K=12i
        'Find highest Denomination
        Do
            denom = denom - 1
        Loop Until IsAnySuit(hand, denom)

        'If highest denomination is less than a 4 then there is no straight
        If denom < 4 Then
            Return False
        End If

        For i As Integer = 1 To 3 'Test three cards before denom (which is our highest card)
            If Not IsAnySuit(hand, denom - 1) Then
                Return False
            End If
        Next

        'highest card is king, check for ace, also check for 9
        If (denom = 12 And IsAnySuit(hand, 0)) Or (denom = 12 And IsAnySuit(hand, 8)) Then
            Return True
            'highest card is 5, check for ace (counts as 1)
        ElseIf denom = 4 And IsAnySuit(hand, 0) Then
            Return True
            'check if last card is 4 smaller than highest. 
            'For example, if highest is 9, the lowest needs to be 5 in order to have Straight (5,6,7,8,9)
        ElseIf IsAnySuit(hand, denom - 4) Then
            Return True
        End If

        Return False
    End Function

    Private Function IsAnySuit(hand(,) As Integer, denom As Integer) As Boolean
        'Test for a 1 for any suit of the given denomination
        For suit As Integer = 0 To 3
            If hand(suit, denom) = 1 Then
                Return True
            End If
        Next

        Return False
    End Function


End Class
