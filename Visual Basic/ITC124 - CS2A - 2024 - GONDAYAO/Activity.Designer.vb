<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity
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
        btncompute = New Button()
        txttangent = New TextBox()
        Label8 = New Label()
        txtcos = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        btnreset = New Button()
        txtsine = New TextBox()
        Label4 = New Label()
        txthypo = New TextBox()
        Label3 = New Label()
        txtAdjacent = New TextBox()
        Label2 = New Label()
        txtopposite = New TextBox()
        Label1 = New Label()
        btncos = New Button()
        btntan = New Button()
        btnsin = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btncompute
        ' 
        btncompute.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btncompute.Cursor = Cursors.Hand
        btncompute.Location = New Point(436, 158)
        btncompute.Margin = New Padding(3, 2, 3, 2)
        btncompute.Name = "btncompute"
        btncompute.Size = New Size(128, 33)
        btncompute.TabIndex = 59
        btncompute.Text = "Compute All"
        btncompute.UseVisualStyleBackColor = False
        ' 
        ' txttangent
        ' 
        txttangent.Enabled = False
        txttangent.Location = New Point(190, 220)
        txttangent.Margin = New Padding(3, 2, 3, 2)
        txttangent.Name = "txttangent"
        txttangent.Size = New Size(123, 23)
        txttangent.TabIndex = 58
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(190, 203)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 57
        Label8.Text = "Tangent:"
        ' 
        ' txtcos
        ' 
        txtcos.Enabled = False
        txtcos.Location = New Point(190, 164)
        txtcos.Margin = New Padding(3, 2, 3, 2)
        txtcos.Name = "txtcos"
        txtcos.Size = New Size(123, 23)
        txtcos.TabIndex = 56
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(190, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 15)
        Label7.TabIndex = 55
        Label7.Text = "Cosine:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(190, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 54
        Label6.Text = "Sine:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(229, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(248, 26)
        Label5.TabIndex = 53
        Label5.Text = "Trigonometric Calculator"
        ' 
        ' btnreset
        ' 
        btnreset.BackColor = Color.Silver
        btnreset.Cursor = Cursors.Hand
        btnreset.Location = New Point(453, 210)
        btnreset.Margin = New Padding(3, 2, 3, 2)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(96, 33)
        btnreset.TabIndex = 52
        btnreset.Text = "Clear"
        btnreset.UseVisualStyleBackColor = False
        ' 
        ' txtsine
        ' 
        txtsine.Enabled = False
        txtsine.Location = New Point(190, 108)
        txtsine.Margin = New Padding(3, 2, 3, 2)
        txtsine.Name = "txtsine"
        txtsine.Size = New Size(123, 23)
        txtsine.TabIndex = 51
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 50
        ' 
        ' txthypo
        ' 
        txthypo.Location = New Point(45, 220)
        txthypo.Margin = New Padding(3, 2, 3, 2)
        txthypo.Name = "txthypo"
        txthypo.Size = New Size(123, 23)
        txthypo.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(45, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 48
        Label3.Text = "Hypotenuse Side:"
        ' 
        ' txtAdjacent
        ' 
        txtAdjacent.Location = New Point(44, 164)
        txtAdjacent.Margin = New Padding(3, 2, 3, 2)
        txtAdjacent.Name = "txtAdjacent"
        txtAdjacent.Size = New Size(124, 23)
        txtAdjacent.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 46
        Label2.Text = "Adjacent Side:"
        ' 
        ' txtopposite
        ' 
        txtopposite.Location = New Point(44, 108)
        txtopposite.Margin = New Padding(3, 2, 3, 2)
        txtopposite.Name = "txtopposite"
        txtopposite.Size = New Size(124, 23)
        txtopposite.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(44, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 44
        Label1.Text = "Opposite Side:"
        ' 
        ' btncos
        ' 
        btncos.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btncos.Cursor = Cursors.Hand
        btncos.Location = New Point(453, 103)
        btncos.Margin = New Padding(3, 2, 3, 2)
        btncos.Name = "btncos"
        btncos.Size = New Size(96, 33)
        btncos.TabIndex = 43
        btncos.Text = "Cosine"
        btncos.UseVisualStyleBackColor = False
        ' 
        ' btntan
        ' 
        btntan.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btntan.Cursor = Cursors.Hand
        btntan.Location = New Point(555, 103)
        btntan.Margin = New Padding(3, 2, 3, 2)
        btntan.Name = "btntan"
        btntan.Size = New Size(96, 33)
        btntan.TabIndex = 42
        btntan.Text = "Tangent"
        btntan.UseVisualStyleBackColor = False
        ' 
        ' btnsin
        ' 
        btnsin.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnsin.Cursor = Cursors.Hand
        btnsin.Location = New Point(352, 103)
        btnsin.Margin = New Padding(3, 2, 3, 2)
        btnsin.Name = "btnsin"
        btnsin.Size = New Size(96, 33)
        btnsin.TabIndex = 41
        btnsin.Text = "Sine"
        btnsin.UseVisualStyleBackColor = False
        ' 
        ' Activity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 305)
        Controls.Add(btncompute)
        Controls.Add(txttangent)
        Controls.Add(Label8)
        Controls.Add(txtcos)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnreset)
        Controls.Add(txtsine)
        Controls.Add(Label4)
        Controls.Add(txthypo)
        Controls.Add(Label3)
        Controls.Add(txtAdjacent)
        Controls.Add(Label2)
        Controls.Add(txtopposite)
        Controls.Add(Label1)
        Controls.Add(btncos)
        Controls.Add(btntan)
        Controls.Add(btnsin)
        Name = "Activity"
        Text = "Activity"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btncompute As Button
    Friend WithEvents txttangent As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents txtsine As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txthypo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdjacent As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtopposite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncos As Button
    Friend WithEvents btntan As Button
    Friend WithEvents btnsin As Button
End Class
