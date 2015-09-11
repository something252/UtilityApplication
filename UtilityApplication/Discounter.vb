Public Class Discounter

    Private Sub Discount1Button1_Click(sender As Object, e As EventArgs) Handles Discount1Button1.Click
        Dim tmp As String = "", _
            price As Decimal = 0.0
        tmp = Discount1TextBox1.Text
        price = CheckInput(tmp) ' turn string into decimal

        Dim discount As Decimal = 0.0
        discount = CheckInput(Discount1TextBox2.Text)
        discount = discount * 0.01
        If discount <> 1 Then : Discount1Result.Text = CStr(price / (1 - discount)) ' Result
        Else : Discount1Result.Text = 0 : End If ' division by zero avoidance
    End Sub

    Private Sub Discount1Button2_Click(sender As Object, e As EventArgs) Handles Discount2Button1.Click
        Dim tmp As String = "", _
            price2 As Decimal = 0.0
        tmp = Discount2TextBox1.Text
        price2 = CheckInput(tmp) ' turn string into decimal

        Dim discount As Decimal = 0.0
        discount = CheckInput(Discount2TextBox2.Text)
        discount = discount * 0.01
        Discount2Result.Text = CStr(price2 - (discount * price2)) ' Result (Discounted price)
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
        With Discounter2
            For Each myForm As Form In My.Application.OpenForms
                If myForm.Name = Discounter2.Name Then
                    .Location = Me.Location
                End If
            Next
            .Show()
            .Location = Me.Location
            .AutoCalculateCheckBox.Checked = Me.AutoCalculateCheckBox.Checked
            .AutoSelectCheckBox.Checked = Me.AutoSelectCheckBox.Checked
            .SuppressErrorsCheckBox.Checked = Me.SuppressErrorsCheckBox.Checked
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
            If ((tmp < 0 AndAlso tmp2 > 0) OrElse (tmp > 0 AndAlso tmp2 < 0)) Then ' one negative number needs increase/decrease number (not percentage) swapped
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then : PercentageResultTextBox1.Text = CStr(Math.Abs(((tmp2 - tmp) / (tmp)) * 100)) ' Result
                Else : PercentageResultTextBox1.Text = "0" : End If ' division by zero avoidance
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then : PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else : PercentageResultTextBox3.Text = "0" : End If ' division by zero avoidance
                PercentageResultTextBox4.Text = CStr(tmp2)
            ElseIf (tmp < 0 AndAlso tmp2 < 0) Then ' both negatives then change labels
                PercentLabel1.Text = "Decrease From"
                PercentLabel2.Text = "Increase From"
                If tmp <> 0 Then : PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp2 - tmp) / (tmp)) * 100)) ' Result
                Else : PercentageResultTextBox3.Text = "0" : End If ' division by zero avoidance
                PercentageResultTextBox2.Text = CStr(tmp2)
                If tmp2 <> 0 Then : PercentageResultTextBox1.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else : PercentageResultTextBox1.Text = "0" : End If ' division by zero avoidance
                PercentageResultTextBox4.Text = CStr(tmp)
            Else ' Normal without any negative numbers
                PercentLabel1.Text = "Increase From"
                PercentLabel2.Text = "Decrease From"
                If tmp <> 0 Then : PercentageResultTextBox1.Text = CStr(((tmp2 - tmp) / (tmp)) * 100) ' Result
                Else : PercentageResultTextBox1.Text = "0" : End If ' division by zero avoidance
                PercentageResultTextBox2.Text = CStr(tmp)
                If tmp2 <> 0 Then : PercentageResultTextBox3.Text = CStr(Math.Abs(((tmp - tmp2) / (tmp2)) * 100)) ' Result
                Else : PercentageResultTextBox3.Text = "0" : End If ' division by zero avoidance
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

    Private Sub Discount2TextBox1_Enter(sender As Object, e As EventArgs) Handles Discount2TextBox1.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount2TextBox1.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount2TextBox2_Enter(sender As Object, e As EventArgs) Handles Discount2TextBox2.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount2TextBox2.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox5.SelectAll(), Action)) : End If
    End Sub

    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() TextBox6.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount1Result_Enter(sender As Object, e As EventArgs) Handles Discount1Result.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount1Result.SelectAll(), Action)) : End If
    End Sub

    Private Sub Discount2Result_Enter(sender As Object, e As EventArgs) Handles Discount2Result.Enter
        If AutoSelectCheckBox.Checked = True Then : BeginInvoke(DirectCast(Sub() Discount2Result.SelectAll(), Action)) : End If
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
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Discount1Button1.PerformClick()
        End If
    End Sub

    Private Sub Discount1TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Discount1Button1.PerformClick()
        End If
    End Sub

    Private Sub Discount2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount2TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Discount2Button1.PerformClick()
        End If
    End Sub

    Private Sub Discount2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Discount2Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ComparePricesButton.PerformClick()
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ComparePricesButton.PerformClick()
        End If
    End Sub

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
    End Sub

    Private Sub Discount1TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox1.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount1TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Discount1TextBox2.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount1Button1.PerformClick() : End If
    End Sub

    Private Sub Discount2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Discount2TextBox1.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount2Button1.PerformClick() : End If
    End Sub

    Private Sub Discount2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Discount2TextBox2.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : Discount2Button1.PerformClick() : End If
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

    Private Sub Discount2TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount2TextBox1.Validating
        Static lastGoodInput As String = Discount2TextBox1.Text
        Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub Discount2TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Discount2TextBox2.Validating
        Static lastGoodInput As String = Discount2TextBox2.Text
        Validator(sender, e, lastGoodInput)
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
            If sender.Text.Substring(sender.Text.Length - 1) = "-" OrElse sender.Text.Substring(sender.Text.Length - 1) = "+" Then ' if last char is minus sign
                sender.Text = sender.Text.Remove(sender.Text.Length - 1) ' prevent "0-" or "22-" inputs from getting through which isNumeric does not catch (appears to be purely cosmetic however)
                sender.SelectionStart = sender.Text.Length ' set cursor to end
            End If
            lastGoodInput = sender.Text ' record good input for replacing of bad input
        End If
    End Sub

    Private Sub Discounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub

    Private Sub Discounter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.SaveSettings()
    End Sub

    Private Sub SaveSettings()
        My.Settings.DiscounterVersion = 1

        My.Settings.DiscounterAutoCalculate = Me.AutoCalculateCheckBox.Checked
        My.Settings.DiscounterAutoSelect = Me.AutoSelectCheckBox.Checked
        My.Settings.DiscounterSuppressErrors = Me.SuppressErrorsCheckBox.Checked
    End Sub
End Class