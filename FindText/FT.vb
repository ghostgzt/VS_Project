Public Class FT
    Dim te As System.Text.Encoding = System.Text.Encoding.Default
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As New FolderBrowserDialog
        With t
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择路径:"
            .ShowDialog()
            If .SelectedPath <> "" Then
                TextBox1.Text = .SelectedPath
            End If
        End With
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)).ToUpper = str1f.ToUpper Then
                    If n = 0 Then
                        q = u
                        i = i + 1
                    Else
                        If i = n - 1 Then
                            q = u
                            i = i + 1
                            GoTo p
                        End If
                    End If
                End If
            Next
        End If
p:      If q <> "" Then
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
    Dim c2
    Dim t2
    Function tx(ByVal vv As Boolean)
        TextBox1.Enabled = vv
        TextBox2.Enabled = vv
        ComboBox1.Enabled = vv
        ComboBox2.Enabled = vv
        Button1.Enabled = vv
        Button4.Enabled = vv
        清空ToolStripMenuItem.Enabled = vv
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        If Button2.Text = "查找" Then
            If TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" And ComboBox1.Text.Trim <> "" And ComboBox2.Text.Trim <> "" Then
                ListBox1.Items.Clear()
                c2 = ComboBox2.Text.Trim
                t2 = TextBox2.Text
                tx(False)
                eed = False
                Timer1.Enabled = True
                BackgroundWorker1.RunWorkerAsync()
                Button2.Text = "停止"
                查找ToolStripMenuItem.Text = "停止"
            Else
                MsgBox("请填好所需信息！！！", MsgBoxStyle.Information, "敬告！！！")
            End If
        Else
            eed = True
            tx(True)
            Button2.Text = "查找"
            查找ToolStripMenuItem.Text = "查找"
        End If
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        If ListBox1.SelectedItems.Count <> 0 Then
            On Error Resume Next
            If ListBox1.Items.Count <> 0 Then
                Dim u As New FolderBrowserDialog
                With u
                    .SelectedPath = ""
                    .ShowNewFolderButton = True
                    .Description = "请选择复制路径:"
                    .ShowDialog()
                    If .SelectedPath <> "" Then
                        For c = 0 To ListBox1.SelectedItems.Count - 1
                            My.Computer.FileSystem.CopyFile(ListBox1.SelectedItems(c).ToString, .SelectedPath + "\" + getname(ListBox1.SelectedItems(c).ToString, "\", False, 0), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                        Next
                    End If
                End With
            End If
        End If
    End Sub
    Private Sub Button7_Click() Handles Button7.Click
        Dim tt = MsgBox("您确定要删除这些文件吗?", MsgBoxStyle.YesNo, "删除！！")
        If tt = MsgBoxResult.Yes Then
            For q = 0 To ListBox1.SelectedItems.Count - 1
                On Error Resume Next
                My.Computer.FileSystem.DeleteFile(ListBox1.SelectedItems.Item(0).ToString)
                ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0).ToString)
            Next
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub 查找ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查找ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub 打开ToolStripMenuItem_Click() Handles 打开ToolStripMenuItem.Click
        If ListBox1.Text.Trim <> "" Then
            On Error Resume Next
            Shell("notepad " + ListBox1.Text.Trim, 1, False)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox1.Text.Trim <> "" Then
            On Error Resume Next
            Shell("notepad " + ListBox1.Text.Trim)
        End If
    End Sub
    Private Sub 全选ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem.Click
        On Error Resume Next
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndices.Add(x)
        Next
    End Sub
    Private Sub 复制到ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制到ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        Button7_Click()
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
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        打开ToolStripMenuItem_Click()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Dim ll As New ListBox
    Dim eed As Boolean = False
    Dim r1
    Dim r2
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        ll.Items.Clear()
        Dim k = My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories, c2)
        For r = 0 To k.Count - 1
            If eed = True Then
                GoTo L
            End If
            Dim t = My.Computer.FileSystem.ReadAllText(k(r).ToString, te)
            If getname(t, t2, False, 1) <> "" Or getname(t, t2, True, 1) = "" Or getname(t, t2, True, 1) <> t Then
                r1 = k(r)
                r2 = True
                While r2 = True
                End While
                ll.Items.Add(k(r))
            End If
        Next
        MsgBox("已完成！！！" + vbCrLf + "找到" + Str(ListBox1.Items.Count) + "个符合的文件！！", MsgBoxStyle.Information, "温馨提示！！！")
        Exit Function
L:      MsgBox("已停止！！！" + vbCrLf + "找到" + Str(ListBox1.Items.Count) + "个符合的文件！！", MsgBoxStyle.Information, "温馨提示！！！")
    End Function
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Timer1.Enabled = False
        eed = True
        tx(True)
        Button2.Text = "查找"
        查找ToolStripMenuItem.Text = "查找"
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If r2 = True Then
            ListBox1.Items.Add(r1)
            r2 = False
            r1 = ""
        End If
    End Sub
    Private Sub FT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Command() <> "" Then
            If My.Computer.FileSystem.DirectoryExists(Command.Trim.Replace(Label5.Text, "")) = True Then
                TextBox1.Text = Command.Trim.Replace(Label5.Text, "")
            End If
        End If
    End Sub
    Private Sub TextBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        Dim xu = (e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, True)(0))
        If My.Computer.FileSystem.DirectoryExists(xu.ToString) = True Then
            TextBox1.Text = xu
        End If
    End Sub
    Private Sub TextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
End Class