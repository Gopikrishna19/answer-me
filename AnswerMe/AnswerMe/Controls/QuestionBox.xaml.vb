Public Class QuestionBox

    Private _QuestionContent As String
    Public Property QuestionContent As String
        Get
            Return _QuestionContent
        End Get
        Set(ByVal value As String)
            Question.Text = value
            _QuestionContent = value
        End Set
    End Property
End Class
