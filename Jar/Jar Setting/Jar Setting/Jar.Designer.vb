<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jar))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.还原备份ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.自义定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.更换ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.M3 = New System.Windows.Forms.TextBox
        Me.M2 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.M0 = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.新建ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.主窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.查看ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.高级ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.测试ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.另存为ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListBox9 = New System.Windows.Forms.ListBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(128, 21)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 21)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(204, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.还原备份ToolStripMenuItem, Me.ToolStripSeparator2, Me.编辑ToolStripMenuItem, Me.自义定ToolStripMenuItem, Me.ToolStripSeparator1, Me.更换ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(173, 104)
        '
        '还原备份ToolStripMenuItem
        '
        Me.还原备份ToolStripMenuItem.Name = "还原备份ToolStripMenuItem"
        Me.还原备份ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.还原备份ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.还原备份ToolStripMenuItem.Text = "还原备份"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        '自义定ToolStripMenuItem
        '
        Me.自义定ToolStripMenuItem.Name = "自义定ToolStripMenuItem"
        Me.自义定ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.自义定ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.自义定ToolStripMenuItem.Text = "自义定大小"
        '
        '更换ToolStripMenuItem
        '
        Me.更换ToolStripMenuItem.Name = "更换ToolStripMenuItem"
        Me.更换ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.更换ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.更换ToolStripMenuItem.Text = "更换"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(71, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 20)
        Me.ComboBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&另存为"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(139, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "&查看"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "&更换"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(74, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "&打开"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(73, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 24)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "&设置"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(683, 39)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(20, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = """"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(591, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(86, 100)
        Me.ListBox1.TabIndex = 14
        '
        'M3
        '
        Me.M3.Enabled = False
        Me.M3.Location = New System.Drawing.Point(683, 65)
        Me.M3.Multiline = True
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(20, 20)
        Me.M3.TabIndex = 16
        '
        'M2
        '
        Me.M2.Enabled = False
        Me.M2.Location = New System.Drawing.Point(709, 39)
        Me.M2.Multiline = True
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(20, 20)
        Me.M2.TabIndex = 17
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(204, 35)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 23)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "&修改"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 12
        Me.ListBox3.Location = New System.Drawing.Point(407, 15)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(86, 100)
        Me.ListBox3.TabIndex = 19
        '
        'M0
        '
        Me.M0.Enabled = False
        Me.M0.Location = New System.Drawing.Point(683, 15)
        Me.M0.Multiline = True
        Me.M0.Name = "M0"
        Me.M0.Size = New System.Drawing.Size(20, 20)
        Me.M0.TabIndex = 29
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(204, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(65, 23)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "&高级"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(13, 91)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(51, 23)
        Me.Button10.TabIndex = 35
        Me.Button10.Text = "FL"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(499, 15)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(86, 100)
        Me.ListBox2.TabIndex = 15
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(709, 91)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(20, 20)
        Me.TextBox9.TabIndex = 31
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(709, 16)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(20, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(683, 90)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(20, 20)
        Me.TextBox5.TabIndex = 36
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "FQ2009 -> FQ2010" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fuck Q！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "作者：關鎭濤"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建ToolStripMenuItem, Me.打开ToolStripMenuItem, Me.主窗口ToolStripMenuItem, Me.查看ToolStripMenuItem, Me.高级ToolStripMenuItem, Me.FLToolStripMenuItem, Me.测试ToolStripMenuItem, Me.设置ToolStripMenuItem, Me.保存ToolStripMenuItem, Me.另存为ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 268)
        '
        '新建ToolStripMenuItem
        '
        Me.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem"
        Me.新建ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.新建ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.新建ToolStripMenuItem.Text = "新建"
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.打开ToolStripMenuItem.Text = "打开"
        '
        '主窗口ToolStripMenuItem
        '
        Me.主窗口ToolStripMenuItem.Name = "主窗口ToolStripMenuItem"
        Me.主窗口ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.主窗口ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.主窗口ToolStripMenuItem.Text = "主窗口"
        '
        '查看ToolStripMenuItem
        '
        Me.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem"
        Me.查看ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.查看ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.查看ToolStripMenuItem.Text = "查看"
        '
        '高级ToolStripMenuItem
        '
        Me.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem"
        Me.高级ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.高级ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.高级ToolStripMenuItem.Text = "高级"
        '
        'FLToolStripMenuItem
        '
        Me.FLToolStripMenuItem.Name = "FLToolStripMenuItem"
        Me.FLToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.FLToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FLToolStripMenuItem.Text = "FL"
        '
        '测试ToolStripMenuItem
        '
        Me.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem"
        Me.测试ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.测试ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.测试ToolStripMenuItem.Text = "测试Jar"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '保存ToolStripMenuItem
        '
        Me.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        Me.保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.保存ToolStripMenuItem.Text = "保存"
        '
        '另存为ToolStripMenuItem
        '
        Me.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem"
        Me.另存为ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.另存为ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.另存为ToolStripMenuItem.Text = "另存为"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'ListBox9
        '
        Me.ListBox9.Enabled = False
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 12
        Me.ListBox9.Location = New System.Drawing.Point(315, 14)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(86, 100)
        Me.ListBox9.TabIndex = 25
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(709, 65)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(20, 20)
        Me.TextBox7.TabIndex = 27
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'Jar
        '
        Me.AcceptButton = Me.Button5
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(284, 120)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.M0)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.M2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.M3)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Jar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jar Setting"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents M3 As System.Windows.Forms.TextBox
    Friend WithEvents M2 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents M0 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 打开ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查看ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 高级ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 测试ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents 主窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents 保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新建ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 还原备份ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 更换ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自义定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class