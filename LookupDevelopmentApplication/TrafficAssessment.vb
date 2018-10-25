Imports system.data.sqlclient

Public Class TrafficAssessment
    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private DANo As String
    Public WriteOnly Property AssessmentNo() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TrafficAssessment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckDataEntry() Then
            SaveData()
        Else
            If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
        End If

    End Sub

    Private Sub TrafficAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.TrafficAccessYesNoExtendedComboBox.SelectedIndex = -1
        Me.TrafficCarpkYesNoExtendedComboBox.SelectedIndex = -1
        Me.TrafficCommitteeYesNoExtendedComboBox.SelectedIndex = -1
        Me.TrafficLoadingYesNoExtendedComboBox.SelectedIndex = -1
        Me.TrafficRoadYesNoExtendedComboBox.SelectedIndex = -1
        LoadForm()

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

    Private Sub LoadForm()
        Try
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SaveData()

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_InsertUpdateDAassessment_Traffic"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@LEVELDESC", SqlDbType.NVarChar).Value = Me.TrafficLevelDescTextBox.Text
                        .Parameters.Add("@ROADYN", SqlDbType.NVarChar).Value = Me.TrafficRoadYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@ACCESSYN", SqlDbType.NVarChar).Value = Me.TrafficAccessYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@ACCESSCOMENT", SqlDbType.NText).Value = Me.TrafficAccessCommentsTextBox.Text
                        .Parameters.Add("@LOADINGYN", SqlDbType.NVarChar).Value = Me.TrafficLoadingYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@CARPARKYN", SqlDbType.NVarChar).Value = Me.TrafficCarpkYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@CAREXIST", SqlDbType.NVarChar).Value = Me.TrafficCarExistTextBox.Text
                        .Parameters.Add("@CARPREV", SqlDbType.NVarChar).Value = Me.TrafficCarPrevTextBox.Text
                        .Parameters.Add("@CARSURPLUS", SqlDbType.NVarChar).Value = Me.TrafficCarSurplusTextBox.Text
                        .Parameters.Add("@CARREQUIRED", SqlDbType.NVarChar).Value = Me.TrafficCarRequiredTextBox.Text
                        .Parameters.Add("@CARPROPOSED", SqlDbType.NVarChar).Value = Me.TrafficCarProposedTextBox.Text
                        .Parameters.Add("@CARSHORTFALL", SqlDbType.NVarChar).Value = Me.TrafficCarShortfallTextBox.Text
                        .Parameters.Add("@CARCONT", SqlDbType.NVarChar).Value = Me.TrafficCarContTextBox.Text
                        .Parameters.Add("@COMMITEYN", SqlDbType.NVarChar).Value = Me.TrafficCommitteeYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@PUBLICACCESSCOMENT", SqlDbType.NText).Value = Me.TrafficPublicAccCommentsTextBox.Text
                        .Parameters.Add("@GENCOMMENT", SqlDbType.NText).Value = Me.TrafficGenComTextBox.Text
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



        If Me.TrafficAccessYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.TrafficAccessYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.TrafficAccessYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.TrafficAccessYesNoExtendedComboBox, "")

        End If

        If Me.TrafficCarpkYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.TrafficCarpkYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.TrafficCarpkYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.TrafficCarpkYesNoExtendedComboBox, "")

        End If

        If Me.TrafficCommitteeYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.TrafficCommitteeYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.TrafficCommitteeYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.TrafficCommitteeYesNoExtendedComboBox, "")

        End If

        If Me.TrafficLoadingYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.TrafficLoadingYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.TrafficLoadingYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.TrafficLoadingYesNoExtendedComboBox, "")

        End If

        If Me.TrafficRoadYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.TrafficRoadYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.TrafficRoadYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.TrafficRoadYesNoExtendedComboBox, "")

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
End Class