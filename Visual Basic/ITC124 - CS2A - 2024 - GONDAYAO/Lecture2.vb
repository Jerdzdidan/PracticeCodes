Public Class frmLecture2
    Private Sub frmLecture2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtinput1.Select()

    End Sub

    Dim n1, n2, result As Double
    Dim errorcount As Integer

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtinput1.Clear()
        txtinput2.Clear()
        txtresult.Clear()
        txtinput1.Select()
    End Sub

    Private Sub clearError()
        errorcount = 0
        ErrorProvider1.Clear()
    End Sub
    Private Sub validateInput1(txtinp)
        ' validating input1
        If String.IsNullOrEmpty(txtinp.Text) Then
            ErrorProvider1.SetError(txtinp, "Input is Empty")
            errorcount = errorcount + 1
            txtresult.Clear()
        ElseIf Not IsNumeric(txtinp.Text) Then
            ErrorProvider1.SetError(txtinp, "Input is not numeric")
            errorcount = errorcount + 1
            txtresult.Clear()
        Else
            n1 = Double.Parse(txtinp.Text)
        End If
    End Sub
    Private Sub validateInput2()
        If String.IsNullOrEmpty(txtinput2.Text) Then
            ErrorProvider1.SetError(txtinput2, "Input is Empty")
            errorcount = errorcount + 1
            txtresult.Clear()
        ElseIf Not IsNumeric(txtinput2.Text) Then
            ErrorProvider1.SetError(txtinput2, "Input is not numeric")
            errorcount = errorcount + 1
            txtresult.Clear()
        Else
            n2 = Double.Parse(txtinput2.Text)
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        clearError()
        validateInput1(txtinput1)
        validateInput2()

        If errorcount = 0 Then
            'process
            result = n1 + n2
            'output
            txtresult.Text = result.ToString
        End If

    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        clearError()
        validateInput1(txtinput1)
        validateInput2()

        If errorcount = 0 Then
            'process
            result = n1 - n2

            'output
            txtresult.Text = result.ToString
        End If

    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        clearError()
        validateInput1(txtinput1)
        validateInput2()

        If errorcount = 0 Then
            'process
            result = n1 * n2

            'output
            txtresult.Text = result.ToString
        End If

    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        clearError()
        validateInput1(txtinput1)
        validateInput2()

        If errorcount = 0 Then
            'process
            result = n1 / n2

            'output
            txtresult.Text = result.ToString
        End If

    End Sub
End Class