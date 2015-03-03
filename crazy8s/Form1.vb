Public Class Form1
    Dim player As Integer
    Dim objDeckOfCards As New DeckofCards
    Dim PlayerNumber1 As New player
    Dim playerNumber2 As New player
    Dim upCard As Card

    Public Function getRandom(ByVal min As Integer, ByRef max As Integer) As Integer
        Dim generator As System.Random = New System.Random()
        Return generator.Next(0, objDeckOfCards.Count)
    End Function

    Private Sub betweenTurns()
        lblP1Hand.Visible = False
        LstP1.Visible = False
        btnP1Draw.Visible = False
        BtnP1Pass.Visible = False
        btnP1Play.Visible = False
        btnNextPlayer.Visible = True
        btnChooseSuit.Visible = False
        lstSuits.Visible = False
        lstP2.Visible = False
        btnP2Draw.Visible = False
        btnP2Pass.Visible = False
        btnP2Play.Visible = False
    End Sub
    Private Sub player1()
        player = 2
        lblP1Hand.Visible = True
        LstP1.Visible = True
        btnP1Draw.Visible = True
        BtnP1Pass.Visible = True
        btnP1Play.Visible = True
        btnNextPlayer.Visible = False
        btnChooseSuit.Visible = False
        lstSuits.Visible = False
        lstP2.Visible = False
        lblP2Hand.Visible = False
        btnP2Draw.Visible = False
        btnP2Pass.Visible = False
        btnP2Play.Visible = False
        btnNextPlayer.Text = "Start player" & player & "'s Turn"
    End Sub
    Private Sub player2()
        player = 1
        lblP1Hand.Visible = False
        LstP1.Visible = False
        btnP1Draw.Visible = False
        BtnP1Pass.Visible = False
        btnP1Play.Visible = False
        btnNextPlayer.Visible = False
        btnChooseSuit.Visible = False
        lstSuits.Visible = False
        lstP2.Visible = True
        lblP2Hand.Visible = False
        btnP2Draw.Visible = True
        btnP2Pass.Visible = True
        btnP2Play.Visible = True
        btnNextPlayer.Text = "Start player " & player & "'s Turn"
    End Sub

    Private Sub buildDeck(cardvalue As Integer, suit As String)
        Dim addedCard As Card

        addedCard.cardValue = cardvalue
        addedCard.suit = suit

        objDeckOfCards.build(addedCard)
    End Sub
    Private Function shuffle() As DeckofCards
        Dim suits As Array = {"Clubs", "Spades", "Diamonds", "Hearts"}

        For Each suit In suits
            For i As Integer = 0 To 12
                i += 1
                buildDeck(i, suit.ToString)
            Next
        Next

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        betweenTurns()
        player = 1


    End Sub

    Private Sub btnNextPlayer_Click(sender As Object, e As EventArgs) Handles btnNextPlayer.Click
        If player = 1 Then
            player1()
        ElseIf player = 2 Then
            player2()
        End If
    End Sub

    Private Sub btnP1Play_Click(sender As Object, e As EventArgs) Handles btnP1Play.Click
        betweenTurns()
    End Sub

    Private Sub btnP2Play_Click(sender As Object, e As EventArgs) Handles btnP2Play.Click
        betweenTurns()
    End Sub
End Class
