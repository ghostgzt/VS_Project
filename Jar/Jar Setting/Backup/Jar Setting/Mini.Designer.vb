﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mini))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Mini
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(0, 0)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mini"
        Me.Opacity = 0.85
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MiniWin"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class