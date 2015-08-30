<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DiscounterButton = New System.Windows.Forms.Button()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeCalculatorButton = New System.Windows.Forms.Button()
        Me.MultiplesButton = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.AlarmButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiscounterButton
        '
        Me.DiscounterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscounterButton.Location = New System.Drawing.Point(13, 28)
        Me.DiscounterButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscounterButton.Name = "DiscounterButton"
        Me.DiscounterButton.Size = New System.Drawing.Size(226, 100)
        Me.DiscounterButton.TabIndex = 1
        Me.DiscounterButton.Text = "Discounter"
        Me.DiscounterButton.UseVisualStyleBackColor = True
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HelpToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.VoiceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoiceToolStripMenuItem
        '
        Me.VoiceToolStripMenuItem.Name = "VoiceToolStripMenuItem"
        Me.VoiceToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.VoiceToolStripMenuItem.Text = "Narrator"
        '
        'TimeCalculatorButton
        '
        Me.TimeCalculatorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeCalculatorButton.Location = New System.Drawing.Point(13, 136)
        Me.TimeCalculatorButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeCalculatorButton.Name = "TimeCalculatorButton"
        Me.TimeCalculatorButton.Size = New System.Drawing.Size(226, 100)
        Me.TimeCalculatorButton.TabIndex = 2
        Me.TimeCalculatorButton.Text = "Time Calculator"
        Me.TimeCalculatorButton.UseVisualStyleBackColor = True
        '
        'MultiplesButton
        '
        Me.MultiplesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplesButton.Location = New System.Drawing.Point(247, 28)
        Me.MultiplesButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MultiplesButton.Name = "MultiplesButton"
        Me.MultiplesButton.Size = New System.Drawing.Size(226, 100)
        Me.MultiplesButton.TabIndex = 4
        Me.MultiplesButton.Text = "Multiples Finder"
        Me.MultiplesButton.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "Utility Application"
        '
        'AlarmButton
        '
        Me.AlarmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmButton.Location = New System.Drawing.Point(247, 136)
        Me.AlarmButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AlarmButton.Name = "AlarmButton"
        Me.AlarmButton.Size = New System.Drawing.Size(226, 100)
        Me.AlarmButton.TabIndex = 5
        Me.AlarmButton.Text = "Alarm"
        Me.AlarmButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(484, 248)
        Me.Controls.Add(Me.AlarmButton)
        Me.Controls.Add(Me.MultiplesButton)
        Me.Controls.Add(Me.TimeCalculatorButton)
        Me.Controls.Add(Me.DiscounterButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utility Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiscounterButton As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TimeCalculatorButton As System.Windows.Forms.Button
    Friend WithEvents MultiplesButton As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents AlarmButton As System.Windows.Forms.Button
    Friend WithEvents VoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
