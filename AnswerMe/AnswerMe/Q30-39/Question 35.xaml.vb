Public Class Question_35
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Button1.MouseMove
        MainPath.Opacity = 100
        Button2.Opacity = 100
        pathCons.Opacity = 100
        pathArrow.Opacity = 100
        pathHint.Opacity = 100
        pathMsg.Opacity = 100
    End Sub

    Private Sub UserControl_Loaded() Handles MyBase.Loaded
        MainPath.Opacity = 0
        Button2.Opacity = 0
        pathCons.Opacity = 0
        pathArrow.Opacity = 0
        pathHint.Opacity = 0
        pathMsg.Opacity = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
        RaiseEvent AnswerPressed(True)
    End Sub

    Private Sub pathCons_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles pathCons.MouseMove, pathCons.MouseEnter
        If pathCons.Opacity = 100 Then
            RaiseEvent AnswerPressed(False)
            UserControl_Loaded()
        End If
    End Sub
End Class
