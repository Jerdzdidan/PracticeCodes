Public Class Activity2
    Private Sub Activity2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtopp.Select()
    End Sub

    Dim oppositeSide, adjacentSide, hypotenuseSide, result, sine, cos, tan As Double
    Dim errorcount As Integer

    Private Sub clearError()
        errorcount = 0
        ErrorProvider1.Clear()
    End Sub
    Private Sub validateAdj()
        If String.IsNullOrEmpty(txtadj.Text) Then
            ErrorProvider1.SetError(txtadj, "Input is Empty")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
            txtopp.Select()
        ElseIf Not IsNumeric(txtadj.Text) Then
            ErrorProvider1.SetError(txtadj, "Input is not numeric")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        Else
            adjacentSide = Double.Parse(txtadj.Text)
        End If
    End Sub
    Private Sub validateOpp()
        If String.IsNullOrEmpty(txtopp.Text) Then
            ErrorProvider1.SetError(txtopp, "Input is Empty")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        ElseIf Not IsNumeric(txtopp.Text) Then
            ErrorProvider1.SetError(txtopp, "Input is not numeric")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        Else
            oppositeSide = Double.Parse(txtopp.Text)
        End If
    End Sub
    Private Sub validateHyp()
        If String.IsNullOrEmpty(txthyp.Text) Then
            ErrorProvider1.SetError(txthyp, "Input is Empty")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        ElseIf Not IsNumeric(txthyp.Text) Then
            ErrorProvider1.SetError(txthyp, "Input is not numeric")
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        ElseIf Double.Parse(txthyp.Text) < oppositeSide Then
            ErrorProvider1.SetError(txthyp, "Hypotenuse should be greater than the Opposite Side")
            MessageBox.Show("Hypotenuse should be greater than the Opposite Side", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        ElseIf Double.Parse(txthyp.Text) < adjacentSide Then
            ErrorProvider1.SetError(txthyp, "Hypotenuse should greater than the Adjacent Side")
            MessageBox.Show("Hypotenuse should be greater than the Adjacent Side", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            errorcount = errorcount + 1
            sineOutput.Clear()
            cosOutput.Clear()
            tanOutput.Clear()
        Else
            hypotenuseSide = Double.Parse(txthyp.Text)
        End If
    End Sub
    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
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
        validateAdj()
        validateHyp()

        If errorcount = 0 And (hypotenuseSide >= oppositeSide And hypotenuseSide >= adjacentSide) Then
            result = oppositeSide / hypotenuseSide
            sineOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnCosine_Click(sender As Object, e As EventArgs) Handles btnCosine.Click
        clearError()
        validateOpp()
        validateAdj()
        validateHyp()

        If errorcount = 0 And (hypotenuseSide >= oppositeSide And hypotenuseSide >= adjacentSide) Then
            result = adjacentSide / hypotenuseSide
            cosOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnTangent_Click(sender As Object, e As EventArgs) Handles btnTangent.Click
        clearError()
        validateAdj()
        validateOpp()
        validateHyp()

        If errorcount = 0 And (hypotenuseSide >= oppositeSide And hypotenuseSide >= adjacentSide) Then
            result = oppositeSide / adjacentSide
            tanOutput.Text = result.ToString
        End If

    End Sub

    Private Sub btnComputeAll_Click(sender As Object, e As EventArgs) Handles btnComputeAll.Click
        clearError()
        validateAdj()
        validateOpp()
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

