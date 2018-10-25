Public Class ReferralsResponsePopUp

    Public Property ResponseText() As String
        Get
            Return Me.txtResponse.Text
        End Get
        Set(ByVal value As String)
            txtResponse.Text = value
        End Set
    End Property

  
End Class