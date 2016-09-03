Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = MyStart.Left
        Me.Label4.Text = MyStart.Top
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then
        Else
            MyStart.Left = Me.TextBox1.Text
            MyStart.Top = Me.TextBox2.Text
            My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "X", Me.Left)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Y", Me.Top)
            Me.Close()
        End If
    End Sub
    Private Sub Form2_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.TextBox1.Text = Me.Left
        Me.TextBox2.Text = Me.Top
    End Sub
End Class