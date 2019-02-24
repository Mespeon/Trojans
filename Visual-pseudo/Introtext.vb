Public Class Introtext
    Public ending1 = 0
    Private Sub Introtext_ContextMenuChanged(sender As Object, e As EventArgs) Handles Me.ContextMenuChanged

    End Sub

    Private Sub Introtext_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Enabled = False
        Me.Opacity = 1
        ending1 = 1
        wordlighter.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Introductory.ctr2 += 1
        ending1 = 0
        wordlighter.Start()
        Label1.Enabled = False
    End Sub

    Private Sub worddimmer_Tick(sender As Object, e As EventArgs) Handles worddimmer.Tick
        If Me.Opacity >= 1 Then
            Me.Opacity -= 0.01
        Else
            wordlighter.Start()
            worddimmer.Stop()
        End If
    End Sub

    Private Sub wordlighter_Tick(sender As Object, e As EventArgs) Handles wordlighter.Tick
        wordlighter.Interval = 1
        If ending1 = 0 Then
            Me.Opacity += 0.015
            If Me.Opacity >= 1 Then
                Introductory.Label1.Text = Introductory.dialogue(Introductory.ctr2)
                Introductory.ctr2 += 1
                If Introductory.ctr2 >= Introductory.dialogue.Count Then
                    Me.TopMost = False
                    Me.Close()
                    Introductory.Close()
                    wordlighter.Stop()
                    Storyboard.Show()
                End If
                wordlighter.Interval = 500
                ending1 = 1
            End If
        Else

            Me.Opacity -= 0.015
            If Me.Opacity <= 0 Then
                wordlighter.Interval = 500
                ending1 = 0
            End If


        End If
        ' If Me.Opacity = 1 = False Then
        'Label1.Enabled = False
        ' Me.Opacity += 0.01
        ' Else

        ' Label1.Enabled = True
        'worddimmer.Stop()
        'wordlighter.Stop()
        ' End If
    End Sub
End Class