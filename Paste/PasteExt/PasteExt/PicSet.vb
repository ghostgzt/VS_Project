
Public Class PicSet
    Dim jjk As New PasteExt.Pic
    Dim yyk As New PasteExt.MissWindow
    Function readpic(ByVal picimage As System.Windows.Forms.PictureBox, ByVal uiq As System.Windows.Forms.Form)
        yyk.wii()
        Dim x As Integer = yyk.xr
        Dim y As Integer = yyk.yr
        If picimage.Image Is Nothing Then
        Else
            jjk.PictureBox1.Image = picimage.Image
            If jjk.PictureBox1.Height <= y And jjk.PictureBox1.Width <= x Then
                jjk.Height = jjk.PictureBox1.Height
                jjk.Width = jjk.PictureBox1.Width
            End If
            If jjk.PictureBox1.Height <= y And jjk.PictureBox1.Width > x Then
                jjk.Height = jjk.PictureBox1.Height
                jjk.Width = x
                jjk.AutoScroll = True
            End If
            If jjk.PictureBox1.Height > y And jjk.PictureBox1.Width <= x Then
                jjk.Height = y
                jjk.Width = jjk.PictureBox1.Width
                jjk.AutoScroll = True
            End If
            If jjk.PictureBox1.Height > y And jjk.PictureBox1.Width > x Then
                jjk.Width = x
                jjk.AutoScroll = True
            End If
            jjk.Opacity = uiq.Opacity
            jjk.ShowDialog()
            jjk.Refresh()
        End If
    End Function
End Class