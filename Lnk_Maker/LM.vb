Public Class LM
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "快捷方式 *.Lnk|*.Lnk"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox2.Text = .FileName
            End If
        End With
    End Sub
    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "图标文件 *.ico|*.ico|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox4.Text = .FileName
            End If
        End With
    End Sub
    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo Q
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox5.Text = "" Then
                TextBox5.Text = "0"
            End If
            If CheckBox2.Checked = True Then
                Dim kke = (getname(TextBox1.Text, ".", True, 0))
                TextBox1.Text = kke
            End If
            Dim vt As String = My.Application.Info.DirectoryPath + "\lk.idx"
            If My.Computer.FileSystem.FileExists(vt) = False Then
                My.Computer.FileSystem.WriteAllBytes(vt, My.Resources.WinCMD, False)
            End If
            Shell(vt + " LINK !" + TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text)
            MsgBox("生成成功！！！", MsgBoxStyle.Information)
            Me.Close()
        End If
        Exit Sub
Q:      MsgBox("生成失败！！！", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub
    Public Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If CheckBox1.Checked = True And TextBox2.Text <> "" And CheckBox2.Checked = True Then
            TextBox1.Text = desk() + "\" + TextBox2.Text.Split("\")(TextBox2.Text.Split("\").LongLength - 1)
        Else
            If CheckBox1.Checked = True And TextBox2.Text <> "" And CheckBox2.Checked = False Then
                TextBox1.Text = TextBox2.Text
            End If
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)) = str1f Then
                    If n = 0 Then
                        q = u
                        i = i + 1
                    Else
                        If i = n - 1 Then
                            q = u
                            i = i + 1
                            GoTo p
                        End If
                    End If
                End If
            Next
        End If
p:      If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + Len(str1f))
            Else
                Return str.Remove(q)
            End If
        Else
            If qh = True Then
                Return str
            Else
                Return ""
            End If
        End If
    End Function
    Public Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            If TextBox2.Text <> "" Then
                TextBox1.Text = desk() + "\" + TextBox2.Text.Split("\")(TextBox2.Text.Split("\").LongLength - 1)
            End If
        Else
            TextBox1.Enabled = True
            Button1.Enabled = True
            TextBox1.Text = ""
        End If
    End Sub
    Public Sub LM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If Command() <> "" Then
            TextBox1.Text = My.Application.CommandLineArgs.Item(0).Trim
            TextBox2.Text = My.Application.CommandLineArgs.Item(1).Trim
            TextBox3.Text = My.Application.CommandLineArgs.Item(2).Trim
            TextBox4.Text = My.Application.CommandLineArgs.Item(3).Trim
            TextBox5.Text = My.Application.CommandLineArgs.Item(5).Trim
        End If
    End Sub
    Function desk()
        On Error Resume Next
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Desktop", My.Computer.FileSystem.SpecialDirectories.Desktop)
    End Function
    Function tr(ByVal t1 As String, ByVal t2 As String)
        On Error Resume Next
        TextBox1.Text = t1
        TextBox2.Text = t2
    End Function
    Function te(ByVal t1 As Boolean, ByVal t2 As Boolean)
        On Error Resume Next
        TextBox1.Enabled = t1
        Button1.Enabled = t1
        TextBox2.Enabled = t2
        Button2.Enabled = t2
    End Function
    Function ct(ByVal c1 As Boolean, ByVal c2 As Boolean)
        On Error Resume Next
        CheckBox1.Checked = c1
        CheckBox2.Checked = c2
    End Function
    Function doit()
        On Error Resume Next
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox5.Text = "" Then
                TextBox5.Text = "0"
            End If
            If CheckBox2.Checked = True Then
                Dim kke = (getname(TextBox1.Text, ".", True, 0))
                TextBox1.Text = kke
            End If
            Dim vt As String = My.Application.Info.DirectoryPath + "\lk.idx"
            If My.Computer.FileSystem.FileExists(vt) = False Then
                My.Computer.FileSystem.WriteAllBytes(vt, My.Resources.WinCMD, False)
            End If
            Shell(vt + " LINK !" + TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text)
        End If
    End Function
    Function ki(ByVal kr As String)
        On Error Resume Next
        Pic2Ico.TextBox1.Text = kr
    End Function
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Pic2Ico.ShowDialog()
        Me.Show()
    End Sub
End Class