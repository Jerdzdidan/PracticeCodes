Imports ITC124_2024_CS2A_GONDAYAO_dbms_.Class1
Public Class frmaddaccount
    Dim errorCount As Integer
    Public Sub validateForm()
        ErrorProvider1.Clear()

        If txtusername.Text = "" Then
            ErrorProvider1.SetError(txtusername, "Username is required")
        End If
        If txtpassword.TextLength < 6 Then
            ErrorProvider1.SetError(txtpassword, "Password should be 6 characters or more")
        End If
        If cmbusertype.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbusertype, "Usertype is required")
        End If
        If action = "add" Then
            Try
                DSRec.Clear()
                DSRec = GetDataTable("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "'")
                If DSRec.Rows.Count > 0 Then
                    ErrorProvider1.SetError(txtusername, "Username is already in use")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If frmaccounts.frmInstance IsNot Nothing Then
            frmaccounts.frmInstance.formRefresh()
        End If
    End Sub

    Public Sub countErrors()
        errorcount = 0
        For Each obj As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(obj) <> "" Then
                errorCount += 1
            End If
        Next
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        validateForm()
        countErrors()

        If errorCount = 0 Then
            If action = "add" Then
                Try
                    executeSQL("INSERT INTO tblaccounts (username, password, usertype, status, createdby, datecreated) VALUES ('" + txtusername.Text + "','" +
                               txtpassword.Text + "','" + cmbusertype.Text + "','ACTIVE','" + loginuser + "','" + txtdatecreated.Text + "')")
                    If rowAffected > 0 Then
                        MessageBox.Show("New Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If frmaccounts.frmInstance IsNot Nothing Then
                            frmaccounts.frmInstance.formRefresh()
                        End If
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(add)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    executeSQL("UPDATE tblaccounts SET password = '" + txtpassword.Text + "', usertype = '" + cmbusertype.Text + "' WHERE username = '" +
                           txtusername.Text + "'")
                    If rowAffected > 0 Then
                        MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If frmaccounts.frmInstance IsNot Nothing Then
                            frmaccounts.frmInstance.formRefresh()
                        End If
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(edit)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If

    End Sub

    Private Sub cbshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpassword.CheckedChanged
        If cbshowpassword.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        If action = "add" Then
            txtusername.Clear()
            txtpassword.Clear()
            txtdatecreated.Clear()
            cmbusertype.SelectedIndex = -1
        Else
            txtpassword.Clear()
        End If
        ErrorProvider1.Clear()
    End Sub


End Class