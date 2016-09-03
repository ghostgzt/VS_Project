Imports System.Runtime.InteropServices
Public Class HS
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    Dim getname As New GN
    Dim tmppath = ""
    Dim list As String = ""
    Dim fgf As String
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim gnn As New GN
    Dim tile As String = ""
    Dim cs As Integer
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
                    ListBox1.Items.Remove(sb.ToString)
                    ListBox1.Items.Add(sb.ToString)
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.htm")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            If ListBox1.Items.Count <> 0 Then
                Button2.Enabled = True
            Else
                Button2.Enabled = False
            End If
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        ListBox1.Enabled = False
        If ListBox1.Items.Count <> 0 Then
            Dim yt = MsgBox("你是否确定进行处理?！", MsgBoxStyle.YesNo, "温馨提示！！！")
            If yt = MsgBoxResult.Yes Then
                If NumericUpDown1.Value <> 0 And Str(NumericUpDown1.Value) <> "" Then
                    For t = 0 To ListBox1.Items.Count - 1
                        ListBox1.SetSelected(t, True)
                        run(gnn.getname(ListBox1.Text, "\", True, 0), NumericUpDown1.Value)
                    Next
                    MsgBox("操作成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
                    Button7_Click()
                Else
                    If NumericUpDown1.Value = 0 Then
                        ToolStripProgressBar1.Value = 0
                        For t = 0 To ListBox1.Items.Count - 1
                            ListBox1.SetSelected(t, True)
                            run(gnn.getname(ListBox1.Text, "\", True, 0), NumericUpDown1.Value)
                            On Error Resume Next
                            Me.Refresh()
                            If ToolStripProgressBar1.Value >= 100 Then
                                ToolStripProgressBar1.Value = 100
                            Else
                                ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + (ListBox1.Items.Count / 100)
                            End If
                        Next
                        ToolStripProgressBar1.Value = 100
                        MsgBox("操作成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
                        Button7_Click()
                    Else
                        MsgBox("请设置好分隔字符数,记住它不能为0！！！！" + vbCrLf + "若为0则不分割,字符数应小于" + Str(TextBox1.Text.Length), MsgBoxStyle.Information, "温馨提示！！！")
                    End If
                End If
            End If
        End If
        ListBox1.Enabled = True
    End Sub
    Function mk()
        On Error Resume Next
        tmppath = ""
        Dim tmm = gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0)
        My.Computer.FileSystem.MoveFile(ListBox1.Text, tmm + "\" + "YWJ" + ".htm", True)
        My.Computer.FileSystem.MoveDirectory(tmm + ".files", tmm + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0) + ".files", True)
        tmppath = tmm
    End Function
    Function qs()
        On Error Resume Next
        Dim yy = 1
        Dim t1 As Integer = 0
        Dim t2 As Integer = 0
        Dim style = ""
        Dim g As String = My.Computer.FileSystem.ReadAllText(ListBox1.Items(0), System.Text.Encoding.Default)
        style = (gnn.getname(gnn.getname(g, "<style>", False, 1), "</style>", True, 1))
        MsgBox(g.Replace(style, ""))
        If style <> "" Then
            TextBox1.Text = g.Replace(style, "")
        End If
    End Function
    Function run(ByVal lj As String, ByVal fgzs As Integer)
        Dim name = (gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0))
        cs = 2
        Dim yy = 1
        Dim s1 = 0
        Dim s2 = 0
        Dim dy = 1
        Dim ky = 1
        Dim t1 As Integer = 0
        Dim t2 As Integer = 0
        tile = ""
        Dim kkb = TextBox1.Text.Length
        Do
            If Mid(TextBox1.Text, yy, Len("<TITLE>")) = "<TITLE>" Or Mid(TextBox1.Text, yy, Len("<TITLE>")) = "<TITLE>".ToLower Then
                t1 = yy
            End If
            If Mid(TextBox1.Text, yy, Len("</TITLE>")) = "</TITLE>" Or Mid(TextBox1.Text, yy, Len("</TITLE>")) = "</TITLE>".ToLower Then
                t2 = yy
            End If
            If t1 <> 0 And t2 <> 0 And t1 < t2 Then
                tile = TextBox1.Text.Remove(yy + Len("</TITLE>") - 2 - Len("<TITLE>")).Remove(0, t1 - 1 + Len("<TITLE>"))
            End If
            yy = yy + 1
        Loop Until tile <> "" Or yy > TextBox1.Text.Length
        If tile <> "" Then
            TextBox1.Text = TextBox1.Text.Replace(TextBox1.Text.Remove(yy + Len("</TITLE>") - 1), "")
        End If
        With TextBox1
            If TextBox4.Text <> "" Then
                .Text = .Text.Replace(TextBox4.Text, TextBox5.Text)
            End If
            .Text = .Text.Replace(vbCrLf, "")
            .Text = .Text.Replace(vbCr, "")
            .Text = .Text.Replace(vbLf, "")
            If ListBox2.Items.Count <> 0 Then
                For r = 0 To ListBox2.Items.Count - 1
                    TextBox1.Text = TextBox1.Text.Replace(gnn.getname(ListBox2.Items(r), "‘", True, 0), gnn.getname(ListBox2.Items(r), "‘", False, 0))
                Next
            End If
            If CheckBox1.Checked = True Then
                qs()
            End If
            .Text = .Text.Replace(".gif", ".png")
            .Text = .Text.Replace(".jpg", ".png")
            .Text = .Text.Replace(".bmp", ".png")
            .Text = .Text.Replace("</BODY></HTML>", "")
            .Text = .Text.Replace("</body></html>", "")
            .Text = .Text.Replace("<", vbCrLf + "<")
            .Text = .Text.Replace(vbCrLf + "</", "</")
        End With

        If fgzs = 0 Or fgzs >= TextBox1.Text.Length Then
            My.Computer.FileSystem.WriteAllText(gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0) + "-New" + ".htm", "<html>" + "<head>" + "<title>" + tile + "</title>" + TextBox1.Text + "</BODY></HTML>", False, System.Text.Encoding.Default)
            Shell("attrib " + TextBox7.Text + ListBox1.Text + TextBox7.Text + " +H", AppWinStyle.Hide)
            If CheckBox2.Checked = True Then
                On Error Resume Next
                Dim tmm = gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0)
                tmppath = tmm
                Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe" + " /Hide " + TextBox7.Text + gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0) + ".files" + TextBox7.Text, AppWinStyle.Hide, True)
            End If
        Else
            Dim yyd As String
            yyd = "YWJ"
            If CheckBox3.Checked = True Then
                mk()
            Else
                tmppath = gnn.getname(ListBox1.Text, "\", True, 0)
                yyd = gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0)
            End If
            My.Computer.FileSystem.WriteAllText(tmppath + "\" + yyd + "New" + ".htm", "<html>" + "<head>" + "<title>" + tile + "</title>" + TextBox1.Text + "</BODY></HTML>", False, System.Text.Encoding.Default)
            Do
                Dim eee = Str(cs).Trim
                If eee.Length = 1 Then
                    eee = "00" + eee
                End If
                If eee.Length = 2 Then
                    eee = "0" + eee
                End If
                Dim eek = Str(cs - 1).Trim
                If eek.Length = 1 Then
                    eek = "00" + eek
                End If
                If eek.Length = 2 Then
                    eek = "0" + eek
                End If
                Dim eeb = Str(cs - 2).Trim
                If eeb.Length = 1 Then
                    eeb = "00" + eeb
                End If
                If eeb.Length = 2 Then
                    eeb = "0" + eeb
                End If
                Dim tt = ""
                Dim yyt = fgzs
                Do
                    If Mid(TextBox1.Text, yyt, 1) = ">" Then
                        tt = "1"
                    End If
                    yyt = yyt + 1
                Loop Until tt <> "" Or yyt > TextBox1.Text.Length
                Dim zy = TextBox3.Text + "000" + (TextBox2.Text.Replace("&gt;Next", "&gt;000").Replace("</DIV></BODY></HTML>", ""))
                On Error Resume Next
                If cs = 1 Then
                    My.Computer.FileSystem.WriteAllText(tmppath + "\" + eek + ".htm", "<html>" + "<head>" + "<title>" + tile + eek + "</title>" + vbCrLf + TextBox1.Text.Remove(yyt - 1) + ("</P></A></Span></Table></Font>" + TextBox3.Text + eee + TextBox2.Text.Replace("</DIV></BODY></HTML>", "")) + vbCrLf + zy + vbCrLf + "<P><Font>" + "当前" + eek + "</Font></P>" + vbCrLf + "</DIV></BODY></HTML>", False, System.Text.Encoding.Default)
                Else
                    My.Computer.FileSystem.WriteAllText(tmppath + "\" + eek + ".htm", "<html>" + "<head>" + "<title>" + tile + eek + "</title>" + vbCrLf + TextBox1.Text.Remove(yyt - 1) + ("</P></A></Span></Table></Font>" + TextBox3.Text + eee + TextBox2.Text.Replace("</DIV></BODY></HTML>", "")) + vbCrLf + zy + vbCrLf + "<P><Font>" + "当前" + eek + "</Font></P>" + vbCrLf + TextBox3.Text + eeb + (TextBox2.Text.Replace("&gt;Next", "&gt;Last")), False, System.Text.Encoding.Default)
                End If
                ToolStripStatusLabel1.Text = "输出" + Str(cs) + "个文件"
                cs = cs + 1
                TextBox1.Text = TextBox1.Text.Remove(0, yyt - 1)
            Loop Until TextBox1.Text.Length < fgzs
            Dim eef = Str(cs).Trim
            If eef.Length = 1 Then
                eef = "00" + eef
            End If
            If eef.Length = 2 Then
                eef = "0" + eef
            End If
            Dim eed = Str(cs - 1).Trim
            If eed.Length = 1 Then
                eed = "00" + eed
            End If
            If eed.Length = 2 Then
                eed = "0" + eed
            End If
            If TextBox1.Text <> "" Then
                Dim zy = TextBox3.Text + "000" + (TextBox2.Text.Replace("&gt;Next", "&gt;000").Replace("</DIV></BODY></HTML>", ""))
                My.Computer.FileSystem.WriteAllText(tmppath + "\" + eed + ".htm", "<html>" + "<head>" + "<title>" + tile + "</title>" + vbCrLf + TextBox1.Text + vbCrLf + zy, False)
                TextBox1.Text = ""
            End If
            Dim ko = ""
            For k = 1 To cs - 1
                Dim eep = Str(k).Trim
                If eep.Length = 1 Then
                    eep = "00" + eep
                End If
                If eep.Length = 2 Then
                    eep = "0" + eep
                End If
                ko = ko + vbCrLf + TextBox3.Text + eep + (TextBox2.Text.Replace("&gt;Next", "&gt;Next" + eep).Replace("</DIV></BODY></HTML>", ""))
            Next
            ko = ko + vbCrLf + TextBox3.Text + yyd + (TextBox2.Text.Replace("&gt;Next", "&gt;Next" + "源文件").Replace("</DIV></BODY></HTML>", "")) + vbCrLf + TextBox3.Text + yyd + "New" + (TextBox2.Text.Replace("&gt;Next", "&gt;Next" + "源文件-New").Replace("</DIV></BODY></HTML>", ""))
            My.Computer.FileSystem.WriteAllText(tmppath + "\" + "000" + ".htm", "<html>" + "<head>" + "<title>" + tile + "</title>" + vbCrLf + "<DIV>" + "<B><P><Font>" + tile + "</Font></P></B>" + vbCrLf + ko + "</DIV></BODY></HTML>", False, System.Text.Encoding.Default)
            If CheckBox2.Checked = True Then
                On Error Resume Next
                Dim tmm = gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0)
                tmppath = tmm
                Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe" + " /Hide " + TextBox7.Text + tmppath + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0) + ".files" + TextBox7.Text, AppWinStyle.Hide, True)
            End If
        End If
    End Function
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox5.Enabled = False
        Else
            TextBox5.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.htm;*.html|*.htm;*.html|*.*|*.*"
            .ShowDialog()
            If .FileNames.Count <> 0 Then
                For v = 0 To .FileNames.Count - 1
                    ListBox1.Items.Remove(.FileNames(v))
                    ListBox1.Items.Add(.FileNames(v))
                    ListBox1.Items.Remove("")
                Next
            End If
        End With
        If ListBox1.Items.Count = 0 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        TextBox1.Text = ""
        WebBrowser1.Url = Nothing
        If ListBox1.Text <> "" Then
            If ListBox1.Text <> "" Then
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Text, System.Text.Encoding.Default)
            End If
            Dim uu As New Uri(ListBox1.Text)
            WebBrowser1.Url = uu
        End If
        If ListBox1.Items.Count <> 0 Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click() Handles Button4.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有网页的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly, "*.htm")
                For qq = 0 To tt.count - 1
                    ListBox1.Items.Remove(tt(qq))
                    ListBox1.Items.Add(tt(qq))
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有网页的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.htm")
                For qq = 0 To tt.count - 1
                    ListBox1.Items.Remove(tt(qq))
                    ListBox1.Items.Add(tt(qq))
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        TextBox1.Text = ""
        ListBox1.Items.Remove(ListBox1.Text)
        WebBrowser1.Url = Nothing
    End Sub
    Private Sub Button7_Click() Handles Button7.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
        WebBrowser1.Url = Nothing
    End Sub
    Private Sub Button8_Click() Handles Button8.Click
        If ListBox1.Text <> "" Then
            If ListBox1.Text <> "" Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ListBox1.Text, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub 添加文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文件ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub 添加目录根ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加目录根ToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Private Sub 添加目录全ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加目录全ToolStripMenuItem.Click
        Button5_Click()
    End Sub
    Private Sub 启动ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 启动ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub Button9_Click() Handles Button9.Click
        End
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Button9_Click()
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem.Click
        Button7_Click()
    End Sub
    Private Sub 打开文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开文件ToolStripMenuItem.Click
        Button8_Click()
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox4.Text <> "" Then
            ListBox2.Items.Remove(TextBox4.Text + "‘" + TextBox5.Text)
            ListBox2.Items.Add(TextBox4.Text + "‘" + TextBox5.Text)
        End If
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ListBox2.Items.Remove(ListBox2.Text)
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ListBox2.Items.Clear()
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Dim lst As New ListBox
        With OpenFileDialog1
            .Multiselect = False
            .FileName = ""
            .Filter = "*.Glst|*.Glst"
            .ShowDialog()
            If .FileName <> "" Then
                Dim r = 1
                Dim i = ""
                Dim kui As String = My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.Default)
                lst.Items.Clear()
                For g = 1 To kui.Length
                    If Mid(kui, g, 10) = "$$!!$$~~%%" Then
                        lst.Items.Add(g)
                    End If
                Next
                lst.Items.Remove("")
                If lst.Items.Count <> 0 Then
                    For y = 0 To lst.Items.Count - 1
                        If y + 1 <= lst.Items.Count - 1 Then
                            ListBox2.Items.Remove((Mid(kui, (lst.Items(y) + 10), lst.Items(y + 1) - (lst.Items(y) + 10))))
                            ListBox2.Items.Add((Mid(kui, (lst.Items(y) + 10), lst.Items(y + 1) - (lst.Items(y) + 10))))
                        End If
                    Next
                End If
                ListBox2.Items.Remove("")
                ListBox2.Items.Remove(vbCr)
            End If
            .Multiselect = True
        End With
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        With SaveFileDialog1
            .FileName = ""
            .Filter = "*.Glst|*.Glst"
            .ShowDialog()
            If .FileName <> "" Then
                Dim ss = ""
                For c = 0 To ListBox2.Items.Count - 1
                    ss = ss + "$$!!$$~~%%" + ListBox2.Items(c)
                Next
                My.Computer.FileSystem.WriteAllText(.FileName, ss + "$$!!$$~~%%", False, System.Text.Encoding.Default)
            End If
        End With
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox6.Text = ""
        TextBox6.Text = ListBox2.Text
    End Sub
    Private Sub HS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.AddMessageFilter(Me)
        DragAcceptFiles(ListBox1.Handle.ToInt32, True)
        If Command() <> "" Then
            Dim bbint As Integer = 0
            For t = 0 To My.Application.CommandLineArgs.Count - 1
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    ListBox1.Items.Remove(My.Application.CommandLineArgs.Item(t))
                    ListBox1.Items.Add(My.Application.CommandLineArgs.Item(t))
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(t), FileIO.SearchOption.SearchAllSubDirectories, "*.htm")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim uu As New Uri("about:blank")
        If WebBrowser1.Url = Nothing Or WebBrowser1.Url = uu Then
            With OpenFileDialog1
                .Multiselect = False
                .FileName = ""
                .Filter = "*.htm;*.html|*.htm;*.html|*.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    Shell("explorer " + .FileName)
                End If
                .Multiselect = True
            End With
        Else
            WebBrowser1.ShowSaveAsDialog()
        End If
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        On Error Resume Next
        If ListBox1.Text <> "" Then
            Dim tmm = gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0)
            tmppath = tmm
            Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe" + " " + TextBox7.Text + gnn.getname(ListBox1.Text, "\", True, 0) + "\" + gnn.getname(gnn.getname(ListBox1.Text, "\", False, 0), ".", True, 0) + ".files" + TextBox7.Text, AppWinStyle.NormalFocus)
        Else
            Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe", AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        On Error Resume Next
        If ListBox1.Items.Count <> 0 And ListBox2.Items.Count <> 0 Then
            With ToolStripProgressBar1
                .Value = 0
                For r = 0 To ListBox1.Items.Count - 1
                    Shell("Attrib -s -r -h " + TextBox7.Text + ListBox1.Items(r) + TextBox7.Text, AppWinStyle.Hide, True)
                    Dim ee As String = My.Computer.FileSystem.ReadAllText(ListBox1.Items(r), System.Text.Encoding.Default)
                    For b = 0 To ListBox2.Items.Count - 1
                        ee = ee.Replace(gnn.getname(ListBox2.Items(b), "‘", True, 0), gnn.getname(ListBox2.Items(b), "‘", False, 0))
                    Next
                    My.Computer.FileSystem.WriteAllText(ListBox1.Items(r), ee, False, System.Text.Encoding.Default)
                    .Value = .Value + Str(ListBox1.Items.Count / 100)
                Next
                ListBox1.Items.Clear()
                TextBox1.Text = ""
                WebBrowser1.Url = Nothing
                MsgBox("Successful！！！", MsgBoxStyle.Information)
            End With
        End If
    End Sub
    Dim ls As Integer = 0
    Dim x As Integer = 0
    Private Sub HtmlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HtmlToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Enabled = False
            ls = ListBox1.Items.Count
            x = 0
            ll.Items.Clear()
            WebBrowser1.Url = Nothing
            Dim uu As New Uri(ListBox1.Items.Item(x))
            WebBrowser1.Url = uu
            Timer1.Enabled = True
        End If
    End Sub
    Dim ll As New ListBox
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Timer1.Enabled = False
        If WebBrowser1.StatusText = "完毕" Then
            If WebBrowser1.DocumentTitle <> "" Then
                If My.Computer.FileSystem.FileExists(WebBrowser1.DocumentTitle.Replace(":", "").Replace("?", "").Replace(TextBox7.Text, "").Replace("/", "").Replace("\", "").Replace("(", "").Replace(")", "").Replace("|", "").Replace("*", "") + ".Html") = False Then
                    My.Computer.FileSystem.RenameFile(ListBox1.Items(x), WebBrowser1.DocumentTitle.Replace(":", "").Replace("?", "").Replace(TextBox7.Text, "").Replace("/", "").Replace("\", "").Replace("(", "").Replace(")", "").Replace("|", "").Replace("*", "") + ".Html")
                    ll.Items.Add(ListBox1.Items(x))
                End If
            End If
            x = x + 1
            Dim uu As New Uri(ListBox1.Items.Item(x))
            WebBrowser1.Url = uu
        End If
        Timer1.Enabled = True
        If x > ls - 1 Then
            WebBrowser1.Url = Nothing
            Timer1.Enabled = False
            MsgBox("Finish！！！", MsgBoxStyle.Information)
            ListBox1.Enabled = True
            If ll.Items.Count <> 0 Then
                For k = 0 To ll.Items.Count - 1
                    ListBox1.Items.Remove(ll.Items.Item(k))
                Next
            End If
        End If
    End Sub
    Dim FJ As New STC.STC
    Function FJJ(ByVal FJC As Boolean)
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Then
            With ToolStripProgressBar1
                .Value = 0
                For r = 0 To ListBox1.Items.Count - 1
                    Shell("Attrib -s -r -h " + TextBox7.Text + ListBox1.Items(r) + TextBox7.Text, AppWinStyle.Hide, True)
                    Dim ee As String = My.Computer.FileSystem.ReadAllText(ListBox1.Items(r), System.Text.Encoding.Default)
                    If FJC = True Then
                        ee = FJ.FCJ(ee)
                    Else
                        ee = FJ.JCF(ee)
                    End If
                    My.Computer.FileSystem.WriteAllText(ListBox1.Items(r), ee, False, System.Text.Encoding.Default)
                    .Value = .Value + Str(ListBox1.Items.Count / 100)
                Next
                ListBox1.Items.Clear()
                TextBox1.Text = ""
                WebBrowser1.Url = Nothing
                MsgBox("Successful！！！", MsgBoxStyle.Information)
            End With
        End If
    End Function
    Private Sub 繁简ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 繁简ToolStripMenuItem.Click
        FJJ(True)
    End Sub
    Private Sub 简繁ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 简繁ToolStripMenuItem.Click
        FJJ(False)
    End Sub
End Class