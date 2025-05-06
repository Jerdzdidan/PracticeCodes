Public Class frmLecture3
    Private Sub frmLecture3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtinput.Select()
    End Sub

    Dim input, errorcount As Integer

    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        errorcount = 0
        ErrorProvider1.Clear()

        If String.IsNullOrEmpty(txtinput.Text) Then
            ErrorProvider1.SetError(txtinput, "Input is Empty")
            errorcount = errorcount + 1
        ElseIf Not IsNumeric(txtinput.Text) Then
            ErrorProvider1.SetError(txtinput, "Input is not numeric")
            errorcount = errorcount + 1
        Else
            input = Double.Parse(txtinput.Text)
        End If

        If errorcount = 0 Then
            If input > 0 Then
                MessageBox.Show("Input is a positive number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf input < 0 Then
                MessageBox.Show("Input is a negative number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Input is 0", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub
End Class