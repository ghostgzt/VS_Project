Public Class GN
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean)
        Dim q = ""
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, 1) = str1f Then
                    q = u
                End If
            Next
        End If
        If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + 1)
            Else
                Return str.Remove(q)
            End If
        Else
            If qh = True Then
                Return str
            Else
                Return ""
            End If
        End If
    End Function
End Class