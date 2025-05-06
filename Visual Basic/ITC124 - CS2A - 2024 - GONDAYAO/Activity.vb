Public Class Activity
    Private Sub Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim adjacent, hypotenuse, opposite, sin, cosine, tangent As Double
    Dim errorcount As Integer
    Private Sub clearError()
        errorcount = 0
        ErrorProvider1.Clear()
    End Sub
    Private Sub validateAdjacent()
        If String.IsNullOrEmpty(txtAdjacent.Text) Then
            ErrorProvider1.SetError(txtAdjacent, "Input is empty")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        ElseIf Not IsNumeric(txtAdjacent.Text) Then
            ErrorProvider1.SetError(txtAdjacent, "Input is not Numeric")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        Else
            adjacent = Double.Parse(txtAdjacent.Text)
        End If
    End Sub
    Private Sub validateOpposite()
        If String.IsNullOrEmpty(txtopposite.Text) Then
            ErrorProvider1.SetError(txtopposite, "Input is empty")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        ElseIf Not IsNumeric(txtopposite.Text) Then
            ErrorProvider1.SetError(txtopposite, "Input is not Numeric")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        Else
            opposite = Double.Parse(txtopposite.Text)

        End If
    End Sub
    Private Sub validateHypotenuse()
        If String.IsNullOrEmpty(txthypo.Text) Then
            ErrorProvider1.SetError(txthypo, "Input is empty")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        ElseIf Not IsNumeric(txthypo.Text) Then
            ErrorProvider1.SetError(txthypo, "Input is not Numeric")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        ElseIf Double.Parse(txthypo.Text) < adjacent Then
            ErrorProvider1.SetError(txthypo, "Hypotenuse < Adjacent")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        ElseIf Double.Parse(txthypo.Text) < opposite Then
            ErrorProvider1.SetError(txthypo, "Hypotenuse < Opposite")
            errorcount = errorcount + 1
            txtsine.Clear()
            txtcos.Clear()
            txttangent.Clear()
        Else
            hypotenuse = Double.Parse(txthypo.Text)
        End If
    End Sub
    Private Sub btnsin_Click(sender As Object, e As EventArgs) Handles btnsin.Click
        clearError()
        validateOpposite()
        validateAdjacent()
        validateHypotenuse()

        If errorcount = 0 And (hypotenuse > opposite And hypotenuse > adjacent) Then
            sin = opposite / hypotenuse
            txtsine.Text = sin.ToString
        End If
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        clearError()
        validateAdjacent()
        validateOpposite()
        validateHypotenuse()

        If errorcount = 0 And (hypotenuse > opposite And hypotenuse > adjacent) Then
            cosine = adjacent / hypotenuse
            txtcos.Text = cosine.ToString
        End If
    End Sub
    Private Sub btntan_Click(sender As Object, e As EventArgs) Handles btntan.Click
        clearError()
        validateAdjacent()
        validateOpposite()
        validateHypotenuse()

        If errorcount = 0 And (hypotenuse > opposite And hypotenuse > adjacent) Then
            tangent = opposite / adjacent
            txttangent.Text = tangent.ToString
        End If
    End Sub
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        clearError()
        validateAdjacent()
        validateOpposite()
        validateHypotenuse()

        If errorcount = 0 And (hypotenuse > opposite And hypotenuse > adjacent) Then
            tangent = opposite / adjacent
            txttangent.Text = tangent.ToString

            cosine = adjacent / hypotenuse
            txtcos.Text = cosine.ToString

            sin = opposite / hypotenuse
            txtsine.Text = sin.ToString
        End If
    End Sub
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtAdjacent.Clear()
        txthypo.Clear()
        txtopposite.Clear()
        txtsine.Clear()
        txtcos.Clear()
        txttangent.Clear()
    End Sub
End Class