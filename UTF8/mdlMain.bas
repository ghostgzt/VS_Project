Attribute VB_Name = "mdlMain"
Option Explicit
'改变 MsgBox 消息框上按钮的文字
'--------------------API声明部分--------------------
Private Const WH_CBT = 5
Private Const HCBT_ACTIVATE = 5
Private Type RECT
   Left As Long
   Top As Long
   Right As Long
   Bottom As Long
End Type
Private Declare Function MessageBox Lib "user32" Alias "MessageBoxA" (ByVal hWnd As Long, ByVal lpText As String, ByVal lpCaption As String, ByVal wType As Long) As Long
Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Long, ByVal lpfn As Long, ByVal hmod As Long, ByVal dwThreadId As Long) As Long
Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Long) As Long
Private Declare Function MoveWindow Lib "user32" (ByVal hWnd As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal bRepaint As Long) As Long
Private Declare Function GetWindowRect Lib "user32" (ByVal hWnd As Long, lpRect As RECT) As Long
Private Declare Function GetDlgItem Lib "user32" (ByVal hDlg As Long, ByVal nIDDlgItem As Long) As Long
Private Declare Function SetDlgItemText Lib "user32" Alias "SetDlgItemTextA" (ByVal hDlg As Long, ByVal nIDDlgItem As Long, ByVal lpString As String) As Long
Private Declare Function GetDlgItemText Lib "user32" Alias "GetDlgItemTextA" (ByVal hDlg As Long, ByVal nIDDlgItem As Long, ByVal lpString As String, ByVal nMaxCount As Long) As Long
Private Const IDOK = 1
Private Const IDCANCEL = 2
Private Const IDABORT = 3
Private Const IDRETRY = 4
Private Const IDIGNORE = 5
Private Const IDYES = 6
Private Const IDNO = 7
'Private Const IDPROMPT = &HFFFF&
Private hHook As Long           '钩子
Private hFormhWnd As Long       '窗体句柄
Private cmdButton() As String   '按钮文字数组
'---------------------------------------------------
'字节数组转换为字符串
'--------------------API声明部分--------------------
Private Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (Destination As Any, Source As Any, ByVal Length As Long)
'---------------------------------------------------
'调用 浏览目录 对话框
'--------------------API声明部分--------------------
'common to both methods
Private Type BROWSEINFO
    hOwner As Long
    pidlRoot As Long
    pszDisplayName As String
    lpszTitle As String
    ulFlags As Long
    lpfn As Long
    lParam As Long
    iImage As Long
End Type
Private Declare Function SHBrowseForFolder Lib "shell32.dll" Alias "SHBrowseForFolderA" (lpBrowseInfo As BROWSEINFO) As Long
Private Declare Function SHGetPathFromIDList Lib "shell32.dll" Alias "SHGetPathFromIDListA" (ByVal pidl As Long, ByVal pszPath As String) As Long
Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv As Long)
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
'Private Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (pDest As Any, pSource As Any, ByVal dwLength As Long) '前面已定义
Private Const MAX_PATH = 260
Private Const WM_USER = &H400
Private Const BFFM_INITIALIZED = 1
Private Const BFFM_SETSTATUSTEXTA As Long = (WM_USER + 100)
Private Const BFFM_SETSTATUSTEXTW As Long = (WM_USER + 104)
Private Const BFFM_ENABLEOK As Long = (WM_USER + 101)
Private Const BFFM_SETSELECTIONA As Long = (WM_USER + 102)
Private Const BFFM_SETSELECTIONW As Long = (WM_USER + 103)
Private Declare Function SHSimpleIDListFromPath Lib "shell32" Alias "#162" (ByVal szPath As String) As Long
Private Declare Function LocalAlloc Lib "kernel32" (ByVal uFlags As Long, ByVal uBytes As Long) As Long
Private Declare Function LocalFree Lib "kernel32" (ByVal hMem As Long) As Long
Private Declare Function lstrcpyA Lib "kernel32" (lpString1 As Any, lpString2 As Any) As Long
Private Declare Function lstrlenA Lib "kernel32" (lpString As Any) As Long
Private Const LMEM_FIXED = &H0
Private Const LMEM_ZEROINIT = &H40
Private Const lPtr = (LMEM_FIXED Or LMEM_ZEROINIT)
Private Const BIF_RETURNONLYFSDIRS = 1
Private Const BIF_USENEWUI = &H40
'---------------------------------------------------
'调用 打开&保存 对话框
'--------------------API声明部分--------------------
Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (pOpenfilename As OpenFileName) As Long '打开
Private Declare Function GetSaveFileName Lib "comdlg32.dll" Alias "GetSaveFileNameA" (pOpenfilename As OpenFileName) As Long '保存
Private Type OpenFileName
    lStructSize As Long
    hWndOwner As Long
    hInstance As Long
    lpstrFilter As String
    lpstrCustomFilter As String
    nMaxCustFilter As Long
    nFilterIndex As Long
    lpstrFile As String
    nMaxFile As Long
    lpstrFileTitle As String
    nMaxFileTitle As Long
    lpstrInitialDir As String
    lpstrTitle As String
    flags As Long
    nFileOffset As Integer
    nFileExtension As Integer
    lpstrDefExt As String
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type
    
Private Const OFN_EXPLORER = &H80000
Private Const OFN_FILEMUSTEXIST = &H1000
Private Const OFN_HIDEREADONLY = &H4
Private Const OFN_OVERWRITEPROMPT = &H2
Private Const OFN_PATHMUSTEXIST = &H800
Private Const OFN_ALLOWMULTISELECT = &H200
'自定义:
Private Const OFN_MAXSPACE = &H4000 '最多允许选择的文件名长度
'GetFileNames() 函数所使用的枚举常量
Enum ShowOpenSave
    ShowOpenFile = 0        '打开
    ShowSaveFile = 1        '保存
End Enum
Private Type FileTextOption
    TextAct As Integer
    OldText As String
    NewText As String
End Type
'---------------------------------------------------
'UTF8 编码/解码
'--------------------API声明部分--------------------
Private Declare Function WideCharToMultiByte Lib "kernel32" (ByVal CodePage As Long, ByVal dwFlags As Long, ByVal lpWideCharStr As Long, ByVal cchWideChar As Long, ByRef lpMultiByteStr As Any, ByVal cchMultiByte As Long, ByVal lpDefaultChar As String, ByVal lpUsedDefaultChar As Long) As Long
Private Declare Function MultiByteToWideChar Lib "kernel32" (ByVal CodePage As Long, ByVal dwFlags As Long, ByVal lpMultiByteStr As Long, ByVal cchMultiByte As Long, ByVal lpWideCharStr As Long, ByVal cchWideChar As Long) As Long
Private Const CP_UTF8 = 65001
'---------------------------------------------------
'GBK 码繁简转换
'--------------------API声明部分--------------------
Private Declare Function LCMapString Lib "kernel32" Alias "LCMapStringA" (ByVal Locale As Long, ByVal dwMapFlags As Long, ByVal lpSrcStr As String, ByVal cchSrc As Long, ByVal lpDestStr As String, ByVal cchDest As Long) As Long
Private Declare Function lstrlen Lib "kernel32" Alias "lstrlenA" (ByVal lpString As String) As Long
Enum TextCode
    GB2312_Code = 0
    BIG5_Code = 1
    UTF8_Code = 2
End Enum
'---------------------------------------------------
'用于文本替换的公用变量
'---------------------------------------------------
Public FileTextAction(8) As FileTextOption
Public TextActionIdx As Integer '最后操作指针
Private UTF8_Header(2) As Byte  'utf-8文件头
';
'----------------------------------------------------
'--------------程序入口------------------------------
';
Sub Main()

    
    '初始化变量
    UTF8_Header(0) = &HEF: UTF8_Header(1) = &HBB: UTF8_Header(2) = &HBF
    FileTextAction(0).TextAct = -1
    
    frmMain.Show
End Sub

Function Save2File(ByVal sFile As String, Optional ByVal frmCode As TextCode, Optional ByVal toCode As TextCode, Optional ByVal bFile As Boolean, Optional ByVal TextAct As Boolean, Optional ByVal u8BOM As Boolean) As Boolean
'读取指定文件进行处理：utf8解码，替换内容
'然后保存到指定编码格式(utf8/gb/big5)
On Error GoTo aErr
    Dim fText As String
    Dim bFileName As String
    Dim fByte() As Byte
    Dim fh As Integer
    
    '读取文件，返回内容是 gb/gbk 或 big5 编码字串
    fText = InputFileText(sFile, frmCode)
    '为防止 gb 或 utf-8 文件中存在 gbk 编码，做一次 gbk --> gb 转换
    '如果本身已是 gb 编码，这个转换API能自动识别不会出错
    If frmCode <> BIG5_Code Then fText = GBK2GB(fText)
    '如果是big5, 先转换编码到 gb 后处理，如有必要再转回big5
    If frmCode = BIG5_Code Then fText = BIG2GB(fText)
        
    '按规则数组进行替换
    If TextAct Then Text2Action fText
    
    '将处理后的文本编码到目标格式的 byte() 数组
    If toCode = UTF8_Code Then
        '如果来源是 big5 编码，需要编码成 utf-8，保存为 gbk 的 u8编码，使之看起来象繁体字的 utf-8 文件
        '这样做的原因在于，API 函数 WideCharToMultiByte 在简体中文系统中无法编码 big5 为 utf-8
        If frmCode = BIG5_Code Then fText = GB2GBK(fText)
        
        fByte = UTF8_Encode(fText)             '编码成utf8字节数组
    Else
        '需要保存为 big5 编码，执行 gb -> big5 转换;
        If toCode = BIG5_Code Then fText = GB2BIG(fText)
        
        fByte = SaveStringToByteArry(fText)     '转换到字节数组
    End If
    
    '备份源文件
    If bFile Then
        bFileName = sFile & ".bak"
        If Len(Dir(bFileName)) > 0 Then Kill bFileName
        Name sFile As bFileName
    Else
        Kill sFile
    End If
    '写文件
    fh = FreeFile()
    Open sFile For Binary As #fh
    If toCode = UTF8_Code Then
        If u8BOM Then           '保存到utf-8编码，加utf8文件头(BOM)
            Put #fh, , UTF8_Header
        End If
    End If
    Put #fh, , fByte
    
    Save2File = True
    
aErr:
    
    Close #fh
    
End Function
Private Sub Text2Action(ByRef fText As String)
'文本内容替换
    Dim i As Integer
    For i = 0 To 8
        Select Case FileTextAction(i).TextAct
            Case 0
                '替换
                If Len(FileTextAction(i).OldText) > 0 Then
                    fText = Replace(fText, FileTextAction(i).OldText, FileTextAction(i).NewText, , , vbTextCompare)
                End If
            Case 1
                '加头
                If Len(FileTextAction(i).NewText) > 0 Then
                    fText = FileTextAction(i).NewText & fText
                End If
            Case 2
                '加尾
                If Len(FileTextAction(i).NewText) > 0 Then
                    fText = fText & FileTextAction(i).NewText
                End If
        End Select
    Next
End Sub
Private Function GB2BIG(ByVal sStr As String) As String
'Gb2312 编码转换到 Big5 码，需要通过 GBK 编码过渡
    Dim STR As String, STR2 As String
    
    '通过 API 转换成 GBK 码
    STR = GB2GBK(sStr)
    
    '从 GBK 编码转成 Big5
    STR2 = StrConv(STR, vbFromUnicode, &H404)
    GB2BIG = StrConv(STR2, vbUnicode, &H804)
End Function
Private Function BIG2GB(ByVal sStr As String) As String
'Big5 编码转换到 Gb2312 编码，需要通过 GBK 编码过渡
    Dim STR As String, STR2 As String
    
    'Big5 编码转换成 GBK
    STR = StrConv(sStr, vbFromUnicode, &H804)
    STR2 = StrConv(STR, vbUnicode, &H404)
    
    '用 API 将 GBK 转成 GB2312
    BIG2GB = GBK2GB(STR2)
End Function
Private Function GB2GBK(ByVal gbStr As String) As String
'Gb码简体转GBK繁体
    Dim strlen As Long
    strlen = lstrlen(gbStr)
    GB2GBK = Space(strlen)
    LCMapString &H804, &H4000000, gbStr, strlen, GB2GBK, strlen
End Function
Private Function GBK2GB(ByVal bigStr As String) As String
'GBK码繁体转GB简体
    Dim strlen As Long
    strlen = lstrlen(bigStr)
    GBK2GB = Space(strlen)
    LCMapString &H804, &H2000000, bigStr, strlen, GBK2GB, strlen
End Function
Private Function UTF8_Encode(ByVal strUnicode As String) As Byte()
'UTF-8 编码
    Dim TLen As Long
    Dim lngBufferSize As Long
    Dim lngResult As Long
    Dim bytUtf8() As Byte
    
    TLen = Len(strUnicode)
    If TLen = 0 Then Exit Function
    
    lngBufferSize = TLen * 3 + 1
    ReDim bytUtf8(lngBufferSize - 1)
    
    lngResult = WideCharToMultiByte(CP_UTF8, 0, StrPtr(strUnicode), TLen, bytUtf8(0), lngBufferSize, vbNullString, 0)
    
    If lngResult <> 0 Then
        lngResult = lngResult - 1
        ReDim Preserve bytUtf8(lngResult)
    End If
    
    UTF8_Encode = bytUtf8
End Function
Private Function UTF8_Decode(ByRef bUTF8() As Byte) As String
'UTF-8 解码
    Dim lRet As Long
    Dim lLen As Long
    Dim lBufferSize As Long
    Dim sBuffer As String
    Dim bBuffer() As Byte
    
    lLen = UBound(bUTF8) + 1
    
    If lLen = 0 Then Exit Function
    
    lBufferSize = lLen * 2
    
    sBuffer = String$(lBufferSize, Chr(0))
    
    lRet = MultiByteToWideChar(CP_UTF8, 0, VarPtr(bUTF8(0)), lLen, StrPtr(sBuffer), lBufferSize)
    
    If lRet <> 0 Then
        sBuffer = Left(sBuffer, lRet)
    End If
    
    UTF8_Decode = sBuffer
End Function
Private Function UTF8Head(ByRef fByte() As Byte) As Boolean
'是否 utf-8 编码格式
    If UBound(fByte) > 1 Then
        If fByte(0) = UTF8_Header(0) And fByte(1) = UTF8_Header(1) And fByte(2) = UTF8_Header(2) Then
            UTF8Head = True
        End If
    End If
End Function
Private Function InputFileText(ByVal strFileName As String, ByVal fileCode As TextCode) As String
'读取指定文件内容并返回字符串；
'自动判断是否 utf-8 文件，如果是执行 utf-8 解码;否则根据用户选择决定是否解码
'注意：如果对二进制文件操作，返回的内容可能与期许不一致
    Dim hByte() As Byte, arrByte() As Byte
    Dim fh As Integer, lngLen As Long
    Dim uFlag As Boolean
    
    fh = FreeFile()
    Open strFileName For Binary Access Read Shared As #fh
    lngLen = LOF(fh)
    
    If lngLen > 2 Then
        ReDim hByte(2)
        Get #fh, , hByte()          '先读出3个字节，判断是否utf-8文件
        uFlag = UTF8Head(hByte)
    End If
    
    If uFlag Or fileCode = UTF8_Code Then
        If uFlag Then
            ReDim arrByte(lngLen - 4)
            Get #fh, , arrByte()        '如果有u8文件bom，忽略其三个字节的头
        Else
            ReDim arrByte(lngLen - 1)   '如果没有u8编码头但指定为u8，读取全部内容
            Get #fh, 1, arrByte()
        End If
        Close #fh
        
        InputFileText = UTF8_Decode(arrByte)
    Else
        ReDim arrByte(lngLen - 1)   '如果不是u8编码头，读取全部内容
        Get #fh, 1, arrByte()
        Close #fh
        
        InputFileText = CreateStringFromByte(arrByte, lngLen)
    End If
End Function
Private Function CreateStringFromByte(ByRef byteArray() As Byte, ByVal ByteLength As Long) As String
'字节数组中的数据连接成字符串
    Dim StringData As String
    
    '** 分配字符串空间
    StringData = Space(ByteLength)
    '** 复制字符数组地址内容到字符串地址
    MoveMemory ByVal StringData, ByVal VarPtr(byteArray(0)), ByteLength
    
    '** 返回字符串
    CreateStringFromByte = StringData
End Function
Private Function SaveStringToByteArry(ByRef strString As String) As Byte()
'把字符串存入字节数组
    
    Dim BytArray() As Byte, lngStrLen As Long
    
    '** 获取字符串的长度(字节)
    lngStrLen = LenB(StrConv(strString, vbFromUnicode))
    
    '** 分配数组空间
    ReDim BytArray(lngStrLen - 1)
    '** 将字符串地址中的内容拷贝到数组
    MoveMemory ByVal VarPtr(BytArray(0)), ByVal strString, lngStrLen
    
    SaveStringToByteArry = BytArray
End Function
Function SearchFiles(Optional ByVal SearchDirectory As String, Optional ByVal SearchString As String, Optional ByVal SearchSubDir As Boolean) As String()
'获取指定目录中的文件清单
'若返回的数组第0元素为空，表示没找到任何文件
    Dim FilePackage() As String, DirPackage() As String, DirString As String
    Dim SearchPackage As Variant, IsLike As Boolean, s As Long
    Dim i As Long, j As Long, k As Long
   
    ReDim DirPackage(0)
    
    '没有参数，当前目录
    If SearchDirectory = "" Then SearchDirectory = CurDir()
    
    '目录必须以 \ 符闭合
    If Right(SearchDirectory, 1) <> "\" Then SearchDirectory = SearchDirectory & "\"
    
    DirPackage(0) = SearchDirectory
    If SearchString = "" Then SearchString = "*.*"  '没有参数，所有文件
    SearchPackage = Split(SearchString, "|")        ' (|) 为扫描串的分隔符
    Do While i <= j
        DirString = Dir(DirPackage(i), vbHidden Or vbDirectory Or vbReadOnly Or vbSystem)
        Do While DirString <> ""
            If DirString <> "." And DirString <> ".." Then
                If (GetAttr(DirPackage(i) & DirString) And vbDirectory) = vbDirectory And SearchSubDir Then
                    j = j + 1
                    
                    ReDim Preserve DirPackage(j)
                    DirPackage(j) = DirPackage(i) + DirString + "\"
                Else
                    IsLike = False
                    For s = 0 To UBound(SearchPackage)
                        If UCase(DirString) Like UCase(SearchPackage(s)) Then
                            IsLike = True
                            Exit For
                        End If
                    Next
                    If IsLike Then
                        ReDim Preserve FilePackage(k)
                        FilePackage(k) = DirPackage(i) + DirString
                        
                        k = k + 1
                    End If
                End If
            End If
            DirString = Dir
        Loop
        i = i + 1
    Loop
    
    If k = 0 Then   '没有检索到文件
        ReDim Preserve FilePackage(0)
    End If
    SearchFiles = FilePackage()
End Function
'-------------------------------------------
' 目录选择窗(允许指定初始目录)
'-------------------------------------------
Function BrowseForFolder(Optional ByVal sTitle As String, Optional ByVal sSelPath As String, Optional NewFolder As Boolean, Optional ByVal hWndOwner As Long) As String
    Dim BI As BROWSEINFO
    Dim pidl As Long
    Dim lpSelPath As Long
    Dim sPath As String * MAX_PATH
    
    If Len(sSelPath) > 0 Then sSelPath = Replace(sSelPath & "\", "\\", "\")
    
    With BI
        .hOwner = hWndOwner
        .pidlRoot = 0
        .lpszTitle = sTitle
        .lpfn = FARPROC(AddressOf BrowseCallbackProcStr)
        
        lpSelPath = LocalAlloc(lPtr, Len(sSelPath))
        MoveMemory ByVal lpSelPath, ByVal sSelPath, Len(sSelPath)
        
        .lParam = lpSelPath
        .ulFlags = IIf(NewFolder, BIF_USENEWUI, BIF_RETURNONLYFSDIRS)
    End With
    
    pidl = SHBrowseForFolder(BI)
    
    If pidl Then
        If SHGetPathFromIDList(pidl, sPath) Then
            BrowseForFolder = Left$(sPath, InStr(sPath, vbNullChar) - 1)
        End If
        
        Call CoTaskMemFree(pidl)
    End If
    
    Call LocalFree(lpSelPath)
    
    'If cancel was pressed, sPath = ""
    If Len(BrowseForFolder) > 0 Then
        BrowseForFolder = Replace(BrowseForFolder & "\", "\\", "\")
    End If
End Function
Private Function BrowseCallbackProcStr(ByVal hWnd As Long, ByVal uMsg As Long, ByVal lParam As Long, ByVal lpData As Long) As Long
    Select Case uMsg
        Case BFFM_INITIALIZED
    
            Call SendMessage(hWnd, BFFM_SETSELECTIONA, True, ByVal StrFromPtrA(lpData))
            
        Case Else:
    
    End Select
End Function
Private Function FARPROC(ByVal pfn As Long) As Long
    FARPROC = pfn
End Function
Private Function StrFromPtrA(ByVal lpszA As Long) As String
    Dim sRtn As String
    
    sRtn = String$(lstrlenA(ByVal lpszA), 0)
    Call lstrcpyA(ByVal sRtn, ByVal lpszA)
    StrFromPtrA = sRtn
End Function
Function GetFileNames(Optional ByVal actType As ShowOpenSave = ShowOpenFile, Optional ByVal digTitle As String, Optional ByVal sFile As String, Optional ByVal sFilter As String, Optional ByVal allowMulti As Boolean, Optional ByVal hWndOwner As Long) As String
'打开/保存文件对话框（允许多选)
    
    Dim ofn As OpenFileName, rtn As Long
        
    If Trim(sFilter) = "" Then
        sFilter = "所有文件(*.*)" & Chr$(0) & "*.*"
    Else
        sFilter = Replace(sFilter, "|", Chr$(0))
    End If
    
    With ofn
        .lStructSize = Len(ofn)
        .hWndOwner = hWndOwner
        .hInstance = App.hInstance
        .lpstrFilter = sFilter
        .lpstrFile = sFile & Space(OFN_MAXSPACE - 1 - Len(sFile))
        .nMaxFile = OFN_MAXSPACE
        .lpstrFileTitle = Space(254)
        .nMaxFileTitle = OFN_MAXSPACE
        .lpstrInitialDir = App.Path
        .lpstrTitle = digTitle
        If actType = ShowOpenFile Then
            .flags = OFN_EXPLORER Or OFN_FILEMUSTEXIST Or OFN_HIDEREADONLY Or OFN_PATHMUSTEXIST Or IIf(allowMulti, OFN_ALLOWMULTISELECT, &H0)
        Else
            .flags = &H1804   '只允许选择单个文件
        End If
    End With
    
    If actType = ShowOpenFile Then
        rtn = GetOpenFileName(ofn)
    Else
        rtn = GetSaveFileName(ofn)
    End If
    
    If rtn > 0 Then
        GetFileNames = Trim(ofn.lpstrFile)
        If actType = ShowSaveFile Then
            GetFileNames = Replace(GetFileNames, Chr(0), "")  '去掉多选分隔符
            If Len(Dir(GetFileNames)) > 0 Then
                If MsgBox("文件 '" & GetFileNames & "' 已存在，是否覆盖？", vbExclamation + vbYesNo + vbDefaultButton2, "文件存在") = vbNo Then GetFileNames = ""
            End If
        Else
            If allowMulti Then
                GetFileNames = Replace(GetFileNames, Chr(0), "|")
                GetFileNames = Replace(GetFileNames, "||", "|")
                If Right(GetFileNames, 1) = "|" Then GetFileNames = Left(GetFileNames, Len(GetFileNames) - 1)
                
                Dim i As Integer, d As String
                i = InStr(GetFileNames, "|")
                If i > 0 Then       '多重选择
                    d = Replace(Left(GetFileNames, i - 1) & "\", "\\", "\")
                    GetFileNames = Mid(GetFileNames, i)
                    GetFileNames = Replace(GetFileNames, "|", "|" & d)
                    GetFileNames = Mid(GetFileNames, 2)
                End If
            Else
                GetFileNames = Replace(GetFileNames, Chr(0), "")
            End If
        End If
    End If
    
End Function
'---------------------------------------------------------------------------
'函 数 名：MsgBoxA()
'
'功    能: 改变 MsgBox 消息框上按钮的文字
'
'参数说明：
'       sPrompt --- 提示信息
'       sButton --- (可选)按钮字符串，多按钮以 ","(逗号) 分隔
'                   例如 "按钮A,按钮B"，最多3个有效，其余的将被忽略
'       sTitle --- (可选)标题文字
'       dwStyle --- (可选)消息框样式，与标准 MsgBox 完全一致
'               例如 vbYesNoCancel + vbQuestion + vbDefaultButton3
'       hWnd --- (可选)窗体句柄
'               建议传递当前活动窗体句柄，否则 MsgBox 窗口将为非模态
'
'返 回 值：vbMsgBoxResult --- 取决于传递的 dwStyle 参数，
'       如果传递 vbYesNoCancel ，则返回 vbYes/vbNo/vbCancel 其中之一
'----------------------------------------------------------------------------
Function MsgBoxA(ByVal sPrompt As String, Optional ByVal sButton As String, Optional ByVal sTitle As String, Optional ByVal dwStyle As VbMsgBoxStyle = vbOKOnly, Optional ByVal hWndOwner As Long) As VbMsgBoxResult
    
    Dim hInstance As Long
    Dim hThreadId As Long
    
    hInstance = App.hInstance
    hThreadId = App.ThreadID
    If Len(Trim(sTitle)) = 0 Then sTitle = App.EXEName
    
    '分解按钮文字
    If Len(Trim(sButton)) = 0 Then
        ReDim cmdButton(0)
        cmdButton(0) = ""
    Else
        cmdButton = Split(sButton, ",")
    End If
    
    '将当前窗口的句柄付给变量
    hFormhWnd = hWndOwner
    
    '设置钩子
    hHook = SetWindowsHookEx(WH_CBT, AddressOf CBTProc, hInstance, hThreadId)
    
    '调用MessageBox API
    MsgBoxA = MessageBox(hWndOwner, sPrompt, sTitle, dwStyle)
End Function
'-----------------HOOK处理------------------
Private Function CBTProc(ByVal nCode As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
      
    '变量声明
    Dim rc As RECT
    Dim rcFrm As RECT
    Dim hwndMsgBox As Long
    
    If nCode = HCBT_ACTIVATE Then
        '消息为HCBT_ACTIVATE时，参数wParam包含的是MessageBox的句柄
        hwndMsgBox = wParam
        
        '得到MessageBox对话框的Rect
        Call GetWindowRect(hwndMsgBox, rc)
        Call GetWindowRect(hFormhWnd, rcFrm)
        
        '修改按钮上的文字
        If Len(Trim(cmdButton(0))) > 0 Then
            Call SetDlgItemText(hwndMsgBox, IDYES, cmdButton(0))
            Call SetDlgItemText(hwndMsgBox, IDOK, cmdButton(0))
            Call SetDlgItemText(hwndMsgBox, IDABORT, cmdButton(0))
            Call SetDlgItemText(hwndMsgBox, IDRETRY, cmdButton(0))
        End If
        
        If UBound(cmdButton) > 0 Then
            If Len(Trim(cmdButton(1))) > 0 Then
                Call SetDlgItemText(hwndMsgBox, IDNO, cmdButton(1))
                Call SetDlgItemText(hwndMsgBox, IDRETRY, cmdButton(1))
                Call SetDlgItemText(hwndMsgBox, IDCANCEL, cmdButton(1))
            End If
        End If
        
        If UBound(cmdButton) > 1 Then
            If Len(Trim(cmdButton(2))) > 0 Then
                Call SetDlgItemText(hwndMsgBox, IDCANCEL, cmdButton(2))
                Call SetDlgItemText(hwndMsgBox, IDIGNORE, cmdButton(2))
            End If
        End If
          
        '卸载钩子
        UnhookWindowsHookEx hHook
    End If
    CBTProc = False
End Function
