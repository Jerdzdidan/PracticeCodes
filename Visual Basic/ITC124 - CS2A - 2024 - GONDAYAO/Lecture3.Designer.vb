<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecture3
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
        Label1 = New Label()
        txtinput = New TextBox()
        btnDetermine = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(23, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 14)
        Label1.TabIndex = 16
        Label1.Text = "Input number:"
        ' 
        ' txtinput
        ' 
        txtinput.Location = New Point(126, 27)
        txtinput.Name = "txtinput"
        txtinput.Size = New Size(251, 23)
        txtinput.TabIndex = 15
        ' 
        ' btnDetermine
        ' 
        btnDetermine.BackColor = Color.Khaki
        btnDetermine.Cursor = Cursors.Hand
        btnDetermine.Location = New Point(292, 66)
        btnDetermine.Name = "btnDetermine"
        btnDetermine.Size = New Size(84, 23)
        btnDetermine.TabIndex = 17
        btnDetermine.Text = "&Determine"
        btnDetermine.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmLecture3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(411, 109)
        Controls.Add(btnDetermine)
        Controls.Add(Label1)
        Controls.Add(txtinput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "frmLecture3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lecture3"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents btnDetermine As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
