Public Class Main
    Private Sub Button1_Click() Handles Button1.Click
        AddText.CheckBox6.Checked = False
        Me.Hide()
        AddText.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        AddPic.CheckBox2.Checked = False
        Me.Hide()
        AddPic.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        LJ.CheckBox2.Checked = False
        Me.Hide()
        LJ.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        saveit(Me.Text + "\Test.Html")
        Dim uu As New Uri(Me.Text + "\Test.Html")
        WebBrowser1.Url = uu
        If ListView1.Width = 0 Then
            Button10_Click()
        End If
        w = ListView1.Width
        ListView1.Width = 0
        SplitContainer1.Panel2Collapsed = False
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        h = Panel1.Height
        Panel1.Height = 10
    End Sub
    Function saveit(ByVal path As String)
        On Error Resume Next
        Dim kkk = ""
        Dim h1 As String
        Dim h2 As String
        For x = 0 To ListView1.Items.Count - 1
            If ListView1.Items(x).SubItems(2).Text = "是" Then
                h1 = "<P>"
                h2 = "</P>"
            Else
                h1 = ""
                h2 = ""
            End If
            kkk = kkk + h1 + vbCrLf + ListView1.Items(x).SubItems(1).Text + h2
        Next
        My.Computer.FileSystem.WriteAllText(path, "<html><head><title>" + biaoti + "</title>" + kkk + "</head></html>", False, System.Text.Encoding.Default)
    End Function
    Private Sub Button8_Click() Handles Button8.Click
        WebBrowser1.ShowSaveAsDialog()
        'If Me.Text <> "" Then
        '    Dim r = InputBox("网页名:", "请输入", "Index")
        '    If r <> "" Then
        '        saveit(Me.Text + "\" + r + ".Html")
        '        On Error Resume Next
        '        Kill(Me.Text + "\Test.Html")
        '    End If
        'End If
    End Sub
    Private Sub Button7_Click() Handles Button7.Click
        If MsgBox("是否清空这剧本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            Dim b As New Uri("about:blank")
            WebBrowser1.Url = b
        End If
    End Sub
    Private Sub Button9_Click() Handles Button9.Click
        ATA.CheckBox2.Checked = False
        Me.Hide()
        ATA.ShowDialog()
        Me.Show()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        If SplitContainer1.Panel2Collapsed = True And dong = False Then
            lx1(ListView1)
            ListView2.SelectedIndices.Clear()
            For x = 0 To ListView1.SelectedIndices.Count - 1
                ListView2.SelectedIndices.Add(ListView1.SelectedIndices.Item(x))
            Next
        End If
    End Sub
    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        On Error Resume Next
        If SplitContainer1.Panel2Collapsed = False And dong = False Then
            lx1(ListView2)
            ListView1.SelectedIndices.Clear()
            For x = 0 To ListView2.SelectedIndices.Count - 1
                ListView1.SelectedIndices.Add(ListView2.SelectedIndices.Item(x))
            Next
        End If
    End Sub
    Function lx1(ByVal lx As ListView)
        On Error Resume Next
        Dim h1 As String
        Dim h2 As String
        If lx.SelectedItems(0).SubItems(2).Text = "是" Then
            h1 = "<P>"
            h2 = "</P>"
        Else
            h1 = ""
            h2 = ""
        End If
        My.Computer.FileSystem.WriteAllText(Me.Text + "\Test.Html", h1 + lx.SelectedItems(0).SubItems(1).Text + h2, False)
        Dim uu As New Uri(Me.Text + "\Test.Html")
        WebBrowser1.Url = uu
    End Function
    Public gml As String
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        Kill(Me.Text + "\Test.Html")
        If MsgBox("是否要保存这剧本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            导出ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
a:      Me.Hide()
        SplashScreen1.ShowDialog()
        Me.Show()
        If Me.Text = "" Then
            Dim tei As New FolderBrowserDialog
            With tei
                .Description = "网页根目录:"
                .SelectedPath = ""
                .ShowDialog()
                If .SelectedPath <> "" Then
                    gml = .SelectedPath
                    Me.Text = gml
                    ChDir(gml)
                Else
                    GoTo a
                End If
            End With
        End If
    End Sub
    Private Sub Button4_Click() Handles Button4.Click
        For x = 0 To ListView1.SelectedItems.Count - 1
            Dim s
            If SplitContainer1.Panel2Collapsed = False Then
                s = ListView2.SelectedItems(0).Index
            Else
                s = ListView1.SelectedItems(0).Index
            End If
            ListView1.Items.RemoveAt(s)
            ListView2.Items.RemoveAt(s)
        Next
        Dim b As New Uri("about:blank")
        WebBrowser1.Url = b
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Dim qqw = ListView1.SelectedItems(0)
            BJ.TextBox1.Text = ""
            BJ.TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
            If ListView1.SelectedItems(0).SubItems(2).Text = "是" Then
                BJ.CheckBox1.Checked = True
            Else
                BJ.CheckBox1.Checked = False
            End If
            BJ.ShowDialog()
        End If
    End Sub
    Private Sub 添加文字ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文字ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 添加图片ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加图片ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub 添加链接ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加链接ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub 添加其他ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加其他ToolStripMenuItem.Click
        Button9_Click()
    End Sub
    Private Sub 编辑ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        Button7_Click()
    End Sub
    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Button8_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        If MsgBox("是否要保存这剧本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            导出ToolStripMenuItem_Click()
        End If
        On Error Resume Next
        Kill(Me.Text + "\Test.Html")
        End
    End Sub
    Function YW(ByVal L As ListView, ByVal SX As Boolean)
        Dim o As String
        Dim t As String
        Dim d As String
        Dim b As String
        Dim q As String
        Dim r As String
        Dim t0 As Integer
        Dim t1 As Integer
        Dim i1 As Integer
        Dim i2 As Integer
        On Error Resume Next
        o = ""
        t = ""
        d = ""
        b = ""
        q = ""
        r = ""
        t0 = Nothing
        t1 = Nothing
        i1 = Nothing
        i2 = Nothing
        If SX = True Then
            If L.Items.IndexOf(L.SelectedItems(0)) > 0 Then
                t1 = (L.Items.IndexOf(L.SelectedItems.Item(0)))
                t0 = t1 - 1
                GoTo g
            End If
        Else
            If L.Items.IndexOf(L.SelectedItems(0)) < L.Items.Count - 1 Then
                t1 = (L.Items.IndexOf(L.SelectedItems.Item(0)))
                t0 = t1 + 1
                GoTo g
            End If
        End If
        L.Select()
        Return Nothing
        Exit Function
g:      o = L.Items(t0).Text
        t = L.Items(t1).Text
        d = L.Items(t0).SubItems(1).Text
        b = L.Items(t1).SubItems(1).Text
        q = L.Items(t0).SubItems(2).Text
        r = L.Items(t1).SubItems(2).Text
        i1 = L.Items(t0).ImageIndex
        i2 = L.Items(t1).ImageIndex
        L.Items(t0).Text = t
        L.Items(t1).Text = o
        L.Items(t0).SubItems(1).Text = b
        L.Items(t1).SubItems(1).Text = d
        L.Items(t0).SubItems(2).Text = r
        L.Items(t1).SubItems(2).Text = q
        L.SelectedItems.Clear()
        L.SelectedIndices.Add(t0)
        L.Items(t0).ImageIndex = i2
        L.Items(t1).ImageIndex = i1
        L.Select()
    End Function
    Dim dong = False
    Private Sub 上移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 上移ToolStripMenuItem.Click
        dong = True
        If SplitContainer1.Panel2Collapsed = False Then
            YW(ListView1, True)
            YW(ListView2, True)
        Else
            YW(ListView2, True)
            YW(ListView1, True)
        End If
        dong = False
    End Sub
    Private Sub 下移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 下移ToolStripMenuItem.Click
        dong = True
        If SplitContainer1.Panel2Collapsed = False Then
            YW(ListView1, False)
            YW(ListView2, False)
        Else
            YW(ListView2, False)
            YW(ListView1, False)
        End If
        dong = False
    End Sub
    Private Sub 浏览器预览ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 浏览器预览ToolStripMenuItem.Click
        On Error Resume Next
        saveit(Me.Text + "\Test.Html")
        Shell("explorer " + Me.Text + "\Test.Html", AppWinStyle.NormalFocus)
    End Sub
    Dim w As Integer
    Private Sub Button10_Click() Handles Button10.Click
        If ListView1.Width <> 0 Then
            w = ListView1.Width
            ListView1.Width = 0
            SplitContainer1.Panel2Collapsed = False
        Else
            ListView1.Width = w
            SplitContainer1.Panel2Collapsed = True
        End If
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Dim biaoti As String
    Private Sub 标题ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 标题ToolStripMenuItem.Click
        biaoti = InputBox("请输入标题:", "设置标题", biaoti)
    End Sub
    Dim h As Integer
    Private Sub Button11_Click() Handles Button11.Click
        If Panel1.Height <> 10 Then
            h = Panel1.Height
            Panel1.Height = 10
        Else
            Panel1.Height = h
        End If
    End Sub
    Function bi(ByVal dd As String)
        On Error Resume Next
        Dim kk As String = TextBox1.Text.Replace("/Name", biaoti.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Num", Str(ListView1.Items.Count).Trim).Replace("/PPAATTHH", Me.Text)
        For x = 0 To ListView1.Items.Count - 1
            kk = kk + vbCrLf + TextBox2.Text.Replace("/DZ", ListView1.Items.Item(x).SubItems.Item(0).Text.Trim.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(x).Trim.Trim.Replace("<", "###!#").Replace(">", "#!##")).Replace("/PPP", ListView1.Items.Item(x).SubItems.Item(1).Text.Trim.Trim.Replace("<", "###!#").Replace(">", "#!##")).Replace("/SSS", ListView1.Items.Item(x).SubItems.Item(2).Text.Trim.Trim.Replace("<", "###!#").Replace(">", "#!##"))
        Next
        kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</HM>"
        My.Computer.FileSystem.WriteAllText(dd, kk.Replace("&", "*\*/*"), False)
    End Function
    Private Sub 导出ToolStripMenuItem_Click() Handles 导出ToolStripMenuItem.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "*.XML 剧本文件|*.XML|*.* ALL File|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                bi(.FileName)
                MsgBox("操作完成！！！", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Public Sub 导入ToolStripMenuItem_Click() Handles 导入ToolStripMenuItem.Click
        If MsgBox("是否放弃这剧本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            With OpenFileDialog1
                .FileName = ""
                .Filter = "*.XML 剧本文件|*.XML|*.* ALL File|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    di(.FileName)
                    If Me.Text = "" Then
                        目录StripMenuItem1_Click()
                    End If
                    MsgBox("操作完成！！！", MsgBoxStyle.Information, "温馨提示！！！")
                End If
            End With
        End If
    End Sub
    Function di(ByVal str As String)
        On Error Resume Next
        Dim ddc As String = str
        Dim Aero = XDocument.Load(ddc)
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        biaoti = Aero.<HM>.<Tile>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
        Me.Text = Aero.<HM>.<Path>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
        Dim yys As Integer = 0
        For x = 0 To CInt(Aero.<HM>.<FileNum>.Value) - 1
            Dim knn As String = Aero.<HM>.<Files>.<File>(x).<Name>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kpp As String = Aero.<HM>.<Files>.<File>(x).<LX>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kss As String = Aero.<HM>.<Files>.<File>(x).<NR>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim khh As String = Aero.<HM>.<Files>.<File>(x).<HH>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            If knn = "文字" Then
                yys = 0
            Else
                If knn = "图片" Then
                    yys = 1
                Else
                    If knn = "连接" Then
                        yys = 2
                    Else
                        yys = 3
                    End If
                End If
            End If
            ListView1.Items.Add(knn, yys)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(khh)
            ListView2.Items.Add(knn, yys)
            ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Add(kpp)
            ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Add(khh)
        Next
    End Function
    Private Sub 文字ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 文字ToolStripMenuItem1.Click
        AddText.CheckBox6.Checked = True
        Me.Hide()
        AddText.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 图片ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图片ToolStripMenuItem1.Click
        AddPic.CheckBox2.Checked = True
        Me.Hide()
        AddPic.ShowDialog()
        Me.Show()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count <> 0 Then
            插入ToolStripMenuItem.Visible = True
            替换ToolStripMenuItem.Visible = True
        Else
            插入ToolStripMenuItem.Visible = False
            替换ToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub 图片ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图片ToolStripMenuItem.Click
        AddPic.CheckBox2.Checked = True
        Dim tts As Integer = 0
        tts = ListView1.Items.Count
        Me.Hide()
        AddPic.ShowDialog()
        If ListView1.Items.Count > tts Then
            ListView1.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
            ListView2.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
        End If
        Me.Show()
    End Sub
    Private Sub 文字ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 文字ToolStripMenuItem.Click
        AddText.CheckBox6.Checked = True
        Dim tts As Integer = 0
        tts = ListView1.Items.Count
        Me.Hide()
        AddText.ShowDialog()
        If ListView1.Items.Count > tts Then
            ListView1.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
            ListView2.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
        End If
        Me.Show()
    End Sub
    Private Sub 连接ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 连接ToolStripMenuItem.Click
        LJ.CheckBox2.Checked = True
        Me.Hide()
        LJ.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 连接StripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 连接StripMenuItem1.Click
        LJ.CheckBox2.Checked = True
        Dim tts As Integer = 0
        tts = ListView1.Items.Count
        Me.Hide()
        LJ.ShowDialog()
        If ListView1.Items.Count > tts Then
            ListView1.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
            ListView2.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
        End If
        Me.Show()
    End Sub
    Private Sub 其他ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 其他ToolStripMenuItem.Click
        ATA.CheckBox2.Checked = True
        Me.Hide()
        ATA.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 其他StripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 其他StripMenuItem1.Click
        ATA.CheckBox2.Checked = True
        Dim tts As Integer = 0
        tts = ListView1.Items.Count
        Me.Hide()
        ATA.ShowDialog()
        If ListView1.Items.Count > tts Then
            ListView1.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
            ListView2.Items.RemoveAt(ListView1.SelectedItems.Item(0).Index)
        End If
        Me.Show()
    End Sub
    Private Sub 新建StripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建StripMenuItem1.Click
        If MsgBox("是否放弃这剧本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            Me.Hide()
            SplashScreen1.ShowDialog()
        End If
    End Sub
    Public Sub 目录StripMenuItem1_Click() Handles 目录StripMenuItem1.Click
k:      Dim tei As New FolderBrowserDialog
        With tei
            .Description = "网页根目录:"
            .SelectedPath = Me.Text
            .ShowDialog()
            If .SelectedPath <> "" Then
                gml = .SelectedPath
                Me.Text = gml
                ChDir(gml)
            Else
                MsgBox("网页根目录不能空！！", MsgBoxStyle.Information, "温馨提示！！！")
                GoTo k
            End If
        End With
    End Sub
    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Button10_Click()
        SplitContainer1.Panel2Collapsed = True
    End Sub
    Private Sub Panel3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.DoubleClick
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
End Class