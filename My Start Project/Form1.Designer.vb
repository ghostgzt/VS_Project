<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyStart
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyStart))
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text4 = New System.Windows.Forms.TextBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.Text6 = New System.Windows.Forms.TextBox
        Me.Text7 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Image2 = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.出现ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.隐藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StattSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.视图转换ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.影音全屏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.调整坐标ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重新启动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.WindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.PictureBox
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text1
        '
        resources.ApplyResources(Me.Text1, "Text1")
        Me.Text1.Name = "Text1"
        '
        'Text2
        '
        resources.ApplyResources(Me.Text2, "Text2")
        Me.Text2.Name = "Text2"
        '
        'Text3
        '
        resources.ApplyResources(Me.Text3, "Text3")
        Me.Text3.Name = "Text3"
        '
        'Text4
        '
        resources.ApplyResources(Me.Text4, "Text4")
        Me.Text4.Name = "Text4"
        '
        'Text5
        '
        resources.ApplyResources(Me.Text5, "Text5")
        Me.Text5.Name = "Text5"
        '
        'Text6
        '
        resources.ApplyResources(Me.Text6, "Text6")
        Me.Text6.Name = "Text6"
        '
        'Text7
        '
        resources.ApplyResources(Me.Text7, "Text7")
        Me.Text7.Name = "Text7"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Image2
        '
        Me.Image2.BackColor = System.Drawing.SystemColors.Control
        Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Image2, "Image2")
        Me.Image2.Name = "Image2"
        Me.Image2.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Value = 100
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.出现ToolStripMenuItem, Me.隐藏ToolStripMenuItem, Me.StattSettingToolStripMenuItem, Me.视图转换ToolStripMenuItem, Me.影音全屏ToolStripMenuItem, Me.调整坐标ToolStripMenuItem, Me.重新启动ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        '出现ToolStripMenuItem
        '
        resources.ApplyResources(Me.出现ToolStripMenuItem, "出现ToolStripMenuItem")
        Me.出现ToolStripMenuItem.Name = "出现ToolStripMenuItem"
        '
        '隐藏ToolStripMenuItem
        '
        resources.ApplyResources(Me.隐藏ToolStripMenuItem, "隐藏ToolStripMenuItem")
        Me.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem"
        '
        'StattSettingToolStripMenuItem
        '
        resources.ApplyResources(Me.StattSettingToolStripMenuItem, "StattSettingToolStripMenuItem")
        Me.StattSettingToolStripMenuItem.Name = "StattSettingToolStripMenuItem"
        '
        '视图转换ToolStripMenuItem
        '
        resources.ApplyResources(Me.视图转换ToolStripMenuItem, "视图转换ToolStripMenuItem")
        Me.视图转换ToolStripMenuItem.Name = "视图转换ToolStripMenuItem"
        '
        '影音全屏ToolStripMenuItem
        '
        resources.ApplyResources(Me.影音全屏ToolStripMenuItem, "影音全屏ToolStripMenuItem")
        Me.影音全屏ToolStripMenuItem.Name = "影音全屏ToolStripMenuItem"
        '
        '调整坐标ToolStripMenuItem
        '
        resources.ApplyResources(Me.调整坐标ToolStripMenuItem, "调整坐标ToolStripMenuItem")
        Me.调整坐标ToolStripMenuItem.Name = "调整坐标ToolStripMenuItem"
        '
        '重新启动ToolStripMenuItem
        '
        resources.ApplyResources(Me.重新启动ToolStripMenuItem, "重新启动ToolStripMenuItem")
        Me.重新启动ToolStripMenuItem.Name = "重新启动ToolStripMenuItem"
        '
        '退出ToolStripMenuItem
        '
        resources.ApplyResources(Me.退出ToolStripMenuItem, "退出ToolStripMenuItem")
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        resources.ApplyResources(Me.File1, "File1")
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.jpg;*.bmp;*.png;*.gif"
        '
        'Timer4
        '
        Me.Timer4.Interval = 2000
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        resources.ApplyResources(Me.TextBox4, "TextBox4")
        Me.TextBox4.Name = "TextBox4"
        '
        'TextBox5
        '
        resources.ApplyResources(Me.TextBox5, "TextBox5")
        Me.TextBox5.Name = "TextBox5"
        '
        'WindowsMediaPlayer1
        '
        Me.WindowsMediaPlayer1.AllowDrop = True
        resources.ApplyResources(Me.WindowsMediaPlayer1, "WindowsMediaPlayer1")
        Me.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1"
        Me.WindowsMediaPlayer1.OcxState = CType(resources.GetObject("WindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Timer5
        '
        '
        'TextBox6
        '
        resources.ApplyResources(Me.TextBox6, "TextBox6")
        Me.TextBox6.Name = "TextBox6"
        '
        'TextBox7
        '
        resources.ApplyResources(Me.TextBox7, "TextBox7")
        Me.TextBox7.Name = "TextBox7"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.Label3.TabStop = False
        '
        'Timer6
        '
        Me.Timer6.Interval = 1
        '
        'MyStart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.Button1
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.WindowsMediaPlayer1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.File1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Text7)
        Me.Controls.Add(Me.Text6)
        Me.Controls.Add(Me.Text5)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Image2)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "MyStart"
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Text3 As System.Windows.Forms.TextBox
    Friend WithEvents Text4 As System.Windows.Forms.TextBox
    Friend WithEvents Text5 As System.Windows.Forms.TextBox
    Friend WithEvents Text6 As System.Windows.Forms.TextBox
    Friend WithEvents Text7 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Image2 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 出现ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 隐藏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StattSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重新启动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents 调整坐标ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents 影音全屏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents 视图转换ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
End Class
