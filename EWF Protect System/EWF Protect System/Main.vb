Public Class Main
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error GoTo g
        Me.Visible = False
        Me.Hide()
        If Command().Trim = "/s" Then
            EWF.Show()
        Else
            EWF.del()
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd", "Filter -all >" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt" + My.Resources.x1, False, System.Text.Encoding.Default)
            Shell(My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\$look.cmd" + My.Resources.x1, AppWinStyle.Hide, True)
            Dim h = (My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.txt", System.Text.Encoding.Default))
            Dim t = h.ToLower.Replace("enable", "")
            If t.Length <> h.Length Then
                EWF.NotifyIcon1.Icon = My.Resources.bear
                EWF.NotifyIcon1.Text = "EWF Protect System" + vbCrLf + "状态: 保护中"
            Else
                EWF.NotifyIcon1.Icon = My.Resources.X
                EWF.NotifyIcon1.Text = "EWF Protect System" + vbCrLf + "状态: 全关闭"
            End If
            EWF.del()
        End If
        Exit Sub
g:      MsgBox("请先安装EWF！", MsgBoxStyle.Exclamation)
        Other.ShowDialog()
    End Sub
End Class