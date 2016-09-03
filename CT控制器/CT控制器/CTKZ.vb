Imports System.Runtime.InteropServices
Public Class CTKZ
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim bbint As Integer
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            listbox3.Items.Clear()
            bbint = 0
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                Dim tp As String = sb.ToString.Trim
                sadd(tp)
                opq = ""
                fo(sb.ToString.Trim)
                ListView1.Items.Add(sb.ToString.Trim)
                ListView1.Items.Item(ListView1.Items.Count - 1).Text = opq
                ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(sb.ToString.Trim)
                ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = 0
                bbint = bbint + 1
            Next
            For y = 0 To ListView1.Items.Count - 1
                If My.Computer.FileSystem.FileExists(ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP") = False Then
                    My.Computer.FileSystem.CopyFile(ListView1.Items.Item(y).SubItems(1).Text.Trim, ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP")
                    My.Computer.FileSystem.WriteAllBytes(ListView1.Items.Item(y).SubItems(1).Text.Trim, My.Resources.CTP, False)
                Else
                    listbox3.Items.Add(ListView1.Items.Item(y).SubItems(1).Text.Trim)
                End If
            Next
            ro()
            If bbint <> 0 Then
                MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
            DragFinish(m.WParam.ToInt32)
        End If
    End Function
    Dim opq
    Function sadd(ByVal r As String)
        On Error Resume Next
        Dim listbox2 As New ListBox
        listbox2.Items.Clear()
        ListView1.Enabled = False
        If ListView1.Items.Count <> 0 Then
            For b = 0 To ListView1.Items.Count - 1
                listbox2.Items.Add(ListView1.Items(b).SubItems(1).Text)
            Next
        End If
        If listbox2.Items.Count <> 0 Then
            For x = 0 To listbox2.Items.Count - 1
                listbox2.SetSelected(x, True)
                If listbox2.Text = r Then
                    ListView1.Items.RemoveAt(x)
                End If
            Next
        End If
        ListView1.Enabled = True
    End Function
    Function fo(ByVal st As String)
        On Error Resume Next
        Dim mm = ""
        For b = 0 To Len(st) - 1
            If Mid(st, b + 1, 1) = "\" Then
                mm = b
            End If
        Next
        opq = (st.Remove(0, mm + 1))
    End Function
    Dim listbox3 As New ListBox
    Private Sub Button1_Click() Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("处理" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    listbox3.Items.Clear()
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        Dim tp As String = OpenFileDialog1.FileNames(x)
                        sadd(tp)
                        opq = ""
                        fo(OpenFileDialog1.FileNames(x))
                        ListView1.Items.Add(OpenFileDialog1.FileNames(x))
                        ListView1.Items.Item(ListView1.Items.Count - 1).Text = opq
                        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(OpenFileDialog1.FileNames(x))
                        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                        ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = 0
                    Next
                    For y = 0 To ListView1.Items.Count - 1
                        If My.Computer.FileSystem.FileExists(ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP") = False Then
                            My.Computer.FileSystem.CopyFile(ListView1.Items.Item(y).SubItems(1).Text.Trim, ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP")
                            My.Computer.FileSystem.WriteAllBytes(ListView1.Items.Item(y).SubItems(1).Text.Trim, My.Resources.CTP, False)
                        Else
                            listbox3.Items.Add(ListView1.Items.Item(y).SubItems(1).Text.Trim)
                        End If
                    Next
                    ro()
                End If
            End If
        End With
    End Sub
    Function ro()
        On Error Resume Next
        If listbox3.Items.Count <> 0 Then
            Dim kb = ""
            For v = 0 To listbox3.Items.Count - 1
                listbox3.SetSelected(v, True)
                Dim ki = listbox3.Text
                kb = kb + vbCrLf + ki + "已装备"
            Next
            MsgBox("信息:" + kb, MsgBoxStyle.Information)
        End If
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        If ListView1.SelectedItems.Count <> 0 Then
            For c = 0 To ListView1.SelectedItems.Count - 1
                dou(ListView1.SelectedItems.Item(0).SubItems(1).Text)
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            Next
        End If
    End Sub
    Private Sub ListView1_DoubleClick() Handles ListView1.DoubleClick
        On Error GoTo 4
        dou(ListView1.SelectedItems(0).SubItems(1).Text)
        ListView1.Items.Remove(ListView1.SelectedItems(0))
        Exit Sub
4:      MsgBox("卸载失败！！！,请稍后再试！！！", MsgBoxStyle.Exclamation, "卸载CT！")
    End Sub
    Function dou(ByVal dr As String)
        On Error Resume Next
        My.Computer.FileSystem.CopyFile(dr + ".CTP", dr, True)
        My.Computer.FileSystem.DeleteFile(dr + ".CTP")
    End Function
    Private Sub Button3_Click() Handles Button3.Click
        On Error Resume Next
        If ListView1.Items.Count <> 0 Then
            Dim j = MsgBox("你确定退出?" + vbCrLf + "Y - 退出 " + "N - 最小化 " + "Cancle - 取消", MsgBoxStyle.YesNoCancel, "温馨提示！！！")
            If j = MsgBoxResult.Yes Then
                For x = 0 To ListView1.Items.Count - 1
                    dou(ListView1.Items.Item(0).SubItems(1).Text.Trim)
                    ListView1.Items.RemoveAt(0)
                Next
                NotifyIcon1.Icon = Nothing
                End
            Else
                If j = MsgBoxResult.No Then
                    Me.WindowState = FormWindowState.Minimized
                End If
            End If
        Else
            NotifyIcon1.Icon = Nothing
            End
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
        End If
    End Sub
    Private Sub CTKZ_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NotifyIcon1.Icon = Nothing
    End Sub
    Private Sub CT装备ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CT装备ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 卸载CTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 卸载CTToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub CTKZ_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If ListView1.Items.Count <> 0 Then
            Dim j = MsgBox("你确定退出?" + vbCrLf + "Y - 退出 " + "N - 最小化 " + "Cancle - 取消", MsgBoxStyle.YesNoCancel, "温馨提示！！！")
            If j = MsgBoxResult.Yes Then
                For x = 0 To ListView1.Items.Count - 1
                    dou(ListView1.Items.Item(0).SubItems(1).Text.Trim)
                    ListView1.Items.RemoveAt(0)
                Next
            Else
                If j = MsgBoxResult.No Then
                    e.Cancel = True
                    Me.WindowState = FormWindowState.Minimized
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub CTKZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Command() <> "" Then
            If My.Application.CommandLineArgs.Count <> 0 Then
                MsgBox("处理" + My.Application.CommandLineArgs.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                listbox3.Items.Clear()
                For x = 0 To My.Application.CommandLineArgs.Count - 1
                    Dim tp As String = My.Application.CommandLineArgs(x)
                    sadd(tp)
                    opq = ""
                    fo(My.Application.CommandLineArgs(x))
                    ListView1.Items.Add(My.Application.CommandLineArgs(x))
                    ListView1.Items.Item(ListView1.Items.Count - 1).Text = opq
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(My.Application.CommandLineArgs(x))
                    ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                    ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = 0
                Next
                For y = 0 To ListView1.Items.Count - 1
                    If My.Computer.FileSystem.FileExists(ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP") = False Then
                        My.Computer.FileSystem.CopyFile(ListView1.Items.Item(y).SubItems(1).Text.Trim, ListView1.Items.Item(y).SubItems(1).Text.Trim + ".CTP")
                        My.Computer.FileSystem.WriteAllBytes(ListView1.Items.Item(y).SubItems(1).Text.Trim, My.Resources.CTP, False)
                    Else
                        listbox3.Items.Add(ListView1.Items.Item(y).SubItems(1).Text.Trim)
                    End If
                Next
                ro()
                Me.WindowState = FormWindowState.Minimized
            End If
        End If
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For x = 0 To ListView1.Items.Count - 1
            dou(ListView1.Items.Item(0).SubItems(1).Text)
            ListView1.Items.RemoveAt(0)
        Next
    End Sub
End Class