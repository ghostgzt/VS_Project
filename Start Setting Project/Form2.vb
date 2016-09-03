Option Strict Off
Option Explicit On
Friend Class Form2
	Inherits System.Windows.Forms.Form
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        If Form1.TextBox5.Text = "1" Or Form1.TextBox5.Text = "" Then
            Form1.CommonDialog1Open.FileName = ""
            Form1.CommonDialog1Open.Filter = "Picture File(*.MP3;*.MID;*.WMA;*.WAV)|*.MP3;*.MID;*.WMA;*.WAV|All File(*.*)|*.*"
            Form1.CommonDialog1Open.ShowDialog()
            If Form1.CommonDialog1Open.FileName <> "" Then
                Form1.Text2.Text = Form1.CommonDialog1Open.FileName
            End If
        End If
        If Form1.TextBox5.Text = "2" Then
            Form1.CommonDialog1Open.FileName = ""
            Form1.CommonDialog1Open.Filter = "Video File(*.wmv;*.avi;*.rm;*.rmvb)|*.wmv;*.avi;*.rm;*.rmvb|All File(*.*)|*.*"
            Form1.CommonDialog1Open.ShowDialog()
            If Form1.CommonDialog1Open.FileName <> "" Then
                Form1.Text2.Text = Form1.CommonDialog1Open.FileName
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Timer1.Enabled = False
        If Form1.TextBox5.Text = "1" Or Form1.TextBox5.Text = "" Then
            Form4.Text1.Text = "*.mp3;*.mid;*.wav;*.wma "
        End If
        If Form1.TextBox5.Text = "2" Then
            Form4.Text1.Text = "*.wmv;*.avi;*.rm;*.rmvb"
        End If
        Me.Hide()
        VB6.ShowForm(Form4, VB6.FormShowConstants.Modal, Me)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form1.CommonDialog1Open.FileName = ""
        Form1.CommonDialog1Open.Filter = "WPL File(*.wpl)|*.wpl"
        Form1.CommonDialog1Open.ShowDialog()
        If Form1.CommonDialog1Open.FileName <> "" Then
            Form1.Text2.Text = Form1.CommonDialog1Open.FileName
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim st
        st = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\AIFFFile\shell\play\command", "", Nothing)
        Shell(st, AppWinStyle.NormalFocus)
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
End Class