<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EASEInsertWordDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EASEInsertWordDocument))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtPartID = New System.Windows.Forms.TextBox()
        Me.txtFileSubTitle = New System.Windows.Forms.TextBox()
        Me.txtFileTitle = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtFileXref = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAttachDocument = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the file number to which this document is to be attached."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.txtPartID)
        Me.GroupBox1.Controls.Add(Me.txtFileSubTitle)
        Me.GroupBox1.Controls.Add(Me.txtFileTitle)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Controls.Add(Me.txtFileXref)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Lookup"
        '
        'btnFind
        '
        Me.btnFind.ImageIndex = 1
        Me.btnFind.ImageList = Me.ImageList1
        Me.btnFind.Location = New System.Drawing.Point(188, 19)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(30, 22)
        Me.btnFind.TabIndex = 19
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BINOCULR.ICO")
        Me.ImageList1.Images.SetKeyName(1, "smlbinos.ico")
        '
        'txtPartID
        '
        Me.txtPartID.BackColor = System.Drawing.SystemColors.Info
        Me.txtPartID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartID.Location = New System.Drawing.Point(292, 21)
        Me.txtPartID.Name = "txtPartID"
        Me.txtPartID.ReadOnly = True
        Me.txtPartID.Size = New System.Drawing.Size(23, 20)
        Me.txtPartID.TabIndex = 18
        '
        'txtFileSubTitle
        '
        Me.txtFileSubTitle.AcceptsReturn = True
        Me.txtFileSubTitle.BackColor = System.Drawing.SystemColors.Info
        Me.txtFileSubTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileSubTitle.Location = New System.Drawing.Point(75, 91)
        Me.txtFileSubTitle.Name = "txtFileSubTitle"
        Me.txtFileSubTitle.ReadOnly = True
        Me.txtFileSubTitle.Size = New System.Drawing.Size(240, 20)
        Me.txtFileSubTitle.TabIndex = 17
        '
        'txtFileTitle
        '
        Me.txtFileTitle.BackColor = System.Drawing.SystemColors.Info
        Me.txtFileTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileTitle.Location = New System.Drawing.Point(75, 72)
        Me.txtFileTitle.Name = "txtFileTitle"
        Me.txtFileTitle.ReadOnly = True
        Me.txtFileTitle.Size = New System.Drawing.Size(240, 20)
        Me.txtFileTitle.TabIndex = 16
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.SystemColors.Info
        Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocation.Location = New System.Drawing.Point(200, 46)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(115, 20)
        Me.txtLocation.TabIndex = 15
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Location = New System.Drawing.Point(75, 46)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(62, 20)
        Me.txtBarcode.TabIndex = 14
        '
        'txtFileXref
        '
        Me.txtFileXref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileXref.Location = New System.Drawing.Point(75, 21)
        Me.txtFileXref.Name = "txtFileXref"
        Me.txtFileXref.Size = New System.Drawing.Size(111, 20)
        Me.txtFileXref.TabIndex = 13
        Me.txtFileXref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Part:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sub Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Barcode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "File No.:"
        '
        'btnAttachDocument
        '
        Me.btnAttachDocument.Location = New System.Drawing.Point(116, 163)
        Me.btnAttachDocument.Name = "btnAttachDocument"
        Me.btnAttachDocument.Size = New System.Drawing.Size(123, 23)
        Me.btnAttachDocument.TabIndex = 2
        Me.btnAttachDocument.Text = "Attach Document"
        Me.btnAttachDocument.UseVisualStyleBackColor = True
        '
        'EASEInsertWordDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAttachDocument)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EASEInsertWordDocument"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert Document into EASE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtPartID As System.Windows.Forms.TextBox
    Friend WithEvents txtFileSubTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtFileTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtFileXref As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAttachDocument As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
