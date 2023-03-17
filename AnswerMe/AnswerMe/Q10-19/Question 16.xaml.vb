Public Class Question_16
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerNumber">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressedNum(ByVal AnswerNumber As Integer)
    Private Sub OptionsLeft1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsLeft1.Click
        RaiseEvent AnswerPressedNum(15)
    End Sub

    Private Sub OptionsLeft2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsLeft2.Click
        RaiseEvent AnswerPressedNum(14)
    End Sub

    Private Sub OptionsRight1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsRight1.Click
        RaiseEvent AnswerPressedNum(12)
    End Sub

    Private Sub OptionsRight2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles OptionsRight2.Click
        RaiseEvent AnswerPressedNum(17)
    End Sub
End Class
