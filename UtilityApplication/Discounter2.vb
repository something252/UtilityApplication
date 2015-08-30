Public Class Discounter2
    Private standardMaxLength As Integer = 15
    Private RedButton1_Clicked As Boolean = False, RedButton2_Clicked As Boolean = False, _
        RedButton3_Clicked As Boolean = True ' default is Button 3 (bottom-most) as active

    Private Sub Discount1Button1_Click(sender As Object, e As EventArgs) Handles Discount1Button1.Click
        Dim tmp As String = "", _
            price As Decimal = 0.0, discount As Decimal = 0.0

        If RedButton1_Clicked = True Then ' User gives discount and discounted price... Solve for Original Price.
            tmp = Discount1TextBox3.Text
            price = CheckInput(tmp) ' turn string into Decimal

            discount = CheckInput(Discount1TextBox2.Text)
            discount = discount * 0.01
            If discount <> 1 Then : TextBox1.Text = CStr(price / (1 - discount)) ' Result
            Else : TextBox1.Text = 0 : End If ' division by zero avoidance
        ElseIf RedButton2_Clicked = True Then ' User gives price and discounted price... Solve for Discount.
            tmp = Discount1TextBox1.Text
            price = CheckInput(tmp) ' turn string into Decimal

            If price <> 0 Then : TextBox2.Text = CStr(100 * (1 - (CheckInput(Discount1TextBox3.Text) / price))) ' Result is... discount  = 1-(discounted price)/price
            Else : TextBox2.Text = "0" : End If ' division by zero avoidance
        ElseIf RedButton3_Clicked = True Then ' User gives price and discount... Solve for Discounted Price.
            tmp = Discount1TextBox1.Text
            price = CheckInput(tmp) ' turn string into Decimal

            discount = CheckInput(Discount1TextBox2.Text)
            discount = discount * 0.01
            Discount1TextBox3.Text = CStr(price - (discount * price)) ' Result (Discounted price)
            Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text ' new good input
        Else
            Discount1TextBox3.Text = "Error #252"
        End If
    End Sub

    Protected Function CheckInput(tmp As String) As Decimal ' Change to decimal and some Input catching here
        If tmp = "" Then
            Return 0.0
        ElseIf tmp = "-" Then
            Return -0.0
        Else
            Return CDec(tmp) ' convert string
        End If
    End Function

    Private Sub RadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton1.MouseClick
        With Discounter
            .Show()
            .Location = Me.Location
            .AutoCalculateCheckBox.Checked = Me.AutoCalculateCheckBox.Checked
            .AutoSelectCheckBox.Checked = Me.AutoSelectCheckBox.Checked
            .SuppressErrorsCheckBox.Checked = Me.SuppressErrorsCheckBox.Checked
        End With
        MainForm.discounterHistory = 0 ' discounter is now active (0 = discounter form)
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
        Me.Hide()
    End Sub

    Private Sub ComparePricesButton_Click(sender As Object, e As EventArgs) Handles ComparePricesButton.Click
        Dim tmp As Decimal = 0.0, tmp2 As Decimal = 0.0
        tmp = CheckInput(TextBox5.Text) ' first number
        tmp2 = CheckInput(TextBox6.Text) ' second number

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
            If ((tmp < 0 And tmp2 > 0) Or (tmp > 0 And tmp2 < 0)) Then ' one negative number needs increase/decrease number (not percentage) swapped
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then
                    PercentageResultTextBox1.Text = CStr(Math.Abs(((tmp2 - tmp) / (tmp)) * 100)) ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then
                    PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox4.Text = CStr(tmp2)
            ElseIf (tmp < 0 And tmp2 < 0) Then ' both negatives then change labels
                PercentLabel1.Text = "Decrease From"
                PercentLabel2.Text = "Increase From"
                If tmp <> 0 Then
                    PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp2 - tmp) / (tmp)) * 100)) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox2.Text = CStr(tmp2)
                If tmp2 <> 0 Then
                    PercentageResultTextBox1.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox4.Text = CStr(tmp)
            Else ' Normal without any negative numbers
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then
                    PercentageResultTextBox1.Text = CStr(((tmp2 - tmp) / (tmp)) * 100) ' Result
                Else
                    PercentageResultTextBox1.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then
                    PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else
                    PercentageResultTextBox3.Text = "0" ' division by zero avoidance
                End If
                PercentageResultTextBox4.Text = CStr(tmp2)
            End If
        End If
    End Sub

    Private Sub Discount1TextBox1_Enter(sender As Object, e As EventArgs) Handles Discount1TextBox1.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount1TextBox1.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount1TextBox2_Enter(sender As Object, e As EventArgs) Handles Discount1TextBox2.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount1TextBox2.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount1TextBox3_Enter(sender As Object, e As EventArgs) Handles Discount1TextBox3.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount1TextBox3.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox5.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox6.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox1.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox2.SelectAll(), Action)) : End If
    End Sub

    Private Sub PercentageResultTextBox1_Enter(sender As Object, e As EventArgs) Handles PercentageResultTextBox1.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() PercentageResultTextBox1.SelectAll(), Action)) : End If
    End Sub

    Private Sub PercentageResultTextBox2_Enter(sender As Object, e As EventArgs) Handles PercentageResultTextBox2.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() PercentageResultTextBox2.SelectAll(), Action)) : End If
    End Sub

    Private Sub PercentageResultTextBox3_Enter(sender As Object, e As EventArgs) Handles PercentageResultTextBox3.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() PercentageResultTextBox3.SelectAll(), Action)) : End If
    End Sub

    Private Sub PercentageResultTextBox4_Enter(sender As Object, e As EventArgs) Handles PercentageResultTextBox4.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() PercentageResultTextBox4.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount1TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount1TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : ComparePricesButton.PerformClick() : End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then : e.SuppressKeyPress = True : ComparePricesButton.PerformClick() : End If
    End Sub

    Private Sub RedButton1_Click(sender As Object, e As EventArgs) Handles RedButton1.Click
        If RedButton1_Clicked = False Then
            Discount1TextBox3.MaxLength = standardMaxLength ' editable now, so set textbox to desired max length
            RedButton1_Clicked = True ' User gives discount and discounted price... Solve for Original Price.
            RedButton2_Clicked = False
            RedButton3_Clicked = False

            Me.RedButton1.BackgroundImage = My.Resources.green_check_24_22
            Me.RedButton2.BackgroundImage = My.Resources.red_x_24_22
            Me.RedButton3.BackgroundImage = My.Resources.red_x_24_22
            Me.Discount1TextBox3.BackColor = Color.FromName("Window")
            Me.Label4.Visible = False
            Me.Label6.Visible = False
            Me.Discount1TextBox1.Visible = False
            Me.Label5.Visible = True
            Me.Discount1TextBox2.Visible = True
            Me.Label7.Visible = True

            Me.TextBox1.Visible = True
            Me.Label3.Visible = True
            Me.TextBox2.Visible = False
            Me.Label9.Visible = False
            Me.Label10.Visible = False
            Me.Label11.Visible = True

            Me.Discount1TextBox1.ReadOnly = True
            Me.Discount1TextBox2.ReadOnly = False
            Me.Discount1TextBox3.ReadOnly = False

            If AutoCalculateCheckBox.Checked = True Then
                Discount1Button1.PerformClick()
            End If
        ElseIf RedButton1_Clicked = True Then ' Toggle off stuff related to Button
            RedButton3_Click(sender, e)
        End If

    End Sub

    Private Sub RedButton2_Click(sender As Object, e As EventArgs) Handles RedButton2.Click
        If RedButton2_Clicked = False Then
            Discount1TextBox3.MaxLength = standardMaxLength ' editable now, so set textbox to desired max length
            RedButton1_Clicked = False
            RedButton2_Clicked = True ' User gives price and discounted price... Solve for Discount.
            RedButton3_Clicked = False

            Me.RedButton1.BackgroundImage = My.Resources.red_x_24_22
            Me.RedButton2.BackgroundImage = My.Resources.green_check_24_22
            Me.RedButton3.BackgroundImage = My.Resources.red_x_24_22
            Me.Discount1TextBox3.BackColor = Color.FromName("Window")
            Me.Label4.Visible = True
            Me.Label6.Visible = True
            Me.Discount1TextBox1.Visible = True
            Me.Label5.Visible = False
            Me.Discount1TextBox2.Visible = False
            Me.Label7.Visible = False

            Me.TextBox1.Visible = False
            Me.Label3.Visible = False
            Me.TextBox2.Visible = True
            Me.Label9.Visible = True
            Me.Label10.Visible = True
            Me.Label11.Visible = False

            Me.Discount1TextBox1.ReadOnly = False
            Me.Discount1TextBox2.ReadOnly = True
            Me.Discount1TextBox3.ReadOnly = False

            If AutoCalculateCheckBox.Checked = True Then
                Discount1Button1.PerformClick()
            End If
        ElseIf RedButton2_Clicked = True Then ' Toggle off stuff related to Button
            RedButton3_Click(sender, e)
        End If
    End Sub

    Private Sub RedButton3_Click(sender As Object, e As EventArgs) Handles RedButton3.Click
        If RedButton3_Clicked = False Then
            Discount1TextBox3.MaxLength = 32767 ' no longer editable, so increase maxlength
            RedButton1_Clicked = False
            RedButton2_Clicked = False
            RedButton3_Clicked = True ' Normal computation (before scenario)

            Me.RedButton1.BackgroundImage = My.Resources.red_x_24_22
            Me.RedButton2.BackgroundImage = My.Resources.red_x_24_22
            Me.RedButton3.BackgroundImage = My.Resources.green_check_24_22
            Me.Discount1TextBox3.BackColor = Color.FromName("Control")
            Me.Label4.Visible = True
            Me.Label6.Visible = True
            Me.Discount1TextBox1.Visible = True
            Me.Label5.Visible = True
            Me.Discount1TextBox2.Visible = True
            Me.Label7.Visible = True
            Me.TextBox1.Visible = False
            Me.Label3.Visible = False
            Me.TextBox2.Visible = False
            Me.Label9.Visible = False
            Me.Label10.Visible = False
            Me.Label11.Visible = False

            Me.Discount1TextBox1.ReadOnly = False
            Me.Discount1TextBox2.ReadOnly = False
            Me.Discount1TextBox3.ReadOnly = True

            If AutoCalculateCheckBox.Checked = True Then
                Discount1Button1.PerformClick()
            End If
        End If
    End Sub

    Private Sub Discounter2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32

        Discount1TextBox3_lastGoodInput = Discount1TextBox3.Text ' set to default text
    End Sub

    Private Sub Discount1TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox1.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox2.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox3.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : ComparePricesButton.PerformClick() : End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : ComparePricesButton.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox1.Validating
        Static lastGoodInput As String = Discount1TextBox1.Text
        Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub Discount1TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox2.Validating
        Static lastGoodInput As String = Discount1TextBox2.Text
        Validator(sender, e, lastGoodInput)
    End Sub

    Property Discount1TextBox3_lastGoodInput As String ' default text set in load event
    Private Sub Discount1TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount1TextBox3.Validating
        Validator(sender, e, Discount1TextBox3_lastGoodInput)
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox5.Validating
        Static lastGoodInput As String = TextBox5.Text
        Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub TextBox6_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox6.Validating
        Static lastGoodInput As String = TextBox6.Text
        Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub Validator(ByRef sender As Object, ByRef e As System.ComponentModel.CancelEventArgs, ByRef lastGoodInput As String)
        If sender.Text = "" Then
            lastGoodInput = "" ' make usage case for this
        ElseIf sender.Text = "-" Then
            lastGoodInput = "-" ' make usage case for this
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

    Private Sub Discounter2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub

End Class