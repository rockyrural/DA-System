<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryDCPCheckList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatutoryDCPCheckList))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlControlParent = New DevExpress.XtraEditors.PanelControl()
        Me.cboDCPCheckList = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlTop.SuspendLayout()
        CType(Me.pnlControlParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDCPCheckList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.cboDCPCheckList)
        Me.pnlTop.Controls.Add(Me.btnView)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1059, 52)
        Me.pnlTop.TabIndex = 2
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(439, 10)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "View Checklist"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select DCP CheckList:"
        '
        'pnlControlParent
        '
        Me.pnlControlParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControlParent.Location = New System.Drawing.Point(0, 52)
        Me.pnlControlParent.Name = "pnlControlParent"
        Me.pnlControlParent.Size = New System.Drawing.Size(1059, 712)
        Me.pnlControlParent.TabIndex = 3
        '
        'cboDCPCheckList
        '
        Me.cboDCPCheckList.Location = New System.Drawing.Point(124, 12)
        Me.cboDCPCheckList.Name = "cboDCPCheckList"
        Me.cboDCPCheckList.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDCPCheckList.Properties.DisplayMember = "DCPDesc"
        Me.cboDCPCheckList.Properties.NullText = "[Select DCP Check List]"
        Me.cboDCPCheckList.Properties.ValueMember = "DCPType"
        Me.cboDCPCheckList.Size = New System.Drawing.Size(300, 20)
        Me.cboDCPCheckList.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(936, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 42)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'StatutoryDCPCheckList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1059, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlControlParent)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryDCPCheckList"
        Me.Text = "Statutory DCP CheckList"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pnlControlParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDCPCheckList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents pnlControlParent As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboDCPCheckList As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
