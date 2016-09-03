Public Class TH
    Private Sub TH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = VBS.TextBox1.SelectedText
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            VBS.TextBox1.Text = VBS.TextBox1.Text.Replace(TextBox1.Text, TextBox2.Text)
            Me.Close()
        Else
            MsgBox("原文不能空！！！", MsgBoxStyle.Exclamation, "敬告！！！")
        End If
    End Sub
End Class