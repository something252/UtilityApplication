Module Module1

    Public Function Timer1(tmp As String) As String
        Static start_time As DateTime
        Static stop_time As DateTime
        Dim elapsed_time As TimeSpan

        If tmp = "Start" Or tmp = "start" Then
            start_time = Now
        ElseIf tmp = "Stop" Or tmp = "stop" Then
            stop_time = Now
            elapsed_time = stop_time.Subtract(start_time)
            Return elapsed_time.TotalSeconds.ToString("0.000000")
        End If
        Return ""
    End Function
End Module