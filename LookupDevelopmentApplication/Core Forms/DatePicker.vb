Public Class DatePicker
    Private mdlsKeyDate As String




    Public Property GetTheDate() As String
        Get
            Return mdlsKeyDate
        End Get
        Set(ByVal value As String)
            mdlsKeyDate = value
        End Set

    End Property
    Private Sub btnUpDateRego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpDateRego.Click
        mdlsKeyDate = Format(MonthCalendar1.SelectionRange.Start.Date, "dd/MM/yyyy") 'sTestDate
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        mdlsKeyDate = String.Empty
        Me.Close()
    End Sub

    Private Sub DatePicker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mdlsKeyDate <> String.Empty Then
            Me.MonthCalendar1.AddBoldedDate(CDate(mdlsKeyDate))
        End If
    End Sub
End Class