Public Class TimeCalculator
    ' (need truncate, no auto truncate in VB) https://en.wikibooks.org/wiki/Visual_Basic_.NET/Arithmetic_operators#Rounding
    Private timetext As String = "PM"

    Private Sub CalculateButton1_Click(sender As Object, e As EventArgs) Handles CalculateButton1.Click
        Dim t1 As Integer = 0, t2 As Integer = "0", t3 As Integer = 0, t4 As Integer = 0, _
        totalHours As Integer = 0, totalMinutes As Integer = 0, totalDays As Integer = 0, twelves As Integer = 0

        TextBox1.Text = "--" : TextBox2.Text = "--" : TextBox3.Text = "--" : TextBox4.Text = "--" : TextBox5.Text = "--"  ' debug related
        TextBox6.Text = "--" : TextBox7.Text = "--" : TextBox8.Text = "--" : TextBox9.Text = "--" : TextBox10.Text = "--" ' debug related

        If (CurrentHours.Text = "") Then : t1 = 0 : Else : t1 = CInt(CurrentHours.Text) : End If
        If (CurrentMinutes.Text = "") Then : t2 = 0 : Else : t2 = CInt(CurrentMinutes.Text) : End If
        If PMRadioButton.Checked = True Then
            timetext = "PM" ' PM
        ElseIf AMRadioButton.Checked = True Then
            timetext = "AM" ' AM
        End If
        If (AddHours.Text = "" OrElse AddDays.Text = "") Then : t3 = 0 : Else : t3 = CInt(AddHours.Text) + (CInt(AddDays.Text) * 24) : End If
        If (AddMinutes.Text = "") Then : t4 = 0 : Else : t4 = CInt(AddMinutes.Text) : End If

        totalHours = (t1 Mod 12) + t3 ' add together hours to get total (t1 mod 12 so 12 PM is = to 0)
        totalMinutes = t2 + t4 ' add together minutes to get total
        If (totalMinutes >= 60) Then ' minutes handling
            totalHours = totalHours + Math.Truncate(totalMinutes / 60) ' convert minutes to hours and add to totalhours
            TextBox7.Text = totalMinutes Mod 60
            totalMinutes = totalMinutes Mod 60 ' put remainder minutes back into totalminutes
        End If

        If (totalHours >= 12) Then ' hours check
            TextBox10.Text = "T"
            ' find out number of 12's in total hours
            twelves = Math.Truncate(totalHours / 12) ' total number of 12's in totalHours goes into twelves variable
            TextBox8.Text = totalHours Mod 12
            totalHours = totalHours Mod 12 ' put remainder hours back into totalHours
            If (totalHours = 0) Then ' 12 mod 12 = 0, 24 mod 12 = 0 etc.
                totalHours = 12
            End If

            TextBox9.Text = twelves
            If (timetext = "PM") Then ' if current time starts out as "PM"
                If ((twelves = 1) OrElse twelves = 2) Then ' Initial 12-ish hours and currently PM check for correcting days
                    totalDays = totalDays + 1
                ElseIf (twelves >= 3 AndAlso (twelves Mod 2) = 1) Then ' twelves is odd (3, 5, 7 etc)
                    totalDays = totalDays + 1 + CInt(Math.Truncate(twelves / 2)) ' days from current time (one day is 2 twelves)
                ElseIf (twelves >= 3 AndAlso (twelves Mod 2) = 0) Then ' twelves is even (4, 6, 8 etc)
                    totalDays = totalDays + CInt(Math.Truncate(twelves / 2))
                End If
                TextBox2.Text = CStr(Math.Truncate(twelves / 2))
                TextBox1.Text = CStr(totalDays)
            ElseIf (timetext = "AM") Then ' if current time starts out as "AM"
                If (twelves >= 2) Then
                    totalDays = totalDays + CInt(Math.Truncate(twelves / 2)) ' days from current time (one day is 2 twelves)
                End If
            End If
            If (twelves = 1 AndAlso t1 < 12) Then ' if current hours were less than 12 but is now 12 hours atleast
                SwapMeridiem(timetext)
            ElseIf ((twelves Mod 2) = 1) Then ' if odd twelves, then change PM <--> AM else stays the same
                SwapMeridiem(timetext)
            End If
        End If

        If totalHours = 0 Then
            ResultText1.Text = "12" ' (t1 Mod 12 = 0, if no hours added then totalHours would equal 0)
        Else
            ResultText1.Text = CStr(totalHours) ' total hours result
        End If
        If (totalMinutes < 10) Then ' add a zero for low minutes
            ResultText2.Text = "0" + CStr(totalMinutes) ' total minutes result
        Else
            ResultText2.Text = CStr(totalMinutes) ' total minutes result
        End If
        ResultText3.Text = timetext ' AM/PM result
        ResultText4.Text = CStr(totalDays) ' total days result

        TextBox5.Text = totalHours : TextBox6.Text = totalMinutes : TextBox3.Text = t4 : TextBox4.Text = t3 ' debug related
    End Sub

    Private Sub SwapMeridiem(ByRef timetext As String)
        If (timetext = "PM") Then ' (PM)
            timetext = "AM"
        Else ' (timetext = "AM")    (AM)
            timetext = "PM"
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
        Me.Hide()
    End Sub

    Private Sub CurrentHours_Click(sender As Object, e As EventArgs) Handles CurrentHours.Click
        If AutoSelectCheckBox.Checked = True Then : CurrentHours.Select(0, CurrentHours.Text.Length) : End If
    End Sub

    Private Sub CurrentMinutes_Click(sender As Object, e As EventArgs) Handles CurrentMinutes.Click
        If AutoSelectCheckBox.Checked = True Then : CurrentMinutes.Select(0, CurrentMinutes.Text.Length) : End If
    End Sub

    Private Sub AddDays_Click(sender As Object, e As EventArgs) Handles AddDays.Click
        If AutoSelectCheckBox.Checked = True Then : AddDays.Select(0, AddDays.Text.Length) : End If
    End Sub

    Private Sub AddHours_Click(sender As Object, e As EventArgs) Handles AddHours.Click
        If AutoSelectCheckBox.Checked = True Then : AddHours.Select(0, AddHours.Text.Length) : End If
    End Sub

    Private Sub AddMinutes_Click(sender As Object, e As EventArgs) Handles AddMinutes.Click
        If AutoSelectCheckBox.Checked = True Then : AddMinutes.Select(0, AddMinutes.Text.Length) : End If
    End Sub

    Private Sub ResultText1_Click(sender As Object, e As EventArgs) Handles ResultText1.Click
        If AutoSelectCheckBox.Checked = True Then : ResultText1.Select(0, ResultText1.Text.Length) : End If
    End Sub

    Private Sub ResultText2_Click(sender As Object, e As EventArgs) Handles ResultText2.Click
        If AutoSelectCheckBox.Checked = True Then : ResultText2.Select(0, ResultText2.Text.Length) : End If
    End Sub

    Private Sub ResultText3_Click(sender As Object, e As EventArgs) Handles ResultText3.Click
        If AutoSelectCheckBox.Checked = True Then : ResultText3.Select(0, ResultText3.Text.Length) : End If
    End Sub

    Private Sub ResultText4_Click(sender As Object, e As EventArgs) Handles ResultText4.Click
        If AutoSelectCheckBox.Checked = True Then : ResultText4.Select(0, ResultText4.Text.Length) : End If
    End Sub

    Private Sub TimeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32

        If Not IsNothing(My.Settings.TimeCalcAutoCalculate) Then
            AutoCalculateCheckBox.Checked = My.Settings.TimeCalcAutoCalculate
        End If
        If Not IsNothing(My.Settings.TimeCalcAutoSelect) Then
            AutoSelectCheckBox.Checked = My.Settings.TimeCalcAutoSelect
        End If
        If Not IsNothing(My.Settings.TimeCalcSuppressErrors) Then
            SuppressErrorsCheckBox.Checked = My.Settings.TimeCalcSuppressErrors
        End If
    End Sub

    Private Sub CurrentHours_KeyDown(sender As Object, e As KeyEventArgs) Handles CurrentHours.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub CurrentMinutes_KeyDown(sender As Object, e As KeyEventArgs) Handles CurrentMinutes.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub AddDays_KeyDown(sender As Object, e As KeyEventArgs) Handles AddDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub AddHours_KeyDown(sender As Object, e As KeyEventArgs) Handles AddHours.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub AddMinutes_KeyDown(sender As Object, e As KeyEventArgs) Handles AddMinutes.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub TimeCalculator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window

        My.Settings.TimeCalcAutoCalculate = AutoCalculateCheckBox.Checked
        My.Settings.TimeCalcAutoSelect = AutoSelectCheckBox.Checked
        My.Settings.TimeCalcSuppressErrors = SuppressErrorsCheckBox.Checked
    End Sub

    Private Sub CurrentHours_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CurrentHours.Validating
        Static lastGoodInput As String = 1 ' default

        If CurrentHours.Text = "" Then
            lastGoodInput = ""
        ElseIf CurrentHours.Text = "-" Then
            CurrentHours.Text = lastGoodInput
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Current hour should not be negative.", vbInformation) : End If
        ElseIf Not IsNumeric(CurrentHours.Text) Then
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Please enter numeric values only.", vbInformation) : End If
            e.Cancel = True
            CurrentHours.Text = lastGoodInput ' set input back to last good input
        Else
            Dim tmp As Integer = CInt(CurrentHours.Text) ' Current Hours
            If (tmp < 1 OrElse tmp > 12) Then
                CurrentHours.Text = lastGoodInput ' default back to last good input
                If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Please enter 1 - 12 for current hours.", vbInformation) : End If
            Else
                CurrentHours.Text = CStr(Math.Abs(CInt(CurrentHours.Text))) ' no negatives (especially from copy paste)
                lastGoodInput = CurrentHours.Text ' record good input for replacing of bad input
            End If
        End If
    End Sub


    Private Sub CurrentMinutes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CurrentMinutes.Validating
        Static lastGoodInput As String = 0 ' default
        If CurrentMinutes.Text = "" Then
            lastGoodInput = ""
        ElseIf CurrentMinutes.Text = "-" Then
            CurrentMinutes.Text = lastGoodInput
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Current minute should not be negative.", vbInformation) : End If
        ElseIf Not IsNumeric(CurrentMinutes.Text) Then
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Please enter numeric values only.", vbInformation) : End If
            e.Cancel = True
            CurrentMinutes.Text = lastGoodInput ' set input back to last good input
        Else
            Dim tmp As Integer = CInt(CurrentMinutes.Text) ' Current Minutes
            If ((tmp > 59) OrElse (tmp < 0)) Then ' check if any minutes are wrong
                CurrentMinutes.Text = lastGoodInput
                If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Please enter 0 - 59 for current minutes.", vbInformation) : End If
            Else
                CurrentMinutes.Text = CStr(Math.Abs(CInt(CurrentMinutes.Text))) ' no negatives (especially from copy paste)
                lastGoodInput = CurrentMinutes.Text ' record good input for replacing of bad input
            End If
        End If
    End Sub

    Private Sub AddDays_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddDays.Validating
        Static lastGoodInput As String = 0 ' default
        Add_Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub AddHours_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddHours.Validating
        Static lastGoodInput As String = 0 ' default
        Add_Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub AddMinutes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddMinutes.Validating
        Static lastGoodInput As String = 0 ' default
        Add_Validator(sender, e, lastGoodInput)
    End Sub

    Private Sub Add_Validator(ByRef sender As Object, ByRef e As System.ComponentModel.CancelEventArgs, ByRef lastGoodInput As String)
        If sender.Text = "" Then
            lastGoodInput = ""
        ElseIf sender.Text = "-" Then
            sender.Text = lastGoodInput
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Added minutes should not be negative.", vbInformation) : End If
        ElseIf Not IsNumeric(sender.Text) Then
            If SuppressErrorsCheckBox.Checked = False Then : MsgBox("Please enter numeric values only.", vbInformation) : End If
            e.Cancel = True
            sender.Text = lastGoodInput ' set input back to last good input
        Else
            sender.Text = CStr(Math.Abs(CInt(sender.Text))) ' no negatives (especially from copy paste)
            lastGoodInput = sender.Text ' record good input for replacing of bad input
        End If
    End Sub

    Private Sub PMRadioButton_MouseClick(sender As Object, e As MouseEventArgs) Handles PMRadioButton.MouseClick
        timetext = "PM"
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub AMRadioButton_MouseClick(sender As Object, e As MouseEventArgs) Handles AMRadioButton.MouseClick
        timetext = "AM"
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub CurrentHours_TextChanged(sender As Object, e As EventArgs) Handles CurrentHours.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub CurrentMinutes_TextChanged(sender As Object, e As EventArgs) Handles CurrentMinutes.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub AddDays_TextChanged(sender As Object, e As EventArgs) Handles AddDays.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub AddHours_TextChanged(sender As Object, e As EventArgs) Handles AddHours.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

    Private Sub AddMinutes_TextChanged(sender As Object, e As EventArgs) Handles AddMinutes.TextChanged
        If (AutoCalculateCheckBox.Checked = True) Then : CalculateButton1.PerformClick() : End If
    End Sub

End Class