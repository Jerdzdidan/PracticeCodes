Public Class frmMrecitation1
    Private Sub frmMrecitation1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtopp.Select()
    End Sub


    Dim oppositeSide, adjacentSide, hypotenuseSide, result, sine, cos, tan As Double
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
            ErrorProvider1.SetError(txtadj, "Input is Empty")
            errorcount = errorcount + 1

            txtadj.Clear()
            clearOutput()
            txtadj.Select()
        ElseIf Not IsNumeric(txtadj.Text) Then
            ErrorProvider1.SetError(txtadj, "Input is not numeric")
            errorcount = errorcount + 1

            txtadj.Clear()
            clearOutput()
            txtadj.Select()
        Else
            adjacentSide = Double.Parse(txtadj.Text)
            If adjacentSide < 0 Then
                ErrorProvider1.SetError(txtadj, "Input must be a positive number")
                MessageBox.Show("Input in Adjacent Side must be a positive number", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                errorcount = errorcount + 1

                txtadj.Clear()
                clearOutput()
                txtadj.Select()
            End If
        End If
    End Sub
    Private Sub validateOpp()
        If String.IsNullOrEmpty(txtopp.Text) Then
            ErrorProvider1.SetError(txtopp, "Input is Empty")
            errorcount = errorcount + 1

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        ElseIf Not IsNumeric(txtopp.Text) Then
            ErrorProvider1.SetError(txtopp, "Input is not numeric")
            errorcount = errorcount + 1

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        ElseIf Double.Parse(txtopp.Text) < 0 Then
            ErrorProvider1.SetError(txtopp, "Input must be a positive number")
            MessageBox.Show("Input in Opposite Side must be a positive number", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            errorcount = errorcount + 1

            txtopp.Clear()
            clearOutput()
            txtopp.Select()
        Else
            oppositeSide = Double.Parse(txtopp.Text)
        End If
    End Sub
    Private Sub validateHyp()
        If String.IsNullOrEmpty(txthyp.Text) Then
            ErrorProvider1.SetError(txthyp, "Input is Empty")
            errorcount = errorcount + 1

            txthyp.Clear()
            clearOutput()
            txthyp.Select()
        ElseIf Not IsNumeric(txthyp.Text) Then
            ErrorProvider1.SetError(txthyp, "Input is not numeric")
            errorcount = errorcount + 1

            txthyp.Clear()
            clearOutput()
            txthyp.Select()
        ElseIf Double.Parse(txthyp.Text) < 0 Then
            ErrorProvider1.SetError(txthyp, "Input must be a positive number")
            MessageBox.Show("Input in Hypotenuse Side must be a positive number", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            errorcount = errorcount + 1

            txthyp.Clear()
            clearOutput()
            txthyp.Select()
        Else
            hypotenuseSide = Double.Parse(txthyp.Text)
            If hypotenuseSide < oppositeSide Or hypotenuseSide < adjacentSide Then
                ErrorProvider1.SetError(txthyp, "Hypotenuse should greater than the Adjacent or Opposite Side")
                MessageBox.Show("Hypotenuse should be greater than the Adjacent or Opposite Side",
                                "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                errorcount = errorcount + 1

                txthyp.Clear()
                clearOutput()
                txthyp.Select()
            End If
        End If
    End Sub
    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        clearError()
        txtopp.Clear()
        txtadj.Clear()
        txthyp.Clear()
        sineOutput.Clear()
        cosOutput.Clear()
        tanOutput.Clear()
        txtopp.Select()
    End Sub

    Private Sub btnSine_Click(sender As Object, e As EventArgs) Handles btnSine.Click
        clearError()
        validateOpp()
        validateHyp()

        If errorcount = 0 And hypotenuseSide >= oppositeSide Then
            result = oppositeSide / hypotenuseSide
            sineOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnCosine_Click(sender As Object, e As EventArgs) Handles btnCosine.Click
        clearError()
        validateAdj()
        validateHyp()

        If errorcount = 0 And hypotenuseSide >= adjacentSide Then
            result = adjacentSide / hypotenuseSide
            cosOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnTangent_Click(sender As Object, e As EventArgs) Handles btnTangent.Click
        clearError()
        validateAdj()
        validateOpp()

        If errorcount = 0 Then
            result = oppositeSide / adjacentSide
            tanOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnComputeAll_Click(sender As Object, e As EventArgs) Handles btnComputeAll.Click
        clearError()
        validateOpp()
        validateAdj()
        validateHyp()

        If errorcount = 0 And (hypotenuseSide >= oppositeSide And hypotenuseSide >= adjacentSide) Then
            sine = oppositeSide / hypotenuseSide
            cos = adjacentSide / hypotenuseSide
            tan = oppositeSide / adjacentSide

            sineOutput.Text = sine.ToString
            cosOutput.Text = cos.ToString
            tanOutput.Text = tan.ToString
        End If

    End Sub

End Class