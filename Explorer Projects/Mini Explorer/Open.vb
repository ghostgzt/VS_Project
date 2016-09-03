Public Class Open
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim sp
        sp = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing)
        If Me.RadioButton1.Checked = True Then
            Mini_Explorer.TextBox2.Text = sp + "\explorer.exe"
            GoTo t
        End If
        If Me.RadioButton2.Checked = True Then
            Mini_Explorer.TextBox2.Text = sp + "\notepad.exe"
            GoTo t
        End If
        If Me.RadioButton3.Checked = True Then
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "*.EXE|*.exe"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                Mini_Explorer.TextBox2.Text = OpenFileDialog1.FileName
                GoTo t
            End If
        End If
        If RadioButton4.Checked = True Then
            On Error Resume Next
            Shell(Mini_Explorer.TextBox5.Text + TextBox1.Text + Mini_Explorer.TextBox5.Text + " " + Mini_Explorer.TextBox1.Text + Mini_Explorer.File1.FileName, AppWinStyle.NormalFocus)
        End If
        Exit Sub
t:      Shell(Mini_Explorer.TextBox5.Text + Mini_Explorer.TextBox2.Text + Mini_Explorer.TextBox5.Text + " " + Mini_Explorer.TextBox1.Text + Mini_Explorer.File1.FileName, AppWinStyle.NormalFocus)
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ui(True, False, False, False, False)
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ui(False, True, False, False, False)
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ui(False, False, True, False, False)
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ui(False, False, False, True, True)
        End If
    End Sub
    Function ui(ByVal t As Boolean, ByVal q As Boolean, ByVal w As Boolean, ByVal e As Boolean, ByVal r As Boolean)
        RadioButton1.Checked = t
        RadioButton2.Checked = q
        RadioButton3.Checked = w
        RadioButton4.Checked = e
        TextBox1.Enabled = r
    End Function
End Class