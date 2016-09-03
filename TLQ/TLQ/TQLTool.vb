Imports System.Windows.Forms
Public Class TQLTool
    Dim xx As New X
    Private Sub Button1_Click() Handles Button1.Click
        Dim l As Object
        Dim t As Object
        If CheckBox1.Checked = True Then
            l = TextBox1
        Else
            l = Nothing
        End If
        If CheckBox2.Checked = True Then
            t = ListBox1
        Else
            t = Nothing
        End If
        If ComboBox1.Text.Trim = "" Then
            ComboBox1.Text = "*.*"
        End If
        xx.Run(Me, t, l, ComboBox1.Text, CheckBox3.Checked, CheckBox4.Checked)
        MsgBox("修改成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
    End Sub
    Private Sub TLQTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xx.Run(Me, ListBox1, TextBox1, "*.*", True, True)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(xx.Xcount)
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ComboBox1.Enabled = False
            Button2.Enabled = True
        Else
            ComboBox1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        On Error Resume Next
        If ListBox1.Text <> "" Then
            Shell("Rundll32.exe url.dll, FileProtocolHandler " + ListBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
End Class