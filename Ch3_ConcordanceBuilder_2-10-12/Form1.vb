

Imports System.IO

Public Class Form1

    Private infile As StreamReader
    Private wordDict As New Dictionary(Of String, List(Of Integer))
    ' The rawText variable holds all input lines from the file, so we can display
    ' these lines later in the list box when the user searches for a word.
    Private rawText As New List(Of String)

    ' Add the OpenInputFile function, which returns True if a file was selected by
    ' the user. We have already discussed the mechanics of the OpenFileDialog.
    Private Function OpenInputFile() As Boolean
        ' Displays an OpenFileDialog control and lets the user
        ' select the input file.
        With ofdOpenFile
            .InitialDirectory = Directory.GetCurrentDirectory()
            .FileName = "*.txt"
            '.FileName = "*.pdf"
            Dim result As DialogResult = .ShowDialog()
            If result = DialogResult.OK Then
                infile = New StreamReader(.OpenFile())
                ' the next line copies the filename from the OpenFileDialog control into a label on the tool strip
                ' The call to Path.GetFileName returns just the filename after stripping off the long directory path
                lblFileName.Text = "Filename: " & Path.GetFileName(.FileName)
                Return True
            Else
                Return False
            End If
        End With
    End Function




    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        ' The user has clicked the File | Open menu item.
        'calls OpenInputFile, and exits if the user canceled the dialog.
        If Not OpenInputFile() Then Return

        ' Read each line and insert each new word into the dictionary.
        ' For each existing word, add its line number to the list for that word entry.
        ' 
        ' creates a variable named linenum, which will keep track of the line read most recently from the file.
        Dim lineNum As Integer = 0
        Dim filterOut As Char() = ("?':;.,!""").ToCharArray()

        ' repeats the loop until the end of the input file.
        Do While Not infile.EndOfStream()
            ' reads a complete line of input from the file
            Dim temp As String = infile.ReadLine()
            If temp.Trim().Length = 0 Then Continue Do ' skips if the line is blank & goes back to the Do While

            ' adds the line to the rawText list we declared earlier
            rawText.Add(temp)
            ' splits the input line into an array of words
            Dim words() As String = temp.Split(" "c)

            ' begins a new loop whose job is to take each word in the array, trim it and convert it to lowercase
            For Each word As String In words
                word = word.TrimEnd(filterOut).ToLower() ' convert it to lowercase
                If word.Length > 0 AndAlso Char.IsLetter(word(0)) Then 'make sure it is not blank and it begins w/a letter
                    ' we check if the word is already in the dictionary.
                    If Not wordDict.ContainsKey(word) Then ' If it is not, we add the word to the dictionary
                        ' and give it a new empty line number list.
                        wordDict.Add(word, New List(Of Integer))
                    End If
                    ' we add the current line number to the list associated with the current word.
                    wordDict(word).Add(lineNum)
                End If
            Next
            ' increments the line number, and the loop goes back to read another line from the file
            lineNum += 1
        Loop
    End Sub


    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

        lstBox.MultiColumn = True
        lstBox.Items.Clear()
        For Each entry As KeyValuePair(Of String, List(Of Integer)) In wordDict
            lstBox.Items.Add(entry.Key)
        Next
    End Sub
    ' Notice how the code sets the MultiColumn property in the list box to display
    ' as many words as possible at the same time.



    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        ' Its job is to look for the user’s word in the dictionary and then pull out all
        ' matching lines from the "rawText" list.

        lstBox.MultiColumn = False
        lstBox.Items.Clear()
        ' calls ContainsKey to find out if the word (in txtSearchWord.Text) exists in the dictionary.
        If wordDict.ContainsKey(txtSearchWord.Text) Then
            ' if the word is found, the following expression returns a List(Of Integer) object containing
            ' the line numbers where the word was found in the input file: ----- wordDict(txtSearchWord.
            For Each lineNum As Integer In wordDict(txtSearchWord.Text)
                ' uses each line number as an index into the rawText List object, and inserts the text into the lstbox
                lstBox.Items.Add(lineNum & ":" & vbTab & rawText(lineNum))
            Next
        Else
            lstBox.Items.Add("(word not found)")
        End If
    End Sub


    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
End Class
