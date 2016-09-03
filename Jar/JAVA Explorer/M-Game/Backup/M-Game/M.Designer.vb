<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.运行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.打开方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.设为默认ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.固定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.属性ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.列表移除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.清空列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.背景ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox
        Me.浏览ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.透明度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.透明色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.列表长度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.列表图片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.浏览ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.图标大小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.主题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox
        Me.浏览ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.列表名称ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.字体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.最简模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.开机启动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.顶端显示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.保存列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(196, 463)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.运行ToolStripMenuItem, Me.打开方式ToolStripMenuItem, Me.设为默认ToolStripMenuItem, Me.固定ToolStripMenuItem, Me.属性ToolStripMenuItem, Me.ToolStripSeparator1, Me.列表移除ToolStripMenuItem, Me.清空列表ToolStripMenuItem, Me.ToolStripSeparator3, Me.背景ToolStripMenuItem, Me.透明度ToolStripMenuItem, Me.列表长度ToolStripMenuItem, Me.列表图片ToolStripMenuItem, Me.图标大小ToolStripMenuItem, Me.主题ToolStripMenuItem, Me.列表名称ToolStripMenuItem, Me.ToolStripSeparator2, Me.最简模式ToolStripMenuItem, Me.开机启动ToolStripMenuItem, Me.顶端显示ToolStripMenuItem, Me.保存列表ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 440)
        '
        '运行ToolStripMenuItem
        '
        Me.运行ToolStripMenuItem.Name = "运行ToolStripMenuItem"
        Me.运行ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.运行ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.运行ToolStripMenuItem.Text = "运行"
        '
        '打开方式ToolStripMenuItem
        '
        Me.打开方式ToolStripMenuItem.Name = "打开方式ToolStripMenuItem"
        Me.打开方式ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.打开方式ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.打开方式ToolStripMenuItem.Text = "打开方式"
        '
        '设为默认ToolStripMenuItem
        '
        Me.设为默认ToolStripMenuItem.Name = "设为默认ToolStripMenuItem"
        Me.设为默认ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.设为默认ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.设为默认ToolStripMenuItem.Text = "设为默认"
        '
        '固定ToolStripMenuItem
        '
        Me.固定ToolStripMenuItem.Name = "固定ToolStripMenuItem"
        Me.固定ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.固定ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.固定ToolStripMenuItem.Text = "固定"
        '
        '属性ToolStripMenuItem
        '
        Me.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem"
        Me.属性ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.属性ToolStripMenuItem.Text = "属性"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        '列表移除ToolStripMenuItem
        '
        Me.列表移除ToolStripMenuItem.Name = "列表移除ToolStripMenuItem"
        Me.列表移除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.列表移除ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.列表移除ToolStripMenuItem.Text = "列表移除"
        '
        '清空列表ToolStripMenuItem
        '
        Me.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem"
        Me.清空列表ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.清空列表ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.清空列表ToolStripMenuItem.Text = "清空列表"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(187, 6)
        '
        '背景ToolStripMenuItem
        '
        Me.背景ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox4, Me.浏览ToolStripMenuItem})
        Me.背景ToolStripMenuItem.Name = "背景ToolStripMenuItem"
        Me.背景ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.背景ToolStripMenuItem.Text = "背景"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 21)
        '
        '浏览ToolStripMenuItem
        '
        Me.浏览ToolStripMenuItem.Name = "浏览ToolStripMenuItem"
        Me.浏览ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.浏览ToolStripMenuItem.Text = "浏览"
        '
        '透明度ToolStripMenuItem
        '
        Me.透明度ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox5, Me.ToolStripSeparator5, Me.透明色ToolStripMenuItem})
        Me.透明度ToolStripMenuItem.Name = "透明度ToolStripMenuItem"
        Me.透明度ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.透明度ToolStripMenuItem.Text = "透明度"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(100, 21)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(157, 6)
        '
        '透明色ToolStripMenuItem
        '
        Me.透明色ToolStripMenuItem.Name = "透明色ToolStripMenuItem"
        Me.透明色ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.透明色ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.透明色ToolStripMenuItem.Text = "透明色"
        '
        '列表长度ToolStripMenuItem
        '
        Me.列表长度ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.列表长度ToolStripMenuItem.Name = "列表长度ToolStripMenuItem"
        Me.列表长度ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.列表长度ToolStripMenuItem.Text = "列表长度"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        '列表图片ToolStripMenuItem
        '
        Me.列表图片ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2, Me.浏览ToolStripMenuItem1})
        Me.列表图片ToolStripMenuItem.Name = "列表图片ToolStripMenuItem"
        Me.列表图片ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.列表图片ToolStripMenuItem.Text = "列表图片"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        '
        '浏览ToolStripMenuItem1
        '
        Me.浏览ToolStripMenuItem1.Name = "浏览ToolStripMenuItem1"
        Me.浏览ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.浏览ToolStripMenuItem1.Text = "浏览"
        '
        '图标大小ToolStripMenuItem
        '
        Me.图标大小ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.图标大小ToolStripMenuItem.Name = "图标大小ToolStripMenuItem"
        Me.图标大小ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.图标大小ToolStripMenuItem.Text = "图标大小"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"24*24", "48*48", "64*64", "128*128", "256*256"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 21)
        '
        '主题ToolStripMenuItem
        '
        Me.主题ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox6, Me.浏览ToolStripMenuItem3})
        Me.主题ToolStripMenuItem.Name = "主题ToolStripMenuItem"
        Me.主题ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.主题ToolStripMenuItem.Text = "主题"
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(100, 21)
        '
        '浏览ToolStripMenuItem3
        '
        Me.浏览ToolStripMenuItem3.Name = "浏览ToolStripMenuItem3"
        Me.浏览ToolStripMenuItem3.Size = New System.Drawing.Size(160, 22)
        Me.浏览ToolStripMenuItem3.Text = "浏览"
        '
        '列表名称ToolStripMenuItem
        '
        Me.列表名称ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox3, Me.ToolStripSeparator4, Me.字体ToolStripMenuItem})
        Me.列表名称ToolStripMenuItem.Name = "列表名称ToolStripMenuItem"
        Me.列表名称ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.列表名称ToolStripMenuItem.Text = "列表名称"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 21)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(157, 6)
        '
        '字体ToolStripMenuItem
        '
        Me.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem"
        Me.字体ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.字体ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.字体ToolStripMenuItem.Text = "字体"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        '最简模式ToolStripMenuItem
        '
        Me.最简模式ToolStripMenuItem.Name = "最简模式ToolStripMenuItem"
        Me.最简模式ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.最简模式ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.最简模式ToolStripMenuItem.Text = "最简模式"
        '
        '开机启动ToolStripMenuItem
        '
        Me.开机启动ToolStripMenuItem.Name = "开机启动ToolStripMenuItem"
        Me.开机启动ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.开机启动ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.开机启动ToolStripMenuItem.Text = "开机启动"
        '
        '顶端显示ToolStripMenuItem
        '
        Me.顶端显示ToolStripMenuItem.Name = "顶端显示ToolStripMenuItem"
        Me.顶端显示ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.顶端显示ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.顶端显示ToolStripMenuItem.Text = "顶端显示"
        '
        '保存列表ToolStripMenuItem
        '
        Me.保存列表ToolStripMenuItem.Name = "保存列表ToolStripMenuItem"
        Me.保存列表ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存列表ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.保存列表ToolStripMenuItem.Text = "保存列表"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(256, 256)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = """"
        Me.TextBox1.Visible = False
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "301.png")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(89, 208)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(0, 0)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "<?xml version=""1.0"" encoding=""utf-8""?>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<Aero>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <Tile>/Name</Tile>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <MZZ>" & _
            "/MMM</MZZ>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <FileNum>/Num</FileNum>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <Files>"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(97, 216)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(0, 0)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "    <File>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        <Name>/DZ</Name>  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        <Pic>/Png</Pic>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        <Path>/P" & _
            "PP</Path>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        <Size>/SSS</Size>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    </File>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 63)
        Me.Panel1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(176, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 63)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "M-Games"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 63)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(0, 0)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(10, 21)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        Me.TextBox4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 526)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(0, 438)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 88)
        Me.ListBox1.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(196, 561)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "M"
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.Purple
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 运行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开方式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 列表移除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 列表长度ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents 列表名称ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 列表图片ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents 背景ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents 透明度ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents 最简模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设为默认ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents 图标大小ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents 保存列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 属性ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 主题ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox6 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents 开机启动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 顶端显示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents 浏览ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 浏览ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 浏览ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 固定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 字体ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 透明色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class