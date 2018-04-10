Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Public Class StatutoryDCPCheckList

    Dim ucChecklist1 As DCPCheckListOne
    Dim ucChecklist2 As DCPCheckListTwo
    Dim ucChecklist3 As DCPCheckListThree
    Dim ucChecklist4 As DCPCheckListFour
    Dim ucChecklist5 As DCPCheckListFive
    Dim ucChecklist6 As DCPCheckListSix

    Private isloading As Boolean = False

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


    Private Sub StatutoryDCPCheckList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(cboDCPCheckList) Then SaveData()
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
                        .CommandText = "usp_Statutory_DCP_CheckList_Update"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@DCPCODE", SqlDbType.Int).Value = CInt(cboDCPCheckList.EditValue)
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadDCPchecklistCombo()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDCPchecklistCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadDCPCheckListCombo"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboDCPCheckList.Properties
                        .DataSource = objDT
                        .DisplayMember = "DCPDesc"
                        .ValueMember = "DCPType"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With
                    Dim col2 As LookUpColumnInfoCollection = cboDCPCheckList.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DCPDesc", 0))
                    col2.Add(New LookUpColumnInfo("DCPType", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDCPchecklistCombo routine - form " & Me.Name)

            End Try
        End Using


    End Sub


    Private Sub LoadDCPcheckListType()

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
                        .CommandText = "usp_SELECT_AssessmentDCPCode"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANo
                        .Parameters.Add("@DCP", SqlDbType.Int).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()

                        cboDCPCheckList.EditValue = CInt(.Parameters("@DCP").Value)


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub StatutoryDCPCheckList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        isloading = True
        LoadDCPchecklistCombo()



        ucChecklist1 = New DCPCheckListOne
        ucChecklist2 = New DCPCheckListTwo
        ucChecklist3 = New DCPCheckListThree
        ucChecklist4 = New DCPCheckListFour
        ucChecklist5 = New DCPCheckListFive
        ucChecklist6 = New DCPCheckListSix

        pnlControlParent.Controls.Add(ucChecklist1)
        pnlControlParent.Controls.Add(ucChecklist2)
        pnlControlParent.Controls.Add(ucChecklist3)
        pnlControlParent.Controls.Add(ucChecklist4)
        pnlControlParent.Controls.Add(ucChecklist5)
        pnlControlParent.Controls.Add(ucChecklist6)

        ucChecklist1.Islocked = _Islocked
        ucChecklist1.AssessmentNo = DANo
        ucChecklist1.Visible = False

        ucChecklist2.Islocked = _Islocked
        ucChecklist2.AssessmentNo = DANo
        ucChecklist2.Visible = False

        ucChecklist3.Islocked = _Islocked
        ucChecklist3.AssessmentNo = DANo
        ucChecklist3.Visible = False

        ucChecklist4.Islocked = _Islocked
        ucChecklist4.AssessmentNo = DANo
        ucChecklist4.Visible = False

        ucChecklist5.Islocked = _Islocked
        ucChecklist5.AssessmentNo = DANo
        ucChecklist5.Visible = False

        ucChecklist6.Islocked = _Islocked
        ucChecklist6.AssessmentNo = DANo
        ucChecklist6.Visible = False

        LoadDCPcheckListType()

        cboDCPCheckList.ReadOnly = _Islocked

        isloading = False

    End Sub

    Private Sub LoadFormControls()

        ucChecklist1.Visible = False
        ucChecklist2.Visible = False
        ucChecklist3.Visible = False
        ucChecklist4.Visible = False
        ucChecklist5.Visible = False
        ucChecklist6.Visible = False

        Select Case CInt(cboDCPCheckList.EditValue)
            Case 1
                ucChecklist1.Visible = True
                'With My.Forms.DCPCheckList1
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With
            Case 2
                ucChecklist2.Visible = True
                'With My.Forms.DCPCheckList2
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With
            Case 3
                ucChecklist3.Visible = True
                'With My.Forms.DCPCheckList3
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With
            Case 4
                ucChecklist4.Visible = True
                'With My.Forms.DCPCheckList4
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With
            Case 5
                ucChecklist5.Visible = True
                'With My.Forms.DCPCheckList5
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With
            Case 6
                ucChecklist6.Visible = True
                'With My.Forms.DCPCheckList6
                '    .AssessmentNo = DANo
                '    .StartPosition = FormStartPosition.CenterParent
                '    .ShowDialog()
                '    .Dispose()
                'End With

        End Select


    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click



    End Sub


    Private Sub cboDCPCheckList_EditValueChanged(sender As Object, e As EventArgs) Handles cboDCPCheckList.EditValueChanged

        If cboDCPCheckList.IsLoading Then Return

        If Not IsNothing(cboDCPCheckList) Then LoadFormControls()

    End Sub
End Class