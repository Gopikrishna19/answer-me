Public Class Question_20
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub OptionsLeft2_MouseDown() Handles OptionsLeft2.Click, OptionsRight2.Click, OptionsRight1.Click, OptionsLeft1.Click
        RaiseEvent AnswerPressed(True)
    End Sub
End Class
