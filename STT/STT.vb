Public Class STT
    Dim ss As New SpeechLib.SpVoice
    Dim sd As New SpeechLib.SpAudioFormat
    Private Sub STT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sd.Type = SpeechLib.SpeechAudioFormatType.SAFTCCITT_ALaw_44kHzStereo
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ss.Speak(TextBox1.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub
End Class
