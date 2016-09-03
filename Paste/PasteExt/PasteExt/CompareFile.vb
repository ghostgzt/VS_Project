Imports System.IO
Public Class CompareFile
    Function CompareFiles(ByVal file1 As String, ByVal file2 As String) As Boolean
        Dim filesAreEqual As Boolean = False
        With My.Computer.FileSystem
            If .GetFileInfo(file1).Length = .GetFileInfo(file2).Length Then
                Using file1Reader As New FileStream(file1, FileMode.Open), _
                      file2Reader As New FileStream(file2, FileMode.Open)
                    Dim byte1 As Integer = file1Reader.ReadByte()
                    Dim byte2 As Integer = file2Reader.ReadByte()
                    While byte1 >= 0 And byte2 >= 0
                        If (byte1 <> byte2) Then
                            filesAreEqual = False
                            Exit While
                        Else
                            filesAreEqual = True
                        End If
                        byte1 = file1Reader.ReadByte()
                        byte2 = file2Reader.ReadByte()
                    End While
                End Using
            End If
        End With
        Return filesAreEqual
    End Function
End Class