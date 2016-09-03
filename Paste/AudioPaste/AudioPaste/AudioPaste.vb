Public Class AudioPaste
    Dim userInput As New System.IO.MemoryStream
    Dim m1 As New System.IO.MemoryStream
    Dim m2 As New System.IO.MemoryStream
    Dim m3 As New System.IO.MemoryStream
    Dim m4 As New System.IO.MemoryStream
    Dim m5 As New System.IO.MemoryStream
    Dim m6 As New System.IO.MemoryStream
    Dim m7 As New System.IO.MemoryStream
    Dim m8 As New System.IO.MemoryStream
    Dim m9 As New System.IO.MemoryStream
    Dim m10 As New System.IO.MemoryStream
    Dim tt As String
    Dim jj As New PasteExt.MiniIcon
    Dim cc As New PasteExt.EndCommand
    Private Sub writefile(ByVal stream As System.IO.MemoryStream)
        On Error GoTo x
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.Filter = "Wav Files (*.Wav)|*.Wav|All File (*.*)|*.*"
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()
        Dim fileStream As System.IO.Stream
        If (result = DialogResult.OK) Then
            If My.Computer.Clipboard.ContainsAudio Then
                stream = My.Computer.Clipboard.GetAudioStream
            End If
            fileStream = SaveFileDialog1.OpenFile()
            stream.Position = 0
            stream.WriteTo(fileStream)
            fileStream.Close()
            MsgBox("Save Seccessed！！！", MsgBoxStyle.Information)
        End If
        Exit Sub
x:
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        If ListView1.SelectedItems.Count <> 0 Then
            For x = 0 To ListView1.SelectedItems.Count - 1
                My.Computer.Audio.Stop()
                If ListView1.SelectedItems.Item(x).Text = "1.Wav" Then
                    play(m1)
                End If
                If ListView1.SelectedItems.Item(x).Text = "2.Wav" Then
                    play(m2)
                End If
                If ListView1.SelectedItems.Item(x).Text = "3.Wav" Then
                    play(m3)
                End If
                If ListView1.SelectedItems.Item(x).Text = "4.Wav" Then
                    play(m4)
                End If
                If ListView1.SelectedItems.Item(x).Text = "5.Wav" Then
                    play(m5)
                End If
                If ListView1.SelectedItems.Item(x).Text = "6.Wav" Then
                    play(m6)
                End If
                If ListView1.SelectedItems.Item(x).Text = "7.Wav" Then
                    play(m7)
                End If
                If ListView1.SelectedItems.Item(x).Text = "8.Wav" Then
                    play(m8)
                End If
                If ListView1.SelectedItems.Item(x).Text = "9.Wav" Then
                    play(m9)
                End If
                If ListView1.SelectedItems.Item(x).Text = "10.Wav" Then
                    play(m10)
                End If
            Next
        End If
    End Sub
    Function play(ByVal srr As System.IO.MemoryStream)
        srr.Position = 0
        My.Computer.Audio.Play(srr, AudioPlayMode.Background)
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Clipboard.ContainsAudio Then
            Dim xx = My.Computer.Clipboard.GetAudioStream
            If ListView1.Items.Count = 0 Then
                userInput = xx
                m1 = xx
                tt = "1"
                GoTo g
            Else
                If userInput.Length = xx.Length And userInput.ToString = xx.ToString Then
                    If ListView1.Items.Count = 10 Then
                        kou("Audio剪辑板的片段已经超出最大值," + "是否清空并收集新的片段?")
                    End If
                Else
                    userInput = xx
                    If ListView1.Items.Count = 1 Then
                        m2 = xx
                        tt = "2"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 2 Then
                        m3 = xx
                        tt = "3"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 3 Then
                        m4 = xx
                        tt = "4"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 4 Then
                        m5 = xx
                        tt = "5"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 5 Then
                        m6 = xx
                        tt = "6"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 6 Then
                        m7 = xx
                        tt = "7"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 7 Then
                        m8 = xx
                        tt = "8"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 8 Then
                        m9 = xx
                        tt = "9"
                        GoTo g
                    End If
                    If ListView1.Items.Count = 9 Then
                        m10 = xx
                        tt = "10"
                        GoTo g
                    End If
                End If
            End If
        End If
        Exit Sub
g:
        Dim kk As String = tt + ".Wav"
        ListView1.Items.Add(kk, 0)
    End Sub
    Function kou(ByVal text As String)
        Timer1.Enabled = False
        Dim u = MsgBox(text, MsgBoxStyle.YesNo)
        If u = MsgBoxResult.Yes Then
            Dim ie = MsgBox("是否在清空前不保存？？", MsgBoxStyle.YesNo)
            If ie = MsgBoxResult.Yes Then
                ListView1.Items.Clear()
                Timer1.Enabled = True
            Else
                q()
                ListView1.Items.Clear()
                Timer1.Enabled = True
            End If
        Else
            Timer1.Enabled = True
        End If
    End Function
    Function q()
        If ListView1.Items.Count <> 0 Then
            If ListView1.Items.Count < 10 Then
                For x = 0 To ListView1.Items.Count - 1
                    ListView1.Items.Item(x).Selected = True
                    Button2_Click()
                Next
            Else
                writefile(m1)
                writefile(m2)
                writefile(m3)
                writefile(m4)
                writefile(m5)
                writefile(m6)
                writefile(m7)
                writefile(m8)
                writefile(m9)
                writefile(m10)
            End If
        End If
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        If ListView1.SelectedItems.Count <> 0 Then
            For x = 0 To ListView1.SelectedItems.Count - 1
                If ListView1.SelectedItems.Item(x).Text = "1.Wav" Then
                    writefile(m1)
                End If
                If ListView1.SelectedItems.Item(x).Text = "2.Wav" Then
                    writefile(m2)
                End If
                If ListView1.SelectedItems.Item(x).Text = "3.Wav" Then
                    writefile(m3)
                End If
                If ListView1.SelectedItems.Item(x).Text = "4.Wav" Then
                    writefile(m4)
                End If
                If ListView1.SelectedItems.Item(x).Text = "5.Wav" Then
                    writefile(m5)
                End If
                If ListView1.SelectedItems.Item(x).Text = "6.Wav" Then
                    writefile(m6)
                End If
                If ListView1.SelectedItems.Item(x).Text = "7.Wav" Then
                    writefile(m7)
                End If
                If ListView1.SelectedItems.Item(x).Text = "8.Wav" Then
                    writefile(m8)
                End If
                If ListView1.SelectedItems.Item(x).Text = "9.Wav" Then
                    writefile(m9)
                End If
                If ListView1.SelectedItems.Item(x).Text = "10.Wav" Then
                    writefile(m10)
                End If
            Next
        End If
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        My.Computer.Audio.Stop()
    End Sub
    Private Sub 试听ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 试听ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 停止ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 停止ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        q()
    End Sub
    Private Sub 全部保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全部保存ToolStripMenuItem.Click
        q()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        Form1_FormClosing()
        End
    End Sub
    Private Sub Form1_FormClosing() Handles Me.FormClosing
        NotifyIcon1.Icon = Nothing
    End Sub
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        kou("是否清空并收集新的片段?")
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Button1_Click()
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        If ListView1.SelectedItems.Count = 1 Then
            For x = 0 To ListView1.SelectedItems.Count - 1
                If ListView1.SelectedItems.Item(x).Text = "1.Wav" Then
                    upload(m1)
                End If
                If ListView1.SelectedItems.Item(x).Text = "2.Wav" Then
                    upload(m2)
                End If
                If ListView1.SelectedItems.Item(x).Text = "3.Wav" Then
                    upload(m3)
                End If
                If ListView1.SelectedItems.Item(x).Text = "4.Wav" Then
                    upload(m4)
                End If
                If ListView1.SelectedItems.Item(x).Text = "5.Wav" Then
                    upload(m5)
                End If
                If ListView1.SelectedItems.Item(x).Text = "6.Wav" Then
                    upload(m6)
                End If
                If ListView1.SelectedItems.Item(x).Text = "7.Wav" Then
                    upload(m7)
                End If
                If ListView1.SelectedItems.Item(x).Text = "8.Wav" Then
                    upload(m8)
                End If
                If ListView1.SelectedItems.Item(x).Text = "9.Wav" Then
                    upload(m9)
                End If
                If ListView1.SelectedItems.Item(x).Text = "10.Wav" Then
                    upload(m10)
                End If
            Next
        End If
    End Sub
    Function upload(ByVal stt As System.IO.MemoryStream)
        My.Computer.Clipboard.SetAudio(stt)
    End Function
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Button5_Click()
    End Sub
    Private Sub AudioPaste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cc.showend("AudioPaste", False)
        If My.Application.CommandLineArgs.Contains("/MiniTrue") = True Then
            MissWindow1.miss(Me, True, True)
        Else
            MissWindow1.miss(Me, True, False)
        End If
        If My.Application.CommandLineArgs.Contains("/hide") = True Then
            Me.ShowInTaskbar = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If
        If My.Application.CommandLineArgs.Contains("/TopmostFalse") = True Then
            顶端ToolStripMenuItem_Click()
        End If
        If My.Application.CommandLineArgs.Contains("/ShowTask") = True Then
            Me.ShowInTaskbar = True
        Else
            Me.ShowInTaskbar = False
        End If
        If Command() = "/?" Then
            Timer1.Enabled = False
            NotifyIcon1.Icon = Nothing
            MsgBox("AudioPaste.exe [/hide] [/TopmostFalse] [/MiniTrue] [/ShowTask]" + vbCrLf + "[/hide]启动窗口最小化" + vbCrLf + "[/TopmostFalse]取消Topmost" + vbCrLf + "[/MiniTrue]最小还原在原来位置" + vbCrLf + "[/ShowTask]显示在任务栏上", MsgBoxStyle.Information, "AudioPaste参数行")
            End
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        jj.mini(Me, True, "AudioPaste")
        ListView1.Refresh()
    End Sub
    Private Sub 顶端ToolStripMenuItem_Click() Handles 顶端ToolStripMenuItem.Click
        If 顶端ToolStripMenuItem.Checked = True Then
            Me.TopMost = False
            顶端ToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            顶端ToolStripMenuItem.Checked = True
        End If
    End Sub
    Private Sub ListView1_MouseMove() Handles ListView1.MouseMove
        If ListView1.SelectedItems.Count = 0 Then
            sim(False)
        Else
            sim(True)
        End If
    End Sub
    Function sim(ByVal i As Boolean)
        保存ToolStripMenuItem.Visible = i
        试听ToolStripMenuItem.Visible = i
        Button1.Enabled = i
        Button2.Enabled = i
        Button5.Enabled = i
    End Function
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        ListView1_MouseMove()
    End Sub
    Private Sub 顶端ToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles 顶端ToolStripMenuItem.MouseMove
        ListView1_MouseMove()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Paste\AudioPaste", "End", Nothing) = "1" Then
            退出ToolStripMenuItem_Click()
        End If
    End Sub
End Class