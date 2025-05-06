Imports ITC124_2024_CS2A_GONDAYAO_dbms_.Class1

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim errorcount As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        errorcount = 0
        ErrorProvider1.Clear()

        If String.IsNullOrEmpty(txtusername.Text) Then
            ErrorProvider1.SetError(txtusername, "Username is empty")
            errorcount = errorcount + 1
        End If

        If String.IsNullOrEmpty(txtpassword.Text) Then
            ErrorProvider1.SetError(txtpassword, "Password is empty")
            errorcount = errorcount + 1
        End If

        If errorcount = 0 Then
            Try
                DSRec.Clear()
                DSRec = GetDataTable("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "' AND status = 'ACTIVE'")
                If DSRec.Rows.Count > 0 Then
                    frmmain.lblusername.Text = "Username: " + txtusername.Text
                    frmmain.lblusertype.Text = "Usertype: " + DSRec.Rows(0).Item(2).ToString
                    loginuser = txtusername.Text
                    logintype = DSRec.Rows(0).Item(2).ToString
                    frmmain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Login Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ErrorProvider1.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Select()
    End Sub

    Private Sub cbshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpassword.CheckedChanged
        If cbshowpassword.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub
End Class