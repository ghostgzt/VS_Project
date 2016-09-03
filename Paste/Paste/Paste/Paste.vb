Public Class Paste
    Dim myProcesses() As Process
    Dim myProcess As Process
    Dim jj As New PasteExt.MissWindow
    Dim cc As New PasteExt.EndCommand
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex() = 1
        Me.AcceptButton = Button3
        Me.CancelButton = Button6
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex() = 0
        Me.AcceptButton = Button2
        Me.CancelButton = Button5
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            textp(True, True)
        Else
            textp(False, True)
        End If
    End Sub
    Function textp(ByVal s As Boolean, ByVal hh As Boolean)
        CheckBox1.Checked = s
        CheckBox3.Checked = s
        CheckBox4.Checked = s
        CheckBox5.Checked = s
        CheckBox6.Checked = s
        CheckBox14.Checked = s
        If hh = True Then
            CheckBox17.Checked = s
        Else
            CheckBox17.Checked = False
        End If
    End Function
    Function imagep(ByVal s As Boolean, ByVal hh As Boolean)
        CheckBox2.Checked = s
        CheckBox7.Checked = s
        CheckBox8.Checked = s
        CheckBox9.Checked = s
        CheckBox13.Checked = s
        CheckBox15.Checked = s
        If hh = True Then
            CheckBox18.Checked = s
        Else
            CheckBox18.Checked = False
        End If
    End Function
    Function textch(ByVal ch1 As CheckBox, ByVal ch2 As CheckBox, ByVal ch3 As CheckBox, ByVal ch4 As CheckBox, ByVal ch5 As CheckBox, ByVal ch6 As CheckBox, ByVal ch7 As CheckBox)
        If ch2.Checked = False And ch3.Checked = False And ch4.Checked = False And ch5.Checked = False And ch6.Checked = False And ch7.Checked = False Then
            ch1.CheckState = CheckState.Unchecked
        Else
            If ch2.Checked = True And ch3.Checked = True And ch4.Checked = True And ch5.Checked = True And ch6.Checked = True And ch7.Checked = True Then
                ch1.CheckState = CheckState.Checked
            Else
                ch1.CheckState = CheckState.Indeterminate
            End If
        End If
    End Function
    Private Sub CheckBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.Click
        text11()
    End Sub
    Private Sub CheckBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        text11()
    End Sub
    Private Sub CheckBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        text11()
    End Sub
    Private Sub CheckBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        text11()
    End Sub
    Private Sub CheckBox7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox7.Click
        image11()
    End Sub
    Private Sub CheckBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.Click
        image11()
    End Sub
    Private Sub CheckBox9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox9.Click
        image11()
    End Sub
    Private Sub CheckBox13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox13.Click
        image11()
    End Sub
    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked = True Then
            imagep(True, True)
        Else
            imagep(False, True)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TabControl1.SelectedIndex() = 2
        Me.AcceptButton = Button10
        Me.CancelButton = Button8
    End Sub
    Function audioch()
        If CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox16.Checked = False And CheckBox19.Checked = False Then
            CheckBox10.CheckState = CheckState.Unchecked
        Else
            If CheckBox11.Checked = True And CheckBox12.Checked = True And CheckBox16.Checked = True And CheckBox19.Checked = True Then
                CheckBox10.CheckState = CheckState.Checked
            Else
                CheckBox10.CheckState = CheckState.Indeterminate
            End If
        End If
    End Function
    Function audiop(ByVal s As Boolean, ByVal hh As Boolean)
        CheckBox10.Checked = s
        CheckBox11.Checked = s
        CheckBox12.Checked = s
        CheckBox16.Checked = s
        If hh = True Then
            CheckBox19.Checked = s
        Else
            CheckBox19.Checked = False
        End If
    End Function
    Private Sub CheckBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox10.Click
        If CheckBox10.Checked = True Then
            audiop(True, True)
        Else
            audiop(False, True)
        End If
    End Sub
    Private Sub CheckBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox11.Click
        audioch()
    End Sub
    Private Sub CheckBox12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox12.Click
        audioch()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TabControl1.SelectedIndex() = 1
        Me.AcceptButton = Button3
        Me.CancelButton = Button6
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        Timer1.Enabled = False
        If Button2.Text = "&Stop" Then
            endd("TextPaste")
        Else
        Dim uo = ""
        If CheckBox6.Checked = True Then
            uo = uo + " /hide"
        End If
        If CheckBox3.Checked = True Then
            uo = uo + " /tool"
        End If
        If CheckBox4.Checked = True Then
            uo = uo + " /saveend"
        End If
        If CheckBox5.Checked = True Then
            uo = uo + " /dellog"
        End If
        If CheckBox14.Checked = True Then
            uo = uo + " /MiniTrue"
        End If
        If CheckBox17.Checked = True Then
            uo = uo + " /ShowTask"
        End If
        textpast(uo)
        End If
        TabPage1_MouseMove()
        Timer1.Enabled = True
    End Sub
    Function textpast(ByVal s As String)
        Shell(My.Application.Info.DirectoryPath + "\TextPaste.exe" + s)
    End Function
    Function imagepast(ByVal s As String)
        Shell(My.Application.Info.DirectoryPath + "\ImagePaste.exe" + s)
    End Function
    Function text2(ByVal s As Boolean)
        CheckBox1.Enabled = s
        CheckBox3.Enabled = s
        CheckBox4.Enabled = s
        CheckBox5.Enabled = s
        CheckBox6.Enabled = s
        CheckBox14.Enabled = s
        CheckBox17.Enabled = s
    End Function
    Function image2(ByVal s As Boolean)
        CheckBox2.Enabled = s
        CheckBox7.Enabled = s
        CheckBox8.Enabled = s
        CheckBox9.Enabled = s
        CheckBox13.Enabled = s
        CheckBox15.Enabled = s
        CheckBox18.Enabled = s
    End Function
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.AcceptButton = Button2
            Me.CancelButton = Button5
        End If
        If TabControl1.SelectedIndex = 1 Then
            Me.AcceptButton = Button3
            Me.CancelButton = Button6
        End If
        If TabControl1.SelectedIndex = 2 Then
            Me.AcceptButton = Button10
            Me.CancelButton = Button8
        End If
    End Sub
    Function audio2(ByVal s As Boolean)
        CheckBox10.Enabled = s
        CheckBox11.Enabled = s
        CheckBox12.Enabled = s
        CheckBox16.Enabled = s
        CheckBox19.Enabled = s
    End Function
    Private Sub Button3_Click() Handles Button3.Click
        Timer1.Enabled = False
        If Button3.Text = "&Stop" Then
            endd("ImagePaste")
      Else
            Dim uo = ""
            If CheckBox7.Checked = True Then
                uo = uo + " /hide"
            End If
            If CheckBox13.Checked = True Then
                uo = uo + " /TopmostFalse"
            End If
            If CheckBox8.Checked = True Then
                uo = uo + " /saveend"
            End If
            If CheckBox9.Checked = True Then
                uo = uo + " /dellog"
            End If
            If CheckBox15.Checked = True Then
                uo = uo + " /MiniTrue"
            End If
            If CheckBox18.Checked = True Then
                uo = uo + " /ShowTask"
            End If
            imagepast(uo)
        End If
        TabPage2_MouseMove()
        Timer1.Enabled = True
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
    Function audiopast(ByVal s As String)
        Shell(My.Application.Info.DirectoryPath + "\AudioPaste.exe" + s)
    End Function
    Private Sub Button10_Click() Handles Button10.Click
        Timer1.Enabled = False
        If Button10.Text = "&Stop" Then
            endd("AudioPaste")
        Else
            Dim uo = ""
            If CheckBox11.Checked = True Then
                uo = uo + " /hide"
            End If
            If CheckBox12.Checked = True Then
                uo = uo + " /TopmostFalse"
            End If
            If CheckBox16.Checked = True Then
                uo = uo + " /MiniTrue"
            End If
            If CheckBox19.Checked = True Then
                uo = uo + " /ShowTask"
            End If
            audiopast(uo)
        End If
        TabPage3_MouseMove()
        Timer1.Enabled = True
    End Sub
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        应用ToolStripMenuItem.Text = "TextPaste " + Button2.Text
        ImagePasteToolStripMenuItem.Text = "ImagePaste " + Button3.Text
        AudioPasteToolStripMenuItem.Text = "AudioPaste " + Button10.Text
        If Button2.Text = "&应用" And Button3.Text = "&应用" And Button10.Text = "&应用" Then
            AllToolStripMenuItem.Visible = True
            AllToolStripMenuItem.Text = "All " + "Run"
        Else
            If Button2.Text = "&Stop" And Button3.Text = "&Stop" And Button10.Text = "&Stop" Then
                AllToolStripMenuItem.Visible = True
                AllToolStripMenuItem.Text = "All " + "Stop"
            Else
                AllToolStripMenuItem.Visible = False
            End If
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub 应用ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 应用ToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub ImagePasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagePasteToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub AudioPasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioPasteToolStripMenuItem.Click
        Button10_Click()
    End Sub
    Private Sub AllToolStripMenuItem_Click() Handles AllToolStripMenuItem.Click
        Button2_Click()
        Button3_Click()
        Button10_Click()
    End Sub
    Private Sub Paste_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon1.Icon = Nothing
    End Sub
    Private Sub Paste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        jj.miss(Me, True, True)
        If My.Application.CommandLineArgs.Contains("/AllCommand") = True And My.Application.CommandLineArgs.Contains("/UnShowTask") = False Then
            textp(True, True)
            imagep(True, True)
            audiop(True, True)
        End If
        If My.Application.CommandLineArgs.Contains("/AllCommand") = True And My.Application.CommandLineArgs.Contains("/UnShowTask") = True Then
            textp(True, False)
            imagep(True, False)
            audiop(True, False)
        End If
        If My.Application.CommandLineArgs.Contains("/hide") = True Then
            Me.ShowInTaskbar = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If
        If My.Application.CommandLineArgs.Contains("/TopmostFalse") = True Then
            顶端ToolStripMenuItem_Click()
        End If
        If My.Application.CommandLineArgs.Contains("/TextPaste") = True Then
            Button2_Click()
        End If
        If My.Application.CommandLineArgs.Contains("/ImagePaste") = True Then
            Button3_Click()
        End If
        If My.Application.CommandLineArgs.Contains("/AudioPaste") = True Then
            Button10_Click()
        End If
        If My.Application.CommandLineArgs.Contains("/AllRun") = True Then
            AllToolStripMenuItem_Click()
        End If
        If Command() = "/?" Then
            NotifyIcon1.Icon = Nothing
            MsgBox("Paste.exe [/hide] [/AllRun] [Un/ShowTask] [/AllCommand] [/TextPaste] [/ImagePaste] [/AudioPaste] [/TopmostFalse]" + vbCrLf + "[/hide]启动窗口最小化" + vbCrLf + "[/AllRun]全部启动" + vbCrLf + "[/AllCommand]执行所有程序指令" + vbCrLf + "[/TextPaste]启动TextPaste" + vbCrLf + "[/ImagePaste]启动ImagePaste" + vbCrLf + "[/UnShowTask]不显示在任务栏上" + vbCrLf + "[/AudioPaste]启动AudioPaste" + vbCrLf + "[/TopmostFalse]取消Topmost", MsgBoxStyle.Information, "Paste参数行")
            End
        End If
        TabPage1_MouseMove()
        TabPage2_MouseMove()
        TabPage3_MouseMove()
    End Sub
    Private Sub TabPage1_MouseMove() Handles TabPage1.MouseMove
        myProcesses = Process.GetProcesses()
        Dim ti = "0"
        For Each myProcess In myProcesses
            If myProcess.ProcessName = "TextPaste" Then
                ti = 1
            End If
        Next
        If ti = 1 Then
            Button2.Text = "&Stop"
            text2(False)
        Else
            If ti = 0 Then
                Button2.Text = "&应用"
                If CheckBox1.Enabled = False Then
                    text2(True)
                End If
            End If
        End If
    End Sub
    Private Sub TabPage2_MouseMove() Handles TabPage2.MouseMove
        myProcesses = Process.GetProcesses()
        Dim ti = "0"
        For Each myProcess In myProcesses
            If myProcess.ProcessName = "ImagePaste" Then
                ti = 1
            End If
        Next
        If ti = 1 Then
            Button3.Text = "&Stop"
            image2(False)
        Else
            If ti = 0 Then
                Button3.Text = "&应用"
                If CheckBox2.Enabled = False Then
                    image2(True)
                End If
            End If
        End If
    End Sub
    Private Sub TabPage3_MouseMove() Handles TabPage3.MouseMove
        myProcesses = Process.GetProcesses()
        Dim ti = 0
        For Each myProcess In myProcesses
            If myProcess.ProcessName = "AudioPaste" Then
                ti = 1
            End If
        Next
        If ti = 1 Then
            Button10.Text = "&Stop"
            audio2(False)
        Else
            If ti = 0 Then
                Button10.Text = "&应用"
                If CheckBox10.Enabled = False Then
                    audio2(True)
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TabPage1_MouseMove()
        TabPage2_MouseMove()
        TabPage3_MouseMove()
        Timer1.Enabled = False
    End Sub
    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick() Handles NotifyIcon1.MouseDoubleClick
        MiniIcon1.mini(Me, True, "Paste")
        TabControl1.Refresh()
    End Sub
    Private Sub CheckBox14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox14.Click
        text11()
    End Sub
    Private Sub CheckBox17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox17.Click
        text11()
    End Sub
    Function text11()
        textch(CheckBox1, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox14, CheckBox17)
    End Function
    Function image11()
        textch(CheckBox2, CheckBox7, CheckBox8, CheckBox9, CheckBox13, CheckBox15, CheckBox18)
    End Function
    Private Sub CheckBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox18.Click
        image11()
    End Sub
    Private Sub CheckBox19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox19.Click
        audioch()
    End Sub
    Private Sub CheckBox16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox16.Click
        audioch()
    End Sub
    Function endd(ByVal d As String)
        myProcesses = Process.GetProcessesByName(d)
        For Each myProcess In myProcesses
            If myProcess.ProcessName = d Then
                cc.showend(d, True)
            End If
        Next
        Timer3.Enabled = True
    End Function
    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Timer1.Enabled = True
    End Sub
    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Timer1.Enabled = True
    End Sub
    Private Sub Button10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseMove
        Timer1.Enabled = True
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer1.Enabled = True
    End Sub
End Class