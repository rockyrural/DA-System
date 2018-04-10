Imports system.data.sqlclient

Public Class GeneralImpacts
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

    Private Sub GeneralImpacts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then

            If CheckDataEntry() Then
                SaveData()
            Else
                If MessageBox.Show("You are required to answer ALL questions before closing this form, do you still wish to exit?", "All questions not answered", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
            End If

        End If

    End Sub

    Private Sub GeneralImpacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
        Me.cboAppearance.SelectedIndex = -1
        Me.cboBushFire.SelectedIndex = -1
        Me.cboCharacter.SelectedIndex = -1
        Me.cboCompatible.SelectedIndex = -1
        Me.cboDrainage.SelectedIndex = -1
        Me.cboEdge.SelectedIndex = -1
        Me.cboFlooding.SelectedIndex = -1
        Me.cboGeo.SelectedIndex = -1
        Me.cboHealth.SelectedIndex = -1
        Me.cboLandform.SelectedIndex = -1
        Me.cboLocation.SelectedIndex = -1
        Me.cboNoise.SelectedIndex = -1
        Me.cboNuisance.SelectedIndex = -1
        Me.cboPrivacy.SelectedIndex = -1
        Me.cboPropImpScenicYesNo.SelectedIndex = -1
        Me.cboSunLight.SelectedIndex = -1
        Me.cboViews.SelectedIndex = -1
        Me.cboWater.SelectedIndex = -1
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


                cb.Enabled = False

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
                        .CommandText = "usp_InsertUpdateDAassessment_Impacts"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@SCENIC", SqlDbType.NVarChar).Value = Me.cboPropImpScenicYesNo.SelectedValue.ToString
                        .Parameters.Add("@CHARACTER", SqlDbType.NVarChar).Value = Me.cboCharacter.SelectedValue.ToString
                        .Parameters.Add("@LOCATION", SqlDbType.NVarChar).Value = Me.cboLocation.SelectedValue.ToString
                        .Parameters.Add("@APPEAR", SqlDbType.NVarChar).Value = Me.cboAppearance.SelectedValue.ToString
                        .Parameters.Add("@IMPCOMPAT", SqlDbType.NVarChar).Value = Me.cboCompatible.SelectedValue.ToString
                        .Parameters.Add("@IMPSUN", SqlDbType.NVarChar).Value = Me.cboSunLight.SelectedValue.ToString
                        .Parameters.Add("@IMPPRIVACY", SqlDbType.NVarChar).Value = Me.cboPrivacy.SelectedValue.ToString
                        .Parameters.Add("@IMPNUISANCE", SqlDbType.NVarChar).Value = Me.cboNuisance.SelectedValue.ToString
                        .Parameters.Add("@IMPNOISE", SqlDbType.NVarChar).Value = Me.cboNoise.SelectedValue.ToString
                        .Parameters.Add("@IMPVIEWS", SqlDbType.NVarChar).Value = Me.cboViews.SelectedValue.ToString
                        .Parameters.Add("@IMPEDGE", SqlDbType.NVarChar).Value = Me.cboEdge.SelectedValue.ToString
                        .Parameters.Add("@IMPLANDFORM", SqlDbType.NVarChar).Value = Me.cboLandform.SelectedValue.ToString
                        .Parameters.Add("@IMPWATER", SqlDbType.NVarChar).Value = Me.cboWater.SelectedValue.ToString
                        .Parameters.Add("@IMPDRAIN", SqlDbType.NVarChar).Value = Me.cboDrainage.SelectedValue.ToString
                        .Parameters.Add("@IMPGEO", SqlDbType.NVarChar).Value = Me.cboGeo.SelectedValue.ToString
                        .Parameters.Add("@IMPFLOOD", SqlDbType.NVarChar).Value = Me.cboFlooding.SelectedValue.ToString
                        .Parameters.Add("@IMPBUSHFIRE", SqlDbType.NVarChar).Value = Me.cboBushFire.SelectedValue.ToString
                        .Parameters.Add("@IMPHEALTH", SqlDbType.NVarChar).Value = Me.cboHealth.SelectedValue.ToString
                        .Parameters.Add("@IMPCURTILAGE", SqlDbType.NVarChar).Value = cboTree.SelectedValue.ToString
                        .Parameters.Add("@IMPCOMMENTS", SqlDbType.NText).Value = PropImpCommentsTextBox.Text
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



        If Me.cboAppearance.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboAppearance, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboAppearance, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboAppearance, "")

        End If

        If Me.cboBushFire.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboBushFire, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboBushFire, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboBushFire, "")

        End If

        If Me.cboCharacter.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboCharacter, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboCharacter, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboCharacter, "")

        End If

        If Me.cboCompatible.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboCompatible, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboCompatible, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboCompatible, "")

        End If

        If Me.cboDrainage.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDrainage, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDrainage, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDrainage, "")

        End If


        If Me.cboEdge.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboEdge, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboEdge, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboEdge, "")

        End If

        If Me.cboFlooding.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboFlooding, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboFlooding, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboFlooding, "")

        End If

        If Me.cboGeo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboGeo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboGeo, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboGeo, "")

        End If

        If Me.cboHealth.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboHealth, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboHealth, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboHealth, "")

        End If

        If Me.cboLandform.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboLandform, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboLandform, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboLandform, "")

        End If

        If Me.cboLocation.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboLocation, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboLocation, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboLocation, "")

        End If

        If Me.cboNoise.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboNoise, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboNoise, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboNoise, "")

        End If

        If Me.cboNuisance.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboNuisance, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboNuisance, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboNuisance, "")

        End If

        If Me.cboPrivacy.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboPrivacy, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboPrivacy, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPrivacy, "")

        End If

        If Me.cboPropImpScenicYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboPropImpScenicYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboPropImpScenicYesNo, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPropImpScenicYesNo, "")

        End If

        If Me.cboSunLight.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSunLight, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSunLight, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSunLight, "")

        End If

 

        If Me.cboViews.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboViews, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboViews, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboViews, "")

        End If

        If Me.cboWater.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboWater, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboWater, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboWater, "")

        End If

        If Me.cboTree.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboTree, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboTree, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboTree, "")

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
            End If
        Next

    End Sub

  
    Private Sub btnViewComments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewComments.Click
        With My.Forms.CommentsViewer
            .txtTexttoView.Text = PropImpCommentsTextBox.Text
            .ShowDialog()
            PropImpCommentsTextBox.Text = .txtTexttoView.Text
            .Dispose()
        End With
    End Sub
End Class