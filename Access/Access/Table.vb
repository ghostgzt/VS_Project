Public Class Table
    Private Sub Dialog1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = Access.TextBox3.Text
        MsgBox("本文数据可以按Ctrl+C——复制", MsgBoxStyle.Information, "温馨提示！！！")
    End Sub
End Class