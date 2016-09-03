Option Strict Off
Option Explicit On
Friend Class Form2
	Inherits System.Windows.Forms.Form
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.CommonDialog1Open.FileName = ""
        Form1.CommonDialog1Open.Filter = "Picture File(*.MP3;*.MID;*.WMA;*.WAV)|*.MP3;*.MID;*.WMA;*.WAV|All File(*.*)|*.*"
        Form1.CommonDialog1Open.ShowDialog()
        If Form1.CommonDialog1Open.FileName <> "" Then
            Form1.Text2.Text = Form1.CommonDialog1Open.FileName
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        VB6.ShowForm(Form4, VB6.FormShowConstants.Modal, Me)
    End Sub
End Class