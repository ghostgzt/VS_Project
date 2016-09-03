Public Class Web_Explorer
    Function wu(ByVal jj As String)
        Dim u As New Uri(jj)
        WebBrowser1.Url = u
    End Function
End Class