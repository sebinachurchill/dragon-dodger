Imports System.IO
Public Class Gameplay
    'GLOBAL VARIABLES
    Dim player As Character                 'Create variable of type Character
    Dim playerName As String                'Variable holds player's name
    Dim playerRight As Boolean              'Keeps track of player moving right
    Dim playerLeft As Boolean               'Keeps track of player moving left
    Dim playerSpeed As Integer              'Holds player's speed

    Dim dragonSpeed As Integer              'Variable for dragon's speed

    Dim dragonNum As Integer                'Variable for first randomly selected dragon
    Dim dragonNumTwo As Integer             'Variable for second randomly selected dragon
    Dim dragonNumThree As Integer           'Variable for third randomly selected dragon

    Dim dragon As PictureBox                'PictureBox for first dragon
    Dim dragonTwo As PictureBox             'PictureBox for second dragon
    Dim dragonThree As PictureBox           'PictureBox for third dragon

    Dim yCoord As Integer = 77              'Holds original y-coordinate of dragons

    Dim seconds As Integer                  'Keeps track of how many seconds have passed

    Dim dragonFalling As Integer            'Variable for dragon falling animation
    Dim playerRunning As Integer = 0        'Variable for player movement animation

    Dim score As Integer                    'Keeps track of player score

    Private Sub Gameplay_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Call LoadSettings procedure
        LoadSettings()

        'Create new Character
        player = New Character(characterName, speed, lives)

        'Display lives and player stats
        lblLives.Text = lives
        lblStats.Text = player.stats()

        'Play background music
        My.Computer.Audio.Play(My.Resources.Fairy_Tail_Main_Theme_8_Bit_Remix__BETTER_VERSION_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'Increment and display score
        score += (1 + lives)
        lblScore.Text = score

        'Increment seconds counter
        seconds += 1

        'Check if level counter is 10
        If seconds = 10 Then
            'Increase dragon speed and reset seconds counter
            dragonSpeed += 3
            seconds = 0
        End If
    End Sub

    Private Sub Gameplay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Check if right arrow key is pressed
        If e.KeyValue = Keys.Right Then
            'Set playerRight to True and playerLeft to False
            playerRight = True
            playerLeft = False
        End If

        'Check if left arrow key is pressed
        If e.KeyValue = Keys.Left Then
            'Set playerLeft to True and playerRight to False
            playerLeft = True
            playerRight = False
        End If
    End Sub

    Public Sub MovePlayer()
        'Check if tank is moving right and hasn't hit right edge
        If playerRight = True And picPlayer.Right < Me.ClientRectangle.Right Then
            'Move player to the right
            picPlayer.Left += playerSpeed
        End If

        'Check if tank is moving left and hasn't hit left edge
        If playerLeft = True And picPlayer.Left - playerSpeed > Me.ClientRectangle.Left Then
            'Move player to the left
            picPlayer.Left -= playerSpeed
        End If
    End Sub

    Private Sub Gameplay_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'Check if right arrow key is released
        If e.KeyValue = Keys.Right Then
            'Set playerRight boolean to false
            playerRight = False
        End If

        'Check if left arrow key is released
        If e.KeyValue = Keys.Left Then
            'Set playerLeft boolean to false
            playerLeft = False
        End If
    End Sub

    Private Sub tmrMovement_Tick(sender As Object, e As EventArgs) Handles tmrMovement.Tick
        'Call MovePlayer procedure
        MovePlayer()

        'Check if player is Jane
        If characterName = "Jane" Then
            'Check if player is moving right
            If playerRight = True Then
                'Animate Jane running right
                Select Case playerRunning
                    Case 0
                        picPlayer.Image = My.Resources.girlRight2
                    Case 1
                        picPlayer.Image = My.Resources.girlRight1
                    Case 2
                        picPlayer.Image = My.Resources.girlRight2
                    Case 3
                        picPlayer.Image = My.Resources.girlRight3
                End Select
            End If

            'Check if player is moving left
            If playerLeft = True Then
                'Animate Jane running left
                Select Case playerRunning
                    Case 0
                        picPlayer.Image = My.Resources.girlLeft2
                    Case 1
                        picPlayer.Image = My.Resources.girlLeft1
                    Case 2
                        picPlayer.Image = My.Resources.girlLeft2
                    Case 3
                        picPlayer.Image = My.Resources.girlLeft3
                End Select
            End If

            'Increment playerRunning counter by 1
            playerRunning += 1

            'Reset playerRunning counter to 0 if it = 4
            If playerRunning = 4 Then
                playerRunning = 0
            End If


            'Make character face forward if not moving
            If playerRight = False And playerLeft = False Then
                picPlayer.Image = My.Resources.girlForward
            End If


        ElseIf characterName = "John" Then
            'Check if player is moving right
            If playerRight = True Then
                'Animate John running to the right
                Select Case playerRunning
                    Case 0
                        picPlayer.Image = My.Resources.guyRight2
                    Case 1
                        picPlayer.Image = My.Resources.guyRight1
                    Case 2
                        picPlayer.Image = My.Resources.guyRight2
                    Case 3
                        picPlayer.Image = My.Resources.guyRight3
                End Select
            End If

            'Check if player is moving left
            If playerLeft = True Then
                'Animate John running to the left
                Select Case playerRunning
                    Case 0
                        picPlayer.Image = My.Resources.guyLeft2
                    Case 1
                        picPlayer.Image = My.Resources.guyLeft1
                    Case 2
                        picPlayer.Image = My.Resources.guyLeft2
                    Case 3
                        picPlayer.Image = My.Resources.guyLeft3
                End Select
            End If

            'Make character face forward if not moving
            If playerRight = False And playerLeft = False Then
                picPlayer.Image = My.Resources.guyForward
            End If

            'Increment playerRunning counter by 1
            playerRunning += 1

            'Reset playerRunning counter to 0 if it = 4
            If playerRunning = 4 Then
                playerRunning = 0
            End If
        End If

    End Sub

    'Procedure that sets speed of dragons and player and starts timers
    Private Sub LoadSettings()
        'Set player and dragon speed
        dragonSpeed = 15
        playerSpeed = speed

        'Start timers
        tmrTimer.Start()
        tmrMovement.Start()
        tmrDragonChoose.Start()
    End Sub

    Private Sub tmrDragonChoose_Tick(sender As Object, e As EventArgs) Handles tmrDragonChoose.Tick
        'Ensures number is truly random
        Randomize()

        'Generate random number for first demon
        dragonNum = Int((5 - 1 + 1) * Rnd() + 1)

        'Make dragon of the generated number visible, and set that picturebox as first dragon PictureBox object
        Select Case dragonNum
            Case 1
                picDragon1.Visible = True
                dragon = picDragon1

            Case 2
                picDragon2.Visible = True
                dragon = picDragon2

            Case 3
                picDragon3.Visible = True
                dragon = picDragon3

            Case 4
                picDragon4.Visible = True
                dragon = picDragon4

            Case 5
                picDragon5.Visible = True
                dragon = picDragon5
        End Select

        'Generate random number for second dragon
        dragonNumTwo = Int((5 - 1 + 1) * Rnd() + 1)
        'Generate a new number if it is the same as the first dragon
        Do While dragonNumTwo = dragonNum
            dragonNumTwo = Int((5 - 1 + 1) * Rnd() + 1)
        Loop

        'Make dragon of the generated number visible, and set that picturebox as second dragon PictureBox object
        Select Case dragonNumTwo
            Case 1
                picDragon1.Visible = True
                dragonTwo = picDragon1
            Case 2
                picDragon2.Visible = True
                dragonTwo = picDragon2
            Case 3
                picDragon3.Visible = True
                dragonTwo = picDragon3
            Case 4
                picDragon4.Visible = True
                dragonTwo = picDragon4
            Case 5
                picDragon5.Visible = True
                dragonTwo = picDragon5
        End Select

        'Generate random number for third dragon
        dragonNumThree = Int((5 - 1 + 1) * Rnd() + 1)
        'Generate new number if it is the same as the first or second dragon
        Do While dragonNumThree = dragonNum Or dragonNumThree = dragonNumTwo
            dragonNumThree = Int((5 - 1 + 1) * Rnd() + 1)
        Loop

        'Make dragon of the generated number visible, and set that picturebox as third dragon PictureBox object
        Select Case dragonNumThree
            Case 1
                picDragon1.Visible = True
                dragonThree = picDragon1
            Case 2
                picDragon2.Visible = True
                dragonThree = picDragon2
            Case 3
                picDragon3.Visible = True
                dragonThree = picDragon3
            Case 4
                picDragon4.Visible = True
                dragonThree = picDragon4
            Case 5
                picDragon5.Visible = True
                dragonThree = picDragon5
        End Select

        'Stop DragonChoose timer And start DragonFall timer
        tmrDragonChoose.Stop()
        tmrDragonFall.Start()
    End Sub

    Private Sub tmrDragonFall_Tick(sender As Object, e As EventArgs) Handles tmrDragonFall.Tick
        'Call MoveDragon procedure
        MoveDragon()

        'Call CheckCollision procedure
        CheckCollision()

        'Call CheckLives procedure
        CheckLives()
    End Sub

    'Procedure that causes dragons to fall
    Private Sub MoveDragon()
        'Make dragons fall from top of screen
        dragon.Top += dragonSpeed : dragonTwo.Top += dragonSpeed : dragonThree.Top += dragonSpeed


        'Check if dragon has reached the bottom of the screen
        If dragon.Bottom >= Me.ClientRectangle.Bottom Or dragonTwo.Bottom >= Me.ClientRectangle.Bottom Or dragonThree.Bottom >= Me.ClientRectangle.Bottom Then
            'Stop DragonFall timer
            tmrDragonFall.Stop()

            'Make dragons invisible and return them to top of screen
            dragon.Visible = False
            dragon.Location = New Point(dragon.Location.X, yCoord)
            dragonTwo.Visible = False
            dragonTwo.Location = New Point(dragonTwo.Location.X, yCoord)
            dragonThree.Visible = False
            dragonThree.Location = New Point(dragonThree.Location.X, yCoord)

            'Start DragonChoose timer
            tmrDragonChoose.Start()
        End If


        'Animate dragons falling
        Select Case dragonFalling
            Case 0
                dragon.Image = My.Resources.demon1
                dragonTwo.Image = My.Resources.demon1
                dragonThree.Image = My.Resources.demon1
            Case 1
                dragon.Image = My.Resources.demon2
                dragonTwo.Image = My.Resources.demon2
                dragonThree.Image = My.Resources.demon2
            Case 2
                dragon.Image = My.Resources.demon3
                dragonTwo.Image = My.Resources.demon3
                dragonThree.Image = My.Resources.demon3
            Case 3
                dragon.Image = My.Resources.demon2
                dragonTwo.Image = My.Resources.demon2
                dragonThree.Image = My.Resources.demon2
        End Select

        'Increment dragonFalling counter by 1
        dragonFalling += 1

        'Reset dragonFalling counter to 0 if it = 4
        If dragonFalling = 4 Then
            dragonFalling = 0
        End If
    End Sub

    'Procedure that checks if dragon has collided with player
    Private Sub CheckCollision()
        'Check if any dragon has collided with player
        If dragon.Bounds.IntersectsWith(picPlayer.Bounds) Or dragonTwo.Bounds.IntersectsWith(picPlayer.Bounds) Or dragonThree.Bounds.IntersectsWith(picPlayer.Bounds) Then
            'Stop DragonFall timer
            tmrDragonFall.Stop()

            'Decrease lives by 1 and set lives label
            lives -= 1
            lblLives.Text = lives

            'Make dragons invisible and return them to top of screen
            dragon.Visible = False
            dragon.Location = New Point(dragon.Location.X, yCoord)
            dragonTwo.Visible = False
            dragonTwo.Location = New Point(dragonTwo.Location.X, yCoord)
            dragonThree.Visible = False
            dragonThree.Location = New Point(dragonThree.Location.X, yCoord)

            'Start DragonChoose timer
            tmrDragonChoose.Start()
        End If
    End Sub

    'Procedure that checks player's lives
    Private Sub CheckLives()
        'Check if player has one life left
        If lives = 1 Then
            'Change lives label colour to red
            lblLives.ForeColor = Color.Red
        End If

        'Check player has run out of lives
        If lives = 0 Then
            'Stop all timers
            tmrTimer.Stop()
            tmrMovement.Stop()
            tmrDragonChoose.Stop()
            tmrDragonFall.Stop()

            'Make dragons invisible and retunr them to top of screen
            dragon.Visible = False
            dragon.Location = New Point(dragon.Location.X, yCoord)
            dragonTwo.Visible = False
            dragonTwo.Location = New Point(dragonTwo.Location.X, yCoord)
            dragonTwo.Visible = False
            dragonThree.Location = New Point(dragonThree.Location.X, yCoord)

            'Set dragon's speed to 0
            dragonSpeed = 0

            'InputBox asks user for their name, and sets playerName value to that name
            playerName = InputBox("Your score is : " & score & " " & "Please enter your name.", "Game Over!")

            'Check if playerName is blank
            If playerName = "" Then
                'Set playerName to Nameless Hero
                playerName = "A Nameless Hero"
            End If


            'Creates object of FileStream class set to "open" and "write" to Leaderboard file
            Dim FSWrite As New FileStream("Leaderboard.txt", FileMode.Append, FileAccess.Write)
            'Create instance of StreamWriter to write text to file
            Dim SW As New StreamWriter(FSWrite)
            'Write score to text file
            SW.WriteLine(score)
            'Close StreamWriter
            SW.Close()
            'Close FileStream
            FSWrite.Close()


            'Creates object of FileStream class set to "open" and "write" to ScoreNames file
            Dim FSWriteTwo As New FileStream("ScoreNames.txt", FileMode.Append, FileAccess.Write)
            'Create instance of StreamWriter to write text to file
            Dim SWTwo As New StreamWriter(FSWriteTwo)
            'Write playerName to text file
            SWTwo.WriteLine(playerName)
            'Close StreamWriter
            SWTwo.Close()
            'Close FileStream
            FSWriteTwo.Close()


            'Reset score and set lives to -1
            score = 0
            lives = -1

            'Stop background music
            My.Computer.Audio.Stop()

            'Close gameplay form and open main form
            Me.Close()
            Form1.Show()
        End If
    End Sub

End Class