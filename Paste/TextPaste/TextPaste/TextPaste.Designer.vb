<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextPaste
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextPaste))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除这一条ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.全部保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.清空剪辑板ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.显示标签ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MiniIcon1 = New PasteExt.MiniIcon
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(42, 60)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(28, 4)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(0, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.White
        Me.ListBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(0, -3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(172, 220)
        Me.ListBox2.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除这一条ToolStripMenuItem, Me.全部保存ToolStripMenuItem, Me.清空剪辑板ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 92)
        '
        '删除这一条ToolStripMenuItem
        '
        Me.删除这一条ToolStripMenuItem.Name = "删除这一条ToolStripMenuItem"
        Me.删除这一条ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.删除这一条ToolStripMenuItem.Text = "删除这一条"
        '
        '全部保存ToolStripMenuItem
        '
        Me.全部保存ToolStripMenuItem.Name = "全部保存ToolStripMenuItem"
        Me.全部保存ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.全部保存ToolStripMenuItem.Text = "全部保存"
        '
        '清空剪辑板ToolStripMenuItem
        '
        Me.清空剪辑板ToolStripMenuItem.Name = "清空剪辑板ToolStripMenuItem"
        Me.清空剪辑板ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.清空剪辑板ToolStripMenuItem.Text = "清空剪辑板"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.ContextMenuStrip = Me.ContextMenuStrip2
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox3.Location = New System.Drawing.Point(169, -3)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(180, 220)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.WordWrap = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.复制ToolStripMenuItem, Me.显示标签ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(119, 48)
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.复制ToolStripMenuItem.Text = "复制"
        '
        '显示标签ToolStripMenuItem
        '
        Me.显示标签ToolStripMenuItem.Name = "显示标签ToolStripMenuItem"
        Me.显示标签ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.显示标签ToolStripMenuItem.Text = "显示标签"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "剪辑板"
        Me.NotifyIcon1.Visible = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(169, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckFileExists = True
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
        Me.MiniIcon1.Location = New System.Drawing.Point(0, 0)
        Me.MiniIcon1.Name = "MiniIcon1"
        Me.MiniIcon1.Size = New System.Drawing.Size(129, 99)
        Me.MiniIcon1.TabIndex = 7
        Me.MiniIcon1.Visible = False
        '
        'TextPaste
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 242)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MiniIcon1)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "TextPaste"
        Me.Opacity = 0.85
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除这一条ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空剪辑板ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents 全部保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 复制ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示标签ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private components As System.ComponentModel.IContainer
    Friend WithEvents MiniIcon1 As PasteExt.MiniIcon
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
