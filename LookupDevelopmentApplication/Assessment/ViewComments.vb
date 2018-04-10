Public Class ViewComments

    Private _Islocked As Boolean
    Public WriteOnly Property Islocked() As Boolean
        Set(ByVal value As Boolean)
            _Islocked = value
        End Set
    End Property


    Public Property CommentText() As String
        Get
            Return txtNote.Text
        End Get
        Set(ByVal value As String)
            txtNote.Text = value
        End Set
    End Property

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        txtNote.ReadOnly = False
    End Sub

    Private Sub ViewComments_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnChange.Enabled = Not _Islocked

    End Sub
End Class