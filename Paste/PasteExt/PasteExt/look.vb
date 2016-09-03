Public Class look
    Dim x As Integer
    Dim y As Integer
    Dim w As Integer
    Dim kkk As New PasteExt.MissWindow
    Dim ko As System.Windows.Forms.PictureBox
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Top > y - Me.Height - w Then
            Me.Top = Me.Top - 30
        Else
            Timer1.Enabled = False
        End If
    End Sub
    Function d()
        Timer1.Enabled = False
        kkk.wii()
        x = kkk.xr
        y = kkk.yr
        Me.Left = x - Me.Width
        Me.Top = y
        Timer1.Enabled = True
        Me.PictureBox1.Image = ko.Image
    End Function
    Function ws(ByVal SetNum As Integer)
        w = SetNum
    End Function
    Function kof(ByVal lookpic As System.Windows.Forms.PictureBox, ByVal win As System.Windows.Forms.Form)
        ko = lookpic
        d()
    End Function
    Function enn()
        Me.Hide()
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub
 
    'Function run()
    '    On Error Resume Next
    '    Dim q = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "BigWX", Nothing)
    '    If q <> "" Then
    '        Me.Left = q
    '    End If
    '    Dim w = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "BigWY", Nothing)
    '    If w <> "" Then
    '        Me.Top = w
    '    End If
    '    Dim t = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "SmallWX", Nothing)
    '    If t <> "" Then
    '        PictureBox1.Left = t
    '    End If
    '    Dim r = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "SmallWY", Nothing)
    '    If r <> "" Then
    '        PictureBox1.Top = r
    '    End If
    '    Dim a = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "BigWW", Nothing)
    '    If a <> "" Then
    '        Me.Width = a
    '    End If
    '    Dim s = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "BigWH", Nothing)
    '    If s <> "" Then
    '        Me.Height = s
    '    End If
    '    Dim d = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "SmallWW", Nothing)
    '    If d <> "" Then
    '        PictureBox1.Width = d
    '    End If
    '    Dim f = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "SmallWH", Nothing)
    '    If f <> "" Then
    '        PictureBox1.Height = f
    '    End If
    '    Dim l = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "Backpic", Nothing)
    '    If l <> "" Then
    '        PictureBox2.ImageLocation = l
    '    End If
    '    Dim m = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "Backpicset", Nothing)
    '    If m <> "" Then
    '        If m = 0 Then
    '            PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
    '        End If
    '        If m = 1 Then
    '            PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    '        End If
    '        If m = 2 Then
    '            PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    '        End If
    '    End If
    '    Dim j = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "bigopci", Nothing)
    '    If j <> "" Then
    '        Me.Opacity = j
    '    End If
    '    Dim p = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + "ImagePaste", "pictr", Nothing)
    '    If p <> "" Then
    '        If p = "0" Then
    '            PictureBox1.BackColor = System.Drawing.Color.Transparent
    '        End If
    '    End If
    'End Function

End Class