Public Class TZ
    Dim te As System.Text.Encoding
    Dim de As System.Text.Encoding
    Dim u8w As Boolean
    Dim yyt
    Dim tt As New TLQ.x
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If yyt <> 0 Then
            FolderBrowserDialog1.SelectedPath = ""
            FolderBrowserDialog1.ShowNewFolderButton = False
            FolderBrowserDialog1.Description = "请选择含有TXT的目录！！！"
            FolderBrowserDialog1.ShowDialog()
            If FolderBrowserDialog1.SelectedPath <> "" Then
                FileListBox1.Refresh()
                FileListBox1.Pattern = "*.txt"
                FileListBox1.Path = FolderBrowserDialog1.SelectedPath
                If FileListBox1.Items.Count <> 0 Then
                    For i = 0 To FileListBox1.Items.Count - 1
                        FileListBox1.SetSelected(i, True)
                        ListBox1.Items.Remove(FolderBrowserDialog1.SelectedPath + "\" + FileListBox1.FileName.Trim)
                        ListBox1.Items.Add(FolderBrowserDialog1.SelectedPath + "\" + FileListBox1.FileName)
                    Next
                End If
                MsgBox("添加了" + FileListBox1.Items.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
            End If
        Else
            With OpenFileDialog1
                .FileName = ""
                .Filter = "Txt File *.txt|*.txt|All File *.*|*.*"
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
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If My.Application.CommandLineArgs.Count <> 0 Then
            For m = 0 To My.Application.CommandLineArgs.Count - 1
                ListBox1.Items.Add(My.Application.CommandLineArgs(m).Trim)
            Next
            MsgBox("处理" + My.Application.CommandLineArgs.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
        End If
        yyt = 0
        ComboBox1.Text = "UTF8"
        ComboBox2.Text = "Default"
        ComboBox1_SelectedIndexChanged()
        ComboBox2_SelectedIndexChanged()
        tt.Run(ListBox1, ListBox1, Nothing, "*.txt|*.mf|*.htm|*.html|*.rc|*.vbs|*.js|*.java|*.jad", False, True)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged() Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Default" Then
            te = System.Text.Encoding.Default
            u8w = False
        End If
        If ComboBox1.Text = "ASCII" Then
            te = System.Text.Encoding.ASCII
            u8w = False
        End If
        If ComboBox1.Text = "Unicode" Then
            te = System.Text.Encoding.Unicode
            u8w = False
        End If
        If ComboBox1.Text = "UTF8" Then
            te = System.Text.Encoding.UTF8
            u8w = False
        End If
        ListBox1_SelectedIndexChanged()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged() Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Default" Then
            de = System.Text.Encoding.Default
            u8w = False
        End If
        If ComboBox2.Text = "ASCII" Then
            de = System.Text.Encoding.ASCII
            u8w = False
        End If
        If ComboBox2.Text = "Unicode" Then
            de = System.Text.Encoding.Unicode
            u8w = False
        End If
        If ComboBox2.Text = "UTF8" Then
            de = System.Text.Encoding.UTF8
            u8w = False
        End If
        If ComboBox2.Text = "UTF8 WOB" Then
            de = System.Text.Encoding.UTF8
            u8w = True
        End If
        ListBox1_SelectedIndexChanged()
    End Sub
    Function u8ww(ByVal st As String)
        If u8w = True Then
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP", My.Resources.UTF8, False)
            Shell(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP" + " " + st)
        End If
    End Function
    Function iuu(ByVal hs As String)
        If My.Computer.FileSystem.FileExists(hs + ".BAK") = True Then
            Dim kyf = MsgBox(hs + ".BAK" + "已存在！是否覆盖！", MsgBoxStyle.YesNo)
            If kyf = MsgBoxResult.Yes Then
                rg(hs)
            End If
        Else
            rg(hs)
        End If
    End Function
    Function rg(ByVal hs As String)
        Dim ku = ""
        For v = 0 To Len(hs) - 1
            If Mid(hs, v + 1, 1) = "\" Then
                ku = v
            End If
        Next
        If My.Computer.FileSystem.FileExists(hs + ".BAK") = True Then
            Kill(hs + ".BAK")
        End If
        My.Computer.FileSystem.RenameFile(hs, hs.Remove(0, ku + 1) + ".BAK")
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.Items.Count <> 0 Then
            Dim ky = MsgBox("你确定把文本编码 " + ComboBox1.Text + " To " + ComboBox2.Text, MsgBoxStyle.YesNo, "温馨提示！！！")
            If ky = MsgBoxResult.Yes Then
                If ListBox1.Items.Count <> 0 And ComboBox1.Text <> ComboBox2.Text Then
                    ListBox1.Enabled = False
                    ListBox2.Items.Clear()
                    For x = 0 To ListBox1.Items.Count - 1
                        ListBox1.SetSelected(x, True)
                        On Error GoTo 4
                        Dim ti = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te)
                        TextBox1.Text = ti
                        If CheckBox1.Checked = True Then
                            iuu(ListBox1.Text)
                        End If
                        My.Computer.FileSystem.WriteAllText(ListBox1.Text, TextBox1.Text, False, de)
                        u8ww(ListBox1.Text)
                        ListBox2.Items.Add(ListBox1.Text)
                        TextBox1.Text = ""
4:                  Next
                    If ListBox2.Items.Count <> 0 Then
                        For b = 0 To ListBox2.Items.Count - 1
                            ListBox2.SetSelected(b, True)
                            ListBox1.Items.Remove(ListBox2.Text)
                        Next
                    End If
                    Dim hh = "操作失败的有："
                    If ListBox1.Items.Count <> 0 Then
                        For u = 0 To ListBox1.Items.Count - 1
                            ListBox1.SetSelected(u, True)
                            hh = hh + vbCrLf + ListBox1.Text
                        Next
                        MsgBox(hh, MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Successed！！！", MsgBoxStyle.Information)
                    End If
                    ListBox1.Enabled = True
                End If
                If ComboBox1.Text = ComboBox2.Text Then
                    MsgBox("输入编码与输出编码相同哦！,请选择不同编码！！！", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged() Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        If ListBox1.Text <> "" Then
            TextBox1.Text = ""
            Dim ti = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te)
            TextBox1.Text = ti
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub 按文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 按文件ToolStripMenuItem.Click
        yyt = 0
    End Sub
    Private Sub 按文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 按文件夹ToolStripMenuItem.Click
        yyt = 1
    End Sub
End Class