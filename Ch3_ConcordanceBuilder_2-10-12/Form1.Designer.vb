<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFileName = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearchWord = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFind = New System.Windows.Forms.ToolStripButton()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.lblFileName, Me.txtSearchWord, Me.btnFind, Me.btnAll})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(940, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileExit})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(120, 26)
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(120, 26)
        Me.mnuFileExit.Text = "Exit"
        '
        'lblFileName
        '
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(118, 24)
        Me.lblFileName.Text = "Click File to start"
        '
        'txtSearchWord
        '
        Me.txtSearchWord.Name = "txtSearchWord"
        Me.txtSearchWord.Size = New System.Drawing.Size(132, 27)
        '
        'btnFind
        '
        Me.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(41, 24)
        Me.btnFind.Text = "Find"
        '
        'btnAll
        '
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(31, 24)
        Me.btnAll.Text = "All"
        '
        'lstBox
        '
        Me.lstBox.ColumnWidth = 100
        Me.lstBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 22
        Me.lstBox.Location = New System.Drawing.Point(0, 27)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(940, 373)
        Me.lstBox.TabIndex = 1
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 400)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lance'sLab - Searching for a word in a Text file"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFileName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearchWord As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstBox As System.Windows.Forms.ListBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog

End Class
