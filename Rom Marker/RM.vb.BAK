Public Class RM
    Private Sub RM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否退出?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            NotifyIcon1.Icon = Nothing
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub RM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DP.Run(TextBox6)
        NotifyIcon1.Icon = Me.Icon
        Panel3.Height = 104
        RadioButton2.Top = 128
        Panel5.Top = 216 - Panel4.Height
        Me.Height = 360 - Panel4.Height
        Panel4.Height = 0
        getdic()
        If Command() <> "" Then
            RadioButton2.Checked = True
            add(Command.Replace(Label5.Text, ""))
        End If
        NotifyIcon1.ShowBalloonTip(500)
    End Sub
    Function getdic()
        On Error Resume Next
        ComboBox1.Items.Clear()
        Dim k = My.Computer.FileSystem.Drives
        If k.Count <> 0 Then
            For x = 0 To k.Count - 1
                If k(x).DriveType = IO.DriveType.Fixed Or k(x).DriveType = IO.DriveType.Removable Then
                    ComboBox1.Items.Add(k(x))
                End If
            Next
        End If
    End Function
    Dim run = ""
    Dim ico = ""
    Public Sub ComboBox1_SelectedIndexChanged() Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        TextBox1.Text = ""
        TextBox1.Text = My.Computer.FileSystem.GetDriveInfo(ComboBox1.Text).VolumeLabel
        Dim kk As New ListBox
        kk.Items.Clear()
        TextBox2.Text = ""
        TextBox9.Text = "0"
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        Button2.Enabled = True
        Button3.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Dim g = My.Computer.FileSystem.ReadAllText(ComboBox1.Text + "Autorun.inf", System.Text.Encoding.Default)
        ChDrive(ComboBox1.Text)
        TextBox2.Text = (gg.getname(gg.getname(g.ToLower, "open=", False, 0), vbCrLf, True, 1))
        TextBox3.Text = (gg.getname(gg.getname(g.ToLower, "icon=", False, 0), vbCrLf, True, 1)).ToString.Trim.Split(",")(0)
        If (TextBox3.Text.Split(",")(1)).Trim <> "" Then
            TextBox9.Text = (TextBox3.Text.Split(",")(1)).Trim
        Else
            TextBox9.Text = "0"
        End If
        loadpic(ComboBox1.Text)
        If RadioButton1.Checked = True Then
            If ComboBox1.Text <> "" Then
                LinkLabel1.Visible = True
            Else
                LinkLabel1.Visible = False
            End If
        End If
        If TextBox3.Text.Trim <> "" Then
            TextBox9.Enabled = True
            TextBox9.BackColor = Color.White
        Else
            TextBox9.Enabled = False
            TextBox9.BackColor = TextBox2.BackColor
        End If
    End Sub
    Function loadpic(ByVal path As String)
        On Error Resume Next
        Dim dd As Integer
        dd = 0
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        Dim b = My.Computer.FileSystem.ReadAllText(path + "Desktop.ini", System.Text.Encoding.Default)
        TextBox4.Text = (gg.getname(gg.getname(b.ToLower, "iconarea_image=", False, 0), vbCrLf, True, 1))
        ChDir(path)
        PictureBox1.ImageLocation = TextBox4.Text
    End Function
    Function loadinfo()
        On Error Resume Next
        CheckBox2.Checked = False
        If My.Computer.FileSystem.DirectoryExists(TextBox6.Text) = True Then
            If (My.Computer.FileSystem.GetFileInfo(TextBox6.Text).Attributes = 2071) Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
        End If
        TextBox3.Text = ""
        TextBox7.Text = ""
        On Error Resume Next
        Dim dd As Integer
        dd = 0
        ChDir(TextBox6.Text)
        Dim b = My.Computer.FileSystem.ReadAllText(TextBox6.Text + "\" + "Desktop.ini", System.Text.Encoding.Default)
        TextBox7.Text = (gg.getname(gg.getname(b.ToLower, "infotip=", False, 0), vbCrLf, True, 1))
        TextBox3.Text = (gg.getname(gg.getname(b.ToLower, "iconfile=", False, 0), vbCrLf, True, 1))
        TextBox9.Text = (gg.getname(gg.getname(b.ToLower, "iconindex=", False, 0), vbCrLf, True, 1))
        'If (TextBox3.Text.Split(",")(1)).Trim <> "" Then
        '    TextBox9.Text = (TextBox3.Text.Split(",")(1)).Trim
        'Else
        '    TextBox9.Text = "0"
        'End If
    End Function
    Function opp(ByVal sss As Integer)
        On Error Resume Next
        With OpenFileDialog1
            Dim kk = "*.*|*.*"
            If sss = 1 Then
                kk = "*.exe|*.exe"
            End If
            If sss = 2 Then
                kk = "*.ico|*.ico"
            End If
            If sss = 3 Then
                kk = "*.Jpg|*.Jpg"
            End If
            .FileName = ""
            .Filter = kk
            .ShowDialog()
            If .FileName <> "" Then
                If sss = 1 Then
                    TextBox2.Text = .FileName
                    run = ""
                    run = gg.getname(.FileName, "\", False, 0)
                End If
                If sss = 2 Then
                    TextBox3.Text = .FileName
                    ico = ""
                    ico = gg.getname(.FileName, "\", False, 0)
                    TextBox9.Text = "0"
                    If TextBox3.Text.Trim <> "" Then
                        TextBox9.Enabled = True
                        TextBox9.BackColor = Color.White
                    Else
                        TextBox9.Enabled = False
                        TextBox9.BackColor = TextBox2.BackColor
                    End If
                End If
                If sss = 3 Then
                    TextBox4.Text = .FileName
                    PictureBox1.ImageLocation = TextBox4.Text
                End If
            End If
        End With
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getdic()
        LinkLabel1.Visible = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        TextBox9.Enabled = False
        TextBox9.BackColor=textbox2.BackColor 
        CheckBox2.Enabled = False
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        run = ""
        ico = ""
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        On Error Resume Next
        If TextBox1.Text <> "" And RadioButton1.Checked = True Then
            NotifyIcon1.Text = TextBox1.Text
        Else
            If TextBox7.Text <> "" And RadioButton2.Checked = True Then
                NotifyIcon1.Text = TextBox7.Text
            Else
                NotifyIcon1.Text = "个性制作[Made By GhostGzt In 2010]"
            End If
        End If
        If RadioButton1.Checked = True Then
            ChDir(ComboBox1.Text)
        Else
            ChDir(TextBox6.Text)
        End If
        NotifyIcon1.Icon = Me.Icon
        If TextBox3.Text <> "" Then
            NotifyIcon1.Icon = System.Drawing.Icon.ExtractAssociatedIcon(TextBox3.Text)
        End If
    End Sub
    Dim gg As New GN
    Function ky(ByVal path As String, ByVal file As String, ByVal xx As String)
        On Error Resume Next
        If CheckBox1.Checked = True Then
            Dim g = My.Computer.FileSystem.ReadAllText(path + file, System.Text.Encoding.Default)
            ChDir(path)
            Dim qqu = gg.getname(gg.getname(g.ToLower, xx, False, 0), vbCrLf, True, 1).ToString.Trim.Split(",")(0)
            Shell("Attrib -s -r -h " + Label5.Text + path + qqu + Label5.Text, AppWinStyle.Hide, True)
            My.Computer.FileSystem.DeleteFile(path + qqu)
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opp(1)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        opp(2)
    End Sub
    Private Sub 运行程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 运行程序ToolStripMenuItem.Click
        On Error Resume Next
        Shell(TextBox2.Text, AppWinStyle.NormalFocus)
    End Sub
    Private Sub NotifyIcon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If My.Computer.FileSystem.FileExists(TextBox2.Text) = True And RadioButton1.Checked = True Then
            运行程序ToolStripMenuItem.Visible = True
            ToolStripSeparator1.Visible = True
        Else
            运行程序ToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If My.Computer.FileSystem.FileExists(TextBox2.Text) = True Then
            Shell(TextBox2.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub Button4_Click() Handles Button4.Click
        On Error Resume Next
        If RadioButton1.Checked = True Then
            If ComboBox1.Text <> "" Then
                Dim g = My.Computer.FileSystem.ReadAllText(ComboBox1.Text + "Desktop.ini", System.Text.Encoding.Default)
                Dim q1 = gg.getname(gg.getname(g.ToLower, "iconarea_image=", False, 0), vbCrLf, True, 1)
                If TextBox4.Text.Replace(ComboBox1.Text, "").ToLower <> q1.ToString.ToLower Then
                    ky(ComboBox1.Text, "Desktop.ini", "iconarea_image=")
                End If
                Dim w = My.Computer.FileSystem.ReadAllText(ComboBox1.Text + "Autorun.inf", System.Text.Encoding.Default)
                Dim d1 = gg.getname(gg.getname(w.ToLower, "icon=", False, 0), vbCrLf, True, 1).ToString.Trim.Split(",")(0)
                Dim d2 = gg.getname(gg.getname(w.ToLower, "open=", False, 0), vbCrLf, True, 1)
                If TextBox3.Text.Replace(ComboBox1.Text, "").ToLower <> d1.ToString.ToLower Then
                    ky(ComboBox1.Text, "Autorun.inf", "icon=")
                End If
                If TextBox2.Text.Replace(ComboBox1.Text, "").ToLower <> d2.ToString.ToLower Then
                    ky(ComboBox1.Text, "Autorun.inf", "open=")
                End If
                If TextBox3.Text <> "" Then
                    If TextBox3.Text <> ComboBox1.Text + ico Then
                        My.Computer.FileSystem.CopyFile(TextBox3.Text, ComboBox1.Text + ico)
                        Shell("Attrib +h " + Label5.Text + ComboBox1.Text + ico + Label5.Text, AppWinStyle.Hide, True)
                    End If
                    ico = ""
                    ico = gg.getname(TextBox3.Text, "\", False, 0)
                    If ico = "" Then
                        ico = TextBox3.Text
                    End If
                    run = ""
                    run = gg.getname(TextBox2.Text, "\", False, 0)
                    If run = "" Then
                        run = TextBox2.Text
                    End If
                    Dim k = "[Autorun]" + vbCrLf + "icon=" + ico
                    If TextBox2.Text <> "" Then
                        If TextBox2.Text <> ComboBox1.Text + run Then
                            My.Computer.FileSystem.CopyFile(TextBox2.Text, ComboBox1.Text + run, True)
                            Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + run + Label5.Text, AppWinStyle.Hide, True)
                        End If
                        k = "[Autorun]" + vbCrLf + "open=" + run + vbCrLf + "icon=" + ico + "," + TextBox9.Text
                    Else
                        k = "[Autorun]" + vbCrLf + "icon=" + ico + "," + TextBox9.Text
                    End If
                    Shell("Attrib -s -r -h " + Label5.Text + ComboBox1.Text + "Autorun.inf" + Label5.Text, AppWinStyle.Hide, True)
                    My.Computer.FileSystem.DeleteFile(ComboBox1.Text + "Autorun.inf")
                    My.Computer.FileSystem.WriteAllText(ComboBox1.Text + "Autorun.inf", k, False, System.Text.Encoding.Default)
                    Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + "Autorun.inf" + Label5.Text, AppWinStyle.Hide, True)
                Else
                    Shell("Attrib -s -r -h " + Label5.Text + ComboBox1.Text + "Autorun.inf" + Label5.Text, AppWinStyle.Hide, True)
                    My.Computer.FileSystem.DeleteFile(ComboBox1.Text + "Autorun.inf")
                    If TextBox3.Text = "" And TextBox2.Text <> "" Then
                        run = ""
                        run = gg.getname(TextBox2.Text, "\", False, 0)
                        If run = "" Then
                            run = TextBox2.Text
                        End If
                        If TextBox2.Text <> ComboBox1.Text + run Then
                            My.Computer.FileSystem.CopyFile(TextBox2.Text, ComboBox1.Text + run, True)
                            Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + run + Label5.Text, AppWinStyle.Hide, True)
                        End If
                        Dim k
                        k = "[Autorun]" + vbCrLf + "open=" + run
                        My.Computer.FileSystem.WriteAllText(ComboBox1.Text + "Autorun.inf", k, False, System.Text.Encoding.Default)
                        Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + "Autorun.inf" + Label5.Text, AppWinStyle.Hide, True)
                    End If
                End If
                Dim pic = gg.getname(TextBox4.Text, "\", False, 0)
                If pic = "" Then
                    pic = TextBox4.Text
                End If
                If My.Computer.FileSystem.FileExists(TextBox4.Text) = True Then
                    If TextBox4.Text <> ComboBox1.Text + pic Then
                        My.Computer.FileSystem.CopyFile(TextBox4.Text, ComboBox1.Text + pic, True)
                    End If
                    Shell("Attrib -s -r -h " + Label5.Text + ComboBox1.Text + "Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    My.Computer.FileSystem.DeleteFile(ComboBox1.Text + "Desktop.ini")
                    My.Computer.FileSystem.WriteAllText(ComboBox1.Text + "Desktop.ini", TextBox5.Text.Replace("PPPP", pic), False, System.Text.Encoding.Default)
                    Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + "Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + pic + Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + ico + Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s +r +h " + Label5.Text + ComboBox1.Text + run + Label5.Text, AppWinStyle.Hide, True)
                End If
                If TextBox4.Text = "" Then
                    Shell("Attrib -s -r -h " + Label5.Text + ComboBox1.Text + "Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    My.Computer.FileSystem.DeleteFile(ComboBox1.Text + "Desktop.ini")
                End If
                Dim r = -1
                If TextBox1.Text <> "" Then
                    Dim t = My.Computer.FileSystem.Drives
                    For x = 0 To t.Count - 1
                        If t(x).ToString.Trim = ComboBox1.Text.Trim Then
                            r = x
                        End If
                    Next
                    If r <> -1 Then
                        My.Computer.FileSystem.Drives(r).VolumeLabel = TextBox1.Text
                    End If
                Else
                    Dim t = My.Computer.FileSystem.Drives
                    For x = 0 To t.Count - 1
                        If t(x).ToString.Trim = ComboBox1.Text.Trim Then
                            r = x
                        End If
                    Next
                    If r <> -1 Then
                        My.Computer.FileSystem.Drives(ComboBox1.SelectedIndex).VolumeLabel = ""
                    End If
                End If
                If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                    Shell("explorer " + Label5.Text + ComboBox1.Text + Label5.Text, AppWinStyle.MaximizedFocus)
                End If
            Else
                MsgBox("请选择盘符！", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        Else
            If TextBox6.Text <> "" Then
                If TextBox7.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
                    Shell("Attrib -s -r -h " + Label5.Text + TextBox6.Text + "\Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    ky(TextBox6.Text + "\", "Desktop.ini", "iconfile=")
                    ky(TextBox6.Text + "\", "Desktop.ini", "iconarea_image=")
                    My.Computer.FileSystem.DeleteFile(TextBox6.Text + "\Desktop.ini")
                    Shell("Attrib -s " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.Hide, True)
                    If MsgBox("清除成功！！！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                        Shell("explorer " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.MaximizedFocus)
                    End If
                Else
                    Dim g = My.Computer.FileSystem.ReadAllText(TextBox6.Text + "\Desktop.ini", System.Text.Encoding.Default)
                    Dim q1 = gg.getname(gg.getname(g.ToLower, "iconfile=", False, 0), vbCrLf, True, 1)
                    Dim q2 = gg.getname(gg.getname(g.ToLower, "iconarea_image=", False, 0), vbCrLf, True, 1)
                    If TextBox3.Text.Replace(TextBox6.Text + "\", "").ToLower <> q1.ToString.ToLower Then
                        ky(TextBox6.Text + "\", "Desktop.ini", "iconfile=")
                    End If
                    If TextBox4.Text.Replace(TextBox6.Text + "\", "").ToLower <> q2.ToString.ToLower Then
                        ky(TextBox6.Text + "\", "Desktop.ini", "iconarea_image=")
                    End If
                    Dim pic = gg.getname(TextBox4.Text, "\", False, 0)
                    If pic = "" Then
                        pic = TextBox4.Text
                    End If
                    ChDir(TextBox6.Text)
                    Shell("Attrib -s -r -h " + Label5.Text + TextBox6.Text + "\Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    My.Computer.FileSystem.DeleteFile(TextBox6.Text + "\Desktop.ini")
                    If TextBox3.Text = "" Then
                        ico = ""
                    Else
                        ico = ""
                        ico = gg.getname(TextBox3.Text, "\", False, 0)
                        If ico = "" Then
                            ico = TextBox3.Text
                        End If
                        If My.Computer.FileSystem.FileExists(ico) = False Then
                            My.Computer.FileSystem.CopyFile(TextBox3.Text, ico)
                            Shell("Attrib +h " + TextBox6.Text + ico, AppWinStyle.Hide, True)
                        End If
                    End If
                    If TextBox4.Text = "" Then
                        pic = ""
                    Else
                        If My.Computer.FileSystem.FileExists(TextBox4.Text) = True Then
                            If My.Computer.FileSystem.FileExists(pic) = False Then
                                My.Computer.FileSystem.CopyFile(TextBox4.Text, pic, True)
                            End If
                        End If
                    End If
                    My.Computer.FileSystem.WriteAllText(TextBox6.Text + "\Desktop.ini", TextBox8.Text.Replace("PPPP", pic).Replace("TTTT", ico).Replace("HHHH", TextBox9.Text).Replace("IIII", TextBox7.Text), False, System.Text.Encoding.Default)
                    Shell("Attrib +s +r +h " + Label5.Text + TextBox6.Text + "\Desktop.ini" + Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s +r +h " + Label5.Text + TextBox6.Text + "\" + pic + Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s +r +h " + Label5.Text + TextBox6.Text + "\" + ico + Label5.Text, AppWinStyle.Hide, True)
                    If CheckBox2.Checked = True Then
                        Shell("Attrib +h +r +s " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.Hide, True)
                    Else
                        Shell("Attrib  -s -r -h " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.Hide, True)
                        Shell("Attrib +s " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.Hide, True)
                    End If
                    If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                        Shell("explorer " + Label5.Text + TextBox6.Text + Label5.Text, AppWinStyle.MaximizedFocus)
                    End If
                End If
            Else
                    MsgBox("请选择目录！", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("是否退出?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            NotifyIcon1.Icon = Nothing
            End
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox2.Text = ""
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox3.Text = ""
        TextBox9.Enabled = False
        TextBox9.Text = "0"
        TextBox9.BackColor = TextBox2.BackColor
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        opp(3)
    End Sub
    Private Sub RadioButton1_CheckedChanged() Handles RadioButton1.CheckedChanged
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        If RadioButton1.Checked = True Then
            CheckBox2.Visible = False
            Panel1.Enabled = True
            If ComboBox1.Text <> "" Then
                ComboBox1_SelectedIndexChanged()
            End If
            RadioButton2.Checked = False
            Panel2.Enabled = False
            Panel3.Height = 104
            RadioButton2.Top = 128
            Panel5.Top = 216 - Panel4.Height
            Me.Height = 360 - Panel4.Height
            Panel4.Height = 0
            If ComboBox1.Text <> "" Then
                LinkLabel1.Visible = True
            Else
                LinkLabel1.Visible = False
            End If
        End If
        If TextBox3.Text.Trim <> "" Then
            TextBox9.Enabled = True
            TextBox9.BackColor = Color.White
        Else
            TextBox9.Enabled = False
            TextBox9.BackColor = TextBox2.BackColor
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged() Handles RadioButton2.CheckedChanged
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        If RadioButton2.Checked = True Then
            CheckBox2.Visible = True
            Panel2.Enabled = True
            RadioButton1.Checked = False
            Panel1.Enabled = False
            If TextBox6.Text <> "" Then
                loadpic(TextBox6.Text + "\")
            End If
            loadinfo()
            Panel4.Height = 73
            Panel5.Top = 216 - Panel3.Height
            Me.Height = 360 - Panel3.Height
            RadioButton2.Top = 128 - Panel3.Height
            Panel4.Top = 145 - Panel3.Height
            Panel3.Height = 0
            If TextBox6.Text <> "" Then
                LinkLabel1.Visible = True
            Else
                LinkLabel1.Visible = False
            End If
        End If
        If TextBox3.Text.Trim <> "" Then
            TextBox9.Enabled = True
            TextBox9.BackColor = Color.White
        Else
            TextBox9.Enabled = False
            TextBox9.BackColor = TextBox2.BackColor
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = True
            .Description = "请选择目录"
            .ShowDialog()
            If .SelectedPath <> "" Then
                If My.Computer.FileSystem.DirectoryExists(.SelectedPath) = True Then
                    TextBox6.Text = ""
                    If Len(.SelectedPath) = 3 Then
                        ComboBox1.Text = .SelectedPath
                        RadioButton1.Checked = True
                    Else
                        TextBox6.Text = .SelectedPath
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub TextBox6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.DoubleClick
        Dim q = InputBox("请输入目录路径:", "输入路径", "")
        add(q)
    End Sub
    Function add(ByVal q As String)
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(q) = True Then
            If Len(q) <= 3 And Len(q) >= 2 Then
                If Len(q) = 2 Then
                    ComboBox1.Text = q.ToUpper + "\"
                Else
                    ComboBox1.Text = q
                End If
                RadioButton1.Checked = True
            Else
                TextBox6.Text = q
              
            End If
        Else
            MsgBox("输入路径错误！！！", MsgBoxStyle.Exclamation, "敬告！")
        End If
    End Function
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            NotifyIcon1.Text = TextBox1.Text
        Else
            NotifyIcon1.Text = "个性制作[Made By GhostGzt In 2010]"
        End If
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text <> "" Then
            NotifyIcon1.Text = TextBox7.Text
        Else
            NotifyIcon1.Text = "个性制作[Made By GhostGzt In 2010]"
        End If
    End Sub
    Public Sub TextBox6_TextChanged() Handles TextBox6.TextChanged
        If TextBox6.Text <> "" Then
            If My.Computer.FileSystem.DirectoryExists(TextBox6.Text) = True Then
                If Len(TextBox6.Text) <= 3 And Len(TextBox6.Text) >= 2 Then
                    ComboBox1.Text = TextBox6.Text
                    RadioButton1.Checked = True
                    TextBox6.Text = ""
                Else
                    CheckBox2.Enabled = True
                    TextBox9.Text = "0"
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    PictureBox1.Image = Nothing
                    Button3.Enabled = True
                    Button7.Enabled = True
                    Button8.Enabled = True
                    Button9.Enabled = True
                    loadpic(TextBox6.Text + "\")
                    loadinfo()
                    RadioButton2.Checked = True
                End If
            End If
        End If
        If RadioButton2.Checked = True Then
            If TextBox6.Text <> "" Then
                LinkLabel1.Visible = True
            Else
                LinkLabel1.Visible = False
            End If
        End If
        If TextBox3.Text.Trim <> "" Then
            TextBox9.Enabled = True
            TextBox9.BackColor = Color.White
        Else
            TextBox9.Enabled = False
            TextBox9.BackColor = TextBox2.BackColor
        End If
    End Sub
    Private Sub 制作ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 制作ToolStripMenuItem.Click
        AboutBox1.Close()
        Button4_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        If MsgBox("是否退出?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            NotifyIcon1.Icon = Nothing
            End
        End If
    End Sub
    Private Sub 方式ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 方式ToolStripMenuItem.DropDownOpening
        If RadioButton1.Checked = True Then
            磁盘ToolStripMenuItem.Enabled = False
            目录ToolStripMenuItem.Enabled = True
            磁盘ToolStripMenuItem.Checked = True
            目录ToolStripMenuItem.Checked = False
        Else
            磁盘ToolStripMenuItem.Enabled = True
            目录ToolStripMenuItem.Enabled = False
            磁盘ToolStripMenuItem.Checked = False
            目录ToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub 磁盘ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 磁盘ToolStripMenuItem.Click
        AboutBox1.Close()
        RadioButton1.Checked = True
    End Sub
    Private Sub 目录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 目录ToolStripMenuItem.Click
        AboutBox1.Close()
        RadioButton2.Checked = True
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(TextBox4.Text) = True Then
            Shell("Rundll32.exe url.dll, FileProtocolHandler " + TextBox4.Text)
        End If
    End Sub
    Function reg()
        On Error Resume Next
        Dim pp As String
        pp = My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe"
        pp = pp.Replace("\", "\\").Replace(Label5.Text, "")
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$R1.reg", reg1.Text.Replace("%PATH%", pp), False, System.Text.Encoding.Default)
        Shell("regedit /s " + Label5.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$R1.reg" + Label5.Text, AppWinStyle.Hide)
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$R2.reg", reg2.Text.Replace("%PATH%", pp), False, System.Text.Encoding.Default)
        Shell("regedit /s " + Label5.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$R2.reg" + Label5.Text, AppWinStyle.Hide)
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$R1.reg")
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$R2.reg")
        MsgBox("注册成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
    End Function
    Private Sub 注册菜单ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 注册菜单ToolStripMenuItem.Click
        If MsgBox("你确定要注册到菜单?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            reg()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        Edit.TextBox1.Text = ""
        Edit.TextBox2.Text = ""
        Edit.TabControl1.TabPages.Remove(Edit.TabPage1)
        Edit.TabControl1.TabPages.Remove(Edit.TabPage2)
        Edit.TextBox1.Enabled = False
        Edit.Text = ""
        Edit.Label1.Text = ""
        Edit.TextBox1.Text = ""
        If RadioButton1.Checked = True And ComboBox1.Text <> "" Then
            Edit.Text = "手动编辑 - Autorun.inf"
            Edit.Label1.Text = "Path:" + vbCrLf + ComboBox1.Text
            Edit.TextBox1.Text = My.Computer.FileSystem.ReadAllText(ComboBox1.Text + "Autorun.inf", System.Text.Encoding.Default)
            Edit.TextBox2.Text = My.Computer.FileSystem.ReadAllText(ComboBox1.Text + "Desktop.ini", System.Text.Encoding.Default)
            Edit.TextBox1.Enabled = True
            Edit.TabControl1.TabPages.Add(Edit.TabPage1)
            Edit.TabControl1.SelectedTab = Edit.TabPage1
            Edit.TabControl1.TabPages.Add(Edit.TabPage2)
            GoTo g
        Else
            If RadioButton2.Checked = True And TextBox6.Text <> "" Then
                Edit.Text = "手动编辑 - Desktop.ini"
                Edit.Label1.Text = "Path:" + vbCrLf + TextBox6.Text
                Edit.TextBox2.Text = My.Computer.FileSystem.ReadAllText(TextBox6.Text + "\Desktop.ini", System.Text.Encoding.Default)
                Edit.TextBox1.Enabled = False
                Edit.TabControl1.TabPages.Add(Edit.TabPage2)
                Edit.TabControl1.SelectedTab = Edit.TabPage2
                GoTo g
            End If
        End If
        Exit Sub
g:      Me.Hide()
        Edit.ShowDialog()
        Me.Show()
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text.Trim = "" Then
            TextBox9.Text = "0"
        End If
    End Sub
End Class