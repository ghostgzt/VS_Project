Attribute VB_Name = "mdlMain"
Option Explicit
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
Private hHook As Long           '����
Private hFormhWnd As Long       '������
Private cmdButton() As String   '��ť��������
'---------------------------------------------------
'�ֽ�����ת��Ϊ�ַ���
'--------------------API��������--------------------
Private Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (Destination As Any, Source As Any, ByVal Length As Long)
'---------------------------------------------------
'���� ���Ŀ¼ �Ի���
'--------------------API��������--------------------
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
'Private Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (pDest As Any, pSource As Any, ByVal dwLength As Long) 'ǰ���Ѷ���
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
'���� ��&���� �Ի���
'--------------------API��������--------------------
Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (pOpenfilename As OpenFileName) As Long '��
Private Declare Function GetSaveFileName Lib "comdlg32.dll" Alias "GetSaveFileNameA" (pOpenfilename As OpenFileName) As Long '����
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
'�Զ���:
Private Const OFN_MAXSPACE = &H4000 '�������ѡ����ļ�������
'GetFileNames() ������ʹ�õ�ö�ٳ���
Enum ShowOpenSave
    ShowOpenFile = 0        '��
    ShowSaveFile = 1        '����
End Enum
Private Type FileTextOption
    TextAct As Integer
    OldText As String
    NewText As String
End Type
Function GetFileNames(Optional ByVal actType As ShowOpenSave = ShowOpenFile, Optional ByVal digTitle As String, Optional ByVal sFile As String, Optional ByVal sFilter As String, Optional ByVal allowMulti As Boolean, Optional ByVal hWndOwner As Long) As String
'��/�����ļ��Ի��������ѡ)
    Dim ofn As OpenFileName, rtn As Long
    If Trim(sFilter) = "" Then
        sFilter = "�����ļ�(*.*)" & Chr$(0) & "*.*"
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
            .flags = &H1804   'ֻ����ѡ�񵥸��ļ�
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
            GetFileNames = Replace(GetFileNames, Chr(0), "")  'ȥ����ѡ�ָ���
            If Len(Dir(GetFileNames)) > 0 Then
                If MsgBox("�ļ� '" & GetFileNames & "' �Ѵ��ڣ��Ƿ񸲸ǣ�", vbExclamation + vbYesNo + vbDefaultButton2, "�ļ�����") = vbNo Then GetFileNames = ""
            End If
        Else
            If allowMulti Then
                GetFileNames = Replace(GetFileNames, Chr(0), "|")
                GetFileNames = Replace(GetFileNames, "||", "|")
                If Right(GetFileNames, 1) = "|" Then GetFileNames = Left(GetFileNames, Len(GetFileNames) - 1)
                
                Dim i As Integer, d As String
                i = InStr(GetFileNames, "|")
                If i > 0 Then       '����ѡ��
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