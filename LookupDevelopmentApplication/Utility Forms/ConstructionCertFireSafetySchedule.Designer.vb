<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConstructionCertFireSafetySchedule
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
        Me.lblCCappID = New System.Windows.Forms.Label()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCCappID
        '
        Me.lblCCappID.AutoSize = True
        Me.lblCCappID.Location = New System.Drawing.Point(13, 9)
        Me.lblCCappID.Name = "lblCCappID"
        Me.lblCCappID.Size = New System.Drawing.Size(0, 13)
        Me.lblCCappID.TabIndex = 0
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(12, 57)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(592, 361)
        Me.txtSchedule.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule"
        '
        'ConstructionCertFireSafetySchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 430)
        Me.Controls.Add(Me.txtSchedule)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCCappID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConstructionCertFireSafetySchedule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Construction Certificate Fire Safety Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCCappID As System.Windows.Forms.Label
    Friend WithEvents txtSchedule As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
