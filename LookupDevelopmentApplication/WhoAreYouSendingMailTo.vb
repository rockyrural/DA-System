Public Class WhoAreYouSendingMailTo


    Private _Recipient As Integer
    Public ReadOnly Property Recepient() As Integer
        Get
            Return _Recipient
        End Get
    End Property
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If rbnApplicant.Checked = False And rbnOwner.Checked = False Then
            MessageBox.Show("You are required to select an option", "Select receipient", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        Else
            If rbnOwner.Checked Then

                Me._Recipient = 1

            Else

                Me._Recipient = 2

            End If

            Me.Close()
        End If
    End Sub
End Class