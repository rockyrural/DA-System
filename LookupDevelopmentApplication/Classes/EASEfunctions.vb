Imports System.Data.SqlClient

Module EASEfunctions

    Public Const ADDINFO As Integer = 1
    Public Const REFERRAL As Integer = 2
    Public Const SUBMISSION As Integer = 3
    Public Const HISTORY As Integer = 4
    Public Const ZONE As Integer = 5
    Public Const REP As Integer = 6
    Public Const SEPP As Integer = 7
    Public Const GUIDE As Integer = 8
    Public Const DCP As Integer = 9
    Public Const SEC94 As Integer = 10
    Public Const VARIATION As Integer = 11
    Public Const CONDLINK As Integer = 12
    Public Const ONEOFF As Integer = 13




    Public LOCALRECORDFOLDER As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"



    Public Function BuildYear(ByVal sDocumentNumber As String) As String
        BuildYear = "20" & sDocumentNumber.Substring(InStr(sDocumentNumber, "_"), 2).ToString & "\" ' Right(sDocumentNumber, 2) & "\"
    End Function
    Public Function ImageFileName(ByVal sDocumentNumber As String) As String
        ImageFileName = "\" & sDocumentNumber & ".pdf"
    End Function
    Public Function FolderHash(ByVal sDocumentNumber As String) As Long
        Dim lFilenumber As Long
        lFilenumber = CLng(sDocumentNumber.Substring(0, sDocumentNumber.IndexOf("_")))
        'lFilenumber = Left(sDocumentNumber, InStr(sDocumentNumber, "_") - 1)
        FolderHash = lFilenumber \ 5000
    End Function

    Public Function CreateNewFileName(ByVal FileNumber As String) As String
        Dim newName As String = FileNumber.Replace(".", "_") & ".pdf"

        Return newName
    End Function
#Region "Printer Functions"

    Public Function GetSelectedPaperSource() As System.Drawing.Printing.PaperSource
        Dim selectedPaperSource As System.Drawing.Printing.PaperSource = New System.Drawing.Printing.PaperSource
        Dim myPrinterSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
        myPrinterSettings.PrinterName = My.Settings.DefaultPrinter

        For Each myPaperSource As System.Drawing.Printing.PaperSource In myPrinterSettings.PaperSources
            If myPaperSource.SourceName = My.Settings.FirstTray Then
                selectedPaperSource = myPaperSource
            End If

        Next
        Return selectedPaperSource
    End Function

    Public Function GetSelectedSecondPaperSource() As System.Drawing.Printing.PaperSource
        Dim selectedPaperSource As System.Drawing.Printing.PaperSource = New System.Drawing.Printing.PaperSource
        Dim myPrinterSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
        myPrinterSettings.PrinterName = My.Settings.DefaultPrinter

        For Each myPaperSource As System.Drawing.Printing.PaperSource In myPrinterSettings.PaperSources
            If myPaperSource.SourceName = My.Settings.OtherTray Then
                selectedPaperSource = myPaperSource
            End If

        Next
        Return selectedPaperSource
    End Function

#End Region
#Region "EASE Functions"

    Public Function GetNextDocumentNumber() As String
        Dim Returnvalue As String = String.Empty




        Using cn As New SqlConnection(My.Settings.cnEASE)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetNextDocumentNumber routine - module EaseFunctions")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetDocumentNumber"

                        .Parameters.Add("@NEWDOCID", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        Returnvalue = .Parameters("@NEWDOCID").Value.ToString
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetNextDocumentNumber routine - - module EaseFunctions")

            End Try
        End Using







        Return Returnvalue

    End Function


#End Region


    Public Function HasStandardCondition(ByVal id As Integer) As Boolean

        Dim result As Boolean


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in HasStandardCondition routine - - in EASEfunction")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_HasStandardCondition"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = id
                        .Parameters.Add("@STDCOND", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@STDCOND").Value)

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in HasStandardCondition routine - in EASEfunction")

            End Try
        End Using


        Return result


    End Function

End Module
