<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.添加ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.上移ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下降ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.导入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.写出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.标准ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.说明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(326, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "执行修改"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(245, 328)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "广告地址"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "屏蔽地址"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "添加"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(263, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "编辑"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(263, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 27)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "删除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(263, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "上移"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(263, 137)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 27)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "下降"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(263, 162)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 27)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "导入"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(263, 187)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 27)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "写出"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(263, 315)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 25)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "退出"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(263, 292)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 25)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "说明"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(263, 269)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 25)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "标准"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加ToolStripMenuItem, Me.编辑ToolStripMenuItem, Me.ToolStripSeparator1, Me.删除ToolStripMenuItem, Me.清空ToolStripMenuItem, Me.ToolStripSeparator2, Me.上移ToolStripMenuItem, Me.下降ToolStripMenuItem, Me.ToolStripSeparator3, Me.导入ToolStripMenuItem, Me.写出ToolStripMenuItem, Me.ToolStripSeparator4, Me.标准ToolStripMenuItem, Me.说明ToolStripMenuItem, Me.ToolStripSeparator5, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 276)
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(263, 87)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 27)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "清空"
        Me.Button12.UseVisualStyleBackColor = True
        '
        '添加ToolStripMenuItem
        '
        Me.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem"
        Me.添加ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.添加ToolStripMenuItem.Text = "添加"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(95, 6)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        '清空ToolStripMenuItem
        '
        Me.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem"
        Me.清空ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.清空ToolStripMenuItem.Text = "清空"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(95, 6)
        '
        '上移ToolStripMenuItem
        '
        Me.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem"
        Me.上移ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.上移ToolStripMenuItem.Text = "上移"
        '
        '下降ToolStripMenuItem
        '
        Me.下降ToolStripMenuItem.Name = "下降ToolStripMenuItem"
        Me.下降ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.下降ToolStripMenuItem.Text = "下降"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(95, 6)
        '
        '导入ToolStripMenuItem
        '
        Me.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem"
        Me.导入ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.导入ToolStripMenuItem.Text = "导入"
        '
        '写出ToolStripMenuItem
        '
        Me.写出ToolStripMenuItem.Name = "写出ToolStripMenuItem"
        Me.写出ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.写出ToolStripMenuItem.Text = "写出"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(95, 6)
        '
        '标准ToolStripMenuItem
        '
        Me.标准ToolStripMenuItem.Name = "标准ToolStripMenuItem"
        Me.标准ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.标准ToolStripMenuItem.Text = "标准"
        '
        '说明ToolStripMenuItem
        '
        Me.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem"
        Me.说明ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.说明ToolStripMenuItem.Text = "说明"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(95, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 414)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "广告克星"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents 添加ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清空ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 上移ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 下降ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 导入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 写出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 标准ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 说明ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
