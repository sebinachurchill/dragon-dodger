Public Class CharacterSelect
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Check if Jane is selected
        If rdbJane.Checked = True Then
            'Set name, speed, and lives
            characterName = "Jane"
            speed = 25
            lives = 3
            'Check if John is selected
        ElseIf rdbJohn.Checked = True Then
            'Set name, speed, and lives
            characterName = "John"
            speed = 15
            lives = 4
        End If

        'Hide current form and open gameplay form
        Me.Hide()
        Gameplay.Show()
    End Sub
End Class