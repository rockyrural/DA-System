<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldImagesViewer
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.imgCurrent = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.FilmStripControl = New FilmStripControl.FilmStrip.FilmStripControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.imgCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel1.Controls.Add(Me.imgCurrent)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(773, 699)
        Me.SplitContainer1.SplitterDistance = 472
        Me.SplitContainer1.TabIndex = 1
        '
        'imgCurrent
        '
        Me.imgCurrent.BackColor = System.Drawing.Color.Transparent
        Me.imgCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCurrent.Location = New System.Drawing.Point(133, 67)
        Me.imgCurrent.Name = "imgCurrent"
        Me.imgCurrent.Size = New System.Drawing.Size(503, 314)
        Me.imgCurrent.TabIndex = 0
        Me.imgCurrent.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Double click image to see large version and to print"
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.PapayaWhip
        Me.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfo.Controls.Add(Me.FilmStripControl)
        Me.pnlInfo.Controls.Add(Me.Label2)
        Me.pnlInfo.Controls.Add(Me.txtDescription)
        Me.pnlInfo.Controls.Add(Me.Label3)
        Me.pnlInfo.Controls.Add(Me.Label1)
        Me.pnlInfo.Controls.Add(Me.txtDate)
        Me.pnlInfo.Controls.Add(Me.txtSubject)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfo.Location = New System.Drawing.Point(0, 3)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(773, 220)
        Me.pnlInfo.TabIndex = 1
        '
        'FilmStripControl
        '
        Me.FilmStripControl.Location = New System.Drawing.Point(4, 97)
        Me.FilmStripControl.Name = "FilmStripControl"
        Me.FilmStripControl.Size = New System.Drawing.Size(757, 110)
        Me.FilmStripControl.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comment:"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Location = New System.Drawing.Point(153, 65)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(596, 26)
        Me.txtDescription.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Taken By:"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate.Location = New System.Drawing.Point(153, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(123, 20)
        Me.txtDate.TabIndex = 0
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubject.Location = New System.Drawing.Point(153, 39)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(123, 20)
        Me.txtSubject.TabIndex = 0
        '
        'OldImagesViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 699)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OldImagesViewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OldImagesViewer"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.imgCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgCurrent As System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents FilmStripControl As FilmStripControl.FilmStrip.FilmStripControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
