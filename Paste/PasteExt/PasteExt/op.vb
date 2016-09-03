Imports System.Windows.Forms.Form
Public Class op
    Dim w As Integer
    Dim c As String
    Dim form2 As System.Windows.Forms.Form
 Function wr()
        Return w
    End Function
    Function cr()
        Return c
    End Function
    Function all(ByVal oform As System.Windows.Forms.Form, ByVal wname As String)
        form2 = oform
        Dim k = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "Opacity", Nothing)
        If k <> "" Then
            oform.Opacity = k
        End If
        w = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "BoxSet", Nothing)
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "Topmost", Nothing) = "False" Then
            c = "False"
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + wname, "Topmost", Nothing) = "True" Then
            c = "True"
        End If
        wr()
        cr()
    End Function
End Class