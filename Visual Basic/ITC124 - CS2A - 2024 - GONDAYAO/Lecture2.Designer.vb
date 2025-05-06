<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecture2
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
        Title = New Label()
        btndiv = New Button()
        btnmulti = New Button()
        btnsub = New Button()
        btnclr = New Button()
        Label3 = New Label()
        txtresult = New TextBox()
        Label2 = New Label()
        btnadd = New Button()
        Label1 = New Label()
        txtinput2 = New TextBox()
        txtinput1 = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(105, 28)
        Title.Name = "Title"
        Title.Size = New Size(263, 39)
        Title.TabIndex = 23
        Title.Text = "CALCULATOR APP"
        ' 
        ' btndiv
        ' 
        btndiv.BackColor = Color.Silver
        btndiv.Location = New Point(232, 252)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(75, 23)
        btndiv.TabIndex = 22
        btndiv.Text = "Divide"
        btndiv.UseVisualStyleBackColor = False
        ' 
        ' btnmulti
        ' 
        btnmulti.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnmulti.Location = New Point(137, 252)
        btnmulti.Name = "btnmulti"
        btnmulti.Size = New Size(75, 23)
        btnmulti.TabIndex = 21
        btnmulti.Text = "Multiply"
        btnmulti.UseVisualStyleBackColor = False
        ' 
        ' btnsub
        ' 
        btnsub.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnsub.Location = New Point(232, 223)
        btnsub.Name = "btnsub"
        btnsub.Size = New Size(75, 23)
        btnsub.TabIndex = 20
        btnsub.Text = "Subtract"
        btnsub.UseVisualStyleBackColor = False
        ' 
        ' btnclr
        ' 
        btnclr.BackColor = Color.YellowGreen
        btnclr.Location = New Point(338, 236)
        btnclr.Name = "btnclr"
        btnclr.Size = New Size(75, 23)
        btnclr.TabIndex = 19
        btnclr.Text = "Clear"
        btnclr.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(48, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 14)
        Label3.TabIndex = 18
        Label3.Text = "Result:"
        ' 
        ' txtresult
        ' 
        txtresult.Enabled = False
        txtresult.Location = New Point(137, 176)
        txtresult.Name = "txtresult"
        txtresult.Size = New Size(276, 23)
        txtresult.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(34, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 14)
        Label2.TabIndex = 16
        Label2.Text = "Input number:"
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Khaki
        btnadd.Cursor = Cursors.Hand
        btnadd.Location = New Point(137, 223)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 23)
        btnadd.TabIndex = 15
        btnadd.Text = "&Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(34, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 14)
        Label1.TabIndex = 14
        Label1.Text = "Input number:"
        ' 
        ' txtinput2
        ' 
        txtinput2.Location = New Point(137, 133)
        txtinput2.Name = "txtinput2"
        txtinput2.Size = New Size(276, 23)
        txtinput2.TabIndex = 13
        ' 
        ' txtinput1
        ' 
        txtinput1.Location = New Point(137, 87)
        txtinput1.Name = "txtinput1"
        txtinput1.Size = New Size(276, 23)
        txtinput1.TabIndex = 12
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmLecture2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(475, 301)
        Controls.Add(Title)
        Controls.Add(btndiv)
        Controls.Add(btnmulti)
        Controls.Add(btnsub)
        Controls.Add(btnclr)
        Controls.Add(Label3)
        Controls.Add(txtresult)
        Controls.Add(Label2)
        Controls.Add(btnadd)
        Controls.Add(Label1)
        Controls.Add(txtinput2)
        Controls.Add(txtinput1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLecture2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lecture2"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresult As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput2 As TextBox
    Friend WithEvents txtinput1 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
