Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class CreateBlankTemplate

    Private errorProvider As New DXErrorProvider.DXErrorProvider

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadDATypes()

        LoadOfficers()

        LoadStatus()


    End Sub

    Private Sub LoadDATypes()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDATypes routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT  DAAppTypeId, DAAppType FROM DAAppType"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboAppType.Properties
                        .DataSource = objDT
                        .DisplayMember = "DAAppType"
                        .ValueMember = "DAAppTypeId"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboAppType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DAAppType", 0))
                    col2.Add(New LookUpColumnInfo("DAAppTypeId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDATypes routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadOfficers()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficers routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT OfficerID, Officer FROM Officer WHERE (Quit = 0) AND (ExternalAuthorityYN = 0) AND (AssessmentOfficer = 1) ORDER BY Officer"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboOfficer.Properties
                        .DataSource = objDT
                        .DisplayMember = "Officer"
                        .ValueMember = "OfficerID"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboOfficer.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Officer", 0))
                    col2.Add(New LookUpColumnInfo("OfficerID", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficers routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadStatus()

        Dim ApplicationStatus As New ArrayList

        With ApplicationStatus
            .Add(New ApplicationStatus("WITH OFFICER", 7))
            .Add(New ApplicationStatus("REGISTERED", 6))
        End With

        With Me.cboStatus.Properties
            .DataSource = ApplicationStatus
            .DisplayMember = "ApplicationStatus"
            .ValueMember = "AppStatCode"
        End With
        Dim col2 As LookUpColumnInfoCollection = cboStatus.Properties.Columns
        col2.Add(New LookUpColumnInfo("ApplicationStatus", 0))
        col2.Add(New LookUpColumnInfo("AppStatCode", 0))

        col2.Item(1).Visible = False

    End Sub

    Private Function AllTheFeildsHaveBeenCompleted() As Boolean

        Dim Result As Boolean = True


        If txtDAnumber.Text = String.Empty Then

            errorProvider.SetError(txtDAnumber, "Application Number is required")
            Result = False

        Else

            errorProvider.SetError(txtDAnumber, "")

        End If


        If Me.txtAppName.Text = String.Empty Then

            errorProvider.SetError(Me.txtAppName, "Applicants name is required")
            Result = False

        Else

            errorProvider.SetError(Me.txtAppName, "")

        End If

        If Me.txtAppAddress.Text = String.Empty Then

            errorProvider.SetError(Me.txtAppAddress, "Applicants address is required")
            Result = False

        Else

            errorProvider.SetError(Me.txtAppAddress, "")

        End If

        If Me.txtAppTown.Text = String.Empty Then

            errorProvider.SetError(txtAppTown, "Applicants town is required")

            Result = False
        Else
            errorProvider.SetError(txtAppTown, "")

        End If

        If Me.txtappPcode.EditValue Is Nothing Then

            errorProvider.SetError(Me.txtappPcode, "Applicants postcode Is required")

            Result = False

        Else

            errorProvider.SetError(Me.txtappPcode, "")

        End If

        If Me.cboAppType.EditValue Is Nothing Then

            errorProvider.SetError(Me.cboAppType, "Application Type Is required")

            Result = False
        Else

            errorProvider.SetError(Me.cboAppType, "")

        End If

        If Me.txtAppPhone.Text = String.Empty Then

            errorProvider.SetError(Me.txtAppPhone, "Phone number Is required")

            Result = False

        Else

            errorProvider.SetError(Me.txtAppPhone, "")

        End If

        If txtFileNo.Text = String.Empty Then

            errorProvider.SetError(Me.txtFileNo, "File number Is required")

            Result = False
        Else

            errorProvider.SetError(Me.txtFileNo, "")

        End If

        If dtRego.EditValue Is Nothing Then

            errorProvider.SetError(dtRego, "Registration Date Is required")

            Result = False
        Else
            errorProvider.SetError(dtRego, "")

        End If

        If cboOfficer.EditValue Is Nothing Then

            errorProvider.SetError(cboOfficer, "Officer Is required")

            Result = False
        Else

            errorProvider.SetError(cboOfficer, "")

        End If



        If cboStatus.EditValue Is Nothing Then

            errorProvider.SetError(Me.cboStatus, "Application status Is required")

            Result = False

        Else
            errorProvider.SetError(cboStatus, "")

        End If



        Return Result

    End Function

    Private Sub CreateANewDA()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " In btnCreate_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateNewDa"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDAnumber.Text

                        .Parameters.Add("@DATypeId", SqlDbType.Int).Value = CInt(cboAppType.EditValue)

                        .Parameters.Add("@DARegoDt", SqlDbType.SmallDateTime).Value = Format(CDate(dtRego.EditValue), "yyyy-MM-dd")

                        .Parameters.Add("@DADecisionId", SqlDbType.Int).Value = CInt(cboStatus.EditValue)

                        .Parameters.Add("@DAOfficerId", SqlDbType.Int).Value = CInt(cboOfficer.EditValue)

                        .Parameters.Add("@DAFileNo", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@DAAppName", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@DAAppAddr", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@DAAppTown", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@DAAppEmail", SqlDbType.NVarChar).Value = Me.txtEmail.Text
                        .Parameters.Add("@DAAppPC", SqlDbType.SmallInt).Value = CInt(txtappPcode.Text)

                        .Parameters.Add("@DAAppPhone", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text

                        .ExecuteNonQuery()

                    End With



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " In btnCreate_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub btnCreateTemplate_Click(sender As Object, e As EventArgs) Handles btnCreateTemplate.Click

        If AllTheFeildsHaveBeenCompleted() Then

            CreateANewDA()

            DialogResult = DialogResult.OK

        Else

            Return

        End If

    End Sub
End Class