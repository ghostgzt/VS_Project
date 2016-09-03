Public Class Look
    Private Sub Look_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.ContextMenuStrip = TTS.ContextMenuStrip1
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = TTS.LinkLabel1.Text
            TextBox2.Text = TTS.Label1.Text
        End If
    End Sub
    Private Sub SplitContainer1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.DoubleClick
        Fonts.ShowDialog()
    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Fonts.ShowDialog()
    End Sub
    Private Sub GroupBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.DoubleClick
        Fonts.ShowDialog()
    End Sub
    Private Sub GroupBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.DoubleClick
        Fonts.ShowDialog()
    End Sub
End Class