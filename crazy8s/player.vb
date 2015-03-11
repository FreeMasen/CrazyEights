Public Class player
    Public hand As New ArrayList
    Public drawCount As Integer
    Public playerTurn As Boolean

    
    Public Property turn() As Boolean
        'defines how to set and get the player turn property
        'this dictates who's turn it is
        Get
            Return playerTurn
        End Get
        Set(value As Boolean)
            playerTurn = value
        End Set
    End Property


    Public Sub New()
        'constuctor for a new player
        'set the default values
        drawCount = 0
        playerTurn = False
    End Sub


    Public Sub DrawCard(DrawnCard As Card)
        'Add a card to the player's hand
        Me.hand.Add(DrawnCard)
        'increase the drawcount by 1
        drawCount = drawCount + 1
    End Sub

    Public Sub AcceptDeal(dealtCard As Card)
        'this method accepts a deal card differently than a draw card
        'so that a player can be delt 7 cards at the begining
        hand.Add(CType(dealtCard, Card))
    End Sub

    Public Function PlayCard(CardToPlay As Integer) As Card
        'when a player plays a card, set the method to 
        'the card at the selected integer
        PlayCard = CType(hand.Item(CardToPlay), Card)
        'remove this card from the arraylist
        Me.hand.RemoveAt(CardToPlay)
    End Function
End Class
