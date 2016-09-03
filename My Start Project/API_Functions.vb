Option Strict Off
Option Explicit On
Module API_Functions
	Public Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal HWND As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Private Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal RectX1 As Integer, ByVal RectY1 As Integer, ByVal RectX2 As Integer, ByVal RectY2 As Integer, ByVal EllipseWidth As Integer, ByVal EllipseHeight As Integer) As Integer
	Private Declare Function SetWindowRgn Lib "user32" (ByVal HWND As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
	Public Declare Sub ReleaseCapture Lib "user32" ()
	Public Const WM_NCLBUTTONDOWN As Short = &HA1s
	Public Const HTCAPTION As Short = 2
	Private Declare Function SetWindowPos Lib "user32" (ByVal HWND As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
	Private Const HWND_TOPMOST As Short = -1
	Private Const HWND_NOTOPMOST As Short = -2
	Private Const SWP_NOSIZE As Short = &H1s
	Private Const SWP_NOMOVE As Short = &H2s
	Private Const TOPMOST_FLAGS As Boolean = SWP_NOMOVE Or SWP_NOSIZE
	Public Sub Make_On_Top(ByVal HWND As Integer, Optional ByRef OnTop As Boolean = True)
        On Error GoTo Err_Handler
        Dim r As Integer
        If OnTop = True Then
            r = SetWindowPos(HWND, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS)
        Else
            r = SetWindowPos(HWND, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS)
        End If
Exit_Sub:
        Exit Sub
Err_Handler:
        Resume Exit_Sub
    End Sub
	Public Sub Round_Corners(ByRef FRM As System.Windows.Forms.Form)
        Dim mlHeight As Object
        Dim mlWidth As Object
     mlWidth = VB6.PixelsToTwipsX(FRM.ClientRectangle.Width)
        mlHeight = VB6.PixelsToTwipsY(FRM.ClientRectangle.Height)
        SetWindowRgn(FRM.Handle.ToInt32, CreateRoundRectRgn(1, 1, VB6.PixelsToTwipsX(FRM.Width) / VB6.TwipsPerPixelX, VB6.PixelsToTwipsY(FRM.Height) / VB6.TwipsPerPixelY, 15, 15), True)
    End Sub
End Module
