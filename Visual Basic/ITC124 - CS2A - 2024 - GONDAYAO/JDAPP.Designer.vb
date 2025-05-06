<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JDAPP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JDAPP))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.rockP = New System.Windows.Forms.PictureBox()
        Me.scissorP = New System.Windows.Forms.PictureBox()
        Me.paperP = New System.Windows.Forms.PictureBox()
        Me.paperC = New System.Windows.Forms.PictureBox()
        Me.scissorC = New System.Windows.Forms.PictureBox()
        Me.rockC = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.rockP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissorP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paperP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paperC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissorC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rockC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Coral
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Location = New System.Drawing.Point(304, 299)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(124, 48)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Lock In"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'rockP
        '
        Me.rockP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rockP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rockP.Image = CType(resources.GetObject("rockP.Image"), System.Drawing.Image)
        Me.rockP.Location = New System.Drawing.Point(38, 125)
        Me.rockP.Name = "rockP"
        Me.rockP.Size = New System.Drawing.Size(120, 101)
        Me.rockP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rockP.TabIndex = 1
        Me.rockP.TabStop = False
        '
        'scissorP
        '
        Me.scissorP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scissorP.Image = CType(resources.GetObject("scissorP.Image"), System.Drawing.Image)
        Me.scissorP.Location = New System.Drawing.Point(106, 246)
        Me.scissorP.Name = "scissorP"
        Me.scissorP.Size = New System.Drawing.Size(124, 101)
        Me.scissorP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.scissorP.TabIndex = 2
        Me.scissorP.TabStop = False
        '
        'paperP
        '
        Me.paperP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paperP.Image = CType(resources.GetObject("paperP.Image"), System.Drawing.Image)
        Me.paperP.Location = New System.Drawing.Point(181, 125)
        Me.paperP.Name = "paperP"
        Me.paperP.Size = New System.Drawing.Size(124, 101)
        Me.paperP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paperP.TabIndex = 3
        Me.paperP.TabStop = False
        '
        'paperC
        '
        Me.paperC.Image = CType(resources.GetObject("paperC.Image"), System.Drawing.Image)
        Me.paperC.Location = New System.Drawing.Point(572, 125)
        Me.paperC.Name = "paperC"
        Me.paperC.Size = New System.Drawing.Size(124, 101)
        Me.paperC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paperC.TabIndex = 6
        Me.paperC.TabStop = False
        '
        'scissorC
        '
        Me.scissorC.Image = CType(resources.GetObject("scissorC.Image"), System.Drawing.Image)
        Me.scissorC.Location = New System.Drawing.Point(497, 246)
        Me.scissorC.Name = "scissorC"
        Me.scissorC.Size = New System.Drawing.Size(124, 101)
        Me.scissorC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.scissorC.TabIndex = 5
        Me.scissorC.TabStop = False
        '
        'rockC
        '
        Me.rockC.Image = CType(resources.GetObject("rockC.Image"), System.Drawing.Image)
        Me.rockC.Location = New System.Drawing.Point(429, 125)
        Me.rockC.Name = "rockC"
        Me.rockC.Size = New System.Drawing.Size(120, 101)
        Me.rockC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rockC.TabIndex = 4
        Me.rockC.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(127, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(500, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Computer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(231, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rock, Paper, Scissor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(325, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 38)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Game"
        '
        'JDAPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(729, 404)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.paperC)
        Me.Controls.Add(Me.scissorC)
        Me.Controls.Add(Me.rockC)
        Me.Controls.Add(Me.paperP)
        Me.Controls.Add(Me.scissorP)
        Me.Controls.Add(Me.rockP)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "JDAPP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JDAPP"
        CType(Me.rockP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissorP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paperP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paperC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissorC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rockC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents rockP As PictureBox
    Friend WithEvents scissorP As PictureBox
    Friend WithEvents paperP As PictureBox
    Friend WithEvents paperC As PictureBox
    Friend WithEvents scissorC As PictureBox
    Friend WithEvents rockC As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
