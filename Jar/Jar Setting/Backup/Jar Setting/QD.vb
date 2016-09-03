Public Class QD
    Dim tmppath
    Private Sub QD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = Jar.Opacity
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        tmppath = Jar.TextBox9.Text
        Dim k = My.Computer.FileSystem.GetFiles(tmppath, FileIO.SearchOption.SearchAllSubDirectories, "*.class")
        For i = 0 To k.Count - 1
            ComboBox1.Items.Add(k(i).Replace(tmppath, ""))
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            Dim bo = MsgBox("是否确定修改启动项 " + ComboBox1.Text + " ?", MsgBoxStyle.YesNo)
            If bo = MsgBoxResult.Yes Then
                JS.M1.Text = (JS.MName.Text + "," + JS.MIcon.Text + "," + ComboBox1.Text.Remove(Len(ComboBox1.Text) - 6).Replace("\", ".").Remove(0, 1))
                Me.Close()
            End If
        Else
            MsgBox("请选择启动项！！！", MsgBoxStyle.Information, "提示！！！")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class