<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSection94Contribution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSection94Contribution))
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSection94Code = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboS94Type = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtS94ContCalc = New DevExpress.XtraEditors.TextEdit()
        Me.txtS94CalcNote = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cboSection94Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboS94Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtS94ContCalc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtS94CalcNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(365, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(365, 49)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 36)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'cboSection94Code
        '
        Me.cboSection94Code.Location = New System.Drawing.Point(40, 12)
        Me.cboSection94Code.Name = "cboSection94Code"
        Me.cboSection94Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSection94Code.Properties.NullText = "[Select Plan]"
        Me.cboSection94Code.Size = New System.Drawing.Size(319, 20)
        Me.cboSection94Code.TabIndex = 2
        '
        'cboS94Type
        '
        Me.cboS94Type.Location = New System.Drawing.Point(40, 42)
        Me.cboS94Type.Name = "cboS94Type"
        Me.cboS94Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboS94Type.Properties.NullText = "[Select Type]"
        Me.cboS94Type.Size = New System.Drawing.Size(128, 20)
        Me.cboS94Type.TabIndex = 3
        '
        'txtS94ContCalc
        '
        Me.txtS94ContCalc.EditValue = ""
        Me.txtS94ContCalc.Location = New System.Drawing.Point(259, 42)
        Me.txtS94ContCalc.Name = "txtS94ContCalc"
        Me.txtS94ContCalc.Size = New System.Drawing.Size(100, 20)
        Me.txtS94ContCalc.TabIndex = 4
        '
        'txtS94CalcNote
        '
        Me.txtS94CalcNote.EditValue = ""
        Me.txtS94CalcNote.Location = New System.Drawing.Point(40, 68)
        Me.txtS94CalcNote.Name = "txtS94CalcNote"
        Me.txtS94CalcNote.Size = New System.Drawing.Size(319, 20)
        Me.txtS94CalcNote.TabIndex = 5
        '
        'LabelControl
        '
        Me.LabelControl.Location = New System.Drawing.Point(5, 15)
        Me.LabelControl.Name = "LabelControl"
        Me.LabelControl.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl.TabIndex = 6
        Me.LabelControl.Text = "Plan:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Type:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Note:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(189, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Calc Amount:"
        '
        'AddSection94Contribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(472, 93)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl)
        Me.Controls.Add(Me.txtS94CalcNote)
        Me.Controls.Add(Me.txtS94ContCalc)
        Me.Controls.Add(Me.cboS94Type)
        Me.Controls.Add(Me.cboSection94Code)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddSection94Contribution"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cboSection94Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboS94Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtS94ContCalc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtS94CalcNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSection94Code As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboS94Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtS94ContCalc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtS94CalcNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
