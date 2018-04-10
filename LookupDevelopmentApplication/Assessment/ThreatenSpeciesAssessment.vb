Imports system.data.sqlclient


Public Class ThreatenSpeciesAssessment
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

        Dim RowCount As Integer = AAdata.DAAssessmentData.Rows.Count
        If AAdata.DAAssessmentData.Rows.Count > 0 Then

            Dim objDataRow As DataRow = AAdata.DAAssessmentData.Rows.Item(0)
            If Not IsDBNull(objDataRow.Item("ThreatSpecLiveTrees")) Then
                Select Case CInt(objDataRow.Item("ThreatSpecLiveTrees"))
                    Case 1
                        Me.rbLiveTreeAbsent.Checked = True
                    Case 2
                        Me.rbLiveTreePresent.Checked = True
                End Select
            Else

                Me.rbLiveTreeAbsent.Checked = False
                Me.rbLiveTreePresent.Checked = False
            End If

            If Not IsDBNull(objDataRow.Item("ThreatSpecDeadTrees")) Then
                Select Case CInt(objDataRow.Item("ThreatSpecDeadTrees"))
                    Case 1
                        Me.rbDeadTreeAbsent.Checked = True
                    Case 2
                        Me.rbDeadTreePresent.Checked = True
                End Select
            Else

                Me.rbLiveTreeAbsent.Checked = False
                Me.rbLiveTreePresent.Checked = False
            End If

            If Not IsDBNull(objDataRow.Item("GrdCoverMulti")) Then
                Select Case CInt(objDataRow.Item("GrdCoverMulti"))
                    Case 1
                        Me.rbUnderstoryNone.Checked = True
                    Case 2
                        Me.rbUnderstoryFew.Checked = True
                    Case 3
                        Me.rbUnderstoryWelDevel.Checked = True
                    Case 4
                        Me.rbUnderstoryContinuous.Checked = True
                End Select
            Else

                Me.rbUnderstoryNone.Checked = False
                Me.rbUnderstoryFew.Checked = False
                Me.rbUnderstoryWelDevel.Checked = False
                Me.rbUnderstoryContinuous.Checked = False

            End If

            If Not IsDBNull(objDataRow.Item("VegRemove")) Then
                Select Case CInt(objDataRow.Item("VegRemove"))
                    Case 1
                        Me.rbVegAbsent.Checked = True
                    Case 2
                        Me.rbVegPresent.Checked = True
                End Select
            Else

                Me.rbVegAbsent.Checked = False
                Me.rbVegPresent.Checked = False

            End If




        End If


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



            ElseIf TypeOf ctrl Is RadioButton Then
                Dim cb As RadioButton = DirectCast(ctrl, RadioButton)
                cb.Enabled = False



            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = False



            End If


            If ctrl.HasChildren Then
                LockTheForm(ctrl)
            End If
        Next
    End Sub


    Private Sub ThreatenSpeciesAssessment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then

            If CheckDataEntry() Then

                SaveData()
            Else

                If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True

            End If



        End If

    End Sub

    Private Sub ThreatenSpeciesAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.PropImpFaunaYesNoExtendedComboBox.SelectedIndex = -1
        Me.PropImpHabitatYesNoExtendedComboBox.SelectedIndex = -1
        Me.ThreatSpecFurtherAssYesNoExtendedComboBox.SelectedIndex = -1

        Dim EnvironPlanner As New ArrayList

        ' Add division structure entries to the arraylist
        With EnvironPlanner
            .Add(New AreaType("Yes", "Y"))
            .Add(New AreaType("No", "R"))
         End With

        With Me.cboEnvironPlanner
            .DataSource = EnvironPlanner
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

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
                        .CommandText = "usp_InsertUpdateDAassessment_ThreatenSpecies"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@FAUNA", SqlDbType.NVarChar).Value = Me.PropImpFaunaYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@HABITATE", SqlDbType.NVarChar).Value = Me.PropImpHabitatYesNoExtendedComboBox.SelectedValue.ToString()

                        If cboEnvironPlanner.SelectedIndex <> -1 Then .Parameters.Add("@ENVIRONPLAN", SqlDbType.NVarChar).Value = Me.cboEnvironPlanner.SelectedValue.ToString()

                        .Parameters.Add("@LIVETREE", SqlDbType.Int)
                        If Me.rbLiveTreeAbsent.Checked = True Then
                            .Parameters("@LIVETREE").Value = 1
                        ElseIf Me.rbLiveTreePresent.Checked = True Then
                            .Parameters("@LIVETREE").Value = 2
                        End If

                        .Parameters.Add("@DEADTREE", SqlDbType.Int)
                        If Me.rbDeadTreeAbsent.Checked = True Then
                            .Parameters("@DEADTREE").Value = 1
                        ElseIf Me.rbDeadTreePresent.Checked = True Then
                            .Parameters("@DEADTREE").Value = 2
                        End If

                        .Parameters.Add("@GRNDCOVER", SqlDbType.Int)
                        If Me.rbUnderstoryNone.Checked = True Then
                            .Parameters("@GRNDCOVER").Value = 1
                        ElseIf Me.rbUnderstoryFew.Checked = True Then
                            .Parameters("@GRNDCOVER").Value = 2
                        ElseIf Me.rbUnderstoryWelDevel.Checked = True Then
                            .Parameters("@GRNDCOVER").Value = 3
                        ElseIf Me.rbUnderstoryContinuous.Checked = True Then
                            .Parameters("@GRNDCOVER").Value = 4
                        End If


                        ''.Parameters.Add("@GRNDCOVER", SqlDbType.Int).Value = Me.PropImpFaunaYesNoExtendedComboBox.SelectedValue.ToString

                        .Parameters.Add("@ROCKNONE", SqlDbType.Bit).Value = Me.RockNoneCheckBox.CheckState
                        .Parameters.Add("@ROCKCAVES", SqlDbType.Bit).Value = Me.RockCavesCheckBox.CheckState
                        .Parameters.Add("@ROCKOUTCROPS", SqlDbType.Bit).Value = Me.RockOutcropsCheckBox.CheckState
                        .Parameters.Add("@ROCKOVERHANG", SqlDbType.Bit).Value = Me.RockOhangsCheckBox.CheckState
                        .Parameters.Add("@ROCKCREVICE", SqlDbType.Bit).Value = Me.RockCreviceCheckBox.CheckState
                        .Parameters.Add("@WATERNONE", SqlDbType.Bit).Value = Me.WaterNoneCheckBox.CheckState
                        .Parameters.Add("@WATERPERMCK", SqlDbType.Bit).Value = Me.WaterPermCrkCheckBox.CheckState
                        .Parameters.Add("@WATEREMPCRK", SqlDbType.Bit).Value = Me.WaterEphCrkCheckBox.CheckState
                        .Parameters.Add("@WATERPERMPOND", SqlDbType.Bit).Value = Me.WaterPermPndCheckBox.CheckState
                        .Parameters.Add("@WATEREMPPOND", SqlDbType.Bit).Value = Me.WaterEphPndCheckBox.CheckState
                        .Parameters.Add("@WATERDRAIN", SqlDbType.Bit).Value = Me.WaterOpenDrnCheckBox.CheckState
                        .Parameters.Add("@WATERWETLAND", SqlDbType.Bit).Value = Me.WaterWetlandCheckBox.CheckState

                        .Parameters.Add("@WATERVEG", SqlDbType.Int)
                        If Me.rbVegAbsent.Checked = True Then
                            .Parameters("@WATERVEG").Value = 1
                        ElseIf Me.rbVegPresent.Checked = True Then
                            .Parameters("@WATERVEG").Value = 2
                        End If


                        If ThreatSpecFurtherAssYesNoExtendedComboBox.SelectedIndex <> -1 Then .Parameters.Add("@FURTHER", SqlDbType.NVarChar).Value = Me.ThreatSpecFurtherAssYesNoExtendedComboBox.SelectedValue.ToString
                        .Parameters.Add("@COMMENT", SqlDbType.NVarChar).Value = ThreatSpecGenComTextBox.Text



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



        If Me.ThreatSpecFurtherAssYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.ThreatSpecFurtherAssYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.ThreatSpecFurtherAssYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.ThreatSpecFurtherAssYesNoExtendedComboBox, "")

        End If

        If Me.PropImpFaunaYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.PropImpFaunaYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.PropImpFaunaYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.PropImpFaunaYesNoExtendedComboBox, "")

        End If

        If Me.PropImpHabitatYesNoExtendedComboBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.PropImpHabitatYesNoExtendedComboBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.PropImpHabitatYesNoExtendedComboBox, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.PropImpHabitatYesNoExtendedComboBox, "")

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
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                If cb.Name <> "cboEnvironPlanner" Then
                    cb.SelectedValue = "O"

                Else
                    cb.SelectedIndex = -1
                End If
            ElseIf TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.Text = "N/A for this proposal"
            End If
        Next

    End Sub

End Class