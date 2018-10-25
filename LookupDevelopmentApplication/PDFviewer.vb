Public Class PDFviewer
    Private mdlDocumentToShow As String = String.Empty
    Public WriteOnly Property DocumentToDisplay() As String
        Set(ByVal value As String)
            mdlDocumentToShow = value
        End Set
    End Property
    Private Sub PDFviewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WebBrowser1.Navigate(mdlDocumentToShow)
    End Sub
End Class