Public Class Question_24
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub TextBlock1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles TextBlock1.MouseDown
        RaiseEvent AnswerPressed(True)
    End Sub

    Private Sub OptionsLeft1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsLeft1.Click, OptionsLeft2.Click, OptionsRight1.Click, OptionsRight2.Click
        RaiseEvent AnswerPressed(False)
    End Sub
End Class
