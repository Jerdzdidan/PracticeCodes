<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnSine = New Button()
        btnTangent = New Button()
        btnCosine = New Button()
        Label1 = New Label()
        txtopp = New TextBox()
        Label2 = New Label()
        txtadj = New TextBox()
        Label3 = New Label()
        txthyp = New TextBox()
        Label4 = New Label()
        sineOutput = New TextBox()
        txtClear = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cosOutput = New TextBox()
        Label8 = New Label()
        tanOutput = New TextBox()
        btnComputeAll = New Button()
        SuspendLayout()
        ' 
        ' btnSine
        ' 
        btnSine.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSine.Cursor = Cursors.Hand
        btnSine.Location = New Point(427, 132)
        btnSine.Name = "btnSine"
        btnSine.Size = New Size(110, 44)
        btnSine.TabIndex = 0
        btnSine.Text = "Sine"
        btnSine.UseVisualStyleBackColor = False
        ' 
        ' btnTangent
        ' 
        btnTangent.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnTangent.Cursor = Cursors.Hand
        btnTangent.Location = New Point(659, 132)
        btnTangent.Name = "btnTangent"
        btnTangent.Size = New Size(110, 44)
        btnTangent.TabIndex = 1
        btnTangent.Text = "Tangent"
        btnTangent.UseVisualStyleBackColor = False
        ' 
        ' btnCosine
        ' 
        btnCosine.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnCosine.Cursor = Cursors.Hand
        btnCosine.Location = New Point(543, 132)
        btnCosine.Name = "btnCosine"
        btnCosine.Size = New Size(110, 44)
        btnCosine.TabIndex = 2
        btnCosine.Text = "Cosine"
        btnCosine.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(76, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 3
        Label1.Text = "Opposite Side:"
        ' 
        ' txtopp
        ' 
        txtopp.Location = New Point(76, 139)
        txtopp.Name = "txtopp"
        txtopp.Size = New Size(141, 27)
        txtopp.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(76, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 5
        Label2.Text = "Adjacent Side:"
        ' 
        ' txtadj
        ' 
        txtadj.Location = New Point(76, 213)
        txtadj.Name = "txtadj"
        txtadj.Size = New Size(141, 27)
        txtadj.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(77, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 20)
        Label3.TabIndex = 7
        Label3.Text = "Hypotenuse Side:"
        ' 
        ' txthyp
        ' 
        txthyp.Location = New Point(77, 288)
        txthyp.Name = "txthyp"
        txthyp.Size = New Size(140, 27)
        txthyp.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(76, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 9
        ' 
        ' sineOutput
        ' 
        sineOutput.Enabled = False
        sineOutput.Location = New Point(242, 139)
        sineOutput.Name = "sineOutput"
        sineOutput.Size = New Size(140, 27)
        sineOutput.TabIndex = 10
        ' 
        ' txtClear
        ' 
        txtClear.BackColor = Color.Silver
        txtClear.Cursor = Cursors.Hand
        txtClear.Location = New Point(543, 275)
        txtClear.Name = "txtClear"
        txtClear.Size = New Size(110, 44)
        txtClear.TabIndex = 14
        txtClear.Text = "Clear"
        txtClear.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(181, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(461, 42)
        Label5.TabIndex = 15
        Label5.Text = "Trigonometric Calculator"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(242, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 16
        Label6.Text = "Sine:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(242, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 20)
        Label7.TabIndex = 17
        Label7.Text = "Cosine:"
        ' 
        ' cosOutput
        ' 
        cosOutput.Enabled = False
        cosOutput.Location = New Point(242, 213)
        cosOutput.Name = "cosOutput"
        cosOutput.Size = New Size(140, 27)
        cosOutput.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(242, 265)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 19
        Label8.Text = "Tangent:"
        ' 
        ' tanOutput
        ' 
        tanOutput.Enabled = False
        tanOutput.Location = New Point(242, 288)
        tanOutput.Name = "tanOutput"
        tanOutput.Size = New Size(140, 27)
        tanOutput.TabIndex = 20
        ' 
        ' btnComputeAll
        ' 
        btnComputeAll.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnComputeAll.Cursor = Cursors.Hand
        btnComputeAll.Location = New Point(524, 206)
        btnComputeAll.Name = "btnComputeAll"
        btnComputeAll.Size = New Size(146, 44)
        btnComputeAll.TabIndex = 21
        btnComputeAll.Text = "Compute All"
        btnComputeAll.UseVisualStyleBackColor = False
        ' 
        ' frmActivity1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnComputeAll)
        Controls.Add(tanOutput)
        Controls.Add(Label8)
        Controls.Add(cosOutput)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtClear)
        Controls.Add(sineOutput)
        Controls.Add(Label4)
        Controls.Add(txthyp)
        Controls.Add(Label3)
        Controls.Add(txtadj)
        Controls.Add(Label2)
        Controls.Add(txtopp)
        Controls.Add(Label1)
        Controls.Add(btnCosine)
        Controls.Add(btnTangent)
        Controls.Add(btnSine)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmActivity1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Activity 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSine As Button
    Friend WithEvents btnTangent As Button
    Friend WithEvents btnCosine As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtopp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtadj As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txthyp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sineOutput As TextBox
    Friend WithEvents txtClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cosOutput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tanOutput As TextBox
    Friend WithEvents btnComputeAll As Button
End Class
