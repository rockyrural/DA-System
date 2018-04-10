Imports Microsoft.Office.Interop
Imports System.IO.FileInfo


Public Class OutlookHelper
    Public Sub SendMail(ByVal recepient As String, ByVal bcc As String, ByVal cc As String, ByVal subject As String, ByVal body As String, ByVal MailAttachment As String)
        Dim FileName As IO.FileInfo

        Dim oApp As Outlook.Application
        oApp = CType(CreateObject("Outlook.Application"), Outlook.Application)

        ' Logon. Doesn't hurt if you are already running and logged on...
        Dim olNs As Outlook.NameSpace
        olNs = oApp.GetNamespace("MAPI")
        olNs.Logon()

        Dim sBodyLen As String
        Dim oAttachs As Outlook.Attachments
        Dim oAttach As Outlook.Attachment
        'oApp = New Outlook.ApplicationClass()

        ' Create a new MailItem.
        Dim oMsg As Outlook._MailItem
        oMsg = CType(oApp.CreateItem(Outlook.OlItemType.olMailItem), Outlook._MailItem)
        oMsg.Subject = subject
        oMsg.Body = body & vbCr & vbCr

        ' TODO: Replace with a valid e-mail address.
        oMsg.To = recepient

        If cc <> String.Empty Then oMsg.CC = cc

        ' Add an attachment

        'Add email attachments if there are some
        For Each attachment As String In MailAttachment
            'Add attachment only if the attachment path really exists
            If My.Computer.FileSystem.FileExists(attachment) Then
                FileName = My.Computer.FileSystem.GetFileInfo(attachment)

                sBodyLen = CStr(oMsg.Body.Length)
                oAttachs = oMsg.Attachments

                oAttach = oAttachs.Add(MailAttachment, , CDbl(sBodyLen) + 1, FileName.ToString)


            End If
        Next

        'If MailAttachment <> String.Empty Then
        '    FileName = My.Computer.FileSystem.GetFileInfo(MailAttachment)

        '    sBodyLen = CStr(oMsg.Body.Length)
        '    oAttachs = oMsg.Attachments

        '    oAttach = oAttachs.Add(MailAttachment, , CDbl(sBodyLen) + 1, FileName.ToString)
        'End If

        ' Send
        oMsg.Send()

        ' Clean up
        olNs.Logoff()
        oApp = Nothing
        oMsg = Nothing
        oAttach = Nothing
        oAttachs = Nothing

    End Sub

End Class
