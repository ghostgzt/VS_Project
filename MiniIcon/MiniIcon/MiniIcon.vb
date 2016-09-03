Public Class MiniIcon
    Function click(ByVal mywin As System.Windows.Forms.Form)
        If mywin.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
            mywin.WindowState = System.Windows.Forms.FormWindowState.Normal
        Else
            mywin.WindowState = System.Windows.Forms.FormWindowState.Minimized
        End If
    End Function
    Function alldo(ByVal notyico As System.Windows.Forms.NotifyIcon, ByVal icon As System.Drawing.Icon, ByVal text As String, ByVal menu As System.Windows.Forms.ContextMenuStrip)
        notyico.Icon = icon
        notyico.Text = text
        notyico.ContextMenuStrip = menu
    End Function
End Class