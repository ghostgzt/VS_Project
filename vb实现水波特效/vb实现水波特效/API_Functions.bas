Attribute VB_Name = "API_Functions"
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal HWND As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Long) As Long

Private Declare Function CreateRoundRectRgn Lib "gdi32" _
    (ByVal RectX1 As Long, ByVal RectY1 As Long, ByVal RectX2 As Long, _
    ByVal RectY2 As Long, ByVal EllipseWidth As Long, _
    ByVal EllipseHeight As Long) As Long
Private Declare Function SetWindowRgn Lib "user32" (ByVal HWND As Long, _
ByVal hRgn As Long, ByVal bRedraw As Long) As Long

Public Declare Sub ReleaseCapture Lib "user32" ()
Public Const WM_NCLBUTTONDOWN = &HA1
Public Const HTCAPTION = 2

Private Declare Function SetWindowPos Lib "user32" (ByVal HWND As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Private Const HWND_TOPMOST = -1
Private Const HWND_NOTOPMOST = -2
Private Const SWP_NOSIZE = &H1
Private Const SWP_NOMOVE = &H2
Private Const TOPMOST_FLAGS = SWP_NOMOVE Or SWP_NOSIZE



Public Sub Make_On_Top(ByVal HWND As Long, Optional OnTop As Boolean = True)
    
On Error GoTo Err_Handler
    
    Dim r As Long
    
    If OnTop = True Then
        r = SetWindowPos(HWND, HWND_TOPMOST, _
            0&, 0&, 0&, 0&, TOPMOST_FLAGS)
    Else
        r = SetWindowPos(HWND, HWND_NOTOPMOST, _
            0&, 0&, 0&, 0&, TOPMOST_FLAGS)
    End If

Exit_Sub:
    Exit Sub

Err_Handler:
    Resume Exit_Sub

End Sub


Public Sub Round_Corners(ByRef FRM As Form)
    FRM.ScaleMode = vbPixels
    mlWidth = FRM.ScaleWidth
    mlHeight = FRM.ScaleHeight
    
    
    SetWindowRgn FRM.HWND, CreateRoundRectRgn(1, 1, _
                (FRM.Width / Screen.TwipsPerPixelX), (FRM.Height / Screen.TwipsPerPixelY), _
                15, 15), _
                True
    FRM.ScaleMode = vbTwips
End Sub

