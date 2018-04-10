<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAdjacentPropertiesForMailMerge
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAdjacentPropertiesForMailMerge))
        Me.chkStrataProperties = New DevExpress.XtraEditors.CheckEdit()
        Me.bedtMergeFile = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblSelectMailMergeData = New DevExpress.XtraEditors.LabelControl()
        Me.btnRun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.chkStrataProperties.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bedtMergeFile.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'chkStrataProperties
        '
        Me.chkStrataProperties.Location = New System.Drawing.Point(12, 64)
        Me.chkStrataProperties.Name = "chkStrataProperties"
        Me.chkStrataProperties.Properties.Caption = "Strata / Units"
        Me.chkStrataProperties.Size = New System.Drawing.Size(116, 19)
        Me.chkStrataProperties.TabIndex = 0
        '
        'bedtMergeFile
        '
        Me.bedtMergeFile.EditValue = ""
        Me.bedtMergeFile.Location = New System.Drawing.Point(12, 28)
        Me.bedtMergeFile.Name = "bedtMergeFile"
        Me.bedtMergeFile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bedtMergeFile.Properties.ReadOnly = true
        Me.bedtMergeFile.Size = New System.Drawing.Size(371, 20)
        Me.bedtMergeFile.TabIndex = 1
        '
        'lblSelectMailMergeData
        '
        Me.lblSelectMailMergeData.Location = New System.Drawing.Point(12, 8)
        Me.lblSelectMailMergeData.Name = "lblSelectMailMergeData"
        Me.lblSelectMailMergeData.Size = New System.Drawing.Size(109, 13)
        Me.lblSelectMailMergeData.TabIndex = 2
        Me.lblSelectMailMergeData.Text = "Select Mail Merge Data"
        '
        'btnRun
        '
        Me.btnRun.Enabled = false
        Me.btnRun.ImageOptions.Image = CType(resources.GetObject("btnRun.ImageOptions.Image"),System.Drawing.Image)
        Me.btnRun.Location = New System.Drawing.Point(283, 67)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(100, 36)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "Run"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(283, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'ImportAdjacentPropertiesForMailMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 159)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblSelectMailMergeData)
        Me.Controls.Add(Me.bedtMergeFile)
        Me.Controls.Add(Me.chkStrataProperties)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ImportAdjacentPropertiesForMailMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Adjacent Properties "
        CType(Me.chkStrataProperties.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bedtMergeFile.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents chkStrataProperties As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bedtMergeFile As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblSelectMailMergeData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRun As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
