Public Class KZTZZ
    Dim JJE As New JEExt.JEE
    Dim d1 = ""
    Private Sub KZTZZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        If Ku.TextBox9.Text <> "" Then
            rzt(Ku.TextBox9.Text)
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        tt(TextBox1, PictureBox1)
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        tt(TextBox2, PictureBox2)
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        tt(TextBox3, PictureBox3)
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        tt(TextBox4, PictureBox4)
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        tt(TextBox5, PictureBox5)
    End Sub
    Function tt(ByVal textt As TextBox, ByVal pp As PictureBox)
        On Error Resume Next
        pp.Image = Nothing
        If textt.Text <> "" Then
            pp.ImageLocation = textt.Text
            If pp.Image Is Nothing Then
                textt.Text = ""
            End If
        End If
    End Function
    Function xx(ByVal ttt As TextBox)
        On Error Resume Next
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.BMP;*.JPG;*.PNG;*.GIF;*.PIC;*.WMF;*.EMF;*.JPEG|*.BMP;*.JPG;*.PNG;*.GIF;*.PIC;*.WMF;*.EMF;*.JPEG|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                ttt.Text = .FileName
            End If
        End With
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        xx(TextBox1)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        xx(TextBox2)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        xx(TextBox3)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        xx(TextBox4)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        xx(TextBox5)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(d1, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Me.Close()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        If TextBox1.Text <> "" Or TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Or TextBox4.Text <> "" Or TextBox5.Text <> "" Then
            With SaveFileDialog1
                .FileName = ""
                .Filter = "*.Jaz主题文件|*.Jaz"
                .ShowDialog()
                If .FileName <> "" Then
                    Dim wj As String = JJE.wjj
                    Kill(wj + "\1.zt")
                    Kill(wj + "\2.zt")
                    Kill(wj + "\3.zt")
                    Kill(wj + "\4.zt")
                    Kill(wj + "\5.zt")
                    FileCopy(TextBox1.Text, wj + "\1.zt")
                    FileCopy(TextBox2.Text, wj + "\2.zt")
                    FileCopy(TextBox3.Text, wj + "\3.zt")
                    FileCopy(TextBox4.Text, wj + "\4.zt")
                    FileCopy(TextBox5.Text, wj + "\5.zt")
                    JJE.obb(wj, .FileName, Label6.Text)
                    MsgBox("Finished！！！", MsgBoxStyle.Information, "温馨提示！")
                    ChDir(My.Application.Info.DirectoryPath)
                    On Error Resume Next
                    My.Computer.FileSystem.DeleteDirectory(d1, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.DeleteDirectory(wj, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    Me.Close()
                End If
            End With
        End If
    End Sub
    Function rzt(ByVal ztt As String)
        On Error Resume Next
        Dim kktt As String
        Dim xxx = JJE.wjj
        ChDir(My.Application.Info.DirectoryPath)
        Kill(xxx + "\*.*")
        JJE.ddd(xxx, ztt, Label6.Text)
        kktt = xxx
        d1 = kktt
        TextBox1.Text = kktt + "\1.zt"
        TextBox2.Text = kktt + "\2.zt"
        TextBox3.Text = kktt + "\3.zt"
        TextBox4.Text = kktt + "\4.zt"
        TextBox5.Text = kktt + "\5.zt"
    End Function
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "库主题文件*.Jaz|*.Jaz"
            .ShowDialog()
            If .FileName <> "" Then
                rzt(.FileName)
            End If
        End With
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
    End Sub
End Class