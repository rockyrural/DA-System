﻿Imports System.Data.SqlClient

Public Class DCPCheckListFour

    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private DANo As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

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
            Me.DevelopmentDataTableAdapter.Fill(Me.DAdatasets.DevelopmentData, DANo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is DevExpress.XtraEditors.SimpleButton Then

                Dim cb As DevExpress.XtraEditors.SimpleButton = DirectCast(ctrl, DevExpress.XtraEditors.SimpleButton)

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


    Private Sub SetUpDCPCheck1ComboBoxs()
        Dim Nathers As New ArrayList

        ' Add division structure entries to the arraylist
        With Nathers
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboNatHERSComply
            .DataSource = Nathers
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With


        Dim Height As New ArrayList

        ' Add division structure entries to the arraylist
        With Height
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboMaxHeight
            .DataSource = Height
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim SetBackFront As New ArrayList

        ' Add division structure entries to the arraylist
        With SetBackFront
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboSetBkFront
            .DataSource = SetBackFront
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim SetBackSS As New ArrayList

        ' Add division structure entries to the arraylist
        With SetBackSS
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cbosetbkSS
            .DataSource = SetBackSS
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim SetBackSide As New ArrayList

        ' Add division structure entries to the arraylist
        With SetBackSide
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboSetBkS
            .DataSource = SetBackSide
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim SetBackRear As New ArrayList

        ' Add division structure entries to the arraylist
        With SetBackRear
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboSetBkR
            .DataSource = SetBackRear
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim SetBackForeshore As New ArrayList

        ' Add division structure entries to the arraylist
        With SetBackForeshore
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Not Applicable", "O"))
        End With

        With Me.cboSetBkFS
            .DataSource = SetBackForeshore
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With




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
                        .CommandText = "usp_UpdateDA_CheckList"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@FORM", SqlDbType.Int).Value = 4
                        If Not IsNothing(cboNatHERSComply) Then .Parameters.Add("@NATHERS", SqlDbType.NVarChar).Value = cboNatHERSComply.SelectedValue.ToString
                        .Parameters.Add("@NATHERRATING", SqlDbType.NVarChar).Value = NatHERS_RatingTextBox.Text
                        If Not IsNothing(cboMaxHeight) Then .Parameters.Add("@HEIGHTCOMPLY", SqlDbType.NVarChar).Value = cboMaxHeight.SelectedValue.ToString
                        .Parameters.Add("@HEIGHT", SqlDbType.NVarChar).Value = MaxHeightTextBox.Text
                        .Parameters.Add("@SETBKF", SqlDbType.NVarChar).Value = SetbackFTextBox.Text
                        If Not IsNothing(cboSetBkFront) Then .Parameters.Add("@SETBKFCMP", SqlDbType.NVarChar).Value = cboSetBkFront.SelectedValue.ToString
                        .Parameters.Add("@SETBKS", SqlDbType.NVarChar).Value = SetbackSTextBox.Text
                        If Not IsNothing(cboSetBkS) Then .Parameters.Add("@SETBKSCMP", SqlDbType.NVarChar).Value = cboSetBkS.SelectedValue.ToString
                        .Parameters.Add("@SETBKSS", SqlDbType.NVarChar).Value = SetbackSSTextBox.Text
                        If Not IsNothing(cbosetbkSS) Then .Parameters.Add("@SETBKSSCMP", SqlDbType.NVarChar).Value = cbosetbkSS.SelectedValue.ToString
                        .Parameters.Add("@SETBKR", SqlDbType.NVarChar).Value = SetbackRTextBox.Text
                        .Parameters.Add("@SETBKRCMP", SqlDbType.NVarChar).Value = cboSetBkR.SelectedValue.ToString
                        .Parameters.Add("@SETBKFS", SqlDbType.NVarChar).Value = SetbackFSTextBox.Text
                        If Not IsNothing(cboSetBkFS) Then .Parameters.Add("@SETBKFSCMP", SqlDbType.NVarChar).Value = cboSetBkFS.SelectedValue.ToString
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




        If Me.cboMaxHeight.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboMaxHeight, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboMaxHeight, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboMaxHeight, "")

            If cboMaxHeight.SelectedValue.ToString <> "O" Then
                If Me.MaxHeightTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.MaxHeightTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.MaxHeightTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.NatHERS_RatingTextBox, "")

                End If
            End If
        End If


        If Me.cboNatHERSComply.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboNatHERSComply, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboNatHERSComply, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboNatHERSComply, "")

            If cboNatHERSComply.SelectedValue.ToString <> "O" Then
                If Me.NatHERS_RatingTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.NatHERS_RatingTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.NatHERS_RatingTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.NatHERS_RatingTextBox, "")

                End If
            End If


        End If





        If Me.cboSetBkFront.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSetBkFront, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSetBkFront, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSetBkFront, "")

            If cboSetBkFront.SelectedValue.ToString <> "O" Then
                If Me.SetbackFTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.SetbackFTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.SetbackFTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.SetbackFTextBox, "")

                End If
            End If


        End If

        If Me.cboSetBkFS.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSetBkFS, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSetBkFS, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSetBkFS, "")

            If cboSetBkFS.SelectedValue.ToString <> "O" Then
                If Me.SetbackFSTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.SetbackFSTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.SetbackFSTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.SetbackFSTextBox, "")

                End If
            End If

        End If

        If Me.cboSetBkR.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSetBkR, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSetBkR, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSetBkR, "")

            If cboSetBkR.SelectedValue.ToString <> "O" Then
                If Me.SetbackRTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.SetbackRTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.SetbackRTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.SetbackRTextBox, "")

                End If
            End If


        End If

        If Me.cboSetBkS.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSetBkS, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSetBkS, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSetBkS, "")

            If cboSetBkS.SelectedValue.ToString <> "O" Then
                If Me.SetbackSTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.SetbackSTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.SetbackSTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.SetbackSTextBox, "")

                End If
            End If


        End If

        If Me.cbosetbkSS.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cbosetbkSS, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cbosetbkSS, "Answer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cbosetbkSS, "")

            If cbosetbkSS.SelectedValue.ToString <> "O" Then
                If Me.SetbackSSTextBox.Text = String.Empty Then
                    With ErrorProvider
                        .SetIconAlignment(Me.SetbackSSTextBox, ErrorIconAlignment.MiddleRight)
                        .SetError(Me.SetbackSSTextBox, "Answer is required")
                    End With
                    result = False
                Else
                    ErrorProvider.SetError(Me.SetbackSSTextBox, "")

                End If
            End If


        End If




        Return result
    End Function


    Private Sub DCPCheckListOne_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged


        If Me.Visible = True Then


            SetUpDCPCheck1ComboBoxs()
            LoadForm()

            If _Islocked Then LockTheForm(pnlDCPCheck1)

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        SaveData()
    End Sub

End Class
