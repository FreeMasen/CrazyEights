Public Class player
    Public hand As ArrayList
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
        If drawCount = 3 Then
            turn = False
            drawCount = 0
        End If
    End Sub

    Public Sub AcceptDeal(dealtCard As Card)
        Me.hand.Add(dealtCard)
    End Sub

    Public Function PlayCard(CardToPlay As Integer) As Card
        Return CType(hand.Item(CardToPlay), Card)
        Me.hand.Remove(CardToPlay)
    End Function
End Class
