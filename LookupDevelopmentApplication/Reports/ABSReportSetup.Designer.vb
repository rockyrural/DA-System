<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABSReportSetup
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
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.dtpFromTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnABSstats = New System.Windows.Forms.Button
        Me.btnConRes = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(87, 42)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(95, 20)
        Me.dtpDateFrom.TabIndex = 0
        '
        'dtpFromTo
        '
        Me.dtpFromTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromTo.Location = New System.Drawing.Point(87, 79)
        Me.dtpFromTo.Name = "dtpFromTo"
        Me.dtpFromTo.Size = New System.Drawing.Size(95, 20)
        Me.dtpFromTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'btnABSstats
        '
        Me.btnABSstats.Location = New System.Drawing.Point(17, 125)
        Me.btnABSstats.Name = "btnABSstats"
        Me.btnABSstats.Size = New System.Drawing.Size(168, 28)
        Me.btnABSstats.TabIndex = 4
        Me.btnABSstats.Text = "Produce ABS Statistics"
        Me.btnABSstats.UseVisualStyleBackColor = True
        '
        'btnConRes
        '
        Me.btnConRes.Location = New System.Drawing.Point(191, 125)
        Me.btnConRes.Name = "btnConRes"
        Me.btnConRes.Size = New System.Drawing.Size(168, 28)
        Me.btnConRes.TabIndex = 5
        Me.btnConRes.Text = "Produce ConRes Statistics"
        Me.btnConRes.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(22, 172)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        '
        'ABSReportSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 259)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnConRes)
        Me.Controls.Add(Me.btnABSstats)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFromTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ABSReportSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABS Report Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnABSstats As System.Windows.Forms.Button
    Friend WithEvents btnConRes As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
