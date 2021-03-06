﻿Public Class DeckofCards
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
        'define a varible as a card, this will accept both a value and a suit
        Dim NewCard As Card
        'set the value and suit that are passed into this method, to the approprate properties
        NewCard.cardValue = cardValue
        NewCard.suit = suit
        'adds a new card to the collection
        Me.List.Add(NewCard)
    End Sub

    Public Function deal() As Card
        'create a random seed value as a static item
        Static Dim r As Random = New Random
        'create an integer
        Dim cardIndex As Integer
        'set the integer value to a new instance of the random object
        cardIndex = r.Next(0, Me.List.Count - 1)
        'set the function to a card pulled from the random index in the deck
        deal = CType(Me.List.Item(cardIndex), Card)
        'removes a card from the collection
        List.RemoveAt(cardIndex)

    End Function

    Public Sub remove(oldcard As Card)
        'when the method is called, find it in list and remove it
        Me.List.Remove(oldcard)
    End Sub


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
