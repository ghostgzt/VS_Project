Public Class AddText
    Dim te As System.Text.Encoding = System.Text.Encoding.Default
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.TXT|*.TXT|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        Dim tt = My.Computer.FileSystem.ReadAllText((OpenFileDialog1.FileNames(x).Trim), te)
                        ListBox1.Items.Remove(tt)
                        ListBox1.Items.Add(tt)
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
            .Description = "请选择含有TXT的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim ttt
               
                ttt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
                For qq = 0 To ttt.count - 1
                    Dim tt = My.Computer.FileSystem.ReadAllText(ttt(qq), te)
                    ListBox1.Items.Remove(tt)
                    ListBox1.Items.Add(tt)
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(ttt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text <> "" Then
            ListBox1.Items.Add(TextBox1.Text)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim h1 As String
        Dim h2 As String
        Dim col As String
        Dim cu1 As String
        Dim cu2 As String
        Dim he1 As String
        Dim he2 As String
        Dim b1 As String
        Dim ii As Integer
        Dim iii As Integer
        If CheckBox6.Checked = True Then
            iii = Main.ListView1.SelectedItems.Item(0).Index
        End If
        For x = 0 To ListBox1.Items.Count - 1
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
            If CheckBox4.Checked = True Then
                col = " Color=" + L.Text + System.Drawing.ColorTranslator.ToHtml(Button8.BackColor) + L.Text
            Else
                col = ""
            End If
            If CheckBox2.Checked = True Then
                cu1 = "<b>"
                cu2 = "</b>"
            Else
                cu1 = ""
                cu2 = ""
            End If
            If CheckBox3.Checked = True Then
                he1 = "<u>"
                he2 = "</u>"
            Else
                he1 = ""
                he2 = ""
            End If
            If CheckBox5.Checked = True Then
                he1 = "<i>"
                he2 = "</i>"
            Else
                he1 = ""
                he2 = ""
            End If
            If CheckBox6.Checked = True Then
                ii = iii + x
                Main.ListView1.Items.Insert(ii, "文字", 0)
                Main.ListView1.Items.Item(ii).SubItems.Add(h1 + he1 + cu1 + "<Font" + col + ">" + ListBox1.Items(x).ToString.Replace(vbCrLf, "</P><P>").Replace(vbCr, "</P><P>").Replace(vbLf, "</P><P>") + "</Font>" + cu2 + he2 + h2)
                Main.ListView1.Items.Item(ii).SubItems.Add(b1)
                Main.ListView2.Items.Insert(ii, "文字", 0)
                Main.ListView2.Items.Item(ii).SubItems.Add(h1 + he1 + cu1 + "<Font" + col + ">" + ListBox1.Items(x).ToString.Replace(vbCrLf, "</P><P>").Replace(vbCr, "</P><P>").Replace(vbLf, "</P><P>") + "</Font>" + cu2 + he2 + h2)
                Main.ListView2.Items.Item(ii).SubItems.Add(b1)
            Else
                Main.ListView1.Items.Add("文字", 0)
                Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(h1 + he1 + cu1 + "<Font" + col + ">" + ListBox1.Items(x).ToString.Replace(vbCrLf, "</P><P>").Replace(vbCr, "</P><P>").Replace(vbLf, "</P><P>") + "</Font>" + cu2 + he2 + h2)
                Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(b1)
                Main.ListView2.Items.Add("文字", 0)
                Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(h1 + he1 + cu1 + "<Font" + col + ">" + ListBox1.Items(x).ToString.Replace(vbCrLf, "</P><P>").Replace(vbCr, "</P><P>").Replace(vbLf, "</P><P>") + "</Font>" + cu2 + he2 + h2)
                Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(b1)
            End If
        Next
        Me.Close()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        With ColorDialog1
            .Color = Nothing
            .ShowDialog()
            If .Color <> Nothing Then
                Button8.BackColor = .Color
                MsgBox((System.Drawing.ColorTranslator.ToHtml(.Color)))
            End If
        End With
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For x = 0 To ListBox1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0))
        Next
        TextBox1.Text = ""
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
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
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SY()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        XY()
    End Sub
    Private Sub AddText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        Button8.BackColor = Color.Empty
        ComboBox1.Text = "Default"
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox1.Text = ListBox1.Text
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
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
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub
End Class