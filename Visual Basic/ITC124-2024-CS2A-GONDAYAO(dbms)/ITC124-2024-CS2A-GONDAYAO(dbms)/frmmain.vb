Imports ITC124_2024_CS2A_GONDAYAO_dbms_.Class1
Public Class frmmain
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Left = (Me.Width - Label1.Width) \ 2
        Label1.Top = ((Me.Height - Label1.Height) \ 2) - 74
        Label2.Left = (Me.Width - Label1.Width) \ 2 - 60
        Label2.Top = ((Me.Height - Label1.Height) \ 2)


        If logintype = "USER" Then
            AccountsToolStripMenuItem.Visible = False
            EquipmentsToolStripMenuItem.Visible = False
            TicketsToolStripMenuItem.Visible = True
        ElseIf logintype = "TECHNICAL" Then
            AccountsToolStripMenuItem.Visible = False
            EquipmentsToolStripMenuItem.Visible = True
            TicketsToolStripMenuItem.Visible = True
        Else
            AccountsToolStripMenuItem.Visible = True
            EquipmentsToolStripMenuItem.Visible = True
            TicketsToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.txtusername.Clear()
        frmLogin.txtpassword.Clear()
        frmLogin.txtusername.Select()
        frmLogin.Show()
    End Sub

    Dim openAccountFormCount As Integer = 0
    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        Dim accountfrm As New frmaccounts
        accountfrm.MdiParent = Me
        AddHandler accountfrm.FormClosed, AddressOf AccountFormClosed
        accountfrm.Show()
        accountfrm.TopMost = True
        Label1.SendToBack()
        Label2.SendToBack()

        openAccountFormCount += 1
    End Sub

    Private Sub AccountFormClosed(sender As Object, e As FormClosedEventArgs)
        openAccountFormCount -= 1

        If openAccountFormCount = 0 Then
            Label1.BringToFront()
            Label2.BringToFront()
        End If
    End Sub

    Private Sub ManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagementToolStripMenuItem.Click
        ManagementToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub ManagementToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ManagementToolStripMenuItem.DropDownClosed
        ManagementToolStripMenuItem.ForeColor = Color.White
    End Sub


    Private Sub frmmain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmLogin.txtusername.Clear()
        frmLogin.txtpassword.Clear()
        frmLogin.txtusername.Select()
        frmLogin.Show()
    End Sub
End Class