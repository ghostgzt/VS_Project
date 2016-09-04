Public Class Main
    Dim sp = "C:\Windows\System32\Drivers\etc\hosts"
    Dim sd = "C:\Windows\System32\Drivers\etc\host"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo s
        MsgBox("开始去广告")
        Shell("attrib -r -h -s " + sp)
        My.Computer.FileSystem.WriteAllText(sp, My.Resources.host, False, System.Text.Encoding.Default)
        Shell("attrib +r +h +s " + sp)
        '假装
        My.Computer.FileSystem.WriteAllText(sd, My.Resources.host, False, System.Text.Encoding.Default)
        '创建host的快捷方式混淆视听
        MsgBox("去除迅雷广告成功", MsgBoxStyle.Information)
        Exit Sub
s:      MsgBox("请以管理员权限运行", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim hosts = My.Computer.FileSystem.ReadAllText(sp)
        MsgBox(hosts)
        readhosts(hosts)
    End Sub
    Function readhosts(hosts As String)
        On Error Resume Next
        Dim ss As Array = hosts.Split(vbCrLf)
        Dim dx(0 To ss.Length - 1, 0 To 1) As String
        For x = 0 To ss.Length - 1
            For y = 0 To 1
                dx(x, y) = ss(x).ToString.Split(" ")(y).Trim
            Next
        Next
        For x = 0 To ss.Length - 1
            If dx(x, 0) <> Nothing And dx(x, 1) <> Nothing Then
                Dim xk = ListView1.Items.Add(dx(x, 1))
                xk.SubItems.Add(dx(x, 0))
            End If
        Next
        ListView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
    End Function
    Function writehosts(path As String)
        On Error Resume Next
        Dim xx = ""
        For x = 0 To ListView1.Items.Count - 1
            xx = xx + vbCrLf + ListView1.Items(x).SubItems(1).Text + " " + ListView1.Items(x).SubItems(0).Text
        Next
        My.Computer.FileSystem.WriteAllText(path, xx, False)
    End Function
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AE.Text = "添加规则"
        AE.TextBox1.Text = ""
        AE.ComboBox1.Text = ""
        AE.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            AE.Text = "编辑规则"
            AE.TextBox1.Text = ListView1.SelectedItems(0).Text
            AE.ComboBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
            AE.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For x = 0 To ListView1.SelectedItems.Count - 1
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        With New OpenFileDialog
            .Filter = "*.*|*.*"
            .FileName = ""
            .ShowDialog()
            If .FileName <> "" Then
                readhosts(My.Computer.FileSystem.ReadAllText(.FileName))
            End If
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        With New SaveFileDialog
            .Filter = "*.*|*.*"
            .FileName = ""
            .ShowDialog()
            If .FileName <> "" Then
                writehosts(.FileName)
            End If
        End With
    End Sub
End Class