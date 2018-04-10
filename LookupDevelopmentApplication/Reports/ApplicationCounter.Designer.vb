<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationCounter
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
        Me.btnCurCY = New System.Windows.Forms.Button
        Me.btnLastCY = New System.Windows.Forms.Button
        Me.btnCurFY = New System.Windows.Forms.Button
        Me.btnLastFY = New System.Windows.Forms.Button
        Me.btnCurQtr = New System.Windows.Forms.Button
        Me.btnLastQtr = New System.Windows.Forms.Button
        Me.btnPrevQtr = New System.Windows.Forms.Button
        Me.btnPrePrevQtr = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblDA = New System.Windows.Forms.Label
        Me.lblCC = New System.Windows.Forms.Label
        Me.lblCD = New System.Windows.Forms.Label
        Me.lblAA = New System.Windows.Forms.Label
        Me.lblNoDays = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.btnSelected = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCurCY
        '
        Me.btnCurCY.Location = New System.Drawing.Point(381, 43)
        Me.btnCurCY.Name = "btnCurCY"
        Me.btnCurCY.Size = New System.Drawing.Size(75, 23)
        Me.btnCurCY.TabIndex = 0
        Me.btnCurCY.Text = "Current CY"
        Me.btnCurCY.UseVisualStyleBackColor = True
        '
        'btnLastCY
        '
        Me.btnLastCY.Location = New System.Drawing.Point(381, 68)
        Me.btnLastCY.Name = "btnLastCY"
        Me.btnLastCY.Size = New System.Drawing.Size(75, 23)
        Me.btnLastCY.TabIndex = 1
        Me.btnLastCY.Text = "Last CY"
        Me.btnLastCY.UseVisualStyleBackColor = True
        '
        'btnCurFY
        '
        Me.btnCurFY.Location = New System.Drawing.Point(381, 104)
        Me.btnCurFY.Name = "btnCurFY"
        Me.btnCurFY.Size = New System.Drawing.Size(75, 23)
        Me.btnCurFY.TabIndex = 2
        Me.btnCurFY.Text = "Current FY"
        Me.btnCurFY.UseVisualStyleBackColor = True
        '
        'btnLastFY
        '
        Me.btnLastFY.Location = New System.Drawing.Point(381, 129)
        Me.btnLastFY.Name = "btnLastFY"
        Me.btnLastFY.Size = New System.Drawing.Size(75, 23)
        Me.btnLastFY.TabIndex = 3
        Me.btnLastFY.Text = "Last FY"
        Me.btnLastFY.UseVisualStyleBackColor = True
        '
        'btnCurQtr
        '
        Me.btnCurQtr.Location = New System.Drawing.Point(381, 169)
        Me.btnCurQtr.Name = "btnCurQtr"
        Me.btnCurQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnCurQtr.TabIndex = 4
        Me.btnCurQtr.Text = "Current Qtr"
        Me.btnCurQtr.UseVisualStyleBackColor = True
        '
        'btnLastQtr
        '
        Me.btnLastQtr.Location = New System.Drawing.Point(381, 195)
        Me.btnLastQtr.Name = "btnLastQtr"
        Me.btnLastQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnLastQtr.TabIndex = 5
        Me.btnLastQtr.Text = "Last Qtr"
        Me.btnLastQtr.UseVisualStyleBackColor = True
        '
        'btnPrevQtr
        '
        Me.btnPrevQtr.Location = New System.Drawing.Point(381, 219)
        Me.btnPrevQtr.Name = "btnPrevQtr"
        Me.btnPrevQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevQtr.TabIndex = 6
        Me.btnPrevQtr.Text = "Previous Qtr"
        Me.btnPrevQtr.UseVisualStyleBackColor = True
        '
        'btnPrePrevQtr
        '
        Me.btnPrePrevQtr.Location = New System.Drawing.Point(381, 244)
        Me.btnPrePrevQtr.Name = "btnPrePrevQtr"
        Me.btnPrePrevQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnPrePrevQtr.TabIndex = 7
        Me.btnPrePrevQtr.Text = "PrePrevious Qtr"
        Me.btnPrePrevQtr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "DA Rego Count = "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CC Rego Count = "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CD Rego Count = "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "AA Rego Count = "
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.Location = New System.Drawing.Point(160, 88)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(0, 13)
        Me.lblDA.TabIndex = 15
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(160, 113)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(0, 13)
        Me.lblCC.TabIndex = 15
        '
        'lblCD
        '
        Me.lblCD.AutoSize = True
        Me.lblCD.Location = New System.Drawing.Point(160, 139)
        Me.lblCD.Name = "lblCD"
        Me.lblCD.Size = New System.Drawing.Size(0, 13)
        Me.lblCD.TabIndex = 15
        '
        'lblAA
        '
        Me.lblAA.AutoSize = True
        Me.lblAA.Location = New System.Drawing.Point(160, 163)
        Me.lblAA.Name = "lblAA"
        Me.lblAA.Size = New System.Drawing.Size(0, 13)
        Me.lblAA.TabIndex = 15
        '
        'lblNoDays
        '
        Me.lblNoDays.AutoSize = True
        Me.lblNoDays.Location = New System.Drawing.Point(298, 43)
        Me.lblNoDays.Name = "lblNoDays"
        Me.lblNoDays.Size = New System.Drawing.Size(0, 13)
        Me.lblNoDays.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(40, 39)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpFromDate.TabIndex = 20
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(159, 39)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpToDate.TabIndex = 21
        '
        'btnSelected
        '
        Me.btnSelected.Location = New System.Drawing.Point(381, 9)
        Me.btnSelected.Name = "btnSelected"
        Me.btnSelected.Size = New System.Drawing.Size(75, 23)
        Me.btnSelected.TabIndex = 22
        Me.btnSelected.Text = "Selected"
        Me.btnSelected.UseVisualStyleBackColor = True
        '
        'ApplicationCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 283)
        Me.Controls.Add(Me.btnSelected)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAA)
        Me.Controls.Add(Me.lblCD)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.lblNoDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrePrevQtr)
        Me.Controls.Add(Me.btnPrevQtr)
        Me.Controls.Add(Me.btnLastQtr)
        Me.Controls.Add(Me.btnCurQtr)
        Me.Controls.Add(Me.btnLastFY)
        Me.Controls.Add(Me.btnCurFY)
        Me.Controls.Add(Me.btnLastCY)
        Me.Controls.Add(Me.btnCurCY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ApplicationCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Application Counters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCurCY As System.Windows.Forms.Button
    Friend WithEvents btnLastCY As System.Windows.Forms.Button
    Friend WithEvents btnCurFY As System.Windows.Forms.Button
    Friend WithEvents btnLastFY As System.Windows.Forms.Button
    Friend WithEvents btnCurQtr As System.Windows.Forms.Button
    Friend WithEvents btnLastQtr As System.Windows.Forms.Button
    Friend WithEvents btnPrevQtr As System.Windows.Forms.Button
    Friend WithEvents btnPrePrevQtr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDA As System.Windows.Forms.Label
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents lblCD As System.Windows.Forms.Label
    Friend WithEvents lblAA As System.Windows.Forms.Label
    Friend WithEvents lblNoDays As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSelected As System.Windows.Forms.Button
End Class
