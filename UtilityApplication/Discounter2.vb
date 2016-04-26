Public Class Discounter2
    Private RedButton1_Clicked As Boolean = False, RedButton2_Clicked As Boolean = False,
        RedButton3_Clicked As Boolean = True ' default is Button 3 (bottom-most) as active

    Private Sub Discounter2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32

        Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text ' set to default text

        For Each myForm As Form In My.Application.OpenForms
            If myForm.Name = Discounter.Name Then
                Me.Location = Discounter.Location
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

        DiscountTextBox1_lastGoodInput = DiscountTextBox1.Text
        DiscountTextBox2_lastGoodInput = DiscountTextBox2.Text
        Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text
        NumCompare1TextBox_lastGoodInput = NumCompare1TextBox.Text
        NumCompare2TextBox_lastGoodInput = NumCompare2TextBox.Text
    End Sub

    Private Sub Discounter2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub

    Private Sub Discounter2_FormClosing() Handles MyBase.FormClosing
        SaveSettings()
    End Sub

    Private Sub SaveSettings()
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

    Private Sub DiscountButton1_Click(sender As Object, e As EventArgs) Handles DiscountButton1.Click
        Dim Temp As String = "",
            Price As Decimal = 0.0, Discount As Decimal = 0.0

        If RedButton1_Clicked = True Then ' User gives discount and discounted price... Solve for Original Price.
            Temp = Discount1TextBox3.Text
            Price = CheckInput(Temp) ' turn string into Decimal

            Discount = CheckInput(DiscountTextBox2.Text)
            Discount = Discount * 0.01
            If Discount <> 1 Then
                TextBox1.Text = CStr(RoundResult(Price / (1 - Discount), RoundingCheckBox.Checked, RoundingNumericUpDown.Value)) ' Result
            Else
                TextBox1.Text = 0
            End If ' division by zero avoidance
        ElseIf RedButton2_Clicked = True Then ' User gives price and discounted price... Solve for Discount.
            Temp = DiscountTextBox1.Text
            Price = CheckInput(Temp) ' turn string into Decimal

            If Price <> 0 Then
                TextBox2.Text = CStr(RoundResult(100 * (1 - (CheckInput(Discount1TextBox3.Text) / Price)), RoundingCheckBox.Checked, RoundingNumericUpDown.Value)) ' Result is... discount  = 1-(discounted price)/price
            Else
                TextBox2.Text = "0"
            End If ' division by zero avoidance
        ElseIf RedButton3_Clicked = True Then ' User gives price and discount... Solve for Discounted Price.
            Temp = DiscountTextBox1.Text
            Price = CheckInput(Temp) ' turn string into Decimal

            Discount = CheckInput(DiscountTextBox2.Text)
            Discount = Discount * 0.01
            Discount1TextBox3.Text = CStr(RoundResult(Price - (Discount * Price), RoundingCheckBox.Checked, RoundingNumericUpDown.Value)) ' Result (Discounted price)
            Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text ' new good input
        Else
            Discount1TextBox3.Text = "Error #252"
        End If
    End Sub

    Public Function CheckInput(tmp As String) As Decimal ' Change to decimal and some Input catching here
        If tmp = "" OrElse tmp = "-" OrElse tmp = "." Then
            Return 0D
        Else
            Dim result As Decimal
            If Decimal.TryParse(tmp, result) Then
                Return result
            Else
                MsgBox("Value Entered is too large or invalid.", MsgBoxStyle.Critical)
                Return 0D
            End If
        End If
    End Function

    Private Sub RadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton1.MouseClick
        With Discounter
            For Each myForm As Form In My.Application.OpenForms
                If myForm.Name = Discounter.Name Then
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
        My.Settings.DiscounterVersion = 1 ' discounter is now active (1 = discounter form)
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SaveSettings()

        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
        Me.Hide()
    End Sub

    Private Sub ComparePricesButton_Click(sender As Object, e As EventArgs) Handles ComparePricesButton.Click
        ComparePricesButtonWork(NumCompare1TextBox, NumCompare2TextBox, PercentLabel1,
                                       PercentLabel2, PercentageResultTextBox1, PercentageResultTextBox2,
                                       PercentageResultTextBox3, PercentageResultTextBox4, RoundingCheckBox.Checked, RoundingNumericUpDown.Value)
    End Sub

    Public Sub ComparePricesButtonWork(ByRef NumCompare1TextBox As TextBox, ByRef NumCompare2TextBox As TextBox, ByRef PercentLabel1 As Label,
                                         ByRef PercentLabel2 As Label, ByRef PercentageResultTextBox1 As TextBox, ByRef PercentageResultTextBox2 As TextBox,
                                         ByRef PercentageResultTextBox3 As TextBox, ByRef PercentageResultTextBox4 As TextBox, ByRef RoundingCheckBox As Boolean, ByRef RoundingValue As Integer)

        Dim tmp As Decimal = 0D, tmp2 As Decimal = 0D
        tmp = CheckInput(NumCompare1TextBox.Text) ' first number
        tmp2 = CheckInput(NumCompare2TextBox.Text) ' second number

        If (tmp = tmp2) Then
            PercentLabel1.Text = "Increase From"
            PercentLabel2.Text = "Decrease From"
            PercentageResultTextBox1.Text = "0"
            PercentageResultTextBox2.Text = CStr(tmp)
            PercentageResultTextBox3.Text = "0"
            PercentageResultTextBox4.Text = CStr(tmp2)
        Else
            If (tmp < tmp2) Then
                ' no swapping needed
            ElseIf (tmp > tmp2) Then
                ' swap tmp with tmp2
                Dim a As Decimal
                a = tmp2
                tmp2 = tmp
                tmp = a
            End If
            Dim PercentageResultTextBox1Value As Decimal
            Dim PercentageResultTextBox3Value As Decimal
            If ((tmp < 0D And tmp2 > 0D) Or (tmp > 0D And tmp2 < 0D)) Then ' one negative number needs increase/decrease number (not percentage) swapped
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then
                    PercentageResultTextBox1Value = Math.Abs(((tmp2 - tmp) / (tmp)) * 100D) ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero
                End If
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then
                    PercentageResultTextBox3Value = Math.Abs(((tmp - tmp2) / (tmp2)) * 100D) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero
                End If
                PercentageResultTextBox4.Text = CStr(tmp2)
            ElseIf (tmp < 0 And tmp2 < 0) Then ' both negatives then change labels
                PercentLabel1.Text = "Decrease From"
                PercentLabel2.Text = "Increase From"
                If tmp <> 0 Then
                    PercentageResultTextBox3Value = Math.Abs(((tmp2 - tmp) / (tmp)) * 100D) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero
                End If
                PercentageResultTextBox2.Text = CStr(tmp2)
                If tmp2 <> 0 Then
                    PercentageResultTextBox1Value = Math.Abs(((tmp - tmp2) / (tmp2)) * 100D) ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero
                End If
                PercentageResultTextBox4.Text = CStr(tmp)
            Else ' Normal without any negative numbers
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then
                    PercentageResultTextBox1Value = ((tmp2 - tmp) / (tmp)) * 100D ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero
                End If
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then
                    PercentageResultTextBox3Value = Math.Abs(((tmp - tmp2) / (tmp2)) * 100D) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero
                End If
                PercentageResultTextBox4.Text = CStr(tmp2)
            End If

            ' set values and round if necessary
            If Not IsNothing(PercentageResultTextBox1Value) Then
                PercentageResultTextBox1.Text = CStr(RoundResult(PercentageResultTextBox1Value, RoundingCheckBox, RoundingValue))
            End If
            If Not IsNothing(PercentageResultTextBox3Value) Then
                PercentageResultTextBox3.Text = CStr(RoundResult(PercentageResultTextBox3Value, RoundingCheckBox, RoundingValue))
            End If

        End If
    End Sub

    Public Function RoundResult(GivenValue As Decimal, RoundingEnabled As Boolean, RoundingValue As Integer) As Decimal
        If Not IsNothing(GivenValue) Then
            If RoundingEnabled Then
                Dim Result As Decimal = Math.Round(GivenValue, RoundingValue)
                If Not Result Mod 1D = 0D Then
                    Return Result
                Else
                    Return Math.Truncate(Result)
                End If
            Else
                If Not GivenValue Mod 1D = 0D Then
                    Return GivenValue
                Else
                    Return Math.Truncate(GivenValue)
                End If
            End If
        Else
            Return Nothing
        End If
    End Function

    Private Sub SelectAllEvent(sender As Object, e As EventArgs) Handles DiscountTextBox1.Enter, DiscountTextBox2.Enter, Discount1TextBox3.Enter,
             NumCompare1TextBox.Enter, NumCompare2TextBox.Enter, TextBox1.Enter, TextBox2.Enter, PercentageResultTextBox1.Enter, PercentageResultTextBox2.Enter,
             PercentageResultTextBox3.Enter, PercentageResultTextBox4.Enter

        SelectAllText(sender, AutoSelectCheckBox.Checked)
    End Sub

    Private Sub SelectAllText(TextBoxObj As TextBox, Conditional As Boolean)
        If Conditional = True Then
            BeginInvoke(DirectCast(Sub() TextBoxObj.SelectAll(), Action))
        End If
    End Sub

    Private Sub Discount1TextBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles DiscountTextBox1.KeyDown, DiscountTextBox2.KeyDown, Discount1TextBox3.KeyDown,
            TextBox1.KeyDown, TextBox2.KeyDown
        TextBoxEnterKeyDown(sender, e, DiscountButton1)
    End Sub

    Private Sub ComparePricesTextBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles NumCompare1TextBox.KeyDown, NumCompare2TextBox.KeyDown
        TextBoxEnterKeyDown(sender, e, ComparePricesButton)
    End Sub

    Private Sub TextBoxEnterKeyDown(sender As Object, e As KeyEventArgs, ButtonObj As Button)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ButtonObj.PerformClick()
        End If
    End Sub

    Private Sub RedButton1_Click(sender As Object, e As EventArgs) Handles RedButton1.Click, RedButton1.DoubleClick
        If RedButton1_Clicked = False Then
            RedButton1_Clicked = True ' User gives discount and discounted price... Solve for Original Price.
            RedButton2_Clicked = False
            RedButton3_Clicked = False

            RedButton1.BackgroundImage = My.Resources.green_check_24_22
            RedButton2.BackgroundImage = My.Resources.red_x_24_22
            RedButton3.BackgroundImage = My.Resources.red_x_24_22
            Discount1TextBox3.BackColor = Color.FromName("Window")
            Label4.Visible = False
            Label6.Visible = False
            DiscountTextBox1.Visible = False
            Label5.Visible = True
            DiscountTextBox2.Visible = True
            Label7.Visible = True

            TextBox1.Visible = True
            Label3.Visible = True
            TextBox2.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = True

            DiscountTextBox1.ReadOnly = True
            DiscountTextBox2.ReadOnly = False
            Discount1TextBox3.ReadOnly = False

            If AutoCalculateCheckBox.Checked = True Then
                DiscountButton1.PerformClick()
            End If
        ElseIf RedButton1_Clicked = True Then ' Toggle off stuff related to Button
            RedButton3_Click(sender, e)
        End If

    End Sub

    Private Sub RedButton2_Click(sender As Object, e As EventArgs) Handles RedButton2.Click, RedButton2.DoubleClick
        If RedButton2_Clicked = False Then
            RedButton1_Clicked = False
            RedButton2_Clicked = True ' User gives price and discounted price... Solve for Discount.
            RedButton3_Clicked = False

            RedButton1.BackgroundImage = My.Resources.red_x_24_22
            RedButton2.BackgroundImage = My.Resources.green_check_24_22
            RedButton3.BackgroundImage = My.Resources.red_x_24_22
            Discount1TextBox3.BackColor = Color.FromName("Window")
            Label4.Visible = True
            Label6.Visible = True
            DiscountTextBox1.Visible = True
            Label5.Visible = False
            DiscountTextBox2.Visible = False
            Label7.Visible = False

            TextBox1.Visible = False
            Label3.Visible = False
            TextBox2.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = False

            DiscountTextBox1.ReadOnly = False
            DiscountTextBox2.ReadOnly = True
            Discount1TextBox3.ReadOnly = False

            If AutoCalculateCheckBox.Checked = True Then
                DiscountButton1.PerformClick()
            End If
        ElseIf RedButton2_Clicked = True Then ' Toggle off stuff related to Button
            RedButton3_Click(sender, e)
        End If
    End Sub

    Private Sub RedButton3_Click(sender As Object, e As EventArgs) Handles RedButton3.Click, RedButton3.DoubleClick
        If RedButton3_Clicked = False Then
            Discount1TextBox3.MaxLength = 32767 ' no longer editable, so increase maxlength
            RedButton1_Clicked = False
            RedButton2_Clicked = False
            RedButton3_Clicked = True ' Normal computation (before scenario)

            RedButton1.BackgroundImage = My.Resources.red_x_24_22
            RedButton2.BackgroundImage = My.Resources.red_x_24_22
            RedButton3.BackgroundImage = My.Resources.green_check_24_22
            Discount1TextBox3.BackColor = Color.FromName("Control")
            Label4.Visible = True
            Label6.Visible = True
            DiscountTextBox1.Visible = True
            Label5.Visible = True
            DiscountTextBox2.Visible = True
            Label7.Visible = True
            TextBox1.Visible = False
            Label3.Visible = False
            TextBox2.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False

            DiscountTextBox1.ReadOnly = False
            DiscountTextBox2.ReadOnly = False
            Discount1TextBox3.ReadOnly = True

            If AutoCalculateCheckBox.Checked = True Then
                DiscountButton1.PerformClick()
            End If
        End If
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox1.TextChanged, DiscountTextBox2.TextChanged, Discount1TextBox3.TextChanged
        TextChanged_PerformClick(DiscountButton1, AutoCalculateCheckBox.Checked)
    End Sub

    Private Sub NumCompareTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumCompare1TextBox.TextChanged, NumCompare2TextBox.TextChanged
        TextChanged_PerformClick(ComparePricesButton, AutoCalculateCheckBox.Checked)
    End Sub

    Private Sub TextChanged_PerformClick(ByRef ButtonObj As Button, Conditional As Boolean)
        If (Conditional = True) Then
            ButtonObj.PerformClick()
        End If
    End Sub

    Dim DiscountTextBox1_lastGoodInput As String
    Private Sub DiscountTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DiscountTextBox1.Validating
        Validator(sender, e, DiscountTextBox1_lastGoodInput)
        DiscountTextBox1_lastGoodInput = DiscountTextBox1.Text
    End Sub

    Dim DiscountTextBox2_lastGoodInput As String
    Private Sub DiscountTextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DiscountTextBox2.Validating
        Validator(sender, e, DiscountTextBox2_lastGoodInput)
        DiscountTextBox2_lastGoodInput = DiscountTextBox2.Text
    End Sub

    Dim Discount1TextBox3_lastGoodInput As String
    Private Sub Discount1TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox3.Validating
        Validator(sender, e, Discount1TextBox3_lastGoodInput)
        Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text
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
        DiscountButton1.PerformClick()
        ComparePricesButton.PerformClick()
    End Sub

    Private Sub RoundingNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles RoundingNumericUpDown.ValueChanged
        DiscountButton1.PerformClick()
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