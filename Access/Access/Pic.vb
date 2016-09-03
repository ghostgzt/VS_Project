Public Class Pic
    Private Sub PictureBox1_Click() Handles PictureBox1.Click
        Me.PictureBox1.Image = Nothing
        Me.Close()
    End Sub
    Private Sub Pic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        PictureBox1_Click()
    End Sub
End Class