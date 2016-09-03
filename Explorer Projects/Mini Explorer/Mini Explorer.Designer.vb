<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini_Explorer
    Inherits System.Windows.Forms.Form
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
 Private components As System.ComponentModel.IContainer
<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mini_Explorer))
        Me.treeMain = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.刷新ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.新建文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.复制文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.移动文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重命名文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.删除文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重命名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.删除全部ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.新建ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.预览栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.隐藏预览栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.文件类型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.显示预览栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.隐藏预览栏ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.还原ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.隐藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.刷新ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeMain
        '
        Me.treeMain.ContextMenuStrip = Me.ContextMenuStrip2
        Me.treeMain.Location = New System.Drawing.Point(10, 53)
        Me.treeMain.Name = "treeMain"
        Me.treeMain.Size = New System.Drawing.Size(140, 220)
        Me.treeMain.TabIndex = 0
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刷新ToolStripMenuItem1, Me.新建文件夹ToolStripMenuItem, Me.复制文件夹ToolStripMenuItem, Me.移动文件夹ToolStripMenuItem, Me.重命名文件夹ToolStripMenuItem, Me.删除文件夹ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(149, 136)
        '
        '刷新ToolStripMenuItem1
        '
        Me.刷新ToolStripMenuItem1.Image = CType(resources.GetObject("刷新ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1"
        Me.刷新ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.刷新ToolStripMenuItem1.Text = "刷新"
        '
        '新建文件夹ToolStripMenuItem
        '
        Me.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem"
        Me.新建文件夹ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.新建文件夹ToolStripMenuItem.Text = "新建文件夹"
        '
        '复制文件夹ToolStripMenuItem
        '
        Me.复制文件夹ToolStripMenuItem.Name = "复制文件夹ToolStripMenuItem"
        Me.复制文件夹ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.复制文件夹ToolStripMenuItem.Text = "复制文件夹"
        '
        '移动文件夹ToolStripMenuItem
        '
        Me.移动文件夹ToolStripMenuItem.Name = "移动文件夹ToolStripMenuItem"
        Me.移动文件夹ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.移动文件夹ToolStripMenuItem.Text = "移动文件夹"
        '
        '重命名文件夹ToolStripMenuItem
        '
        Me.重命名文件夹ToolStripMenuItem.Name = "重命名文件夹ToolStripMenuItem"
        Me.重命名文件夹ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.重命名文件夹ToolStripMenuItem.Text = "重命名文件夹"
        '
        '删除文件夹ToolStripMenuItem
        '
        Me.删除文件夹ToolStripMenuItem.Name = "删除文件夹ToolStripMenuItem"
        Me.删除文件夹ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.删除文件夹ToolStripMenuItem.Text = "删除文件夹"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(10, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 21)
        Me.TextBox1.TabIndex = 2
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        Me.File1.Hidden = True
        Me.File1.Location = New System.Drawing.Point(156, 53)
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.*"
        Me.File1.Size = New System.Drawing.Size(124, 220)
        Me.File1.System = True
        Me.File1.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刷新ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.剪切ToolStripMenuItem, Me.重命名ToolStripMenuItem, Me.删除ToolStripMenuItem, Me.删除全部ToolStripMenuItem, Me.新建ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 158)
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Image = CType(resources.GetObject("刷新ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Image = CType(resources.GetObject("复制ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.复制ToolStripMenuItem.Text = "复制"
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Image = CType(resources.GetObject("剪切ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.剪切ToolStripMenuItem.Text = "剪切"
        '
        '重命名ToolStripMenuItem
        '
        Me.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem"
        Me.重命名ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.重命名ToolStripMenuItem.Text = "重命名"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Image = CType(resources.GetObject("删除ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        '删除全部ToolStripMenuItem
        '
        Me.删除全部ToolStripMenuItem.Name = "删除全部ToolStripMenuItem"
        Me.删除全部ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.删除全部ToolStripMenuItem.Text = "删除全部"
        '
        '新建ToolStripMenuItem
        '
        Me.新建ToolStripMenuItem.Image = CType(resources.GetObject("新建ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem"
        Me.新建ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.新建ToolStripMenuItem.Text = "新建文件"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 21)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowMerge = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 284)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(288, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(92, 20)
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预览栏ToolStripMenuItem, Me.隐藏预览栏ToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        '预览栏ToolStripMenuItem
        '
        Me.预览栏ToolStripMenuItem.Name = "预览栏ToolStripMenuItem"
        Me.预览栏ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.预览栏ToolStripMenuItem.Text = "显示预览栏"
        '
        '隐藏预览栏ToolStripMenuItem
        '
        Me.隐藏预览栏ToolStripMenuItem.Name = "隐藏预览栏ToolStripMenuItem"
        Me.隐藏预览栏ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.隐藏预览栏ToolStripMenuItem.Text = "隐藏预览栏"
        Me.隐藏预览栏ToolStripMenuItem.Visible = False
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(96, 16)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel2.Text = "24:00:00"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(295, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(160, 207)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(152, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(295, 257)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(160, 16)
        Me.HScrollBar1.TabIndex = 16
        Me.HScrollBar1.Visible = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 100
        Me.VScrollBar1.Location = New System.Drawing.Point(454, 53)
        Me.VScrollBar1.Maximum = 100000000
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 207)
        Me.VScrollBar1.TabIndex = 17
        Me.VScrollBar1.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(295, 28)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(160, 21)
        Me.TrackBar1.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选项ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(288, 25)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.AutoSize = False
        Me.选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件类型ToolStripMenuItem, Me.显示预览栏ToolStripMenuItem, Me.隐藏预览栏ToolStripMenuItem1, Me.退出ToolStripMenuItem})
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.选项ToolStripMenuItem.Text = "选项"
        '
        '文件类型ToolStripMenuItem
        '
        Me.文件类型ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.文件类型ToolStripMenuItem.Image = CType(resources.GetObject("文件类型ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.文件类型ToolStripMenuItem.Name = "文件类型ToolStripMenuItem"
        Me.文件类型ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.文件类型ToolStripMenuItem.Text = "文件类型"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "*.*"
        '
        '显示预览栏ToolStripMenuItem
        '
        Me.显示预览栏ToolStripMenuItem.Image = CType(resources.GetObject("显示预览栏ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.显示预览栏ToolStripMenuItem.Name = "显示预览栏ToolStripMenuItem"
        Me.显示预览栏ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.显示预览栏ToolStripMenuItem.Text = "显示预览栏"
        '
        '隐藏预览栏ToolStripMenuItem1
        '
        Me.隐藏预览栏ToolStripMenuItem1.Image = CType(resources.GetObject("隐藏预览栏ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.隐藏预览栏ToolStripMenuItem1.Name = "隐藏预览栏ToolStripMenuItem1"
        Me.隐藏预览栏ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.隐藏预览栏ToolStripMenuItem1.Text = "隐藏预览栏"
        Me.隐藏预览栏ToolStripMenuItem1.Visible = False
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Image = CType(resources.GetObject("退出ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(53, 21)
        Me.关于ToolStripMenuItem.Text = "关于..."
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(154, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(10, 21)
        Me.TextBox5.TabIndex = 26
        Me.TextBox5.Text = """"
        Me.TextBox5.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(246, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 21)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Copy"
        Me.ToolTip1.SetToolTip(Me.Button1, "Copy Path" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "将本文框的本文" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "复制到剪辑板！")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip3
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Mini Explorer"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.还原ToolStripMenuItem, Me.隐藏ToolStripMenuItem, Me.刷新ToolStripMenuItem2, Me.退出ToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(101, 92)
        '
        '还原ToolStripMenuItem
        '
        Me.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem"
        Me.还原ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.还原ToolStripMenuItem.Text = "还原"
        '
        '隐藏ToolStripMenuItem
        '
        Me.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem"
        Me.隐藏ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.隐藏ToolStripMenuItem.Text = "隐藏"
        '
        '刷新ToolStripMenuItem2
        '
        Me.刷新ToolStripMenuItem2.Name = "刷新ToolStripMenuItem2"
        Me.刷新ToolStripMenuItem2.Size = New System.Drawing.Size(100, 22)
        Me.刷新ToolStripMenuItem2.Text = "刷新"
        '
        '退出ToolStripMenuItem1
        '
        Me.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1"
        Me.退出ToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.退出ToolStripMenuItem1.Text = "退出"
        '
        'Mini_Explorer
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 306)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.File1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.treeMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Mini_Explorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "简易浏览器"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents treeMain As System.Windows.Forms.TreeView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents 预览栏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents 隐藏预览栏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 选项ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 文件类型ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents 显示预览栏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 隐藏预览栏ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 刷新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 剪切ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents 新建ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 刷新ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除全部ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新建文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 移动文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重命名文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 还原ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 隐藏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 刷新ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重命名ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripSplitButton
End Class
