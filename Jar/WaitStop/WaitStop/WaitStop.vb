Public Class WaitStop
    Dim mouseOffset
    Dim ko
    Private Sub WaitStop_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        dohiid()
    End Sub
    Private Sub WaitStop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.NotifyIcon1.Icon = Nothing
    End Sub
    Private Sub WaitStop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "End", "0")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", "0")
        Me.Height = 48
        Me.Width = 48
        Me.TransparencyKey = Me.BackColor
        NotifyIcon1.ShowBalloonTip(100)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "WH", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "WW", Nothing)
        Me.Top = r1
        Me.Left = r2
    End Sub
    Private Sub 中止解压ToolStripMenuItem_Click() Handles 中止解压ToolStripMenuItem.Click
        On Error Resume Next
        endd("$JEE163.tmp")
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
        Timer2.Enabled = False
    End Sub
    Function endd(ByVal d As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Winrar", Nothing)
        If r1 <> "" Then
            d = "Winrar.exe"
        End If
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(d)
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "End", Nothing)
        If r1 = "1" Then
            Me.NotifyIcon1.Icon = Nothing
            End
        End If
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "Run", Nothing)
        If r2 = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run", "0")
            Timer2.Enabled = True
        End If
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", Nothing)
        If r3 = "1" Then
            Timer2.Enabled = False
        End If
        Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "TM", Nothing)
        If r4 <> "" Then
            Timer2.Interval = Int(r4)
        End If
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", Nothing)
        If r5 = "1" Then
            ProgressBar1.Visible = True
            Button1.Visible = True
            PictureBox1.Visible = False
        Else
            ProgressBar1.Value = 0
            Button1.Text = "0%"
            ProgressBar1.Visible = False
            Button1.Visible = False
            PictureBox1.Visible = True
            中止解压ToolStripMenuItem.Visible = False
            全部中止ToolStripMenuItem.Visible = False
            唤醒ToolStripMenuItem.Visible = False
            等待ToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
        End If
        If ProgressBar1.Visible = True Then
            中止解压ToolStripMenuItem.Visible = True
            全部中止ToolStripMenuItem.Visible = True
            唤醒ToolStripMenuItem.Visible = True
            等待ToolStripMenuItem.Visible = True
            ToolStripSeparator2.Visible = True
            Dim r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "NG", Nothing)
            Dim r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", Nothing)
            Dim no = r6
            If no <> ko Then
                ko = no
                If CInt(r6) / CInt(r7) <= 100 Then
                    If (CInt(r6) / CInt(r7) * 100) > 1 Then
                        Button1.Text = Str(CInt(r6) / CInt(r7) * 100).Remove(5).Trim + "%"
                    Else
                        Button1.Text = "0" + Str(CInt(r6) / CInt(r7) * 100).Remove(4).Trim + "%"
                    End If
                    ProgressBar1.Value = CInt(r6) / CInt(r7) * 100
                    NotifyIcon1.Text = Str(CInt(r6) / CInt(r7) * 100).Remove(5).Trim + "%"
                Else
                    Button1.Text = "99.9%"
                    ProgressBar1.Value = 100
                    NotifyIcon1.BalloonTipText = "99.9%"
                End If
            End If
        Else
            NotifyIcon1.Text = "双击打开Java Explorer,请右键WaitStop控制程序！！！"
        End If
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)) = str1f Then
                    If n = 0 Then
                        q = u
                        i = i + 1
                    Else
                        If i = n - 1 Then
                            q = u
                            i = i + 1
                            GoTo p
                        End If
                    End If
                End If
            Next
        End If
p:      If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + Len(str1f))
            Else
                Return str.Remove(q)
            End If
        Else
            If qh = True Then
                Return str
            Else
                Return ""
            End If
        End If
    End Function
    Function AddKu(ByVal ki As ToolStripMenuItem)
        On Error Resume Next
        For x = 5 To ki.DropDownItems.Count - 1
            ki.DropDownItems.RemoveAt(ki.DropDownItems.Count - 1)
        Next
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ku") = True Then
            Dim jal = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath + "\Ku", FileIO.SearchOption.SearchTopLevelOnly, "*.Xml")
            If jal.Count <> 0 Then
                For x = 0 To jal.Count - 1
                    Dim kk As String = getname(jal(x).Replace(My.Application.Info.DirectoryPath + "\Ku\", ""), ".", True, 0)
                    If kk <> "Default" Then
                        addtools(MGameToolStripMenuItem, kk)
                    End If
                Next
            End If
        End If
    End Function
    Function addtools(ByVal mt As ToolStripMenuItem, ByVal tj As String)
        On Error Resume Next
        Dim addedMenuStripItem As New ToolStripMenuItem
        addedMenuStripItem.Text = tj
        mt.DropDownItems.Insert(5, addedMenuStripItem)
    End Function
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        dohiid()
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        On Error Resume Next
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Picturebox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub WaitStop_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "WH", Me.Top)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "WW", Me.Left)
    End Sub
    Private Sub JarSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JarSettingToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub JFRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JFRToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\JFR.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Jar Setting.exe") = False Then
            JarSettingToolStripMenuItem.Enabled = False
        Else
            JarSettingToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\JFR.exe") = False Then
            JFRToolStripMenuItem.Enabled = False
        Else
            JFRToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\M-Game.exe") = False Then
            默认库ToolStripMenuItem.Enabled = False
        Else
            默认库ToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Java Explorer.exe") = False Then
            JavaExplorerToolStripMenuItem.Enabled = False
        Else
            JavaExplorerToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Timer2.Enabled = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "ZD", Nothing) <> "1" Then
            Dim rr = MsgBox("Java Explorer解压超时,是否中止这个文件的解压?" + vbCrLf + "Yes表示中止单个,No表示全部中止,Cancle表示等待", MsgBoxStyle.YesNoCancel, "提示！")
            If rr = MsgBoxResult.Yes Then
                中止解压ToolStripMenuItem_Click()
            End If
            If rr = MsgBoxResult.No Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "1")
                中止解压ToolStripMenuItem_Click()
            End If
        Else
            中止解压ToolStripMenuItem_Click()
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
    End Sub
    Private Sub 全部中止ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全部中止ToolStripMenuItem.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "1")
        中止解压ToolStripMenuItem_Click()
    End Sub
    Private Sub JarSetting中止ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JarSetting中止ToolStripMenuItem.Click
        endd("$Z12Z.tmp")
    End Sub
    Private Sub JFR中止ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JFR中止ToolStripMenuItem.Click
        endd("$BBF163.tmp")
    End Sub
    Private Sub 唤醒ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 唤醒ToolStripMenuItem.Click
        endd("$JEE163.tmp")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "HX", "1")
    End Sub
    Private Sub Button1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.DoubleClick
        dohiid()
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        On Error Resume Next
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub JavaExplorerToolStripMenuItem_Click() Handles JavaExplorerToolStripMenuItem.Click
        On Error Resume Next
        dohiid()
    End Sub
    Function hiid(ByVal t As Boolean)
        On Error Resume Next
        If t = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", "0")
            Shell(My.Application.Info.DirectoryPath + "\Java Explorer.exe", AppWinStyle.NormalFocus)
        End If
    End Function
    Function rhiid()
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", Nothing)
        If r0 = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Function dohiid()
        On Error Resume Next
        If rhiid() = True Then
            hiid(False)
        Else
            hiid(True)
        End If
    End Function
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        dohiid()
    End Sub
    Private Sub MGameToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MGameToolStripMenuItem.DropDownItemClicked
        readm()
        For x = 5 To MGameToolStripMenuItem.DropDownItems.Count - 1
            If MGameToolStripMenuItem.DropDownItems.Item(x).Selected = True Then
                If MGameToolStripMenuItem.DropDownItems.Item(x).Image Is Nothing Then

                    If MGameToolStripMenuItem.DropDownItems.Item(x).Text = "" Then
                        Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe")
                    Else
                        Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe" + " " + MGameToolStripMenuItem.DropDownItems.Item(x).Text)
                    End If
                    MGameToolStripMenuItem.DropDownItems.Item(x).Image = My.Resources.hello

                Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + MGameToolStripMenuItem.DropDownItems.Item(x).Text, "End", "1")
                    MGameToolStripMenuItem.DropDownItems.Item(x).Image = Nothing
                End If
            End If
        Next
    End Sub
    Private Sub MGameToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles MGameToolStripMenuItem.DropDownOpening
        AddKu(MGameToolStripMenuItem)
        readm()
    End Sub
    Function readm()
        On Error Resume Next
        Dim yx As Integer
        Dim gb As Integer
        yx = 0
        gb = 0
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + "Default", "Run", Nothing) = "1" Then
            yx = 1
            MGameToolStripMenuItem.DropDownItems.Item(3).Image = My.Resources.hello
        Else
            gb = 1
            MGameToolStripMenuItem.DropDownItems.Item(3).Image = Nothing
        End If
        For x = 5 To MGameToolStripMenuItem.DropDownItems.Count - 1
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + MGameToolStripMenuItem.DropDownItems.Item(x).Text, "Run", Nothing) = "1" Then
                MGameToolStripMenuItem.DropDownItems.Item(x).Image = My.Resources.hello
                yx = 1
            Else
                MGameToolStripMenuItem.DropDownItems.Item(x).Image = Nothing
                gb = 1
            End If
        Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\M-Game.exe") = True Then
            全部运行ToolStripMenuItem.Enabled = True
            全部关闭ToolStripMenuItem.Enabled = True
        Else
            全部运行ToolStripMenuItem.Enabled = False
            全部关闭ToolStripMenuItem.Enabled = False
        End If
        If gb = 1 Then
            全部运行ToolStripMenuItem.Visible = True
        Else
            全部运行ToolStripMenuItem.Visible = False
        End If
        If yx = 1 Then
            全部关闭ToolStripMenuItem.Visible = True
        Else
            全部关闭ToolStripMenuItem.Visible = False
        End If
    End Function
    Private Sub 默认库ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认库ToolStripMenuItem.Click
        readm()
        If 默认库ToolStripMenuItem.Image Is Nothing Then
            Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe")
            默认库ToolStripMenuItem.Image = My.Resources.hello
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + "Default", "End", "1")
            默认库ToolStripMenuItem.Image = Nothing
        End If
    End Sub
    Private Sub 全部运行ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全部运行ToolStripMenuItem.Click
        On Error Resume Next
        If 默认库ToolStripMenuItem.Image Is Nothing Then
            Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe")
            默认库ToolStripMenuItem.Image = My.Resources.hello
        End If
        For x = 5 To MGameToolStripMenuItem.DropDownItems.Count - 1
            If MGameToolStripMenuItem.DropDownItems.Item(x).Image Is Nothing Then
                If MGameToolStripMenuItem.DropDownItems.Item(x).Text = "" Then
                    Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe")
                Else
                    Shell(My.Application.Info.DirectoryPath + "\" + "M-Game.exe" + " " + MGameToolStripMenuItem.DropDownItems.Item(x).Text)
                End If
                MGameToolStripMenuItem.DropDownItems.Item(x).Image = My.Resources.hello
            End If
        Next
    End Sub
    Private Sub 全部关闭ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全部关闭ToolStripMenuItem.Click
        If 默认库ToolStripMenuItem.Image Is Nothing Then
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + "Default", "End", "1")
            默认库ToolStripMenuItem.Image = Nothing
        End If
        For x = 5 To MGameToolStripMenuItem.DropDownItems.Count - 1
            If MGameToolStripMenuItem.DropDownItems.Item(x).Image Is Nothing Then
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + MGameToolStripMenuItem.DropDownItems.Item(x).Text, "End", "1")
                MGameToolStripMenuItem.DropDownItems.Item(x).Image = Nothing
            End If
        Next
    End Sub
End Class