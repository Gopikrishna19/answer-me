Public Class Question_5
    ''' <summary>
    ''' Raises the event when the answer button is clicked
    ''' </summary>
    ''' <param name="AnswerIsCorrect">Is the answer pressed is correct?</param>
    ''' <remarks>True : Correct answer ; False : Wrong Answer</remarks>
    Public Event AnswerPressed(ByVal AnswerIsCorrect As Boolean)
    Private Sub UserControl_Loaded() Handles MyBase.Loaded
        pathCons.Opacity = 0
        pathArrow.Opacity = 0
        pathHint.Opacity = 0
        btnAns.Opacity = 0
        pathArrow.Opacity = 0
        pathMsg.Opacity = 0
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Button1.MouseMove
        pathCons.Opacity = 100
        pathArrow.Opacity = 100
        pathHint.Opacity = 100
        btnAns.Opacity = 100
        pathArrow.Opacity = 100
        pathMsg.Opacity = 100
    End Sub

    Private Sub pathCons_MouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles pathCons.MouseMove
        If pathCons.Opacity = 100 Then
            RaiseEvent AnswerPressed(False)
            UserControl_Loaded()
        End If
    End Sub

    Private Sub btnAns_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnAns.Click
        RaiseEvent AnswerPressed(True)
    End Sub
End Class
