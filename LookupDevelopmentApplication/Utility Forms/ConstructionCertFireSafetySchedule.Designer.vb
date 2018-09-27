<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConstructionCertFireSafetySchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConstructionCertFireSafetySchedule))
        Me.lblCCappID = New DevExpress.XtraEditors.LabelControl()
        Me.txtSchedule = New DevExpress.XtraEditors.MemoEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSchedule.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblCCappID
        '
        Me.lblCCappID.Location = New System.Drawing.Point(13, 9)
        Me.lblCCappID.Name = "lblCCappID"
        Me.lblCCappID.Size = New System.Drawing.Size(0, 13)
        Me.lblCCappID.TabIndex = 0
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(12, 57)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(592, 361)
        Me.txtSchedule.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(501, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.ImageOptions.Image = CType(resources.GetObject("btnOK.ImageOptions.Image"),System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(394, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(101, 34)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        '
        'ConstructionCertFireSafetySchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(614, 430)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtSchedule)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCCappID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConstructionCertFireSafetySchedule"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Construction Certificate Fire Safety Schedule"
        CType(Me.txtSchedule.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblCCappID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSchedule As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
End Class
