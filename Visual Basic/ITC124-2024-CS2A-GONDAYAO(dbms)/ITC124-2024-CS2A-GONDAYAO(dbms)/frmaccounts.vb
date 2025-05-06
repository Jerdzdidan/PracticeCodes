Imports ITC124_2024_CS2A_GONDAYAO_dbms_.Class1

Public Class frmaccounts
    Private bindingSource As New BindingSource()
    Public Sub formRefresh()
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT username, usertype, status, createdby, datecreated FROM tblaccounts WHERE username <> '" +
                                 loginuser + "' ORDER BY username")
            DataGridView1.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on Form Accounts Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared frmInstance As frmaccounts
    Private Sub frmaccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmInstance = Me
        formRefresh()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        formRefresh()
    End Sub

    Dim selectedUser, selectedType, selectedDate As String
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedUser = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        selectedType = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        selectedDate = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
    End Sub

    Private Sub btndeactivate_Click(sender As Object, e As EventArgs) Handles btndeactivate.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to deactivate this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = DialogResult.Yes Then
                executeSQL("UPDATE tblaccounts SET status = 'INACTIVE' WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Deactivated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmaccounts_Load(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on Deactivate Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnactivate_Click(sender As Object, e As EventArgs) Handles btnactivate.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to activate this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = DialogResult.Yes Then
                executeSQL("UPDATE tblaccounts SET status = 'ACTIVE' WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Activated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmaccounts_Load(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on Activate Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to delete this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = DialogResult.Yes Then
                executeSQL("DELETE FROM tblaccounts WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmaccounts_Load(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on Activate Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT username, usertype, status, createdby, datecreated FROM tblaccounts WHERE username <> '" +
                 loginuser + "' AND (username LIKE '%" + txtsearch.Text + "%' OR usertype LIKE '%" + txtsearch.Text + "%') ORDER BY username")
            DataGridView1.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on txtsearch_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmaddaccount.Label4.Text = "ADD ACCOUNT"
        frmaddaccount.Text = "Add new account"
        frmaddaccount.txtusername.Clear()
        frmaddaccount.txtpassword.Clear()
        frmaddaccount.txtdatecreated.Clear()
        frmaddaccount.cbshowpassword.Checked = False
        frmaddaccount.txtdatecreated.Text = todaysdate
        frmaddaccount.cmbusertype.SelectedIndex = -1
        action = "add"
        frmaddaccount.Show()

        frmaddaccount.txtdatecreated.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        frmaddaccount.Label4.Text = "EDIT ACCOUNT"
        frmaddaccount.Text = "Edit account"
        frmaddaccount.txtusername.Text = selectedUser
        frmaddaccount.txtdatecreated.Text = selectedDate
        frmaddaccount.txtpassword.Clear()
        frmaddaccount.cbshowpassword.Checked = False

        If selectedType = "ADMINISTRATOR" Then
            frmaddaccount.cmbusertype.SelectedIndex = 0
        ElseIf selectedType = "TECHNICAL" Then
            frmaddaccount.cmbusertype.SelectedIndex = 1
        Else
            frmaddaccount.cmbusertype.SelectedIndex = 2
        End If

        frmaddaccount.txtusername.Enabled = False
        frmaddaccount.txtdatecreated.Enabled = False
        action = "edit"
        frmaddaccount.Show()
    End Sub


End Class