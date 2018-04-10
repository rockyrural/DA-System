Imports System.IO
Public Class ViewerForPDF


    Private _File As MemoryStream
    Public Property FileLocation() As MemoryStream
        Get
            Return _File
        End Get
        Set(ByVal value As MemoryStream)
            _File = value
        End Set
    End Property


    Private Sub ViewerForPDF_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

        Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

            _File.WriteTo(fs)

            PdfViewer1.LoadDocument(fs)
            PdfViewer1.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible

        End Using



    End Sub
End Class