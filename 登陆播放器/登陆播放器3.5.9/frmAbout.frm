VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "�����ҵ�Ӧ�ó���"
   ClientHeight    =   2085
   ClientLeft      =   1680
   ClientTop       =   1665
   ClientWidth     =   2985
   ClipControls    =   0   'False
   Icon            =   "frmAbout.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1439.104
   ScaleMode       =   0  'User
   ScaleWidth      =   2803.069
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   500
      Left            =   0
      Top             =   600
   End
   Begin VB.CommandButton Command1 
      Caption         =   "�˳�"
      Height          =   855
      Left            =   2040
      Picture         =   "frmAbout.frx":27A2
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   1200
      Width           =   735
   End
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "ȷ��"
      Default         =   -1  'True
      Height          =   345
      Left            =   0
      TabIndex        =   0
      Top             =   1320
      Width           =   1500
   End
   Begin VB.CommandButton cmdSysInfo 
      Caption         =   "stat�޸ĳ���"
      Height          =   345
      Left            =   0
      TabIndex        =   1
      Top             =   1680
      Width           =   1485
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   0
      Picture         =   "frmAbout.frx":42E6
      Stretch         =   -1  'True
      Top             =   240
      Width           =   495
   End
   Begin VB.Label Label1 
      BackColor       =   &H00008080&
      Caption         =   "   ���ߣ�������"
      BeginProperty Font 
         Name            =   "����"
         Size            =   12
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   840
      Width           =   2535
   End
   Begin VB.Label lblVersion 
      BackStyle       =   0  'Transparent
      Caption         =   "       �汾"
      Height          =   255
      Left            =   600
      TabIndex        =   3
      Top             =   480
      Width           =   2175
   End
   Begin VB.Label lblTitle 
      BackStyle       =   0  'Transparent
      Caption         =   "Ӧ�ó������"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   600
      TabIndex        =   2
      Top             =   240
      Width           =   2205
   End
   Begin VB.Image Image1 
      Height          =   2055
      Left            =   0
      Picture         =   "frmAbout.frx":45F0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   3015
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cmdOK_Click()
  Unload frmAbout
End Sub

Private Sub cmdSysInfo_Click()
Dim retval
retval = Shell(App.Path + "\STAT�޸���.exe", 1)
End Sub

Private Sub Command1_Click()
End
End Sub

Private Sub Form_Load()
    
        Timer1.Enabled = True                  '������ʼ���ʱ������
                
  
    Me.Caption = "���� " & App.Title
    lblVersion.Caption = "�汾 " & App.Major & "." & App.Minor & "." & App.Revision
    lblTitle.Caption = App.Title
    End Sub

Private Sub Timer1_Timer()
    Dim r As Byte, G As Byte, B As Byte
    Randomize
    r = Int(Rnd * 255) + 1                     '�������RGB��ɫֵ
    G = Int(Rnd * 255) + 1
    B = Int(Rnd * 255) + 1
    Label1.ForeColor = RGB(r, G, B)
End Sub
