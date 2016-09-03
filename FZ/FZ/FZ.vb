Public Class FZ
    Dim te As System.Text.Encoding
    Dim tt As New TLQ.X
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Txt File *.txt|*.txt|All File *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        ListBox1.Items.Remove(OpenFileDialog1.FileNames(x).Trim)
                        ListBox1.Items.Add(OpenFileDialog1.FileNames(x).Trim)
                    Next
                End If
            End If
        End With
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Default" Then
            te = System.Text.Encoding.Default
        End If
        If ComboBox1.Text = "ASCII" Then
            te = System.Text.Encoding.ASCII
        End If
        If ComboBox1.Text = "Unicode" Then
            te = System.Text.Encoding.Unicode
        End If
        If ComboBox1.Text = "UTF8" Then
            te = System.Text.Encoding.UTF8
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Default"
        tt.Run(ListBox1, "*.txt")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim ll As New ListBox
        ll.Items.Clear()
        If ListBox1.Items.Count <> 0 Then
            ListBox2.Items.Clear()
            ListBox1.Enabled = False
            For f = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(f, True)
                Dim ky = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te) + vbCrLf
                While ky.Remove(2) = vbCrLf
                    ky = ky.Remove(0, 2)
                End While
                For o = 1 To Len(ky)
                    If Mid(ky, o, 2) = vbCrLf Then
                        ListBox2.Items.Add(o)
                    End If
                Next
                ListBox2.SetSelected(0, True)
                Dim by = ky.Remove(ListBox2.Text).Replace("䉈", "").Replace("。", "").Replace("，", "").Replace("?", " ").Replace(":", "").Replace("<", "").Replace(">", "").Trim
                If ListBox3.Items.Count <> 0 Then
                    For x = 0 To ListBox3.Items.Count - 1
                        by = by.Replace(ListBox3.Items(x), "")
                    Next
                End If
                If TextBox3.Text <> "" Then
                    If TextBox3.Text <> "0" And by.Length > CInt(TextBox3.Text) Then
                        by = by.Remove(TextBox3.Text)
                    End If
                End If
                If by <> "" Then
                    On Error GoTo k
                    My.Computer.FileSystem.RenameFile(ListBox1.Text, by + ".txt")
                    ll.Items.Add(ListBox1.Text)
                End If
                ListBox2.Items.Clear()
k:          Next
            If ll.Items.Count <> 0 Then
                For r = 0 To ll.Items.Count - 1
                    ListBox1.Items.Remove(ll.Items(r))
                Next
            End If
            ListBox1.Enabled = True
        End If
        ll.Items.Clear()
        TextBox1.Text = ""
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ""
        If ListBox1.Text <> "" Then
            ListBox2.Items.Clear()
            Dim ky = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te) + vbCrLf
            While ky.Remove(2) = vbCrLf
                ky = ky.Remove(0, 2)
            End While
            For o = 1 To Len(ky)
                If Mid(ky, o, 2) = vbCrLf Then
                    ListBox2.Items.Add(o)
                End If
            Next
            ListBox2.SetSelected(0, True)
            Dim by = ky.Remove(ListBox2.Text).Replace("䉈", "").Replace("。", "").Replace("，", "").Replace("?", " ").Replace(":", "").Replace("<", "").Replace(">", "").Trim
            If ListBox3.Items.Count <> 0 Then
                For x = 0 To ListBox3.Items.Count - 1
                    by = by.Replace(ListBox3.Items(x), "")
                Next
            End If
            If TextBox3.Text <> "" Then
                If TextBox3.Text <> "0" And by.Length > CInt(TextBox3.Text) Then
                    by = by.Remove(TextBox3.Text)
                End If
            End If
            TextBox1.Text = by
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox3.Items.Remove(TextBox2.Text)
        ListBox3.Items.Add(TextBox2.Text)
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        On Error GoTo i
        Dim kb As Integer = CInt(TextBox3.Text)
        Exit Sub
i:      TextBox3.Text = "0"
    End Sub
    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedItems.Count <> 0 Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        For a = 0 To ListBox3.SelectedItems.Count - 1
            ListBox3.Items.Remove(ListBox3.SelectedItems(0))
        Next
    End Sub
End Class