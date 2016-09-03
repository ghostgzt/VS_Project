Public Class Other
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If EWF.NotifyIcon1.Icon Is Nothing Then
            End
        Else
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If MsgBox("是否安装EWF?", MsgBoxStyle.YesNo, "EWF") = MsgBoxResult.Yes Then
            ChDir(My.Resources.x1 + My.Application.Info.DirectoryPath + "\EWF_Files" + My.Resources.x1)
            Shell(My.Resources.x1 + My.Application.Info.DirectoryPath + "\EWF_Files\setup.bat" + My.Resources.x1, AppWinStyle.NormalFocus, True)
            ChDir(My.Resources.x1 + My.Application.Info.DirectoryPath + My.Resources.x1)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        If MsgBox("是否启动一次休眠多次快速启动功能?", MsgBoxStyle.YesNo, "EWF") = MsgBoxResult.Yes Then
            If My.Computer.FileSystem.FileExists("C:\HORM.Dat") = False Then
                Dim d As New OpenFileDialog
                With d
                    .FileName = ""
                    .Filter = "HORM.Dat文件|HORM.Dat"
                    .ShowDialog()
                    If .FileName <> "" = True Then
                        My.Computer.FileSystem.CopyFile(.FileName, "C:\HORM.Dat", True)
                    Else
                        MsgBox("缺失HORM.Dat文件！", MsgBoxStyle.Exclamation, "EWF")
                    End If
                    If My.Computer.FileSystem.FileExists("C:\hiberfil.sys") = True Then
                        EWF.read("Filter C: -activatehorm")
                        '   Shell("Filter C: -activatehorm", AppWinStyle.Hide, True)
                    Else
                        MsgBox("没有开启休眠功能,请先启动休眠功能！", MsgBoxStyle.Exclamation, "EWF")
                    End If
                End With
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        If MsgBox("是否关闭一次休眠多次快速启动功能?", MsgBoxStyle.YesNo, "EWF") = MsgBoxResult.Yes Then
            Shell("Filter C: -DISABLE", AppWinStyle.Hide, True)
            EWF.read("Filter C: -deactivatehorm")
            ' Shell("Filter C: -deactivatehorm", AppWinStyle.Hide, True)
            MsgBox("重启系统后生效！", MsgBoxStyle.Information, "EWF")
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("是否重启系统?", MsgBoxStyle.YesNo, "EWF") = MsgBoxResult.Yes Then
            Shell("shutdown -r -f -t 00", AppWinStyle.Hide, True)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If yo = 0 Then
            On Error Resume Next
            If CheckBox1.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "EWF", My.Application.Info.DirectoryPath + "\EWF Protect System.exe")
            Else
                Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                ke.DeleteValue("EWF")
            End If
        End If
    End Sub
    Dim yo = 0
    Private Sub Other_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If EWF.NotifyIcon1.Icon Is Nothing Then
            End
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub Other_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error GoTo g
        yo = 1
        Dim r = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "EWF", Nothing)
        If r.ToString.Trim <> "" And r.ToString.Trim <> Nothing Then
            CheckBox1.Checked = True
        Else
g:          CheckBox1.Checked = False
        End If
        yo = 0
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Me.Hide()
        Dim j = InputBox("请输入命令行:", "命令行", "")
        If j.Trim <> "" Then
            EWF.read("Filter " + j)
            ' Shell("Filter " + j, AppWinStyle.NormalFocus, False)
            If EWF.TextBox1.Text <> "" Then
                MsgBox("输出结果:" + vbCrLf + EWF.TextBox1.Text.Trim, MsgBoxStyle.Information, "EWF")
            Else
                MsgBox("操作完成！！！", MsgBoxStyle.Information, "EWF")
            End If
        End If
        Me.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        AB.ShowDialog()
        Me.Show()
    End Sub
End Class