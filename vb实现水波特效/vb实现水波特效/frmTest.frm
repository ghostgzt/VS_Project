VERSION 5.00
Begin VB.Form Main 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "About"
   ClientHeight    =   9315
   ClientLeft      =   0
   ClientTop       =   60
   ClientWidth     =   12960
   Icon            =   "frmTest.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   621
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   864
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '��Ļ����
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H00000000&
      ForeColor       =   &H80000008&
      Height          =   6855
      Left            =   0
      Picture         =   "frmTest.frx":268B2
      ScaleHeight     =   455
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   318
      TabIndex        =   0
      Top             =   0
      Width           =   4800
      Begin VB.Image Image7 
         BorderStyle     =   1  'Fixed Single
         Height          =   480
         Left            =   -30
         Picture         =   "frmTest.frx":30B70
         Top             =   6360
         Width           =   4890
      End
   End
   Begin VB.Image Image9 
      Height          =   2175
      Left            =   10800
      Top             =   2520
      Width           =   2175
   End
   Begin VB.Image Image8 
      Height          =   1965
      Left            =   10890
      Picture         =   "frmTest.frx":33A09
      Stretch         =   -1  'True
      Top             =   2610
      Visible         =   0   'False
      Width           =   1950
   End
   Begin VB.Label l 
      Caption         =   """"
      Height          =   255
      Left            =   12120
      TabIndex        =   1
      Top             =   8760
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Image Image6 
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   10800
      MousePointer    =   99  'Custom
      Top             =   4920
      Width           =   2160
   End
   Begin VB.Line Line4 
      BorderColor     =   &H00FFFFFF&
      X1              =   320
      X2              =   868
      Y1              =   620
      Y2              =   620
   End
   Begin VB.Image Image5 
      BorderStyle     =   1  'Fixed Single
      Height          =   855
      Left            =   0
      Picture         =   "frmTest.frx":35084
      Stretch         =   -1  'True
      Top             =   8505
      Width           =   4815
   End
   Begin VB.Line Line3 
      BorderColor     =   &H8000000B&
      X1              =   320
      X2              =   864
      Y1              =   384
      Y2              =   384
   End
   Begin VB.Line Line2 
      BorderColor     =   &H8000000B&
      X1              =   320
      X2              =   864
      Y1              =   168
      Y2              =   168
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000B&
      X1              =   320
      X2              =   320
      Y1              =   384
      Y2              =   620
   End
   Begin VB.Image Image1 
      Height          =   1560
      Left            =   240
      Picture         =   "frmTest.frx":369B4
      Top             =   6960
      Width           =   4410
   End
   Begin VB.Image Image2 
      Height          =   2520
      Left            =   4800
      Picture         =   "frmTest.frx":3AD8B
      Top             =   0
      Width           =   8220
   End
   Begin VB.Image Image4 
      Height          =   3255
      Left            =   4800
      Picture         =   "frmTest.frx":423DB
      Stretch         =   -1  'True
      Top             =   2520
      Width           =   8175
   End
   Begin VB.Image Image3 
      Height          =   3435
      Left            =   4920
      Picture         =   "frmTest.frx":4EC74
      Top             =   5880
      Width           =   7980
   End
End
Attribute VB_Name = "Main"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'*************************************************************************
'**ģ �� ����mWaveObjApis
'**˵    ����WaveObj.dll������������
'**�� �� �ˣ��·�
'**��    ����WaveObj.dll�ɹ·���д���������Ʊ�ʵ��ˮ����Ч�Ĵ�������
'**         ������email:roisegufan@126.com
'**��    ����V1.0.0
'*************************************************************************

Private Sub Form_Activate()
 WaveEffect wClose, 0, 0, 0

 Call Round_Corners(Me)
    Call Make_On_Top(Me.HWND, True)
    Dim ret As Long
    DoEvents
    ret = WaveInit(Picture1.HWND, Picture1.Picture.Handle, 30, sRound)
    If ret = 1 Then Unload Picture1
    If Command <> "" Then
    If Trim(Command) = "0" Then
     WaveEffect wWaves, 250, 4, 8
    Else
       If Trim(Command) = "1" Then
    WaveEffect wlaunch, 5, 4, 250
      Else
        If Trim(Command) = "2" Then
     WaveEffect wrain, 5, 4, 150
        Else
           If Trim(Command) = "3" Then
         WaveEffect wClose, 0, 0, 0
           Else
     WaveEffect wWaves, 250, 4, 8
           End If
   
        End If
    End If
    End If
    
    End If

End Sub



Private Sub Form_Unload(Cancel As Integer)
  WaveEffect wClose, 0, 0, 0
End Sub

Private Sub Image1_Click()
 WaveEffect wClose, 0, 0, 0
End
End Sub

Private Sub Image2_Click()
 WaveEffect wClose, 0, 0, 0
End
End Sub

Private Sub Image3_Click()
 WaveEffect wClose, 0, 0, 0
End
End Sub

Private Sub Image4_Click()
 WaveEffect wClose, 0, 0, 0
End
End Sub

Private Sub Image5_Click()
 WaveEffect wClose, 0, 0, 0
End
End Sub

Private Sub Image6_Click()
On Error Resume Next
r = Shell("wscript " + l + App.Path + "\QQ.WSF" + l, 1)
End Sub



Private Sub Image8_Click()
Image9.Visible = True
Image8.Visible = False
End Sub

Private Sub Image9_Click()
Image8.Visible = True
Image9.Visible = False
End Sub

Private Sub picture1_MouseDown(Button As Integer, Shift As Integer, X As Single, y As Single)
 Dim LClickCount As Long
    '    Randomize
    If Button = 1 Then
        WaveDropStone X, y, 2, 256
    Else
        LClickCount = Rnd * 3
        Select Case LClickCount
          Case 0
            WaveEffect wlaunch, 5, 4, 250
          Case 1
            WaveEffect wWaves, 250, 4, 8
          Case 2
            WaveEffect wrain, 5, 4, 150
          Case 3
            WaveEffect wClose, 0, 0, 0
        End Select
    End If
End Sub

Private Sub picture1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Dim LClickCount As Long
WaveDropStone X, y, 2, 256
End Sub

