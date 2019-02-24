Public Class Ending
    Public timermarker As Integer
    Public prints(99)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If timermarker = 0 Then
            If Arceus.r1 >= 1 Then
                Label1.Text = prints(4)
            Else
                Label1.Text = prints(5)
            End If
        End If

        If timermarker = 2 Then
            If Arceus.r2 >= 1 Then
                Label1.Text = prints(10)
            Else
                Label1.Text = prints(11)
            End If
        End If

        If timermarker = 4 Then
            If Arceus.r3 >= 3 Then
                Label1.Text = prints(2)
            Else
                Label1.Text = prints(3)
            End If
        End If

        If timermarker = 6 Then
            If Arceus.r4 >= 1 Then
                Label1.Text = prints(8)
            Else
                Label1.Text = prints(9)
            End If
        End If


        If timermarker = 8 Then
            If Arceus.r5 >= 3 Then
                Label1.Text = prints(6)
            Else
                Label1.Text = prints(7)
            End If
        End If


        If timermarker = 10 Then
            If Arceus.r6 >= 3 Then
                Label1.Text = prints(0)
            Else
                Label1.Text = prints(1)
            End If
        End If
        timermarker += 1
    End Sub

    Private Sub Ending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(r6)
        Timer1.Enabled = True
        prints(0) = "Congratulations, You have won bluehacks competition thanks to your good occupational wellness decision making. You are set for a bright career future!"
        prints(1) = " You've made some poor decisions leading to bad occupational wellness which can ultimately lead to poor career decision making and an unbalanced work and leisure management. 
Social"
        prints(2) = "You have stayed in touch and socially interacted with your friend Patrick."
        prints(3) = "You might have lost your friend Patrick."
        prints(4) = " You have been physically active and enjoyed a healthy body.Health is Wealth!"
        prints(5) = "You were not physically active thus you might be prone to illnesses."
        prints(6) = "Listening to others and being open about their beliefs are one way to achieve inner peace along with spiritual wellness and you seccesfully did that "
        prints(7) = "Being narrow minded doesnt really give you alot spiritually. Acceptance is key."
        prints(8) = "Stood up to the quiz's challenge, learned something new, became a little smarter."
        prints(9) = "Passed up the quiz, a quiz not taken is also a knowledge wasted."
        prints(10) = "Have stayed calm under pressure and succesfully controlled your emotions, you are emotionally well"
        prints(11) = "You lost the game and some friends. You should control your emotions, not your emotions controlling you."
    End Sub
End Class