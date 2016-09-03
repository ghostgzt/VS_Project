Imports System.Windows.Forms
Public Class SX
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        Label1.Text = ""
        Me.Close()
    End Sub
End Class