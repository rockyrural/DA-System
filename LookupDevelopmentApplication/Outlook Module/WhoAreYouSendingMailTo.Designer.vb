<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhoAreYouSendingMailTo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhoAreYouSendingMailTo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnApplicant = New System.Windows.Forms.RadioButton()
        Me.rbnOwner = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sending this mail to the:"
        '
        'rbnApplicant
        '
        Me.rbnApplicant.AutoSize = True
        Me.rbnApplicant.Location = New System.Drawing.Point(177, 12)
        Me.rbnApplicant.Name = "rbnApplicant"
        Me.rbnApplicant.Size = New System.Drawing.Size(69, 17)
        Me.rbnApplicant.TabIndex = 1
        Me.rbnApplicant.TabStop = True
        Me.rbnApplicant.Text = "Applicant"
        Me.rbnApplicant.UseVisualStyleBackColor = True
        '
        'rbnOwner
        '
        Me.rbnOwner.AutoSize = True
        Me.rbnOwner.Location = New System.Drawing.Point(177, 35)
        Me.rbnOwner.Name = "rbnOwner"
        Me.rbnOwner.Size = New System.Drawing.Size(56, 17)
        Me.rbnOwner.TabIndex = 1
        Me.rbnOwner.TabStop = True
        Me.rbnOwner.Text = "Owner"
        Me.rbnOwner.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(278, 29)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'WhoAreYouSendingMailTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 60)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.rbnOwner)
        Me.Controls.Add(Me.rbnApplicant)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WhoAreYouSendingMailTo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Who Are You Sending Mail To"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbnApplicant As System.Windows.Forms.RadioButton
    Friend WithEvents rbnOwner As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
