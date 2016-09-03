<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagePaste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImagePaste))
        Me.Button1 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除这一条ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.保存这一条ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.清空剪辑板ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.获取频率ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.高ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.中ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.低ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.自义定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.微调设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.顶端ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MiniIcon1 = New PasteExt.MiniIcon
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(0, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除这一条ToolStripMenuItem, Me.保存这一条ToolStripMenuItem, Me.全部保存ToolStripMenuItem, Me.清空剪辑板ToolStripMenuItem, Me.获取频率ToolStripMenuItem, Me.微调设置ToolStripMenuItem, Me.顶端ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 202)
        '
        '删除这一条ToolStripMenuItem
        '
        Me.删除这一条ToolStripMenuItem.Name = "删除这一条ToolStripMenuItem"
        Me.删除这一条ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.删除这一条ToolStripMenuItem.Text = "删除这一条"
        '
        '保存这一条ToolStripMenuItem
        '
        Me.保存这一条ToolStripMenuItem.Name = "保存这一条ToolStripMenuItem"
        Me.保存这一条ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.保存这一条ToolStripMenuItem.Text = "保存这一条"
        '
        '全部保存ToolStripMenuItem
        '
        Me.全部保存ToolStripMenuItem.Name = "全部保存ToolStripMenuItem"
        Me.全部保存ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.全部保存ToolStripMenuItem.Text = "全部保存"
        '
        '清空剪辑板ToolStripMenuItem
        '
        Me.清空剪辑板ToolStripMenuItem.Name = "清空剪辑板ToolStripMenuItem"
        Me.清空剪辑板ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.清空剪辑板ToolStripMenuItem.Text = "清空剪辑板"
        '
        '获取频率ToolStripMenuItem
        '
        Me.获取频率ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.高ToolStripMenuItem, Me.中ToolStripMenuItem, Me.低ToolStripMenuItem, Me.自义定ToolStripMenuItem})
        Me.获取频率ToolStripMenuItem.Name = "获取频率ToolStripMenuItem"
        Me.获取频率ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.获取频率ToolStripMenuItem.Text = "获取频率"
        '
        '高ToolStripMenuItem
        '
        Me.高ToolStripMenuItem.Name = "高ToolStripMenuItem"
        Me.高ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.高ToolStripMenuItem.Text = "高"
        '
        '中ToolStripMenuItem
        '
        Me.中ToolStripMenuItem.Checked = True
        Me.中ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.中ToolStripMenuItem.Name = "中ToolStripMenuItem"
        Me.中ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.中ToolStripMenuItem.Text = "中"
        '
        '低ToolStripMenuItem
        '
        Me.低ToolStripMenuItem.Name = "低ToolStripMenuItem"
        Me.低ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.低ToolStripMenuItem.Text = "低"
        '
        '自义定ToolStripMenuItem
        '
        Me.自义定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.自义定ToolStripMenuItem.Name = "自义定ToolStripMenuItem"
        Me.自义定ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.自义定ToolStripMenuItem.Text = "自义定"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        '微调设置ToolStripMenuItem
        '
        Me.微调设置ToolStripMenuItem.Name = "微调设置ToolStripMenuItem"
        Me.微调设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.微调设置ToolStripMenuItem.Text = "微调设置"
        '
        '顶端ToolStripMenuItem
        '
        Me.顶端ToolStripMenuItem.Checked = True
        Me.顶端ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.顶端ToolStripMenuItem.Name = "顶端ToolStripMenuItem"
        Me.顶端ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.顶端ToolStripMenuItem.Text = "顶端"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(248, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 162)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(248, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 328)
        Me.ListBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(248, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ImagePaste"
        Me.NotifyIcon1.Visible = True
        '
        'ListBox2
        '
        Me.ListBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(0, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(246, 328)
        Me.ListBox2.TabIndex = 10
        '
        'BackgroundWorker1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'MiniIcon1
        '
        Me.MiniIcon1.AutoSize = True
        Me.MiniIcon1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MiniIcon1.Location = New System.Drawing.Point(8, 8)
        Me.MiniIcon1.Name = "MiniIcon1"
        Me.MiniIcon1.Size = New System.Drawing.Size(81, 17)
        Me.MiniIcon1.TabIndex = 11
        Me.MiniIcon1.Visible = False
        '
        'ImagePaste
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 360)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MiniIcon1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ImagePaste"
        Me.Opacity = 0.85
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImagePaste"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除这一条ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存这一条ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全部保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空剪辑板ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 顶端ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MiniIcon1 As PasteExt.MiniIcon
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents 微调设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 获取频率ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 高ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 中ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 低ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自义定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
End Class
