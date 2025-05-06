Public Class JDAPP
    Private Sub JDAPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim player, computer, win As Integer

    Private random As New Random()

    Private Sub rockP_Click(sender As Object, e As EventArgs) Handles rockP.Click
        player = 1
        rockP.BackColor = Color.Red
        paperP.BackColor = Color.Transparent
        scissorP.BackColor = Color.Transparent
    End Sub
    Private Sub paperP_Click(sender As Object, e As EventArgs) Handles paperP.Click
        player = 2
        paperP.BackColor = Color.Red
        rockP.BackColor = Color.Transparent
        scissorP.BackColor = Color.Transparent
    End Sub
    Private Sub scissorP_Click(sender As Object, e As EventArgs) Handles scissorP.Click
        player = 3
        scissorP.BackColor = Color.Red
        rockP.BackColor = Color.Transparent
        paperP.BackColor = Color.Transparent
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        computer = random.Next(1, 4)
        If computer = 1 Then
            rockC.BackColor = Color.Red
        ElseIf computer = 2 Then
            paperC.BackColor = Color.Red
        ElseIf computer = 3 Then
            scissorC.BackColor = Color.Red
        End If

        If player = 1 And computer = 1 Then
            win = 0
        ElseIf player = 1 And computer = 2 Then
            win = 2
        ElseIf player = 1 And computer = 3 Then
            win = 1
        End If

        If player = 2 And computer = 1 Then
            win = 1
        ElseIf player = 2 And computer = 2 Then
            win = 0
        ElseIf player = 2 And computer = 3 Then
            win = 2
        End If

        If player = 3 And computer = 1 Then
            win = 2
        ElseIf player = 3 And computer = 2 Then
            win = 1
        ElseIf player = 3 And computer = 3 Then
            win = 0
        End If


        If win = 0 Then
            MsgBox("It is a DRAW!!!")
            player = 0
            rockP.BackColor = Color.Transparent
            paperP.BackColor = Color.Transparent
            scissorP.BackColor = Color.Transparent
            rockC.BackColor = Color.Transparent
            paperC.BackColor = Color.Transparent
            scissorC.BackColor = Color.Transparent
        ElseIf win = 1 Then
            MsgBox("PLAYER WINS!!!")
            player = 0
            rockP.BackColor = Color.Transparent
            paperP.BackColor = Color.Transparent
            scissorP.BackColor = Color.Transparent
            rockC.BackColor = Color.Transparent
            paperC.BackColor = Color.Transparent
            scissorC.BackColor = Color.Transparent
        ElseIf win = 2 Then
            MsgBox("COMPUTER WINS!!!")
            player = 0
            rockP.BackColor = Color.Transparent
            paperP.BackColor = Color.Transparent
            scissorP.BackColor = Color.Transparent
            rockC.BackColor = Color.Transparent
            paperC.BackColor = Color.Transparent
            scissorC.BackColor = Color.Transparent
        End If

    End Sub


End Class