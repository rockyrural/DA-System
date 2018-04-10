<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultimediaInterface
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.imgCurrent = New System.Windows.Forms.PictureBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.FilmStripControl = New FilmStripControl.FilmStrip.FilmStripControl()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.cd = New System.Windows.Forms.OpenFileDialog()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPrint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.imgCurrent)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(765, 710)
        Me.SplitContainer1.SplitterDistance = 481
        Me.SplitContainer1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(616, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(137, 31)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print This"
        Me.btnPrint.UseVisualStyleBackColor = False
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
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.PapayaWhip
        Me.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfo.Controls.Add(Me.FilmStripControl)
        Me.pnlInfo.Controls.Add(Me.btnAddPhoto)
        Me.pnlInfo.Controls.Add(Me.Label2)
        Me.pnlInfo.Controls.Add(Me.txtDescription)
        Me.pnlInfo.Controls.Add(Me.Label1)
        Me.pnlInfo.Controls.Add(Me.txtSubject)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(765, 225)
        Me.pnlInfo.TabIndex = 1
        '
        'FilmStripControl
        '
        Me.FilmStripControl.Location = New System.Drawing.Point(3, 110)
        Me.FilmStripControl.Name = "FilmStripControl"
        Me.FilmStripControl.Size = New System.Drawing.Size(757, 110)
        Me.FilmStripControl.TabIndex = 5
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAddPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnAddPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPhoto.Location = New System.Drawing.Point(313, 71)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(137, 31)
        Me.btnAddPhoto.TabIndex = 4
        Me.btnAddPhoto.Text = "&Add Photo"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Location = New System.Drawing.Point(81, 37)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(671, 26)
        Me.txtDescription.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject:"
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubject.Location = New System.Drawing.Point(81, 12)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(673, 20)
        Me.txtSubject.TabIndex = 0
        '
        'cd
        '
        Me.cd.FileName = "OpenFileDialog1"
        Me.cd.Filter = "JPEG file|*.jpg|Bitmap Files|*.bmp"
        '
        'MultimediaInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 710)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MultimediaInterface"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add and View Images"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
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
    Friend WithEvents btnAddPhoto As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents cd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FilmStripControl As FilmStripControl.FilmStrip.FilmStripControl
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
