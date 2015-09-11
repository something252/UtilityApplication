Public Class MultiplesFinder
    Private Const DEBUG As Boolean = False
    Private clearedOnce As Boolean = False, undoOnce As Boolean = False, locked As Boolean = False, CalculateThreadAlive As Boolean = False, _
        CalculateIntegerThreadAlive As Boolean = False
    Private workLoadLng As Long, workLoadDec As Decimal ' numbers calculated per thread
    Private threadCount As Integer = 8 ' number of threads used in calculation
    Private CalculateThread(threadCount - 1) As System.Threading.Thread
    Private endThread As Boolean = False ' used to end threads
    Private accessLock As New Object

    ' Multiples Finder takes half a number, divides that by itself ascending from 2 or 3 by 2 steppings, and finds the multiples of it.
    ' even number multiples can ONLY be: even*odd or even*even (check evens)... odd number multiples can ONLY be: odd*odd. (check odds)
    Private Sub CalculateButton1_Click(sender As Object, e As EventArgs) Handles CalculateButton1.Click
        If (Not locked) Then
            locked = True ' lock calculate button from further execution
            TimerBox.Text = Module1.Timer1("start") ' start timer

            Dim pass1 As Boolean = True, halfInput As Decimal, rawInput As Decimal, inputType As Integer
            If (InputTextBox.Text = "") OrElse (InputTextBox.Text = "0" OrElse InputTextBox.Text = "1") Then ' no input and zero/one check
                TimerBox.Text = Module1.Timer1("stop") ' stop timer
                MsgBox("Zero, one or blank input entered.", vbInformation)
            Else
                rawInput = CDec(InputTextBox.Text)
                halfInput = Math.Truncate(rawInput / 2D) ' halve the input because first half is all that's needed
                ' Truncating odd half numbers instead of rounding up combined with a "-1" in calculations may mean "input - 2" is last tested ... 
                ' ... number instead of intended "input - 1", however this should not matter at all.
                If rawInput <= 2147483647 Then ' Integer var maximum size
                    inputType = 1 ' Integer
                ElseIf rawInput <= 9223372036854775807L Then ' Long var maximum size
                    inputType = 2 ' Long
                Else ' default
                    inputType = 3 ' Decimal
                End If

                If inputType = 1 Then ' Integer datatype

                    ' does not show progress bar
                    CalculateThread(0) = New System.Threading.Thread(Sub()
                                                                         CalculateNumber(CInt(rawInput))
                                                                     End Sub)
                    CalculateThread(0).IsBackground = True
                    CalculateThread(0).Start()
                    CalculateIntegerThreadAlive = True
                ElseIf inputType = 2 Then ' Long datatype
                    ToggleInputControls() ' toggle control visibility and more
                    progress1 = 0 ' reset variable
                    ProgressBar1.Value = 0 ' reset progress
                    ProgressGroupBox.Visible = True ' show progress bar
                    text1 = "" ' reset
                    LongProgressTimer.Enabled = True
                    LongProgressTimer.Start() ' start related timer

                    workLoadLng = DetermineThreadWork(CLng(halfInput)) ' determine each threads workload
                    workLoadLngHalf = Math.Truncate(workLoadLng / 2) ' used in respective progress timer (half because every other is tested)
                    StartMultiThreading(CLng(rawInput), CLng(halfInput), workLoadLng) ' start multi-threaded thread work
                    CalculateThreadAlive = True
                ElseIf inputType = 3 Then ' Decimal datatype
                    ToggleInputControls() ' toggle control visibility and more
                    progress2 = 0 ' reset variable
                    ProgressBar1.Value = 0 ' reset progress
                    text1 = "" 'reset
                    ProgressGroupBox.Visible = True ' show progress bar
                    DecimalProgressTimer.Enabled = True
                    DecimalProgressTimer.Start() ' start related timer

                    workLoadDec = DetermineThreadWork(CDec(halfInput))
                    workLoadDecHalf = Math.Truncate(workLoadDec / 2) ' used in respective progress timer (half because every other is tested)
                    StartMultiThreading(CDec(rawInput), CDec(halfInput), workLoadDec) ' start multi-threaded thread work
                    CalculateThreadAlive = True
                End If
            End If
        End If
    End Sub

    Private Function DetermineThreadWork(ByVal halfOfInput As Object) As Object
        If TypeOf halfOfInput Is Long Then
            Return CLng(Math.Truncate(halfOfInput / CLng(threadCount))) ' round down result and last thread does remainder extra work
        ElseIf TypeOf halfOfInput Is Decimal Then
            Return CDec(Math.Truncate(halfOfInput / CDec(threadCount))) ' round down result and last thread does remainder extra work
        Else : MsgBox("Error: Null condition occured in thread work.") : Return DBNull.Value
        End If
    End Function

    Private Overloads Sub StartMultiThreading(ByVal rawInput As Long, ByVal halfInput As Long, ByVal workLoadDec As Long)
        For a As Integer = 0 To (threadCount - 1) Step 1 ' divide up workload over multiple threads
            Dim i = a
            If i = 0 Then ' first thread (0)
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, 2L, workLoadDec))
            ElseIf i = 1 Then ' second thread
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec, workLoadDec * 2L)) ' last to end (input size)
            ElseIf i = (threadCount - 1) Then ' last thread
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec * i, CLng(halfInput))) ' last to end (input size)
            Else ' other threads
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec * i, workLoadDec * (i + 1)))
            End If
            CalculateThread(i).IsBackground = True
            CalculateThread(i).Start()
        Next
    End Sub

    Private Overloads Sub StartMultiThreading(ByVal rawInput As Decimal, ByVal halfInput As Decimal, ByVal workLoadDec As Decimal)
        For a As Integer = 0 To (threadCount - 1) Step 1 ' divide up workload over multiple threads
            Dim i = a
            If i = 0 Then ' first thread (0)
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, 2D, workLoadDec))
            ElseIf i = 1 Then ' second thread
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec, workLoadDec * 2D)) ' last to end (input size)
            ElseIf i = (threadCount - 1) Then ' last thread
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec * i, CDec(halfInput))) ' last to end (input size)
            Else ' other threads
                CalculateThread(i) = New System.Threading.Thread(Sub() CalculateNumber(rawInput, workLoadDec * i, workLoadDec * (i + 1)))
            End If
            CalculateThread(i).IsBackground = True
            CalculateThread(i).Start()
        Next
    End Sub

    ' Integer inputs are single threaded, other types are multi-threaded
    Private Overloads Sub CalculateNumber(ByVal input As Integer)
        Dim evens(1) As Integer ' starts with 2 elements, each consecutive 2 elements is one pair of multiples for the solution displaying
        Dim quotient As Integer = 0 ' quotient contains division result

        Dim pass As Boolean = True ' pass is duplicate pairs of multiples prevention
        Dim startNum As Integer ' starting number in for loop count1

        ' test 1's digit place of input to find out if even or odd (mod 2)
        Dim inputString As String = CStr(input)
        If CInt(inputString.Substring(inputString.Length - 1)) Mod 2 = 0 Then ' if even numeric input
            startNum = 2 ' even numeric input
        Else ' Mod 2 = 1 (odd)
            startNum = 3 ' odd numeric input
        End If

        For count1 As Integer = startNum To (CInt(input / 2)) Step 2 ' start from 2 (evens) or 3 (odds)
            If endThread = True Then : Continue For : End If ' end thread flag
            If ((input Mod count1) = 0) Then ' DIVIDES EVENLY
                tally += 1 ' no tallies = no divisible numbers
                quotient = input / count1 ' get other multiple (besides count1)

                For tmp As Integer = 0 To (evens.Length - 1) Step 1
                    If evens(tmp) = count1 Then ' check if multiple pair already found, ex: a*b=input (a or b will re-occur and attempt to re-add multiples into array)
                        pass = False ' skip code
                        Exit For ' break
                    End If
                Next
                If (pass = False) Then
                    pass = True ' reset to true for next loop
                    Continue For ' skip rest of code
                End If

                If firstTime = False Then
                    ReDim Preserve evens((evens.Length - 1) + 2) ' add two elements to array (one for first and second multiples)
                Else : firstTime = False ' do non-first time code from now on
                End If
                If (count1 < quotient) Then ' Formatting of array (smallest number is first in pair)
                    evens(evens.Length - 2) = count1 ' puts first multiple into the array
                    evens(evens.Length - 1) = quotient ' puts second multiple into the array
                Else ' quotient < count1
                    evens(evens.Length - 2) = quotient ' puts first multiple into the array
                    evens(evens.Length - 1) = count1 ' puts second multiple into the array
                End If
            End If
        Next

        If endThread = False Then
            DisplayResults(evens, input, tally, startNum)
            tally = 0 ' reset value
            firstTime = True ' reset value
            locked = False ' release calculate button lock
        End If
    End Sub

    Private tally As Integer ' tally helps check for no divisible pairs
    Private firstTime As Boolean = True ' firstTime is for one time execution flag
    Private evensLng(1) As Long ' starts with 2 elements, each consecutive 2 elements is one pair of multiples for the solution displaying
    Private Overloads Sub CalculateNumber(ByVal input As Long, ByVal inputStart As Long, ByVal inputEnd As Long)
        Dim quotient As Long = 0L ' quotient contains division result

        Dim flag1 As Boolean = False ' flag is true for last thread in calcuation (display results purposes)
        Dim pass As Boolean = True ' pass is duplicate pairs of multiples prevention
        Dim startNum As Integer ' when var equals 2 it means input is even and 3 means it is odd

        ' test 1's digit place of input to find out if even or odd (mod 2)
        Dim inputStr As String = CStr(input)
        If CInt(inputStr.Substring(inputStr.Length - 1)) Mod 2 = 0 Then ' if even numeric input
            startNum = 2 ' even numeric input
        Else ' Mod 2 = 1 (odd)
            startNum = 3 ' odd numeric input
            inputStart += 1 ' add one to inputStart, making it odd
        End If

        If inputEnd = Math.Truncate(input / 2L) Then ' right half of equal sign should be same as approximately line 24
            inputEnd -= 1
            flag1 = True
        End If ' do not test input itself (minus 1)

        For count As Long = inputStart To (inputEnd) Step 2L ' start from 2 (evens) or 3 (odds)
            If endThread = True Then : Continue For : End If ' end thread flag
            If flag1 = True Then : Me.progress1 += 1 : End If ' last thread adds to timer progress
            If ((input Mod count) = 0L) Then ' DIVIDES EVENLY
                SyncLock accessLock ' only one thread at a time can use evensLng() variable
                    tally += 1 ' no tallies = no divisible number pairs
                    quotient = input / count ' get other multiple (besides count)

                    For tmp As Integer = 0 To (evensLng.Length - 1) Step 1
                        If evensLng(tmp) = count Then ' check if multiple pair already found, ex: a*b=input (a or b will re-occur and attempt to re-add multiples into array)
                            pass = False ' skip rest of code flag
                            Exit For ' break
                        End If
                    Next
                    If (pass = False) Then
                        pass = True ' reset to true for next loop
                        Continue For ' skip rest of code
                    End If

                    If firstTime = False Then
                        ReDim Preserve evensLng((evensLng.Length - 1) + 2) ' add two elements to array (one for first and second multiples)
                    Else ' firstTime = True
                        firstTime = False ' do non-first time code from now on
                    End If
                    If (count < quotient) Then ' Formatting of array (smallest number is first in pair)
                        evensLng(evensLng.Length - 2) = count ' puts first multiple into the array
                        evensLng(evensLng.Length - 1) = quotient ' puts second multiple into the array
                    Else ' quotient < count1
                        evensLng(evensLng.Length - 2) = quotient ' puts first multiple into the array
                        evensLng(evensLng.Length - 1) = count ' puts second multiple into the array
                    End If
                End SyncLock
            End If
        Next

        If endThread = False AndAlso flag1 = True Then ' only last thread may enter
            While (pass)
                pass = False
                For a As Integer = 0 To (threadCount - 2) Step 1 ' test all except last thread (the thread executing this)
                    If CalculateThread(a).IsAlive = True Then
                        pass = True ' repeat while loop until other threads finish executation
                    End If
                Next
            End While ' while loop ends when all except last thread finish executation
            LongProgressTimer.Stop()
            LongProgressTimer.Enabled = False

            DisplayResults(evensLng, input, tally, startNum)
            tally = 0 ' reset value
            firstTime = True ' reset value
            ReDim evensLng(1) ' reset evensLng back to 2 elements
            locked = False ' release calculate button lock
        End If
    End Sub

    Private evensDec(1) As Decimal ' starts with 2 elements, each consecutive 2 elements is one pair of multiples for the solution displaying
    Private Overloads Sub CalculateNumber(ByVal input As Decimal, ByVal inputStart As Decimal, ByVal inputEnd As Decimal)
        Dim quotient As Decimal = 0D ' quotient contains division result

        Dim flag1 As Boolean = False ' flag is true for last thread in calcuation (display results purposes)
        Dim pass As Boolean = True ' pass is duplicate pairs of multiples prevention
        Dim startNum As Integer ' when var equals 2 it means input is even and 3 means it is odd

        ' test 1's digit place of input to find out if even or odd (mod 2)
        Dim inputStr As String = CStr(input)
        If CInt(inputStr.Substring(inputStr.Length - 1)) Mod 2 = 0 Then ' if even numeric input
            startNum = 2 ' even numeric input
        Else ' Mod 2 = 1 (odd)
            startNum = 3 ' odd numeric input
            inputStart += 1 ' add one to inputStart, making it odd
        End If

        If inputEnd = Math.Truncate(input / 2D) Then ' right half of equal sign should be same as approximately line 24
            inputEnd -= 1
            flag1 = True
        End If ' do not test input itself (minus 1)

        For count As Decimal = inputStart To (inputEnd) Step 2D ' start from 2 (evens) or 3 (odds)
            If endThread = True Then : Continue For : End If ' end thread flag
            If flag1 = True Then : Me.progress1 += 1 : End If ' last thread adds to timer progress
            If ((input Mod count) = 0D) Then ' DIVIDES EVENLY
                SyncLock accessLock ' only one thread at a time can use evensDec() variable
                    tally += 1 ' no tallies = no divisible number pairs
                    quotient = input / count ' get other multiple (besides count)

                    For tmp As Integer = 0 To (evensDec.Length - 1) Step 1
                        If evensDec(tmp) = count Then ' check if multiple pair already found, ex: a*b=input (a or b will re-occur and attempt to re-add multiples into array)
                            pass = False ' skip rest of code flag
                            Exit For ' break
                        End If
                    Next
                    If (pass = False) Then
                        pass = True ' reset to true for next loop
                        Continue For ' skip rest of code
                    End If

                    If firstTime = False Then
                        ReDim Preserve evensDec((evensDec.Length - 1) + 2) ' add two elements to array (one for first and second multiples)
                    Else : firstTime = False ' do non-first time code from now on
                    End If
                    If (count < quotient) Then ' Formatting of array (smallest number is first in pair)
                        evensDec(evensDec.Length - 2) = count ' puts first multiple into the array
                        evensDec(evensDec.Length - 1) = quotient ' puts second multiple into the array
                    Else ' quotient < count1
                        evensDec(evensDec.Length - 2) = quotient ' puts first multiple into the array
                        evensDec(evensDec.Length - 1) = count ' puts second multiple into the array
                    End If
                End SyncLock
            End If
        Next

        If endThread = False AndAlso flag1 = True Then ' only last thread may enter
            While (pass)
                pass = False
                For a As Integer = 0 To (threadCount - 2) Step 1 ' test all except last thread (the thread executing this)
                    If CalculateThread(a).IsAlive = True Then
                        pass = True ' repeat while loop until other threads finish executation
                    End If
                Next
            End While ' while loop ends when all except last thread finish executation
            LongProgressTimer.Stop()
            LongProgressTimer.Enabled = False

            DisplayResults(evensDec, input, tally, startNum)
            tally = 0 ' reset value
            firstTime = True ' reset value
            ReDim evensDec(1) ' reset evensDec back to 2 elements
            locked = False ' release calculate button lock
        End If
    End Sub

    Private Sub DisplayResults(ByRef evens As Object, ByRef input As Object, ByRef tally As Integer, ByRef startNum As Integer)
        Control.CheckForIllegalCrossThreadCalls = False

        AppendText(vbNewLine + vbNewLine)
        AppendText("Number: " + CStr(input) + vbNewLine)

        Dim firstTime As Boolean ' firstTime is for one time execution flag
        If (tally = 0) Then ' no multiples found (prime number)
            AppendText(vbTab + "    THERE ARE NO DIVISIBLE NUMBERS" + vbNewLine + vbNewLine + _
                                    vbTab + "*/*/*/*/*/*/*" + vbTab + "PRIME NUMBER" + vbTab + "*/*/*/*/*/*/*" + vbNewLine)
        Else ' Found multiples
            AppendText(vbNewLine + vbTab + vbTab + "**** LIST OF ALL DIVISIBLE NUMBERS ****" + vbNewLine + vbNewLine)
            firstTime = True
            If startNum = 2 Then ' even output formatting
                For count3 As Integer = 0 To (evens.Length - 1) Step 2 ' output two pairs at a time
                    If (firstTime = True) Then
                        SortMultiples(evens) ' sort array once
                        AppendText(CStr(evens(count3)) + " * " + CStr(evens(count3 + 1))) ' output multiples
                        firstTime = False
                    Else ' firstTime = False
                        AppendText(vbNewLine + CStr(evens(count3)) + " * " + CStr(evens(count3 + 1))) ' output multiples
                    End If
                Next
            Else ' odd number (normal/simple formatting)
                For count3 As Integer = 0 To (evens.Length - 1) Step 2 ' output two pairs at a time
                    If (firstTime = True) Then
                        ' odd numbers don't need sorting
                        AppendText(CStr(evens(count3)) + " * " + CStr(evens(count3 + 1))) ' output multiples
                        firstTime = False
                    Else ' firstTime = False
                        AppendText(vbNewLine + CStr(evens(count3)) + " * " + CStr(evens(count3 + 1))) ' output multiples
                    End If
                Next
            End If

            AppendText(vbNewLine)
        End If

        TimerBox.Text = Module1.Timer1("stop") ' stop timer
        'AppendText(vbNewLine + "Time Elapsed: " + TimerBox.Text + vbNewLine) ' display time elapsed
        If Not (TypeOf input Is Integer) Then
            ToggleInputControls() ' all except Integer does this
        End If
    End Sub

    ' appends text to main screens RichTextBox and file if enabled
    Private Sub AppendText(Text As String)
        If FileOutputCheckBox.Checked = True Then ' file output related
            RichTextBox1.AppendText(Text)
            My.Computer.FileSystem.WriteAllText(FileOutputDirectory & "Multiples Output.txt", Text, True)
        Else ' file output disabled
            RichTextBox1.AppendText(Text)
        End If
    End Sub

    Public Overloads Sub SortMultiples(ByRef evens() As Integer)
        Dim max As Integer = evens.Max(), min As Integer = evens.Min()
        Dim candidate As Integer = evens.Max() ' candidate for next number to be displayed (from smallest to higher multiple pairs; first in pair is checked)
        Dim inIf = False ' boolean for detecting when in a If statment
        Dim index As Integer ' index in candidate finding array
        Dim tmp1 As Integer, tmp2 As Integer

        If (min <> evens(0)) Then ' make sure min value pair is in 0 element starting position
            For tmp As Integer = (evens.Length - 2) To (2) Step -2 ' start from end and go backwards
                If evens(tmp) = min Then ' swap values
                    tmp1 = evens(0)
                    tmp2 = evens(1)
                    evens(0) = evens(tmp)
                    evens(1) = evens(tmp + 1)
                    evens(tmp) = tmp1
                    evens(tmp + 1) = tmp2
                    Exit For
                End If
            Next
        End If

        ' find minimum of array
        For y As Integer = 2 To (evens.Length - 3) Step 2
            For i As Integer = y To (evens.Length - 1) Step 2 ' check every other element (which is formatted to be smallest one in each pair)
                If (evens(i) > min) AndAlso (evens(i) < max) AndAlso (evens(i) < candidate) Then ' starts after first and smallest number is displayed
                    candidate = evens(i) ' set new candidate
                    index = i
                    inIf = True ' in this if block
                End If
            Next
            If inIf = True Then ' found candidate, the next higher number than previously found
                inIf = False ' reset
                min = candidate ' new minimum
                candidate = max ' reset candidate

                ' swap values
                tmp1 = evens(y)
                tmp2 = evens(y + 1)
                evens(y) = evens(index)
                evens(y + 1) = evens(index + 1)
                evens(index) = tmp1
                evens(index + 1) = tmp2

            Else ' inIf = False
                Exit For ' Done with sort
            End If
        Next
    End Sub

    Public Overloads Sub SortMultiples(ByRef evens() As Long)
        Dim max As Long = evens.Max(), min As Long = evens.Min()
        Dim candidate As Long = evens.Max() ' candidate for next number to be displayed (from smallest to higher multiple pairs; first in pair is checked)
        Dim inIf = False ' boolean for detecting when in a If statment
        Dim index As Integer ' index in candidate finding array
        Dim tmp1 As Long, tmp2 As Long

        If (min <> evens(0)) Then ' make sure min value pair is in 0 element starting position
            For tmp As Integer = (evens.Length - 2) To (2) Step -2 ' start from end and go backwards
                If evens(tmp) = min Then ' swap values
                    tmp1 = evens(0)
                    tmp2 = evens(1)
                    evens(0) = evens(tmp)
                    evens(1) = evens(tmp + 1)
                    evens(tmp) = tmp1
                    evens(tmp + 1) = tmp2
                    Exit For
                End If
            Next
        End If

        ' find minimum of array
        For y As Integer = 2 To (evens.Length - 3) Step 2
            For i As Integer = y To (evens.Length - 1) Step 2 ' check every other element (which is formatted to be smallest one in each pair)
                If (evens(i) > min) AndAlso (evens(i) < max) AndAlso (evens(i) < candidate) Then ' starts after first and smallest number is displayed
                    candidate = evens(i) ' set new candidate
                    index = i
                    inIf = True ' in this if block
                End If
            Next
            If inIf = True Then ' found candidate, the next higher number than previously found
                inIf = False ' reset
                min = candidate ' new minimum
                candidate = max ' reset candidate

                ' swap values
                tmp1 = evens(y)
                tmp2 = evens(y + 1)
                evens(y) = evens(index)
                evens(y + 1) = evens(index + 1)
                evens(index) = tmp1
                evens(index + 1) = tmp2

            Else ' inIf = False
                Exit For ' Done with sort
            End If
        Next
    End Sub

    Public Overloads Sub SortMultiples(ByRef evens() As Decimal)
        Dim max As Decimal = evens.Max(), min As Decimal = evens.Min()
        Dim candidate As Decimal = evens.Max() ' candidate for next number to be displayed (from smallest to higher multiple pairs; first in pair is checked)
        Dim inIf = False ' boolean for detecting when in a If statment
        Dim index As Integer ' index in candidate finding array
        Dim tmp1 As Decimal, tmp2 As Decimal

        If (min <> evens(0)) Then ' make sure min value pair is in 0 element starting position
            For tmp As Integer = (evens.Length - 2) To (2) Step -2 ' start from end and go backwards
                If evens(tmp) = min Then ' swap values
                    tmp1 = evens(0)
                    tmp2 = evens(1)
                    evens(0) = evens(tmp)
                    evens(1) = evens(tmp + 1)
                    evens(tmp) = tmp1
                    evens(tmp + 1) = tmp2
                    Exit For
                End If
            Next
        End If

        ' find minimum of array
        For y As Integer = 2 To (evens.Length - 3) Step 2
            For i As Integer = y To (evens.Length - 1) Step 2 ' check every other element (which is formatted to be smallest one in each pair)
                If (evens(i) > min) AndAlso (evens(i) < max) AndAlso (evens(i) < candidate) Then ' starts after first and smallest number is displayed
                    candidate = evens(i) ' set new candidate
                    index = i
                    inIf = True ' in this if block
                End If
            Next
            If inIf = True Then ' found candidate, the next higher number than previously found
                inIf = False ' reset
                min = candidate ' new minimum
                candidate = max ' reset candidate

                ' swap values
                tmp1 = evens(y)
                tmp2 = evens(y + 1)
                evens(y) = evens(index)
                evens(y + 1) = evens(index + 1)
                evens(index) = tmp1
                evens(index + 1) = tmp2

            Else ' inIf = False
                Exit For ' Done with sort
            End If
        Next
    End Sub

    Private progress1 As Long = 0, workLoadLngHalf As Long
    Private Sub LongProgressTimer_Tick(sender As Object, e As EventArgs) Handles LongProgressTimer.Tick
        ProgressBar1.Value = 100L * (progress1 / workLoadLngHalf) ' update progress
        text1 = CStr(ProgressBar1.Value) + "%"
        PictureBox1.Refresh()
    End Sub

    Private progress2 As Decimal = 0, workLoadDecHalf As Long
    Private Sub DecimalProgressTimer_Tick(sender As Object, e As EventArgs) Handles DecimalProgressTimer.Tick
        ProgressBar1.Value = 100D * (progress2 / workLoadDecHalf) ' update progress
        text1 = CStr(ProgressBar1.Value) + "%"
        PictureBox1.Refresh()
    End Sub

    Private text1 As String = ""
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawString(text1, New Font("Microsoft Sans Serif", 11), New SolidBrush(Color.Black), New Point(0, 0))
    End Sub

    Private Sub ToggleInputControls()
        ' toggle control visiblility and ReadOnly
        Static Dim tmp1 As Boolean = True
        BackButton.Visible = Not BackButton.Visible ' controls wont move and toggle visibility properly if back is used to hide before a number completes calculation
        ProgressGroupBox.Visible = Not ProgressGroupBox.Visible
        CalculateButton1.Visible = Not CalculateButton1.Visible
        InputTextBox.ReadOnly = Not InputTextBox.ReadOnly
        TimerBox.Visible = Not TimerBox.Visible
        Label2.Visible = Not Label2.Visible
        Label3.Visible = Not Label3.Visible
        If tmp1 Then
            Label1.Text = "Number"
            Label1.Location = New Point(Label1.Location.X + 27, Label1.Location.Y - 15) ' change location
            InputTextBox.Location = New Point(InputTextBox.Location.X, InputTextBox.Location.Y - 18) ' change location
            tmp1 = False ' toggle boolean
        Else
            Label1.Text = "Enter A Number"
            Label1.Location = New Point(Label1.Location.X - 27, Label1.Location.Y + 15) ' reset location
            InputTextBox.Location = New Point(InputTextBox.Location.X, InputTextBox.Location.Y + 18) ' reset location
            tmp1 = True ' toggle boolean
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window
        Me.Hide()
    End Sub

    Private Sub InputTextBox_Enter(sender As Object, e As EventArgs) Handles InputTextBox.Enter
        If AutoSelectCheckBox.Checked = True Then
            BeginInvoke(DirectCast(Sub() InputTextBox.SelectAll(), Action))
        End If
    End Sub

    Private Sub TimerBox_Enter(sender As Object, e As EventArgs) Handles TimerBox.Enter
        If AutoSelectCheckBox.Checked = True Then
            BeginInvoke(DirectCast(Sub() TimerBox.SelectAll(), Action))
        End If
    End Sub

    Private Sub MultiplesFinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgramIcon_32x32
        ProgressGroupBox.Location = New Point(ProgressGroupBox.Location.X, ProgressGroupBox.Location.Y - 78) ' change location

        If Not IsNothing(My.Settings.MultiplesFinderAutoSelect) Then
            AutoSelectCheckBox.Checked = My.Settings.MultiplesFinderAutoSelect
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If (Not locked) Then
            If (clearedOnce = True AndAlso Not (RichTextBox1.Text = "")) Then ' After doing else once ever, var will always be true and do this block on clear
                'System.Diagnostics.Debugger.Break()
                HiddenRichTextBox.Text = RichTextBox1.Text
                undoOnce = False ' Allows undo button to do only one undo again
                RichTextBox1.Clear()
            ElseIf clearedOnce = False Then ' false by default and from start of window form
                'System.Diagnostics.Debugger.Break()
                HiddenRichTextBox.Text = RichTextBox1.Text
                RichTextBox1.Clear()
                UndoButton.Visible = True ' First and only time undo button becomes visible
                clearedOnce = True ' set to true forever now
            End If
        End If
    End Sub

    Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
        If (Not locked) Then
            If (undoOnce = False) Then
                undoOnce = True ' only allow one undo history
                RichTextBox1.Text = HiddenRichTextBox.Text ' swap text
                RichTextBox1.SelectionStart = RichTextBox1.Text.Length ' set view to bottom-most
            End If
        End If
    End Sub

    Private Sub InputTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CalculateButton1.PerformClick()
        End If
    End Sub

    Private Sub MultiplesFinder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (CalculateThreadAlive = True OrElse CalculateIntegerThreadAlive = True) Then ' non-integer input has been used at least once
            endThread = True ' end threads early
        End If

        MainForm.Show()
        MainForm.WindowState = FormWindowState.Normal ' Unminimize Window

        My.Settings.MultiplesFinderAutoSelect = AutoSelectCheckBox.Checked
    End Sub

    Private Sub InputTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InputTextBox.Validating
        Static lastGoodInput As String = "0" ' Default is 0

        If InputTextBox.Text = "" Then
            lastGoodInput = ""
            locked = True ' lock calculation from occuring
        Else
            InputTextBox.Text = Replace(InputTextBox.Text, "-", "") ' no minus signs allowed
            If Not IsNumeric(InputTextBox.Text) Then
                MsgBox("Please enter numeric values only.", vbInformation)
                e.Cancel = True
                InputTextBox.Text = lastGoodInput ' set input back to last good input
            Else
                locked = False ' allow calculation
                InputTextBox.Text = CStr(Math.Truncate(CDec(InputTextBox.Text))) ' no decimal numbers
                lastGoodInput = InputTextBox.Text ' record good input for replacing of bad input
            End If
        End If
    End Sub

    Dim FileOutputDirectory As String = ""
    Private Sub FileOutputCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FileOutputCheckBox.CheckedChanged
        If FileOutputCheckBox.Checked = True Then ' was just false
            FileOutputDirectory = InputBox("Enter the directory for the file.", "Specify Directory", Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            If Not FileOutputDirectory = "" Then
                If Not System.IO.Directory.Exists(FileOutputDirectory) Then
                    MsgBox("Directory not specified.", MsgBoxStyle.Exclamation, "Warning")
                    Exit Sub ' directory does not exist
                Else
                    If FileOutputDirectory(FileOutputDirectory.Count - 1) <> "\" Then
                        FileOutputDirectory = FileOutputDirectory & "\"
                    End If
                End If

            Else
                FileOutputCheckBox.Checked = False
            End If
        ElseIf FileOutputCheckBox.Checked = False Then ' was just true
            'FileOutputCheckBox.Checked = False
        End If
    End Sub
End Class