<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHallOfFame = New System.Windows.Forms.Button()
        Me.picTitleImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picTitleImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(74, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(796, 99)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DRAGON DODGER"
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.Black
        Me.btnRules.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRules.ForeColor = System.Drawing.Color.White
        Me.btnRules.Location = New System.Drawing.Point(478, 457)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(178, 64)
        Me.btnRules.TabIndex = 3
        Me.btnRules.Text = "RULES"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(294, 457)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(178, 64)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnHallOfFame
        '
        Me.btnHallOfFame.BackColor = System.Drawing.Color.Black
        Me.btnHallOfFame.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHallOfFame.ForeColor = System.Drawing.Color.White
        Me.btnHallOfFame.Location = New System.Drawing.Point(294, 528)
        Me.btnHallOfFame.Name = "btnHallOfFame"
        Me.btnHallOfFame.Size = New System.Drawing.Size(362, 64)
        Me.btnHallOfFame.TabIndex = 5
        Me.btnHallOfFame.Text = "HALL OF FAME"
        Me.btnHallOfFame.UseVisualStyleBackColor = False
        '
        'picTitleImage
        '
        Me.picTitleImage.Image = CType(resources.GetObject("picTitleImage.Image"), System.Drawing.Image)
        Me.picTitleImage.Location = New System.Drawing.Point(185, 146)
        Me.picTitleImage.Name = "picTitleImage"
        Me.picTitleImage.Size = New System.Drawing.Size(579, 293)
        Me.picTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitleImage.TabIndex = 6
        Me.picTitleImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(294, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*View the leaderboard in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hall of Fame"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(942, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTitleImage)
        Me.Controls.Add(Me.btnHallOfFame)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximumSize = New System.Drawing.Size(964, 716)
        Me.MinimumSize = New System.Drawing.Size(964, 716)
        Me.Name = "Form1"
        Me.Text = "Main"
        CType(Me.picTitleImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRules As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnHallOfFame As Button
    Friend WithEvents picTitleImage As PictureBox
    Friend WithEvents Label1 As Label
End Class
