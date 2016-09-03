<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MB))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ByteDataGridViewImageColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.新增数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.更新名称ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.更新数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.删除记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveQuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SkyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyDataSet = New My_Byte.SkyDataSet
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.button5 = New System.Windows.Forms.Button
        Me.SkyTableAdapter = New My_Byte.SkyDataSetTableAdapters.SkyTableAdapter
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button10 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SkyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.ByteDataGridViewImageColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.SkyBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(382, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "Num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "Num"
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        Me.NumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NumDataGridViewTextBoxColumn.Width = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 54
        '
        'ByteDataGridViewImageColumn
        '
        Me.ByteDataGridViewImageColumn.DataPropertyName = "Byte"
        Me.ByteDataGridViewImageColumn.HeaderText = "Byte"
        Me.ByteDataGridViewImageColumn.Name = "ByteDataGridViewImageColumn"
        Me.ByteDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ByteDataGridViewImageColumn.Width = 35
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刷新ToolStripMenuItem, Me.SaveToolStripMenuItem, Me.新增数据ToolStripMenuItem, Me.更新名称ToolStripMenuItem, Me.更新数据ToolStripMenuItem, Me.删除记录ToolStripMenuItem, Me.SaveQuitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 158)
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SaveToolStripMenuItem.Text = "保存数据"
        '
        '新增数据ToolStripMenuItem
        '
        Me.新增数据ToolStripMenuItem.Name = "新增数据ToolStripMenuItem"
        Me.新增数据ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.新增数据ToolStripMenuItem.Text = "新增数据"
        '
        '更新名称ToolStripMenuItem
        '
        Me.更新名称ToolStripMenuItem.Name = "更新名称ToolStripMenuItem"
        Me.更新名称ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.更新名称ToolStripMenuItem.Text = "更新名称"
        '
        '更新数据ToolStripMenuItem
        '
        Me.更新数据ToolStripMenuItem.Name = "更新数据ToolStripMenuItem"
        Me.更新数据ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.更新数据ToolStripMenuItem.Text = "更新数据"
        '
        '删除记录ToolStripMenuItem
        '
        Me.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem"
        Me.删除记录ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.删除记录ToolStripMenuItem.Text = "删除记录"
        '
        'SaveQuitToolStripMenuItem
        '
        Me.SaveQuitToolStripMenuItem.Name = "SaveQuitToolStripMenuItem"
        Me.SaveQuitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SaveQuitToolStripMenuItem.Text = "Save& Quit"
        '
        'SkyBindingSource
        '
        Me.SkyBindingSource.DataMember = "Sky"
        Me.SkyBindingSource.DataSource = Me.SkyDataSet
        '
        'SkyDataSet
        '
        Me.SkyDataSet.DataSetName = "SkyDataSet"
        Me.SkyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "新增数据"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "保存数据"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 21)
        Me.TextBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(59, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "删除记录"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Location = New System.Drawing.Point(222, 277)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Save& Quit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(303, 221)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 20)
        Me.ComboBox1.TabIndex = 6
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(222, 248)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(75, 23)
        Me.button5.TabIndex = 7
        Me.button5.Text = "刷新"
        Me.button5.UseVisualStyleBackColor = True
        '
        'SkyTableAdapter
        '
        Me.SkyTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(141, 277)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "更新名称"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(303, 248)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "更换数据库"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = """"
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(142, 24)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Visible = False
        '
        'button8
        '
        Me.button8.Location = New System.Drawing.Point(303, 277)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(75, 23)
        Me.button8.TabIndex = 13
        Me.button8.Text = "原本数据库"
        Me.button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(222, 221)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "更新数据"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "My Byte"
        Me.NotifyIcon1.Visible = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 248)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 52)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "压缩修复"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'MB
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.Button4
        Me.ClientSize = New System.Drawing.Size(382, 306)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MB"
        Me.Opacity = 0.85
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Byte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SkyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SkyDataSet As My_Byte.SkyDataSet
    Friend WithEvents SkyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkyTableAdapter As My_Byte.SkyDataSetTableAdapters.SkyTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PicNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicDataGridViewImageColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 刷新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新增数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveQuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ByteDataGridViewImageColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents 更新名称ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 更新数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button10 As System.Windows.Forms.Button

End Class
