Public Class Question_33
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub OptionsRight1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsRight1.Click, OptionsRight2.Click, OptionsLeft1.Click, OptionsLeft2.Click
        RaiseEvent AnswerPressed(False)
    End Sub
End Class
