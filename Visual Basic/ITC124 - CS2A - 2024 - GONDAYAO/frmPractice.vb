Public Class frmPractice
    Private Sub frmPractice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtadj.Select()
    End Sub

    Dim adj, opp, hyp, sin, cos, tan, result As Double
    Dim errorcount As Integer

    Private Sub clearOutput()
        sineOutput.Clear()
        cosOutput.Clear()
        tanOutput.Clear()
    End Sub
    Private Sub clearError()
        errorcount = 0
        ErrorProvider1.Clear()
    End Sub

    Private Sub validateAdj()
        If String.IsNullOrEmpty(txtadj.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtadj, "Input is empty.")

            txtadj.Clear()
            clearOutput()
            txtadj.Select()
        ElseIf Not IsNumeric(txtadj.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtadj, "Input must be a number.")

            txtadj.Clear()
            clearOutput()
            txtadj.Select()
        ElseIf Double.Parse(txtadj.Text) < 0 Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtadj, "Input must be a positive number.")

            txtadj.Clear()
            clearOutput()
            txtadj.Select()
        Else
            adj = Double.Parse(txtadj.Text)
        End If
    End Sub
    Private Sub validateOpp()
        If String.IsNullOrEmpty(txtopp.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtopp, "Input is empty.")

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        ElseIf Not IsNumeric(txtopp.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtopp, "Input must be a number.")

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        ElseIf Double.Parse(txtopp.Text) < 0 Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txtopp, "Input must be a positive number.")

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        Else
            opp = Double.Parse(txtopp.Text)
        End If
    End Sub
    Private Sub validateHyp()
        If String.IsNullOrEmpty(txthyp.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txthyp, "Input is empty.")

            txthyp.Clear()
            txthyp.Select()
        ElseIf Not IsNumeric(txthyp.Text) Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txthyp, "Input must be a number.")

            txthyp.Clear()
            txthyp.Select()
        ElseIf Double.Parse(txthyp.Text) < 0 Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txthyp, "Input must be a positive number.")

            txthyp.Clear()
            txthyp.Select()
        ElseIf Double.Parse(txthyp.Text) < opp Or Double.Parse(txthyp.Text) < adj Then
            errorcount = errorcount + 1
            ErrorProvider1.SetError(txthyp, "Hypotenuse must be greater than either the Opposite side or Adjacent Side.")

            txthyp.Clear()
            txthyp.Select()
        Else
            hyp = Double.Parse(txthyp.Text)
        End If
    End Sub

    Private Sub btnSine_Click(sender As Object, e As EventArgs) Handles btnSine.Click
        clearError()
        validateOpp()
        validateHyp()

        If errorcount = 0 And hyp >= opp Then
            result = opp / hyp
            sineOutput.Text = result.ToString()
        End If
    End Sub

    Private Sub btnCosine_Click(sender As Object, e As EventArgs) Handles btnCosine.Click
        clearError()
        validateAdj()
        validateHyp()

        If errorcount = 0 And hyp >= adj Then
            result = adj / hyp
            cosOutput.Text = result.ToString()
        End If
    End Sub

    Private Sub btnTangent_Click(sender As Object, e As EventArgs) Handles btnTangent.Click
        clearError()
        validateAdj()
        validateOpp()

        If errorcount = 0 Then
            result = opp / adj
            tanOutput.Text = result.ToString()
        End If
    End Sub

    Private Sub btnComputeAll_Click(sender As Object, e As EventArgs) Handles btnComputeAll.Click
        clearError()
        validateAdj()
        validateOpp()

        If errorcount = 0 Then
            tan = opp / adj
            tanOutput.Text = tan.ToString()
        End If

        validateHyp()

        If errorcount = 0 And (hyp >= opp And hyp >= adj) Then
            sin = opp / hyp
            cos = adj / hyp
            sineOutput.Text = sin.ToString()
            cosOutput.Text = cos.ToString()
        End If
    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        txtadj.Clear()
        txtopp.Clear()
        txthyp.Clear()
        sineOutput.Clear()
        cosOutput.Clear()
        tanOutput.Clear()
        txtadj.Select()
    End Sub
End Class