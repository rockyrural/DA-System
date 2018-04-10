Imports system.data.sqlclient
Imports spellCheckTextbox

Imports WORD = Microsoft.Office.Interop.Word

Public Class StatutoryLEP

    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    'Private txtLEPRelevantProv As spellCheckTextbox.UserControl1
    'Private txtLEPComments As spellCheckTextbox.UserControl1

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
            LoadData(DANo)
            LoadDataGrid(DANo)
            'Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
            'Me.ZoneInformationGridTableAdapter.Fill(Me.AAdata.ZoneInformationGrid, DANo)

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


    Private Sub StatutoryLEP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _Islocked Then SaveData()

    End Sub


    Private Sub LoadDataGrid(DANo As String)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDataGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ZoneInformationGrid"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvZoneInformation.DataSource = objDT
                    dgvZoneInformation.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDataGrid routine - form " & Me.Name)

            End Try
        End Using

    End Sub




    Private Sub LoadData(DANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAAssessmentData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        txtLEPRelevantProv.text = objDataRow.Item("LEPRelevantProv").ToString

                        txtLEPComments.text = objDataRow.Item("LEPComments").ToString

                    End If


                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub
    Private Sub StatutoryLEP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




        Dim Permitted As New ArrayList

        ' Add division structure entries to the arraylist
        With Permitted
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With cboPermited
            .DataSource = Permitted
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        loadform()

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
                        .CommandText = "usp_Statutory_LEP_Update"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@LEPRELEVANT", SqlDbType.NVarChar).Value = Me.txtLEPRelevantProv.text
                        .Parameters.Add("@LEPCOMMENTS", SqlDbType.NText).Value = Me.txtLEPComments.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub
    Private Sub btnPlanObjectives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanObjectives.Click

        If dgvZoneInformation.RowCount = 0 Then Return

        Dim objWordApp As New WORD.Application

        Dim objWordDoc As New WORD.Document

        objWordDoc = objWordApp.Application.Documents.Open(FileName:=Me.dgvZoneInformation.CurrentRow.Cells(5).Value.ToString,
         ReadOnly:=True, AddToRecentFiles:=False)
        objWordDoc.Application.Selection.GoTo(What:=WORD.WdGoToItem.wdGoToBookmark, Name:="PlanObjectives")


        objWordDoc.Activate()
        objWordApp.Visible = True

    End Sub

    Private Sub btnObjectives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObjectives.Click

        If dgvZoneInformation.RowCount = 0 Then Return


        Dim objWordApp As New WORD.Application

        Dim objWordDoc As New WORD.Document

        objWordDoc = objWordApp.Application.Documents.Open(FileName:=Me.dgvZoneInformation.CurrentRow.Cells(5).Value.ToString, _
         ReadOnly:=True, AddToRecentFiles:=False)
        objWordDoc.Application.Selection.GoTo(What:=WORD.WdGoToItem.wdGoToBookmark, Name:=Me.dgvZoneInformation.CurrentRow.Cells(6).Value.ToString)


        objWordDoc.Activate()
        objWordApp.Visible = True

    End Sub

    Private Sub btnUses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUses.Click

        If dgvZoneInformation.RowCount = 0 Then Return

        Dim objWordApp As New WORD.Application

        Dim objWordDoc As New WORD.Document

        objWordDoc = objWordApp.Application.Documents.Open(FileName:=Me.dgvZoneInformation.CurrentRow.Cells(5).Value.ToString, _
         ReadOnly:=True, AddToRecentFiles:=False)
        objWordDoc.Application.Selection.GoTo(What:=WORD.WdGoToItem.wdGoToBookmark, Name:=Me.dgvZoneInformation.CurrentRow.Cells(7).Value.ToString)


        objWordDoc.Activate()
        objWordApp.Visible = True

    End Sub

    Private Sub dgvZoneInformation_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvZoneInformation.CellClick

        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvZoneInformation_CellClick routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_CommentsPermitedFromDA_Zone_records"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvZoneInformation.CurrentRow.Cells(0).Value)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            Me.lblZoneID.Text = objDataReader.Item(0).ToString
                            cboPermited.SelectedValue = objDataReader.Item(2).ToString
                            Me.btnUpdate.Enabled = True
                        Loop
                    End Using


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvZoneInformation_CellClick routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdate_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_DA_Zone_Redcords"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = lblZoneID.Text
                        .Parameters.Add("@PERMITTED", SqlDbType.NVarChar).Value = cboPermited.SelectedValue.ToString
                        .Parameters.Add("@DAZONEDESC", SqlDbType.NVarChar).Value = Me.txtDAzone.Text
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo

                        .ExecuteNonQuery()
                    End With


                End Using
                ' 
                Me.btnUpdate.Enabled = False
                LoadDataGrid(DANo)

                'Me.ZoneInformationGridTableAdapter.Fill(Me.AAdata.ZoneInformationGrid, DANo)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdate_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnRetrieveZones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieveZones.Click

        If MessageBox.Show("This action will remove all previous codes and replace it, including comments, still proceed?", "Reload Zoning info", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveZones_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertZoneCodeIntoDA_ZONE_RECORDS"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveZones_Click routine - form " & Me.Name)

            End Try
        End Using
        Try
            LoadData(DANo)
            LoadDataGrid(DANo)

            'Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, DANo)
            'Me.ZoneInformationGridTableAdapter.Fill(Me.AAdata.ZoneInformationGrid, DANo)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub avAddressCtrl_TextChanged(ByVal sender As Object, ByVal args As System.Windows.Controls.TextChangedEventArgs)

    End Sub

End Class