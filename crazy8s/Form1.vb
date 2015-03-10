Public Class Form1
    Dim GameDeck As New DeckofCards
    Dim PlayerNumber1 As New player
    Dim PlayerNumber2 As New player
    Dim upCard As Card

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
        PlayerNumber1.turn = False
        PlayerNumber2.turn = False
    End Sub
    Private Sub player1()
        PlayerNumber1.turn = True
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
        btnNextPlayer.Text = "Start player 2's Turn"
    End Sub
    Private Sub player2()
        PlayerNumber2.turn = True
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
        btnNextPlayer.Text = "Start player 1's Turn"
    End Sub
    Private Sub updateLsts()
        LstP1.Items.Clear()
        lstP2.Items.Clear()
        For Each Card In GameDeck
            LstP1.Items.Add(Card)
        Next
        For Each Card In PlayerNumber2.hand
            lstP2.Items.Add(Card)
        Next
        txtUpCard.Text = upCard.ToString
    End Sub
    Private Sub Deal()
        For i As Integer = 0 To 6
            PlayerNumber1.AcceptDeal(GameDeck.deal)
            PlayerNumber2.AcceptDeal(GameDeck.deal)
        Next
    End Sub

    Private Sub setUpCard()
        upCard = GameDeck.deal
        updateLsts()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Card In GameDeck
            LstP1.Items.Add(Card)
        Next
        PlayerNumber2.DrawCard(GameDeck.deal)
    End Sub

    Private Sub btnNextPlayer_Click(sender As Object, e As EventArgs) Handles btnNextPlayer.Click

    End Sub

    Private Sub btnP1Play_Click(sender As Object, e As EventArgs) Handles btnP1Play.Click
        betweenTurns()
    End Sub

    Private Sub btnP2Play_Click(sender As Object, e As EventArgs) Handles btnP2Play.Click
        betweenTurns()
    End Sub
End Class
