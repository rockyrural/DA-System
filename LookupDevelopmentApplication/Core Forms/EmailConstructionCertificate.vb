Imports Microsoft.Office.Interop
Imports WORD = Microsoft.Office.Interop.Word
Imports System.IO

Public Class EmailConstructionCertificate
    Private errorProvider1 As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

    Private _LetterBeingSent As String
    Public WriteOnly Property LetterBeingSent() As String

        Set(ByVal value As String)
            _LetterBeingSent = value
        End Set
    End Property



    Private _DocumentName As String
    Public WriteOnly Property DocumentName() As String

        Set(ByVal value As String)
            _DocumentName = value
        End Set
    End Property


    Private _DaNo As String
    Public WriteOnly Property DANo() As String

        Set(ByVal value As String)
            _DaNo = value
        End Set
    End Property


    Private _EmailAddress As String
    Public WriteOnly Property EmailAddress() As String

        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property


    'Private Function formNotComplete() As Boolean
    '    Dim result As Boolean = False
    '    If txtSubject.Text.Length = 0 Then

    '        errorProvider1.SetError(txtSubject, "Subject is a required field")

    '        result = True
    '    Else
    '        errorProvider1.SetError(txtSubject, "")

    '    End If

    '    If txtBody.Text.Length = 0 Then

    '        errorProvider1.SetError(txtBody, "Email Message is a required field")

    '        result = True
    '    Else
    '        errorProvider1.SetError(txtBody, "")


    '    End If
    '    Return result
    'End Function
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function
    Private Sub MyValidatingCode()
        ' Confirm there is text in the control.
        If txtemailAddress.Text.Length = 0 Then
            Throw New Exception("Email address is a required field")
        Else
            ' Confirm that there is a "." and an "@" in the e-mail address.
            'If txtemailAddress.Text.IndexOf(".") = -1 Or txtemailAddress.Text.IndexOf("@") = -1 Then
            If Not ValidateEmail(txtemailAddress.Text) Then
                Throw New Exception("Email address must be valid e-mail address format." +
                  Microsoft.VisualBasic.ControlChars.Cr + "For example 'someone@example.com'")
            End If
        End If
    End Sub

    Private Sub BuildPDFDocument()

        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document
        'assume success
        Dim result As Boolean = True
        Dim filelocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\emailAttachment.pdf"

        Try

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor



            'If My.Computer.FileSystem.DirectoryExists(LOCALRECORDFOLDER) = False Then My.Computer.FileSystem.CreateDirectory(LOCALRECORDFOLDER)


            If My.Computer.FileSystem.FileExists(filelocation) Then My.Computer.FileSystem.DeleteFile(filelocation)


            objWordDoc = objWordApp.Application.Documents.Open(_DocumentName)


            With objWordDoc
                .Activate()
                .ExportAsFixedFormat(filelocation, WORD.WdExportFormat.wdExportFormatPDF, False,
                WORD.WdExportOptimizeFor.wdExportOptimizeForOnScreen,
                WORD.WdExportRange.wdExportAllDocument, 1, 1,
                WORD.WdExportItem.wdExportDocumentContent, True, False,
                WORD.WdExportCreateBookmarks.wdExportCreateHeadingBookmarks, False, False, False)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in PrintPDFdocument routine - form " & Me.Name)
            result = False

        Finally

            objWordDoc.Close(SaveChanges:=False)
            objWordApp.Quit()

            releaseObject(objWordDoc)

            releaseObject(objWordApp)

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try




    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'If formNotComplete() Then Exit Sub

        Dim attachments() As String

        'MailAttachment(0) = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\emailAttachment.pdf"
        'MailAttachment(1) = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DA Acknowledgement Letter Attachment.pdf"

        BuildPDFDocument()


        attachments = {My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\emailAttachment.pdf"}


        Dim Addresses() As String = {txtemailAddress.Text}

        Try

            If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\emailAttachment.pdf") Then

                SendEmail(Addresses, "", "", attachments)


                'Dim OutLookHelper As New OutlookHelper

                'OutLookHelper.SendMail(txtemailAddress.Text, "", "", txtSubject.Text, txtBody.Text, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\emailAttachment.pdf")

                Me.DialogResult = DialogResult.OK

            End If

        Catch ex As Exception
            MessageBox.Show("The following error occurred" & ex.Message.ToString)

        End Try


    End Sub

    Private Sub txtemailAddress_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemailAddress.Validated
        ' If all conditions have been met, clear the error provider of errors.
        errorProvider1.SetError(txtemailAddress, "")

    End Sub

    Private Sub txtemailAddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemailAddress.Validating
        Try
            MyValidatingCode()

        Catch ex As Exception
            ' Cancel the event and select the text to be corrected by the user.
            e.Cancel = True
            txtemailAddress.Select(0, txtemailAddress.Text.Length)

            ' Set the ErrorProvider error with the text to display. 
            errorProvider1.SetError(txtemailAddress, ex.Message)

        End Try

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SendEmail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'txtSubject.Text = "Acknowledge letter in regards to your submission in respect to D.A. No. " & _DaNo
        txtemailAddress.Text = _EmailAddress
    End Sub



    Public Shared Sub SendEmail([to] As String(), subject As String, body As String, attachments As String(), Optional display As Boolean = True, Optional useSignature As Boolean = True)
        'Create main objects
        Dim outlookApp As New Microsoft.Office.Interop.Outlook.Application()
        Dim [nameSpace] As Outlook.NameSpace = outlookApp.GetNamespace("MAPI")
        Dim mapiFolder As Outlook.MAPIFolder = [nameSpace].GetDefaultFolder(Outlook.OlDefaultFolders.olFolderSentMail)
        Dim mailItem As Outlook.MailItem = TryCast(mapiFolder.Items.Add(Outlook.OlItemType.olMailItem), Outlook.MailItem)
        Dim recipients As Outlook.Recipients = TryCast(mailItem.Recipients, Outlook.Recipients)

        'Set email subject
        mailItem.Subject = subject

        'Set email recipients
        For Each tempTO As String In [to]
            'Set recipient only if it is an Valid email address
            If tempTO <> String.Empty Then
                recipients.Add(tempTO)
            End If
        Next
        'Resolve recipients
        recipients.ResolveAll()

        'Add email attachments if there are some
        For Each attachment As String In attachments
            'Add attachment only if the attachment path really exists
            If File.Exists(attachment) Then
                mailItem.Attachments.Add(attachment)
            End If
        Next

        'Get the signature in the email body
        mailItem.GetInspector.Activate()
        Dim signature = mailItem.HTMLBody

        'Set the email body
        mailItem.HTMLBody = body

        'If useSignature is true add the signature to the body
        If useSignature Then
            mailItem.HTMLBody += signature
        End If

        'Display or directly send email depending on if there are recipients or the bool display
        If mailItem.Recipients.Count = 0 OrElse display Then
            mailItem.Display()
        Else
            mailItem.Send()
        End If
    End Sub

End Class