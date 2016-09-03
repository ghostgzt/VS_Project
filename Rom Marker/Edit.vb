Imports System.Windows.Forms
Public Class Edit
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        done()
    End Sub
    Function done()
        On Error Resume Next
        If Me.Text = "手动编辑 - Autorun.inf" Then
            If TextBox1.Text.Trim <> "" Then
                Shell("Attrib -s -r -h " + RM.Label5.Text + RM.ComboBox1.Text + "Autorun.inf" + RM.Label5.Text, 0, True)
                My.Computer.FileSystem.WriteAllText(RM.ComboBox1.Text + "Autorun.inf", TextBox1.Text, False, System.Text.Encoding.Default)
                Shell("Attrib +s +r +h " + RM.Label5.Text + RM.ComboBox1.Text + "Autorun.inf" + RM.Label5.Text, 0, True)
            Else
                Shell("Attrib -s -r -h " + RM.Label5.Text + RM.ComboBox1.Text + "Autorun.inf" + RM.Label5.Text, 0, True)
                My.Computer.FileSystem.DeleteFile(RM.ComboBox1.Text + "Autorun.inf")
            End If
            TabControl1.SelectedTab = TabPage2
            RM.ComboBox1_SelectedIndexChanged()
        Else
            If TextBox2.Text.Trim <> "" And RM.RadioButton2.Checked = True Then
                Shell("Attrib -s -r -h " + RM.Label5.Text + RM.TextBox6.Text + "\Desktop.ini" + RM.Label5.Text, 0, True)
                My.Computer.FileSystem.WriteAllText(RM.TextBox6.Text + "\Desktop.ini", TextBox2.Text, False, System.Text.Encoding.Default)
                Shell("Attrib +s +r +h " + RM.Label5.Text + RM.TextBox6.Text + "\Desktop.ini" + RM.Label5.Text, 0, True)
                If RM.CheckBox2.Checked = True Then
                    Shell("Attrib +h +r +s " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.Hide, True)
                Else
                    Shell("Attrib  -s -r -h " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.Hide, True)
                    Shell("Attrib +s " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.Hide, True)
                End If
                If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                    Shell("explorer " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.MaximizedFocus)
                End If
                RM.TextBox6_TextChanged()
            Else
                If TextBox2.Text.Trim <> "" And RM.RadioButton1.Checked = True Then
                    Shell("Attrib -s -r -h " + RM.Label5.Text + RM.ComboBox1.Text + "Desktop.ini" + RM.Label5.Text, 0, True)
                    My.Computer.FileSystem.WriteAllText(RM.ComboBox1.Text + "Desktop.ini", TextBox2.Text, False, System.Text.Encoding.Default)
                    Shell("Attrib +s +r +h " + RM.Label5.Text + RM.ComboBox1.Text + "Desktop.ini" + RM.Label5.Text, 0, True)
                    If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                        Shell("explorer " + RM.Label5.Text + RM.ComboBox1.Text + RM.Label5.Text, AppWinStyle.MaximizedFocus)
                    End If
                    RM.ComboBox1_SelectedIndexChanged()
                Else
                    If TextBox2.Text.Trim = "" And RM.RadioButton1.Checked = True Then
                        Shell("Attrib -s -r -h " + RM.Label5.Text + RM.ComboBox1.Text + "Desktop.ini" + RM.Label5.Text, 0, True)
                        My.Computer.FileSystem.DeleteFile(RM.ComboBox1.Text + "Desktop.ini")
                        If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                            Shell("explorer " + RM.Label5.Text + RM.ComboBox1.Text + RM.Label5.Text, AppWinStyle.MaximizedFocus)
                        End If
                        RM.ComboBox1_SelectedIndexChanged()
                    Else
                        If TextBox2.Text.Trim = "" And RM.RadioButton2.Checked = True Then
                            Shell("Attrib  -s -r -h " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.Hide, True)
                            Shell("Attrib  -s -r -h " + RM.Label5.Text + RM.TextBox6.Text + "\Desktop.ini" + RM.Label5.Text, AppWinStyle.Hide, True)
                            My.Computer.FileSystem.DeleteFile(RM.TextBox6.Text + "\Desktop.ini")
                            If MsgBox("操作成功！" + vbCrLf + "是否打开该视图?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                                Shell("explorer " + RM.Label5.Text + RM.TextBox6.Text + RM.Label5.Text, AppWinStyle.MaximizedFocus)
                            End If
                            RM.TextBox6_TextChanged()
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oo As New OpenFileDialog
        With oo
            .FileName = ""
            .Filter = "All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                On Error GoTo g
                If Me.Text = "手动编辑 - Autorun.inf" Then
                    TextBox1.Text = My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.Default)
                Else
                    TextBox2.Text = My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.Default)
                End If
            End If
        End With
        Exit Sub
g:      MsgBox("读取错误！", MsgBoxStyle.Exclamation, "敬告！！！")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.Text = "手动编辑 - Autorun.inf" Then
            TextBox1.Text = My.Resources.A
        Else
            If RM.RadioButton1.Checked = True Then
                TextBox2.Text = My.Resources.X
            Else
                TextBox2.Text = My.Resources.D
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedIndex = 0) Then
            Me.Text = "手动编辑 - Autorun.inf"
        Else
            Me.Text = "手动编辑 - Desktop.ini"
        End If
    End Sub
End Class