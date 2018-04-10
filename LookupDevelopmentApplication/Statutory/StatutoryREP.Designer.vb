<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryREP
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
        Dim RepCommentssLabel As System.Windows.Forms.Label
        Me.dgvStatutory_REP_Records = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRepCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboLoadREPcodesList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdateREPCode = New System.Windows.Forms.Button()
        Me.lblREPid = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.RepCommentssTextBox = New System.Windows.Forms.TextBox()
        RepCommentssLabel = New System.Windows.Forms.Label()
        CType(Me.dgvStatutory_REP_Records, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepCommentssLabel
        '
        RepCommentssLabel.AutoSize = True
        RepCommentssLabel.Location = New System.Drawing.Point(15, 285)
        RepCommentssLabel.Name = "RepCommentssLabel"
        RepCommentssLabel.Size = New System.Drawing.Size(59, 13)
        RepCommentssLabel.TabIndex = 8
        RepCommentssLabel.Text = "Comments:"
        '
        'dgvStatutory_REP_Records
        '
        Me.dgvStatutory_REP_Records.AllowUserToAddRows = False
        Me.dgvStatutory_REP_Records.AllowUserToDeleteRows = False
        Me.dgvStatutory_REP_Records.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colRepCode, Me.colComments})
        Me.dgvStatutory_REP_Records.Location = New System.Drawing.Point(12, 12)
        Me.dgvStatutory_REP_Records.Name = "dgvStatutory_REP_Records"
        Me.dgvStatutory_REP_Records.ReadOnly = True
        Me.dgvStatutory_REP_Records.RowHeadersVisible = False
        Me.dgvStatutory_REP_Records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatutory_REP_Records.Size = New System.Drawing.Size(626, 152)
        Me.dgvStatutory_REP_Records.TabIndex = 2
        '
        'colID
        '
        Me.colID.DataPropertyName = "id"
        Me.colID.HeaderText = ""
        Me.colID.MinimumWidth = 2
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colID.Visible = False
        Me.colID.Width = 2
        '
        'colRepCode
        '
        Me.colRepCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRepCode.DataPropertyName = "RepTitle"
        Me.colRepCode.FillWeight = 50.0!
        Me.colRepCode.HeaderText = "REP Code"
        Me.colRepCode.Name = "colRepCode"
        Me.colRepCode.ReadOnly = True
        '
        'colComments
        '
        Me.colComments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colComments.DataPropertyName = "Comments"
        Me.colComments.FillWeight = 50.0!
        Me.colComments.HeaderText = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.ReadOnly = True
        '
        'cboLoadREPcodesList
        '
        Me.cboLoadREPcodesList.DisplayMember = "Id"
        Me.cboLoadREPcodesList.Location = New System.Drawing.Point(12, 189)
        Me.cboLoadREPcodesList.Name = "cboLoadREPcodesList"
        Me.cboLoadREPcodesList.Size = New System.Drawing.Size(300, 21)
        Me.cboLoadREPcodesList.TabIndex = 0
        Me.cboLoadREPcodesList.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "REP Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comment"
        '
        'btnUpdateREPCode
        '
        Me.btnUpdateREPCode.Location = New System.Drawing.Point(562, 253)
        Me.btnUpdateREPCode.Name = "btnUpdateREPCode"
        Me.btnUpdateREPCode.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateREPCode.TabIndex = 3
        Me.btnUpdateREPCode.Text = "Update"
        Me.btnUpdateREPCode.UseVisualStyleBackColor = True
        '
        'lblREPid
        '
        Me.lblREPid.AutoSize = True
        Me.lblREPid.Location = New System.Drawing.Point(21, 221)
        Me.lblREPid.Name = "lblREPid"
        Me.lblREPid.Size = New System.Drawing.Size(0, 13)
        Me.lblREPid.TabIndex = 6
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(325, 190)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(312, 52)
        Me.txtComment.TabIndex = 9
        '
        'RepCommentssTextBox
        '
        Me.RepCommentssTextBox.Location = New System.Drawing.Point(20, 304)
        Me.RepCommentssTextBox.Multiline = True
        Me.RepCommentssTextBox.Name = "RepCommentssTextBox"
        Me.RepCommentssTextBox.Size = New System.Drawing.Size(617, 68)
        Me.RepCommentssTextBox.TabIndex = 10
        '
        'StatutoryREP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 382)
        Me.Controls.Add(Me.RepCommentssTextBox)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(RepCommentssLabel)
        Me.Controls.Add(Me.lblREPid)
        Me.Controls.Add(Me.btnUpdateREPCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLoadREPcodesList)
        Me.Controls.Add(Me.dgvStatutory_REP_Records)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryREP"
        Me.Text = "Statutory REP"
        CType(Me.dgvStatutory_REP_Records, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStatutory_REP_Records As System.Windows.Forms.DataGridView
    Friend WithEvents cboLoadREPcodesList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateREPCode As System.Windows.Forms.Button
    Friend WithEvents lblREPid As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRepCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents RepCommentssTextBox As System.Windows.Forms.TextBox
End Class
