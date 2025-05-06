<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLecture1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtinput1 = New TextBox()
        txtinput2 = New TextBox()
        Label1 = New Label()
        btnadd = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtresult = New TextBox()
        clr = New Button()
        btnsub = New Button()
        btnmulti = New Button()
        btndiv = New Button()
        Title = New Label()
        SuspendLayout()
        ' 
        ' txtinput1
        ' 
        txtinput1.Location = New Point(143, 96)
        txtinput1.Margin = New Padding(3, 4, 3, 4)
        txtinput1.Name = "txtinput1"
        txtinput1.Size = New Size(315, 27)
        txtinput1.TabIndex = 0
        ' 
        ' txtinput2
        ' 
        txtinput2.Location = New Point(143, 157)
        txtinput2.Margin = New Padding(3, 4, 3, 4)
        txtinput2.Name = "txtinput2"
        txtinput2.Size = New Size(315, 27)
        txtinput2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 17)
        Label1.TabIndex = 2
        Label1.Text = "Input number:"
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Khaki
        btnadd.Cursor = Cursors.Hand
        btnadd.Location = New Point(143, 277)
        btnadd.Margin = New Padding(3, 4, 3, 4)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(86, 31)
        btnadd.TabIndex = 3
        btnadd.Text = "&Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 17)
        Label2.TabIndex = 4
        Label2.Text = "Input number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(41, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 17)
        Label3.TabIndex = 6
        Label3.Text = "Result:"
        ' 
        ' txtresult
        ' 
        txtresult.Enabled = False
        txtresult.Location = New Point(143, 215)
        txtresult.Margin = New Padding(3, 4, 3, 4)
        txtresult.Name = "txtresult"
        txtresult.Size = New Size(315, 27)
        txtresult.TabIndex = 5
        ' 
        ' clr
        ' 
        clr.BackColor = Color.YellowGreen
        clr.Location = New Point(373, 295)
        clr.Margin = New Padding(3, 4, 3, 4)
        clr.Name = "clr"
        clr.Size = New Size(86, 31)
        clr.TabIndex = 7
        clr.Text = "Clear"
        clr.UseVisualStyleBackColor = False
        ' 
        ' btnsub
        ' 
        btnsub.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnsub.Location = New Point(251, 277)
        btnsub.Margin = New Padding(3, 4, 3, 4)
        btnsub.Name = "btnsub"
        btnsub.Size = New Size(86, 31)
        btnsub.TabIndex = 8
        btnsub.Text = "Subtract"
        btnsub.UseVisualStyleBackColor = False
        ' 
        ' btnmulti
        ' 
        btnmulti.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnmulti.Location = New Point(143, 316)
        btnmulti.Margin = New Padding(3, 4, 3, 4)
        btnmulti.Name = "btnmulti"
        btnmulti.Size = New Size(86, 31)
        btnmulti.TabIndex = 9
        btnmulti.Text = "Multiply"
        btnmulti.UseVisualStyleBackColor = False
        ' 
        ' btndiv
        ' 
        btndiv.BackColor = Color.Silver
        btndiv.Location = New Point(251, 316)
        btndiv.Margin = New Padding(3, 4, 3, 4)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(86, 31)
        btndiv.TabIndex = 10
        btndiv.Text = "Divide"
        btndiv.UseVisualStyleBackColor = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Comic Sans MS", 21F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(106, 17)
        Title.Name = "Title"
        Title.Size = New Size(335, 49)
        Title.TabIndex = 11
        Title.Text = "CALCULATOR APP"
        ' 
        ' frmLecture1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(509, 371)
        Controls.Add(Title)
        Controls.Add(btndiv)
        Controls.Add(btnmulti)
        Controls.Add(btnsub)
        Controls.Add(clr)
        Controls.Add(Label3)
        Controls.Add(txtresult)
        Controls.Add(Label2)
        Controls.Add(btnadd)
        Controls.Add(Label1)
        Controls.Add(txtinput2)
        Controls.Add(txtinput1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MinimizeBox = False
        Name = "frmLecture1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lecture 1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtinput1 As TextBox
    Friend WithEvents txtinput2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresult As TextBox
    Friend WithEvents clr As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents Title As Label
End Class
