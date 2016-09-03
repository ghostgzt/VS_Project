Public Class DirCho
    Dim mouseOffset
    Dim tmppath As String = ""
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ListView1.Items.Count <> 0 Then
            For g = 0 To ListView1.Items.Count - 1
                If ListView1.Items(g).SubItems(1).Text <> "\" Then
                    If My.Computer.FileSystem.FileExists(tmppath + ListView1.Items(g).SubItems(1).Text + "\" + ListView1.Items(g).SubItems(0).Text) = False Then
                        My.Computer.FileSystem.CopyFile(ListView1.Items(g).SubItems(2).Text, tmppath + ListView1.Items(g).SubItems(1).Text + "\" + ListView1.Items(g).SubItems(0).Text)
                    Else
                        If MsgBox(TextBox1.Text + "已存在，是否覆盖？！", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            My.Computer.FileSystem.CopyFile(ListView1.Items(g).SubItems(2).Text, tmppath + ListView1.Items(g).SubItems(1).Text + "\" + ListView1.Items(g).SubItems(0).Text, True)
                        End If
                    End If
                Else
                    If My.Computer.FileSystem.FileExists(tmppath + "\" + ListView1.Items(g).SubItems(0).Text) = False Then
                        My.Computer.FileSystem.CopyFile(ListView1.Items(g).SubItems(2).Text, tmppath + "\" + ListView1.Items(g).SubItems(0).Text)
                    Else
                        If MsgBox(TextBox1.Text + "已存在，是否覆盖？！", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            My.Computer.FileSystem.CopyFile(ListView1.Items(g).SubItems(2).Text, tmppath + "\" + ListView1.Items(g).SubItems(0).Text, True)
                        End If
                    End If
                End If
            Next
            Me.Close()
        Else
            MsgBox("不能空！！！", MsgBoxStyle.Exclamation)
            Button1_Click()
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        Jar.ContextMenuStrip1.Enabled = False
        Try
            With Jar.OpenFileDialog1
                .Multiselect = True
                .FileName = ""
                .Filter = "All File *.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    If .FileNames.Count <> 0 Then
                        MsgBox("处理" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                        For x = 0 To .FileNames.Count - 1
                            TextBox2.Text = .FileNames(x)
                            Dim kkd
                            For c = 0 To TextBox2.Text.Length - 1
                                If Mid(TextBox2.Text, c + 1, 1) = "\" Then
                                    kkd = c
                                End If
                            Next
                            ListView1.SelectedItems.Clear()
                            TextBox1.Text = TextBox2.Text.Remove(0, kkd + 1)
                            For v = 0 To ListView1.Items.Count - 1
                                If ListView1.Items(v).Text = TextBox1.Text And ListView1.Items(v).SubItems(1).Text = ComboBox1.Text Then
                                    ListView1.Items(v).Remove()
                                End If
                            Next
                            ListView1.Items.Add(TextBox1.Text)
                            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(ComboBox1.Text)
                            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(TextBox2.Text)
                            ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                            ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                            ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                        Next
                    End If
                End If
                .Multiselect = False
            End With
        Catch
        End Try
        If ListView1.SelectedItems.Count = 0 Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        Jar.ContextMenuStrip1.Enabled = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ko = InputBox("新建文件夹名称：", "输入", , , )
        If ko <> "" Then
            If ComboBox1.Text <> "\" Then
                If My.Computer.FileSystem.DirectoryExists(tmppath + "\" + ComboBox1.Text + "\" + ko) = False Then
                    My.Computer.FileSystem.CreateDirectory(tmppath + "\" + ComboBox1.Text + "\" + ko)
                    LookFile.ad()
                    ComboBox1.Text = "\" + ComboBox1.Text + "\" + ko
                Else
                    GoTo m
                End If
            Else
                If My.Computer.FileSystem.DirectoryExists(tmppath + ComboBox1.Text.Replace("\", "") + "\" + ko) = False Then
                    My.Computer.FileSystem.CreateDirectory(tmppath + ComboBox1.Text.Replace("\", "") + "\" + ko)
                    LookFile.ad()
                    ComboBox1.Text = ComboBox1.Text.Replace("\", "") + "\" + ko
                Else
                    GoTo m
                End If
            End If
        End If
        Exit Sub
m:      MsgBox("目录已存在！！！", MsgBoxStyle.Information, "提示")
    End Sub
    Private Sub DirCho_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LookFile.Show()
        LookFile.ii()
    End Sub
    Private Sub DirCho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Opacity = Jar.Opacity
        Me.Refresh()
        tmppath = Jar.TextBox9.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListView1.Items.Clear()
    End Sub
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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox1.Text <> "\" Then
            Dim tp = MsgBox("确定删除" + ComboBox1.Text + "吗?", MsgBoxStyle.YesNo, "提示")
            If tp = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(tmppath + ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                LookFile.ad()
            End If
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
        TextBox2.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        ComboBox1.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            ListView1.SelectedItems.Item(0).SubItems(1).Text = ComboBox1.Text
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = TextBox1.Text.Trim.Replace(" ", "_")
        If ListView1.SelectedItems.Count <> 0 Then
            ListView1.SelectedItems.Item(0).Text = TextBox1.Text
        End If
    End Sub
    Private Sub 添加文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文件ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 删除ToolStripMenuItem_Click() Handles 删除ToolStripMenuItem.Click
        On Error Resume Next
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListView1.SelectedItems.Item(0).Remove()
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListView1.Items.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim uu
                For u = 0 To .SelectedPath.Length - 1
                    If Mid(.SelectedPath, u + 1, 1) = "\" Then
                        uu = u
                    End If
                Next
                If My.Computer.FileSystem.DirectoryExists(tmppath + "\" + .SelectedPath.Remove(0, uu + 1)) = False Then
                    My.Computer.FileSystem.CopyDirectory(.SelectedPath, tmppath + "\" + .SelectedPath.Remove(0, uu + 1))
                    LookFile.ad()
                Else
                    MsgBox("目录" + .SelectedPath.Remove(0, uu + 1) + "已存在！！！", MsgBoxStyle.Exclamation, "已存在！！")
                End If
            End If
        End With
    End Sub
End Class