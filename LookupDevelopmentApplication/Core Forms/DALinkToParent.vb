Public Class DALinkToParent

    Private mdlDAno As String


    Public WriteOnly Property DaNo() As String
        Set(ByVal value As String)
            mdlDAno = value
        End Set
    End Property

    Private Sub LoadForm()
        Try
            Me.DaModLinkTableAdapter.Fill(Me.DAdatasets.DaModLink, mdlDAno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.DaModLink_ChildAppsTableAdapter.Fill(Me.DAdatasets.DaModLink_ChildApps, mdlDAno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DALinkToParent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadForm()
    End Sub


    Private Sub DaModLink_ChildAppsDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DaModLink_ChildAppsDataGridView.CellClick
        If e.RowIndex = -1 Then Exit Sub
        DevelopmentStart.PopulateForm(DaModLink_ChildAppsDataGridView.CurrentRow.Cells(0).Value.ToString)

    End Sub

    Private Sub btnLoadParent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoadParent.Click
        DevelopmentStart.PopulateForm(Me.lblDANo.Text)

    End Sub
End Class