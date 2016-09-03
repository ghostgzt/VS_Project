Attribute VB_Name = "mString"
Option Explicit

Private Declare Function WideCharToMultiByte Lib "kernel32.dll" (ByVal CodePage As Long, ByVal dwFlags As Long, ByVal lpWideCharStr As String, ByVal cchWideChar As Long, ByVal lpMultiByteStr As String, ByVal cchMultiByte As Long, ByVal lpDefaultChar As String, ByVal lpUsedDefaultChar As Long) As Long
Private Declare Function MultiByteToWideChar Lib "kernel32.dll" (ByVal CodePage As Long, ByVal dwFlags As Long, ByVal lpMultiByteStr As String, ByVal cchMultiByte As Long, ByVal lpWideCharStr As String, ByVal cchWideChar As Long) As Long
Private Declare Sub CopyMemory Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef Destination As Any, ByRef Source As Any, ByVal Length As Long)

Public Sub lstrToStringA(ByVal iPtr As Long, ByRef sOut As String, Optional ByVal iLength As Long)
'---------------------------------------------------------------------------------------
' Date      : 9/2/05
' Purpose   : get a vb unicode string from an ansi lstr.
'---------------------------------------------------------------------------------------
    
    Debug.Assert iPtr
    
    If iPtr Then
        If iLength = ZeroL Then iLength = lstrlen(iPtr)
        
        sOut = Space$(MultiByteToWideChar(CP_ACP, MB_PRECOMPOSED, ByVal iPtr, iLength, ByVal ZeroL, ByVal ZeroL))
        MultiByteToWideChar CP_ACP, MB_PRECOMPOSED, ByVal iPtr, iLength, ByVal StrPtr(sOut), ByVal LenB(sOut)
        
    End If
    
End Sub

Public Sub lstrFromStringA(ByVal iPtr As Long, ByVal iPtrLen As Long, ByRef sIn As String)
'---------------------------------------------------------------------------------------
' Date      : 9/2/05
' Purpose   : get an ansi lstr from a vb unicode string.
'---------------------------------------------------------------------------------------

    Dim liLen As Long
    Dim lsAnsi As String
    
    Debug.Assert iPtr
    
    If iPtr Then
        
        lsAnsi = StrConv(sIn, vbFromUnicode)
        liLen = LenB(lsAnsi)
        
        If liLen > iPtrLen - 1 Then liLen = iPtrLen - 1
        
        If liLen > ZeroL Then
            CopyMemory ByVal iPtr, ByVal StrPtr(lsAnsi), liLen
        End If
        MemByte(ByVal UnsignedAdd(iPtr, liLen)) = ZeroY
    End If
End Sub

Public Sub lstrFromStringW(ByVal iPtr As Long, ByVal iPtrLen As Long, ByRef sIn As String)
'---------------------------------------------------------------------------------------
' Date      : 9/2/05
' Purpose   : get a unicode lstr from a vb unicode string.
'---------------------------------------------------------------------------------------
    'lstrFromStringW .pszText, .cchTextMax, Filename
    
    Dim liLen As Long
    
    Debug.Assert iPtr
    
    If iPtr Then
        liLen = 0
        liLen = LenB(Trim$(sIn))
        
        iPtrLen = iPtrLen - TwoL
                
        If liLen > iPtrLen - 2 Then liLen = iPtrLen - 2
        
        If liLen > ZeroL Then
            CopyMemory ByVal iPtr, ByVal StrPtr(sIn), liLen
        End If
        MemWord(ByVal UnsignedAdd(iPtr, liLen)) = 0
        
    End If
End Sub

Public Sub lstrToStringW(ByVal iPtr As Long, ByRef sOut As String)
'---------------------------------------------------------------------------------------
' Date      : 9/2/05
' Purpose   : get a vb string from a unicode lstr.
'---------------------------------------------------------------------------------------
    Dim liLen As Long
    
    Debug.Assert iPtr
    
    If iPtr Then
        liLen = lstrlenW(iPtr)
        sOut = Space$(liLen)
        If liLen Then CopyMemory ByVal StrPtr(sOut), ByVal iPtr, liLen + liLen
    End If
    
End Sub

Public Function lstrToStringAFunc(ByVal lpString As Long) As String
    lstrToStringA lpString, lstrToStringAFunc
End Function

Public Function UnsignedAdd(ByVal iStart As Long, ByVal iInc As Long) As Long
'---------------------------------------------------------------------------------------
' Date      : 1/17/05
' Purpose   : Emulate unsigned addition.
'---------------------------------------------------------------------------------------
    UnsignedAdd = (iStart Xor &H80000000) + iInc Xor &H80000000
End Function

' Returns an ANSI string from a pointer to a Unicode string.
Public Function GetStrFromPtrW(lpszW As Long) As String
    Dim sRtn As String
    sRtn = String$(lstrlenW(ByVal lpszW) * 2, 0)   ' 2 bytes/char
    ' WideCharToMultiByte also returns Unicode string length
    Call WideCharToMultiByte(CP_ACP, 0, ByVal lpszW, -1, ByVal sRtn, Len(sRtn), 0, 0)
    GetStrFromPtrW = GetStrFromBufferA(sRtn)
End Function

' Returns the string before first null char encountered (if any) from an ANSII string.
Public Function GetStrFromBufferA(sz As String) As String
    If InStr(sz, vbNullChar) Then
        GetStrFromBufferA = Left$(sz, InStr(sz, vbNullChar) - 1)
    Else
        ' If sz had no null char, the Left$ function
        ' above would return a zero length string ("").
        GetStrFromBufferA = sz
    End If
End Function

