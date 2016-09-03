Public Class ImagePaste
    Dim picture As Image
    Dim w = My.Computer.FileSystem.SpecialDirectories.Temp + "\$picpaste"
    Dim k As String
    Dim q As Boolean
    Dim ke As Boolean
    Dim jj As New PasteExt.MissWindow
    Dim kk As New PasteExt.CompareFile
    Dim cc As New PasteExt.EndCommand
    Dim dpic As New PasteExt.PicSet
    Dim uy As New PasteExt.look
    Dim wt As New PasteExt.BoxSet
    Dim op As New PasteExt.op
    Dim w1 As String
    Dim t As Boolean
    Private Sub ImagePaste_FormClosing() Handles Me.FormClosing
        On Error Resume Next
        If q = True Then
            On Error Resume Next
            we(My.Application.Info.DirectoryPath + "\Last Image")
        End If
        Kill(w + "\" + "*.*")
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$picpaste")
        NotifyIcon1.Icon = Nothing
    End Sub
    Function setting()
        op.all(Me, "ImagePaste")
        w1 = op.wr.ToString
        uy.ws(w1)
        On Error Resume Next
        If op.cr.ToString = "True" Then
            顶端ToolStripMenuItem.Checked = True
            Me.TopMost = True
        Else
            If op.cr.ToString = "False" Then
                顶端ToolStripMenuItem.Checked = False
                Me.TopMost = False
            End If
        End If
    End Function
    Private Sub Image_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      wt.wf(Me, "ImagePaste")
        setting()
        'MiniIcon1.rof(False, "ImagePaste")
        cc.showend("ImagePaste", False)
        'uy.run()
        If My.Application.CommandLineArgs.Contains("/MiniTrue") = True Then
            jj.miss(Me, True, True)
        Else
            jj.miss(Me, True, False)
        End If
        If My.Application.CommandLineArgs.Contains("/hide") = True Then
            Me.ShowInTaskbar = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
            Me.ShowInTaskbar = False
            MiniIcon1.rof(True, "ImagePaste")
        End If
        If My.Application.CommandLineArgs.Contains("/saveend") = True Then
            q = True
        Else
            q = False
        End If
        If My.Application.CommandLineArgs.Contains("/dellog") = True Then
            On Error Resume Next
            Kill(My.Application.Info.DirectoryPath + "\Last Image\*.*")
        End If
        If My.Application.CommandLineArgs.Contains("/ShowTask") = True Then
            Me.ShowInTaskbar = True
        Else
            Me.ShowInTaskbar = False
        End If
        On Error Resume Next
        Dim r As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\ImagePaste", "PL", Nothing)
        If r <> Nothing Then
            Timer1.Interval = (r)
            If r = 100 Then
                高ToolStripMenuItem.Checked = True
                中ToolStripMenuItem.Checked = False
            End If
            If r = 500 Then
                低ToolStripMenuItem.Checked = True
                中ToolStripMenuItem.Checked = False
            End If
            If r <> 100 And r <> 250 And r <> 500 Then
                自义定ToolStripMenuItem.Checked = True
                中ToolStripMenuItem.Checked = False
                ToolStripTextBox1.Text = r
            End If
        End If
        If Command() = "/?" Then
            Timer1.Enabled = False
            NotifyIcon1.Icon = Nothing
            MsgBox("ImagePaste.exe [/hide] [/saveend] [/dellog] [/MiniTrue] [/ShowTask]" + vbCrLf + "[/hide]启动窗口最小化" + vbCrLf + "[/saveend]关闭时保存图像到目录根下" + vbCrLf + "[/dellog]清空Last Image" + vbCrLf + "[/MiniTrue]最小还原在原来位置" + vbCrLf + "[/ShowTask]显示在任务栏上", MsgBoxStyle.Information, "ImagePaste参数行")
            End
        End If
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$picpaste")
        setting()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If My.Computer.Clipboard.ContainsImage() Then
            picture = My.Computer.Clipboard.GetImage
            PictureBox1.Image = picture
            PictureBox1.Image.Save(w + "\" + "$$Now", System.Drawing.Imaging.ImageFormat.Jpeg)
            If ListBox1.Items.Count <> 0 Then
                Dim shu = ListBox1.Items.Count
                ListBox1.SetSelected(shu - 1, True)
                BackgroundWorker1_DoWork()
                If ke = True Then
                Else
                    loader()
                End If
            Else
                loader()
            End If
        End If
    End Sub
    Function loader()
        Dim h As String = Hour(Now)
        Dim m As String = Minute(Now)
        Dim s As String = Second(Now)
        k = h + "-" + m + "-" + s
        PictureBox1.Image.Save(w + "\" + k, System.Drawing.Imaging.ImageFormat.Jpeg)
        ListBox1.Items.Add(k)
        ListBox2.Items.Add(k)
        picsuo()
    End Function
    Private Sub ListBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.Click
        If ListBox2.Text <> "" Then
            PictureBox2.ImageLocation = (w + "\" + ListBox2.Text)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PictureBox2.Image Is Nothing Or ListBox1.Text = "" Then
        Else
            My.Computer.Clipboard.SetImage(PictureBox2.Image)
            MsgBox("Copy Successed！！！", MsgBoxStyle.Information)
            删除这一条ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        ImagePaste_FormClosing()
        End
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click() Handles 删除这一条ToolStripMenuItem.Click
        Kill(w + "\" + ListBox2.Text)
        ListBox1.Items.Remove(ListBox2.Text)
        ListBox2.Items.Remove(ListBox2.Text)
        PictureBox2.Image = Nothing
    End Sub
    Private Sub 保存这一条ToolStripMenuItem_Click() Handles 保存这一条ToolStripMenuItem.Click
        If ListBox2.Text <> "" Then
            With SaveFileDialog1
                .FileName = ""
                .Filter = "Picture File *.png;*.jpg;*.bmp;*.gif|*.png;*.jpg;*.bmp;*.gif|All File *.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    If My.Computer.FileSystem.FileExists(.FileName) = True Then
                        Kill(.FileName)
                    End If
                    PictureBox2.Image.Save(.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    'My.Computer.FileSystem.CopyFile(w + "\" + ListBox2.Text, .FileName)
                    MsgBox("Save Successed！！！", MsgBoxStyle.Information)
                End If
            End With
        End If
    End Sub
    Private Sub 全部保存ToolStripMenuItem_Click() Handles 全部保存ToolStripMenuItem.Click
        If ListBox2.Items.Count <> 0 Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .Description = ("Please Choose Save Path:")
                .ShowDialog()
                If .SelectedPath <> "" Then
                    we(.SelectedPath)
                    MsgBox("Save Successed！！！", MsgBoxStyle.Information)
                End If
            End With
        End If
    End Sub
    Function we(ByVal o As String)
        'My.Computer.FileSystem.CopyDirectory(w, o)
        For tt = 0 To ListBox2.Items.Count - 1
            Dim dd As String = ""
            If Len(Str(tt).Trim) = 1 Then
                dd = "00" + Str(tt).Trim
            End If
            If Len(Str(tt).Trim) = 2 Then
                dd = "0" + Str(tt).Trim
            End If
            If Len(Str(tt).Trim) = 3 Then
                dd = tt
            End If
            If My.Computer.FileSystem.FileExists(o + "\" + (dd) + ".Jpg") = True Then
                My.Computer.FileSystem.CopyFile(o + "\" + (dd) + ".Jpg", o + "\" + (dd) + ".Jpg.Bak")
                Kill(o + "\" + (dd) + ".Jpg")
            End If
            My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\$picpaste" + "\" + ListBox2.Items(tt).ToString, o + "\" + (dd) + ".Jpg")
        Next
    End Function
    Private Sub 清空剪辑板ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空剪辑板ToolStripMenuItem.Click
        If ListBox2.Items.Count <> 0 Then
            Dim p = MsgBox("是否先保存？", MsgBoxStyle.YesNoCancel)
            If p <> MsgBoxResult.Cancel Then
                If p = MsgBoxResult.Yes Then
                    全部保存ToolStripMenuItem_Click()
                    dl()
                End If
                If p = MsgBoxResult.No Then
                    dl()
                End If
            End If
        End If
    End Sub
    Function dl()
        Kill(w + "\" + "*.*")
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        PictureBox2.Image = Nothing
    End Function
    Private Sub ListBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseMove
        If ListBox2.Text = "" Then
            ou(False)
        Else
            ou(True)
        End If
    End Sub
    Function ou(ByVal l As Boolean)
        删除这一条ToolStripMenuItem.Visible = l
        保存这一条ToolStripMenuItem.Visible = l
        Button1.Enabled = l
        Button2.Enabled = l
    End Function
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If ListBox2.Text = "" Then
            ou(False)
        Else
            ou(True)
        End If
    End Sub
    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If ListBox2.Text = "" Then
            ou(False)
        Else
            ou(True)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        保存这一条ToolStripMenuItem_Click()
    End Sub
    Function picsuo()
        If PictureBox1.Image Is Nothing Then
        Else
            If WindowState = System.Windows.Forms.FormWindowState.Minimized Or My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "Hide", Nothing) = 1 Then
                On Error GoTo p
i:              uy.kof(PictureBox1, Me)
                uy.Show()
            Else
                uy.Hide()
            End If
            uy.Refresh()
        End If
        Exit Function
p:      uy.Hide()
        GoTo i
    End Function
    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        uy.Hide()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
            MiniIcon1.mini(Me, True, "ImagePaste")
        Else
            MiniIcon1.mini(Me, False, "ImagePaste")
        End If
    End Sub
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        删除这一条ToolStripMenuItem.Visible = False
        保存这一条ToolStripMenuItem.Visible = False
    End Sub
    Private Sub 顶端ToolStripMenuItem_Click() Handles 顶端ToolStripMenuItem.Click
        If 顶端ToolStripMenuItem.Checked = True Then
            t = False
            顶端ToolStripMenuItem.Checked = False
        Else
            t = True
            顶端ToolStripMenuItem.Checked = True
        End If
        If t = False Then
            Me.TopMost = False
            wt.write(False)
        End If
        If t = True Then
            Me.TopMost = True
            wt.write(True)
        End If
        setting()
    End Sub
    Private Sub BackgroundWorker1_DoWork() Handles BackgroundWorker1.DoWork
        If kk.CompareFiles(w + "\" + "$$Now", w + "\" + ListBox1.Text) = True Then
            ke = True
        Else
            ke = False
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Paste\ImagePaste", "End", Nothing) = "1" Then
            退出ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        dpic.readpic(PictureBox1, Me)
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        dpic.readpic(PictureBox2, Me)
    End Sub
    Private Sub 微调设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 微调设置ToolStripMenuItem.Click
        wt.wf(Me, "ImagePaste")
        wt.ShowDialog()
        setting()
    End Sub
    Private Sub 高ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 高ToolStripMenuItem.Click
        Timer1.Interval = 100
        reg(100)
        高ToolStripMenuItem.Checked = True
        中ToolStripMenuItem.Checked = False
        低ToolStripMenuItem.Checked = False
        自义定ToolStripMenuItem.Checked = False
        ToolStripTextBox1.Text = ""
    End Sub
    Private Sub 中ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 中ToolStripMenuItem.Click
        Timer1.Interval = 250
        reg(250)
        高ToolStripMenuItem.Checked = False
        中ToolStripMenuItem.Checked = True
        低ToolStripMenuItem.Checked = False
        自义定ToolStripMenuItem.Checked = False
        ToolStripTextBox1.Text = ""
    End Sub
    Private Sub 低ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 低ToolStripMenuItem.Click
        Timer1.Interval = 500
        reg(500)
        高ToolStripMenuItem.Checked = False
        中ToolStripMenuItem.Checked = False
        低ToolStripMenuItem.Checked = True
        自义定ToolStripMenuItem.Checked = False
        ToolStripTextBox1.Text = ""
    End Sub
    Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        On Error GoTo 0
        If ToolStripTextBox1.Text <> "" Then
            Dim ty As Integer = Int(ToolStripTextBox1.Text)
            Timer1.Interval = ty
            reg(ty)
            高ToolStripMenuItem.Checked = False
            中ToolStripMenuItem.Checked = False
            低ToolStripMenuItem.Checked = False
            自义定ToolStripMenuItem.Checked = True
        End If
    End Sub
    Function reg(ByVal str As Integer)
        On Error Resume Next
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Paste\ImagePaste", "PL", str)
    End Function
End Class