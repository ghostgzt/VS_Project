Public Class QSF
    Dim db As Boolean = False
    Dim te As System.Text.Encoding = System.Text.Encoding.UTF8
    Dim jt = My.Computer.FileSystem.SpecialDirectories.Temp + "\$JEE163.tmp"
    Private Sub QSF_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon1.Icon = Nothing
        On Error Resume Next
        Kill(jt)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\QSF-Temp", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Private Sub ShowFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\QSF", "ST", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\QSF", "YL", Nothing)
        If r1 = "" Or r1 = "0" Then
            ComboBox1.Text = ComboBox1.Items(0).ToString
            列表ToolStripMenuItem_Click()
        Else
            ComboBox1.Text = ComboBox1.Items(1).ToString
            图标ToolStripMenuItem_Click()
        End If
        If r2 = "" Or r2 = "0" Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
        If Command() <> "" Then
            TextBox3.Text = Command().Replace(TextBox2.Text, "")
            Button1_ButtonClick()
        End If
        ComboBox2.Text = "UTF-8"
        cls()
    End Sub
    Function Run()
        On Error Resume Next
        Me.Hide()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Text = "Opening Jar File" + vbCrLf + "Please Wait Some Time！"
        NotifyIcon1.ShowBalloonTip(100)
        cls()
        If TextBox3.Text <> "" And My.Computer.FileSystem.FileExists(TextBox3.Text) = True Then
            opp()
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.cmd")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF")
            Dim ttemp As String = TextBox2.Text + jt + TextBox2.Text + " -l " + TextBox2.Text + TextBox3.Text + TextBox2.Text + " > " + TextBox2.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.tmp" + TextBox2.Text
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.cmd", ttemp, False, System.Text.Encoding.Default)
            Shell(TextBox2.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.cmd" + TextBox2.Text, AppWinStyle.Hide, True)
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.tmp", System.Text.Encoding.Default)
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.cmd")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$SF.tmp")
            uuu(0, TextBox1.Text.Length, ListBox1)
            ListView1.Items.Clear()
            Dim t0
            Dim t1
            ListBox2.Items.Clear()
            For x = 0 To ListBox1.Items.Count - 1
                t0 = ListBox1.Items(x).ToString()
                If x + 1 < ListBox1.Items.Count - 1 Then
                    t1 = ListBox1.Items(x + 1).ToString()
                Else
                    t1 = TextBox1.Text.Length
                End If
                ListBox2.Items.Add(Mid(TextBox1.Text, Int(t0) + 3, Int(t1) - (t0)))
            Next
            For y = 0 To 2
                ListBox2.Items.RemoveAt(0)
            Next
            TextBox1.Text = ListBox2.Items(ListBox2.Items.Count - 2).ToString
            For z = 0 To 2
                ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            Next
            For t = 0 To ListBox2.Items.Count - 1
                Dim r = Mid(ListBox2.Items(t).ToString(), 29, Len(ListBox2.Items(t).ToString()) - 29).Trim
                Dim kk = getkzm(r)
                Dim time = Mid(ListBox2.Items(t).ToString(), 12, 26 - 12).Trim
                Dim dx = Mid(ListBox2.Items(t).ToString(), 1, 11).Trim
                Dim gg = Nothing
                Dim doc = Nothing
                For tb = 0 To r.Length - 1
                    If Mid(r, tb + 1, 1) = "/" And Mid(r, Len(r), 1) <> "/" Then
                        gg = tb
                    End If
                Next
                If Mid(r, Len(r), 1) = "/" Then
                    doc = True
                End If
                Dim kb = ""
                If (gg) <> Nothing Then
                    kb = Mid(r, gg + 1, Len(r) - gg + 1)
                Else
                    kb = r
                End If
                Dim ky = ""
                If (gg) <> Nothing Then
                    ky = Mid(r, 1, gg + 1)
                Else
                    ky = "/"
                End If
                If doc = True Then
                    ky = ""
                End If
                If ToolStripComboBox1.Text.Trim = "" Then
                    ToolStripComboBox1.Text = "*.*"
                End If
                If ToolStripComboBox1.Text.Trim = "*." Then
                    ToolStripComboBox1.Text = "*."
                    GoTo b
                End If
                If ToolStripComboBox1.Text.Trim = "." Then
                    ToolStripComboBox1.Text = "*.*"
                    GoTo b
                End If
                If getname(ToolStripComboBox1.Text, ".", False, 0) = "" Then
                    If getname((getname(ToolStripComboBox1.Text, ".", True, 0).ToString.Trim.ToUpper), "*", False, 0) = "" Then
                        ToolStripComboBox1.Text = "*." + ToolStripComboBox1.Text
                    Else
                        ToolStripComboBox1.Text = ToolStripComboBox1.Text + "."
b:                  End If
                Else
                    If (getname(ToolStripComboBox1.Text, ".", True, 0).ToString.Trim.ToUpper) = "" Then
                        If getname((getname(ToolStripComboBox1.Text, ".", True, 0).ToString.Trim.ToUpper), "*", False, 0) = "" Then
                            ToolStripComboBox1.Text = "*" + ToolStripComboBox1.Text
                        End If
                    End If
                End If
                If ToolStripComboBox1.Text.Trim = "*.*" Then
g:                  ListView1.Items.Add(kb, kk)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ky)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dx)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(time)
                Else
                    Dim wjQ = (getname(kb, ".", True, 0).ToString.Trim.ToUpper)
                    Dim wjH = (getname(kb, ".", False, 0).ToString.Trim.ToUpper)
                    Dim km = (getname(ToolStripComboBox1.Text, ".", True, 0).ToString.Trim.ToUpper)
                    Dim rg As Boolean = False
                    If km <> (km.Replace("*", "")) Then
                        If wjQ.Trim.Length <= Len(wjQ.Replace(km.Replace("*", ""), "").Trim) Then
                        Else
                            If wjQ.Trim.ToUpper <> wjQ.Replace(km.Replace("*", ""), "").Trim.ToUpper Or wjQ = km Then
                                rg = True
                            Else
                                rg = False
                            End If
                        End If
                    Else
                        If wjQ = km Then
                            rg = True
                        Else
                            rg = False
                        End If
                    End If
                    Dim kz = (getname(ToolStripComboBox1.Text, ".", False, 0).ToString.Trim.ToUpper)
                    If km.Replace("*", "").Trim = "" And kz.Replace("*", "").Trim <> "" Then
                        If (wjH = kz And ky <> "") Or (wjQ = km And ky <> "") Then
                            GoTo g
                        End If
                    Else
                        If km.Replace("*", "").Trim <> "" And kz.Replace("*", "").Trim = "" Then
                            If (rg = True And ky <> "") Or (wjH = kz And ky <> "") Then
                                GoTo g
                            End If
                        End If
                        If km.Replace("*", "").Trim <> "" And kz.Replace("*", "").Trim <> "" Then
                            If (rg = True And ky <> "") And (wjH = kz And ky <> "") Then
                                GoTo g
                            End If
                        End If
                        If km.Replace("*", "").Trim = "" And kz.Replace("*", "").Trim = "" Then
                            If (wjH = kz And ky <> "") Then
                                GoTo g
                            End If
                        End If
                    End If
                End If
            Next
            AU()
            Me.Text = "QSF-" + TextBox3.Text
        End If
        ToolStripStatusLabel2.Text = "总共" + Str(ListView1.Items.Count) + "个文件！"
        ListView1_SelectedIndexChanged()
        NotifyIcon1.Icon = Nothing
        NotifyIcon1.Text = ""
        Me.Show()
    End Function
    Function AU()
        On Error Resume Next
        If ListView1.Items.Count <> 0 Then
            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.Columns.Item(2).Width = 80
            ListView1.Columns.Item(3).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        Else
            ListView1.Columns.Item(0).Width = 60
            ListView1.Columns.Item(1).Width = 60
            ListView1.Columns.Item(2).Width = 80
            ListView1.Columns.Item(3).Width = 60
        End If
    End Function
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)) = str1f Then
                    If i < n Or n = 0 Then
                        q = u
                        i = i + 1
                    End If
                End If
            Next
        End If
        If q <> "" Then
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
    Function getkzm(ByVal str As String)
        Dim kzm = getname(str, ".", False, 0).ToString.ToUpper.Trim
        If kzm = "TXT" Then
            Return "txt"
        End If
        If kzm = "PNG" Then
            Return "png"
        End If
        If kzm = "GIF" Then
            Return "png"
        End If
        If kzm = "JPG" Then
            Return "png"
        End If
        If kzm = "BMP" Then
            Return "png"
        End If
        If kzm = "MID" Then
            Return "mid"
        End If
        If kzm = "WAV" Then
            Return "mid"
        End If
        If kzm = "AMR" Then
            Return "mid"
        End If
        If kzm = "OGG" Then
            Return "mid"
        End If
        If kzm = "MP3" Then
            Return "mid"
        End If
        If kzm = "" Then
g:          If Mid(str, Len(str), 1) = "/" Then
                Return "Doc"
            End If
            Return "wu"
        End If
        If kzm = "CLASS" Then
            Return "class"
        End If
        If kzm = "MF" Then
            Return "mf"
        End If
        If kzm = "BAK" Then
            Return "bak"
        End If
        If kzm = "HTM" Then
            Return "htm"
        End If
        If kzm = "HTML" Then
            Return "htm"
        End If
        GoTo g
        Return "wu"
    End Function
    Function uuu(ByVal x As Integer, ByVal uu As Integer, ByVal listboxx As Windows.Forms.ListBox)
        On Error Resume Next
        listboxx.Items.Clear()
        listboxx.Items.Add(-2)
        For y = x To uu - 1
            If Mid(TextBox1.Text, y + 1, 2) = vbCrLf Then
                listboxx.Items.Add(y)
            End If
        Next
        listboxx.SetSelected(0, True)
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.Jar|*.Jar|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox3.Text = .FileName
                Button1_ButtonClick()
            End If
        End With
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "列表" Then
            列表ToolStripMenuItem_Click()
        Else
            图标ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub ListView1_DoubleClick() Handles ListView1.DoubleClick
        On Error Resume Next
        opp()
        Dim olddir = ""
        Dim y = "QSF-Temp"
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y)
        olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y
        ChDir(olddir)
        My.Computer.FileSystem.DeleteDirectory(olddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Dim kkv = (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/")
        If Mid(kkv, 1, 1) = "/" Then
            kkv = Mid(kkv, 2, Len(kkv) - 1)
        End If
        If Mid(kkv, Len(kkv), 1) <> "/" Then
            Shell(TextBox2.Text + jt + TextBox2.Text + " -o " + " " + TextBox2.Text + TextBox3.Text + TextBox2.Text + " " + TextBox2.Text + kkv + TextBox2.Text, AppWinStyle.Hide, True)
            Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/").Replace("/", "\"), AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub 属性ToolStripMenuItem_Click() Handles 属性ToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems.Count = 1 Then
                On Error Resume Next
                AT.TextBox1.Text = ""
                AT.PictureBox1.Image = Nothing
                opp()
                Dim olddir = ""
                Dim y = "QSF-Temp"
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y)
                olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y
                ChDir(olddir)
                My.Computer.FileSystem.DeleteDirectory(olddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
                AT.Label1.Text = "文件" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).Text).Replace("//", "/") + vbCrLf + "大小共" + Str(Int(Int(ListView1.SelectedItems(0).SubItems(2).Text) / 1024)) + "k" + vbCrLf + "创建日期:" + ListView1.SelectedItems(0).SubItems(3).Text
                AT.Text = ListView1.SelectedItems(0).Text + "属性"
                Dim kkv = (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/")
                If Mid(kkv, 1, 1) = "/" Then
                    kkv = Mid(kkv, 2, Len(kkv) - 1)
                End If
                If Mid(kkv, Len(kkv), 1) <> "/" Then
                    Shell(TextBox2.Text + jt + TextBox2.Text + " -o " + " " + TextBox2.Text + TextBox3.Text + TextBox2.Text + " " + TextBox2.Text + kkv + TextBox2.Text, AppWinStyle.Hide, True)
                    AT.PictureBox1.Image = Nothing
                    AT.PictureBox1.Image = Image.FromFile((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/").Replace("/", "\")).Replace("\\", "\"))
                    If AT.PictureBox1.Image Is Nothing Then
                        AT.TextBox1.Visible = True
                        AT.TextBox1.Text = ""
                        AT.TextBox1.Text = My.Computer.FileSystem.ReadAllText((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/").Replace("/", "\")).Replace("\\", "\")).Replace(vbLf, vbCrLf)
                    Else
                        AT.TextBox1.Visible = False
                    End If
                End If
                If AT.PictureBox1.Image Is Nothing Then
                    If AT.TextBox1.Text = "" Then
                        MsgBox("文件夹" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).Text).Replace("//", "/") + vbCrLf + "大小共" + Str(Int(ListView1.SelectedItems(0).SubItems(2).Text) / 1024) + "k" + vbCrLf + "创建日期:" + ListView1.SelectedItems(0).SubItems(3).Text, MsgBoxStyle.Information, ListView1.SelectedItems(0).Text + "属性")
                    Else
                        AT.ShowDialog()
                    End If
                Else
                    AT.ShowDialog()
                End If
            Else
                Dim hhb As Integer = 0
                For w = 0 To ListView1.SelectedItems.Count - 1
                    hhb = hhb + Int(ListView1.SelectedItems(w).SubItems(2).Text)
                Next
                MsgBox("选择文件数:" + Str(ListView1.SelectedItems.Count) + vbCrLf + "大小共" + Str(Int(hhb / 1024)) + "k", MsgBoxStyle.Information, "属性")
            End If
        End If
    End Sub
    Private Sub 复制到ToolStripMenuItem_Click() Handles 复制到ToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .ShowDialog()
                If .SelectedPath <> "" Then
                    opp()
                    ToolStripProgressBar1.Value = 0
                    Dim uuq As Integer = ListView1.SelectedItems.Count / 100
                    For c = 0 To ListView1.SelectedItems.Count - 1
                        ChDir(.SelectedPath)
                        Dim kkv = (ListView1.SelectedItems(c).SubItems(1).Text + ListView1.SelectedItems(c).SubItems(0).Text).Replace("//", "/")
                        If Mid(kkv, 1, 1) = "/" Then
                            kkv = Mid(kkv, 2, Len(kkv) - 1)
                        End If
                        If Mid(kkv, Len(kkv), 1) <> "/" Then
                            If My.Computer.FileSystem.FileExists(.SelectedPath + "\" + (ListView1.SelectedItems(c).SubItems(1).Text + ListView1.SelectedItems(c).SubItems(0).Text).Replace("//", "/").Replace("/", "\")) = True Then
                                Kill(.SelectedPath + "\" + (ListView1.SelectedItems(c).SubItems(1).Text + ListView1.SelectedItems(c).SubItems(0).Text).Replace("//", "/").Replace("/", "\"))
                            End If
                            Shell(TextBox2.Text + jt + TextBox2.Text + " -o " + " " + TextBox2.Text + TextBox3.Text + TextBox2.Text + " " + kkv, AppWinStyle.Hide, True)
                        End If
                        If ToolStripProgressBar1.Value + uuq >= 100 Then
                            ToolStripProgressBar1.Value = 100
                        Else
                            ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + uuq
                        End If
                    Next
                    ToolStripProgressBar1.Value = 100
                    MsgBox("文件已复制到" + vbCrLf + .SelectedPath, MsgBoxStyle.Information, "操作成功！！！")
                End If
            End With
        End If
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        属性ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        全选ToolStripMenuItem_Click()
    End Sub
    Private Sub 全选ToolStripMenuItem_Click() Handles 全选ToolStripMenuItem.Click
        db = True
        cls()
        For g = 0 To ListView1.Items.Count - 1
            ListView1.SelectedIndices.Add(g)
        Next
        db = False
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        复制到ToolStripMenuItem_Click()
    End Sub
    Private Sub 列表ToolStripMenuItem_Click() Handles 列表ToolStripMenuItem.Click
        ListView1.View = View.Details
        ComboBox1.Text = ComboBox1.Items(0).ToString
        AU()
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\QSF")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\QSF", "ST", "0")
    End Sub
    Private Sub 图标ToolStripMenuItem_Click() Handles 图标ToolStripMenuItem.Click
        ListView1.View = View.LargeIcon
        ComboBox1.Text = ComboBox1.Items(1).ToString
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\QSF")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\QSF", "ST", "1")
    End Sub
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        ListView1_DoubleClick()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems.Count > 1 Then
                打开ToolStripMenuItem.Visible = False
            Else
                打开ToolStripMenuItem.Visible = True
            End If
            复制到ToolStripMenuItem.Visible = True
            属性ToolStripMenuItem.Visible = True
        Else
            打开ToolStripMenuItem.Visible = False
            复制到ToolStripMenuItem.Visible = False
            属性ToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged() Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        If ListView1.SelectedItems.Count <> 0 Then
            ToolStripButton3.Enabled = True
            ToolStripButton1.Enabled = True
            If ListView1.SelectedItems.Count = 1 And db = False Then
                opp()
                If SplitContainer1.Panel2Collapsed = False Then
                    change()
                End If
            Else
                cls()
            End If
        Else
            ToolStripButton3.Enabled = False
            ToolStripButton1.Enabled = False
            cls()
        End If
        Dim hhb As Integer = 0
        For w = 0 To ListView1.SelectedItems.Count - 1
            hhb = hhb + Int(ListView1.SelectedItems(w).SubItems(2).Text)
        Next
        ToolStripStatusLabel1.Text = "选择文件数:" + Str(ListView1.SelectedItems.Count) + " | " + "大小共" + Str(Int(hhb / 1024)) + "k"

        ToolStripStatusLabel1.Text = ("Height: " + Str(ImageControl1.Image.Height) + " Width: " + Str(ImageControl1.Image.Width) + " Color: " + PictureBox1.Image.PixelFormat.ToString)

    End Sub
    Function opp()
        On Error Resume Next
        My.Computer.FileSystem.WriteAllBytes(jt, My.Resources.unzip, False)
    End Function
    Function change()
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems.Count = 1 Then
                On Error Resume Next
                TextBox4.Text = ""
                ImageControl1.Image = Nothing
                AxWindowsMediaPlayer1.URL = ""
                opp()
                Dim olddir = ""
                Dim y = "QSF-Temp"
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y)
                olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y
                ChDir(olddir)
                My.Computer.FileSystem.DeleteDirectory(olddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Dim kkv = (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/")
                If Mid(kkv, 1, 1) = "/" Then
                    kkv = Mid(kkv, 2, Len(kkv) - 1)
                End If
                If Mid(kkv, Len(kkv), 1) <> "/" Then
                    Shell(TextBox2.Text + jt + TextBox2.Text + " -o " + " " + TextBox2.Text + TextBox3.Text + TextBox2.Text + " " + TextBox2.Text + kkv + TextBox2.Text, AppWinStyle.Hide, True)
                    Dim kl As String = ""
                    kl = changeYL()
                    If kl = "txt" Then
                        TextBox4.Text = My.Computer.FileSystem.ReadAllText((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text)).Replace("//", "/").Replace("/", "\").Replace("\\", "\"), te).Replace(vbLf, vbCrLf)
                    End If
                    If kl = "png" Then

                        PictureBox1.Image = Image.FromFile(((olddir + "\" + ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text).Replace("//", "/").Replace("/", "\").Replace("\\", "\")))
                        ImageControl1.Image = PictureBox1.Image
                    End If
                    If kl = "mid" Then
                        AxWindowsMediaPlayer1.URL = (olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text)).Replace("//", "/").Replace("/", "\").Replace("\\", "\")
                    End If
                    If kl = "htm" Then
                        Dim qu As New Uri((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text)).Replace("//", "/").Replace("/", "\").Replace("\\", "\"))
                        WebBrowser1.Url = qu
                    End If
                    If kl = "wu" Then
                        ImageControl1.Image = Image.FromFile((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text)).Replace("//", "/").Replace("/", "\").Replace("\\", "\"))
                        If ImageControl1.Image Is Nothing Then
                            TextBox4.Visible = True
                            TextBox4.Text = ""
                            TextBox4.Text = My.Computer.FileSystem.ReadAllText((olddir + "\" + (ListView1.SelectedItems(0).SubItems(1).Text + ListView1.SelectedItems(0).SubItems(0).Text)).Replace("//", "/").Replace("/", "\").Replace("\\", "\"), te).Replace(vbLf, vbCrLf)
                        Else
                            Panel1.Visible = False
                        End If
                    End If
                End If
            Else
                cls()
            End If
        End If
    End Function
    Function cls()
        On Error Resume Next
        PictureBox1.Image = Nothing
        WebBrowser1.Visible = False
        AxWindowsMediaPlayer1.Visible = False
        Panel1.Visible = True
        Panel1.Enabled = False
        TextBox4.Text = ""
        AxWindowsMediaPlayer1.URL = ""
    End Function
    Function changeYL()
        On Error Resume Next
        Dim kzm As String = ""
        kzm = getkzm(ListView1.SelectedItems.Item(0).Text)
        If kzm = "txt" Or kzm = "mf" Then
            AxWindowsMediaPlayer1.Visible = False
            WebBrowser1.Visible = False
            Panel1.Visible = True
            Panel1.Enabled = True
            Return "txt"
        End If
        If kzm = "png" Then
            AxWindowsMediaPlayer1.Visible = False
            WebBrowser1.Visible = False
            Panel1.Visible = False
            Return "png"
        End If
        If kzm = "mid" Then
            AxWindowsMediaPlayer1.Visible = True
            WebBrowser1.Visible = False
            Panel1.Visible = False
            Return "mid"
        End If
        If kzm = "wu" Or kzm = "bak" Then
            AxWindowsMediaPlayer1.Visible = False
            WebBrowser1.Visible = False
            Panel1.Visible = True
            Panel1.Enabled = True
            Return "wu"
        End If
        If kzm = "class" Or kzm = "Doc" Then
            AxWindowsMediaPlayer1.Visible = False
            WebBrowser1.Visible = False
            TextBox4.Text = "This is not a txt document！"
            Panel1.Visible = True
            Panel1.Enabled = False
            Return "Doc"
        End If
        If kzm = "htm" Then
            AxWindowsMediaPlayer1.Visible = False
            WebBrowser1.Visible = True
            Panel1.Visible = False
            Return "htm"
        End If
    End Function
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\QSF")
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
            ListView1_SelectedIndexChanged()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\QSF", "YL", "0")
        Else
            SplitContainer1.Panel2Collapsed = True
                     
            cls()
            ListView1_SelectedIndexChanged()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\QSF", "YL", "1")
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Default" Then
            te = System.Text.Encoding.Default
        End If
        If ComboBox2.Text = "ASCII" Then
            te = System.Text.Encoding.ASCII
        End If
        If ComboBox2.Text = "Unicode" Then
            te = System.Text.Encoding.Unicode
        End If
        If ComboBox2.Text = "UTF-8" Then
            te = System.Text.Encoding.UTF8
        End If
        ListView1_SelectedIndexChanged()
    End Sub
    Private Sub Button1_ButtonClick() Handles Button1.ButtonClick
        Run()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Run()
    End Sub
    Private Sub ToolStripButton5_Click() Handles ToolStripButton5.Click
        db = True
        cls()
        Dim lb As New ListBox
        lb.Items.Clear()
        For t = 0 To ListView1.SelectedItems.Count - 1
            lb.Items.Add(ListView1.SelectedItems.Item(t).Index)
        Next
        For g = 0 To ListView1.Items.Count - 1
            ListView1.SelectedIndices.Add(g)
        Next
        On Error Resume Next
        For g = 0 To ListView1.SelectedIndices.Count - 1
            ListView1.SelectedIndices.Remove(CInt(lb.Items.Item(g)))
        Next
        db = False
    End Sub
    Private Sub 反选ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 反选ToolStripMenuItem.Click
        ToolStripButton5_Click()
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Trim = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class