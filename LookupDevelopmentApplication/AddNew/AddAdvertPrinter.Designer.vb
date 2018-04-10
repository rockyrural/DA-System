<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAdvertPrinter
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.crvAdvert = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1131, 42)
        Me.Panel1.TabIndex = 0
        '
        'crvAdvert
        '
        Me.crvAdvert.ActiveViewIndex = -1
        Me.crvAdvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvAdvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvAdvert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvAdvert.Location = New System.Drawing.Point(0, 42)
        Me.crvAdvert.Name = "crvAdvert"
        Me.crvAdvert.SelectionFormula = ""
        Me.crvAdvert.ShowCloseButton = False
        Me.crvAdvert.ShowGotoPageButton = False
        Me.crvAdvert.ShowGroupTreeButton = False
        Me.crvAdvert.ShowRefreshButton = False
        Me.crvAdvert.ShowTextSearchButton = False
        Me.crvAdvert.ShowZoomButton = False
        Me.crvAdvert.Size = New System.Drawing.Size(1131, 761)
        Me.crvAdvert.TabIndex = 1
        Me.crvAdvert.ViewTimeSelectionFormula = ""
        '
        'AddAdvertPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 803)
        Me.Controls.Add(Me.crvAdvert)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddAdvertPrinter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents crvAdvert As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
