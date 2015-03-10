<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrazyEights
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstP1 = New System.Windows.Forms.ListBox()
        Me.lblP1Hand = New System.Windows.Forms.Label()
        Me.lblP2Hand = New System.Windows.Forms.Label()
        Me.lstP2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUpCard = New System.Windows.Forms.TextBox()
        Me.lstSuits = New System.Windows.Forms.ListBox()
        Me.btnP1Draw = New System.Windows.Forms.Button()
        Me.btnP1Play = New System.Windows.Forms.Button()
        Me.btnP2Play = New System.Windows.Forms.Button()
        Me.btnP2Draw = New System.Windows.Forms.Button()
        Me.btnChooseSuit = New System.Windows.Forms.Button()
        Me.btnNextPlayer = New System.Windows.Forms.Button()
        Me.BtnP1Pass = New System.Windows.Forms.Button()
        Me.btnP2Pass = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstP1
        '
        Me.LstP1.FormattingEnabled = True
        Me.LstP1.ItemHeight = 20
        Me.LstP1.Location = New System.Drawing.Point(12, 32)
        Me.LstP1.Name = "LstP1"
        Me.LstP1.Size = New System.Drawing.Size(373, 424)
        Me.LstP1.TabIndex = 0
        '
        'lblP1Hand
        '
        Me.lblP1Hand.AutoSize = True
        Me.lblP1Hand.Location = New System.Drawing.Point(12, 9)
        Me.lblP1Hand.Name = "lblP1Hand"
        Me.lblP1Hand.Size = New System.Drawing.Size(105, 20)
        Me.lblP1Hand.TabIndex = 1
        Me.lblP1Hand.Text = "Player 1 hand"
        '
        'lblP2Hand
        '
        Me.lblP2Hand.AutoSize = True
        Me.lblP2Hand.Location = New System.Drawing.Point(665, 9)
        Me.lblP2Hand.Name = "lblP2Hand"
        Me.lblP2Hand.Size = New System.Drawing.Size(105, 20)
        Me.lblP2Hand.TabIndex = 3
        Me.lblP2Hand.Text = "Player 2 hand"
        '
        'lstP2
        '
        Me.lstP2.FormattingEnabled = True
        Me.lstP2.ItemHeight = 20
        Me.lstP2.Location = New System.Drawing.Point(665, 32)
        Me.lstP2.Name = "lstP2"
        Me.lstP2.Size = New System.Drawing.Size(373, 424)
        Me.lstP2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Face up card"
        '
        'txtUpCard
        '
        Me.txtUpCard.Location = New System.Drawing.Point(391, 32)
        Me.txtUpCard.Name = "txtUpCard"
        Me.txtUpCard.Size = New System.Drawing.Size(268, 26)
        Me.txtUpCard.TabIndex = 5
        '
        'lstSuits
        '
        Me.lstSuits.FormattingEnabled = True
        Me.lstSuits.ItemHeight = 20
        Me.lstSuits.Items.AddRange(New Object() {"Hearts", "Diamonds", "Clubs", "Spades"})
        Me.lstSuits.Location = New System.Drawing.Point(391, 64)
        Me.lstSuits.Name = "lstSuits"
        Me.lstSuits.Size = New System.Drawing.Size(268, 184)
        Me.lstSuits.TabIndex = 6
        '
        'btnP1Draw
        '
        Me.btnP1Draw.Location = New System.Drawing.Point(228, 462)
        Me.btnP1Draw.Name = "btnP1Draw"
        Me.btnP1Draw.Size = New System.Drawing.Size(157, 35)
        Me.btnP1Draw.TabIndex = 8
        Me.btnP1Draw.Text = "Draw"
        Me.btnP1Draw.UseVisualStyleBackColor = True
        '
        'btnP1Play
        '
        Me.btnP1Play.Location = New System.Drawing.Point(12, 462)
        Me.btnP1Play.Name = "btnP1Play"
        Me.btnP1Play.Size = New System.Drawing.Size(157, 35)
        Me.btnP1Play.TabIndex = 9
        Me.btnP1Play.Text = "Play"
        Me.btnP1Play.UseVisualStyleBackColor = True
        '
        'btnP2Play
        '
        Me.btnP2Play.Location = New System.Drawing.Point(665, 462)
        Me.btnP2Play.Name = "btnP2Play"
        Me.btnP2Play.Size = New System.Drawing.Size(157, 35)
        Me.btnP2Play.TabIndex = 10
        Me.btnP2Play.Text = "Play"
        Me.btnP2Play.UseVisualStyleBackColor = True
        '
        'btnP2Draw
        '
        Me.btnP2Draw.Location = New System.Drawing.Point(881, 462)
        Me.btnP2Draw.Name = "btnP2Draw"
        Me.btnP2Draw.Size = New System.Drawing.Size(157, 35)
        Me.btnP2Draw.TabIndex = 11
        Me.btnP2Draw.Text = "Draw"
        Me.btnP2Draw.UseVisualStyleBackColor = True
        '
        'btnChooseSuit
        '
        Me.btnChooseSuit.Location = New System.Drawing.Point(391, 254)
        Me.btnChooseSuit.Name = "btnChooseSuit"
        Me.btnChooseSuit.Size = New System.Drawing.Size(268, 35)
        Me.btnChooseSuit.TabIndex = 12
        Me.btnChooseSuit.Text = "Choose Suit"
        Me.btnChooseSuit.UseVisualStyleBackColor = True
        '
        'btnNextPlayer
        '
        Me.btnNextPlayer.Location = New System.Drawing.Point(391, 421)
        Me.btnNextPlayer.Name = "btnNextPlayer"
        Me.btnNextPlayer.Size = New System.Drawing.Size(268, 35)
        Me.btnNextPlayer.TabIndex = 13
        Me.btnNextPlayer.Text = "Next Player"
        Me.btnNextPlayer.UseVisualStyleBackColor = True
        '
        'BtnP1Pass
        '
        Me.BtnP1Pass.Location = New System.Drawing.Point(124, 503)
        Me.BtnP1Pass.Name = "BtnP1Pass"
        Me.BtnP1Pass.Size = New System.Drawing.Size(157, 35)
        Me.BtnP1Pass.TabIndex = 14
        Me.BtnP1Pass.Text = "Pass"
        Me.BtnP1Pass.UseVisualStyleBackColor = True
        '
        'btnP2Pass
        '
        Me.btnP2Pass.Location = New System.Drawing.Point(781, 503)
        Me.btnP2Pass.Name = "btnP2Pass"
        Me.btnP2Pass.Size = New System.Drawing.Size(157, 35)
        Me.btnP2Pass.TabIndex = 15
        Me.btnP2Pass.Text = "Pass"
        Me.btnP2Pass.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(391, 292)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(57, 20)
        Me.lblError.TabIndex = 16
        Me.lblError.Text = "Label1"
        Me.lblError.Visible = False
        '
        'CrazyEights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 556)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnP2Pass)
        Me.Controls.Add(Me.BtnP1Pass)
        Me.Controls.Add(Me.btnNextPlayer)
        Me.Controls.Add(Me.btnChooseSuit)
        Me.Controls.Add(Me.btnP2Draw)
        Me.Controls.Add(Me.btnP2Play)
        Me.Controls.Add(Me.btnP1Play)
        Me.Controls.Add(Me.btnP1Draw)
        Me.Controls.Add(Me.lstSuits)
        Me.Controls.Add(Me.txtUpCard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblP2Hand)
        Me.Controls.Add(Me.lstP2)
        Me.Controls.Add(Me.lblP1Hand)
        Me.Controls.Add(Me.LstP1)
        Me.Name = "CrazyEights"
        Me.Text = "Crazy Eights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstP1 As System.Windows.Forms.ListBox
    Friend WithEvents lblP1Hand As System.Windows.Forms.Label
    Friend WithEvents lblP2Hand As System.Windows.Forms.Label
    Friend WithEvents lstP2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUpCard As System.Windows.Forms.TextBox
    Friend WithEvents lstSuits As System.Windows.Forms.ListBox
    Friend WithEvents btnP1Draw As System.Windows.Forms.Button
    Friend WithEvents btnP1Play As System.Windows.Forms.Button
    Friend WithEvents btnP2Play As System.Windows.Forms.Button
    Friend WithEvents btnP2Draw As System.Windows.Forms.Button
    Friend WithEvents btnChooseSuit As System.Windows.Forms.Button
    Friend WithEvents btnNextPlayer As System.Windows.Forms.Button
    Friend WithEvents BtnP1Pass As System.Windows.Forms.Button
    Friend WithEvents btnP2Pass As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
