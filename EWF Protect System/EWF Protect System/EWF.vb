Public Class EWF
    Dim sum As String
    Private Sub EWF_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub EWF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshing()
    End Sub
    Function refreshing()
        On Error Resume Next
        ComboBox1.Items.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button6.Enabled = False
        Button1.Text = "启动"
        sum = ""
        Dim k = My.Computer.FileSystem.Drives
        For x = 0 To k.Count - 1
            If (k(x).DriveType) = 3 Then
                ComboBox1.Items.Add(k(x))
            End If
        Next
        del()
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd", My.Resources.look, False, System.Text.Encoding.Default)
        Shell(My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd" + My.Resources.x1, AppWinStyle.Hide, True)
        Dim h = (My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt", System.Text.Encoding.Default))
        sum = h
        If h.Split("-")(0).Trim <> "" Then
            Label2.Text = "已启动EWF的驱动器: " + (h.Split("-")(0).Trim.Replace(":", ":\"))
            NotifyIcon1.Icon = My.Resources.bear
            NotifyIcon1.Text = "EWF Protect System" + vbCrLf + "状态: 保护中"
        Else
            Label2.Text = "没有启动EWF的驱动器"
            NotifyIcon1.Icon = My.Resources.X
            NotifyIcon1.Text = "EWF Protect System" + vbCrLf + "状态: 全关闭"
        End If
        read("Filter -all >" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt" + My.Resources.x1)
    End Function
    Function del()
        On Error Resume Next
        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd")
        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt")
    End Function
    Function jj(ByVal dir As String)
        On Error Resume Next
        Dim t = sum.Split("-")(1).Trim.Replace(":", ":\")
        Dim q = 0
        Dim x = 0
        While x < t.Split(" ").LongCount And q = 0
            If dir.Trim.ToUpper = t.Split(" ")(x).Trim.ToUpper Then
                q = 1
            End If
            x = x + 1
        End While
        If q = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            If jj(ComboBox1.Text.Trim) = 1 Then
                Button1.Text = "启动"
                Button2.Enabled = False
                Button6.Enabled = False
            Else
                Button1.Text = "关闭"
                Button2.Enabled = True
                Button6.Enabled = True
            End If
            Button1.Enabled = True
            read("Filter " + ComboBox1.Text.Trim + " >" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt" + My.Resources.x1)
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        refreshing()
        Me.Show()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Other.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            If Button1.Text = "启动" Then
                If MsgBox("是否在" + ComboBox1.Text.Trim + "上启动EWF?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    read("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -enable")
                    'Shell("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -enable", AppWinStyle.Hide, True)
                    GoTo g
                End If
            Else
                If MsgBox("是否在" + ComboBox1.Text.Trim + "上关闭EWF?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If MsgBox("是否即时关闭(立即生效)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        read("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -commitanddisable -live")
                        refreshing()
                    Else
                        read("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -commitanddisable")
                        'Shell("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -commitanddisable", AppWinStyle.Hide, True)
                        GoTo g
                    End If
                End If
            End If
        End If
        Exit Sub
g:      If MsgBox("重启后生效！" + vbCrLf + "是否重启系统?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Shell("shutdown -r -f -t 00", AppWinStyle.Hide, True)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            If Button1.Text = "关闭" Then
                If MsgBox("是否在" + ComboBox1.Text.Trim + "上保存数据?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    read("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -COMMIT")
                    'Shell("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -COMMIT", AppWinStyle.Hide, True)
                    If MsgBox("重启后生效！" + vbCrLf + "是否重启系统?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Shell("shutdown -r -f -t 00", AppWinStyle.Hide, True)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub EWFSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWFSettingToolStripMenuItem.Click
        On Error Resume Next
        Other.Close()
        Me.Show()
    End Sub
    Private Sub 重启系统ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重启系统ToolStripMenuItem.Click
        If MsgBox("是否重启系统?", MsgBoxStyle.YesNo, "EWF") = MsgBoxResult.Yes Then
            Shell("shutdown -r -f -t 00", AppWinStyle.Hide, True)
        End If
    End Sub
    Private Sub 其他ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 其他ToolStripMenuItem.Click
        On Error Resume Next
        Other.ShowDialog()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        NotifyIcon1.Icon = Nothing
        End
    End Sub
    Function read(ByVal str1 As String)
        On Error Resume Next
        del()
        TextBox1.Text = ""
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd", str1 + " >" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt" + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd" + My.Resources.x1, AppWinStyle.Hide, True)
        TextBox1.Text = (My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt", System.Text.Encoding.Default)).Trim
        del()
    End Function
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        On Error Resume Next
        AB.ShowDialog()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            If Button1.Text = "关闭" Then
                If MsgBox("是否在" + ComboBox1.Text.Trim + "上清除数据?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    read("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -restore")
                    'Shell("Filter " + ComboBox1.Text.Trim.Replace(":\", ":").ToLower + " -restore", AppWinStyle.Hide, True)
                End If
            End If
        End If
    End Sub
End Class