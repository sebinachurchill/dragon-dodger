<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rules))
        Me.lblRulesTitle = New System.Windows.Forms.Label()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.picRightArrow = New System.Windows.Forms.PictureBox()
        Me.picLeftArrow = New System.Windows.Forms.PictureBox()
        Me.lblRulesRight = New System.Windows.Forms.Label()
        Me.lblRulesLeft = New System.Windows.Forms.Label()
        Me.lblRulesTwo = New System.Windows.Forms.Label()
        Me.lblRulesThree = New System.Windows.Forms.Label()
        CType(Me.picRightArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRulesTitle
        '
        Me.lblRulesTitle.AutoSize = True
        Me.lblRulesTitle.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRulesTitle.Location = New System.Drawing.Point(410, 9)
        Me.lblRulesTitle.Name = "lblRulesTitle"
        Me.lblRulesTitle.Size = New System.Drawing.Size(160, 46)
        Me.lblRulesTitle.TabIndex = 0
        Me.lblRulesTitle.Text = "Rules"
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRules.Location = New System.Drawing.Point(51, 55)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(816, 72)
        Me.lblRules.TabIndex = 1
        Me.lblRules.Text = "Ancient dragons have awoken and are attacking the Earth!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In order to stay alive," &
    " you have to dodge the invading dragons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by moving left and right."
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Black
        Me.btnMain.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMain.ForeColor = System.Drawing.Color.White
        Me.btnMain.Location = New System.Drawing.Point(396, 590)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(151, 58)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'picRightArrow
        '
        Me.picRightArrow.Image = CType(resources.GetObject("picRightArrow.Image"), System.Drawing.Image)
        Me.picRightArrow.Location = New System.Drawing.Point(51, 236)
        Me.picRightArrow.Name = "picRightArrow"
        Me.picRightArrow.Size = New System.Drawing.Size(75, 75)
        Me.picRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightArrow.TabIndex = 3
        Me.picRightArrow.TabStop = False
        '
        'picLeftArrow
        '
        Me.picLeftArrow.Image = CType(resources.GetObject("picLeftArrow.Image"), System.Drawing.Image)
        Me.picLeftArrow.Location = New System.Drawing.Point(51, 316)
        Me.picLeftArrow.Name = "picLeftArrow"
        Me.picLeftArrow.Size = New System.Drawing.Size(75, 75)
        Me.picLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftArrow.TabIndex = 4
        Me.picLeftArrow.TabStop = False
        '
        'lblRulesRight
        '
        Me.lblRulesRight.AutoSize = True
        Me.lblRulesRight.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRulesRight.Location = New System.Drawing.Point(141, 261)
        Me.lblRulesRight.Name = "lblRulesRight"
        Me.lblRulesRight.Size = New System.Drawing.Size(530, 24)
        Me.lblRulesRight.TabIndex = 5
        Me.lblRulesRight.Text = "Press the right arrow key to move right."
        '
        'lblRulesLeft
        '
        Me.lblRulesLeft.AutoSize = True
        Me.lblRulesLeft.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRulesLeft.Location = New System.Drawing.Point(141, 342)
        Me.lblRulesLeft.Name = "lblRulesLeft"
        Me.lblRulesLeft.Size = New System.Drawing.Size(504, 24)
        Me.lblRulesLeft.TabIndex = 6
        Me.lblRulesLeft.Text = "Press the left arrow key to move left."
        '
        'lblRulesTwo
        '
        Me.lblRulesTwo.AutoSize = True
        Me.lblRulesTwo.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRulesTwo.Location = New System.Drawing.Point(51, 152)
        Me.lblRulesTwo.Name = "lblRulesTwo"
        Me.lblRulesTwo.Size = New System.Drawing.Size(829, 72)
        Me.lblRulesTwo.TabIndex = 7
        Me.lblRulesTwo.Text = "When you click the Start button, you must first choose to play" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as Jane or John. " &
    "Jane moves faster than John, but John has more" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lives. Click the Play button to " &
    "begin the game."
        '
        'lblRulesThree
        '
        Me.lblRulesThree.AutoSize = True
        Me.lblRulesThree.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRulesThree.Location = New System.Drawing.Point(51, 406)
        Me.lblRulesThree.Name = "lblRulesThree"
        Me.lblRulesThree.Size = New System.Drawing.Size(816, 168)
        Me.lblRulesThree.TabIndex = 8
        Me.lblRulesThree.Text = resources.GetString("lblRulesThree.Text")
        '
        'Rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(942, 660)
        Me.Controls.Add(Me.lblRulesThree)
        Me.Controls.Add(Me.lblRulesTwo)
        Me.Controls.Add(Me.lblRulesLeft)
        Me.Controls.Add(Me.lblRulesRight)
        Me.Controls.Add(Me.picLeftArrow)
        Me.Controls.Add(Me.picRightArrow)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.lblRulesTitle)
        Me.MaximumSize = New System.Drawing.Size(964, 716)
        Me.MinimumSize = New System.Drawing.Size(964, 716)
        Me.Name = "Rules"
        Me.Text = "Rules"
        CType(Me.picRightArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRulesTitle As Label
    Friend WithEvents lblRules As Label
    Friend WithEvents btnMain As Button
    Friend WithEvents picRightArrow As PictureBox
    Friend WithEvents picLeftArrow As PictureBox
    Friend WithEvents lblRulesRight As Label
    Friend WithEvents lblRulesLeft As Label
    Friend WithEvents lblRulesTwo As Label
    Friend WithEvents lblRulesThree As Label
End Class
