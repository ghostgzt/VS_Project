<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetBox))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.ZTHHText = New System.Windows.Forms.TextBox
        Me.ZQText = New System.Windows.Forms.TextBox
        Me.ZHText = New System.Windows.Forms.TextBox
        Me.ZTHYText = New System.Windows.Forms.TextBox
        Me.XLTHText = New System.Windows.Forms.TextBox
        Me.XLYText = New System.Windows.Forms.TextBox
        Me.KTHHText = New System.Windows.Forms.TextBox
        Me.KZText = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XLZText = New System.Windows.Forms.TextBox
        Me.PXKQ = New System.Windows.Forms.CheckBox
        Me.PXCom = New System.Windows.Forms.ComboBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(271, 197)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(8, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "增加字符"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(8, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "序列添0模式"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(8, 81)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "字符串替换"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(8, 112)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "扩展名更改"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(40, 134)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox5.TabIndex = 5
        Me.CheckBox5.Text = "替换"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(237, 134)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "追加"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'ZTHHText
        '
        Me.ZTHHText.Location = New System.Drawing.Point(314, 81)
        Me.ZTHHText.Name = "ZTHHText"
        Me.ZTHHText.Size = New System.Drawing.Size(100, 21)
        Me.ZTHHText.TabIndex = 7
        '
        'ZQText
        '
        Me.ZQText.Location = New System.Drawing.Point(161, 7)
        Me.ZQText.Name = "ZQText"
        Me.ZQText.Size = New System.Drawing.Size(100, 21)
        Me.ZQText.TabIndex = 8
        '
        'ZHText
        '
        Me.ZHText.Location = New System.Drawing.Point(314, 7)
        Me.ZHText.Name = "ZHText"
        Me.ZHText.Size = New System.Drawing.Size(100, 21)
        Me.ZHText.TabIndex = 9
        '
        'ZTHYText
        '
        Me.ZTHYText.Location = New System.Drawing.Point(161, 79)
        Me.ZTHYText.Name = "ZTHYText"
        Me.ZTHYText.Size = New System.Drawing.Size(100, 21)
        Me.ZTHYText.TabIndex = 10
        '
        'XLTHText
        '
        Me.XLTHText.Location = New System.Drawing.Point(282, 43)
        Me.XLTHText.Name = "XLTHText"
        Me.XLTHText.Size = New System.Drawing.Size(42, 21)
        Me.XLTHText.TabIndex = 11
        '
        'XLYText
        '
        Me.XLYText.Location = New System.Drawing.Point(161, 43)
        Me.XLYText.Name = "XLYText"
        Me.XLYText.Size = New System.Drawing.Size(68, 21)
        Me.XLYText.TabIndex = 12
        '
        'KTHHText
        '
        Me.KTHHText.Enabled = False
        Me.KTHHText.Location = New System.Drawing.Point(95, 132)
        Me.KTHHText.Name = "KTHHText"
        Me.KTHHText.Size = New System.Drawing.Size(123, 21)
        Me.KTHHText.TabIndex = 13
        '
        'KZText
        '
        Me.KZText.Location = New System.Drawing.Point(292, 132)
        Me.KZText.Name = "KZText"
        Me.KZText.Size = New System.Drawing.Size(122, 21)
        Me.KZText.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "前加"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "后加"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "序号前" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "德字符" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "串"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "标准名" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "称字数"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "原字符串"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "替换为"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "自义定" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "字符"
        '
        'XLZText
        '
        Me.XLZText.Location = New System.Drawing.Point(376, 43)
        Me.XLZText.Name = "XLZText"
        Me.XLZText.Size = New System.Drawing.Size(38, 21)
        Me.XLZText.TabIndex = 22
        '
        'PXKQ
        '
        Me.PXKQ.AutoSize = True
        Me.PXKQ.Location = New System.Drawing.Point(8, 203)
        Me.PXKQ.Name = "PXKQ"
        Me.PXKQ.Size = New System.Drawing.Size(84, 16)
        Me.PXKQ.TabIndex = 23
        Me.PXKQ.Text = "排序列方式"
        Me.PXKQ.UseVisualStyleBackColor = True
        '
        'PXCom
        '
        Me.PXCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PXCom.Enabled = False
        Me.PXCom.FormattingEnabled = True
        Me.PXCom.Items.AddRange(New Object() {"前加", "后加", "只有"})
        Me.PXCom.Location = New System.Drawing.Point(97, 201)
        Me.PXCom.Name = "PXCom"
        Me.PXCom.Size = New System.Drawing.Size(121, 20)
        Me.PXCom.TabIndex = 24
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(8, 156)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox7.TabIndex = 25
        Me.CheckBox7.Text = "繁简转换"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(40, 178)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.Text = "繁体"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(161, 178)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 27
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "简体"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'SetBox
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(429, 227)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.PXCom)
        Me.Controls.Add(Me.PXKQ)
        Me.Controls.Add(Me.XLZText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KZText)
        Me.Controls.Add(Me.KTHHText)
        Me.Controls.Add(Me.XLYText)
        Me.Controls.Add(Me.XLTHText)
        Me.Controls.Add(Me.ZTHYText)
        Me.Controls.Add(Me.ZHText)
        Me.Controls.Add(Me.ZQText)
        Me.Controls.Add(Me.ZTHHText)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetBox"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GNEasy SetBox"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents ZTHHText As System.Windows.Forms.TextBox
    Friend WithEvents ZQText As System.Windows.Forms.TextBox
    Friend WithEvents ZHText As System.Windows.Forms.TextBox
    Friend WithEvents ZTHYText As System.Windows.Forms.TextBox
    Friend WithEvents XLTHText As System.Windows.Forms.TextBox
    Friend WithEvents XLYText As System.Windows.Forms.TextBox
    Friend WithEvents KTHHText As System.Windows.Forms.TextBox
    Friend WithEvents KZText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XLZText As System.Windows.Forms.TextBox
    Friend WithEvents PXKQ As System.Windows.Forms.CheckBox
    Friend WithEvents PXCom As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class