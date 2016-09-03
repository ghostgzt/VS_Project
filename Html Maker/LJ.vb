Public Class LJ
    Dim getname As New GN
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.Htm;*.Html|*.Htm;*.Html|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        Dim kk = getname.getname(getname.getname(.FileNames(x), "\", False), ".", True)
                        ListBox1.Items.Remove(OpenFileDialog1.FileNames(x).Trim + "@" + kk)
                        ListBox1.Items.Add(OpenFileDialog1.FileNames(x).Trim + "@" + kk)
                    Next
                End If
            End If
        End With
    End Sub
    Function ti(ByVal stt As String)
        Dim s = 0
        For y = 1 To stt.Length
            If Mid(stt, y, 1) = "\" Then
                s = s + 1
            End If
        Next
        Return s
    End Function
    Dim zhupath = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .Description = "请选择添加的路径:"
            .ShowNewFolderButton = False
            .Description = "请选择含有Jpg的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                Dim bb
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.htm")
                bb = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.html")
                For qq = 0 To tt.count - 1
                    Dim kk = getname.getname(getname.getname(tt(qq), "\", False), ".", True)
                    ListBox1.Items.Remove(tt(qq) + "@" + kk)
                    ListBox1.Items.Add(tt(qq) + "@" + kk)
                    ListBox1.Items.Remove("")
                Next
                For qq = 0 To bb.count - 1
                    Dim kk = getname.getname(getname.getname(bb(qq), "\", False), ".", True)
                    ListBox1.Items.Remove(bb(qq) + "@" + kk)
                    ListBox1.Items.Add(bb(qq) + "@" + kk)
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(tt.count + bb.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For x = 0 To ListBox1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0))
        Next
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        XY()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        If ListBox1.SelectedItems.Count <> 0 Then
            Dim m = ListBox1.Text.Split("@".ToCharArray, 2)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button7.Enabled = True
            TextBox1.Text = m(0)
            TextBox2.Text = m(1)
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button7.Enabled = False
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim t = ListBox1.Items
        zhupath = Main.Text
        Dim ii As Integer
        Dim iii As Integer
        If CheckBox2.Checked = True Then
            iii = Main.ListView1.SelectedItems.Item(0).Index
        End If
        For h = 0 To t.Count - 1
            Dim k0
            Dim m = ListBox1.Items(h).Split("@".ToCharArray, 2)
            If zhupath = "" Then
                k0 = m(0)
            Else
                k0 = m(0).Replace(zhupath + "\", "")
            End If
            Dim h1 As String
            Dim h2 As String
            Dim b1 As String
            If CheckBox1.Checked = True Then
                'h1 = "<P>"
                'h2 = "</P>"
                h1 = ""
                h2 = ""
                b1 = "是"
            Else
                h1 = ""
                h2 = ""
                b1 = "否"
            End If
            If CheckBox2.Checked = True Then
                ii = iii + h
                Main.ListView1.Items.Insert(ii, "连接", 2)
                Main.ListView1.Items.Item(ii).SubItems.Add(h1 + "<A href=" + Label1.Text + k0 + Label1.Text + " target=_blank>" + m(1) + "</A>" + h2)
                Main.ListView1.Items.Item(ii).SubItems.Add(b1)
                Main.ListView2.Items.Insert(ii, "连接", 2)
                Main.ListView2.Items.Item(ii).SubItems.Add(h1 + "<A href=" + Label1.Text + k0 + Label1.Text + " target=_blank>" + m(1) + "</A>" + h2)
                Main.ListView2.Items.Item(ii).SubItems.Add(b1)
            Else
                Main.ListView1.Items.Add("连接", 2)
                Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(h1 + "<A href=" + Label1.Text + k0 + Label1.Text + " target=_blank>" + m(1) + "</A>" + h2)
                Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(b1)
                Main.ListView2.Items.Add("连接", 2)
                Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(h1 + "<A href=" + Label1.Text + k0 + Label1.Text + " target=_blank>" + m(1) + "</A>" + h2)
                Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(b1)
            End If
Next
        Main.Text = zhupath
        Me.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        Dim t = ListBox1.SelectedItems(0)
        ListBox1.Items(ListBox1.Items.IndexOf(t)) = TextBox1.Text + "@" + TextBox2.Text
    End Sub
    Private Sub LJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button7.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Close()
    End Sub
End Class