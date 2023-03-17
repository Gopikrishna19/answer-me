Public Class QuestionNumber
    Private _QuestionNumber As String
    Public Property QuestionNumber As String
        Get
            Return _QuestionNumber
        End Get
        Set(ByVal value As String)
            _QuestionNumber = value
            QNumber.Text = value
        End Set
    End Property
End Class
