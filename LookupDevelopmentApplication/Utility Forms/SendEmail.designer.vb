<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmail))
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me.txtemailAddress = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtemailAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email address:"
        '
        'btnSend
        '
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.Location = New System.Drawing.Point(464, 20)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(103, 34)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send Email"
        '
        'txtemailAddress
        '
        Me.txtemailAddress.Location = New System.Drawing.Point(12, 34)
        Me.txtemailAddress.Name = "txtemailAddress"
        Me.txtemailAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtemailAddress.Size = New System.Drawing.Size(442, 20)
        Me.txtemailAddress.TabIndex = 6
        '
        'SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 67)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtemailAddress)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SendEmail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.txtemailAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtemailAddress As DevExpress.XtraEditors.TextEdit
End Class
