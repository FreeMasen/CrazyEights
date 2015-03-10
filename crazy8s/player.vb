Public Class player
    Public hand As New ArrayList
    Public drawCount As Integer
    Public playerTurn As Boolean

    Public Property turn() As Boolean
        Get
            Return playerTurn
        End Get
        Set(value As Boolean)
            playerTurn = value
        End Set
    End Property


    Public Sub New()
        'set the default values
        drawCount = 0
        playerTurn = False
    End Sub

    Public Sub DrawCard(DrawnCard As Card)
        'Add a card to the player's hand
        Me.hand.Add(DrawnCard)
        drawCount = drawCount + 1
    End Sub

    Public Sub AcceptDeal(dealtCard As Card)
        hand.Add(CType(dealtCard, Card))
    End Sub

    Public Function PlayCard(CardToPlay As Integer) As Card
        PlayCard = CType(hand.Item(CardToPlay), Card)
        Me.hand.RemoveAt(CardToPlay)
    End Function
End Class
