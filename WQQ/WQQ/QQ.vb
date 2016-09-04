Public Class QQ
    Private Sub QQ_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TopMost = False
        Dim r = MsgBox("你是否要最小化WebQQ?" + vbCrLf + "Y - 最小化" + vbCrLf + "N - 退出", MsgBoxStyle.YesNoCancel, "Gentle提示！")
        If 总是在前ToolStripMenuItem.Checked = True Then
            Me.TopMost = True
        End If
        If r = MsgBoxResult.Yes Then
            显示隐藏ToolStripMenuItem_Click(Nothing, Nothing)
            e.Cancel = True
            'Me.Visible = False
        Else
            If r = MsgBoxResult.Cancel Then
                e.Cancel = True
            Else
                NotifyIcon1.Icon = Nothing
                runat(True, 1)
            End If
        End If
    End Sub
    Private Sub QQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tx = txz
        Me.TopMost = False
        runat(False, 1)
    End Sub
    Dim ll
    Dim lt
    Dim lh
    Dim lw
    Dim lwin As FormWindowState
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            If 总是在前ToolStripMenuItem.Checked = True Then
                Me.TopMost = True
            Else
                Me.TopMost = False
            End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.Left = ll
            Me.Top = lt
            Me.Height = lh
            Me.Width = lw
            Me.WindowState = lwin
            显示切换ToolStripMenuItem.Checked = False
        Else
            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            End If
            ll = Me.Left
            lt = Me.Top
            lh = Me.Height
            lw = Me.Width
            lwin = Me.WindowState
            Me.Left = 0
            Me.Top = 0
            'Me.TopMost = True
            If 总是在前ToolStripMenuItem.Checked = True Then
                Me.TopMost = True
            Else
                Me.TopMost = False
            End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Width = My.Computer.Screen.WorkingArea.Width
            Me.Height = My.Computer.Screen.WorkingArea.Height
            显示切换ToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        显示隐藏ToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub 退出QQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出QQToolStripMenuItem.Click
        If MsgBox("你是否要退出WebQQ?", MsgBoxStyle.YesNo, "温馨提示！") = MsgBoxResult.Yes Then
            NotifyIcon1.Icon = Nothing
            runat(True, 1)
            End
        End If
    End Sub
    Private Sub 原始窗口大小ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 原始窗口大小ToolStripMenuItem.Click
        'Me.TopMost = False
        If 总是在前ToolStripMenuItem.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Normal
        Me.Width = 800
        Me.Height = 600
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2
        显示切换ToolStripMenuItem.Checked = False
        runat(True, 1)
    End Sub
    Private Sub 显示切换ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示切换ToolStripMenuItem.Click
        Button1_Click(Nothing, Nothing)
    End Sub
    Private Sub 显示隐藏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示隐藏ToolStripMenuItem.Click
        If Me.Visible = False Then
            Me.Visible = True
        Else
            Me.Visible = False
            With NotifyIcon1
                .BalloonTipText = "WebQQ被最小化到这里啊！@。@！"
                .BalloonTipIcon = ToolTipIcon.Info
                .BalloonTipTitle = "Gentle提示！！！"
                .ShowBalloonTip(500)
            End With
        End If
    End Sub
    Private Sub 新窗口ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新窗口ToolStripMenuItem.Click
        Shell(My.Application.Info.DirectoryPath + "\WQQ.exe", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        Me.TopMost = False
        About.ShowDialog()
        If 显示切换ToolStripMenuItem.Checked = True Then
            Me.TopMost = True
        End If
    End Sub
    Dim txz As String = "Gentle: 广州中医药大学大学城校区2011届本科在读，吾之微博是http://weibo.com/u/1843533784，网站是http://ghostgzt.7ta.cn/，欢迎光临关注！！！提示：按ESC键可进行界面切换！@。@！"
    Dim tx As String = ""
    Dim nums As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo s
d:
        tx = txz.Substring(nums, 40)
        nums = nums + 1
        Me.Text = "WebQQ - Made By Gentle In 2012 - QQ:1275731466 " + "[" + tx + "]"
        Exit Sub
s:      nums = 0
        GoTo d
    End Sub

    Private Sub 总是在前ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 总是在前ToolStripMenuItem.Click
        If 总是在前ToolStripMenuItem.Checked = True Then
            Me.TopMost = False
            总是在前ToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            总是在前ToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        WebBrowser1.Refresh(System.Windows.Forms.WebBrowserRefreshOption.Continue)
    End Sub

    Private Sub 开机启动ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开机启动ToolStripMenuItem.Click
        If 开机启动ToolStripMenuItem.Checked = True Then
            runat(False, 0)
            开机启动ToolStripMenuItem.Checked = False
        Else
            runat(True, 0)
            开机启动ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function runat(tf As Boolean, i As Integer)
        On Error Resume Next
        Select Case i
            Case 0
                If tf = True Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WQQ", My.Application.Info.DirectoryPath + "\wqq.exe")
                Else
                    Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                    ke.DeleteValue("WQQ")
                End If
            Case 1
                If tf = True Then
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\WQQ")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WQQ", "TopMost", IIf(总是在前ToolStripMenuItem.Checked, "1", "0"))
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WQQ", "Max", IIf(Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None, "1", "0"))
                Else
                    Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WQQ", "TopMost", Nothing)
                    Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WQQ", "Max", Nothing)
                    Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WQQ", Nothing)
                    If r0 = "1" Then
                        总是在前ToolStripMenuItem_Click(Nothing, Nothing)
                    End If
                    If r1 = "1" Then
                        Button1_Click(Nothing, Nothing)
                    End If
                    If r2 <> Nothing Then
                        开机启动ToolStripMenuItem.Checked = True
                    End If
                End If
        End Select
    End Function
End Class