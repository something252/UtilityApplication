<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeCalculator
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CalculateButton1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PMRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AMRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddDays = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.AddMinutes = New System.Windows.Forms.NumericUpDown()
        Me.AddHours = New System.Windows.Forms.NumericUpDown()
        Me.CurrentMinutes = New System.Windows.Forms.NumericUpDown()
        Me.CurrentHours = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ResultText3 = New System.Windows.Forms.TextBox()
        Me.ResultText4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultText1 = New System.Windows.Forms.TextBox()
        Me.ResultText2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AutoSelectCheckBox = New System.Windows.Forms.CheckBox()
        Me.AutoCalculateCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.SuppressErrorsCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(157, 193)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(126, 45)
        Me.BackButton.TabIndex = 11
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CalculateButton1
        '
        Me.CalculateButton1.Location = New System.Drawing.Point(144, 103)
        Me.CalculateButton1.Name = "CalculateButton1"
        Me.CalculateButton1.Size = New System.Drawing.Size(99, 23)
        Me.CalculateButton1.TabIndex = 6
        Me.CalculateButton1.Text = "Calculate"
        Me.CalculateButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(220, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ":"
        '
        'PMRadioButton
        '
        Me.PMRadioButton.AutoSize = True
        Me.PMRadioButton.Checked = True
        Me.PMRadioButton.Location = New System.Drawing.Point(292, 45)
        Me.PMRadioButton.Name = "PMRadioButton"
        Me.PMRadioButton.Size = New System.Drawing.Size(46, 20)
        Me.PMRadioButton.TabIndex = 2
        Me.PMRadioButton.TabStop = True
        Me.PMRadioButton.Text = "PM"
        Me.PMRadioButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Add Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Minute"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(220, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'AMRadioButton
        '
        Me.AMRadioButton.AutoSize = True
        Me.AMRadioButton.Location = New System.Drawing.Point(339, 45)
        Me.AMRadioButton.Name = "AMRadioButton"
        Me.AMRadioButton.Size = New System.Drawing.Size(46, 20)
        Me.AMRadioButton.TabIndex = 3
        Me.AMRadioButton.Text = "AM"
        Me.AMRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Time:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddDays)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.AddMinutes)
        Me.GroupBox1.Controls.Add(Me.AddHours)
        Me.GroupBox1.Controls.Add(Me.CurrentMinutes)
        Me.GroupBox1.Controls.Add(Me.CurrentHours)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ResultText3)
        Me.GroupBox1.Controls.Add(Me.AMRadioButton)
        Me.GroupBox1.Controls.Add(Me.ResultText4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ResultText1)
        Me.GroupBox1.Controls.Add(Me.ResultText2)
        Me.GroupBox1.Controls.Add(Me.PMRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CalculateButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 181)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                     Calculate Time Difference"
        '
        'AddDays
        '
        Me.AddDays.Location = New System.Drawing.Point(123, 72)
        Me.AddDays.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.AddDays.Name = "AddDays"
        Me.AddDays.Size = New System.Drawing.Size(46, 22)
        Me.AddDays.TabIndex = 24
        Me.AddDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(128, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 16)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Day"
        '
        'AddMinutes
        '
        Me.AddMinutes.Location = New System.Drawing.Point(228, 72)
        Me.AddMinutes.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.AddMinutes.Name = "AddMinutes"
        Me.AddMinutes.Size = New System.Drawing.Size(46, 22)
        Me.AddMinutes.TabIndex = 5
        Me.AddMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddHours
        '
        Me.AddHours.Location = New System.Drawing.Point(175, 72)
        Me.AddHours.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.AddHours.Name = "AddHours"
        Me.AddHours.Size = New System.Drawing.Size(46, 22)
        Me.AddHours.TabIndex = 4
        Me.AddHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurrentMinutes
        '
        Me.CurrentMinutes.Location = New System.Drawing.Point(228, 44)
        Me.CurrentMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.CurrentMinutes.Name = "CurrentMinutes"
        Me.CurrentMinutes.Size = New System.Drawing.Size(46, 22)
        Me.CurrentMinutes.TabIndex = 1
        Me.CurrentMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurrentHours
        '
        Me.CurrentHours.Location = New System.Drawing.Point(175, 44)
        Me.CurrentHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.CurrentHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CurrentHours.Name = "CurrentHours"
        Me.CurrentHours.Size = New System.Drawing.Size(46, 22)
        Me.CurrentHours.TabIndex = 0
        Me.CurrentHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CurrentHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(275, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Days from now."
        '
        'ResultText3
        '
        Me.ResultText3.Location = New System.Drawing.Point(191, 148)
        Me.ResultText3.Name = "ResultText3"
        Me.ResultText3.ReadOnly = True
        Me.ResultText3.Size = New System.Drawing.Size(26, 22)
        Me.ResultText3.TabIndex = 9
        Me.ResultText3.Text = "- -"
        Me.ResultText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultText4
        '
        Me.ResultText4.Location = New System.Drawing.Point(223, 148)
        Me.ResultText4.Name = "ResultText4"
        Me.ResultText4.ReadOnly = True
        Me.ResultText4.Size = New System.Drawing.Size(46, 22)
        Me.ResultText4.TabIndex = 10
        Me.ResultText4.Text = "0"
        Me.ResultText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Minute"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Hour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(130, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = ":"
        '
        'ResultText1
        '
        Me.ResultText1.Location = New System.Drawing.Point(86, 148)
        Me.ResultText1.Name = "ResultText1"
        Me.ResultText1.ReadOnly = True
        Me.ResultText1.Size = New System.Drawing.Size(46, 22)
        Me.ResultText1.TabIndex = 7
        Me.ResultText1.Text = "0"
        Me.ResultText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultText2
        '
        Me.ResultText2.Location = New System.Drawing.Point(139, 148)
        Me.ResultText2.Name = "ResultText2"
        Me.ResultText2.ReadOnly = True
        Me.ResultText2.Size = New System.Drawing.Size(46, 22)
        Me.ResultText2.TabIndex = 8
        Me.ResultText2.Text = "0"
        Me.ResultText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(479, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = "-"
        Me.TextBox1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(510, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "totalDays"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(501, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "twelves / 2"
        Me.Label12.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(479, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Text = "-"
        Me.TextBox2.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(553, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 9)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "add minutes"
        Me.Label13.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(555, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(31, 20)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "-"
        Me.TextBox3.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(518, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 9)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "addhours"
        Me.Label14.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(520, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(31, 20)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.Text = "-"
        Me.TextBox4.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(444, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 9)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "totalhours"
        Me.Label15.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(451, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(31, 20)
        Me.TextBox5.TabIndex = 35
        Me.TextBox5.Text = "-"
        Me.TextBox5.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(480, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 9)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "totalminutes"
        Me.Label16.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(486, 110)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(31, 20)
        Me.TextBox6.TabIndex = 33
        Me.TextBox6.Text = "-"
        Me.TextBox6.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Location = New System.Drawing.Point(501, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "values:"
        Me.Label17.Visible = False
        '
        'AutoSelectCheckBox
        '
        Me.AutoSelectCheckBox.AutoSize = True
        Me.AutoSelectCheckBox.Location = New System.Drawing.Point(20, 208)
        Me.AutoSelectCheckBox.Name = "AutoSelectCheckBox"
        Me.AutoSelectCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.AutoSelectCheckBox.TabIndex = 13
        Me.AutoSelectCheckBox.Text = "Auto Select"
        Me.AutoSelectCheckBox.UseVisualStyleBackColor = True
        '
        'AutoCalculateCheckBox
        '
        Me.AutoCalculateCheckBox.AutoSize = True
        Me.AutoCalculateCheckBox.Checked = True
        Me.AutoCalculateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoCalculateCheckBox.Location = New System.Drawing.Point(20, 191)
        Me.AutoCalculateCheckBox.Name = "AutoCalculateCheckBox"
        Me.AutoCalculateCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.AutoCalculateCheckBox.TabIndex = 12
        Me.AutoCalculateCheckBox.Text = "Auto Calculate"
        Me.AutoCalculateCheckBox.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(428, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 9)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "totalMinutes Mod 60 "
        Me.Label18.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(446, 50)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(31, 20)
        Me.TextBox7.TabIndex = 40
        Me.TextBox7.Text = "-"
        Me.TextBox7.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(505, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 9)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "totalHours Mod 12"
        Me.Label19.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(523, 51)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(31, 20)
        Me.TextBox8.TabIndex = 42
        Me.TextBox8.Text = "-"
        Me.TextBox8.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Enabled = False
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(434, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "twelves"
        Me.Label20.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(442, 166)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(31, 20)
        Me.TextBox9.TabIndex = 44
        Me.TextBox9.Text = "-"
        Me.TextBox9.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(427, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "in >=12 if"
        Me.Label21.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(439, 212)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(31, 20)
        Me.TextBox10.TabIndex = 46
        Me.TextBox10.Text = "-"
        Me.TextBox10.Visible = False
        '
        'SuppressErrorsCheckBox
        '
        Me.SuppressErrorsCheckBox.AutoSize = True
        Me.SuppressErrorsCheckBox.Location = New System.Drawing.Point(20, 225)
        Me.SuppressErrorsCheckBox.Name = "SuppressErrorsCheckBox"
        Me.SuppressErrorsCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.SuppressErrorsCheckBox.TabIndex = 29
        Me.SuppressErrorsCheckBox.Text = "Suppress Errors"
        Me.SuppressErrorsCheckBox.UseVisualStyleBackColor = True
        '
        'TimeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(431, 244)
        Me.Controls.Add(Me.SuppressErrorsCheckBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.AutoSelectCheckBox)
        Me.Controls.Add(Me.AutoCalculateCheckBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TimeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AddDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ResultText4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ResultText2 As System.Windows.Forms.TextBox
    Friend WithEvents ResultText1 As System.Windows.Forms.TextBox
    Friend WithEvents ResultText3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AutoSelectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AutoCalculateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents CurrentHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents CurrentMinutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddMinutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents SuppressErrorsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
