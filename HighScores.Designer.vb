<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.lblHighScores = New System.Windows.Forms.Label()
        Me.lstHighScores = New System.Windows.Forms.ListBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHighScores
        '
        Me.lblHighScores.AutoSize = True
        Me.lblHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHighScores.ForeColor = System.Drawing.Color.White
        Me.lblHighScores.Location = New System.Drawing.Point(303, 27)
        Me.lblHighScores.Name = "lblHighScores"
        Me.lblHighScores.Size = New System.Drawing.Size(271, 52)
        Me.lblHighScores.TabIndex = 0
        Me.lblHighScores.Text = "High Scores"
        '
        'lstHighScores
        '
        Me.lstHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstHighScores.ForeColor = System.Drawing.Color.Maroon
        Me.lstHighScores.FormattingEnabled = True
        Me.lstHighScores.ItemHeight = 32
        Me.lstHighScores.Location = New System.Drawing.Point(56, 97)
        Me.lstHighScores.Name = "lstHighScores"
        Me.lstHighScores.Size = New System.Drawing.Size(827, 452)
        Me.lstHighScores.TabIndex = 1
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.White
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMain.Location = New System.Drawing.Point(399, 567)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(161, 57)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "MAIN"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(942, 660)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lstHighScores)
        Me.Controls.Add(Me.lblHighScores)
        Me.MaximumSize = New System.Drawing.Size(964, 716)
        Me.MinimumSize = New System.Drawing.Size(964, 716)
        Me.Name = "HighScores"
        Me.Text = "HighScores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHighScores As Label
    Friend WithEvents lstHighScores As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMain As Button
End Class
