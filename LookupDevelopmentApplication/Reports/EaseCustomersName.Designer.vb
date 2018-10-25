<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EaseCustomersName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EaseCustomersName))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAppPcode = New System.Windows.Forms.TextBox()
        Me.txtAppTown = New System.Windows.Forms.TextBox()
        Me.txtAppAddress = New System.Windows.Forms.TextBox()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This is the name that will be used when inserted into EASE Change it now if not c" & _
            "orrect."
        '
        'txtAppPcode
        '
        Me.txtAppPcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtAppPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPcode.Location = New System.Drawing.Point(168, 114)
        Me.txtAppPcode.Name = "txtAppPcode"
        Me.txtAppPcode.ReadOnly = True
        Me.txtAppPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtAppPcode.TabIndex = 9
        '
        'txtAppTown
        '
        Me.txtAppTown.BackColor = System.Drawing.SystemColors.Info
        Me.txtAppTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppTown.Location = New System.Drawing.Point(15, 114)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.ReadOnly = True
        Me.txtAppTown.Size = New System.Drawing.Size(154, 20)
        Me.txtAppTown.TabIndex = 8
        '
        'txtAppAddress
        '
        Me.txtAppAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtAppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppAddress.Location = New System.Drawing.Point(15, 79)
        Me.txtAppAddress.Multiline = True
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.ReadOnly = True
        Me.txtAppAddress.Size = New System.Drawing.Size(192, 36)
        Me.txtAppAddress.TabIndex = 7
        '
        'txtAppName
        '
        Me.txtAppName.BackColor = System.Drawing.SystemColors.Info
        Me.txtAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppName.Location = New System.Drawing.Point(15, 60)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.ReadOnly = True
        Me.txtAppName.Size = New System.Drawing.Size(192, 20)
        Me.txtAppName.TabIndex = 6
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(217, 99)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(44, 35)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'EaseCustomersName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 145)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtAppPcode)
        Me.Controls.Add(Me.txtAppTown)
        Me.Controls.Add(Me.txtAppAddress)
        Me.Controls.Add(Me.txtAppName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EaseCustomersName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EASE Customers Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAppPcode As System.Windows.Forms.TextBox
    Friend WithEvents txtAppTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAppAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAppName As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
