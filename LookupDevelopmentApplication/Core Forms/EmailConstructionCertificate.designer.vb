<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmailConstructionCertificate
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemailAddress = New DevExpress.XtraEditors.TextEdit()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtemailAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Confirm Email address:"
        '
        'txtemailAddress
        '
        Me.txtemailAddress.Location = New System.Drawing.Point(5, 24)
        Me.txtemailAddress.Name = "txtemailAddress"
        Me.txtemailAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtemailAddress.Size = New System.Drawing.Size(451, 20)
        Me.txtemailAddress.TabIndex = 6
        '
        'btnSend
        '
        Me.btnSend.Image = Global.LookupDevelopmentApplication.My.Resources.Resources.eMail
        Me.btnSend.Location = New System.Drawing.Point(462, 11)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(88, 35)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email"
        '
        'EmailConstructionCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 56)
        Me.Controls.Add(Me.txtemailAddress)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EmailConstructionCertificate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirm Email Address"
        CType(Me.txtemailAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtemailAddress As DevExpress.XtraEditors.TextEdit
End Class
