<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discounter
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
        Me.Discount1TextBox1 = New System.Windows.Forms.TextBox()
        Me.Discount1TextBox2 = New System.Windows.Forms.TextBox()
        Me.Discount1Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Discount1Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Discount2Result = New System.Windows.Forms.TextBox()
        Me.Discount2TextBox1 = New System.Windows.Forms.TextBox()
        Me.Discount2TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Discount2Button1 = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PercentageResultTextBox4 = New System.Windows.Forms.TextBox()
        Me.PercentageResultTextBox2 = New System.Windows.Forms.TextBox()
        Me.PercentageResultTextBox1 = New System.Windows.Forms.TextBox()
        Me.PercentageResultTextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.PercentLabel2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PercentLabel1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComparePricesButton = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AutoCalculateCheckBox = New System.Windows.Forms.CheckBox()
        Me.AutoSelectCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuppressErrorsCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Discount1TextBox1
        '
        Me.Discount1TextBox1.Location = New System.Drawing.Point(223, 55)
        Me.Discount1TextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount1TextBox1.MaxLength = 15
        Me.Discount1TextBox1.Name = "Discount1TextBox1"
        Me.Discount1TextBox1.Size = New System.Drawing.Size(119, 22)
        Me.Discount1TextBox1.TabIndex = 0
        Me.Discount1TextBox1.Text = "0"
        Me.Discount1TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Discount1TextBox2
        '
        Me.Discount1TextBox2.Location = New System.Drawing.Point(223, 83)
        Me.Discount1TextBox2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount1TextBox2.MaxLength = 15
        Me.Discount1TextBox2.Name = "Discount1TextBox2"
        Me.Discount1TextBox2.Size = New System.Drawing.Size(119, 22)
        Me.Discount1TextBox2.TabIndex = 1
        Me.Discount1TextBox2.Text = "0"
        Me.Discount1TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Discount1Button1
        '
        Me.Discount1Button1.Location = New System.Drawing.Point(223, 111)
        Me.Discount1Button1.Name = "Discount1Button1"
        Me.Discount1Button1.Size = New System.Drawing.Size(119, 23)
        Me.Discount1Button1.TabIndex = 2
        Me.Discount1Button1.Text = "Calculate"
        Me.Discount1Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price After Discount Was Applied:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Discount That Was Applied:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(210, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(340, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "%"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Discount1Result)
        Me.GroupBox1.Controls.Add(Me.Discount1TextBox1)
        Me.GroupBox1.Controls.Add(Me.Discount1TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Discount1Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 220)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "     Price amount BEFORE applied discount (find original price)"
        '
        'Discount1Result
        '
        Me.Discount1Result.BackColor = System.Drawing.SystemColors.Control
        Me.Discount1Result.Location = New System.Drawing.Point(223, 179)
        Me.Discount1Result.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount1Result.Name = "Discount1Result"
        Me.Discount1Result.ReadOnly = True
        Me.Discount1Result.Size = New System.Drawing.Size(119, 22)
        Me.Discount1Result.TabIndex = 3
        Me.Discount1Result.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(210, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 160)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Original Price"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Discount2Result)
        Me.GroupBox2.Controls.Add(Me.Discount2TextBox1)
        Me.GroupBox2.Controls.Add(Me.Discount2TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Discount2Button1)
        Me.GroupBox2.Controls.Add(Me.Label88)
        Me.GroupBox2.Controls.Add(Me.Label99)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 220)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "   Price amount AFTER discount is applied (find discount price)"
        '
        'Discount2Result
        '
        Me.Discount2Result.BackColor = System.Drawing.SystemColors.Control
        Me.Discount2Result.Location = New System.Drawing.Point(223, 176)
        Me.Discount2Result.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount2Result.Name = "Discount2Result"
        Me.Discount2Result.ReadOnly = True
        Me.Discount2Result.Size = New System.Drawing.Size(119, 22)
        Me.Discount2Result.TabIndex = 7
        Me.Discount2Result.Text = "0"
        '
        'Discount2TextBox1
        '
        Me.Discount2TextBox1.Location = New System.Drawing.Point(223, 55)
        Me.Discount2TextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount2TextBox1.MaxLength = 15
        Me.Discount2TextBox1.Name = "Discount2TextBox1"
        Me.Discount2TextBox1.Size = New System.Drawing.Size(119, 22)
        Me.Discount2TextBox1.TabIndex = 4
        Me.Discount2TextBox1.Text = "0"
        Me.Discount2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Discount2TextBox2
        '
        Me.Discount2TextBox2.Location = New System.Drawing.Point(223, 83)
        Me.Discount2TextBox2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Discount2TextBox2.MaxLength = 15
        Me.Discount2TextBox2.Name = "Discount2TextBox2"
        Me.Discount2TextBox2.Size = New System.Drawing.Size(119, 22)
        Me.Discount2TextBox2.TabIndex = 5
        Me.Discount2TextBox2.Text = "0"
        Me.Discount2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(210, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(119, 58)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Original Price:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(228, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Discounted Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(340, 86)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "%"
        '
        'Discount2Button1
        '
        Me.Discount2Button1.Location = New System.Drawing.Point(223, 111)
        Me.Discount2Button1.Name = "Discount2Button1"
        Me.Discount2Button1.Size = New System.Drawing.Size(119, 23)
        Me.Discount2Button1.TabIndex = 6
        Me.Discount2Button1.Text = "Calculate"
        Me.Discount2Button1.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(160, 86)
        Me.Label88.Margin = New System.Windows.Forms.Padding(0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(63, 16)
        Me.Label88.TabIndex = 7
        Me.Label88.Text = "Discount:"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Location = New System.Drawing.Point(210, 58)
        Me.Label99.Margin = New System.Windows.Forms.Padding(0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(15, 16)
        Me.Label99.TabIndex = 8
        Me.Label99.Text = "$"
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(541, 242)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(126, 45)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoCheck = False
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(25, 238)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(10, 3, 3, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(108, 17)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Single Discounter"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PercentageResultTextBox4)
        Me.GroupBox3.Controls.Add(Me.PercentageResultTextBox2)
        Me.GroupBox3.Controls.Add(Me.PercentageResultTextBox1)
        Me.GroupBox3.Controls.Add(Me.PercentageResultTextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.PercentLabel2)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.PercentLabel1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ComparePricesButton)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(824, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 220)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "    Compare prices to find percentage difference between them"
        '
        'PercentageResultTextBox4
        '
        Me.PercentageResultTextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PercentageResultTextBox4.Location = New System.Drawing.Point(261, 179)
        Me.PercentageResultTextBox4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.PercentageResultTextBox4.Name = "PercentageResultTextBox4"
        Me.PercentageResultTextBox4.ReadOnly = True
        Me.PercentageResultTextBox4.Size = New System.Drawing.Size(81, 22)
        Me.PercentageResultTextBox4.TabIndex = 14
        Me.PercentageResultTextBox4.Text = "0"
        '
        'PercentageResultTextBox2
        '
        Me.PercentageResultTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PercentageResultTextBox2.Location = New System.Drawing.Point(261, 151)
        Me.PercentageResultTextBox2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.PercentageResultTextBox2.Name = "PercentageResultTextBox2"
        Me.PercentageResultTextBox2.ReadOnly = True
        Me.PercentageResultTextBox2.Size = New System.Drawing.Size(81, 22)
        Me.PercentageResultTextBox2.TabIndex = 12
        Me.PercentageResultTextBox2.Text = "0"
        '
        'PercentageResultTextBox1
        '
        Me.PercentageResultTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PercentageResultTextBox1.Location = New System.Drawing.Point(78, 151)
        Me.PercentageResultTextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.PercentageResultTextBox1.Name = "PercentageResultTextBox1"
        Me.PercentageResultTextBox1.ReadOnly = True
        Me.PercentageResultTextBox1.Size = New System.Drawing.Size(81, 22)
        Me.PercentageResultTextBox1.TabIndex = 11
        Me.PercentageResultTextBox1.Text = "0"
        '
        'PercentageResultTextBox3
        '
        Me.PercentageResultTextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PercentageResultTextBox3.Location = New System.Drawing.Point(78, 179)
        Me.PercentageResultTextBox3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.PercentageResultTextBox3.Name = "PercentageResultTextBox3"
        Me.PercentageResultTextBox3.ReadOnly = True
        Me.PercentageResultTextBox3.Size = New System.Drawing.Size(81, 22)
        Me.PercentageResultTextBox3.TabIndex = 13
        Me.PercentageResultTextBox3.Text = "0"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(223, 55)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TextBox5.MaxLength = 15
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(119, 22)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(223, 83)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TextBox6.MaxLength = 15
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(119, 22)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Text = "0"
        '
        'PercentLabel2
        '
        Me.PercentLabel2.AutoSize = True
        Me.PercentLabel2.BackColor = System.Drawing.Color.Transparent
        Me.PercentLabel2.Location = New System.Drawing.Point(159, 182)
        Me.PercentLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.PercentLabel2.Name = "PercentLabel2"
        Me.PercentLabel2.Size = New System.Drawing.Size(102, 16)
        Me.PercentLabel2.TabIndex = 19
        Me.PercentLabel2.Text = "Decrease From"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(60, 154)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "%"
        '
        'PercentLabel1
        '
        Me.PercentLabel1.AutoSize = True
        Me.PercentLabel1.BackColor = System.Drawing.Color.Transparent
        Me.PercentLabel1.Location = New System.Drawing.Point(163, 154)
        Me.PercentLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.PercentLabel1.Name = "PercentLabel1"
        Me.PercentLabel1.Size = New System.Drawing.Size(94, 16)
        Me.PercentLabel1.TabIndex = 16
        Me.PercentLabel1.Text = "Increase From"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(60, 182)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "%"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(210, 86)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 16)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(120, 58)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "First Number:"
        '
        'ComparePricesButton
        '
        Me.ComparePricesButton.Location = New System.Drawing.Point(223, 111)
        Me.ComparePricesButton.Name = "ComparePricesButton"
        Me.ComparePricesButton.Size = New System.Drawing.Size(119, 23)
        Me.ComparePricesButton.TabIndex = 10
        Me.ComparePricesButton.Text = "Calculate"
        Me.ComparePricesButton.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(101, 86)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Second Number:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(210, 58)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 16)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "$"
        '
        'AutoCalculateCheckBox
        '
        Me.AutoCalculateCheckBox.AutoSize = True
        Me.AutoCalculateCheckBox.Checked = True
        Me.AutoCalculateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoCalculateCheckBox.Location = New System.Drawing.Point(25, 256)
        Me.AutoCalculateCheckBox.Name = "AutoCalculateCheckBox"
        Me.AutoCalculateCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.AutoCalculateCheckBox.TabIndex = 17
        Me.AutoCalculateCheckBox.Text = "Auto Calculate"
        Me.AutoCalculateCheckBox.UseVisualStyleBackColor = True
        '
        'AutoSelectCheckBox
        '
        Me.AutoSelectCheckBox.AutoSize = True
        Me.AutoSelectCheckBox.Location = New System.Drawing.Point(25, 274)
        Me.AutoSelectCheckBox.Name = "AutoSelectCheckBox"
        Me.AutoSelectCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.AutoSelectCheckBox.TabIndex = 19
        Me.AutoSelectCheckBox.Text = "Auto Select"
        Me.AutoSelectCheckBox.UseVisualStyleBackColor = True
        '
        'SuppressErrorsCheckBox
        '
        Me.SuppressErrorsCheckBox.AutoSize = True
        Me.SuppressErrorsCheckBox.Location = New System.Drawing.Point(126, 256)
        Me.SuppressErrorsCheckBox.Name = "SuppressErrorsCheckBox"
        Me.SuppressErrorsCheckBox.Size = New System.Drawing.Size(100, 17)
        Me.SuppressErrorsCheckBox.TabIndex = 18
        Me.SuppressErrorsCheckBox.Text = "Suppress Errors"
        Me.SuppressErrorsCheckBox.UseVisualStyleBackColor = True
        '
        'Discounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(1235, 300)
        Me.Controls.Add(Me.SuppressErrorsCheckBox)
        Me.Controls.Add(Me.AutoSelectCheckBox)
        Me.Controls.Add(Me.AutoCalculateCheckBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Discounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Discounter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Discount1TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Discount1TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Discount1Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Discount1Result As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Discount2Result As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Discount2Button1 As System.Windows.Forms.Button
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Discount2TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Discount2TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PercentageResultTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PercentageResultTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PercentLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PercentageResultTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PercentLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PercentageResultTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComparePricesButton As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents AutoCalculateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AutoSelectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SuppressErrorsCheckBox As System.Windows.Forms.CheckBox
End Class
