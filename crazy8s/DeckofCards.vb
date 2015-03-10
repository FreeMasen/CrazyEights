Public Class DeckofCards
    Inherits CollectionBase

    'array of suits for the contructor to pull from
    Public suits As Array = {"Hearts", "Diamonds", "Clubs", "Spades"}

    'constructor to create a deck of 52 cards 
    Public Sub New()
        'for each suit in suits
        For Each x In suits
            'for each number from 1 to 13
            For i As Integer = 1 To 13
                'create a card with that number and that suit
                Build(i, CStr(x))
            Next
        Next
    End Sub

    Public Sub Build(cardValue As Integer, suit As String)
        Dim NewCard As Card
        NewCard.cardValue = cardValue
        NewCard.suit = suit
        'adds a new card to the collection
        Me.List.Add(NewCard)
    End Sub

    Public Function deal() As Card
        Static Dim r As Random = New Random

        'define a card to be delt
        Dim deltcard As Card
        'choose that card randomly from the existing deck
        deltcard = CType(Me.List.Item(0), Card)
        'return that card
        Return CType(deltcard, Card)
        'removes a card from the collection
        List.RemoveAt(Convert.ToInt32(r))

    End Function


    'defines how to get and set an item based on an index number
    Default Public Property Item(index As Integer) As Card
        Get
            Return CType(Me.List.Item(index), Card)
        End Get
        Set(value As Card)
            Me.List.Item(index) = value
        End Set
    End Property

End Class
