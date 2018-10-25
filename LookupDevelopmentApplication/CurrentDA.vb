Imports System.Data.SqlClient

Public Class CurrentDA

    Private mdl_PIN As Integer ' = 23601


    Public WriteOnly Property PIN() As Integer
        Set(ByVal value As Integer)
            mdl_PIN = value
        End Set
    End Property


    Private Sub CurrentDA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.CurrentDAsTableAdapter.Fill_CurrentDA(Me.CZONES.CurrentDAs, New System.Nullable(Of Integer)(mdl_PIN))
            Me.DA_ReferralsTableAdapter.Fill_Referrals(CZONES.DA_Referrals, DANoTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class