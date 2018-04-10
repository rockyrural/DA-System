Public Class PDFDocumentViewer

    Private Document As String
    Public WriteOnly Property DocumentToView() As String

        Set(ByVal value As String)
            Document = value
        End Set
    End Property

    Private Sub PDFDocumentViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        With PdfViewer

            .ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel



            .LoadDocument(Document)



        End With


    End Sub
End Class