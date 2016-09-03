Public Class STC
    Function JCF(ByVal JT As String)
        Dim tString As String = StrConv(JT, VbStrConv.TraditionalChinese)
        Return tString
    End Function
    Function FCJ(ByVal FT As String)
        Dim sString As String = StrConv(FT, VbStrConv.SimplifiedChinese)
        Return sString
    End Function
End Class
