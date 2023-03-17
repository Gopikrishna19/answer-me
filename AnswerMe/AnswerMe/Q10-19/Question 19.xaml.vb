Public Class Question_19

	''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub Path_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles path1.MouseDown
        RaiseEvent AnswerPressed(False)
    End Sub

    Private Sub path2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles path2.MouseDown
        RaiseEvent AnswerPressed(True)
    End Sub

End Class
