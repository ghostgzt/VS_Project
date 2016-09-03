Public Class JZF



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tString As String = StrConv(TextBox1.Text, _
    VbStrConv.TraditionalChinese)
        TextBox1.Text = tString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sString As String = StrConv(TextBox1.Text, _
    VbStrConv.SimplifiedChinese)
        TextBox1.Text = sString
    End Sub
End Class
