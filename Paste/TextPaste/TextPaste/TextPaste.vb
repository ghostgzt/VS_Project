Public Class TextPaste
    Dim Text As String
    Dim k As Boolean
    Dim Textbox2 As New System.Windows.Forms.TextBox
    Dim jj As New PasteExt.MissWindow
    Dim cc As New PasteExt.EndCommand
    Private Sub Timer1_Tick() Handles Timer1.Tick
        On Error Resume Next
        Text = ""
        If My.Computer.Clipboard.ContainsText Then
            Text = My.Computer.Clipboard.GetText
            If Text <> "" Then
                Dim w = ListBox1.Items.Count
                ListBox1.SetSelected(w - 1, True)
                Textbox2.Text = ListBox1.Text
                If Textbox2.Text <> Text Then
                    ListBox1.Items.Add(Text)
                    ListBox2.Items.Add(Text)
                End If
            End If
        End If
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        TextBox3.SelectAll()
        TextBox3.Copy()
        If ListBox2.Text <> text Then
            删除这一条ToolStripMenuItem_Click()
        End If
        MsgBox("Copy Sucessed！！！", MsgBoxStyle.Information)
    End Sub
    Private Sub ListBox2_MouseMove() Handles ListBox2.MouseMove
        If ListBox2.Text = "" Then
            删除这一条ToolStripMenuItem.Visible = False
        Else
            删除这一条ToolStripMenuItem.Visible = True
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged() Handles ListBox2.SelectedIndexChanged
        TextBox3.Text = ListBox2.Text
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick() Handles NotifyIcon1.MouseDoubleClick
        If Me.ShowInTaskbar = False Then
            MiniIcon1.mini(Me, True, "TextPaste")
        Else
            MiniIcon1.mini(Me, False, "TextPaste")
        End If
    End Sub
    Private Sub Paste_FormClosing() Handles Me.FormClosing
        en()
        NotifyIcon1.Icon = Nothing
    End Sub
    Function en()
        If k = True Then
            write2(My.Application.Info.DirectoryPath + "\Last Lists.txt")
        End If
    End Function
    Private Sub 删除这一条ToolStripMenuItem_Click() Handles 删除这一条ToolStripMenuItem.Click
        ListBox2.Items.Remove(ListBox2.Text)
    End Sub
    Private Sub 清空剪辑板ToolStripMenuItem_Click() Handles 清空剪辑板ToolStripMenuItem.Click
        If ListBox2.Items.Count <> 0 Then
            Dim i = MsgBox("是否在清空前保存列表？", MsgBoxStyle.YesNoCancel)
            If i <> MsgBoxResult.Cancel Then
                If i = MsgBoxResult.Yes Then
                    全部保存ToolStripMenuItem_Click()
                End If
                no()
            End If
        Else
            no()
        End If
    End Sub
    Function no()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Function
    Private Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        Paste_FormClosing()
        End
    End Sub
    Private Sub NotifyIcon1_MouseMove() Handles NotifyIcon1.MouseMove
        删除这一条ToolStripMenuItem.Visible = False
        If TextBox2.Text <> "" Then
            If text.Length > 64 Then
                NotifyIcon1.Text = text.Remove(60) + "..."
            Else
                NotifyIcon1.Text = text
            End If
        Else
            NotifyIcon1.Text = "剪辑板"
        End If
    End Sub
    Private Sub TextBox3_MouseMove() Handles TextBox3.MouseMove
        If TextBox3.SelectedText = "" Then
            复制ToolStripMenuItem.Visible = False
        Else
            复制ToolStripMenuItem.Visible = True
        End If
        fz()
    End Sub
    Private Sub TextBox3_TextChanged() Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
    Private Sub Paste_Load() Handles Me.Load
        MiniIcon1.rof(False, "TextPaste")
        cc.showend("TextPaste", False)
        If My.Application.CommandLineArgs.Contains("/MiniTrue") = True Then
            jj.miss(Me, True, True)
        Else
            jj.miss(Me, True, False)
        End If
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs.Contains("/hide") = True Then
                Me.ShowInTaskbar = True
                Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
                Me.ShowInTaskbar = False
                MiniIcon1.rof(False, "TextPaste")
            End If
            If My.Application.CommandLineArgs.Contains("/tool") = True Then
                显示标签ToolStripMenuItem_Click()
            End If
            If My.Application.CommandLineArgs.Contains("/saveend") = True Then
                k = True
            Else
                k = False
            End If
            If My.Application.CommandLineArgs.Contains("/dellog") = True Then
                Try
                    Kill(My.Application.Info.DirectoryPath + "\Last Lists.txt")
                Catch
                End Try
            End If
            If My.Application.CommandLineArgs.Contains("/ShowTask") = True Then
                Me.ShowInTaskbar = True
            Else
                Me.ShowInTaskbar = False
            End If
            If Command() = "/?" Then
                NotifyIcon1.Icon = Nothing
                MsgBox("Paste.exe [/hide] [/tool] [/saveend] [/dellog] [/MiniTrue] [/ShowTask]" + vbCrLf + "[/hide]启动窗口最小化" + vbCrLf + "[/tool]显示标签" + vbCrLf + "[/saveend]关闭时保存列表到目录根下" + vbCrLf + "[/dellog]清空Last Lists.txt" + vbCrLf + "[/MiniTrue]最小还原在原来位置" + vbCrLf + "[/ShowTask]显示在任务栏上", MsgBoxStyle.Information, "TextPaste参数行")
                End
            End If
        End If
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        write(False)
    End Sub
    Private Sub 全部保存ToolStripMenuItem_Click() Handles 全部保存ToolStripMenuItem.Click
        write(True)
    End Sub
    Function write(ByVal ko As Boolean)
        With SaveFileDialog1
            .FileName = ""
            .Filter = "本文文件*.txt|*.txt|All Files*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If ko = False Then
                    My.Computer.FileSystem.WriteAllText(.FileName, TextBox3.Text, False)
                Else
                    write2(.FileName)
                End If
                MsgBox("Save Successed！！！", MsgBoxStyle.Information)
            End If
        End With
    End Function
    Function write2(ByVal str As String)
        Dim d As String = Date.Now
        My.Computer.FileSystem.WriteAllText(str, vbCrLf + d, True)
        For x = 0 To ListBox2.Items.Count - 1
            ListBox2.SetSelected(x, True)
            My.Computer.FileSystem.WriteAllText(str, vbCrLf + TextBox3.Text, True)
        Next
    End Function
    Private Sub 复制ToolStripMenuItem_Click() Handles 复制ToolStripMenuItem.Click
        TextBox3.Copy()
    End Sub
    Private Sub 显示标签ToolStripMenuItem_Click() Handles 显示标签ToolStripMenuItem.Click
        If 显示标签ToolStripMenuItem.Text = "显示标签" Then
            显示标签ToolStripMenuItem.Text = "隐藏标签"
            ToolTip1.SetToolTip(TextBox3, TextBox3.Text)
        Else
            显示标签ToolStripMenuItem.Text = "显示标签"
            ToolTip1.SetToolTip(TextBox3, "")
        End If
    End Sub
    Function fz()
        If 显示标签ToolStripMenuItem.Text = "隐藏标签" Then
            ToolTip1.SetToolTip(TextBox3, TextBox3.Text)
        End If
    End Function
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Paste\TextPaste", "End", Nothing) = "1" Then
            退出ToolStripMenuItem_Click()
        End If
    End Sub
End Class