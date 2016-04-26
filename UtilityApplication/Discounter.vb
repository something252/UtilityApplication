Public Class Discounter

    Private Sub Discounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32

        For Each myForm As Form In My.Application.OpenForms
            If myForm.Name = Discounter2.Name Then
                Me.Location = Discounter2.Location
            End If
        Next

        If Not IsNothing(My.Settings.DiscounterAutoCalculate) Then
            AutoCalculateCheckBox.Checked = My.Settings.DiscounterAutoCalculate
        End If
        If Not IsNothing(My.Settings.DiscounterAutoSelect) Then
            AutoSelectCheckBox.Checked = My.Settings.DiscounterAutoSelect
        End If
        If Not IsNothing(My.Settings.DiscounterSuppressErrors) Then
            SuppressErrorsCheckBox.Checked = My.Settings.DiscounterSuppressErrors
        End If
        If Not IsNothing(My.Settings.DiscounterRoundingEnabled) Then
            RoundingCheckBox.Checked = My.Settings.DiscounterRoundingEnabled
        End If
        If Not IsNothing(My.Settings.DiscounterRoundingValue) Then
            RoundingNumericUpDown.Value = My.Settings.DiscounterRoundingValue
        End If

        Discount1TextBox1_lastGoodInput = Discount1TextBox1.Text
        Discount1TextBox2_lastGoodInput = Discount1TextBox2.Text
        Discount2TextBox1_lastGoodInput = Discount2TextBox1.Text
        Discount2TextBox2_lastGoodInput = Discount2TextBox2.Text
        NumCompare1TextBox_lastGoodInput = NumCompare1TextBox.Text
        NumCompare2TextBox_lastGoodInput = NumCompare2TextBox.Text
    End Sub

    Private Sub Discounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub

    Private Sub Discounter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveSettings()
    End Sub

    Public Sub SaveSettings()
        If RadioButton1.Checked = True Then
            My.Settings.DiscounterVersion = 2
        Else
            My.Settings.DiscounterVersion = 1
        End If

        My.Settings.DiscounterAutoCalculate = AutoCalculateCheckBox.Checked
        My.Settings.DiscounterAutoSelect = AutoSelectCheckBox.Checked
        My.Settings.DiscounterSuppressErrors = SuppressErrorsCheckBox.Checked
        My.Settings.DiscounterRoundingEnabled = RoundingCheckBox.Checked
        My.Settings.DiscounterRoundingValue = RoundingNumericUpDown.Value
    End Sub

    Private Sub Discount1Button1_Click(sender As Object, e As EventArgs) Handles Discount1Button1.Click
        Dim tmp As String = "",
            price As Decimal
        tmp = Discount1TextBox1.Text
        price = Discounter2.CheckInput(tmp) ' turn string into decimal

        Dim discount As Decimal
        discount = Discounter2.CheckInput(Discount1TextBox2.Text)
        discount = discount * 0.01
        If discount <> 1D Then
            Discount1Result.Text = CStr(Discounter2.RoundResult(price / (1 - discount), RoundingCheckBox.Checked, RoundingNumericUpDown.Value)) ' Result
        Else
            Discount1Result.Text = 0
        End If ' division by zero avoidance
    End Sub

    Private Sub Discount1Button2_Click(sender As Object, e As EventArgs) Handles Discount2Button1.Click
        Dim tmp As String = "",
            price2 As Decimal
        tmp = Discount2TextBox1.Text
        price2 = Discounter2.CheckInput(tmp) ' turn string into decimal

        Dim Discount As Decimal
        Discount = Discounter2.CheckInput(Discount2TextBox2.Text)
        Discount = Discount * 0.01
        Discount2Result.Text = CStr(Discounter2.RoundResult(price2 - (Discount * price2), RoundingCheckBox.Checked, RoundingNumericUpDown.Value)) ' Result (Discounted price)
    End Sub

    Private Sub RadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton1.MouseClick
        With Discounter2
            For Each myForm As Form In My.Application.OpenForms
                If myForm.Name = Discounter2.Name Then
                    .Location = Location
                End If
            Next
            .Show()
            .Location = Location
            .AutoCalculateCheckBox.Checked = AutoCalculateCheckBox.Checked
            .AutoSelectCheckBox.Checked = AutoSelectCheckBox.Checked
            .SuppressErrorsCheckBox.Checked = SuppressErrorsCheckBox.Checked
            .RoundingCheckBox.Checked = RoundingCheckBox.Checked
            .RoundingNumericUpDown.Value = RoundingNumericUpDown.Value
        End With
        My.Settings.DiscounterVersion = 2 ' discounter2 is now active (2 = discounter2 form)
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SaveSettings()

        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
        Me.Hide()
    End Sub

    Private Sub Discounter1ComparePricesButton_Click(sender As Object, e As EventArgs) Handles ComparePricesButton.Click
        Discounter2.ComparePricesButtonWork(NumCompare1TextBox, NumCompare2TextBox, PercentLabel1,
                                       PercentLabel2, PercentageResultTextBox1, PercentageResultTextBox2,
                                       PercentageResultTextBox3, PercentageResultTextBox4, RoundingCheckBox.Checked, RoundingNumericUpDown.Value)
    End Sub

    Private Sub SelectAllEvent(sender As Object, e As EventArgs) Handles Discount1TextBox1.Enter, Discount1TextBox2.Enter, Discount2TextBox1.Enter, Discount2TextBox2.Enter,
             NumCompare1TextBox.Enter, NumCompare2TextBox.Enter, Discount1Result.Enter, Discount2Result.Enter, PercentageResultTextBox1.Enter, PercentageResultTextBox2.Enter,
             PercentageResultTextBox3.Enter, PercentageResultTextBox4.Enter

        SelectAllText(sender, AutoSelectCheckBox.Checked)
    End Sub

    Private Sub SelectAllText(TextBoxObj As TextBox, Conditional As Boolean)
        If Conditional = True Then
            BeginInvoke(DirectCast(Sub() TextBoxObj.SelectAll(), Action))
        End If
    End Sub

    Private Sub Discount1TextBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount1TextBox1.KeyDown, Discount1TextBox2.KeyDown
        TextBoxEnterKeyDown(sender, e, Discount1Button1)
    End Sub

    Private Sub Discount2TextBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount2TextBox1.KeyDown, Discount2TextBox2.KeyDown
        TextBoxEnterKeyDown(sender, e, Discount2Button1)
    End Sub

    Private Sub ComparePricesTextBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles NumCompare1TextBox.KeyDown, NumCompare2TextBox.KeyDown
        TextBoxEnterKeyDown(sender, e, ComparePricesButton)
    End Sub

    Public Sub TextBoxEnterKeyDown(sender As Object, e As KeyEventArgs, ButtonObj As Button)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ButtonObj.PerformClick()
        End If
    End Sub

    Private Sub Discount1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox1.TextChanged, Discount1TextBox2.TextChanged
        TextChanged_PerformClick(Discount1Button1, AutoCalculateCheckBox.Checked)
    End Sub

    Private Sub Discount2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Discount2TextBox1.TextChanged, Discount2TextBox2.TextChanged
        TextChanged_PerformClick(Discount2Button1, AutoCalculateCheckBox.Checked)
    End Sub

    Private Sub NumCompareTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumCompare1TextBox.TextChanged, NumCompare2TextBox.TextChanged
        TextChanged_PerformClick(ComparePricesButton, AutoCalculateCheckBox.Checked)
    End Sub

    Public Sub TextChanged_PerformClick(ByRef ButtonObj As Button, Conditional As Boolean)
        If (Conditional = True) Then
            ButtonObj.PerformClick()
        End If
    End Sub

    Dim Discount1TextBox1_lastGoodInput As String
    Private Sub Discount1TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox1.Validating
        Validator(sender, e, Discount1TextBox1_lastGoodInput)
        Discount1TextBox1_lastGoodInput = Discount1TextBox1.Text
    End Sub

    Dim Discount1TextBox2_lastGoodInput As String
    Private Sub Discount1TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox2.Validating
        Validator(sender, e, Discount1TextBox2_lastGoodInput)
        Discount1TextBox2_lastGoodInput = Discount1TextBox2.Text
    End Sub

    Dim Discount2TextBox1_lastGoodInput As String
    Private Sub Discount2TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount2TextBox1.Validating
        Validator(sender, e, Discount2TextBox1_lastGoodInput)
        Discount2TextBox1_lastGoodInput = Discount2TextBox1.Text
    End Sub

    Dim Discount2TextBox2_lastGoodInput As String
    Private Sub Discount2TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount2TextBox2.Validating
        Validator(sender, e, Discount2TextBox2_lastGoodInput)
        Discount2TextBox2_lastGoodInput = Discount2TextBox2.Text
    End Sub

    Dim NumCompare1TextBox_lastGoodInput As String
    Private Sub NumCompare1TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumCompare1TextBox.Validating
        Validator(sender, e, NumCompare1TextBox_lastGoodInput)
        NumCompare1TextBox_lastGoodInput = NumCompare1TextBox.Text
    End Sub

    Dim NumCompare2TextBox_lastGoodInput As String
    Private Sub NumCompare2TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumCompare2TextBox.Validating
        Validator(sender, e, NumCompare2TextBox_lastGoodInput)
        NumCompare2TextBox_lastGoodInput = NumCompare2TextBox.Text
    End Sub

    Private Sub RoundingCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RoundingCheckBox.CheckedChanged
        Discount1Button1.PerformClick()
        Discount2Button1.PerformClick()
        ComparePricesButton.PerformClick()
    End Sub

    Private Sub RoundingNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles RoundingNumericUpDown.ValueChanged
        Discount1Button1.PerformClick()
        Discount2Button1.PerformClick()
        ComparePricesButton.PerformClick()
    End Sub

    Private Sub Validator(ByRef sender As Object, ByRef e As System.ComponentModel.CancelEventArgs, ByRef lastGoodInput As String)
        If sender.Text = "" OrElse sender.Text = "-" OrElse sender.Text = "." Then
            lastGoodInput = sender.Text ' make usage case for this
        ElseIf Not IsNumeric(sender.Text) Then
            If SuppressErrorsCheckBox.Checked = False Then
                MsgBox("Please enter numeric values only.", vbInformation)
            End If
            e.Cancel = True
            sender.Text = lastGoodInput ' set input back to last good input
        Else
            If sender.Text.Substring(sender.Text.Length - 1) = "-" Or sender.Text.Substring(sender.Text.Length - 1) = "+" Then ' if last char is minus sign
                sender.Text = sender.Text.Remove(sender.Text.Length - 1) ' prevent "0-" or "22-" inputs from getting through which isNumeric does not catch (appears to be purely cosmetic however)
                sender.SelectionStart = sender.Text.Length ' set cursor to end
            End If
            lastGoodInput = sender.Text ' record good input for replacing of bad input
        End If
    End Sub
End Class