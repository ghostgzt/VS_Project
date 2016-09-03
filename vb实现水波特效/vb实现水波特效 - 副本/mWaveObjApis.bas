Attribute VB_Name = "mWaveObjApis"
'*************************************************************************
'**模 块 名：mWaveObjApis
'**说    明：WaveObj.dll导出函数声明
'**创 建 人：孤帆
'**描    述：WaveObj.dll由孤帆改写编译自罗云彬：实现水波特效的代码例子
'**版    本：V1.0.0
'*************************************************************************

'1、创建水波对象：>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
'   要对一个窗口进行绘画，首先要创建一个水波对象（本函数申请一些缓冲区）
'      hWnd --> 要绘画水波效果的窗口，渲染后的图片将画到窗口的客户区中
'      hBmp --> 背景图片，绘画的范围大小同背景图片大小
'      dwTime --> 刷新的时间间隔（毫秒），建议值：10～30
'      dwType --> =0 表示圆形水波，=1表示椭圆型水波（用于透视效果）
'      返回值： 0（成功，对象被初始化），1（失败）
Public Enum WaveShape
    sRound   '圆形水波
    sEllipse '椭圆型水波
End Enum
Declare Function WaveInit Lib "WaveObj.dll" Alias "_WaveInit" _
        (ByVal hwnd&, ByVal hBmp&, ByVal dwSpeed&, ByVal dwType As WaveShape) As Long

'2、>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
'◎1. 自动显示特效
' --> 下雨，dwParam1＝密集速度（0最密，越大越稀疏），建议值：0～30
'           dwParam2＝最大雨点直径，建议值：0～5
'           dwParam3＝最大雨点重量，建议值：50～250
' --> 汽艇，dwParam1＝速度（0最慢，越大越快），建议值：0～8
'           dwParam2＝船大小，建议值：0～4
'           dwParam3＝水波扩散的范围，建议值：100～500
' --> 风浪，dwParam1＝密度（越大越密），建议值：50～300
'           dwParam2＝大小，建议值：2～5
'           dwParam3＝能量，建议值：5～10
Public Enum WaveType
    wClose  '关闭特效
    wrain   '下雨
    wlaunch '汽艇
    wWaves  '风浪
End Enum
Declare Sub WaveEffect Lib "WaveObj.dll" Alias "_WaveEffect" _
        (ByVal dwType As WaveType, ByVal dwParam1&, ByVal dwParam2&, ByVal dwParam3&)

'◎2.在指定位置“扔石头”，激起水波
'         dwPosX,dwPosY --> 扔下石头的位置
'         dwStoneSize --> 石头的大小，即初始点的大小，建议值：0～5
'         dwStoneWeight --> 石头的重量，决定了波最后扩散的范围大小，建议值：10～1000
Declare Sub WaveDropStone Lib "WaveObj.dll" Alias "_WaveDropStone" _
        (ByVal dwX&, ByVal dwY&, ByVal dwSize&, ByVal dwWeight&)


'◎ 窗口客户区强制更新
Declare Sub WaveUpdateFrame Lib "WaveObj.dll" Alias "_WaveUpdateFrame" (ByVal bIfForce As Boolean)


'3、 释放水波对象(该dll在卸载时会自动调用该函数)
Declare Sub WaveFree Lib "WaveObj.dll" Alias "_WaveFree" ()
