<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maker))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.添加目录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.文件夹批量ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.输出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.上移ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.下移ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.旋转ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.图片全屏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PNG反色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.输出大小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox
        Me.输出格式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.删除这一条ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除这一条ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.清空列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.输出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.主目录方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PictureBox1 = New CSI_ImageControl.ImageControl
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(176, 244)
        Me.ListBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPENToolStripMenuItem, Me.添加目录ToolStripMenuItem, Me.文件夹批量ToolStripMenuItem, Me.输出ToolStripMenuItem, Me.ToolStripSeparator1, Me.上移ToolStripMenuItem, Me.下移ToolStripMenuItem, Me.ToolStripSeparator4, Me.旋转ToolStripMenuItem, Me.图片全屏ToolStripMenuItem, Me.PNG反色ToolStripMenuItem, Me.ToolStripMenuItem1, Me.输出大小ToolStripMenuItem, Me.输出格式ToolStripMenuItem, Me.ToolStripSeparator2, Me.删除这一条ToolStripMenuItem, Me.清空ToolStripMenuItem, Me.ToolStripSeparator3, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 380)
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.OPENToolStripMenuItem.Text = "添加"
        '
        '添加目录ToolStripMenuItem
        '
        Me.添加目录ToolStripMenuItem.Name = "添加目录ToolStripMenuItem"
        Me.添加目录ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.添加目录ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.添加目录ToolStripMenuItem.Text = "添加目录"
        '
        '文件夹批量ToolStripMenuItem
        '
        Me.文件夹批量ToolStripMenuItem.Name = "文件夹批量ToolStripMenuItem"
        Me.文件夹批量ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.文件夹批量ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.文件夹批量ToolStripMenuItem.Text = "文件夹批量"
        '
        '输出ToolStripMenuItem
        '
        Me.输出ToolStripMenuItem.Name = "输出ToolStripMenuItem"
        Me.输出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.输出ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.输出ToolStripMenuItem.Text = "输出"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        '上移ToolStripMenuItem
        '
        Me.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem"
        Me.上移ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.上移ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.上移ToolStripMenuItem.Text = "上移"
        '
        '下移ToolStripMenuItem
        '
        Me.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem"
        Me.下移ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.下移ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.下移ToolStripMenuItem.Text = "下移"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        '旋转ToolStripMenuItem
        '
        Me.旋转ToolStripMenuItem.Name = "旋转ToolStripMenuItem"
        Me.旋转ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.旋转ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.旋转ToolStripMenuItem.Text = "旋转"
        '
        '图片全屏ToolStripMenuItem
        '
        Me.图片全屏ToolStripMenuItem.Name = "图片全屏ToolStripMenuItem"
        Me.图片全屏ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.图片全屏ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.图片全屏ToolStripMenuItem.Text = "图片全屏"
        '
        'PNG反色ToolStripMenuItem
        '
        Me.PNG反色ToolStripMenuItem.Name = "PNG反色ToolStripMenuItem"
        Me.PNG反色ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.PNG反色ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PNG反色ToolStripMenuItem.Text = "PNG反色"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.ToolStripMenuItem1.Text = "PNG降色到256位"
        '
        '输出大小ToolStripMenuItem
        '
        Me.输出大小ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox2})
        Me.输出大小ToolStripMenuItem.Name = "输出大小ToolStripMenuItem"
        Me.输出大小ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.输出大小ToolStripMenuItem.Text = "输出大小"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.Items.AddRange(New Object() {"240*320", "480*640", "720*960"})
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ToolStripComboBox2.Text = "240*320"
        '
        '输出格式ToolStripMenuItem
        '
        Me.输出格式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.输出格式ToolStripMenuItem.Name = "输出格式ToolStripMenuItem"
        Me.输出格式ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.输出格式ToolStripMenuItem.Text = "输出格式"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"PNG", "BMP", "JPG", "GIF"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 21)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        '删除这一条ToolStripMenuItem
        '
        Me.删除这一条ToolStripMenuItem.Name = "删除这一条ToolStripMenuItem"
        Me.删除这一条ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.删除这一条ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.删除这一条ToolStripMenuItem.Text = "删除这一条"
        '
        '清空ToolStripMenuItem
        '
        Me.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem"
        Me.清空ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.清空ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.清空ToolStripMenuItem.Text = "清空"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = """"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ListBox2
        '
        Me.ListBox2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.HorizontalScrollbar = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(0, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(96, 100)
        Me.ListBox2.TabIndex = 6
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除这一条ToolStripMenuItem1, Me.清空列表ToolStripMenuItem, Me.输出ToolStripMenuItem1, Me.主目录方式ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(170, 92)
        '
        '删除这一条ToolStripMenuItem1
        '
        Me.删除这一条ToolStripMenuItem1.Name = "删除这一条ToolStripMenuItem1"
        Me.删除这一条ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.删除这一条ToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.删除这一条ToolStripMenuItem1.Text = "删除这一条"
        '
        '清空列表ToolStripMenuItem
        '
        Me.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem"
        Me.清空列表ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.清空列表ToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.清空列表ToolStripMenuItem.Text = "清空列表"
        '
        '输出ToolStripMenuItem1
        '
        Me.输出ToolStripMenuItem1.Name = "输出ToolStripMenuItem1"
        Me.输出ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.输出ToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.输出ToolStripMenuItem1.Text = "输出"
        '
        '主目录方式ToolStripMenuItem
        '
        Me.主目录方式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.主目录方式ToolStripMenuItem.Name = "主目录方式ToolStripMenuItem"
        Me.主目录方式ToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.主目录方式ToolStripMenuItem.Text = "主目录方式"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Visible = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(448, 246)
        Me.SplitContainer1.SplitterDistance = 176
        Me.SplitContainer1.TabIndex = 7
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListBox2)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(268, 246)
        Me.SplitContainer2.SplitterDistance = 158
        Me.SplitContainer2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Nothing
        Me.PictureBox1.initialimage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Origin = New System.Drawing.Point(0, 0)
        Me.PictureBox1.PanButton = System.Windows.Forms.MouseButtons.Left
        Me.PictureBox1.PanMode = True
        Me.PictureBox1.ScrollbarsVisible = True
        Me.PictureBox1.Size = New System.Drawing.Size(268, 246)
        Me.PictureBox1.StretchImageToFit = False
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.ZoomFactor = 1
        Me.PictureBox1.ZoomOnMouseWheel = True
        '
        'Maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 246)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile PPT Maker By GhostGzt"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 输出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 旋转ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 图片全屏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OPENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents 清空ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除这一条ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 添加目录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents 上移ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 下移ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents 文件夹批量ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除这一条ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 输出ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 主目录方式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents 输出格式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents PNG反色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As CSI_ImageControl.ImageControl
    Friend WithEvents 输出大小ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
End Class