Public Class Narrator
    Private accessLock As New Object ' declaration
    Public VoiceThread As System.Threading.Thread
    Dim pass1 As Boolean = True
    Dim voice As Object

    Private Sub Narrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32
    End Sub

    Private Sub SpeakButton_Click(sender As Object, e As EventArgs) Handles SpeakButton.Click

        If SpeakButton.Text = "Speak" Then
            pass1 = True ' reset
            SpeakButton.Text = "Stop"
            SpeedTextBox.ReadOnly = True
            VoiceThread = New System.Threading.Thread(AddressOf Speech)
            VoiceThread.IsBackground = True
            VoiceThread.Start() ' start alarm sound
        ElseIf SpeakButton.Text = "Stop" Then
            If pass1 = True Then
                pass1 = False ' ddeny multiple clicks
                StopThread()
                'SpeakButton.Text = "Speak"
            End If
        End If

    End Sub

    Private Sub Speech()
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            voice = CreateObject("SAPI.spvoice") ' voice.speak()
            With voice
                '.Volume = 100
                .Rate = CInt(SpeedTextBox.Text)
                .Speak(RichTextBox1.Text) ' play alarm sound/text
            End With
        Catch ex As Exception
        End Try
        Reset()
    End Sub

    Private Delegate Sub ResetDelegate()
    Private Sub Reset()
        If Not closingFlag = True Then
            SpeakButton.Text = "Speak" ' reset back to original text
            SpeedTextBox.ReadOnly = False ' reset state
        End If
    End Sub

    Public Sub StopThread() ' used to stop all thread(s)
        If Not IsNothing(voice) Then
            voice.Skip("Sentence", 500)
        End If
    End Sub

    Private Sub SpeedTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SpeedTextBox.Validating
        Static lastGoodInput As String = "0" ' Default is 0

        If SpeedTextBox.Text = "" Then
            lastGoodInput = ""
        ElseIf Not IsNumeric(SpeedTextBox.Text) Then
            'If SuppressErrorsCheckBox.Checked = False Then
            MsgBox("Please enter numeric values only for speed.", vbInformation)
            'End If
            e.Cancel = True
            SpeedTextBox.Text = lastGoodInput ' set input back to last good input
        Else
            lastGoodInput = SpeedTextBox.Text ' record good input for replacing of bad input
        End If
    End Sub

    Dim closingFlag As Boolean = False
    Private Sub Narrator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closingFlag = True

        If Not IsNothing(voice) Then
            StopThread() ' stop thread(s)
        End If

        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
    End Sub
End Class