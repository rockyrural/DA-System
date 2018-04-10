Imports System.Data.SqlClient

Public Class DraftConditions
    Private AppID As String
    Public WriteOnly Property ApplicationID() As String
        Set(ByVal value As String)
            AppID = value
        End Set
    End Property

    Private ReferralId As Integer
    Public WriteOnly Property TheReferralId() As Integer
        Set(ByVal value As Integer)
            ReferralId = value
        End Set
    End Property
    Private Sub DraftConditions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DraftConditions_Load routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Conditions"
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboConditionCode.Items.Add(New DraftConditionsList(CInt(objDataReader("ID")), objDataReader("CondDesc").ToString, objDataReader("CondCode").ToString, CBool(objDataReader("FreeFormInserts")), objDataReader("ConditionText").ToString))
                        Loop
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DraftConditions_Load routine - form " & Me.Name)

            End Try
        End Using

        Try
            Me.RetrieveBookmarksAndFreeTextTableAdapter.Fill(Me.CCdata.RetrieveBookmarksAndFreeText, Me.cboConditionCode.Text, ReferralId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.LoadReferralDraftConditionsTableAdapter.Fill(Me.CCdata.LoadReferralDraftConditions, New System.Nullable(Of Integer)(ReferralId))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cboConditionCode_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConditionCode.SelectedValueChanged
        Dim mlist As DraftConditionsList = CType(Me.cboConditionCode.SelectedItem, DraftConditionsList)
        Me.txtcondition.Text = mlist.DocDescription
        Me.grpFreeForm.Visible = mlist.IsFreeForm
        Me.btnViewCondition.Enabled = True

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
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT     DA_ConditionComponents_freeform.id, " & _
                                      "ConditionCode.CondCode + ' - ' + DA_ConditionComponents_freeform.CondBookmarkFreeForm AS BookMark " & _
                                        " FROM DA_ConditionComponents_freeform INNER JOIN " & _
                                      "ConditionCode ON DA_ConditionComponents_freeform.ConditionCodeFreeFormID = ConditionCode.Id " & _
                                        "WHERE     (ConditionCode.Id = " & mlist.CodeID & ")"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboBookMarks
                        .DataSource = objDT
                        .DisplayMember = "BookMark"
                        .ValueMember = "id"
                        .SelectedIndex = -1
                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnViewCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCondition.Click
        Dim mlist As DraftConditionsList = CType(Me.cboConditionCode.SelectedItem, DraftConditionsList)
        Dim objWordApp As New Microsoft.Office.Interop.Word.Application

        Dim objWordDoc As New Microsoft.Office.Interop.Word.Document

        objWordDoc = objWordApp.Application.Documents.Open(FileName:=mlist.WordDocLoc, _
         ReadOnly:=True, AddToRecentFiles:=False)



        'objWordDoc.Activate()
        objWordApp.Visible = True

    End Sub


    Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCondition.Click
        If Me.cboConditionCode.SelectedIndex = -1 Then Exit Sub

        If MessageBox.Show("Insert this condition?", "Insert Referral condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim mlist As DraftConditionsList = CType(Me.cboConditionCode.SelectedItem, DraftConditionsList)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertReferralConditionCode"

                        .Parameters.Add("@REFID", SqlDbType.Int).Value = ReferralId
                        .Parameters.Add("@CONDCODE", SqlDbType.Int).Value = mlist.CodeID
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            Me.LoadReferralDraftConditionsTableAdapter.Fill(Me.CCdata.LoadReferralDraftConditions, New System.Nullable(Of Integer)(ReferralId))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnAddFreeformText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFreeformText.Click

        If MessageBox.Show("Insert referral freetext?", "Insert Referral record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub





        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddFreeformText_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertReferralFreeFormText"

                        .Parameters.Add("@REFID", SqlDbType.Int).Value = ReferralId
                        .Parameters.Add("@CONDID", SqlDbType.Int).Value = CInt(cboBookMarks.SelectedValue)
                        .Parameters.Add("@TEXT", SqlDbType.NText).Value = txtFreeformtext.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblFreeFormID.Text)
                        .ExecuteNonQuery()

                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddFreeformText_Click routine - form " & Me.Name)

            End Try
        End Using


        Me.cboBookMarks.SelectedIndex = -1
        Me.txtcondition.Text = String.Empty
        Me.lblFreeFormID.Text = "0"

        ' DO TO:

        Try
            Me.RetrieveBookmarksAndFreeTextTableAdapter.Fill(Me.CCdata.RetrieveBookmarksAndFreeText, Me.cboConditionCode.Text, ReferralId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub btnRemoveCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click

        If lstConditions.SelectedIndex = -1 Then Exit Sub

        If MessageBox.Show("Remove " & Me.lstConditions.Text & "?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveReferralDraftCondition"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lstConditions.SelectedValue)
                        .ExecuteNonQuery()
                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            Me.LoadReferralDraftConditionsTableAdapter.Fill(Me.CCdata.LoadReferralDraftConditions, New System.Nullable(Of Integer)(ReferralId))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnRemoveFreeForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFreeForm.Click

        If dgvReferralFreeformText.CurrentRow.Index = -1 Then Exit Sub


        If MessageBox.Show("Remove Freeform text " & Me.dgvReferralFreeformText.CurrentRow.Cells(2).Value.ToString & "?", "Remove text", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFreeForm_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveReferralDraftFreeformText"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvReferralFreeformText.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFreeForm_Click routine - form " & Me.Name)

            End Try
        End Using
        'TO DO:
        Try
            Me.RetrieveBookmarksAndFreeTextTableAdapter.Fill(Me.CCdata.RetrieveBookmarksAndFreeText, Me.cboConditionCode.Text, ReferralId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub dgvReferralFreeformText_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReferralFreeformText.CellClick


        If dgvReferralFreeformText.CurrentRow.Index = -1 Then Exit Sub

        Me.lblFreeFormID.Text = dgvReferralFreeformText.CurrentRow.Cells(0).Value.ToString
        Me.txtFreeformtext.Text = dgvReferralFreeformText.CurrentRow.Cells(2).Value.ToString
        cboBookMarks.Text = dgvReferralFreeformText.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub btnIncludeConditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncludeConditions.Click

        If MessageBox.Show("ou are about to copy all the proposed condition records for this referral and add them to the list of conditions for this DA!  OK to proceed?", "Update the Contributions Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnIncludeConditions_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertDraftReferralConditions"

                        .Parameters.Add("@REFID", SqlDbType.Int).Value = ReferralId
                        .Parameters.Add("@APPNO", SqlDbType.NVarChar).Value = AppID
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnIncludeConditions_Click routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub lstConditions_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstConditions.SelectedValueChanged
        Dim freeformtext As Boolean = False
        Dim condCodes As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in lstConditions_SelectedValueChanged routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ThereIsFreeFormText"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lstConditions.SelectedValue)
                        .Parameters.Add("@RESULT", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .Parameters.Add("@CONDCODE", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        freeformtext = CBool(.Parameters("@RESULT").Value)
                        condCodes = .Parameters("@CONDCODE").Value.ToString
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in lstConditions_SelectedValueChanged routine - form " & Me.Name)

            End Try
        End Using


        Me.grpFreeForm.Visible = freeformtext
        Me.txtFreeformtext.Text = String.Empty
        Me.cboConditionCode.Text = condCodes
        Me.lblFreeFormID.Text = "0"


        Try
            Me.RetrieveBookmarksAndFreeTextTableAdapter.Fill(Me.CCdata.RetrieveBookmarksAndFreeText, Me.cboConditionCode.Text, ReferralId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

 
End Class