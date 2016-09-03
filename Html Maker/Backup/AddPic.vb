Public Class AddPic
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
    End Sub
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
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For x = 0 To ListBox1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0))
        Next
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        PictureBox1.Image = Nothing
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
            'MsgBox(ListBox1.Items.IndexOf(t))
            ListBox1.Items(ListBox1.Items.IndexOf(t)) = qian
            ListBox1.ClearSelected()
            ListBox1.SetSelected(ListBox1.Items.IndexOf(t), True)
        End If
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim ii As Integer
        Dim iii As Integer
        If CheckBox2.Checked = True Then
            iii = Main.ListView1.SelectedItems.Item(0).Index
        End If
        If ListBox1.Items.Count <> 0 Then
            For x = 0 To ListBox1.Items.Count - 1
                Dim t = Image.FromFile(ListBox1.Items(x).ToString)
                Dim h = t.Height
                Dim w = t.Width
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
                    ii = iii + x
                    Main.ListView1.Items.Insert(ii, "图片", 1)
                    Main.ListView1.Items.Item(ii).SubItems.Add(h1 + "<img src=" + Label1.Text + ListBox1.Items(x).ToString.Replace(Main.Text + "\", "").Replace("\", "/") + Label1.Text + " width=" + Str(w) + " height=" + Str(h) + ">" + h2)
                    Main.ListView1.Items.Item(ii).SubItems.Add(b1)
                    Main.ListView2.Items.Insert(ii, "图片", 1)
                    Main.ListView2.Items.Item(ii).SubItems.Add(h1 + "<img src=" + Label1.Text + ListBox1.Items(x).ToString.Replace(Main.Text + "\", "").Replace("\", "/") + Label1.Text + " width=" + Str(w) + " height=" + Str(h) + ">" + h2)
                    Main.ListView2.Items.Item(ii).SubItems.Add(b1)
                Else
                    Main.ListView1.Items.Add("图片", 1)
                    Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(h1 + "<img src=" + Label1.Text + ListBox1.Items(x).ToString.Replace(Main.Text + "\", "").Replace("\", "/") + Label1.Text + " width=" + Str(w) + " height=" + Str(h) + ">" + h2)
                    Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(b1)
                    Main.ListView2.Items.Add("图片", 1)
                    Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(h1 + "<img src=" + Label1.Text + ListBox1.Items(x).ToString.Replace(Main.Text + "\", "").Replace("\", "/") + Label1.Text + " width=" + Str(w) + " height=" + Str(h) + ">" + h2)
                    Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(b1)
                End If
            Next
            Me.Close()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.ImageLocation = ListBox1.Text
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        XY()
    End Sub
    Private Sub AddPic_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Items.Clear()
        PictureBox1.Image = Nothing
    End Sub
End Class