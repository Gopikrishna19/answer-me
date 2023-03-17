Public Class Question_15
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn2.Click
        RaiseEvent AnswerPressed(True)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn1.Click
        RaiseEvent AnswerPressed(False)
    End Sub
End Class
