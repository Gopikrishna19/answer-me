Public Class Question_22
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub opt1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles opt1.MouseDown, opt3.MouseDown, opt4.MouseDown
        RaiseEvent AnswerPressed(False)
    End Sub

    Private Sub opt2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles opt2.MouseDown
        RaiseEvent AnswerPressed(True)
    End Sub
End Class
