Imports System.IO
Public Class HighScores
    Private Sub HighScores_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Clear listbox
        lstHighScores.Items.Clear()

        'Create instance of StreamReader class to read from selected file
        Dim textFile As New StreamReader("Leaderboard.txt")
        Dim textFileTwo As New StreamReader("ScoreNames.txt")

        'Read each line from Leaderboard file and add to listbox
        Do While textFile.Peek <> -1
            lstHighScores.Items.Add(textFile.ReadLine)
        Loop

        'Create array for scores that is the same length as the number of items in listbox
        Dim scoresArray(lstHighScores.Items.Count - 1) As Integer

        'Add each number from listbox into scoresArray
        For index As Integer = 0 To lstHighScores.Items.Count - 1
            scoresArray(index) = lstHighScores.Items(index)
        Next

        'Clear listbox
        lstHighScores.Items.Clear()

        'Read each line from ScoreNames file and add to listbox
        Do While textFileTwo.Peek <> -1
            lstHighScores.Items.Add(textFileTwo.ReadLine)
        Loop

        'Create array for names that is the same length as the number of items in the listbox
        Dim namesArray(lstHighScores.Items.Count - 1) As String

        'Add each name from listbox into namesArray
        For index As Integer = 0 To lstHighScores.Items.Count - 1
            namesArray(index) = lstHighScores.Items(index)
        Next

        'Clear listbox
        lstHighScores.Items.Clear()

        'Call SortScores procedure and pass scoresArray and namesArray as arguments
        SortScores(scoresArray, namesArray)

        'Add names and scores from arrays to listbox
        For index As Integer = 0 To scoresArray.Length - 1
            lstHighScores.Items.Add("Name: " & namesArray(index) & " " & "--" & " " & "Score: " & scoresArray(index))
        Next
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'Close current form and open main form
        Me.Hide()
        Form1.Show()
    End Sub

    'Procedure that sorts scores and their corresponding names in descending order
    Sub SortScores(ByRef arrayReceived() As Integer, ByRef nameReceived() As String)
        'LOCAL VARIABLES
        Dim holder As Integer               'Holds value at current index so it's not lost (for scoresArray)
        Dim nameHolder As String            'Holds string value at current index so it's not lost (for namesArray)


        'THIS SORTS THE SCORES ARRAY AND NAME ARRAY AT THE SAME TIME
        'WHEN THE NUMBERS ARE REARRANGED IN THE SCORES ARRAY, THE NAMES IN THE NAMES ARRAY
        'ARE REARRANGED IN THE EXACT SAME WAY

        'From index 0 to the end of the array
        For index As Integer = 0 To arrayReceived.Length - 1

            'For the value at the current index to the end of the array (This loop runs for each index in the first loop)
            For findHighScore As Integer = index To arrayReceived.Length - 1

                'Check if any values in the array are higher than the value at the current index
                If arrayReceived(findHighScore) > arrayReceived(index) Then

                    holder = arrayReceived(index)           'Set holder value to current index value in arrayReceived (save current index value so it's not lost)
                    nameHolder = nameReceived(index)        'Set nameHolder value to current index value in nameReceived (save current index value so it's not lost)

                    'Set value at the current index of array to the value of highest number found
                    arrayReceived(index) = arrayReceived(findHighScore)
                    'Set string value at current index to the name at the same index of highest number
                    nameReceived(index) = nameReceived(findHighScore)
                    'Set value of the highest number's original index to holder value/current index original value
                    arrayReceived(findHighScore) = holder
                    'Set value of name with highest score's original index to nameHolder value/current index original value
                    nameReceived(findHighScore) = nameHolder
                End If
            Next
        Next
    End Sub

    Private Sub lstHighScores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHighScores.SelectedIndexChanged

    End Sub
End Class