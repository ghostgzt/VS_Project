Public Class Maker
    Dim Pic1 As New Pic_Format_Convert.Pic
    Dim gnn As New GN
    Dim TL As New TLQ.X
    Dim ll As New ListBox
    Private Sub 输出ToolStripMenuItem_Click() Handles 输出ToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Or ListBox2.Items.Count <> 0 Then
            Me.Hide()
            Me.Enabled = False
            NotifyIcon1.Icon = Me.Icon
            TextBox1.Text = ""
            If 文件夹批量ToolStripMenuItem.Checked = False And ListBox1.Items.Count <> 0 Then
                With SaveFileDialog1
                    .FileName = ""
                    .Filter = "*.Zip|*.Zip|*.*|*.*"
                    .ShowDialog()
                    If .FileName <> "" Then
                        NotifyIcon1.ShowBalloonTip(200, "温馨提示！！！", "Mobile PPT Making...", ToolTipIcon.Info)
                        make(.FileName, ListBox1)
                        MsgBox("Finished！！！", MsgBoxStyle.Information, "温馨提示！！！")
                        Shell("Explorer.exe " + TextBox1.Text, AppWinStyle.NormalFocus)
                    End If
                End With
            Else
                If ListBox2.Items.Count <> 0 Then
                    With FolderBrowserDialog1
                        .SelectedPath = ""
                        .Description = "请选择输出路径:"
                        .ShowNewFolderButton = True
                        .ShowDialog()
                        If .SelectedPath <> "" Then
                            For bs = 0 To ListBox2.Items.Count - 1
                                NotifyIcon1.ShowBalloonTip(200, "温馨提示！！！", "Mobile PPT Making..." + vbCrLf + Str(bs + 1).Trim + "/" + Str(ListBox2.Items.Count).Trim, ToolTipIcon.Info)
                                add(ListBox2.Items.Item(bs), ll)
                                If ll.Items.Count <> 0 Then
                                    Dim sc As String
                                    If ToolStripTextBox1.Text = "" Then
k:                                      sc = gnn.getname(ListBox2.Items.Item(bs), "\", False)
                                        make(.SelectedPath + "\" + sc + ".Zip", ll)
                                    Else
                                        If Len(ListBox2.Items.Item(bs).ToString.Replace(ToolStripTextBox1.Text, "")) = Len(ListBox2.Items.Item(bs).ToString) Then
                                            GoTo k
                                        Else
                                            MkDir(.SelectedPath.Replace("\", "") + gnn.getname(ListBox2.Items.Item(bs).ToString.Replace(ToolStripTextBox1.Text, ""), "\", True))
                                            sc = .SelectedPath.Replace("\", "") + ListBox2.Items.Item(bs).ToString.Replace(ToolStripTextBox1.Text, "")
                                            make(sc + ".Zip", ll)
                                        End If
                                    End If

                                End If
                            Next
                            MsgBox("Finished！！！", MsgBoxStyle.Information, "温馨提示！！！")
                            Shell("Explorer.exe " + .SelectedPath, AppWinStyle.NormalFocus)
                        End If
                    End With
                End If
            End If
        End If
        NotifyIcon1.Icon = Nothing
        Me.Enabled = True
        Me.Show()
    End Sub
    Function make(ByVal d As String, ByVal listt As ListBox)
        TextBox1.Text = d
        Dim kt = (My.Computer.FileSystem.SpecialDirectories.Temp + "\%MPT%")
        MkDir(kt)
        For x = 0 To listt.Items.Count - 1
            My.Computer.FileSystem.CopyFile(listt.Items.Item(x), kt + "\幻灯片" + Str(x + 1).Trim + "." + ToolStripComboBox1.Items.Item(pp), True)
        Next
        Shell(My.Application.Info.DirectoryPath + "\GNEasy.exe " + "/XLY " + TextBox2.Text + "幻灯片" + TextBox2.Text + " " + TextBox2.Text + "10" + TextBox2.Text + " " + TextBox2.Text + "0" + TextBox2.Text + " " + TextBox2.Text + kt + TextBox2.Text, AppWinStyle.Hide, True)
        Dim b = My.Computer.FileSystem.GetFiles(kt, FileIO.SearchOption.SearchAllSubDirectories, "*." + ToolStripComboBox1.Items.Item(pp).ToString.ToLower)
        Dim hh = 240
        Dim ww = 320

        Dim xz As Boolean = False
        Dim qp As Boolean = False
        If 旋转ToolStripMenuItem.Checked = True Then
            xz = True
        Else
            xz = False
        End If
        If 图片全屏ToolStripMenuItem.Checked = True Then
            qp = True
            If ToolStripComboBox2.Text <> "" Then
                hh = gnn.getname(ToolStripComboBox2.Text, "*", True)
                ww = gnn.getname(ToolStripComboBox2.Text, "*", False)
            End If
        Else
            qp = False
        End If
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
        For y = 0 To b.Count - 1
            Pic1.Run(hh, ww, b(y), gss, False, qp, xz, True, ToolStripComboBox1.Items.Item(pp))
        Next
        If PNG反色ToolStripMenuItem.Checked = True And PNG反色ToolStripMenuItem.Enabled = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "FS", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "FS", "0")
        End If
        If ToolStripMenuItem1.Checked = True And ToolStripMenuItem1.Enabled = True Then
            On Error Resume Next
            My.Computer.Registry.CurrentUser.CreateSubKey("software\PCD")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "Se", 256)
            Shell(My.Application.Info.DirectoryPath + "\PNG Color Down.exe " + "/JS " + TextBox2.Text + kt + TextBox2.Text, AppWinStyle.Hide, True)
        End If
        ChDir(kt)
        Dim i = 0
        Dim n = 0
        Dim ppp As String = ""
        Dim nnn As String = ""
        Dim kkke
        If 文件夹批量ToolStripMenuItem.Checked = True Then
            Do
                If i <> 0 Then
                    ppp = "(" + Str(i).Trim + ")"
                End If
                If My.Computer.FileSystem.FileExists(gnn.getname(TextBox1.Text, "\", True) + "\" + gnn.getname(gnn.getname(TextBox1.Text, "\", False), ".", True) + ppp + ".Zip") = False Then
                    n = 1
                End If
                i = i + 1
            Loop Until n = 1
        Else
            On Error Resume Next
            Kill(TextBox1.Text)
            kkke = TextBox1.Text
        End If
        kkke = gnn.getname(TextBox1.Text, "\", True) + "\" + gnn.getname(gnn.getname(TextBox1.Text, "\", False), ".", True) + ppp + ".Zip"
        Shell(TextBox2.Text + My.Application.Info.DirectoryPath + "\zip.exe" + TextBox2.Text + " -r " + TextBox2.Text + kkke + TextBox2.Text + " " + "*.*", AppWinStyle.Hide, True)
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(kt, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Private Sub Maker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripComboBox1.SelectedIndex = 0
        pp = 0
        TL.Run(ListBox1, ListBox1, Nothing, "*.Jpg|*.Bmp|*.Png|*.Jpeg".ToLower, False, True)
        If My.Application.CommandLineArgs.Count <> 0 Then
            For t = 0 To My.Application.CommandLineArgs.Count - 1
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    ListBox1.Items.Remove(My.Application.CommandLineArgs.Item(t))
                    ListBox1.Items.Add(My.Application.CommandLineArgs.Item(t))
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    add(My.Application.CommandLineArgs.Item(t), ListBox1)
                End If
            Next
            MsgBox("添加了若干文件", MsgBoxStyle.Information, "温馨提示！！！")
        End If
    End Sub
    Private Sub OPENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click
        If 文件夹批量ToolStripMenuItem.Checked = False Then
            With OpenFileDialog1
                .FileName = ""
                .Filter = "*.Jpg;*.Bmp;*.Png;*.Jpeg|*.Jpg;*.Bmp;*.Png;*.Jpeg|*.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    If .FileNames.Count <> 0 Then
                        MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                        For x = 0 To OpenFileDialog1.FileNames.Count - 1
                            ListBox1.Items.Remove(OpenFileDialog1.FileNames(x).Trim)
                            ListBox1.Items.Add(OpenFileDialog1.FileNames(x).Trim)
                        Next
                    End If
                End If
            End With
        Else
            With FolderBrowserDialog1
                .SelectedPath = ""
                .Description = "请选择添加的路径:"
                .ShowNewFolderButton = False
                .ShowDialog()
                If .SelectedPath <> "" Then
                    ListBox2.Items.Remove(.SelectedPath)
                    ListBox2.Items.Add(.SelectedPath)
                End If
            End With
        End If
    End Sub
    Private Sub 旋转ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旋转ToolStripMenuItem.Click
        If 旋转ToolStripMenuItem.Checked = True Then
            旋转ToolStripMenuItem.Checked = False
        Else
            旋转ToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub 图片全屏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图片全屏ToolStripMenuItem.Click
        If 图片全屏ToolStripMenuItem.Checked = True Then
            图片全屏ToolStripMenuItem.Checked = False
            输出大小ToolStripMenuItem.Enabled = False
        Else
            图片全屏ToolStripMenuItem.Checked = True
            输出大小ToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        ListBox1.Items.Clear()
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        For x = 0 To ListBox1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0))
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = Nothing
        If ListBox1.Text <> "" Then
            Try
                PictureBox1.Image = Image.FromFile(ListBox1.Text)
                If PNG反色ToolStripMenuItem.Checked = True And PNG反色ToolStripMenuItem.Enabled = True Then
                    Me.PictureBox1.InvertColors()
                End If
            Catch
            End Try
        End If
    End Sub
    Private Sub 添加目录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加目录ToolStripMenuItem.Click
        If 文件夹批量ToolStripMenuItem.Checked = False Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .Description = "请选择添加的路径:"
                .ShowNewFolderButton = False
                .Description = "请选择含有图片文件的目录！！！"
                .ShowDialog()
                If .SelectedPath <> "" Then
                    Dim tt
                    Dim bb
                    Dim jj
                    Dim gg
                    Dim ww
                    tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                    bb = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.bmp")
                    jj = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                    gg = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.gif")
                    ww = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.wmf")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                    Next
                    For qq = 0 To bb.count - 1
                        ListBox1.Items.Remove(bb(qq))
                        ListBox1.Items.Add(bb(qq))
                        ListBox1.Items.Remove("")
                    Next
                    For qq = 0 To jj.count - 1
                        ListBox1.Items.Remove(jj(qq))
                        ListBox1.Items.Add(jj(qq))
                        ListBox1.Items.Remove("")
                    Next
                    For qq = 0 To gg.count - 1
                        ListBox1.Items.Remove(gg(qq))
                        ListBox1.Items.Add(gg(qq))
                        ListBox1.Items.Remove("")
                    Next
                    For qq = 0 To ww.count - 1
                        ListBox1.Items.Remove(ww(qq))
                        ListBox1.Items.Add(ww(qq))
                        ListBox1.Items.Remove("")
                    Next
                    MsgBox("添加了" + Str(tt.count + bb.count + jj.count + gg.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
                End If
            End With
        Else
            With FolderBrowserDialog1
                .SelectedPath = ""
                .Description = "请选择输入路径:"
                .ShowNewFolderButton = False
                .ShowDialog()
                If .SelectedPath <> "" Then
                    Dim b = My.Computer.FileSystem.GetDirectories(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories)
                    For q = 0 To b.Count - 1
                        If My.Computer.FileSystem.GetFiles(b(q)).Count <> 0 Then
                            ListBox2.Items.Remove(b(q))
                            ListBox2.Items.Add(b(q))
                        End If
                    Next
                    ToolStripTextBox1.Text = .SelectedPath
                End If
            End With
        End If
    End Sub
    Private Sub 上移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 上移ToolStripMenuItem.Click
        SY()
    End Sub
    Function SY()
        On Error Resume Next
        Dim qian As String
        Dim huo As String
        If ListBox1.Items.IndexOf(ListBox1.SelectedItems(0)) > 0 Then
            huo = ListBox1.SelectedItems(0)
            Dim t = ListBox1.SelectedItems(0)
            qian = ListBox1.Items(ListBox1.Items.IndexOf(t) - 1)
            ListBox1.Items(ListBox1.Items.IndexOf(t)) = qian
            t = ListBox1.SelectedItems(0)
            ListBox1.Items(ListBox1.Items.IndexOf(t)) = huo
            ListBox1.ClearSelected()
            ListBox1.SetSelected(ListBox1.Items.IndexOf(t) - 1, True)
        End If
    End Function
    Function XY()
        On Error Resume Next
        Dim qian As String
        Dim huo As String
        If ListBox1.Items.IndexOf(ListBox1.SelectedItems(0)) < ListBox1.Items.Count - 1 Then
            huo = ListBox1.SelectedItems(0)
            Dim t = ListBox1.SelectedItems(0)
            qian = ListBox1.Items(ListBox1.Items.IndexOf(t) + 1)
            ListBox1.Items(ListBox1.Items.IndexOf(t) + 1) = huo
            t = ListBox1.SelectedItems(0)
            ListBox1.Items(ListBox1.Items.IndexOf(t)) = qian
            ListBox1.ClearSelected()
            ListBox1.SetSelected(ListBox1.Items.IndexOf(t), True)
        End If
    End Function
    Private Sub 下移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 下移ToolStripMenuItem.Click
        XY()
    End Sub
    Private Sub 文件夹批量ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 文件夹批量ToolStripMenuItem.Click
        If 文件夹批量ToolStripMenuItem.Checked = True Then
            SplitContainer2.Panel2Collapsed = True
            文件夹批量ToolStripMenuItem.Checked = False
        Else
            '  ListBox2.Width = Me.Width * 0.25
            SplitContainer2.Panel2Collapsed = False
            文件夹批量ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function add(ByVal f As String, ByVal listt As ListBox)
        On Error Resume Next
        listt.Items.Clear()
        PictureBox1.Image = Nothing
        Dim tt
        Dim bb
        Dim jj
        Dim gg
        tt = My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
        bb = My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchAllSubDirectories, "*.bmp")
        jj = My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
        gg = My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchAllSubDirectories, "*.gif")
        For qq = 0 To tt.count - 1
            listt.Items.Remove(tt(qq))
            listt.Items.Add(tt(qq))
            listt.Items.Remove("")
        Next
        For qq = 0 To bb.count - 1
            listt.Items.Remove(bb(qq))
            listt.Items.Add(bb(qq))
            listt.Items.Remove("")
        Next
        For qq = 0 To jj.count - 1
            listt.Items.Remove(jj(qq))
            listt.Items.Add(jj(qq))
            listt.Items.Remove("")
        Next
        For qq = 0 To gg.count - 1
            listt.Items.Remove(gg(qq))
            listt.Items.Add(gg(qq))
            listt.Items.Remove("")
        Next
    End Function
    Private Sub 删除这一条ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem1.Click
        If 文件夹批量ToolStripMenuItem.Checked = True Then
            For x = 0 To ListBox2.SelectedItems.Count - 1
                ListBox2.Items.Remove(ListBox2.SelectedItems.Item(0))
                ListBox1.Items.Clear()
                PictureBox1.Image = Nothing
            Next
        End If
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem.Click
        If 文件夹批量ToolStripMenuItem.Checked = True Then
            ListBox2.Items.Clear()
            ListBox1.Items.Clear()
            PictureBox1.Image = Nothing
        End If
    End Sub
    Private Sub 输出ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 输出ToolStripMenuItem1.Click
        输出ToolStripMenuItem_Click()
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        If ListBox2.Text <> "" Then
            add(ListBox2.Text, ListBox1)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If ToolStripMenuItem1.Checked = True Then
            ToolStripMenuItem1.Checked = False
        Else
            ToolStripMenuItem1.Checked = True
        End If
    End Sub
    Dim pp As Integer
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        With ToolStripComboBox1
            If .SelectedIndex = 0 Then
                pp = 0
                ToolStripMenuItem1.Enabled = True
                PNG反色ToolStripMenuItem.Enabled = True
            Else
                ToolStripMenuItem1.Enabled = False
                PNG反色ToolStripMenuItem.Enabled = False
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
    Private Sub PNG反色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNG反色ToolStripMenuItem.Click
        If PNG反色ToolStripMenuItem.Checked = True Then
            PNG反色ToolStripMenuItem.Checked = False
        Else
            PNG反色ToolStripMenuItem.Checked = True
        End If
    End Sub
End Class