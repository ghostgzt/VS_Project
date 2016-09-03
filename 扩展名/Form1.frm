VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form FormFile 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "File Extension Rewriter"
   ClientHeight    =   4350
   ClientLeft      =   2310
   ClientTop       =   870
   ClientWidth     =   7770
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   4350
   ScaleWidth      =   7770
   StartUpPosition =   2  '屏幕中心
   Begin VB.ListBox List1 
      Height          =   2580
      Left            =   4080
      TabIndex        =   12
      Top             =   1200
      Width           =   3495
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   3255
      Left            =   120
      TabIndex        =   10
      Top             =   960
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   5741
      _Version        =   393216
      BorderStyle     =   1
      Appearance      =   1
      MousePointer    =   99
      Orientation     =   1
      Scrolling       =   1
   End
   Begin VB.ComboBox Text2 
      Height          =   300
      Left            =   6000
      TabIndex        =   8
      Text            =   "*"
      Top             =   600
      Width           =   1575
   End
   Begin VB.ComboBox Text1 
      Height          =   300
      Left            =   4080
      TabIndex        =   7
      Text            =   "*.*"
      Top             =   600
      Width           =   1575
   End
   Begin VB.FileListBox File1 
      Height          =   2430
      Left            =   4080
      TabIndex        =   0
      Top             =   1200
      Width           =   3495
   End
   Begin VB.CheckBox Check1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "去除原本扩展名"
      ForeColor       =   &H80000008&
      Height          =   255
      Left            =   4080
      TabIndex        =   6
      Top             =   930
      Width           =   3495
   End
   Begin VB.CommandButton Command1 
      Caption         =   "退出"
      Height          =   375
      Left            =   4080
      TabIndex        =   5
      Top             =   3840
      Width           =   3495
   End
   Begin VB.DirListBox Dir1 
      Height          =   2820
      Left            =   480
      TabIndex        =   4
      Top             =   960
      Width           =   3495
   End
   Begin VB.DriveListBox Drive1 
      Height          =   300
      Left            =   480
      TabIndex        =   3
      Top             =   600
      Width           =   3495
   End
   Begin VB.CommandButton Command2 
      Caption         =   "更改扩展名"
      Height          =   375
      Left            =   480
      TabIndex        =   2
      Top             =   3840
      Width           =   3495
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   480
      TabIndex        =   1
      Top             =   240
      Width           =   7095
   End
   Begin VB.TextBox Text4 
      Height          =   375
      Left            =   1800
      TabIndex        =   13
      Top             =   2040
      Width           =   1215
   End
   Begin VB.TextBox Text5 
      Height          =   495
      Left            =   1320
      TabIndex        =   15
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox Text6 
      Height          =   495
      Left            =   2640
      TabIndex        =   16
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox Text7 
      Height          =   495
      Left            =   3960
      TabIndex        =   17
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox Text8 
      Height          =   495
      Left            =   5400
      TabIndex        =   18
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "路径:"
      Height          =   255
      Left            =   0
      TabIndex        =   14
      Top             =   240
      Width           =   495
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   255
      Left            =   120
      TabIndex        =   11
      Top             =   720
      Width           =   255
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "—>"
      Height          =   255
      Left            =   5640
      TabIndex        =   9
      Top             =   600
      Width           =   375
   End
   Begin VB.Menu t1 
      Caption         =   "菜单"
      Visible         =   0   'False
      Begin VB.Menu t11 
         Caption         =   "刷新"
         Index           =   0
      End
      Begin VB.Menu t11 
         Caption         =   "退出"
         Index           =   1
      End
   End
   Begin VB.Menu t2 
      Caption         =   "t2"
      Visible         =   0   'False
      Begin VB.Menu t12 
         Caption         =   "删除这一条"
         Index           =   0
      End
      Begin VB.Menu t12 
         Caption         =   "刷新"
         Index           =   1
      End
   End
End
Attribute VB_Name = "FormFile"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim we As String
Dim koo As String
Private Sub Command1_Click()
End
End Sub
Function good()
Me.ProgressBar1.Value = "0"
If Check1.Value = Checked Then
Y = Len(Text1.Text)
For x = 1 To List1.ListCount
o = Len(Text2.Text)
k = Mid(Text2.Text, 2, o - 1)
List1.Selected(x - 1) = True
 u = Len(List1.Text)
i = Mid(List1.Text, 1, u - Y + 1)
Name Text3.Text + "\" + List1.Text As Text3.Text + "\" + i + k
start
Next
Else
o = Len(Text2.Text)
k = Mid(Text2.Text, 2, o - 1)
For x = 1 To List1.ListCount
List1.Selected(x - 1) = True
Name Text3.Text + "\" + List1.Text As Text3.Text + "\" + List1.Text + k
start
Next
Label2.Caption = 100
End If
Text1.Text = Text2.Text
Text1.AddItem (Text1.Text)
Text2.AddItem (Text2.Text)
Text2.Text = "*"
MsgBox "Done Seccessed！！！", vbInformation
End Function
Private Sub Command2_Click()
On Error GoTo x
If Text2.Text <> "" And List1.ListCount <> 0 And Text1.Text <> "*.*" And Text1.Text <> "*" Then
If koo = "1" Then
good
Else
If MsgBox("你确定转换？", vbYesNo) = vbYes Then
good
Else
MsgBox "请设置！！", vbInformation
End If
End If
Else
If Text1.Text = "*.*" Or Text1.Text = "*" Then
MsgBox "原本扩展名不能为*.* 或*，请更改！！！", vbExclamation
Else
MsgBox "请输入更改后的扩展名！！" + vbCrLf + "或找不到这类型文件！！", vbInformation
End If
End If
File1.Refresh
Exit Sub
x: MsgBox Err.Description, vbCritical
Me.ProgressBar1.Value = 0
End Sub
Private Sub Dir1_Change()
If Len(Dir1.Path) > 3 Then
Text3.Text = Dir1.Path + "\"
File1.Path = Text3.Text
Else
Text3.Text = Dir1.Path
File1.Path = Text3.Text
End If
Dir1.Refresh
End Sub
Private Sub Dir1_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
If Button = 2 Then
PopupMenu t1, 6
End If
End Sub
Private Sub Drive1_Change()
On Error GoTo x
Dir1.Path = Drive1.Drive
Exit Sub
x: MsgBox Err.Description, vbCritical
Drive1.Drive = "c:\"
End Sub
Private Sub File1_PathChange()
cl
End Sub
Private Sub File1_PatternChange()
cl
End Sub
Private Sub Form_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
If Button = 2 Then
PopupMenu t1, 6
End If
End Sub
Private Sub List1_DblClick()
If List1.Text <> "" Then
we = ""
 Y = Len(List1.Text)
For x = 1 To Y
 u = Mid(List1.Text, x, 1)
If u = "." Then
we = x
End If
Next
If we <> "" Then
Text1.Text = "*" + Mid(List1.Text, we, Y - we + 1)
End If
End If
End Sub
Private Sub List1_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
If Button = 2 Then
If List1.Text = "" Then
t12.Item(0).Visible = False
Else
t12.Item(0).Visible = True
End If
PopupMenu t2, 6
End If
End Sub
Private Sub T11_Click(Index As Integer)
  Select Case Index
    Case 0
    Drive1.Refresh
    Dir1.Refresh
     File1.Refresh
     cl
    Case 1
      End
  End Select
End Sub
Private Sub Form_Load()
On Error GoTo x
Dim p1 As Integer
p1 = 0
Dim p2 As Integer
p2 = 0
Dim p3  As Integer
p3 = 0
Dim p4 As Integer
p4 = 0
If Command <> "" Then
If Command = "/?" Then
ui = MsgBox("File Extension.exe" + vbCrLf + " [/目录路径]" + vbCrLf + " [/原本扩展名，如*.txt]" + vbCrLf + " [/修改后扩展名]" + vbCrLf + " [/是否删除原本扩展名,是True,否False]", vbInformation)
End
End If
l = Len(Command)
For x = 1 To l
u = Mid(Command, x, 1)
If u = "/" Then
If p1 = 0 And p2 = 0 And p3 = 0 Then
p1 = x
Else
If p2 = 0 And p1 <> 0 And p3 = 0 Then
p2 = x
Else
If p3 = 0 And p1 <> 0 And p2 <> 0 Then
p3 = x
Else
If p4 = 0 And p1 <> 0 And p2 <> 0 And p3 <> 0 Then
p4 = x
End If
End If
End If
End If
End If
Next
koo = "1"
w1 = Mid(Command, p1 + 1, p2 - p1 - 2)
w2 = Mid(Command, p2 + 1, p3 - p2 - 2)
w3 = Mid(Command, p3 + 1, p4 - p3 - 2)
w4 = Mid(Command, p4 + 1, l - 2 - p4 + 2)
Text5.Text = w1
Text6.Text = w2
Text7.Text = w3
Text8.Text = w4
Text3.Text = Text5.Text
Text3.Text = Text5.Text
Text1.Text = Text6.Text
Text2.Text = Text7.Text
If Text8.Text = "True" Then
Check1.Value = Checked
Command2_Click
End
End If
If Text8.Text = "False" Then
Check1.Value = Unchecked
Command2_Click
End
End If
End If
Text1.AddItem (Text1.Text)
cl
Exit Sub
x:
MsgBox "你输入参数有错误！！！", vbExclamation
ui = MsgBox("File Extension.exe" + vbCrLf + " [/目录路径]" + vbCrLf + " [/原本扩展名，如*.txt]" + vbCrLf + " [/修改后扩展名]" + vbCrLf + " [/是否删除原本扩展名,是True,否False]", vbInformation)
End Sub
Function cl()
List1.Clear
If File1.ListCount <> 0 Then
For x = 1 To File1.ListCount
File1.Selected(x - 1) = True
List1.AddItem (File1.FileName)
Next
List1.Text = ""
End If
End Function
Private Sub t12_Click(Index As Integer)
Select Case Index
    Case 0
    If Text1.Text = "*.*" Or Text1.Text = "*" Then
    MsgBox "原本扩展名不能为*.*或*，请更改！！！", vbInformation
Else
  del
  End If
    Case 1
   File1.Refresh
     Drive1.Refresh
    Dir1.Refresh
    cl
  End Select
End Sub
Function del()
On Error Resume Next
If List1.Text <> "" Then
Text4.Text = List1.Text
End If
     If List1.ListCount <> 0 Then
   For x = 0 To List1.ListCount - 1
   List1.Selected(x) = True
   If List1.Text = Text4.Text Then
   List1.RemoveItem (x)
    End If
    Next
    End If
End Function
Private Sub Text1_Change()
If Text1.Text = "" Then
Text1.Text = "*.*"
End If
File1.Pattern = Text1.Text
End Sub
Private Sub Text1_Click()
File1.Pattern = Text1.Text
End Sub
Private Sub Text2_Change()
If Text2.Text = "" Then
Text2.Text = "*"
End If
End Sub
Private Sub Text3_Change()
On Error Resume Next
Drive1.Drive = Mid(Text3.Text, 1, 3)
Dir1.Path = Text3.Text
File1.Path = Text3.Text
End Sub
Function start()
u = List1.ListCount
If Me.ProgressBar1.Value < 100 Then
On Error GoTo t
Me.ProgressBar1.Value = Me.ProgressBar1.Value + (100 / u)
Else
t: Me.ProgressBar1.Value = 100
End If
Me.Label2.Caption = Me.ProgressBar1.Value
End Function

