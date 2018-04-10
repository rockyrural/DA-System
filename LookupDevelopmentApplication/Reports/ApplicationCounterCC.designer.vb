<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationCounterCC
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
        Me.components = New System.ComponentModel.Container
        Me.lblNoDays = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLastCY = New System.Windows.Forms.Button
        Me.btnCurCY = New System.Windows.Forms.Button
        Me.btnPrePrevQtr = New System.Windows.Forms.Button
        Me.btnPrevQtr = New System.Windows.Forms.Button
        Me.btnLastQtr = New System.Windows.Forms.Button
        Me.btnCurQtr = New System.Windows.Forms.Button
        Me.btnLastFY = New System.Windows.Forms.Button
        Me.btnCurFY = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTot1 = New System.Windows.Forms.Label
        Me.lblTot2 = New System.Windows.Forms.Label
        Me.lblTargetD1 = New System.Windows.Forms.Label
        Me.lblTargetD2 = New System.Windows.Forms.Label
        Me.lblD1 = New System.Windows.Forms.Label
        Me.lblD2 = New System.Windows.Forms.Label
        Me.lblTargetP1 = New System.Windows.Forms.Label
        Me.lblTargetP2 = New System.Windows.Forms.Label
        Me.lblP1 = New System.Windows.Forms.Label
        Me.lblP2 = New System.Windows.Forms.Label
        Me.btnSelected = New System.Windows.Forms.Button
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.cboOfficer = New System.Windows.Forms.ComboBox
        Me.ListOfOfficersForReportSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZONES = New LookupDevelopmentApplication.CZONES
        Me.Officer = New System.Windows.Forms.Label
        Me.ListOfOfficersForReportSelectionTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoDays
        '
        Me.lblNoDays.AutoSize = True
        Me.lblNoDays.Location = New System.Drawing.Point(281, 45)
        Me.lblNoDays.Name = "lblNoDays"
        Me.lblNoDays.Size = New System.Drawing.Size(0, 13)
        Me.lblNoDays.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "From"
        '
        'btnLastCY
        '
        Me.btnLastCY.Location = New System.Drawing.Point(420, 138)
        Me.btnLastCY.Name = "btnLastCY"
        Me.btnLastCY.Size = New System.Drawing.Size(75, 23)
        Me.btnLastCY.TabIndex = 17
        Me.btnLastCY.Text = "Last CY"
        Me.btnLastCY.UseVisualStyleBackColor = True
        '
        'btnCurCY
        '
        Me.btnCurCY.Location = New System.Drawing.Point(420, 113)
        Me.btnCurCY.Name = "btnCurCY"
        Me.btnCurCY.Size = New System.Drawing.Size(75, 23)
        Me.btnCurCY.TabIndex = 16
        Me.btnCurCY.Text = "Current CY"
        Me.btnCurCY.UseVisualStyleBackColor = True
        '
        'btnPrePrevQtr
        '
        Me.btnPrePrevQtr.Location = New System.Drawing.Point(420, 327)
        Me.btnPrePrevQtr.Name = "btnPrePrevQtr"
        Me.btnPrePrevQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnPrePrevQtr.TabIndex = 29
        Me.btnPrePrevQtr.Text = "PrePrevious Qtr"
        Me.btnPrePrevQtr.UseVisualStyleBackColor = True
        '
        'btnPrevQtr
        '
        Me.btnPrevQtr.Location = New System.Drawing.Point(420, 302)
        Me.btnPrevQtr.Name = "btnPrevQtr"
        Me.btnPrevQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevQtr.TabIndex = 28
        Me.btnPrevQtr.Text = "Previous Qtr"
        Me.btnPrevQtr.UseVisualStyleBackColor = True
        '
        'btnLastQtr
        '
        Me.btnLastQtr.Location = New System.Drawing.Point(420, 278)
        Me.btnLastQtr.Name = "btnLastQtr"
        Me.btnLastQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnLastQtr.TabIndex = 27
        Me.btnLastQtr.Text = "Last Qtr"
        Me.btnLastQtr.UseVisualStyleBackColor = True
        '
        'btnCurQtr
        '
        Me.btnCurQtr.Location = New System.Drawing.Point(420, 252)
        Me.btnCurQtr.Name = "btnCurQtr"
        Me.btnCurQtr.Size = New System.Drawing.Size(75, 23)
        Me.btnCurQtr.TabIndex = 26
        Me.btnCurQtr.Text = "Current Qtr"
        Me.btnCurQtr.UseVisualStyleBackColor = True
        '
        'btnLastFY
        '
        Me.btnLastFY.Location = New System.Drawing.Point(420, 212)
        Me.btnLastFY.Name = "btnLastFY"
        Me.btnLastFY.Size = New System.Drawing.Size(75, 23)
        Me.btnLastFY.TabIndex = 25
        Me.btnLastFY.Text = "Last FY"
        Me.btnLastFY.UseVisualStyleBackColor = True
        '
        'btnCurFY
        '
        Me.btnCurFY.Location = New System.Drawing.Point(420, 187)
        Me.btnCurFY.Name = "btnCurFY"
        Me.btnCurFY.Size = New System.Drawing.Size(75, 23)
        Me.btnCurFY.TabIndex = 24
        Me.btnCurFY.Text = "Current FY"
        Me.btnCurFY.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Target is % < days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "D"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "<D"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(326, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "T%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(372, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "A%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Class 1, 1A,1B,10,10A,10B : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Class 2, 3, 4, 4+6, 5, 7, 8,  9A : "
        '
        'lblTot1
        '
        Me.lblTot1.AutoSize = True
        Me.lblTot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot1.Location = New System.Drawing.Point(191, 140)
        Me.lblTot1.Name = "lblTot1"
        Me.lblTot1.Size = New System.Drawing.Size(0, 13)
        Me.lblTot1.TabIndex = 30
        '
        'lblTot2
        '
        Me.lblTot2.AutoSize = True
        Me.lblTot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot2.Location = New System.Drawing.Point(191, 167)
        Me.lblTot2.Name = "lblTot2"
        Me.lblTot2.Size = New System.Drawing.Size(0, 13)
        Me.lblTot2.TabIndex = 30
        '
        'lblTargetD1
        '
        Me.lblTargetD1.AutoSize = True
        Me.lblTargetD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetD1.Location = New System.Drawing.Point(235, 140)
        Me.lblTargetD1.Name = "lblTargetD1"
        Me.lblTargetD1.Size = New System.Drawing.Size(19, 13)
        Me.lblTargetD1.TabIndex = 30
        Me.lblTargetD1.Text = "30"
        '
        'lblTargetD2
        '
        Me.lblTargetD2.AutoSize = True
        Me.lblTargetD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetD2.Location = New System.Drawing.Point(235, 167)
        Me.lblTargetD2.Name = "lblTargetD2"
        Me.lblTargetD2.Size = New System.Drawing.Size(19, 13)
        Me.lblTargetD2.TabIndex = 30
        Me.lblTargetD2.Text = "30"
        '
        'lblD1
        '
        Me.lblD1.AutoSize = True
        Me.lblD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD1.Location = New System.Drawing.Point(278, 140)
        Me.lblD1.Name = "lblD1"
        Me.lblD1.Size = New System.Drawing.Size(0, 13)
        Me.lblD1.TabIndex = 30
        '
        'lblD2
        '
        Me.lblD2.AutoSize = True
        Me.lblD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD2.Location = New System.Drawing.Point(278, 167)
        Me.lblD2.Name = "lblD2"
        Me.lblD2.Size = New System.Drawing.Size(0, 13)
        Me.lblD2.TabIndex = 30
        '
        'lblTargetP1
        '
        Me.lblTargetP1.AutoSize = True
        Me.lblTargetP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetP1.Location = New System.Drawing.Point(322, 140)
        Me.lblTargetP1.Name = "lblTargetP1"
        Me.lblTargetP1.Size = New System.Drawing.Size(19, 13)
        Me.lblTargetP1.TabIndex = 30
        Me.lblTargetP1.Text = "75"
        '
        'lblTargetP2
        '
        Me.lblTargetP2.AutoSize = True
        Me.lblTargetP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetP2.Location = New System.Drawing.Point(322, 167)
        Me.lblTargetP2.Name = "lblTargetP2"
        Me.lblTargetP2.Size = New System.Drawing.Size(19, 13)
        Me.lblTargetP2.TabIndex = 30
        Me.lblTargetP2.Text = "75"
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(366, 140)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(0, 13)
        Me.lblP1.TabIndex = 30
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(366, 167)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(0, 13)
        Me.lblP2.TabIndex = 30
        '
        'btnSelected
        '
        Me.btnSelected.Location = New System.Drawing.Point(420, 75)
        Me.btnSelected.Name = "btnSelected"
        Me.btnSelected.Size = New System.Drawing.Size(75, 23)
        Me.btnSelected.TabIndex = 31
        Me.btnSelected.Text = "Selected"
        Me.btnSelected.UseVisualStyleBackColor = True
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(142, 41)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpToDate.TabIndex = 33
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(23, 41)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpFromDate.TabIndex = 32
        '
        'cboOfficer
        '
        Me.cboOfficer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOfficer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOfficer.DataSource = Me.ListOfOfficersForReportSelectionBindingSource
        Me.cboOfficer.DisplayMember = "Officer"
        Me.cboOfficer.Location = New System.Drawing.Point(64, 72)
        Me.cboOfficer.Name = "cboOfficer"
        Me.cboOfficer.Size = New System.Drawing.Size(217, 21)
        Me.cboOfficer.TabIndex = 34
        Me.cboOfficer.ValueMember = "Officer"
        Me.cboOfficer.Visible = False
        '
        'ListOfOfficersForReportSelectionBindingSource
        '
        Me.ListOfOfficersForReportSelectionBindingSource.DataMember = "ListOfOfficersForReportSelection"
        Me.ListOfOfficersForReportSelectionBindingSource.DataSource = Me.CZONES
        '
        'CZONES
        '
        Me.CZONES.DataSetName = "CZONES"
        Me.CZONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Officer
        '
        Me.Officer.AutoSize = True
        Me.Officer.Location = New System.Drawing.Point(20, 75)
        Me.Officer.Name = "Officer"
        Me.Officer.Size = New System.Drawing.Size(38, 13)
        Me.Officer.TabIndex = 35
        Me.Officer.Text = "Officer"
        Me.Officer.Visible = False
        '
        'ListOfOfficersForReportSelectionTableAdapter
        '
        Me.ListOfOfficersForReportSelectionTableAdapter.ClearBeforeFill = True
        '
        'ApplicationCounterCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 361)
        Me.Controls.Add(Me.Officer)
        Me.Controls.Add(Me.cboOfficer)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.btnSelected)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblTargetP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lblD2)
        Me.Controls.Add(Me.lblTargetP1)
        Me.Controls.Add(Me.lblD1)
        Me.Controls.Add(Me.lblTargetD2)
        Me.Controls.Add(Me.lblTargetD1)
        Me.Controls.Add(Me.lblTot2)
        Me.Controls.Add(Me.lblTot1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPrePrevQtr)
        Me.Controls.Add(Me.btnPrevQtr)
        Me.Controls.Add(Me.btnLastQtr)
        Me.Controls.Add(Me.btnCurQtr)
        Me.Controls.Add(Me.btnLastFY)
        Me.Controls.Add(Me.btnCurFY)
        Me.Controls.Add(Me.lblNoDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLastCY)
        Me.Controls.Add(Me.btnCurCY)
        Me.Name = "ApplicationCounterCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Operating Performance CC"
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoDays As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLastCY As System.Windows.Forms.Button
    Friend WithEvents btnCurCY As System.Windows.Forms.Button
    Friend WithEvents btnPrePrevQtr As System.Windows.Forms.Button
    Friend WithEvents btnPrevQtr As System.Windows.Forms.Button
    Friend WithEvents btnLastQtr As System.Windows.Forms.Button
    Friend WithEvents btnCurQtr As System.Windows.Forms.Button
    Friend WithEvents btnLastFY As System.Windows.Forms.Button
    Friend WithEvents btnCurFY As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTot1 As System.Windows.Forms.Label
    Friend WithEvents lblTot2 As System.Windows.Forms.Label
    Friend WithEvents lblTargetD1 As System.Windows.Forms.Label
    Friend WithEvents lblTargetD2 As System.Windows.Forms.Label
    Friend WithEvents lblD1 As System.Windows.Forms.Label
    Friend WithEvents lblD2 As System.Windows.Forms.Label
    Friend WithEvents lblTargetP1 As System.Windows.Forms.Label
    Friend WithEvents lblTargetP2 As System.Windows.Forms.Label
    Friend WithEvents lblP1 As System.Windows.Forms.Label
    Friend WithEvents lblP2 As System.Windows.Forms.Label
    Friend WithEvents btnSelected As System.Windows.Forms.Button
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboOfficer As System.Windows.Forms.ComboBox
    Friend WithEvents Officer As System.Windows.Forms.Label
    Friend WithEvents ListOfOfficersForReportSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents ListOfOfficersForReportSelectionTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter
End Class
