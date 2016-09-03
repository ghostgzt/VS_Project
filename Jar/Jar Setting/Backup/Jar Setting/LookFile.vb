Public Class LookFile
    Dim tmppath As String = ""
    Dim picpath As String = ""
    Dim fby As String = ""
    Dim kp
    Dim te As System.Text.Encoding = System.Text.Encoding.UTF8
    Dim mouseOffset
    Dim nn
    Dim bt
    Dim tm = 0
    Dim km = 0
    Dim df = 0
    Function ii()
        ComboBox2_SelectedIndexChanged()
    End Function
    Private Sub LookFile_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        km = 1
        ComboBox2.Text = "*.*"
        Jar.read()
        Mini.Show()
    End Sub
    Private Sub LookFile_Load() Handles MyBase.Load
        Jar.XB(False)
        Mini.Hide()
        Me.Text = "LookFile-" + Jar.Retoqqq
        km = 0
        ComboBox2_SelectedIndexChanged()
    End Sub
    Function uii()
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Java FBY.exe") = False Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
        ListBox1.Text = ""
        Button9.Visible = False
        PictureBox2.Image = Nothing
        Me.Opacity = Jar.Opacity
        Me.Refresh()
        tmppath = Jar.TextBox9.Text
        picpath = Jar.TextBox5.Text
        TextBox1.Enabled = False
        Button3.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        ListBox1.Items.Clear()
        ComboBox1.Text = "UTF8"
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        WebBrowser1.Visible = False
        WebBrowser1.Url = Nothing
        Dim k = My.Computer.FileSystem.GetFiles(tmppath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
        For i = 0 To k.Count - 1
            ListBox1.Items.Add(k(i).Replace(tmppath, ""))
        Next
        Button4.Enabled = False
        Button1.Enabled = False
        Button8.Enabled = False
        Button5.Enabled = False
        Button10.Enabled = False
        Button3.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
    End Function
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Function r()
        If tm = 0 Then
            Button9.Visible = False
            bt = ""
            ListBox1.Width = 244
            On Error Resume Next
            PictureBox1.Image = Nothing
            PictureBox1.ImageLocation = tmppath + ListBox1.Text
            Dim uy = ""
            For k = 0 To ListBox1.Text.Length - 1
                If Mid(ListBox1.Text, k, 1) = "." Then
                    uy = k
                End If
            Next
            If ListBox1.Text <> "" Then
                PictureBox2.Image = ImageList1.Images.Item(4)
                Button8.Enabled = True
                Button1.Enabled = True
                Button4.Enabled = True
                Dim yt = (ListBox1.Text.Remove(0, uy).ToLower)
                bt = yt
                If PictureBox1.Image Is Nothing Then
                    kp = "T"
                    TextBox1.Visible = True
                    TextBox1.Top = PictureBox1.Top
                    TextBox1.Height = 284 + 8
                    PictureBox1.Height = 142
                    Button5.Enabled = False
                    Button10.Enabled = False
                    TextBox1.Enabled = True
                    Button3.Enabled = True
                    Button4.Enabled = True
                    Button13.Enabled = True
                    Button14.Enabled = True
                    PictureBox2.Image = ImageList1.Images.Item(0)
                    TextBox1.Text = My.Computer.FileSystem.ReadAllText(tmppath + ListBox1.Text, te)
                    ComboBox1.Enabled = True
                Else
                    kp = "P"
                    TextBox1.Left = 250
                    TextBox1.Top = 148
                    TextBox1.Height = 142
                    PictureBox1.Height = 284 + 8
                    Button5.Enabled = True
                    Button10.Enabled = True
                    TextBox1.Enabled = False
                    TextBox1.Visible = False
                    Button3.Enabled = False
                    Button13.Enabled = False
                    Button14.Enabled = False
                    If PictureBox1.Image.Size.Height > PictureBox1.Size.Height Or PictureBox1.Image.Size.Width > PictureBox1.Size.Width Then
                        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    Else
                        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    End If
                    PictureBox2.Image = ImageList1.Images.Item(2)
                    ComboBox1.Enabled = False
                    If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\PicResizer.exe") = False Then
                        Button10.Enabled = False
                    Else
                        Button10.Enabled = True
                    End If
                End If
                TextBox1.Enabled = True
                If yt = "class" Then
                    nn = ""
                    Button5.Enabled = False
                    Button10.Enabled = False
                    Button3.Enabled = False
                    Button13.Enabled = False
                    Button14.Enabled = False
                    TextBox1.Text = ""
                    TextBox1.Enabled = False
                    PictureBox2.Image = ImageList1.Images.Item(5)
                    If df = 1 Then
                        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Java FBY.exe") = True Then
                            ListBox1.Enabled = False
                            Shell(My.Application.Info.DirectoryPath + "\Java FBY.exe" + " " + Jar.TextBox3.Text + tmppath + ListBox1.Text + Jar.TextBox3.Text, AppWinStyle.Hide, True)
                            gett(True)
                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$\" + nn + ".java") = True Then
                                TextBox1.Enabled = True
                                TextBox1.ReadOnly = True
                                Dim bb = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$\" + nn + ".java", System.Text.Encoding.Default)
                                Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$\" + nn + ".java")
                                TextBox1.Text = bb
                                Button9.Visible = True
                            Else
                                TextBox1.Enabled = False
                                TextBox1.ReadOnly = False
                            End If
                            ListBox1.Enabled = True
                        End If
                    End If
                Else
                    TextBox1.ReadOnly = False
                    If df = 1 Then
                        PictureBox2_DoubleClick()
                    End If
                End If
                If yt = "mid" Then
                    PictureBox2.Image = ImageList1.Images.Item(1)
                    TextBox1.Enabled = False
                    TextBox1.Text = ""
                    Button5.Enabled = False
                    Button10.Enabled = False
                    Button3.Enabled = False
                    Button13.Enabled = False
                    Button14.Enabled = False
                    TextBox1.Visible = False
                    WebBrowser1.Visible = True
                End If
                WebBrowser1.Visible = False
                If yt = "htm" Or yt = "html" Then
                    Button5.Enabled = False
                    Button10.Enabled = False
                    Button3.Enabled = False
                    Button13.Enabled = False
                    Button14.Enabled = False
                    TextBox1.Visible = False
                    WebBrowser1.Visible = True
                    PictureBox2.Image = ImageList1.Images.Item(3)
                    Dim qu As New Uri(tmppath + ListBox1.Text)
                    WebBrowser1.Url = qu
                End If
            Else
                Button8.Enabled = False
                Button1.Enabled = False
                Button4.Enabled = False
                Button3.Enabled = False
                Button13.Enabled = False
                Button14.Enabled = False
                PictureBox2.Image = Nothing
            End If
        End If
    End Function
    Function gett(ByVal n As Boolean)
        Dim ko = ""
        For x = 0 To Len(ListBox1.Text) - 1
            If Mid(ListBox1.Text, x + 1, 1) = "\" Then
                ko = x
            End If
        Next
        Dim kk = (ListBox1.Text.Remove(0, ko + 1))
        If n = True Then
            nn = (kk.Remove(Len(kk) - 6))
        Else
            nn = kk
        End If
    End Function
    Private Sub Button1_Click() Handles Button1.Click
        Jar.OpenFileDialog1.FileName = ""
        Jar.OpenFileDialog1.Filter = "*.*|*.*"
        Jar.OpenFileDialog1.ShowDialog()
        If Jar.OpenFileDialog1.FileName <> "" Then
            Dim t0 = Jar.OpenFileDialog1.FileName
            If MsgBox("是否替换？！", MsgBoxStyle.YesNo, "文件替换！！！") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.CopyFile(t0, tmppath + ListBox1.Text, True)
                r()
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        km = 1
        ComboBox2.Text = "*.*"
        Jar.readpic()
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        My.Computer.FileSystem.WriteAllText(tmppath + ListBox1.Text, TextBox1.Text, False, te)
        u8ww(tmppath + ListBox1.Text)
    End Sub
    Function u8ww(ByVal st As String)
        On Error Resume Next
        If te Is System.Text.Encoding.UTF8 Then
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP", My.Resources.UTF8, False)
            Shell(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP" + " " + st)
        End If
    End Function
    Private Sub Button4_Click() Handles Button4.Click
        If ListBox1.SelectedItems.Count = 1 Then
            Jar.SaveFileDialog1.FileName = ""
            gett(False)
            Jar.SaveFileDialog1.FileName = nn
            Jar.SaveFileDialog1.Filter = "*.*|*.*"
            If Jar.SaveFileDialog1.FileName <> "" And Jar.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(tmppath + ListBox1.Text, Jar.SaveFileDialog1.FileName, True)
            End If
        Else
            On Error Resume Next
            With DirCho.FolderBrowserDialog1
                .SelectedPath = ""
                .ShowDialog()
                If .SelectedPath <> "" Then
                    For c = 0 To ListBox1.SelectedItems.Count - 1
                        My.Computer.FileSystem.CopyFile(tmppath + ListBox1.SelectedItems.Item(c).ToString, .SelectedPath + ListBox1.SelectedItems.Item(c).ToString, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                    Next
                End If
            End With
        End If
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        On Error Resume Next
        Shell(Jar.TextBox3.Text + picpath + Jar.TextBox3.Text + " " + Jar.TextBox3.Text + tmppath + ListBox1.Text, 1, True)
        PictureBox1.ImageLocation = tmppath + ListBox1.Text
    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        df = 1
        r()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If di = False Then
            If ListBox1.Items.Count <> 0 Then
                全部保存ToolStripMenuItem.Visible = True
                全选ToolStripMenuItem.Visible = True
                Button15.Enabled = True
            Else
                全部保存ToolStripMenuItem.Visible = False
                全选ToolStripMenuItem.Visible = False
                Button15.Enabled = False
            End If
            df = 0
            r()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Default" Then
            te = System.Text.Encoding.Default
        End If
        If ComboBox1.Text = "ASCII" Then
            te = System.Text.Encoding.ASCII
        End If
        If ComboBox1.Text = "Unicode" Then
            te = System.Text.Encoding.Unicode
        End If
        If ComboBox1.Text = "UTF8" Then
            te = System.Text.Encoding.UTF8
        End If
        r()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\Java FBY.exe" + " " + Jar.TextBox3.Text + tmppath + Jar.TextBox3.Text, 1)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ad()
        Me.Hide()
        DirCho.ShowDialog()
    End Sub
    Function ad()
        DirCho.ComboBox1.Items.Clear()
        Dim uk = My.Computer.FileSystem.GetDirectories(tmppath, FileIO.SearchOption.SearchAllSubDirectories)
        DirCho.ComboBox1.Items.Add("\")
        For c = 0 To uk.Count - 1
            DirCho.ComboBox1.Items.Add(uk(c).Replace(tmppath, ""))
        Next
        DirCho.ComboBox1.Text = "\"
    End Function
    Private Sub Button8_Click() Handles Button8.Click
        Dim tt = MsgBox("删除——是文件，否文件夹?", MsgBoxStyle.YesNoCancel, "删除！！")
        If tt = MsgBoxResult.Yes Then
            For q = 0 To ListBox1.SelectedItems.Count - 1
                On Error Resume Next
                My.Computer.FileSystem.DeleteFile(tmppath + ListBox1.SelectedItems.Item(q).ToString)
            Next
            ii()
        End If
        Dim jj = 0
        If tt = MsgBoxResult.No Then
            For q = 0 To ListBox1.SelectedItems.Count - 1
                Dim ttx = ListBox1.SelectedItems.Item(q).ToString
                For x = 0 To ttx.Length - 1
                    If Mid(ttx, x + 1, 1) = "\" Then
                        jj = x
                    End If
                Next
                If ttx.Remove(jj + 1) <> "\" Then
                    Dim yj = tmppath + ttx.Remove(jj + 1).Remove(ttx.Remove(jj + 1).Length - 1)
                    On Error Resume Next
                    My.Computer.FileSystem.DeleteDirectory(yj, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            Next
            ii()
        End If
    End Sub
    Private Sub PictureBox2_DoubleClick() Handles PictureBox2.DoubleClick
        If ListBox1.Text <> "" And bt <> "" Then
            If bt <> "class" Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + tmppath + ListBox1.Text)
            End If
            If bt = "class" And TextBox1.Enabled = True Then
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$$$.java", TextBox1.Text, False, System.Text.Encoding.Default)
                Shell("notepad " + My.Computer.FileSystem.SpecialDirectories.Temp + "\$$$.java", AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        With Jar.SaveFileDialog1
            .Filter = "*.Java|*.Java|*.*|*.*"
            .FileName = nn + ".java"
            If .FileName <> "" And .ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(.FileName, TextBox1.Text, False, te)
                MsgBox("Save Successed！！！", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe " + Jar.TextBox3.Text + tmppath + ListBox1.Text + Jar.TextBox3.Text, AppWinStyle.NormalFocus, False)
        PictureBox1.ImageLocation = tmppath + ListBox1.Text
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged() Handles ComboBox2.SelectedIndexChanged
        ListBox1.SelectionMode = SelectionMode.One
        If km = 0 Then
            uii()
            ListBox1.Enabled = False
            tm = 1
            ListBox2.Items.Clear()
            For x = 0 To ListBox1.Items.Count - 1
                On Error GoTo h
                ListBox1.SetSelected(x, True)
                Dim uy As Integer
                uy = 0
                For k = 0 To ListBox1.Text.Length - 1
                    If Mid(ListBox1.Text, k + 1, 1) = "." Then
                        uy = k
                    End If
                Next
                Dim yt = (ListBox1.Text.Remove(0, uy).ToLower)
                GoTo t7
                Exit Sub
h:              If ComboBox2.Text <> "*." Then
                    ListBox2.Items.Add(ListBox1.Text)
                End If
t7:             If ComboBox2.Text.Trim <> "*.*" Then
                    If ComboBox2.Text.Trim = "*." Then
                        If uy <> 0 Then
                            ListBox2.Items.Add(ListBox1.Text)
                        End If
                    Else
                        If yt <> ComboBox2.Text.Replace("*", "").ToLower.Trim Then
                            If ComboBox2.Text <> "" Then
                                ListBox2.Items.Add(ListBox1.Text)
                            End If
                        End If
                    End If
                End If
            Next
            If ListBox2.Items.Count <> 0 Then
                For x = 0 To ListBox2.Items.Count - 1
                    ListBox2.SetSelected(x, True)
                    ListBox1.Items.Remove(ListBox2.Text)
                Next
            End If
            If ListBox1.Items.Count <> 0 Then
                ListBox1.SetSelected(0, True)
            End If
            tm = 0
            ListBox1.Enabled = True
            ListBox1.SelectedItem = Nothing
        End If
        ListBox1.SelectionMode = SelectionMode.MultiExtended
    End Sub
    Private Sub Button11_Click() Handles Button11.Click
        If ComboBox2.Text.Trim <> "" Then
            Dim uip = -1
            For x = 0 To ComboBox2.Text.Length - 1
                If Mid(ComboBox2.Text, x + 1, 2) = "*." Then
                    uip = 1
                End If
            Next
            If uip = -1 Then
                ComboBox2.Text = ComboBox2.Text.Replace("*", "")
                ComboBox2.Text = "*." + ComboBox2.Text
            Else
                ComboBox2.Text = "*." + ComboBox2.Text.Replace("*.", "")
            End If
            If ComboBox2.Text.Trim <> "*.png" And ComboBox2.Text.Trim <> "*." And ComboBox2.Text.Trim <> "*." And ComboBox2.Text.Trim <> "*.mid" And ComboBox2.Text.Trim <> "*.txt" And ComboBox2.Text.Trim <> "*.htm" And ComboBox2.Text.Trim <> "*.html" Then
                ComboBox2_SelectedIndexChanged()
            End If
        Else
            ComboBox2.Text = "*."
        End If
    End Sub
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        PictureBox2_DoubleClick()
    End Sub
    Private Sub 另保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 另保存ToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        Button8_Click()
    End Sub
    Private Sub 重命名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重命名ToolStripMenuItem.Click
        CMM.TextBox1.Text = ListBox1.Text
        If ListBox1.Text <> "" Then
            CMM.TextBox2.Text = getname(ListBox1.Text, "\", False)
            CMM.TextBox3.Text = CMM.TextBox2.Text
        End If
        Me.Hide()
        CMM.ShowDialog()
        Dim dd = getname(CMM.TextBox3.Text, ".", False)
        Dim bb = getname(ComboBox2.Text, ".", False)
        Dim uu = (getname(ListBox1.Text, "\", True))
        If CMM.TextBox3.Text <> CMM.TextBox2.Text Then
            ListBox1.Items.Remove(ListBox1.Text)
            TextBox1.Text = ""
            TextBox1.Enabled = False
            PictureBox1.Image = Nothing
            WebBrowser1.Visible = False
            If dd = bb Or bb.ToString.Trim = "*" Or bb = "*.*" Or bb.ToString.Trim = "" Then
                ListBox1.Items.Add(uu + "\" + CMM.TextBox3.Text)
            End If
        End If
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean)
        Dim q = ""
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, 1) = str1f Then
                    q = u
                End If
            Next
        End If
        If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + 1)
            Else
                Return str.Remove(q)
            End If
        Else
            Return ""
        End If
    End Function
    Private Sub 替换ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 替换ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 全部保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全部保存ToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Then
            With DirCho.FolderBrowserDialog1
                .SelectedPath = ""
                .ShowDialog()
                If .SelectedPath <> "" Then
                    For c = 0 To ListBox1.Items.Count - 1
                        My.Computer.FileSystem.CopyFile(tmppath + ListBox1.Items(c).ToString, .SelectedPath + ListBox1.Items(c).ToString, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                    Next
                End If
            End With
        End If
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.Items.Count <> 0 Then
            全部保存ToolStripMenuItem.Visible = True
            全选ToolStripMenuItem.Visible = True
            Button15.Enabled = True
        Else
            全部保存ToolStripMenuItem.Visible = False
            全选ToolStripMenuItem.Visible = False
            Button15.Enabled = False
        End If
        If ListBox1.SelectedItems.Count = 0 Then
            打开ToolStripMenuItem.Visible = False
            另保存ToolStripMenuItem.Visible = False
            删除ToolStripMenuItem.Visible = False
            重命名ToolStripMenuItem.Visible = False
            替换ToolStripMenuItem.Visible = False
            Hex编辑ToolStripMenuItem.Visible = False
        Else
            Hex编辑ToolStripMenuItem.Visible = True
            If ListBox1.SelectedItems.Count = 1 Then
                打开ToolStripMenuItem.Visible = True
                另保存ToolStripMenuItem.Visible = True
                删除ToolStripMenuItem.Visible = True
                重命名ToolStripMenuItem.Visible = True
                替换ToolStripMenuItem.Visible = True
            Else
                打开ToolStripMenuItem.Visible = False
                另保存ToolStripMenuItem.Visible = True
                删除ToolStripMenuItem.Visible = True
                重命名ToolStripMenuItem.Visible = False
                替换ToolStripMenuItem.Visible = False
            End If
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error Resume Next
        If ListBox1.SelectedItems.Count = 0 Then
            Shell(My.Application.Info.DirectoryPath + "\PNG Color Down.exe " + Jar.TextBox3.Text + tmppath + Jar.TextBox3.Text, 1, False)
        Else
            Dim k = ""
            For x = 0 To ListBox1.SelectedItems.Count - 1
                k = k + " " + Jar.TextBox3.Text + tmppath + ListBox1.SelectedItems.Item(x) + Jar.TextBox3.Text
            Next
            Shell(My.Application.Info.DirectoryPath + "\PNG Color Down.exe " + k, 1, False)
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = StrConv(TextBox1.Text, VbStrConv.SimplifiedChinese)
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = StrConv(TextBox1.Text, VbStrConv.TraditionalChinese)
    End Sub
    Dim di As Boolean = False
    Private Sub 全选ToolStripMenuItem_Click() Handles 全选ToolStripMenuItem.Click
        On Error Resume Next
        di = True
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndices.Add(x)
        Next
        If ListBox1.Items.Count <> 0 Then
            Button8.Enabled = True
        End If
        di = False
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        全选ToolStripMenuItem_Click()
    End Sub
    Private Sub 文件夹位置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 文件夹位置ToolStripMenuItem.Click
        On Error Resume Next
        Shell("explorer " + Jar.TextBox3.Text + tmppath + Jar.TextBox3.Text, AppWinStyle.MaximizedFocus, False)
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        Button11_Click()
    End Sub
    Private Sub Hex编辑ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hex编辑ToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count <> 0 Then
            Dim k = ""
            For x = 0 To ListBox1.SelectedItems.Count - 1
                k = k + " " + Jar.TextBox3.Text + tmppath + ListBox1.SelectedItems.Item(x).ToString.Trim + Jar.TextBox3.Text
            Next
            Shell(My.Application.Info.DirectoryPath + "\MiniHex.exe" + k)
        End If
    End Sub
End Class