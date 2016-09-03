Public Class Choose_Me
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        quit("out")
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        quit(True)
        Me.Close()
    End Sub
    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileListBox1.SelectedIndex = 0
        TextBox1.Text = ""
        Timer1.Enabled = True
    End Sub
    Private Sub FileListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged
        TextBox1.Text = FileListBox1.FileName
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Left < 122 Then
            Label1.Left = Label1.Left + 1
        Else
            quit("t1")
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Left > 12 Then
            Label1.Left = Label1.Left - 1
        Else
            quit("t2")
        End If
    End Sub
    Function quit(ByVal u As String)
        If u = "t1" Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
        If u = "t2" Then
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
        If u = "out" Then
            Timer2.Enabled = False
            Timer1.Enabled = False
        End If
    End Function
End Class