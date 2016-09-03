Public Class TG
    Dim tex As TextBox
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        tex.Text = TextBox1.Text
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub TG_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = ""
        TextBox1.Text = tex.Text
    End Sub
    Function set1(ByVal texx As TextBox, ByVal mt As String)
        tex = texx
        Me.Text = "本文修改-" + mt
    End Function
    Private Sub TG_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TableLayoutPanel1.Refresh()
        TableLayoutPanel2.Refresh()
    End Sub
End Class