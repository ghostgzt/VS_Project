Public Class J_R
    Function allend()
        On Error Resume Next
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$2.tmp")
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$4.tmp")
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$5.tmp")
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jad", FileIO.DeleteDirectoryOption.DeleteAllContents)
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jad")
    End Function
    Private Sub J_R_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        allend()
    End Sub
    Private Sub J_R(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        JX = "xNokiaN73"
        ComboBox1.SelectedItem = ComboBox1.Items.Item(2)
        loadreg()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        If Command() <> "" Then
            If My.Application.CommandLineArgs.Item(0).ToLower = "/jad" Then
                Dim j As New Jad
                j.MakeJad(My.Application.CommandLineArgs(1).Trim)
            Else
                If r1.ToString = "" Then
                    d1()
                Else
                    d2(Command)
                End If
            End If
            allend()
            End
        Else
            If r1.ToString <> "" Then
                allend()
                End
            Else
                Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Run", "Run", Nothing)
                If r2 = "1" Or My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\KEmulator\KEmulator.exe") = False Then
                    RadioButton2.Checked = True
                    If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\KEmulator\KEmulator.exe") = False Then
                        MsgBox("请安装KEmulator在程序目录根下的KEmulator目录里！！！", MsgBoxStyle.Exclamation, "找不到KEmulator程序！！！")
                        RadioButton1.Enabled = False
                    End If
                Else
                    RadioButton1.Checked = True
                End If
            End If
        End If
    End Sub
    Dim JX As String
    Function d1()
        On Error Resume Next
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Run", "Run", Nothing)
        If r1 = "1" Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
            ChDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$2.tmp", My.Resources.Jar_RUN_, False)
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$4.tmp", My.Resources.unzip, False)
            Shell(Label1.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$4.tmp" + Label1.Text + " -o " + " " + Label1.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$2.tmp" + Label1.Text, AppWinStyle.Hide, True)
            writeskin()
            Shell(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\sjboy.exe" + " " + Command.Trim + " " + JX, AppWinStyle.NormalFocus)
        Else
            Shell(My.Application.Info.DirectoryPath + "\KEmulator\KEmulator.exe" + " " + Command.Trim, AppWinStyle.NormalFocus)
        End If
    End Function
    Function d2(ByVal jar)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "WZ", Nothing)
        If r1.ToString <> "" Then
            Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Jad", Nothing)
            If r2 = True Then
                Dim k As New Jad
                k.MakeJad(jar.Replace(Label1.Text, ""))
                Shell(r0 + " " + Label1.Text + Mid(jar.Replace(Label1.Text, ""), 1, Len(jar.Replace(Label1.Text, "")) - 1) + "d" + Label1.Text, AppWinStyle.NormalFocus)
            Else
                Shell(r0 + " " + Label1.Text + jar.Replace(Label1.Text, "") + Label1.Text, AppWinStyle.NormalFocus)
            End If
            allend()
        End If
    End Function
    Function writeskin()
        On Error Resume Next
        If NumericUpDown1.Value <> Nothing And NumericUpDown2.Value <> Nothing And ComboBox1.Text <> "" Then
            Dim rw As String = TextBox1.Text
            rw = rw.Replace("WWWW", NumericUpDown1.Value)
            rw = rw.Replace("HHHH", NumericUpDown2.Value)
            rw = rw.Replace("FFFF", FBL())
            rw = rw.Replace("MMMM", NumericUpDown2.Value - 30)
            rw = rw.Replace("NNNN", NumericUpDown1.Value - 30)
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\plugin\skin\" + Skin(), rw, False, System.Text.Encoding.Default)
        End If
    End Function
    Function FBL()
        Dim fff As String = "230400"
        If ComboBox1.SelectedIndex = 0 Then
            fff = "109824"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            fff = "49152"
        End If
        If ComboBox1.SelectedIndex = 2 Then
            fff = "230400"
        End If
        If ComboBox1.SelectedIndex = 3 Then
            fff = "116688"
        End If
        If ComboBox1.SelectedIndex = 4 Then
            fff = "107712"
        End If
        Return fff
    End Function
    Function Skin()
        Dim sss As String = "nokian73x2.skin"
        If ComboBox1.SelectedIndex = 0 Then
            sss = "nokiax2.skin"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            sss = "nokiasx2.skin"
        End If
        If ComboBox1.SelectedIndex = 2 Then
            sss = "nokian73x2.skin"
        End If
        If ComboBox1.SelectedIndex = 3 Then
            sss = "sex2.skin"
        End If
        If ComboBox1.SelectedIndex = 4 Then
            sss = "motox2.skin"
        End If
        Return sss
    End Function
    Function loadreg()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Jar Run")
        Dim r1 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Run", "W", Nothing)
        Dim r2 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Run", "H", Nothing)
        Dim r3 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Run", "F", Nothing)
        If r1 <> Nothing Then
            NumericUpDown1.Value = r1.ToString.Trim
        End If
        If r2 <> Nothing Then
            NumericUpDown2.Value = r2.ToString.Trim
        End If
        If r3 <> Nothing Then
            ComboBox1.Text = r3.ToString
            If ComboBox1.Text = "" Then
                ComboBox1.Text = "xNokiaN73"
            End If
        End If
    End Function
    Function savereg()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Jar Run")
        If RadioButton2.Checked = True Then
            If NumericUpDown1.Value <> Nothing Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "W", NumericUpDown1.Value)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "W", 240)
            End If
            If NumericUpDown2.Value <> Nothing Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "H", NumericUpDown2.Value)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "H", 320)
            End If
            If ComboBox1.Text <> Nothing Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "F", ComboBox1.Text)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "F", "xNokiaN73")
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "Run", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Run", "Run", "0")
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            NumericUpDown1.Value = "240"
            NumericUpDown2.Value = "320"
            ComboBox1.Text = "xNokiaN73"
        Else
            TextBox2.Text = Label5.Text
        End If
        savereg()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        If RadioButton2.Checked = True Then
            If NumericUpDown1.Value <> Nothing And NumericUpDown2.Value <> Nothing And ComboBox1.Text <> "" Then
                savereg()
                MsgBox("请重新启动！！！", MsgBoxStyle.Information, "温馨提示！！！")
                allend()
                End
            Else
                MsgBox("请填写正确！！！", MsgBoxStyle.Exclamation, "敬告！！！")
            End If
        Else
            If TextBox2.Text <> "" Then
                savereg()
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\KEmulator\property.txt", TextBox2.Text, False, System.Text.Encoding.Default)
                MsgBox("请重新启动！！！", MsgBoxStyle.Information, "温馨提示！！！")
                allend()
                End
            Else
                MsgBox("请填写正确！！！", MsgBoxStyle.Exclamation, "敬告！！！")
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        allend()
        End
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        JX = ComboBox1.Text
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        On Error Resume Next
        If RadioButton1.Checked = True Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\KEmulator\property.txt") = False Then
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\KEmulator\property.txt", Label5.Text, False, System.Text.Encoding.Default)
            End If
            TextBox2.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\KEmulator\property.txt", System.Text.Encoding.Default)
            Panel2.Visible = True
            Panel1.Visible = False
            RadioButton2.Checked = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            Panel2.Visible = False
            Panel1.Visible = True
        End If
    End Sub
End Class