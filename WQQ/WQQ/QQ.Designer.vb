<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QQ
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QQ))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示隐藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.显示切换ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.总是在前ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.原始窗口大小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出QQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.开机启动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(784, 562)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://web.qq.com", System.UriKind.Absolute)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示隐藏ToolStripMenuItem, Me.ToolStripSeparator1, Me.显示切换ToolStripMenuItem, Me.总是在前ToolStripMenuItem, Me.原始窗口大小ToolStripMenuItem, Me.ToolStripSeparator2, Me.刷新ToolStripMenuItem, Me.新窗口ToolStripMenuItem, Me.ToolStripSeparator3, Me.开机启动ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.ToolStripSeparator4, Me.退出QQToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 248)
        '
        '显示隐藏ToolStripMenuItem
        '
        Me.显示隐藏ToolStripMenuItem.Name = "显示隐藏ToolStripMenuItem"
        Me.显示隐藏ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.显示隐藏ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.显示隐藏ToolStripMenuItem.Text = "显示/隐藏"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        '显示切换ToolStripMenuItem
        '
        Me.显示切换ToolStripMenuItem.Name = "显示切换ToolStripMenuItem"
        Me.显示切换ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.显示切换ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.显示切换ToolStripMenuItem.Text = "全屏切换"
        '
        '总是在前ToolStripMenuItem
        '
        Me.总是在前ToolStripMenuItem.Name = "总是在前ToolStripMenuItem"
        Me.总是在前ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.总是在前ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.总是在前ToolStripMenuItem.Text = "总是在前"
        '
        '原始窗口大小ToolStripMenuItem
        '
        Me.原始窗口大小ToolStripMenuItem.Name = "原始窗口大小ToolStripMenuItem"
        Me.原始窗口大小ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.原始窗口大小ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.原始窗口大小ToolStripMenuItem.Text = "原始窗口大小"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        '新窗口ToolStripMenuItem
        '
        Me.新窗口ToolStripMenuItem.Name = "新窗口ToolStripMenuItem"
        Me.新窗口ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.新窗口ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.新窗口ToolStripMenuItem.Text = "新窗口"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(186, 6)
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(186, 6)
        '
        '退出QQToolStripMenuItem
        '
        Me.退出QQToolStripMenuItem.Name = "退出QQToolStripMenuItem"
        Me.退出QQToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.退出QQToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.退出QQToolStripMenuItem.Text = "退出QQ"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WebQQ - Made By Gentle In 2012"
        Me.NotifyIcon1.Visible = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Chage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        '开机启动ToolStripMenuItem
        '
        Me.开机启动ToolStripMenuItem.Name = "开机启动ToolStripMenuItem"
        Me.开机启动ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.开机启动ToolStripMenuItem.Text = "开机启动"
        '
        'QQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebQQ - Made By Gentle In 2012 - QQ:1275731466"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 显示隐藏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示切换ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 原始窗口大小ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出QQToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents 总是在前ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 刷新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 开机启动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class