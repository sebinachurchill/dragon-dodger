<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gameplay
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
        Me.components = New System.ComponentModel.Container()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picDragon1 = New System.Windows.Forms.PictureBox()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.picDragon2 = New System.Windows.Forms.PictureBox()
        Me.picDragon3 = New System.Windows.Forms.PictureBox()
        Me.picDragon4 = New System.Windows.Forms.PictureBox()
        Me.picDragon5 = New System.Windows.Forms.PictureBox()
        Me.tmrDragonChoose = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDragonFall = New System.Windows.Forms.Timer(Me.components)
        Me.lblLivesTitle = New System.Windows.Forms.Label()
        Me.tmrBonus = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragon4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragon5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picPlayer.Location = New System.Drawing.Point(405, 577)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(90, 90)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picDragon1
        '
        Me.picDragon1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDragon1.Location = New System.Drawing.Point(28, 86)
        Me.picDragon1.Name = "picDragon1"
        Me.picDragon1.Size = New System.Drawing.Size(175, 175)
        Me.picDragon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon1.TabIndex = 1
        Me.picDragon1.TabStop = False
        Me.picDragon1.Visible = False
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.AutoSize = True
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScoreTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(115, 37)
        Me.lblScoreTitle.TabIndex = 5
        Me.lblScoreTitle.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(153, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(39, 37)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "--"
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'tmrMovement
        '
        Me.tmrMovement.Interval = 75
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLives.Location = New System.Drawing.Point(851, 9)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(39, 37)
        Me.lblLives.TabIndex = 9
        Me.lblLives.Text = "--"
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStats.Location = New System.Drawing.Point(12, 44)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(22, 22)
        Me.lblStats.TabIndex = 10
        Me.lblStats.Text = "--"
        '
        'picDragon2
        '
        Me.picDragon2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDragon2.Location = New System.Drawing.Point(209, 86)
        Me.picDragon2.Name = "picDragon2"
        Me.picDragon2.Size = New System.Drawing.Size(175, 175)
        Me.picDragon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon2.TabIndex = 11
        Me.picDragon2.TabStop = False
        Me.picDragon2.Visible = False
        '
        'picDragon3
        '
        Me.picDragon3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDragon3.Location = New System.Drawing.Point(390, 86)
        Me.picDragon3.Name = "picDragon3"
        Me.picDragon3.Size = New System.Drawing.Size(175, 175)
        Me.picDragon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon3.TabIndex = 12
        Me.picDragon3.TabStop = False
        Me.picDragon3.Visible = False
        '
        'picDragon4
        '
        Me.picDragon4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDragon4.Location = New System.Drawing.Point(571, 86)
        Me.picDragon4.Name = "picDragon4"
        Me.picDragon4.Size = New System.Drawing.Size(175, 175)
        Me.picDragon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon4.TabIndex = 13
        Me.picDragon4.TabStop = False
        Me.picDragon4.Visible = False
        '
        'picDragon5
        '
        Me.picDragon5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDragon5.Location = New System.Drawing.Point(752, 86)
        Me.picDragon5.Name = "picDragon5"
        Me.picDragon5.Size = New System.Drawing.Size(175, 175)
        Me.picDragon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon5.TabIndex = 14
        Me.picDragon5.TabStop = False
        Me.picDragon5.Visible = False
        '
        'tmrDragonChoose
        '
        '
        'tmrDragonFall
        '
        '
        'lblLivesTitle
        '
        Me.lblLivesTitle.AutoSize = True
        Me.lblLivesTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLivesTitle.Location = New System.Drawing.Point(710, 9)
        Me.lblLivesTitle.Name = "lblLivesTitle"
        Me.lblLivesTitle.Size = New System.Drawing.Size(105, 37)
        Me.lblLivesTitle.TabIndex = 15
        Me.lblLivesTitle.Text = "Lives:"
        '
        'Gameplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 660)
        Me.Controls.Add(Me.lblLivesTitle)
        Me.Controls.Add(Me.picDragon5)
        Me.Controls.Add(Me.picDragon4)
        Me.Controls.Add(Me.picDragon3)
        Me.Controls.Add(Me.picDragon2)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTitle)
        Me.Controls.Add(Me.picDragon1)
        Me.Controls.Add(Me.picPlayer)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(964, 716)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(964, 716)
        Me.Name = "Gameplay"
        Me.Text = "Gameplay"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragon4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragon5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picDragon1 As PictureBox
    Friend WithEvents lblScoreTitle As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents tmrMovement As Timer
    Friend WithEvents lblLives As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents picDragon2 As PictureBox
    Friend WithEvents picDragon3 As PictureBox
    Friend WithEvents picDragon4 As PictureBox
    Friend WithEvents picDragon5 As PictureBox
    Friend WithEvents tmrDragonChoose As Timer
    Friend WithEvents tmrDragonFall As Timer
    Friend WithEvents lblLivesTitle As Label
    Friend WithEvents tmrBonus As Timer
End Class
