Public Class Pic2Ico
    Private Sub Button1_Click() Handles Button1.Click
        With LM.OpenFileDialog1
            .FileName = ""
            .Filter = ("图片文件 *.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|*.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|全部文件 *.*|*.*")
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        If TextBox1.Text <> "" Then
            If My.Computer.FileSystem.FileExists(TextBox1.Text) = True Then
                Me.Hide()
                Shell(My.Application.Info.DirectoryPath + "\ICOMaker.exe " + Label1.Text + TextBox1.Text + Label1.Text, AppWinStyle.NormalFocus, True)
                Me.Show()
            Else
                Button1_Click()
            End If
        Else
            Button1_Click()
        End If
    End Sub
    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        Button1_Click()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PictureBox1.ImageLocation = TextBox1.Text
        If TextBox1.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Button1_Click()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        If TextBox1.Text <> "" Then
            Shell("Rundll32.exe url.dll, FileProtocolHandler " + TextBox1.Text.Trim)
        End If
    End Sub
End Class