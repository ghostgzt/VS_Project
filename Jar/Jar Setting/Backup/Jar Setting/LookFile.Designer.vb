<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LookFile))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.替换ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.另保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重命名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.文件夹位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Hex编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(244, 292)
        Me.ListBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开ToolStripMenuItem, Me.ToolStripSeparator4, Me.Hex编辑ToolStripMenuItem, Me.ToolStripSeparator3, Me.替换ToolStripMenuItem, Me.另保存ToolStripMenuItem, Me.全部保存ToolStripMenuItem, Me.重命名ToolStripMenuItem, Me.全选ToolStripMenuItem, Me.删除ToolStripMenuItem, Me.ToolStripSeparator2, Me.刷新ToolStripMenuItem, Me.ToolStripSeparator1, Me.文件夹位置ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 270)
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.打开ToolStripMenuItem.Text = "打开"
        '
        '替换ToolStripMenuItem
        '
        Me.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem"
        Me.替换ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.替换ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.替换ToolStripMenuItem.Text = "替换"
        '
        '另保存ToolStripMenuItem
        '
        Me.另保存ToolStripMenuItem.Name = "另保存ToolStripMenuItem"
        Me.另保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.另保存ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.另保存ToolStripMenuItem.Text = "另保存"
        '
        '全部保存ToolStripMenuItem
        '
        Me.全部保存ToolStripMenuItem.Name = "全部保存ToolStripMenuItem"
        Me.全部保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.全部保存ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.全部保存ToolStripMenuItem.Text = "全部保存"
        '
        '重命名ToolStripMenuItem
        '
        Me.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem"
        Me.重命名ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.重命名ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.重命名ToolStripMenuItem.Text = "重命名"
        '
        '全选ToolStripMenuItem
        '
        Me.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem"
        Me.全选ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.全选ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.全选ToolStripMenuItem.Text = "全选"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        '文件夹位置ToolStripMenuItem
        '
        Me.文件夹位置ToolStripMenuItem.Name = "文件夹位置ToolStripMenuItem"
        Me.文件夹位置ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.文件夹位置ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.文件夹位置ToolStripMenuItem.Text = "文件夹位置"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&替换"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(485, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 20)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&返回"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(349, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 20)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "&保存"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(349, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 20)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "&另存为"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(417, 338)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 20)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "&编辑"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(70, 335)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(62, 20)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "&反编译"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "ASCII", "Unicode", "UTF8"})
        Me.ComboBox1.Location = New System.Drawing.Point(275, 339)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 20)
        Me.ComboBox1.TabIndex = 11
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(281, 295)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(62, 20)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "添加"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(349, 338)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(62, 20)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "&删除"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(3, 297)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Txt.ico")
        Me.ImageList1.Images.SetKeyName(1, "Mid.ico")
        Me.ImageList1.Images.SetKeyName(2, "Png.ico")
        Me.ImageList1.Images.SetKeyName(3, "Internet.ico")
        Me.ImageList1.Images.SetKeyName(4, "UN.ico")
        Me.ImageList1.Images.SetKeyName(5, "Class.ico")
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(250, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(304, 292)
        Me.WebBrowser1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(250, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(304, 290)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        Me.TextBox1.WordWrap = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Button9
        '
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button9.ImageIndex = 0
        Me.Button9.Location = New System.Drawing.Point(485, 297)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(62, 32)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "保存为JAVA"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "本文格式"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(214, 295)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(61, 20)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "&大小修改"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"*.*", "*.", "*.class", "*.txt", "*.png", "*.mid", "*.htm", "*.html"})
        Me.ComboBox2.Location = New System.Drawing.Point(146, 307)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox2.TabIndex = 18
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(146, 335)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(62, 20)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "&显示"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(0, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(0, 4)
        Me.ListBox2.TabIndex = 20
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(214, 315)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(61, 20)
        Me.Button12.TabIndex = 21
        Me.Button12.Text = "降色256"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(417, 296)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(62, 19)
        Me.Button13.TabIndex = 22
        Me.Button13.Text = "繁转简"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(417, 315)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(62, 20)
        Me.Button14.TabIndex = 23
        Me.Button14.Text = "简转繁"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(281, 315)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(62, 20)
        Me.Button15.TabIndex = 24
        Me.Button15.Text = "全选"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Hex编辑ToolStripMenuItem
        '
        Me.Hex编辑ToolStripMenuItem.Name = "Hex编辑ToolStripMenuItem"
        Me.Hex编辑ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.Hex编辑ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.Hex编辑ToolStripMenuItem.Text = "Hex编辑"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(173, 6)
        '
        'LookFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(554, 365)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LookFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LookFile"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 打开ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重命名ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 替换ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全部保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents 全选ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 文件夹位置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 刷新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hex编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class