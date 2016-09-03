Public NotInheritable Class AboutBox1
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "Everyday Crazy English" + vbCrLf + "Made By GhostGzt(Gentle Guan)" + vbCrLf + "E-Mail:GhostGzt@163.com" + vbCrLf + "QQ:1275731466" + vbCrLf + "Fuck Q！" + vbCrLf + "2011.07.01"
    End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        ss.Pause()
        Me.Close()
    End Sub
    Dim ss As New SpeechLib.SpVoice
    Private Sub TextBoxDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxDescription.Click
        On Error Resume Next
        ss.Resume()
        ss.Speak(TextBoxDescription.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub
End Class