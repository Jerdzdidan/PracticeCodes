Public Class frmActivity1

    Private Sub frmActivity1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtopp.Select()
    End Sub

    Dim oppositeSide, adjacentSide, hypotenuseSide, result, sine, cos, tan As Double

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
        oppositeSide = Double.Parse(txtopp.Text)
        hypotenuseSide = Double.Parse(txthyp.Text)

        result = oppositeSide / hypotenuseSide

        sineOutput.Text = result.ToString
    End Sub

    Private Sub btnCosine_Click(sender As Object, e As EventArgs) Handles btnCosine.Click
        adjacentSide = Double.Parse(txtadj.Text)
        hypotenuseSide = Double.Parse(txthyp.Text)

        result = adjacentSide / hypotenuseSide
        cosOutput.Text = result.ToString
    End Sub

    Private Sub btnTangent_Click(sender As Object, e As EventArgs) Handles btnTangent.Click
        oppositeSide = Double.Parse(txtopp.Text)
        adjacentSide = Double.Parse(txtadj.Text)

        result = oppositeSide / adjacentSide
        tanOutput.Text = result.ToString
    End Sub

    Private Sub btnComputeAll_Click(sender As Object, e As EventArgs) Handles btnComputeAll.Click
        oppositeSide = Double.Parse(txtopp.Text)
        adjacentSide = Double.Parse(txtadj.Text)
        hypotenuseSide = Double.Parse(txthyp.Text)

        sine = oppositeSide / hypotenuseSide
        cos = adjacentSide / hypotenuseSide
        tan = oppositeSide / adjacentSide

        sineOutput.Text = sine.ToString
        cosOutput.Text = cos.ToString
        tanOutput.Text = tan.ToString
    End Sub
End Class