Public Class PNGC
    Dim tmppath
    Private Sub PNGC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        JS.Show()
    End Sub
    Private Sub PNGC_Load() Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        PictureBox1.Image = Nothing
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        tmppath = Jar.TextBox9.Text
        Dim k = My.Computer.FileSystem.GetFiles(tmppath, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
        For i = 0 To k.Count - 1
            ComboBox1.Items.Add(k(i).Replace(tmppath, ""))
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            JS.MIcon.Text = ComboBox1.Text.Replace("\", "/")
            ty()
            Me.Close()
        End If
    End Sub
    Function ty()
        If JS.M1.Text <> "" Then
            Dim t = 0
            Do
                t = t + 1
            Loop Until Mid(JS.M1.Text, t, 1) = ","
            Do
                t = t + 1
            Loop Until Mid(JS.M1.Text, t, 1) = ","
            JS.M1.Text = (JS.MName.Text + "," + JS.MIcon.Text + "," + JS.M1.Text.Remove(0, t).Trim)
        End If
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.ImageLocation = tmppath + ComboBox1.Text
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class