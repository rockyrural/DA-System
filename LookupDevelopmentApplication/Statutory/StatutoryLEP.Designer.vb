<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryLEP
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
        Dim Label19 As System.Windows.Forms.Label
        Dim LEPRelevantProvLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvZoneInformation = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZoning = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermitted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZoneObjectives = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZoneUses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblZoneID = New System.Windows.Forms.Label()
        Me.btnUses = New System.Windows.Forms.Button()
        Me.btnObjectives = New System.Windows.Forms.Button()
        Me.btnPlanObjectives = New System.Windows.Forms.Button()
        Me.cboPermited = New System.Windows.Forms.ComboBox()
        Me.txtDAzone = New System.Windows.Forms.TextBox()
        Me.btnRetrieveZones = New System.Windows.Forms.Button()
        Me.txtLEPComments = New System.Windows.Forms.TextBox()
        Me.txtLEPRelevantProv = New System.Windows.Forms.TextBox()
        Label19 = New System.Windows.Forms.Label()
        LEPRelevantProvLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvZoneInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(21, 151)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(51, 13)
        Label19.TabIndex = 87
        Label19.Text = "Permited:"
        '
        'LEPRelevantProvLabel
        '
        LEPRelevantProvLabel.AutoSize = True
        LEPRelevantProvLabel.Location = New System.Drawing.Point(6, 248)
        LEPRelevantProvLabel.Name = "LEPRelevantProvLabel"
        LEPRelevantProvLabel.Size = New System.Drawing.Size(104, 13)
        LEPRelevantProvLabel.TabIndex = 94
        LEPRelevantProvLabel.Text = "Relevant Provisions:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(267, 9)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(205, 13)
        Label17.TabIndex = 98
        Label17.Text = "Editable Zone Desc for use in documents:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 350)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 100
        Label1.Text = "Comments:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnUpdate)
        Me.GroupBox4.Controls.Add(Me.dgvZoneInformation)
        Me.GroupBox4.Controls.Add(Me.lblZoneID)
        Me.GroupBox4.Controls.Add(Me.btnUses)
        Me.GroupBox4.Controls.Add(Me.btnObjectives)
        Me.GroupBox4.Controls.Add(Me.btnPlanObjectives)
        Me.GroupBox4.Controls.Add(Me.cboPermited)
        Me.GroupBox4.Controls.Add(Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(661, 186)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(141, 147)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(54, 21)
        Me.btnUpdate.TabIndex = 95
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvZoneInformation
        '
        Me.dgvZoneInformation.AllowUserToAddRows = False
        Me.dgvZoneInformation.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZoneInformation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvZoneInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colZoning, Me.colLEP, Me.colPermitted, Me.colComments, Me.DocPath, Me.ZoneObjectives, Me.ZoneUses})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvZoneInformation.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvZoneInformation.Location = New System.Drawing.Point(8, 15)
        Me.dgvZoneInformation.Name = "dgvZoneInformation"
        Me.dgvZoneInformation.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZoneInformation.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvZoneInformation.RowHeadersVisible = False
        Me.dgvZoneInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvZoneInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZoneInformation.Size = New System.Drawing.Size(644, 117)
        Me.dgvZoneInformation.TabIndex = 94
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = ""
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colZoning
        '
        Me.colZoning.DataPropertyName = "ZDS"
        Me.colZoning.HeaderText = "Zoning"
        Me.colZoning.Name = "colZoning"
        Me.colZoning.ReadOnly = True
        Me.colZoning.Width = 200
        '
        'colLEP
        '
        Me.colLEP.DataPropertyName = "LEP"
        Me.colLEP.HeaderText = "LEP"
        Me.colLEP.Name = "colLEP"
        Me.colLEP.ReadOnly = True
        Me.colLEP.Width = 200
        '
        'colPermitted
        '
        Me.colPermitted.DataPropertyName = "Permitted"
        Me.colPermitted.HeaderText = "Permit"
        Me.colPermitted.Name = "colPermitted"
        Me.colPermitted.ReadOnly = True
        Me.colPermitted.Width = 40
        '
        'colComments
        '
        Me.colComments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colComments.DataPropertyName = "comments"
        Me.colComments.HeaderText = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.ReadOnly = True
        '
        'DocPath
        '
        Me.DocPath.DataPropertyName = "DocPath"
        Me.DocPath.HeaderText = ""
        Me.DocPath.MinimumWidth = 2
        Me.DocPath.Name = "DocPath"
        Me.DocPath.ReadOnly = True
        Me.DocPath.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DocPath.Visible = False
        Me.DocPath.Width = 2
        '
        'ZoneObjectives
        '
        Me.ZoneObjectives.DataPropertyName = "ZoneObjectives"
        Me.ZoneObjectives.HeaderText = ""
        Me.ZoneObjectives.MinimumWidth = 2
        Me.ZoneObjectives.Name = "ZoneObjectives"
        Me.ZoneObjectives.ReadOnly = True
        Me.ZoneObjectives.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ZoneObjectives.Visible = False
        Me.ZoneObjectives.Width = 2
        '
        'ZoneUses
        '
        Me.ZoneUses.DataPropertyName = "ZoneUses"
        Me.ZoneUses.HeaderText = ""
        Me.ZoneUses.MinimumWidth = 2
        Me.ZoneUses.Name = "ZoneUses"
        Me.ZoneUses.ReadOnly = True
        Me.ZoneUses.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ZoneUses.Visible = False
        Me.ZoneUses.Width = 2
        '
        'lblZoneID
        '
        Me.lblZoneID.AutoSize = True
        Me.lblZoneID.Location = New System.Drawing.Point(179, 135)
        Me.lblZoneID.Name = "lblZoneID"
        Me.lblZoneID.Size = New System.Drawing.Size(0, 13)
        Me.lblZoneID.TabIndex = 93
        '
        'btnUses
        '
        Me.btnUses.Location = New System.Drawing.Point(577, 138)
        Me.btnUses.Name = "btnUses"
        Me.btnUses.Size = New System.Drawing.Size(75, 38)
        Me.btnUses.TabIndex = 90
        Me.btnUses.Text = "Uses"
        Me.btnUses.UseVisualStyleBackColor = True
        '
        'btnObjectives
        '
        Me.btnObjectives.Location = New System.Drawing.Point(496, 138)
        Me.btnObjectives.Name = "btnObjectives"
        Me.btnObjectives.Size = New System.Drawing.Size(75, 38)
        Me.btnObjectives.TabIndex = 89
        Me.btnObjectives.Text = "Objectives"
        Me.btnObjectives.UseVisualStyleBackColor = True
        '
        'btnPlanObjectives
        '
        Me.btnPlanObjectives.Location = New System.Drawing.Point(385, 138)
        Me.btnPlanObjectives.Name = "btnPlanObjectives"
        Me.btnPlanObjectives.Size = New System.Drawing.Size(105, 38)
        Me.btnPlanObjectives.TabIndex = 88
        Me.btnPlanObjectives.Text = "Plan Objectives"
        Me.btnPlanObjectives.UseVisualStyleBackColor = True
        '
        'cboPermited
        '
        Me.cboPermited.FormattingEnabled = True
        Me.cboPermited.Location = New System.Drawing.Point(78, 148)
        Me.cboPermited.Name = "cboPermited"
        Me.cboPermited.Size = New System.Drawing.Size(57, 21)
        Me.cboPermited.TabIndex = 1
        '
        'txtDAzone
        '
        Me.txtDAzone.BackColor = System.Drawing.SystemColors.Info
        Me.txtDAzone.Location = New System.Drawing.Point(269, 25)
        Me.txtDAzone.Name = "txtDAzone"
        Me.txtDAzone.ReadOnly = True
        Me.txtDAzone.Size = New System.Drawing.Size(398, 20)
        Me.txtDAzone.TabIndex = 97
        '
        'btnRetrieveZones
        '
        Me.btnRetrieveZones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieveZones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRetrieveZones.Location = New System.Drawing.Point(6, 12)
        Me.btnRetrieveZones.Name = "btnRetrieveZones"
        Me.btnRetrieveZones.Size = New System.Drawing.Size(229, 34)
        Me.btnRetrieveZones.TabIndex = 96
        Me.btnRetrieveZones.Text = "Get/Refresh Zone Details"
        Me.btnRetrieveZones.UseVisualStyleBackColor = True
        '
        'txtLEPComments
        '
        Me.txtLEPComments.Location = New System.Drawing.Point(7, 372)
        Me.txtLEPComments.Multiline = True
        Me.txtLEPComments.Name = "txtLEPComments"
        Me.txtLEPComments.Size = New System.Drawing.Size(862, 355)
        Me.txtLEPComments.TabIndex = 103
        '
        'txtLEPRelevantProv
        '
        Me.txtLEPRelevantProv.Location = New System.Drawing.Point(6, 264)
        Me.txtLEPRelevantProv.Multiline = True
        Me.txtLEPRelevantProv.Name = "txtLEPRelevantProv"
        Me.txtLEPRelevantProv.Size = New System.Drawing.Size(863, 83)
        Me.txtLEPRelevantProv.TabIndex = 104
        '
        'StatutoryLEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 736)
        Me.Controls.Add(Me.txtLEPRelevantProv)
        Me.Controls.Add(Me.txtLEPComments)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.txtDAzone)
        Me.Controls.Add(Me.btnRetrieveZones)
        Me.Controls.Add(LEPRelevantProvLabel)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryLEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Statutory LEP"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvZoneInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblZoneID As System.Windows.Forms.Label
    Friend WithEvents btnUses As System.Windows.Forms.Button
    Friend WithEvents btnObjectives As System.Windows.Forms.Button
    Friend WithEvents btnPlanObjectives As System.Windows.Forms.Button
    Friend WithEvents cboPermited As System.Windows.Forms.ComboBox
    Friend WithEvents dgvZoneInformation As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtDAzone As System.Windows.Forms.TextBox
    Friend WithEvents btnRetrieveZones As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colZoning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPermitted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZoneObjectives As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZoneUses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLEPComments As System.Windows.Forms.TextBox
    Friend WithEvents txtLEPRelevantProv As System.Windows.Forms.TextBox
End Class
