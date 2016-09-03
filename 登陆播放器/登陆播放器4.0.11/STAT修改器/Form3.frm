VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form3 
   Caption         =   "Form3"
   ClientHeight    =   1140
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4980
   LinkTopic       =   "Form3"
   ScaleHeight     =   1140
   ScaleWidth      =   4980
   StartUpPosition =   3  '窗口缺省
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   3120
      Top             =   600
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      Flags           =   1
   End
   Begin VB.CommandButton Command2 
      Caption         =   "应用"
      Height          =   255
      Left            =   4200
      TabIndex        =   1
      Top             =   360
      Width           =   735
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   480
      TabIndex        =   0
      Top             =   360
      Width           =   3495
   End
   Begin VB.Image Image1 
      Height          =   495
      Left            =   1800
      Picture         =   "Form3.frx":0000
      Stretch         =   -1  'True
      Top             =   600
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "选择你的图片文件夹："
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   1935
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Command2_Click()
 Form1.Text6.Text = Text1.Text
 Unload Me
End Sub

