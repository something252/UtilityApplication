Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32
        Me.NotifyIcon1.Icon = My.Resources.ProgramIcon_32x32
    End Sub

    Private Sub DiscounterButton_Click(sender As Object, e As EventArgs) Handles DiscounterButton.Click
        If (Discounter2.Visible = True) Then ' If open already
            OpenForm(Discounter2)
        ElseIf (Discounter.Visible = True) Then ' If open already
            OpenForm(Discounter)
        ElseIf Not IsNothing(My.Settings.DiscounterVersion) AndAlso My.Settings.DiscounterVersion = 1 Then
            Discounter.StartPosition = FormStartPosition.CenterScreen
            OpenForm(Discounter)
        ElseIf Not IsNothing(My.Settings.DiscounterVersion) AndAlso My.Settings.DiscounterVersion = 2 Then
            OpenForm(Discounter2)
        Else ' default
            OpenForm(Discounter2)
        End If
    End Sub

    Private Sub TimeCalculatorButton_Click(sender As Object, e As EventArgs) Handles TimeCalculatorButton.Click
        OpenForm(TimeCalculator)
    End Sub

    Private Sub MultiplesButton_Click(sender As Object, e As EventArgs) Handles MultiplesButton.Click
        OpenForm(MultiplesFinder)
    End Sub

    Private Sub CalculatorButton_Click(sender As Object, e As EventArgs) Handles AlarmButton.Click
        OpenForm(Alarm)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
        ElseIf Me.WindowState = FormWindowState.Normal Then
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then ' right click
            TrayMenu.Show()
            TrayMenu.Activate()
            TrayMenu.Width = 1 'it will be set behind the menu, so it's 1x1 pixels
            TrayMenu.Height = 1
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then ' left click
            TrayMenu.Hide()
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub AlarmToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OpenForm(Alarm)
    End Sub

    Private Sub VoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoiceToolStripMenuItem.Click
        OpenForm(Narrator)
    End Sub

    Private Sub OpenForm(ByRef Form As Object) ' what happens when a form is opened from MainForm
        Form.Show()
        Me.WindowState = FormWindowState.Minimized ' minimize MainForm
    End Sub
End Class
