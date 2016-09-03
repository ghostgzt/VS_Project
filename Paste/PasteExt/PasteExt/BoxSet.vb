Imports System.Windows.Forms
Public Class BoxSet
    Dim form1 As System.Windows.Forms.Form
    Dim wname As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text < "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text - 1
            ProgressBar1.Value = TextBox1.Text
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo a
        TextBox1.Text = TextBox1.Text + 1
        ProgressBar1.Value = TextBox1.Text
        Exit Sub
a:      op()
    End Sub
    Function op()
        If TextBox1.Text > "100" Then
            TextBox1.Text = "100"
        End If
    End Function
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        On Error GoTo a
        ProgressBar1.Value = TextBox1.Text
        form1.Opacity = TextBox1.Text / 100
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Paste\" + wname)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "Opacity", TextBox1.Text / 100)
        Exit Sub
a:      op()
        If TextBox1.Text = "" Or TextBox1.Text < "0" Then
            TextBox1.Text = "0"
        End If
    End Sub
    Function write(ByVal ron As Boolean)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Paste\" + wname)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "Topmost", ron)
    End Function
    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim k = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "BoxSet", Nothing)
        Me.ProgressBar2.Value = k
        TextBox2.Text = k
        If wname = "TextPaste" Then
            TextBox2.Enabled = False
            Button3.Enabled = False
            Button3.Enabled = False
            Me.ProgressBar2.Enabled = False
        End If
        TextBox1.Text = form1.Opacity * 100
        If form1.TopMost = True Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If
    End Sub
    Function wf(ByVal wform As System.Windows.Forms.Form, ByVal wnamew As String)
        form1 = wform
        wname = wnamew
    End Function
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox2.Text < "0" Then
            TextBox2.Text = "0"
        Else
            TextBox2.Text = TextBox2.Text - 1
            ProgressBar2.Value = TextBox2.Text
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        On Error GoTo a
        ProgressBar2.Value = TextBox2.Text
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Paste\" + wname)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "BoxSet", TextBox2.Text)
        Exit Sub
a:      ip()
        If TextBox2.Text = "" Or TextBox2.Text < "0" Then
            TextBox2.Text = "0"
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo a
        TextBox2.Text = TextBox2.Text + 1
        ProgressBar2.Value = TextBox2.Text
        Exit Sub
a:      ip()
    End Sub
    Function ip()
        If TextBox2.Text > "100" Then
            TextBox2.Text = "100"
        End If
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        If CheckBox1.Checked = True Then
            form1.TopMost = True
            write(True)
        Else
            form1.TopMost = False
            write(False)
        End If

        Me.Close()
    End Sub
End Class