Public Class Storyboard
    Dim menuOn As Boolean = False
    Public currentChapter As Integer = 0
    Public currentPage As Integer = 1
    Dim score = 0

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If menuOn = False Then
            menuOn = True
            btnReturn.Visible = True

        Else
            menuOn = False
            btnReturn.Visible = False

        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnChoiceA_Click(sender As Object, e As EventArgs) Handles btnChoiceA.Click
        'currentPage + 1 CASE BY CASE
        If currentChapter = 1 And currentPage = 8 Then
            r1 += 1
            pageForward(currentChapter, 9)
        ElseIf currentChapter = 1 And currentPage = 9

            pageForward(currentChapter, 11)
        ElseIf currentChapter = 1 And currentPage = 10
            r1 += 1
            pageForward(currentChapter, 13)
        ElseIf currentChapter = 2 And currentPage = 4
            pageForward(currentChapter, 4)
        ElseIf currentChapter = 2 And currentPage = 8

            currentPage += 3
            pageForward(currentChapter, currentPage)
        ElseIf currentChapter = 2 And currentPage = 18

            currentPage += 3

            pageForward(currentChapter, 18)
        ElseIf currentChapter = 2 And currentPage = 14

            pageForward(currentChapter, 16)
        ElseIf currentChapter = 3 And currentPage = 7
            r3 += 1
            pageForward(currentChapter, 7)
        ElseIf currentChapter = 3 And currentPage = 11
            r3 += 1
            pageForward(currentChapter, 11)
        ElseIf currentChapter = 3 And currentPage = 12
            r3 += 1
            pageForward(currentChapter, 13)
        ElseIf currentChapter = 3 And currentPage = 14
            r3 += 1
            currentPage = 7
            pageForward(currentChapter, 7)

        ElseIf currentChapter = 4 And currentPage = 4
            r4 += 1
            currentPage = 5
            pageForward(currentChapter, 5)
        ElseIf currentChapter = 4 And currentPage = 6

            pageForward(currentChapter, 6)
            score += 1
        ElseIf currentChapter = 4 And currentPage = 8
            r4 += 1

            pageForward(currentChapter, 8)
            score += 1
        ElseIf currentChapter = 4 And currentPage = 9
            r4 += 1
            pageForward(currentChapter, 9)
            score += 1
        ElseIf currentChapter = 4 And currentPage = 10
            currentPage = 10
            pageForward(currentChapter, 10)
        ElseIf currentChapter = 4 And currentPage = 11
            If MsgBox("YOUR SCORE IS: " & score & " OUT OF 4", vbOKOnly) = vbOK Then
                currentChapter += 1
                currentPage = 1
                pageForward(currentChapter, currentPage)
            End If
        ElseIf currentChapter = 5 And currentPage = 3

            pageForward(currentChapter, 3)
        ElseIf currentChapter = 5 And currentPage = 6

            pageForward(currentChapter, 7)
        ElseIf currentChapter = 5 And currentPage = 9

            pageForward(currentChapter, 9)
        ElseIf currentChapter = 5 And currentPage = 12
            r5 += 1
            pageForward(currentChapter, 13)

        ElseIf currentChapter = 6 And currentPage = 4
            r6 += 1
            currentPage = 5
            pageForward(currentChapter, 5)
        ElseIf currentChapter = 6 And currentPage = 7
            r6 += 1
            currentPage = 8
            pageForward(currentChapter, 8)
        ElseIf currentChapter = 6 And currentPage = 9
            r6 += 1
            currentPage = 11
            pageForward(currentChapter, 11)
        ElseIf currentChapter = 6 And currentPage = 13
            r6 += 1
            pageForward(currentChapter, 14)
        Else



            pageForward(currentChapter, currentPage)
        End If
    End Sub

    Private Sub btnChoiceB_Click(sender As Object, e As EventArgs) Handles btnChoiceB.Click
        'currentPage + 1
        If currentChapter = 1 And currentPage = 8 Then

            pageForward(currentChapter, 8)
        ElseIf currentChapter = 1 And currentPage = 10 Then

            pageForward(currentChapter, 10)
        ElseIf currentChapter = 1 And currentPage = 11

            pageForward(currentChapter, 12)
        ElseIf currentChapter = 2 And currentPage = 4

            pageForward(currentChapter, 8)
        ElseIf currentChapter = 2 And (currentPage = 11 Or currentPage = 8)

            currentPage = 16
            pageForward(currentChapter, 16)

        ElseIf currentChapter = 2 And currentPage = 17
            r2 += 1
            currentPage = 20
            pageForward(currentChapter, 20)
        ElseIf currentChapter = 2 And currentPage = 18
            r2 += 1
            currentPage += 2
            pageForward(currentChapter, currentPage)
        ElseIf currentChapter = 3 And currentPage = 4 Then

            currentPage = 12
            pageForward(currentChapter, 12)
        ElseIf currentChapter = 3 And currentPage = 8 Then

            r3 += 1
            pageForward(currentChapter, 9)
        ElseIf currentChapter = 3 And currentPage = 7

            currentPage = 10
            pageForward(currentChapter, 10)
        ElseIf currentChapter = 3 And currentPage = 13

            currentPage += 1
            pageForward(currentChapter, 14)
        ElseIf currentChapter = 3 And currentPage = 11

            currentPage += 1
            pageForward(currentChapter, 14)
        ElseIf currentChapter = 4 And currentPage = 4

            pageForward(currentChapter, 4)
        ElseIf currentChapter = 4 And currentPage = 6
            r4 += 1
            currentPage = 7
            pageForward(currentChapter, 7)
            score += 1
        ElseIf currentChapter = 4 And currentPage = 8

            pageForward(currentChapter, 8)
        ElseIf currentChapter = 4 And currentPage = 9

            pageForward(currentChapter, 9)
        ElseIf currentChapter = 4 And currentPage = 10
            r4 += 1
            currentPage = 10
            pageForward(currentChapter, 10)
            score += 1
        ElseIf currentChapter = 4 And currentPage = 11

            pageForward(currentChapter, 11)

        ElseIf currentChapter = 5 And currentPage = 3
            r5 += 1
            pageForward(currentChapter, 4)
        ElseIf currentChapter = 5 And currentPage = 6
            r5 += 1
            pageForward(currentChapter, 7)
        ElseIf currentChapter = 5 And currentPage = 9
            r5 += 1
            pageForward(currentChapter, 10)
        ElseIf currentChapter = 5 And currentPage = 12

            pageForward(currentChapter, 12)

        ElseIf currentChapter = 6 And currentPage = 4
            pageForward(currentChapter, 4)
        ElseIf currentChapter = 6 And currentPage = 7

            pageForward(currentChapter, 7)
        ElseIf currentChapter = 6 And currentPage = 9
            pageForward(currentChapter, 9)
        ElseIf currentChapter = 6 And currentPage = 13
            pageForward(currentChapter, 13)
        Else




            pageForward(currentChapter, currentPage)
        End If
    End Sub

    Private Sub Storyboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        connect()
        pageForward(currentChapter, currentPage) 'by default, always get chapter 0 page 0
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        'Dimension skip
        If currentChapter = 1 And currentPage = 11 Then
            currentChapter += 1
            currentPage = 1
        ElseIf currentChapter = 2 And (currentPage = 22 Or currentPage = 16 Or currentPage = 20) Then
            currentChapter += 1
            currentPage = 1
        ElseIf currentChapter = 3 And (currentPage = 10 Or currentPage = 15 Or currentPage = 9) Then
            currentChapter += 1
            currentPage = 1
        ElseIf currentChapter = 4 And (currentPage = 5 Or currentPage = 12) Then
            currentChapter += 1
            currentPage = 1
        ElseIf currentChapter = 5 And (currentPage = 4 Or currentPage = 7 Or currentPage = 10 Or currentPage = 13) Then
            currentChapter += 1
            currentPage = 1
        ElseIf currentChapter = 6 And (currentPage = 15 Or currentPage = 14 Or currentPage = 11 Or currentPage = 8 Or currentPage = 5) Then
            Ending.Show()
            Me.Close()

        End If

        pageForward(currentChapter, currentPage)
    End Sub

    Private Sub tmrCharPrint_Tick(sender As Object, e As EventArgs) Handles tmrCharPrint.Tick
        Arceus.printText(Text)
    End Sub
End Class