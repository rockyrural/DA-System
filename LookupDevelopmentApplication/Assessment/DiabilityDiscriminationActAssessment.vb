Imports system.data.sqlclient

Public Class DiabilityDiscriminationActAssessment
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
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANO)
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


    Private Sub DiabilityDiscriminationActAssessment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then

            If CheckDataEntry() Then
            SaveData()
        Else
            If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
        End If

        End If

    End Sub

    Private Sub DiabilityDiscriminationActAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.DDAAccessAdequateYesNoExtendedComboBox.SelectedIndex = -1
        Me.DDAAccessAvailYesNoExtendedComboBox.SelectedIndex = -1
        Me.DDAAccessYesNoExtendedComboBox.SelectedIndex = -1
        Me.DDACommitteeYesNoExtendedComboBox.SelectedIndex = -1
        Me.DDAImpactYesNoExtendedComboBox.SelectedIndex = -1


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
                        .CommandText = "usp_InsertUpdateDAassessment_Disability"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@Adequate", SqlDbType.NVarChar).Value = Me.DDAAccessAdequateYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@Avail", SqlDbType.NVarChar).Value = Me.DDAAccessAvailYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@AccessYesNo", SqlDbType.NVarChar).Value = Me.DDAAccessYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@Committee", SqlDbType.NVarChar).Value = Me.DDACommitteeYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@Impact", SqlDbType.NVarChar).Value = Me.DDAImpactYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = Me.DDACommentsTextBox.Text
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



        If Me.DDAAccessAdequateYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDAAccessAdequateYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDAAccessAdequateYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDAAccessAdequateYesNoExtendedComboBox, "")

        End If

        If Me.DDAAccessAvailYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDAAccessAvailYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDAAccessAvailYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDAAccessAvailYesNoExtendedComboBox, "")

        End If

        If Me.DDAAccessYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDAAccessYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDAAccessYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDAAccessYesNoExtendedComboBox, "")

        End If

        If Me.DDACommitteeYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDACommitteeYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDACommitteeYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDACommitteeYesNoExtendedComboBox, "")

        End If

        If Me.DDAImpactYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDAImpactYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDAImpactYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDAImpactYesNoExtendedComboBox, "")

        End If




        If Me.DDACommentsTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.DDACommentsTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.DDACommentsTextBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.DDACommentsTextBox, "")

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