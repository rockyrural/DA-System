Imports system.data.sqlclient

Public Class StatutoryDAMS

    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private isLoading As Boolean

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
        isLoading = True
        Try
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        isLoading = False
        CalculateDams()
        CalculateVolume()
        CalculateMHRDC()
        CalculateAllowesMHRDC()
        CalculateLicenceRequired()

        If _Islocked Then LockTheForm(Me)

    End Sub

    Private Sub StatutoryDAMS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then
            If CheckDataEntry() Then
                SaveData()
            Else
                If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
            End If
        End If
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


    Private Sub StatutoryDAMS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim IntDev As New ArrayList

        ' Add division structure entries to the arraylist
        With IntDev
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With cboDamYN
            .DataSource = IntDev
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = 0
        End With
        isLoading = True
        Dim DamShape As New ArrayList

        ' Add division structure entries to the arraylist
        With DamShape
            .Add(New YesNoAnswer("Round", "R"))
            .Add(New YesNoAnswer("Square", "S"))
            .Add(New YesNoAnswer("Triangular", "T"))
        End With

        With Me.DamShapeExtendedComboBox
            .DataSource = DamShape
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With


        LoadForm()

    End Sub

    Private Sub cboDamYN_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDamYN.SelectedValueChanged
        Me.GroupBox1.Visible = Me.cboDamYN.SelectedValue.ToString <> "N"
    End Sub

    Private Sub DamShapeExtendedComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamShapeExtendedComboBox.SelectedValueChanged
        If isLoading Then Exit Sub
        CalculateDams()
    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Sub CalculateDams()

        If DamShapeExtendedComboBox.SelectedIndex = -1 Then Exit Sub
        Dim damwidth As Double
        Dim damlength As Double

        If DamWidthTextBox.Text <> String.Empty Then damwidth = CDbl(DamWidthTextBox.Text)
        If DamLengthTextBox.Text <> String.Empty Then damlength = CDbl(DamLengthTextBox.Text)

        Select Case DamShapeExtendedComboBox.SelectedValue.ToString.ToUpper

            Case "S"


                txtArea.Text = (damwidth * damlength).ToString

            Case "R"
                txtArea.Text = (0.8 * damwidth * damlength).ToString

            Case "T"
                txtArea.Text = (damwidth * damlength * 0.5).ToString


        End Select

    End Sub

    Private Sub CalculateMHRDC()
        Dim DamLostSize As Double
        Dim DamMultipler As Double

        If DamLotSizeTextBox.Text <> String.Empty Then DamLostSize = CDbl(DamLotSizeTextBox.Text)
        If DamMultiplierTextBox.Text <> String.Empty Then DamMultipler = CDbl(DamMultiplierTextBox.Text)

        txtMHRDC.Text = (DamLostSize * DamMultipler).ToString()
    End Sub

    Private Sub CalculateVolume()
        Dim existVol As Double = 0
        Dim VolToAdd As Double = 0
        Dim DamDepth As Double
        Dim DamArea As Double

        If DamDepthTextBox.Text <> String.Empty Then DamDepth = CDbl(DamDepthTextBox.Text)
        If txtArea.Text <> String.Empty Then DamArea = CDbl(txtArea.Text)


        Me.txtVolume.Text = ((DamDepth * DamArea * 0.4) / 1000).ToString
        If DamExistVolTextBox.Text <> String.Empty Then existVol = CDbl(DamExistVolTextBox.Text)
        If txtVolume.Text <> String.Empty Then VolToAdd = CDbl(txtVolume.Text)

        Me.txtTotalVolume.Text = (existVol + VolToAdd).ToString
    End Sub

    Private Sub CalculateAllowesMHRDC()
        'If Not IsDate(Me.DamSubdivDateMaskedTextBox.Text) Then Exit Sub

        Dim Allowed As Double
        Dim TotalVol As Double

        If txtAllowed.Text <> String.Empty Then Allowed = CDbl(txtAllowed.Text)
        If txtTotalVolume.Text <> String.Empty Then TotalVol = CDbl(txtTotalVolume.Text)
        If DamSubdivDateMaskedTextBox.Text <> String.Empty Then
            If DateDiff(DateInterval.Day, CDate("1/1/1999"), CDate(DamSubdivDateMaskedTextBox.Text)) > 0 Then
                Me.txtAllowed.Text = Me.txtMHRDC.Text
            Else
                If NZ(txtMHRDC.Text) < 1 Then
                    txtAllowed.Text = "1"
                Else
                    Me.txtAllowed.Text = Me.txtMHRDC.Text
                End If
            End If
        End If
        Me.txtDifference.Text = (Allowed - TotalVol).ToString

    End Sub

    Private Sub CalculateLicenceRequired()
        'If Not IsDate(Me.DamSubdivDateMaskedTextBox.Text) Then Exit Sub
        If DamSubdivDateMaskedTextBox.Text = String.Empty Then
            txtLicenceRequired.Text = "Unknown"
        Else
            If NZ(Me.txtDifference.Text) > 0 Then
                txtLicenceRequired.Text = "No"
            Else
                txtLicenceRequired.Text = "YES!"
            End If
        End If
    End Sub

    Private Sub DamLengthTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateDams()
    End Sub

    Private Sub DamWidthTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateDams()
    End Sub

    Private Sub DamDepthTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateVolume()
    End Sub

    Private Sub DamLotSizeTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateMHRDC()
    End Sub

    Private Sub DamMultiplierTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateMHRDC()
    End Sub

    Private Sub DamSubdivDateMaskedTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DamSubdivDateMaskedTextBox.TextChanged
        CalculateAllowesMHRDC()
        CalculateLicenceRequired()
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
                        .CommandText = "usp_InsertUpdateDAassessment_DAMs"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        If DamShapeExtendedComboBox.SelectedIndex <> -1 Then .Parameters.Add("@SHAPE", SqlDbType.NVarChar).Value = Me.DamShapeExtendedComboBox.SelectedValue.ToString
                        If Not String.IsNullOrEmpty(DamLengthTextBox.Text) Then .Parameters.Add("@LENGTH", SqlDbType.Float).Value = CDbl(DamLengthTextBox.Text)
                        If Not String.IsNullOrEmpty(DamWidthTextBox.Text) Then .Parameters.Add("@WIDTH", SqlDbType.Float).Value = CDbl(Me.DamWidthTextBox.Text)
                        If Not String.IsNullOrEmpty(DamDepthTextBox.Text) Then .Parameters.Add("@DEPTH", SqlDbType.Float).Value = CDbl(Me.DamDepthTextBox.Text)
                        If Not String.IsNullOrEmpty(DamExistVolTextBox.Text) Then .Parameters.Add("@EXISTVOL", SqlDbType.Float).Value = CDbl(Me.DamExistVolTextBox.Text)
                        If Not String.IsNullOrEmpty(DamLotSizeTextBox.Text) Then .Parameters.Add("@LOTSIZE", SqlDbType.Float).Value = CDbl(Me.DamLotSizeTextBox.Text)
                        If Not String.IsNullOrEmpty(DamMultiplierTextBox.Text) Then .Parameters.Add("@MULT", SqlDbType.Float).Value = CDbl(Me.DamMultiplierTextBox.Text)
                        If IsDate(DamSubdivDateMaskedTextBox.Text) Then .Parameters.Add("@SUBDATE", SqlDbType.SmallDateTime).Value = Format(CDate(Me.DamSubdivDateMaskedTextBox.Text), "dd/MM/yyyy")
                        .Parameters.Add("@YESNO", SqlDbType.NVarChar).Value = Me.cboDamYN.SelectedValue.ToString
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



        If Me.cboDamYN.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDamYN, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDamYN, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDamYN, "")


            If Me.cboDamYN.SelectedValue.ToString = "Y" Then

                If Me.DamShapeExtendedComboBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamShapeExtendedComboBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamShapeExtendedComboBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamShapeExtendedComboBox, "")

                End If

                If Me.DamSubdivDateMaskedTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamSubdivDateMaskedTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamSubdivDateMaskedTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamSubdivDateMaskedTextBox, "")

                End If

                If Me.DamWidthTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamWidthTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamWidthTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamWidthTextBox, "")

                End If

                If Me.DamMultiplierTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamMultiplierTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamMultiplierTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamMultiplierTextBox, "")

                End If

                If Me.DamLotSizeTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamLotSizeTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamLotSizeTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamLotSizeTextBox, "")

                End If

                If Me.DamLengthTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamLengthTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamLengthTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamLengthTextBox, "")

                End If

                If Me.DamExistVolTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamExistVolTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamExistVolTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamExistVolTextBox, "")

                End If

                If Me.DamDepthTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.DamDepthTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.DamDepthTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.DamDepthTextBox, "")

                End If

            End If
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

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        If TheNewDate <> String.Empty Then datefield.Text = TheNewDate

    End Sub

    Private Sub btnDARegoDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDARegoDt.Click
        RetrieveDate(Me.DamSubdivDateMaskedTextBox)
    End Sub

    Private Sub DamExistVolTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        CalculateVolume()

    End Sub

  
End Class