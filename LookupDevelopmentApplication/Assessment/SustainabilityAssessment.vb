Imports system.data.sqlclient


Public Class SustainabilityAssessment

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

    Private Sub SustainabilityAssessment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then
            If CheckDataEntry() Then
                SaveData()
            Else
                If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
        End If


        End If

    End Sub

    Private Sub SustainabilityAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.SustImpactYesNoExtendedComboBox.SelectedIndex = -1

        LoadForm()
    End Sub

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

            If TypeOf ctrl Is Button Then

                Dim cb As Button = DirectCast(ctrl, Button)

                Select Case cb.Name

                    Case "btnPlanObjectives", "btnObjectives", "btnUses"

                        cb.Enabled = True


                    Case Else

                        cb.Enabled = False

                End Select


            ElseIf TypeOf ctrl Is Windows.Forms.ComboBox Then

                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)

                cb.Enabled = False


            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = True




            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = False



            End If


            If ctrl.HasChildren Then
                LockTheForm(ctrl)
            End If
        Next
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
                        .CommandText = "usp_InsertUpdateDAassessment_Sustainability"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@IMPACTYN", SqlDbType.NVarChar).Value = Me.SustImpactYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@WASTE", SqlDbType.NVarChar).Value = Me.SustImpactWasteCommentsTextBox.Text
                        .Parameters.Add("@WATER", SqlDbType.NVarChar).Value = Me.SustImpactWaterCommentsTextBox.Text
                        .Parameters.Add("@VEGETATION", SqlDbType.NVarChar).Value = Me.SustImpactVegeCommentsTextBox.Text
                        .Parameters.Add("@COMMENT", SqlDbType.NVarChar).Value = Me.SustainGenComTextBox.Text
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



        If Me.SustImpactYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.SustImpactYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.SustImpactYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.SustImpactYesNoExtendedComboBox, "")

        End If

        If Me.SustainGenComTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.SustainGenComTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.SustainGenComTextBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.SustainGenComTextBox, "")

        End If

        If Me.SustImpactVegeCommentsTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.SustImpactVegeCommentsTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.SustImpactVegeCommentsTextBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.SustImpactVegeCommentsTextBox, "")

        End If

        If Me.SustImpactWasteCommentsTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.SustImpactWasteCommentsTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.SustImpactWasteCommentsTextBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.SustImpactWasteCommentsTextBox, "")

        End If
        If Me.SustImpactWaterCommentsTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.SustImpactWaterCommentsTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.SustImpactWaterCommentsTextBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.SustImpactWaterCommentsTextBox, "")

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
            If TypeOf ctrl Is combobox Then
                Dim cb As combobox = DirectCast(ctrl, combobox)
                cb.SelectedValue = "O"
            ElseIf TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.Text = "N/A for this proposal"
            End If
        Next

    End Sub
End Class