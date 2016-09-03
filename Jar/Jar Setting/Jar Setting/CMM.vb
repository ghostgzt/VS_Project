Public Class CMM
    Dim tmppath
    Private Sub CMM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LookFile.Show()
    End Sub
    Private Sub CMM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmppath = Jar.TextBox9.Text
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo err
        If TextBox3.Text <> TextBox2.Text Then
            My.Computer.FileSystem.RenameFile(tmppath + TextBox1.Text, TextBox3.Text)
        End If
        Exit Sub
err:
        MsgBox("重命名失败！！！", MsgBoxStyle.Exclamation, "重命名")
        TextBox3.Text = TextBox2.Text
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class