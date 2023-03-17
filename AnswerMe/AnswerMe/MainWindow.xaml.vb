Imports System.Runtime.InteropServices
Imports System.Windows.Interop

Class MainWindow

    Private Property Lives As Integer
        Get
            Return Val(liveText.Text)
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                GameOver()
                liveText.Text = "5"
            Else
                liveText.Text = value.ToString
                If Not value = 5 Then
                    ErrorNav.Navigate(New WrongAnswer)
                End If
            End If
        End Set
    End Property

    Private Property Skips As Integer
        Get
            Return Val(skipText.Text)
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                skipBtn.IsEnabled = True
            Else
                skipBtn.IsEnabled = False
            End If
            skipText.Text = value.ToString
        End Set
    End Property

    Dim WithEvents q1 As Question_1
    Dim WithEvents q2 As Question_2
    Dim WithEvents q3 As Question_3
    Dim WithEvents q4 As Question_4
    Dim WithEvents q5 As Question_5
    Dim WithEvents q6 As Question_6
    Dim WithEvents q7 As Question_7
    Dim WithEvents q8 As Question_8
    Dim WithEvents q9 As Question_9
    Dim WithEvents q10 As Question_10
    Dim WithEvents q11 As Question_11
    Dim WithEvents q12 As Question_12
    Dim WithEvents q13 As Question_13
    Dim WithEvents q14 As Question_14
    Dim WithEvents q15 As Question_15
    Dim WithEvents q16 As Question_16
    Dim WithEvents q17 As Question_17
    Dim WithEvents q18 As Question_18
    Dim WithEvents q19 As Question_19
    Dim WithEvents q20 As Question_20
    Dim WithEvents q21 As Question_21
    Dim WithEvents q22 As Question_22
    Dim WithEvents q23 As Question_23
    Dim WithEvents q24 As Question_24
    Dim WithEvents q25 As Question_25
    Dim WithEvents q26 As Question_26
    Dim WithEvents q27 As Question_27
    Dim WithEvents q28 As Question_28
    Dim WithEvents q29 As Question_29
    Dim WithEvents q30 As Question_30
    Dim WithEvents q31 As Question_31
    Dim WithEvents q32 As Question_32
    Dim WithEvents q33 As Question_33
    Dim WithEvents q34 As Question_34
    Dim WithEvents q35 As Question_35
    Dim WithEvents q36 As Question_36
    Dim WithEvents q37 As Question_37
    Dim WithEvents q38 As Question_38
    Dim WithEvents q39 As Question_39
    Dim WithEvents q40 As Question_40

    Private index As Integer = 0
    Private Sub Window_Loaded() Handles MyBase.Loaded
        q1 = New Question_1
        q2 = New Question_2
        q3 = New Question_3
        q4 = New Question_4
        q5 = New Question_5
        q6 = New Question_6
        q7 = New Question_7
        q8 = New Question_8
        q9 = New Question_9
        q10 = New Question_10
        q11 = New Question_11
        q12 = New Question_12
        q13 = New Question_13
        q14 = New Question_14
        q15 = New Question_15
        q16 = New Question_16
        q17 = New Question_17
        q18 = New Question_18
        q19 = New Question_19
        q20 = New Question_20
        q21 = New Question_21
        q22 = New Question_22
        q23 = New Question_23
        q24 = New Question_24
        q25 = New Question_25
        q26 = New Question_26
        q27 = New Question_27
        q28 = New Question_28
        q29 = New Question_29
        q30 = New Question_30
        q31 = New Question_31
        q32 = New Question_32
        q33 = New Question_33
        q34 = New Question_34
        q35 = New Question_35
        q36 = New Question_36
        q37 = New Question_37
        q38 = New Question_38
        q39 = New Question_39
        q40 = New Question_40
        Skips = 0
        Lives = 5
        index = 1
        skipBtn.Content = "Skip"
        MyNav.Navigate(q1)
    End Sub

    Private Sub q1_AnswerPressed(ByVal AnswerIsCorrect As Boolean) Handles q1.AnswerPressed, q2.AnswerPressed, _
        q3.AnswerPressed, q4.AnswerPressed, q5.AnswerPressed, q6.AnswerPressed, q7.AnswerPressed, _
        q8.AnswerPressed, q9.AnswerPressed, q10.AnswerPressed, q11.AnswerPressed, q12.AnswerPressed, q13.AnswerPressed, _
        q14.AnswerPressed, q15.AnswerPressed, q17.AnswerPressed, q18.AnswerPressed, q20.AnswerPressed, _
        q21.AnswerPressed, q22.AnswerPressed, q23.AnswerPressed, q24.AnswerPressed, q25.AnswerPressed, q26.AnswerPressed, _
        q27.AnswerPressed, q28.AnswerPressed, q29.AnswerPressed, q30.AnswerPressed, q31.AnswerPressed, q32.AnswerPressed, _
        q33.AnswerPressed, q34.AnswerPressed, q35.AnswerPressed, q36.AnswerPressed, q37.AnswerPressed, q38.AnswerPressed, _
        q39.AnswerPressed

        If AnswerIsCorrect Then
            Select Case (index)
                Case 1
                    MyNav.Navigate(q3)
                    index += 2
                Case 2
                    MyNav.Navigate(q4)
                    index += 1
                Case 3
                    MyNav.Navigate(q4)
                    index += 1
                Case 4
                    MyNav.Navigate(q5)
                    index += 1
                Case 5
                    MyNav.Navigate(q6)
                    index += 1
                Case 6
                    MyNav.Navigate(q7)
                    index += 1
                Case 7
                    MyNav.Navigate(q8)
                    index += 1
                Case 8
                    MyNav.Navigate(q9)
                    index += 1
                Case 9
                    MyNav.Navigate(q10)
                    index += 1
                Case 10
                    MyNav.Navigate(q11)
                    index += 1
                    Skips += 1
                Case 11
                    MyNav.Navigate(q12)
                    index += 1
                Case 12
                    MyNav.Navigate(q13)
                    index += 1
                Case 13
                    MyNav.Navigate(q14)
                    index += 1
                Case 14
                    MyNav.Navigate(q15)
                    index += 1
                Case 15
                    MyNav.Navigate(q16)
                    index += 1
                Case 16
                    MyNav.Navigate(q17)
                    index += 1
                Case 17
                    MyNav.Navigate(q18)
                    index += 1
                Case 18
                    MyNav.Navigate(q19)
                    index += 1
                Case 20
                    MyNav.Navigate(q21)
                    index += 1
                    Skips += 1
                Case 21
                    MyNav.Navigate(q22)
                    index += 1
                Case 22
                    MyNav.Navigate(q23)
                    index += 1
                Case 23
                    MyNav.Navigate(q24)
                    index += 1
                Case 24
                    MyNav.Navigate(q25)
                    index += 1
                Case 25
                    MyNav.Navigate(q26)
                    index += 1
                Case 26
                    MyNav.Navigate(q27)
                    index += 1
                Case 27
                    MyNav.Navigate(q28)
                    index += 1
                Case 28
                    MyNav.Navigate(q29)
                    index += 1
                Case 29
                    MyNav.Navigate(q30)
                    index += 1
                Case 30
                    MyNav.Navigate(q31)
                    index += 1
                    Skips += 1
                Case 31
                    MyNav.Navigate(q32)
                    index += 1
                Case 32
                    MyNav.Navigate(q33)
                    index += 1
                Case 33
                    MyNav.Navigate(q34)
                    index += 1
                Case 34
                    MyNav.Navigate(q35)
                    index += 1
                Case 35
                    MyNav.Navigate(q36)
                    index += 1
                Case 36
                    MyNav.Navigate(q37)
                    index += 1
                Case 37
                    MyNav.Navigate(q38)
                    index += 1
                Case 38
                    MyNav.Navigate(q39)
                    index += 1
                Case 39
                    MyNav.Navigate(q40)
                    index += 1
                    skipBtn.Content = "Restart"
            End Select
        Else
            Lives -= 1
        End If
    End Sub

    Private Sub q16_AnswerPressedNum(ByVal AnswerNumber As Integer) Handles q16.AnswerPressedNum
        Select Case (AnswerNumber)
            Case 12
                MyNav.Navigate(q12)
            Case 14
                MyNav.Navigate(q14)
            Case 15
                MyNav.Navigate(q15)
            Case 17
                MyNav.Navigate(q17)
        End Select
        index = AnswerNumber
    End Sub


    Private Sub q19_AnswerPressed(ByVal AnswerIsCorrect As Boolean) Handles q19.AnswerPressed
        If AnswerIsCorrect Then
            MyNav.Navigate(q20)
            index += 1
        Else
            GameOver()
        End If
    End Sub

    Private Sub GameOver()
        ErrorNav.Navigate(New GameOverMsg)
        Window_Loaded()
    End Sub

    Private Sub Window_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs) Handles MyBase.KeyDown
        If e.Key = Key.Right Then
            If index = 28 Then
                MyNav.Navigate(q29)
                index += 1
            End If
        End If
        If e.Key = Key.D1 Then
            If index = 33 Then
                MyNav.Navigate(q34)
                index += 1
            End If
        End If
    End Sub

    Private Sub skipBtn_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles skipBtn.Click
        If index = 40 Then
            Window_Loaded()
        Else
            Skips -= 1
            q1_AnswerPressed(True)
        End If
    End Sub
End Class
