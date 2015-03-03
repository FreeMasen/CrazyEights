Public Class player
    Inherits CollectionBase
    Dim hand As ArrayList

    Default Public Property item(index As Integer) As Card
        Get
            Return CType(Me.list.item(index), Card)
        End Get
        Set(value As Card)
            Me.list.item(index) = value
        End Set
    End Property

    Public Function Play(playedcard As Card) As Card
        Return playedcard
        Me.list.remove(playedcard)
    End Function
End Class
