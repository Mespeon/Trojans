Module Arceus
    Public ctr1
    Public choicebtn As Integer
    Public wordarr(250)
    Public c
    Public r1, r2, r3, r4, r5, r6
    'Swap overlays
    Public Sub swapOverlays(button, mode)
        If button = "btnStart" Then
            If mode = "enter" Then
                Main.btnStart.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnStart.BackgroundImage = Nothing
            End If
        ElseIf button = "btnLoad" Then
            If mode = "enter" Then
                Main.btnLoad.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnLoad.BackgroundImage = Nothing
            End If
        ElseIf button = "btnPreferences" Then
            If mode = "enter" Then
                Main.btnPreferences.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnPreferences.BackgroundImage = Nothing
            End If
        ElseIf button = "btnLoadClose" Then
            If mode = "enter" Then
                Main.btnLoadClose.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnLoadClose.BackgroundImage = Nothing
            End If
        Else
            If mode = "enter" Then
                Main.btnQuit.BackgroundImage = My.Resources.scrim_w
            Else
                Main.btnQuit.BackgroundImage = Nothing
            End If
        End If
    End Sub

    'En/disable control panel
    Public Sub ctrlPanelToggle(mode)
        If mode = 1 Then
            Main.pnlControls.Enabled = True
        Else
            Main.pnlControls.Enabled = False
        End If
    End Sub

    'View load menu
    Public Sub load()
        'Set background to scrimmed and show load menu
        Main.pnlLeftScrim.BackgroundImage = My.Resources.scrim
        Main.pnlLoadData.Enabled = True
        Main.pnlLoadData.Visible = True

        'Disable control panel
        ctrlPanelToggle(0)

        'Pull saved data from file
    End Sub

    'Close load menu
    Public Sub closeLoad()
        'Reset backgrounds
        Main.pnlLeftScrim.BackgroundImage = Nothing
        Main.pnlLoadData.Enabled = False
        Main.pnlLoadData.Visible = False

        'Reenable control panel
        ctrlPanelToggle(1)
    End Sub

    Public Sub pageForward(chapter, page)
        If chapter = 0 Then
            navChapter0(page)
        ElseIf chapter = 1 Then
            navChapter1(page)
        ElseIf chapter = 2 Then
            navChapter2(page)
        ElseIf chapter = 3 Then
            navChapter3(page)
        ElseIf chapter = 4 Then
            navChapter4(page)
        ElseIf chapter = 5 Then
            navChapter5(page)
        Else
            navChapter6(page)
        End If
    End Sub

    'Navigate Chapter 0
    Public Sub navChapter0(page)
        Dim chapter As Integer = 0

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then


                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 7 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Navigate Chapter 1
    Public Sub navChapter1(page)
        Dim chapter As Integer = 1

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 13 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Navigate Chapter 2
    Public Sub navChapter2(page)
        Dim chapter As Integer = 2

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 21 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Navigate Chapter 3
    Public Sub navChapter3(page)
        Dim chapter As Integer = 3

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.lblStory.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 14 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Navigate Chapter 4
    Public Sub navChapter4(page)
        Dim chapter As Integer = 4

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 11 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Navigate Chapter 5
    Public Sub navChapter5(page)
        Dim chapter As Integer = 5

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 13 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub printText(str)
        Dim retString As String
        c += 1
        If c < Len(str) Then
            retString = str.Substring(0, c + 1)
            Storyboard.lblStory.Text = retString
        Else
            Storyboard.tmrCharPrint.Stop()
            c = 0
        End If

    End Sub
    'Navigate Chapter 6
    Public Sub navChapter6(page)
        Dim chapter As Integer = 6

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        sqlQuery = "SELECT content, choiceA, choiceB FROM stories WHERE chapterNum=" & chapter & " AND pageNum=" & page
        Try
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Storyboard.tmrCharPrint.Start()
                Storyboard.Text = sqlDataReader.Item("content")
                If (sqlDataReader.Item("choiceA") = "none") Then
                    Storyboard.btnChoiceA.Visible = False
                    Storyboard.btnNext.Visible = True
                Else
                    Storyboard.btnChoiceA.Visible = True
                    Storyboard.btnChoiceA.Text = sqlDataReader.Item("choiceA")
                    Storyboard.btnNext.Visible = False
                End If

                If (sqlDataReader.Item("choiceB") = "none") Then
                    Storyboard.btnNext.Visible = True
                    Storyboard.btnChoiceB.Visible = False
                Else
                    Storyboard.btnChoiceB.Visible = True
                    Storyboard.btnChoiceB.Text = sqlDataReader.Item("choiceB")
                    Storyboard.btnNext.Visible = False
                End If

                Storyboard.currentPage += 1
                If Storyboard.currentPage > 14 Then
                    Storyboard.currentChapter += 1
                    Storyboard.currentPage = 1
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Else
                MessageBox.Show("An error has occurred.")
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                Storyboard.Close()
                Main.Show()
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Save progress

    Public Sub wordorganizer()
        Dim s As String
        s = "SWAP FOR REAL DIALOGUES"
        Storyboard.lblStory.Text = Nothing
        Dim words
        words = Split(s)
        For i = 0 To UBound(words)
            wordarr(ctr1) = words(i)
            ctr1 += 1
        Next
        ctr1 = 0
        Storyboard.worddisplayer.Start()
        Storyboard.worddisplayer.Interval = Len(wordarr(ctr1)) * 100
    End Sub

    Public Sub worddisplay()
        Storyboard.lblStory.Text += wordarr(ctr1) & " "
        ctr1 += 1
        If ctr1 >= wordarr.Count - 2 = False Then
            If Len(wordarr(ctr1)) * 100 > 0 Then
                Storyboard.worddisplayer.Interval = Len(wordarr(ctr1)) * 100
            Else
                Storyboard.worddisplayer.Stop()
            End If
        Else
            Storyboard.worddisplayer.Stop()
        End If
    End Sub
End Module
