<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JS))
        Me.MName = New System.Windows.Forms.TextBox
        Me.MIcon = New System.Windows.Forms.TextBox
        Me.Description = New System.Windows.Forms.TextBox
        Me.M1 = New System.Windows.Forms.TextBox
        Me.URL = New System.Windows.Forms.TextBox
        Me.Notify = New System.Windows.Forms.TextBox
        Me.Version = New System.Windows.Forms.TextBox
        Me.Vendor = New System.Windows.Forms.TextBox
        Me.Za = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Permissions = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.PerOpt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Data = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MName
        '
        Me.MName.Location = New System.Drawing.Point(77, 20)
        Me.MName.Name = "MName"
        Me.MName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.MName.Size = New System.Drawing.Size(300, 21)
        Me.MName.TabIndex = 0
        '
        'MIcon
        '
        Me.MIcon.BackColor = System.Drawing.SystemColors.Window
        Me.MIcon.Location = New System.Drawing.Point(77, 47)
        Me.MIcon.Name = "MIcon"
        Me.MIcon.ReadOnly = True
        Me.MIcon.Size = New System.Drawing.Size(300, 21)
        Me.MIcon.TabIndex = 1
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(77, 74)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(300, 21)
        Me.Description.TabIndex = 2
        '
        'M1
        '
        Me.M1.BackColor = System.Drawing.Color.White
        Me.M1.Location = New System.Drawing.Point(77, 101)
        Me.M1.Name = "M1"
        Me.M1.ReadOnly = True
        Me.M1.Size = New System.Drawing.Size(246, 21)
        Me.M1.TabIndex = 4
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(77, 156)
        Me.URL.Name = "URL"
        Me.URL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.URL.Size = New System.Drawing.Size(300, 21)
        Me.URL.TabIndex = 5
        '
        'Notify
        '
        Me.Notify.Location = New System.Drawing.Point(77, 183)
        Me.Notify.Name = "Notify"
        Me.Notify.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Notify.Size = New System.Drawing.Size(300, 21)
        Me.Notify.TabIndex = 6
        '
        'Version
        '
        Me.Version.Location = New System.Drawing.Point(77, 210)
        Me.Version.Name = "Version"
        Me.Version.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Version.Size = New System.Drawing.Size(300, 21)
        Me.Version.TabIndex = 7
        '
        'Vendor
        '
        Me.Vendor.Location = New System.Drawing.Point(77, 237)
        Me.Vendor.Name = "Vendor"
        Me.Vendor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Vendor.Size = New System.Drawing.Size(300, 21)
        Me.Vendor.TabIndex = 8
        '
        'Za
        '
        Me.Za.Location = New System.Drawing.Point(77, 371)
        Me.Za.Multiline = True
        Me.Za.Name = "Za"
        Me.Za.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Za.Size = New System.Drawing.Size(300, 55)
        Me.Za.TabIndex = 9
        Me.Za.WordWrap = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1.0"})
        Me.ComboBox1.Location = New System.Drawing.Point(323, 318)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(54, 20)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CLDC-1.0", "CLDC-1.1"})
        Me.ComboBox2.Location = New System.Drawing.Point(108, 345)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(79, 20)
        Me.ComboBox2.TabIndex = 11
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"MIDP-1.0", "MIDP-2.0"})
        Me.ComboBox3.Location = New System.Drawing.Point(253, 345)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(70, 20)
        Me.ComboBox3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&修改"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "&重读"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(302, 433)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "&返回"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "名称:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "图标:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "描述:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "主启动项:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "URL路径:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Notify:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "版本:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "出版商:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 12)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Manifest-Version:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 12)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Configuration:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(194, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Profile:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 387)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 12)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "杂项:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(329, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 21)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "修改"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(329, 342)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 23)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "&关于"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(377, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 159)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "URL路径:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(221, 433)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "&测试"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(127, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(196, 21)
        Me.TextBox1.TabIndex = 33
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(329, 128)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 21)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "修改"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "其他启动项"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(77, 128)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(44, 20)
        Me.ComboBox4.TabIndex = 36
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(127, 188)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(28, 4)
        Me.ListBox1.TabIndex = 37
        '
        'Permissions
        '
        Me.Permissions.Location = New System.Drawing.Point(77, 264)
        Me.Permissions.Name = "Permissions"
        Me.Permissions.Size = New System.Drawing.Size(300, 21)
        Me.Permissions.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 12)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "许可:"
        '
        'PerOpt
        '
        Me.PerOpt.Location = New System.Drawing.Point(77, 291)
        Me.PerOpt.Name = "PerOpt"
        Me.PerOpt.Size = New System.Drawing.Size(300, 21)
        Me.PerOpt.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 291)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 12)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "许可-Opt:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 321)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Data-Size:"
        '
        'Data
        '
        Me.Data.Location = New System.Drawing.Point(108, 318)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(79, 21)
        Me.Data.TabIndex = 44
        '
        'JS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(399, 473)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PerOpt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Permissions)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Za)
        Me.Controls.Add(Me.Vendor)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Notify)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.MIcon)
        Me.Controls.Add(Me.MName)
        Me.Controls.Add(Me.ListBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "JS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jar高级修改"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents MName As System.Windows.Forms.TextBox
    Friend WithEvents MIcon As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents M1 As System.Windows.Forms.TextBox
    Friend WithEvents URL As System.Windows.Forms.TextBox
    Friend WithEvents Notify As System.Windows.Forms.TextBox
    Friend WithEvents Version As System.Windows.Forms.TextBox
    Friend WithEvents Vendor As System.Windows.Forms.TextBox
    Friend WithEvents Za As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Permissions As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PerOpt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Data As System.Windows.Forms.TextBox
End Class