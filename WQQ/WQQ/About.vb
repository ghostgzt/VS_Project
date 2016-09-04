Public Class About
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer http://weibo.com/u/1843533784", AppWinStyle.MaximizedFocus, False)
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("explorer http://www.godwolfs.asia/", AppWinStyle.MaximizedFocus, False)
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        My.Computer.Clipboard.SetText("1275731466")
        MsgBox("已经复制到剪辑版！@。@！", MsgBoxStyle.Information, "温馨提示！！！")
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Shell("explorer https://www.alipay.com", AppWinStyle.MaximizedFocus, False)
    End Sub
    Dim a As New fluidEffect.fluidEffectControl
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 0
        Timer1.Enabled = True
        'a.AutoSize = True
        'Dim b As Bitmap
        'b = My.Resources.Tulips
        'a.FluidEffectControl(b)
        'a.Size = b.Size
        'a.StopRipples = True
        'Me.Controls.Add(a)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        While Me.Height < 248
            Me.Height = Me.Height + 1
        End While
        If Me.Height = 248 Then
            Me.BackgroundImage = My.Resources.Tulips
            Me.Timer1.Enabled = False
        End If
    End Sub
End Class