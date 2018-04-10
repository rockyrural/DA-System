Public Class SpellCheck

    Public Event TextChanged()


    Private Sub flowDocument1_TextInput(ByVal sender As System.Object, ByVal e As System.Windows.Input.TextCompositionEventArgs) Handles flowDocument1.TextInput
        If e.Text <> String.Empty Then
            RaiseEvent TextChanged()
        End If
    End Sub
End Class
