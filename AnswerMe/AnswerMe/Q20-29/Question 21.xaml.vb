Public Class Question_21
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    
    Private Sub cpath_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles cpath.MouseDown
        RaiseEvent AnswerPressed(True)
    End Sub

    Private Sub wpath1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles wpath1.MouseDown, wpath2.MouseDown
        RaiseEvent AnswerPressed(False)
    End Sub
End Class
