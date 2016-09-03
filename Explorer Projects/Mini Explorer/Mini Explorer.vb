Option Explicit On
Imports System.IO
Imports System.Globalization
Public Class Mini_Explorer
    Dim f As Integer
    Dim g As Integer
    Dim y = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Personal", Nothing)
    Dim u = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", Nothing)
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon1.Icon = Nothing
    End Sub
    Private Sub Form1_Load() Handles MyBase.Load
        tp()
        vh(False)
        Timer3.Enabled = True
        b()
        treeMain.Nodes.Clear()
        PopulateTreeView(u)
        PopulateTreeView(y)
        Dim drives() As DriveInfo = DriveInfo.GetDrives()
        Dim myComputer As TreeNode = treeMain.Nodes.Add("My Computer")
        For Each d As DriveInfo In drives
            Dim topNode As TreeNode = myComputer.Nodes.Add(GetNameAndType(d))
            topNode.Tag = d.Name
            topNode.ImageIndex = GetDriveIndex(d)
            topNode.SelectedImageIndex = topNode.ImageIndex
            If d.IsReady Then
                AddSubNodes(topNode, d.Name, True)
            End If
        Next
        If treeMain.Nodes.Count > 0 Then
            treeMain.SelectedNode = treeMain.Nodes(0)
            If Not treeMain.SelectedNode Is Nothing Then
                treeMain.SelectedNode.Expand()
            End If
        End If
    End Sub
    Private Sub PopulateTreeView(ByVal L As String)
        Dim rootNode As TreeNode
        Dim info As New DirectoryInfo(L)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            treeMain.Nodes.Add(rootNode)
        End If
    End Sub
    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, _
        ByVal nodeToAddTo As TreeNode)
        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir
    End Sub
    Private Sub AddSubNodes(ByVal node As TreeNode, ByVal dirName As String, ByVal iterate As Boolean)
        Try
            For Each dir As String In Directory.GetDirectories(dirName)
                Dim found As Boolean
                For Each tn As TreeNode In node.Nodes
                    If tn.Text = dir.Substring(dir.LastIndexOf("\") + 1) Then
                        found = True
                        Exit For
                    End If
                Next
                If Not found Then
                    Dim subNode As TreeNode = node.Nodes.Add(dir.Substring(dir.LastIndexOf("\") + 1))
                    subNode.ImageIndex = 4
                    subNode.SelectedImageIndex = 4
                    subNode.Tag = dir
                    If iterate Then
                        AddSubNodes(subNode, dir, False)
                    End If
                End If
            Next
        Catch uae As UnauthorizedAccessException
        Finally
        End Try
    End Sub
    Public Function GetDriveIndex(ByVal d As DriveInfo) As Integer
        Select Case d.DriveType
            Case DriveType.Removable
                Return 2
            Case DriveType.CDRom
                Return 0
            Case DriveType.Fixed
                Return 5
            Case DriveType.Network
                Return 7
        End Select
        Return 5
    End Function
    Public Function GetNameAndType(ByVal d As DriveInfo) As String
        Return String.Format(CultureInfo.CurrentCulture, "{0} {1}", GetDriveType(d, False), d.Name.Substring(0, 2))
    End Function
    Public Function GetDriveType(ByVal d As DriveInfo, ByVal network As Boolean) As String
        Dim typeName As String
        Select Case d.DriveType
            Case DriveType.Removable
                typeName = ""
            Case DriveType.CDRom
                typeName = ""
            Case DriveType.Fixed
                typeName = ""
            Case DriveType.Network
                If Not network Then
                    typeName = ""
                Else
                    typeName = ""
                End If
            Case Else
                typeName = ""
        End Select
        Return typeName
    End Function
    Private Sub treeMain_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeMain.AfterExpand
        On Error Resume Next
        If Not e.Node.Parent Is Nothing Then
            For Each tn As TreeNode In e.Node.Nodes
                AddSubNodes(tn, tn.Tag.ToString(), False)
            Next
        End If
    End Sub
    Private Sub treeMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeMain.AfterSelect
        Dim w As Integer = treeMain.Nodes(0).Text.Length
        Dim k As Integer = treeMain.Nodes(1).Text.Length
        Dim ki As String
        On Error Resume Next
        treeMain.SelectedNode.Expand()
        If treeMain.SelectedNode.FullPath = "My Computer" Then
            TextBox1.Text = ""
            新建文件夹ToolStripMenuItem.Visible = False
            File1.Visible = False
        Else
            新建文件夹ToolStripMenuItem.Visible = True
        End If
        ki = treeMain.SelectedNode.FullPath.Remove(0, 12)
        TextBox1.Text = ki.Trim + "\"
        ToolStripStatusLabel1.Text = ""
        If treeMain.SelectedNode.Text = treeMain.Nodes.Item(1).Text.Remove(k - 1) + treeMain.Nodes.Item(1).Text(k - 1) Then
            TextBox1.Text = y
        End If
        If treeMain.SelectedNode.FullPath.Remove(k - 1) + treeMain.Nodes.Item(1).Text(k - 1) = treeMain.Nodes.Item(1).Text.Remove(k - 1) + treeMain.Nodes.Item(1).Text(k - 1) Then
            ki = treeMain.SelectedNode.FullPath.Remove(0, k)
            TextBox1.Text = y + ki.Trim + "\"
        End If
        If treeMain.SelectedNode.Text = treeMain.Nodes.Item(0).Text.Remove(w - 1) + treeMain.Nodes.Item(0).Text(w - 1) Then
            TextBox1.Text = u
        End If
        If treeMain.SelectedNode.FullPath.Remove(w - 1) + treeMain.Nodes.Item(0).Text(w - 1) = treeMain.Nodes.Item(0).Text.Remove(w - 1) + treeMain.Nodes.Item(0).Text(w - 1) Then
            ki = treeMain.SelectedNode.FullPath.Remove(0, w)
            TextBox1.Text = u + ki.Trim + "\"
        End If
        p1(False)
        If TextBox1.TextLength > 3 Then
            p2(True)
        Else
            p2(False)
        End If
        刷新ToolStripMenuItem_Click()
    End Sub
    Private Sub File1_DoubleClick() Handles File1.DoubleClick
        On Error GoTo t
        Me.ToolStripProgressBar1.Value = 0
        Timer2.Enabled = True
        Shell(TextBox5.Text + TextBox1.Text + File1.FileName + TextBox5.Text, AppWinStyle.NormalFocus)
        Me.ToolStripProgressBar1.Value = 100
        Exit Sub
t:      Open.ShowDialog()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        On Error GoTo t
        File1.Visible = True
        File1.Path = TextBox1.Text
        Exit Sub
t:      File1.Visible = False
    End Sub
    Private Sub VScrollBar1_ChangeUICues() Handles VScrollBar1.ChangeUICues
        On Error GoTo u
        VScrollBar1.Maximum = PictureBox1.Height - 78
        PictureBox1.Top = -VScrollBar1.Value
        Exit Sub
u:      File1_SelectedValueChanged()
    End Sub
    Private Sub VScrollBar1_Scroll() Handles VScrollBar1.Scroll
        VScrollBar1_ChangeUICues()
    End Sub
    Private Sub HScrollBar1_ChangeUICues() Handles HScrollBar1.ChangeUICues
        On Error GoTo u
        HScrollBar1.Maximum = PictureBox1.Width - 143
        PictureBox1.Left = -HScrollBar1.Value
        Exit Sub
u:      File1_SelectedValueChanged()
    End Sub
    Private Sub HScrollBar1_Scroll() Handles HScrollBar1.Scroll
        HScrollBar1_ChangeUICues()
    End Sub
    Private Sub TrackBar1_ChangeUICues() Handles TrackBar1.ChangeUICues
        On Error Resume Next
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If f > TabControl1.Height Or g > TabControl1.Width Then
            vh(True)
            PictureBox1.Height = f * (TrackBar1.Value / 10)
            PictureBox1.Width = g * (TrackBar1.Value / 10)
            If TrackBar1.Value = "0" Then
                PictureBox1.Height = f * (1 / 10)
                PictureBox1.Width = g * (1 / 10)
            End If
        Else
            vh(False)
            PictureBox1.Height = f * (TrackBar1.Value * 5)
            PictureBox1.Width = g * (TrackBar1.Value * 5)
            If TrackBar1.Value = "0" Then
                PictureBox1.Height = f
                PictureBox1.Width = g
            End If
        End If
        If PictureBox1.Height > TabControl1.Height Or PictureBox1.Width > TabControl1.Width Then
            vh(True)
        Else
            vh(False)
        End If
        b()
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        TrackBar1_ChangeUICues()
    End Sub
    Private Sub File1_SelectedValueChanged() Handles File1.SelectedValueChanged
        On Error Resume Next
        If File1.SelectedItem Is Nothing Then
            p1(False)
        Else
            ToolStripStatusLabel1.DropDownItems.Clear()
            ToolStripStatusLabel1.DropDownItems.Add(TextBox1.Text + File1.FileName)
            ToolStripStatusLabel1.Text = TextBox1.Text + File1.FileName
            p1(True)
        End If
        TabPage1.Text = File1.FileName
        TrackBar1.Value = 0
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.ImageLocation = TextBox1.Text + File1.FileName
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        b()
        f = PictureBox1.Image.Height
        g = PictureBox1.Image.Width
        If f < TabControl1.Height And g < TabControl1.Width Then
            vh(False)
        Else
            vh(True)
        End If
       Timer1.Enabled = False
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.ToolStripProgressBar1.Value < 98 Then
            Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Value + 20
        Else
        End If
    End Sub
    Private Sub 预览栏ToolStripMenuItem_Click() Handles 预览栏ToolStripMenuItem.Click
        vh(False)
        Me.Width = 489
        Timer1.Enabled = True
        Me.Left = Me.Left - ((489 - 298) / 2)
        ToolStripStatusLabel1.Width = 277
        预览栏ToolStripMenuItem.Visible = False
        yl(False, True)
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Label1.Text = Hour(Now)
        Me.Label2.Text = Minute(Now)
        Me.Label3.Text = Second(Now)
        Me.ToolStripStatusLabel2.Text = Me.Label1.Text + ":" + Label2.Text + ":" + Label3.Text
    End Sub
    Private Sub 隐藏预览栏ToolStripMenuItem_Click() Handles 隐藏预览栏ToolStripMenuItem.Click
        vh(False)
        Me.Width = 298
        Me.Left = Me.Left + ((489 - 298) / 2)
        ToolStripStatusLabel1.Width = 92
        yl(True, False)
    End Sub
    Private Sub 隐藏预览栏ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 隐藏预览栏ToolStripMenuItem1.Click
        隐藏预览栏ToolStripMenuItem_Click()
    End Sub
    Private Sub 显示预览栏ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 显示预览栏ToolStripMenuItem.Click
        预览栏ToolStripMenuItem_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        On Error GoTo o
        File1.Pattern = ToolStripTextBox1.Text
        If ToolStripTextBox1.Text = "" Then
            ToolStripTextBox1.Text = "*.*"
            File1.Pattern = "*.*"
        End If
        Exit Sub
o:      File1.Pattern = "*.*"
        ToolStripTextBox1.Text = "*.*"
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        MsgBox("Mini Explorer By Gzt In 2008", MsgBoxStyle.Information, "Abort")
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click() Handles 刷新ToolStripMenuItem.Click
        tp()
        p1(False)
    End Sub
    Private Sub 复制ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem.Click
        Me.FolderBrowserDialog1.ShowDialog()
        If Me.FolderBrowserDialog1.SelectedPath <> "" Then
            On Error GoTo p
            Dim i
            Dim o
            i = Me.ToolStripStatusLabel1.Text
            o = Me.FolderBrowserDialog1.SelectedPath + "\" + File1.SelectedItem
            Me.ToolStripProgressBar1.Value = 0
            Timer2.Enabled = True
            FileCopy(i, o)
            Me.ToolStripProgressBar1.Value = 100
            tp()
        End If
        Exit Sub
p:      MsgBox("Copy File Failed！！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 剪切ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪切ToolStripMenuItem.Click
        Me.FolderBrowserDialog1.ShowDialog()
        If Me.FolderBrowserDialog1.SelectedPath <> "" Then
            On Error GoTo p
            Dim i
            Dim o
            i = Me.ToolStripStatusLabel1.Text
            o = Me.FolderBrowserDialog1.SelectedPath + "\" + File1.SelectedItem
            Me.ToolStripProgressBar1.Value = 0
            Timer2.Enabled = True
            FileCopy(i, o)
            Kill(i)
            Me.ToolStripProgressBar1.Value = 100
            tp()
        End If
        Exit Sub
p:      MsgBox("Cut File Failed！！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        On Error GoTo i
        If MsgBox("删除文件放入回收站？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteFile(ToolStripStatusLabel1.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Form1_Load()
        Else
            My.Computer.FileSystem.DeleteFile(ToolStripStatusLabel1.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            tp()
        End If
        p1(False)
        Exit Sub
i:      MsgBox("Delete File Failed！！！", MsgBoxStyle.Exclamation, "Error")
    End Sub
    Private Sub 新建ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem.Click
        On Error GoTo o
        Dim y
        y = InputBox("请输入新建文件的名称和扩展名", "新建文件", , , )
        FileOpen(1, TextBox1.Text + y, OpenMode.Output, OpenAccess.Default, OpenShare.Shared, )
        FileClose()
        tp()
        Exit Sub
o:      MsgBox("新建文件失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub 刷新ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem1.Click
        Form1_Load()
    End Sub
    Private Sub 删除全部ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除全部ToolStripMenuItem.Click
        If MsgBox("确定删除全部？", MsgBoxStyle.YesNo, ) = MsgBoxResult.Yes Then
            On Error GoTo i
            Kill(TextBox1.Text + "*.*")
            tp()
        End If
        Exit Sub
i:      MsgBox("Delete File Failed！！！", MsgBoxStyle.Exclamation, "Error")
        p1(False)
    End Sub
    Private Sub 新建文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建文件夹ToolStripMenuItem.Click
        On Error GoTo o
        My.Computer.FileSystem.CreateDirectory(TextBox1.Text + InputBox("请输入新建文件夹的名称", "新建文件夹"))
        Form1_Load()
        Exit Sub
o:      MsgBox("新建文件夹失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub 复制文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制文件夹ToolStripMenuItem.Click
        On Error GoTo o
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            My.Computer.FileSystem.CopyDirectory(TextBox1.Text.TrimEnd("\"), FolderBrowserDialog1.SelectedPath + "\" + treeMain.SelectedNode.Text)
            Form1_Load()
        End If
        Exit Sub
o:      MsgBox("复制文件夹失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub 移动文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移动文件夹ToolStripMenuItem.Click
        On Error GoTo o
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            My.Computer.FileSystem.MoveDirectory(TextBox1.Text.TrimEnd("\"), FolderBrowserDialog1.SelectedPath + "\" + treeMain.SelectedNode.Text)
            Form1_Load()
        End If
        Exit Sub
o:      MsgBox("移动文件夹失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub 重命名文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重命名文件夹ToolStripMenuItem.Click
        On Error GoTo o
        My.Computer.FileSystem.RenameDirectory(TextBox1.Text.TrimEnd("\"), InputBox("请输入新名称："))
        Form1_Load()
        Exit Sub
o:      MsgBox("重命名文件夹失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub 删除文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除文件夹ToolStripMenuItem.Click
        On Error GoTo o
        If MsgBox("删除文件放入回收站", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(TextBox1.Text.TrimEnd("\"), FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Form1_Load()
        Else
            My.Computer.FileSystem.DeleteDirectory(TextBox1.Text.TrimEnd("\"), FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            Form1_Load()
        End If
        Exit Sub
o:      MsgBox("删除文件夹失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub
    Private Sub 还原ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 还原ToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
            hy(True, False)
        End If
    End Sub
    Private Sub 隐藏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 隐藏ToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
            hy(False, True)
        End If
    End Sub
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        If Me.WindowState = FormWindowState.Normal Then
            hy(True, False)
        Else
            hy(False, True)
        End If
    End Sub
    Private Sub 刷新ToolStripMenuItem2_Click() Handles 刷新ToolStripMenuItem2.Click
        Form1_Load()
    End Sub
    Private Sub 退出ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem1.Click
        Me.NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
            hy(True, False)
        End If
    End Sub
    Private Sub 重命名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重命名ToolStripMenuItem.Click
        On Error GoTo o
        My.Computer.FileSystem.RenameFile(TextBox1.Text + File1.SelectedItem, InputBox("请输入新名称："))
        tp()
        Exit Sub
o:      MsgBox("重命名文件失败", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub ToolStripStatusLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.DropDown.Show()
    End Sub
    Private Sub ToolStripStatusLabel1_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripStatusLabel1.DropDownItemClicked
        If ToolStripStatusLabel1.Text <> "" Then
            File1_DoubleClick()
        End If
    End Sub
    Public Function tp()
        File1.Refresh()
        TabPage1.Text = ""
        ToolStripStatusLabel1.Text = ""
        ToolStripStatusLabel1.DropDownItems.Clear()
        PictureBox1.Image = Nothing
        vh(False)
        TrackBar1.Value = 0
        b()
    End Function
    Public Function p1(ByVal r As Boolean)
        Me.复制ToolStripMenuItem.Visible = r
        Me.剪切ToolStripMenuItem.Visible = r
        Me.删除ToolStripMenuItem.Visible = r
        Me.重命名ToolStripMenuItem.Visible = r
    End Function
    Public Function p2(ByVal r As Boolean)
        复制文件夹ToolStripMenuItem.Visible = r
        移动文件夹ToolStripMenuItem.Visible = r
        重命名文件夹ToolStripMenuItem.Visible = r
        删除文件夹ToolStripMenuItem.Visible = r
    End Function
    Public Function vh(ByVal r As Boolean)
        VScrollBar1.Visible = r
        HScrollBar1.Visible = r
    End Function
    Public Function hy(ByVal r As Boolean, ByVal l As Boolean)
        隐藏ToolStripMenuItem.Visible = r
        还原ToolStripMenuItem.Visible = l
    End Function
    Public Function yl(ByVal r As Boolean, ByVal l As Boolean)
        预览栏ToolStripMenuItem.Visible = r
        显示预览栏ToolStripMenuItem.Visible = r
        隐藏预览栏ToolStripMenuItem1.Visible = l
        隐藏预览栏ToolStripMenuItem.Visible = l
    End Function
    Public Function b()
        VScrollBar1.Minimum = 0
        VScrollBar1.Value = 0
        HScrollBar1.Minimum = 0
        HScrollBar1.Value = 0
        HScrollBar1_Scroll()
        VScrollBar1_Scroll()
        PictureBox1.Top = 0
        PictureBox1.Left = 0
    End Function
End Class