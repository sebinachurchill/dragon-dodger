Public Class Form1
    'SEBINA CHURCHILL
    '29/01/2021
    'Final Project - Dragon Dodger
    'Game where you have to dodge falling dragons for as long as possible

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        'Close main form and open rules
        Me.Hide()
        Rules.Show()
    End Sub

    Private Sub btnHallOfFame_Click(sender As Object, e As EventArgs) Handles btnHallOfFame.Click
        'Close main form and open high scores
        Me.Hide()
        HighScores.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Close main form and open character select form
        Me.Hide()
        CharacterSelect.Show()
    End Sub
End Class
