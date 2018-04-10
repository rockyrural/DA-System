Public Class OpenDocument
    Public WithEvents wxProcess As New Process

    Public Sub OpenVisible(ByVal sPath As String)
        Try
            wxProcess.StartInfo.FileName = sPath
            wxProcess.Start()
            wxProcess.EnableRaisingEvents = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Close()
        Try
            wxProcess.Kill()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
