Imports System.Runtime.InteropServices
Public Class Mini
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim tf As String = ""
    Dim mouseOffset
    Dim op
    Const CtrlMask As Byte = 8
    Private Sub Mini_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Cancel = 1
        eventArgs.Cancel = Cancel
        Jar.del()
        Jar.退出ToolStripMenuItem_Click()
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean)
        Dim q = ""
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, 1) = str1f Then
                    q = u
                End If
            Next
        End If
        If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + 1)
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
    Private Sub Mini_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
        If Command() <> "" Then
            If My.Application.CommandLineArgs.Item(0).ToLower = "/setbox" Then
                Jar.NotifyIcon1.Icon = Nothing
                Me.Hide()
                SetBox.ShowDialog()
                End
            End If
            If My.Application.CommandLineArgs.Item(0).ToLower = "/about" Then
                Jar.NotifyIcon1.Icon = Nothing
                Me.Hide()
                AboutMe.ShowDialog()
                End
            End If
            If My.Application.CommandLineArgs.Item(0) = "/?" Then
                MsgBox("[/Setbox]设置" + vbCrLf + "[/About]关于" + vbCrLf + "[/Mini]+[Path]最简模式" + vbCrLf + "[Path]载入文件")
                End
            End If
        End If
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Runned", Nothing)
        If r0 <> "000" Then
            MsgBox("感谢你的使用！！！" + vbCrLf + AboutMe.TextBox2.Text, MsgBoxStyle.Information, "第一次运行！")
            AboutMe.ShowDialog()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Runned", "000")
            SetBox.ShowDialog()
        End If
        Dim r7 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Mini", Nothing)
        If r7 <> "1" Then
            Me.Height = 32
            Me.Width = 32
            Me.TransparencyKey = Me.BackColor
            Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MX", Nothing)
            Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MY", Nothing)
            Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MP", Nothing)
            Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MH", Nothing)
            Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MW", Nothing)
            Dim r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Opacity", Nothing)
            If r1 <> Nothing Then
                Me.Left = Int(r1)
            End If
            If r2 <> Nothing Then
                Me.Top = Int(r2)
            End If
            If r4 <> Nothing Then
                Me.Height = Int(r4)
            End If
            If r5 <> Nothing Then
                Me.Width = Int(r5)
            End If
            If r6 <> Nothing Then
                Me.Opacity = Int(r6) / 100
            End If
            Me.ContextMenuStrip = Jar.ContextMenuStrip1
            Try
                If r3 <> "" Then
                    PictureBox1.WaitOnLoad = True
                    PictureBox1.ImageLocation = r3
                Else
                    PictureBox1.Image = Jar.Icon.ToBitmap
                End If
            Catch
                GoTo p
            End Try
        Else
            Me.TopMost = False
            Me.Hide()
            Me.Visible = False
            Me.Height = 0
            Me.Width = 0
        End If
        If My.Application.CommandLineArgs.Count = 2 Then
            Dim pro = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", Nothing)
            If My.Application.CommandLineArgs.Item(0).ToLower = "/mini" And My.Application.CommandLineArgs.Item(1).Trim <> "" Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", False)
                Me.ContextMenuStrip = Nothing
                Jar.MinimizeBox = False
                Jar.Height = 92
                Jar.ContextMenuStrip1.Enabled = False
            End If
            Jar.Show()
            If My.Application.CommandLineArgs.Item(0).ToLower = "/mini" And My.Application.CommandLineArgs.Item(1).Trim <> "" Then
                Jar.Enabled = False
                Jar.readjar(My.Application.CommandLineArgs.Item(1))
                Jar.Enabled = True
                Jar.ContextMenuStrip = Nothing
                Jar.XB(True)
                Jar.NotifyIcon1.Icon = Nothing
                Jar.Height = 92
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", pro)
            End If
        Else
            Jar.Show()
        End If
        Exit Sub
p:      SetBox.ShowDialog()
    End Sub
    Private Sub PictureBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        Jar.主窗口ToolStripMenuItem_Click()
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        ToolTip1.SetToolTip(PictureBox1, Jar.Text)
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MX", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "MY", Me.Top)
    End Sub
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            tf = ""
            DragQueryFile(m.WParam.ToInt32, 0, sb, 256)
            sFirstFileName = sb.ToString
            tf = (sb.ToString)
            If getname(tf, ".", False).ToString.ToUpper = "JAR" Then
                Jar.ContextMenuStrip1.Enabled = False
                Dim yy = MsgBox("确定打开" + tf + "？", MsgBoxStyle.YesNo, "温馨提示！！！")
                If yy = MsgBoxResult.Yes Then
                    Jar.readjar(tf)
                End If
                Jar.ContextMenuStrip1.Enabled = True
                Jar.打开ToolStripMenuItem.Checked = False
            End If
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
End Class