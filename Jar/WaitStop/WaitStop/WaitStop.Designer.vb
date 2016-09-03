<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitStop
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaitStop))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JavaExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部运行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.默认库ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.中止解压ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部中止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.唤醒ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.等待ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.JarSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JFRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JarSetting中止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JFR中止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "双击打开Java Explorer,请右键WaitStop控制程序！！！"
        Me.NotifyIcon1.BalloonTipTitle = "WaitStop"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "双击打开Java Explorer,请右键WaitStop控制程序！！！"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JavaExplorerToolStripMenuItem, Me.ToolStripSeparator3, Me.MGameToolStripMenuItem, Me.ToolStripSeparator2, Me.中止解压ToolStripMenuItem, Me.全部中止ToolStripMenuItem, Me.唤醒ToolStripMenuItem, Me.等待ToolStripMenuItem, Me.ToolStripSeparator1, Me.JarSettingToolStripMenuItem, Me.JFRToolStripMenuItem, Me.JarSetting中止ToolStripMenuItem, Me.JFR中止ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 242)
        Me.ContextMenuStrip1.Text = "中止解压"
        '
        'JavaExplorerToolStripMenuItem
        '
        Me.JavaExplorerToolStripMenuItem.Name = "JavaExplorerToolStripMenuItem"
        Me.JavaExplorerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JavaExplorerToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.JavaExplorerToolStripMenuItem.Text = "Java Explorer"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'MGameToolStripMenuItem
        '
        Me.MGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.全部运行ToolStripMenuItem, Me.全部关闭ToolStripMenuItem, Me.ToolStripSeparator5, Me.默认库ToolStripMenuItem, Me.ToolStripSeparator4})
        Me.MGameToolStripMenuItem.Name = "MGameToolStripMenuItem"
        Me.MGameToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MGameToolStripMenuItem.Text = "M-Game"
        '
        '全部运行ToolStripMenuItem
        '
        Me.全部运行ToolStripMenuItem.Name = "全部运行ToolStripMenuItem"
        Me.全部运行ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.全部运行ToolStripMenuItem.Text = "全部运行"
        '
        '全部关闭ToolStripMenuItem
        '
        Me.全部关闭ToolStripMenuItem.Name = "全部关闭ToolStripMenuItem"
        Me.全部关闭ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.全部关闭ToolStripMenuItem.Text = "全部关闭"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        '默认库ToolStripMenuItem
        '
        Me.默认库ToolStripMenuItem.Name = "默认库ToolStripMenuItem"
        Me.默认库ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.默认库ToolStripMenuItem.Text = "默认库"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(119, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        '中止解压ToolStripMenuItem
        '
        Me.中止解压ToolStripMenuItem.Name = "中止解压ToolStripMenuItem"
        Me.中止解压ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.中止解压ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.中止解压ToolStripMenuItem.Text = "中止解压"
        '
        '全部中止ToolStripMenuItem
        '
        Me.全部中止ToolStripMenuItem.Name = "全部中止ToolStripMenuItem"
        Me.全部中止ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.全部中止ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.全部中止ToolStripMenuItem.Text = "全部中止"
        '
        '唤醒ToolStripMenuItem
        '
        Me.唤醒ToolStripMenuItem.Name = "唤醒ToolStripMenuItem"
        Me.唤醒ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.唤醒ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.唤醒ToolStripMenuItem.Text = "唤醒/暂停"
        '
        '等待ToolStripMenuItem
        '
        Me.等待ToolStripMenuItem.Name = "等待ToolStripMenuItem"
        Me.等待ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.等待ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.等待ToolStripMenuItem.Text = "等待"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'JarSettingToolStripMenuItem
        '
        Me.JarSettingToolStripMenuItem.Name = "JarSettingToolStripMenuItem"
        Me.JarSettingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.JarSettingToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.JarSettingToolStripMenuItem.Text = "Jar Setting"
        '
        'JFRToolStripMenuItem
        '
        Me.JFRToolStripMenuItem.Name = "JFRToolStripMenuItem"
        Me.JFRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.JFRToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.JFRToolStripMenuItem.Text = "JFR"
        '
        'JarSetting中止ToolStripMenuItem
        '
        Me.JarSetting中止ToolStripMenuItem.Name = "JarSetting中止ToolStripMenuItem"
        Me.JarSetting中止ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.JarSetting中止ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.JarSetting中止ToolStripMenuItem.Text = "Jar Setting中止"
        '
        'JFR中止ToolStripMenuItem
        '
        Me.JFR中止ToolStripMenuItem.Name = "JFR中止ToolStripMenuItem"
        Me.JFR中止ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.JFR中止ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.JFR中止ToolStripMenuItem.Text = "JFR中止"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "双击打开Java Explorer,请右键WaitStop控制程序！！！")
        Me.PictureBox1.WaitOnLoad = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 37)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(55, 15)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'Button1
        '
        Me.Button1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "0%"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'WaitStop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(55, 52)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WaitStop"
        Me.Opacity = 0.85
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 中止解压ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 等待ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents JarSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JFRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents 全部中止ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JarSetting中止ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JFR中止ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents 唤醒ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents JavaExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 默认库ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全部运行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全部关闭ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
