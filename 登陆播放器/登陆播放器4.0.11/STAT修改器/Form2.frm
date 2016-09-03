VERSION 5.00
Begin VB.Form Form2 
   BackColor       =   &H00FFC0C0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "选择模式"
   ClientHeight    =   1770
   ClientLeft      =   6630
   ClientTop       =   5205
   ClientWidth     =   2070
   Icon            =   "Form2.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1770
   ScaleWidth      =   2070
   StartUpPosition =   1  '所有者中心
   Begin VB.Shape Shape2 
      Height          =   375
      Left            =   1320
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   " 边听边    选择"
      Height          =   375
      Left            =   1320
      TabIndex        =   2
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "  手动     选择"
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   1320
      Width           =   735
   End
   Begin VB.Shape Shape1 
      Height          =   375
      Left            =   0
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "   请选择适合的操作模式！！！"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   1815
   End
   Begin VB.Image Image1 
      Height          =   1815
      Left            =   0
      Picture         =   "Form2.frx":0152
      Stretch         =   -1  'True
      Top             =   0
      Width           =   2055
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Label1_Click()
Unload Me
            Form1.CommonDialog1.FileName = ""
             Form1.CommonDialog1.Filter = "Picture File(*.MP3;*.MID;*.WMA;*.WAV)|*.MP3;*.MID;*.WMA;*.WAV"
             Form1.CommonDialog1.ShowOpen
            If Form1.CommonDialog1.FileName <> "" Then
                Form1.Text2.Text = Form1.CommonDialog1.FileName
               End If
           
End Sub


Private Sub Label2_Click()
Unload Me
Form4.Show vbModal, Me

End Sub

