Public Class BJ
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.ListView1.SelectedItems(0).SubItems(1).Text = TextBox1.Text
        Main.ListView2.SelectedItems(0).SubItems(1).Text = TextBox1.Text
        If CheckBox1.Checked = True Then
            Main.ListView1.SelectedItems(0).SubItems(2).Text = "是"
            Main.ListView2.SelectedItems(0).SubItems(2).Text = "是"
        Else
            Main.ListView1.SelectedItems(0).SubItems(2).Text = "否"
            Main.ListView2.SelectedItems(0).SubItems(2).Text = "否"
        End If
        Me.Close()
    End Sub
End Class