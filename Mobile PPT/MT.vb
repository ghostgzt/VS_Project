Imports System.Runtime.InteropServices
Public Class MT
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
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            Dim bbint As Integer = 0
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                If i = 0 Then sFirstFileName = sb.ToString
                If My.Computer.FileSystem.FileExists(sb.ToString) = True Then
                    Dim gg As String = gnn.getname(sb.ToString.Trim, ".", False)
                    If gg.ToLower = "ppt" Then
                        Dim sq As Integer = 0
                        For xt = 0 To ListView1.Items.Count - 1
                            If sb.ToString = ListView1.Items.Item(xt).SubItems(1).Text Then
                                sq = 1
                            End If
                        Next
                        If sq = 0 Then
                            ListView1.Items.Add(gnn.getname(sb.ToString, "\", False), 0)
                            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sb.ToString)
                            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        End If
                       bbint = bbint + 1
                    End If
                End If
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.ppt")
                    For qq = 0 To tt.count - 1
                        Dim sq As Integer = 0
                        For xt = 0 To ListView1.Items.Count - 1
                            If tt(qq) = ListView1.Items.Item(xt).SubItems(1).Text Then
                                sq = 1
                            End If
                        Next
                        If sq = 0 Then
                            ListView1.Items.Add(gnn.getname(tt(qq), "\", False), 0)
                            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(tt(qq))
                            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        End If
                       bbint = bbint + 1
                    Next
                End If
            Next
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Dim Pic1 As New Pic_Format_Convert.Pic
    Dim NPPT As New PPT_Expand_Worker.PPT
    Dim gnn As New GN
    Dim se As Integer
    Private Sub MT_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        savereg()
        NotifyIcon1.Icon = Nothing
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PPT%", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Private Sub MT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripComboBox2.SelectedIndex = 0
        pp = 0
        ComboBox2.Text = "256"
        ImageList1.Images.Add(My.Resources.ppt)
        ImageList2.Images.Add(My.Resources.ppt)
        NotifyIcon1.Icon = Nothing
        Application.AddMessageFilter(Me)
        DragAcceptFiles(ListView1.Handle.ToInt32, True)
        ComboBox1.Text = "WMF"
        If My.Application.CommandLineArgs.Count <> 0 Then
            Dim bbint As Integer = 0
            For t = 0 To My.Application.CommandLineArgs.Count - 1
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim sq As Integer = 0
                    For xt = 0 To ListView1.Items.Count - 1
                        If My.Application.CommandLineArgs.Item(t) = ListView1.Items.Item(xt).SubItems(1).Text Then
                            sq = 1
                        Else
                            sq = 0
                        End If
                    Next
                    If sq = 0 Then
                        ListView1.Items.Add(gnn.getname(My.Application.CommandLineArgs.Item(t), "\", False), 0)
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(My.Application.CommandLineArgs.Item(t))
                        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                    End If
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(t), FileIO.SearchOption.SearchAllSubDirectories, "*.ppt")
                    For qq = 0 To tt.count - 1
                        Dim sq As Integer = 0
                        For xt = 0 To ListView1.Items.Count - 1
                            If tt(qq) = ListView1.Items.Item(xt).SubItems(1).Text Then
                                sq = 1
                            End If
                        Next
                        If sq = 0 Then
                            ListView1.Items.Add(gnn.getname(tt(qq), "\", False), 0)
                            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(tt(qq))
                            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        End If
                        bbint = bbint + 1
                    Next
                End If
            Next
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
        End If
        loadreg()
    End Sub
    Function Run()
        Me.Hide()
        NotifyIcon1.Icon = Me.Icon
        Me.Enabled = False
        On Error Resume Next
        Dim rand As New Random
        Dim t As Integer = rand.Next
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PPT%")
        Dim kt = My.Computer.FileSystem.SpecialDirectories.Temp + "\%PPT%\" + Str(t).Trim
        For x = 0 To ListView1.Items.Count - 1
            NotifyIcon1.Text = "Mobile PTT Making..." + vbCrLf + Str(x + 1) + "/" + Str(ListView1.Items.Count)
            NotifyIcon1.BalloonTipText = "Mobile PTT Making..." + vbCrLf + Str(x + 1) + "/" + Str(ListView1.Items.Count)
            NotifyIcon1.ShowBalloonTip(100)
            Dim uu = ""
            If ComboBox1.Text = "WMF" Then
                NPPT.PPT(ListView1.Items.Item(x).SubItems(1).Text, kt, PowerPoint.PpSaveAsFileType.ppSaveAsMetaFile)
                uu = "*.wmf"
            End If
            If ComboBox1.Text = "EMF" Then
                NPPT.PPT(ListView1.Items.Item(x).SubItems(1).Text, kt, PowerPoint.PpSaveAsFileType.ppSaveAsEMF)
                uu = "*.emf"
            End If
            If ComboBox1.Text = "BMP" Then
                NPPT.PPT(ListView1.Items.Item(x).SubItems(1).Text, kt, PowerPoint.PpSaveAsFileType.ppSaveAsBMP)
                uu = "*.bmp"
            End If
            If ComboBox1.Text = "JPG" Then
                NPPT.PPT(ListView1.Items.Item(x).SubItems(1).Text, kt, PowerPoint.PpSaveAsFileType.ppSaveAsJPG)
                uu = "*.jpg"
            End If
            Shell(My.Application.Info.DirectoryPath + "\GNEasy.exe " + "/XLY " + TextBox2.Text + "幻灯片" + TextBox2.Text + " " + TextBox2.Text + "10" + TextBox2.Text + " " + TextBox2.Text + "0" + TextBox2.Text + " " + TextBox2.Text + kt + TextBox2.Text, AppWinStyle.Hide, True)
            Dim b = My.Computer.FileSystem.GetFiles(kt, FileIO.SearchOption.SearchAllSubDirectories, uu)
            Dim hh = 240
            Dim ww = 320
            If ToolStripComboBox1.Text <> "" Then
                hh = gnn.getname(ToolStripComboBox1.Text, "*", True)
                ww = gnn.getname(ToolStripComboBox1.Text, "*", False)
            End If
            For y = 0 To b.Count - 1
                Dim gss As System.Drawing.Imaging.ImageFormat
                gss = System.Drawing.Imaging.ImageFormat.Png
                If pp = 0 Then
                    gss = System.Drawing.Imaging.ImageFormat.Png
                End If
                If pp = 1 Then
                    gss = System.Drawing.Imaging.ImageFormat.Bmp
                End If
                If pp = 2 Then
                    gss = System.Drawing.Imaging.ImageFormat.Jpeg
                End If
                If pp = 3 Then
                    gss = System.Drawing.Imaging.ImageFormat.Gif
                End If
                If CheckBox1.Checked = True Then
                    Pic1.Run(hh, ww, b(y), gss, False, True, True, True, ToolStripComboBox2.Items.Item(pp).ToString.ToLower)
                Else
                    Pic1.Run(hh, ww, b(y), gss, False, True, False, True, ToolStripComboBox2.Items.Item(pp).ToString.ToLower)
                End If
            Next
            If 减色ToolStripMenuItem.Checked = True Then
                On Error Resume Next
                My.Computer.Registry.CurrentUser.CreateSubKey("software\PCD")
                If CInt(se) >= 1 And CInt(se) <= 7 Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "SE", se)
                Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "SE", CInt(ComboBox2.Text))
                End If
                Shell(My.Application.Info.DirectoryPath + "\PNG Color Down.exe " + "/JS " + TextBox2.Text + kt + TextBox2.Text, AppWinStyle.Hide, True)
            End If
            ChDir(kt)
            Dim i = 0
            Dim n = 0
            Dim ppp As String = ""
            Dim nnn As String = ""
            Do
                If i <> 0 Then
                    ppp = "(" + Str(i).Trim + ")"
                End If
                If My.Computer.FileSystem.FileExists(TextBox1.Text + "\" + gnn.getname(gnn.getname(ListView1.Items.Item(x).SubItems(1).Text, "\", False), ".", True) + ppp + ".Zip") = False Then
                    n = 1
                End If
                i = i + 1
            Loop Until n = 1
            Shell(TextBox2.Text + My.Application.Info.DirectoryPath + "\zip.exe" + TextBox2.Text + " -r " + TextBox2.Text + TextBox1.Text + "\" + gnn.getname(gnn.getname(ListView1.Items.Item(x).SubItems(1).Text, "\", False), ".", True) + ppp + ".Zip" + TextBox2.Text + " " + "*.*", AppWinStyle.Hide, True)
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(kt, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Next
        Me.Enabled = True
        NotifyIcon1.Icon = Nothing
        Me.Show()
        MsgBox("Finished！！！", MsgBoxStyle.Information, "温馨提示！！！")
        Shell("Explorer.exe " + TextBox1.Text, AppWinStyle.NormalFocus)
    End Function
    Private Sub 添加文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文件ToolStripMenuItem.Click
        AddWJ()
    End Sub
    Private Sub 添加目录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加目录ToolStripMenuItem.Click
        AddML()
    End Sub
    Function AddWJ()
        On Error Resume Next
        With OpenFileDialog1
            .FileName = ""
            .Filter = "PPT文档 *.PPT|*.PPT|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        Dim sq As Integer = 0
                        For xt = 0 To ListView1.Items.Count - 1
                            If .FileNames(x) = ListView1.Items.Item(xt).SubItems(1).Text Then
                                sq = 1
                            End If
                        Next
                        If sq = 0 Then
                            ListView1.Items.Add(gnn.getname(.FileNames(x), "\", False), 0)
                            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(.FileNames(x))
                            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        End If
                    Next
                End If
            End If
        End With
    End Function
    Function AddML()
        On Error Resume Next
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有PPT的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.ppt")
                For qq = 0 To tt.count - 1
                    Dim sq As Integer = 0
                    For xt = 0 To ListView1.Items.Count - 1
                        If tt(qq) = ListView1.Items.Item(xt).SubItems(1).Text Then
                            sq = 1
                        End If
                    Next
                    If sq = 0 Then
                        ListView1.Items.Add(gnn.getname(tt(qq), "\", False), 0)
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(tt(qq))
                        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                    End If
                Next
                MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddML()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddWJ()
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        On Error Resume Next
        For x = 0 To ListView1.SelectedItems.Count - 1
            ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
        Next
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView1.Items.Clear()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        On Error Resume Next
        savereg()
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PPT%", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG", FileIO.DeleteDirectoryOption.DeleteAllContents)
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        savereg()
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\%PPT%", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG", FileIO.DeleteDirectoryOption.DeleteAllContents)
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        Button8_Click()
    End Sub
    Private Sub Button8_Click() Handles Button8.Click
        On Error Resume Next
        If ListView1.SelectedItems(0).SubItems(1).Text <> "" Then
            Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ListView1.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .Description = "请选择输出路径:"
            .ShowNewFolderButton = True
            .ShowDialog()
            If .SelectedPath <> "" Then
                TextBox1.Text = .SelectedPath
            End If
        End With
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        If ListView1.Items.Count <> 0 Then
            If TextBox1.Text <> "" Then
                If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = True Then
                    Run()
                Else
                    MsgBox("输出目录不可取！！！", MsgBoxStyle.Exclamation, "敬告！！！")
                    GoTo k
                End If
            Else
                MsgBox("输出目录不为空！！！", MsgBoxStyle.Exclamation, "敬告！！！")
k:              Button5_Click()
            End If
        End If
        Exit Sub
    End Sub
    Private Sub 降色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 降色ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.View = View.Details Then
            列表ToolStripMenuItem.Checked = True
            图标ToolStripMenuItem.Checked = False
        Else
            列表ToolStripMenuItem.Checked = False
            图标ToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub 图标ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图标ToolStripMenuItem.Click
        ListView1.View = View.LargeIcon
    End Sub
    Private Sub 列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 列表ToolStripMenuItem.Click
        ListView1.View = View.Details
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Button8_Click()
    End Sub
    Private Sub 减色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 减色ToolStripMenuItem.Click
        If 减色ToolStripMenuItem.Checked = True Then
            减色ToolStripMenuItem.Checked = False
        Else
            减色ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function loadreg()
        On Error Resume Next
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "TB", Nothing)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "JS", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "DX", Nothing)
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "SC", Nothing)
        Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "XZ", Nothing)
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Mobile PPT", "GS", Nothing)
        Dim r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "SE", Nothing)
        Dim r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "FS", Nothing)
        Dim r8 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "ZGS", Nothing)
        If r0 = "1" Then
            ListView1.View = View.LargeIcon
        Else
            ListView1.View = View.Details
        End If
        If r1 = "0" Then
            减色ToolStripMenuItem.Checked = False
        Else
            减色ToolStripMenuItem.Checked = True
        End If
        If r2 <> "" Then
            ToolStripComboBox1.Text = r2
        Else
            ToolStripComboBox1.Text = "240*320"
        End If
        If r3 <> "" Then
            TextBox1.Text = r3
        Else
            TextBox1.Text = ""
        End If
        If r4 = "0" Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        If r5 <> "" Then
            ComboBox1.Text = r5
        Else
            ComboBox1.Text = "WMF"
        End If
        If Str(r6) = "" Then
            ComboBox2.Text = "256"
        Else
            If CInt(r6) = 1 Then
                ComboBox2.Text = "2色灰"
            Else
                If CInt(r6) = 2 Then
                    ComboBox2.Text = "4色灰"
                Else
                    If CInt(r6) = 3 Then
                        ComboBox2.Text = "256色灰"
                    Else
                        If CInt(r6) = 4 Then
                            ComboBox2.Text = "256色A"
                        Else
                            If CInt(r6) = 5 Then
                                ComboBox2.Text = "256色B"
                            Else
                                If CInt(r6) = 6 Then
                                    ComboBox2.Text = "24位色"
                                Else
                                    If CInt(r6) = 7 Then
                                        ComboBox2.Text = "32位色"
                                    Else
                                        ComboBox2.Text = Str(r6).Trim
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            End If
            If ComboBox2.Text = "" Then
                ComboBox2.Text = "256"
            End If
        End If
        If r7 = "1" Then
            图片反色ToolStripMenuItem.Checked = True
        Else
            图片反色ToolStripMenuItem.Checked = False
        End If
        If r8 <> "" And CInt(r8) <= 3 Then
            pp = CInt(r8)
        Else
            pp = 0
        End If
        If pp <> 0 Then
            减色ToolStripMenuItem.Enabled = False
            图片反色ToolStripMenuItem.Enabled = False
        Else
            减色ToolStripMenuItem.Enabled = True
            图片反色ToolStripMenuItem.Enabled = True
        End If
    End Function
    Function savereg()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Mobile PPT")
        If ListView1.View = View.LargeIcon Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "TB", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "TB", "0")
        End If
        If 减色ToolStripMenuItem.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "JS", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "JS", "0")
        End If
        If ToolStripComboBox1.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "DX", ToolStripComboBox1.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "DX", "240*320")
        End If
        If TextBox1.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "SC", TextBox1.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "SC", "")
        End If
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "XZ", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "XZ", "0")
        End If
        If ComboBox1.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "GS", ComboBox1.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "GS", "WMF")
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Mobile PPT", "ZGS", pp)
    End Function
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <> "" Then
            With ComboBox2
                If .Text = "2" Then
                    se = 10
                End If
                If .Text = "3" Then
                    se = 11
                End If
                If .Text = "4" Then
                    se = 12
                End If
                If .Text = "5" Then
                    se = 13
                End If
                If .Text = "6" Then
                    se = 14
                End If
                If .Text = "7" Then
                    se = 15
                End If
                If .Text = "8" Then
                    se = 16
                End If
                If .Text = "10" Then
                    se = 17
                End If
                If .Text = "12" Then
                    se = 18
                End If
                If .Text = "14" Then
                    se = 19
                End If
                If .Text = "16" Then
                    se = 20
                End If
                If .Text = "24" Then
                    se = 21
                End If
                If .Text = "32" Then
                    se = 22
                End If
                If .Text = "48" Then
                    se = 23
                End If
                If .Text = "64" Then
                    se = 24
                End If
                If .Text = "128" Then
                    se = 25
                End If
                If .Text = "256" Then
                    se = 26
                End If
                If .Text = "512" Then
                    se = 27
                End If
                If .Text = "2色灰" Then
                    se = 1
                End If
                If .Text = "4色灰" Then
                    se = 2
                End If
                If .Text = "256色灰" Then
                    se = 3
                End If
                If .Text = "256色A" Then
                    se = 4
                End If
                If .Text = "256色B" Then
                    se = 5
                End If
                If .Text = "24位色" Then
                    se = 6
                End If
                If .Text = "32位色" Then
                    se = 7
                End If
            End With
        End If
    End Sub
    Private Sub 图片反色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图片反色ToolStripMenuItem.Click
        If 图片反色ToolStripMenuItem.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "FS", "1")
            图片反色ToolStripMenuItem.Checked = True
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "FS", "0")
            图片反色ToolStripMenuItem.Checked = False
        End If
    End Sub
    Dim pp As Integer
    Private Sub ToolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        With ToolStripComboBox2
            If .SelectedIndex = 0 Then
                pp = 0
                减色ToolStripMenuItem.Enabled = True
                图片反色ToolStripMenuItem.Enabled = True
            Else
                减色ToolStripMenuItem.Enabled = False
                图片反色ToolStripMenuItem.Enabled = False
                If .SelectedIndex = 1 Then
                    pp = 1
                End If
                If .SelectedIndex = 2 Then
                    pp = 2
                End If
                If .SelectedIndex = 3 Then
                    pp = 3
                End If
            End If
        End With
    End Sub
End Class