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
        Me.lblwin = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstP1
        '
        Me.LstP1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstP1.FormattingEnabled = True
        Me.LstP1.ItemHeight = 26
        Me.LstP1.Location = New System.Drawing.Point(12, 36)
        Me.LstP1.Name = "LstP1"
        Me.LstP1.Size = New System.Drawing.Size(373, 420)
        Me.LstP1.TabIndex = 0
        '
        'lblP1Hand
        '
        Me.lblP1Hand.AutoSize = True
        Me.lblP1Hand.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Hand.Location = New System.Drawing.Point(12, 6)
        Me.lblP1Hand.Name = "lblP1Hand"
        Me.lblP1Hand.Size = New System.Drawing.Size(135, 26)
        Me.lblP1Hand.TabIndex = 1
        Me.lblP1Hand.Text = "Player 1 hand"
        '
        'lblP2Hand
        '
        Me.lblP2Hand.AutoSize = True
        Me.lblP2Hand.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Hand.Location = New System.Drawing.Point(665, 6)
        Me.lblP2Hand.Name = "lblP2Hand"
        Me.lblP2Hand.Size = New System.Drawing.Size(135, 26)
        Me.lblP2Hand.TabIndex = 3
        Me.lblP2Hand.Text = "Player 2 hand"
        '
        'lstP2
        '
        Me.lstP2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstP2.FormattingEnabled = True
        Me.lstP2.ItemHeight = 26
        Me.lstP2.Location = New System.Drawing.Point(665, 36)
        Me.lstP2.Name = "lstP2"
        Me.lstP2.Size = New System.Drawing.Size(373, 420)
        Me.lstP2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Face up card"
        '
        'txtUpCard
        '
        Me.txtUpCard.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpCard.Location = New System.Drawing.Point(391, 32)
        Me.txtUpCard.Name = "txtUpCard"
        Me.txtUpCard.Size = New System.Drawing.Size(268, 31)
        Me.txtUpCard.TabIndex = 5
        '
        'lstSuits
        '
        Me.lstSuits.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSuits.FormattingEnabled = True
        Me.lstSuits.ItemHeight = 26
        Me.lstSuits.Items.AddRange(New Object() {"Hearts", "Diamonds", "Clubs", "Spades"})
        Me.lstSuits.Location = New System.Drawing.Point(391, 69)
        Me.lstSuits.Name = "lstSuits"
        Me.lstSuits.Size = New System.Drawing.Size(268, 160)
        Me.lstSuits.TabIndex = 6
        '
        'btnP1Draw
        '
        Me.btnP1Draw.BackColor = System.Drawing.Color.White
        Me.btnP1Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP1Draw.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP1Draw.Location = New System.Drawing.Point(228, 460)
        Me.btnP1Draw.Name = "btnP1Draw"
        Me.btnP1Draw.Size = New System.Drawing.Size(157, 50)
        Me.btnP1Draw.TabIndex = 8
        Me.btnP1Draw.Text = "Draw"
        Me.btnP1Draw.UseVisualStyleBackColor = False
        '
        'btnP1Play
        '
        Me.btnP1Play.BackColor = System.Drawing.Color.White
        Me.btnP1Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP1Play.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP1Play.Location = New System.Drawing.Point(12, 460)
        Me.btnP1Play.Name = "btnP1Play"
        Me.btnP1Play.Size = New System.Drawing.Size(157, 50)
        Me.btnP1Play.TabIndex = 9
        Me.btnP1Play.Text = "Play"
        Me.btnP1Play.UseVisualStyleBackColor = False
        '
        'btnP2Play
        '
        Me.btnP2Play.BackColor = System.Drawing.Color.White
        Me.btnP2Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP2Play.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP2Play.Location = New System.Drawing.Point(665, 460)
        Me.btnP2Play.Name = "btnP2Play"
        Me.btnP2Play.Size = New System.Drawing.Size(157, 50)
        Me.btnP2Play.TabIndex = 10
        Me.btnP2Play.Text = "Play"
        Me.btnP2Play.UseVisualStyleBackColor = False
        '
        'btnP2Draw
        '
        Me.btnP2Draw.BackColor = System.Drawing.Color.White
        Me.btnP2Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP2Draw.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP2Draw.Location = New System.Drawing.Point(881, 460)
        Me.btnP2Draw.Name = "btnP2Draw"
        Me.btnP2Draw.Size = New System.Drawing.Size(157, 50)
        Me.btnP2Draw.TabIndex = 11
        Me.btnP2Draw.Text = "Draw"
        Me.btnP2Draw.UseVisualStyleBackColor = False
        '
        'btnChooseSuit
        '
        Me.btnChooseSuit.BackColor = System.Drawing.Color.White
        Me.btnChooseSuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseSuit.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSuit.Location = New System.Drawing.Point(391, 245)
        Me.btnChooseSuit.Name = "btnChooseSuit"
        Me.btnChooseSuit.Size = New System.Drawing.Size(268, 50)
        Me.btnChooseSuit.TabIndex = 12
        Me.btnChooseSuit.Text = "Choose Suit"
        Me.btnChooseSuit.UseVisualStyleBackColor = False
        '
        'btnNextPlayer
        '
        Me.btnNextPlayer.BackColor = System.Drawing.Color.White
        Me.btnNextPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPlayer.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPlayer.Location = New System.Drawing.Point(391, 407)
        Me.btnNextPlayer.Name = "btnNextPlayer"
        Me.btnNextPlayer.Size = New System.Drawing.Size(268, 50)
        Me.btnNextPlayer.TabIndex = 13
        Me.btnNextPlayer.Text = "Next Player"
        Me.btnNextPlayer.UseVisualStyleBackColor = False
        '
        'BtnP1Pass
        '
        Me.BtnP1Pass.BackColor = System.Drawing.Color.White
        Me.BtnP1Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnP1Pass.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnP1Pass.Location = New System.Drawing.Point(118, 514)
        Me.BtnP1Pass.Name = "BtnP1Pass"
        Me.BtnP1Pass.Size = New System.Drawing.Size(157, 50)
        Me.BtnP1Pass.TabIndex = 14
        Me.BtnP1Pass.Text = "Pass"
        Me.BtnP1Pass.UseVisualStyleBackColor = False
        '
        'btnP2Pass
        '
        Me.btnP2Pass.BackColor = System.Drawing.Color.White
        Me.btnP2Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP2Pass.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP2Pass.Location = New System.Drawing.Point(775, 514)
        Me.btnP2Pass.Name = "btnP2Pass"
        Me.btnP2Pass.Size = New System.Drawing.Size(157, 50)
        Me.btnP2Pass.TabIndex = 15
        Me.btnP2Pass.Text = "Pass"
        Me.btnP2Pass.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(391, 297)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(71, 26)
        Me.lblError.TabIndex = 16
        Me.lblError.Text = "Label1"
        Me.lblError.Visible = False
        '
        'lblwin
        '
        Me.lblwin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblwin.AutoSize = True
        Me.lblwin.BackColor = System.Drawing.Color.Aqua
        Me.lblwin.Font = New System.Drawing.Font("Trebuchet MS", 60.0!)
        Me.lblwin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblwin.Location = New System.Drawing.Point(31, 78)
        Me.lblwin.Name = "lblwin"
        Me.lblwin.Size = New System.Drawing.Size(979, 151)
        Me.lblwin.TabIndex = 18
        Me.lblwin.Text = "Player One Wins!"
        Me.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblwin.Visible = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Fuchsia
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGame.Font = New System.Drawing.Font("Trebuchet MS", 50.0!)
        Me.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewGame.Location = New System.Drawing.Point(31, 232)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(979, 169)
        Me.btnNewGame.TabIndex = 19
        Me.btnNewGame.Text = "Start a new game?"
        Me.btnNewGame.UseVisualStyleBackColor = False
        Me.btnNewGame.Visible = False
        '
        'CrazyEights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 573)
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
        Me.Controls.Add(Me.LstP1)
        Me.Controls.Add(Me.lblP1Hand)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblwin)
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
    Friend WithEvents lblwin As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button

End Class
