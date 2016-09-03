VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form2 
   BorderStyle     =   0  'None
   ClientHeight    =   3960
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3120
   ClipControls    =   0   'False
   BeginProperty Font 
      Name            =   "华文彩云"
      Size            =   12
      Charset         =   134
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3960
   ScaleWidth      =   3120
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   2280
      Top             =   3480
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   2640
      Top             =   3480
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   120
      Top             =   960
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   35
      ImageHeight     =   64
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   3
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form2.frx":0000
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form2.frx":0637
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form2.frx":0C3B
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.FileListBox File1 
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   0
      TabIndex        =   4
      Top             =   0
      Visible         =   0   'False
      Width           =   3120
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&OK"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   3480
      Width           =   2895
   End
   Begin VB.DriveListBox Drive1 
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   120
      TabIndex        =   0
      ToolTipText     =   "改变驱动器"
      Top             =   120
      Width           =   2895
   End
   Begin VB.DirListBox Dir1 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2610
      Left            =   120
      TabIndex        =   1
      ToolTipText     =   "双击选择目录"
      Top             =   480
      Width           =   2895
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   120
      TabIndex        =   2
      Top             =   3120
      Width           =   2535
   End
   Begin VB.Line Line11 
      X1              =   3000
      X2              =   3000
      Y1              =   120
      Y2              =   3840
   End
   Begin VB.Line Line10 
      X1              =   120
      X2              =   3000
      Y1              =   3840
      Y2              =   3840
   End
   Begin VB.Line Line9 
      X1              =   120
      X2              =   120
      Y1              =   120
      Y2              =   3840
   End
   Begin VB.Line Line8 
      X1              =   3000
      X2              =   3120
      Y1              =   3840
      Y2              =   3960
   End
   Begin VB.Line Line7 
      X1              =   3120
      X2              =   3000
      Y1              =   0
      Y2              =   120
   End
   Begin VB.Line Line6 
      X1              =   0
      X2              =   120
      Y1              =   3960
      Y2              =   3840
   End
   Begin VB.Line Line5 
      X1              =   0
      X2              =   120
      Y1              =   0
      Y2              =   120
   End
   Begin VB.Line Line4 
      X1              =   0
      X2              =   3120
      Y1              =   3960
      Y2              =   3960
   End
   Begin VB.Line Line3 
      X1              =   3120
      X2              =   3120
      Y1              =   0
      Y2              =   3960
   End
   Begin VB.Line Line2 
      X1              =   0
      X2              =   3120
      Y1              =   0
      Y2              =   0
   End
   Begin VB.Line Line1 
      X1              =   0
      X2              =   0
      Y1              =   0
      Y2              =   3960
   End
   Begin VB.Image Image1 
      Height          =   375
      Left            =   2640
      Stretch         =   -1  'True
      ToolTipText     =   "卸下原有镜像"
      Top             =   3120
      Width           =   375
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
If Text1.Text = "" Then
MsgBox "Please fill the Dir Path", vbInformation, "Information"
Else
On Error GoTo e
File1.ListIndex = "0"
MsgBox "It isn't a empty folder.So you cannot choose it！！！", vbInformation, "Choose Path"
Text1.Text = ""
Exit Sub
e:
If File1.FileName = "" Then
End If
If Text1.Text = "" Then
MsgBox "Please fill the Dir Path", vbInformation, "Information"
Else
Me.Hide
End If
Form3.Text2.Text = Text1.Text
Form3.Text2.Visible = True
End If
End Sub
Private Sub Dir1_Change()
Text1.Text = Dir1.Path
Me.File1.Path = Text1.Text
End Sub
Private Sub Dir1_Click()
Text1.Text = Dir1.Path
Me.File1.Path = Text1.Text
End Sub
Private Sub Drive1_Change()
On Error Resume Next
Dir1.Path = Drive1.Drive
End Sub
Private Sub Form_Load()
Image1.Picture = ImageList1.ListImages(1).ExtractIcon
Call Round_Corners(Form2)
End Sub
Private Sub Image1_Click()
If Text1.Text = "" Then
MsgBox "Please fill the dir！OK?", vbInformation, "信息"
Else
If MsgBox("只读是否！！！", vbYesNo, "信息") = vbYes Then
Shell (App.Path + "\imagex.exe /unmount " + Form3.Text3.Text + Text1.Text + Form3.Text3.Text), vbNormalNoFocus
Else
Shell (App.Path + "\imagex.exe /unmount /commit " + Form3.Text3.Text + Text1.Text + Form3.Text3.Text), vbNormalNoFocus
End If
End If
Dir1.Refresh
File1.Refresh
Timer1.Enabled = True
End Sub
Private Sub Image1_MouseDown(Button As Integer, Shift As Integer, X As Single, y As Single)
Image1.Picture = ImageList1.ListImages(3).ExtractIcon
End Sub
Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image1.Picture = ImageList1.ListImages(2).ExtractIcon
End Sub
Private Sub Timer1_Timer()
Dir1.Refresh
File1.Refresh
Dir1.Visible = False
Timer2.Enabled = True
Timer1.Enabled = False
End Sub
Private Sub Timer2_Timer()
Dir1.Refresh
File1.Refresh
Dir1.Visible = True
Timer2.Enabled = False
End Sub
