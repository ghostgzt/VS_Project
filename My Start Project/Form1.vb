Public Class MyStart
 Private Sub Form1_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cancel As Boolean = eventArgs.Cancel
        Dim unloadmode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If unloadmode = 0 Or unloadmode = 3 Then
            cancel = True
            My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
            Me.NotifyIcon1.Icon = Nothing
            End
        End If
        eventArgs.Cancel = cancel
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sp As String
        Dim sm As String
        Dim sti As String
        Dim sf As String
        Dim str As String
        Dim stf As String
        Dim stis As String
        Dim mx As String
        Dim myy As String
        Dim col As String
        Dim edw As String
        Dim pop As String
        Dim desk As Integer
        Dim mov As String
        Dim fff As String
        Dim desk2 As Integer
        On Error GoTo e
        Me.ProgressBar1.Value = 100
        Call Round_Corners(Me)
        Call Make_On_Top(Me.Handle.ToInt32, True)
        sp = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Picture", Nothing)
        sm = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Music", Nothing)
        sti = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Time up", Nothing)
        sf = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Font", Nothing)
        str = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "True/False1", Nothing)
        stf = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "True/False2", Nothing)
        stis = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Times", Nothing)
        mx = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "X", Nothing)
        myy = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Y", Nothing)
        col = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Transparency Color", Nothing))
        edw = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "dxy", Nothing))
        pop = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Picture or Path", Nothing))
        desk = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "desk", Nothing))
        mov = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "M or V", Nothing))
        fff = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Full", Nothing))
        desk2 = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "desk2", Nothing))
        TextBox7.Text = mov
        If TextBox7.Text = "" Then
            TextBox7.Text = "0"
        End If
        If col = "" Then
        Else
            If col = "1" Then
                Me.TransparencyKey = Color.Transparent
            End If
            If col = "2" Then
                Me.TransparencyKey = Color.White
            End If
            If col = "3" Then
                Me.TransparencyKey = Color.Coral
            End If
            If col = "4" Then
                Me.TransparencyKey = Color.Black
            End If
            If col = "5" Then
                Me.TransparencyKey = Color.Red
            End If
            If col = "6" Then
                Me.TransparencyKey = Color.Purple
            End If
            If col = "7" Then
                Me.TransparencyKey = Color.Yellow
            End If
            If col = "8" Then
                Me.TransparencyKey = Color.Gold
            End If
            If col = "9" Then
                Me.TransparencyKey = Color.Green
            End If
            If col = "10" Then
                Me.TransparencyKey = Color.Pink
            End If
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Y", Nothing) Is Nothing Or My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "X", Nothing) Is Nothing Then
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            If mx = "" Or myy = "" Then
                Me.StartPosition = FormStartPosition.CenterScreen
            Else
                Me.Left = mx
                Me.Top = myy
            End If
        End If
        Text1.Text = sp
        Text2.Text = sm
        Text3.Text = sti
        Text4.Text = sf
        Text5.Text = str
        Text6.Text = stf
        Text7.Text = stis
        TextBox2.Text = edw
        Me.TextBox4.Text = desk
        Me.TextBox5.Text = desk2
        If TextBox4.Text = "" Or TextBox5.Text = "" Then
            TextBox4.Text = "800"
            TextBox5.Text = "600"
        End If
        If pop = "" Then
            GoTo e
        End If
        If pop = 1 Then
            Image2.Image = System.Drawing.Image.FromFile(Text1.Text)
            Me.BackgroundImage = System.Drawing.Image.FromFile(Text1.Text)
            Me.Height = Image2.Height
            Me.Width = Image2.Width
            Call Round_Corners(Me)
            Call Make_On_Top(Me.Handle.ToInt32, True)
            If Me.Image2.Image.Width > TextBox4.Text Then
                Me.Top = 0
                Me.Left = 0
                Me.Width = TextBox4.Text
                Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                Me.StartPosition = FormStartPosition.CenterParent
            Else
                Me.Height = Image2.Height
                Me.Width = Image2.Width
                PictureBox1.Height = Me.Size.Height
                PictureBox1.Width = Me.Size.Width
                Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                Me.ProgressBar1.Left = VB6.TwipsToPixelsY(137 / 470 * VB6.PixelsToTwipsY(Me.Width))
                Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Width = Me.Width
            End If
            If Me.Image2.Height > TextBox5.Text Then
                Me.Top = 0
                Me.Left = 0
                Me.Height = TextBox5.Text
                Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                Me.StartPosition = FormStartPosition.CenterParent
            Else
                Me.Height = Image2.Height
                Me.Width = Image2.Width
                PictureBox1.Height = Me.Size.Height
                PictureBox1.Width = Me.Size.Width
                Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                Me.ProgressBar1.Left = VB6.TwipsToPixelsY(137 / 470 * VB6.PixelsToTwipsY(Me.Width))
                Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Width = Me.Width
            End If
        End If
        If pop = 2 Then
            Me.Label1.Enabled = False
            Me.Label1.Visible = False
            Me.Label2.Enabled = False
            Me.Label1.Visible = False
            Me.Label1.SendToBack()
            Me.Label2.SendToBack()
            File1.Path = sp
            Dim f As Short
            f = File1.SelectedIndex + 1
            File1.SelectedIndex = f
            Me.Image2.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
            PictureBox1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
            Me.Label3.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
            Me.Visible = False
            Timer6.Enabled = True
             Timer4.Enabled = True
        End If
        If Text7.Text = "" Or Text7.Text = "0" Then
        Else
            If Text7.Text >= 65001 Or Text7.Text <= "0" Then
                GoTo e
            End If
        End If
        If Text1.Text = "" Or Text2.Text = "" Then
            Me.Visible = False
        End If
        On Error Resume Next
        Timer1.Interval = Text3.Text
        Timer1.Enabled = True
        If Text3.Text = "0" Then
            Me.ProgressBar1.Visible = False
            Timer1.Interval = 1
            Timer1.Enabled = True
        End If
        If Text3.Text = "" Then
            Me.ProgressBar1.Visible = False
            Timer1.Enabled = False
        ElseIf Text3.Text >= 65001 Then
            Me.WindowsMediaPlayer1.URL = ""
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Me.Visible = False
            Me.ProgressBar1.Visible = False
            GoTo e
        End If
        If edw = "True" Then
            Me.Height = 317
            Me.Width = 470
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Top = mx
            Me.Left = myy
            Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
            Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
            Label1.Left = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Width))
            Label2.Width = Me.Width
            If Me.Height >= TextBox5.Text Or Me.Width >= TextBox4.Text Then
                Me.TopMost = False
                Me.ProgressBar1.Top = (90 / 100 * (Me.Height))
                Me.ProgressBar1.Left = (40 / 100 * (Me.Width))
            Else
                Me.TopMost = True
                Me.ProgressBar1.Top = (90 / 100 * (Me.Height))
                Me.ProgressBar1.Left = (137 / 470 * (Me.Width))
            End If
            Me.TextBox1.Text = "True"
            Call Round_Corners(Me)
            Call Make_On_Top(Me.Handle.ToInt32, True)
        End If
        If mov = "1" Or mov = "" Then
            Me.WindowsMediaPlayer1.fullScreen = False
            Me.WindowsMediaPlayer1.Visible = False
            WindowsMediaPlayer1.URL = Text2.Text
            Me.影音全屏ToolStripMenuItem.Visible = False
            Me.视图转换ToolStripMenuItem.Visible = False
            WindowsMediaPlayer1.Height = "36"
            Me.WindowsMediaPlayer1.Width = "199"
        End If
        If mov = "2" Then
            If Text2.Text = "" Then
                Me.影音全屏ToolStripMenuItem.Visible = False
                Me.视图转换ToolStripMenuItem.Visible = False
            Else
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Me.Width = 470
                Me.Height = 317
                Me.MaximizeBox = False
                Timer4.Enabled = False
                Timer5.Enabled = True
                WindowsMediaPlayer1.URL = Text2.Text
                WindowsMediaPlayer1.Visible = True
            End If
        End If
        Exit Sub
e:
        MsgBox("请先运行STAT修改器进行设置", MsgBoxStyle.Information, "STAT登陆播放器未进行设置")
        Shell(My.Application.Info.DirectoryPath + "\Start Setting.exe", 1)
        End
        Exit Sub
    End Sub
    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        AboutBox1.Show()
    End Sub
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If Text4.Text = "" Then
            Label1.Text = ""
            Label1.Visible = False
            Label2.Visible = False
            If Text5.Text = "" Or Text5.Text = "0" Then
                Timer2.Enabled = False
            Else
                Timer2.Enabled = (Text5.Text)
            End If
            If Text6.Text = "" Or Text6.Text = "0" Then
                Timer3.Enabled = False
            Else
                Timer3.Enabled = (Text6.Text)
            End If
        Else
            Label1.Text = Text4.Text
            Label1.AutoSize = True
            If Text5.Text = "" Or Text5.Text = "0" Then
                Timer2.Enabled = False
            Else
                Timer2.Enabled = (Text5.Text)
            End If
            If Text6.Text = "" Or Text6.Text = "0" Then
                Timer3.Enabled = False
            Else
                Timer3.Enabled = (Text6.Text)
            End If
        End If
        Exit Sub
e:
        MsgBox("请先运行STAT修改器进行设置", MsgBoxStyle.Information, "STAT登陆播放器未进行设置")
        Shell(My.Application.Info.DirectoryPath + "\Start Setting.exe", 1)
    End Sub
    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        On Error GoTo e
        If Text4.Text = "" Then
            Label1.Text = ""
            Label1.Visible = False
            Label2.Visible = False
            If Text5.Text = "" Or Text5.Text = "0" Then
                Timer2.Enabled = False
            Else
                Timer2.Enabled = (Text5.Text)
            End If
            If Text6.Text = "" Or Text6.Text = "0" Then
                Timer3.Enabled = False
            Else
                Timer3.Enabled = (Text6.Text)
            End If
        Else
            Label1.Text = Text4.Text
            Label1.AutoSize = True
            If Text5.Text = "" Or Text5.Text = "0" Then
                Timer2.Enabled = False
            Else
                Timer2.Enabled = (Text5.Text)
            End If
            If Text6.Text = "" Or Text6.Text = "0" Then
                Timer3.Enabled = False
            Else
                Timer3.Enabled = (Text6.Text)
            End If
        End If
        Exit Sub
e:
        MsgBox("请先运行STAT修改器进行设置", MsgBoxStyle.Information, "STAT登陆播放器未进行设置")
        Dim retval As Object
        retval = Shell(My.Application.Info.DirectoryPath + "\Start Setting.exe", 1)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 Then
            On Error GoTo e
            Me.ProgressBar1.Value = -(100 / Text3.Text * 100) + Me.ProgressBar1.Value
        ElseIf Me.ProgressBar1.Value <= 0 Then

            Me.Visible = False
            Timer1.Enabled = False
        End If
        Exit Sub
e:      Me.ProgressBar1.Value = 0
    End Sub
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Label1.Left = Label1.Left - Text7.Text
        If Label1.Left <= -(Label1.Left + Label1.Width) Then
            Label1.Left = Me.Width
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim r As Byte, G As Byte, B As Byte
        Randomize()
        r = Int(Rnd() * 255) + 1
        G = Int(Rnd() * 255) + 1
        B = Int(Rnd() * 255) + 1
        Label1.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(r, G, B))
    End Sub
    Private Sub MyStart_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        If Me.WindowsMediaPlayer1.Visible = True And TextBox7.Text = 2 Then
            WindowsMediaPlayer1.Height = Me.Height - 30
            WindowsMediaPlayer1.Width = Me.Width
        End If
        Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
        Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
        Label1.Left = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Width))
        Label2.Width = Me.Width
        If Me.Height >= TextBox5.Text Or Me.Width >= TextBox4.Text Then
            Me.TopMost = False
            Me.ProgressBar1.Top = (90 / 100 * (Me.Height))
            Me.ProgressBar1.Left = (40 / 100 * (Me.Width))
        Else
            Me.TopMost = True
            Me.ProgressBar1.Top = (90 / 100 * (Me.Height))
            Me.ProgressBar1.Left = (137 / 470 * (Me.Width))
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
    End Sub
    Private Sub 出现ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 出现ToolStripMenuItem.Click
        Dim edw As String
        edw = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Picture or Path", Nothing))
        If edw = 2 Then
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Timer4.Enabled = True
            End If
        Else
            Timer4.Enabled = False
        End If
        Me.Visible = True
        Me.ProgressBar1.Visible = False
    End Sub
    Private Sub StattSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StattSettingToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Private Sub 隐藏ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 隐藏ToolStripMenuItem.Click
        Timer4.Enabled = False
        Me.Visible = False
        Me.ProgressBar1.Visible = False
    End Sub
    Private Sub 重新启动ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重新启动ToolStripMenuItem.Click
        Dim retval As Object
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
        retval = Shell(My.Application.Info.DirectoryPath + "\My Start.exe", 1)
        End
    End Sub
    Private Sub 退出ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
        Me.NotifyIcon1.Icon = Nothing
        End
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If TextBox3.Text = "" Or TextBox3.Text = "0" Then
            Timer4.Enabled = False
            TextBox3.Text = "1"
        End If
        If Me.TextBox1.Text = "" Then
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label1.Left = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Width))
                Label2.Width = Me.Width
                If Image2.Height >= TextBox4.Text Or Image2.Width >= TextBox5.Text Then
                    Me.MaximizeBox = True
                Else
                    Me.MaximizeBox = False
                End If
                On Error Resume Next
                If Me.Height >= TextBox5.Text Or Me.Width >= TextBox4.Text Then
                    Me.TopMost = False
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                Else
                    Me.TopMost = True
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(137 / 470 * VB6.PixelsToTwipsY(Me.Width))
                End If
            Else
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Call Round_Corners(Me)
                Call Make_On_Top(Me.Handle.ToInt32, True)
                Label1.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label2.Top = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Height))
                Label1.Left = VB6.TwipsToPixelsY(3 / 5 * VB6.PixelsToTwipsY(Me.Width))
                Label2.Width = Me.Width
                If Me.Height >= TextBox5.Text Or Me.Width >= TextBox4.Text Then
                    If Me.Height <= Image2.Height And Me.Width <= 120 Then
                        Me.Width = Image2.Width
                        Me.Height = TextBox5.Text
                    End If
                    Me.TopMost = False
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                Else
                    If Image2.Width <= 120 And Image2.Height <= 120 Then
                        Me.Width = Image2.Width
                        Me.Height = Image2.Height
                    End If
                    Me.TopMost = True
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(137 / 470 * VB6.PixelsToTwipsY(Me.Width))
                End If
            End If
        Else
        End If
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        If TextBox3.Text = "1" Then
            Timer4.Enabled = True
            TextBox3.Text = "0"
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Me.WindowsMediaPlayer1.Visible = False
        Label1.AutoSize = False
        Label1.Text = ""
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub
    Private Sub ProgressBar1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar1.MouseMove
        Label1.AutoSize = False
        Label1.Text = ""
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub
    Private Sub 调整坐标ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 调整坐标ToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.TextBox6.Text = "1" Then
        Else
            On Error GoTo e
            Dim f As Short
            f = File1.SelectedIndex + 1
            File1.SelectedIndex = f
            Me.Image2.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
            PictureBox1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
            If Me.TextBox2.Text = "True" Then
                Timer4.Interval = 1000
                Me.Height = 317
                Me.Width = 470
                Me.TextBox1.Text = "True"
                Call Round_Corners(Me)
                Call Make_On_Top(Me.Handle.ToInt32, True)
            Else
                Timer4.Interval = 3000
                PictureBox1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
                PictureBox1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
                Me.Height = Image2.Height
                Me.Width = Image2.Width
                Call Round_Corners(Me)
                Call Make_On_Top(Me.Handle.ToInt32, True)
                If Me.Height > TextBox5.Text Then
                    Me.Top = 0
                    Me.Height = TextBox5.Text
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                    Me.StartPosition = FormStartPosition.CenterParent
                Else
                    Dim myy As String
                    myy = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Y", Nothing)
                    Me.Top = myy
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                    Me.StartPosition = FormStartPosition.CenterParent
                End If
                If Me.Width > TextBox4.Text Then
                    Me.Left = 0
                    Me.Width = TextBox4.Text
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                    Me.StartPosition = FormStartPosition.CenterParent
                Else
                    Dim mx As String
                    mx = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "X", Nothing)
                    Me.Left = mx
                    Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
                    Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
                    Me.StartPosition = FormStartPosition.CenterParent
                End If
            End If
        End If
        Exit Sub
e:      File1.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
        Me.NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub WindowsMediaPlayer1_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent)
        Me.WindowsMediaPlayer1.fullScreen = True
    End Sub
    Private Sub 影音全屏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 影音全屏ToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.Width = 470
        Me.Height = 338
        WindowsMediaPlayer1.Height = Me.Height - 30
        WindowsMediaPlayer1.Width = Me.Width
        Me.MaximizeBox = False
        Timer5.Enabled = True
        TextBox6.Text = "1"
        Me.WindowsMediaPlayer1.Visible = False
        On Error GoTo e
        Me.WindowsMediaPlayer1.fullScreen = True
        Exit Sub
e:
        Me.WindowsMediaPlayer1.Visible = True
    End Sub
    Private Sub WindowsMediaPlayer1_ClickEvent1(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles WindowsMediaPlayer1.ClickEvent
        Me.WindowsMediaPlayer1.fullScreen = True
        Me.WindowsMediaPlayer1.Visible = False
    End Sub
    Private Sub 视图转换ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 视图转换ToolStripMenuItem.Click
        Me.WindowsMediaPlayer1.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Timer4.Enabled = True
        Me.MaximizeBox = True
        TextBox6.Text = ""
        Timer5.Enabled = False
        WindowsMediaPlayer1.Height = "36"
        Me.WindowsMediaPlayer1.Width = "199"
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Me.WindowsMediaPlayer1.Visible = True
    End Sub
    Private Sub Label3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        Me.WindowsMediaPlayer1.Visible = True
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Dim f As Short
        f = File1.SelectedIndex + 1
        File1.SelectedIndex = f
        Me.Image2.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
        PictureBox1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
        Me.Height = Image2.Height
        Me.Width = Image2.Width
        Call Round_Corners(Me)
        Call Make_On_Top(Me.Handle.ToInt32, True)
        If Me.Height > TextBox5.Text Then
            Me.Top = 0
            Me.Height = TextBox5.Text
            Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
            Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
            Me.StartPosition = FormStartPosition.CenterParent
        Else
            Dim myy As String
            myy = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Y", Nothing)
            Me.Top = myy
            Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
            Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
            Me.StartPosition = FormStartPosition.CenterParent
        End If
        If Me.Width > TextBox4.Text Then
            Me.Left = 0
            Me.Width = TextBox4.Text
            Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
            Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
            Me.StartPosition = FormStartPosition.CenterParent
        Else
            Dim mx As String
            mx = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "X", Nothing)
            Me.Left = mx
            Me.ProgressBar1.Top = VB6.TwipsToPixelsY(90 / 100 * VB6.PixelsToTwipsY(Me.Height))
            Me.ProgressBar1.Left = VB6.TwipsToPixelsY(40 / 100 * VB6.PixelsToTwipsY(Me.Width))
            Me.StartPosition = FormStartPosition.CenterParent
        End If
        Timer6.Enabled = False
    End Sub
End Class