Imports System.Runtime.InteropServices
Public Class JE
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            Dim tf = ""
            DragQueryFile(m.WParam.ToInt32, 0, sb, 256)
            sFirstFileName = sb.ToString
            tf = (sb.ToString)
            If gnn.getname(tf, ".", False, 0).ToString.ToUpper = "JAL" Then
                Dim yy = MsgBox("确定打开" + tf + "？", MsgBoxStyle.YesNo, "温馨提示！！！")
                If yy = MsgBoxResult.Yes Then
                    PictureBox1.Image = My.Resources.UC小松鼠
                    Label1.Text = ""
                    ToolStripStatusLabel3.Text = ""
                    Dim ddc As String = JJE.odd(tf, TextBox1.Text)
                    di(ddc)
                    findpath()
                    MsgBox("Unzip Successed！！！", MsgBoxStyle.Information, "温馨提示！")
                End If
            End If
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Dim JJE As New JEExt.JEE
    Dim JJM As New JALM.JLL
    Dim gnn As New GN
    Dim kjj As New Lnk_Maker.LM
    Dim runer As String
    Dim fir As Integer
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
        findpath()
        ToolStripButton1.Select()
        AddJar()
    End Sub
    Function regyh(ByVal str As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", str)
    End Function
    Function regrun(ByVal str As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run", str)
    End Function
    Function AddJar()
        查找ToolStripMenuItem.Enabled = False
        ToolStrip1.Enabled = False
        ListView2.Items.Clear()
        ListView2.Visible = False
        后退ToolStripMenuItem.Enabled = False
        前进ToolStripMenuItem.Enabled = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XX", "0")
        ToolStripButton2.Enabled = False
        ToolStripButton1.Enabled = False
        ToolStripButton5.Enabled = False
        TreeView2.Enabled = False
        TreeView1.Enabled = False
        ListView1.Enabled = False
        文件ToolStripMenuItem.Enabled = False
        ToolStripButton4.Enabled = True
        设置ToolStripMenuItem.Enabled = False
        ToolStripProgressBar2.Value = 0
        On Error Resume Next
        PictureBox1.Image = My.Resources.UC小松鼠
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        ListView1.Items.Clear()
        ListView1.LargeImageList = ImageList1
        ListView1.SmallImageList = ImageList2
        Dim pathin As String
        载入库ToolStripMenuItem.Enabled = False
        pathin = JJM.run(TextBox1.Text, TextBox2.Text, TextBox3.Text, ToolStripComboBox1.Text, 独项读法ToolStripMenuItem.Checked)
        PictureBox1.Image = My.Resources.UC小松鼠
        Timer1.Enabled = True
        If ToolStripComboBox1.Text.Trim <> "" And ToolStripComboBox1.Text.Trim.ToLower <> path0.ToLower Then
            If back <> 1 Then
                addc1(path0.Trim)
            Else
                addc2(path0.Trim)
            End If
            path0 = ToolStripComboBox1.Text.Trim
        End If
        back = 0
    End Function
    Function endd(ByVal d As String)
        On Error Resume Next
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(d)
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
            myProcess.Kill()
        Next
    End Function
    Private Sub 独项读法ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 独项读法ToolStripMenuItem.Click
        Dim yyy As String
        If 独项读法ToolStripMenuItem.Checked = True Then
            独项读法ToolStripMenuItem.Checked = False
            启动读法ToolStripMenuItem.Checked = True
            yyy = "1"
        Else
            独项读法ToolStripMenuItem.Checked = True
            启动读法ToolStripMenuItem.Checked = False
            yyy = "0"
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Plan", yyy)
    End Sub
    Private Sub 启动读法ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 启动读法ToolStripMenuItem.Click
        Dim yyy As String
        If 启动读法ToolStripMenuItem.Checked = True Then
            启动读法ToolStripMenuItem.Checked = False
            独项读法ToolStripMenuItem.Checked = True
            yyy = "0"
        Else
            启动读法ToolStripMenuItem.Checked = True
            独项读法ToolStripMenuItem.Checked = False
            yyy = "1"
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Plan", yyy)
    End Sub
    Private Sub 图标ToolStripMenuItem_Click() Handles 图标ToolStripMenuItem.Click
        ListView1.View = View.LargeIcon
        shitu()
    End Sub
    Private Sub 列表ToolStripMenuItem_Click() Handles 列表ToolStripMenuItem.Click
        ListView1.View = View.Details
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        shitu()
    End Sub
    Function getDiv()
        On Error Resume Next
        Dim y = My.Computer.FileSystem.Drives.ToList
        For k = 0 To y.Count - 1
            TreeView1.Nodes.Add(y(k).RootDirectory.ToString)
        Next
    End Function
    Private Sub JE_FormClosing() Handles Me.FormClosing
        On Error Resume Next
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Last", Nothing) = "1" Then
            Kill(My.Application.Info.DirectoryPath + "\Last.Jal")
            bi(My.Application.Info.DirectoryPath + "\Last.Jal")
        Else
            Kill(My.Application.Info.DirectoryPath + "\Last.Jal")
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "End", "1")
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar")
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jad")
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$")
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\QSF-Temp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\QSF-Temp")
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JEE168.tmp")
    End Sub
    Dim path0 As String
    Private Sub JE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Runned", Nothing)
        If r0 <> "000" Then
            If MsgBox(AboutMe.M.Text + vbCrLf + "你是否接受", MsgBoxStyle.YesNo, "免责声明！！！") = MsgBoxResult.No Then
                End
            End If
            MsgBox("感谢你的使用！！！" + vbCrLf + "作者:关镇涛" + vbCrLf + "现读于广东省开平市第一中学" + vbCrLf + "编程不是一件简单的事." + vbCrLf + "呕心沥血杰作出,欲使人人逐笑颜！" + vbCrLf + "千呼万唤知己者,捐款支持动起来！" + vbCrLf + "中国建设银行:" + vbCrLf + "卡号:6227 0031 2601 0025 966" + vbCrLf + "谢谢大家！！", MsgBoxStyle.Information, "第一次运行！")
            AboutMe.ShowDialog()
            Shell(My.Application.Info.DirectoryPath + "\My Love ！.exe", , True)
            MsgBox("你的赏识是我最大的荣幸！！！", MsgBoxStyle.Information, "感谢你的使用！！！")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Runned", "000")
        End If
        PictureBox1.Image = My.Resources.UC小松鼠
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", "0")
        Me.Hide()
        Timer2.Enabled = False
        SplashScreen.ShowDialog()
        Timer2.Enabled = True
        shitu()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "0")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "TB", Nothing)
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "BJ", Nothing)
        If r1 <> "" Then
            ci(gnn.getname(r1, "*", True, 0), gnn.getname(r1, "*", False, 0))
        End If
        If r3 <> "" Then
            ListView1.BackgroundImage = Image.FromFile(r3)
        Else
            ListView1.BackgroundImage = Nothing
        End If
        getDiv()
        ToolStripComboBox1.Text = ""
        ToolStripComboBox1.Width = Me.Width * 0.75
        ToolStripStatusLabel3.Width = Me.Width * 0.56
        regyh("0")
        Shell(My.Application.Info.DirectoryPath + "\WaitStop.exe", AppWinStyle.Hide, False)
        If Command.Trim <> "" Then
            If My.Computer.FileSystem.FileExists(Command.Trim.Replace(TextBox1.Text, "")) = True Then
                Dim ddc As String = JJE.odd(Command.Trim.Replace(TextBox1.Text, ""), TextBox1.Text)
                di(ddc)
                findpath()
            Else
                fir = 0
                ToolStripComboBox1.Text = Command().Replace(TextBox1.Text, "")
                If XS() = 0 Then
                    ToolStripButton2_Click()
                Else
                    findpath()
                    AddJar()
                End If
            End If
        Else
            Dim rkj As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Last", Nothing)
            If rkj = "1" And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Last.Jal") = True Then
                fir = 0
                Dim ddc As String = JJE.odd(My.Application.Info.DirectoryPath + "\Last.Jal", TextBox1.Text)
                di(ddc)
                findpath()
            End If
        End If
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Plan", Nothing)
        If r2 = 1 Then
            独项读法ToolStripMenuItem.Checked = False
            启动读法ToolStripMenuItem.Checked = True
        End If
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
        Timer2.Enabled = True
        path0 = ToolStripComboBox1.Text
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Topmost", Nothing) = 1 Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    Function getfiles()
        On Error Resume Next
        TreeView1.SelectedNode.Nodes.Clear()
        Dim h = My.Computer.FileSystem.GetDirectories(TreeView1.SelectedNode.FullPath)
        For k = 0 To h.Count - 1
            TreeView1.SelectedNode.Nodes.Add(getDic(h(k).ToString), getDic(h(k).ToString), 1)
            TreeView1.SelectedNode.Expand()
        Next
    End Function
    Function getDic(ByVal str As String)
        Dim x As Integer
        For g = 0 To Len(str) - 1
            If Mid(str, g + 1, 1) = "\" Then
                x = g
            End If
        Next
        Return (str.Remove(0, x + 1))
    End Function
    Private Sub TreeView1_AfterSelect() Handles TreeView1.AfterSelect
        If fir <> 0 Then
            getfiles()
            ToolStripComboBox1.Text = TreeView1.SelectedNode.FullPath.Replace("\\", "\")
            If XS() = 0 Then
                Addfile()
            Else
                AddJar()
            End If
        End If
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        getfiles()
    End Sub
    Private Sub ListView1_MouseDoubleClick() Handles ListView1.MouseDoubleClick
        On Error Resume Next
        runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(runer + " " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 显示ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示ToolStripMenuItem.Click
        TreeView1_AfterSelect()
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        TreeView1.Nodes.Clear()
        getDiv()
        ToolStripComboBox1.Text = ""
    End Sub
    Private Sub 复制到ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制到ToolStripMenuItem.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                On Error GoTo q
                My.Computer.FileSystem.CopyDirectory(TreeView1.SelectedNode.FullPath.Replace("\\", "\"), .SelectedPath + "\" + getname(TreeView1.SelectedNode.FullPath.Replace("\\", "\")), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 移动到ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移动到ToolStripMenuItem.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                On Error GoTo q
                My.Computer.FileSystem.MoveDirectory(TreeView1.SelectedNode.FullPath.Replace("\\", "\"), .SelectedPath + "\" + getname(TreeView1.SelectedNode.FullPath.Replace("\\", "\")), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        If MsgBox("是否删除选择的文件?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            On Error GoTo q
            My.Computer.FileSystem.DeleteDirectory(TreeView1.SelectedNode.FullPath.Replace("\\", "\"), FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
        End If
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 运行ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 运行ToolStripMenuItem.Click
        ListView1_MouseDoubleClick()
    End Sub
    Private Sub 修改ToolStripMenuItem_Click() Handles 修改ToolStripMenuItem.Click
        On Error Resume Next
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 刷新ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem1.Click
        AddJar()
    End Sub
    Private Sub 复制到ToolStripMenuItem1_Click() Handles 复制到ToolStripMenuItem1.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                For x = 0 To ListView1.SelectedItems.Count - 1
                    Try
                        My.Computer.FileSystem.CopyFile((ListView1.SelectedItems.Item(x).SubItems(1).Text), .SelectedPath + "\" + getname(ListView1.SelectedItems.Item(x).SubItems(1).Text), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                    Catch
                        GoTo q
                    End Try
q:              Next
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
    End Sub
    Function getname(ByVal str As String)
        On Error Resume Next
        If str.Length > 1 Then
            Dim u As Integer = 0
            For c = 0 To str.Length - 1
                If Mid(str, c + 1, 1) = "\" Then
                    u = c + 1
                End If
            Next
            Return (str.Remove(0, u))
        End If
    End Function
    Private Sub 移动到ToolStripMenuItem1_Click() Handles 移动到ToolStripMenuItem1.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                For x = 0 To ListView1.SelectedItems.Count - 1
                    Try
                        My.Computer.FileSystem.MoveFile((ListView1.SelectedItems.Item(0).SubItems(1).Text), .SelectedPath + "\" + getname(ListView1.SelectedItems.Item(0).SubItems(1).Text), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                    Catch
                        ListView1.SelectedIndices.Remove(0)
                        GoTo q
                    End Try
                    ListView1.Items.Remove((ListView1.SelectedItems.Item(0)))
q:              Next
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
    End Sub
    Private Sub 删除ToolStripMenuItem1_Click() Handles 删除ToolStripMenuItem1.Click
        If MsgBox("是否删除选择的文件?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For x = 0 To ListView1.SelectedItems.Count - 1
                If My.Computer.FileSystem.FileExists(ListView1.SelectedItems.Item(0).SubItems(1).Text) = True Then
                    Try
                        My.Computer.FileSystem.DeleteFile(ListView1.SelectedItems.Item(0).SubItems(1).Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                    Catch
                        ListView1.SelectedIndices.Remove(0)
                        GoTo q
                    End Try
                End If
                ListView1.Items.Remove((ListView1.SelectedItems.Item(0)))
q:          Next
            MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
        End If
    End Sub
    Private Sub 属性ToolStripMenuItem_Click() Handles 属性ToolStripMenuItem.Click
        On Error Resume Next
        regrun("1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
        Dim ra = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JE", Nothing)
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Mini JE.exe") = False Or ra = "1" Then
g:          Dim qb = JJE.JJ(TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, 3, TextBox1.Text)
            regrun("0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
            MsgBox(qb, MsgBoxStyle.Information, ListView1.SelectedItems.Item(0).Text + "属性")
            ChDir(My.Application.Info.DirectoryPath)
        Else
            On Error GoTo g
            Timer2.Enabled = False
            Me.Hide()
            Shell(My.Application.Info.DirectoryPath + "\Mini JE.exe" + " F " + TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, AppWinStyle.NormalFocus, True)
            Me.Show()
            Timer2.Enabled = True
        End If
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(JJE.Rolddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Me.Refresh()
    End Sub
    Function C1cls(ByVal TF As Boolean)
        On Error Resume Next
        显示ToolStripMenuItem.Visible = TF
        复制到ToolStripMenuItem.Visible = TF
        移动到ToolStripMenuItem.Visible = TF
        删除ToolStripMenuItem.Visible = TF
    End Function
    Function c3cls(ByVal TF As Boolean)
        On Error Resume Next
        显示ToolStripMenuItem1.Visible = TF
        复制到ToolStripMenuItem1.Visible = TF
        移动到ToolStripMenuItem1.Visible = TF
        删除ToolStripMenuItem1.Visible = TF
        ToolStripButton11.Enabled = TF
        ToolStripButton12.Enabled = TF
        ToolStripButton13.Enabled = TF
    End Function
    Function C2cls(ByVal TF As Boolean)
        On Error Resume Next
        复制到ToolStripMenuItem1.Visible = TF
        移动到ToolStripMenuItem1.Visible = TF
        删除ToolStripMenuItem1.Visible = TF
        ToolStripButton11.Enabled = TF
        ToolStripButton12.Enabled = TF
        ToolStripButton13.Enabled = TF
    End Function
    Function c2dcls(ByVal TF As Boolean)
        On Error Resume Next
        运行ToolStripMenuItem.Visible = TF
        修改ToolStripMenuItem.Visible = TF
        快速修改ToolStripMenuItem1.Visible = TF
        ToolStripButton7.Enabled = TF
        ToolStripButton8.Enabled = TF
        ToolStripButton9.Enabled = TF
        修改ToolStripMenuItem2.Visible = TF
        文件名更改ToolStripMenuItem.Visible = TF
        JadToolStripMenuItem.Visible = TF
        属性ToolStripMenuItem.Visible = TF
        ToolStripButton14.Enabled = TF
        打开方式ToolStripMenuItem.Visible = TF
        If ListView1.SelectedItems.Count > 1 Then
            JadToolStripMenuItem.Enabled = False
            Jad制作ToolStripMenuItem.Enabled = False
            查看ToolStripMenuItem.Enabled = False
            查看ToolStripMenuItem1.Enabled = False
            ToolStripButton7.Enabled = False
            ToolStripButton8.Enabled = False
            ToolStripButton9.Enabled = False
            修改ToolStripMenuItem.Enabled = False
            修改ToolStripMenuItem2.Enabled = False
            快速修改ToolStripMenuItem.Enabled = False
            快速修改ToolStripMenuItem1.Enabled = False
            文件名更改ToolStripMenuItem.Visible = True
        Else
            If ListView1.SelectedItems.Count <> 0 Then
                修改ToolStripMenuItem.Enabled = True
                修改ToolStripMenuItem2.Enabled = True
                ToolStripButton7.Enabled = True
                ToolStripButton8.Enabled = True
                ToolStripButton9.Enabled = True
                快速修改ToolStripMenuItem.Enabled = True
                快速修改ToolStripMenuItem1.Enabled = True
                JadToolStripMenuItem.Enabled = True
                Jad制作ToolStripMenuItem.Enabled = True
                查看ToolStripMenuItem.Enabled = True
                查看ToolStripMenuItem1.Enabled = True
                文件名更改ToolStripMenuItem.Visible = True
            End If
        End If
    End Function
    Function shitu()
        On Error Resume Next
        If ListView1.View = View.LargeIcon Then
            图标ToolStripMenuItem1.Checked = True
            列表ToolStripMenuItem1.Checked = False
        Else
            图标ToolStripMenuItem1.Checked = False
            列表ToolStripMenuItem1.Checked = True
        End If
        If ListView1.View = View.LargeIcon Then
            图标ToolStripMenuItem.Checked = True
            列表ToolStripMenuItem.Checked = False
        Else
            图标ToolStripMenuItem.Checked = False
            列表ToolStripMenuItem.Checked = True
        End If
        If ListView1.SelectedItems.Count = 0 Then
            添加到库中ToolStripMenuItem.Visible = False
            添加到库中ToolStripMenuItem1.Visible = False
            ToolStripSplitButton1.Enabled = False
        Else
            添加到库中ToolStripMenuItem.Visible = True
            添加到库中ToolStripMenuItem1.Visible = True
            ToolStripSplitButton1.Enabled = True
        End If
    End Function
    Function getfile2()
        On Error Resume Next
        Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
        Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
        TreeView2.SelectedNode.Nodes.Clear()
        Dim h = My.Computer.FileSystem.GetDirectories(TreeView1.SelectedNode.FullPath)
        If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
            h = My.Computer.FileSystem.GetDirectories(y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
        End If
        If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
            h = My.Computer.FileSystem.GetDirectories(u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
        End If
        For k = 0 To h.Count - 1
            TreeView2.SelectedNode.Nodes.Add(getDic(h(k).ToString), getDic(h(k).ToString), 1)
            TreeView2.SelectedNode.Expand()
        Next
    End Function
    Function Addfile()
        On Error Resume Next
        If ToolStripComboBox1.Text.Trim <> "" And ToolStripComboBox1.Text.Trim.ToLower <> path0.ToLower Then
            If back <> 1 Then
                addc1(path0.Trim)
            Else
                addc2(path0.Trim)
            End If
            path0 = ToolStripComboBox1.Text.Trim
        End If
        back = 0
        ListView2.Items.Clear()
        ListView2.Visible = False
        PictureBox1.Image = My.Resources.UC小松鼠
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        ListView1.Items.Clear()
        ListView1.LargeImageList = ImageList4
        ListView1.SmallImageList = ImageList4
        Dim t = My.Computer.FileSystem.GetFiles(ToolStripComboBox1.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        If t.Count <> 0 Then
            For h = 0 To t.Count - 1
                ListView1.Items.Add(getname(t(h)), 0)
                ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(t(h))
                Dim r = My.Computer.FileSystem.GetFileInfo(t(h)).Length
                ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(Str(Int((r / 1024))) + "KB")
            Next
        End If
        ContextMenuStrip2_Opening()
    End Function
    Dim snod = Nothing
    Private Sub ToolStripButton2_Click() Handles ToolStripButton2.Click
        findpath()
        Addfile()
    End Sub
    Function findpath()
        On Error Resume Next
        If ToolStripContainer1.Text <> "" Then
            fir = 0
            Dim s = 0
            For y = 1 To ToolStripComboBox1.Text.Length
                If Mid(ToolStripComboBox1.Text, y, 1) = "\" Then
                    s = s + 1
                End If
            Next
            Dim m = ToolStripComboBox1.Text.Split("\".ToCharArray, s + 1)
            For x = 0 To m.Count - 1
                If x = 0 Then
                    Dim nn = TreeView1
                    Dim ll = nn.Nodes.Count
                    Dim tt = m(0).Trim + "\"
                    TreeView1.Nodes.Clear()
                    getDiv()
                    For k = 0 To ll - 1
                        If nn.Nodes(k).Text.Trim.ToLower = tt.ToLower Then
                            TreeView1.SelectedNode = nn.Nodes(k)
                            snod = nn.Nodes(k)
                            getfiles()
                            TreeView1.SelectedNode.Expand()
                        End If
                    Next
                    ListView1.Select()
                Else
                    find(snod, m(x))
                End If
            Next
            fir = 1
        End If
    End Function
    Dim fd = 0
    Function find(ByVal nn As TreeNode, ByVal ss As String)
        fd = 0
        On Error Resume Next
        Dim x = 0
        Do
            If nn.Nodes(x).Text.ToLower = ss.ToLower Then
                TreeView1.SelectedNode = nn.Nodes(x)
                getfiles()
                TreeView1.SelectedNode.Expand()
                snod = nn.Nodes(x)
                fd = 1
            End If
            x = x + 1
        Loop Until x > nn.Nodes.Count - 1 Or fd <> 0
        TreeView1.Select()
    End Function
    Private Sub ContextMenuStrip2_Opening() Handles ContextMenuStrip2.Opening
        On Error Resume Next
        shitu()
        If ListView1.SelectedItems.Count <> 0 Then
            C2cls(True)
            If ListView1.SelectedItems.Count > 1 Then
                c2dcls(False)
            Else
                c2dcls(True)
            End If
        Else
            C2cls(False)
            c2dcls(False)
        End If
        etf()
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems.Count <= 1 Then
                查看ToolStripMenuItem.Visible = True
            Else
                查看ToolStripMenuItem.Visible = False
            End If
        Else
            查看ToolStripMenuItem.Visible = False
        End If
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "WZ", Nothing)
        If r0.ToString <> "" Then
            外置运行程序ToolStripMenuItem.Visible = True
            外置运行程序ToolStripMenuItem.Text = "内置运行程序"
        Else
            If r1.ToString.Trim <> "" Then
                外置运行程序ToolStripMenuItem.Visible = True
                外置运行程序ToolStripMenuItem.Text = "外置运行程序"
            Else
                外置运行程序ToolStripMenuItem.Visible = False
            End If
        End If
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        On Error Resume Next
        If TreeView1.SelectedNode Is Nothing Then
            C1cls(False)
        Else
            C1cls(True)
        End If
        If TreeView1.SelectedNode.FullPath.Length > 3 Then
            复制到ToolStripMenuItem.Visible = True
            移动到ToolStripMenuItem.Visible = True
            删除ToolStripMenuItem.Visible = True
        Else
            复制到ToolStripMenuItem.Visible = False
            移动到ToolStripMenuItem.Visible = False
            删除ToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub TreeView2_AfterSelect() Handles TreeView2.AfterSelect
        On Error Resume Next
        If Command() = "" Then
            fir = 1
        End If
        If fir <> 0 Then
            getfile2()
            Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
            Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
            If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
                ToolStripComboBox1.Text = (y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
            End If
            If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
                ToolStripComboBox1.Text = (u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
            End If
        End If
        fir = 1
        findpath()
        If XS() = 0 Then
            Addfile()
        Else
            AddJar()
        End If
    End Sub
    Private Sub TreeView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView2.DoubleClick
        getfile2()
    End Sub
    Private Sub 显示ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示ToolStripMenuItem1.Click
        TreeView2_AfterSelect()
    End Sub
    Private Sub 刷新ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem2.Click
        TreeView2.Nodes(0).Nodes.Clear()
        TreeView2.Nodes(1).Nodes.Clear()
        TreeView2.Refresh()
    End Sub
    Private Sub 复制到ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制到ToolStripMenuItem2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim gee As String
                gee = ""
                On Error Resume Next
                Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
                Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
                If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
                    gee = (y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
                End If
                If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
                    gee = (u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
                End If
                On Error GoTo q
                My.Computer.FileSystem.CopyDirectory(gee.Replace("\\", "\"), .SelectedPath + "\" + getname(gee.Replace("\\", "\")), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 移动到ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移动到ToolStripMenuItem2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim gee As String
                gee = ""
                On Error Resume Next
                Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
                Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
                If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
                    gee = (y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
                End If
                If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
                    gee = (u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
                End If
                On Error GoTo q
                My.Computer.FileSystem.MoveDirectory(gee.Replace("\\", "\"), .SelectedPath + "\" + getname(gee.Replace("\\", "\")), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                TreeView2.Nodes.Remove(TreeView2.SelectedNode)
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 删除ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem2.Click
        If MsgBox("是否删除选择的文件?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            On Error GoTo q
            Dim gee As String
            gee = ""
            Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
            Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
            If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
                gee = (y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
            End If
            If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
                gee = (u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
            End If
            My.Computer.FileSystem.DeleteDirectory(gee.Replace("\\", "\"), FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            TreeView2.Nodes.Remove(TreeView2.SelectedNode)
            MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
        End If
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub ContextMenuStrip3_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening
        If TreeView2.SelectedNode Is Nothing Then
            c3cls(False)
        Else
            c3cls(True)
        End If
        If TreeView2.SelectedNode.FullPath <> "My Documents" And TreeView2.SelectedNode.FullPath <> "Desktop" Then
            复制到ToolStripMenuItem2.Visible = True
            移动到ToolStripMenuItem2.Visible = True
            删除ToolStripMenuItem2.Visible = True
        Else
            复制到ToolStripMenuItem2.Visible = False
            移动到ToolStripMenuItem2.Visible = False
            删除ToolStripMenuItem2.Visible = False
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            C2cls(True)
            If ListView1.SelectedItems.Count > 1 Then
                c2dcls(False)
            Else
                c2dcls(True)
            End If
        Else
            C2cls(False)
            c2dcls(False)
        End If
        etf()
        If ListView1.SelectedItems.Count = 0 Then
            添加到库中ToolStripMenuItem.Visible = False
            添加到库中ToolStripMenuItem1.Visible = False
            ToolStripSplitButton1.Enabled = False
        Else
            添加到库中ToolStripMenuItem.Visible = True
            添加到库中ToolStripMenuItem1.Visible = True
            ToolStripSplitButton1.Enabled = True
        End If
        On Error Resume Next
        PictureBox1.Image = My.Resources.UC小松鼠
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        If ListView1.SelectedItems.Count = 1 Then
            修改ToolStripMenuItem1.Enabled = True
            ToolStripButton7.Enabled = True
            ToolStripButton8.Enabled = True
            ToolStripButton9.Enabled = True
            快速修改ToolStripMenuItem.Enabled = True
            文件名更改ToolStripMenuItem1.Enabled = True
            If ListView1.LargeImageList Is ImageList4 Then
                PictureBox1.Image = ImageList4.Images.Item(0)
            Else
                PictureBox1.Image = ImageList1.Images.Item(ListView1.SelectedItems.Item(0).ImageIndex)
            End If
            Label1.Text = "名称和版本号:" + ListView1.SelectedItems.Item(0).Text + vbCrLf + "路径:" + ListView1.SelectedItems.Item(0).SubItems(1).Text + vbCrLf + "大小:" + (ListView1.SelectedItems.Item(0).SubItems(2).Text)
            ToolStripStatusLabel3.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
            创建快捷方式ToolStripMenuItem.Visible = True
            ToolStripSeparator17.Visible = True
            发送到桌面ToolStripMenuItem.Visible = True
            自义定ToolStripMenuItem.Visible = True
            ToolStripSeparator18.Visible = True
            ToolStripSeparator3.Visible = True
            显示方式ToolStripMenuItem1.Visible = True
            ToolStripSplitButton2.Enabled = True
            发送到桌面ToolStripMenuItem1.Visible = True
            ToolStripSeparator20.Visible = True
            自义定ToolStripMenuItem1.Visible = True
        Else
            修改ToolStripMenuItem1.Enabled = False
            ToolStripButton7.Enabled = False
            ToolStripButton8.Enabled = False
            ToolStripButton9.Enabled = False
            快速修改ToolStripMenuItem.Enabled = False
            文件名更改ToolStripMenuItem1.Enabled = False
            创建快捷方式ToolStripMenuItem.Visible = False
            ToolStripSeparator17.Visible = False
            ToolStripSeparator3.Visible = False
            显示方式ToolStripMenuItem1.Visible = False
            ToolStripSplitButton2.Enabled = False
            发送到桌面ToolStripMenuItem1.Visible = False
            If ListView1.SelectedItems.Count > 1 Then
                PictureBox1.Image = ImageList3.Images.Item(3)
                Label1.Text = "已选择:" + Str(ListView1.SelectedItems.Count) + vbCrLf + "总文件数:" + Str(ListView1.Items.Count)
                创建快捷方式ToolStripMenuItem.Visible = True
                ToolStripSeparator17.Visible = True
                发送到桌面ToolStripMenuItem.Visible = True
                自义定ToolStripMenuItem.Visible = False
                ToolStripSeparator18.Visible = False
                ToolStripSeparator3.Visible = False
                显示方式ToolStripMenuItem1.Visible = False
                ToolStripSplitButton2.Enabled = True
                发送到桌面ToolStripMenuItem1.Visible = True
                ToolStripSeparator20.Visible = False
                自义定ToolStripMenuItem1.Visible = False
            End If
        End If
    End Sub
    Private Sub 图标ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图标ToolStripMenuItem1.Click
        图标ToolStripMenuItem_Click()
    End Sub
    Private Sub 列表ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 列表ToolStripMenuItem1.Click
        列表ToolStripMenuItem_Click()
    End Sub
    Private Sub JarSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JarSettingToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub JE_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ToolStripComboBox1.Width = Me.Width * 0.7
        ToolStripStatusLabel3.Width = Me.Width * 0.56
    End Sub
    Private Sub 重刷ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重刷ToolStripMenuItem.Click
        Addfile()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        JE_FormClosing()
        End
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ListView1_MouseDoubleClick()
    End Sub
    Private Sub 文件名更改ToolStripMenuItem_Click() Handles 文件名更改ToolStripMenuItem.Click
        On Error Resume Next
        Dim yun As String
        yun = ""
        For m = 0 To ListView1.SelectedItems.Count - 1
            yun = yun + TextBox1.Text + ListView1.SelectedItems.Item(m).SubItems(1).Text + TextBox1.Text + " "
        Next
        Shell(My.Application.Info.DirectoryPath + "\JFR.exe " + yun, AppWinStyle.NormalFocus)
    End Sub
    Private Sub 文件名更改ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 文件名更改ToolStripMenuItem1.Click
        文件名更改ToolStripMenuItem_Click()
    End Sub
    Private Sub JFRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JFRToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\JFR.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub 作者ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者ToolStripMenuItem.Click
        MsgBox("作者:关镇涛" + vbCrLf + "现读于" + vbCrLf + "广东省开平市第一中学", MsgBoxStyle.Information, "关于作者！")
    End Sub
    Private Sub 捐款支持ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 捐款支持ToolStripMenuItem.Click
        MsgBox("编程不是一件简单的事." + vbCrLf + "呕心沥血杰作出,欲使人人逐笑颜！" + vbCrLf + "千呼万唤知己者,捐款支持动起来！" + vbCrLf + "中国建设银行:" + vbCrLf + "卡号:6227 0031 2601 0025 966" + vbCrLf + "谢谢大家！！", MsgBoxStyle.Information, "关于捐款支持！")
    End Sub
    Private Sub 产品ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 产品ToolStripMenuItem.Click
        AboutMe.ShowDialog()
    End Sub
    Private Sub 编辑ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.DropDownOpening
        If ListView1.SelectedItems.Count <> 0 Then
            etf()
            If ListView1.SelectedItems.Count > 1 Then
                查看ToolStripMenuItem1.Enabled = False
                修改ToolStripMenuItem1.Enabled = False
                ToolStripButton7.Enabled = False
                ToolStripButton8.Enabled = False
                ToolStripButton9.Enabled = False
                快速修改ToolStripMenuItem.Enabled = False
                Jad制作ToolStripMenuItem.Enabled = False
                文件名更改ToolStripMenuItem1.Enabled = True
            End If
        Else
            查看ToolStripMenuItem1.Enabled = False
            修改ToolStripMenuItem1.Enabled = False
            ToolStripButton7.Enabled = False
            ToolStripButton8.Enabled = False
            ToolStripButton9.Enabled = False
            快速修改ToolStripMenuItem.Enabled = False
            Jad制作ToolStripMenuItem.Enabled = False
            文件名更改ToolStripMenuItem1.Enabled = False
        End If
    End Sub
    Private Sub 工具ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 工具ToolStripMenuItem.DropDownOpening
        etf()
    End Sub
    Function etf()
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Jar Setting.exe") = False Then
            修改ToolStripMenuItem.Enabled = False
            修改ToolStripMenuItem1.Enabled = False
            ToolStripButton7.Enabled = False
            ToolStripButton8.Enabled = False
            ToolStripButton9.Enabled = False
            快速修改ToolStripMenuItem1.Enabled = False
            快速修改ToolStripMenuItem.Enabled = False
            JarSettingToolStripMenuItem.Enabled = False
        Else
            修改ToolStripMenuItem.Enabled = True
            修改ToolStripMenuItem1.Enabled = True
            快速修改ToolStripMenuItem1.Enabled = True
            快速修改ToolStripMenuItem.Enabled = True
            JarSettingToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\JFR.exe") = False Then
            文件名更改ToolStripMenuItem.Enabled = False
            文件名更改ToolStripMenuItem1.Enabled = False
            JFRToolStripMenuItem.Enabled = False
        Else
            文件名更改ToolStripMenuItem.Enabled = True
            文件名更改ToolStripMenuItem1.Enabled = True
            JFRToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\QuickShowFiles.exe") = False Then
            查看ToolStripMenuItem.Enabled = False
            查看ToolStripMenuItem1.Enabled = False
            ToolStripButton7.Enabled = False
        Else
            查看ToolStripMenuItem.Enabled = True
            查看ToolStripMenuItem1.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\JAR_RUN.exe") = False Then
            JadToolStripMenuItem.Enabled = False
            Jad制作ToolStripMenuItem.Enabled = False
        Else
            JadToolStripMenuItem.Enabled = True
            Jad制作ToolStripMenuItem.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Mini JE.exe") = False Then
            MiniJEToolStripMenuItem.Enabled = False
            ToolStripButton5.Enabled = False
        Else
            MiniJEToolStripMenuItem.Enabled = True
            ToolStripButton5.Enabled = True
        End If
    End Function
    Private Sub 设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设置ToolStripMenuItem.Click
        Timer2.Enabled = False
        Me.Hide()
        RunSet.ShowDialog()
        Me.Show()
        Timer2.Enabled = True
    End Sub
    Private Sub 全选ToolStripMenuItem_Click() Handles 全选ToolStripMenuItem.Click
        For g = 0 To ListView1.Items.Count - 1
            ListView1.SelectedIndices.Add(g)
        Next
    End Sub
    Private Sub 修改ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改ToolStripMenuItem2.Click
        修改ToolStripMenuItem_Click()
    End Sub
    Private Sub 全选ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem1.Click
        全选ToolStripMenuItem_Click()
    End Sub
    Private Sub WaitStopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitStopToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\WaitStop.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub MyLoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyLoveToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\My Love ！.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub QSFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QSFToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\QuickShowFiles.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub 查看ToolStripMenuItem_Click() Handles 查看ToolStripMenuItem.Click
        On Error Resume Next
        Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
        Shell(My.Application.Info.DirectoryPath + "\QuickShowFiles.exe" + " " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
    End Sub
    Private Sub 查看ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查看ToolStripMenuItem1.Click
        查看ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next
        If ToolStripButton1.Enabled = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "1")
        End If
    End Sub
    Private Sub 保存列表ToolStripMenuItem_Click() Handles 保存列表ToolStripMenuItem.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "*.Jal列表文件|*.Jal"
            .ShowDialog()
            If .FileName <> "" Then
                bi(.FileName)
                MsgBox("Finished！！！", MsgBoxStyle.Information, "温馨提示！")
            End If
        End With
    End Sub
    Function bi(ByVal dd As String)
        On Error GoTo l
        Dim wj As String = JJE.wjj
        Dim kk As String = TextBox2.Text.Replace("/Name", (ToolStripComboBox1.Text).Trim).Replace("/Num", Str(ListView1.Items.Count).Trim)
        For x = 0 To ListView1.Items.Count - 1
            ImageList1.Images.Item(ListView1.Items.Item(x).ImageIndex).Save(wj + "\" + Str(x).Trim + ".png")
            kk = kk + vbCrLf + TextBox3.Text.Replace("/DZ", ListView1.Items.Item(x).SubItems.Item(0).Text).Replace("/Png", Str(x).Trim + ".png").Replace("/PPP", ListView1.Items.Item(x).SubItems.Item(1).Text.Trim).Replace("/SSS", ListView1.Items.Item(x).SubItems.Item(2).Text.Trim)
        Next
        kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</Aero>"
        My.Computer.FileSystem.WriteAllText(wj + "\Aero.xml", kk.Replace("&", "*\*/*"), False)
        JJE.obb(wj, dd, TextBox1.Text)
        Return 0
        Exit Function
l:      MsgBox("Failed！", MsgBoxStyle.Exclamation)
    End Function
    Private Sub 导入列表ToolStripMenuItem_Click() Handles 导入列表ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.UC小松鼠
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.Jal列表文件|*.Jal"
            .ShowDialog()
            If .FileName <> "" Then
                Dim ddc As String = JJE.odd(.FileName, TextBox1.Text)
                ListView2.Items.Clear()
                ListView2.Visible = False
                di(ddc)
                findpath()
                MsgBox("Unzip Successed！！！", MsgBoxStyle.Information, "温馨提示！")
            End If
        End With
    End Sub
    Function di(ByVal str As String)
        On Error Resume Next
        Dim ddc As String = str
        Dim Aero = XDocument.Load(ddc + "\Aero.xml")
        ListView1.Items.Clear()
        ListView1.LargeImageList = ImageList1
        ListView1.SmallImageList = ImageList2
        ToolStripComboBox1.Text = Aero.<Aero>.<Tile>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
        ImageList1.Images.Clear()
        ImageList2.Images.Clear()
        ToolStripProgressBar2.Value = 0
        For x = 0 To CInt(Aero.<Aero>.<FileNum>.Value) - 1
            Dim yb = New PictureBox
            yb.WaitOnLoad = True
            yb.ErrorImage = Nothing
            yb.Image = Nothing
            yb.ImageLocation = ddc + "\" + Aero.<Aero>.<Files>.<File>(x).<Pic>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            ImageList1.Images.Add(yb.Image)
            ImageList2.Images.Add(yb.Image)
            Dim knn As String = Aero.<Aero>.<Files>.<File>(x).<Name>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kpp As String = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kss As String = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            If knn <> "Not a Jar" And knn <> "" Then
                ListView1.Items.Add(knn, x)
                ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
            Else
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", Nothing) <> "1" Then
                    ListView1.Items.Add(knn, x)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
                End If
            End If
            On Error Resume Next
            ToolStripProgressBar2.Value = ToolStripProgressBar2.Value + 100 / CInt(Aero.<Aero>.<FileNum>.Value)
        Next
        ToolStripProgressBar1.Value = 100
        ToolStripProgressBar2.Value = 100
        On Error Resume Next
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(ddc, FileIO.DeleteDirectoryOption.DeleteAllContents)
        ContextMenuStrip2_Opening()
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XX", Nothing) = "1" Then
            di(JJM.rwj)
            Dim r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", Nothing)
            Label1.Text = "已处理" + Str(CInt(r7) + 1).Trim + "/" + Str(CInt(r7) + 1).Trim + vbCrLf + "总进度:" + Str(100) + "%"
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", -1)
            ToolStripProgressBar1.Value = 100
            Timer1.Enabled = False
            ToolStripButton2.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton5.Enabled = True
            TreeView1.Enabled = True
            TreeView2.Enabled = True
            ListView1.Enabled = True
            文件ToolStripMenuItem.Enabled = True
            ToolStripButton4.Enabled = False
            设置ToolStripMenuItem.Enabled = True
            载入库ToolStripMenuItem.Enabled = True
            前进ToolStripMenuItem.Enabled = True
            后退ToolStripMenuItem.Enabled = True
            ToolStrip1.Enabled = True
            查找ToolStripMenuItem.Enabled = True
            ContextMenuStrip2_Opening()
            If ListView1.View = View.Details Then
                列表ToolStripMenuItem_Click()
            End If
        Else
            On Error Resume Next
            If ToolStripProgressBar1.Visible = True Then
                Dim r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "NG", Nothing)
                Dim r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", Nothing)
                Dim no = r6
                Dim ko = r7
                If no <> ko Then
                    ko = no
                    If CInt(r6) / CInt(r7) < 1 Then
                        Label1.Text = "已处理" + Str(CInt(r6) + 1).Trim + "/" + Str(CInt(r7) + 1).Trim + vbCrLf + "总进度:" + Str(CInt(r6) / CInt(r7) * 100).Trim.Remove(4) + "%"
                        ToolStripProgressBar1.Value = CInt(r6) / CInt(r7) * 100
                    End If
                End If
            End If
        End If
    End Sub
    Function ci(ByVal h As Integer, ByVal w As Integer)
        On Error Resume Next
        ImageList1.ImageSize = JJE.issize(h, w)
    End Function
    Private Sub 修改ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改ToolStripMenuItem1.Click
        修改ToolStripMenuItem_Click()
    End Sub
    Private Sub 管理库ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 管理库ToolStripMenuItem.Click
        Timer2.Enabled = False
        Me.Hide()
        Ku.ShowDialog()
        Me.Show()
        Timer2.Enabled = True
    End Sub
    Private Sub 默认库ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认库ToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\M-Game.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub 默认库ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认库ToolStripMenuItem1.Click
        On Error Resume Next
        Dim ddc As String = JJE.odd(My.Application.Info.DirectoryPath + "\Ku" + "\Default.Jal", TextBox1.Text)
        di(ddc)
    End Sub
    Private Sub 默认库ToolStripMenuItem2_Click() Handles 默认库ToolStripMenuItem2.Click
        On Error Resume Next
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + "Default", "Jal", bi2)
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + "Default", "Run", Nothing) <> "1" Then
            Shell(My.Application.Info.DirectoryPath + "\M-Game.exe", AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 默认库ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认库ToolStripMenuItem3.Click
        默认库ToolStripMenuItem2_Click()
    End Sub
    Private Sub 其他库ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 其他库ToolStripMenuItem.DropDownOpening
        AddKu(ToolStripComboBox2)
    End Sub
    Function AddKu(ByVal ki As ToolStripComboBox)
        On Error Resume Next
        ki.Items.Clear()
        Dim jal = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath + "\Ku", FileIO.SearchOption.SearchTopLevelOnly, "*.Xml")
        If jal.Count <> 0 Then
            For x = 0 To jal.Count - 1
                Dim kk As String = gnn.getname(jal(x).Replace(My.Application.Info.DirectoryPath + "\Ku\", ""), ".", True, 0)
                If kk <> "Default" Then
                    ki.Items.Add(kk)
                End If
            Next
        End If
    End Function
    Private Sub 载入库ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 载入库ToolStripMenuItem.DropDownOpening
        AddKu(ToolStripComboBox4)
    End Sub
    Private Sub 添加到库中ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 添加到库中ToolStripMenuItem.DropDownOpening
        AddKu(ToolStripComboBox3)
    End Sub
    Private Sub 添加到库中ToolStripMenuItem1_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 添加到库中ToolStripMenuItem1.DropDownOpening
        AddKu(ToolStripComboBox5)
    End Sub
    Private Sub ToolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        If ToolStripComboBox2.Text.Trim <> "" Then
            On Error Resume Next
            Shell(My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + ToolStripComboBox2.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub ToolStripComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox4.SelectedIndexChanged
        On Error Resume Next
        Dim ddc As String = JJE.odd(My.Application.Info.DirectoryPath + "\Ku" + "\" + ToolStripComboBox4.Text + ".Jal", TextBox1.Text)
        di(ddc)
    End Sub
    Private Sub ToolStripComboBox3_SelectedIndexChanged() Handles ToolStripComboBox3.SelectedIndexChanged
        If ToolStripComboBox3.Text <> "" Then
            On Error Resume Next
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox3.Text, "Jal", bi2())
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox3.Text, "Run", Nothing) <> "1" Then
                Shell(My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + ToolStripComboBox3.Text, AppWinStyle.NormalFocus)
            End If
        End If
        ToolStripComboBox3.SelectedItem = Nothing
    End Sub
    Private Sub ToolStripComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox5.SelectedIndexChanged
        If ToolStripComboBox5.Text <> "" Then
            On Error Resume Next
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox5.Text, "Jal", bi2())
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox5.Text, "Run", Nothing) <> "1" Then
                Shell(My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + ToolStripComboBox5.Text, AppWinStyle.NormalFocus)
            End If
        End If
        ToolStripComboBox5.SelectedItem = Nothing
    End Sub
    Function XS()
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XS", Nothing)
        If r1 = "1" Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Timer2.Enabled = False
        Me.Hide()
        _18yo.ShowDialog()
        Me.Show()
        Timer2.Enabled = True
    End Sub
    Private Sub JadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadToolStripMenuItem.Click
        Jad制作ToolStripMenuItem_Click()
    End Sub
    Private Sub Jad制作ToolStripMenuItem_Click() Handles Jad制作ToolStripMenuItem.Click
        On Error Resume Next
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(My.Application.Info.DirectoryPath + "\JAR_RUN.exe" + " /Jad " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 库ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 库ToolStripMenuItem.DropDownOpening
        If ListView1.SelectedItems.Count = 0 Then
            添加到库中ToolStripMenuItem.Visible = False
            添加到库中ToolStripMenuItem1.Visible = False
            ToolStripSplitButton1.Enabled = False
        Else
            添加到库中ToolStripMenuItem.Visible = True
            添加到库中ToolStripMenuItem1.Visible = True
            ToolStripSplitButton1.Enabled = True
        End If
    End Sub
    Private Sub 选择运行程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 选择运行程序ToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim ke = ListView1.SelectedItems.Item(0).SubItems(1).Text
            If My.Computer.FileSystem.FileExists(ke) = True Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ke, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub 外置运行程序ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 外置运行程序ToolStripMenuItem.Click
        On Error Resume Next
        If 外置运行程序ToolStripMenuItem.Text = "内置运行程序" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", "1")
        End If
        runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(runer + " " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus, True)
        End If
        If 外置运行程序ToolStripMenuItem.Text = "内置运行程序" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", "")
        End If
    End Sub
    Private Sub MiniJEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniJEToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\Mini JE.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        On Error Resume Next
        Timer2.Enabled = False
        Me.Hide()
        Shell(My.Application.Info.DirectoryPath + "\Mini JE.exe" + " D " + TextBox1.Text + ToolStripComboBox1.Text + TextBox1.Text, AppWinStyle.NormalFocus, True)
        Me.Show()
        Timer2.Enabled = True
    End Sub
    Private Sub 快速修改ToolStripMenuItem_Click() Handles 快速修改ToolStripMenuItem.Click
        On Error Resume Next
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe /Mini " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 快速修改ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 快速修改ToolStripMenuItem1.Click
        快速修改ToolStripMenuItem_Click()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "MHide", Nothing)
        If r0 = "1" Then
            If Me.WindowState = FormWindowState.Minimized = True Then
                Me.WindowState = FormWindowState.Normal
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", "1")
            End If
        End If
        dohiid(Me.WindowState)
    End Sub
    Function rhiid()
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "Hide", Nothing)
        If r0 = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Function dohiid(ByVal b)
        On Error Resume Next
        If rhiid() = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
        Me.WindowState = b
    End Function
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        On Error Resume Next
        Timer2.Enabled = False
        Me.Hide()
        AboutMe.ShowDialog()
        Me.Show()
        Timer2.Enabled = True
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        With FolderBrowserDialog1
            .ShowNewFolderButton = False
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                ToolStripComboBox1.Items.Add(.SelectedPath)
                ToolStripComboBox1.Text = .SelectedPath
                If XS() = 0 Then
                    Addfile()
                Else
                    AddJar()
                End If
                findpath()
            End If
            .ShowNewFolderButton = True
        End With
    End Sub
    Function bi2()
        On Error Resume Next
        Dim wjs As Integer = ListView1.SelectedItems.Count
        Dim wj As String = JJE.wjj
        Dim kk As String = TextBox2.Text.Replace("/Name", (ToolStripComboBox1.Text).Trim).Replace("/Num", Str(wjs).Trim)
        For j = 0 To wjs - 1
            Dim tts = (ListView1.SelectedItems(j).ImageIndex)
            If tts = 0 Then
                ImageList1.Images.Item(0).Save(wj + "\" + Str(j).Trim + ".png")
            Else
                ImageList1.Images.Item(tts).Save(wj + "\" + Str(j).Trim + ".png")
            End If
            kk = kk + vbCrLf + TextBox3.Text.Replace("/DZ", ListView1.SelectedItems(j).Text.Trim.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(j).Trim + ".png").Replace("/PPP", ListView1.SelectedItems(j).SubItems(1).Text.Trim).Replace("/SSS", ListView1.SelectedItems(j).SubItems(2).Text.Trim)
        Next
        kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</Aero>"
        My.Computer.FileSystem.WriteAllText(wj + "\Aero.xml", kk.Replace("&", "*\*/*"), False)
        Return wj
    End Function
    Private Sub 前进ToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles 前进ToolStripMenuItem.DropDownItemClicked
        If 前进ToolStripMenuItem.DropDownItems.Count > 3 And 前进ToolStripMenuItem.DropDownItems.Item(0).Selected = False And 前进ToolStripMenuItem.DropDownItems.Item(1).Selected = False Then
            On Error Resume Next
            If fir <> 0 Then
                For x = 3 To 前进ToolStripMenuItem.DropDownItems.Count - 1
                    If 前进ToolStripMenuItem.DropDownItems.Item(x).Selected = True Then
                        ToolStripComboBox1.Text = 前进ToolStripMenuItem.DropDownItems.Item(x).Text
                    End If
                Next
                If XS() = 0 Then
                    Addfile()
                Else
                    AddJar()
                End If
                findpath()
            End If
        End If
    End Sub
    Function addtools(ByVal mt As ToolStripMenuItem, ByVal tj As String)
        On Error Resume Next
        If tj.Trim <> "" Then
            Dim addedMenuStripItem As New ToolStripMenuItem
            addedMenuStripItem.Text = tj
            mt.DropDownItems.Insert(3, addedMenuStripItem)
        End If
    End Function
    Dim back As String
    Dim toward As String
    Function addc1(ByVal his As String)
        On Error Resume Next
        addtools(后退ToolStripMenuItem, his)
    End Function
    Function addc2(ByVal his As String)
        On Error Resume Next
        addtools(前进ToolStripMenuItem, his)
    End Function
    Private Sub 后退ToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles 后退ToolStripMenuItem.DropDownItemClicked
        On Error Resume Next
        If 后退ToolStripMenuItem.DropDownItems.Count > 3 And 后退ToolStripMenuItem.DropDownItems.Item(0).Selected = False And 后退ToolStripMenuItem.DropDownItems.Item(1).Selected = False Then
            If fir <> 0 Then
                For x = 3 To 后退ToolStripMenuItem.DropDownItems.Count - 1
                    If 后退ToolStripMenuItem.DropDownItems.Item(x).Selected = True Then
                        ToolStripComboBox1.Text = 后退ToolStripMenuItem.DropDownItems.Item(x).Text
                        If path0 <> "" And 后退ToolStripMenuItem.DropDownItems.Item(x).Text <> path0 Then
                            addc2(path0)
                        End If
                    End If
                Next
                rcc()
            End If
        End If
    End Sub
    Private Sub 前进ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 前进ToolStripMenuItem1.Click
        On Error Resume Next
        If 前进ToolStripMenuItem.DropDownItems.Item(3).Text.Trim <> "" Then
            ToolStripComboBox1.Text = 前进ToolStripMenuItem.DropDownItems.Item(3).Text
            前进ToolStripMenuItem.DropDownItems.Remove(前进ToolStripMenuItem.DropDownItems.Item(3))
        End If
        rcc()
    End Sub
    Function rcc()
        On Error Resume Next
        If ToolStripComboBox1.Text <> path0 Then
            If XS() = 0 Then
                Addfile()
            Else
                AddJar()
            End If
            findpath()
        End If
    End Function
    Private Sub 后退ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 后退ToolStripMenuItem1.Click
        On Error Resume Next
        If 后退ToolStripMenuItem.DropDownItems.Item(3).Text.Trim <> "" Then
            ToolStripComboBox1.Text = 后退ToolStripMenuItem.DropDownItems.Item(3).Text
            后退ToolStripMenuItem.DropDownItems.Remove(后退ToolStripMenuItem.DropDownItems.Item(3))
            back = 1
        End If
        rcc()
    End Sub
    Private Sub 后退ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 后退ToolStripMenuItem.DropDownOpening
        If 后退ToolStripMenuItem.DropDownItems.Count = 3 Then
            后退ToolStripMenuItem.DropDownItems.Item(0).Visible = False
            后退ToolStripMenuItem.DropDownItems.Item(1).Visible = False
            后退ToolStripMenuItem.DropDownItems.Item(2).Visible = False
        Else
            后退ToolStripMenuItem.DropDownItems.Item(0).Visible = True
            后退ToolStripMenuItem.DropDownItems.Item(1).Visible = True
            后退ToolStripMenuItem.DropDownItems.Item(2).Visible = True
        End If
    End Sub
    Private Sub 前进ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 前进ToolStripMenuItem.DropDownOpening
        If 前进ToolStripMenuItem.DropDownItems.Count = 3 Then
            前进ToolStripMenuItem.DropDownItems.Item(0).Visible = False
            前进ToolStripMenuItem.DropDownItems.Item(1).Visible = False
            前进ToolStripMenuItem.DropDownItems.Item(2).Visible = False
        Else
            前进ToolStripMenuItem.DropDownItems.Item(0).Visible = True
            前进ToolStripMenuItem.DropDownItems.Item(1).Visible = True
            前进ToolStripMenuItem.DropDownItems.Item(2).Visible = True
        End If
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        后退ToolStripMenuItem.Visible = False
        For x = 3 To 后退ToolStripMenuItem.DropDownItems.Count - 1
            后退ToolStripMenuItem.DropDownItems.Remove(后退ToolStripMenuItem.DropDownItems.Item(3))
        Next
        后退ToolStripMenuItem.Visible = True
    End Sub
    Private Sub 清空ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem1.Click
        前进ToolStripMenuItem.Visible = False
        For x = 3 To 前进ToolStripMenuItem.DropDownItems.Count - 1
            前进ToolStripMenuItem.DropDownItems.Remove(前进ToolStripMenuItem.DropDownItems.Item(3))
        Next
        前进ToolStripMenuItem.Visible = True
    End Sub
    Private Sub 查找ToolStripMenuItem_Click() Handles 查找ToolStripMenuItem.Click
        If ListView2.Visible = True Then
            ListView2.Visible = False
            ListView1.Items.Clear()
            If ListView2.Items.Count <> 0 Then
                For x = 0 To ListView2.Items.Count - 1
                    ListView1.Items.Add(ListView2.Items.Item(x).Clone)
                Next
                ListView2.Items.Clear()
            End If
        Else
           If ListView1.Items.Count <> 0 Then
                Dim zzrr As String = InputBox("请输入相关字符:", "Java程序查找~/~")
                If zzrr <> "" Then
                    ListView2.Items.Clear()
                    ListView2.Visible = True
                    For x = 0 To ListView1.Items.Count - 1
                        ListView2.Items.Add(ListView1.Items.Item(x).Clone)
                    Next
                    ListView1.Items.Clear()
                    For x = 0 To ListView2.Items.Count - 1
                        If Len(ListView2.Items(x).Text.ToUpper.Trim) >= Len(zzrr.ToUpper.Trim) Then
                            If ListView2.Items(x).Text.ToUpper.Trim <> zzrr.ToUpper Then
                                If gnn.getname(ListView2.Items(x).Text.ToUpper, zzrr.ToUpper, True, 1).ToString.Trim <> ListView2.Items(x).Text.ToUpper.Trim Or gnn.getname(ListView2.Items(x).Text.ToUpper, zzrr.ToUpper, False, 1).ToString.Trim <> "" Then
                                    ListView1.Items.Insert(0, ListView2.Items.Item(x).Clone)
                                End If
                            Else
                                ListView1.Items.Insert(0, ListView2.Items.Item(x).Clone)
                            End If
                        End If
                    Next
                End If
            Else
                MsgBox("无效查找！！！", MsgBoxStyle.Exclamation, "敬告！！！")
            End If
        End If
        ContextMenuStrip2_Opening()
        If ListView1.View = View.Details Then
            列表ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
        默认库ToolStripMenuItem2_Click()
    End Sub
    Private Sub ToolStripSplitButton1_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.DropDownOpening
        AddKu(ToolStripComboBox6)
    End Sub
    Private Sub 默认库ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认库ToolStripMenuItem4.Click
        默认库ToolStripMenuItem2_Click()
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        查看ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        修改ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        快速修改ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        全选ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        复制到ToolStripMenuItem1_Click()
    End Sub
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        移动到ToolStripMenuItem1_Click()
    End Sub
    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        删除ToolStripMenuItem1_Click()
    End Sub
    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        属性ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        查找ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        导入列表ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        保存列表ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox6.SelectedIndexChanged
        If ToolStripComboBox6.Text <> "" Then
            On Error Resume Next
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox6.Text, "Jal", bi2())
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + ToolStripComboBox6.Text, "Run", Nothing) <> "1" Then
                Shell(My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + ToolStripComboBox6.Text, AppWinStyle.NormalFocus)
            End If
        End If
        ToolStripComboBox6.SelectedItem = Nothing
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
    End Sub
    Private Sub 帮助ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem.Click
        On Error Resume Next
        Shell("hh " + My.Application.Info.DirectoryPath + "\JE.CHM", 1)
    End Sub
    Function rest()
        On Error Resume Next
        kjj.ct(False, True)
        kjj.tr("", "")
        kjj.te(True, True)
    End Function
    Private Sub 发送到桌面ToolStripMenuItem_Click() Handles 发送到桌面ToolStripMenuItem.Click
        rest()
        If ListView1.SelectedItems.Count = 1 Then
            kjj.tr("", ListView1.SelectedItems.Item(0).SubItems(1).Text)
            kjj.te(False, False)
            kjj.ct(True, True)
            Dim t0 = (JJE.JJ(TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, 0, TextBox1.Text).ToString.Split(vbCrLf)(1)).Replace(vbCrLf, "").Trim.Replace(vbCr, "").Replace(vbLf, "")
            kjj.ki(t0)
            kjj.ShowDialog()
        Else
            For x = 0 To ListView1.SelectedItems.Count - 1
                kjj.tr("", ListView1.SelectedItems.Item(x).SubItems(1).Text)
                kjj.te(False, False)
                kjj.ct(True, True)
                kjj.doit()
            Next
            MsgBox("操作完成！！！", MsgBoxStyle.Information, "温馨提示！！！")
        End If
    End Sub
    Private Sub 自义定ToolStripMenuItem_Click() Handles 自义定ToolStripMenuItem.Click
        rest()
        If ListView1.SelectedItems.Count = 1 Then
            kjj.ct(False, True)
            kjj.tr("", ListView1.SelectedItems.Item(0).SubItems(1).Text)
            kjj.te(True, False)
            Dim t0 = (JJE.JJ(TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, 0, TextBox1.Text).ToString.Split(vbCrLf)(1)).Replace(vbCrLf, "").Trim.Replace(vbCr, "").Replace(vbLf, "")
            kjj.ki(t0)
            kjj.ShowDialog()
        End If
    End Sub
    Private Sub 发送到桌面ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 发送到桌面ToolStripMenuItem1.Click
        发送到桌面ToolStripMenuItem_Click()
    End Sub
    Private Sub 自义定ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 自义定ToolStripMenuItem1.Click
        自义定ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripSplitButton2_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton2.ButtonClick
        发送到桌面ToolStripMenuItem_Click()
    End Sub
End Class