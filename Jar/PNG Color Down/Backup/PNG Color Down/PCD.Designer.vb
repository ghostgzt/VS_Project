<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PCD))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.添加文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.添加目录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.降色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.删除这一条ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.清空列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.备份ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button6 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImgEdit1 = New AxImgeditLibCtl.AxImgEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New CSI_ImageControl.ImageControl
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 11)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 160)
        Me.ListBox1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加文件ToolStripMenuItem, Me.添加目录ToolStripMenuItem, Me.ToolStripSeparator3, Me.降色ToolStripMenuItem, Me.ToolStripSeparator1, Me.删除这一条ToolStripMenuItem, Me.清空列表ToolStripMenuItem, Me.ToolStripSeparator4, Me.备份ToolStripMenuItem, Me.ToolStripSeparator2, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 182)
        '
        '添加文件ToolStripMenuItem
        '
        Me.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem"
        Me.添加文件ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.添加文件ToolStripMenuItem.Text = "添加文件"
        '
        '添加目录ToolStripMenuItem
        '
        Me.添加目录ToolStripMenuItem.Name = "添加目录ToolStripMenuItem"
        Me.添加目录ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.添加目录ToolStripMenuItem.Text = "添加目录"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(131, 6)
        '
        '降色ToolStripMenuItem
        '
        Me.降色ToolStripMenuItem.Name = "降色ToolStripMenuItem"
        Me.降色ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.降色ToolStripMenuItem.Text = "降色"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        '删除这一条ToolStripMenuItem
        '
        Me.删除这一条ToolStripMenuItem.Name = "删除这一条ToolStripMenuItem"
        Me.删除这一条ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.删除这一条ToolStripMenuItem.Text = "删除这一条"
        '
        '清空列表ToolStripMenuItem
        '
        Me.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem"
        Me.清空列表ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.清空列表ToolStripMenuItem.Text = "清空列表"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(131, 6)
        '
        '备份ToolStripMenuItem
        '
        Me.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem"
        Me.备份ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.备份ToolStripMenuItem.Text = "备份"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "添加文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "添加目录"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "清空"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(259, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "降色"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(340, 206)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "退出"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 235)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(102, 177)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "删除这一条"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "10", "12", "14", "16", "24", "32", "48", "64", "128", "256", "512", "2色灰", "4色灰", "256色灰", "256色A", "256色B", "24位色", "32位色"})
        Me.ComboBox1.Location = New System.Drawing.Point(259, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 20)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PNG颜色:"
        '
        'ImgEdit1
        '
        Me.ImgEdit1.Location = New System.Drawing.Point(183, 203)
        Me.ImgEdit1.Name = "ImgEdit1"
        Me.ImgEdit1.OcxState = CType(resources.GetObject("ImgEdit1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImgEdit1.Size = New System.Drawing.Size(70, 26)
        Me.ImgEdit1.TabIndex = 11
        Me.ImgEdit1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-2, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = """"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Nothing
        Me.PictureBox1.initialimage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(183, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Origin = New System.Drawing.Point(0, 0)
        Me.PictureBox1.PanButton = System.Windows.Forms.MouseButtons.Left
        Me.PictureBox1.PanMode = True
        Me.PictureBox1.ScrollbarsVisible = True
        Me.PictureBox1.Size = New System.Drawing.Size(232, 160)
        Me.PictureBox1.StretchImageToFit = False
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.ZoomFactor = 1
        Me.PictureBox1.ZoomOnMouseWheel = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(183, 210)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "图片反色"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 253)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ImgEdit1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PCD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PNG Color Down"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 添加文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 添加目录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 降色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 删除这一条ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 备份ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImgEdit1 As AxImgeditLibCtl.AxImgEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As CSI_ImageControl.ImageControl
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class