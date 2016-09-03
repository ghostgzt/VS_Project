Public Class JE
    Dim JJE As New JEExt.JEE
    Dim JJM As New JALM.JLL
    Dim runer As String
    Dim fir As Integer
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
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
        On Error Resume Next
        PictureBox1.Image = Nothing
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        ListView1.Items.Clear()
        ListView1.LargeImageList = ImageList1
        ListView1.SmallImageList = ImageList2
        Dim qtx As String = ""
        Dim t = My.Computer.FileSystem.GetFiles(ToolStripComboBox1.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        If t.Count <> 0 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "1")
            ImageList1.Images.Clear()
            ImageList2.Images.Clear()
            ToolStripProgressBar2.Value = 0
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "0")
            For x = 0 To t.Count - 1
                Label1.Text = "已处理" + Str(x) + "/" + Str(t.Count - 1)
                regyh("0")
                regrun("1")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
                endd("$JEE163.tmp")
                Dim jd As Integer = 100 / t.Count
                Dim yl As New ListBox
                yl.Items.Clear()
                If 独项读法ToolStripMenuItem.Checked = True Then
                    Dim t0 As String
                    endd("$JEE163.tmp")
                    t0 = JJE.JJ(TextBox1.Text + t(x) + TextBox1.Text, 0, TextBox1.Text)
                    endd("$JEE163.tmp")
                    ToolStripProgressBar1.Value = 0
                    If t0 = "" Then
                        Dim yy = New PictureBox
                        ImageList1.Images.Add(yy.InitialImage)
                        ImageList2.Images.Add(yy.InitialImage)
                        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", Nothing) <> "1" Then
                            ListView1.Items.Add("Not a Jar", x)
                        End If
                    Else
                        Dim u = ""
                        Dim micon = ""
                        Dim vedor = ""
                        Dim x0 = 0
                        Do
                            x0 = x0 + 1
                        Loop Until Mid(t0, x0, Len(vbCrLf)) = vbCrLf Or x0 > Len(t0)
                        Dim r = x0 + 1
                        Dim mnane = t0.Remove(x0)
                        Do
                            x0 = x0 + 1
                        Loop Until Mid(t0, x0, Len(vbCrLf)) = vbCrLf Or x0 > Len(t0)
                        u = x0 + 1
                        micon = t0.Remove(0, r).Remove(u - r)
                        vedor = t0.Remove(0, u)
                        ToolStripProgressBar1.Value = 50
                        Dim l = mnane + " v" + vedor
                        Dim yy = New PictureBox
                        yy.WaitOnLoad = True
                        yy.ErrorImage = Nothing
                        On Error Resume Next
                        yy.Image = Nothing
                        yy.ImageLocation = micon
                        If yy.Image Is Nothing Then
                            yy.Image = Nothing
                            endd("$JEE163.tmp")
                            Dim i As String
                            i = JJE.getN(JJE.Rolddir + "\META-INF\MANIFEST.MF")
                            endd("$JEE163.tmp")
                            Dim h As String
                            h = JJE.zf(TextBox1.Text + t(x) + TextBox1.Text, i, False, TextBox1.Text)
                            endd("$JEE163.tmp")
                            If h = "" Then
                                yy.Image = ImageList4.Images.Item(0)
                            Else
                                yy.WaitOnLoad = True
                                yy.ImageLocation = h
                            End If
                            If yy.Image Is Nothing Then
                                yy.Image = ImageList4.Images.Item(0)
                            End If
                        End If
                        ImageList1.Images.Add(yy.Image)
                        ImageList2.Images.Add(yy.Image)
                        If l.Trim = "v" Or l = "" Then
                            l = ""
                        End If
                        ListView1.Items.Add(l, x)
                    End If
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(t(x))
                    Dim r1 = My.Computer.FileSystem.GetFileInfo(t(x)).Length
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(Str(Int((r1 / 1024))) + "KB")
                    'ListView1.Refresh()
                    ToolStripProgressBar1.Value = 100
                    ToolStripProgressBar2.Value = ToolStripProgressBar2.Value + jd
                Else
                    ToolStripProgressBar1.Value = 0
                    Dim y = JJE.JJ(TextBox1.Text + t(x) + TextBox1.Text, 1, TextBox1.Text)
                    If y = "" Then
                        Dim yy = New PictureBox
                        ImageList1.Images.Add(yy.InitialImage)
                        ImageList2.Images.Add(yy.InitialImage)
                    Else
                        Dim yy = New PictureBox
                        yy.WaitOnLoad = True
                        On Error Resume Next
                        yy.Image = Nothing
                        yy.ImageLocation = JJE.zf(TextBox1.Text + t(x) + TextBox1.Text, y, False, TextBox1.Text)
                        If yy.Image Is Nothing Then
                            Dim h = JJE.getM(JJE.Rolddir + "\META-INF\MANIFEST.MF", TextBox1.Text + t(x) + TextBox1.Text, 1, TextBox1.Text)
                            If h = "" Or h = JJE.Rolddir + "\" Then
                                yy.Image = ImageList4.Images.Item(0)
                            Else
                                yy.WaitOnLoad = True
                                yy.ImageLocation = h
                            End If
                        End If

                        ToolStripProgressBar1.Value = 50
                        If yy.Image Is Nothing Then
                            yy.Image = ImageList4.Images.Item(0)
                        End If
                        ImageList1.Images.Add(yy.Image)
                        ImageList2.Images.Add(yy.Image)
                    End If
                    Dim b = JJE.zf(TextBox1.Text + t(x) + TextBox1.Text, y, True, TextBox1.Text)
                    Dim v = JJE.getM(JJE.Rolddir + "\META-INF\MANIFEST.MF", TextBox1.Text + t(x) + TextBox1.Text, 2, TextBox1.Text)
                    If b + " v" + v <> " v" Then
                        ListView1.Items.Add(b + " v" + v, x)
                    Else
                        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", Nothing) <> "1" Then
                            ListView1.Items.Add("Not a Jar", x)
                        End If
                    End If
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(t(x))
                    Dim r1 = My.Computer.FileSystem.GetFileInfo(t(x)).Length
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(Str(Int((r1 / 1024))) + "KB")
                    'ListView1.Refresh()
                    ToolStripProgressBar1.Value = 100
                    ToolStripProgressBar2.Value = ToolStripProgressBar2.Value + jd
                End If
                endd("$JEE163.tmp")
                On Error Resume Next
                ChDir(My.Application.Info.DirectoryPath)
                My.Computer.FileSystem.DeleteDirectory(JJE.Rolddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Me.Refresh()
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", Nothing) = "1" Then
                    qtx = qtx + t(x) + vbCrLf
                    regyh("0")
                End If
                regrun("0")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "HX", Nothing) = "1" Then
                    MsgBox("唤醒成功！！！", MsgBoxStyle.Information, "唤醒命令！")
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "HX", "0")
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", Nothing) = "1" Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "0")
                    MsgBox("显示已中止！！！", MsgBoxStyle.Exclamation, "中止！！！")
                    GoTo e
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "NG", Str(x))
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", Str(t.Count - 1))
            Next
            If qtx <> "" Then
                MsgBox(qtx + "可能已损坏！", MsgBoxStyle.Exclamation, "发生解压错误！！！")
            End If
e:          ToolStripProgressBar2.Value = 100
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "0")
        End If
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
    End Sub
    Private Sub 列表ToolStripMenuItem_Click() Handles 列表ToolStripMenuItem.Click
        ListView1.View = View.Details
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    Private Sub 视图ToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles 视图ToolStripMenuItem.MouseMove
        If ListView1.View = View.LargeIcon Then
            图标ToolStripMenuItem.Checked = True
            列表ToolStripMenuItem.Checked = False
        Else
            图标ToolStripMenuItem.Checked = False
            列表ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function getDiv()
        On Error Resume Next
        Dim y = My.Computer.FileSystem.Drives.ToList
        For k = 0 To y.Count - 1
            TreeView1.Nodes.Add(y(k).RootDirectory.ToString)
        Next
    End Function
    Private Sub JE_FormClosing() Handles Me.FormClosing
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "End", "1")
    End Sub
    Private Sub JE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "0")
        On Error Resume Next
        getDiv()
        ToolStripComboBox1.Text = ""
        ToolStripComboBox1.Width = Me.Width * 0.8
        ToolStripStatusLabel3.Width = Me.Width * 0.56
        regyh("0")
        Shell(My.Application.Info.DirectoryPath + "\WaitStop.exe", AppWinStyle.Hide, False)
        If Command.Trim <> "" Then
            If My.Computer.FileSystem.FileExists(Command.Trim.Replace(TextBox1.Text, "")) = True Then
                di(Command.Trim.Replace(TextBox1.Text, ""))
            Else
                fir = 0
                ToolStripComboBox1.Text = Command().Replace(TextBox1.Text, "")
                Addfile()
            End If
        End If
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Plan", Nothing)
        If r1 = 1 Then
            独项读法ToolStripMenuItem.Checked = False
            启动读法ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function getfiles()
        On Error Resume Next
        TreeView1.SelectedNode.Nodes.Clear()
        Dim h = My.Computer.FileSystem.GetDirectories(TreeView1.SelectedNode.FullPath)
        For k = 0 To h.Count - 1
            TreeView1.SelectedNode.Nodes.Add(TreeView1.SelectedNode.Text, getDic(h(k).ToString), 1)
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
    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If fir <> 0 Then
            ToolStripComboBox1.Text = TreeView1.SelectedNode.FullPath.Replace("\\", "\")
            addfile()
        End If
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        getfiles()
    End Sub
    Private Sub ListView1_MouseDoubleClick() Handles ListView1.MouseDoubleClick
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        If r1 <> "" Then
            runer = r1
        Else
            runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        End If
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(runer + " " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 显示ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示ToolStripMenuItem.Click
        AddJar()
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
            My.Computer.FileSystem.DeleteDirectory(TreeView1.SelectedNode.FullPath.Replace("\\", "\"), FileIO.DeleteDirectoryOption.DeleteAllContents)
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
    Private Sub 复制到ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制到ToolStripMenuItem1.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                For x = 0 To ListView1.SelectedItems.Count - 1
                    On Error GoTo q
                    My.Computer.FileSystem.CopyFile((ListView1.SelectedItems.Item(x).SubItems(1).Text), .SelectedPath + "\" + getname(ListView1.SelectedItems.Item(x).SubItems(1).Text), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                Next
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
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
    Private Sub 移动到ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移动到ToolStripMenuItem1.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                For x = 0 To ListView1.SelectedItems.Count - 1
                    On Error GoTo q
                    My.Computer.FileSystem.MoveFile((ListView1.SelectedItems.Item(0).SubItems(1).Text), .SelectedPath + "\" + getname(ListView1.SelectedItems.Item(0).SubItems(1).Text), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                    ListView1.Items.Remove((ListView1.SelectedItems.Item(0)))
                Next
                MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
            End If
        End With
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 删除ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem1.Click
        If MsgBox("是否删除选择的文件?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For x = 0 To ListView1.SelectedItems.Count - 1
                On Error GoTo q
                If My.Computer.FileSystem.FileExists(ListView1.SelectedItems.Item(0).SubItems(1).Text) = True Then
                    My.Computer.FileSystem.DeleteFile(ListView1.SelectedItems.Item(0).SubItems(1).Text)
                End If
              ListView1.Items.Remove((ListView1.SelectedItems.Item(0)))
            Next
            MsgBox("Success！！！", MsgBoxStyle.Information, "Information")
        End If
        Exit Sub
q:      MsgBox("Error！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 属性ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 属性ToolStripMenuItem.Click
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + "Mini JE.exe") = False Then
            regrun("1")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
            Dim qb = JJE.JJ(TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, 3, TextBox1.Text)
            regrun("0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
            MsgBox(qb, MsgBoxStyle.OkOnly, ListView1.SelectedItems.Item(0).Text + "属性")
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(JJE.Rolddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Me.Refresh()
        Else
            Shell(My.Application.Info.DirectoryPath + "\" + "Mini JE.exe F " + TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
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
    End Function
    Function C2cls(ByVal TF As Boolean)
        On Error Resume Next
        复制到ToolStripMenuItem1.Visible = TF
        移动到ToolStripMenuItem1.Visible = TF
        删除ToolStripMenuItem1.Visible = TF
    End Function
    Function c2dcls(ByVal TF As Boolean)
        On Error Resume Next
        运行ToolStripMenuItem.Visible = TF
        修改ToolStripMenuItem.Visible = TF
        修改ToolStripMenuItem2.Visible = TF
        文件名更改ToolStripMenuItem.Visible = TF
        属性ToolStripMenuItem.Visible = TF
        打开方式ToolStripMenuItem.Visible = TF
        If ListView1.SelectedItems.Count > 1 Then
            修改ToolStripMenuItem.Enabled = False
            修改ToolStripMenuItem2.Enabled = False
            文件名更改ToolStripMenuItem.Visible = True
        Else
            If ListView1.SelectedItems.Count <> 0 Then
                修改ToolStripMenuItem.Enabled = True
                修改ToolStripMenuItem2.Enabled = True
                文件名更改ToolStripMenuItem.Visible = True
            End If
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
            TreeView2.SelectedNode.Nodes.Add(TreeView2.SelectedNode.Text, getDic(h(k).ToString), 1)
            TreeView2.SelectedNode.Expand()
        Next
    End Function
    Function Addfile()
        On Error Resume Next
        PictureBox1.Image = Nothing
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
    End Function
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        addfile()
    End Sub
    Private Sub ContextMenuStrip2_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
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
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        If My.Computer.FileSystem.FileExists(r1) = True Or r1 = "" Then
            运行ToolStripMenuItem.Enabled = True
        Else
            运行ToolStripMenuItem.Enabled = False
        End If
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems.Count <= 1 Then
                查看ToolStripMenuItem.Visible = True
            Else
                查看ToolStripMenuItem.Visible = False
            End If
        Else
            查看ToolStripMenuItem.Visible = False
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
    Private Sub TreeView2_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterSelect
        On Error Resume Next
        If Command() = "" Then
            fir = 1
        End If
        If fir <> 0 Then
            Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
            Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
            If TreeView2.SelectedNode.FullPath.Remove(Len("My Documents")) = "My Documents" Then
                ToolStripComboBox1.Text = (y + TreeView2.SelectedNode.FullPath.Remove(0, Len("My Documents")))
                addfile()
            End If
            If TreeView2.SelectedNode.FullPath.Remove(Len("Desktop")) = "Desktop" Then
                ToolStripComboBox1.Text = (u + TreeView2.SelectedNode.FullPath.Remove(0, Len("Desktop")))
                addfile()
            End If
        End If
        fir = 1
    End Sub
    Private Sub TreeView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView2.DoubleClick
        getfile2()
    End Sub
    Private Sub 显示ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示ToolStripMenuItem1.Click
        AddJar()
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
                'Dim ee As Boolean
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
            My.Computer.FileSystem.DeleteDirectory(gee.Replace("\\", "\"), FileIO.DeleteDirectoryOption.DeleteAllContents)
            TreeView1.Nodes.Remove(TreeView2.SelectedNode)
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
        On Error Resume Next
        PictureBox1.Image = Nothing
        Label1.Text = ""
        ToolStripStatusLabel3.Text = ""
        If ListView1.SelectedItems.Count = 1 Then
            修改ToolStripMenuItem1.Enabled = True
            文件名更改ToolStripMenuItem1.Enabled = True
            If ListView1.LargeImageList Is ImageList4 Then
                PictureBox1.Image = ImageList4.Images.Item(0)
            Else
                PictureBox1.Image = ImageList1.Images.Item(ListView1.SelectedItems.Item(0).ImageIndex)
            End If
            Label1.Text = "名称和版本号:" + ListView1.SelectedItems.Item(0).Text + vbCrLf + "路径:" + ListView1.SelectedItems.Item(0).SubItems(1).Text + vbCrLf + "大小:" + (ListView1.SelectedItems.Item(0).SubItems(2).Text)
            ToolStripStatusLabel3.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
        Else
            修改ToolStripMenuItem1.Enabled = False
            文件名更改ToolStripMenuItem1.Enabled = False
        End If
        If ListView1.SelectedItems.Count > 1 Then
            PictureBox1.Image = ImageList3.Images.Item(3)
            Label1.Text = "已选择:" + Str(ListView1.SelectedItems.Count) + vbCrLf + "总文件数:" + Str(ListView1.Items.Count)
        End If
    End Sub
    Private Sub 图标ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图标ToolStripMenuItem1.Click
        图标ToolStripMenuItem_Click()
    End Sub
    Private Sub 列表ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 列表ToolStripMenuItem1.Click
        列表ToolStripMenuItem_Click()
    End Sub
    Private Sub 显示方式ToolStripMenuItem1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles 显示方式ToolStripMenuItem1.MouseMove
        If ListView1.View = View.LargeIcon Then
            图标ToolStripMenuItem1.Checked = True
            列表ToolStripMenuItem1.Checked = False
        Else
            图标ToolStripMenuItem1.Checked = False
            列表ToolStripMenuItem1.Checked = True
        End If
    End Sub
    Private Sub JarSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JarSettingToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub JE_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ToolStripComboBox1.Width = Me.Width * 0.8
        ToolStripStatusLabel3.Width = Me.Width * 0.56
    End Sub
    Private Sub 重刷ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重刷ToolStripMenuItem.Click
        addfile()
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
        MsgBox("作者:关镇涛" + vbCrLf + "现读于广东省开平市第一中学", MsgBoxStyle.Information, "关于作者！")
    End Sub
    Private Sub 捐款支持ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 捐款支持ToolStripMenuItem.Click
        MsgBox("编程不是一件简单的事." + vbCrLf + "呕心沥血编出来,欲使大家笑开颜！" + vbCrLf + "千呼万唤感恩心,捐款支持动起来！" + vbCrLf + "中国建设银行:" + vbCrLf + "卡号:6227 0031 2601 0025 966" + vbCrLf + "谢谢大家！！", MsgBoxStyle.Information, "关于捐款支持！")
    End Sub
    Private Sub 产品ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 产品ToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub 编辑ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.DropDownOpening
        If ListView1.SelectedItems.Count <> 0 Then
            etf()
            If ListView1.SelectedItems.Count > 1 Then
                查看ToolStripMenuItem1.Enabled = False
                修改ToolStripMenuItem1.Enabled = False
                文件名更改ToolStripMenuItem1.Enabled = True
            End If
        Else
            查看ToolStripMenuItem1.Enabled = False
            修改ToolStripMenuItem1.Enabled = False
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
            查看ToolStripMenuItem.Enabled = False
            查看ToolStripMenuItem1.Enabled = False
            JarSettingToolStripMenuItem.Enabled = False
        Else
            查看ToolStripMenuItem.Enabled = True
            查看ToolStripMenuItem1.Enabled = True
            修改ToolStripMenuItem.Enabled = True
            修改ToolStripMenuItem1.Enabled = True
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
    End Function
    Private Sub 设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设置ToolStripMenuItem.Click
        Me.Hide()
        RunSet.ShowDialog()
        Me.Show()
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
        If ToolStripComboBox1.Text <> "" Then
            Me.Hide()
            Shell(My.Application.Info.DirectoryPath + "\" + "Mini JE.exe D " + TextBox1.Text + ToolStripComboBox1.Text + TextBox1.Text, AppWinStyle.NormalFocus, True)
            Me.Show()
        End If
    End Sub
    Private Sub MiniJEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniJEToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\" + "Mini JE.exe", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub 保存列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存列表ToolStripMenuItem.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "*.Jal列表文件|*.Jal"
            .ShowDialog()
            If .FileName <> "" Then
                bi(.FileName)
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
        JJE.obb("wj", dd, TextBox1.Text)
        Exit Function
l:      MsgBox("Failed！", MsgBoxStyle.Exclamation)
    End Function
    Private Sub 导入列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导入列表ToolStripMenuItem.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.Jal列表文件|*.Jal"
            .ShowDialog()
            If .FileName <> "" Then
                di(.FileName)
            End If
        End With
    End Sub
    Function di(ByVal str As String)
        On Error Resume Next
        Dim ddc As String = JJE.odd(str, TextBox1.Text)
        Dim Aero = XDocument.Load(ddc + "\Aero.xml")
        ListView1.Items.Clear()
        ListView1.LargeImageList = ImageList1
        ListView1.SmallImageList = ImageList2
        ToolStripComboBox1.Text = Aero.<Aero>.<Tile>.Value
        ImageList1.Images.Clear()
        ImageList2.Images.Clear()
        For x = 0 To CInt(Aero.<Aero>.<FileNum>.Value) - 1
            Dim yb = New PictureBox
            yb.WaitOnLoad = True
            yb.ErrorImage = Nothing
            yb.Image = Nothing
            yb.ImageLocation = ddc + "\" + Aero.<Aero>.<Files>.<File>(x).<Pic>.Value.Replace("*\*/*", "&")
            ImageList1.Images.Add(yb.Image)
            ImageList2.Images.Add(yb.Image)
            Dim knn As String = Aero.<Aero>.<Files>.<File>(x).<Name>.Value.Replace("*\*/*", "&")
            Dim kpp As String = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&")
            Dim kss As String = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&")
            ListView1.Items.Add(knn, x)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
        Next
        MsgBox("添加" + Aero.<Aero>.<FileNum>.Value + "个文件！", MsgBoxStyle.Information)
        On Error Resume Next
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(ddc, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Private Sub 打开方式ToolStripMenuItem_Click() Handles 打开方式ToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim ke = ListView1.SelectedItems.Item(0).SubItems(1).Text
            If My.Computer.FileSystem.FileExists(ke) = True Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ke, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        JJM.run(TextBox1.Text, TextBox2.Text, TextBox3.Text, ToolStripComboBox1.Text, 独项读法ToolStripMenuItem.Checked)
    End Sub
End Class