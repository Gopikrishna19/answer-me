Public Class Question_9
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn8.Click
        RaiseEvent AnswerPressed(True)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn1.Click, btn2.Click, btn3.Click, bnt4.Click, btn5.Click, btn6.Click, btn7.Click
        RaiseEvent AnswerPressed(False)
    End Sub
End Class
