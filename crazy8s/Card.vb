Public Structure Card
    Dim cardValue As Integer
    Dim suit As String

    Public ReadOnly Property name As String
        'the name of the card is set to the value followed by the suit seperated by the space
        Get
            Return cardValue & " " & suit
        End Get
    End Property

    Public Overrides Function ToString() As String
        'this checks for values over 10 first and sets the proper royality
        If cardValue = 11 Then
            Return "jack of " & suit
        ElseIf cardValue = 12 Then
            Return "Queen of " & suit
        ElseIf cardValue = 13 Then
            Return "King of " & suit
        ElseIf cardValue = 1 Then
            Return "ace of " & suit
        Else
            'if not royality go back to simple formatting
            Return cardValue & " " & suit
        End If
    End Function

End Structure
