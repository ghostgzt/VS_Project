<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form4
#Region "Windows 窗体设计器生成的代码 "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'此调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
	End Sub
	'窗体重写释放，以清理组件列表。
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器来修改它。
    '不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.image1 = New System.Windows.Forms.Button
        Me.WindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "欢迎使用"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(160, 148)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(153, 21)
        Me.Text1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Text1, "类似*.mp3;*.mid;*.wav;*.wma输入后按回车即可 ")
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        Me.File1.Hidden = True
        Me.File1.Location = New System.Drawing.Point(0, 168)
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.*"
        Me.File1.Size = New System.Drawing.Size(273, 40)
        Me.File1.System = True
        Me.File1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.File1, "双击被选择的项目" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　即可播放")
        '
        'Drive1
        '
        Me.Drive1.BackColor = System.Drawing.SystemColors.Window
        Me.Drive1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drive1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Drive1.FormattingEnabled = True
        Me.Drive1.Location = New System.Drawing.Point(160, 0)
        Me.Drive1.Name = "Drive1"
        Me.Drive1.Size = New System.Drawing.Size(153, 22)
        Me.Drive1.TabIndex = 0
        '
        'Dir1
        '
        Me.Dir1.BackColor = System.Drawing.SystemColors.Window
        Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(160, 20)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.Size = New System.Drawing.Size(153, 130)
        Me.Dir1.TabIndex = 1
        '
        'image1
        '
        Me.image1.Image = CType(resources.GetObject("image1.Image"), System.Drawing.Image)
        Me.image1.Location = New System.Drawing.Point(275, 170)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(38, 38)
        Me.image1.TabIndex = 5
        Me.image1.Text = "确定"
        Me.image1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.image1.UseVisualStyleBackColor = True
        '
        'WindowsMediaPlayer1
        '
        Me.WindowsMediaPlayer1.AllowDrop = True
        Me.WindowsMediaPlayer1.Enabled = True
        Me.WindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.WindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(0)
        Me.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1"
        Me.WindowsMediaPlayer1.OcxState = CType(resources.GetObject("WindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WindowsMediaPlayer1.Size = New System.Drawing.Size(158, 169)
        Me.WindowsMediaPlayer1.TabIndex = 6
        Me.WindowsMediaPlayer1.UseWaitCursor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Form4
        '
        Me.AcceptButton = Me.image1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(312, 209)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.File1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Drive1)
        Me.Controls.Add(Me.Dir1)
        Me.Controls.Add(Me.WindowsMediaPlayer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(362, 307)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "选择播放"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents image1 As System.Windows.Forms.Button
    Friend WithEvents WindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
#End Region
End Class