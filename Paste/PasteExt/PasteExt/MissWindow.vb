Imports System.Windows.Forms
Public Class MissWindow
    Dim x As Integer
    Dim y As Integer
    Dim MissWindow As System.Windows.Forms.Form
    Function wii()
        Dim GetPoint As New System.Windows.Forms.Form
        With GetPoint
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .Opacity = 0
            .Visible = False
            .Show()
            .TabIndex = 0
            .Text = ""
            x = .Width
            y = .Height
            .Close()
        End With
        xr()
        yr()
    End Function
    Function xr()
        Return x
    End Function
    Function yr()
        Return y
    End Function
    Function miss(ByVal Miss1 As System.Windows.Forms.Form, ByVal top As Boolean, ByVal 是否最小还原后在原本位置 As Boolean)
        If top = True Then
            Miss1.TopMost = True
        Else
            Miss1.TopMost = False
        End If
        If 是否最小还原后在原本位置 = True Then
            Timer2.Enabled = True
        Else
            Timer2.Enabled = False
        End If
        wii()
        MissWindow = Miss1
        Timer1.Enabled = True
    End Function
    Function stopmiss()
        Timer1.Enabled = False
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MissWindow.Left <= 0 And MousePosition.X > MissWindow.Width Then
            MissWindow.Left = -MissWindow.Width + 1
        End If
        If MissWindow.Left < 0 And MousePosition.X < 1 Then
            MissWindow.Left = 0
        End If
        If MissWindow.Top <= 0 And MousePosition.Y > MissWindow.Height Then
            MissWindow.Top = -MissWindow.Height + 1
        End If
        If MissWindow.Top < 0 And MousePosition.Y < 1 Then
            MissWindow.Top = 0
        End If
        If MissWindow.Left >= x - MissWindow.Width And MousePosition.X < x - MissWindow.Width Then
            MissWindow.Left = x + MissWindow.Width - 10
        End If
        If MissWindow.Left > x - MissWindow.Width And MousePosition.X > x - 10 Then
            MissWindow.Left = x - MissWindow.Width
        End If
        If MissWindow.Top >= y - MissWindow.Height And MousePosition.Y < y - MissWindow.Height Then
            MissWindow.Top = x + MissWindow.Height - 10
        End If
        If MissWindow.Top > y - MissWindow.Height And MousePosition.Y > y - 10 Then
            MissWindow.Top = y - MissWindow.Height
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If MissWindow.WindowState = FormWindowState.Minimized Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub MissWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = False
    End Sub
End Class