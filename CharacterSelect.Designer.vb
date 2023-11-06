<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterSelect))
        Me.lblCharSelect = New System.Windows.Forms.Label()
        Me.picJane = New System.Windows.Forms.PictureBox()
        Me.picJohn = New System.Windows.Forms.PictureBox()
        Me.rdbJane = New System.Windows.Forms.RadioButton()
        Me.rdbJohn = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        CType(Me.picJane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJohn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharSelect
        '
        Me.lblCharSelect.AutoSize = True
        Me.lblCharSelect.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCharSelect.Location = New System.Drawing.Point(239, 29)
        Me.lblCharSelect.Name = "lblCharSelect"
        Me.lblCharSelect.Size = New System.Drawing.Size(468, 46)
        Me.lblCharSelect.TabIndex = 0
        Me.lblCharSelect.Text = "Character Select"
        '
        'picJane
        '
        Me.picJane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picJane.Image = CType(resources.GetObject("picJane.Image"), System.Drawing.Image)
        Me.picJane.Location = New System.Drawing.Point(135, 135)
        Me.picJane.Name = "picJane"
        Me.picJane.Size = New System.Drawing.Size(275, 275)
        Me.picJane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJane.TabIndex = 1
        Me.picJane.TabStop = False
        '
        'picJohn
        '
        Me.picJohn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picJohn.Image = CType(resources.GetObject("picJohn.Image"), System.Drawing.Image)
        Me.picJohn.Location = New System.Drawing.Point(519, 135)
        Me.picJohn.Name = "picJohn"
        Me.picJohn.Size = New System.Drawing.Size(275, 275)
        Me.picJohn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJohn.TabIndex = 2
        Me.picJohn.TabStop = False
        '
        'rdbJane
        '
        Me.rdbJane.AutoSize = True
        Me.rdbJane.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdbJane.Location = New System.Drawing.Point(135, 416)
        Me.rdbJane.Name = "rdbJane"
        Me.rdbJane.Size = New System.Drawing.Size(282, 28)
        Me.rdbJane.TabIndex = 3
        Me.rdbJane.TabStop = True
        Me.rdbJane.Text = "Jane - Faster speed"
        Me.rdbJane.UseVisualStyleBackColor = True
        '
        'rdbJohn
        '
        Me.rdbJohn.AutoSize = True
        Me.rdbJohn.Font = New System.Drawing.Font("OCR A Extended", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdbJohn.Location = New System.Drawing.Point(519, 417)
        Me.rdbJohn.Name = "rdbJohn"
        Me.rdbJohn.Size = New System.Drawing.Size(256, 28)
        Me.rdbJohn.TabIndex = 4
        Me.rdbJohn.TabStop = True
        Me.rdbJohn.Text = "John - Extra life"
        Me.rdbJohn.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("OCR A Extended", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(395, 545)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(150, 54)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'CharacterSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(942, 660)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.rdbJohn)
        Me.Controls.Add(Me.rdbJane)
        Me.Controls.Add(Me.picJohn)
        Me.Controls.Add(Me.picJane)
        Me.Controls.Add(Me.lblCharSelect)
        Me.MaximumSize = New System.Drawing.Size(964, 716)
        Me.MinimumSize = New System.Drawing.Size(964, 716)
        Me.Name = "CharacterSelect"
        Me.Text = "Character Select"
        CType(Me.picJane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJohn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCharSelect As Label
    Friend WithEvents picJane As PictureBox
    Friend WithEvents picJohn As PictureBox
    Friend WithEvents rdbJane As RadioButton
    Friend WithEvents rdbJohn As RadioButton
    Friend WithEvents btnPlay As Button
End Class
