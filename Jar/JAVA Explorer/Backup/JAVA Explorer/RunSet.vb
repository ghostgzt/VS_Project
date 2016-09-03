Imports System.Windows.Forms
Public Class RunSet
    Dim gnn As New GN
    Dim ko
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        If RadioButton2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", "")
        End If
        If TextBox1.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "WZ", TextBox1.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "WZ", "")
        End If
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "ZD", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "ZD", "0")
        End If
        If TextBox2.Text.Trim = "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "TM", "10000")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "TM", TextBox2.Text)
        End If
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", "0")
        End If
        If CheckBox4.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XS", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XS", "0")
        End If
        If ComboBox1.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "TB", ComboBox1.Text)
            If ComboBox1.Text <> ko Then
                JE.ci(gnn.getname(ComboBox1.Text, "*", True, 0), gnn.getname(ComboBox1.Text, "*", False, 0))
                JE.AddJar()
            End If
        End If
        If TextBox3.Text <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "BJ", TextBox3.Text)
            JE.ListView1.BackgroundImage = Image.FromFile(TextBox3.Text)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "BJ", "")
            JE.ListView1.BackgroundImage = Nothing
        End If
        If CheckBox3.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Jad", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Jad", "0")
        End If
        If CheckBox5.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "VZ", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "VZ", "0")
        End If
        If CheckBox6.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JM", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JM", "")
        End If
        If CheckBox7.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JE", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JE", "")
        End If
        If CheckBox8.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Last", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Last", "")
        End If
        If CheckBox9.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WaitStop", My.Application.Info.DirectoryPath + "\WaitStop.exe")
        Else
            Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            ke.DeleteValue("WaitStop")
        End If
        If CheckBox10.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "MHide", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "MHide", "0")
        End If
        If CheckBox11.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Topmost", "1")
            JE.TopMost = True
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Topmost", "0")
            JE.TopMost = False
        End If
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub RunSet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        TextBox1.Text = ""
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Run", Nothing)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "WZ", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "ZD", Nothing)
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "TM", Nothing)
        Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "TB", Nothing)
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "BJ", Nothing)
        Dim r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Jad", Nothing)
        Dim r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XS", Nothing)
        Dim r8 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "VZ", Nothing)
        Dim r9 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JM", Nothing)
        Dim ra = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JE", Nothing)
        Dim rb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Last", Nothing)
        Dim rc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "WaitStop", Nothing)
        Dim rd = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "MHide", Nothing)
        Dim ri = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "Topmost", Nothing)
        If r0 <> "" And r0 <> Nothing Then
            RadioButton2.Checked = True
        Else
            RadioButton1.Checked = True
        End If
        If r1 <> "" Then
            TextBox1.Text = r1
        End If
        If r2 = "1" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If r3 <> "" Then
            TextBox2.Text = r3
        Else
            TextBox2.Text = "10000"
        End If
        If r4 <> "" Then
            ComboBox1.Text = r4
            ko = r4
        Else
            ComboBox1.Text = "64*64"
            ko = "64*64"
        End If
        If r5 <> "" Then
            TextBox3.Text = r5
        End If
        If r6 = "0" Then
            CheckBox3.Checked = False
        Else
            CheckBox3.Checked = True
        End If
        If r7 = "1" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
        If r8 = "1" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        If r9 = "1" Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If
        If ra <> "1" Then
            CheckBox7.Checked = False
        Else
            CheckBox7.Checked = True
        End If
        If rb <> "1" Then
            CheckBox8.Checked = False
        Else
            CheckBox8.Checked = True
        End If
        If rc <> "" Then
            CheckBox9.Checked = True
        Else
            CheckBox9.Checked = False
        End If
        If rd <> "1" Then
            CheckBox10.Checked = False
        Else
            CheckBox10.Checked = True
        End If
        If ri <> "1" Then
            CheckBox11.Checked = False
        Else
            CheckBox11.Checked = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            TextBox1.Enabled = False
            Button1.Enabled = False
            Button5.Enabled = True
        Else
            RadioButton2.Checked = True
            TextBox1.Enabled = True
            Button1.Enabled = True
            Button5.Enabled = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            TextBox1.Enabled = True
            Button1.Enabled = True
            CheckBox3.Enabled = True
        Else
            RadioButton1.Checked = True
            TextBox1.Enabled = False
            Button1.Enabled = False
            CheckBox3.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Java Runer *.exe|*.exe|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Me.Hide()
        Shell(My.Application.Info.DirectoryPath + "\JarReg.exe" + " " + TextBox1.Text, AppWinStyle.NormalFocus, True)
        Me.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.Bmp;*.Jpg;*.Png;*.Jpeg;*.Gif;*.Wmf|*.Bmp;*.Jpg;*.Png;*.Jpeg;*.Gif;*.Wmf|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox3.Text = .FileName
                PictureBox1.ImageLocation = .FileName
            End If
        End With
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        PictureBox1.Image = Nothing
        PictureBox1.ImageLocation = TextBox3.Text
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\JAR_RUN.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        TextBox3.Text = ""
    End Sub
End Class