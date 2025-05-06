<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity2
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
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        btnComputeAll = New Button()
        tanOutput = New TextBox()
        Label8 = New Label()
        cosOutput = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtClear = New Button()
        sineOutput = New TextBox()
        Label4 = New Label()
        txthyp = New TextBox()
        Label3 = New Label()
        txtadj = New TextBox()
        Label2 = New Label()
        txtopp = New TextBox()
        Label1 = New Label()
        btnCosine = New Button()
        btnTangent = New Button()
        btnSine = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnComputeAll
        ' 
        btnComputeAll.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnComputeAll.Cursor = Cursors.Hand
        btnComputeAll.Location = New Point(443, 160)
        btnComputeAll.Margin = New Padding(3, 2, 3, 2)
        btnComputeAll.Name = "btnComputeAll"
        btnComputeAll.Size = New Size(128, 33)
        btnComputeAll.TabIndex = 40
        btnComputeAll.Text = "Compute All"
        btnComputeAll.UseVisualStyleBackColor = False
        ' 
        ' tanOutput
        ' 
        tanOutput.Enabled = False
        tanOutput.Location = New Point(197, 222)
        tanOutput.Margin = New Padding(3, 2, 3, 2)
        tanOutput.Name = "tanOutput"
        tanOutput.Size = New Size(123, 23)
        tanOutput.TabIndex = 39
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(197, 205)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 38
        Label8.Text = "Tangent:"
        ' 
        ' cosOutput
        ' 
        cosOutput.Enabled = False
        cosOutput.Location = New Point(197, 166)
        cosOutput.Margin = New Padding(3, 2, 3, 2)
        cosOutput.Name = "cosOutput"
        cosOutput.Size = New Size(123, 23)
        cosOutput.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(197, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 15)
        Label7.TabIndex = 36
        Label7.Text = "Cosine:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(197, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 35
        Label6.Text = "Sine:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(182, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(338, 38)
        Label5.TabIndex = 34
        Label5.Text = "Trigonometric Calculator"
        ' 
        ' txtClear
        ' 
        txtClear.BackColor = Color.Silver
        txtClear.Cursor = Cursors.Hand
        txtClear.Location = New Point(460, 212)
        txtClear.Margin = New Padding(3, 2, 3, 2)
        txtClear.Name = "txtClear"
        txtClear.Size = New Size(96, 33)
        txtClear.TabIndex = 33
        txtClear.Text = "Clear"
        txtClear.UseVisualStyleBackColor = False
        ' 
        ' sineOutput
        ' 
        sineOutput.Enabled = False
        sineOutput.Location = New Point(197, 110)
        sineOutput.Margin = New Padding(3, 2, 3, 2)
        sineOutput.Name = "sineOutput"
        sineOutput.Size = New Size(123, 23)
        sineOutput.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(51, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 31
        ' 
        ' txthyp
        ' 
        txthyp.Location = New Point(52, 222)
        txthyp.Margin = New Padding(3, 2, 3, 2)
        txthyp.Name = "txthyp"
        txthyp.Size = New Size(123, 23)
        txthyp.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(52, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 29
        Label3.Text = "Hypotenuse Side:"
        ' 
        ' txtadj
        ' 
        txtadj.Location = New Point(51, 166)
        txtadj.Margin = New Padding(3, 2, 3, 2)
        txtadj.Name = "txtadj"
        txtadj.Size = New Size(124, 23)
        txtadj.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(51, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 27
        Label2.Text = "Adjacent Side:"
        ' 
        ' txtopp
        ' 
        txtopp.Location = New Point(51, 110)
        txtopp.Margin = New Padding(3, 2, 3, 2)
        txtopp.Name = "txtopp"
        txtopp.Size = New Size(124, 23)
        txtopp.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(51, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 25
        Label1.Text = "Opposite Side:"
        ' 
        ' btnCosine
        ' 
        btnCosine.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnCosine.Cursor = Cursors.Hand
        btnCosine.Location = New Point(460, 105)
        btnCosine.Margin = New Padding(3, 2, 3, 2)
        btnCosine.Name = "btnCosine"
        btnCosine.Size = New Size(96, 33)
        btnCosine.TabIndex = 24
        btnCosine.Text = "Cosine"
        btnCosine.UseVisualStyleBackColor = False
        ' 
        ' btnTangent
        ' 
        btnTangent.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnTangent.Cursor = Cursors.Hand
        btnTangent.Location = New Point(562, 105)
        btnTangent.Margin = New Padding(3, 2, 3, 2)
        btnTangent.Name = "btnTangent"
        btnTangent.Size = New Size(96, 33)
        btnTangent.TabIndex = 23
        btnTangent.Text = "Tangent"
        btnTangent.UseVisualStyleBackColor = False
        ' 
        ' btnSine
        ' 
        btnSine.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSine.Cursor = Cursors.Hand
        btnSine.Location = New Point(359, 105)
        btnSine.Margin = New Padding(3, 2, 3, 2)
        btnSine.Name = "btnSine"
        btnSine.Size = New Size(96, 33)
        btnSine.TabIndex = 22
        btnSine.Text = "Sine"
        btnSine.UseVisualStyleBackColor = False
        ' 
        ' Activity2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(696, 289)
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
        Name = "Activity2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Activity 2"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnComputeAll As Button
    Friend WithEvents tanOutput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cosOutput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClear As Button
    Friend WithEvents sineOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txthyp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtadj As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtopp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCosine As Button
    Friend WithEvents btnTangent As Button
    Friend WithEvents btnSine As Button
End Class
