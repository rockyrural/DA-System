Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class DepositedPlanAssessment
    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private DANo As String
    Public WriteOnly Property AssessmentNo() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property


    Private _Islocked As Boolean
    Public WriteOnly Property Islocked() As Boolean
        Set(ByVal value As Boolean)
            _Islocked = value
        End Set
    End Property

    Private Sub LoadForm()
        Try
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If _Islocked Then LockTheForm(Me)


    End Sub


    Private Sub LockTheForm(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is SimpleButton Then

                Dim cb As SimpleButton = DirectCast(ctrl, SimpleButton)

                Select Case cb.Name

                    Case "btnPlanObjectives", "btnObjectives", "btnUses"

                        cb.Enabled = True


                    Case Else

                        cb.Enabled = False

                End Select


            ElseIf TypeOf ctrl Is LookUpEdit Then

                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)

                cb.ReadOnly = True


            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.ReadOnly = True




            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.ReadOnly = True



            End If


            If ctrl.HasChildren Then
                LockTheForm(ctrl)
            End If
        Next
    End Sub


    Private Sub DepositedPlanAssessment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then

            If CheckDataEntry() Then
                SaveData()
            Else
                If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
            End If

        End If

    End Sub

    Private Sub DepositedPlanAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.cboDPEasementsYN.EditValue = Nothing
        Me.cboDPRestrictsYN.EditValue = Nothing

        LoadForm()

    End Sub

    Private Sub SaveData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateDAassessment_DepositedPlan"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@RESTRICTIONSYN", SqlDbType.VarChar).Value = Me.cboDPEasementsYN.EditValue.ToString
                        .Parameters.Add("@RESTRICTION", SqlDbType.VarChar).Value = Me.txtDPRestrictComment.Text
                        .Parameters.Add("@EASEMENTSYN", SqlDbType.NVarChar).Value = Me.cboDPRestrictsYN.EditValue.ToString
                        .Parameters.Add("@EASEMENTS", SqlDbType.VarChar).Value = Me.txtDPEasements.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using


    End Sub
    Private Function CheckDataEntry() As Boolean
        Dim result As Boolean = True



        If Me.cboDPEasementsYN.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDPEasementsYN, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDPEasementsYN, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDPEasementsYN, "")

        End If

        If Me.cboDPRestrictsYN.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDPRestrictsYN, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDPRestrictsYN, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDPRestrictsYN, "")

        End If

        If Me.txtDPRestrictComment.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtDPRestrictComment, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtDPRestrictComment, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtDPRestrictComment, "")

        End If

 

        Return result
    End Function


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub btnMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMark.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = "O"
            ElseIf TypeOf ctrl Is textedit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                tb.Text = "N/A for this proposal"
            End If
        Next

    End Sub

End Class