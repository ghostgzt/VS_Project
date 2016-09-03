Option Strict Off
Option Explicit On
Friend Class Form4
	Inherits System.Windows.Forms.Form
	Private Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change
		File1.Pattern = Text1.Text
		File1.Path = Dir1.Path
	End Sub
    Private Sub Drive1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drive1.SelectedIndexChanged
        On Error Resume Next
        Dir1.Path = Drive1.Drive
    End Sub
    Private Sub File1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.DoubleClick
        ChDir(Dir1.Path)
        WindowsMediaPlayer1.URL = File1.Path & "\" & File1.FileName
    End Sub
    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowsMediaPlayer1.URL = ""
        If File1.FileName = "" Then
            MsgBox("�㻹û��ѡ�񣡣�", MsgBoxStyle.Information)
        End If
        Form1.Timer1.Enabled = True
        Form1.Show()
    End Sub
    Private Sub Form4_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        File1.FileName = ""
        Timer1.Enabled = True
        File1.Pattern = Text1.Text
        Me.ToolTip1.IsBalloon = True
    End Sub
    Private Sub Text1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles Text1.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Dim enter_Renamed As Object
        Dim Key As Object
        On Error Resume Next
        If Key = enter_Renamed Then
            File1.Pattern = Text1.Text
        End If
    End Sub
    Private Sub image1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles image1.Click
        ChDir(Dir1.Path)
        If File1.FileName = "" Then
            MsgBox("�㻹û��ѡ�񣡣�", MsgBoxStyle.Information)
        Else
            Form1.Text2.Text = File1.Path & "\" & File1.FileName
            Me.WindowsMediaPlayer1.URL = ""
            Timer1.Enabled = True
            Form1.Timer1.Enabled = True
            Form1.Show()
            Me.Close()
        End If
    End Sub
   Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.WindowsMediaPlayer1.Width = 159
        Me.WindowsMediaPlayer1.Height = 169
        Me.WindowsMediaPlayer1.Visible = True
    End Sub
    Private Sub WindowsMediaPlayer1_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles WindowsMediaPlayer1.ClickEvent
        Me.WindowsMediaPlayer1.fullScreen = True
    End Sub
End Class