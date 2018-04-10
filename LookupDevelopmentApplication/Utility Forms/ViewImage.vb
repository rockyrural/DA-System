Public Class ViewImage

    Private _image As Image
    Public Property PictureToShow() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
        End Set
    End Property

    Private Sub ViewImage_Load(sender As Object, e As EventArgs) Handles Me.Load

        picImage.Image = _image
        'picImage.ClientSize = New System.Drawing.Size(picImage.Image.Width + 2, picImage.Image.Height + 2)

    End Sub
End Class