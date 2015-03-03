﻿Public Class DeckofCards
    Inherits CollectionBase

    Public Sub build(newCard As Card)
        Me.List.Add(newCard)
    End Sub

    Public Sub deal(deltCard As Card)
        Me.List.Remove(deltCard)
    End Sub


    Default Public Property Item(index As Integer) As Card
        Get
            Return CType(Me.List.Item(index), Card)
        End Get
        Set(value As Card)
            Me.List.Item(index) = value
        End Set
    End Property

End Class
