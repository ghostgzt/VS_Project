Public Class SetBox
    Dim mouseOffset
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        opp(TextBox2, "*.exe|*.exe")
    End Sub
    Function opp(ByVal textxx As TextBox, ByVal filter As String)
        With Jar.OpenFileDialog1
            .FileName = ""
            .Filter = filter
            .ShowDialog()
            If .FileName <> "" Then
                textxx.Text = .FileName
            End If
        End With
    End Function
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
            Button2.Enabled = True
        Else
            TextBox2.Enabled = False
            Button2.Enabled = False
        End If
    End Sub
    Private Sub SetBox_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Mini.Show()
    End Sub
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub SetBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proo = False
        Mini.Hide()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Jar Setting")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Run", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pic", Nothing)
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", Nothing)
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Opacity", Nothing)
        Dim r6 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MP", Nothing)
        Dim r7 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MH", Nothing)
        Dim r8 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MW", Nothing)
        Dim r9 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Mini", Nothing)
        Dim r0 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Jad", Nothing)
        Dim ra As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Yin", Nothing)
        Dim rb As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MF", Nothing)
        Dim rc As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", Nothing)
        If r2 <> Nothing Then
            CheckBox2.Checked = True
            TextBox2.Text = r2
        End If
        If r6 <> "" Then
            TextBox3.Text = r6
        Else
            TextBox3.Text = ""
        End If
        If r7 <> Nothing And r8 <> Nothing Then
            ComboBox1.Text = Str(r8).Trim + "*" + Str(r7).Trim
        End If
        If r1 <> Nothing Then
            CheckBox3.Checked = True
            TextBox1.Text = r1
        End If
        If r3 = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If r5 <> Nothing Then
            TextBox4.Text = r5
            ProgressBar1.Value = r5
        Else
            TextBox4.Text = Me.Opacity * 100
            ProgressBar1.Value = Me.Opacity * 100
        End If
        If r9 = "1" Then
            CheckBox4.CheckState = CheckState.Unchecked
        End If
        If r0 <> "" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        If ra <> "" Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If
        If rb = "" Then
            CheckBox7.Checked = True
        Else
            CheckBox7.Checked = False
        End If
        If rc = "0" Then
            CheckBox8.Checked = False
        Else
            CheckBox8.Checked = True
        End If
        Button7.Image = Me.Icon.ToBitmap
        Button9.BackgroundImage = Me.BackgroundImage
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Progress.exe") = True Then
            Button8.Enabled = True
            Button10.Enabled = True
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\bg.xy") = True Then
                PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\bg.xy"
            End If
        Else
            Button8.Enabled = False
            Button10.Enabled = False
            PictureBox1.Image = Nothing
        End If
        jj.Text = ""
        Me.Refresh()
    End Sub
    Function re()
        Jar.ContextMenuStrip1.Enabled = False
        If MsgBox("是否重新启动？！", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Jar.del()
            Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe", 1)
            Jar.NotifyIcon1.Icon = Nothing
            End
        Else
            Me.Close()
            Jar.ContextMenuStrip1.Enabled = True
        End If
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        re()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ProgressBar1.Value >= 0 And ProgressBar1.Value <= 99 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
            TextBox4.Text = TextBox4.Text + 1
        End If
        Me.Opacity = TextBox4.Text * 0.01
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ProgressBar1.Value >= 1 And ProgressBar1.Value <= 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 1
            TextBox4.Text = TextBox4.Text - 1
        End If
        Me.Opacity = TextBox4.Text * 0.01
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.Text = 100
        End If
        If TextBox4.Text > 100 Then
            TextBox4.Text = 100
            ProgressBar1.Value = 100
        End If
        If TextBox4.Text < 0 Then
            TextBox4.Text = 0
            ProgressBar1.Value = 0
        End If
        Me.Opacity = TextBox4.Text * 0.01
        If TextBox4.Text >= 0 And TextBox4.Text <= 100 Then
            ProgressBar1.Value = TextBox4.Text
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If CheckBox2.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pic", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pic", TextBox2.Text)
        End If
        If CheckBox3.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Run", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Run", TextBox1.Text)
        End If
        If CheckBox4.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Mini", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Mini", "")
        End If
        If CheckBox5.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Jad", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Jad", "1")
        End If
        If TextBox3.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MP", TextBox3.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MP", "")
        End If
        If CheckBox6.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Yin", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Yin", "1")
        End If
        If CheckBox7.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MF", "")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MF", "1")
        End If
        If CheckBox8.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", "0")
        End If
        If ComboBox1.Text <> "" Then
            Dim emailparts() As String
            Dim user As String
            Dim provider As String
            emailparts = ComboBox1.Text.Split("*".ToCharArray, 2)
            If emailparts.Length = 2 Then
                user = emailparts(0)
                provider = emailparts(1)
            Else
                user = ""
                provider = ""
            End If
            If user <> "" And provider <> "" Or ComboBox1.Text <> "" Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MW", user)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MH", provider)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MW", "")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MH", "")
            End If
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", CheckBox1.Checked)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Opacity", TextBox4.Text)
        On Error Resume Next
        If jj.Text <> "" Then
            My.Computer.FileSystem.CopyFile(jj.Text, My.Application.Info.DirectoryPath + "\bg.xy", True)
        Else
            If proo = True Then
                On Error Resume Next
                Kill(My.Application.Info.DirectoryPath + "\bg.xy")
            End If
        End If
        re()
    End Sub
    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Function s(ByVal e)
        mouseOffset = New Point(-e.X, -e.Y)
    End Function
    Function se(ByVal e)
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Function
    Private Sub Button7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseDown
        s(e)
    End Sub
    Private Sub Button7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove
        se(e)
    End Sub
    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        s(e)
    End Sub
    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        se(e)
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox1.Enabled = True
            Button1.Enabled = True
        Else
            TextBox1.Enabled = False
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opp(TextBox1, "*.exe|*.exe")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        opp(TextBox3, "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png|*.*|*.*")
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        On Error Resume Next
        Button3.BackgroundImage = Nothing
        Dim u As New PictureBox
        u.WaitOnLoad = True
        u.ImageLocation = TextBox3.Text
        If u.Image Is Nothing Then
            ComboBox1.Text = ""
        Else
            ComboBox1.Text = Str(u.Image.Width).Trim + "*" + Str(u.Image.Height).Trim
        End If
        Button3.BackgroundImage = u.Image
        If TextBox3.Text = "" Then
            ComboBox1.Text = ""
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox1.Enabled = True
            TextBox3.Enabled = True
            Button3.Enabled = True
        Else
            ComboBox1.Enabled = False
            TextBox3.Enabled = False
            Button3.Enabled = False
        End If
    End Sub
    Dim jj As New TextBox
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        jj.Text = ""
        opp(jj, "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png|*.*|*.*")
        If jj.Text <> "" Then
            PictureBox1.ImageLocation = jj.Text
        End If
    End Sub
    Dim proo As Boolean = False
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        PictureBox1.Image = My.Resources._1
        jj.Text = ""
        proo = True
    End Sub
End Class