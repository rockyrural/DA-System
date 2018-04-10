<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationCounterCD
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
        Me.components = New System.ComponentModel.Container()
        Me.lblNoDays = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLastCY = New System.Windows.Forms.Button()
        Me.btnCurCY = New System.Windows.Forms.Button()
        Me.btnPrePrevQtr = New System.Windows.Forms.Button()
        Me.btnPrevQtr = New System.Windows.Forms.Button()
        Me.btnLastQtr = New System.Windows.Forms.Button()
        Me.btnCurQtr = New System.Windows.Forms.Button()
        Me.btnLastFY = New System.Windows.Forms.Button()
        Me.btnCurFY = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTot1 = New System.Windows.Forms.Label()
        Me.lblTot2 = New System.Windows.Forms.Label()
        Me.lblTot3 = New System.Windows.Forms.Label()
        Me.lblTot4 = New System.Windows.Forms.Label()
        Me.lblTot5 = New System.Windows.Forms.Label()
        Me.lblTot6 = New System.Windows.Forms.Label()
        Me.lblTargetD1 = New System.Windows.Forms.Label()
        Me.lblTargetD2 = New System.Windows.Forms.Label()
        Me.lblTargetD3 = New System.Windows.Forms.Label()
        Me.lblD1 = New System.Windows.Forms.Label()
        Me.lblD2 = New System.Windows.Forms.Label()
        Me.lblD3 = New System.Windows.Forms.Label()
        Me.lblD4 = New System.Windows.Forms.Label()
        Me.lblD5 = New System.Windows.Forms.Label()
        Me.lblD6 = New System.Windows.Forms.Label()
        Me.lblTargetP1 = New System.Windows.Forms.Label()
        Me.lblTargetP2 = New System.Windows.Forms.Label()
        Me.lblTargetP3 = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.lblP3 = New System.Windows.Forms.Label()
        Me.lblP4 = New System.Windows.Forms.Label()
        Me.lblP5 = New System.Windows.Forms.Label()
        Me.lblP6 = New System.Windows.Forms.Label()
        Me.btnSelected = New System.Windows.Forms.Button()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.cboOfficer = New System.Windows.Forms.ComboBox()
        Me.ListOfOfficersForReportSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZONES = New LookupDevelopmentApplication.CZONES()
        Me.Officer = New System.Windows.Forms.Label()
        Me.ListOfOfficersForReportSelectionTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTot7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnLastCY.Location = New System.Drawing.Point(7, 136)
        Me.btnLastCY.Name = "btnLastCY"
        Me.btnLastCY.Size = New System.Drawing.Size(75, 26)
        Me.btnLastCY.TabIndex = 17
        Me.btnLastCY.Text = "Last CY"
        Me.btnLastCY.UseVisualStyleBackColor = True
        '
        'btnCurCY
        '
        Me.btnCurCY.Location = New System.Drawing.Point(7, 111)
        Me.btnCurCY.Name = "btnCurCY"
        Me.btnCurCY.Size = New System.Drawing.Size(75, 26)
        Me.btnCurCY.TabIndex = 16
        Me.btnCurCY.Text = "Current CY"
        Me.btnCurCY.UseVisualStyleBackColor = True
        '
        'btnPrePrevQtr
        '
        Me.btnPrePrevQtr.Location = New System.Drawing.Point(7, 360)
        Me.btnPrePrevQtr.Name = "btnPrePrevQtr"
        Me.btnPrePrevQtr.Size = New System.Drawing.Size(75, 47)
        Me.btnPrePrevQtr.TabIndex = 29
        Me.btnPrePrevQtr.Text = "PrePrevious Qtr"
        Me.btnPrePrevQtr.UseVisualStyleBackColor = True
        '
        'btnPrevQtr
        '
        Me.btnPrevQtr.Location = New System.Drawing.Point(7, 309)
        Me.btnPrevQtr.Name = "btnPrevQtr"
        Me.btnPrevQtr.Size = New System.Drawing.Size(75, 35)
        Me.btnPrevQtr.TabIndex = 28
        Me.btnPrevQtr.Text = "Previous Qtr"
        Me.btnPrevQtr.UseVisualStyleBackColor = True
        '
        'btnLastQtr
        '
        Me.btnLastQtr.Location = New System.Drawing.Point(7, 277)
        Me.btnLastQtr.Name = "btnLastQtr"
        Me.btnLastQtr.Size = New System.Drawing.Size(75, 26)
        Me.btnLastQtr.TabIndex = 27
        Me.btnLastQtr.Text = "Last Qtr"
        Me.btnLastQtr.UseVisualStyleBackColor = True
        '
        'btnCurQtr
        '
        Me.btnCurQtr.Location = New System.Drawing.Point(7, 243)
        Me.btnCurQtr.Name = "btnCurQtr"
        Me.btnCurQtr.Size = New System.Drawing.Size(75, 26)
        Me.btnCurQtr.TabIndex = 26
        Me.btnCurQtr.Text = "Current Qtr"
        Me.btnCurQtr.UseVisualStyleBackColor = True
        '
        'btnLastFY
        '
        Me.btnLastFY.Location = New System.Drawing.Point(7, 210)
        Me.btnLastFY.Name = "btnLastFY"
        Me.btnLastFY.Size = New System.Drawing.Size(75, 26)
        Me.btnLastFY.TabIndex = 25
        Me.btnLastFY.Text = "Last FY"
        Me.btnLastFY.UseVisualStyleBackColor = True
        '
        'btnCurFY
        '
        Me.btnCurFY.Location = New System.Drawing.Point(7, 185)
        Me.btnCurFY.Name = "btnCurFY"
        Me.btnCurFY.Size = New System.Drawing.Size(75, 26)
        Me.btnCurFY.TabIndex = 24
        Me.btnCurFY.Text = "Current FY"
        Me.btnCurFY.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Target is % < days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "D"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "<D"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "T%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(468, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "A%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "1.4. CD Determined by ESC"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "1.6. Building Certificate (AA)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "6. Turnaround of DA Referrals"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "1 / 1.2. CC determ by Total and Council"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "1 / 1.3. CO Rego by Total and Council"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(184, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "1 / 1.4. CD rego by Total and Council"
        '
        'lblTot1
        '
        Me.lblTot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot1.Location = New System.Drawing.Point(287, 39)
        Me.lblTot1.Name = "lblTot1"
        Me.lblTot1.Size = New System.Drawing.Size(38, 13)
        Me.lblTot1.TabIndex = 30
        '
        'lblTot2
        '
        Me.lblTot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot2.Location = New System.Drawing.Point(287, 66)
        Me.lblTot2.Name = "lblTot2"
        Me.lblTot2.Size = New System.Drawing.Size(38, 13)
        Me.lblTot2.TabIndex = 30
        '
        'lblTot3
        '
        Me.lblTot3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot3.Location = New System.Drawing.Point(287, 136)
        Me.lblTot3.Name = "lblTot3"
        Me.lblTot3.Size = New System.Drawing.Size(38, 13)
        Me.lblTot3.TabIndex = 30
        '
        'lblTot4
        '
        Me.lblTot4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot4.Location = New System.Drawing.Point(287, 163)
        Me.lblTot4.Name = "lblTot4"
        Me.lblTot4.Size = New System.Drawing.Size(38, 13)
        Me.lblTot4.TabIndex = 30
        '
        'lblTot5
        '
        Me.lblTot5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot5.Location = New System.Drawing.Point(287, 190)
        Me.lblTot5.Name = "lblTot5"
        Me.lblTot5.Size = New System.Drawing.Size(38, 13)
        Me.lblTot5.TabIndex = 30
        '
        'lblTot6
        '
        Me.lblTot6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot6.Location = New System.Drawing.Point(287, 217)
        Me.lblTot6.Name = "lblTot6"
        Me.lblTot6.Size = New System.Drawing.Size(38, 13)
        Me.lblTot6.TabIndex = 30
        '
        'lblTargetD1
        '
        Me.lblTargetD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetD1.Location = New System.Drawing.Point(341, 39)
        Me.lblTargetD1.Name = "lblTargetD1"
        Me.lblTargetD1.Size = New System.Drawing.Size(18, 13)
        Me.lblTargetD1.TabIndex = 30
        Me.lblTargetD1.Text = "7"
        '
        'lblTargetD2
        '
        Me.lblTargetD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetD2.Location = New System.Drawing.Point(341, 66)
        Me.lblTargetD2.Name = "lblTargetD2"
        Me.lblTargetD2.Size = New System.Drawing.Size(18, 13)
        Me.lblTargetD2.TabIndex = 30
        Me.lblTargetD2.Text = "5"
        '
        'lblTargetD3
        '
        Me.lblTargetD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetD3.Location = New System.Drawing.Point(341, 136)
        Me.lblTargetD3.Name = "lblTargetD3"
        Me.lblTargetD3.Size = New System.Drawing.Size(18, 13)
        Me.lblTargetD3.TabIndex = 30
        Me.lblTargetD3.Text = "20"
        '
        'lblD1
        '
        Me.lblD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD1.Location = New System.Drawing.Point(374, 39)
        Me.lblD1.Name = "lblD1"
        Me.lblD1.Size = New System.Drawing.Size(25, 13)
        Me.lblD1.TabIndex = 30
        '
        'lblD2
        '
        Me.lblD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD2.Location = New System.Drawing.Point(374, 66)
        Me.lblD2.Name = "lblD2"
        Me.lblD2.Size = New System.Drawing.Size(25, 13)
        Me.lblD2.TabIndex = 30
        '
        'lblD3
        '
        Me.lblD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD3.Location = New System.Drawing.Point(374, 136)
        Me.lblD3.Name = "lblD3"
        Me.lblD3.Size = New System.Drawing.Size(25, 13)
        Me.lblD3.TabIndex = 30
        '
        'lblD4
        '
        Me.lblD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD4.Location = New System.Drawing.Point(374, 163)
        Me.lblD4.Name = "lblD4"
        Me.lblD4.Size = New System.Drawing.Size(25, 13)
        Me.lblD4.TabIndex = 30
        '
        'lblD5
        '
        Me.lblD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD5.Location = New System.Drawing.Point(374, 190)
        Me.lblD5.Name = "lblD5"
        Me.lblD5.Size = New System.Drawing.Size(25, 13)
        Me.lblD5.TabIndex = 30
        '
        'lblD6
        '
        Me.lblD6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD6.Location = New System.Drawing.Point(374, 217)
        Me.lblD6.Name = "lblD6"
        Me.lblD6.Size = New System.Drawing.Size(25, 13)
        Me.lblD6.TabIndex = 30
        '
        'lblTargetP1
        '
        Me.lblTargetP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetP1.Location = New System.Drawing.Point(422, 39)
        Me.lblTargetP1.Name = "lblTargetP1"
        Me.lblTargetP1.Size = New System.Drawing.Size(26, 13)
        Me.lblTargetP1.TabIndex = 30
        Me.lblTargetP1.Text = "90"
        '
        'lblTargetP2
        '
        Me.lblTargetP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetP2.Location = New System.Drawing.Point(422, 66)
        Me.lblTargetP2.Name = "lblTargetP2"
        Me.lblTargetP2.Size = New System.Drawing.Size(26, 13)
        Me.lblTargetP2.TabIndex = 30
        Me.lblTargetP2.Text = "75"
        '
        'lblTargetP3
        '
        Me.lblTargetP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetP3.Location = New System.Drawing.Point(422, 136)
        Me.lblTargetP3.Name = "lblTargetP3"
        Me.lblTargetP3.Size = New System.Drawing.Size(26, 13)
        Me.lblTargetP3.TabIndex = 30
        Me.lblTargetP3.Text = "70"
        '
        'lblP1
        '
        Me.lblP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(468, 39)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(26, 13)
        Me.lblP1.TabIndex = 30
        '
        'lblP2
        '
        Me.lblP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(468, 66)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(26, 13)
        Me.lblP2.TabIndex = 30
        '
        'lblP3
        '
        Me.lblP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3.Location = New System.Drawing.Point(468, 136)
        Me.lblP3.Name = "lblP3"
        Me.lblP3.Size = New System.Drawing.Size(26, 13)
        Me.lblP3.TabIndex = 30
        '
        'lblP4
        '
        Me.lblP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4.Location = New System.Drawing.Point(468, 163)
        Me.lblP4.Name = "lblP4"
        Me.lblP4.Size = New System.Drawing.Size(26, 13)
        Me.lblP4.TabIndex = 30
        '
        'lblP5
        '
        Me.lblP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP5.Location = New System.Drawing.Point(468, 190)
        Me.lblP5.Name = "lblP5"
        Me.lblP5.Size = New System.Drawing.Size(26, 13)
        Me.lblP5.TabIndex = 30
        '
        'lblP6
        '
        Me.lblP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP6.Location = New System.Drawing.Point(468, 217)
        Me.lblP6.Name = "lblP6"
        Me.lblP6.Size = New System.Drawing.Size(26, 13)
        Me.lblP6.TabIndex = 30
        '
        'btnSelected
        '
        Me.btnSelected.Location = New System.Drawing.Point(7, 73)
        Me.btnSelected.Name = "btnSelected"
        Me.btnSelected.Size = New System.Drawing.Size(75, 26)
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Not Officer Specific"
        '
        'lblTot7
        '
        Me.lblTot7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot7.Location = New System.Drawing.Point(287, 246)
        Me.lblTot7.Name = "lblTot7"
        Me.lblTot7.Size = New System.Drawing.Size(38, 13)
        Me.lblTot7.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 246)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(228, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Occupation Certificates for NEW DWELLINGS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSelected)
        Me.Panel1.Controls.Add(Me.btnPrePrevQtr)
        Me.Panel1.Controls.Add(Me.btnPrevQtr)
        Me.Panel1.Controls.Add(Me.btnLastQtr)
        Me.Panel1.Controls.Add(Me.btnCurQtr)
        Me.Panel1.Controls.Add(Me.btnLastFY)
        Me.Panel1.Controls.Add(Me.btnCurFY)
        Me.Panel1.Controls.Add(Me.btnLastCY)
        Me.Panel1.Controls.Add(Me.btnCurCY)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(546, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(91, 501)
        Me.Panel1.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTot7)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblP6)
        Me.GroupBox1.Controls.Add(Me.lblD6)
        Me.GroupBox1.Controls.Add(Me.lblP5)
        Me.GroupBox1.Controls.Add(Me.lblD5)
        Me.GroupBox1.Controls.Add(Me.lblP4)
        Me.GroupBox1.Controls.Add(Me.lblD4)
        Me.GroupBox1.Controls.Add(Me.lblP3)
        Me.GroupBox1.Controls.Add(Me.lblTot6)
        Me.GroupBox1.Controls.Add(Me.lblTargetP3)
        Me.GroupBox1.Controls.Add(Me.lblD3)
        Me.GroupBox1.Controls.Add(Me.lblTot5)
        Me.GroupBox1.Controls.Add(Me.lblP2)
        Me.GroupBox1.Controls.Add(Me.lblTargetD3)
        Me.GroupBox1.Controls.Add(Me.lblTargetP2)
        Me.GroupBox1.Controls.Add(Me.lblTot4)
        Me.GroupBox1.Controls.Add(Me.lblP1)
        Me.GroupBox1.Controls.Add(Me.lblD2)
        Me.GroupBox1.Controls.Add(Me.lblTargetP1)
        Me.GroupBox1.Controls.Add(Me.lblTot3)
        Me.GroupBox1.Controls.Add(Me.lblD1)
        Me.GroupBox1.Controls.Add(Me.lblTargetD2)
        Me.GroupBox1.Controls.Add(Me.lblTargetD1)
        Me.GroupBox1.Controls.Add(Me.lblTot2)
        Me.GroupBox1.Controls.Add(Me.lblTot1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 290)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 468)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(144, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "T% = Target percentage"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 449)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(160, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "A% = Achieved percentage"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 430)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(188, 13)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "<D = Determined under required"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 411)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(273, 13)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "D = Days with in which it should be determined"
        '
        'ApplicationCounterCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 501)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Officer)
        Me.Controls.Add(Me.cboOfficer)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.lblNoDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ApplicationCounterCD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Operating Performance CD"
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTot1 As System.Windows.Forms.Label
    Friend WithEvents lblTot2 As System.Windows.Forms.Label
    Friend WithEvents lblTot3 As System.Windows.Forms.Label
    Friend WithEvents lblTot4 As System.Windows.Forms.Label
    Friend WithEvents lblTot5 As System.Windows.Forms.Label
    Friend WithEvents lblTot6 As System.Windows.Forms.Label
    Friend WithEvents lblTargetD1 As System.Windows.Forms.Label
    Friend WithEvents lblTargetD2 As System.Windows.Forms.Label
    Friend WithEvents lblTargetD3 As System.Windows.Forms.Label
    Friend WithEvents lblD1 As System.Windows.Forms.Label
    Friend WithEvents lblD2 As System.Windows.Forms.Label
    Friend WithEvents lblD3 As System.Windows.Forms.Label
    Friend WithEvents lblD4 As System.Windows.Forms.Label
    Friend WithEvents lblD5 As System.Windows.Forms.Label
    Friend WithEvents lblD6 As System.Windows.Forms.Label
    Friend WithEvents lblTargetP1 As System.Windows.Forms.Label
    Friend WithEvents lblTargetP2 As System.Windows.Forms.Label
    Friend WithEvents lblTargetP3 As System.Windows.Forms.Label
    Friend WithEvents lblP1 As System.Windows.Forms.Label
    Friend WithEvents lblP2 As System.Windows.Forms.Label
    Friend WithEvents lblP3 As System.Windows.Forms.Label
    Friend WithEvents lblP4 As System.Windows.Forms.Label
    Friend WithEvents lblP5 As System.Windows.Forms.Label
    Friend WithEvents lblP6 As System.Windows.Forms.Label
    Friend WithEvents btnSelected As System.Windows.Forms.Button
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboOfficer As System.Windows.Forms.ComboBox
    Friend WithEvents Officer As System.Windows.Forms.Label
    Friend WithEvents ListOfOfficersForReportSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents ListOfOfficersForReportSelectionTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTot7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
