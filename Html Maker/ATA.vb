Public Class ATA
    Private Sub ATA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim h1 As String
        Dim h2 As String
        Dim b1 As String
        Dim ii As Integer
        Dim iii As Integer
        If CheckBox2.Checked = True Then
            iii = Main.ListView1.SelectedItems.Item(0).Index
        End If
        If CheckBox1.Checked = True Then
            'h1 = "<P>"
            'h2 = "</P>"
            h1 = ""
            h2 = ""
            b1 = "是"
        Else
            h1 = ""
            h2 = ""
            b1 = "否"
        End If
        If CheckBox2.Checked = True Then
            ii = iii
            Main.ListView1.Items.Insert(ii, "其他", 3)
            Main.ListView1.Items.Item(ii).SubItems.Add(h1 + TextBox1.Text + h2)
            Main.ListView1.Items.Item(ii).SubItems.Add(b1)
            Main.ListView2.Items.Insert(ii, "其他", 3)
            Main.ListView2.Items.Item(ii).SubItems.Add(h1 + TextBox1.Text + h2)
            Main.ListView2.Items.Item(ii).SubItems.Add(b1)
        Else
            Main.ListView1.Items.Add("其他", 3)
            Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(h1 + TextBox1.Text + h2)
            Main.ListView1.Items.Item(Main.ListView1.Items.Count - 1).SubItems.Add(b1)
            Main.ListView2.Items.Add("其他", 3)
            Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(h1 + TextBox1.Text + h2)
            Main.ListView2.Items.Item(Main.ListView2.Items.Count - 1).SubItems.Add(b1)
        End If
        Me.Close()
    End Sub
End Class