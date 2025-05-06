Public Class frmLecture1

    Private Sub frmLecture1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtinput1.Select()

    End Sub

    Dim n1, n2, result As Integer

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        txtinput1.Clear()
        txtinput2.Clear()
        txtresult.Clear()
        txtinput1.Select()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'input
        n1 = Integer.Parse(txtinput1.Text)
        n2 = Integer.Parse(txtinput2.Text)

        'process
        result = n1 + n2

        'output
        txtresult.Text = result.ToString

    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        'input
        n1 = Integer.Parse(txtinput1.Text)
        n2 = Integer.Parse(txtinput2.Text)

        'process
        result = n1 - n2

        'output
        txtresult.Text = result.ToString

    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        'input
        n1 = Integer.Parse(txtinput1.Text)
        n2 = Integer.Parse(txtinput2.Text)

        'process
        result = n1 * n2

        'output
        txtresult.Text = result.ToString

    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        'input
        n1 = Integer.Parse(txtinput1.Text)
        n2 = Integer.Parse(txtinput2.Text)

        'process
        result = n1 / n2

        'output
        txtresult.Text = result.ToString

    End Sub

End Class
