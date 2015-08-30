Public Class Alarm
    Dim loop1 As Boolean = True, pass1 As Boolean = True, endThread As Boolean = False
    'Dim keepRunning As Boolean = True ' for flagging when a loop for a thread should end
    Dim messageTime As DateTime = Now
    Public AlarmThread As System.Threading.Thread
    Public AlarmStopThread As System.Threading.Thread
    'Dim ResetThread As System.Threading.Thread
    Private accessLock As New Object


    Private Sub Alarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32
        CurrentTimer.Enabled = True ' Start current time related timer
        Dim tmp As DateTime = Now
        NumericUpDown1.Value = CDec(My.Settings.AlarmAddMinutes)
        tmp = tmp.AddMinutes(My.Settings.AlarmAddMinutes)
        AlarmTimeDatePicker.Text = tmp ' Set default alarm to 5 minutes from now
    End Sub

    Private Sub Alarm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopThread() ' stop thread(s)

        My.Settings.AlarmAddMinutes = CInt(NumericUpDown1.Value)

        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Text = "Set Alarm" Then
            'loop1 = True
            AlarmTimeDatePicker.Enabled = False
            pass1 = True
            AlarmTimer.Enabled = True
            StartButton.Text = "Cancel"
            AlarmTimeLabel.Text = AlarmTimeDatePicker.Text
            GroupBox1.BackColor = Color.Red
            StartButton.BackColor = Color.Gray
            Button1.Enabled = False
        ElseIf StartButton.Text = "Cancel" Then
            AlarmTimer.Enabled = False
            AlarmTimeDatePicker.Enabled = True
            Reset() ' reset settings
            Button1.Enabled = True
        ElseIf StartButton.Text = "Stop" Then
            'loop1 = False ' stop AlarmSound() loop1 boolean
            If pass1 Then
                pass1 = False ' prevent multiple tries
                StopThread() ' stop alarm sound thread
            End If
        End If
    End Sub

    Private Sub CurrentTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimer.Tick
        CurrentTimeLabel.Text = TimeOfDay
    End Sub

    Private Sub AlarmTimer_Tick(sender As Object, e As EventArgs) Handles AlarmTimer.Tick
        If TimeOfDay = AlarmTimeDatePicker.Text Then
            'start the work
            StartButton.Text = "Stop" ' reset button text
            AlarmTimeLabel.Text = "Right now!"
            GroupBox1.BackColor = Color.Green ' reset color
            StartButton.BackColor = Color.Gold ' reset color
            messageTime = Now ' set msgbox alarm start variable to now
            AlarmThread = New System.Threading.Thread(AddressOf AlarmSound)
            AlarmThread.IsBackground = True
            endThread = False
            AlarmThread.Start() ' start alarm sound

            'Reset() ' reset settings
            AlarmTimer.Enabled = False ' turn off this timer
        End If
    End Sub

    Dim voice As Object
    Private Sub AlarmSound()
        Control.CheckForIllegalCrossThreadCalls = False

        voice = CreateObject("SAPI.spvoice") ' voice.speak()

        For i As Integer = 0 To 100 Step 1
            voice.speak("ALARM, ALARM! TIME IS UP!") ' play alarm sound/text
            SyncLock accessLock
                If endThread = True Then
                    'keepRunning = False
                    AlarmTimeDatePicker.Enabled = True
                    Exit For
                End If
            End SyncLock
            'voice.WaitUntilDone(-1&)
            'System.Threading.Thread.Sleep(5000)
        Next

        Button1.Enabled = True
        Reset()
        ' MsgBox("Alarm started at " + CStr(messageTime) + "." + vbNewLine + "Alarm stopped at " + CStr(Now) + ".")
        endThread = False ' reset back to false for later uses
    End Sub

    Private Sub Reset()
        Control.CheckForIllegalCrossThreadCalls = False
        StartButton.Text = "Set Alarm" ' reset button text
        AlarmTimeLabel.Text = "ALARM NOT SET" ' reset alarm set to text
        GroupBox1.BackColor = System.Drawing.SystemColors.Control ' reset color
        StartButton.BackColor = System.Drawing.SystemColors.Control ' reset color
    End Sub

    Public Sub StopThread()
        SyncLock accessLock
            endThread = True
        End SyncLock
        If Not IsNothing(voice) Then
            voice.Skip("Sentence", 500)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If StartButton.Text <> "Cancel" Then
            Dim tmp As DateTime = Now
            tmp = tmp.AddMinutes(CInt(NumericUpDown1.Value))
            AlarmTimeDatePicker.Text = tmp ' Set default alarm to x minutes from now
            StartButton.PerformClick()
            My.Settings.AlarmAddMinutes = CInt(NumericUpDown1.Value) ' update saved setting
            Button1.Enabled = False
        End If
    End Sub

End Class