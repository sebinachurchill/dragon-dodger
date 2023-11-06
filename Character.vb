Public Class Character
    'Member variables for Character class
    Public speedNum, livesNum As Integer
    Public name As String

    'Constructor for name, speed, and lives
    Public Sub New(ByVal nameText As String, ByVal speedAmt As Integer, ByVal livesAmt As Integer)
        Me.name = nameText
        Me.speedNum = speedAmt
        Me.livesNum = livesAmt
    End Sub

    'Return information of character's stats
    Public Overridable Function stats()
        Return name & " - " & "Speed: " & speedNum & "  " & "Base Lives: " & livesNum
    End Function
End Class
