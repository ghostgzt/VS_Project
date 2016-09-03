Public Class GN
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)) = str1f Then
                    If n = 0 Then
                        q = u
                        i = i + 1
                    Else
                        If i = n - 1 Then
                            q = u
                            i = i + 1
                            GoTo p
                        End If
                    End If
                End If
            Next
        End If
p:      If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + Len(str1f))
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