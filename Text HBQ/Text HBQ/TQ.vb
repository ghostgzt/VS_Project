Imports System.Runtime.InteropServices
Public Class TQ
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim te As System.Text.Encoding = System.Text.Encoding.Default
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
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Private Sub Button1_Click() Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "本文文件 *.TXT|*.TXT|*.*|*.*"
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
        TextBox2.Text = ""
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有TXT的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
                For qq = 0 To tt.count - 1
                    ListBox1.Items.Remove(tt(qq))
                    ListBox1.Items.Add(tt(qq))
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
        TextBox2.Text = ""
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        TextBox2.Text = ""
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub Button4_Click() Handles Button4.Click
        TextBox2.Text = ""
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        On Error Resume Next
        If ListBox1.Text <> "" Then
            Shell("Notepad.exe " + ListBox1.Text)
        End If
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        End
    End Sub
    Private Sub Button7_Click() Handles Button7.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "*.TXT|*.TXT|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub ListBox1_SelectedIndexChanged() Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        TextBox2.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged() Handles ComboBox1.SelectedIndexChanged
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
        ListBox1_SelectedIndexChanged()
    End Sub
    Private Sub TQ_Load() Handles MyBase.Load
        ComboBox1.Text = "Default"
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
    End Sub
    Private Sub Button8_Click() Handles Button8.Click
        If ListBox1.Items.Count <> 0 Then
            If TextBox1.Text <> "" Then
                If MsgBox("确定要合并?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                    Me.Enabled = False
                    Dim tz As String
                    tz = ""
                    For x = 0 To ListBox1.Items.Count - 1
                        Dim tg As String = My.Computer.FileSystem.ReadAllText(ListBox1.Items(x), te)
                        If tz <> "" Then
                            tz = tz + vbCrLf + tg
                        Else
                            tz = tg
                        End If
                    Next
                    On Error GoTo f
                    If tz <> "" Then
                        If My.Computer.FileSystem.FileExists(TextBox1.Text) = True Then
                            Rename(TextBox1.Text, TextBox1.Text + ".Bak")
                        End If
                        My.Computer.FileSystem.WriteAllText(TextBox1.Text, tz, False, te)
                        If MsgBox("合并成功！" + vbCrLf + "是否要打开?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            On Error Resume Next
                            Shell("Notepad.exe " + TextBox1.Text)
                        End If
                    Else
                        GoTo f
                    End If
                End If
            Else
                Button7_Click()
                Button8_Click()
            End If
        End If
        Me.Enabled = True
        Exit Sub
f:      MsgBox("合并失败！！！", MsgBoxStyle.Exclamation, "操作失败！！！")
        Me.Enabled = True
    End Sub
    Private Sub 添加文件ToolStripMenuItem_Click() Handles 添加文件ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 添加文件夹ToolStripMenuItem_Click() Handles 添加文件夹ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click() Handles 删除这一条ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click() Handles 清空列表ToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Private Sub 打开ToolStripMenuItem_Click() Handles 打开ToolStripMenuItem.Click
        Button5_Click()
    End Sub
    Private Sub 保存为ToolStripMenuItem_Click() Handles 保存为ToolStripMenuItem.Click
        Button7_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub 合并ToolStripMenuItem_Click() Handles 合并ToolStripMenuItem.Click
        Button8_Click()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button4_Click()
        TextBox1.Text = ""
        TQ_Load()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.SelectedItems.Count <> 0 Then
            删除这一条ToolStripMenuItem.Visible = True
            打开ToolStripMenuItem.Visible = True
            合并ToolStripMenuItem.Visible = True
        Else
            删除这一条ToolStripMenuItem.Visible = False
            打开ToolStripMenuItem.Visible = False
            合并ToolStripMenuItem.Visible = False
        End If
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
    Private Sub 上移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 上移ToolStripMenuItem.Click
        SY()
    End Sub
    Private Sub 下移ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 下移ToolStripMenuItem.Click
        XY()
    End Sub
End Class