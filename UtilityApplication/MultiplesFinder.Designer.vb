<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiplesFinder
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CalculateButton1 = New System.Windows.Forms.Button()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileOutputCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClearButton = New System.Windows.Forms.PictureBox()
        Me.UndoButton = New System.Windows.Forms.PictureBox()
        Me.HiddenRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AutoSelectCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LongProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DecimalProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LastCalculateRTB = New System.Windows.Forms.RichTextBox()
        CType(Me.ClearButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UndoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProgressGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 113)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(613, 484)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(255, 603)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(126, 45)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CalculateButton1
        '
        Me.CalculateButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton1.Location = New System.Drawing.Point(255, 61)
        Me.CalculateButton1.Name = "CalculateButton1"
        Me.CalculateButton1.Size = New System.Drawing.Size(126, 46)
        Me.CalculateButton1.TabIndex = 1
        Me.CalculateButton1.Text = "Calculate"
        Me.CalculateButton1.UseVisualStyleBackColor = True
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(255, 35)
        Me.InputTextBox.MaxLength = 28
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(126, 20)
        Me.InputTextBox.TabIndex = 0
        Me.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enter a Number"
        '
        'FileOutputCheckBox
        '
        Me.FileOutputCheckBox.AutoSize = True
        Me.FileOutputCheckBox.Location = New System.Drawing.Point(548, 90)
        Me.FileOutputCheckBox.Name = "FileOutputCheckBox"
        Me.FileOutputCheckBox.Size = New System.Drawing.Size(77, 17)
        Me.FileOutputCheckBox.TabIndex = 7
        Me.FileOutputCheckBox.Text = "File Output"
        Me.FileOutputCheckBox.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.BackgroundImage = Global.UtilityApplication.My.Resources.Resources.red_x_24_22
        Me.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.InitialImage = Nothing
        Me.ClearButton.Location = New System.Drawing.Point(583, 115)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(24, 22)
        Me.ClearButton.TabIndex = 23
        Me.ClearButton.TabStop = False
        '
        'UndoButton
        '
        Me.UndoButton.BackColor = System.Drawing.Color.Transparent
        Me.UndoButton.BackgroundImage = Global.UtilityApplication.My.Resources.Resources.undo_24_22
        Me.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoButton.InitialImage = Nothing
        Me.UndoButton.Location = New System.Drawing.Point(556, 115)
        Me.UndoButton.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(24, 22)
        Me.UndoButton.TabIndex = 24
        Me.UndoButton.TabStop = False
        Me.UndoButton.Visible = False
        '
        'HiddenRichTextBox
        '
        Me.HiddenRichTextBox.Location = New System.Drawing.Point(435, 603)
        Me.HiddenRichTextBox.Name = "HiddenRichTextBox"
        Me.HiddenRichTextBox.Size = New System.Drawing.Size(46, 40)
        Me.HiddenRichTextBox.TabIndex = 25
        Me.HiddenRichTextBox.Text = ""
        Me.HiddenRichTextBox.Visible = False
        '
        'AutoSelectCheckBox
        '
        Me.AutoSelectCheckBox.AutoSize = True
        Me.AutoSelectCheckBox.Location = New System.Drawing.Point(12, 603)
        Me.AutoSelectCheckBox.Name = "AutoSelectCheckBox"
        Me.AutoSelectCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.AutoSelectCheckBox.TabIndex = 6
        Me.AutoSelectCheckBox.Text = "Auto Select"
        Me.AutoSelectCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Time Taken"
        '
        'TimerBox
        '
        Me.TimerBox.Location = New System.Drawing.Point(12, 87)
        Me.TimerBox.Name = "TimerBox"
        Me.TimerBox.ReadOnly = True
        Me.TimerBox.Size = New System.Drawing.Size(77, 20)
        Me.TimerBox.TabIndex = 5
        Me.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Seconds"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 38)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(279, 20)
        Me.ProgressBar1.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Calculation Progress"
        '
        'ProgressGroupBox
        '
        Me.ProgressGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ProgressGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProgressGroupBox.Controls.Add(Me.PictureBox1)
        Me.ProgressGroupBox.Controls.Add(Me.Label4)
        Me.ProgressGroupBox.Controls.Add(Me.ProgressBar1)
        Me.ProgressGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressGroupBox.Location = New System.Drawing.Point(153, 115)
        Me.ProgressGroupBox.Name = "ProgressGroupBox"
        Me.ProgressGroupBox.Size = New System.Drawing.Size(330, 70)
        Me.ProgressGroupBox.TabIndex = 46
        Me.ProgressGroupBox.TabStop = False
        Me.ProgressGroupBox.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(289, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 20)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'LongProgressTimer
        '
        Me.LongProgressTimer.Interval = 50
        '
        'DecimalProgressTimer
        '
        Me.DecimalProgressTimer.Interval = 1000
        '
        'LastCalculateRTB
        '
        Me.LastCalculateRTB.Location = New System.Drawing.Point(574, 44)
        Me.LastCalculateRTB.Name = "LastCalculateRTB"
        Me.LastCalculateRTB.Size = New System.Drawing.Size(33, 31)
        Me.LastCalculateRTB.TabIndex = 47
        Me.LastCalculateRTB.Text = ""
        Me.LastCalculateRTB.Visible = False
        '
        'MultiplesFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(636, 655)
        Me.Controls.Add(Me.LastCalculateRTB)
        Me.Controls.Add(Me.ProgressGroupBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TimerBox)
        Me.Controls.Add(Me.AutoSelectCheckBox)
        Me.Controls.Add(Me.HiddenRichTextBox)
        Me.Controls.Add(Me.UndoButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.FileOutputCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.CalculateButton1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MultiplesFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiples Finder"
        CType(Me.ClearButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UndoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProgressGroupBox.ResumeLayout(False)
        Me.ProgressGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton1 As System.Windows.Forms.Button
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileOutputCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClearButton As System.Windows.Forms.PictureBox
    Friend WithEvents UndoButton As System.Windows.Forms.PictureBox
    Friend WithEvents HiddenRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AutoSelectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LongProgressTimer As System.Windows.Forms.Timer
    Friend WithEvents DecimalProgressTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LastCalculateRTB As System.Windows.Forms.RichTextBox
End Class
